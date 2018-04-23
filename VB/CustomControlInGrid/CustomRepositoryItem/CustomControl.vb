Imports Microsoft.VisualBasic
Imports System
Imports System.Collections.Generic
Imports System.Text
Imports DevExpress.XtraEditors
Imports DevExpress.XtraEditors.Controls
Imports System.ComponentModel
Imports DevExpress.Utils.Drawing
Imports DevExpress.XtraEditors.ViewInfo

Namespace CustomControlInGrid
	Friend Class CustomControl
		Inherits BaseEdit
		Implements IAutoHeightControl
		#Region "IAutoHeightControl implement"
		Private ReadOnly Property SupportsAutoHeight() As Boolean Implements IAutoHeightControl.SupportsAutoHeight
			Get
				Return True
			End Get
		End Property

		Public Event eHeightChanged As EventHandler
		Private Custom Event HeightChanged As EventHandler Implements IAutoHeightControl.HeightChanged
			AddHandler(ByVal value As EventHandler)
				AddHandler eHeightChanged, value
			End AddHandler
			RemoveHandler(ByVal value As EventHandler)
				RemoveHandler eHeightChanged, value
			End RemoveHandler
			RaiseEvent(ByVal sender As System.Object, ByVal e As System.EventArgs)
			End RaiseEvent
		End Event
		Protected Sub RaiseHeightChanged()
			RaiseEvent eHeightChanged(Me, EventArgs.Empty)
		End Sub

		Private Function CalcHeight(ByVal cache As GraphicsCache) As Integer Implements IAutoHeightControl.CalcHeight
			If ViewInfo.IsReady Then
				Dim ih As IHeightAdaptable = TryCast(ViewInfo, IHeightAdaptable)
				If ih IsNot Nothing Then
					Return ih.CalcHeight(cache, Width)
				End If
			End If
			Return Height

		End Function
		#End Region
		Shared Sub New()
			CustomRepositoryItem.Register()
		End Sub
		Public Sub New()
			MyBase.New()
			AddHandler Properties.ControlTypeChanged, AddressOf Properties_ControlTypeChanged
			UpdateControls()
			'this.Dock = System.Windows.Forms.DockStyle.Fill;
		End Sub

		Private Sub Properties_ControlTypeChanged(ByVal sender As Object, ByVal e As EventArgs)
			UpdateControls()
		End Sub
		Private Sub UpdateControls()
			Controls.Clear()
			If Properties.ControlType Is Nothing Then
				Return
			End If
			Controls.Add(Properties.EditorControl)
			AddHandler TryCast(Properties.EditorControl, IEditValue).EditValueChanged, AddressOf editor_EditValueChanged
			TryCast(Properties.EditorControl, IEditValue).EditValue = EditValue
		End Sub

		Private Sub editor_EditValueChanged(ByVal sender As Object, ByVal e As EventArgs)

			EditValue = (TryCast(Properties.EditorControl, IEditValue)).EditValue
			IsModified = True
		End Sub
		Public Overrides ReadOnly Property EditorTypeName() As String
			Get
				Return CustomRepositoryItem.EditorName
			End Get
		End Property
		<DesignerSerializationVisibility(DesignerSerializationVisibility.Content)> _
		Public Shadows ReadOnly Property Properties() As CustomRepositoryItem
			Get
				Return TryCast(MyBase.Properties, CustomRepositoryItem)
			End Get
		End Property
		Protected Overrides Sub OnPropertiesChanged()
			MyBase.OnPropertiesChanged()
			Me.RaiseHeightChanged()
		End Sub
		Public Overrides Property EditValue() As Object
			Get
				Return MyBase.EditValue
			End Get
			Set(ByVal value As Object)
				MyBase.EditValue = value
				TryCast(Properties.EditorControl, IEditValue).EditValue = EditValue
			End Set
		End Property
	End Class

End Namespace
