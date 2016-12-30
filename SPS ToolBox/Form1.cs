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
        
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void lblA_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {

        }

        private void lblB_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {

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
            ShellWindows shellWindows = new ShellWindows();
            string filename;
            
            if (shellWindows.Count > 0)
            {
                foreach (InternetExplorer ie in shellWindows)
                {
                    filename = Path.GetFileNameWithoutExtension(ie.FullName).ToLower();
                    if (filename.Equals("iexplore"))
                    {
                        string[] urlParts = (ie.LocationURL.ToString()).Split('/');
                        string website = urlParts[2];
                        if (website.Contains("wikipedia"))
                        {
                            shellWindows.Show(ie) ("https://en.wikipedia.org/wiki/Home");
                            //{ Process.Start("IExplore.exe", "https://en.wikipedia.org/wiki/Home"); }
                        }
                    }
                }
               

            }
            else { Process.Start("IExplore.exe", "https://en.wikipedia.org/wiki/Home"); }

           
        }

        private void btnCbom_Click(object sender, EventArgs e)
        {

        }

        private void btnCsrWorkBench_Click(object sender, EventArgs e)
        {

        }

        private void btnDataExplorer_Click(object sender, EventArgs e)
        {

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
