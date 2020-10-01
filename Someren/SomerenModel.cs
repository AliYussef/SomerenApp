using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Someren
{
    class SomerenModel
    {
        public class Student
        {
            int id;
            string name;

            public void setName(string nameStudent)
            {
                name = nameStudent;
            }

            public string getName()
            {
                return name;
            }

            public int getId()
            {
                return id;
            }

        }

        public class StudentList
        {
            List<SomerenModel.Student> sl = new List<SomerenModel.Student>();

            public void addList(SomerenModel.Student s)
            {
                sl.Add(s);
            }

            public List<SomerenModel.Student> getList()
            {

                return sl;
            }
        }

        public class Rooms
        {
            int roomNumber;
            int roomCapacity;
            bool roomType;

            public void setRoomNumber(int room_number)
            {
                roomNumber = room_number;
            }
            public void setRoomCapacity(int room_capacity)
            {
                roomCapacity = room_capacity;
            }
            public void setRoomType(bool type)
            {
                roomType = type;
            }

            public int getRoomNumber()
            {
                return roomNumber;
            }

            public int getRoomCapacity()
            {
                return roomCapacity;
            }

            public bool getRoomType()
            {
                return roomType;
            }
        }
        //I don't use this stuff below I just repeated it 
        public class RoomsList
        {
            List<SomerenModel.Rooms> r = new List<SomerenModel.Rooms>();

            public void addList(SomerenModel.Rooms s)
            {
                r.Add(s);
            }

            public List<SomerenModel.Rooms> getList()
            {
                return r;
            }
        }
    }
}
