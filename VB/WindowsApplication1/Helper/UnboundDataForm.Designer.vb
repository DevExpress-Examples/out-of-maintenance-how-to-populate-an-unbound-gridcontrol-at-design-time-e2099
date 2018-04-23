Imports Microsoft.VisualBasic
Imports System
Namespace WindowsApplication1.Helper
	Partial Public Class UnboundDataForm
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
			Me.propertyGrid1 = New System.Windows.Forms.PropertyGrid()
			Me.dataGridView1 = New System.Windows.Forms.DataGridView()
			Me.dataNavigator1 = New DevExpress.XtraEditors.DataNavigator()
			Me.panelControl1 = New DevExpress.XtraEditors.PanelControl()
			Me.simpleButton1 = New DevExpress.XtraEditors.SimpleButton()
			CType(Me.dataGridView1, System.ComponentModel.ISupportInitialize).BeginInit()
			CType(Me.panelControl1, System.ComponentModel.ISupportInitialize).BeginInit()
			Me.panelControl1.SuspendLayout()
			Me.SuspendLayout()
			' 
			' propertyGrid1
			' 
			Me.propertyGrid1.Dock = System.Windows.Forms.DockStyle.Left
			Me.propertyGrid1.Location = New System.Drawing.Point(0, 0)
			Me.propertyGrid1.Name = "propertyGrid1"
			Me.propertyGrid1.Size = New System.Drawing.Size(200, 343)
			Me.propertyGrid1.TabIndex = 0
			' 
			' dataGridView1
			' 
			Me.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
			Me.dataGridView1.Dock = System.Windows.Forms.DockStyle.Fill
			Me.dataGridView1.Location = New System.Drawing.Point(200, 0)
			Me.dataGridView1.Name = "dataGridView1"
			Me.dataGridView1.Size = New System.Drawing.Size(352, 319)
			Me.dataGridView1.TabIndex = 1
			' 
			' dataNavigator1
			' 
			Me.dataNavigator1.Dock = System.Windows.Forms.DockStyle.Bottom
			Me.dataNavigator1.Location = New System.Drawing.Point(200, 319)
			Me.dataNavigator1.Name = "dataNavigator1"
			Me.dataNavigator1.Size = New System.Drawing.Size(352, 24)
			Me.dataNavigator1.TabIndex = 2
			Me.dataNavigator1.Text = "dataNavigator1"
			' 
			' panelControl1
			' 
			Me.panelControl1.Controls.Add(Me.simpleButton1)
			Me.panelControl1.Dock = System.Windows.Forms.DockStyle.Bottom
			Me.panelControl1.Location = New System.Drawing.Point(0, 343)
			Me.panelControl1.Name = "panelControl1"
			Me.panelControl1.Size = New System.Drawing.Size(552, 48)
			Me.panelControl1.TabIndex = 3
			' 
			' simpleButton1
			' 
			Me.simpleButton1.DialogResult = System.Windows.Forms.DialogResult.OK
			Me.simpleButton1.Location = New System.Drawing.Point(472, 6)
			Me.simpleButton1.Name = "simpleButton1"
			Me.simpleButton1.Size = New System.Drawing.Size(75, 23)
			Me.simpleButton1.TabIndex = 0
			Me.simpleButton1.Text = "OK"
			' 
			' UnboundDataForm
			' 
			Me.AutoScaleDimensions = New System.Drawing.SizeF(6F, 13F)
			Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
			Me.ClientSize = New System.Drawing.Size(552, 391)
			Me.Controls.Add(Me.dataGridView1)
			Me.Controls.Add(Me.dataNavigator1)
			Me.Controls.Add(Me.propertyGrid1)
			Me.Controls.Add(Me.panelControl1)
			Me.Name = "UnboundDataForm"
			Me.Text = "frmUnboundData"
			CType(Me.dataGridView1, System.ComponentModel.ISupportInitialize).EndInit()
			CType(Me.panelControl1, System.ComponentModel.ISupportInitialize).EndInit()
			Me.panelControl1.ResumeLayout(False)
			Me.ResumeLayout(False)

		End Sub

		#End Region

		Private propertyGrid1 As System.Windows.Forms.PropertyGrid
		Private dataGridView1 As System.Windows.Forms.DataGridView
		Private dataNavigator1 As DevExpress.XtraEditors.DataNavigator
		Private panelControl1 As DevExpress.XtraEditors.PanelControl
		Private simpleButton1 As DevExpress.XtraEditors.SimpleButton
	End Class
End Namespace