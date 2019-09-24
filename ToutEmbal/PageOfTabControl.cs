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
    public partial class PageOfTabControl : UserControl
    {
        public PageOfTabControl()
        {
            InitializeComponent();
        }

        public void UpdatePage(int _numberBoxes, int _txDefault, int _txAllDefault)
        {
            TBNbBox.Text = _numberBoxes.ToString();
            TBTxDft.Text = _txDefault.ToString();
            TBTxDftAll.Text = _txAllDefault.ToString();
        }
    }
}
