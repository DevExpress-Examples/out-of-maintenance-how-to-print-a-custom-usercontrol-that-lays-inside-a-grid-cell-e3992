using System;
using System.Collections.Generic;
using System.Text;
using DevExpress.XtraEditors.ViewInfo;
using DevExpress.XtraEditors.Repository;
using DevExpress.Utils.Drawing;

namespace CustomControlInGrid
{
    class CustomControlViewInfo : BaseEditViewInfo, IHeightAdaptable
    {
        CustomControlViewInfo(RepositoryItem Item) : base(Item) { }
        int IHeightAdaptable.CalcHeight(GraphicsCache cache, int width)
        {
            CustomRepositoryItem cri = Item as CustomRepositoryItem;
            if (cri.ControlType == null)
                return this.CalcMinHeight(cache.Graphics);
            return cri.DrawControl.Height;
        }
        public override object EditValue
        {
            get
            {
                return base.EditValue;
            }
            set
            {
                base.EditValue = value;
            }
        }
        public override string DisplayText
        {
            get
            {
                return base.DisplayText;
            }
        }
    }

}
