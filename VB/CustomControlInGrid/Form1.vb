Imports System
Imports System.ComponentModel
Imports System.Data
Imports System.Drawing
Imports System.Windows.Forms
Imports DevExpress.XtraEditors.Controls
Imports DevExpress.XtraEditors.Drawing
Imports DevExpress.XtraEditors.ViewInfo
Imports DevExpress.Utils.Drawing

Namespace CustomControlInGrid

    Public Partial Class Form1
        Inherits Form

        Private cc As CustomControl = New CustomControl()

        Private dt As DataTable = New DataTable()

        Public Sub New()
            InitializeComponent()
            dt.Columns.Add("Date", GetType(ProjectTime))
            For i As Integer = 0 To 5 - 1
                dt.Rows.Add(New ProjectTime(Date.Now.AddDays(-i), Date.Now.AddDays(5 - i)))
            Next

            customRepositoryItem1.ControlType = GetType(ProjectLayoutControl)
            cc.Properties.ControlType = GetType(ProjectLayoutControl)
            cc.Dock = DockStyle.Fill
            cc.Location = New Point(5, 25)
            cc.Properties.AutoHeight = False
            groupControl2.Controls.Add(cc)
            AddHandler cc.EditValueChanged, New EventHandler(AddressOf cc_EditValueChanged)
        End Sub

        Private Sub Form1_Load(ByVal sender As Object, ByVal e As EventArgs)
            Dim bs As BindingSource = New BindingSource()
            bs.DataSource = dt
            gridControl1.DataSource = bs
            projectLayoutControl1.EditValue = New ProjectTime(Date.Now.AddDays(-1), Date.Now.AddDays(1))
            cc.EditValue = New ProjectTime(Date.Now.AddDays(-1), Date.Now.AddDays(1))
        End Sub

        Private Sub cc_EditValueChanged(ByVal sender As Object, ByVal e As EventArgs)
            groupControl3.Refresh()
        End Sub

        Private Sub groupControl3_Paint(ByVal sender As Object, ByVal e As PaintEventArgs)
            Dim bm As Bitmap = New Bitmap(cc.Width, cc.Height)
            cc.DrawToBitmap(bm, cc.Bounds)
            Dim pb As BaseEditPainter = cc.Properties.CreatePainter()
            Dim bevi As BaseEditViewInfo = cc.Properties.CreateViewInfo()
            bevi.CalcViewInfo(e.Graphics, MouseButtons.Left, New Point(0, 0), cc.Bounds)
            Dim gc As GraphicsCache = New GraphicsCache(e.Graphics)
            Try
                pb.Draw(New ControlGraphicsInfoArgs(bevi, gc, cc.Bounds))
            Catch
            End Try
        End Sub

        Private Sub radioGroup1_SelectedIndexChanged(ByVal sender As Object, ByVal e As EventArgs)
            gridControl1.MainView = gridControl1.ViewCollection(radioGroup1.SelectedIndex)
        End Sub

        Private Sub simpleButton1_Click(ByVal sender As Object, ByVal e As EventArgs)
            gridControl1.ShowPrintPreview()
        End Sub

        Private Sub gridView1_BeforePrintRow(ByVal sender As Object, ByVal e As DevExpress.XtraGrid.Views.Printing.CancelPrintRowEventArgs)
        End Sub
    End Class
End Namespace
