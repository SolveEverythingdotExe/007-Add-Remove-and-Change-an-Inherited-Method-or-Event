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
    //it inherits our parent form
    public partial class ChildForm : ParentForm
    {
        public ChildForm()
        {
            InitializeComponent();
        }

        //now lets override the method
        protected override void OnNew()
        {
            //we can also just add a code to the existing one
            base.OnNew();

            //lets add a new code to execute
            MessageBox.Show("Show a new work from child form!");
        }

        //lets test
    }
}
