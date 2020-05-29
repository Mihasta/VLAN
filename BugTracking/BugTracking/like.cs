using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BugTracking
{
    class Like
    {
        public void lke(int _id, int id)
        {
            int i = 0;
            string l = "";
            using (BTContext db = new BTContext())
            {
                var solution = db.Solutions.First(x => x.ErrorId == _id);
                if (solution.LikedUsersId == null)
                {
                    solution.LikedUsersId = String.Empty;
                    db.SaveChanges();
                }
            }
            using (BTContext db = new BTContext())
            {
                var solution = db.Solutions.First(x => x.ErrorId == _id);
                l = solution.LikedUsersId;
                if (l.Contains(Globals.user_id.ToString()))
                {
                    MessageBox.Show("Вы не можете поставить больше 1 лайка на решения");
                }
                else
                {
                    solution.LikedUsersId += Globals.user_id.ToString() + " ";
                    i = solution.Likes;
                    i++;
                    solution.Likes = i;
                    db.SaveChanges();
                }
            }
        }   
    }
}
