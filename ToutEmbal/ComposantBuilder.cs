using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ToutEmbal
{
    class ComposantBuilder
    {
        public Label CreateLabel(Control _parent, string _name, string _text, int _width, int _height, int _posX, int _posY)
        {
            Label l = new Label();
            l.Name = "L" + _name;
            l.Text = _text;
            l.Size = new Size(_width, _height);
            l.Location = new Point(_posX, _posY);
            l.Parent = _parent;
            return l;
        }

        public TextBox CreateTextBox(Control _parent, string _name, string _ValueDefault, int _width, int _height, int _posX, int _posY)
        {
            TextBox tb = new TextBox();
            tb.Name = "TB" + _name;
            tb.Text = _ValueDefault;
            tb.Size = new Size(_width, _height);
            tb.Location = new Point(_posX, _posY);
            tb.Parent = _parent;
            return tb;
        }

        public Button CreateButton(Control _parent, string _name, string _text, int _width, int _height, int _posX, int _posY, EventHandler _eh)
        {
            Button b = new Button();
            b.Name = "B" + _name;
            b.Text = _text;
            b.Size = new Size(_width, _height);
            b.Location = new Point(_posX, _posY);
            b.Parent = _parent;
            b.Click += _eh;
            return b;
        }

        public TabPage CreateTabPage(string _name)
        {
            TabPage tp = new TabPage();

            return tp;
        }

        public ProgressBar CreateProgressBar(string _name, int _valueMin, int _valueMax, int _step, int _width, int _height, int _posX, int _posY)
        {
            ProgressBar pb = new ProgressBar();
            pb.Name = "PB" + _name;
            pb.Minimum = _valueMin;
            pb.Value = _valueMin;
            pb.Maximum = _valueMax;
            pb.Step = _step;
            pb.Size = new Size(_width, _height);
            pb.Location = new Point(_posX, _posY);
            return pb;
        }
    }
}
