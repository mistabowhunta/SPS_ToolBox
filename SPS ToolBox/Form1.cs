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
                            ie.Quit();
                            //Enter new instance of website that just closed
                            Process.Start("IExplore.exe", "http://owebprd2.tek.com/svcTechWorkbench/TechWorkbench.jsp");
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
