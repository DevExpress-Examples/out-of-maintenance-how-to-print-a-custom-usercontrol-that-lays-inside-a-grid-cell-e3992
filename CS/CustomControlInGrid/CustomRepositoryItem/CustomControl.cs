using System;
using System.Collections.Generic;
using System.Text;
using DevExpress.XtraEditors;
using DevExpress.XtraEditors.Controls;
using System.ComponentModel;
using DevExpress.Utils.Drawing;
using DevExpress.XtraEditors.ViewInfo;

namespace CustomControlInGrid
{
    class CustomControl : BaseEdit, IAutoHeightControl
    {
        #region IAutoHeightControl implement
        bool IAutoHeightControl.SupportsAutoHeight { get { return true; } }

        public event EventHandler eHeightChanged;
        event EventHandler IAutoHeightControl.HeightChanged
        {
            add { eHeightChanged += value; }
            remove { eHeightChanged -= value; }
        }
        protected void RaiseHeightChanged()
        {
            if (eHeightChanged != null)
                eHeightChanged(this, EventArgs.Empty);
        }

        int IAutoHeightControl.CalcHeight(GraphicsCache cache)
        {
            if (ViewInfo.IsReady)
            {
                IHeightAdaptable ih = ViewInfo as IHeightAdaptable;
                if (ih != null) return ih.CalcHeight(cache, Width);
            }
            return Height;

        }
        #endregion
        static CustomControl()
        {
            CustomRepositoryItem.Register();
        }
        public CustomControl()
            : base()
        {
            Properties.ControlTypeChanged += new EventHandler(Properties_ControlTypeChanged);
            UpdateControls();
            //this.Dock = System.Windows.Forms.DockStyle.Fill;
        }

        void Properties_ControlTypeChanged(object sender, EventArgs e)
        {
            UpdateControls();
        }
        void UpdateControls()
        {
            Controls.Clear();
            if (Properties.ControlType == null)
                return;
            Controls.Add(Properties.EditorControl);
            (Properties.EditorControl as IEditValue).EditValueChanged += new EventHandler(this.editor_EditValueChanged);
            (Properties.EditorControl as IEditValue).EditValue = EditValue;
        }

        void editor_EditValueChanged(object sender, EventArgs e)
        {

            EditValue = (Properties.EditorControl as IEditValue).EditValue;
            IsModified = true;
        }
        public override string EditorTypeName
        {
            get { return CustomRepositoryItem.EditorName; }
        }
        [DesignerSerializationVisibility(DesignerSerializationVisibility.Content)]
        public new CustomRepositoryItem Properties
        {
            get { return base.Properties as CustomRepositoryItem; }
        }
        protected override void OnPropertiesChanged()
        {
            base.OnPropertiesChanged();
            this.RaiseHeightChanged();
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
                (Properties.EditorControl as IEditValue).EditValue = EditValue;
            }
        }
    }

}
