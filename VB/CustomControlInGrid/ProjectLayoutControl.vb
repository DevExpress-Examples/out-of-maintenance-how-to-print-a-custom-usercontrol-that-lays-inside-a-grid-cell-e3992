Imports System
Imports System.ComponentModel
Imports System.Drawing
Imports System.Windows.Forms
Imports DevExpress.XtraEditors.Mask
Imports DevExpress.XtraEditors
Imports DevExpress.XtraEditors.Repository
Imports DevExpress.XtraPrinting

Namespace CustomControlInGrid

    Public Partial Class ProjectLayoutControl
        Inherits UserControl
        Implements IEditValue, IExport

        Private EditValueEventBlock As Boolean = False

        Public Sub New()
            InitializeComponent()
            dateEdit_Begin.DateTime = Date.Now
            dateEdit_Now.DateTime = Date.Now
            dateEdit_End.DateTime = Date.Now
            AddHandler dateEdit_Begin.Controls(0).VisibleChanged, New EventHandler(AddressOf Me.ProjectLayoutControl_VisibleChanged)
        End Sub

        Private Sub ProjectLayoutControl_VisibleChanged(ByVal sender As Object, ByVal e As EventArgs)
            Dim v As Boolean = TryCast(sender, MaskBox).Visible
        End Sub

        Public Property EditValue As Object Implements IEditValue.EditValue
            Get
                Return CObj(New ProjectTime(dateEdit_Begin.DateTime, dateEdit_End.DateTime))
            End Get

            Set(ByVal value As Object)
                If value Is Nothing Then
                    dateEdit_Begin.EditValue = Nothing
                    dateEdit_End.EditValue = Nothing
                    dateEdit_Now.EditValue = Nothing
                    progressBarControl1.Position = 0
                    Refresh()
                    Return
                End If

                EditValueEventBlock = True
                Try
                    dateEdit_Begin.DateTime = CType(value, ProjectTime).Begin
                    dateEdit_End.DateTime = CType(value, ProjectTime).End
                    dateEdit_Now.DateTime = Date.Now
                    Refresh()
                Finally
                    EditValueEventBlock = False
                End Try
            End Set
        End Property

        Public Event EditValueChanged As EventHandler Implements IEditValue.EditValueChanged

        Private Sub dateEdit_EditValueChanged(ByVal sender As Object, ByVal e As EventArgs)
            Dim tsAll As TimeSpan = dateEdit_End.DateTime - dateEdit_Begin.DateTime
            Dim tsNow As TimeSpan = dateEdit_Now.DateTime - dateEdit_Begin.DateTime
            If tsAll.Days <> 0 Then
                progressBarControl1.Position = tsNow.Days * 100 \ tsAll.Days
            Else
                progressBarControl1.Position = 100
            End If

            If EditValueChangedEvent Is Nothing OrElse EditValueEventBlock Then Return
            RaiseEvent EditValueChanged(Me, EventArgs.Empty)
        End Sub

