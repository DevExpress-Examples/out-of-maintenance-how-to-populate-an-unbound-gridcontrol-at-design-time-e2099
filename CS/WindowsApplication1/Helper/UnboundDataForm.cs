using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace WindowsApplication1.Helper
{
    public partial class UnboundDataForm : Form
    {
        private MyUnboundGridHelper _Helper;
        public MyUnboundGridHelper Helper
        {
            get { return _Helper; }
            set { _Helper = value; HelperChanged(); }
        }

        public UnboundDataForm(MyUnboundGridHelper helper)
        {
            InitializeComponent();
            Helper = helper;
        }

        private void HelperChanged()
        {
            propertyGrid1.SelectedObject = Helper.GridData;
            dataGridView1.DataSource = Helper.GridData;
            dataNavigator1.DataSource = Helper.GridData;
        }
    }
}