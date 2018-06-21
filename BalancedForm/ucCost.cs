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
    public partial class ucCost : UserControl
    {
        public int xLocation;
        public int rareStep;
        public List<ComboBox> rares;
        public List<ucRemoveButton> removeButtons;

        public ucCost()
        {
            rares = new List<ComboBox>();
            removeButtons = new List<ucRemoveButton>();
            InitializeComponent();
            xLocation = 10;
            rareStep = 100;
        }


        private void AddRareButton_Click(object sender, EventArgs e)
        {
            AddNewRare();
        }

        public void AddNewRare()
        {
            ComboBox rare = new ComboBox();
            rare.Items.Add("Редкое1");
            rare.Items.Add("Редкое2");
            rare.Items.Add("Редкое3");
            RarePanel.Controls.Add(rare);
            rare.Size = new Size(70, 30);
            rare.Location = new Point(xLocation, 5);
            xLocation += rareStep;
            rares.Add(rare);
            ucRemoveButton button = new ucRemoveButton(rares.Count - 1, this);
            RarePanel.Controls.Add(button);
            button.Location = new Point(rares[button.objectNumber].Location.X + 73, 3);
            removeButtons.Add(button);
        }

        public void RemoveBox(int number, ucRemoveButton button)
        {
            ComboBox cb = rares[number];
            rares.Remove(rares[number]);
            removeButtons.Remove(removeButtons[number]);
            RarePanel.Controls.Remove(cb);
            RarePanel.Controls.Remove(button);
            for (int i = number; i < rares.Count; i++)
            {
                rares[i].Location = new Point(rares[i].Location.X - rareStep, 5);
                removeButtons[i].Location = new Point(rares[i].Location.X + 73, 3);
                removeButtons[i].objectNumber -= 1;
            }
            xLocation -= rareStep;
        }
    }
}
