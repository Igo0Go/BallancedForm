using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BalancedForm
{
    public partial class ucRemoveButton : UserControl
    {
        public int objectNumber;
        public ucCost container;

        public ucRemoveButton()
        {
            InitializeComponent();
        }

        public ucRemoveButton(int number, ucCost cont)
        {
            InitializeComponent();
            objectNumber = number;
            container = cont;
        }

        private void RemoveRareButton_Click(object sender, EventArgs e)
        {
            container.RemoveBox(objectNumber, this);
        }
    }
}
