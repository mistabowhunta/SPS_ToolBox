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

        // For all buttons listed below I am first iterating through all open Internet Explorer windows to see if the user already has the website open.
        // If the user has the website open, it will be closed and a new insance of IE will start
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

        private void btnDataExplorer_Click(object sender, EventArgs e)
        {
            //Opening a new instance of all the windows currently open
            ShellWindows shellWindows = new ShellWindows();
            string filename;

            //If there are no shellWindows open, start a new instance of IE
            if (shellWindows.Count > 0)
            {
                foreach (InternetExplorer ie in shellWindows)
                {
                    filename = Path.GetFileNameWithoutExtension(ie.FullName).ToLower();
                    if (filename.Equals("iexplore"))
                    {
                        string website = ie.LocationURL.ToString();

                        //Enter website that needs to close if it is already open
                        if (website.Contains("sso/jsp/login-tek.jsp"))
                        {
                            //Giving the user a choice if they want to close the existing IE instance
                            DialogResult dialogResult = MessageBox.Show("There is already an instance of " + btnDataExplorer.Text + ". Close it?", "Close " + btnDataExplorer.Text + "?", 
                                MessageBoxButtons.YesNo);
                            if(dialogResult == DialogResult.Yes)
                            {
                                ie.Quit();
                                //Enter new instance of website that just closed
                                Process.Start("IExplore.exe", "http://owebprd2.tek.com/svcTechWorkbench/TechWorkbench.jsp");
                            }
                           else if(dialogResult == DialogResult.No)
                            {
                                Process.Start("IExplore.exe", "http://owebprd2.tek.com/svcTechWorkbench/TechWorkbench.jsp");
                            }
                        }
                    }
                }
            }
            // There are no shellwindows open so create a new instance of IE
            else
            {
                Process.Start("IExplore.exe", "http://owebprd2.tek.com/svcTechWorkbench/TechWorkbench.jsp");
            }
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

//NOTES
// Parsing out URL's by putting them into array
//string[] urlParts = (ie.LocationURL.ToString()).Split('/');
//string website = urlParts[2];

// data Explorer: http://tekprd34.bv.tek.com:7780/sso/jsp/login-tek.jsp?site2pstoretoken=v1.4~1933623B~8A0D13911343E1A645E0355535B41BDCB578858B9F0E0DBE85F9BD2646BB69A0B13D8D3413D74ACA1652900D998ADB8F368DAC76E4B52112B8A223720BE2B5B0FE7D3CC7675085E45F12CA3C1C3BDC301D5CE763ED449C43BE3C205E5BEB4908653C8208C49FFD002D7D6868DC0304D335690DC71D55419D9777BE59A6BE7E079C765B45F0990731F83DEA5CE33E44A2E1C3B1EA881D16C39B88CD274ABCE2CF42F60F6B4FB730BDC0CC0E786AF383DAF96E1F4439A36D2FFD1157A61DDE2C7D61170A27AC0A97516826A4E7A84E7223057CF79346A53445&p_error_code=&p_submit_url=http%3A%2F%2Ftekprd34.bv.tek.com%3A7780%2Fsso%2Fauth&p_cancel_url=http%3A%2F%2Fowebprd2.tek.com%3A7779&ssousername=
