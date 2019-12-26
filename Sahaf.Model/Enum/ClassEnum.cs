
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sahaf.Model.Enum
{
   public enum Status
    {
       New,
       Old
    }

    public enum Condition
    {
        VeryBad,
        Bad,
        Normal,
        Good,
        VeryGood
    }

    public enum Payment
    {
        EFT,
        CreditCard,
        Transfer
    }

    public enum Roles
    {
        User,
        Antiquarian
    }
}
