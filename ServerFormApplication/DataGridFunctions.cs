using System.Drawing;
using System.Linq;
using System.Windows.Forms;

namespace ServerFormApplication
{
    static class DataGridFunctions
    {
        public static int FindIndexByValue(DataGridView dataGridView, string columnName, string searchValue)
        {
            int rowIndex = -1;

            DataGridViewRow row = dataGridView.Rows
                .Cast<DataGridViewRow>()
                .Where(r => r.Cells[columnName].Value.ToString().Equals(searchValue))
                .First();

            rowIndex = row.Index;

            return rowIndex;
        }

        public static void ChangeColor(DataGridView dataGridView1, int rowIndex, string columnName, Color color)
        {
            dataGridView1.Rows[rowIndex].Cells[columnName].Style.BackColor = color;
        }

    }
}
