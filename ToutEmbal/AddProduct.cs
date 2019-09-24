using LibraryProduction;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ToutEmbal
{
    public partial class AddProduct : Form
    {
        public delegate void DelegeAddOneProduct(string _name, int _numberOfProduct, int _speedProduct);
        public event DelegeAddOneProduct AddOneProduct;

        
        public AddProduct()
        {
            InitializeComponent();
        }

        public void EventAddOneProduct(string _name, int _numberOfProduct, int _speedProduct)
        {
            if(AddOneProduct != null)
            {
                AddOneProduct(_name, _numberOfProduct, _speedProduct);
            }
        }

        public void BValidateClick(object sender, EventArgs e)
        {
            if (Regex.IsMatch(TBNameProduct.Text, @"^[A-Za-z0-9]{1,6}$"))
            {
                errorProvider1.Clear();
                if (Regex.IsMatch(TBNumberOfProduct.Text, @"^[1-9][0-9]{0,5}$"))
                {
                    errorProvider1.Clear();
                    if (Regex.IsMatch(TBSpeedProduct.Text, @"^[1-9][0-9]{0,3}$"))
                    {
                        errorProvider1.Clear();
                        EventAddOneProduct(TBNameProduct.Text, int.Parse(TBNumberOfProduct.Text), int.Parse(TBSpeedProduct.Text));
                        Close();
                    }
                    else
                    {
                        errorProvider1.SetError(TBSpeedProduct, "1 a 4 chiffres ne commencant pas par \"0\"");
                    }
                }
                else
                {
                    errorProvider1.SetError(TBNumberOfProduct, "1 a 6 chiffres ne commencant pas par \"0\"");
                }
            }
            else
            {
                errorProvider1.SetError(TBNameProduct, "1 caractère mini et 6 maxi");
            }
        }  

        private void BCancelClick(object sender, EventArgs e)
        {
           Close();
        }
    }
}
