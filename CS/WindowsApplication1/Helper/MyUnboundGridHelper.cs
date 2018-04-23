using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using DevExpress.XtraGrid.Views.Grid;
using DevExpress.XtraGrid;
using System.IO;
using DevExpress.XtraLayout.Resizing;
using WindowsApplication1.Helper;

namespace WindowsApplication1
{
    [Designer(typeof(MyDesigner))]
    public class MyUnboundGridHelper : Component
    {

        public MyUnboundGridHelper()
        {

        }

        private GridControl _SelectedGridControl;
        public GridControl SelectedGridControl
        {
            get { return _SelectedGridControl; }
            set { _SelectedGridControl = value; OnSelectedGridControlChanged(); }
        }

        private void OnSelectedGridControlChanged()
        {
            if (SelectedGridControl != null)
                SelectedGridControl.DataSource = GridData;
        }

        private DataTable _GridData;

        [DesignerSerializationVisibility(DesignerSerializationVisibility.Content)]
        public DataTable GridData
        {
            get
            {
                if
              (_GridData == null) _GridData = new DataTable();
                    if (File.Exists(Constants.XmlFileName))
                    {
                        _GridData.Clear();
                        _GridData.ReadXmlSchema(Constants.SchemaName);
                        _GridData.ReadXml(Constants.XmlFileName);
                    }
                return _GridData;
            }
            set { _GridData = value;}
        }

        public void ShowDesigner()
        {
            new UnboundDataForm(this).ShowDialog();
            File.Delete(Constants.XmlFileName);
            GridData.WriteXmlSchema(Constants.SchemaName);
            GridData.WriteXml(Constants.XmlFileName);
            SelectedGridControl.MainView.PopulateColumns();
        }

    }

}