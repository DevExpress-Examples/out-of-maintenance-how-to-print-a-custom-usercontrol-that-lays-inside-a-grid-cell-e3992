Imports Microsoft.VisualBasic
Imports System
Imports System.Collections.Generic
Imports System.Text
Imports DevExpress.XtraEditors.ViewInfo
Imports DevExpress.XtraEditors.Repository
Imports DevExpress.Utils.Drawing

Namespace CustomControlInGrid
	Friend Class CustomControlViewInfo
		Inherits BaseEditViewInfo
		Implements IHeightAdaptable
		Private Sub New(ByVal Item As RepositoryItem)
			MyBase.New(Item)
		End Sub
		Private Function CalcHeight(ByVal cache As GraphicsCache, ByVal width As Integer) As Integer Implements IHeightAdaptable.CalcHeight
			Dim cri As CustomRepositoryItem = TryCast(Item, CustomRepositoryItem)
			If cri.ControlType Is Nothing Then
				Return Me.CalcMinHeight(cache.Graphics)
			End If
			Return cri.DrawControl.Height
		End Function
		Public Overrides Property EditValue() As Object
			Get
				Return MyBase.EditValue
			End Get
			Set(ByVal value As Object)
				MyBase.EditValue = value
			End Set
		End Property
		Public Overrides ReadOnly Property DisplayText() As String
			Get
				Return MyBase.DisplayText
			End Get
		End Property
	End Class

End Namespace
