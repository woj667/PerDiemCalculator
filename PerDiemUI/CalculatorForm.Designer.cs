
namespace PerDiemUI
{
    partial class CalculatorForm
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.tripStartDMY = new System.Windows.Forms.DateTimePicker();
            this.tripFinishDMY = new System.Windows.Forms.DateTimePicker();
            this.tripDaysLabel = new System.Windows.Forms.Label();
            this.calculateButton = new System.Windows.Forms.Button();
            this.labelStart = new System.Windows.Forms.Label();
            this.labelFinish = new System.Windows.Forms.Label();
            this.CountryDropDown = new System.Windows.Forms.ComboBox();
            this.currencyValue = new System.Windows.Forms.Label();
            this.perDiemValue = new System.Windows.Forms.Label();
            this.currencyLabel = new System.Windows.Forms.Label();
            this.perDiemLabel = new System.Windows.Forms.Label();
            this.hoursLabel = new System.Windows.Forms.Label();
            this.tripDaysValue = new System.Windows.Forms.Label();
            this.tripHoursValue = new System.Windows.Forms.Label();
            this.totalAllowanceLabel = new System.Windows.Forms.Label();
            this.totalAllowanceValue = new System.Windows.Forms.Label();
            this.exchangeRateValue = new System.Windows.Forms.TextBox();
            this.labelExchangeRate = new System.Windows.Forms.Label();
            this.currencyValue2 = new System.Windows.Forms.Label();
            this.plnLabel = new System.Windows.Forms.Label();
            this.totalAllowanceExchangedValue = new System.Windows.Forms.Label();
            this.currentExchangeRateCheckBox = new System.Windows.Forms.CheckBox();
            this.advancePaymentLabel = new System.Windows.Forms.Label();
            this.advancePaymentValue = new System.Windows.Forms.TextBox();
            this.balanceValue = new System.Windows.Forms.Label();
            this.balanceLabel = new System.Windows.Forms.Label();
            this.plnLabel2 = new System.Windows.Forms.Label();
            this.destinationGroupBox = new System.Windows.Forms.GroupBox();
            this.countryLabel = new System.Windows.Forms.Label();
            this.datesGroupBox = new System.Windows.Forms.GroupBox();
            this.tripFinishHM = new System.Windows.Forms.DateTimePicker();
            this.tripStartHM = new System.Windows.Forms.DateTimePicker();
            this.minutesLabel = new System.Windows.Forms.Label();
            this.tripMinutesValue = new System.Windows.Forms.Label();
            this.calculationGroupBox = new System.Windows.Forms.GroupBox();
            this.ResultGroupBox = new System.Windows.Forms.GroupBox();
            this.statusStrip = new System.Windows.Forms.StatusStrip();
            this.toolStripStatusLabel = new System.Windows.Forms.ToolStripStatusLabel();
            this.destinationGroupBox.SuspendLayout();
            this.datesGroupBox.SuspendLayout();
            this.calculationGroupBox.SuspendLayout();
            this.ResultGroupBox.SuspendLayout();
            this.statusStrip.SuspendLayout();
            this.SuspendLayout();
            // 
            // tripStartDMY
            // 
            this.tripStartDMY.CustomFormat = "dd/MM/yyyy";
            this.tripStartDMY.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.tripStartDMY.Location = new System.Drawing.Point(71, 25);
            this.tripStartDMY.Name = "tripStartDMY";
            this.tripStartDMY.Size = new System.Drawing.Size(123, 23);
            this.tripStartDMY.TabIndex = 0;
            this.tripStartDMY.ValueChanged += new System.EventHandler(this.tripStartDate_ValueChanged);
            // 
            // tripFinishDMY
            // 
            this.tripFinishDMY.CustomFormat = "dd/MM/yyyy";
            this.tripFinishDMY.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.tripFinishDMY.Location = new System.Drawing.Point(71, 59);
            this.tripFinishDMY.Name = "tripFinishDMY";
            this.tripFinishDMY.Size = new System.Drawing.Size(123, 23);
            this.tripFinishDMY.TabIndex = 0;
            this.tripFinishDMY.ValueChanged += new System.EventHandler(this.tripFinishDate_ValueChanged);
            // 
            // tripDaysLabel
            // 
            this.tripDaysLabel.AutoSize = true;
            this.tripDaysLabel.Location = new System.Drawing.Point(308, 29);
            this.tripDaysLabel.Name = "tripDaysLabel";
            this.tripDaysLabel.Size = new System.Drawing.Size(32, 15);
            this.tripDaysLabel.TabIndex = 1;
            this.tripDaysLabel.Text = "Days";
            this.tripDaysLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // calculateButton
            // 
            this.calculateButton.Location = new System.Drawing.Point(12, 430);
            this.calculateButton.Name = "calculateButton";
            this.calculateButton.Size = new System.Drawing.Size(486, 37);
            this.calculateButton.TabIndex = 2;
            this.calculateButton.Text = "Calculate";
            this.calculateButton.UseVisualStyleBackColor = true;
            this.calculateButton.Click += new System.EventHandler(this.calculateButton_Click);
            // 
            // labelStart
            // 
            this.labelStart.AutoSize = true;
            this.labelStart.Location = new System.Drawing.Point(11, 29);
            this.labelStart.Name = "labelStart";
            this.labelStart.Size = new System.Drawing.Size(31, 15);
            this.labelStart.TabIndex = 3;
            this.labelStart.Text = "Start";
            this.labelStart.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // labelFinish
            // 
            this.labelFinish.AutoSize = true;
            this.labelFinish.Location = new System.Drawing.Point(11, 63);
            this.labelFinish.Name = "labelFinish";
            this.labelFinish.Size = new System.Drawing.Size(38, 15);
            this.labelFinish.TabIndex = 3;
            this.labelFinish.Text = "Finish";
            this.labelFinish.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // CountryDropDown
            // 
            this.CountryDropDown.FormattingEnabled = true;
            this.CountryDropDown.Location = new System.Drawing.Point(71, 42);
            this.CountryDropDown.Name = "CountryDropDown";
            this.CountryDropDown.Size = new System.Drawing.Size(200, 23);
            this.CountryDropDown.TabIndex = 4;
            this.CountryDropDown.SelectedIndexChanged += new System.EventHandler(this.CountryDropDown_SelectedIndexChanged);
            // 
            // currencyValue
            // 
            this.currencyValue.AutoSize = true;
            this.currencyValue.Location = new System.Drawing.Point(308, 46);
            this.currencyValue.Name = "currencyValue";
            this.currencyValue.Size = new System.Drawing.Size(69, 15);
            this.currencyValue.TabIndex = 3;
            this.currencyValue.Text = "<currency>";
            this.currencyValue.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.currencyValue.TextChanged += new System.EventHandler(this.currencyValue_TextChanged);
            // 
            // perDiemValue
            // 
            this.perDiemValue.AutoSize = true;
            this.perDiemValue.Location = new System.Drawing.Point(405, 46);
            this.perDiemValue.Name = "perDiemValue";
            this.perDiemValue.Size = new System.Drawing.Size(70, 15);
            this.perDiemValue.TabIndex = 3;
            this.perDiemValue.Text = "<per diem>";
            this.perDiemValue.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // currencyLabel
            // 
            this.currencyLabel.AutoSize = true;
            this.currencyLabel.Location = new System.Drawing.Point(308, 19);
            this.currencyLabel.Name = "currencyLabel";
            this.currencyLabel.Size = new System.Drawing.Size(55, 15);
            this.currencyLabel.TabIndex = 3;
            this.currencyLabel.Text = "Currency";
            this.currencyLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // perDiemLabel
            // 
            this.perDiemLabel.AutoSize = true;
            this.perDiemLabel.Location = new System.Drawing.Point(405, 19);
            this.perDiemLabel.Name = "perDiemLabel";
            this.perDiemLabel.Size = new System.Drawing.Size(55, 15);
            this.perDiemLabel.TabIndex = 3;
            this.perDiemLabel.Text = "Per Diem";
            this.perDiemLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // hoursLabel
            // 
            this.hoursLabel.AutoSize = true;
            this.hoursLabel.Location = new System.Drawing.Point(361, 29);
            this.hoursLabel.Name = "hoursLabel";
            this.hoursLabel.Size = new System.Drawing.Size(39, 15);
            this.hoursLabel.TabIndex = 1;
            this.hoursLabel.Text = "Hours";
            this.hoursLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // tripDaysValue
            // 
            this.tripDaysValue.AutoSize = true;
            this.tripDaysValue.Location = new System.Drawing.Point(308, 63);
            this.tripDaysValue.Name = "tripDaysValue";
            this.tripDaysValue.Size = new System.Drawing.Size(47, 15);
            this.tripDaysValue.TabIndex = 1;
            this.tripDaysValue.Text = "<days>";
            this.tripDaysValue.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // tripHoursValue
            // 
            this.tripHoursValue.AutoSize = true;
            this.tripHoursValue.Location = new System.Drawing.Point(361, 63);
            this.tripHoursValue.Name = "tripHoursValue";
            this.tripHoursValue.Size = new System.Drawing.Size(53, 15);
            this.tripHoursValue.TabIndex = 1;
            this.tripHoursValue.Text = "<hours>";
            this.tripHoursValue.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // totalAllowanceLabel
            // 
            this.totalAllowanceLabel.AutoSize = true;
            this.totalAllowanceLabel.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.totalAllowanceLabel.Location = new System.Drawing.Point(6, 19);
            this.totalAllowanceLabel.Name = "totalAllowanceLabel";
            this.totalAllowanceLabel.Size = new System.Drawing.Size(94, 15);
            this.totalAllowanceLabel.TabIndex = 1;
            this.totalAllowanceLabel.Text = "Total Allowance";
            this.totalAllowanceLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // totalAllowanceValue
            // 
            this.totalAllowanceValue.AutoSize = true;
            this.totalAllowanceValue.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.totalAllowanceValue.Location = new System.Drawing.Point(198, 19);
            this.totalAllowanceValue.Name = "totalAllowanceValue";
            this.totalAllowanceValue.Size = new System.Drawing.Size(107, 15);
            this.totalAllowanceValue.TabIndex = 1;
            this.totalAllowanceValue.Text = "<total allowance>";
            this.totalAllowanceValue.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // exchangeRateValue
            // 
            this.exchangeRateValue.Location = new System.Drawing.Point(171, 24);
            this.exchangeRateValue.Name = "exchangeRateValue";
            this.exchangeRateValue.Size = new System.Drawing.Size(101, 23);
            this.exchangeRateValue.TabIndex = 5;
            this.exchangeRateValue.Text = "1";
            this.exchangeRateValue.Leave += new System.EventHandler(this.exchangeRateValue_Leave);
            // 
            // labelExchangeRate
            // 
            this.labelExchangeRate.AutoSize = true;
            this.labelExchangeRate.Location = new System.Drawing.Point(11, 28);
            this.labelExchangeRate.Name = "labelExchangeRate";
            this.labelExchangeRate.Size = new System.Drawing.Size(84, 15);
            this.labelExchangeRate.TabIndex = 3;
            this.labelExchangeRate.Text = "Exchange Rate";
            this.labelExchangeRate.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // currencyValue2
            // 
            this.currencyValue2.AutoSize = true;
            this.currencyValue2.Location = new System.Drawing.Point(390, 19);
            this.currencyValue2.Name = "currencyValue2";
            this.currencyValue2.Size = new System.Drawing.Size(69, 15);
            this.currencyValue2.TabIndex = 3;
            this.currencyValue2.Text = "<currency>";
            this.currencyValue2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // plnLabel
            // 
            this.plnLabel.AutoSize = true;
            this.plnLabel.Location = new System.Drawing.Point(390, 49);
            this.plnLabel.Name = "plnLabel";
            this.plnLabel.Size = new System.Drawing.Size(29, 15);
            this.plnLabel.TabIndex = 3;
            this.plnLabel.Text = "PLN";
            this.plnLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // totalAllowanceExchangedValue
            // 
            this.totalAllowanceExchangedValue.AutoSize = true;
            this.totalAllowanceExchangedValue.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.totalAllowanceExchangedValue.Location = new System.Drawing.Point(198, 49);
            this.totalAllowanceExchangedValue.Name = "totalAllowanceExchangedValue";
            this.totalAllowanceExchangedValue.Size = new System.Drawing.Size(113, 15);
            this.totalAllowanceExchangedValue.TabIndex = 1;
            this.totalAllowanceExchangedValue.Text = "<total exchanged>";
            this.totalAllowanceExchangedValue.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // currentExchangeRateCheckBox
            // 
            this.currentExchangeRateCheckBox.AutoSize = true;
            this.currentExchangeRateCheckBox.Location = new System.Drawing.Point(308, 26);
            this.currentExchangeRateCheckBox.Name = "currentExchangeRateCheckBox";
            this.currentExchangeRateCheckBox.Size = new System.Drawing.Size(64, 19);
            this.currentExchangeRateCheckBox.TabIndex = 6;
            this.currentExchangeRateCheckBox.Text = "current";
            this.currentExchangeRateCheckBox.UseVisualStyleBackColor = true;
            this.currentExchangeRateCheckBox.CheckedChanged += new System.EventHandler(this.currentExchangeRateCheckBox_CheckedChanged);
            // 
            // advancePaymentLabel
            // 
            this.advancePaymentLabel.AutoSize = true;
            this.advancePaymentLabel.Location = new System.Drawing.Point(11, 64);
            this.advancePaymentLabel.Name = "advancePaymentLabel";
            this.advancePaymentLabel.Size = new System.Drawing.Size(103, 15);
            this.advancePaymentLabel.TabIndex = 3;
            this.advancePaymentLabel.Text = "Advance Payment";
            this.advancePaymentLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // advancePaymentValue
            // 
            this.advancePaymentValue.Location = new System.Drawing.Point(130, 60);
            this.advancePaymentValue.Name = "advancePaymentValue";
            this.advancePaymentValue.Size = new System.Drawing.Size(141, 23);
            this.advancePaymentValue.TabIndex = 5;
            this.advancePaymentValue.Text = "0";
            this.advancePaymentValue.Leave += new System.EventHandler(this.advancePaymentValue_Leave);
            // 
            // balanceValue
            // 
            this.balanceValue.AutoSize = true;
            this.balanceValue.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.balanceValue.Location = new System.Drawing.Point(198, 79);
            this.balanceValue.Name = "balanceValue";
            this.balanceValue.Size = new System.Drawing.Size(65, 15);
            this.balanceValue.TabIndex = 1;
            this.balanceValue.Text = "<balance>";
            this.balanceValue.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // balanceLabel
            // 
            this.balanceLabel.AutoSize = true;
            this.balanceLabel.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.balanceLabel.Location = new System.Drawing.Point(47, 79);
            this.balanceLabel.Name = "balanceLabel";
            this.balanceLabel.Size = new System.Drawing.Size(53, 15);
            this.balanceLabel.TabIndex = 1;
            this.balanceLabel.Text = "Balance:";
            this.balanceLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // plnLabel2
            // 
            this.plnLabel2.AutoSize = true;
            this.plnLabel2.Location = new System.Drawing.Point(390, 80);
            this.plnLabel2.Name = "plnLabel2";
            this.plnLabel2.Size = new System.Drawing.Size(29, 15);
            this.plnLabel2.TabIndex = 3;
            this.plnLabel2.Text = "PLN";
            this.plnLabel2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // destinationGroupBox
            // 
            this.destinationGroupBox.Controls.Add(this.CountryDropDown);
            this.destinationGroupBox.Controls.Add(this.currencyValue);
            this.destinationGroupBox.Controls.Add(this.perDiemValue);
            this.destinationGroupBox.Controls.Add(this.countryLabel);
            this.destinationGroupBox.Controls.Add(this.currencyLabel);
            this.destinationGroupBox.Controls.Add(this.perDiemLabel);
            this.destinationGroupBox.Location = new System.Drawing.Point(12, 12);
            this.destinationGroupBox.Name = "destinationGroupBox";
            this.destinationGroupBox.Size = new System.Drawing.Size(486, 85);
            this.destinationGroupBox.TabIndex = 7;
            this.destinationGroupBox.TabStop = false;
            this.destinationGroupBox.Text = "Destination";
            // 
            // countryLabel
            // 
            this.countryLabel.AutoSize = true;
            this.countryLabel.Location = new System.Drawing.Point(11, 46);
            this.countryLabel.Name = "countryLabel";
            this.countryLabel.Size = new System.Drawing.Size(50, 15);
            this.countryLabel.TabIndex = 3;
            this.countryLabel.Text = "Country";
            this.countryLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // datesGroupBox
            // 
            this.datesGroupBox.Controls.Add(this.tripFinishDMY);
            this.datesGroupBox.Controls.Add(this.tripFinishHM);
            this.datesGroupBox.Controls.Add(this.tripStartHM);
            this.datesGroupBox.Controls.Add(this.tripStartDMY);
            this.datesGroupBox.Controls.Add(this.tripDaysLabel);
            this.datesGroupBox.Controls.Add(this.tripDaysValue);
            this.datesGroupBox.Controls.Add(this.minutesLabel);
            this.datesGroupBox.Controls.Add(this.tripMinutesValue);
            this.datesGroupBox.Controls.Add(this.hoursLabel);
            this.datesGroupBox.Controls.Add(this.tripHoursValue);
            this.datesGroupBox.Controls.Add(this.labelStart);
            this.datesGroupBox.Controls.Add(this.labelFinish);
            this.datesGroupBox.Location = new System.Drawing.Point(12, 103);
            this.datesGroupBox.Name = "datesGroupBox";
            this.datesGroupBox.Size = new System.Drawing.Size(486, 100);
            this.datesGroupBox.TabIndex = 8;
            this.datesGroupBox.TabStop = false;
            this.datesGroupBox.Text = "Dates";
            // 
            // tripFinishHM
            // 
            this.tripFinishHM.CustomFormat = "HH:mm";
            this.tripFinishHM.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.tripFinishHM.Location = new System.Drawing.Point(200, 59);
            this.tripFinishHM.Name = "tripFinishHM";
            this.tripFinishHM.ShowUpDown = true;
            this.tripFinishHM.Size = new System.Drawing.Size(73, 23);
            this.tripFinishHM.TabIndex = 0;
            this.tripFinishHM.ValueChanged += new System.EventHandler(this.tripFinishDate_ValueChanged);
            // 
            // tripStartHM
            // 
            this.tripStartHM.CustomFormat = "HH:mm";
            this.tripStartHM.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.tripStartHM.Location = new System.Drawing.Point(200, 25);
            this.tripStartHM.Name = "tripStartHM";
            this.tripStartHM.ShowUpDown = true;
            this.tripStartHM.Size = new System.Drawing.Size(73, 23);
            this.tripStartHM.TabIndex = 0;
            this.tripStartHM.ValueChanged += new System.EventHandler(this.tripStartDate_ValueChanged);
            // 
            // minutesLabel
            // 
            this.minutesLabel.AutoSize = true;
            this.minutesLabel.Location = new System.Drawing.Point(421, 29);
            this.minutesLabel.Name = "minutesLabel";
            this.minutesLabel.Size = new System.Drawing.Size(50, 15);
            this.minutesLabel.TabIndex = 1;
            this.minutesLabel.Text = "Minutes";
            this.minutesLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // tripMinutesValue
            // 
            this.tripMinutesValue.AutoSize = true;
            this.tripMinutesValue.Location = new System.Drawing.Point(421, 63);
            this.tripMinutesValue.Name = "tripMinutesValue";
            this.tripMinutesValue.Size = new System.Drawing.Size(66, 15);
            this.tripMinutesValue.TabIndex = 1;
            this.tripMinutesValue.Text = "<minutes>";
            this.tripMinutesValue.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // calculationGroupBox
            // 
            this.calculationGroupBox.Controls.Add(this.labelExchangeRate);
            this.calculationGroupBox.Controls.Add(this.exchangeRateValue);
            this.calculationGroupBox.Controls.Add(this.currentExchangeRateCheckBox);
            this.calculationGroupBox.Controls.Add(this.advancePaymentValue);
            this.calculationGroupBox.Controls.Add(this.advancePaymentLabel);
            this.calculationGroupBox.Location = new System.Drawing.Point(13, 210);
            this.calculationGroupBox.Name = "calculationGroupBox";
            this.calculationGroupBox.Size = new System.Drawing.Size(485, 100);
            this.calculationGroupBox.TabIndex = 9;
            this.calculationGroupBox.TabStop = false;
            this.calculationGroupBox.Text = "Complementary Data";
            // 
            // ResultGroupBox
            // 
            this.ResultGroupBox.Controls.Add(this.totalAllowanceLabel);
            this.ResultGroupBox.Controls.Add(this.totalAllowanceValue);
            this.ResultGroupBox.Controls.Add(this.currencyValue2);
            this.ResultGroupBox.Controls.Add(this.totalAllowanceExchangedValue);
            this.ResultGroupBox.Controls.Add(this.balanceLabel);
            this.ResultGroupBox.Controls.Add(this.plnLabel2);
            this.ResultGroupBox.Controls.Add(this.plnLabel);
            this.ResultGroupBox.Controls.Add(this.balanceValue);
            this.ResultGroupBox.Location = new System.Drawing.Point(13, 316);
            this.ResultGroupBox.Name = "ResultGroupBox";
            this.ResultGroupBox.Size = new System.Drawing.Size(485, 108);
            this.ResultGroupBox.TabIndex = 10;
            this.ResultGroupBox.TabStop = false;
            this.ResultGroupBox.Text = "Result";
            // 
            // statusStrip
            // 
            this.statusStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripStatusLabel});
            this.statusStrip.Location = new System.Drawing.Point(0, 473);
            this.statusStrip.Name = "statusStrip";
            this.statusStrip.Size = new System.Drawing.Size(512, 22);
            this.statusStrip.TabIndex = 11;
            this.statusStrip.Text = "statusStrip";
            // 
            // toolStripStatusLabel
            // 
            this.toolStripStatusLabel.Name = "toolStripStatusLabel";
            this.toolStripStatusLabel.Size = new System.Drawing.Size(118, 17);
            this.toolStripStatusLabel.Text = "toolStripStatusLabel1";
            // 
            // CalculatorForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.ClientSize = new System.Drawing.Size(512, 495);
            this.Controls.Add(this.statusStrip);
            this.Controls.Add(this.ResultGroupBox);
            this.Controls.Add(this.calculationGroupBox);
            this.Controls.Add(this.datesGroupBox);
            this.Controls.Add(this.destinationGroupBox);
            this.Controls.Add(this.calculateButton);
            this.Name = "CalculatorForm";
            this.Text = "Per Diem Calclator";
            this.destinationGroupBox.ResumeLayout(false);
            this.destinationGroupBox.PerformLayout();
            this.datesGroupBox.ResumeLayout(false);
            this.datesGroupBox.PerformLayout();
            this.calculationGroupBox.ResumeLayout(false);
            this.calculationGroupBox.PerformLayout();
            this.ResultGroupBox.ResumeLayout(false);
            this.ResultGroupBox.PerformLayout();
            this.statusStrip.ResumeLayout(false);
            this.statusStrip.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DateTimePicker tripStartDMY;
        private System.Windows.Forms.DateTimePicker tripFinishDMY;
        private System.Windows.Forms.Label tripDaysLabel;
        private System.Windows.Forms.Button calculateButton;
        private System.Windows.Forms.Label labelStart;
        private System.Windows.Forms.Label labelFinish;
        private System.Windows.Forms.ComboBox CountryDropDown;
        private System.Windows.Forms.Label currencyValue;
        private System.Windows.Forms.Label perDiemValue;
        private System.Windows.Forms.Label currencyLabel;
        private System.Windows.Forms.Label perDiemLabel;
        private System.Windows.Forms.Label hoursLabel;
        private System.Windows.Forms.Label tripDaysValue;
        private System.Windows.Forms.Label tripHoursValue;
        private System.Windows.Forms.Label totalAllowanceLabel;
        private System.Windows.Forms.Label totalAllowanceValue;
        private System.Windows.Forms.TextBox exchangeRateValue;
        private System.Windows.Forms.Label labelExchangeRate;
        private System.Windows.Forms.Label currencyValue2;
        private System.Windows.Forms.Label plnLabel;
        private System.Windows.Forms.Label totalAllowanceExchangedValue;
        private System.Windows.Forms.CheckBox currentExchangeRateCheckBox;
        private System.Windows.Forms.Label advancePaymentLabel;
        private System.Windows.Forms.TextBox advancePaymentValue;
        private System.Windows.Forms.Label balanceValue;
        private System.Windows.Forms.Label balanceLabel;
        private System.Windows.Forms.Label plnLabel2;
        private System.Windows.Forms.GroupBox destinationGroupBox;
        private System.Windows.Forms.GroupBox datesGroupBox;
        private System.Windows.Forms.Label countryLabel;
        private System.Windows.Forms.GroupBox calculationGroupBox;
        private System.Windows.Forms.GroupBox ResultGroupBox;
        private System.Windows.Forms.StatusStrip statusStrip;
        private System.Windows.Forms.ToolStripStatusLabel toolStripStatusLabel;
        private System.Windows.Forms.Label minutesLabel;
        private System.Windows.Forms.Label tripMinutesValue;
        private System.Windows.Forms.DateTimePicker tripStartHM;
        private System.Windows.Forms.DateTimePicker tripFinishHM;
    }
}

