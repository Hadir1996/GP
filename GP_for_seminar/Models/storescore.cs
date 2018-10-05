using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace GP_for_seminar.Models
{
    public class storescore
    {
        public string savescore(string username, string password, int practiceid,string type, int score)
        {

            KidsKingdomEntities3 DB = new KidsKingdomEntities3();
            var query = from k in DB.Kids
                        where
      (k.UserName== username && k.Password == password)
                        select k;
            if (query.Count() > 0)
            {
                Kid l = query.Single();

                var query2 = from e in DB.Kid_level_practice
                            where
              (e.KidID == l.KidID && e.practiceID == practiceid)
                            select e;

                if(query2.Count()>0)
                {
                    Kid_level_practice obj = query2.Single();
                    obj.practiceID = practiceid;
                    obj.KidID = l.KidID;
                    obj.Score = score;
                    obj.PracticeName = type;
                    obj.UseName = username;
                    DB.SaveChanges();
                }
                else
                { 
                Kid_level_practice p = new Kid_level_practice();
                p.practiceID = practiceid;
                p.KidID = l.KidID;
                p.Score = score;
                p.PracticeName = type;
                p.UseName = username;
                    DB.Kid_level_practice.Add(p);
                DB.SaveChanges();
                }

                return "fail";
            }
            else
            {
                return "fail";
            }

        }

    }
}