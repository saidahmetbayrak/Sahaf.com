using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sahaf.Core.DAL
{
    public class EFSingletionContext<TContext>
         where TContext : DbContext, new()
    {
        //Bu classın instance'ı alınabilir,İlerde dene!

        private static TContext _context; //
        public static TContext Instance //İnstance almayı kontrol edip almaya saglıyor
        {
            get
            {
                if (_context == null)
                {
                    _context = new TContext();
                }
                return _context;
            }
        }
    }
}
