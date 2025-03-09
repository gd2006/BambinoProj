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
using static System.ComponentModel.Design.ObjectSelectorEditor;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.StartPanel;

namespace BambinoProj.Forms.Employes
{
    public partial class addEmployedWin : Form
    {
        List<EmployesTBL> employesList;
        public addEmployedWin()
        {
            InitializeComponent();
        }
        private void updateAll()
        {
            employesList = DBhelper.employesList;
            employeddgv.DataSource = employesList;
        }
        private void addEmployedBtn_Click(object sender, EventArgs e)
        {           
            EmployesTBL e1 = new EmployesTBL();
            e1.EmployedName = txtboxEmployedName.Texts.Trim();
            e1.EmployedLastName = txtbxEmployedLastName.Texts.Trim();
            e1.Email = txtboxEmployedEmailAddress.Texts.Trim();
            e1.NameOfTheBank = txtbxEmployedBankName.Texts.Trim();
            if (txtbxBankAccountNumber.Texts.Trim().Length > 9)
            {
                MessageBox.Show("מספר חשבון הבנק לא יכול להיות גדול מ9 ספרות ,אנא וודא שלא שגית בהקלדת החשבון");
                return;
            }
            else
            {
                e1.BankAccountNumber = txtbxBankAccountNumber.Texts.Trim();

            }
            if (txtbxEmployedBankBranchNumber.Texts.Trim().Length == 3)
            {
                e1.BankBranchNumber = txtbxEmployedBankBranchNumber.Texts.Trim();
            }
            else
            {
                MessageBox.Show("מספר הסניף חייב להיות בעל 3 ספרות , אנא וודא שלא נעשתה טעות בהקלדת מספר הסניף");
                return;
            }
            e1.PhoneNumber = txtbxEmployedPhoneNumber.Texts.Trim();
            e1.BirthDate = employeBirthDatePiker.Value.Date; ;
            e1 = DBhelper.addEmployed(e1);
            if (e1 == null)
            {
                MessageBox.Show("error");
                return;
            }
            txtboxEmployedName.Texts = "";
            txtbxEmployedLastName.Texts = "";
            txtboxEmployedEmailAddress.Texts = "";
            txtbxEmployedBankName.Texts = "";
            txtbxEmployedBankBranchNumber.Texts = "";
            txtbxBankAccountNumber.Texts = "";
            txtbxEmployedPhoneNumber.Texts = "";
            updateAll();
            MessageBox.Show("Added successfully");

        }

        private void addEmployedWin_Load(object sender, EventArgs e)
        {
            employeBirthDatePiker.MaxDate = DateTime.Now.AddYears(-18);
            updateAll();

        }

        private void employeddgv_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
