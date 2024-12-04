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
    public partial class addProductWin : Form
    {
     
        List<productTBL> prodList;
        List<productTypeTBL> prodTypeList;
        public addProductWin()
        {
            InitializeComponent();
        }
        private void addProductWin_Load_1(object sender, EventArgs e)
        {

            updateAll();
        }

        private void addProductWin_Load(object sender, EventArgs e)
        {
          

        }

        private void updateAll()
        {
            prodList = DBhelper.productList;
            prodTypeList = DBhelper.productTypeList;
            cmboboxProductTypes.DataSource = prodTypeList;
            dgvProductData.DataSource = cbxHiddenProducts.DataSource = prodList;
        }

        private void addNameOfProduct_Click(object sender, EventArgs e)
        {

        }

        private void addTypeOfProduct_Click(object sender, EventArgs e)
        {

        }

        private void addProductBTN_Click(object sender, EventArgs e)
        {
            productTypeTBL selectedType = cmboboxProductTypes.SelectedItem as productTypeTBL;
            if (selectedType == null)
            {
                MessageBox.Show("Please select a product type.");
                return;
            }
            productTBL pType1 = new productTBL();
            pType1.prodName = txtboxProductName.Texts.Trim();
            pType1.price = (float) Convert.ToInt16( txtboxProductPrice.Texts.Trim());
            int selectedTypeID = selectedType.Id;
            pType1.typeID = selectedTypeID;
            pType1.Location = txtboxProductLocation.Texts.Trim();
            pType1 = DBhelper.addproductList(pType1);
            if (pType1 == null)
            {
                MessageBox.Show("error");
                return;
            }
            txtboxProductName.Texts = "";
            txtboxProductPrice.Texts = "";
            txtboxProductLocation.Texts = "";
                
            updateAll();
            MessageBox.Show("Added successfully");

        }

        private void dgvProductData_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void cmboboxProductTypes_SelectedIndexChanged(object sender, EventArgs e)
        {
                
        }

        private void cbxHiddenProducts_SelectedIndexChanged(object sender, EventArgs e)
        {
            productTBL selectedProduct = (productTBL)cbxHiddenProducts.SelectedItem;
            if (selectedProduct == null)
            {
                dgvExtraData.DataSource = null;
                return;
            }
            List<productView> lst = DBhelper.productViewList.Where(x => x.productID == selectedProduct.Id).ToList();
            dgvExtraData.DataSource = lst;
        }
    }
}
