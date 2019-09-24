using LibraryProduction;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ToutEmbal
{
    public partial class MainForm : Form
    {
        public Dictionary<string, ShowProduction> ShowProductions;

        public MainForm()
        {
            InitializeComponent();
            ShowProductions = new Dictionary<string, ShowProduction>();
        }

        private void Form1_Load(object sender, EventArgs e)
        {         
            if(ShowProductions.Count == 0)
            {
                TCProd.Visible = false;
                MenuItemProd.Enabled = false;
            }
        }

        private void Prod_ProductChange(Production p)
        {
            if(ShowProductions.FirstOrDefault(x => x.Key == p.GetName()).Value is ShowProduction sp)
            {
                sp.Lpb.Invoke(new Action(() =>
                {
                    sp.Lpb.UpdateProgressBar(p.GetNumberBoxBuild());
                }));
                sp.Potc.Invoke(new Action(() =>
                {
                    sp.Potc.UpdatePage(p.GetNumberBoxBuild(), p.GetNumberBoxDefault(), p.GetNumberBoxDefault());
                }));
                if(sp.Prod.GetNumberBoxBuild() == sp.Prod.GetObjectifNumberProduct())
                {
                    sp.Lsp.FinishProduct();
                }
            }           
        }

        private void AddProductClick(object sender, EventArgs e)
        {
            AddProduct ap = new AddProduct();
            ap.Location = new Point(50,50);
            ap.AddOneProduct += CreateProduction;
            ap.ShowDialog();           
        }

        private void StartClick(object sender, EventArgs e)
        {   
            if(sender is ToolStripMenuItem choice)
            {
                if (ShowProductions.FirstOrDefault(x => x.Key == choice.Text).Value is ShowProduction sp)
                {
                    if(sp.Prod.Start())
                    {
                        sp.Lsp.InProgressProduct();
                    }
                } 
            }           
        }

        private void PauseClick(object sender, EventArgs e)
        {
            if(sender is ToolStripMenuItem choice)
            {
                if(ShowProductions.FirstOrDefault(x => x.Key == choice.Text).Value is ShowProduction sp)
                {                 
                    if(sp.Prod.Pause())
                    {
                        sp.Lsp.PauseProduct();
                    }
                }
            }            
        }

        private void ResumeClick(object sender, EventArgs e)
        {
            if(sender is ToolStripMenuItem choice)
            {
                if(ShowProductions.FirstOrDefault(x => x.Key == choice.Text).Value is ShowProduction sp)
                {               
                    if(sp.Prod.Continue())
                    {
                        sp.Lsp.InProgressProduct();
                    }
                }
            }
        }

        public void CreateProduction(string _name, int _numberOfProduct, int _speedProduct)
        {
            if(!ShowProductions.ContainsKey(_name))
            {
                ShowProduction sp = new ShowProduction(_name);
                sp.AddProduction(_numberOfProduct, _speedProduct, Prod_ProductChange);
                sp.AddLabelProgressBar(_numberOfProduct, _speedProduct, this, ShowProductions.Count(), 15, 257, 0, 40);
          

                ProdItemStart.DropDownItems.Add(sp.AddToolStripMenuItem(StartClick));
                ProdItemSuspend.DropDownItems.Add(sp.AddToolStripMenuItem(PauseClick));
                ProdItemResume.DropDownItems.Add(sp.AddToolStripMenuItem(ResumeClick));
                sp.AddLabelStateProduct(this, ShowProductions.Count(), 42, 37, 53, 0);
                ShowProductions.Add(_name, sp);
                TCProd.Visible = true;
                MenuItemProd.Enabled = true;

                MessageBox.Show("Production " + _name + " ajouté", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                MessageBox.Show("Une production est déja nommé " + _name, "Erreur", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void StartAllClick(object sender, EventArgs e)
        {
            foreach(ShowProduction sp in ShowProductions.Values)
            {
                if(sp != null)
                {
                    if (sp.Prod.Start())
                    {
                        sp.Lsp.InProgressProduct();
                    }
                }
            }
        }

        private void PauseAllClick(object sender, EventArgs e)
        {
            foreach (ShowProduction sp in ShowProductions.Values)
            {
                if (sp != null)
                {
                    if (sp.Prod.Pause())
                    {
                        sp.Lsp.PauseProduct();
                    }
                }
            }
        }

        private void ResumeAllClick(object sender, EventArgs e)
        {
            foreach (ShowProduction sp in ShowProductions.Values)
            {
                if (sp != null)
                {
                    if (sp.Prod.Continue())
                    {
                        sp.Lsp.InProgressProduct();
                    }
                }
            }
        }
    }
}
