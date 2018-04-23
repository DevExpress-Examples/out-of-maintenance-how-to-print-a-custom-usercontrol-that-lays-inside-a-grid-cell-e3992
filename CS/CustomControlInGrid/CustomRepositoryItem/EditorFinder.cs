using System;
using System.Collections.Generic;
using System.Text;
using DevExpress.XtraEditors;
using System.Windows.Forms;

namespace CustomControlInGrid
{
    static public class EditorFinder
    {
        static public List<BaseEdit> FindEditors(Control drawControl)
        {
            List<BaseEdit> editorList = new List<BaseEdit>();
            foreach (Control control in drawControl.Controls)
            {
                BaseEdit editor = control as BaseEdit;
                if (editor != null)
                    editorList.Add(editor);
                else
                    editorList.AddRange(FindEditors(control));
            }
            return editorList;
        }
    }
    /*Friend NotInheritable Class EditorFinder
        Private Sub New()
        End Sub
        Public Shared Function findEditors(ByVal drawControl As Control) As List(Of BaseEdit)
            Dim editors As New List(Of BaseEdit)()
            For Each control As Control In drawControl.Controls
                Dim editor As BaseEdit = TryCast(control, BaseEdit)
                If editor IsNot Nothing Then
                    editors.Add(editor)
                Else
                    editors.AddRange(findEditors(control))
                End If
            Next control
            Return editors
        End Function

    End Class*/
}
