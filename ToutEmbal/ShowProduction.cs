using LibraryProduction;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static LibraryProduction.Production;

namespace ToutEmbal
{
    public class ShowProduction
    {
        public string Name;
        public Production Prod;
        public LabelProgressBar Lpb;
        public PageOfTabControl Potc;
        public LabelStateProduct Lsp;

        public ShowProduction(string _name)
        {
            Name = _name;
        }

        public void AddProduction(int _numberOfProduct, int _speedProduct, DelegateProductChange _e)
        {
            Prod = new Production(Name, _numberOfProduct, _speedProduct);
            Prod.ProductChange += _e;
        }

        public void AddLabelProgressBar(int _valueMax, int _step, Control _parent, int _number, int _posX, int _posY, int _interX, int _interY)
        {
            Lpb = new LabelProgressBar(Name, _valueMax, _step);
            Lpb.Location = new Point(_posX, (_posY + (_interY * _number)));
            Lpb.Parent = _parent;
        }

        public TabPage AddPageOfTabControl()
        {
            Potc = new PageOfTabControl();
            TabPage tp = new TabPage();
            tp.Text = Name;
            Potc.Parent = tp;
            return tp;
        }

        public ToolStripMenuItem AddToolStripMenuItem(EventHandler _e)
        {
            ToolStripMenuItem tsmi = new ToolStripMenuItem();
            tsmi.Text = Name;
            tsmi.Click += _e;
            return tsmi;
        }

        public void AddLabelStateProduct(Control _parent, int _number, int _posX, int _posY, int _interX, int _interY)
        {
            Lsp = new LabelStateProduct(Name);
            Lsp.Location = new Point((_posX + (_interX * _number)), _posY);
            Lsp.Parent = _parent;
        }
    }
}
