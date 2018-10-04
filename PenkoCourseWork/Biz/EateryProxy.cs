using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Biz
{
    public class EateryProxy : Proxy
    {
        public override int ClickGain()
        {
            return 1000;
        }

        public override String UpgradeMessage()
        {
            return "Улучшение не дает Вам какого-либо эффекта после того случая с менеджером и тарелкой. Менеджер игриво извиняется и просит повысить ему зарплату.";
        }
    }
}
