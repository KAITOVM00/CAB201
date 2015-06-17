namespace Currency_Convertor_GUI {
    partial class main {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing) {
            if (disposing && (components != null)) {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent() {
            this.lblCurrencyHave = new System.Windows.Forms.Label();
            this.lblCurrencyWant = new System.Windows.Forms.Label();
            this.lblAmountHave = new System.Windows.Forms.Label();
            this.lblAmountWant = new System.Windows.Forms.Label();
            this.cbxCurrencyHave = new System.Windows.Forms.ComboBox();
            this.cbxCurrencyWant = new System.Windows.Forms.ComboBox();
            this.txtAmountHave = new System.Windows.Forms.TextBox();
            this.txtAmountWant = new System.Windows.Forms.TextBox();
            this.btnEquals = new System.Windows.Forms.Button();
            this.gbxAnotherConversion = new System.Windows.Forms.GroupBox();
            this.btnNo = new System.Windows.Forms.RadioButton();
            this.btnYes = new System.Windows.Forms.RadioButton();
            this.lblSymbolHave = new System.Windows.Forms.Label();
            this.lblSymbolWant = new System.Windows.Forms.Label();
            this.gbxAnotherConversion.SuspendLayout();
            this.SuspendLayout();
            // 
            // lblCurrencyHave
            // 
            this.lblCurrencyHave.AutoSize = true;
            this.lblCurrencyHave.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCurrencyHave.Location = new System.Drawing.Point(50, 9);
            this.lblCurrencyHave.Name = "lblCurrencyHave";
            this.lblCurrencyHave.Size = new System.Drawing.Size(127, 17);
            this.lblCurrencyHave.TabIndex = 0;
            this.lblCurrencyHave.Text = "Currency I have:";
            // 
            // lblCurrencyWant
            // 
            this.lblCurrencyWant.AutoSize = true;
            this.lblCurrencyWant.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCurrencyWant.Location = new System.Drawing.Point(372, 9);
            this.lblCurrencyWant.Name = "lblCurrencyWant";
            this.lblCurrencyWant.Size = new System.Drawing.Size(125, 17);
            this.lblCurrencyWant.TabIndex = 1;
            this.lblCurrencyWant.Text = "Currency I want:";
            // 
            // lblAmountHave
            // 
            this.lblAmountHave.AutoSize = true;
            this.lblAmountHave.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAmountHave.Location = new System.Drawing.Point(50, 97);
            this.lblAmountHave.Name = "lblAmountHave";
            this.lblAmountHave.Size = new System.Drawing.Size(116, 17);
            this.lblAmountHave.TabIndex = 2;
            this.lblAmountHave.Text = "Amount I have:";
            // 
            // lblAmountWant
            // 
            this.lblAmountWant.AutoSize = true;
            this.lblAmountWant.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAmountWant.Location = new System.Drawing.Point(373, 97);
            this.lblAmountWant.Name = "lblAmountWant";
            this.lblAmountWant.Size = new System.Drawing.Size(114, 17);
            this.lblAmountWant.TabIndex = 3;
            this.lblAmountWant.Text = "Amount I want:";
            // 
            // cbxCurrencyHave
            // 
            this.cbxCurrencyHave.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbxCurrencyHave.FormattingEnabled = true;
            this.cbxCurrencyHave.Items.AddRange(new object[] {
            "",
            "Australia (AUD)",
            "China (CNY)",
            "Denmark (DKK)",
            "Europe (EUR)",
            "India (INR)",
            "New Zealand (NZD)",
            "United Arab Emirates (AED)",
            "United Kingdom (GBP)",
            "United States (USD)",
            "Vietnam (VND)"});
            this.cbxCurrencyHave.Location = new System.Drawing.Point(53, 29);
            this.cbxCurrencyHave.Name = "cbxCurrencyHave";
            this.cbxCurrencyHave.Size = new System.Drawing.Size(155, 21);
            this.cbxCurrencyHave.TabIndex = 0;
            this.cbxCurrencyHave.DropDownClosed += new System.EventHandler(this.cbxCurrencyHave_DropDownClosed);
            // 
            // cbxCurrencyWant
            // 
            this.cbxCurrencyWant.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbxCurrencyWant.Enabled = false;
            this.cbxCurrencyWant.FormattingEnabled = true;
            this.cbxCurrencyWant.Items.AddRange(new object[] {
            "",
            "Australia (AUD)",
            "China (CNY)",
            "Denmark (DKK)",
            "Europe (EUR)",
            "India (INR)",
            "New Zealand (NZD)",
            "United Arab Emirates (AED)",
            "United Kingdom (GBP)",
            "United States (USD)",
            "Vietnam (VND)"});
            this.cbxCurrencyWant.Location = new System.Drawing.Point(375, 29);
            this.cbxCurrencyWant.Name = "cbxCurrencyWant";
            this.cbxCurrencyWant.Size = new System.Drawing.Size(155, 21);
            this.cbxCurrencyWant.TabIndex = 1;
            this.cbxCurrencyWant.DropDownClosed += new System.EventHandler(this.cbxCurrencyWant_DropDownClosed);
            // 
            // txtAmountHave
            // 
            this.txtAmountHave.Enabled = false;
            this.txtAmountHave.Location = new System.Drawing.Point(53, 117);
            this.txtAmountHave.Name = "txtAmountHave";
            this.txtAmountHave.Size = new System.Drawing.Size(155, 20);
            this.txtAmountHave.TabIndex = 2;
            this.txtAmountHave.TextChanged += new System.EventHandler(this.txtAmountHave_TextChanged);
            // 
            // txtAmountWant
            // 
            this.txtAmountWant.Location = new System.Drawing.Point(375, 117);
            this.txtAmountWant.Name = "txtAmountWant";
            this.txtAmountWant.ReadOnly = true;
            this.txtAmountWant.Size = new System.Drawing.Size(155, 20);
            this.txtAmountWant.TabIndex = 7;
            this.txtAmountWant.TabStop = false;
            // 
            // btnEquals
            // 
            this.btnEquals.Enabled = false;
            this.btnEquals.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEquals.Location = new System.Drawing.Point(254, 99);
            this.btnEquals.Name = "btnEquals";
            this.btnEquals.Size = new System.Drawing.Size(75, 50);
            this.btnEquals.TabIndex = 3;
            this.btnEquals.Text = "equals";
            this.btnEquals.UseVisualStyleBackColor = true;
            this.btnEquals.Click += new System.EventHandler(this.btnEquals_Click);
            // 
            // gbxAnotherConversion
            // 
            this.gbxAnotherConversion.Controls.Add(this.btnNo);
            this.gbxAnotherConversion.Controls.Add(this.btnYes);
            this.gbxAnotherConversion.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gbxAnotherConversion.Location = new System.Drawing.Point(254, 167);
            this.gbxAnotherConversion.Name = "gbxAnotherConversion";
            this.gbxAnotherConversion.Size = new System.Drawing.Size(200, 82);
            this.gbxAnotherConversion.TabIndex = 9;
            this.gbxAnotherConversion.TabStop = false;
            this.gbxAnotherConversion.Text = "Another conversion?";
            // 
            // btnNo
            // 
            this.btnNo.AutoSize = true;
            this.btnNo.Location = new System.Drawing.Point(7, 50);
            this.btnNo.Name = "btnNo";
            this.btnNo.Size = new System.Drawing.Size(46, 21);
            this.btnNo.TabIndex = 5;
            this.btnNo.Text = "No";
            this.btnNo.UseVisualStyleBackColor = true;
            this.btnNo.CheckedChanged += new System.EventHandler(this.btnNo_CheckedChanged);
            // 
            // btnYes
            // 
            this.btnYes.AutoSize = true;
            this.btnYes.Location = new System.Drawing.Point(7, 23);
            this.btnYes.Name = "btnYes";
            this.btnYes.Size = new System.Drawing.Size(53, 21);
            this.btnYes.TabIndex = 4;
            this.btnYes.Text = "Yes";
            this.btnYes.UseVisualStyleBackColor = true;
            this.btnYes.CheckedChanged += new System.EventHandler(this.btnYes_CheckedChanged);
            // 
            // lblSymbolHave
            // 
            this.lblSymbolHave.AutoSize = true;
            this.lblSymbolHave.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSymbolHave.Location = new System.Drawing.Point(13, 118);
            this.lblSymbolHave.Name = "lblSymbolHave";
            this.lblSymbolHave.Size = new System.Drawing.Size(23, 17);
            this.lblSymbolHave.TabIndex = 10;
            this.lblSymbolHave.Text = "   ";
            // 
            // lblSymbolWant
            // 
            this.lblSymbolWant.AutoSize = true;
            this.lblSymbolWant.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSymbolWant.Location = new System.Drawing.Point(335, 118);
            this.lblSymbolWant.Name = "lblSymbolWant";
            this.lblSymbolWant.Size = new System.Drawing.Size(23, 17);
            this.lblSymbolWant.TabIndex = 11;
            this.lblSymbolWant.Text = "   ";
            // 
            // main
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(568, 161);
            this.Controls.Add(this.lblSymbolWant);
            this.Controls.Add(this.lblSymbolHave);
            this.Controls.Add(this.gbxAnotherConversion);
            this.Controls.Add(this.btnEquals);
            this.Controls.Add(this.txtAmountWant);
            this.Controls.Add(this.txtAmountHave);
            this.Controls.Add(this.cbxCurrencyWant);
            this.Controls.Add(this.cbxCurrencyHave);
            this.Controls.Add(this.lblAmountWant);
            this.Controls.Add(this.lblAmountHave);
            this.Controls.Add(this.lblCurrencyWant);
            this.Controls.Add(this.lblCurrencyHave);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "main";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Currency Converter";
            this.gbxAnotherConversion.ResumeLayout(false);
            this.gbxAnotherConversion.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblCurrencyHave;
        private System.Windows.Forms.Label lblCurrencyWant;
        private System.Windows.Forms.Label lblAmountHave;
        private System.Windows.Forms.Label lblAmountWant;
        private System.Windows.Forms.ComboBox cbxCurrencyHave;
        private System.Windows.Forms.ComboBox cbxCurrencyWant;
        private System.Windows.Forms.TextBox txtAmountHave;
        private System.Windows.Forms.TextBox txtAmountWant;
        private System.Windows.Forms.Button btnEquals;
        private System.Windows.Forms.GroupBox gbxAnotherConversion;
        private System.Windows.Forms.RadioButton btnNo;
        private System.Windows.Forms.RadioButton btnYes;
        private System.Windows.Forms.Label lblSymbolHave;
        private System.Windows.Forms.Label lblSymbolWant;

     
    }
}

