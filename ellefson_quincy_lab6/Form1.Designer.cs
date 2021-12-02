
namespace ellefson_quincy_lab6
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

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.comboUnits = new System.Windows.Forms.ComboBox();
            this.numberboxTempValue = new System.Windows.Forms.NumericUpDown();
            this.label1 = new System.Windows.Forms.Label();
            this.lblConversion1Value = new System.Windows.Forms.Label();
            this.lblConversion2Value = new System.Windows.Forms.Label();
            this.imageTempGauge = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.numberboxTempValue)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.imageTempGauge)).BeginInit();
            this.SuspendLayout();
            // 
            // comboUnits
            // 
            this.comboUnits.Font = new System.Drawing.Font("Courier New", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.comboUnits.FormattingEnabled = true;
            this.comboUnits.Items.AddRange(new object[] {
            "Celcius",
            "Fahrenheit",
            "Kelvin"});
            this.comboUnits.Location = new System.Drawing.Point(451, 12);
            this.comboUnits.Name = "comboUnits";
            this.comboUnits.Size = new System.Drawing.Size(121, 26);
            this.comboUnits.TabIndex = 1;
            this.comboUnits.SelectedIndexChanged += new System.EventHandler(this.comboUnits_SelectedIndexChanged);
            // 
            // numberboxTempValue
            // 
            this.numberboxTempValue.Font = new System.Drawing.Font("Courier New", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.numberboxTempValue.Location = new System.Drawing.Point(300, 12);
            this.numberboxTempValue.Maximum = new decimal(new int[] {
            100000000,
            0,
            0,
            0});
            this.numberboxTempValue.Minimum = new decimal(new int[] {
            100000000,
            0,
            0,
            -2147483648});
            this.numberboxTempValue.Name = "numberboxTempValue";
            this.numberboxTempValue.Size = new System.Drawing.Size(145, 26);
            this.numberboxTempValue.TabIndex = 2;
            this.numberboxTempValue.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.numberboxTempValue.ValueChanged += new System.EventHandler(this.numberboxTempValue_ValueChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Courier New", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(27, 15);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(218, 18);
            this.label1.TabIndex = 3;
            this.label1.Text = "Starting Temperature:";
            // 
            // lblConversion1Value
            // 
            this.lblConversion1Value.AutoSize = true;
            this.lblConversion1Value.BackColor = System.Drawing.Color.White;
            this.lblConversion1Value.Font = new System.Drawing.Font("Courier New", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblConversion1Value.Location = new System.Drawing.Point(297, 85);
            this.lblConversion1Value.Name = "lblConversion1Value";
            this.lblConversion1Value.Size = new System.Drawing.Size(68, 18);
            this.lblConversion1Value.TabIndex = 4;
            this.lblConversion1Value.Text = "value1";
            this.lblConversion1Value.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // lblConversion2Value
            // 
            this.lblConversion2Value.AutoSize = true;
            this.lblConversion2Value.BackColor = System.Drawing.Color.White;
            this.lblConversion2Value.Font = new System.Drawing.Font("Courier New", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblConversion2Value.Location = new System.Drawing.Point(297, 129);
            this.lblConversion2Value.Name = "lblConversion2Value";
            this.lblConversion2Value.Size = new System.Drawing.Size(68, 18);
            this.lblConversion2Value.TabIndex = 5;
            this.lblConversion2Value.Text = "value2";
            this.lblConversion2Value.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // imageTempGauge
            // 
            this.imageTempGauge.Image = global::ellefson_quincy_lab6.Properties.Resources.tempNone;
            this.imageTempGauge.Location = new System.Drawing.Point(12, 85);
            this.imageTempGauge.Name = "imageTempGauge";
            this.imageTempGauge.Size = new System.Drawing.Size(175, 84);
            this.imageTempGauge.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.imageTempGauge.TabIndex = 0;
            this.imageTempGauge.TabStop = false;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(584, 181);
            this.Controls.Add(this.lblConversion2Value);
            this.Controls.Add(this.lblConversion1Value);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.numberboxTempValue);
            this.Controls.Add(this.comboUnits);
            this.Controls.Add(this.imageTempGauge);
            this.Name = "Form1";
            this.Text = "Temperature Conversion Program";
            ((System.ComponentModel.ISupportInitialize)(this.numberboxTempValue)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.imageTempGauge)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox imageTempGauge;
        private System.Windows.Forms.ComboBox comboUnits;
        private System.Windows.Forms.NumericUpDown numberboxTempValue;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lblConversion1Value;
        private System.Windows.Forms.Label lblConversion2Value;
    }
}

