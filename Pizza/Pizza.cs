using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Pizza
{
    public partial class Pizza : Form
    {
        public Pizza()
        {
            InitializeComponent();
        }

        double small, medium, large, xlarge;

        private void RdoSmall_CheckedChanged(object sender, EventArgs e)
        {
            TxtBasePrice.Text = small.ToString("c");
            basePrice = small;

            price = basePrice + basicSurcharge;
            TxtPrice.Text = price.ToString("c");
        }

        private void RdoMedium_CheckedChanged(object sender, EventArgs e)
        {
            TxtBasePrice.Text = medium.ToString("c");
            basePrice = medium;

            price = basePrice + basicSurcharge;
            TxtPrice.Text = price.ToString("c");
        }

        private void RdoLarge_CheckedChanged(object sender, EventArgs e)
        {
            TxtBasePrice.Text = large.ToString("c");
            basePrice = large;

            price = basePrice + basicSurcharge;
            TxtPrice.Text = price.ToString("c");
        }

        private void RdoXLarge_CheckedChanged(object sender, EventArgs e)
        {
            TxtBasePrice.Text = xlarge.ToString("c");
            basePrice = xlarge;

            price = basePrice + basicSurcharge;
            TxtPrice.Text = price.ToString("c");
        }

        private void RdoBasic_CheckedChanged(object sender, EventArgs e)
        {
            TxtItemSurcharge.Text = basic.ToString("c");
            basicSurcharge = basic;

            price = basePrice + basicSurcharge;
            TxtPrice.Text = price.ToString("c");
        }

        private void RdoVeggie_CheckedChanged(object sender, EventArgs e)
        {
            TxtItemSurcharge.Text = veggie.ToString("c");
            basicSurcharge = veggie;

            price = basePrice + basicSurcharge;
            TxtPrice.Text = price.ToString("c");
        }

        private void RdoMeatLovers_CheckedChanged(object sender, EventArgs e)
        {
            TxtItemSurcharge.Text = meatLovers.ToString("c");
            basicSurcharge = meatLovers;

            price = basePrice + basicSurcharge;
            TxtPrice.Text = price.ToString("c");
        }

        private void RdoStuffedCrust_CheckedChanged(object sender, EventArgs e)
        {
            TxtItemSurcharge.Text = stuffedCrust.ToString("c");
            basicSurcharge = stuffedCrust;

            price = basePrice + basicSurcharge;
            TxtPrice.Text = price.ToString("c");
        }

        private void RdoDeluxe_CheckedChanged(object sender, EventArgs e)
        {
            TxtItemSurcharge.Text = deluxe.ToString("c");
            basicSurcharge = deluxe;

            price = basePrice + basicSurcharge;
            TxtPrice.Text = price.ToString("c");
        }

        private void BtnCalculate_Click(object sender, EventArgs e)
        {
            subTotal = price * int.Parse(TxtQuantity.Text);
            tax = subTotal * 0.14;
            total = subTotal + tax;

            TxtSubtotal.Text = subTotal.ToString("c");
            TxtTax.Text = tax.ToString("c");
            TxtTotal.Text = total.ToString("c");
            
        }

        private void BtnNewOrder_Click(object sender, EventArgs e)
        {
            RdoSmall.Checked = false;
            RdoMedium.Checked = false;
            RdoLarge.Checked = false;
            RdoXLarge.Checked = false;

            RdoBasic.Checked = false;
            RdoVeggie.Checked = false;
            RdoMeatLovers.Checked = false;
            RdoStuffedCrust.Checked = false;
            RdoDeluxe.Checked = false;

            TxtBasePrice.Text = "";
            TxtItemSurcharge.Text = "";
            TxtPrice.Text = "";
            TxtQuantity.Text = "1";
            TxtSubtotal.Text = "";
            TxtTax.Text = "";
            TxtTotal.Text =  "";

        }

        private void BtnExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        double basic, veggie, meatLovers, stuffedCrust, deluxe;
        double basePrice, basicSurcharge, subTotal, tax, price, total;

        private void Pizza_Load(object sender, EventArgs e)
        {
            small = 4.99;
            medium = 5.99;
            large = 7.99;
            xlarge = 9.99;

            basic = 0.89;
            veggie = 1.49;
            meatLovers = 2.07;
            stuffedCrust = 3.45;
            deluxe = 4.75;

            price = 0;
            basePrice = 0;
            basicSurcharge = 0;

            TxtQuantity.Text = "1";
        }
    }
}
