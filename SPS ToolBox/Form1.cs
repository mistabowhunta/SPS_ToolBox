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

        //When user clicks index letter, all buttons starting with that letter will highlight red
        private void lblA_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            foreach (Button element in btnListButtons)
            {
                //Changing all buttons back to normal color then highlighting user selected letter
                element.BackColor = SystemColors.ControlLightLight; if (element.Text.StartsWith("A")) { element.BackColor = Color.Red; }
            }
        }

        private void lblB_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            foreach (Button element in btnListButtons)
            {
                //Changing all buttons back to normal color then highlighting user selected letter
                element.BackColor = SystemColors.ControlLightLight; if (element.Text.StartsWith("B")) { element.BackColor = Color.Red; }
            }
        }

        private void lblC_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            foreach (Button element in btnListButtons)
            {
                //Changing all buttons back to normal color then highlighting user selected letter
                element.BackColor = SystemColors.ControlLightLight; if (element.Text.StartsWith("C")) { element.BackColor = Color.Red; }
            }
        }

        private void lblD_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            foreach (Button element in btnListButtons)
            {
                //Changing all buttons back to normal color then highlighting user selected letter
                element.BackColor = SystemColors.ControlLightLight; if (element.Text.StartsWith("D")) { element.BackColor = Color.Red; }
            }
        }

        private void lblE_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            foreach (Button element in btnListButtons)
            {
                //Changing all buttons back to normal color then highlighting user selected letter
                element.BackColor = SystemColors.ControlLightLight; if (element.Text.StartsWith("E")) { element.BackColor = Color.Red; }
            }
        }

        private void lblF_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            foreach (Button element in btnListButtons)
            {
                //Changing all buttons back to normal color then highlighting user selected letter
                element.BackColor = SystemColors.ControlLightLight; if (element.Text.StartsWith("F")) { element.BackColor = Color.Red; }
            }
        }

        private void lblG_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            foreach (Button element in btnListButtons)
            {
                //Changing all buttons back to normal color then highlighting user selected letter
                element.BackColor = SystemColors.ControlLightLight; if (element.Text.StartsWith("G")) { element.BackColor = Color.Red; }
            }
        }

        private void lblH_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            foreach (Button element in btnListButtons)
            {
                //Changing all buttons back to normal color then highlighting user selected letter
                element.BackColor = SystemColors.ControlLightLight; if (element.Text.StartsWith("H")) { element.BackColor = Color.Red; }
            }
        }

        private void lblI_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            foreach (Button element in btnListButtons)
            {
                //Changing all buttons back to normal color then highlighting user selected letter
                element.BackColor = SystemColors.ControlLightLight; if (element.Text.StartsWith("I")) { element.BackColor = Color.Red; }
            }
        }

        private void lblJ_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            foreach (Button element in btnListButtons)
            {
                //Changing all buttons back to normal color then highlighting user selected letter
                element.BackColor = SystemColors.ControlLightLight; if (element.Text.StartsWith("J")) { element.BackColor = Color.Red; }
            }
        }

        private void lblK_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            foreach (Button element in btnListButtons)
            {
                //Changing all buttons back to normal color then highlighting user selected letter
                element.BackColor = SystemColors.ControlLightLight; if (element.Text.StartsWith("K")) { element.BackColor = Color.Red; }
            }
        }

        private void lblL_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            foreach (Button element in btnListButtons)
            {
                //Changing all buttons back to normal color then highlighting user selected letter
                element.BackColor = SystemColors.ControlLightLight; if (element.Text.StartsWith("L")) { element.BackColor = Color.Red; }
            }
        }

        private void lblM_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            foreach (Button element in btnListButtons)
            {
                //Changing all buttons back to normal color then highlighting user selected letter
                element.BackColor = SystemColors.ControlLightLight; if (element.Text.StartsWith("M")) { element.BackColor = Color.Red; }
            }
        }

        private void lblN_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            foreach (Button element in btnListButtons)
            {
                //Changing all buttons back to normal color then highlighting user selected letter
                element.BackColor = SystemColors.ControlLightLight; if (element.Text.StartsWith("N")) { element.BackColor = Color.Red; }
            }
        }

        private void lblO_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            foreach (Button element in btnListButtons)
            {
                //Changing all buttons back to normal color then highlighting user selected letter
                element.BackColor = SystemColors.ControlLightLight; if (element.Text.StartsWith("O")) { element.BackColor = Color.Red; }
            }
        }

        private void lblP_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            foreach (Button element in btnListButtons)
            {
                //Changing all buttons back to normal color then highlighting user selected letter
                element.BackColor = SystemColors.ControlLightLight; if (element.Text.StartsWith("P")) { element.BackColor = Color.Red; }
            }
        }

        private void lblQ_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            foreach (Button element in btnListButtons)
            {
                //Changing all buttons back to normal color then highlighting user selected letter
                element.BackColor = SystemColors.ControlLightLight; if (element.Text.StartsWith("Q")) { element.BackColor = Color.Red; }
            }
        }

        private void lblR_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            foreach (Button element in btnListButtons)
            {
                //Changing all buttons back to normal color then highlighting user selected letter
                element.BackColor = SystemColors.ControlLightLight; if (element.Text.StartsWith("R")) { element.BackColor = Color.Red; }
            }
        }

        private void lblS_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            foreach (Button element in btnListButtons)
            {
                //Changing all buttons back to normal color then highlighting user selected letter
                element.BackColor = SystemColors.ControlLightLight; if (element.Text.StartsWith("S")) { element.BackColor = Color.Red; }
            }
        }

        private void lblT_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            foreach (Button element in btnListButtons)
            {
                //Changing all buttons back to normal color then highlighting user selected letter
                element.BackColor = SystemColors.ControlLightLight; if (element.Text.StartsWith("T")) { element.BackColor = Color.Red; }
            }
        }

        private void lblU_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            foreach (Button element in btnListButtons)
            {
                //Changing all buttons back to normal color then highlighting user selected letter
                element.BackColor = SystemColors.ControlLightLight; if (element.Text.StartsWith("U")) { element.BackColor = Color.Red; }
            }
        }

        private void lblV_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            foreach (Button element in btnListButtons)
            {
                //Changing all buttons back to normal color then highlighting user selected letter
                element.BackColor = SystemColors.ControlLightLight; if (element.Text.StartsWith("V")) { element.BackColor = Color.Red; }
            }
        }

        private void lblW_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            foreach (Button element in btnListButtons)
            {
                //Changing all buttons back to normal color then highlighting user selected letter
                element.BackColor = SystemColors.ControlLightLight; if (element.Text.StartsWith("W")) { element.BackColor = Color.Red; }
            }
        }

        private void lblX_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            foreach (Button element in btnListButtons)
            {
                //Changing all buttons back to normal color then highlighting user selected letter
                element.BackColor = SystemColors.ControlLightLight; if (element.Text.StartsWith("X")) { element.BackColor = Color.Red; }
            }
        }

        private void lblY_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            foreach (Button element in btnListButtons)
            {
                //Changing all buttons back to normal color then highlighting user selected letter
                element.BackColor = SystemColors.ControlLightLight; if (element.Text.StartsWith("Y")) { element.BackColor = Color.Red; }
            }
        }

        private void lblZ_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            foreach (Button element in btnListButtons)
            {
                //Changing all buttons back to normal color then highlighting user selected letter
                element.BackColor = SystemColors.ControlLightLight; if (element.Text.StartsWith("Z")) { element.BackColor = Color.Red; }
            }
        }

        private void txtSearch_TextChanged(object sender, EventArgs e)
        {
            //Highlighting all buttons matching user's text
 
            //Storing every letter into a string list
            List<string> strTxtSearch = new List<string>();
            strTxtSearch.Add(txtSearch.Text.ToLower());

            //User can't have 2 spaces in textbox
            if (txtSearch.Text.Contains("  "))
            {
                //Trimming the end of textbox to get rid of the extra space user entered
                txtSearch.Text = txtSearch.Text.TrimEnd(txtSearch.Text[txtSearch.Text.Length - 1]);

                //Adding one space back to string so still has one space
                txtSearch.Text += " ";

                //Trimming the end of strTxtSearch to get rid of the extra space user entered
                strTxtSearch[0] = strTxtSearch[0].TrimEnd(strTxtSearch[0][strTxtSearch[0].Length - 1]);

                //Adding one space back to string so still has one space
                strTxtSearch[0] += " ";

                //Setting the cursor to the end of the users already entered string
                txtSearch.SelectionStart = txtSearch.Text.Length;
      
            }

            //Preventing user from entering a space at the beggining of text 
            else if (txtSearch.Text.Contains(" ") && (strTxtSearch[0] == " "))
            {
                //Trimming the end of textbox to get rid of the extra space user entered
                txtSearch.Text = txtSearch.Text.TrimEnd(txtSearch.Text[txtSearch.Text.Length - 1]);

                //Trimming the end of strTxtSearch to get rid of the extra space user entered
                strTxtSearch[0] = strTxtSearch[0].TrimEnd(strTxtSearch[0][strTxtSearch[0].Length - 1]);

                //Setting the cursor back to the beginning
                txtSearch.SelectionStart = txtSearch.Text.Length;
            }

            //In case user deletes all text need to change all backcolor back to original color, otherwise all buttons turn red
            else if (strTxtSearch[0] == "") { foreach(Button element in btnListButtons) { element.BackColor = SystemColors.ControlLightLight; } }
            else 
            {
                foreach (Button element in btnListButtons)
                {
                    element.BackColor = SystemColors.ControlLightLight;
                    if (element.Text.ToLower().StartsWith(strTxtSearch[0].ToLower())) { element.BackColor = Color.Red; }
                }
            }
        }

        // For all buttons listed below I am first iterating through all open Internet Explorer windows to see if the user already has the website open.
        // If the user has the website open, it will be closed and a new insance of IE will start
        private void btnLastClicked_Click(object sender, EventArgs e)
        {
            //Captures the last button user clicked and then enables the "LastClicked" button to click the user's last clicked button
            foreach (Button element in btnListButtons)
            {
                if (element.Text == btnLastClicked.Text) { element.PerformClick(); }
            }
        }

        private void btnBomComparison_Click(object sender, EventArgs e)
        {
            //Sending strings to IEHandling class: url contains, button text, and URL that button corresponds to
            IEHandling iehandling = new IEHandling("wikipedia.org/wiki/George", btnDataExplorer.Text, "https://en.wikipedia.org/wiki/George");

            //Setting Last Click button text to this button text so user knows the last button they clicked
            btnLastClicked.Text = btnBomComparison.Text;
        }

        private void btnCbom_Click(object sender, EventArgs e)
        {
            //Sending strings to IEHandling class: url contains, button text, and URL that button corresponds to
            IEHandling iehandling = new IEHandling("wikipedia.org/wiki/George", btnDataExplorer.Text, "https://en.wikipedia.org/wiki/George");

            //Setting Last Click button text to this button text so user knows the last button they clicked
            btnLastClicked.Text = btnCbom.Text;
        }

        private void btnCsrWorkBench_Click(object sender, EventArgs e)
        {
            //Sending strings to IEHandling class: url contains, button text, and URL that button corresponds to
            IEHandling iehandling = new IEHandling("wikipedia.org/wiki/George", btnDataExplorer.Text, "https://en.wikipedia.org/wiki/George");

            //Setting Last Click button text to this button text so user knows the last button they clicked
            btnLastClicked.Text = btnCsrWorkBench.Text;
        }

        private void btnDataExplorer_Click(object sender, EventArgs e)
        {
            //Sending strings to IEHandling class: url contains, button text, and URL that button corresponds to
            IEHandling iehandling = new IEHandling("wikipedia.org/wiki/George", btnDataExplorer.Text, "https://en.wikipedia.org/wiki/George");

            //Setting Last Click button text to this button text so user knows the last button they clicked
            btnLastClicked.Text = btnDataExplorer.Text;
        }

        private void btnEcm_Click(object sender, EventArgs e)
        {
            //Sending strings to IEHandling class: url contains, button text, and URL that button corresponds to
            IEHandling iehandling = new IEHandling("wikipedia.org/wiki/George", btnDataExplorer.Text, "https://en.wikipedia.org/wiki/George");

            //Setting Last Click button text to this button text so user knows the last button they clicked
            btnLastClicked.Text = btnEcm.Text;
        }

        private void btnEdpm_Click(object sender, EventArgs e)
        {
            //Sending strings to IEHandling class: url contains, button text, and URL that button corresponds to
            IEHandling iehandling = new IEHandling("wikipedia.org/wiki/George", btnDataExplorer.Text, "https://en.wikipedia.org/wiki/George");

            //Setting Last Click button text to this button text so user knows the last button they clicked
            btnLastClicked.Text = btnEdpm.Text;
        }

        private void btnFfrCalculator_Click(object sender, EventArgs e)
        {
            //Setting Last Click button text to this button text so user knows the last button they clicked
            btnLastClicked.Text = btnFfrCalculator.Text;
        }

        private void btnFfrQuality_Click(object sender, EventArgs e)
        {
            //Sending strings to IEHandling class: url contains, button text, and URL that button corresponds to
            IEHandling iehandling = new IEHandling("wikipedia.org/wiki/George", btnDataExplorer.Text, "https://en.wikipedia.org/wiki/George");

            //Setting Last Click button text to this button text so user knows the last button they clicked
            btnLastClicked.Text = btnFfrQuality.Text;
        }

        private void btnFoxPro_Click(object sender, EventArgs e)
        {
            //Setting Last Click button text to this button text so user knows the last button they clicked
            btnLastClicked.Text = btnFoxPro.Text;
        }

        private void btnInstallBase_Click(object sender, EventArgs e)
        {
            //Sending strings to IEHandling class: url contains, button text, and URL that button corresponds to
            IEHandling iehandling = new IEHandling("wikipedia.org/wiki/George", btnDataExplorer.Text, "https://en.wikipedia.org/wiki/George");

            //Setting Last Click button text to this button text so user knows the last button they clicked
            btnLastClicked.Text = btnInstallBase.Text;
        }

        private void btnKeiWebApps_Click(object sender, EventArgs e)
        {
            //Sending strings to IEHandling class: url contains, button text, and URL that button corresponds to
            IEHandling iehandling = new IEHandling("wikipedia.org/wiki/George", btnDataExplorer.Text, "https://en.wikipedia.org/wiki/George");

            //Setting Last Click button text to this button text so user knows the last button they clicked
            btnLastClicked.Text = btnKeiWebApps.Text;
        }

        private void btnOmar_Click(object sender, EventArgs e)
        {
            //Sending strings to IEHandling class: url contains, button text, and URL that button corresponds to
            IEHandling iehandling = new IEHandling("wikipedia.org/wiki/George", btnDataExplorer.Text, "https://en.wikipedia.org/wiki/George");

            //Setting Last Click button text to this button text so user knows the last button they clicked
            btnLastClicked.Text = btnOmar.Text;
        }

        private void btnOracleMfg_Click(object sender, EventArgs e)
        {
            //Sending strings to IEHandling class: url contains, button text, and URL that button corresponds to
            IEHandling iehandling = new IEHandling("wikipedia.org/wiki/George", btnDataExplorer.Text, "https://en.wikipedia.org/wiki/George");

            //Setting Last Click button text to this button text so user knows the last button they clicked
            btnLastClicked.Text = btnOracleMfg.Text;
        }

        private void btnOut_Click(object sender, EventArgs e)
        {
            //Sending strings to IEHandling class: url contains, button text, and URL that button corresponds to
            IEHandling iehandling = new IEHandling("wikipedia.org/wiki/George", btnDataExplorer.Text, "https://en.wikipedia.org/wiki/George");

            //Setting Last Click button text to this button text so user knows the last button they clicked
            btnLastClicked.Text = btnOut.Text;
        }

        private void btnOutQuery_Click(object sender, EventArgs e)
        {
            //Sending strings to IEHandling class: url contains, button text, and URL that button corresponds to
            IEHandling iehandling = new IEHandling("wikipedia.org/wiki/George", btnDataExplorer.Text, "https://en.wikipedia.org/wiki/George");

            //Setting Last Click button text to this button text so user knows the last button they clicked
            btnLastClicked.Text = btnOutQuery.Text;
        }

        private void btnPfListBySwimLane_Click(object sender, EventArgs e)
        {
            //Setting Last Click button text to this button text so user knows the last button they clicked
            btnLastClicked.Text = btnPfListBySwimLane.Text;
        }

        private void btnPlsqlDeveloper_Click(object sender, EventArgs e)
        {
            //Setting Last Click button text to this button text so user knows the last button they clicked
            btnLastClicked.Text = btnPlsqlDeveloper.Text;
        }

        private void btnPortfolioPage_Click(object sender, EventArgs e)
        {
            //Sending strings to IEHandling class: url contains, button text, and URL that button corresponds to
            IEHandling iehandling = new IEHandling("wikipedia.org/wiki/George", btnDataExplorer.Text, "https://en.wikipedia.org/wiki/George");

            //Setting Last Click button text to this button text so user knows the last button they clicked
            btnLastClicked.Text = btnPortfolioPage.Text;
        }

        private void btnPriceAdmin_Click(object sender, EventArgs e)
        {
            //Sending strings to IEHandling class: url contains, button text, and URL that button corresponds to
            IEHandling iehandling = new IEHandling("wikipedia.org/wiki/George", btnDataExplorer.Text, "https://en.wikipedia.org/wiki/George");

            //Setting Last Click button text to this button text so user knows the last button they clicked
            btnLastClicked.Text = btnPriceAdmin.Text;
        }

        private void btnRpdb_Click(object sender, EventArgs e)
        {
            //Sending strings to IEHandling class: url contains, button text, and URL that button corresponds to
            IEHandling iehandling = new IEHandling("wikipedia.org/wiki/George", btnDataExplorer.Text, "https://en.wikipedia.org/wiki/George");

            //Setting Last Click button text to this button text so user knows the last button they clicked
            btnLastClicked.Text = btnRpdb.Text;
        }

        private void btnSpsSharepoint_Click(object sender, EventArgs e)
        {
            //Sending strings to IEHandling class: url contains, button text, and URL that button corresponds to
            IEHandling iehandling = new IEHandling("wikipedia.org/wiki/George", btnDataExplorer.Text, "https://en.wikipedia.org/wiki/George");

            //Setting Last Click button text to this button text so user knows the last button they clicked
            btnLastClicked.Text = btnSpsSharepoint.Text;
        }

        private void btnSqlAvgCalCostProduct_Click(object sender, EventArgs e)
        {
            //Setting Last Click button text to this button text so user knows the last button they clicked
            btnLastClicked.Text = btnSqlAvgCalCostProduct.Text;
        }

        private void btnSqlCalReturnRateProduct_Click(object sender, EventArgs e)
        {
            //Setting Last Click button text to this button text so user knows the last button they clicked
            btnLastClicked.Text = btnSqlCalReturnRateProduct.Text;
        }

        private void btnSqlInstallBase_Click(object sender, EventArgs e)
        {
            //Setting Last Click button text to this button text so user knows the last button they clicked
            btnLastClicked.Text = btnSqlInstallBase.Text;
        }

        private void btnSqlPartUsage_Click(object sender, EventArgs e)
        {
            //Setting Last Click button text to this button text so user knows the last button they clicked
            btnLastClicked.Text = btnSqlPartUsage.Text;
        }

        private void btnSqlPartsPricingHistory_Click(object sender, EventArgs e)
        {
            //Setting Last Click button text to this button text so user knows the last button they clicked
            btnLastClicked.Text = btnSqlPartsPricingHistory.Text;
        }

        private void btnSqlSvcActivityProduct_Click(object sender, EventArgs e)
        {
            //Setting Last Click button text to this button text so user knows the last button they clicked
            btnLastClicked.Text = btnSqlSvcActivityProduct.Text;
        }

        private void btnSqlSvcContractPricingHistory_Click(object sender, EventArgs e)
        {
            //Setting Last Click button text to this button text so user knows the last button they clicked
            btnLastClicked.Text = btnSqlSvcContractPricingHistory.Text;
        }

        private void btnSqlSvcPricingHistory_Click(object sender, EventArgs e)
        {
            //Setting Last Click button text to this button text so user knows the last button they clicked
            btnLastClicked.Text = btnSqlSvcPricingHistory.Text;
        }

        private void btnStockPlacesAndLocations_Click(object sender, EventArgs e)
        {
            //Sending strings to IEHandling class: url contains, button text, and URL that button corresponds to
            IEHandling iehandling = new IEHandling("wikipedia.org/wiki/George", btnDataExplorer.Text, "https://en.wikipedia.org/wiki/George");

            //Setting Last Click button text to this button text so user knows the last button they clicked
            btnLastClicked.Text = btnStockPlacesAndLocations.Text;
        }

        private void btnTekHome_Click(object sender, EventArgs e)
        {
            //Sending strings to IEHandling class: url contains, button text, and URL that button corresponds to
            IEHandling iehandling = new IEHandling("wikipedia.org/wiki/George", btnDataExplorer.Text, "https://en.wikipedia.org/wiki/George");

            //Setting Last Click button text to this button text so user knows the last button they clicked
            btnLastClicked.Text = btnTekHome.Text;
        }

        private void btnTekItemQuery_Click(object sender, EventArgs e)
        {
            //Sending strings to IEHandling class: url contains, button text, and URL that button corresponds to
            IEHandling iehandling = new IEHandling("wikipedia.org/wiki/George", btnDataExplorer.Text, "https://en.wikipedia.org/wiki/George");

            //Setting Last Click button text to this button text so user knows the last button they clicked
            btnLastClicked.Text = btnTekItemQuery.Text;
        }
    }
}

