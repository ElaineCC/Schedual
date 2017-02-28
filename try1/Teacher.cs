using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace try1
{
    class Teacher
    {
        private int teacherId;
        private String teacherName;
        private String teacherDepartment;
        private char[] occupied;

        public Teacher(int id,String name,String department)
        {
            teacherId = id;
            teacherName = name;
            teacherDepartment = department;
            occupied = new char[42];
            for(int i=0;i<42;i++)
            {
                occupied[i] = '0';
            }
        }
        public int getTeacherId()
        {
            return teacherId;
        }
        public int setTeacherId(int id)
        {
            teacherId = id;
            return 0;
        }
        public String getTeacherName()
        {
            return teacherName;
        }
        public int setTeacherName(String name)
        {
            teacherName = name;
            return 0;
        }
        public String getTeacherDepartment()
        {
            return teacherDepartment;
        }
        public int setTeacherDepartment(String department)
        {
            teacherDepartment = department;
            return 0;
        }
        public char getOccupied(int i,int j)//星期i第j节
        {
            return occupied[(i-1)*6+j-1];
        }
        public int  setOcuupied(int i,int j,char c)
        {
            occupied[(i-1)*6+j-1] = c;
            return 0;
        }
    }
}
