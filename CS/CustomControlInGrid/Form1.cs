using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

using DevExpress.XtraEditors;
using DevExpress.XtraEditors.Controls;
using DevExpress.XtraEditors.Drawing;
using DevExpress.XtraEditors.Registrator;
using DevExpress.XtraEditors.Repository;
using DevExpress.XtraEditors.ViewInfo;
using DevExpress.Utils.Drawing;
using DevExpress.XtraBars;

namespace CustomControlInGrid
{
    public partial class Form1 : Form
    {

        CustomControl cc = new CustomControl();
        DataTable dt = new DataTable();
        public Form1()
        {
            InitializeComponent();
            dt.Columns.Add("Date", typeof(ProjectTime));
            for (int i = 0; i < 5; i++)
            {
                dt.Rows.Add(new ProjectTime(DateTime.Now.AddDays(-i), DateTime.Now.AddDays(5-i)));
            }

            customRepositoryItem1.ControlType = typeof(ProjectLayoutControl);

            cc.Properties.ControlType = typeof(ProjectLayoutControl);
            cc.Dock = DockStyle.Fill;
            cc.Location = new Point(5,25);
            cc.Properties.AutoHeight = false;

            groupControl2.Controls.Add(cc);
            cc.EditValueChanged +=new EventHandler(cc_EditValueChanged);
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            BindingSource bs = new BindingSource();
            bs.DataSource = dt;
            gridControl1.DataSource = bs;
            projectLayoutControl1.EditValue = new ProjectTime(DateTime.Now.AddDays(-1), DateTime.Now.AddDays(1));
            cc.EditValue = new ProjectTime(DateTime.Now.AddDays(-1), DateTime.Now.AddDays(1));
        }
        void cc_EditValueChanged(object sender, EventArgs e)
        {
            groupControl3.Refresh();
        }
        private void groupControl3_Paint(object sender, PaintEventArgs e)
        {
            Bitmap bm = new Bitmap(cc.Width, cc.Height);
            cc.DrawToBitmap(bm, cc.Bounds);
            BaseEditPainter pb = cc.Properties.CreatePainter();
            BaseEditViewInfo bevi = cc.Properties.CreateViewInfo();
            bevi.CalcViewInfo(e.Graphics, MouseButtons.Left, new Point(0, 0), cc.Bounds);
            GraphicsCache gc = new GraphicsCache(e.Graphics);
            try
            {
                pb.Draw(new ControlGraphicsInfoArgs(bevi, gc, cc.Bounds));
            }
            catch { }
        }

        private void radioGroup1_SelectedIndexChanged(object sender, EventArgs e)
        {
                    gridControl1.MainView = gridControl1.ViewCollection[radioGroup1.SelectedIndex];
        }

        private void simpleButton1_Click(object sender, EventArgs e) {
            gridControl1.ShowPrintPreview();
        }

        private void gridView1_BeforePrintRow(object sender, DevExpress.XtraGrid.Views.Printing.CancelPrintRowEventArgs e) {

        }
    }
}
