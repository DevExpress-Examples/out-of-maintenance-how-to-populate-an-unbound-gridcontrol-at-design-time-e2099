Imports Microsoft.VisualBasic
Imports System
Namespace WindowsApplication1
	Partial Public Class Form1
		''' <summary>
		''' Required designer variable.
		''' </summary>
		Private components As System.ComponentModel.IContainer = Nothing

		''' <summary>
		''' Clean up any resources being used.
		''' </summary>
		''' <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
		Protected Overrides Sub Dispose(ByVal disposing As Boolean)
			If disposing AndAlso (components IsNot Nothing) Then
				components.Dispose()
			End If
			MyBase.Dispose(disposing)
		End Sub

		#Region "Windows Form Designer generated code"

		''' <summary>
		''' Required method for Designer support - do not modify
		''' the contents of this method with the code editor.
		''' </summary>
		Private Sub InitializeComponent()
			Dim resources As New System.ComponentModel.ComponentResourceManager(GetType(Form1))
			Me.gridControl1 = New DevExpress.XtraGrid.GridControl()
			Me.gridView1 = New DevExpress.XtraGrid.Views.Grid.GridView()
			Me.gridView2 = New DevExpress.XtraGrid.Views.Grid.GridView()
			Me.myUnboundGridHelper1 = New WindowsApplication1.MyUnboundGridHelper()
			Me.colColumn1 = New DevExpress.XtraGrid.Columns.GridColumn()
			Me.colColumn2 = New DevExpress.XtraGrid.Columns.GridColumn()
			Me.colColumn3 = New DevExpress.XtraGrid.Columns.GridColumn()
			Me.colColumn4 = New DevExpress.XtraGrid.Columns.GridColumn()
			Me.colColumn5 = New DevExpress.XtraGrid.Columns.GridColumn()
			Me.colColumn6 = New DevExpress.XtraGrid.Columns.GridColumn()
			Me.colColumn7 = New DevExpress.XtraGrid.Columns.GridColumn()
			CType(Me.gridControl1, System.ComponentModel.ISupportInitialize).BeginInit()
			CType(Me.gridView1, System.ComponentModel.ISupportInitialize).BeginInit()
			CType(Me.gridView2, System.ComponentModel.ISupportInitialize).BeginInit()
			CType(Me.myUnboundGridHelper1.GridData, System.ComponentModel.ISupportInitialize).BeginInit()
			Me.SuspendLayout()
			' 
			' gridControl1
			' 
			Me.gridControl1.Dock = System.Windows.Forms.DockStyle.Fill
			Me.gridControl1.Location = New System.Drawing.Point(0, 0)
			Me.gridControl1.MainView = Me.gridView1
			Me.gridControl1.Name = "gridControl1"
			Me.gridControl1.Size = New System.Drawing.Size(548, 454)
			Me.gridControl1.TabIndex = 0
			Me.gridControl1.ViewCollection.AddRange(New DevExpress.XtraGrid.Views.Base.BaseView() { Me.gridView1, Me.gridView2})
			' 
			' gridView1
			' 
			Me.gridView1.Columns.AddRange(New DevExpress.XtraGrid.Columns.GridColumn() { Me.colColumn1, Me.colColumn2, Me.colColumn3, Me.colColumn4, Me.colColumn5, Me.colColumn6, Me.colColumn7})
			Me.gridView1.GridControl = Me.gridControl1
			Me.gridView1.Name = "gridView1"
			' 
			' gridView2
			' 
			Me.gridView2.GridControl = Me.gridControl1
			Me.gridView2.Name = "gridView2"
			' 
			' myUnboundGridHelper1
			' 
			' 
			' 
			' 
			Me.myUnboundGridHelper1.GridData.Namespace = ""
			Me.myUnboundGridHelper1.GridData.TableName = "Table1"
			Me.myUnboundGridHelper1.SelectedGridControl = Me.gridControl1
			' 
			' colColumn1
			' 
			Me.colColumn1.FieldName = "Column1"
			Me.colColumn1.Name = "colColumn1"
			Me.colColumn1.Visible = True
			Me.colColumn1.VisibleIndex = 0
			' 
			' colColumn2
			' 
			Me.colColumn2.FieldName = "Column2"
			Me.colColumn2.Name = "colColumn2"
			Me.colColumn2.Visible = True
			Me.colColumn2.VisibleIndex = 1
			' 
			' colColumn3
			' 
			Me.colColumn3.FieldName = "Column3"
			Me.colColumn3.Name = "colColumn3"
			Me.colColumn3.Visible = True
			Me.colColumn3.VisibleIndex = 2
			' 
			' colColumn4
			' 
			Me.colColumn4.FieldName = "Column4"
			Me.colColumn4.Name = "colColumn4"
			Me.colColumn4.Visible = True
			Me.colColumn4.VisibleIndex = 3
			' 
			' colColumn5
			' 
			Me.colColumn5.FieldName = "Column5"
			Me.colColumn5.Name = "colColumn5"
			Me.colColumn5.Visible = True
			Me.colColumn5.VisibleIndex = 4
			' 
			' colColumn6
			' 
			Me.colColumn6.FieldName = "Column6"
			Me.colColumn6.Name = "colColumn6"
			Me.colColumn6.Visible = True
			Me.colColumn6.VisibleIndex = 5
			' 
			' colColumn7
			' 
			Me.colColumn7.FieldName = "Column7"
			Me.colColumn7.Name = "colColumn7"
			Me.colColumn7.Visible = True
			Me.colColumn7.VisibleIndex = 6
			' 
			' Form1
			' 
			Me.AutoScaleDimensions = New System.Drawing.SizeF(6F, 13F)
			Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
			Me.ClientSize = New System.Drawing.Size(548, 454)
			Me.Controls.Add(Me.gridControl1)
			Me.Name = "Form1"
			Me.Text = "Form1"
			CType(Me.gridControl1, System.ComponentModel.ISupportInitialize).EndInit()
			CType(Me.gridView1, System.ComponentModel.ISupportInitialize).EndInit()
			CType(Me.gridView2, System.ComponentModel.ISupportInitialize).EndInit()
			CType(Me.myUnboundGridHelper1.GridData, System.ComponentModel.ISupportInitialize).EndInit()
			Me.ResumeLayout(False)

		End Sub

		#End Region

		Private gridControl1 As DevExpress.XtraGrid.GridControl
		Private gridView1 As DevExpress.XtraGrid.Views.Grid.GridView
		Private gridView2 As DevExpress.XtraGrid.Views.Grid.GridView
		Private myUnboundGridHelper1 As MyUnboundGridHelper
		Private colColumn1 As DevExpress.XtraGrid.Columns.GridColumn
		Private colColumn2 As DevExpress.XtraGrid.Columns.GridColumn
		Private colColumn3 As DevExpress.XtraGrid.Columns.GridColumn
		Private colColumn4 As DevExpress.XtraGrid.Columns.GridColumn
		Private colColumn5 As DevExpress.XtraGrid.Columns.GridColumn
		Private colColumn6 As DevExpress.XtraGrid.Columns.GridColumn
		Private colColumn7 As DevExpress.XtraGrid.Columns.GridColumn
	End Class
End Namespace

