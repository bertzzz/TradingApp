﻿using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace TradingCalculator
{
    public partial class MainForm : Form
    {
        private decimal _limitSellAt = 0;
        private decimal _projProfit = 0;
        private decimal _reinvestedAmt = 0;
        private decimal _totalProjProfit = 0;
        private decimal _openQty = 0;
        private decimal _closeQty = 0;
        private decimal _qtyReinvested = 0;
        private decimal _avgPrice = 0;
        private decimal _priceChangePercent = 0;
        private decimal _profitPercent = 0;
        private List<int> _avgDownPercentageList = new List<int>() { 20, 30, 40, 50 };

        public MainForm()
        {
            InitializeComponent();
        }

        private void OpenQtyTextChanged(object sender, EventArgs e)
        {
            ttipTradingCal.Hide(txtOpenQty);
            gbTakeProfit.Enabled = false;

            UpdateQtyAndPrice();

            if (string.IsNullOrWhiteSpace(txtOpenQty.Text))
            {
                ttipTradingCal.ToolTipIcon = ToolTipIcon.Warning;
                ttipTradingCal.ToolTipTitle = "Empty Field";
                ttipTradingCal.Show("Please enter quantity.", txtOpenQty, 50, -20, 2000);
            }
            else if (_openQty <= 0)
            {
                ttipTradingCal.ToolTipIcon = ToolTipIcon.Error;
                ttipTradingCal.ToolTipTitle = "Invalid Field";
                ttipTradingCal.Show("Quantity entered is invalid.", txtOpenQty, 50, -20);
            }
            else
            {
                EnableComboBoxes();
            }
        }

        private void AvgPriceTextChanged(object sender, EventArgs e)
        {
            ttipTradingCal.Hide(txtAvgPrice);
            gbTakeProfit.Enabled = false;
            gbAvgDown.Enabled = false;

            UpdateQtyAndPrice();

            if (string.IsNullOrWhiteSpace(txtAvgPrice.Text))
            {
                ttipTradingCal.ToolTipIcon = ToolTipIcon.Warning;
                ttipTradingCal.ToolTipTitle = "Empty Field";
                ttipTradingCal.Show("Please enter price.", txtAvgPrice, 50, -20, 2000);
            }
            else if (_avgPrice <= 0)
            {
                ttipTradingCal.ToolTipIcon = ToolTipIcon.Error;
                ttipTradingCal.ToolTipTitle = "Invalid Field";
                ttipTradingCal.Show("Price entered is invalid.", txtAvgPrice, 50, -20);
            }
            else
            {
                EnableComboBoxes();
            }
        }

        #region Average Down Combo Box

        private void CustomPercentTextChanged(object sender, EventArgs e)
        {
            ttipTradingCal.Hide(txtAvgDownPercent);
            decimal customPercent = ConvertTxtToDecimal(txtAvgDownPercent.Text);

            if (string.IsNullOrWhiteSpace(txtAvgDownPercent.Text))
            {
                lblPriceTargetCustom.Text = $"0";
            }
            else if (customPercent <= 0)
            {
                ttipTradingCal.ToolTipIcon = ToolTipIcon.Error;
                ttipTradingCal.ToolTipTitle = "Invalid Field";
                ttipTradingCal.Show("Percent entered is invalid.", txtAvgDownPercent, 50, -20, 2000);
                lblPriceTargetCustom.Text = $"0";
            }
            else if (customPercent > 100)
            {
                ttipTradingCal.ToolTipIcon = ToolTipIcon.Error;
                ttipTradingCal.ToolTipTitle = "Invalid Field";
                ttipTradingCal.Show("Percent entered cannot exceed 100.", txtAvgDownPercent, 10, -20);
            }
            else
            {
                decimal percent = customPercent / 100;
                lblPriceTargetCustom.Text = $"${_avgPrice - (_avgPrice * percent)}";
            }
        }

        private void AverageDownComboBoxEnabledChanged(object sender, EventArgs e)
        {
            if (!((GroupBox)sender).Enabled)
            {
                ResetAvgDownFields();
            }
            else
            {
                UpdateAveDown();
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

        private void UpdateAveDown()
        {
            lblAvgDown1.Text = $"{_avgDownPercentageList[0]}";
            lblAvgDown2.Text = $"{_avgDownPercentageList[1]}";
            lblAvgDown3.Text = $"{_avgDownPercentageList[2]}";
            lblAvgDown4.Text = $"{_avgDownPercentageList[3]}";

            lblPriceTarget1.Text = $"${_avgPrice - (_avgPrice * (Convert.ToDecimal(_avgDownPercentageList[0]) / 100))}";
            lblPriceTarget2.Text = $"${_avgPrice - (_avgPrice * (Convert.ToDecimal(_avgDownPercentageList[1]) / 100))}";
            lblPriceTarget3.Text = $"${_avgPrice - (_avgPrice * (Convert.ToDecimal(_avgDownPercentageList[2]) / 100))}";
            lblPriceTarget4.Text = $"${_avgPrice - (_avgPrice * (Convert.ToDecimal(_avgDownPercentageList[3]) / 100))}";
        }

        #endregion Average Down Box

        #region Take Profit Combo box.

        private void PricePercentChanged(object sender, EventArgs e)
        {
            chkReinvestProfit.Enabled = false;
            _priceChangePercent = ConvertTxtToDecimal(cboPercents.Text);

            if (gbTakeProfit.Enabled)
            {
                if (string.IsNullOrWhiteSpace(cboPercents.Text))
                {
                    chkReinvestProfit.Checked = false;
                    chkReinvestProfit.Enabled = false;
                    ResetTakeProfitFields();

                    ttipTradingCal.ToolTipIcon = ToolTipIcon.Warning;
                    ttipTradingCal.ToolTipTitle = "Empty Field";
                    ttipTradingCal.Show("Please enter percent.", cboPercents, 10, -20, 2000);
                }
                else if (_priceChangePercent <= 0)
                {
                    ttipTradingCal.ToolTipIcon = ToolTipIcon.Error;
                    ttipTradingCal.ToolTipTitle = "Invalid Field";
                    ttipTradingCal.Show("Percent entered is invalid.", cboPercents, 10, -20, 2000);
                    cboPercents.SelectedIndex = 0;
                }
                else
                {
                    chkReinvestProfit.Enabled = true;
                    CalculateTakeProfitNumbers(_priceChangePercent);
                }
            }
        }

        private void ReinvestProfitCheckChanged(object sender, EventArgs e)
        {
            _profitPercent = 0;
            _qtyReinvested = 0;
            txtProfitPercent.Text = $"";
            lblQuantityReinvested.Text = $"{_qtyReinvested}";

            gbReinvestProfit.Enabled = chkReinvestProfit.Checked;
        }

        private void ProfitPercentTxtChanged(object sender, EventArgs e)
        {
            ttipTradingCal.Hide(txtProfitPercent);
            _profitPercent = ConvertTxtToDecimal(txtProfitPercent.Text);

            if (string.IsNullOrWhiteSpace(txtProfitPercent.Text))
            {
                _qtyReinvested = 0;
                lblQuantityReinvested.Text = $"{_qtyReinvested}";
                CalculateTakeProfitNumbers(_priceChangePercent);
            }
            else if (_profitPercent <= 0 && chkReinvestProfit.Checked)
            {
                ttipTradingCal.ToolTipIcon = ToolTipIcon.Error;
                ttipTradingCal.ToolTipTitle = "Invalid Field";
                ttipTradingCal.Show("Percent entered is invalid.", txtProfitPercent, 10, -20, 2000);
            }
            else if (_profitPercent > 100)
            {
                ttipTradingCal.ToolTipIcon = ToolTipIcon.Error;
                ttipTradingCal.ToolTipTitle = "Invalid Field";
                ttipTradingCal.Show("Percent entered cannot exceed 100.", txtProfitPercent, 10, -20);
            }
            else
            {
                txtProfitPercent.Text = (chkReinvestProfit.Checked) ? _profitPercent.ToString() : "";
                lblQuantityReinvested.Text = CalculateReinvestedQty(_profitPercent);
                CalculateTakeProfitNumbers(_priceChangePercent);
            }
        }

        private void TakeProfitComboBoxEnabledChanged(object sender, EventArgs e)
        {
            if (!((GroupBox)sender).Enabled)
            {
                chkReinvestProfit.Checked = false;
                ResetTakeProfitFields();
            }
        }

        private void ResetTakeProfitFields()
        {
            _priceChangePercent = 0;
            cboPercents.Text = "";

            _closeQty = 0;
            _limitSellAt = 0;
            _projProfit = 0;
            _reinvestedAmt = 0;
            _totalProjProfit = 0;

            lblCloseQty.Text = $"{_closeQty}";
            lblLimitSellAt.Text = $"{_limitSellAt:C2}";
            lblProjProfit.Text = $"{_projProfit:C2}";
            lblReinvestedAmt.Text = $"-{_reinvestedAmt:C2}";
            lblTotalProjProfit.Text = $"{_totalProjProfit:C2}";
        }

        private string CalculateReinvestedQty(decimal profitPercent)
        {
            decimal reinvestedAmount = (_projProfit * (_profitPercent / 100));
            _qtyReinvested = reinvestedAmount / _limitSellAt;

            return _qtyReinvested.ToString();
        }

        private void CalculateTakeProfitNumbers(decimal priceChangePercent)
        {
            _closeQty = _openQty - _qtyReinvested;
            _limitSellAt = _avgPrice * (1 + (priceChangePercent / 100));
            _projProfit = _limitSellAt * _openQty;

            if (_profitPercent != 0)
            {
                _reinvestedAmt = _qtyReinvested * _limitSellAt;
                _totalProjProfit = _projProfit - _reinvestedAmt;
            }
            else
            {
                _reinvestedAmt = 0;
                _totalProjProfit = _projProfit;
            }

            lblCloseQty.Text = $"{_closeQty}";
            lblLimitSellAt.Text = $"{_limitSellAt:C2}";
            lblProjProfit.Text = $"{_projProfit:C2}";
            lblReinvestedAmt.Text = $"-{_reinvestedAmt:C2}";
            lblTotalProjProfit.Text = $"{_totalProjProfit:C2}";
        }

        #endregion Take Profit Combo box.

        #region Shared Methods

        private void ClearAllClicked(object sender, EventArgs e)
        {
            _openQty = 0;
            _avgPrice = 0;

            txtOpenQty.Text = "";
            txtAvgPrice.Text = "";

            gbAvgDown.Enabled = false;
            gbTakeProfit.Enabled = false;
        }

        private void UpdateQtyAndPrice()
        {
            _avgPrice = ConvertTxtToDecimal(txtAvgPrice.Text);
            _openQty = ConvertTxtToDecimal(txtOpenQty.Text);
        }

        private void EnableComboBoxes()
        {
            if (_openQty != 0 && _avgPrice != 0)
            {
                gbTakeProfit.Enabled = true;
            }

            if (_avgPrice != 0)
            {
                gbAvgDown.Enabled = true;
            }
        }

        private decimal ConvertTxtToDecimal(string txt)
        {
            //Returns 0 if conversion fails.
            bool isNumberic = decimal.TryParse(txt, out decimal x);
            return x;
        }

        #endregion Shared Methods

        private void CloseForm(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}