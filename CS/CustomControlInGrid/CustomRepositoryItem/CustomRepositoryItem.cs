using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Reflection;
using System.Text;
using System.Windows.Forms;

using DevExpress.XtraEditors;
using DevExpress.XtraEditors.Controls;
using DevExpress.XtraEditors.Drawing;
using DevExpress.XtraEditors.Registrator;
using DevExpress.XtraEditors.Repository;
using DevExpress.XtraEditors.ViewInfo;
using DevExpress.Utils.Drawing;
using DevExpress.XtraEditors.Mask;
using DevExpress.XtraPrinting;

namespace CustomControlInGrid {
    [UserRepositoryItem("Register")]
    internal class CustomRepositoryItem : RepositoryItem {
        public event EventHandler ControlTypeChanged;
        private UserControl _drawControl;
        internal UserControl DrawControl {
            get {
                return _drawControl;
            }
        }
        private UserControl _editorControl;
        internal UserControl EditorControl {
            get {
                return _editorControl;
            }
        }
        internal Dictionary<string, RepositoryItem> ControlRepositories;

        private Type _controlType;
        public Type ControlType {
            get {
                return _controlType;
            }
            set {
                if (_controlType == value) {
                    return;
                }
                _controlType = value;
                ConstructorInfo cConstructor = ControlType.GetConstructor(BindingFlags.Instance | BindingFlags.Public | BindingFlags.CreateInstance | BindingFlags.NonPublic, null, new Type[] { }, null);
                _drawControl = cConstructor.Invoke(null) as UserControl;
                _editorControl = cConstructor.Invoke(null) as UserControl;
                _editorControl.Dock = DockStyle.Fill;
                UpdateControlRepositoreies();
                OnControlTypeChanged();
                OnPropertiesChanged();
            }
        }
        private void OnControlTypeChanged() {
            if (ControlTypeChanged != null) {
                ControlTypeChanged(this, EventArgs.Empty);
            }
        }
        private void UpdateControlRepositoreies() {
            ControlRepositories = new Dictionary<string, RepositoryItem>();
            List<BaseEdit> editorList = EditorFinder.FindEditors(_drawControl);
            foreach (Control control in editorList) {
                BaseEdit editor = control as BaseEdit;
                if ( editor == null ) {
                    continue;
                }
                ConstructorInfo cConstructor = editor.Properties.GetType().GetConstructor(BindingFlags.Instance | BindingFlags.Public | BindingFlags.CreateInstance | BindingFlags.NonPublic, null, new Type[] { }, null);
                RepositoryItem ri = cConstructor.Invoke(null) as RepositoryItem;
                if (!ControlRepositories.ContainsKey(ri.EditorTypeName)) {
                    ControlRepositories.Add(ri.EditorTypeName, ri);
                }
            }
        }

        static CustomRepositoryItem() {
            Register();
        }
        public CustomRepositoryItem()
            : base() {
        }
        internal const string EditorName = "Custom Control";

        public static void Register() {
            EditorRegistrationInfo.Default.Editors.Add(new EditorClassInfo(EditorName, typeof(CustomControl),
            typeof(CustomRepositoryItem), typeof(CustomControlViewInfo),
            new CustomControlPainter(), true));
        }
        public override string EditorTypeName {
            get {
                return EditorName;
            }
        }
        public override void Assign(RepositoryItem item) {
            base.Assign(item);
            ControlType = (item as CustomRepositoryItem).ControlType;
        }

        public override IVisualBrick GetBrick(PrintCellHelperInfo info) {
            IVisualBrick brick = base.GetBrick(info);
            info.Graph.DrawBrick(brick, info.Rectangle);
            return (DrawControl as IExport).GetBrick(info);
        }
    }
}
