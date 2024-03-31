using System;
using System.Collections.Generic;
using System.Drawing.Printing;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SW_Cons__T_T_Asgnmnt
{
    internal class DataGridViewPrinter
    {
        public static void PrintDataGridView(DataGridView dataGridView, PrintPageEventArgs e)
        {
            // Set the area for printing
            float yPos = 0f;
            int count = 0;
            float leftMargin = e.MarginBounds.Left;
            float topMargin = e.MarginBounds.Top;
            float rightMargin = e.MarginBounds.Right;

            // Print the header
            foreach (DataGridViewColumn column in dataGridView.Columns)
            {
                e.Graphics.DrawString(column.HeaderText, dataGridView.Font, Brushes.Black, leftMargin, topMargin + yPos);
                leftMargin += column.Width;
            }

            yPos += dataGridView.ColumnHeadersHeight;

            // Print each row
            foreach (DataGridViewRow row in dataGridView.Rows)
            {
                leftMargin = e.MarginBounds.Left;
                foreach (DataGridViewCell cell in row.Cells)
                {
                    e.Graphics.DrawString(cell.Value?.ToString(), dataGridView.Font, Brushes.Black, leftMargin, topMargin + yPos);
                    leftMargin += cell.OwningColumn.Width;
                }
                yPos += row.Height;
                count++;

                // Check if more pages are needed
                if (count % 50 == 0)
                {
                    e.HasMorePages = true;
                    return;
                }
            }

            // No more pages
            e.HasMorePages = false;
        }
    }
}
