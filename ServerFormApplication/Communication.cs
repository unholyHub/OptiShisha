using System;
using System.Drawing;
using System.Windows.Forms;

namespace ServerFormApplication
{
    public static class Communication
    {
        public static void NotifyForCall(DataGridView dataGridView1, string ipAddress, Services service)
        {
            int rowIndex = DataGridFunctions.FindIndexByValue(dataGridView1, "IPAddress", ipAddress);

            DataGridFunctions.ChangeColor(dataGridView1, rowIndex, service.ToString(), Color.Green);
        }

        public static void ProcessRecievedMessage(string recievedMessage, string ipAddress)
        {
            Services service = Services.None;

            switch (recievedMessage)
            {
                case "Bill":
                    {
                        NotifyForCall(MainServerForm.dataGridView1, ipAddress, Services.Bill);
                        break;
                    }
                case "Maintenance":
                    {
                        NotifyForCall(MainServerForm.dataGridView1, ipAddress, Services.Maintainence);
                        break;
                    }
                case "Call":
                    {
                        NotifyForCall(MainServerForm.dataGridView1, ipAddress, Services.Call);
                        break;
                    }
                case "Coal":
                    {
                        NotifyForCall(MainServerForm.dataGridView1, ipAddress, Services.Coal);
                        break;
                    }
                case "Menu":
                    {
                        NotifyForCall(MainServerForm.dataGridView1, ipAddress, Services.Menu);
                        break;
                    }
                case null:
                default:
                    break;
            }
        }
    }
}
