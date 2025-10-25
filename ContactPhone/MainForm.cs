using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ContactPhone
{
    public partial class MainForm : Form 
 
    {
        IContactsRepository repository;

        public MainForm()
        {
            InitializeComponent();
            repository = new ContactsRepository();
        }
        private void MainForm_Load(object sender, EventArgs e)
        {
            dgContacts.AutoGenerateColumns = false;

            dgContacts.DataSource = repository.SelectAll();
        }

        private void dgContacts_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
