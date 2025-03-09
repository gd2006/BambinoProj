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

namespace BambinoProj.Forms.ProductForms
{
    public partial class addExtraData : Form
    {
        List<productTBL> prodList;
        List<prodExtraKeys> prodExtraKeysList;
        List<productExtraData> productExtraDataLst;

        public addExtraData()
        {
            InitializeComponent();
        }
        private void updateAll()
        {
            prodList = DBhelper.productList;
            prodExtraKeysList = DBhelper.prodExtraKeysList;
            productExtraDataLst = DBhelper.productExtraDataList;
            productIdNameCBX.DataSource = prodList;
            ProductKeyCBX.DataSource = prodExtraKeysList;
            dgvProductExtreData.DataSource = productExtraDataLst ;
        }
        private void addNameOfProduct_Click(object sender, EventArgs e)
        {

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

        private void addExtraData_Load(object sender, EventArgs e)
        {
            updateAll();
        }

        private void addExtraDataBTN_Click(object sender, EventArgs e)
        {
            productTBL selectedproduct= productIdNameCBX.SelectedItem as productTBL;
            if (selectedproduct == null)
            {
                MessageBox.Show("Please select a product.");
                return;
            }
            prodExtraKeys selectedkey = ProductKeyCBX.SelectedItem as prodExtraKeys;
            if (selectedkey == null)
            {
                MessageBox.Show("Please select a characteristic.");
                return;
            }

            productExtraData pType1 = new productExtraData();
            int selectedproductId = selectedproduct.Id;
            pType1.productID = selectedproductId;

            int selectedproductkey = selectedkey.Id;
            pType1.keyID = selectedproductkey;

            pType1.value = txtboxProductvalue.Texts.Trim();
            pType1 = DBhelper.addproductExtraData(pType1);
            if (pType1 == null)
            {
                MessageBox.Show("error");
                return;
            }
            txtboxProductvalue.Texts = "";

            updateAll();
            MessageBox.Show("Added successfully");

        }
    }
}
