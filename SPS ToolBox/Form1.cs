using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Diagnostics;
using System.IO;
using SHDocVw;
using System.Runtime.InteropServices;


namespace SPS_ToolBox
{
    public partial class Form1 : Form
    {

       public List<Button> btnListButtons = new List<Button>();
        

        public Form1()
        {
            InitializeComponent();

            // Adding all buttons to btnListButtons. When user clicks "A" all buttons.text starting with "A" will be highlit
            btnListButtons.Add(btnBomComparison); btnListButtons.Add(btnCbom); btnListButtons.Add(btnCsrWorkBench); btnListButtons.Add(btnDataExplorer);
            btnListButtons.Add(btnEcm); btnListButtons.Add(btnEdpm); btnListButtons.Add(btnFfrCalculator); btnListButtons.Add(btnFfrQuality);
            btnListButtons.Add(btnFoxPro); btnListButtons.Add(btnInstallBase); btnListButtons.Add(btnKeiWebApps); btnListButtons.Add(btnOmar);
            btnListButtons.Add(btnOracleMfg); btnListButtons.Add(btnOut); btnListButtons.Add(btnOutQuery); btnListButtons.Add(btnPfListBySwimLane);
            btnListButtons.Add(btnPlsqlDeveloper); btnListButtons.Add(btnPortfolioPage); btnListButtons.Add(btnPriceAdmin); btnListButtons.Add(btnRpdb);
            btnListButtons.Add(btnSpsSharepoint); btnListButtons.Add(btnSqlAvgCalCostProduct); btnListButtons.Add(btnSqlCalReturnRateProduct);
            btnListButtons.Add(btnSqlInstallBase); btnListButtons.Add(btnSqlPartUsage); btnListButtons.Add(btnSqlPartsPricingHistory);
            btnListButtons.Add(btnSqlSvcActivityProduct); btnListButtons.Add(btnSqlSvcContractPricingHistory); btnListButtons.Add(btnSqlSvcPricingHistory);
            btnListButtons.Add(btnStockPlacesAndLocations); btnListButtons.Add(btnTekHome); btnListButtons.Add(btnTekItemQuery);
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void lblA_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            Highlighting highlight = new Highlighting("A");  
        }

        private void lblB_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            Highlighting highlight = new Highlighting("B");
        }

        private void lblC_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {

        }

        private void lblD_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {

        }

        private void lblE_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {

        }

        private void lblF_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {

        }

        private void lblG_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {

        }

        private void lblH_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {

        }

        private void lblI_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {

        }

        private void lblJ_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {

        }

        private void lblK_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {

        }

        private void lblL_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {

        }

        private void lblM_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {

        }

        private void lblN_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {

        }

        private void lblO_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {

        }

        private void lblP_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {

        }

        private void lblQ_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {

        }

        private void lblR_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {

        }

        private void lblS_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {

        }

        private void lblT_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {

        }

        private void lblU_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {

        }

        private void lblV_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {

        }

        private void lblW_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {

        }

        private void lblX_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {

        }

        private void lblY_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {

        }

        private void lblZ_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {

        }

        private void txtSearch_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnLastSearched_Click(object sender, EventArgs e)
        {

        }

        private void btnBomComparison_Click(object sender, EventArgs e)
        {
            Process.Start("IExplore.exe", "https://en.wikipedia.org/wiki/Hater");
        }

        private void btnCbom_Click(object sender, EventArgs e)
        {
            
        }

        private void btnCsrWorkBench_Click(object sender, EventArgs e)
        {
            Process.Start("IExplore.exe", "http://owebprd2.tek.com/svcTechWorkbench/TechWorkbench.jsp");
        }

        //[DllImport("user32.dll")]
        //static extern bool ShowWindow(IntPtr hWnd, int nCmdShow);
        //bool launched = false;
        //private void BringToForeground(IntPtr extHandle)
        //{
        //    if (IsIconic(extHandle))
        //    {
        //        ShowWindow(extHandle, SW_RESTORE);
        //    }
        //    SetForegroundWindow(extHandle);
        //}
//        [DllImport("user32")]
//        public static extern void keybd_event(byte bVk, byte bScan, int dwFlags, int
//dwExtraInfo);
//        private const byte VK_MENU = 0x12;
//        private const byte VK_TAB = 0x09;
//        private const int KEYEVENTF_EXTENDEDKEY = 0x01;
//        private const int KEYEVENTF_KEYUP = 0x02;
        public void PressAButton()
        {
            

            
        }

