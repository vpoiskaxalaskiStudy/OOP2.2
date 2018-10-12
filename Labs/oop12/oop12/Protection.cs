using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace oop12
{

    public class Armor
    {
        public string Sort { get; set; }
    }
    public class Guard
    {
        public string Sort { get; set; }
    }

     public class Protection
    {

        public Armor Armor { get; set; }
        public Guard Guard { get; set; }

        public override string ToString()
        {
            String sb = "";
            if (Armor != null)
                sb += "Доспехи: " + Armor.Sort + "\n";
            if (Guard != null)
                sb += "Щит: " + Guard.Sort + " \n";
            return sb.ToString();
        }
    }

    // абстрактный класс строителя
     public abstract class ProtectionBuilder
    {
        public Protection Protection { get; set; }
        public void CreateProtection()
        {
            Protection = new Protection();
        }
        public abstract void SetArmor(string type);
        public abstract void SetGuard(string type);
    }


   public class WizardProtectionBuilder : ProtectionBuilder
    {

        public override void SetArmor(string type)
        {
            this.Protection.Armor = new Armor { Sort = type };
        }

        public override void SetGuard(string type)
        {
            this.Protection.Guard = new Guard { Sort = type };
        }
    }

   public class BerserkProtectionBuilder : ProtectionBuilder
    {
        public override void SetArmor(string type)
        {
            this.Protection.Armor = new Armor { Sort = type };
        }

        public override void SetGuard(string type)
        {
            this.Protection.Guard = new Guard { Sort = type };
        }
    }
}
