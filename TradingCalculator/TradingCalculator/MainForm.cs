using System;
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
        private decimal _customPercent = 0;
        private decimal _priceChangePercent = 0;
        private decimal _profitPercent = 0;
        private List<int> _avgDownPercentageList = new List<int>() { 20, 30, 40, 50 };

        public MainForm()
        {
            InitializeComponent();
        }

        private void OpenQtyTextChanged(object sender, EventArgs e)
        {
            ttipOpenQty.Hide(txtOpenQty);
            gbTakeProfit.Enabled = false;

            UpdateQtyAndPrice();

            if (string.IsNullOrWhiteSpace(txtOpenQty.Text))
            {
                ttipOpenQty.ToolTipIcon = ToolTipIcon.Warning;
                ttipOpenQty.ToolTipTitle = "Empty Field";
                ttipOpenQty.Show("Please enter quantity.", txtOpenQty, 50, -20, 2000);
            }
            else if (_openQty <= 0)
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
            else if (_avgPrice <= 0)
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

        #region Average Down Box

        private void CustomPercentTextChanged(object sender, EventArgs e)
        {
            ttipCustomPercent.Hide(txtAvgDownPercent);
            decimal customPercent = ConvertTxtToDecimal(txtAvgDownPercent.Text);

            if (string.IsNullOrWhiteSpace(txtAvgDownPercent.Text))
            {
                lblPriceTargetCustom.Text = $"0";
            }
            else if (customPercent <= 0)
            {
                ttipCustomPercent.ToolTipIcon = ToolTipIcon.Error;
                ttipCustomPercent.ToolTipTitle = "Invalid Field";
                ttipCustomPercent.Show("Percent entered is invalid.", txtAvgDownPercent, 50, -20, 2000);
                lblPriceTargetCustom.Text = $"0";
            }
            else
            {
                decimal percent = customPercent / 100;
                lblPriceTargetCustom.Text = $"${_avgPrice - (_avgPrice * percent)}";
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
            _priceChangePercent = ConvertTxtToDecimal(cboPercents.Text);

            if (string.IsNullOrWhiteSpace(cboPercents.Text))
            {
                ttipPriceChangePercent.ToolTipIcon = ToolTipIcon.Warning;
                ttipPriceChangePercent.ToolTipTitle = "Empty Field";
                ttipPriceChangePercent.Show("Please enter percent.", cboPercents, 10, -20, 2000);
            }
            else if (_priceChangePercent <= 0)
            {
                ttipPriceChangePercent.ToolTipIcon = ToolTipIcon.Error;
                ttipPriceChangePercent.ToolTipTitle = "Invalid Field";
                ttipPriceChangePercent.Show("Percent entered is invalid.", cboPercents, 10, -20, 2000);
                cboPercents.SelectedIndex = 0;
            }
            else
            {
                CalculateTakeProfitNumbers(_priceChangePercent);
            }
        }

        private void ReinvestProfitCheckChanged(object sender, EventArgs e)
        {
            _profitPercent = 0;
            _qtyReinvested = 0;
            txtProfitPercent.Text = $"";
            lblQuantityReinvested.Text = $"{_qtyReinvested}";

            if (chkReinvestProfit.Checked)
            {
                gbReinvestProfit.Enabled = true;
            }
            else
            {
                gbReinvestProfit.Enabled = false;
            }
        }

        private void ProfitPercentTxtChanged(object sender, EventArgs e)
        {
            _profitPercent = ConvertTxtToDecimal(txtProfitPercent.Text);

            if (string.IsNullOrWhiteSpace(txtProfitPercent.Text) && chkReinvestProfit.Checked)
            {
                ttipProfitPercent.ToolTipIcon = ToolTipIcon.Warning;
                ttipProfitPercent.ToolTipTitle = "Empty Field";
                ttipProfitPercent.Show("Please enter percent.", txtProfitPercent, 10, -20, 2000);
            }
            else if (_profitPercent <= 0 && chkReinvestProfit.Checked)
            {
                ttipProfitPercent.ToolTipIcon = ToolTipIcon.Error;
                ttipProfitPercent.ToolTipTitle = "Invalid Field";
                ttipProfitPercent.Show("Percent entered is invalid.", txtProfitPercent, 10, -20, 2000);
            }
            else
            {
                txtProfitPercent.Text = (chkReinvestProfit.Checked) ? _profitPercent.ToString() : "";
                CalculateTakeProfitNumbers(_priceChangePercent);
                lblQuantityReinvested.Text = CalculateReinvestedQty(_profitPercent);
            }
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
            _limitSellAt = _avgPrice * (1 + (_priceChangePercent / 100));
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
                UpdateAveDown();
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