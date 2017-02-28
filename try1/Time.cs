using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace try1
{
    class Time
    {
        private char[] occupied;
        private int classIdInSchedule;

        public Time(int id)
        {
            classIdInSchedule = id;
            occupied = new char[42];
            for (int i = 0; i < 6; i++)
            {
                occupied[i] = '0';
            }
                
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

    }
}
