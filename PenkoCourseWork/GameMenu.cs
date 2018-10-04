using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PenkoCourseWork
{
    public partial class GameMenu : Form
    {
        public GameMenu()
        {
            InitializeComponent();
        }

        private void Start_Click(object sender, EventArgs e)
        {
            MainGame mainGame = new MainGame();
            this.Hide();
            mainGame.Show();
        }

        private void Help_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Игра-кликер 'Симулятор бизнесмена'\n" +
            "Задача игрока набрать как можно больше денег, нажимая ЛКМ. Чем больше денег тем лучше.\nНо лучше всего набрать тупа 1400 чтобы купить себе пенёк.");
        }

        private void Exit_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
