Namespace CustomControlInGrid

    Partial Class Form1

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

'#Region "Windows Form Designer generated code"
        ''' <summary>
        ''' Required method for Designer support - do not modify
        ''' the contents of this method with the code editor.
        ''' </summary>
        Private Sub InitializeComponent()
            Me.projectLayoutControl1 = New CustomControlInGrid.ProjectLayoutControl()
            Me.gridControl1 = New DevExpress.XtraGrid.GridControl()
            Me.gridView1 = New DevExpress.XtraGrid.Views.Grid.GridView()
            Me.EmptyColumn = New DevExpress.XtraGrid.Columns.GridColumn()
            Me.customRepositoryItem1 = New CustomControlInGrid.CustomRepositoryItem()
            Me.DateColumn = New DevExpress.XtraGrid.Columns.GridColumn()
            Me.DateColumnCopy = New DevExpress.XtraGrid.Columns.GridColumn()
            Me.cardView1 = New DevExpress.XtraGrid.Views.Card.CardView()
            Me.gridColumn1 = New DevExpress.XtraGrid.Columns.GridColumn()
            Me.gridColumn2 = New DevExpress.XtraGrid.Columns.GridColumn()
            Me.gridColumn3 = New DevExpress.XtraGrid.Columns.GridColumn()
            Me.bandedGridView1 = New DevExpress.XtraGrid.Views.BandedGrid.BandedGridView()
            Me.gridBand1 = New DevExpress.XtraGrid.Views.BandedGrid.GridBand()
            Me.bandedGridColumn1 = New DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn()
            Me.bandedGridColumn2 = New DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn()
            Me.bandedGridColumn3 = New DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn()
            Me.layoutView1 = New DevExpress.XtraGrid.Views.Layout.LayoutView()
            Me.layoutViewColumn1 = New DevExpress.XtraGrid.Columns.LayoutViewColumn()
            Me.layoutViewField_layoutViewColumn1 = New DevExpress.XtraGrid.Views.Layout.LayoutViewField()
            Me.layoutViewColumn2 = New DevExpress.XtraGrid.Columns.LayoutViewColumn()
            Me.layoutViewField_layoutViewColumn2 = New DevExpress.XtraGrid.Views.Layout.LayoutViewField()
            Me.layoutViewColumn3 = New DevExpress.XtraGrid.Columns.LayoutViewColumn()
            Me.layoutViewField_layoutViewColumn3 = New DevExpress.XtraGrid.Views.Layout.LayoutViewField()
            Me.layoutViewCard1 = New DevExpress.XtraGrid.Views.Layout.LayoutViewCard()
            Me.groupControl1 = New DevExpress.XtraEditors.GroupControl()
            Me.groupControl2 = New DevExpress.XtraEditors.GroupControl()
            Me.groupControl3 = New DevExpress.XtraEditors.GroupControl()
            Me.panelControl1 = New DevExpress.XtraEditors.PanelControl()
            Me.simpleButton1 = New DevExpress.XtraEditors.SimpleButton()
            Me.groupControl4 = New DevExpress.XtraEditors.GroupControl()
            Me.radioGroup1 = New DevExpress.XtraEditors.RadioGroup()
            CType((Me.gridControl1), System.ComponentModel.ISupportInitialize).BeginInit()
            CType((Me.gridView1), System.ComponentModel.ISupportInitialize).BeginInit()
            CType((Me.customRepositoryItem1), System.ComponentModel.ISupportInitialize).BeginInit()
            CType((Me.cardView1), System.ComponentModel.ISupportInitialize).BeginInit()
            CType((Me.bandedGridView1), System.ComponentModel.ISupportInitialize).BeginInit()
            CType((Me.layoutView1), System.ComponentModel.ISupportInitialize).BeginInit()
            CType((Me.layoutViewField_layoutViewColumn1), System.ComponentModel.ISupportInitialize).BeginInit()
            CType((Me.layoutViewField_layoutViewColumn2), System.ComponentModel.ISupportInitialize).BeginInit()
            CType((Me.layoutViewField_layoutViewColumn3), System.ComponentModel.ISupportInitialize).BeginInit()
            CType((Me.layoutViewCard1), System.ComponentModel.ISupportInitialize).BeginInit()
            CType((Me.groupControl1), System.ComponentModel.ISupportInitialize).BeginInit()
            Me.groupControl1.SuspendLayout()
            CType((Me.groupControl2), System.ComponentModel.ISupportInitialize).BeginInit()
            CType((Me.groupControl3), System.ComponentModel.ISupportInitialize).BeginInit()
            CType((Me.panelControl1), System.ComponentModel.ISupportInitialize).BeginInit()
            Me.panelControl1.SuspendLayout()
            CType((Me.groupControl4), System.ComponentModel.ISupportInitialize).BeginInit()
            Me.groupControl4.SuspendLayout()
            CType((Me.radioGroup1.Properties), System.ComponentModel.ISupportInitialize).BeginInit()
            Me.SuspendLayout()
            ' 
            ' projectLayoutControl1
            ' 
            Me.projectLayoutControl1.Dock = System.Windows.Forms.DockStyle.Fill
            Me.projectLayoutControl1.Location = New System.Drawing.Point(2, 21)
            Me.projectLayoutControl1.MinimumSize = New System.Drawing.Size(0, 80)
            Me.projectLayoutControl1.Name = "projectLayoutControl1"
            Me.projectLayoutControl1.Size = New System.Drawing.Size(196, 81)
            Me.projectLayoutControl1.TabIndex = 5
            ' 
            ' gridControl1
            ' 
            Me.gridControl1.Dock = System.Windows.Forms.DockStyle.Fill
            Me.gridControl1.Location = New System.Drawing.Point(0, 108)
            Me.gridControl1.MainView = Me.gridView1
            Me.gridControl1.Name = "gridControl1"
            Me.gridControl1.RepositoryItems.AddRange(New DevExpress.XtraEditors.Repository.RepositoryItem() {Me.customRepositoryItem1})
            Me.gridControl1.Size = New System.Drawing.Size(1105, 482)
            Me.gridControl1.TabIndex = 6
            Me.gridControl1.ViewCollection.AddRange(New DevExpress.XtraGrid.Views.Base.BaseView() {Me.gridView1, Me.cardView1, Me.bandedGridView1, Me.layoutView1})
            ' 
            ' gridView1
            ' 
            Me.gridView1.Columns.AddRange(New DevExpress.XtraGrid.Columns.GridColumn() {Me.EmptyColumn, Me.DateColumn, Me.DateColumnCopy})
            Me.gridView1.GridControl = Me.gridControl1
            Me.gridView1.Name = "gridView1"
            Me.gridView1.OptionsView.RowAutoHeight = True
            AddHandler Me.gridView1.BeforePrintRow, New DevExpress.XtraGrid.Views.Base.BeforePrintRowEventHandler(AddressOf Me.gridView1_BeforePrintRow)
            ' 
            ' EmptyColumn
            ' 
            Me.EmptyColumn.Caption = "EmptyColumn"
            Me.EmptyColumn.ColumnEdit = Me.customRepositoryItem1
            Me.EmptyColumn.Name = "EmptyColumn"
            Me.EmptyColumn.Visible = True
            Me.EmptyColumn.VisibleIndex = 2
            ' 
            ' customRepositoryItem1
            ' 
            Me.customRepositoryItem1.AutoHeight = False
            Me.customRepositoryItem1.Name = "customRepositoryItem1"
            ' 
            ' DateColumn
            ' 
            Me.DateColumn.Caption = "DateColumn"
            Me.DateColumn.ColumnEdit = Me.customRepositoryItem1
            Me.DateColumn.FieldName = "Date"
            Me.DateColumn.Name = "DateColumn"
            Me.DateColumn.Visible = True
            Me.DateColumn.VisibleIndex = 0
            ' 
            ' DateColumnCopy
            ' 
            Me.DateColumnCopy.Caption = "DateColumnCopy"
            Me.DateColumnCopy.ColumnEdit = Me.customRepositoryItem1
            Me.DateColumnCopy.FieldName = "Date"
            Me.DateColumnCopy.Name = "DateColumnCopy"
            Me.DateColumnCopy.Visible = True
            Me.DateColumnCopy.VisibleIndex = 1
            ' 
            ' cardView1
            ' 
            Me.cardView1.CardWidth = 400
            Me.cardView1.Columns.AddRange(New DevExpress.XtraGrid.Columns.GridColumn() {Me.gridColumn1, Me.gridColumn2, Me.gridColumn3})
            Me.cardView1.DetailHeight = 700
            Me.cardView1.FocusedCardTopFieldIndex = 0
            Me.cardView1.GridControl = Me.gridControl1
            Me.cardView1.Name = "cardView1"
            Me.cardView1.OptionsBehavior.FieldAutoHeight = True
            ' 
            ' gridColumn1
            ' 
            Me.gridColumn1.Caption = "DateColumn"
            Me.gridColumn1.ColumnEdit = Me.customRepositoryItem1
            Me.gridColumn1.FieldName = "Date"
            Me.gridColumn1.Name = "gridColumn1"
            Me.gridColumn1.Visible = True
            Me.gridColumn1.VisibleIndex = 0
            ' 
            ' gridColumn2
            ' 
            Me.gridColumn2.Caption = "DateColumnCopy"
            Me.gridColumn2.ColumnEdit = Me.customRepositoryItem1
            Me.gridColumn2.FieldName = "Date"
            Me.gridColumn2.Name = "gridColumn2"
            Me.gridColumn2.Visible = True
            Me.gridColumn2.VisibleIndex = 1
            ' 
            ' gridColumn3
            ' 
            Me.gridColumn3.Caption = "EmptyColumn"
            Me.gridColumn3.ColumnEdit = Me.customRepositoryItem1
            Me.gridColumn3.Name = "gridColumn3"
            Me.gridColumn3.Visible = True
            Me.gridColumn3.VisibleIndex = 2
            ' 
            ' bandedGridView1
            ' 
            Me.bandedGridView1.Bands.AddRange(New DevExpress.XtraGrid.Views.BandedGrid.GridBand() {Me.gridBand1})
            Me.bandedGridView1.Columns.AddRange(New DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn() {Me.bandedGridColumn1, Me.bandedGridColumn2, Me.bandedGridColumn3})
            Me.bandedGridView1.GridControl = Me.gridControl1
            Me.bandedGridView1.Name = "bandedGridView1"
            Me.bandedGridView1.OptionsView.RowAutoHeight = True
            ' 
            ' gridBand1
            ' 
            Me.gridBand1.Caption = "gridBand1"
            Me.gridBand1.Columns.Add(Me.bandedGridColumn1)
            Me.gridBand1.Columns.Add(Me.bandedGridColumn2)
            Me.gridBand1.Columns.Add(Me.bandedGridColumn3)
            Me.gridBand1.Name = "gridBand1"
            Me.gridBand1.Width = 521
            ' 
            ' bandedGridColumn1
            ' 
            Me.bandedGridColumn1.Caption = "DateColumn"
            Me.bandedGridColumn1.ColumnEdit = Me.customRepositoryItem1
            Me.bandedGridColumn1.FieldName = "Date"
            Me.bandedGridColumn1.Name = "bandedGridColumn1"
            Me.bandedGridColumn1.Visible = True
            Me.bandedGridColumn1.Width = 173
            ' 
            ' bandedGridColumn2
            ' 
            Me.bandedGridColumn2.Caption = "DateColumnCopy"
            Me.bandedGridColumn2.ColumnEdit = Me.customRepositoryItem1
            Me.bandedGridColumn2.FieldName = "Date"
            Me.bandedGridColumn2.Name = "bandedGridColumn2"
            Me.bandedGridColumn2.Visible = True
            Me.bandedGridColumn2.Width = 173
            ' 
            ' bandedGridColumn3
            ' 
            Me.bandedGridColumn3.Caption = "EmptyColumn"
            Me.bandedGridColumn3.ColumnEdit = Me.customRepositoryItem1
            Me.bandedGridColumn3.Name = "bandedGridColumn3"
            Me.bandedGridColumn3.Visible = True
            Me.bandedGridColumn3.Width = 175
            ' 
            ' layoutView1
            ' 
            Me.layoutView1.CardMinSize = New System.Drawing.Size(520, 160)
            Me.layoutView1.Columns.AddRange(New DevExpress.XtraGrid.Columns.LayoutViewColumn() {Me.layoutViewColumn1, Me.layoutViewColumn2, Me.layoutViewColumn3})
            Me.layoutView1.GridControl = Me.gridControl1
            Me.layoutView1.Name = "layoutView1"
            Me.layoutView1.TemplateCard = Me.layoutViewCard1
            ' 
            ' layoutViewColumn1
            ' 
            Me.layoutViewColumn1.Caption = "DateColumn"
            Me.layoutViewColumn1.ColumnEdit = Me.customRepositoryItem1
            Me.layoutViewColumn1.FieldName = "Date"
            Me.layoutViewColumn1.LayoutViewField = Me.layoutViewField_layoutViewColumn1
            Me.layoutViewColumn1.Name = "layoutViewColumn1"
            ' 
            ' layoutViewField_layoutViewColumn1
            ' 
            Me.layoutViewField_layoutViewColumn1.EditorPreferredWidth = 404
            Me.layoutViewField_layoutViewColumn1.Location = New System.Drawing.Point(0, 20)
            Me.layoutViewField_layoutViewColumn1.Name = "layoutViewField_layoutViewColumn1"
            Me.layoutViewField_layoutViewColumn1.Size = New System.Drawing.Size(500, 20)
            Me.layoutViewField_layoutViewColumn1.TextSize = New System.Drawing.Size(87, 13)
            Me.layoutViewField_layoutViewColumn1.TextToControlDistance = 5
            ' 
            ' layoutViewColumn2
            ' 
            Me.layoutViewColumn2.Caption = "DateColumnCopy"
            Me.layoutViewColumn2.ColumnEdit = Me.customRepositoryItem1
            Me.layoutViewColumn2.FieldName = "Date"
            Me.layoutViewColumn2.LayoutViewField = Me.layoutViewField_layoutViewColumn2
            Me.layoutViewColumn2.Name = "layoutViewColumn2"
            ' 
            ' layoutViewField_layoutViewColumn2
            ' 
            Me.layoutViewField_layoutViewColumn2.EditorPreferredWidth = 404
            Me.layoutViewField_layoutViewColumn2.Location = New System.Drawing.Point(0, 0)
            Me.layoutViewField_layoutViewColumn2.Name = "layoutViewField_layoutViewColumn2"
            Me.layoutViewField_layoutViewColumn2.Size = New System.Drawing.Size(500, 20)
            Me.layoutViewField_layoutViewColumn2.TextSize = New System.Drawing.Size(87, 13)
            Me.layoutViewField_layoutViewColumn2.TextToControlDistance = 5
            ' 
            ' layoutViewColumn3
            ' 
            Me.layoutViewColumn3.Caption = "EmpyColumn"
            Me.layoutViewColumn3.ColumnEdit = Me.customRepositoryItem1
            Me.layoutViewColumn3.LayoutViewField = Me.layoutViewField_layoutViewColumn3
            Me.layoutViewColumn3.Name = "layoutViewColumn3"
            ' 
            ' layoutViewField_layoutViewColumn3
            ' 
            Me.layoutViewField_layoutViewColumn3.EditorPreferredWidth = 404
            Me.layoutViewField_layoutViewColumn3.Location = New System.Drawing.Point(0, 40)
            Me.layoutViewField_layoutViewColumn3.Name = "layoutViewField_layoutViewColumn3"
            Me.layoutViewField_layoutViewColumn3.Size = New System.Drawing.Size(500, 80)
            Me.layoutViewField_layoutViewColumn3.TextSize = New System.Drawing.Size(87, 13)
            Me.layoutViewField_layoutViewColumn3.TextToControlDistance = 5
            ' 
            ' layoutViewCard1
            ' 
            Me.layoutViewCard1.CustomizationFormText = "TemplateCard"
            Me.layoutViewCard1.ExpandButtonLocation = DevExpress.Utils.GroupElementLocation.AfterText
            Me.layoutViewCard1.Items.AddRange(New DevExpress.XtraLayout.BaseLayoutItem() {Me.layoutViewField_layoutViewColumn2, Me.layoutViewField_layoutViewColumn1, Me.layoutViewField_layoutViewColumn3})
            Me.layoutViewCard1.Name = "layoutViewCard1"
            Me.layoutViewCard1.OptionsItemText.TextToControlDistance = 5
            Me.layoutViewCard1.Text = "TemplateCard"
            ' 
            ' groupControl1
            ' 
            Me.groupControl1.Controls.Add(Me.projectLayoutControl1)
            Me.groupControl1.Dock = System.Windows.Forms.DockStyle.Left
            Me.groupControl1.Location = New System.Drawing.Point(402, 2)
            Me.groupControl1.Name = "groupControl1"
            Me.groupControl1.Size = New System.Drawing.Size(200, 104)
            Me.groupControl1.TabIndex = 7
            Me.groupControl1.Text = "Custom UserControl"
            ' 
            ' groupControl2
            ' 
            Me.groupControl2.Dock = System.Windows.Forms.DockStyle.Left
            Me.groupControl2.Location = New System.Drawing.Point(2, 2)
            Me.groupControl2.Name = "groupControl2"
            Me.groupControl2.Size = New System.Drawing.Size(200, 104)
            Me.groupControl2.TabIndex = 8
            Me.groupControl2.Text = "Custom UserControl as Editor"
            ' 
            ' groupControl3
            ' 
            Me.groupControl3.Dock = System.Windows.Forms.DockStyle.Left
            Me.groupControl3.Location = New System.Drawing.Point(202, 2)
            Me.groupControl3.Name = "groupControl3"
            Me.groupControl3.Size = New System.Drawing.Size(200, 104)
            Me.groupControl3.TabIndex = 9
            Me.groupControl3.Text = "Custom UserControl Drawing"
            AddHandler Me.groupControl3.Paint, New System.Windows.Forms.PaintEventHandler(AddressOf Me.groupControl3_Paint)
            ' 
            ' panelControl1
            ' 
            Me.panelControl1.Controls.Add(Me.simpleButton1)
            Me.panelControl1.Controls.Add(Me.groupControl4)
            Me.panelControl1.Controls.Add(Me.groupControl1)
            Me.panelControl1.Controls.Add(Me.groupControl3)
            Me.panelControl1.Controls.Add(Me.groupControl2)
            Me.panelControl1.Dock = System.Windows.Forms.DockStyle.Top
            Me.panelControl1.Location = New System.Drawing.Point(0, 0)
            Me.panelControl1.Name = "panelControl1"
            Me.panelControl1.Size = New System.Drawing.Size(1105, 108)
            Me.panelControl1.TabIndex = 10
            ' 
            ' simpleButton1
            ' 
            Me.simpleButton1.Location = New System.Drawing.Point(900, 41)
            Me.simpleButton1.Name = "simpleButton1"
            Me.simpleButton1.Size = New System.Drawing.Size(75, 23)
            Me.simpleButton1.TabIndex = 11
            Me.simpleButton1.Text = "Print"
            AddHandler Me.simpleButton1.Click, New System.EventHandler(AddressOf Me.simpleButton1_Click)
            ' 
            ' groupControl4
            ' 
            Me.groupControl4.Controls.Add(Me.radioGroup1)
            Me.groupControl4.Dock = System.Windows.Forms.DockStyle.Left
            Me.groupControl4.Location = New System.Drawing.Point(602, 2)
            Me.groupControl4.Name = "groupControl4"
            Me.groupControl4.Size = New System.Drawing.Size(200, 104)
            Me.groupControl4.TabIndex = 10
            Me.groupControl4.Text = "View"
            ' 
            ' radioGroup1
            ' 
            Me.radioGroup1.Dock = System.Windows.Forms.DockStyle.Fill
            Me.radioGroup1.Location = New System.Drawing.Point(2, 21)
            Me.radioGroup1.Name = "radioGroup1"
            Me.radioGroup1.Properties.Items.AddRange(New DevExpress.XtraEditors.Controls.RadioGroupItem() {New DevExpress.XtraEditors.Controls.RadioGroupItem(Nothing, "GridView"), New DevExpress.XtraEditors.Controls.RadioGroupItem(Nothing, "CardView"), New DevExpress.XtraEditors.Controls.RadioGroupItem(Nothing, "BandedGridView"), New DevExpress.XtraEditors.Controls.RadioGroupItem(Nothing, "LayoutView")})
            Me.radioGroup1.Size = New System.Drawing.Size(196, 81)
            Me.radioGroup1.TabIndex = 0
            AddHandler Me.radioGroup1.SelectedIndexChanged, New System.EventHandler(AddressOf Me.radioGroup1_SelectedIndexChanged)
            ' 
            ' Form1
            ' 
            Me.AutoScaleDimensions = New System.Drawing.SizeF(6F, 13F)
            Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
            Me.ClientSize = New System.Drawing.Size(1105, 590)
            Me.Controls.Add(Me.gridControl1)
            Me.Controls.Add(Me.panelControl1)
            Me.Name = "Form1"
            Me.Text = "Form1"
            AddHandler Me.Load, New System.EventHandler(AddressOf Me.Form1_Load)
            CType((Me.gridControl1), System.ComponentModel.ISupportInitialize).EndInit()
            CType((Me.gridView1), System.ComponentModel.ISupportInitialize).EndInit()
            CType((Me.customRepositoryItem1), System.ComponentModel.ISupportInitialize).EndInit()
            CType((Me.cardView1), System.ComponentModel.ISupportInitialize).EndInit()
            CType((Me.bandedGridView1), System.ComponentModel.ISupportInitialize).EndInit()
            CType((Me.layoutView1), System.ComponentModel.ISupportInitialize).EndInit()
            CType((Me.layoutViewField_layoutViewColumn1), System.ComponentModel.ISupportInitialize).EndInit()
            CType((Me.layoutViewField_layoutViewColumn2), System.ComponentModel.ISupportInitialize).EndInit()
            CType((Me.layoutViewField_layoutViewColumn3), System.ComponentModel.ISupportInitialize).EndInit()
            CType((Me.layoutViewCard1), System.ComponentModel.ISupportInitialize).EndInit()
            CType((Me.groupControl1), System.ComponentModel.ISupportInitialize).EndInit()
            Me.groupControl1.ResumeLayout(False)
            CType((Me.groupControl2), System.ComponentModel.ISupportInitialize).EndInit()
            CType((Me.groupControl3), System.ComponentModel.ISupportInitialize).EndInit()
            CType((Me.panelControl1), System.ComponentModel.ISupportInitialize).EndInit()
            Me.panelControl1.ResumeLayout(False)
            CType((Me.groupControl4), System.ComponentModel.ISupportInitialize).EndInit()
            Me.groupControl4.ResumeLayout(False)
            CType((Me.radioGroup1.Properties), System.ComponentModel.ISupportInitialize).EndInit()
            Me.ResumeLayout(False)
        End Sub

