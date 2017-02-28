using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;

namespace try1
{
    class DatabaseController
    {
        private String str = "000000000000000000000000000000000000000000000000";

        public void connect()
        {
            SqlConnection con = new SqlConnection();
            con.ConnectionString = "server=ELAINEC-HP\\SQLEXPRESS;database=Schedule;Trusted_Connection=SSPI";
            con.Open();
            con.Close();
        } 
        
        public static Course getCourseWithMostStudentsToBeDealtWith()    //选择未处理并且上课人数最多的课程
        {
            SqlConnection con = new SqlConnection();
            con.ConnectionString = "server=ELAINEC-HP\\SQLEXPRESS;database=Schedule;Trusted_Connection=SSPI";
            con.Open();
            String sql = "select * from course" +
                        "where courseId=(" +
                        "select top 1 course.courseId" +
                        "from course" +
                        "inner join classcourse on classcourse.courseId=course.courseId" +
                        "inner join class on classcourse.classId=class.classId" +
                        "where course.isDone=0 " +
                        "group by course.courseId,class.classId" +
                        "order by sum(classSize) desc" +
                        ")";
            SqlDataAdapter adapter = new SqlDataAdapter(sql, con);
            DataTable table = new DataTable();
            adapter.Fill(table);
            con.Close();
            Course course = new Course(Convert.ToInt32(table.Rows[0]["courseId"]),
                                     table.Rows[0]["courseName"].ToString(),
                                     table.Rows[0]["courseDepartment"].ToString(),
                                     Convert.ToInt32(table.Rows[0]["coursePeriod"]),
                                     Convert.ToInt32(table.Rows[0]["weektime"]));
            return course;
        }
        public static Classroom getProperClassroom(int size,int time)
        {
            SqlConnection con = new SqlConnection();
            con.ConnectionString = "server=ELAINEC-HP\\SQLEXPRESS;database=Schedule;Trusted_Connection=SSPI";
            con.Open();
            String sql = "select top 1 * " +
                        "from classroom" +
                        "where classroomSize>" + size.ToString() + "AND substring(occupied,"+time.ToString()+",1)=0"+
                        "order by classroomSize ASC";
            SqlDataAdapter adapter = new SqlDataAdapter(sql, con);
            DataTable table = new DataTable();
            adapter.Fill(table);
            con.Close();
            Classroom classroom = new Classroom(Convert.ToInt32(table.Rows[0]["classroomId"]),
                                              table.Rows[0]["classroomName"].ToString(),
                                              table.Rows[0]["classroomType"].ToString(),
                                              Convert.ToInt32(table.Rows[0]["classroomSize"]));
            return classroom;
        }


        /*public Course getCourseById(int id)
        {
            Course course = new Course();
            SqlConnection con = new SqlConnection();
            con.ConnectionString = "server=ELAINEC-HP\\SQLEXPRESS;database=Schedule;Trusted_Connection=SSPI";
            con.Open();
            String str = "select * from course where courseId=" + id.ToString();
            SqlDataAdapter sqlAdapter = new SqlDataAdapter(str, con);
            DataTable table = new DataTable();
            sqlAdapter.Fill(table);
            if(table.Rows.Count>0)
            {
                course.setCourseId()
            }
        }
        public static int getClassNumber()
        {
            SqlConnection con = new SqlConnection();
            con.ConnectionString = "server=ELAINEC-HP\\SQLEXPRESS;database=Schedule;Trusted_Connection=SSPI";
            con.Open();
            String sql = "select count(*) from class";
            SqlDataAdapter adapter = new SqlDataAdapter(sql, con);
            DataTable table = new DataTable();
            adapter.Fill(table);
            con.Close();
            int number = Convert.ToInt32(table.Rows[0][0]);
            return number;
        }*/
    }
}
