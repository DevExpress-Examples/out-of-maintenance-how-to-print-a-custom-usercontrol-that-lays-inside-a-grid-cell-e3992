Imports System.Collections.Generic
Imports DevExpress.XtraEditors.Drawing
Imports DevExpress.XtraEditors
Imports System.Windows.Forms
Imports DevExpress.XtraEditors.Repository
Imports DevExpress.XtraEditors.ViewInfo
Imports System.Drawing

Namespace CustomControlInGrid

    Friend Class CustomControlPainter
        Inherits BaseEditPainter

        Public Sub New()
            MyBase.New()
        End Sub

        Public Overrides Sub Draw(ByVal info As ControlGraphicsInfoArgs)
            MyBase.Draw(info)
            Dim vi As CustomControlViewInfo = TryCast(info.ViewInfo, CustomControlViewInfo)
            Dim cri As CustomRepositoryItem = TryCast(vi.Item, CustomRepositoryItem)
            If cri.ControlType Is Nothing Then Return
            TryCast(cri.DrawControl, IEditValue).EditValue = vi.EditValue
            cri.DrawControl.Bounds = info.Bounds
            Dim bm As Bitmap = New Bitmap(info.Bounds.Width, info.Bounds.Height)
            cri.DrawControl.DrawToBitmap(bm, New Rectangle(0, 0, bm.Width, bm.Height))
            info.Graphics.DrawImage(bm, info.Bounds.Location)
            Dim editors As List(Of BaseEdit) = New List(Of BaseEdit)()
            editors = FindEditors(cri.DrawControl)
            DrawEditors(editors, info, cri)
        End Sub

        Private Sub DrawEditors(ByVal editors As List(Of BaseEdit), ByVal info As ControlGraphicsInfoArgs, ByVal cri As CustomRepositoryItem)
            For Each editor As BaseEdit In editors
                Dim ri As RepositoryItem = cri.ControlRepositories(editor.EditorTypeName)
                ri.Assign(editor.Properties)
                Dim bevi As BaseEditViewInfo = ri.CreateViewInfo()
                bevi.EditValue = editor.EditValue
                Dim rec As Rectangle = editor.Bounds
                rec.X += info.ViewInfo.Bounds.X
                rec.Y += info.ViewInfo.Bounds.Y
                bevi.CalcViewInfo(info.Graphics, MouseButtons.Left, New Point(0, 0), rec)
                Dim cinfo As ControlGraphicsInfoArgs = New ControlGraphicsInfoArgs(bevi, info.Cache, info.ViewInfo.Bounds)
                Dim bp As BaseEditPainter = ri.CreatePainter()
                Try
                    bp.Draw(cinfo)
                Catch
                End Try
            Next
        End Sub
    End Class
End Namespace
