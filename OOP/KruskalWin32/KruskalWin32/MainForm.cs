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

namespace KruskalWin32
{
    public partial class MainForm : Form
    {
        private Kruskal.SquareMatrix2d srcMatrixModel;
        private Kruskal.SquareMatrix2d minSpannedTreeModel;

        private DataGridView srcMatrixView;
        private DataGridView spannedTreeView;

        public MainForm()
        {
            InitializeComponent();

            splitMainForm.SplitterDistance = (splitMainForm.Width) / 2;
            splitLeftPanel.SplitterDistance = (splitMainForm.Height) / 2;
            splitRightPanel.SplitterDistance = (splitMainForm.Height) / 2;
            splitLeftPanel.Panel2.RightToLeft = System.Windows.Forms.RightToLeft.No; //?

            this.Paint += new PaintEventHandler(MainForm_Paint);
            this.Resize += new EventHandler(MainForm_Resize);

            srcMatrixView = new DataGridView();
            spannedTreeView = new DataGridView();

            srcMatrixView.CellValueChanged += new DataGridViewCellEventHandler(matrixViewCellValueChanged);
        }

        #region events

        void MainForm_Resize(object sender, EventArgs e)
        {
            pbLeft.Refresh();
            pbRight.Refresh();
        }
        void MainForm_Paint(object sender, PaintEventArgs e)
        {
            pbLeft.Refresh();
            pbRight.Refresh();
        }

        private void pbRight_Paint(object sender, PaintEventArgs e)
        {
            double rad = (360 / minSpannedTreeModel.XSize * 3.14) / 180;
            Coord[] xy = new Coord[minSpannedTreeModel.XSize];
            float y0 = pbLeft.Height / 2;
            float x0 = pbLeft.Width / 2;
            double r = (x0 > y0 ? y0 : x0) - 20;

            Pen linePen = new Pen(Color.Green, 2);
            Pen numberPen = new Pen(Color.Black, 2);
            Pen whiteNumberPen = new Pen(Color.White, 3);
            Pen vertexPen = new Pen(Color.Red, 1);
            for (int i = 0; i < minSpannedTreeModel.XSize; i++)
            {
                xy[i].x = (int)(Math.Cos(rad * i) * r + x0);
                xy[i].y = (int)(Math.Sin(rad * i) * r + y0);
    
                for (int j = 0; j < i; j++)
                {
                    if (minSpannedTreeModel[i, j] != 0)
                    {
                        e.Graphics.DrawLine(linePen, xy[i].x + 10, xy[i].y + 10, xy[j].x + 10, xy[j].y + 10);
                        e.Graphics.DrawString(minSpannedTreeModel[i, j].ToString(), Font, numberPen.Brush,
                            (xy[i].x + 8 + xy[j].x + 8) / 2,
                            (xy[i].y + 8 + xy[j].y + 8) / 2
                            );
                    }
                }
            }
            for (int i = 0; i < srcMatrixModel.XSize; i++)
            {
                e.Graphics.FillEllipse(vertexPen.Brush, xy[i].x, xy[i].y, 25, 25);
                e.Graphics.DrawString((i + 1).ToString(), Font, whiteNumberPen.Brush, xy[i].x + 6, xy[i].y + 6);
            }
        }

        private void pbLeft_Paint(object sender, PaintEventArgs e)
        {
            double rad = (360 / srcMatrixModel.XSize * 3.14) / 180;
            Coord[] xy = new Coord[srcMatrixModel.XSize];
            float y0 = pbLeft.Height / 2;
            float x0 = pbLeft.Width / 2;
            double r = (x0 > y0 ? y0 : x0) - 20;

            Pen linePen = new Pen(Color.Green, 2);
            Pen numberPen = new Pen(Color.Black, 2);
            Pen whiteNumberPen = new Pen(Color.White, 3);
            Pen vertexPen = new Pen(Color.Red,1);
            for (int i = 0; i < srcMatrixModel.XSize; i++)
            {
                xy[i].x = (int)(Math.Cos(rad * i) * r + x0);
                xy[i].y = (int)(Math.Sin(rad * i) * r + y0);

                for (int j = 0; j < i; j++)
                {
                    if (srcMatrixModel[i, j] != 0)
                    {
                        e.Graphics.DrawLine(linePen, xy[i].x + 10, xy[i].y + 10, xy[j].x + 10, xy[j].y + 10);
                        e.Graphics.DrawString(srcMatrixModel[i, j].ToString(), Font, numberPen.Brush,
                            (xy[i].x + 8 + xy[j].x + 8) / 2,
                            (xy[i].y + 8 + xy[j].y + 8) / 2
                            );         
                    }
                }
            }
            for (int i = 0; i < srcMatrixModel.XSize; i++)
            {
                e.Graphics.FillEllipse(vertexPen.Brush, xy[i].x, xy[i].y, 25, 25);
                e.Graphics.DrawString((i + 1).ToString(), Font, whiteNumberPen.Brush, xy[i].x+6, xy[i].y+6);
            }
        }

