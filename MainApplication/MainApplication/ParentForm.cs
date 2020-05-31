using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MainApplication
{
    public partial class ParentForm : Form
    {
        public ParentForm()
        {
            InitializeComponent();
        }

        private void btnNew_Click(object sender, EventArgs e)
        {
            //execute the method
            OnNew();
        }

        //an overrideable method, using the virtual keyword
        protected virtual void OnNew()
        {
            MessageBox.Show("Showing some work!");
        }
    }
}