//NOTES
// Parsing out URL's by putting them into array
//string[] urlParts = (ie.LocationURL.ToString()).Split('/');
//string website = urlParts[2];

// data Explorer: http://tekprd34.bv.tek.com:7780/sso/jsp/login-tek.jsp?site2pstoretoken=v1.4~1933623B~8A0D13911343E1A645E0355535B41BDCB578858B9F0E0DBE85F9BD2646BB69A0B13D8D3413D74ACA1652900D998ADB8F368DAC76E4B52112B8A223720BE2B5B0FE7D3CC7675085E45F12CA3C1C3BDC301D5CE763ED449C43BE3C205E5BEB4908653C8208C49FFD002D7D6868DC0304D335690DC71D55419D9777BE59A6BE7E079C765B45F0990731F83DEA5CE33E44A2E1C3B1EA881D16C39B88CD274ABCE2CF42F60F6B4FB730BDC0CC0E786AF383DAF96E1F4439A36D2FFD1157A61DDE2C7D61170A27AC0A97516826A4E7A84E7223057CF79346A53445&p_error_code=&p_submit_url=http%3A%2F%2Ftekprd34.bv.tek.com%3A7780%2Fsso%2Fauth&p_cancel_url=http%3A%2F%2Fowebprd2.tek.com%3A7779&ssousername=
