using BambinoProj.Forms;
using BambinoProj.Forms.Clients;
using BambinoProj.Forms.Employes;
using BambinoProj.Forms.ProductForms;
using BambinoProj.IFS;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BambinoProj
{
    public partial class mainWin : Form
    {
        Form current = null;
        public mainWin()
        {
            InitializeComponent();
        }

        private void rjButton2_Click(object sender, EventArgs e)
        {

        }

        private void kryptonRibbonGroup1_DialogBoxLauncherClick(object sender, EventArgs e)
        {

        }

        private void kryptonRibbonGroupButton2_Click(object sender, EventArgs e)
        {

        }

        private void mainWin_Load(object sender, EventArgs e)
        {
            DBhelper.init();
           
        }

        private void ID__TextChanged(object sender, EventArgs e)
        {

        }

        private void rjTextBox1__TextChanged(object sender, EventArgs e)
        {

        }

        private void kryptonRibbon1_SelectedTabChanged(object sender, EventArgs e)
        {

        }

        private void kryptonGroup1_Panel_Paint(object sender, PaintEventArgs e)
        {

        }

        private void kryptonCheckBox1_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void saveFileDialog1_FileOk(object sender, CancelEventArgs e)
        {

        }

        private void הוספתמוצרToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (current != null)

            {

                if (current is addProductWin)

                {



                    return;

                }

                current.Close();

            }

            current = new addProductWin()

            {

                Dock = DockStyle.Fill,

                TopLevel = false,

                TopMost = true

            };

            mainPanel.Controls.Add(current);



            current.Show();
        }

        private void updateProductwin_Click(object sender, EventArgs e)
        {
            if (current != null)

            {

                if (current is addProductTypeWIN)

                {



                    return;

                }

                current.Close();

            }

            current = new addProductTypeWIN()

            {

                Dock = DockStyle.Fill,

                TopLevel = false,

                TopMost = true

            };

            mainPanel.Controls.Add(current);



            current.Show();
        }

        private void מאפיינימוצרToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (current != null)

            {

                if (current is characteristicsProductWin)

                {



                    return;

                }

                current.Close();

            }

            current = new characteristicsProductWin()

            {

                Dock = DockStyle.Fill,

                TopLevel = false,

                TopMost = true

            };

            mainPanel.Controls.Add(current);



            current.Show();
        }

        private void מידענוסףלמוצרToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (current != null)

            {

                if (current is addExtraData)

                {



                    return;

                }

                current.Close();

            }

            current = new addExtraData()

            {

                Dock = DockStyle.Fill,

                TopLevel = false,

                TopMost = true

            };

            mainPanel.Controls.Add(current);



            current.Show();
        
    }

        private void מחיקתמוצרToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (current != null)

            {

                if (current is updateProductWin)

                {



                    return;

                }

                current.Close();

            }

            current = new updateProductWin()

            {

                Dock = DockStyle.Fill,

                TopLevel = false,

                TopMost = true

            };

            mainPanel.Controls.Add(current);



            current.Show();
        }

        private void הוספתעובדToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (current != null)

            {

                if (current is addEmployedWin)

                {



                    return;

                }

                current.Close();

            }

            current = new addEmployedWin()

            {

                Dock = DockStyle.Fill,

                TopLevel = false,

                TopMost = true

            };

            mainPanel.Controls.Add(current);



            current.Show();
  
    }

        private void עדכוןעובדToolStripMenuItem_Click(object sender, EventArgs e)
        {
            
                            if (current != null)

            {

                if (current is updateEmploys)

                {



                    return;

                }

                current.Close();

            }

            current = new updateEmploys()

            {

                Dock = DockStyle.Fill,

                TopLevel = false,

                TopMost = true

            };

            mainPanel.Controls.Add(current);



            current.Show();

        }

        private void הוסףלקוחToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (current != null)

            {

                if (current is addClient)

                {



                    return;

                }

                current.Close();

            }

            current = new addClient()

            {

                Dock = DockStyle.Fill,

                TopLevel = false,

                TopMost = true

            };

            mainPanel.Controls.Add(current);



            current.Show();
        }
    }
    }

