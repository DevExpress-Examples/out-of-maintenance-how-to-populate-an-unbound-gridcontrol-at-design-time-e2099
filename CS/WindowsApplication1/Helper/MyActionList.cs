using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using System.ComponentModel.Design;
using WindowsApplication1.Helper;

namespace WindowsApplication1
{
    public class MyActionList : DesignerActionList
    {
        
   
        public MyUnboundGridHelper Helper
        {
            get
            {
                return Component as MyUnboundGridHelper;
            }
        }

        public MyActionList(IComponent component)
            : base(component)
        {
        }

        public override DesignerActionItemCollection GetSortedActionItems()
        {
            DesignerActionItemCollection items = new DesignerActionItemCollection();
            items.Add(new DesignerActionMethodItem(this,
                                                   "ShowDesigner", "Add unbound data",
                                                   "Data management", "Add unbound data", true));
            return items;
        }


        private void ShowDesigner()
        {
            Helper.ShowDesigner();
        }
    }
}
