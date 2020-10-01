using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Someren
{
    public static class SomerenUI
    {
        public static Control showStudents()
        {
            List<SomerenModel.Student> sl = new List<SomerenModel.Student>();
            //SomerenDB.
            SomerenModel.Student s1 = new SomerenModel.Student();
            s1.setName("Henk");
            SomerenModel.Student s2 = new SomerenModel.Student();
            s2.setName("Piet");
            SomerenModel.Student s3 = new SomerenModel.Student();
            s3.setName("Amber");

            sl.Add(s1);
            sl.Add(s2);
            sl.Add(s3);

            int aantal = sl.Count();
            ListView c = new ListView();
            c.Height = 1000;
            ListViewItem li = new ListViewItem();
            li.SubItems.Add(s1.getName());
            li.SubItems.Add(s1.getId().ToString());
            c.Items.Add(s1.getName());
            c.Items.Add(s2.getName());
            c.Items.Add(s3.getName());
            c.Items.Add(li);

            return c;
        }

        public static Control addUILabel(string text)
        {
            Label l = new Label();
            l.Text = text;
            return l;
        }

        // that's output stuff
        public static Control showRooms()
        {
            List<SomerenModel.Rooms> rl = new List<SomerenModel.Rooms>();
            //SomerenDB.
            rl = SomerenDB.DB_getRooms();

          
            int aantal = rl.Count();
                 ListView c = new ListView();
                 c.Height = 1000;
          //       ListViewItem li = new ListViewItem();
            foreach (SomerenModel.Rooms room in rl)
            {
                c.Items.Add("RoomNumber: " + room.getRoomNumber().ToString());
                c.Items.Add("RoomCapacity: " + room.getRoomCapacity().ToString());
                c.Items.Add(room.getRoomType().ToString());
               
            }

            return c;
        }


    
    }
}
