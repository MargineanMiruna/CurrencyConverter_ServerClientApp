namespace CurrencyConverter
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
            this.amountBox = new System.Windows.Forms.TextBox();
            this.buttonConvert = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.baseBox = new System.Windows.Forms.ComboBox();
            this.targetBox = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // amountBox
            // 
            this.amountBox.AcceptsTab = true;
            this.amountBox.BackColor = System.Drawing.SystemColors.InactiveCaptionText;
            this.amountBox.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.amountBox.ForeColor = System.Drawing.SystemColors.InactiveBorder;
            this.amountBox.Location = new System.Drawing.Point(131, 100);
            this.amountBox.Margin = new System.Windows.Forms.Padding(2);
            this.amountBox.Name = "amountBox";
            this.amountBox.Size = new System.Drawing.Size(146, 26);
            this.amountBox.TabIndex = 0;
            this.amountBox.Text = "Type amount...";
            this.amountBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.amountBox.Click += new System.EventHandler(this.amountBox_Click);
            // 
            // buttonConvert
            // 
            this.buttonConvert.BackColor = System.Drawing.Color.Silver;
            this.buttonConvert.Font = new System.Drawing.Font("Arial Rounded MT Bold", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonConvert.ForeColor = System.Drawing.Color.Black;
            this.buttonConvert.Location = new System.Drawing.Point(318, 314);
            this.buttonConvert.Margin = new System.Windows.Forms.Padding(2);
            this.buttonConvert.Name = "buttonConvert";
            this.buttonConvert.Size = new System.Drawing.Size(79, 30);
            this.buttonConvert.TabIndex = 1;
            this.buttonConvert.Text = "Convert";
            this.buttonConvert.UseVisualStyleBackColor = false;
            this.buttonConvert.Click += new System.EventHandler(this.buttonConvert_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Arial Rounded MT Bold", 10.8F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(61, 147);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(121, 17);
            this.label1.TabIndex = 2;
            this.label1.Text = "Base currency:";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Arial Rounded MT Bold", 10.8F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(51, 193);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(132, 17);
            this.label2.TabIndex = 3;
            this.label2.Text = "Target currency:";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // baseBox
            // 
            this.baseBox.BackColor = System.Drawing.Color.Black;
            this.baseBox.Font = new System.Drawing.Font("Arial", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.baseBox.ForeColor = System.Drawing.Color.White;
            this.baseBox.FormattingEnabled = true;
            this.baseBox.Items.AddRange(new object[] {
            "EUR",
            "USD",
            "JPY",
            "BGN",
            "CZK",
            "DKK",
            "GBP",
            "HUF",
            "PLN",
            "RON",
            "SEK",
            "CHF",
            "ISK",
            "NOK",
            "HRK",
            "RUB",
            "TRY",
            "AUD",
            "BRL",
            "CAD",
            "CNY",
            "HKD",
            "IDR",
            "ILS",
            "INR",
            "KRW",
            "MXN",
            "MYR",
            "NZD",
            "PHP",
            "SGD",
            "THB",
            "ZAR"});
            this.baseBox.Location = new System.Drawing.Point(186, 146);
            this.baseBox.Margin = new System.Windows.Forms.Padding(2);
            this.baseBox.Name = "baseBox";
            this.baseBox.Size = new System.Drawing.Size(135, 24);
            this.baseBox.TabIndex = 4;
            // 
            // targetBox
            // 
            this.targetBox.BackColor = System.Drawing.Color.Black;
            this.targetBox.Font = new System.Drawing.Font("Arial", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.targetBox.ForeColor = System.Drawing.Color.White;
            this.targetBox.FormattingEnabled = true;
            this.targetBox.Items.AddRange(new object[] {
            "EUR",
            "USD",
            "JPY",
            "BGN",
            "CZK",
            "DKK",
            "GBP",
            "HUF",
            "PLN",
            "RON",
            "SEK",
            "CHF",
            "ISK",
            "NOK",
            "HRK",
            "RUB",
            "TRY",
            "AUD",
            "BRL",
            "CAD",
            "CNY",
            "HKD",
            "IDR",
            "ILS",
            "INR",
            "KRW",
            "MXN",
            "MYR",
            "NZD",
            "PHP",
            "SGD",
            "THB",
            "ZAR"});
            this.targetBox.Location = new System.Drawing.Point(186, 188);
            this.targetBox.Margin = new System.Windows.Forms.Padding(2);
            this.targetBox.Name = "targetBox";
            this.targetBox.Size = new System.Drawing.Size(135, 24);
            this.targetBox.TabIndex = 5;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.White;
            this.label3.Location = new System.Drawing.Point(137, 248);
            this.label3.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(0, 18);
            this.label3.TabIndex = 6;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Black;
            this.ClientSize = new System.Drawing.Size(416, 362);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.targetBox);
            this.Controls.Add(this.baseBox);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.buttonConvert);
            this.Controls.Add(this.amountBox);
            this.ForeColor = System.Drawing.SystemColors.ActiveBorder;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "Form1";
            this.Text = "Currency Converter";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox amountBox;
        private System.Windows.Forms.Button buttonConvert;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox baseBox;
        private System.Windows.Forms.ComboBox targetBox;
        private System.Windows.Forms.Label label3;
    }
}

