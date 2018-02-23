using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using StudentBO;
using System.Data.SqlClient;
using System.Data;

namespace StudentDAL
{
    public class DBOperations
    {
        List<Student> list = new List<Student>();
        public int AddStudent(Student st)
        {
                SqlConnection con = new SqlConnection("server=intvmsql01;user id=pj01test01;password=tcstvm;database=db01test01");
                con.Open();
                SqlCommand cmd = new SqlCommand("sp_regist_student_57", con);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@name", st.Name);
                cmd.Parameters.AddWithValue("@contact", st.Contact);
                cmd.Parameters.AddWithValue("@city", st.City);
                cmd.Parameters.AddWithValue("@id", 0);
                cmd.Parameters["@id"].Direction = ParameterDirection.Output;
                int rowsaffected = cmd.ExecuteNonQuery();
                if (rowsaffected > 0)
                {

                    int studentid = Convert.ToInt32(cmd.Parameters["@id"].Value);
                    return studentid;
                }
                else
                    return 0;
        }
        public List<Student> ViewData()
        {

            SqlConnection con = new SqlConnection("server=intvmsql01;user id=pj01test01;password=tcstvm;database=db01test01");
            con.Open();
            SqlCommand cmd = new SqlCommand("sp_view_student_57", con);
            cmd.CommandType = CommandType.StoredProcedure;


            SqlDataReader reader = cmd.ExecuteReader();
            

            while (reader.Read())
            {
                
                int id = Convert.ToInt32(reader["id"]);
                string name = reader["name"].ToString();
                long contact = Convert.ToInt64(reader["contact"]);
                string city = reader["City"].ToString();
                Student S = new Student(id, name, contact, city);

                list.Add(S);
            }
            return list;


        }

        public int delete(int id)
        {
            SqlConnection con = new SqlConnection("server=intvmsql01;user id=pj01test01;password=tcstvm;database=db01test01");
            con.Open();
            SqlCommand cmd = new SqlCommand("sp_delete_student_57", con);
            cmd.CommandType = CommandType.StoredProcedure;

            cmd.Parameters.AddWithValue("@id",id);

            int ra = cmd.ExecuteNonQuery();
            if (ra > 0)
            {
                return id;
            }
            else
                return 0;


        }

        public int update(Student S,int id)
        {
            SqlConnection con = new SqlConnection("server=intvmsql01;user id=pj01test01;password=tcstvm;database=db01test01");
            con.Open();
            SqlCommand cmd = new SqlCommand("sp_update_student_57", con);
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue("@id", id);
            cmd.Parameters.AddWithValue("@name", S.Name);
            cmd.Parameters.AddWithValue("@contact", S.Contact);
            cmd.Parameters.AddWithValue("@city", S.City);

            int ra = cmd.ExecuteNonQuery();
            if (ra > 0)
            {
                return id;
            }
            else
                return 0;

            




        }
    }
}
