using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Laba1.Forms;

namespace Laba1
{
    public abstract class Creator
    {
        public abstract Form Create(FMenu.UpdateMethod method, object obj, int index);
    }

    class BottleCreator : Creator
    {
        public override Form Create(FMenu.UpdateMethod method, object obj, int index)
        {
            return new BottleForm(method, obj, index);
        }
    }
    class High_AlchololCreator : Creator
    {
        public override Form Create(FMenu.UpdateMethod method, object obj, int index)
        {
                  return new High_AlchololForm(method, obj, index);
        }
    }
    class Low_AlchololCreator : Creator
    {
        public override Form Create(FMenu.UpdateMethod method, object obj, int index)
        {
                return new Low_alcoholForm(method, obj, index);
        }
    }
    class Medium_AlchololCreator : Creator
    {
        public override Form Create(FMenu.UpdateMethod method, object obj, int index)
        {
            return new Medium_AlchololForm(method, obj, index);
        }
    }

    class UserDrinkCreator : Creator
    {
        public override Form Create(FMenu.UpdateMethod method, object obj, int index)
        {
            return new USDForm(method, obj, index);
        }
    }

}
