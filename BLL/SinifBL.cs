using DAL;
using Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BLL
{
    public class SinifBL:IDisposable
    {
        OkulDbContext ctx = new OkulDbContext();

        public void Dispose()
        {
            ((IDisposable)ctx).Dispose();
        }

        public bool Ekle(Sinif s)
        {
            ctx.Siniflar.Add(s);
            return ctx.SaveChanges() > 0;
        }
    }
}
