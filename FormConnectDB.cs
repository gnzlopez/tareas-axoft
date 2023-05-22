using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace axoftTareas
{
    public partial class FormConnectDB : Form
    {
        public string ConnString { get; set; }

        public FormConnectDB()
        {
            InitializeComponent();
        }

        private void btnAcceptConnString_Click(object sender, EventArgs e)
        {
            ConnString = txtBoxConnString.Text;
            this.DialogResult = DialogResult.OK;
            this.Close();
        }
    }
}
