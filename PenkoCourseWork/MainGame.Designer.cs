namespace PenkoCourseWork
{
    partial class MainGame
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.Money_lb = new System.Windows.Forms.Label();
            this.money_quantity = new System.Windows.Forms.Label();
            this.burgeryTableLayoutPanel = new System.Windows.Forms.TableLayoutPanel();
            this.Btn_UpgradeBurgery = new System.Windows.Forms.Button();
            this.Btn_Burger = new System.Windows.Forms.Button();
            this.BurgeryMoney_per_click = new System.Windows.Forms.Label();
            this.Burgery_lvl = new System.Windows.Forms.Label();
            this.Btn_OrderManagerBurgery = new System.Windows.Forms.Button();
            this.Burgery_Lb = new System.Windows.Forms.Label();
            this.Btn_OpenBurgery = new System.Windows.Forms.Button();
            this.restaurantTableLayoutPanel = new System.Windows.Forms.TableLayoutPanel();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.Btn_OrderManagerRestaurant = new System.Windows.Forms.Button();
            this.Restaurant_lvl = new System.Windows.Forms.Label();
            this.RestaurantMoney_per_click = new System.Windows.Forms.Label();
            this.casinoTableLayoutPanel = new System.Windows.Forms.TableLayoutPanel();
            this.Btn_OrderManagerCasino = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            this.Casino_lvl = new System.Windows.Forms.Label();
            this.CasinoMoney_per_click = new System.Windows.Forms.Label();
            this.RestaurantLabel = new System.Windows.Forms.Label();
            this.CasinoLabel = new System.Windows.Forms.Label();
            this.Btn_OpenRestaurant = new System.Windows.Forms.Button();
            this.Btn_OpenCasino = new System.Windows.Forms.Button();
            this.burgeryTableLayoutPanel.SuspendLayout();
            this.restaurantTableLayoutPanel.SuspendLayout();
            this.casinoTableLayoutPanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // Money_lb
            // 
            this.Money_lb.BackColor = System.Drawing.Color.YellowGreen;
            this.Money_lb.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Money_lb.Location = new System.Drawing.Point(12, 9);
            this.Money_lb.Name = "Money_lb";
            this.Money_lb.Size = new System.Drawing.Size(136, 63);
            this.Money_lb.TabIndex = 0;
            this.Money_lb.Text = "Деньги:";
            this.Money_lb.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // money_quantity
            // 
            this.money_quantity.BackColor = System.Drawing.Color.YellowGreen;
            this.money_quantity.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.money_quantity.Location = new System.Drawing.Point(168, 9);
            this.money_quantity.Name = "money_quantity";
            this.money_quantity.Size = new System.Drawing.Size(1187, 63);
            this.money_quantity.TabIndex = 1;
            this.money_quantity.Text = "0";
            this.money_quantity.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // burgeryTableLayoutPanel
            // 
            this.burgeryTableLayoutPanel.BackColor = System.Drawing.Color.LimeGreen;
            this.burgeryTableLayoutPanel.ColumnCount = 3;
            this.burgeryTableLayoutPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 18F));
            this.burgeryTableLayoutPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 52F));
            this.burgeryTableLayoutPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 30F));
            this.burgeryTableLayoutPanel.Controls.Add(this.Btn_UpgradeBurgery, 0, 0);
            this.burgeryTableLayoutPanel.Controls.Add(this.Btn_Burger, 0, 1);
            this.burgeryTableLayoutPanel.Controls.Add(this.BurgeryMoney_per_click, 1, 1);
            this.burgeryTableLayoutPanel.Controls.Add(this.Burgery_lvl, 1, 0);
            this.burgeryTableLayoutPanel.Controls.Add(this.Btn_OrderManagerBurgery, 2, 0);
            this.burgeryTableLayoutPanel.Location = new System.Drawing.Point(12, 169);
            this.burgeryTableLayoutPanel.Name = "burgeryTableLayoutPanel";
            this.burgeryTableLayoutPanel.RowCount = 2;
            this.burgeryTableLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 22.02643F));
            this.burgeryTableLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 77.97357F));
            this.burgeryTableLayoutPanel.Size = new System.Drawing.Size(1167, 188);
            this.burgeryTableLayoutPanel.TabIndex = 2;
            this.burgeryTableLayoutPanel.Visible = false;
            // 
            // Btn_UpgradeBurgery
            // 
            this.Btn_UpgradeBurgery.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Btn_UpgradeBurgery.Location = new System.Drawing.Point(3, 3);
            this.Btn_UpgradeBurgery.Name = "Btn_UpgradeBurgery";
            this.Btn_UpgradeBurgery.Size = new System.Drawing.Size(204, 35);
            this.Btn_UpgradeBurgery.TabIndex = 0;
            this.Btn_UpgradeBurgery.Text = "Улучшить за 2500 $";
            this.Btn_UpgradeBurgery.UseVisualStyleBackColor = true;
            this.Btn_UpgradeBurgery.Click += new System.EventHandler(this.Btn_UpgradeBurgery_Click);
            // 
            // Btn_Burger
            // 
            this.Btn_Burger.BackgroundImage = global::PenkoCourseWork.Properties.Resources.burger;
            this.Btn_Burger.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.Btn_Burger.Cursor = System.Windows.Forms.Cursors.Default;
            this.Btn_Burger.Location = new System.Drawing.Point(3, 44);
            this.Btn_Burger.Name = "Btn_Burger";
            this.Btn_Burger.Size = new System.Drawing.Size(204, 141);
            this.Btn_Burger.TabIndex = 1;
            this.Btn_Burger.UseVisualStyleBackColor = true;
            this.Btn_Burger.Click += new System.EventHandler(this.Btn_Burger_Click);
            // 
            // BurgeryMoney_per_click
            // 
            this.BurgeryMoney_per_click.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.BurgeryMoney_per_click.Location = new System.Drawing.Point(213, 41);
            this.BurgeryMoney_per_click.Name = "BurgeryMoney_per_click";
            this.BurgeryMoney_per_click.Size = new System.Drawing.Size(600, 147);
            this.BurgeryMoney_per_click.TabIndex = 2;
            this.BurgeryMoney_per_click.Text = "5000 $ за клик";
            this.BurgeryMoney_per_click.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // Burgery_lvl
            // 
            this.Burgery_lvl.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Burgery_lvl.Location = new System.Drawing.Point(213, 0);
            this.Burgery_lvl.Name = "Burgery_lvl";
            this.Burgery_lvl.Size = new System.Drawing.Size(600, 41);
            this.Burgery_lvl.TabIndex = 3;
            this.Burgery_lvl.Text = "Уровень заведения 0";
            this.Burgery_lvl.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // Btn_OrderManagerBurgery
            // 
            this.Btn_OrderManagerBurgery.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Btn_OrderManagerBurgery.Location = new System.Drawing.Point(819, 3);
            this.Btn_OrderManagerBurgery.Name = "Btn_OrderManagerBurgery";
            this.Btn_OrderManagerBurgery.Size = new System.Drawing.Size(345, 35);
            this.Btn_OrderManagerBurgery.TabIndex = 4;
            this.Btn_OrderManagerBurgery.Text = "Нанять менеджера за 2500 $";
            this.Btn_OrderManagerBurgery.UseVisualStyleBackColor = true;
            this.Btn_OrderManagerBurgery.Click += new System.EventHandler(this.Btn_OrderManagerBurgery_Click);
            // 
            // Burgery_Lb
            // 
            this.Burgery_Lb.BackColor = System.Drawing.Color.LimeGreen;
            this.Burgery_Lb.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Burgery_Lb.Location = new System.Drawing.Point(12, 85);
            this.Burgery_Lb.Name = "Burgery_Lb";
            this.Burgery_Lb.Size = new System.Drawing.Size(156, 54);
            this.Burgery_Lb.TabIndex = 3;
            this.Burgery_Lb.Text = "БУРГЕРНАЯ";
            this.Burgery_Lb.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // Btn_OpenBurgery
            // 
            this.Btn_OpenBurgery.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Btn_OpenBurgery.Location = new System.Drawing.Point(193, 85);
            this.Btn_OpenBurgery.Name = "Btn_OpenBurgery";
            this.Btn_OpenBurgery.Size = new System.Drawing.Size(237, 54);
            this.Btn_OpenBurgery.TabIndex = 0;
            this.Btn_OpenBurgery.Text = "Открыть за 5000 $";
            this.Btn_OpenBurgery.UseVisualStyleBackColor = true;
            this.Btn_OpenBurgery.Click += new System.EventHandler(this.Btn_OpenBurgery_Click);
            // 
            // restaurantTableLayoutPanel
            // 
            this.restaurantTableLayoutPanel.BackColor = System.Drawing.Color.MediumAquamarine;
            this.restaurantTableLayoutPanel.ColumnCount = 3;
            this.restaurantTableLayoutPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 18F));
            this.restaurantTableLayoutPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 52F));
            this.restaurantTableLayoutPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 30F));
            this.restaurantTableLayoutPanel.Controls.Add(this.button1, 0, 0);
            this.restaurantTableLayoutPanel.Controls.Add(this.button2, 0, 1);
            this.restaurantTableLayoutPanel.Controls.Add(this.Btn_OrderManagerRestaurant, 2, 0);
            this.restaurantTableLayoutPanel.Controls.Add(this.Restaurant_lvl, 1, 0);
            this.restaurantTableLayoutPanel.Controls.Add(this.RestaurantMoney_per_click, 1, 1);
            this.restaurantTableLayoutPanel.Location = new System.Drawing.Point(12, 432);
            this.restaurantTableLayoutPanel.Name = "restaurantTableLayoutPanel";
            this.restaurantTableLayoutPanel.RowCount = 2;
            this.restaurantTableLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 21.50943F));
            this.restaurantTableLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 78.49057F));
            this.restaurantTableLayoutPanel.Size = new System.Drawing.Size(1167, 210);
            this.restaurantTableLayoutPanel.TabIndex = 5;
            this.restaurantTableLayoutPanel.Visible = false;
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.button1.Location = new System.Drawing.Point(3, 3);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(204, 39);
            this.button1.TabIndex = 0;
            this.button1.Text = "Улучшить за 50000 $";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.BackgroundImage = global::PenkoCourseWork.Properties.Resources.restaurant;
            this.button2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.button2.Location = new System.Drawing.Point(3, 48);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(204, 159);
            this.button2.TabIndex = 1;
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // Btn_OrderManagerRestaurant
            // 
            this.Btn_OrderManagerRestaurant.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Btn_OrderManagerRestaurant.Location = new System.Drawing.Point(819, 3);
            this.Btn_OrderManagerRestaurant.Name = "Btn_OrderManagerRestaurant";
            this.Btn_OrderManagerRestaurant.Size = new System.Drawing.Size(345, 39);
            this.Btn_OrderManagerRestaurant.TabIndex = 10;
            this.Btn_OrderManagerRestaurant.Text = "Нанять менеджера за 50000 $";
            this.Btn_OrderManagerRestaurant.UseVisualStyleBackColor = true;
            this.Btn_OrderManagerRestaurant.Click += new System.EventHandler(this.Btn_OrderManagerRestaurant_Click);
            // 
            // Restaurant_lvl
            // 
            this.Restaurant_lvl.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Restaurant_lvl.Location = new System.Drawing.Point(213, 0);
            this.Restaurant_lvl.Name = "Restaurant_lvl";
            this.Restaurant_lvl.Size = new System.Drawing.Size(596, 45);
            this.Restaurant_lvl.TabIndex = 2;
            this.Restaurant_lvl.Text = "Уровень заведения 0";
            this.Restaurant_lvl.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // RestaurantMoney_per_click
            // 
            this.RestaurantMoney_per_click.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.RestaurantMoney_per_click.Location = new System.Drawing.Point(213, 45);
            this.RestaurantMoney_per_click.Name = "RestaurantMoney_per_click";
            this.RestaurantMoney_per_click.Size = new System.Drawing.Size(600, 165);
            this.RestaurantMoney_per_click.TabIndex = 3;
            this.RestaurantMoney_per_click.Text = "50000 $ за клик";
            this.RestaurantMoney_per_click.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // casinoTableLayoutPanel
            // 
            this.casinoTableLayoutPanel.BackColor = System.Drawing.Color.IndianRed;
            this.casinoTableLayoutPanel.ColumnCount = 3;
            this.casinoTableLayoutPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 18F));
            this.casinoTableLayoutPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 52F));
            this.casinoTableLayoutPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 30F));
            this.casinoTableLayoutPanel.Controls.Add(this.Btn_OrderManagerCasino, 2, 0);
            this.casinoTableLayoutPanel.Controls.Add(this.button3, 0, 0);
            this.casinoTableLayoutPanel.Controls.Add(this.button4, 0, 1);
            this.casinoTableLayoutPanel.Controls.Add(this.Casino_lvl, 1, 0);
            this.casinoTableLayoutPanel.Controls.Add(this.CasinoMoney_per_click, 1, 1);
            this.casinoTableLayoutPanel.Location = new System.Drawing.Point(12, 717);
            this.casinoTableLayoutPanel.Name = "casinoTableLayoutPanel";
            this.casinoTableLayoutPanel.RowCount = 2;
            this.casinoTableLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 21.42857F));
            this.casinoTableLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 78.57143F));
            this.casinoTableLayoutPanel.Size = new System.Drawing.Size(1164, 193);
            this.casinoTableLayoutPanel.TabIndex = 6;
            this.casinoTableLayoutPanel.Visible = false;
            // 
            // Btn_OrderManagerCasino
            // 
            this.Btn_OrderManagerCasino.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Btn_OrderManagerCasino.Location = new System.Drawing.Point(817, 3);
            this.Btn_OrderManagerCasino.Name = "Btn_OrderManagerCasino";
            this.Btn_OrderManagerCasino.Size = new System.Drawing.Size(344, 35);
            this.Btn_OrderManagerCasino.TabIndex = 12;
            this.Btn_OrderManagerCasino.Text = "Нанять менеджера за 500000 $";
            this.Btn_OrderManagerCasino.UseVisualStyleBackColor = true;
            this.Btn_OrderManagerCasino.Click += new System.EventHandler(this.Btn_OrderManagerCasino_Click);
            // 
            // button3
            // 
            this.button3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.button3.Location = new System.Drawing.Point(3, 3);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(203, 35);
            this.button3.TabIndex = 0;
            this.button3.Text = "Улучшить за 500000 $";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // button4
            // 
            this.button4.BackgroundImage = global::PenkoCourseWork.Properties.Resources.casino;
            this.button4.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.button4.Location = new System.Drawing.Point(3, 44);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(203, 146);
            this.button4.TabIndex = 1;
            this.button4.UseVisualStyleBackColor = true;
            this.button4.Click += new System.EventHandler(this.button4_Click);
            // 
            // Casino_lvl
            // 
            this.Casino_lvl.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Casino_lvl.Location = new System.Drawing.Point(212, 0);
            this.Casino_lvl.Name = "Casino_lvl";
            this.Casino_lvl.Size = new System.Drawing.Size(599, 41);
            this.Casino_lvl.TabIndex = 2;
            this.Casino_lvl.Text = "Уровень заведения 0";
            this.Casino_lvl.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // CasinoMoney_per_click
            // 
            this.CasinoMoney_per_click.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.CasinoMoney_per_click.Location = new System.Drawing.Point(212, 41);
            this.CasinoMoney_per_click.Name = "CasinoMoney_per_click";
            this.CasinoMoney_per_click.Size = new System.Drawing.Size(599, 152);
            this.CasinoMoney_per_click.TabIndex = 3;
            this.CasinoMoney_per_click.Text = "500000 $ за клик";
            this.CasinoMoney_per_click.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // RestaurantLabel
            // 
            this.RestaurantLabel.BackColor = System.Drawing.Color.MediumAquamarine;
            this.RestaurantLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.RestaurantLabel.Location = new System.Drawing.Point(12, 375);
            this.RestaurantLabel.Name = "RestaurantLabel";
            this.RestaurantLabel.Size = new System.Drawing.Size(156, 44);
            this.RestaurantLabel.TabIndex = 7;
            this.RestaurantLabel.Text = "РЕСТОРАН";
            this.RestaurantLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // CasinoLabel
            // 
            this.CasinoLabel.BackColor = System.Drawing.Color.IndianRed;
            this.CasinoLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.CasinoLabel.Location = new System.Drawing.Point(12, 660);
            this.CasinoLabel.Name = "CasinoLabel";
            this.CasinoLabel.Size = new System.Drawing.Size(156, 45);
            this.CasinoLabel.TabIndex = 8;
            this.CasinoLabel.Text = "КАЗИНО";
            this.CasinoLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // Btn_OpenRestaurant
            // 
            this.Btn_OpenRestaurant.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Btn_OpenRestaurant.Location = new System.Drawing.Point(193, 375);
            this.Btn_OpenRestaurant.Name = "Btn_OpenRestaurant";
            this.Btn_OpenRestaurant.Size = new System.Drawing.Size(237, 44);
            this.Btn_OpenRestaurant.TabIndex = 9;
            this.Btn_OpenRestaurant.Text = "Открыть за 100000 $";
            this.Btn_OpenRestaurant.UseVisualStyleBackColor = true;
            this.Btn_OpenRestaurant.Click += new System.EventHandler(this.Btn_OpenRestaurant_Click);
            // 
            // Btn_OpenCasino
            // 
            this.Btn_OpenCasino.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Btn_OpenCasino.Location = new System.Drawing.Point(193, 660);
            this.Btn_OpenCasino.Name = "Btn_OpenCasino";
            this.Btn_OpenCasino.Size = new System.Drawing.Size(237, 45);
            this.Btn_OpenCasino.TabIndex = 11;
            this.Btn_OpenCasino.Text = "Открыть за 1000000 $";
            this.Btn_OpenCasino.UseVisualStyleBackColor = true;
            this.Btn_OpenCasino.Click += new System.EventHandler(this.Btn_OpenCasino_Click);
            // 
            // MainGame
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoScroll = true;
            this.BackgroundImage = global::PenkoCourseWork.Properties.Resources.moneybackground;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1391, 935);
            this.Controls.Add(this.Btn_OpenCasino);
            this.Controls.Add(this.Btn_OpenRestaurant);
            this.Controls.Add(this.CasinoLabel);
            this.Controls.Add(this.RestaurantLabel);
            this.Controls.Add(this.casinoTableLayoutPanel);
            this.Controls.Add(this.restaurantTableLayoutPanel);
            this.Controls.Add(this.Btn_OpenBurgery);
            this.Controls.Add(this.Burgery_Lb);
            this.Controls.Add(this.burgeryTableLayoutPanel);
            this.Controls.Add(this.money_quantity);
            this.Controls.Add(this.Money_lb);
            this.Name = "MainGame";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Businessman Simulator";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.MainGame_FormClosed);
            this.burgeryTableLayoutPanel.ResumeLayout(false);
            this.restaurantTableLayoutPanel.ResumeLayout(false);
            this.casinoTableLayoutPanel.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label Money_lb;
        private System.Windows.Forms.Label money_quantity;
        private System.Windows.Forms.TableLayoutPanel burgeryTableLayoutPanel;
        private System.Windows.Forms.Button Btn_OpenBurgery;
        private System.Windows.Forms.Label Burgery_Lb;
        private System.Windows.Forms.Button Btn_UpgradeBurgery;
        private System.Windows.Forms.Button Btn_Burger;
        private System.Windows.Forms.Label BurgeryMoney_per_click;
        private System.Windows.Forms.Label Burgery_lvl;
        private System.Windows.Forms.Button Btn_OrderManagerBurgery;
        private System.Windows.Forms.TableLayoutPanel restaurantTableLayoutPanel;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Label Restaurant_lvl;
        private System.Windows.Forms.Label RestaurantMoney_per_click;
        private System.Windows.Forms.TableLayoutPanel casinoTableLayoutPanel;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Label Casino_lvl;
        private System.Windows.Forms.Label CasinoMoney_per_click;
        private System.Windows.Forms.Label RestaurantLabel;
        private System.Windows.Forms.Label CasinoLabel;
        private System.Windows.Forms.Button Btn_OpenRestaurant;
        private System.Windows.Forms.Button Btn_OrderManagerRestaurant;
        private System.Windows.Forms.Button Btn_OpenCasino;
        private System.Windows.Forms.Button Btn_OrderManagerCasino;
    }
}