using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Biz
{
    abstract public class Buisness
    {
        protected Proxy manager;
        protected int openCost;
        protected int upgradeCost;
        protected int clickGain;
        protected int buisLevel = 1;
        protected int manageCost;
        public int UpgradeCost { get { return upgradeCost; } }
        public int OpenCost { get { return openCost; } }
        public virtual int ClickGain { get { return clickGain; } }
        public int ManageCost { get { return manageCost; } }
        public int BuisLevel { get { return buisLevel; } }

        abstract public String GetBuisnessType();

        abstract public String Open();

        abstract public String Upgrade();

        protected bool CalculateUpgrade(double clickGainPercent)
        {
            if (buisLevel != 1)
            {
                return false;
            }
            else
            {
                buisLevel = 2;
                clickGain += (int)(clickGain * clickGainPercent);
                return true;
            }
        }

        abstract public String Manage();
    }

    public class Restaurant : Buisness
    {
        public Restaurant()
        {
            openCost = 100000;
            upgradeCost = 50000;
            clickGain = 50000;
            manageCost = 50000;
        }

        public override string GetBuisnessType()
        {
            return "Ресторан";
        }

        public override String Open()
        {
            return GetBuisnessType() + " открыт для элитных посетителей.";
        }

        public override string Upgrade()
        {
            if (CalculateUpgrade(0.12))
                return GetBuisnessType() + " улучшен. Доход улучшен на 12%";
            else
                return GetBuisnessType() + " уже улучшен до " + buisLevel + " уровня.";
        }

        public override string Manage()
        {
            clickGain += 7000;
            return "Нанятый Вами менеджер заставляет персонал помыть все окна и протереть полы. Посетители добавляют вам по 7000$ чаевыми.";
        }
    }

    public class Eatery : Buisness  //забегаловка, бургерная
    {
        public Eatery()
        {
            openCost = 5000;
            upgradeCost = 2500;
            clickGain = 5000;
            manageCost = 2500;
        }

        public override int ClickGain
        {
            get
            {
                if (manager == null)
                    return clickGain;
                else
                    return manager.ClickGain();
            }
        }

        public override string GetBuisnessType()
        {
            return "Бургерная";
        }

        public override String Open()
        {
            return GetBuisnessType() + " открыта для любителей быстро поесть.";
        }

        public override string Upgrade()
        {
            if (CalculateUpgrade(0.28))
            {
                if (manager == null)
                    return GetBuisnessType() + " улучшено. Доход улучшен на 28%";
                else
                    return manager.UpgradeMessage();
            }
            else
                return GetBuisnessType() + " уже улучшена до " + buisLevel + " уровня.";
        }

        public override string Manage()
        {
            manager = new EateryProxy();
            return "Нанятый Вами менеджер публично плюнул в тарелку одного из посетителей. Из-за каких-то там \"прав потребителя\", предприятие теперь дает лишь " +manager.ClickGain() + "$.";
        }
    }

    public class Casino : Buisness
    {
        public Casino()
        {
            openCost = 1000000;
            upgradeCost = 500000;
            clickGain = 500000;
            manageCost = 500000;
        }

        public override string GetBuisnessType()
        {
            return "Казино";
        }

        public override String Open()
        {
            return GetBuisnessType() + " открыто для самых азартных весельчаков.";
        }

        public override string Upgrade()
        {
            if (CalculateUpgrade(0.07))
            {
                return GetBuisnessType() + " улучшено. Доход улучшен на 7%";
            }
            else
                return GetBuisnessType() + " уже улучшено до " + buisLevel + " уровня.";
        }

        public override string Manage()
        {
            if (buisLevel == 1)
            {
                upgradeCost *= 3;
                return "Нанятый Вами менеджер ругается с инвесторами и увеличивает стоимость улучшения бизнеса в 3 раза.";
            }
            else
            {
                return "Нанятый Вами менеджер ругается с инвесторами, но они не находят способа навредить Вашему бизнесу.";
            }
        }
    }
}
