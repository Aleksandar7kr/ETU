using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.IO;

using Kruskal;

namespace Savage
{
    public partial class MainForm : Form
    {
        Matrix2d srcModel;
        Matrix2d calcModel;
       
        public MainForm()
        {
            InitializeComponent();

            xyView.ColumnAdded += new DataGridViewColumnEventHandler(xyView_ColumnAdded);
            xyView.RowsAdded += new DataGridViewRowsAddedEventHandler(xyView_RowsAdded);
            pView.ColumnAdded += new DataGridViewColumnEventHandler(pView_ColumnAdded);

            xyView.RowCount = 2;
            xyView.ColumnCount = 2;
            pView.ColumnCount = 2;
            pView.RowCount = 1;
            resView.RowCount = 2;
            resView.ColumnCount = 3;

            resView.Columns[0].HeaderText = "Ui";
            resView.Columns[1].HeaderText = "Fc";
            resView.Columns[2].HeaderText = "Pb";

        }

        void pView_ColumnAdded(object sender, DataGridViewColumnEventArgs e)
        {
            foreach (DataGridViewColumn column in pView.Columns)
            {
                column.HeaderText = "p" + (column.Index + 1).ToString();
            }
        }

        void xyView_RowsAdded(object sender, DataGridViewRowsAddedEventArgs e)
        {
            foreach (DataGridViewRow row in xyView.Rows)
            {
                row.HeaderCell.Value = "x" + (row.Index + 1).ToString();
            }
        }

        void xyView_ColumnAdded(object sender, DataGridViewColumnEventArgs e)
        {
            foreach (DataGridViewColumn column in xyView.Columns)
            {
                column.HeaderText = "y" + (column.Index + 1).ToString();
            }
        }

        private void addColumnToolStripMenuItem_Click(object sender, EventArgs e)
        {
            xyView.ColumnCount += 1;
            pView.ColumnCount += 1;
            int x = xyView.ColumnCount;
            int y = xyView.RowCount;
            srcModel = new Matrix2d(x, y, 0);

            for (int i = 0; i < y; i++)
            {
                for (int j = 0; j < x; j++)
                {
                    try
                    {
                        srcModel[j, i] = double.Parse(xyView.Rows[i].Cells[j].Value.ToString());
                    }
                    catch (Exception)
                    {
                        xyView.Rows[i].Cells[j].Value = 0;
                        srcModel[j, i] = 0;
                    }
                }
            }
        }

        private void addRowToolStripMenuItem_Click(object sender, EventArgs e)
        {
            xyView.Rows.Add(1);
            resView.Rows.Add(1);
            int x = xyView.ColumnCount;
            int y = xyView.RowCount;
            srcModel = new Matrix2d(x, y, 0);

            for (int i = 0; i < y; i++)
            {
                for (int j = 0; j < x; j++)
                {
                    try
                    {
                        srcModel[j, i] = double.Parse(xyView.Rows[i].Cells[j].Value.ToString());
                    }
                    catch (Exception)
                    {
                        xyView.Rows[i].Cells[j].Value = 0;
                        srcModel[j, i] = 0;
                    }
                }
            }
        }

        private void openToolStripMenuItem_Click(object sender, EventArgs e)
        {
            OpenFileDialog of = new OpenFileDialog();
            if (of.ShowDialog() == DialogResult.OK)
            {
                StreamReader f = new StreamReader(of.FileName);
                int x = Convert.ToInt32(f.ReadLine());
                int y = Convert.ToInt32(f.ReadLine());

                xyView.RowCount = y;
                xyView.ColumnCount = x;
                pView.ColumnCount = x;
                pView.RowCount = 1;
                resView.RowCount = y;

                srcModel = new Matrix2d(x, y, 0);

                for (int i = 0; i < y; i++)
                {
                    string[] s = f.ReadLine().Split();
                    for (int j = 0; j < x; j++)
                    {
                        xyView.Rows[i].Cells[j].Value = double.Parse(s[j]);
                        srcModel[j,i] = double.Parse(s[j]);
                    }
                }

                string[] ss = f.ReadLine().Split();
                for (int j = 0; j < x; j++)
                {
                    pView.Rows[0].Cells[j].Value = double.Parse(ss[j]);
                }
                xyView.CellValueChanged += new DataGridViewCellEventHandler(xyView_CellValueChanged);
            }
        }

