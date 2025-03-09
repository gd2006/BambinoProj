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

namespace BambinoProj.Forms.Clients
{
    public partial class addClient : Form
    {
        List<ClientsTBL> clientsList;
        //function that update the data tabel of clients  
        private void updateAll()
        {
            clientsList = DBhelper.clientsList;
            clientdgv.DataSource = clientsList;
        }
        public addClient()
        {
            InitializeComponent();
        }

        private void nameOfTheBank_Click(object sender, EventArgs e)
        {

        }

        private void addClient_Load(object sender, EventArgs e)
        {

        }

        private void addClientBtn_Click(object sender, EventArgs e)
        {
        //create new client variable 
            ClientsTBL c1 = new ClientsTBL();
        //define new client name
            c1.clientName = clientNameTBX.Texts.Trim();
        //define new client last name
            c1.clientLastName = lastNameClientTBX.Texts.Trim();
        //define new client Email
            c1.Email = clientEmailTBX.Texts.Trim();
        //define new client phone number
            c1.clientPhone = clientPhoneNumberTBX.Texts.Trim();
        //define new client payment method
            c1.paymentMethod = comboBox1.Text.Trim();
            //define new client Institution Symbol
            c1.clientInstitutionSymbol = institutionSymbolTBX.Text.Trim();
            //checking that new client isn't Null
            if (c1 == null)
            {
                MessageBox.Show("please insert details");
                return;
            }
            //add new client to the database
            c1 = DBhelper.addclients(c1);

            clientNameTBX.Texts = "";
            lastNameClientTBX.Texts = "";
            clientEmailTBX.Texts = "";
            clientPhoneNumberTBX.Texts = "";
            institutionSymbolTBX.Texts = "";
            updateAll();
            MessageBox.Show("Added successfully");

        }

        private void rjComboBox1_OnSelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
    }

