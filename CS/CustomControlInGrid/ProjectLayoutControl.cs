using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Text;
using System.Windows.Forms;
using DevExpress.XtraEditors.Mask;
using DevExpress.XtraEditors;
using DevExpress.XtraEditors.Repository;
using DevExpress.XtraPrinting;

namespace CustomControlInGrid
{
    public partial class ProjectLayoutControl : UserControl, IEditValue, IExport
    {
        bool EditValueEventBlock = false;
        public ProjectLayoutControl()
        {
            InitializeComponent();
            dateEdit_Begin.DateTime = DateTime.Now;
            dateEdit_Now.DateTime = DateTime.Now;
            dateEdit_End.DateTime = DateTime.Now;

            dateEdit_Begin.Controls[0].VisibleChanged+=new EventHandler(ProjectLayoutControl_VisibleChanged);

        }
        void ProjectLayoutControl_VisibleChanged(object sender, EventArgs e)
        {
            bool v = (sender as MaskBox).Visible;
        }
        public object EditValue 
       {
           get { return (object)new ProjectTime(dateEdit_Begin.DateTime, dateEdit_End.DateTime); }
            set
            {
                if (value == null)
                {
                    dateEdit_Begin.EditValue = null;
                    dateEdit_End.EditValue = null;
                    dateEdit_Now.EditValue = null;
                    progressBarControl1.Position = 0;
                    this.Refresh();
                    return;

                }
                EditValueEventBlock = true;
                try
                {
                    dateEdit_Begin.DateTime = ((ProjectTime)value).Begin;
                    dateEdit_End.DateTime = ((ProjectTime)value).End;
                    dateEdit_Now.DateTime = DateTime.Now;
                    this.Refresh();
                }
                finally
                {
                    EditValueEventBlock = false;
                }
            }
        }

        public event EventHandler EditValueChanged;

        private void dateEdit_EditValueChanged(object sender, EventArgs e)
        {
            TimeSpan tsAll = dateEdit_End.DateTime - dateEdit_Begin.DateTime;
            TimeSpan tsNow = dateEdit_Now.DateTime - dateEdit_Begin.DateTime;
            if (tsAll.Days != 0)
                progressBarControl1.Position = tsNow.Days * 100 / tsAll.Days;
            else
                progressBarControl1.Position = 100;
            if ((EditValueChanged == null) || (EditValueEventBlock))
                return;
            EditValueChanged(this, EventArgs.Empty);
        }

        #region IExport Members

        private void ExportProgressBar(PrintCellHelperInfo info, PanelBrick brick) {
            Rectangle rect = progressBarControl1.Bounds;
            rect.Width = info.Rectangle.Right - rect.X - info.Rectangle.X;
            rect.Height = info.Rectangle.Bottom - rect.Y - info.Rectangle.Y;
            PrintCellHelperInfo inf = new PrintCellHelperInfo(info.LineColor, info.PS, progressBarControl1.Position, progressBarControl1.Properties.Appearance, progressBarControl1.Properties.DisplayFormat.GetDisplayText(progressBarControl1.Position), rect, info.Graph, DevExpress.Utils.HorzAlignment.Near, true, true, progressBarControl1.Properties.DisplayFormat.GetFormatString(), BorderSide.All);

            ProgressBarBrick pbb = (ProgressBarBrick)progressBarControl1.Properties.GetBrick(inf);
            pbb.Rect = rect;
            brick.Bricks.Add(pbb);
        }

        private void ExportDateEdit(PrintCellHelperInfo info, DateEdit editor, PanelBrick brick) {
            Rectangle rect = editor.Bounds;
            rect.Width = info.Rectangle.Right - rect.X - info.Rectangle.X;

            PrintCellHelperInfo inf = new PrintCellHelperInfo(info.LineColor, info.PS, editor.DateTime, editor.Properties.Appearance, editor.Properties.DisplayFormat.GetDisplayText(editor.EditValue), rect, info.Graph, DevExpress.Utils.HorzAlignment.Near, true, true, editor.Properties.DisplayFormat.GetFormatString(), BorderSide.All);

            TextBrick tb = (TextBrick)editor.Properties.GetBrick(inf);
            tb.Rect = rect;
            brick.Bricks.Add(tb);
        }

        private void ExportPanel(PrintCellHelperInfo info, PanelBrick brick) {
            ExportFirstLine(info, brick);
            ExportSecondLine(info, brick);
            ExportThirdLine(info, brick);
            ExportFourthLine(info, brick);
        }

        private void ExportFourthLine(PrintCellHelperInfo info, PanelBrick brick) {
            Rectangle rect = panelControl1.Bounds;
            rect.Y += progressBarControl1.Bounds.Y;
            rect.Height = info.Rectangle.Bottom - rect.Y - info.Rectangle.Y;
            ExportText(info, rect, "Progress",brick);
        }

        private void ExportThirdLine(PrintCellHelperInfo info, PanelBrick brick) {
            Rectangle rect = panelControl1.Bounds;
            rect.Y += dateEdit_End.Bounds.Y;
            rect.Height = dateEdit_End.Bounds.Height;
            ExportText(info, rect, "End Time", brick);
        }

        private void ExportSecondLine(PrintCellHelperInfo info, PanelBrick brick) {
            Rectangle rect = panelControl1.Bounds;
            rect.Y += dateEdit_Now.Bounds.Y;
            rect.Height = dateEdit_Now.Bounds.Height;
            ExportText(info, rect, "Now Time", brick);
        }

        private void ExportFirstLine(PrintCellHelperInfo info, PanelBrick brick) {
            Rectangle rect = panelControl1.Bounds;
            rect.Height = dateEdit_Begin.Bounds.Height;
            ExportText(info, rect, "Begin Time", brick);
        }

        private static void ExportText(PrintCellHelperInfo info, Rectangle rect, string text, PanelBrick brick) {
            PrintCellHelperInfo inf = new PrintCellHelperInfo(info.LineColor, info.PS, text, info.Appearace, text, rect, info.Graph, DevExpress.Utils.HorzAlignment.Near, true, true, info.TextValueFormatString, BorderSide.All);
            using (RepositoryItemTextEdit repTE = new RepositoryItemTextEdit()) {
                TextBrick tb = (TextBrick)repTE.GetBrick(inf);
                tb.Rect = rect;
                brick.Bricks.Add(tb);
            }
        }

        public IVisualBrick GetBrick(PrintCellHelperInfo info) {
            this.EditValue = info.EditValue;
            PanelBrick brick = new PanelBrick();
            brick.BackColor = Color.White;

            ExportProgressBar(info, brick);
            ExportDateEdit(info, dateEdit_Begin, brick);
            ExportDateEdit(info, dateEdit_End, brick);
            ExportDateEdit(info, dateEdit_Now, brick);
            ExportPanel(info, brick);
            return brick;
        }

        #endregion
    }

    class ProjectTime
    {
        public ProjectTime(DateTime Begin, DateTime End)
        {
            this.Begin = Begin;
            this.End = End;
        }
        public DateTime _begin;
        public DateTime _end;

        public DateTime Begin { get { return _begin; } set { _begin = value; } }
        public DateTime End { get { return _end; } set { _end = value; } }
    }

}

