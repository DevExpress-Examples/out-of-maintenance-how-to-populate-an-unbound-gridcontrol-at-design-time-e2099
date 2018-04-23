Imports Microsoft.VisualBasic
Imports System
Imports System.Collections.Generic
Imports System.ComponentModel
Imports System.Data
Imports System.Drawing
Imports System.Text
Imports System.Windows.Forms
Imports System.Windows.Forms.Design
Imports System.ComponentModel.Design

Namespace WindowsApplication1
	Public Class MyDesigner
		Inherits ComponentDesigner
		Private actionLists_Renamed As DesignerActionListCollection

		Public Overrides ReadOnly Property ActionLists() As DesignerActionListCollection
			Get
				If actionLists_Renamed Is Nothing Then
					actionLists_Renamed = New DesignerActionListCollection()
					actionLists_Renamed.Add(New MyActionList(CType(Component, MyUnboundGridHelper)))
				End If
				Return actionLists_Renamed
			End Get
		End Property
	End Class
End Namespace
