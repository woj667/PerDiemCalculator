using Newtonsoft.Json;
using PerDiemCalculatorLib;
using PerDiemCalculatorLib.Api;
using PerDiemCalculatorLib.Models;
using System;
using System.Globalization;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PerDiemUI
{
    public partial class CalculatorForm : Form
    {
        private readonly ICurrencyExchangeEndpoint _currencyExchangeEndpoint = new CurrencyExchangeEndpoint();
        private readonly IDataConnection _csvConnector = new CSVConnector();

        private BusinessTripModel _bussinesTrip = new();
        private DestinationModel _destination = new();
        private PerDiemModel _perDiem = new();

        public CalculatorForm()
        {
            InitializeComponent();
            WireUpCountries();
            InitializeBusinessTrip();
            toolStripStatusLabel.MessageReady();
        }

        private void WireUpCountries()
        {
            CountryDropDown.DataSource = _csvConnector.GetAllCountries();
            CountryDropDown.DisplayMember = "Name";
        }

        private void InitializeBusinessTrip()
        {
            SetBusinessTripStart();
            SetBusinessTripFinish();
            DisplayTripDuration();
        }

        private void DisplayDestination()
        {
            currencyValue.Text = currencyValue2.Text = _destination.Currency;
            perDiemValue.Text = _destination.PerDiem.ToString();
        }

        private void DisplayTripDuration()
        {
            tripDaysValue.Text = _bussinesTrip.Duration.Days.ToString();
            tripHoursValue.Text = _bussinesTrip.Duration.Hours.ToString();
            tripMinutesValue.Text = _bussinesTrip.Duration.Minutes.ToString();
        }

        private void DisplayPerDiem()
        {
            NumberFormatInfo precision = new() { NumberDecimalDigits = 2 };

            totalAllowanceValue.Text = _perDiem.TotalAllowance.ToString("N", precision);
            totalAllowanceExchangedValue.Text = _perDiem.TotalAllowanceExchanged.ToString("N", precision);
            balanceValue.Text = _perDiem.Balance.ToString("N", precision);
        }

        private async Task GetCurrentExchangeRate()
        {
            try
            {
                var exchangeRate = await _currencyExchangeEndpoint.GetExchangeRate(_destination.Currency);
                _perDiem.ExchangeRate = exchangeRate;
                exchangeRateValue.Text = exchangeRate.ToString();
            }
            catch (Exception ex)
            {
                var errorMessage = JsonConvert.DeserializeObject<ErrorMessageModel>(ex.Message);
                MessageBox.Show(errorMessage.Text, errorMessage.Caption);
            }
        }

        private void calculateButton_Click(object sender, EventArgs e)
        {
            if (Validator.IsTripDurationValid(_bussinesTrip.Duration))
            {
                _perDiem.TotalAllowance = PerDiemProcessor.CalculateTotalAllowance(_bussinesTrip.Duration, _destination.PerDiem);
                DisplayPerDiem();
                toolStripStatusLabel.MessageDone();
                return;
            }

            toolStripStatusLabel.MessageTripDurationHasToBePositive();
        }

        private void CountryDropDown_SelectedIndexChanged(object sender, EventArgs e)
        {
            var selectedCountry = (DestinationModel)CountryDropDown.SelectedItem;

            _destination = selectedCountry;
            DisplayDestination();
            toolStripStatusLabel.MessageReady();
        }

        private void tripStartDate_ValueChanged(object sender, EventArgs e)
        {
            SetBusinessTripStart();
            DisplayTripDuration();
            toolStripStatusLabel.MessageReady();
        }

        private void SetBusinessTripStart()
        {
            int day = tripStartDMY.Value.Day;
            int month = tripStartDMY.Value.Month;
            int year = tripStartDMY.Value.Year;

            int hour = tripStartHM.Value.Hour;
            int minute = tripStartHM.Value.Minute;
            int second = 0;

            _bussinesTrip.Start = new DateTime(year, month, day, hour, minute, second);
        }

        private void SetBusinessTripFinish()
        {
            int day = tripFinishDMY.Value.Day;
            int month = tripFinishDMY.Value.Month;
            int year = tripFinishDMY.Value.Year;

            int hour = tripFinishHM.Value.Hour;
            int minute = tripFinishHM.Value.Minute;
            int second = 0;

            _bussinesTrip.Finish = new DateTime(year, month, day, hour, minute, second);
        }

        private void tripFinishDate_ValueChanged(object sender, EventArgs e)
        {
            SetBusinessTripFinish();
            DisplayTripDuration();
            toolStripStatusLabel.MessageReady();
        }

        private void exchangeRateValue_Leave(object sender, EventArgs e)
        {
            if (decimal.TryParse(exchangeRateValue.Text, out decimal exchangeRate) && Validator.IsExchangeRateValid(exchangeRate))
            {
                _perDiem.ExchangeRate = exchangeRate;
                toolStripStatusLabel.MessageReady();
                return;
            }

            exchangeRateValue.Text = _perDiem.ExchangeRate.ToString();
            toolStripStatusLabel.MessageExchangeRateWrongFormat();
        }

        private void advancePaymentValue_Leave(object sender, EventArgs e)
        {
            if (decimal.TryParse(advancePaymentValue.Text, out decimal advancePayment))
            {
                _perDiem.AdvancePayment = advancePayment;
                toolStripStatusLabel.MessageReady();
                return;
            }

            advancePaymentValue.Text = _perDiem.AdvancePayment.ToString();
            toolStripStatusLabel.MessageAdvanePaymentWrongFormat();
        }

        private async void currentExchangeRateCheckBox_CheckedChanged(object sender, EventArgs e)
        {
            if (currentExchangeRateCheckBox.Checked)
            {
                await GetCurrentExchangeRate();

                exchangeRateValue.Enabled = false;
            }
            else
            {
                exchangeRateValue.Enabled = true;
            }
        }

        private async void currencyValue_TextChanged(object sender, EventArgs e)
        {
            if (currentExchangeRateCheckBox.Checked)
            {
                await GetCurrentExchangeRate();
            }
        }
    }
}