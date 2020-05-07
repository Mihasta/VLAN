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
                var user = db.Users.First(x => x.Id == Globals.user_id);
                l = user.Like;
                if (l.Contains(_id.ToString()))
                {
                    MessageBox.Show("Вы не можете поставить больше 1 лайка на решения");
                }
                else
                {
                    user.Like += _id.ToString() + " ";
                    var solution = db.Solutions.First(x => x.Id == id);
                    i = solution.Likes;
                    i++;
                    solution.Likes = i;
                    db.SaveChanges();
                }
            }
        }   
    }
}
