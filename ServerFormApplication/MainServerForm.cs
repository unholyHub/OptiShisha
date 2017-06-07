using System;
using System.Data;
using System.Drawing;
using System.Windows.Forms;

namespace ServerFormApplication
{
    public partial class MainServerForm : Form
    {
        DataTable dt = new DataTable();

        public MainServerForm()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            dt.Columns.Add("ClientID");

            dt.Columns.Add("IPAddress");

            dt.Columns.Add("Call");

            dt.Columns.Add("Coal");

            dt.Columns.Add("Maintainence");

            dt.Columns.Add("Menu");

            dt.Columns.Add("Bill");

            dataGridView1.RowsDefaultCellStyle.BackColor = Color.White;
            dataGridView1.AlternatingRowsDefaultCellStyle.BackColor = Color.LightGray;

            dataGridView1.DataSource = dt;
            dataGridView1.Columns["IPAddress"].Visible = false;

            RefreshNumberOfTables(); 

            if (Properties.Settings.Default.NumberOfTables > 0)
            {
                Server.Start();
                SuccessfulConnection();
            }

            dataGridView1.CellDoubleClick += dataGridViewCellDoubleClick;
        }

        private void dataGridViewCellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            if (dataGridView1.Rows[e.RowIndex].Cells[e.ColumnIndex].Value != null)
            {
                if ((e.RowIndex + 1) % 2 == 0)
                {
                    dataGridView1.Rows[e.RowIndex].Cells[e.ColumnIndex].Style.BackColor = Color.LightGray;
                    return;
                }
                
                dataGridView1.Rows[e.RowIndex].Cells[e.ColumnIndex].Style.BackColor = Color.White;                
            }
        }

        private void RefreshNumberOfTables()
        {
            lblNumberOfClients.Text = "Total number of tables: " + Properties.Settings.Default.NumberOfTables;
        }

        public void ResetTable()
        {
            dataGridView1.DataSource = null;
            dataGridView1.DataSource = dt;
        }

        private void connectToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (Properties.Settings.Default.NumberOfTables == 0)
            {
                using (SettingsForm sf = new SettingsForm())
                {
                    sf.ShowDialog();
                }

                Server.Start();
                SuccessfulConnection();
                RefreshNumberOfTables();
                return;
            }

            Server.Start();
            SuccessfulConnection();
            RefreshNumberOfTables();
        }

        private void SuccessfulConnection()
        {
            this.btnSuccessfulConnect.Text = "Connected!";
            this.btnSuccessfulConnect.ForeColor = Color.Green;
            this.btnSuccessfulConnect.BackColor = Color.GreenYellow;
        }

        public void AddRow(string clientId, string ipAddress)
        {            
            dataGridView1.BeginInvoke(new MethodInvoker(() =>
            {
                DataRow row = dt.NewRow();

                row[0] = clientId;
                row[1] = ipAddress;
                
                dt.Rows.Add(row);
            }));
        }

        private void settingsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            using (SettingsForm sf = new SettingsForm())
            {
                sf.ShowDialog();
            }

            RefreshNumberOfTables();
        }

        int counter = 0;

        private void TestAddRowBtnClick(object sender, EventArgs e)
        {
            counter = (counter + 1);
            AddRow(counter.ToString(), "10.10.10.1" + (counter + 1));
        }

        private void TestCallBtnClick(object sender, EventArgs e)
        {
            string ipAddress = "10.10.10.14";
            Communication.NotifyForCall(dataGridView1, ipAddress, Services.Bill);
        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            
        }
    }
}
