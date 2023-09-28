using System;
using System.Windows.Forms;

namespace KenoApp
{
    static class ExtensionMethod
    {
        public static bool ValidationCell(this DataGridViewCell cell)
        {
            cell.ErrorText = null;
            bool validationOk = true;
            if (cell != null && cell.Value.ToString()!="")
            {
                int content;
                if (Int32.TryParse(cell.Value.ToString(), out content))
                {
                    if (content < 1 || content > 99)
                    {
                        cell.ErrorText = Properties.Resources.InvalidRange;
                        validationOk = false;

                    }
                }
                else
                {
                    cell.ErrorText = Properties.Resources.NotANumber;
                    validationOk = false;
                }
                for(int i=0; i<4; i++)
                {
                    DataGridView dataGV = cell.DataGridView;
                    if (dataGV[i + 2, cell.RowIndex].Value.ToString() == "")
                    {
                        validationOk = false;
                        cell.DataGridView[i + 2, cell.RowIndex].ErrorText = Properties.Resources.MissingNumbers;
                    }
                    
                }
            }            

            return validationOk;
        }

        public static void ClearErrorText(this DataGridView grid)
        {
            for(int i=0; i<grid.Columns.Count; i++)
            {
                for(int j=0; j<grid.Rows.Count; j++)
                {
                    grid[i, j].ErrorText = null;
                }
            }
        }

        public static bool DataExists(this DataGridView grid)
        {
            bool dataExists = false;
            for (int i = 2; i < grid.Columns.Count; i++)
            {
                for (int j = 0; j < grid.Rows.Count; j++)
                {
                    if(grid[i, j].Value.ToString() != "")
                    {
                        dataExists = true;
                        break;
                    }
                }
            }
            return dataExists;
        }
    }
}

