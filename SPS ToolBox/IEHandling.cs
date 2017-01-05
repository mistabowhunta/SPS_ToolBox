using SHDocVw;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SPS_ToolBox
{
    class IEHandling 
    {
        public string UrlContains { get; set; }
        public string ButtonText { get; set; }
        public string URL { get; set; }

        //Constructor accepting strings from Form 1
        public IEHandling(string urlcontains, string buttonText, string url)
        {
            UrlContains = urlcontains;
            ButtonText = buttonText;
            URL = url;

            //Opening a new instance of all the windows currently open
            ShellWindows shellWindows = new ShellWindows();
            string filename;

            //If there are no shellWindows open, start a new instance of IE (else statement at bottom of method)
            if (shellWindows.Count > 0)
            {
                //intShellWindowsTracker tracks which iteration of shell windows the code is at. If by the last iteration has not found the webpage, then opens a new instance.
                int intShellWindowsTracker = 0;
                foreach (InternetExplorer ie in shellWindows)
                {
                    filename = Path.GetFileNameWithoutExtension(ie.FullName).ToLower();
                    intShellWindowsTracker++;
                    if (filename.Equals("iexplore"))
                    {
                        string website = ie.LocationURL.ToString().ToLower();

                        //Enter website that needs to close if it is already open
                        if (website.Contains(UrlContains.ToLower())) //URL is converted to all lowercase
                        {
                            //Giving the user a choice if they want to close the existing IE instance
                            DialogResult dialogResult = MessageBox.Show(ButtonText + " is already open. Close it?", "Close " + ButtonText + "?",
                                MessageBoxButtons.YesNo);
                            if (dialogResult == DialogResult.Yes)
                            {
                                ie.Quit();

                                //Enter new instance of website that just closed
                                Process.Start("IExplore.exe", URL);

                                //Breaking out of loop because if the user has more webpages open that match UrlContains. Only need to ask once.
                                break;
                            }
                            else if (dialogResult == DialogResult.No)
                            {
                                Process.Start("IExplore.exe", URL);

                                //Breaking out of loop because if the user has more webpages open that match UrlContains. Only need to ask once.
                                break;
                            }
                        }
                        else if (!website.Contains(UrlContains.ToLower()) && (shellWindows.Count == intShellWindowsTracker))
                        {
                            Process.Start("IExplore.exe", URL);
                        }
                    }
                }
            }

            // There are no shellwindows open so create a new instance of IE
            else
            {
                Process.Start("IExplore.exe", URL);
            }
        }
    }
}
