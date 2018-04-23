Imports Microsoft.VisualBasic
Imports System
Imports System.Collections.Generic
Imports System.ComponentModel
Imports System.Drawing
Imports System.Reflection
Imports System.Text
Imports System.Windows.Forms

Imports DevExpress.XtraEditors
Imports DevExpress.XtraEditors.Controls
Imports DevExpress.XtraEditors.Drawing
Imports DevExpress.XtraEditors.Registrator
Imports DevExpress.XtraEditors.Repository
Imports DevExpress.XtraEditors.ViewInfo
Imports DevExpress.Utils.Drawing
Imports DevExpress.XtraEditors.Mask
Imports DevExpress.XtraPrinting

Namespace CustomControlInGrid
	<UserRepositoryItem("Register")> _
	Friend Class CustomRepositoryItem
		Inherits RepositoryItem
		Public Event ControlTypeChanged As EventHandler
		Private _drawControl As UserControl
		Friend ReadOnly Property DrawControl() As UserControl
			Get
				Return _drawControl
			End Get
		End Property
		Private _editorControl As UserControl
		Friend ReadOnly Property EditorControl() As UserControl
			Get
				Return _editorControl
			End Get
		End Property
		Friend ControlRepositories As Dictionary(Of String, RepositoryItem)

		Private _controlType As Type
		Public Property ControlType() As Type
			Get
				Return _controlType
			End Get
			Set(ByVal value As Type)
				If _controlType Is value Then
					Return
				End If
				_controlType = value
				Dim cConstructor As ConstructorInfo = ControlType.GetConstructor(BindingFlags.Instance Or BindingFlags.Public Or BindingFlags.CreateInstance Or BindingFlags.NonPublic, Nothing, New Type() { }, Nothing)
				_drawControl = TryCast(cConstructor.Invoke(Nothing), UserControl)
				_editorControl = TryCast(cConstructor.Invoke(Nothing), UserControl)
				_editorControl.Dock = DockStyle.Fill
				UpdateControlRepositoreies()
				OnControlTypeChanged()
				OnPropertiesChanged()
			End Set
		End Property
		Private Sub OnControlTypeChanged()
			RaiseEvent ControlTypeChanged(Me, EventArgs.Empty)
		End Sub
		Private Sub UpdateControlRepositoreies()
			ControlRepositories = New Dictionary(Of String, RepositoryItem)()
			Dim editorList As List(Of BaseEdit) = EditorFinder.FindEditors(_drawControl)
			For Each control As Control In editorList
				Dim editor As BaseEdit = TryCast(control, BaseEdit)
				If editor Is Nothing Then
					Continue For
				End If
				Dim cConstructor As ConstructorInfo = editor.Properties.GetType().GetConstructor(BindingFlags.Instance Or BindingFlags.Public Or BindingFlags.CreateInstance Or BindingFlags.NonPublic, Nothing, New Type() { }, Nothing)
				Dim ri As RepositoryItem = TryCast(cConstructor.Invoke(Nothing), RepositoryItem)
				If (Not ControlRepositories.ContainsKey(ri.EditorTypeName)) Then
					ControlRepositories.Add(ri.EditorTypeName, ri)
				End If
			Next control
		End Sub

		Shared Sub New()
			Register()
		End Sub
		Public Sub New()
			MyBase.New()
		End Sub
		Friend Const EditorName As String = "Custom Control"

		Public Shared Sub Register()
			EditorRegistrationInfo.Default.Editors.Add(New EditorClassInfo(EditorName, GetType(CustomControl), GetType(CustomRepositoryItem), GetType(CustomControlViewInfo), New CustomControlPainter(), True))
		End Sub
		Public Overrides ReadOnly Property EditorTypeName() As String
			Get
				Return EditorName
			End Get
		End Property
		Public Overrides Sub Assign(ByVal item As RepositoryItem)
			MyBase.Assign(item)
			ControlType = (TryCast(item, CustomRepositoryItem)).ControlType
		End Sub

		Public Overrides Function GetBrick(ByVal info As PrintCellHelperInfo) As IVisualBrick
			Dim brick As IVisualBrick = MyBase.GetBrick(info)
			info.Graph.DrawBrick(brick, info.Rectangle)
			Return (TryCast(DrawControl, IExport)).GetBrick(info)
		End Function
	End Class
End Namespace
