using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Biz;

namespace PenkoCourseWork
{
    public partial class MainGame : Form
    {
        int money;
        int Money
        {
            get { return money; }
            set
            {
                money = value;
                if (money < 0)
                    money = 0;
                money_quantity.Text = money.ToString();
            }
        }
        Buisness[] buisnesses;

        public MainGame()
        {
            InitializeComponent();
            Money = 2000000;

            Creator[] buisCreators = { new EateryCreator(), new RestaurantCreator(), new CasinoCreator() };
            buisnesses = new Buisness[buisCreators.Length];
            for (int i = 0; i < buisCreators.Length; i ++ )
            {
                buisnesses[i] = buisCreators[i].Create();
            }
        }

        private bool TryToOpenBuisness(int BizNumber)
        {
            if (Money >= buisnesses[BizNumber].OpenCost)
            {
                Money -= buisnesses[BizNumber].OpenCost;
                MessageBox.Show(buisnesses[BizNumber].Open());
                UpdateAllLabels();
                return true;
            }
            return false;
        }

        private void Btn_OpenBurgery_Click(object sender, EventArgs e)
        {
            if (TryToOpenBuisness(0))
            {
                burgeryTableLayoutPanel.Show();
                Btn_OpenBurgery.Hide();
            }
        }

        private void Btn_OpenRestaurant_Click(object sender, EventArgs e)
        {
            if (TryToOpenBuisness(1))
            {
                restaurantTableLayoutPanel.Show();
                Btn_OpenRestaurant.Hide();
            }
        }

        private void Btn_OpenCasino_Click(object sender, EventArgs e)
        {
            if (TryToOpenBuisness(2))
            {
                casinoTableLayoutPanel.Show();
                Btn_OpenCasino.Hide();
            }
        }

        private void MainGame_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }

        private bool TryToUpgradeBuisness(int BizNumber)
        {
            if (Money >= buisnesses[BizNumber].UpgradeCost)
            {
                Money -= buisnesses[BizNumber].UpgradeCost;
                MessageBox.Show(buisnesses[BizNumber].Upgrade());
                UpdateAllLabels();
                return true;
            }
            return false;
        }

        private void Btn_UpgradeBurgery_Click(object sender, EventArgs e)
        {
            if (TryToUpgradeBuisness(0))
                Btn_UpgradeBurgery.Hide();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (TryToUpgradeBuisness(1))
                button1.Hide();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            if (TryToUpgradeBuisness(2))
                button3.Hide();
        }

        private void Btn_Burger_Click(object sender, EventArgs e)
        {
            Money += buisnesses[0].ClickGain;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Money += buisnesses[1].ClickGain;
        }

        private void button4_Click(object sender, EventArgs e)
        {
            Money += buisnesses[2].ClickGain;
        }

        private bool TryToManage(int BizNumber)
        {
            if (Money >= buisnesses[BizNumber].ManageCost)
            {
                Money -= buisnesses[BizNumber].ManageCost;
                MessageBox.Show(buisnesses[BizNumber].Manage());
                UpdateAllLabels();
                return true;
            }
            return false;
        }

        private void Btn_OrderManagerBurgery_Click(object sender, EventArgs e)
        {
            if (TryToManage(0))
                Btn_OrderManagerBurgery.Hide();
        }

        private void Btn_OrderManagerRestaurant_Click(object sender, EventArgs e)
        {
            if (TryToManage(1))
                Btn_OrderManagerRestaurant.Hide();
        }

        private void Btn_OrderManagerCasino_Click(object sender, EventArgs e)
        {
            if (TryToManage(2))
                Btn_OrderManagerCasino.Hide();
        }

        private void UpdateAllLabels()
        {
            String upgText = "Улучшить за ";
            String forClickText = " $ за клик";
            String levelText = "Уровень заведения ";
            Btn_UpgradeBurgery.Text = upgText + buisnesses[0].UpgradeCost + "$";
            button1.Text = upgText + buisnesses[1].UpgradeCost + "$";
            button3.Text = upgText + buisnesses[2].UpgradeCost + "$";
            BurgeryMoney_per_click.Text = buisnesses[0].ClickGain + forClickText;
            RestaurantMoney_per_click.Text = buisnesses[1].ClickGain + forClickText;
            CasinoMoney_per_click.Text = buisnesses[2].ClickGain + forClickText;
            Burgery_lvl.Text = buisnesses[0].BuisLevel + levelText;
            Restaurant_lvl.Text = buisnesses[1].BuisLevel + levelText;
            Casino_lvl.Text = buisnesses[2].BuisLevel + levelText;
        }
    }
}
