using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace try1
{
    class Operation
    {
        public int getRandom()
        {
            Random ran;
            int seed = Convert.ToInt32(DateTime.Now.Ticks);
            ran = new Random(seed);
            int result = ran.Next(0, 41);
            return result;
        }
        public int decodeGene(String gene)
        {
            int length = gene.Length;
            int t = 0;
            int result = 0;
            for(int i=length-1;i>=0;i--)
            {
                int temp = gene[t]-'0';
                temp = temp * (int)Math.Pow(2, i);
                result += temp;
                t++;
            }
            return result;
        }
        public String encodeGene(int i,int length)
        {
            String result = Convert.ToString(i, 2);
            if(result.Length<length)
            {
                int add = length - result.Length;
                for(int j=0;j<add;j++)
                {
                    result = '0' + result;
                }
            }
            return result;
        }
        public int conflictDetection()
        {
            //不冲突返回0冲突返回1
        }
        public void makingSchedule()                                //贪心法得到初始种群
        {
            
        }
        public String[,] optimize(String[,] primaryoutcome)                         //是一个两千行二十列的二维数组
        {                                                                         
            int t = 0;
            int maxGeneration = 5000;
            double[,] individualFitness = new double[2,20];
            bool satisfied = false;
            String[,] outcome = new String[2000,20];
            while(t<maxGeneration&&satisfied==false)
            { 
                for(int i=0;i<20;i++)                                                   //计算个体适应度
                {
                    for(int j=0;j<2000;j++)
                    {
                        String gene = primaryoutcome[j,i];
                        int classid = decodeGene(gene.Substring(0, 10));
                        int courseid = decodeGene(gene.Substring(10, 11));
                        int teacherid = decodeGene(gene.Substring(21, 12));
                        int starttime = decodeGene(gene.Substring(33, 5));
                        int endtime = decodeGene(gene.Substring(38, 5));
                        int number = (gene.Length - 43) / 15;
                        int[] time = new int[number];
                        int[] classroomid = new int[number];
                        for(int k=0;k<number;k++)
                        {
                            time[k] = decodeGene(gene.Substring(43 + k * 15, 6));
                            classroomid[k] = decodeGene(gene.Substring(43 + k * 15 + 6, 9));
                        }
                        double[] fitness = new double[2];
                        int[] timeSquare = new int[number];
                        for(int k=0;k<number;k++)
                        {
                            Classroom room = new Classroom();
                            room = Classroom.getClassroomById(classroomid[k]);
                            Class _class=new Class();
                            _class = Class.getClassById(classid);
                            fitness[0] += _class.getClassSize() / room.getClassroomSize();

                            timeSquare[k] = time[k] * time[k];
                            
                        }
                        fitness[0] /= number;
                        fitness[1] = timeSquare.Average() - (time.Average()) * (time.Average());

                        individualFitness[0,i] += fitness[0];
                        individualFitness[1,i] += fitness[1];
                    }
                    individualFitness[0,i] /= 2000;
                    individualFitness[1,i] /= 2000;
                }

            }
            return outcome;
        }
        public void PrintSchedule()
        {

        }
    }
}
