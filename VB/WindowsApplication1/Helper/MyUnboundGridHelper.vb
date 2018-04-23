Imports Microsoft.VisualBasic
Imports System
Imports System.Collections.Generic
Imports System.ComponentModel
Imports System.Data
Imports System.Drawing
Imports System.Text
Imports System.Windows.Forms
Imports DevExpress.XtraGrid.Views.Grid
Imports DevExpress.XtraGrid
Imports System.IO
Imports DevExpress.XtraLayout.Resizing
Imports WindowsApplication1.Helper

Namespace WindowsApplication1
	<Designer(GetType(MyDesigner))> _
	Public Class MyUnboundGridHelper
		Inherits Component

		Public Sub New()

		End Sub

		Private _SelectedGridControl As GridControl
		Public Property SelectedGridControl() As GridControl
			Get
				Return _SelectedGridControl
			End Get
			Set(ByVal value As GridControl)
				_SelectedGridControl = value
				OnSelectedGridControlChanged()
			End Set
		End Property

		Private Sub OnSelectedGridControlChanged()
			If SelectedGridControl IsNot Nothing Then
				SelectedGridControl.DataSource = GridData
			End If
		End Sub

		Private _GridData As DataTable

		<DesignerSerializationVisibility(DesignerSerializationVisibility.Content)> _
		Public Property GridData() As DataTable
			Get
				If _GridData Is Nothing Then
					_GridData = New DataTable()
				End If
					If File.Exists(Constants.XmlFileName) Then
						_GridData.Clear()
						_GridData.ReadXmlSchema(Constants.SchemaName)
						_GridData.ReadXml(Constants.XmlFileName)
					End If
				Return _GridData
			End Get
			Set(ByVal value As DataTable)
				_GridData = value
			End Set
		End Property

		Public Sub ShowDesigner()
			CType(New UnboundDataForm(Me), UnboundDataForm).ShowDialog()
			File.Delete(Constants.XmlFileName)
			GridData.WriteXmlSchema(Constants.SchemaName)
			GridData.WriteXml(Constants.XmlFileName)
			SelectedGridControl.MainView.PopulateColumns()
		End Sub

	End Class

End Namespace