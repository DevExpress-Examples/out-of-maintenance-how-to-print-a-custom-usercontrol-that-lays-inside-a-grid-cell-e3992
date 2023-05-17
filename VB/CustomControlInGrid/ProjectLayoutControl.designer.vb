Namespace CustomControlInGrid

    Partial Class ProjectLayoutControl

        ''' <summary> 
        ''' Required designer variable.
        ''' </summary>
        Private components As System.ComponentModel.IContainer = Nothing

        ''' <summary> 
        ''' Clean up any resources being used.
        ''' </summary>
        ''' <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        Protected Overrides Sub Dispose(ByVal disposing As Boolean)
            If disposing AndAlso (Me.components IsNot Nothing) Then
                Me.components.Dispose()
            End If

            MyBase.Dispose(disposing)
        End Sub

'#Region "Component Designer generated code"
        ''' <summary> 
        ''' Required method for Designer support - do not modify 
        ''' the contents of this method with the code editor.
        ''' </summary>
        Private Sub InitializeComponent()
            Me.dateEdit_Begin = New DevExpress.XtraEditors.DateEdit()
            Me.dateEdit_End = New DevExpress.XtraEditors.DateEdit()
            Me.progressBarControl1 = New DevExpress.XtraEditors.ProgressBarControl()
            Me.dateEdit_Now = New DevExpress.XtraEditors.DateEdit()
            Me.labelControl1 = New DevExpress.XtraEditors.LabelControl()
            Me.labelControl2 = New DevExpress.XtraEditors.LabelControl()
            Me.labelControl3 = New DevExpress.XtraEditors.LabelControl()
            Me.labelControl4 = New DevExpress.XtraEditors.LabelControl()
            Me.panelControl1 = New DevExpress.XtraEditors.PanelControl()
            CType((Me.dateEdit_Begin.Properties.VistaTimeProperties), System.ComponentModel.ISupportInitialize).BeginInit()
            CType((Me.dateEdit_Begin.Properties), System.ComponentModel.ISupportInitialize).BeginInit()
            CType((Me.dateEdit_End.Properties.VistaTimeProperties), System.ComponentModel.ISupportInitialize).BeginInit()
            CType((Me.dateEdit_End.Properties), System.ComponentModel.ISupportInitialize).BeginInit()
            CType((Me.progressBarControl1.Properties), System.ComponentModel.ISupportInitialize).BeginInit()
            CType((Me.dateEdit_Now.Properties.VistaTimeProperties), System.ComponentModel.ISupportInitialize).BeginInit()
            CType((Me.dateEdit_Now.Properties), System.ComponentModel.ISupportInitialize).BeginInit()
            CType((Me.panelControl1), System.ComponentModel.ISupportInitialize).BeginInit()
            Me.panelControl1.SuspendLayout()
            Me.SuspendLayout()
            ' 
            ' dateEdit_Begin
            ' 
            Me.dateEdit_Begin.Dock = System.Windows.Forms.DockStyle.Top
            Me.dateEdit_Begin.EditValue = Nothing
            Me.dateEdit_Begin.Location = New System.Drawing.Point(69, 0)
            Me.dateEdit_Begin.Name = "dateEdit_Begin"
            Me.dateEdit_Begin.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
            Me.dateEdit_Begin.Properties.VistaTimeProperties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton()})
            Me.dateEdit_Begin.Size = New System.Drawing.Size(303, 20)
            Me.dateEdit_Begin.TabIndex = 0
            AddHandler Me.dateEdit_Begin.EditValueChanged, New System.EventHandler(AddressOf Me.dateEdit_EditValueChanged)
            ' 
            ' dateEdit_End
            ' 
            Me.dateEdit_End.Dock = System.Windows.Forms.DockStyle.Top
            Me.dateEdit_End.EditValue = Nothing
            Me.dateEdit_End.Location = New System.Drawing.Point(69, 40)
            Me.dateEdit_End.Name = "dateEdit_End"
            Me.dateEdit_End.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
            Me.dateEdit_End.Properties.VistaTimeProperties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton()})
            Me.dateEdit_End.Size = New System.Drawing.Size(303, 20)
            Me.dateEdit_End.TabIndex = 1
            AddHandler Me.dateEdit_End.EditValueChanged, New System.EventHandler(AddressOf Me.dateEdit_EditValueChanged)
            ' 
            ' progressBarControl1
            ' 
            Me.progressBarControl1.Dock = System.Windows.Forms.DockStyle.Top
            Me.progressBarControl1.Location = New System.Drawing.Point(69, 60)
            Me.progressBarControl1.Name = "progressBarControl1"
            Me.progressBarControl1.Size = New System.Drawing.Size(303, 18)
            Me.progressBarControl1.TabIndex = 2
            ' 
            ' dateEdit_Now
            ' 
            Me.dateEdit_Now.Dock = System.Windows.Forms.DockStyle.Top
            Me.dateEdit_Now.EditValue = Nothing
            Me.dateEdit_Now.Location = New System.Drawing.Point(69, 20)
            Me.dateEdit_Now.Name = "dateEdit_Now"
            Me.dateEdit_Now.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
            Me.dateEdit_Now.Properties.[ReadOnly] = True
            Me.dateEdit_Now.Properties.VistaTimeProperties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton()})
            Me.dateEdit_Now.Size = New System.Drawing.Size(303, 20)
            Me.dateEdit_Now.TabIndex = 3
            AddHandler Me.dateEdit_Now.EditValueChanged, New System.EventHandler(AddressOf Me.dateEdit_EditValueChanged)
            ' 
            ' labelControl1
            ' 
            Me.labelControl1.Location = New System.Drawing.Point(3, 3)
            Me.labelControl1.Name = "labelControl1"
            Me.labelControl1.Size = New System.Drawing.Size(51, 13)
            Me.labelControl1.TabIndex = 8
            Me.labelControl1.Text = "Begin Time"
            ' 
            ' labelControl2
            ' 
            Me.labelControl2.Location = New System.Drawing.Point(3, 22)
            Me.labelControl2.Name = "labelControl2"
            Me.labelControl2.Size = New System.Drawing.Size(46, 13)
            Me.labelControl2.TabIndex = 9
            Me.labelControl2.Text = "Now Time"
            ' 
            ' labelControl3
            ' 
            Me.labelControl3.Location = New System.Drawing.Point(3, 41)
            Me.labelControl3.Name = "labelControl3"
            Me.labelControl3.Size = New System.Drawing.Size(43, 13)
            Me.labelControl3.TabIndex = 10
            Me.labelControl3.Text = "End Time"
            ' 
            ' labelControl4
            ' 
            Me.labelControl4.Location = New System.Drawing.Point(3, 60)
            Me.labelControl4.Name = "labelControl4"
            Me.labelControl4.Size = New System.Drawing.Size(42, 13)
            Me.labelControl4.TabIndex = 11
            Me.labelControl4.Text = "Progress"
            ' 
            ' panelControl1
            ' 
            Me.panelControl1.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.NoBorder
            Me.panelControl1.Controls.Add(Me.labelControl1)
            Me.panelControl1.Controls.Add(Me.labelControl4)
            Me.panelControl1.Controls.Add(Me.labelControl2)
            Me.panelControl1.Controls.Add(Me.labelControl3)
            Me.panelControl1.Dock = System.Windows.Forms.DockStyle.Left
            Me.panelControl1.Location = New System.Drawing.Point(0, 0)
            Me.panelControl1.Name = "panelControl1"
            Me.panelControl1.Size = New System.Drawing.Size(69, 80)
            Me.panelControl1.TabIndex = 12
            ' 
            ' ProjectLayoutControl
            ' 
            Me.AutoScaleDimensions = New System.Drawing.SizeF(6F, 13F)
            Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
            Me.Controls.Add(Me.progressBarControl1)
            Me.Controls.Add(Me.dateEdit_End)
            Me.Controls.Add(Me.dateEdit_Now)
            Me.Controls.Add(Me.dateEdit_Begin)
            Me.Controls.Add(Me.panelControl1)
            Me.MinimumSize = New System.Drawing.Size(0, 80)
            Me.Name = "ProjectLayoutControl"
            Me.Size = New System.Drawing.Size(372, 80)
            CType((Me.dateEdit_Begin.Properties.VistaTimeProperties), System.ComponentModel.ISupportInitialize).EndInit()
            CType((Me.dateEdit_Begin.Properties), System.ComponentModel.ISupportInitialize).EndInit()
            CType((Me.dateEdit_End.Properties.VistaTimeProperties), System.ComponentModel.ISupportInitialize).EndInit()
            CType((Me.dateEdit_End.Properties), System.ComponentModel.ISupportInitialize).EndInit()
            CType((Me.progressBarControl1.Properties), System.ComponentModel.ISupportInitialize).EndInit()
            CType((Me.dateEdit_Now.Properties.VistaTimeProperties), System.ComponentModel.ISupportInitialize).EndInit()
            CType((Me.dateEdit_Now.Properties), System.ComponentModel.ISupportInitialize).EndInit()
            CType((Me.panelControl1), System.ComponentModel.ISupportInitialize).EndInit()
            Me.panelControl1.ResumeLayout(False)
            Me.panelControl1.PerformLayout()
            Me.ResumeLayout(False)
        End Sub

'#End Region
        Private dateEdit_Begin As DevExpress.XtraEditors.DateEdit

        Private dateEdit_End As DevExpress.XtraEditors.DateEdit

        Private progressBarControl1 As DevExpress.XtraEditors.ProgressBarControl

        Private dateEdit_Now As DevExpress.XtraEditors.DateEdit

        Private labelControl1 As DevExpress.XtraEditors.LabelControl

        Private labelControl2 As DevExpress.XtraEditors.LabelControl

        Private labelControl3 As DevExpress.XtraEditors.LabelControl

        Private labelControl4 As DevExpress.XtraEditors.LabelControl

        Private panelControl1 As DevExpress.XtraEditors.PanelControl
    End Class
End Namespace
