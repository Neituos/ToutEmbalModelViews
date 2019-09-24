using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ToutEmbal
{
    public partial class LabelStateProduct : UserControl
    {
        public LabelStateProduct(string _name)
        {
            InitializeComponent();
            label1.Text = _name;
        }

        public void InProgressProduct()
        {
            label1.BackColor = Color.Green;
        }

        public void PauseProduct()
        {
            label1.BackColor = Color.Yellow;
        }

        public void FinishProduct()
        {
            label1.BackColor = Color.Red;
        }
    }
}
