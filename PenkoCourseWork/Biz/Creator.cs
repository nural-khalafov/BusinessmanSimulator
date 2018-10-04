using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Biz
{
    abstract public class Creator
    {
        public abstract Buisness Create();
    }

    class RestaurantCreator : Creator
    {
        public override Buisness Create() { return new Restaurant(); }
    }

    class EateryCreator : Creator
    {
        public override Buisness Create() { return new Eatery(); }
    }

    class CasinoCreator : Creator
    {
        public override Buisness Create() { return new Casino(); }
    }
}
