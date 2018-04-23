Imports Microsoft.VisualBasic
Imports System
Imports System.Collections.Generic
Imports System.ComponentModel
Imports System.Data
Imports System.Drawing
Imports System.Text
Imports System.Windows.Forms
Imports System.ComponentModel.Design
Imports WindowsApplication1.Helper

Namespace WindowsApplication1
	Public Class MyActionList
		Inherits DesignerActionList


		Public ReadOnly Property Helper() As MyUnboundGridHelper
			Get
				Return TryCast(Component, MyUnboundGridHelper)
			End Get
		End Property

		Public Sub New(ByVal component As IComponent)
			MyBase.New(component)
		End Sub

		Public Overrides Function GetSortedActionItems() As DesignerActionItemCollection
			Dim items As New DesignerActionItemCollection()
			items.Add(New DesignerActionMethodItem(Me, "ShowDesigner", "Add unbound data", "Data management", "Add unbound data", True))
			Return items
		End Function


		Private Sub ShowDesigner()
			Helper.ShowDesigner()
		End Sub
	End Class
End Namespace
