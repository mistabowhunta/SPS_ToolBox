using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SPS_ToolBox
{
    public class Highlighting : Form1

    {
        public string Letters { get; set; }
        
        //Constructor
        public Highlighting (string letters)
        {
            Letters = letters;

            foreach (Button element in btnListButtons)
            {
                //Changing all buttons back to normal color then highlighting user selected letter
                //element.BackColor = SystemColors.ControlLightLight;

                if (element.Text.StartsWith(Letters))
                {
                    element.BackColor = Color.Blue;
                    
                }
            }
        }
       

    }
}
