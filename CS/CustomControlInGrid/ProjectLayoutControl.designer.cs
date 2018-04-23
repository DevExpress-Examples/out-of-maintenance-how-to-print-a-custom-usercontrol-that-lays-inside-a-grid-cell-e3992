namespace CustomControlInGrid
{
    partial class ProjectLayoutControl
    {
        /// <summary> 
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary> 
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.dateEdit_Begin = new DevExpress.XtraEditors.DateEdit();
            this.dateEdit_End = new DevExpress.XtraEditors.DateEdit();
            this.progressBarControl1 = new DevExpress.XtraEditors.ProgressBarControl();
            this.dateEdit_Now = new DevExpress.XtraEditors.DateEdit();
            this.labelControl1 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl2 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl3 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl4 = new DevExpress.XtraEditors.LabelControl();
            this.panelControl1 = new DevExpress.XtraEditors.PanelControl();
            ((System.ComponentModel.ISupportInitialize)(this.dateEdit_Begin.Properties.VistaTimeProperties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dateEdit_Begin.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dateEdit_End.Properties.VistaTimeProperties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dateEdit_End.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.progressBarControl1.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dateEdit_Now.Properties.VistaTimeProperties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dateEdit_Now.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.panelControl1)).BeginInit();
            this.panelControl1.SuspendLayout();
            this.SuspendLayout();
            // 
            // dateEdit_Begin
            // 
            this.dateEdit_Begin.Dock = System.Windows.Forms.DockStyle.Top;
            this.dateEdit_Begin.EditValue = null;
            this.dateEdit_Begin.Location = new System.Drawing.Point(69, 0);
            this.dateEdit_Begin.Name = "dateEdit_Begin";
            this.dateEdit_Begin.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.dateEdit_Begin.Properties.VistaTimeProperties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton()});
            this.dateEdit_Begin.Size = new System.Drawing.Size(303, 20);
            this.dateEdit_Begin.TabIndex = 0;
            this.dateEdit_Begin.EditValueChanged += new System.EventHandler(this.dateEdit_EditValueChanged);
            // 
            // dateEdit_End
            // 
            this.dateEdit_End.Dock = System.Windows.Forms.DockStyle.Top;
            this.dateEdit_End.EditValue = null;
            this.dateEdit_End.Location = new System.Drawing.Point(69, 40);
            this.dateEdit_End.Name = "dateEdit_End";
            this.dateEdit_End.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.dateEdit_End.Properties.VistaTimeProperties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton()});
            this.dateEdit_End.Size = new System.Drawing.Size(303, 20);
            this.dateEdit_End.TabIndex = 1;
            this.dateEdit_End.EditValueChanged += new System.EventHandler(this.dateEdit_EditValueChanged);
            // 
            // progressBarControl1
            // 
            this.progressBarControl1.Dock = System.Windows.Forms.DockStyle.Top;
            this.progressBarControl1.Location = new System.Drawing.Point(69, 60);
            this.progressBarControl1.Name = "progressBarControl1";
            this.progressBarControl1.Size = new System.Drawing.Size(303, 18);
            this.progressBarControl1.TabIndex = 2;
            // 
            // dateEdit_Now
            // 
            this.dateEdit_Now.Dock = System.Windows.Forms.DockStyle.Top;
            this.dateEdit_Now.EditValue = null;
            this.dateEdit_Now.Location = new System.Drawing.Point(69, 20);
            this.dateEdit_Now.Name = "dateEdit_Now";
            this.dateEdit_Now.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.dateEdit_Now.Properties.ReadOnly = true;
            this.dateEdit_Now.Properties.VistaTimeProperties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton()});
            this.dateEdit_Now.Size = new System.Drawing.Size(303, 20);
            this.dateEdit_Now.TabIndex = 3;
            this.dateEdit_Now.EditValueChanged += new System.EventHandler(this.dateEdit_EditValueChanged);
            // 
            // labelControl1
            // 
            this.labelControl1.Location = new System.Drawing.Point(3, 3);
            this.labelControl1.Name = "labelControl1";
            this.labelControl1.Size = new System.Drawing.Size(51, 13);
            this.labelControl1.TabIndex = 8;
            this.labelControl1.Text = "Begin Time";
            // 
            // labelControl2
            // 
            this.labelControl2.Location = new System.Drawing.Point(3, 22);
            this.labelControl2.Name = "labelControl2";
            this.labelControl2.Size = new System.Drawing.Size(46, 13);
            this.labelControl2.TabIndex = 9;
            this.labelControl2.Text = "Now Time";
            // 
            // labelControl3
            // 
            this.labelControl3.Location = new System.Drawing.Point(3, 41);
            this.labelControl3.Name = "labelControl3";
            this.labelControl3.Size = new System.Drawing.Size(43, 13);
            this.labelControl3.TabIndex = 10;
            this.labelControl3.Text = "End Time";
            // 
            // labelControl4
            // 
            this.labelControl4.Location = new System.Drawing.Point(3, 60);
            this.labelControl4.Name = "labelControl4";
            this.labelControl4.Size = new System.Drawing.Size(42, 13);
            this.labelControl4.TabIndex = 11;
            this.labelControl4.Text = "Progress";
            // 
            // panelControl1
            // 
            this.panelControl1.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.NoBorder;
            this.panelControl1.Controls.Add(this.labelControl1);
            this.panelControl1.Controls.Add(this.labelControl4);
            this.panelControl1.Controls.Add(this.labelControl2);
            this.panelControl1.Controls.Add(this.labelControl3);
            this.panelControl1.Dock = System.Windows.Forms.DockStyle.Left;
            this.panelControl1.Location = new System.Drawing.Point(0, 0);
            this.panelControl1.Name = "panelControl1";
            this.panelControl1.Size = new System.Drawing.Size(69, 80);
            this.panelControl1.TabIndex = 12;
            // 
            // ProjectLayoutControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.progressBarControl1);
            this.Controls.Add(this.dateEdit_End);
            this.Controls.Add(this.dateEdit_Now);
            this.Controls.Add(this.dateEdit_Begin);
            this.Controls.Add(this.panelControl1);
            this.MinimumSize = new System.Drawing.Size(0, 80);
            this.Name = "ProjectLayoutControl";
            this.Size = new System.Drawing.Size(372, 80);
            ((System.ComponentModel.ISupportInitialize)(this.dateEdit_Begin.Properties.VistaTimeProperties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dateEdit_Begin.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dateEdit_End.Properties.VistaTimeProperties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dateEdit_End.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.progressBarControl1.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dateEdit_Now.Properties.VistaTimeProperties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dateEdit_Now.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.panelControl1)).EndInit();
            this.panelControl1.ResumeLayout(false);
            this.panelControl1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraEditors.DateEdit dateEdit_Begin;
        private DevExpress.XtraEditors.DateEdit dateEdit_End;
        private DevExpress.XtraEditors.ProgressBarControl progressBarControl1;
        private DevExpress.XtraEditors.DateEdit dateEdit_Now;
        private DevExpress.XtraEditors.LabelControl labelControl1;
        private DevExpress.XtraEditors.LabelControl labelControl2;
        private DevExpress.XtraEditors.LabelControl labelControl3;
        private DevExpress.XtraEditors.LabelControl labelControl4;
        private DevExpress.XtraEditors.PanelControl panelControl1;
    }
}
