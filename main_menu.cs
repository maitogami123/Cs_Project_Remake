using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Imaging;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using ComponentFactory.Krypton.Toolkit;

namespace MyFuckingProject.GUI
{
    public partial class main_menu : KryptonForm
    {
        private Color active = Color.FromArgb(252, 252, 252);
        private Color inactive = Color.FromArgb(241, 241, 241);
        Home_Form homeForm = new Home_Form();
        Account_Form accountForm = new Account_Form();
        Statistic_Form statisticForm = new Statistic_Form();
        Products_Form productsForm = new Products_Form();
        Table_Form tableForm = new Table_Form();
        Discount_Form discountForm = new Discount_Form();

        public main_menu()
        {
            InitializeComponent();
            setBtnState(HomeBtn, active);
            handleChangeForm(homeForm);
        }

        private void setBtnState(KryptonButton button, Color color)
        {
            button.OverrideDefault.Back.Color1 = color;
            button.OverrideDefault.Back.Color2 = color;
            button.OverrideDefault.Border.Color1 = color;
            button.StateCommon.Back.Color1 = color;
            button.StateCommon.Back.Color2 = color;
            button.StateCommon.Border.Color1 = color;
        }

        private void handleSetTabState(KryptonButton button)
        {
            KryptonButton[] kryptonButtons = { HomeBtn, AccountBtn, StatisticBtn, 
                ProductsBtn, TableInfoBtn, DiscountBtn };
            foreach(KryptonButton kryptonButton in kryptonButtons)
            {
                if (kryptonButton.Text.Equals(button.Text)) {
                    setBtnState(kryptonButton, active);
                } else
                {
                    setBtnState(kryptonButton, inactive);
                }
            }
        }

        private void handleChangeForm(KryptonForm activeForm)
        {
            foreach (KryptonForm form in panel9.Controls)
            {
                panel9.Controls.Remove(form);
            }
            activeForm.TopLevel = false;
            activeForm.AutoScroll = true;
            activeForm.FormBorderStyle = FormBorderStyle.None;
            panel9.Controls.Add(activeForm);
            activeForm.Show();
        }

        private void HomeBtn_Click(object sender, EventArgs e)
        {
            handleSetTabState(HomeBtn);
            handleChangeForm(homeForm);
        }

        private void AccountBtn_Click(object sender, EventArgs e)
        {
            handleSetTabState(AccountBtn);
            handleChangeForm(accountForm);
        }

        private void StatisticBtn_Click(object sender, EventArgs e)
        {
            handleSetTabState(StatisticBtn);
            handleChangeForm(statisticForm);
        }

        private void ProductsBtn_Click(object sender, EventArgs e)
        {
            handleSetTabState(ProductsBtn);
            handleChangeForm(productsForm);
        }

        private void TableInfoBtn_Click(object sender, EventArgs e)
        {
            handleSetTabState(TableInfoBtn);
            handleChangeForm(tableForm);
        }

        private void DiscountBtn_Click(object sender, EventArgs e)
        {
            handleSetTabState(DiscountBtn);
            handleChangeForm(discountForm);
        }
    }
}