        void xyView_CellValueChanged(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                double data = double.Parse(xyView[e.ColumnIndex, e.RowIndex].Value.ToString());
                srcModel[e.ColumnIndex, e.RowIndex] = data;
            }
            catch (Exception)
            {
          //      xyView[e.ColumnIndex, e.RowIndex].Value = 0;
            }
        }

        private void Calc()
        {
            calcModel = new Matrix2d(srcModel.XSize, srcModel.YSize, 0);

            for (int i = 0; i < calcModel.XSize; i++)
            {
                double max = srcModel.MaxValueAtColumn(i);
                for (int j = 0; j < calcModel.YSize; j++)
                {
                    calcModel[i,j] = max - srcModel[i,j];
                }
            }         

            for (int i = 0; i < srcModel.YSize; i++)
            {
                double s = 0;
                for (int j = 0; j < srcModel.XSize; j++)
                {
                    double a = srcModel[j, i];
                    double b = Convert.ToDouble(pView[j, 0].Value);
                    s += a*b;
                }
                resView[0, i].Value = s;
            }

            for (int i = 0; i < resView.RowCount; i++)
            {
                resView[1, i].Value = calcModel.MaxValueAtRow(i);
            }

            for (int i = 0; i < resView.RowCount; i++)
            {
                double s = 0;
                for (int j = 0; j < calcModel.XSize; j++)
                {
                    s+=(calcModel[j,i]*calcModel[j,i]);
                }
                resView[2, i].Value = Math.Sqrt(s).ToString();
            }

        }

        private void calcToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Calc();
        }

        private void saveToolStripMenuItem_Click(object sender, EventArgs e)
        {
            SaveFileDialog sf = new SaveFileDialog();
            if (sf.ShowDialog() == DialogResult.OK)
            {
                StreamWriter f = new StreamWriter(sf.FileName);
                f.WriteLine(xyView.ColumnCount.ToString());
                f.WriteLine(xyView.RowCount.ToString());

                for (int i = 0; i < xyView.RowCount; i++)
                {
                    for (int j = 0; j < xyView.ColumnCount; j++)
                    {
                        f.Write(xyView[j, i].Value.ToString() + " ");
                    }
                    f.WriteLine();
                }

                for (int i = 0; i < pView.RowCount; i++)
                {
                    for (int j = 0; j < pView.ColumnCount; j++)
                    {
                        f.Write(pView[j, i].Value.ToString() + " ");
                    }
                    f.WriteLine();
                }

                for (int i = 0; i < resView.RowCount; i++)
                {
                    for (int j = 0; j < resView.ColumnCount; j++)
                    {
                        f.Write(resView[j, i].Value.ToString() + " ");
                    }
                    f.WriteLine();
                }
                f.Close();
            }
        }

        private void operationsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            try
            {
                for (int i = 0; i < xyView.RowCount; i++)
                {
                    for (int j = 0; j < xyView.ColumnCount; j++)
                    {
                        double.Parse(xyView[j, i].Value.ToString());
                    }
                }
                for (int j = 0; j < xyView.ColumnCount; j++)
                {
                    double.Parse(xyView[j, 0].Value.ToString());
                }
                calcToolStripMenuItem.Enabled = true;
                saveToolStripMenuItem.Enabled = true;
            }
            catch (Exception)
            {
                calcToolStripMenuItem.Enabled = false;
                saveToolStripMenuItem.Enabled = false;
            }
        }

        private void exitWithoutSaveToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}