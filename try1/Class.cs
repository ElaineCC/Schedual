using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace try1
{
    class Class
    {
        private int classId;
        private String className;
        private int classSize;
        private String classDepartment;
        private char[] occupied;

        public Class()
        {

        }
        public Class(int id,String name,int size,String department)
        {
            classId = id;
            className = name;
            classSize = size;
            classDepartment = department;
            occupied = new char[42];
            for(int i=0;i<42;i++)
            {
                occupied[i] = '0';
            }
        }
        public int getClassId()
        {
            return classId;
        }
        public int setClassId(int id)
        {
            classId = id;
            return 0;
        }
        public String getClassName()
        {
            return className;
        }
        public int setClassName(String name)
        {
            className = name;
            return 0;
        }
        public int getClassSize()
        {
            return classSize;
        }
        public int setClassSize(int size)
        {
            classSize = size;
            return 0;
        }
        public String getClassDepartment()
        {
            return classDepartment;
        }
        public int setClassDepartment(String department)
        {
            classDepartment = department;
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
        public static Class getClassById(int id)
        {
            Class _class = new Class();
            return _class;
        }
    }
}
