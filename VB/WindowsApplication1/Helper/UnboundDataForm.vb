Imports Microsoft.VisualBasic
Imports System
Imports System.Collections.Generic
Imports System.ComponentModel
Imports System.Data
Imports System.Drawing
Imports System.Text
Imports System.Windows.Forms

Namespace WindowsApplication1.Helper
	Partial Public Class UnboundDataForm
		Inherits Form
		Private _Helper As MyUnboundGridHelper
		Public Property Helper() As MyUnboundGridHelper
			Get
				Return _Helper
			End Get
			Set(ByVal value As MyUnboundGridHelper)
				_Helper = value
				HelperChanged()
			End Set
		End Property

		Public Sub New(ByVal helper As MyUnboundGridHelper)
			InitializeComponent()
			Me.Helper = helper
		End Sub

		Private Sub HelperChanged()
			propertyGrid1.SelectedObject = Helper.GridData
			dataGridView1.DataSource = Helper.GridData
			dataNavigator1.DataSource = Helper.GridData
		End Sub
	End Class
End Namespace