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
    public partial class ucBalance : UserControl
    {
        List<Button> MainButtons;
        List<Button> SubTypesButtons;

        public ucBalance()
        {
            InitializeComponent();
            MainButtons = new List<Button>() { ProductsButton, LiveButton, SceneButton, GlobalButton};
            GetButtonType(ProductsButton, true);
        }

        private void GetButtonType(Button button, bool main)
        {
            List<Button> list = new List<Button>();
            int y;
            if(main)
            {
                list = MainButtons;
                y = 5;
            }
            else
            {
                list = SubTypesButtons;
                y = 40;
            }

            button.BackColor = Color.DarkGray;
            button.Size = new Size(button.Size.Width, 29);
            button.Location = new Point(button.Location.X, y - 3);
            foreach (var c in list)
            {
                if (c != button)
                {
                    c.BackColor = Color.LightGray;
                    c.Size = new Size(c.Size.Width, 23);
                    c.Location = new Point(c.Location.X, y);
                }
            }
        }
        private void SubButtonsClick(object sender, EventArgs e)
        {
            GetButtonType((Button)sender, false);
        }

        //главные кнопки
        private void ProductsButton_Click(object sender, EventArgs e)
        {
            GetButtonType((Button)sender, true);
            GetProducts();
        }
        private void LiveButton_Click(object sender, EventArgs e)
        {
            GetButtonType((Button)sender, true);
        }
        private void SceneButton_Click(object sender, EventArgs e)
        {
            GetButtonType((Button)sender, true);
        }
        private void GlobalButton_Click(object sender, EventArgs e)
        {
            GetButtonType((Button)sender, true);
        }

        public void GetProducts()
        {
            Button NodesButton = new Button
            {
                Text = "Узлы",
                Size = new Size(95, 23)
            };
            Button BuildingsButton = new Button
            {
                Text = "Строения",
                Size = new Size(100, 23)
            };
            Button AutoButton = new Button
            {
                Text = "АвтоТехника",
                Size = new Size(115, 23)
            };
            Button ModulesButton = new Button
            {
                Text = "Модули",
                Size = new Size(95, 23)
            };
            Button ConsumablesButton = new Button
            {
                Text = "Расходники",
                Size = new Size(95, 23)
            };

            SubTypesButtons = new List<Button>() { NodesButton, BuildingsButton, AutoButton, ModulesButton, ConsumablesButton };
            int offset = 5;
            foreach (var c in SubTypesButtons)
            {
                BalancedSplitContainer.Panel1.Controls.Add(c);
                c.Location = new Point(offset, 40);
                offset += c.Size.Width + 5;
                c.Click += SubButtonsClick;
            }
            GetButtonType(NodesButton, false);
        }

    }
}
