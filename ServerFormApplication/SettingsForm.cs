using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ServerFormApplication
{
    public partial class SettingsForm : Form
    {
        public SettingsForm()
        {
            InitializeComponent();
            this.txtNumberOfTables.Text = Properties.Settings.Default.NumberOfTables.ToString();
        }

        private void btnOk_Click(object sender, EventArgs e)
        {
            Properties.Settings.Default.NumberOfTables = Convert.ToInt32(this.txtNumberOfTables.Text);
            Properties.Settings.Default.Save();
            this.DialogResult = DialogResult.OK;
        }
    }
}
