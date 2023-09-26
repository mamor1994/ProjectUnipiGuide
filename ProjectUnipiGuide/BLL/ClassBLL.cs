using ProjectUnipiGuide.BLL;
using System;
using System.Collections.Generic;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using ProjectUnipiGuide.DAL;

namespace ProjectUnipiGuide.BLL
{
    class ClassBLL
    {
        public bool SaveItems(Image img, string title, string subtitle)
        {
            try
            {
                ClassDAL objdal = new ClassDAL();
                return objdal.AddItemsToTable(img, title, subtitle);
            }
            catch(Exception e)
            {
                DialogResult result = MessageBox.Show(e.Message, ToString());
                return false;
            }
        }

        public DataTable GetItems()
        {
            try
            {
                ClassDAL objdal = new ClassDAL();
                return objdal.ReadItemsTable();
            }
            catch(Exception e)
            {
                DialogResult result = MessageBox.Show(e.Message.ToString());
                return null;
            }
        }
    }
}
