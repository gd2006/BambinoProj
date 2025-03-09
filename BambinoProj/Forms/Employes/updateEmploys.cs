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

namespace BambinoProj.Forms.Employes
{
    public partial class updateEmploys : Form
    {
        List<EmployesTBL> employesList;
        private void updateAll()
        {
            employesList = DBhelper.employesList;
            updateEmployeddgv.DataSource = employesList;
        }
        public updateEmploys()
        {
            InitializeComponent();
        }

        private void updateEmploys_Load(object sender, EventArgs e)
        {
            updateAll();
            updateCBX();


        }
        private void updateCBX()
        {
            employesList = DBhelper.employesList;
            cbxEmploys.DataSource = employesList;
            cbxEmploys_OnSelectedIndexChanged(null, null);

        }

        private void cbxEmploys_OnSelectedIndexChanged(object sender, EventArgs e)
        {
            EmployesTBL selected = (EmployesTBL)cbxEmploys.SelectedItem as EmployesTBL;
            updateENameTBX.Texts = selected.EmployedName;
            updateELastNameTBX.Texts = selected.EmployedLastName;
            updateEPhoneNumTBX.Texts = selected.PhoneNumber;
            updateEEmailTBX.Texts = selected.Email;
            updateEBankNameTBX.Texts = selected.NameOfTheBank;
            updateEBranchNumTBX.Texts = selected.BankBranchNumber;
            updateEaccountNumTBX.Texts = selected.BankAccountNumber;
            updateEbirthDateTBX.Value = selected.BirthDate;
        }

        private void updateEmployedBtn_Click(object sender, EventArgs e)
        {
            EmployesTBL selected = cbxEmploys.SelectedItem as EmployesTBL;

            if (selected == null)
            {
                MessageBox.Show("Please select a product.");
                return;
            }
            selected.EmployedName = updateENameTBX.Texts.Trim();
            selected.EmployedLastName = updateELastNameTBX.Texts.Trim(); 
            selected.Email = updateEEmailTBX.Texts.Trim();
            selected.BirthDate = updateEbirthDateTBX.Value;
            if (updateEBranchNumTBX.Texts.Trim().Length == 3)
            {
                selected.BankBranchNumber = updateEBranchNumTBX.Texts.Trim();
            }
            else
            {
                MessageBox.Show("מספר הסניף חייב להיות בעל שלושה ספרות");
                return;
            }
            if (updateEaccountNumTBX.Texts.Trim().Length > 9)
            {
                MessageBox.Show("מספר חשבון לא יכול להיות גדול מ9 סםרות");
                return;
            }
            else
            {
                selected.BankAccountNumber = updateEaccountNumTBX.Texts.Trim();
            }
            selected.NameOfTheBank = updateEBankNameTBX.Texts.Trim();
            selected.PhoneNumber = updateEPhoneNumTBX.Texts;
            DBhelper.updateEmployesList(selected);
            MessageBox.Show("update successfully");
            updateAll();

        }
    }
}