#Region "IExport Members"
        Private Sub ExportProgressBar(ByVal info As PrintCellHelperInfo, ByVal brick As PanelBrick)
            Dim rect As Rectangle = progressBarControl1.Bounds
            rect.Width = info.Rectangle.Right - rect.X - info.Rectangle.X
            rect.Height = info.Rectangle.Bottom - rect.Y - info.Rectangle.Y
            Dim inf As PrintCellHelperInfo = New PrintCellHelperInfo(info.LineColor, info.PS, progressBarControl1.Position, progressBarControl1.Properties.Appearance, progressBarControl1.Properties.DisplayFormat.GetDisplayText(progressBarControl1.Position), rect, info.Graph, DevExpress.Utils.HorzAlignment.Near, True, True, progressBarControl1.Properties.DisplayFormat.GetFormatString(), BorderSide.All)
            Dim pbb As ProgressBarBrick = CType(progressBarControl1.Properties.GetBrick(inf), ProgressBarBrick)
            pbb.Rect = rect
            brick.Bricks.Add(pbb)
        End Sub

        Private Sub ExportDateEdit(ByVal info As PrintCellHelperInfo, ByVal editor As DateEdit, ByVal brick As PanelBrick)
            Dim rect As Rectangle = editor.Bounds
            rect.Width = info.Rectangle.Right - rect.X - info.Rectangle.X
            Dim inf As PrintCellHelperInfo = New PrintCellHelperInfo(info.LineColor, info.PS, editor.DateTime, editor.Properties.Appearance, editor.Properties.DisplayFormat.GetDisplayText(editor.EditValue), rect, info.Graph, DevExpress.Utils.HorzAlignment.Near, True, True, editor.Properties.DisplayFormat.GetFormatString(), BorderSide.All)
            Dim tb As TextBrick = CType(editor.Properties.GetBrick(inf), TextBrick)
            tb.Rect = rect
            brick.Bricks.Add(tb)
        End Sub

        Private Sub ExportPanel(ByVal info As PrintCellHelperInfo, ByVal brick As PanelBrick)
            ExportFirstLine(info, brick)
            ExportSecondLine(info, brick)
            ExportThirdLine(info, brick)
            ExportFourthLine(info, brick)
        End Sub

        Private Sub ExportFourthLine(ByVal info As PrintCellHelperInfo, ByVal brick As PanelBrick)
            Dim rect As Rectangle = panelControl1.Bounds
            rect.Y += progressBarControl1.Bounds.Y
            rect.Height = info.Rectangle.Bottom - rect.Y - info.Rectangle.Y
            Call ExportText(info, rect, "Progress", brick)
        End Sub

        Private Sub ExportThirdLine(ByVal info As PrintCellHelperInfo, ByVal brick As PanelBrick)
            Dim rect As Rectangle = panelControl1.Bounds
            rect.Y += dateEdit_End.Bounds.Y
            rect.Height = dateEdit_End.Bounds.Height
            Call ExportText(info, rect, "End Time", brick)
        End Sub

        Private Sub ExportSecondLine(ByVal info As PrintCellHelperInfo, ByVal brick As PanelBrick)
            Dim rect As Rectangle = panelControl1.Bounds
            rect.Y += dateEdit_Now.Bounds.Y
            rect.Height = dateEdit_Now.Bounds.Height
            Call ExportText(info, rect, "Now Time", brick)
        End Sub

        Private Sub ExportFirstLine(ByVal info As PrintCellHelperInfo, ByVal brick As PanelBrick)
            Dim rect As Rectangle = panelControl1.Bounds
            rect.Height = dateEdit_Begin.Bounds.Height
            Call ExportText(info, rect, "Begin Time", brick)
        End Sub

        Private Shared Sub ExportText(ByVal info As PrintCellHelperInfo, ByVal rect As Rectangle, ByVal text As String, ByVal brick As PanelBrick)
            Dim inf As PrintCellHelperInfo = New PrintCellHelperInfo(info.LineColor, info.PS, text, info.Appearace, text, rect, info.Graph, DevExpress.Utils.HorzAlignment.Near, True, True, info.TextValueFormatString, BorderSide.All)
            Using repTE As RepositoryItemTextEdit = New RepositoryItemTextEdit()
                Dim tb As TextBrick = CType(repTE.GetBrick(inf), TextBrick)
                tb.Rect = rect
                brick.Bricks.Add(tb)
            End Using
        End Sub

        Public Function GetBrick(ByVal info As PrintCellHelperInfo) As IVisualBrick Implements IExport.GetBrick
            EditValue = info.EditValue
            Dim brick As PanelBrick = New PanelBrick()
            brick.BackColor = Color.White
            ExportProgressBar(info, brick)
            ExportDateEdit(info, dateEdit_Begin, brick)
            ExportDateEdit(info, dateEdit_End, brick)
            ExportDateEdit(info, dateEdit_Now, brick)
            ExportPanel(info, brick)
            Return brick
        End Function
#End Region
    End Class

    Friend Class ProjectTime

        Public Sub New(ByVal Begin As Date, ByVal [End] As Date)
            Me.Begin = Begin
            Me.End = [End]
        End Sub

        Public _begin As Date

        Public _end As Date

        Public Property Begin As Date
            Get
                Return _begin
            End Get

            Set(ByVal value As Date)
                _begin = value
            End Set
        End Property

        Public Property [End] As Date
            Get
                Return _end
            End Get

            Set(ByVal value As Date)
                _end = value
            End Set
        End Property
    End Class
End Namespace
