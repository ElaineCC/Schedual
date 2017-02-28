using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace try1
{
    class Course
    {
        private int courseId;
        private String courseName;
        private String courseDepartment;
        private int coursePeriod;//总课时数
        private int weektime;//每两周课时

        public Course()
        {

        }
        public Course(int id,String name,String department,int period,int time)
        {
            courseId = id;
            courseName = name;
            courseDepartment = department;
            coursePeriod = period;
            weektime = time;
            
        }
        public int getCourseId()
        {
            return courseId;
        }
        public int setCourseId(int id)
        {
            courseId = id;
            return 0;
        }
        public String getCourseName()
        {
            return courseName;
        }
        public int setCourseName(String name)
        {
            courseName = name;
            return 0;
        }
        public String getCourseDepartment()
        {
            return courseDepartment;
        }
        public int setCourseDepaetment(String department)
        {
            courseDepartment = department;
            return 0;
        }
        public int getCoursePeriod()
        {
            return coursePeriod;
        }
        public int setCoursePeriod(int period)
        {
            coursePeriod = period;
            return 0;
        }
        
    }
}
