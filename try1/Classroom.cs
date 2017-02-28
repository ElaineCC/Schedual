using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace try1
{
    class Classroom
    {
        private int classroomId;
        private String classroomName;
        private String classroomType;
        private int classroomSize;
        private char[] occupied; 

        public Classroom()
        {

        }
        public Classroom(int id,String name,String type,int size)
        {
            classroomId = id;
            classroomName = name;
            classroomType = type;
            classroomSize = size;
            occupied = new char[42];
            for (int i = 0; i < 42; i++)
            {
                occupied[i, j] = '0';
            }
        }
        public int getClassroomId()
        {
            return classroomId;
        }
        public int setClassroomId(int id)
        {
            classroomId = id;
            return 0;
        }
        public String getClassroomName()
        {
            return classroomName;
        }
        public int setClassroomName(String name)
        {
            classroomName = name;
            return 0;
        }
        public String getClassroomType()
        {
            return classroomType;
        }
        public int setClassroomType(String type)
        {
            classroomType = type;
            return 0;
        }
        public int getClassroomSize()
        {
            return classroomSize;
        }
        public int setClassroomSize(int size)
        {
            classroomSize = size;
            return 0;
        }
        public char getOccupied(int i, int j)//星期i第j节
        {
            return occupied[(i - 1) * 6 + j - 1];
        }
        public int setOcuupied(int i, int j, char c)
        {
            occupied[(i - 1) * 6 + j - 1] = c;
            return 0;
        }
        public static Classroom getClassroomById(int id)
        {
            Classroom result=new Classroom();
            return result;
        }
    }
}
