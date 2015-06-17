using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Currency_Convertor_GUI;

namespace Currency_Convertor_GUI {
    
    public partial class main : Form {

        public main() {
            InitializeComponent();
        }

        private void cbxCurrencyHave_DropDownClosed(object sender, EventArgs e) {
            if (cbxCurrencyHave.Text != "") {
                cbxCurrencyHave.Enabled = false;
                cbxCurrencyWant.Enabled = true;

                lblSymbolHave.Text = (string)Currency_Exchange.GetSymbol("name", cbxCurrencyHave.Text);
            }
        }

        private void cbxCurrencyWant_DropDownClosed(object sender, EventArgs e) {
            if (cbxCurrencyWant.Text != "") {
                cbxCurrencyWant.Enabled = false;
                txtAmountHave.Enabled = true;

                lblSymbolWant.Text = (string)Currency_Exchange.GetSymbol("name", cbxCurrencyWant.Text);
            }
        }

        private void txtAmountHave_TextChanged(object sender, EventArgs e) {
            double amountHave;
            bool result = double.TryParse(txtAmountHave.Text, out amountHave);

            if (amountHave < 0) {
                MessageBox.Show("The number cannot be less than 0.");
            } else {
                if (txtAmountHave.Text != "") {
                    if (result) {
                        btnEquals.Enabled = true;
                    } else {
                        MessageBox.Show("This text box must contain a number!");
                    }
                }
            }
        }

        private void btnEquals_Click(object sender, EventArgs e) {
            txtAmountHave.Enabled = false;
                        
            int fromCurrency = (int)Currency_Exchange.GetSymbol("value", cbxCurrencyHave.Text);
            int toCurrency = (int)Currency_Exchange.GetSymbol("value", cbxCurrencyWant.Text);

            txtAmountWant.Text = (Currency_Exchange.CalculateCurrency(txtAmountHave.Text, fromCurrency, toCurrency)).ToString();
            btnEquals.Enabled = false;
            this.Height = 300;
        }

        private void btnYes_CheckedChanged(object sender, EventArgs e) {
            this.Height = 200;

            cbxCurrencyHave.Text = "";
            cbxCurrencyWant.Text = "";

            txtAmountHave.Text = "";
            txtAmountWant.Text = "";

            cbxCurrencyHave.Enabled = true;
        }

        private void btnNo_CheckedChanged(object sender, EventArgs e) {
            Application.Exit();
        }
    }
}
