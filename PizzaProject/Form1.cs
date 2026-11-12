using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PizzaProject
{
    public partial class Form1 : Form
    {
        
        public Form1()
        {
            InitializeComponent();
        }
        void UpdateSize()
        {

            UpdatePrice();
            if (rbsmall.Checked) {
                lbSizeres.Text = "Small";
                return;
            }
            if (rbmedium.Checked) {
                lbSizeres.Text = "Medium";
                return;

            }
            if (rblarge.Checked) {
                lbSizeres.Text = "Large";
                return;
            }
           
        }
        void UpdateCrust()
        {
            UpdatePrice();

            if (rbThin.Checked)
            {
                lbCrustTyperes.Text = "Thin Crust";
                return;
            }
            else
            {
                lbCrustTyperes.Text = "Think Crust";
                return;
            }


        }
        void UpdateToppings()
        {
            UpdatePrice() ;
            string sToppings = "";
            if (chkExtraChees.Checked)
            {
               sToppings+="ExtraChess";
            }
            if (chkOnion.Checked)
            {
                sToppings += ", Onion";
            }
            if (chkOlives.Checked)
            {
                sToppings += ", Olives";
            }
            if (chkMushrooms.Checked)
            {
                sToppings += ", Mushrooms";
            }
            if (chkGreenPappers.Checked)
            {
                sToppings += ", GreenPappers"; 
            }
            if (chkTomatoes.Checked)
            {
                sToppings += ", Tomtoes";
            }
            if (sToppings.StartsWith(","))
            {
                sToppings = sToppings.Substring(1);
            }
            if (sToppings == "")
                sToppings = "No Toppings";
            lbToppingsres.Text = sToppings;

        }
        void UpdateOrderSummary()
        {
            UpdateCrust();
            UpdatePrice();
            UpdateSize();
            UpdateToppings();
            UpdateWhere();
        }
        void RestForm()
        {
            gbCrust.Enabled = true;
            gbToppings.Enabled = true;
            gbWhere.Enabled = true;
            gbSize.Enabled = true;
            rbEatin.Checked = true;
            rbmedium.Checked = true;
            rbThin.Checked = true;
            btnOrderPizza.Enabled = true;

            chkExtraChees.Checked = false;
            chkMushrooms.Checked = false;
            chkOlives.Checked = false;
            chkOnion.Checked = false;
            chkGreenPappers.Checked = false;
            chkTomatoes.Checked = false;
        }
        void UpdateWhere( )
        {
           UpdatePrice();
            if (rbEatin.Checked)
            {
                lbWhereEatres.Text = "Eat In";
            }
            else
            {
                lbWhereEatres.Text = "Eat Out";
            }
        }
        float GetSelectedSizePrice()
        {
            if (rbsmall.Checked)
            {
                
                return Convert.ToSingle(rbsmall.Tag);
            }
            else if (rbmedium.Checked)
            {

                return Convert.ToSingle(rbmedium.Tag);

            }
            else{
               
                return Convert.ToSingle(rblarge.Tag);
            }
        }
        float GetSelectedCrustPrice()
        {
            if (rbThin.Checked) { 
         return   Convert.ToSingle(rbThin.Tag);
            
            }
            else
                return Convert.ToSingle(rbThink.Tag);
        }
        float GetSelectedToppingsPrice()
        {
            float ToppingPrice = 0f;
            if (chkExtraChees.Checked)
            {
                ToppingPrice += Convert.ToSingle(chkExtraChees.Tag);
            }
            if (chkOnion.Checked)
            {
                ToppingPrice += Convert.ToSingle(chkOnion.Tag);
            }
            if (chkOlives.Checked)
            {
                ToppingPrice += Convert.ToSingle(chkOlives.Tag);
            }
            if (chkMushrooms.Checked)
            {
                ToppingPrice += Convert.ToSingle(chkMushrooms.Tag);
            }
            if (chkGreenPappers.Checked)
            {
                ToppingPrice += Convert.ToSingle(chkGreenPappers.Tag);
            }
            if (chkTomatoes.Checked)
            {
                ToppingPrice += Convert.ToSingle(chkTomatoes.Tag);
            }
          return ToppingPrice;
        }

        float CalculateTotalPrice()
        {
            return GetSelectedCrustPrice() + GetSelectedSizePrice() + GetSelectedToppingsPrice();
        }
        void UpdatePrice()
        {
            lbPriceres.Text=CalculateTotalPrice().ToString()+"$";
        }
       

      

       

      

        private void btnOrderPizza_Click(object sender, EventArgs e)
        {
           if( MessageBox.Show("Confirm Order", "Confirm", MessageBoxButtons.OKCancel, MessageBoxIcon.Question)==DialogResult.OK){


                
                       if( MessageBox.Show("Order Successfully", "Sucess", MessageBoxButtons.OK, MessageBoxIcon.Information) == DialogResult.OK)
                        {

                            gbCrust.Enabled = false;
                            gbToppings.Enabled = false;
                              gbWhere.Enabled = false;
                              gbSize.Enabled = false;
                             btnOrderPizza.Enabled = false;
                        }

                  
            
            
            }
            else

                MessageBox.Show("Update your order", "Update",
                    MessageBoxButtons.OK, MessageBoxIcon.Exclamation);


        }

        private void btnRestForm_Click(object sender, EventArgs e)
        {
            RestForm();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            UpdateOrderSummary();
        }

        private void rbSize_CheckedChanged(object sender, EventArgs e)
        {
            UpdateSize();
        }
        private void rbCruxt_CheckedChanged(object sender, EventArgs e)
        {
            UpdateCrust();
        }
        private void rbWhere_CheckedChanged(object sender, EventArgs e)
        {
            UpdateWhere();
        }
        private void chkToppings_CheckedChanged(object sender, EventArgs e)

        {


            UpdateToppings();
        }

    }
}
