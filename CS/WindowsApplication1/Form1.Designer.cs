namespace WindowsApplication1
{
    partial class Form1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.gridControl1 = new DevExpress.XtraGrid.GridControl();
            this.gridView1 = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.gridView2 = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.myUnboundGridHelper1 = new WindowsApplication1.MyUnboundGridHelper();
            this.colColumn1 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colColumn2 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colColumn3 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colColumn4 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colColumn5 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colColumn6 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colColumn7 = new DevExpress.XtraGrid.Columns.GridColumn();
            ((System.ComponentModel.ISupportInitialize)(this.gridControl1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.myUnboundGridHelper1.GridData)).BeginInit();
            this.SuspendLayout();
            // 
            // gridControl1
            // 
            this.gridControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gridControl1.Location = new System.Drawing.Point(0, 0);
            this.gridControl1.MainView = this.gridView1;
            this.gridControl1.Name = "gridControl1";
            this.gridControl1.Size = new System.Drawing.Size(548, 454);
            this.gridControl1.TabIndex = 0;
            this.gridControl1.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridView1,
            this.gridView2});
            // 
            // gridView1
            // 
            this.gridView1.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.colColumn1,
            this.colColumn2,
            this.colColumn3,
            this.colColumn4,
            this.colColumn5,
            this.colColumn6,
            this.colColumn7});
            this.gridView1.GridControl = this.gridControl1;
            this.gridView1.Name = "gridView1";
            // 
            // gridView2
            // 
            this.gridView2.GridControl = this.gridControl1;
            this.gridView2.Name = "gridView2";
            // 
            // myUnboundGridHelper1
            // 
            // 
            // 
            // 
            this.myUnboundGridHelper1.GridData.Namespace = "";
            this.myUnboundGridHelper1.GridData.TableName = "Table1";
            this.myUnboundGridHelper1.SelectedGridControl = this.gridControl1;
            // 
            // colColumn1
            // 
            this.colColumn1.FieldName = "Column1";
            this.colColumn1.Name = "colColumn1";
            this.colColumn1.Visible = true;
            this.colColumn1.VisibleIndex = 0;
            // 
            // colColumn2
            // 
            this.colColumn2.FieldName = "Column2";
            this.colColumn2.Name = "colColumn2";
            this.colColumn2.Visible = true;
            this.colColumn2.VisibleIndex = 1;
            // 
            // colColumn3
            // 
            this.colColumn3.FieldName = "Column3";
            this.colColumn3.Name = "colColumn3";
            this.colColumn3.Visible = true;
            this.colColumn3.VisibleIndex = 2;
            // 
            // colColumn4
            // 
            this.colColumn4.FieldName = "Column4";
            this.colColumn4.Name = "colColumn4";
            this.colColumn4.Visible = true;
            this.colColumn4.VisibleIndex = 3;
            // 
            // colColumn5
            // 
            this.colColumn5.FieldName = "Column5";
            this.colColumn5.Name = "colColumn5";
            this.colColumn5.Visible = true;
            this.colColumn5.VisibleIndex = 4;
            // 
            // colColumn6
            // 
            this.colColumn6.FieldName = "Column6";
            this.colColumn6.Name = "colColumn6";
            this.colColumn6.Visible = true;
            this.colColumn6.VisibleIndex = 5;
            // 
            // colColumn7
            // 
            this.colColumn7.FieldName = "Column7";
            this.colColumn7.Name = "colColumn7";
            this.colColumn7.Visible = true;
            this.colColumn7.VisibleIndex = 6;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(548, 454);
            this.Controls.Add(this.gridControl1);
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.gridControl1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.myUnboundGridHelper1.GridData)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraGrid.GridControl gridControl1;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView1;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView2;
        private MyUnboundGridHelper myUnboundGridHelper1;
        private DevExpress.XtraGrid.Columns.GridColumn colColumn1;
        private DevExpress.XtraGrid.Columns.GridColumn colColumn2;
        private DevExpress.XtraGrid.Columns.GridColumn colColumn3;
        private DevExpress.XtraGrid.Columns.GridColumn colColumn4;
        private DevExpress.XtraGrid.Columns.GridColumn colColumn5;
        private DevExpress.XtraGrid.Columns.GridColumn colColumn6;
        private DevExpress.XtraGrid.Columns.GridColumn colColumn7;
    }
}

