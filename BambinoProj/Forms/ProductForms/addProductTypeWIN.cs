using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
using BambinoProj.IFS;

namespace BambinoProj.Forms.ProductForms
{
    public partial class addProductTypeWIN : Form
    {
       
        List<productTBL> prodList;
        List<productTypeTBL> prodTypeList;
        public addProductTypeWIN()
        {
            InitializeComponent();
        }

        private void dgvupdateProductData_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void updateAll()
        {

            prodTypeList = DBhelper.productTypeList;
            dgvProductData.DataSource = prodTypeList;
            productTypeCount.Text = "כמות סוגי המוצרים הם:" + prodTypeList.Count.ToString();
        }
        private void addNameOfProduct_Click(object sender, EventArgs e)
        {

        }

        private void addProductBTN_Click(object sender, EventArgs e)
        {
           productTypeTBL pType1 = new productTypeTBL();
            pType1.typeName = txtboxProductName.Texts.Trim();
            pType1.description = txtboxProductDescription.Texts.Trim();
            pType1 =  DBhelper.addproductTypeList(pType1);
            if (pType1 == null)
            {
                MessageBox.Show("error");
                return;
            }
            txtboxProductName.Texts = "";
            txtboxProductDescription.Texts = "";
            updateAll();
            MessageBox.Show("Added successfully");

        }



        private void productLocation_Click(object sender, EventArgs e)
        {

        }

        private void txtboxProductLocation__TextChanged(object sender, EventArgs e)
        {

        }

        private void txtboxProductPrice__TextChanged(object sender, EventArgs e)
        {

        }

        private void addTypeOfProduct_Click(object sender, EventArgs e)
        {

        }

        private void dgvProductData_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
          
        }

        private void txtboxProductName__TextChanged(object sender, EventArgs e)
        {

        }

        private void cmboboxProductTypes_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void typeId_Click(object sender, EventArgs e)
        {

        }

        private void addPriceToProduct_Click(object sender, EventArgs e)
        {

        }

        private void updateProductWIN_Load(object sender, EventArgs e)
        {
            updateAll();
        }

        private void productTypeCount_Click(object sender, EventArgs e)
        {

        }
    }
}
