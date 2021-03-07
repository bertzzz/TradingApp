namespace TradingCalculatorBeta
{
    partial class MainForm
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

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.fileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.aboutToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.exitToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.gbWorkSpace = new System.Windows.Forms.GroupBox();
            this.gbAvgDown = new System.Windows.Forms.GroupBox();
            this.gbTakeProfit = new System.Windows.Forms.GroupBox();
            this.lblEstProfit = new System.Windows.Forms.Label();
            this.lblTakeProfitAt = new System.Windows.Forms.Label();
            this.lblEstP = new System.Windows.Forms.Label();
            this.lblTpa = new System.Windows.Forms.Label();
            this.lblProfitPercent = new System.Windows.Forms.Label();
            this.cboPercents = new System.Windows.Forms.ComboBox();
            this.txtAvgPrice = new System.Windows.Forms.TextBox();
            this.lblAvgPrice = new System.Windows.Forms.Label();
            this.txtOpenQty = new System.Windows.Forms.TextBox();
            this.lblOpenQty = new System.Windows.Forms.Label();
            this.lblAvgDown1 = new System.Windows.Forms.Label();
            this.lblAvgDown2 = new System.Windows.Forms.Label();
            this.lblAvgDown3 = new System.Windows.Forms.Label();
            this.lblAvgDown4 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.lblPriceTarget = new System.Windows.Forms.Label();
            this.lblPriceTarget1 = new System.Windows.Forms.Label();
            this.lblPriceTarget2 = new System.Windows.Forms.Label();
            this.lblPriceTarget3 = new System.Windows.Forms.Label();
            this.lblPriceTarget4 = new System.Windows.Forms.Label();
            this.lblCustom = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.lblPriceTargetCustom = new System.Windows.Forms.Label();
            this.chkLeaveShares = new System.Windows.Forms.CheckBox();
            this.lblGainsPercent = new System.Windows.Forms.Label();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.lblclseqty = new System.Windows.Forms.Label();
            this.lblCloseQty = new System.Windows.Forms.Label();
            this.btnClearAll = new System.Windows.Forms.Button();
            this.menuStrip1.SuspendLayout();
            this.gbWorkSpace.SuspendLayout();
            this.gbAvgDown.SuspendLayout();
            this.gbTakeProfit.SuspendLayout();
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
            this.aboutToolStripMenuItem.Size = new System.Drawing.Size(107, 22);
            this.aboutToolStripMenuItem.Text = "About";
            // 
            // exitToolStripMenuItem
            // 
            this.exitToolStripMenuItem.Name = "exitToolStripMenuItem";
            this.exitToolStripMenuItem.Size = new System.Drawing.Size(107, 22);
            this.exitToolStripMenuItem.Text = "Exit";
            // 
            // gbWorkSpace
            // 
            this.gbWorkSpace.Controls.Add(this.btnClearAll);
            this.gbWorkSpace.Controls.Add(this.gbAvgDown);
            this.gbWorkSpace.Controls.Add(this.gbTakeProfit);
            this.gbWorkSpace.Controls.Add(this.txtAvgPrice);
            this.gbWorkSpace.Controls.Add(this.lblAvgPrice);
            this.gbWorkSpace.Controls.Add(this.txtOpenQty);
            this.gbWorkSpace.Controls.Add(this.lblOpenQty);
            this.gbWorkSpace.Location = new System.Drawing.Point(12, 41);
            this.gbWorkSpace.Name = "gbWorkSpace";
            this.gbWorkSpace.Size = new System.Drawing.Size(492, 373);
            this.gbWorkSpace.TabIndex = 2;
            this.gbWorkSpace.TabStop = false;
            this.gbWorkSpace.Text = "Workspace ";
            // 
            // gbAvgDown
            // 
            this.gbAvgDown.Controls.Add(this.lblPriceTargetCustom);
            this.gbAvgDown.Controls.Add(this.textBox1);
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
            this.gbAvgDown.Location = new System.Drawing.Point(23, 101);
            this.gbAvgDown.Name = "gbAvgDown";
            this.gbAvgDown.Size = new System.Drawing.Size(188, 232);
            this.gbAvgDown.TabIndex = 7;
            this.gbAvgDown.TabStop = false;
            this.gbAvgDown.Text = "Average Down";
            this.gbAvgDown.Enter += new System.EventHandler(this.gbAvgDown_Enter);
            // 
            // gbTakeProfit
            // 
            this.gbTakeProfit.Controls.Add(this.lblCloseQty);
            this.gbTakeProfit.Controls.Add(this.lblclseqty);
            this.gbTakeProfit.Controls.Add(this.textBox2);
            this.gbTakeProfit.Controls.Add(this.lblGainsPercent);
            this.gbTakeProfit.Controls.Add(this.chkLeaveShares);
            this.gbTakeProfit.Controls.Add(this.lblEstProfit);
            this.gbTakeProfit.Controls.Add(this.lblTakeProfitAt);
            this.gbTakeProfit.Controls.Add(this.lblEstP);
            this.gbTakeProfit.Controls.Add(this.lblTpa);
            this.gbTakeProfit.Controls.Add(this.lblProfitPercent);
            this.gbTakeProfit.Controls.Add(this.cboPercents);
            this.gbTakeProfit.Location = new System.Drawing.Point(255, 101);
            this.gbTakeProfit.Name = "gbTakeProfit";
            this.gbTakeProfit.Size = new System.Drawing.Size(214, 232);
            this.gbTakeProfit.TabIndex = 6;
            this.gbTakeProfit.TabStop = false;
            this.gbTakeProfit.Text = "Take Profit";
            // 
            // lblEstProfit
            // 
            this.lblEstProfit.AutoSize = true;
            this.lblEstProfit.Location = new System.Drawing.Point(87, 188);
            this.lblEstProfit.Name = "lblEstProfit";
            this.lblEstProfit.Size = new System.Drawing.Size(19, 13);
            this.lblEstProfit.TabIndex = 10;
            this.lblEstProfit.Text = "$1";
            // 
            // lblTakeProfitAt
            // 
            this.lblTakeProfitAt.AutoSize = true;
            this.lblTakeProfitAt.Location = new System.Drawing.Point(87, 162);
            this.lblTakeProfitAt.Name = "lblTakeProfitAt";
            this.lblTakeProfitAt.Size = new System.Drawing.Size(19, 13);
            this.lblTakeProfitAt.TabIndex = 9;
            this.lblTakeProfitAt.Text = "$1";
            // 
            // lblEstP
            // 
            this.lblEstP.AutoSize = true;
            this.lblEstP.Location = new System.Drawing.Point(6, 188);
            this.lblEstP.Name = "lblEstP";
            this.lblEstP.Size = new System.Drawing.Size(82, 13);
            this.lblEstP.TabIndex = 8;
            this.lblEstP.Text = "Projected Profit:";
            // 
            // lblTpa
            // 
            this.lblTpa.AutoSize = true;
            this.lblTpa.Location = new System.Drawing.Point(6, 162);
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
            this.lblProfitPercent.Size = new System.Drawing.Size(47, 13);
            this.lblProfitPercent.TabIndex = 5;
            this.lblProfitPercent.Text = "Percent:";
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
            this.cboPercents.Location = new System.Drawing.Point(87, 33);
            this.cboPercents.Name = "cboPercents";
            this.cboPercents.Size = new System.Drawing.Size(43, 21);
            this.cboPercents.TabIndex = 4;
            this.cboPercents.Text = "10";
            this.cboPercents.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged);
            // 
            // txtAvgPrice
            // 
            this.txtAvgPrice.Location = new System.Drawing.Point(82, 66);
            this.txtAvgPrice.Name = "txtAvgPrice";
            this.txtAvgPrice.Size = new System.Drawing.Size(100, 20);
            this.txtAvgPrice.TabIndex = 3;
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
            // txtOpenQty
            // 
            this.txtOpenQty.Location = new System.Drawing.Point(82, 35);
            this.txtOpenQty.Name = "txtOpenQty";
            this.txtOpenQty.Size = new System.Drawing.Size(100, 20);
            this.txtOpenQty.TabIndex = 1;
            // 
            // lblOpenQty
            // 
            this.lblOpenQty.AutoSize = true;
            this.lblOpenQty.Location = new System.Drawing.Point(20, 38);
            this.lblOpenQty.Name = "lblOpenQty";
            this.lblOpenQty.Size = new System.Drawing.Size(56, 13);
            this.lblOpenQty.TabIndex = 0;
            this.lblOpenQty.Text = "Open  qty:";
            this.lblOpenQty.Click += new System.EventHandler(this.label1_Click);
            // 
            // lblAvgDown1
            // 
            this.lblAvgDown1.AutoSize = true;
            this.lblAvgDown1.Location = new System.Drawing.Point(6, 52);
            this.lblAvgDown1.Name = "lblAvgDown1";
            this.lblAvgDown1.Size = new System.Drawing.Size(27, 13);
            this.lblAvgDown1.TabIndex = 0;
            this.lblAvgDown1.Text = "30%";
            // 
            // lblAvgDown2
            // 
            this.lblAvgDown2.AutoSize = true;
            this.lblAvgDown2.Location = new System.Drawing.Point(6, 77);
            this.lblAvgDown2.Name = "lblAvgDown2";
            this.lblAvgDown2.Size = new System.Drawing.Size(27, 13);
            this.lblAvgDown2.TabIndex = 1;
            this.lblAvgDown2.Text = "50%";
            // 
            // lblAvgDown3
            // 
            this.lblAvgDown3.AutoSize = true;
            this.lblAvgDown3.Location = new System.Drawing.Point(6, 102);
            this.lblAvgDown3.Name = "lblAvgDown3";
            this.lblAvgDown3.Size = new System.Drawing.Size(27, 13);
            this.lblAvgDown3.TabIndex = 2;
            this.lblAvgDown3.Text = "70%";
            // 
            // lblAvgDown4
            // 
            this.lblAvgDown4.AutoSize = true;
            this.lblAvgDown4.Location = new System.Drawing.Point(5, 129);
            this.lblAvgDown4.Name = "lblAvgDown4";
            this.lblAvgDown4.Size = new System.Drawing.Size(33, 13);
            this.lblAvgDown4.TabIndex = 3;
            this.lblAvgDown4.Text = "100%";
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
            // lblPriceTarget
            // 
            this.lblPriceTarget.AutoSize = true;
            this.lblPriceTarget.Location = new System.Drawing.Point(80, 26);
            this.lblPriceTarget.Name = "lblPriceTarget";
            this.lblPriceTarget.Size = new System.Drawing.Size(73, 13);
            this.lblPriceTarget.TabIndex = 5;
            this.lblPriceTarget.Text = "Price Targets:";
            // 
            // lblPriceTarget1
            // 
            this.lblPriceTarget1.AutoSize = true;
            this.lblPriceTarget1.Location = new System.Drawing.Point(80, 52);
            this.lblPriceTarget1.Name = "lblPriceTarget1";
            this.lblPriceTarget1.Size = new System.Drawing.Size(35, 13);
            this.lblPriceTarget1.TabIndex = 6;
            this.lblPriceTarget1.Text = "label2";
            // 
            // lblPriceTarget2
            // 
            this.lblPriceTarget2.AutoSize = true;
            this.lblPriceTarget2.Location = new System.Drawing.Point(80, 77);
            this.lblPriceTarget2.Name = "lblPriceTarget2";
            this.lblPriceTarget2.Size = new System.Drawing.Size(35, 13);
            this.lblPriceTarget2.TabIndex = 7;
            this.lblPriceTarget2.Text = "label3";
            // 
            // lblPriceTarget3
            // 
            this.lblPriceTarget3.AutoSize = true;
            this.lblPriceTarget3.Location = new System.Drawing.Point(80, 102);
            this.lblPriceTarget3.Name = "lblPriceTarget3";
            this.lblPriceTarget3.Size = new System.Drawing.Size(35, 13);
            this.lblPriceTarget3.TabIndex = 8;
            this.lblPriceTarget3.Text = "label4";
            // 
            // lblPriceTarget4
            // 
            this.lblPriceTarget4.AutoSize = true;
            this.lblPriceTarget4.Location = new System.Drawing.Point(80, 129);
            this.lblPriceTarget4.Name = "lblPriceTarget4";
            this.lblPriceTarget4.Size = new System.Drawing.Size(35, 13);
            this.lblPriceTarget4.TabIndex = 9;
            this.lblPriceTarget4.Text = "label5";
            // 
            // lblCustom
            // 
            this.lblCustom.AutoSize = true;
            this.lblCustom.Location = new System.Drawing.Point(6, 162);
            this.lblCustom.Name = "lblCustom";
            this.lblCustom.Size = new System.Drawing.Size(45, 13);
            this.lblCustom.TabIndex = 10;
            this.lblCustom.Text = "Custom:";
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(9, 187);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(43, 20);
            this.textBox1.TabIndex = 11;
            this.textBox1.Text = "10";
            // 
            // lblPriceTargetCustom
            // 
            this.lblPriceTargetCustom.AutoSize = true;
            this.lblPriceTargetCustom.Location = new System.Drawing.Point(80, 194);
            this.lblPriceTargetCustom.Name = "lblPriceTargetCustom";
            this.lblPriceTargetCustom.Size = new System.Drawing.Size(35, 13);
            this.lblPriceTargetCustom.TabIndex = 12;
            this.lblPriceTargetCustom.Text = "label2";
            // 
            // chkLeaveShares
            // 
            this.chkLeaveShares.AutoSize = true;
            this.chkLeaveShares.Location = new System.Drawing.Point(9, 73);
            this.chkLeaveShares.Name = "chkLeaveShares";
            this.chkLeaveShares.Size = new System.Drawing.Size(102, 17);
            this.chkLeaveShares.TabIndex = 11;
            this.chkLeaveShares.Text = "Reinvest gains?";
            this.chkLeaveShares.UseVisualStyleBackColor = true;
            // 
            // lblGainsPercent
            // 
            this.lblGainsPercent.AutoSize = true;
            this.lblGainsPercent.Location = new System.Drawing.Point(6, 102);
            this.lblGainsPercent.Name = "lblGainsPercent";
            this.lblGainsPercent.Size = new System.Drawing.Size(77, 13);
            this.lblGainsPercent.TabIndex = 12;
            this.lblGainsPercent.Text = "Gains Percent:";
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(87, 99);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(43, 20);
            this.textBox2.TabIndex = 13;
            // 
            // lblclseqty
            // 
            this.lblclseqty.AutoSize = true;
            this.lblclseqty.Location = new System.Drawing.Point(6, 129);
            this.lblclseqty.Name = "lblclseqty";
            this.lblclseqty.Size = new System.Drawing.Size(53, 13);
            this.lblclseqty.TabIndex = 14;
            this.lblclseqty.Text = "Close qty:";
            // 
            // lblCloseQty
            // 
            this.lblCloseQty.AutoSize = true;
            this.lblCloseQty.Location = new System.Drawing.Point(87, 129);
            this.lblCloseQty.Name = "lblCloseQty";
            this.lblCloseQty.Size = new System.Drawing.Size(35, 13);
            this.lblCloseQty.TabIndex = 15;
            this.lblCloseQty.Text = "label2";
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
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(508, 417);
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
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem fileToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem aboutToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem exitToolStripMenuItem;
        private System.Windows.Forms.GroupBox gbWorkSpace;
        private System.Windows.Forms.Label lblOpenQty;
        private System.Windows.Forms.TextBox txtOpenQty;
        private System.Windows.Forms.GroupBox gbTakeProfit;
        private System.Windows.Forms.Label lblProfitPercent;
        private System.Windows.Forms.ComboBox cboPercents;
        private System.Windows.Forms.TextBox txtAvgPrice;
        private System.Windows.Forms.Label lblAvgPrice;
        private System.Windows.Forms.Label lblTpa;
        private System.Windows.Forms.Label lblEstP;
        private System.Windows.Forms.Label lblTakeProfitAt;
        private System.Windows.Forms.Label lblEstProfit;
        private System.Windows.Forms.GroupBox gbAvgDown;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lblAvgDown4;
        private System.Windows.Forms.Label lblAvgDown3;
        private System.Windows.Forms.Label lblAvgDown2;
        private System.Windows.Forms.Label lblAvgDown1;
        private System.Windows.Forms.Label lblPriceTarget4;
        private System.Windows.Forms.Label lblPriceTarget3;
        private System.Windows.Forms.Label lblPriceTarget2;
        private System.Windows.Forms.Label lblPriceTarget1;
        private System.Windows.Forms.Label lblPriceTarget;
        private System.Windows.Forms.Label lblPriceTargetCustom;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label lblCustom;
        private System.Windows.Forms.Label lblCloseQty;
        private System.Windows.Forms.Label lblclseqty;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.Label lblGainsPercent;
        private System.Windows.Forms.CheckBox chkLeaveShares;
        private System.Windows.Forms.Button btnClearAll;
    }
}