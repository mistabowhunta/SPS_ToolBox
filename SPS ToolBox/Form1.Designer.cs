using System.Windows.Forms;

namespace SPS_ToolBox
{
    partial class Form1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }
        //Need to override KeyDown event handlers even if KeyPreview is true because they cannot see enter, escape, arrow buttons
        //protected override bool ProcessCmdKey(ref Message msg, Keys keyData)
        //{
        //    if (keyData == Keys.Enter)
        //    {
        //        //btnEquals_Click(sender, e);
        //        //btnEquals.PerformClick();
        //        boolEnterPressed = true;
        //        return true;
        //    }
        //    return base.ProcessCmdKey(ref msg, keyData);
        //}

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.txtSearch = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.lblA = new System.Windows.Forms.LinkLabel();
            this.lblB = new System.Windows.Forms.LinkLabel();
            this.lblC = new System.Windows.Forms.LinkLabel();
            this.lblD = new System.Windows.Forms.LinkLabel();
            this.lblE = new System.Windows.Forms.LinkLabel();
            this.lblF = new System.Windows.Forms.LinkLabel();
            this.lblG = new System.Windows.Forms.LinkLabel();
            this.lblH = new System.Windows.Forms.LinkLabel();
            this.lblI = new System.Windows.Forms.LinkLabel();
            this.lblJ = new System.Windows.Forms.LinkLabel();
            this.lblK = new System.Windows.Forms.LinkLabel();
            this.lblL = new System.Windows.Forms.LinkLabel();
            this.lblM = new System.Windows.Forms.LinkLabel();
            this.lblN = new System.Windows.Forms.LinkLabel();
            this.lblO = new System.Windows.Forms.LinkLabel();
            this.lblP = new System.Windows.Forms.LinkLabel();
            this.lblQ = new System.Windows.Forms.LinkLabel();
            this.lblR = new System.Windows.Forms.LinkLabel();
            this.lblS = new System.Windows.Forms.LinkLabel();
            this.lblT = new System.Windows.Forms.LinkLabel();
            this.lblU = new System.Windows.Forms.LinkLabel();
            this.lblV = new System.Windows.Forms.LinkLabel();
            this.lblW = new System.Windows.Forms.LinkLabel();
            this.lblX = new System.Windows.Forms.LinkLabel();
            this.lblY = new System.Windows.Forms.LinkLabel();
            this.lblZ = new System.Windows.Forms.LinkLabel();
            this.btnBomComparison = new System.Windows.Forms.Button();
            this.btnCbom = new System.Windows.Forms.Button();
            this.btnCsrWorkBench = new System.Windows.Forms.Button();
            this.btnDataExplorer = new System.Windows.Forms.Button();
            this.btnEcm = new System.Windows.Forms.Button();
            this.btnEdpm = new System.Windows.Forms.Button();
            this.btnFfrCalculator = new System.Windows.Forms.Button();
            this.btnFfrQuality = new System.Windows.Forms.Button();
            this.btnFoxPro = new System.Windows.Forms.Button();
            this.btnInstallBase = new System.Windows.Forms.Button();
            this.btnKeiWebApps = new System.Windows.Forms.Button();
            this.btnOmar = new System.Windows.Forms.Button();
            this.btnOracleMfg = new System.Windows.Forms.Button();
            this.btnOut = new System.Windows.Forms.Button();
            this.btnOutQuery = new System.Windows.Forms.Button();
            this.btnPfListBySwimLane = new System.Windows.Forms.Button();
            this.btnPlsqlDeveloper = new System.Windows.Forms.Button();
            this.btnPortfolioPage = new System.Windows.Forms.Button();
            this.btnPriceAdmin = new System.Windows.Forms.Button();
            this.btnRpdb = new System.Windows.Forms.Button();
            this.btnSpsSharepoint = new System.Windows.Forms.Button();
            this.btnSqlAvgCalCostProduct = new System.Windows.Forms.Button();
            this.btnSqlCalReturnRateProduct = new System.Windows.Forms.Button();
            this.btnSqlInstallBase = new System.Windows.Forms.Button();
            this.btnSqlPartUsage = new System.Windows.Forms.Button();
            this.btnSqlPartsPricingHistory = new System.Windows.Forms.Button();
            this.btnSqlSvcActivityProduct = new System.Windows.Forms.Button();
            this.btnSqlSvcContractPricingHistory = new System.Windows.Forms.Button();
            this.btnSqlSvcPricingHistory = new System.Windows.Forms.Button();
            this.btnStockPlacesAndLocations = new System.Windows.Forms.Button();
            this.btnTekHome = new System.Windows.Forms.Button();
            this.btnTekItemQuery = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.btnLastClicked = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // txtSearch
            // 
            this.txtSearch.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.txtSearch.Font = new System.Drawing.Font("Cambria", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtSearch.Location = new System.Drawing.Point(687, 40);
            this.txtSearch.Name = "txtSearch";
            this.txtSearch.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.txtSearch.Size = new System.Drawing.Size(256, 32);
            this.txtSearch.TabIndex = 0;
            this.txtSearch.TextChanged += new System.EventHandler(this.txtSearch_TextChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Cambria", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(682, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(82, 28);
            this.label1.TabIndex = 1;
            this.label1.Text = "Search";
            // 
            // lblA
            // 
            this.lblA.AutoSize = true;
            this.lblA.Font = new System.Drawing.Font("Cambria", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblA.Location = new System.Drawing.Point(59, 89);
            this.lblA.Name = "lblA";
            this.lblA.Size = new System.Drawing.Size(27, 28);
            this.lblA.TabIndex = 2;
            this.lblA.TabStop = true;
            this.lblA.Text = "A";
            this.lblA.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.lblA_LinkClicked);
            // 
            // lblB
            // 
            this.lblB.AutoSize = true;
            this.lblB.Font = new System.Drawing.Font("Cambria", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblB.Location = new System.Drawing.Point(92, 89);
            this.lblB.Name = "lblB";
            this.lblB.Size = new System.Drawing.Size(27, 28);
            this.lblB.TabIndex = 3;
            this.lblB.TabStop = true;
            this.lblB.Text = "B";
            this.lblB.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.lblB_LinkClicked);
            // 
            // lblC
            // 
            this.lblC.AutoSize = true;
            this.lblC.Font = new System.Drawing.Font("Cambria", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblC.Location = new System.Drawing.Point(125, 89);
            this.lblC.Name = "lblC";
            this.lblC.Size = new System.Drawing.Size(26, 28);
            this.lblC.TabIndex = 4;
            this.lblC.TabStop = true;
            this.lblC.Text = "C";
            this.lblC.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.lblC_LinkClicked);
            // 
            // lblD
            // 
            this.lblD.AutoSize = true;
            this.lblD.Font = new System.Drawing.Font("Cambria", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblD.Location = new System.Drawing.Point(157, 89);
            this.lblD.Name = "lblD";
            this.lblD.Size = new System.Drawing.Size(28, 28);
            this.lblD.TabIndex = 5;
            this.lblD.TabStop = true;
            this.lblD.Text = "D";
            this.lblD.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.lblD_LinkClicked);
            // 
            // lblE
            // 
            this.lblE.AutoSize = true;
            this.lblE.Font = new System.Drawing.Font("Cambria", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblE.Location = new System.Drawing.Point(191, 89);
            this.lblE.Name = "lblE";
            this.lblE.Size = new System.Drawing.Size(26, 28);
            this.lblE.TabIndex = 6;
            this.lblE.TabStop = true;
            this.lblE.Text = "E";
            this.lblE.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.lblE_LinkClicked);
            // 
            // lblF
            // 
            this.lblF.AutoSize = true;
            this.lblF.Font = new System.Drawing.Font("Cambria", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblF.Location = new System.Drawing.Point(223, 89);
            this.lblF.Name = "lblF";
            this.lblF.Size = new System.Drawing.Size(25, 28);
            this.lblF.TabIndex = 7;
            this.lblF.TabStop = true;
            this.lblF.Text = "F";
            this.lblF.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.lblF_LinkClicked);
            // 
            // lblG
            // 
            this.lblG.AutoSize = true;
            this.lblG.Font = new System.Drawing.Font("Cambria", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblG.Location = new System.Drawing.Point(254, 89);
            this.lblG.Name = "lblG";
            this.lblG.Size = new System.Drawing.Size(27, 28);
            this.lblG.TabIndex = 8;
            this.lblG.TabStop = true;
            this.lblG.Text = "G";
            this.lblG.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.lblG_LinkClicked);
            // 
            // lblH
            // 
            this.lblH.AutoSize = true;
            this.lblH.Font = new System.Drawing.Font("Cambria", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblH.Location = new System.Drawing.Point(287, 89);
            this.lblH.Name = "lblH";
            this.lblH.Size = new System.Drawing.Size(28, 28);
            this.lblH.TabIndex = 9;
            this.lblH.TabStop = true;
            this.lblH.Text = "H";
            this.lblH.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.lblH_LinkClicked);
            // 
            // lblI
            // 
            this.lblI.AutoSize = true;
            this.lblI.Font = new System.Drawing.Font("Cambria", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblI.Location = new System.Drawing.Point(321, 89);
            this.lblI.Name = "lblI";
            this.lblI.Size = new System.Drawing.Size(20, 28);
            this.lblI.TabIndex = 10;
            this.lblI.TabStop = true;
            this.lblI.Text = "I";
            this.lblI.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.lblI_LinkClicked);
            // 
            // lblJ
            // 
            this.lblJ.AutoSize = true;
            this.lblJ.Font = new System.Drawing.Font("Cambria", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblJ.Location = new System.Drawing.Point(347, 89);
            this.lblJ.Name = "lblJ";
            this.lblJ.Size = new System.Drawing.Size(19, 28);
            this.lblJ.TabIndex = 11;
            this.lblJ.TabStop = true;
            this.lblJ.Text = "J";
            this.lblJ.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.lblJ_LinkClicked);
            // 
            // lblK
            // 
            this.lblK.AutoSize = true;
            this.lblK.Font = new System.Drawing.Font("Cambria", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblK.Location = new System.Drawing.Point(372, 89);
            this.lblK.Name = "lblK";
            this.lblK.Size = new System.Drawing.Size(27, 28);
            this.lblK.TabIndex = 12;
            this.lblK.TabStop = true;
            this.lblK.Text = "K";
            this.lblK.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.lblK_LinkClicked);
            // 
            // lblL
            // 
            this.lblL.AutoSize = true;
            this.lblL.Font = new System.Drawing.Font("Cambria", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblL.Location = new System.Drawing.Point(405, 89);
            this.lblL.Name = "lblL";
            this.lblL.Size = new System.Drawing.Size(25, 28);
            this.lblL.TabIndex = 13;
            this.lblL.TabStop = true;
            this.lblL.Text = "L";
            this.lblL.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.lblL_LinkClicked);
            // 
            // lblM
            // 
            this.lblM.AutoSize = true;
            this.lblM.Font = new System.Drawing.Font("Cambria", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblM.Location = new System.Drawing.Point(436, 89);
            this.lblM.Name = "lblM";
            this.lblM.Size = new System.Drawing.Size(32, 28);
            this.lblM.TabIndex = 14;
            this.lblM.TabStop = true;
            this.lblM.Text = "M";
            this.lblM.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.lblM_LinkClicked);
            // 
            // lblN
            // 
            this.lblN.AutoSize = true;
            this.lblN.Font = new System.Drawing.Font("Cambria", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblN.Location = new System.Drawing.Point(474, 89);
            this.lblN.Name = "lblN";
            this.lblN.Size = new System.Drawing.Size(28, 28);
            this.lblN.TabIndex = 15;
            this.lblN.TabStop = true;
            this.lblN.Text = "N";
            this.lblN.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.lblN_LinkClicked);
            // 
            // lblO
            // 
            this.lblO.AutoSize = true;
            this.lblO.Font = new System.Drawing.Font("Cambria", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblO.Location = new System.Drawing.Point(508, 89);
            this.lblO.Name = "lblO";
            this.lblO.Size = new System.Drawing.Size(28, 28);
            this.lblO.TabIndex = 16;
            this.lblO.TabStop = true;
            this.lblO.Text = "O";
            this.lblO.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.lblO_LinkClicked);
            // 
            // lblP
            // 
            this.lblP.AutoSize = true;
            this.lblP.Font = new System.Drawing.Font("Cambria", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblP.Location = new System.Drawing.Point(542, 89);
            this.lblP.Name = "lblP";
            this.lblP.Size = new System.Drawing.Size(26, 28);
            this.lblP.TabIndex = 17;
            this.lblP.TabStop = true;
            this.lblP.Text = "P";
            this.lblP.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.lblP_LinkClicked);
            // 
            // lblQ
            // 
            this.lblQ.AutoSize = true;
            this.lblQ.Font = new System.Drawing.Font("Cambria", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblQ.Location = new System.Drawing.Point(574, 89);
            this.lblQ.Name = "lblQ";
            this.lblQ.Size = new System.Drawing.Size(28, 28);
            this.lblQ.TabIndex = 18;
            this.lblQ.TabStop = true;
            this.lblQ.Text = "Q";
            this.lblQ.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.lblQ_LinkClicked);
            // 
            // lblR
            // 
            this.lblR.AutoSize = true;
            this.lblR.Font = new System.Drawing.Font("Cambria", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblR.Location = new System.Drawing.Point(608, 89);
            this.lblR.Name = "lblR";
            this.lblR.Size = new System.Drawing.Size(27, 28);
            this.lblR.TabIndex = 19;
            this.lblR.TabStop = true;
            this.lblR.Text = "R";
            this.lblR.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.lblR_LinkClicked);
            // 
            // lblS
            // 
            this.lblS.AutoSize = true;
            this.lblS.Font = new System.Drawing.Font("Cambria", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblS.Location = new System.Drawing.Point(641, 89);
            this.lblS.Name = "lblS";
            this.lblS.Size = new System.Drawing.Size(24, 28);
            this.lblS.TabIndex = 20;
            this.lblS.TabStop = true;
            this.lblS.Text = "S";
            this.lblS.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.lblS_LinkClicked);
            // 
            // lblT
            // 
            this.lblT.AutoSize = true;
            this.lblT.Font = new System.Drawing.Font("Cambria", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblT.Location = new System.Drawing.Point(671, 89);
            this.lblT.Name = "lblT";
            this.lblT.Size = new System.Drawing.Size(26, 28);
            this.lblT.TabIndex = 21;
            this.lblT.TabStop = true;
            this.lblT.Text = "T";
            this.lblT.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.lblT_LinkClicked);
            // 
            // lblU
            // 
            this.lblU.AutoSize = true;
            this.lblU.Font = new System.Drawing.Font("Cambria", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblU.Location = new System.Drawing.Point(703, 89);
            this.lblU.Name = "lblU";
            this.lblU.Size = new System.Drawing.Size(28, 28);
            this.lblU.TabIndex = 22;
            this.lblU.TabStop = true;
            this.lblU.Text = "U";
            this.lblU.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.lblU_LinkClicked);
            // 
            // lblV
            // 
            this.lblV.AutoSize = true;
            this.lblV.Font = new System.Drawing.Font("Cambria", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblV.Location = new System.Drawing.Point(737, 89);
            this.lblV.Name = "lblV";
            this.lblV.Size = new System.Drawing.Size(26, 28);
            this.lblV.TabIndex = 23;
            this.lblV.TabStop = true;
            this.lblV.Text = "V";
            this.lblV.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.lblV_LinkClicked);
            // 
            // lblW
            // 
            this.lblW.AutoSize = true;
            this.lblW.Font = new System.Drawing.Font("Cambria", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblW.Location = new System.Drawing.Point(769, 89);
            this.lblW.Name = "lblW";
            this.lblW.Size = new System.Drawing.Size(34, 28);
            this.lblW.TabIndex = 24;
            this.lblW.TabStop = true;
            this.lblW.Text = "W";
            this.lblW.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.lblW_LinkClicked);
            // 
            // lblX
            // 
            this.lblX.AutoSize = true;
            this.lblX.Font = new System.Drawing.Font("Cambria", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblX.Location = new System.Drawing.Point(809, 89);
            this.lblX.Name = "lblX";
            this.lblX.Size = new System.Drawing.Size(26, 28);
            this.lblX.TabIndex = 25;
            this.lblX.TabStop = true;
            this.lblX.Text = "X";
            this.lblX.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.lblX_LinkClicked);
            // 
            // lblY
            // 
            this.lblY.AutoSize = true;
            this.lblY.Font = new System.Drawing.Font("Cambria", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblY.Location = new System.Drawing.Point(841, 89);
            this.lblY.Name = "lblY";
            this.lblY.Size = new System.Drawing.Size(26, 28);
            this.lblY.TabIndex = 26;
            this.lblY.TabStop = true;
            this.lblY.Text = "Y";
            this.lblY.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.lblY_LinkClicked);
            // 
            // lblZ
            // 
            this.lblZ.AutoSize = true;
            this.lblZ.Font = new System.Drawing.Font("Cambria", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblZ.Location = new System.Drawing.Point(873, 89);
            this.lblZ.Name = "lblZ";
            this.lblZ.Size = new System.Drawing.Size(25, 28);
            this.lblZ.TabIndex = 27;
            this.lblZ.TabStop = true;
            this.lblZ.Text = "Z";
            this.lblZ.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.lblZ_LinkClicked);
            // 
            // btnBomComparison
            // 
            this.btnBomComparison.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.btnBomComparison.Font = new System.Drawing.Font("Cambria", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnBomComparison.Location = new System.Drawing.Point(12, 135);
            this.btnBomComparison.Name = "btnBomComparison";
            this.btnBomComparison.Size = new System.Drawing.Size(120, 40);
            this.btnBomComparison.TabIndex = 28;
            this.btnBomComparison.Text = "BOM Comparison";
            this.btnBomComparison.UseVisualStyleBackColor = false;
            this.btnBomComparison.Click += new System.EventHandler(this.btnBomComparison_Click);
            // 
            // btnCbom
            // 
            this.btnCbom.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.btnCbom.Font = new System.Drawing.Font("Cambria", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCbom.Location = new System.Drawing.Point(126, 135);
            this.btnCbom.Name = "btnCbom";
            this.btnCbom.Size = new System.Drawing.Size(120, 40);
            this.btnCbom.TabIndex = 29;
            this.btnCbom.Text = "CBOM";
            this.btnCbom.UseVisualStyleBackColor = false;
            this.btnCbom.Click += new System.EventHandler(this.btnCbom_Click);
            // 
            // btnCsrWorkBench
            // 
            this.btnCsrWorkBench.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.btnCsrWorkBench.Font = new System.Drawing.Font("Cambria", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCsrWorkBench.Location = new System.Drawing.Point(243, 135);
            this.btnCsrWorkBench.Name = "btnCsrWorkBench";
            this.btnCsrWorkBench.Size = new System.Drawing.Size(120, 40);
            this.btnCsrWorkBench.TabIndex = 30;
            this.btnCsrWorkBench.Text = "CSR WorkBench";
            this.btnCsrWorkBench.UseVisualStyleBackColor = false;
            this.btnCsrWorkBench.Click += new System.EventHandler(this.btnCsrWorkBench_Click);
            // 
            // btnDataExplorer
            // 
            this.btnDataExplorer.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.btnDataExplorer.Font = new System.Drawing.Font("Cambria", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDataExplorer.Location = new System.Drawing.Point(359, 135);
            this.btnDataExplorer.Name = "btnDataExplorer";
            this.btnDataExplorer.Size = new System.Drawing.Size(120, 40);
            this.btnDataExplorer.TabIndex = 31;
            this.btnDataExplorer.Text = "Data Explorer";
            this.btnDataExplorer.UseVisualStyleBackColor = false;
            this.btnDataExplorer.Click += new System.EventHandler(this.btnDataExplorer_Click);
            // 
            // btnEcm
            // 
            this.btnEcm.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.btnEcm.Font = new System.Drawing.Font("Cambria", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEcm.Location = new System.Drawing.Point(477, 135);
            this.btnEcm.Name = "btnEcm";
            this.btnEcm.Size = new System.Drawing.Size(120, 40);
            this.btnEcm.TabIndex = 32;
            this.btnEcm.Text = "ECM";
            this.btnEcm.UseVisualStyleBackColor = false;
            this.btnEcm.Click += new System.EventHandler(this.btnEcm_Click);
            // 
            // btnEdpm
            // 
            this.btnEdpm.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.btnEdpm.Font = new System.Drawing.Font("Cambria", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEdpm.Location = new System.Drawing.Point(593, 135);
            this.btnEdpm.Name = "btnEdpm";
            this.btnEdpm.Size = new System.Drawing.Size(120, 40);
            this.btnEdpm.TabIndex = 33;
            this.btnEdpm.Text = "EDPM";
            this.btnEdpm.UseVisualStyleBackColor = false;
            this.btnEdpm.Click += new System.EventHandler(this.btnEdpm_Click);
            // 
            // btnFfrCalculator
            // 
            this.btnFfrCalculator.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.btnFfrCalculator.Font = new System.Drawing.Font("Cambria", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnFfrCalculator.Location = new System.Drawing.Point(706, 135);
            this.btnFfrCalculator.Name = "btnFfrCalculator";
            this.btnFfrCalculator.Size = new System.Drawing.Size(120, 40);
            this.btnFfrCalculator.TabIndex = 34;
            this.btnFfrCalculator.Text = "FFR Calculator";
            this.btnFfrCalculator.UseVisualStyleBackColor = false;
            this.btnFfrCalculator.Click += new System.EventHandler(this.btnFfrCalculator_Click);
            // 
            // btnFfrQuality
            // 
            this.btnFfrQuality.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.btnFfrQuality.Font = new System.Drawing.Font("Cambria", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnFfrQuality.Location = new System.Drawing.Point(823, 135);
            this.btnFfrQuality.Name = "btnFfrQuality";
            this.btnFfrQuality.Size = new System.Drawing.Size(120, 40);
            this.btnFfrQuality.TabIndex = 35;
            this.btnFfrQuality.Text = "FFR Quality";
            this.btnFfrQuality.UseVisualStyleBackColor = false;
            this.btnFfrQuality.Click += new System.EventHandler(this.btnFfrQuality_Click);
            // 
            // btnFoxPro
            // 
            this.btnFoxPro.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.btnFoxPro.Font = new System.Drawing.Font("Cambria", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnFoxPro.Location = new System.Drawing.Point(12, 172);
            this.btnFoxPro.Name = "btnFoxPro";
            this.btnFoxPro.Size = new System.Drawing.Size(120, 40);
            this.btnFoxPro.TabIndex = 36;
            this.btnFoxPro.Text = "FoxPro";
            this.btnFoxPro.UseVisualStyleBackColor = false;
            this.btnFoxPro.Click += new System.EventHandler(this.btnFoxPro_Click);
            // 
            // btnInstallBase
            // 
            this.btnInstallBase.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.btnInstallBase.Font = new System.Drawing.Font("Cambria", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnInstallBase.Location = new System.Drawing.Point(126, 172);
            this.btnInstallBase.Name = "btnInstallBase";
            this.btnInstallBase.Size = new System.Drawing.Size(120, 40);
            this.btnInstallBase.TabIndex = 37;
            this.btnInstallBase.Text = "Install Base";
            this.btnInstallBase.UseVisualStyleBackColor = false;
            this.btnInstallBase.Click += new System.EventHandler(this.btnInstallBase_Click);
            // 
            // btnKeiWebApps
            // 
            this.btnKeiWebApps.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.btnKeiWebApps.Font = new System.Drawing.Font("Cambria", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnKeiWebApps.Location = new System.Drawing.Point(243, 172);
            this.btnKeiWebApps.Name = "btnKeiWebApps";
            this.btnKeiWebApps.Size = new System.Drawing.Size(120, 40);
            this.btnKeiWebApps.TabIndex = 38;
            this.btnKeiWebApps.Text = "KEI WebApps";
            this.btnKeiWebApps.UseVisualStyleBackColor = false;
            this.btnKeiWebApps.Click += new System.EventHandler(this.btnKeiWebApps_Click);
            // 
            // btnOmar
            // 
            this.btnOmar.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.btnOmar.Font = new System.Drawing.Font("Cambria", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnOmar.Location = new System.Drawing.Point(359, 172);
            this.btnOmar.Name = "btnOmar";
            this.btnOmar.Size = new System.Drawing.Size(120, 40);
            this.btnOmar.TabIndex = 39;
            this.btnOmar.Text = "OMAR";
            this.btnOmar.UseVisualStyleBackColor = false;
            this.btnOmar.Click += new System.EventHandler(this.btnOmar_Click);
            // 
            // btnOracleMfg
            // 
            this.btnOracleMfg.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.btnOracleMfg.Font = new System.Drawing.Font("Cambria", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnOracleMfg.Location = new System.Drawing.Point(477, 172);
            this.btnOracleMfg.Name = "btnOracleMfg";
            this.btnOracleMfg.Size = new System.Drawing.Size(120, 40);
            this.btnOracleMfg.TabIndex = 40;
            this.btnOracleMfg.Text = "Oracle MFG";
            this.btnOracleMfg.UseVisualStyleBackColor = false;
            this.btnOracleMfg.Click += new System.EventHandler(this.btnOracleMfg_Click);
            // 
            // btnOut
            // 
            this.btnOut.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.btnOut.Font = new System.Drawing.Font("Cambria", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnOut.Location = new System.Drawing.Point(593, 172);
            this.btnOut.Name = "btnOut";
            this.btnOut.Size = new System.Drawing.Size(120, 40);
            this.btnOut.TabIndex = 41;
            this.btnOut.Text = "OUT";
            this.btnOut.UseVisualStyleBackColor = false;
            this.btnOut.Click += new System.EventHandler(this.btnOut_Click);
            // 
            // btnOutQuery
            // 
            this.btnOutQuery.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.btnOutQuery.Font = new System.Drawing.Font("Cambria", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnOutQuery.Location = new System.Drawing.Point(706, 172);
            this.btnOutQuery.Name = "btnOutQuery";
            this.btnOutQuery.Size = new System.Drawing.Size(120, 40);
            this.btnOutQuery.TabIndex = 42;
            this.btnOutQuery.Text = "OUT Query";
            this.btnOutQuery.UseVisualStyleBackColor = false;
            this.btnOutQuery.Click += new System.EventHandler(this.btnOutQuery_Click);
            // 
            // btnPfListBySwimLane
            // 
            this.btnPfListBySwimLane.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.btnPfListBySwimLane.Font = new System.Drawing.Font("Cambria", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnPfListBySwimLane.Location = new System.Drawing.Point(823, 172);
            this.btnPfListBySwimLane.Name = "btnPfListBySwimLane";
            this.btnPfListBySwimLane.Size = new System.Drawing.Size(120, 40);
            this.btnPfListBySwimLane.TabIndex = 43;
            this.btnPfListBySwimLane.Text = "PF List by SwimLane";
            this.btnPfListBySwimLane.UseVisualStyleBackColor = false;
            this.btnPfListBySwimLane.Click += new System.EventHandler(this.btnPfListBySwimLane_Click);
            // 
            // btnPlsqlDeveloper
            // 
            this.btnPlsqlDeveloper.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.btnPlsqlDeveloper.Font = new System.Drawing.Font("Cambria", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnPlsqlDeveloper.Location = new System.Drawing.Point(12, 209);
            this.btnPlsqlDeveloper.Name = "btnPlsqlDeveloper";
            this.btnPlsqlDeveloper.Size = new System.Drawing.Size(120, 40);
            this.btnPlsqlDeveloper.TabIndex = 44;
            this.btnPlsqlDeveloper.Text = "PLSQL Developer";
            this.btnPlsqlDeveloper.UseVisualStyleBackColor = false;
            this.btnPlsqlDeveloper.Click += new System.EventHandler(this.btnPlsqlDeveloper_Click);
            // 
            // btnPortfolioPage
            // 
            this.btnPortfolioPage.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.btnPortfolioPage.Font = new System.Drawing.Font("Cambria", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnPortfolioPage.Location = new System.Drawing.Point(126, 209);
            this.btnPortfolioPage.Name = "btnPortfolioPage";
            this.btnPortfolioPage.Size = new System.Drawing.Size(120, 40);
            this.btnPortfolioPage.TabIndex = 45;
            this.btnPortfolioPage.Text = "Portfolio Page";
            this.btnPortfolioPage.UseVisualStyleBackColor = false;
            this.btnPortfolioPage.Click += new System.EventHandler(this.btnPortfolioPage_Click);
            // 
            // btnPriceAdmin
            // 
            this.btnPriceAdmin.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.btnPriceAdmin.Font = new System.Drawing.Font("Cambria", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnPriceAdmin.Location = new System.Drawing.Point(243, 209);
            this.btnPriceAdmin.Name = "btnPriceAdmin";
            this.btnPriceAdmin.Size = new System.Drawing.Size(120, 40);
            this.btnPriceAdmin.TabIndex = 46;
            this.btnPriceAdmin.Text = "Price Admin";
            this.btnPriceAdmin.UseVisualStyleBackColor = false;
            this.btnPriceAdmin.Click += new System.EventHandler(this.btnPriceAdmin_Click);
            // 
            // btnRpdb
            // 
            this.btnRpdb.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.btnRpdb.Font = new System.Drawing.Font("Cambria", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnRpdb.Location = new System.Drawing.Point(359, 210);
            this.btnRpdb.Name = "btnRpdb";
            this.btnRpdb.Size = new System.Drawing.Size(120, 40);
            this.btnRpdb.TabIndex = 47;
            this.btnRpdb.Text = "RPDB";
            this.btnRpdb.UseVisualStyleBackColor = false;
            this.btnRpdb.Click += new System.EventHandler(this.btnRpdb_Click);
            // 
            // btnSpsSharepoint
            // 
            this.btnSpsSharepoint.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.btnSpsSharepoint.Font = new System.Drawing.Font("Cambria", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSpsSharepoint.Location = new System.Drawing.Point(477, 209);
            this.btnSpsSharepoint.Name = "btnSpsSharepoint";
            this.btnSpsSharepoint.Size = new System.Drawing.Size(120, 40);
            this.btnSpsSharepoint.TabIndex = 48;
            this.btnSpsSharepoint.Text = "SPS Sharepoint";
            this.btnSpsSharepoint.UseVisualStyleBackColor = false;
            this.btnSpsSharepoint.Click += new System.EventHandler(this.btnSpsSharepoint_Click);
            // 
            // btnSqlAvgCalCostProduct
            // 
            this.btnSqlAvgCalCostProduct.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.btnSqlAvgCalCostProduct.Font = new System.Drawing.Font("Cambria", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSqlAvgCalCostProduct.Location = new System.Drawing.Point(593, 210);
            this.btnSqlAvgCalCostProduct.Name = "btnSqlAvgCalCostProduct";
            this.btnSqlAvgCalCostProduct.Size = new System.Drawing.Size(120, 40);
            this.btnSqlAvgCalCostProduct.TabIndex = 49;
            this.btnSqlAvgCalCostProduct.Text = "SQL Avg Cal Cost Product";
            this.btnSqlAvgCalCostProduct.UseVisualStyleBackColor = false;
            this.btnSqlAvgCalCostProduct.Click += new System.EventHandler(this.btnSqlAvgCalCostProduct_Click);
            // 
            // btnSqlCalReturnRateProduct
            // 
            this.btnSqlCalReturnRateProduct.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.btnSqlCalReturnRateProduct.Font = new System.Drawing.Font("Cambria", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSqlCalReturnRateProduct.Location = new System.Drawing.Point(706, 210);
            this.btnSqlCalReturnRateProduct.Name = "btnSqlCalReturnRateProduct";
            this.btnSqlCalReturnRateProduct.Size = new System.Drawing.Size(120, 40);
            this.btnSqlCalReturnRateProduct.TabIndex = 50;
            this.btnSqlCalReturnRateProduct.Text = "SQL Cal Return Rate Product";
            this.btnSqlCalReturnRateProduct.UseVisualStyleBackColor = false;
            this.btnSqlCalReturnRateProduct.Click += new System.EventHandler(this.btnSqlCalReturnRateProduct_Click);
            // 
            // btnSqlInstallBase
            // 
            this.btnSqlInstallBase.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.btnSqlInstallBase.Font = new System.Drawing.Font("Cambria", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSqlInstallBase.Location = new System.Drawing.Point(823, 210);
            this.btnSqlInstallBase.Name = "btnSqlInstallBase";
            this.btnSqlInstallBase.Size = new System.Drawing.Size(120, 40);
            this.btnSqlInstallBase.TabIndex = 51;
            this.btnSqlInstallBase.Text = "SQL Install Base";
            this.btnSqlInstallBase.UseVisualStyleBackColor = false;
            this.btnSqlInstallBase.Click += new System.EventHandler(this.btnSqlInstallBase_Click);
            // 
            // btnSqlPartUsage
            // 
            this.btnSqlPartUsage.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.btnSqlPartUsage.Font = new System.Drawing.Font("Cambria", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSqlPartUsage.Location = new System.Drawing.Point(12, 246);
            this.btnSqlPartUsage.Name = "btnSqlPartUsage";
            this.btnSqlPartUsage.Size = new System.Drawing.Size(120, 40);
            this.btnSqlPartUsage.TabIndex = 52;
            this.btnSqlPartUsage.Text = "SQL Part Usage";
            this.btnSqlPartUsage.UseVisualStyleBackColor = false;
            this.btnSqlPartUsage.Click += new System.EventHandler(this.btnSqlPartUsage_Click);
            // 
            // btnSqlPartsPricingHistory
            // 
            this.btnSqlPartsPricingHistory.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.btnSqlPartsPricingHistory.Font = new System.Drawing.Font("Cambria", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSqlPartsPricingHistory.Location = new System.Drawing.Point(126, 246);
            this.btnSqlPartsPricingHistory.Name = "btnSqlPartsPricingHistory";
            this.btnSqlPartsPricingHistory.Size = new System.Drawing.Size(120, 40);
            this.btnSqlPartsPricingHistory.TabIndex = 53;
            this.btnSqlPartsPricingHistory.Text = "SQL Parts Pricing History";
            this.btnSqlPartsPricingHistory.UseVisualStyleBackColor = false;
            this.btnSqlPartsPricingHistory.Click += new System.EventHandler(this.btnSqlPartsPricingHistory_Click);
            // 
            // btnSqlSvcActivityProduct
            // 
            this.btnSqlSvcActivityProduct.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.btnSqlSvcActivityProduct.Font = new System.Drawing.Font("Cambria", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSqlSvcActivityProduct.Location = new System.Drawing.Point(243, 246);
            this.btnSqlSvcActivityProduct.Name = "btnSqlSvcActivityProduct";
            this.btnSqlSvcActivityProduct.Size = new System.Drawing.Size(120, 40);
            this.btnSqlSvcActivityProduct.TabIndex = 54;
            this.btnSqlSvcActivityProduct.Text = "SQL Svc Activity Product";
            this.btnSqlSvcActivityProduct.UseVisualStyleBackColor = false;
            this.btnSqlSvcActivityProduct.Click += new System.EventHandler(this.btnSqlSvcActivityProduct_Click);
            // 
            // btnSqlSvcContractPricingHistory
            // 
            this.btnSqlSvcContractPricingHistory.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.btnSqlSvcContractPricingHistory.Font = new System.Drawing.Font("Cambria", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSqlSvcContractPricingHistory.Location = new System.Drawing.Point(359, 246);
            this.btnSqlSvcContractPricingHistory.Name = "btnSqlSvcContractPricingHistory";
            this.btnSqlSvcContractPricingHistory.Size = new System.Drawing.Size(120, 40);
            this.btnSqlSvcContractPricingHistory.TabIndex = 55;
            this.btnSqlSvcContractPricingHistory.Text = "SQL Svc Contract Pricing History";
            this.btnSqlSvcContractPricingHistory.UseVisualStyleBackColor = false;
            this.btnSqlSvcContractPricingHistory.Click += new System.EventHandler(this.btnSqlSvcContractPricingHistory_Click);
            // 
            // btnSqlSvcPricingHistory
            // 
            this.btnSqlSvcPricingHistory.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.btnSqlSvcPricingHistory.Font = new System.Drawing.Font("Cambria", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSqlSvcPricingHistory.Location = new System.Drawing.Point(477, 246);
            this.btnSqlSvcPricingHistory.Name = "btnSqlSvcPricingHistory";
            this.btnSqlSvcPricingHistory.Size = new System.Drawing.Size(120, 40);
            this.btnSqlSvcPricingHistory.TabIndex = 56;
            this.btnSqlSvcPricingHistory.Text = "SQL Svc Pricing History";
            this.btnSqlSvcPricingHistory.UseVisualStyleBackColor = false;
            this.btnSqlSvcPricingHistory.Click += new System.EventHandler(this.btnSqlSvcPricingHistory_Click);
            // 
            // btnStockPlacesAndLocations
            // 
            this.btnStockPlacesAndLocations.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.btnStockPlacesAndLocations.Font = new System.Drawing.Font("Cambria", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnStockPlacesAndLocations.Location = new System.Drawing.Point(593, 246);
            this.btnStockPlacesAndLocations.Name = "btnStockPlacesAndLocations";
            this.btnStockPlacesAndLocations.Size = new System.Drawing.Size(120, 40);
            this.btnStockPlacesAndLocations.TabIndex = 57;
            this.btnStockPlacesAndLocations.Text = "Stock Places and Locations";
            this.btnStockPlacesAndLocations.UseVisualStyleBackColor = false;
            this.btnStockPlacesAndLocations.Click += new System.EventHandler(this.btnStockPlacesAndLocations_Click);
            // 
            // btnTekHome
            // 
            this.btnTekHome.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.btnTekHome.Font = new System.Drawing.Font("Cambria", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnTekHome.Location = new System.Drawing.Point(706, 246);
            this.btnTekHome.Name = "btnTekHome";
            this.btnTekHome.Size = new System.Drawing.Size(120, 40);
            this.btnTekHome.TabIndex = 58;
            this.btnTekHome.Text = "Tek Home";
            this.btnTekHome.UseVisualStyleBackColor = false;
            this.btnTekHome.Click += new System.EventHandler(this.btnTekHome_Click);
            // 
            // btnTekItemQuery
            // 
            this.btnTekItemQuery.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.btnTekItemQuery.Font = new System.Drawing.Font("Cambria", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnTekItemQuery.Location = new System.Drawing.Point(823, 246);
            this.btnTekItemQuery.Name = "btnTekItemQuery";
            this.btnTekItemQuery.Size = new System.Drawing.Size(120, 40);
            this.btnTekItemQuery.TabIndex = 59;
            this.btnTekItemQuery.Text = "Tek Item Query";
            this.btnTekItemQuery.UseVisualStyleBackColor = false;
            this.btnTekItemQuery.Click += new System.EventHandler(this.btnTekItemQuery_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Cambria", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(12, 10);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(91, 19);
            this.label2.TabIndex = 60;
            this.label2.Text = "Last Clicked";
            // 
            // btnLastClicked
            // 
            this.btnLastClicked.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.btnLastClicked.Font = new System.Drawing.Font("Cambria", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLastClicked.Location = new System.Drawing.Point(12, 32);
            this.btnLastClicked.Name = "btnLastClicked";
            this.btnLastClicked.Size = new System.Drawing.Size(120, 40);
            this.btnLastClicked.TabIndex = 61;
            this.btnLastClicked.Text = "Last Clicked";
            this.btnLastClicked.UseVisualStyleBackColor = false;
            this.btnLastClicked.Click += new System.EventHandler(this.btnLastClicked_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Menu;
            this.ClientSize = new System.Drawing.Size(957, 301);
            this.Controls.Add(this.btnLastClicked);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.btnTekItemQuery);
            this.Controls.Add(this.btnTekHome);
            this.Controls.Add(this.btnStockPlacesAndLocations);
            this.Controls.Add(this.btnSqlSvcPricingHistory);
            this.Controls.Add(this.btnSqlSvcContractPricingHistory);
            this.Controls.Add(this.btnSqlSvcActivityProduct);
            this.Controls.Add(this.btnSqlPartsPricingHistory);
            this.Controls.Add(this.btnSqlPartUsage);
            this.Controls.Add(this.btnSqlInstallBase);
            this.Controls.Add(this.btnSqlCalReturnRateProduct);
            this.Controls.Add(this.btnSqlAvgCalCostProduct);
            this.Controls.Add(this.btnSpsSharepoint);
            this.Controls.Add(this.btnRpdb);
            this.Controls.Add(this.btnPriceAdmin);
            this.Controls.Add(this.btnPortfolioPage);
            this.Controls.Add(this.btnPlsqlDeveloper);
            this.Controls.Add(this.btnPfListBySwimLane);
            this.Controls.Add(this.btnOutQuery);
            this.Controls.Add(this.btnOut);
            this.Controls.Add(this.btnOracleMfg);
            this.Controls.Add(this.btnOmar);
            this.Controls.Add(this.btnKeiWebApps);
            this.Controls.Add(this.btnInstallBase);
            this.Controls.Add(this.btnFoxPro);
            this.Controls.Add(this.btnFfrQuality);
            this.Controls.Add(this.btnFfrCalculator);
            this.Controls.Add(this.btnEdpm);
            this.Controls.Add(this.btnEcm);
            this.Controls.Add(this.btnDataExplorer);
            this.Controls.Add(this.btnCsrWorkBench);
            this.Controls.Add(this.btnCbom);
            this.Controls.Add(this.btnBomComparison);
            this.Controls.Add(this.lblZ);
            this.Controls.Add(this.lblY);
            this.Controls.Add(this.lblX);
            this.Controls.Add(this.lblW);
            this.Controls.Add(this.lblV);
            this.Controls.Add(this.lblU);
            this.Controls.Add(this.lblT);
            this.Controls.Add(this.lblS);
            this.Controls.Add(this.lblR);
            this.Controls.Add(this.lblQ);
            this.Controls.Add(this.lblP);
            this.Controls.Add(this.lblO);
            this.Controls.Add(this.lblN);
            this.Controls.Add(this.lblM);
            this.Controls.Add(this.lblL);
            this.Controls.Add(this.lblK);
            this.Controls.Add(this.lblJ);
            this.Controls.Add(this.lblI);
            this.Controls.Add(this.lblH);
            this.Controls.Add(this.lblG);
            this.Controls.Add(this.lblF);
            this.Controls.Add(this.lblE);
            this.Controls.Add(this.lblD);
            this.Controls.Add(this.lblC);
            this.Controls.Add(this.lblB);
            this.Controls.Add(this.lblA);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtSearch);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.Name = "Form1";
            this.Opacity = 0.98D;
            this.Text = "SPS TOOLBOX";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtSearch;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.LinkLabel lblA;
        private System.Windows.Forms.LinkLabel lblB;
        private System.Windows.Forms.LinkLabel lblC;
        private System.Windows.Forms.LinkLabel lblD;
        private System.Windows.Forms.LinkLabel lblE;
        private System.Windows.Forms.LinkLabel lblF;
        private System.Windows.Forms.LinkLabel lblG;
        private System.Windows.Forms.LinkLabel lblH;
        private System.Windows.Forms.LinkLabel lblI;
        private System.Windows.Forms.LinkLabel lblJ;
        private System.Windows.Forms.LinkLabel lblK;
        private System.Windows.Forms.LinkLabel lblL;
        private System.Windows.Forms.LinkLabel lblM;
        private System.Windows.Forms.LinkLabel lblN;
        private System.Windows.Forms.LinkLabel lblO;
        private System.Windows.Forms.LinkLabel lblP;
        private System.Windows.Forms.LinkLabel lblQ;
        private System.Windows.Forms.LinkLabel lblR;
        private System.Windows.Forms.LinkLabel lblS;
        private System.Windows.Forms.LinkLabel lblT;
        private System.Windows.Forms.LinkLabel lblU;
        private System.Windows.Forms.LinkLabel lblV;
        private System.Windows.Forms.LinkLabel lblW;
        private System.Windows.Forms.LinkLabel lblX;
        private System.Windows.Forms.LinkLabel lblY;
        private System.Windows.Forms.LinkLabel lblZ;
        private System.Windows.Forms.Button btnBomComparison;
        private System.Windows.Forms.Button btnCbom;
        private System.Windows.Forms.Button btnCsrWorkBench;
        private System.Windows.Forms.Button btnDataExplorer;
        private System.Windows.Forms.Button btnEcm;
        private System.Windows.Forms.Button btnEdpm;
        private System.Windows.Forms.Button btnFfrCalculator;
        private System.Windows.Forms.Button btnFfrQuality;
        private System.Windows.Forms.Button btnFoxPro;
        private System.Windows.Forms.Button btnInstallBase;
        private System.Windows.Forms.Button btnKeiWebApps;
        private System.Windows.Forms.Button btnOmar;
        private System.Windows.Forms.Button btnOracleMfg;
        private System.Windows.Forms.Button btnOut;
        private System.Windows.Forms.Button btnOutQuery;
        private System.Windows.Forms.Button btnPfListBySwimLane;
        private System.Windows.Forms.Button btnPlsqlDeveloper;
        private System.Windows.Forms.Button btnPortfolioPage;
        private System.Windows.Forms.Button btnPriceAdmin;
        private System.Windows.Forms.Button btnRpdb;
        private System.Windows.Forms.Button btnSpsSharepoint;
        private System.Windows.Forms.Button btnSqlAvgCalCostProduct;
        private System.Windows.Forms.Button btnSqlCalReturnRateProduct;
        private System.Windows.Forms.Button btnSqlInstallBase;
        private System.Windows.Forms.Button btnSqlPartUsage;
        private System.Windows.Forms.Button btnSqlPartsPricingHistory;
        private System.Windows.Forms.Button btnSqlSvcActivityProduct;
        private System.Windows.Forms.Button btnSqlSvcContractPricingHistory;
        private System.Windows.Forms.Button btnSqlSvcPricingHistory;
        private System.Windows.Forms.Button btnStockPlacesAndLocations;
        private System.Windows.Forms.Button btnTekHome;
        private System.Windows.Forms.Button btnTekItemQuery;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btnLastClicked;
    }
}

