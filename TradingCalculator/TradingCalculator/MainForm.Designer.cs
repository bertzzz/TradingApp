using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace TradingCalculator
{
    partial class MainForm
    {
        private decimal _openQty = 0;
        private decimal _avgPrice = 0;
        private List<int> avgDownPercentageList = new List<int>() { 20, 30, 40, 50 };

        private void OpenQtyTextChanged(object sender, EventArgs e)
        {
            ttipOpenQty.Hide(txtOpenQty);
            gbTakeProfit.Enabled = false;

            UpdateQtyAndPrice();


            if(string.IsNullOrWhiteSpace(txtOpenQty.Text))
            {
                ttipOpenQty.ToolTipIcon = ToolTipIcon.Warning;
                ttipOpenQty.ToolTipTitle = "Empty Field";
                ttipOpenQty.Show("Please enter quantity.", txtOpenQty, 50, -20, 2000);
            }
            else if (_openQty == 0)
            {
                ttipOpenQty.ToolTipIcon = ToolTipIcon.Error;
                ttipOpenQty.ToolTipTitle = "Invalid Field";
                ttipOpenQty.Show("Quantity entered is invalid.", txtOpenQty, 50, -20);
            }
            else
            {
                EnableComboBoxes();
            }
        }

        private void AvgPriceTextChanged(object sender, EventArgs e)
        {
            ttipAvgPrice.Hide(txtAvgPrice);
            gbTakeProfit.Enabled = false;
            gbAvgDown.Enabled = false;

            UpdateQtyAndPrice();

            if (string.IsNullOrWhiteSpace(txtAvgPrice.Text))
            {
                ttipOpenQty.ToolTipIcon = ToolTipIcon.Warning;
                ttipOpenQty.ToolTipTitle = "Empty Field";
                ttipOpenQty.Show("Please enter price.", txtAvgPrice, 50, -20, 2000);

                ResetAvgDownFields();
            }
            else if (_avgPrice == 0)
            {
                ttipOpenQty.ToolTipIcon = ToolTipIcon.Error;
                ttipOpenQty.ToolTipTitle = "Invalid Field";
                ttipOpenQty.Show("Price entered is invalid.", txtAvgPrice, 50, -20);
            }
            else
            {
                EnableComboBoxes();
            }
        }

        private void ResetAvgDownFields()
        {
            lblPriceTarget1.Text = $"$0";
            lblPriceTarget2.Text = $"$0";
            lblPriceTarget3.Text = $"$0";
            lblPriceTarget4.Text = $"$0";
            lblPriceTargetCustom.Text = $"0";

            txtAvgDownPercent.Text = "";
        }

        private void UpdateTakeProfit()
        {
        }

        private void UpdateAveDown()
        {
            lblAvgDown1.Text = $"{avgDownPercentageList[0]}";
            lblAvgDown2.Text = $"{avgDownPercentageList[1]}";
            lblAvgDown3.Text = $"{avgDownPercentageList[2]}";
            lblAvgDown4.Text = $"{avgDownPercentageList[3]}";

            lblPriceTarget1.Text = $"${_avgPrice - (_avgPrice * (Convert.ToDecimal(avgDownPercentageList[0]) / 100))}";
            lblPriceTarget2.Text = $"${_avgPrice - (_avgPrice * (Convert.ToDecimal(avgDownPercentageList[1]) / 100))}";
            lblPriceTarget3.Text = $"${_avgPrice - (_avgPrice * (Convert.ToDecimal(avgDownPercentageList[2]) / 100))}";
            lblPriceTarget4.Text = $"${_avgPrice - (_avgPrice * (Convert.ToDecimal(avgDownPercentageList[3]) / 100))}";
        }                                                                                                 

        private void CustomPercentTextChanged(object sender, EventArgs e)
        {
            ttipCustomPercent.Hide(txtAvgDownPercent);
            bool percentIsNum = decimal.TryParse(txtAvgDownPercent.Text, out decimal result);

            if (string.IsNullOrWhiteSpace(txtAvgDownPercent.Text))
            {
                lblPriceTargetCustom.Text = $"0";
            }
            else if(!percentIsNum)
            {
                ttipCustomPercent.ToolTipIcon = ToolTipIcon.Error;
                ttipCustomPercent.ToolTipTitle = "Invalid Field";
                ttipCustomPercent.Show("Percent entered is invalid.", txtAvgDownPercent, 50, -20, 2000);
                lblPriceTargetCustom.Text = $"0";
            }
            else
            {
                decimal percent = result / 100;
                lblPriceTargetCustom.Text = $"${_avgPrice - (_avgPrice * percent)}";
            }
        }

        private void UpdateQtyAndPrice()
        {
            bool avgPriceIsNumeric = decimal.TryParse(txtAvgPrice.Text, out decimal avgPriceDec);
            _avgPrice = avgPriceDec;

            bool openQtyIsNumeric = decimal.TryParse(txtOpenQty.Text, out decimal openQtyDec);
            _openQty = openQtyDec;
        }

        private void EnableComboBoxes()
        {
            if (_openQty != 0 && _avgPrice != 0)
            {
                gbTakeProfit.Enabled = true;
                UpdateTakeProfit();
            }

            if (_avgPrice != 0)
            {
                gbAvgDown.Enabled = true;
                UpdateAveDown();
            }
        }

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        private void CloseForm (object sender, EventArgs e)
        {
            this.Close();
        }

        #region Private Form Variables
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
        private Label lblTakeProfitAt;
        private Label lblEstProfit;
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
        private Label lblclseqty;
        private Label lblPPercent;
        private CheckBox chkLeaveShares;
        private Button btnClearAll;
        private Label lblCaption;
        private GroupBox groupBox1;
        private Label label2;
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
        private System.ComponentModel.IContainer components = null;

        #endregion

        #region Windows Form Designer generated code
        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        /// 

        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.fileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.aboutToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.exitToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.gbWorkSpace = new System.Windows.Forms.GroupBox();
            this.btnClose = new System.Windows.Forms.Button();
            this.txtAvgPrice = new System.Windows.Forms.TextBox();
            this.txtOpenQty = new System.Windows.Forms.TextBox();
            this.lblCaption = new System.Windows.Forms.Label();
            this.btnClearAll = new System.Windows.Forms.Button();
            this.gbAvgDown = new System.Windows.Forms.GroupBox();
            this.label3 = new System.Windows.Forms.Label();
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
            this.label2 = new System.Windows.Forms.Label();
            this.lblTotalProfit = new System.Windows.Forms.Label();
            this.lblReinvestedAmt = new System.Windows.Forms.Label();
            this.lblReinvest = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.txtProfitPercent = new System.Windows.Forms.TextBox();
            this.lblCloseQty = new System.Windows.Forms.Label();
            this.lblclseqty = new System.Windows.Forms.Label();
            this.lblPPercent = new System.Windows.Forms.Label();
            this.lblEstProfit = new System.Windows.Forms.Label();
            this.lblTakeProfitAt = new System.Windows.Forms.Label();
            this.lblEstP = new System.Windows.Forms.Label();
            this.chkLeaveShares = new System.Windows.Forms.CheckBox();
            this.lblTpa = new System.Windows.Forms.Label();
            this.lblProfitPercent = new System.Windows.Forms.Label();
            this.cboPercents = new System.Windows.Forms.ComboBox();
            this.lblAvgPrice = new System.Windows.Forms.Label();
            this.lblOpenQty = new System.Windows.Forms.Label();
            this.ttipOpenQty = new System.Windows.Forms.ToolTip(this.components);
            this.ttipAvgPrice = new System.Windows.Forms.ToolTip(this.components);
            this.ttipCustomPercent = new System.Windows.Forms.ToolTip(this.components);
            this.menuStrip1.SuspendLayout();
            this.gbWorkSpace.SuspendLayout();
            this.gbAvgDown.SuspendLayout();
            this.gbTakeProfit.SuspendLayout();
            this.groupBox1.SuspendLayout();
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
            // btnClose
            // 
            this.btnClose.Location = new System.Drawing.Point(394, 367);
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
            this.btnClearAll.Location = new System.Drawing.Point(394, 339);
            this.btnClearAll.Name = "btnClearAll";
            this.btnClearAll.Size = new System.Drawing.Size(75, 23);
            this.btnClearAll.TabIndex = 8;
            this.btnClearAll.Text = "Clear All";
            this.btnClearAll.UseVisualStyleBackColor = true;
            // 
            // gbAvgDown
            // 
            this.gbAvgDown.Controls.Add(this.label3);
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
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(56, 184);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(15, 13);
            this.label3.TabIndex = 14;
            this.label3.Text = "%";
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
            this.gbTakeProfit.Controls.Add(this.label2);
            this.gbTakeProfit.Controls.Add(this.lblTotalProfit);
            this.gbTakeProfit.Controls.Add(this.lblReinvestedAmt);
            this.gbTakeProfit.Controls.Add(this.lblReinvest);
            this.gbTakeProfit.Controls.Add(this.groupBox1);
            this.gbTakeProfit.Controls.Add(this.lblEstProfit);
            this.gbTakeProfit.Controls.Add(this.lblTakeProfitAt);
            this.gbTakeProfit.Controls.Add(this.lblEstP);
            this.gbTakeProfit.Controls.Add(this.chkLeaveShares);
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
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.ForeColor = System.Drawing.Color.Green;
            this.label2.Location = new System.Drawing.Point(114, 269);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(19, 13);
            this.label2.TabIndex = 20;
            this.label2.Text = "$0";
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
            // lblReinvestedAmt
            // 
            this.lblReinvestedAmt.AutoSize = true;
            this.lblReinvestedAmt.ForeColor = System.Drawing.Color.Olive;
            this.lblReinvestedAmt.Location = new System.Drawing.Point(114, 241);
            this.lblReinvestedAmt.Name = "lblReinvestedAmt";
            this.lblReinvestedAmt.Size = new System.Drawing.Size(19, 13);
            this.lblReinvestedAmt.TabIndex = 18;
            this.lblReinvestedAmt.Text = "$0";
            // 
            // lblReinvest
            // 
            this.lblReinvest.AutoSize = true;
            this.lblReinvest.Location = new System.Drawing.Point(2, 241);
            this.lblReinvest.Name = "lblReinvest";
            this.lblReinvest.Size = new System.Drawing.Size(85, 13);
            this.lblReinvest.TabIndex = 17;
            this.lblReinvest.Text = "Reinvested Amt:";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.txtProfitPercent);
            this.groupBox1.Controls.Add(this.lblCloseQty);
            this.groupBox1.Controls.Add(this.lblclseqty);
            this.groupBox1.Controls.Add(this.lblPPercent);
            this.groupBox1.Enabled = false;
            this.groupBox1.Location = new System.Drawing.Point(5, 96);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(147, 69);
            this.groupBox1.TabIndex = 16;
            this.groupBox1.TabStop = false;
            // 
            // txtProfitPercent
            // 
            this.txtProfitPercent.Location = new System.Drawing.Point(86, 13);
            this.txtProfitPercent.Name = "txtProfitPercent";
            this.txtProfitPercent.Size = new System.Drawing.Size(32, 20);
            this.txtProfitPercent.TabIndex = 16;
            // 
            // lblCloseQty
            // 
            this.lblCloseQty.AutoSize = true;
            this.lblCloseQty.Location = new System.Drawing.Point(87, 41);
            this.lblCloseQty.Name = "lblCloseQty";
            this.lblCloseQty.Size = new System.Drawing.Size(35, 13);
            this.lblCloseQty.TabIndex = 15;
            this.lblCloseQty.Text = "label2";
            // 
            // lblclseqty
            // 
            this.lblclseqty.AutoSize = true;
            this.lblclseqty.Location = new System.Drawing.Point(6, 41);
            this.lblclseqty.Name = "lblclseqty";
            this.lblclseqty.Size = new System.Drawing.Size(66, 13);
            this.lblclseqty.TabIndex = 14;
            this.lblclseqty.Text = "Qty to close:";
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
            // lblEstProfit
            // 
            this.lblEstProfit.AutoSize = true;
            this.lblEstProfit.ForeColor = System.Drawing.Color.Green;
            this.lblEstProfit.Location = new System.Drawing.Point(114, 208);
            this.lblEstProfit.Name = "lblEstProfit";
            this.lblEstProfit.Size = new System.Drawing.Size(19, 13);
            this.lblEstProfit.TabIndex = 10;
            this.lblEstProfit.Text = "$0";
            // 
            // lblTakeProfitAt
            // 
            this.lblTakeProfitAt.AutoSize = true;
            this.lblTakeProfitAt.Location = new System.Drawing.Point(114, 182);
            this.lblTakeProfitAt.Name = "lblTakeProfitAt";
            this.lblTakeProfitAt.Size = new System.Drawing.Size(19, 13);
            this.lblTakeProfitAt.TabIndex = 9;
            this.lblTakeProfitAt.Text = "$0";
            // 
            // lblEstP
            // 
            this.lblEstP.AutoSize = true;
            this.lblEstP.Location = new System.Drawing.Point(2, 208);
            this.lblEstP.Name = "lblEstP";
            this.lblEstP.Size = new System.Drawing.Size(82, 13);
            this.lblEstP.TabIndex = 8;
            this.lblEstP.Text = "Projected Profit:";
            // 
            // chkLeaveShares
            // 
            this.chkLeaveShares.AutoSize = true;
            this.chkLeaveShares.Location = new System.Drawing.Point(9, 73);
            this.chkLeaveShares.Name = "chkLeaveShares";
            this.chkLeaveShares.Size = new System.Drawing.Size(101, 17);
            this.chkLeaveShares.TabIndex = 11;
            this.chkLeaveShares.Text = "Reinvest Profit?";
            this.chkLeaveShares.UseVisualStyleBackColor = true;
            // 
            // lblTpa
            // 
            this.lblTpa.AutoSize = true;
            this.lblTpa.Location = new System.Drawing.Point(2, 182);
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
            this.cboPercents.Text = "10";
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
            this.ClientSize = new System.Drawing.Size(508, 423);
            this.Controls.Add(this.gbWorkSpace);
            this.Controls.Add(this.menuStrip1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
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
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }
        #endregion

        private Label label3;
        private ToolTip ttipCustomPercent;
    }
}