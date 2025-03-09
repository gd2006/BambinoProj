using BambinoProj.IFS;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BambinoProj
{
    public partial class updateProductWin : Form
    {
        List<productTBL> productList;
        List<productTypeTBL> productTypeList;
        List<prodExtraKeys> prodExtraKeysList;
        public updateProductWin()
        {
            InitializeComponent();
        }

        private void kryptonLabel1_Click(object sender, EventArgs e)
        {

        }

        private void rjTextBox1__TextChanged(object sender, EventArgs e)
        {

        }

        private void updateProductBtn_Click(object sender, EventArgs e)
        {
            productTBL selected = cbxProducts.SelectedItem as productTBL;

            if (selected == null)
            {
                MessageBox.Show("Please select a product.");
                return;
            }
            selected.prodName = updateProductNameTBX.Texts.Trim();
            selected.price = (float)Convert.ToInt16(updateProductPricetBX.Texts.Trim());
            int productTypeID = selected.typeID;
            productTypeTBL selectedType = productTypeList.Where(x => x.Id == productTypeID).FirstOrDefault();
            cbxProductType.SelectedItem = selectedType;
            selected.typeID = selectedType.Id;
            selected.Location = txtboxProductLocationTBX.Texts.Trim();
            DBhelper.updateproductList(selected);
            selected.inStock = checkBoxInStock.Checked;
            MessageBox.Show("update successfully");



        }

        private void deleteProduct_Load(object sender, EventArgs e)
        {
          
            updateCBX();
            

        }

        private void updateCBX()
        {
            productTypeList = DBhelper.productTypeList;
            productList = DBhelper.productList;
            cbxProductType.DataSource = productTypeList;
            prodExtraKeysList = DBhelper.prodExtraKeysList;
            productList = DBhelper.productList;
            cbxProducts.DataSource = productList;
            cbxProducts_OnSelectedIndexChanged(null, null);

        }

        private void cbxProducts_OnSelectedIndexChanged(object sender, EventArgs e)
        {
            productTBL selected = (productTBL)cbxProducts.SelectedItem as productTBL;
            updateProductNameTBX.Texts = selected.prodName;
            updateProductPricetBX.Texts = selected.price.ToString();
            int productTypeID = selected.typeID;
            productTypeTBL selectedType = productTypeList.Where(x => x.Id == productTypeID).FirstOrDefault();
            cbxProductType.SelectedItem = selectedType;
            txtboxProductLocationTBX.Texts = selected.Location;
            checkBoxInStock.Checked = selected.inStock;
            List<productView> lst = DBhelper.productViewList.Where(x => x.productID == selected.Id).ToList();
            dgvExtraData.DataSource = cbxProductViewHidden.DataSource = lst;
            cbxProductViewHidden_SelectedIndexChanged(null,null);

        }

        private void deleteProductBTN_Click(object sender, EventArgs e)
        {

        }

        private void rjComboBox1_OnSelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void kryptonCheckBox1_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void cbxExtraData_SelectedIndexChanged(object sender, EventArgs e)
        {
            
        }

        private void btnAddExtraData_Click(object sender, EventArgs e)
        {
            prodExtraKeys selected = (prodExtraKeys)cbxProductViewHidden.SelectedItem;
            productTBL selectedProduct = (productTBL)cbxProducts.SelectedItem ;
            if (selectedProduct == null || selected == null)
            {
                return;
            }
            productExtraData toAdd = new productExtraData();
            toAdd.productID = selectedProduct.Id;
            toAdd.keyID = selected.Id;
            toAdd.value = txbExtraDataValue.Texts.Trim();
            DBhelper.addproductExtraData(toAdd);
            updateCBX();
            cbxProducts.SelectedItem = selectedProduct;
            MessageBox.Show("update successfully");

        }

        private void cbxProductViewHidden_SelectedIndexChanged(object sender, EventArgs e)
        {
            productView selected = (productView)cbxProductViewHidden.SelectedItem;
            if (selected == null)
                return;
            txbExtraDataValue.Texts = selected.value;
        }

        private void btnUpdateExtraData_Click(object sender, EventArgs e)
        {
            productView selected = (productView)cbxProductViewHidden.SelectedItem;
            if (selected == null)
                return;
            string newValue = txbExtraDataValue.Texts.Trim() ;
            productExtraData toUpdate = DBhelper.productExtraDataList.Where(x => x.productID == selected.productID && x.keyID == selected.keyID).FirstOrDefault();
            if (toUpdate == null)
            {
                MessageBox.Show("error");
                return; 
            }
            toUpdate.value = newValue;
            if (DBhelper.updateExtraDataList(toUpdate))
            {
                updateCBX();
            }
        }
    }
}