        private void matrixViewCellValueChanged(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                srcMatrixView.Rows[e.ColumnIndex].Cells[e.RowIndex].Value = srcMatrixView.Rows[e.RowIndex].Cells[e.ColumnIndex].Value;
                srcMatrixModel[e.RowIndex, e.ColumnIndex] = srcMatrixModel[e.ColumnIndex, e.RowIndex] = double.Parse(srcMatrixView.Rows[e.RowIndex].Cells[e.ColumnIndex].Value.ToString());
            }
            catch (Exception)
            {
                srcMatrixView.Rows[e.ColumnIndex].Cells[e.RowIndex].Value = srcMatrixView.Rows[e.RowIndex].Cells[e.ColumnIndex].Value = 0;
                srcMatrixModel[e.RowIndex, e.ColumnIndex] = srcMatrixModel[e.ColumnIndex, e.RowIndex] = 0;
            }
            UpdateGraphInfo();
            pbLeft.Refresh();
        }

        #endregion


        #region Initters for DataGridViews

        private DataGridView InitSrcMatrixView(Matrix2d m, DataGridView view)
        {
            view.ColumnCount = m.XSize;
            view.RowCount = m.YSize;
            view.RowHeadersVisible = view.ColumnHeadersVisible = false;
            view.Dock = DockStyle.Fill;
            view.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            view.AllowUserToResizeColumns = view.AllowUserToResizeRows = false;

            for (int i = 0; i < m.XSize; i++)
            {
                for (int j = 0; j < m.YSize; j++)
                {
                    view.Rows[i].Cells[j].Value = m[i, j].ToString();
                    view.Rows[i].Cells[j].ReadOnly = true;
                    if (j > i)
                    {
                        view.Rows[i].Cells[j].ReadOnly = false;
                        view.Rows[i].Cells[j].Style.BackColor = Color.LightGreen;
                    }
                }
            } 
            
            splitLeftPanel.Panel2.Controls.Add(view);
            pbLeft.Paint += new PaintEventHandler(pbLeft_Paint);
            UpdateGraphInfo();
            pbLeft.Refresh();
            saveToolStripMenuItem.Enabled = true;
            makeMinSpannedTreeToolStripMenuItem.Enabled = true;
            return view;
        }

        private DataGridView InitSpannedTreeView(Matrix2d m, DataGridView view)
        {
            view.ColumnCount = m.XSize;
            view.RowCount = m.YSize;
            view.RowHeadersVisible = view.ColumnHeadersVisible = false;
            view.Dock = DockStyle.Fill;
            view.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            view.ReadOnly = true;
            view.AllowUserToResizeColumns = view.AllowUserToResizeRows = false;

            for (int i = 0; i < m.XSize; i++)
            {
                for (int j = 0; j < m.YSize; j++)
                {
                    view.Rows[i].Cells[j].Value = m[i, j].ToString();
                }
            }
            splitRightPanel.Panel2.Controls.Add(view);
            pbRight.Paint += new PaintEventHandler(pbRight_Paint);
            pbRight.Refresh();
            return view;
        }

        #endregion

        #region Main menu evetns

        private void openToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (openMatrixFile.ShowDialog() == DialogResult.OK)
            {
                srcMatrixModel = new SquareMatrix2d(openMatrixFile.FileName);
                srcMatrixView = InitSrcMatrixView(srcMatrixModel, srcMatrixView);
            }
        }

        private void makeMinSpannedTreeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            minSpannedTreeModel = MakeMinSpannedTree(srcMatrixView);
            spannedTreeView = InitSpannedTreeView(minSpannedTreeModel, spannedTreeView);
        }

        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MainForm.ActiveForm.Close();
        }

        private void newToolStripMenuItem_Click(object sender, EventArgs e)
        {
            NewGraphCreateDialog creator = new NewGraphCreateDialog();
            creator.Owner = this;
            creator.ShowDialog();
            if (IntData.Value >= 2)
            {
                srcMatrixModel = new SquareMatrix2d(IntData.Value, 0);
                srcMatrixView = InitSrcMatrixView(srcMatrixModel, srcMatrixView);
            }
            this.Refresh();
        }

        /// save src matrix to file
        private void saveToolStripMenuItem_Click(object sender, EventArgs e)
        {
            saveGraphDialog.ShowDialog();
            if (saveGraphDialog.FileName != "")
            {
                StreamWriter sw = new StreamWriter(saveGraphDialog.FileName);
                sw.WriteLine(srcMatrixModel.XSize);
                sw.WriteLine(srcMatrixModel.XSize);
                for (int i = 0; i < srcMatrixModel.XSize; i++)
                {
                    for (int j = 0; j < srcMatrixModel.XSize; j++)
                    {
                        sw.Write(srcMatrixModel[i, j] + " ");
                    }
                    sw.WriteLine();
                }
                sw.Close();
            }
        }
        #endregion

        private SquareMatrix2d MakeMinSpannedTree(DataGridView matrixView)
        {
            matrixView = srcMatrixView;
            SquareMatrix2d m = new SquareMatrix2d(matrixView.ColumnCount, 0.0);
            SquareMatrix2d tree = new SquareMatrix2d(matrixView.ColumnCount, 0.0);
            for (int i = 0; i < m.XSize; i++)
            {
                for (int j = 0; j < m.YSize; j++)
                {
                    m[i, j] = Convert.ToDouble(matrixView.Rows[i].Cells[j].Value);
                }
            }

            tree = Algorithms.MakeMinSpannedTree(m);
            return tree;
        }

        private void UpdateGraphInfo()
        {
            SquareMatrix2d K = Algorithms.MakeKirchhoffMatrix(srcMatrixModel);
            double det = new SquareMatrix2d(K.Cofactor(0, 0)).Determinant();
            statusBar.Text = "this graph contains the " + det.ToString() + " spanned trees";
        }

    }
    static class IntData
    {
        public static int Value { get; set; }
    }
}
