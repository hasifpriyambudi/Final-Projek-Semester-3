using System;
using System.Collections.Generic;
using System.Text;
using System.Data;

namespace inventtaris.model
{
    class modelAdmin
    {
        public string nama { get; set; }
        public string email { get; set; }
        public string user { get; set; }
        public string pass { get; set; }
        public string key { get; set; }
        public string Idadmin { get; set; }
        Koneksi temp;

        public modelAdmin()
        {
            temp = new Koneksi();
        }

        public bool Proses_tambah()
        {
            string data = "'" + nama + "','" + email + "','" + user + "','" + pass + "','1'";
            return temp.Insert("admin",data);
        }

        public DataSet Getdata()
        {
            DataSet data = new DataSet();
            string status = "status_admin='1'";
            data = temp.Select("admin", status);
            return data;
        }

        public int Totaldata()
        {
            return Searchadmin().Tables[0].Rows.Count;
        }

        public DataSet Searchadmin()
        {
            DataSet admin = new DataSet();
            if (key == "")
            {
                admin = Getdata();
            }
            else
            {
                admin = temp.SelectData("SELECT id_admin, nama_admin, email_admin, user_admin FROM admin WHERE " +
                    "(id_admin LIKE '%" + key + "%' OR nama_admin LIKE '%" + key + "%' OR email_admin LIKE '%" + key + "%' OR user_admin LIKE '%" + key + "%') AND status_admin='1'", "admin");
            }
            return admin;
        }

        public bool Deleteadmin()
        {
            string data = "status_admin='0'";
            return temp.Update("admin", data, "Id_admin=" + Idadmin);
        }

        public bool Updateadmin()
        {
            string data = "";
            if (pass == "")
            {
                 data = "nama_admin='" + nama + "',email_admin='" + email + "',user_admin='" + user + "'";
            }
            else
            {
                data = "nama_admin='" + nama + "',email_admin='" + email + "',user_admin='" + user + "',password='"+pass+"'";
            }
            return temp.Update("admin", data, "id_admin=" + Idadmin);
        }
    }
}
