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
    public partial class LabelProgressBar : UserControl
    {
        public string text;
        public int valueMax;
        public int step;

        public LabelProgressBar(string _name, int _valueMax, int _step)
        {
            InitializeComponent();
            label1.Text += " "+_name;
            progressBar1.Maximum = _valueMax;
            progressBar1.Step = _step;
            progressBar1.Tag = _name;
        }

        public void UpdateProgressBar(int _value)
        {
            if(_value > progressBar1.Maximum)
            {
                progressBar1.Value = progressBar1.Maximum;
            }
            else
            {
                progressBar1.Value = _value;
            }
        }
    }
}
