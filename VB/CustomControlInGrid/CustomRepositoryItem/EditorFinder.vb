Imports System.Collections.Generic
Imports DevExpress.XtraEditors
Imports System.Windows.Forms

Namespace CustomControlInGrid

    Public Module EditorFinder

        Public Function FindEditors(ByVal drawControl As Control) As List(Of BaseEdit)
            Dim editorList As List(Of BaseEdit) = New List(Of BaseEdit)()
            For Each control As Control In drawControl.Controls
                Dim editor As BaseEdit = TryCast(control, BaseEdit)
                If editor IsNot Nothing Then
                    editorList.Add(editor)
                Else
                    editorList.AddRange(FindEditors(control))
                End If
            Next

            Return editorList
        End Function
    End Module
' Friend NotInheritable Class EditorFinder
' Private Sub New()
' End Sub
' Public Shared Function findEditors(ByVal drawControl As Control) As List(Of BaseEdit)
' Dim editors As New List(Of BaseEdit)()
' For Each control As Control In drawControl.Controls
' Dim editor As BaseEdit = TryCast(control, BaseEdit)
' If editor IsNot Nothing Then
' editors.Add(editor)
' Else
' editors.AddRange(findEditors(control))
' End If
' Next control
' Return editors
' End Function
' 
' End Class
End Namespace
