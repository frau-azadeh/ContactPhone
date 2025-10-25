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
            BindGrid();
        }

        private void BindGrid()
        {
            dgContacts.AutoGenerateColumns = false;

            dgContacts.DataSource = repository.SelectAll();
        }

        private void dgContacts_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void btnRefresh_Click(object sender, EventArgs e)
        {
            BindGrid();
        }
    }
}