        private void btnDataExplorer_Click(object sender, EventArgs e)
        {
           
            
            //keybd_event(VK_MENU, 0, 0, 0);
            //keybd_event(VK_TAB, 0, 0, 0);
            //System.Threading.Thread.Sleep(1000);
            //keybd_event(VK_TAB, 0, 0, 0);
            //System.Threading.Thread.Sleep(1000);
            //keybd_event(VK_MENU, 0, KEYEVENTF_KEYUP, 0);
            //keybd_event(VK_MENU, 0, KEYEVENTF_KEYUP, 0);

            //Process[] ps = Process.GetProcessesByName("IExplore"); // <-- no path, no extension!

            //foreach(Process theProcess in ps)
            //{
            //    if (ps.Length > 0)
            //    {
            //        MessageBox.Show(ps[0].MainWindowTitle);

            //        BringToForeground(ps[0].MainWindowHandle);
            //    }
            //}

            //Process[] processList = Process.GetProcesses();

<<<<<<< HEAD
            Process[] processList = Process.GetProcesses();


            foreach (Process theProcess in processList)
            {
                
                    ShowWindow(theProcess.MainWindowHandle, 0);
            }

            foreach (Process theProcess in processList)
            {
                if (theProcess.MainWindowTitle.ToUpper().Contains("Hater - Wikipedia".ToUpper()))
                {
                    ShowWindow(theProcess.MainWindowHandle, 9);
                   
                    
                    launched = true;
                }
            }
=======
            //foreach (Process theProcess in processList)
            //{
            //    ShowWindow(theProcess.MainWindowHandle, 2);
            //}

            //foreach (Process theProcess in processList)
            //{
            //    if (theProcess.MainWindowTitle.ToUpper().Contains("death eater – Etsy".ToUpper()))
            //    {
            //        ShowWindow(theProcess.MainWindowHandle, 9);
            //        launched = true;
            //    }
            //}
>>>>>>> origin/master
            //http://stackoverflow.com/questions/15638531/switch-application-in-c-sharp-like-task-manager


            //    //Process.Start("IExplore.exe", "https://en.wikipedia.org/wiki/George");
            //    bool boolFoundIt = false;
            //    while (!boolFoundIt == false) ;
            //    {
            //        //SendKeys.SendWait("%{TAB}");
            //        //ShellWindows shellWindows = new ShellWindows();
            //        IntPtr hWnd = IntPtr.Zero;
            //        foreach(Process pList in Process.GetProcesses())
            //        {
            //            if (pList.MainWindowTitle.Contains("Wikipedia"))
            //            {
            //                hWnd = pList.MainWindowHandle;
            //                boolFoundIt = true;
            //            }
            //        }

            //    }
        }

        private void btnEcm_Click(object sender, EventArgs e)
        {

        }

        private void btnEdpm_Click(object sender, EventArgs e)
        {

        }

        private void btnFfrCalculator_Click(object sender, EventArgs e)
        {

        }

        private void btnFfrQuality_Click(object sender, EventArgs e)
        {

        }

        private void btnFoxPro_Click(object sender, EventArgs e)
        {

        }

        private void btnInstallBase_Click(object sender, EventArgs e)
        {

        }

        private void btnKeiWebApps_Click(object sender, EventArgs e)
        {

        }

        private void btnOmar_Click(object sender, EventArgs e)
        {

        }

        private void btnOracleMfg_Click(object sender, EventArgs e)
        {

        }

        private void btnOut_Click(object sender, EventArgs e)
        {

        }

        private void btnOutQuery_Click(object sender, EventArgs e)
        {

        }

        private void btnPfListBySwimLane_Click(object sender, EventArgs e)
        {

        }

        private void btnPlsqlDeveloper_Click(object sender, EventArgs e)
        {

        }

        private void btnPortfolioPage_Click(object sender, EventArgs e)
        {

        }

        private void btnPriceAdmin_Click(object sender, EventArgs e)
        {

        }

        private void btnRpdb_Click(object sender, EventArgs e)
        {
            { Process.Start("IExplore.exe", "http://owebprd10.tek.com/tekrpdb/rpdb_query.item"); }
        }

        private void btnSpsSharepoint_Click(object sender, EventArgs e)
        {

        }

        private void btnSqlAvgCalCostProduct_Click(object sender, EventArgs e)
        {

        }

        private void btnSqlCalReturnRateProduct_Click(object sender, EventArgs e)
        {

        }

        private void btnSqlInstallBase_Click(object sender, EventArgs e)
        {

        }

        private void btnSqlPartUsage_Click(object sender, EventArgs e)
        {

        }

        private void btnSqlPartsPricingHistory_Click(object sender, EventArgs e)
        {

        }

        private void btnSqlSvcActivityProduct_Click(object sender, EventArgs e)
        {

        }

        private void btnSqlSvcContractPricingHistory_Click(object sender, EventArgs e)
        {

        }

        private void btnSqlSvcPricingHistory_Click(object sender, EventArgs e)
        {

        }

        private void btnStockPlacesAndLocations_Click(object sender, EventArgs e)
        {

        }

        private void btnTekHome_Click(object sender, EventArgs e)
        {

        }

        private void btnTekItemQuery_Click(object sender, EventArgs e)
        {

        }
    }
}
