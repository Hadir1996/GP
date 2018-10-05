using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace GP_for_seminar.Models
{
    public class PracticeModel
    {
        public List<Practice_content> searchpractice(string levelno, string leveltype, int practiceno)
        {

            KidsKingdomEntities3 DB = new KidsKingdomEntities3();
            var query = from k in DB.Levels
                        where
      (k.LevelNumber == levelno && k.LevelType == leveltype)
                        select k;
            if (query.Count() > 0)
            {
                Level l = query.Single();
                var query2 = from s in DB.Practices
                             where
           (s.PracticeNumber == practiceno && s.LevelID == l.LevelID)
                             select s;
                if (query2.Count() > 0)
                {
                   Practice pra = query2.Single();
                    var query3 = from ss in DB.Practice_content
                                 where
               (ss.PracticeID == pra.PracticeID)
                                 select ss;
                    if (query3.Count() > 0)
                    {
                        return query3.ToList();
                    }
                }
                return null;
            }
            else
            {
                return null;
            }

        }
    }
}