using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace TradingCalculator
{
    partial class MainForm
    {
        #region Windows Form Designer generated code
        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        /// 

        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.fileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.aboutToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.exitToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.gbWorkSpace = new System.Windows.Forms.GroupBox();
            this.lblCopyright = new System.Windows.Forms.Label();
            this.btnClose = new System.Windows.Forms.Button();
            this.txtAvgPrice = new System.Windows.Forms.TextBox();
            this.txtOpenQty = new System.Windows.Forms.TextBox();
            this.lblCaption = new System.Windows.Forms.Label();
            this.btnClearAll = new System.Windows.Forms.Button();
            this.gbAvgDown = new System.Windows.Forms.GroupBox();
            this.avgDownPercLiteral = new System.Windows.Forms.Label();
            this.txtAvgDownPercent = new System.Windows.Forms.TextBox();
            this.lblPriceTargetCustom = new System.Windows.Forms.Label();
            this.lblCustom = new System.Windows.Forms.Label();
            this.lblPriceTarget4 = new System.Windows.Forms.Label();
            this.lblPriceTarget3 = new System.Windows.Forms.Label();
            this.lblPriceTarget2 = new System.Windows.Forms.Label();
            this.lblPriceTarget1 = new System.Windows.Forms.Label();
            this.lblPriceTarget = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.lblAvgDown4 = new System.Windows.Forms.Label();
            this.lblAvgDown3 = new System.Windows.Forms.Label();
            this.lblAvgDown2 = new System.Windows.Forms.Label();
            this.lblAvgDown1 = new System.Windows.Forms.Label();
            this.gbTakeProfit = new System.Windows.Forms.GroupBox();
            this.lblTotalProjProfit = new System.Windows.Forms.Label();
            this.lblCloseQty = new System.Windows.Forms.Label();
            this.lblTotalProfit = new System.Windows.Forms.Label();
            this.lblcty = new System.Windows.Forms.Label();
            this.lblReinvestedAmt = new System.Windows.Forms.Label();
            this.lblReinvest = new System.Windows.Forms.Label();
            this.gbReinvestProfit = new System.Windows.Forms.GroupBox();
            this.lblQuantityReinvested = new System.Windows.Forms.Label();
            this.lblQR = new System.Windows.Forms.Label();
            this.txtProfitPercent = new System.Windows.Forms.TextBox();
            this.lblPPercent = new System.Windows.Forms.Label();
            this.lblProjProfit = new System.Windows.Forms.Label();
            this.lblLimitSellAt = new System.Windows.Forms.Label();
            this.lblEstP = new System.Windows.Forms.Label();
            this.chkReinvestProfit = new System.Windows.Forms.CheckBox();
            this.lblTpa = new System.Windows.Forms.Label();
            this.lblProfitPercent = new System.Windows.Forms.Label();
            this.cboPercents = new System.Windows.Forms.ComboBox();
            this.lblAvgPrice = new System.Windows.Forms.Label();
            this.lblOpenQty = new System.Windows.Forms.Label();
            this.ttipOpenQty = new System.Windows.Forms.ToolTip(this.components);
            this.ttipAvgPrice = new System.Windows.Forms.ToolTip(this.components);
            this.ttipCustomPercent = new System.Windows.Forms.ToolTip(this.components);
            this.ttipPriceChangePercent = new System.Windows.Forms.ToolTip(this.components);
            this.ttipProfitPercent = new System.Windows.Forms.ToolTip(this.components);
            this.menuStrip1.SuspendLayout();
            this.gbWorkSpace.SuspendLayout();
            this.gbAvgDown.SuspendLayout();
            this.gbTakeProfit.SuspendLayout();
            this.gbReinvestProfit.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fileToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(508, 24);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // fileToolStripMenuItem
            // 
            this.fileToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.aboutToolStripMenuItem,
            this.exitToolStripMenuItem});
            this.fileToolStripMenuItem.Name = "fileToolStripMenuItem";
            this.fileToolStripMenuItem.Size = new System.Drawing.Size(37, 20);
            this.fileToolStripMenuItem.Text = "File";
            // 
            // aboutToolStripMenuItem
            // 
            this.aboutToolStripMenuItem.Name = "aboutToolStripMenuItem";
            this.aboutToolStripMenuItem.Size = new System.Drawing.Size(181, 22);
            this.aboutToolStripMenuItem.Text = "About - (InProgress)";
            // 
            // exitToolStripMenuItem
            // 
            this.exitToolStripMenuItem.Name = "exitToolStripMenuItem";
            this.exitToolStripMenuItem.Size = new System.Drawing.Size(181, 22);
            this.exitToolStripMenuItem.Text = "Exit";
            this.exitToolStripMenuItem.Click += new System.EventHandler(this.CloseForm);
            // 
            // gbWorkSpace
            // 
            this.gbWorkSpace.Controls.Add(this.lblCopyright);
            this.gbWorkSpace.Controls.Add(this.btnClose);
            this.gbWorkSpace.Controls.Add(this.txtAvgPrice);
            this.gbWorkSpace.Controls.Add(this.txtOpenQty);
            this.gbWorkSpace.Controls.Add(this.lblCaption);
            this.gbWorkSpace.Controls.Add(this.btnClearAll);
            this.gbWorkSpace.Controls.Add(this.gbAvgDown);
            this.gbWorkSpace.Controls.Add(this.gbTakeProfit);
            this.gbWorkSpace.Controls.Add(this.lblAvgPrice);
            this.gbWorkSpace.Controls.Add(this.lblOpenQty);
            this.gbWorkSpace.Location = new System.Drawing.Point(12, 27);
            this.gbWorkSpace.Name = "gbWorkSpace";
            this.gbWorkSpace.Size = new System.Drawing.Size(492, 392);
            this.gbWorkSpace.TabIndex = 2;
            this.gbWorkSpace.TabStop = false;
            this.gbWorkSpace.Text = "Workspace ";
            // 
            // lblCopyright
            // 
            this.lblCopyright.AutoSize = true;
            this.lblCopyright.Font = new System.Drawing.Font("Microsoft Sans Serif", 6F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCopyright.Location = new System.Drawing.Point(420, 383);
            this.lblCopyright.Name = "lblCopyright";
            this.lblCopyright.Size = new System.Drawing.Size(72, 9);
            this.lblCopyright.TabIndex = 13;
            this.lblCopyright.Text = "_dehydratedCoder™";
            // 
            // btnClose
            // 
            this.btnClose.Location = new System.Drawing.Point(395, 344);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(75, 23);
            this.btnClose.TabIndex = 12;
            this.btnClose.Text = "Close";
            this.btnClose.UseVisualStyleBackColor = true;
            this.btnClose.Click += new System.EventHandler(this.CloseForm);
            // 
            // txtAvgPrice
            // 
            this.txtAvgPrice.Location = new System.Drawing.Point(82, 62);
            this.txtAvgPrice.Name = "txtAvgPrice";
            this.txtAvgPrice.Size = new System.Drawing.Size(72, 20);
            this.txtAvgPrice.TabIndex = 11;
            this.txtAvgPrice.TextChanged += new System.EventHandler(this.AvgPriceTextChanged);
            // 
            // txtOpenQty
            // 
            this.txtOpenQty.Location = new System.Drawing.Point(82, 35);
            this.txtOpenQty.Name = "txtOpenQty";
            this.txtOpenQty.Size = new System.Drawing.Size(56, 20);
            this.txtOpenQty.TabIndex = 10;
            this.txtOpenQty.TextChanged += new System.EventHandler(this.OpenQtyTextChanged);
            // 
            // lblCaption
            // 
            this.lblCaption.AutoSize = true;
            this.lblCaption.ForeColor = System.Drawing.Color.DimGray;
            this.lblCaption.Location = new System.Drawing.Point(20, 349);
            this.lblCaption.Name = "lblCaption";
            this.lblCaption.Size = new System.Drawing.Size(111, 13);
            this.lblCaption.TabIndex = 9;
            this.lblCaption.Text = "*All figures are in USD";
            // 
            // btnClearAll
            // 
            this.btnClearAll.Location = new System.Drawing.Point(303, 344);
            this.btnClearAll.Name = "btnClearAll";
            this.btnClearAll.Size = new System.Drawing.Size(75, 23);
            this.btnClearAll.TabIndex = 8;
            this.btnClearAll.Text = "Clear All";
            this.btnClearAll.UseVisualStyleBackColor = true;
            // 
            // gbAvgDown
            // 
            this.gbAvgDown.Controls.Add(this.avgDownPercLiteral);
            this.gbAvgDown.Controls.Add(this.txtAvgDownPercent);
            this.gbAvgDown.Controls.Add(this.lblPriceTargetCustom);
            this.gbAvgDown.Controls.Add(this.lblCustom);
            this.gbAvgDown.Controls.Add(this.lblPriceTarget4);
            this.gbAvgDown.Controls.Add(this.lblPriceTarget3);
            this.gbAvgDown.Controls.Add(this.lblPriceTarget2);
            this.gbAvgDown.Controls.Add(this.lblPriceTarget1);
            this.gbAvgDown.Controls.Add(this.lblPriceTarget);
            this.gbAvgDown.Controls.Add(this.label1);
            this.gbAvgDown.Controls.Add(this.lblAvgDown4);
            this.gbAvgDown.Controls.Add(this.lblAvgDown3);
            this.gbAvgDown.Controls.Add(this.lblAvgDown2);
            this.gbAvgDown.Controls.Add(this.lblAvgDown1);
            this.gbAvgDown.Enabled = false;
            this.gbAvgDown.Location = new System.Drawing.Point(23, 101);
            this.gbAvgDown.Name = "gbAvgDown";
            this.gbAvgDown.Size = new System.Drawing.Size(188, 232);
            this.gbAvgDown.TabIndex = 7;
            this.gbAvgDown.TabStop = false;
            this.gbAvgDown.Text = "Average Down";
            // 
            // avgDownPercLiteral
            // 
            this.avgDownPercLiteral.AutoSize = true;
            this.avgDownPercLiteral.Location = new System.Drawing.Point(56, 184);
            this.avgDownPercLiteral.Name = "avgDownPercLiteral";
            this.avgDownPercLiteral.Size = new System.Drawing.Size(15, 13);
            this.avgDownPercLiteral.TabIndex = 14;
            this.avgDownPercLiteral.Text = "%";
            // 
            // txtAvgDownPercent
            // 
            this.txtAvgDownPercent.Location = new System.Drawing.Point(9, 181);
            this.txtAvgDownPercent.Name = "txtAvgDownPercent";
            this.txtAvgDownPercent.Size = new System.Drawing.Size(42, 20);
            this.txtAvgDownPercent.TabIndex = 13;
            this.txtAvgDownPercent.TextChanged += new System.EventHandler(this.CustomPercentTextChanged);
            // 
            // lblPriceTargetCustom
            // 
            this.lblPriceTargetCustom.AutoSize = true;
            this.lblPriceTargetCustom.Location = new System.Drawing.Point(80, 184);
            this.lblPriceTargetCustom.Name = "lblPriceTargetCustom";
            this.lblPriceTargetCustom.Size = new System.Drawing.Size(19, 13);
            this.lblPriceTargetCustom.TabIndex = 12;
            this.lblPriceTargetCustom.Text = "$0";
            // 
            // lblCustom
            // 
            this.lblCustom.AutoSize = true;
            this.lblCustom.Location = new System.Drawing.Point(6, 162);
            this.lblCustom.Name = "lblCustom";
            this.lblCustom.Size = new System.Drawing.Size(48, 13);
            this.lblCustom.TabIndex = 10;
            this.lblCustom.Text = "Custom :";
            // 
            // lblPriceTarget4
            // 
            this.lblPriceTarget4.AutoSize = true;
            this.lblPriceTarget4.Location = new System.Drawing.Point(80, 129);
            this.lblPriceTarget4.Name = "lblPriceTarget4";
            this.lblPriceTarget4.Size = new System.Drawing.Size(19, 13);
            this.lblPriceTarget4.TabIndex = 9;
            this.lblPriceTarget4.Text = "$0";
            // 
            // lblPriceTarget3
            // 
            this.lblPriceTarget3.AutoSize = true;
            this.lblPriceTarget3.Location = new System.Drawing.Point(80, 102);
            this.lblPriceTarget3.Name = "lblPriceTarget3";
            this.lblPriceTarget3.Size = new System.Drawing.Size(19, 13);
            this.lblPriceTarget3.TabIndex = 8;
            this.lblPriceTarget3.Text = "$0";
            // 
            // lblPriceTarget2
            // 
            this.lblPriceTarget2.AutoSize = true;
            this.lblPriceTarget2.Location = new System.Drawing.Point(80, 77);
            this.lblPriceTarget2.Name = "lblPriceTarget2";
            this.lblPriceTarget2.Size = new System.Drawing.Size(19, 13);
            this.lblPriceTarget2.TabIndex = 7;
            this.lblPriceTarget2.Text = "$0";
            // 
            // lblPriceTarget1
            // 
            this.lblPriceTarget1.AutoSize = true;
            this.lblPriceTarget1.Location = new System.Drawing.Point(80, 52);
            this.lblPriceTarget1.Name = "lblPriceTarget1";
            this.lblPriceTarget1.Size = new System.Drawing.Size(19, 13);
            this.lblPriceTarget1.TabIndex = 6;
            this.lblPriceTarget1.Text = "$0";
            // 
            // lblPriceTarget
            // 
            this.lblPriceTarget.AutoSize = true;
            this.lblPriceTarget.Location = new System.Drawing.Point(80, 26);
            this.lblPriceTarget.Name = "lblPriceTarget";
            this.lblPriceTarget.Size = new System.Drawing.Size(73, 13);
            this.lblPriceTarget.TabIndex = 5;
            this.lblPriceTarget.Text = "Price Targets:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(6, 26);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(47, 13);
            this.label1.TabIndex = 4;
            this.label1.Text = "Percent:";
            // 
            // lblAvgDown4
            // 
            this.lblAvgDown4.AutoSize = true;
            this.lblAvgDown4.Location = new System.Drawing.Point(5, 129);
            this.lblAvgDown4.Name = "lblAvgDown4";
            this.lblAvgDown4.Size = new System.Drawing.Size(27, 13);
            this.lblAvgDown4.TabIndex = 3;
            this.lblAvgDown4.Text = "40%";
            // 
            // lblAvgDown3
            // 
            this.lblAvgDown3.AutoSize = true;
            this.lblAvgDown3.Location = new System.Drawing.Point(6, 102);
            this.lblAvgDown3.Name = "lblAvgDown3";
            this.lblAvgDown3.Size = new System.Drawing.Size(27, 13);
            this.lblAvgDown3.TabIndex = 2;
            this.lblAvgDown3.Text = "30%";
            // 
            // lblAvgDown2
            // 
            this.lblAvgDown2.AutoSize = true;
            this.lblAvgDown2.Location = new System.Drawing.Point(6, 77);
            this.lblAvgDown2.Name = "lblAvgDown2";
            this.lblAvgDown2.Size = new System.Drawing.Size(27, 13);
            this.lblAvgDown2.TabIndex = 1;
            this.lblAvgDown2.Text = "20%";
            // 
            // lblAvgDown1
            // 
            this.lblAvgDown1.AutoSize = true;
            this.lblAvgDown1.Location = new System.Drawing.Point(6, 52);
            this.lblAvgDown1.Name = "lblAvgDown1";
            this.lblAvgDown1.Size = new System.Drawing.Size(27, 13);
            this.lblAvgDown1.TabIndex = 0;
            this.lblAvgDown1.Text = "10%";
            // 
            // gbTakeProfit
            // 
            this.gbTakeProfit.Controls.Add(this.lblTotalProjProfit);
            this.gbTakeProfit.Controls.Add(this.lblCloseQty);
            this.gbTakeProfit.Controls.Add(this.lblTotalProfit);
            this.gbTakeProfit.Controls.Add(this.lblcty);
            this.gbTakeProfit.Controls.Add(this.lblReinvestedAmt);
            this.gbTakeProfit.Controls.Add(this.lblReinvest);
            this.gbTakeProfit.Controls.Add(this.gbReinvestProfit);
            this.gbTakeProfit.Controls.Add(this.lblProjProfit);
            this.gbTakeProfit.Controls.Add(this.lblLimitSellAt);
            this.gbTakeProfit.Controls.Add(this.lblEstP);
            this.gbTakeProfit.Controls.Add(this.chkReinvestProfit);
            this.gbTakeProfit.Controls.Add(this.lblTpa);
            this.gbTakeProfit.Controls.Add(this.lblProfitPercent);
            this.gbTakeProfit.Controls.Add(this.cboPercents);
            this.gbTakeProfit.Enabled = false;
            this.gbTakeProfit.Location = new System.Drawing.Point(255, 38);
            this.gbTakeProfit.Name = "gbTakeProfit";
            this.gbTakeProfit.Size = new System.Drawing.Size(214, 295);
            this.gbTakeProfit.TabIndex = 6;
            this.gbTakeProfit.TabStop = false;
            this.gbTakeProfit.Text = "Take Profit";
            // 
            // lblTotalProjProfit
            // 
            this.lblTotalProjProfit.AutoSize = true;
            this.lblTotalProjProfit.ForeColor = System.Drawing.Color.Green;
            this.lblTotalProjProfit.Location = new System.Drawing.Point(111, 269);
            this.lblTotalProjProfit.Name = "lblTotalProjProfit";
            this.lblTotalProjProfit.Size = new System.Drawing.Size(19, 13);
            this.lblTotalProjProfit.TabIndex = 20;
            this.lblTotalProjProfit.Text = "$0";
            // 
            // lblCloseQty
            // 
            this.lblCloseQty.AutoSize = true;
            this.lblCloseQty.Location = new System.Drawing.Point(116, 165);
            this.lblCloseQty.Name = "lblCloseQty";
            this.lblCloseQty.Size = new System.Drawing.Size(13, 13);
            this.lblCloseQty.TabIndex = 15;
            this.lblCloseQty.Text = "0";
            // 
            // lblTotalProfit
            // 
            this.lblTotalProfit.AutoSize = true;
            this.lblTotalProfit.Location = new System.Drawing.Point(2, 269);
            this.lblTotalProfit.Name = "lblTotalProfit";
            this.lblTotalProfit.Size = new System.Drawing.Size(109, 13);
            this.lblTotalProfit.TabIndex = 19;
            this.lblTotalProfit.Text = "Total Projected Profit:";
            // 
            // lblcty
            // 
            this.lblcty.AutoSize = true;
            this.lblcty.Location = new System.Drawing.Point(3, 165);
            this.lblcty.Name = "lblcty";
            this.lblcty.Size = new System.Drawing.Size(66, 13);
            this.lblcty.TabIndex = 14;
            this.lblcty.Text = "Qty to close:";
            // 
            // lblReinvestedAmt
            // 
            this.lblReinvestedAmt.AutoSize = true;
            this.lblReinvestedAmt.ForeColor = System.Drawing.Color.DarkGoldenrod;
            this.lblReinvestedAmt.Location = new System.Drawing.Point(107, 240);
            this.lblReinvestedAmt.Name = "lblReinvestedAmt";
            this.lblReinvestedAmt.Size = new System.Drawing.Size(22, 13);
            this.lblReinvestedAmt.TabIndex = 18;
            this.lblReinvestedAmt.Text = "-$0";
            // 
            // lblReinvest
            // 
            this.lblReinvest.AutoSize = true;
            this.lblReinvest.Location = new System.Drawing.Point(3, 240);
            this.lblReinvest.Name = "lblReinvest";
            this.lblReinvest.Size = new System.Drawing.Size(85, 13);
            this.lblReinvest.TabIndex = 17;
            this.lblReinvest.Text = "Reinvested Amt:";
            // 
            // gbReinvestProfit
            // 
            this.gbReinvestProfit.Controls.Add(this.lblQuantityReinvested);
            this.gbReinvestProfit.Controls.Add(this.lblQR);
            this.gbReinvestProfit.Controls.Add(this.txtProfitPercent);
            this.gbReinvestProfit.Controls.Add(this.lblPPercent);
            this.gbReinvestProfit.Enabled = false;
            this.gbReinvestProfit.Location = new System.Drawing.Point(5, 96);
            this.gbReinvestProfit.Name = "gbReinvestProfit";
            this.gbReinvestProfit.Size = new System.Drawing.Size(147, 57);
            this.gbReinvestProfit.TabIndex = 16;
            this.gbReinvestProfit.TabStop = false;
            // 
            // lblQuantityReinvested
            // 
            this.lblQuantityReinvested.AutoSize = true;
            this.lblQuantityReinvested.Location = new System.Drawing.Point(86, 40);
            this.lblQuantityReinvested.Name = "lblQuantityReinvested";
            this.lblQuantityReinvested.Size = new System.Drawing.Size(13, 13);
            this.lblQuantityReinvested.TabIndex = 18;
            this.lblQuantityReinvested.Text = "0";
            // 
            // lblQR
            // 
            this.lblQR.AutoSize = true;
            this.lblQR.Location = new System.Drawing.Point(6, 41);
            this.lblQR.Name = "lblQR";
            this.lblQR.Size = new System.Drawing.Size(83, 13);
            this.lblQR.TabIndex = 17;
            this.lblQR.Text = "Qty Reinvested:";
            // 
            // txtProfitPercent
            // 
            this.txtProfitPercent.Location = new System.Drawing.Point(86, 13);
            this.txtProfitPercent.Name = "txtProfitPercent";
            this.txtProfitPercent.Size = new System.Drawing.Size(32, 20);
            this.txtProfitPercent.TabIndex = 16;
            this.txtProfitPercent.TextChanged += new System.EventHandler(this.ProfitPercentTxtChanged);
            // 
            // lblPPercent
            // 
            this.lblPPercent.AutoSize = true;
            this.lblPPercent.Location = new System.Drawing.Point(6, 16);
            this.lblPPercent.Name = "lblPPercent";
            this.lblPPercent.Size = new System.Drawing.Size(74, 13);
            this.lblPPercent.TabIndex = 12;
            this.lblPPercent.Text = "Profit Percent:";
            // 
            // lblProjProfit
            // 
            this.lblProjProfit.AutoSize = true;
            this.lblProjProfit.ForeColor = System.Drawing.Color.Green;
            this.lblProjProfit.Location = new System.Drawing.Point(111, 214);
            this.lblProjProfit.Name = "lblProjProfit";
            this.lblProjProfit.Size = new System.Drawing.Size(19, 13);
            this.lblProjProfit.TabIndex = 10;
            this.lblProjProfit.Text = "$0";
            // 
            // lblLimitSellAt
            // 
            this.lblLimitSellAt.AutoSize = true;
            this.lblLimitSellAt.Location = new System.Drawing.Point(111, 192);
            this.lblLimitSellAt.Name = "lblLimitSellAt";
            this.lblLimitSellAt.Size = new System.Drawing.Size(19, 13);
            this.lblLimitSellAt.TabIndex = 9;
            this.lblLimitSellAt.Text = "$0";
            // 
            // lblEstP
            // 
            this.lblEstP.AutoSize = true;
            this.lblEstP.Location = new System.Drawing.Point(3, 214);
            this.lblEstP.Name = "lblEstP";
            this.lblEstP.Size = new System.Drawing.Size(82, 13);
            this.lblEstP.TabIndex = 8;
            this.lblEstP.Text = "Projected Profit:";
            // 
            // chkReinvestProfit
            // 
            this.chkReinvestProfit.AutoSize = true;
            this.chkReinvestProfit.Location = new System.Drawing.Point(9, 73);
            this.chkReinvestProfit.Name = "chkReinvestProfit";
            this.chkReinvestProfit.Size = new System.Drawing.Size(101, 17);
            this.chkReinvestProfit.TabIndex = 11;
            this.chkReinvestProfit.Text = "Reinvest Profit?";
            this.chkReinvestProfit.UseVisualStyleBackColor = true;
            this.chkReinvestProfit.CheckedChanged += new System.EventHandler(this.ReinvestProfitCheckChanged);
            // 
            // lblTpa
            // 
            this.lblTpa.AutoSize = true;
            this.lblTpa.Location = new System.Drawing.Point(3, 192);
            this.lblTpa.Name = "lblTpa";
            this.lblTpa.Size = new System.Drawing.Size(61, 13);
            this.lblTpa.TabIndex = 6;
            this.lblTpa.Text = "Limit sell at:";
            // 
            // lblProfitPercent
            // 
            this.lblProfitPercent.AutoSize = true;
            this.lblProfitPercent.Location = new System.Drawing.Point(6, 37);
            this.lblProfitPercent.Name = "lblProfitPercent";
            this.lblProfitPercent.Size = new System.Drawing.Size(114, 13);
            this.lblProfitPercent.TabIndex = 5;
            this.lblProfitPercent.Text = "Price Change Percent:";
            // 
            // cboPercents
            // 
            this.cboPercents.FormattingEnabled = true;
            this.cboPercents.Items.AddRange(new object[] {
            "10",
            "20",
            "30",
            "40",
            "50",
            "60",
            "70",
            "80",
            "90",
            "100"});
            this.cboPercents.Location = new System.Drawing.Point(120, 34);
            this.cboPercents.Name = "cboPercents";
            this.cboPercents.Size = new System.Drawing.Size(43, 21);
            this.cboPercents.TabIndex = 4;
            this.cboPercents.SelectedIndexChanged += new System.EventHandler(this.PricePercentChanged);
            this.cboPercents.TextChanged += new System.EventHandler(this.PricePercentChanged);
            // 
            // lblAvgPrice
            // 
            this.lblAvgPrice.AutoSize = true;
            this.lblAvgPrice.Location = new System.Drawing.Point(20, 69);
            this.lblAvgPrice.Name = "lblAvgPrice";
            this.lblAvgPrice.Size = new System.Drawing.Size(55, 13);
            this.lblAvgPrice.TabIndex = 2;
            this.lblAvgPrice.Text = "Avg price:";
            // 
            // lblOpenQty
            // 
            this.lblOpenQty.AutoSize = true;
            this.lblOpenQty.Location = new System.Drawing.Point(20, 38);
            this.lblOpenQty.Name = "lblOpenQty";
            this.lblOpenQty.Size = new System.Drawing.Size(56, 13);
            this.lblOpenQty.TabIndex = 0;
            this.lblOpenQty.Text = "Open  qty:";
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.ClientSize = new System.Drawing.Size(508, 423);
            this.Controls.Add(this.gbWorkSpace);
            this.Controls.Add(this.menuStrip1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MainMenuStrip = this.menuStrip1;
            this.MaximizeBox = false;
            this.Name = "MainForm";
            this.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Show;
            this.Text = "Trading Calculator (BETA: v1)";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.gbWorkSpace.ResumeLayout(false);
            this.gbWorkSpace.PerformLayout();
            this.gbAvgDown.ResumeLayout(false);
            this.gbAvgDown.PerformLayout();
            this.gbTakeProfit.ResumeLayout(false);
            this.gbTakeProfit.PerformLayout();
            this.gbReinvestProfit.ResumeLayout(false);
            this.gbReinvestProfit.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }
        #endregion

        private MenuStrip menuStrip1;
        private ToolStripMenuItem fileToolStripMenuItem;
        private ToolStripMenuItem aboutToolStripMenuItem;
        private ToolStripMenuItem exitToolStripMenuItem;
        private GroupBox gbWorkSpace;
        private Label lblOpenQty;
        private GroupBox gbTakeProfit;
        private Label lblProfitPercent;
        private ComboBox cboPercents;
        private Label lblAvgPrice;
        private Label lblTpa;
        private Label lblEstP;
        private Label lblLimitSellAt;
        private Label lblProjProfit;
        private GroupBox gbAvgDown;
        private Label label1;
        private Label lblAvgDown4;
        private Label lblAvgDown3;
        private Label lblAvgDown2;
        private Label lblAvgDown1;
        private Label lblPriceTarget4;
        private Label lblPriceTarget3;
        private Label lblPriceTarget2;
        private Label lblPriceTarget1;
        private Label lblPriceTarget;
        private Label lblPriceTargetCustom;
        private Label lblCustom;
        private Label lblCloseQty;
        private Label lblcty;
        private Label lblPPercent;
        private CheckBox chkReinvestProfit;
        private Button btnClearAll;
        private Label lblCaption;
        private GroupBox gbReinvestProfit;
        private Label lblTotalProjProfit;
        private Label lblTotalProfit;
        private Label lblReinvestedAmt;
        private Label lblReinvest;
        private ToolTip ttipOpenQty;
        private ToolTip ttipAvgPrice;
        private TextBox txtAvgPrice;
        private TextBox txtOpenQty;
        private TextBox txtAvgDownPercent;
        private TextBox txtProfitPercent;
        private Button btnClose;
        private Label avgDownPercLiteral;
        private Label lblCopyright;
        private ToolTip ttipCustomPercent;
        private System.ComponentModel.IContainer components = null;
        private ToolTip ttipPriceChangePercent;
        private ToolTip ttipProfitPercent;
        private Label lblQuantityReinvested;
        private Label lblQR;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }
    }
}