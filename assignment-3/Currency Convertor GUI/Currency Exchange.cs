using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Currency_Convertor_GUI {
    enum Currencies { AUD, CNY, DKK, EUR, INR, NZD, AED, GBP, USD, VND };
    
    static class Currency_Exchange {
        private static double[] xRates = { 1, 4.2681, 5.0844, 0.6849, 43.5921, 0.9705, 2.7094, 0.4963, 0.7382, 19115.5547 };

        /// <summary>
        /// Converts the specified sum of money from the specified currency to the new currency.
        /// </summary>
        /// <param name="amount">The sum of money that is to be converted.</param>
        /// <param name="FromCurrency">The currency that the amount parameter </param>
        /// <param name="ToCurrency">The currency that the amount parameter is to converted to.</param>
        /// <returns>Returns the new value of the amount parameter after it has been converted.</returns>
        public static double CalculateCurrency(string amountHave, int FromCurrency, int ToCurrency) {
            int index;
            double rate, amountInAUD;
            double amount;

            bool result = Double.TryParse(amountHave, out amount);

            if (result) {
                if (FromCurrency != 0) {
                    index = FromCurrency;
                    rate = xRates[index];
                    amountInAUD = amount / rate;

                    index = ToCurrency;
                    rate = xRates[index];
                    return Math.Round(amountInAUD * rate, 4);
                } else {
                    index = ToCurrency;
                    rate = xRates[index];

                    return Math.Round(amount * rate, 4);
                }
            } else {
                return -1;
            }
        }

        /// <summary>
        /// Retrieves a currency's property depending on the name of the property specified.
        /// </summary>
        /// <param name="property">"value" and "name" are the properties that can be retrieved.</param>
        /// <param name="currencyName">The country and exchange rate code e.g. "Australia (AUD)".</param>
        /// <returns>An object which will have to be casted in order to be assigned to a variable.</returns>
        public static object GetSymbol(string property, string currencyName) {
            object currency = 0;

            switch (currencyName) {
                case "Australia (AUD)":
                    currency = Currencies.AUD;
                    break;
                case "China (CNY)":
                    currency = Currencies.CNY;
                    break;
                case "Denmark (DKK)":
                    currency = Currencies.DKK;
                    break;
                case "Europe (EUR)":
                    currency = Currencies.EUR;
                    break;
                case "India (INR)":
                    currency = Currencies.INR;
                    break;
                case "New Zealand (NZD)":
                    currency = Currencies.NZD;
                    break;
                case "United Arab Emirates (AED)":
                    currency = Currencies.AED;
                    break;
                case "United Kingdom (GBP)":
                    currency = Currencies.GBP;
                    break;
                case "United States (USD)":
                    currency = Currencies.USD;
                    break;
                case "Vietnam (VND)":
                    currency = Currencies.VND;
                    break;
                default:
                    currency = "Invalid (XXX)";
                    break;
            }

            switch (property) {
                case "value":
                    return (int)currency;
                case "name":
                    return currency.ToString();
                default:
                    return "The property could not be returned.";
            }
        }
    }
}
