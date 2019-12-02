using App.model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace App.service
{
    class SinhVienservice
    {
		public static List<SinhVIen> getlist() {
            return new democontext().sinhVIens.ToList();
		}
        public static van getvan(string id)
        {
            return new democontext().vans.Where(e=>e.idsv==id).FirstOrDefault();
        }
        public static vatly getvatly(string id)
        {
            return new democontext().vatlies.Where(e => e.idsv == id).FirstOrDefault();
        }
        public static cntt getcntt(string id)
        {
            return new democontext().cntts.Where(e => e.idsv == id).FirstOrDefault();
        }
        public static void delete(string id)
        {
            var db = new democontext();
            db.sinhVIens.Remove(db.sinhVIens.Where(e => e.id == id).FirstOrDefault());
            db.vans.Remove(db.vans.Where(e => e.idsv == id).FirstOrDefault());
            db.vatlies.Remove(db.vatlies.Where(e => e.idsv == id).FirstOrDefault());
            db.cntts.Remove(db.cntts.Where(e => e.idsv == id).FirstOrDefault());
            db.SaveChanges();
        }
        public static void adddata(SinhVIen sv,van van,vatly vatly,cntt cntt)
        {
            var db = new democontext();
            db.sinhVIens.Add(sv);
            db.SaveChanges();
            if(van!=null)
            {
                db.vans.Add(van);
                db.SaveChanges();
            }
            if (vatly != null)
            {
                db.vatlies.Add(vatly);
                db.SaveChanges();
            }
            if (cntt != null)
            {
                db.cntts.Add(cntt);
                db.SaveChanges();
            }
        }
    }
}
