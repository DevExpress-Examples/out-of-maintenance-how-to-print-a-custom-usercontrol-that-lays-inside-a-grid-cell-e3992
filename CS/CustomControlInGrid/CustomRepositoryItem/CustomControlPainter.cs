using System;
using System.Collections.Generic;
using System.Text;
using DevExpress.XtraEditors.Drawing;
using DevExpress.XtraEditors;
using System.Windows.Forms;
using DevExpress.XtraEditors.Repository;
using DevExpress.XtraEditors.ViewInfo;
using System.Drawing;

namespace CustomControlInGrid
{
    class CustomControlPainter : BaseEditPainter
    {
        public CustomControlPainter() : base() { }
        public override void Draw(ControlGraphicsInfoArgs info)
        {
            base.Draw(info);

            CustomControlViewInfo vi = info.ViewInfo as CustomControlViewInfo;
            CustomRepositoryItem cri = vi.Item as CustomRepositoryItem;
            if (cri.ControlType == null)
                return;
            (cri.DrawControl as IEditValue).EditValue = vi.EditValue;
            cri.DrawControl.Bounds = info.Bounds;
            Bitmap bm = new Bitmap(info.Bounds.Width, info.Bounds.Height);
			cri.DrawControl.DrawToBitmap(bm, new Rectangle(0, 0, bm.Width, bm.Height));
            info.Graphics.DrawImage(bm, info.Bounds.Location);

            List<BaseEdit> editors = new List<BaseEdit>();
            editors = EditorFinder.FindEditors(cri.DrawControl);
            DrawEditors(editors, info, cri);
        }
        void DrawEditors(List<BaseEdit> editors, ControlGraphicsInfoArgs info, CustomRepositoryItem cri)
        {
            foreach (BaseEdit editor in editors)
            {
                RepositoryItem ri = cri.ControlRepositories[editor.EditorTypeName];
                ri.Assign(editor.Properties);
                BaseEditViewInfo bevi = ri.CreateViewInfo();
                bevi.EditValue = editor.EditValue;
                Rectangle rec = editor.Bounds;

                rec.X += info.ViewInfo.Bounds.X;
                rec.Y += info.ViewInfo.Bounds.Y;

                bevi.CalcViewInfo(info.Graphics, MouseButtons.Left, new Point(0, 0), rec);
                ControlGraphicsInfoArgs cinfo = new ControlGraphicsInfoArgs(bevi, info.Cache, info.ViewInfo.Bounds);
                BaseEditPainter bp = ri.CreatePainter();
                try
                {
                    bp.Draw(cinfo);
                }
                catch { }
            }
        }
    }

}
