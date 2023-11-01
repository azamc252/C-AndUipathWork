using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace marketPriceChecker
{
    public partial class metalsPrices : UserControl
    {
        public metalsPrices()
        {
            InitializeComponent();
        }

        private void metalsPrices_Load(object sender, EventArgs e)
        {
            string goldFile = @"C:\Users\micha\Documents\UiPath\metalAndForexChecker\prices\goldPrices.txt";
            string silverFile = @"C:\Users\micha\Documents\UiPath\metalAndForexChecker\prices\silverPrices.txt";
            string titaniumFile = @"C:\Users\micha\Documents\UiPath\metalAndForexChecker\prices\titaniumPrice.txt";
            string dollarFile = @"C:\Users\micha\Documents\UiPath\metalAndForexChecker\prices\dollarPrice.txt";
            string poundFile = @"C:\Users\micha\Documents\UiPath\metalAndForexChecker\prices\poundPrice.txt";
            //populating strings from files containing todays prices

            string goldPrice = File.ReadAllText(goldFile);
            string silverPrice = File.ReadAllText(silverFile);
            string titaniumPrice = File.ReadAllText(titaniumFile);
            string dollarPrice = File.ReadAllText(dollarFile);
            string poundPrice = File.ReadAllText(poundFile);
            goldBox.Text = goldPrice;
            silverBox.Text = silverPrice;
            titaniumBox.Text = titaniumPrice;
            dollarBox.Text = dollarPrice;
            poundBox.Text = poundPrice;
        }
    }
}