'#End Region
        Private projectLayoutControl1 As CustomControlInGrid.ProjectLayoutControl

        Private gridControl1 As DevExpress.XtraGrid.GridControl

        Private gridView1 As DevExpress.XtraGrid.Views.Grid.GridView

        Private DateColumn As DevExpress.XtraGrid.Columns.GridColumn

        Private customRepositoryItem1 As CustomControlInGrid.CustomRepositoryItem

        Private groupControl1 As DevExpress.XtraEditors.GroupControl

        Private groupControl2 As DevExpress.XtraEditors.GroupControl

        Private groupControl3 As DevExpress.XtraEditors.GroupControl

        Private EmptyColumn As DevExpress.XtraGrid.Columns.GridColumn

        Private DateColumnCopy As DevExpress.XtraGrid.Columns.GridColumn

        Private panelControl1 As DevExpress.XtraEditors.PanelControl

        Private groupControl4 As DevExpress.XtraEditors.GroupControl

        Private radioGroup1 As DevExpress.XtraEditors.RadioGroup

        Private cardView1 As DevExpress.XtraGrid.Views.Card.CardView

        Private gridColumn1 As DevExpress.XtraGrid.Columns.GridColumn

        Private gridColumn2 As DevExpress.XtraGrid.Columns.GridColumn

        Private gridColumn3 As DevExpress.XtraGrid.Columns.GridColumn

        Private bandedGridView1 As DevExpress.XtraGrid.Views.BandedGrid.BandedGridView

        Private bandedGridColumn1 As DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn

        Private bandedGridColumn2 As DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn

        Private bandedGridColumn3 As DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn

        Private layoutView1 As DevExpress.XtraGrid.Views.Layout.LayoutView

        Private layoutViewColumn1 As DevExpress.XtraGrid.Columns.LayoutViewColumn

        Private layoutViewColumn2 As DevExpress.XtraGrid.Columns.LayoutViewColumn

        Private layoutViewColumn3 As DevExpress.XtraGrid.Columns.LayoutViewColumn

        Private layoutViewField_layoutViewColumn1 As DevExpress.XtraGrid.Views.Layout.LayoutViewField

        Private layoutViewField_layoutViewColumn2 As DevExpress.XtraGrid.Views.Layout.LayoutViewField

        Private layoutViewField_layoutViewColumn3 As DevExpress.XtraGrid.Views.Layout.LayoutViewField

        Private layoutViewCard1 As DevExpress.XtraGrid.Views.Layout.LayoutViewCard

        Private gridBand1 As DevExpress.XtraGrid.Views.BandedGrid.GridBand

        Private simpleButton1 As DevExpress.XtraEditors.SimpleButton
    End Class
End Namespace
