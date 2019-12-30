using Sahaf.DAL.Concrete;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sahaf.DAL
{
    class MyStrategy : DropCreateDatabaseIfModelChanges<SahafDbContext>
    {
    }
}
