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

namespace BambinoProj.Forms
{
    public partial class characteristicsProductWin : Form
    {
        List<prodExtraKeys> prodKeysList;
        List<productExtraData> prodExtraDataList;
        public characteristicsProductWin()
        {
            InitializeComponent();
        }

        private void keyDescriptionLabel_Click(object sender, EventArgs e)
        {

        }
        private void updateAll()
        {
            prodKeysList = DBhelper.prodExtraKeysList;
            keyDGV.DataSource = prodKeysList;
        }
        private void addKeyBTN_Click(object sender, EventArgs e)
        {
            prodExtraKeys pType1 = new prodExtraKeys();
            pType1.KeyName = keyNametxtbox.Texts.Trim();
            pType1.KeyDescription = KeyDescriptiontxtbox.Texts.Trim();
            pType1 = DBhelper.addprodExtraKeys(pType1);
            if (pType1 == null)
            {
                MessageBox.Show("error");
                return;
            }
            keyNametxtbox.Texts = "";
            KeyDescriptiontxtbox.Texts = "";
            updateAll();
            MessageBox.Show("Added successfully");

        }

        private void characteristicsProductWin_Load(object sender, EventArgs e)
        {
            updateAll();

        }

        private void keyDGV_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
