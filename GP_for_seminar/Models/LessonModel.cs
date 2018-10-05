using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace GP_for_seminar.Models
{
    public class LessonModel
    {
  

        public List< Lesson_Content> searchLesson(string levelno, string leveltype,int lessno,string name)
        {
            KidsKingdomEntities3 DB = new KidsKingdomEntities3();
            var query = from k in DB.Levels
                        where
      (k.LevelNumber == levelno && k.LevelType == leveltype)
                        select k;
            if (query.Count() > 0)
            {
                Level l = query.Single();
                var query2= from s in DB.Lessons
                        where
      (s.LessonNumber == lessno && s.LevelID == l.LevelID)
                        select s;
                if (query2.Count() > 0)
                {
                    Lesson les = query2.Single();
                    var query3 = from ss in DB.Lesson_Content
                                 where
               (ss.LessonID == les.LessonID && ss.name == name)
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



        public Lesson_Content signlangLesson(string levelno, string leveltype, int lessno, string videoname)
        {

            KidsKingdomEntities3 DB = new KidsKingdomEntities3();
            var query = from k in DB.Levels
                        where
      (k.LevelNumber == levelno && k.LevelType == leveltype)
                        select k;
            if (query.Count() > 0)
            {
                Level l = query.Single();
                var query2 = from s in DB.Lessons
                             where
           (s.LessonNumber == lessno && s.LevelID == l.LevelID)
                             select s;
                if (query2.Count() > 0)
                {
                    Lesson les = query2.Single();
                    var query3 = from ss in DB.Lesson_Content
                                 where
               (ss.LessonID == les.LessonID && ss.video == videoname)
                                 select ss;
                    if (query3.Count() > 0)
                    {
                        return query3.Single();
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