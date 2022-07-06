using System;
using System.Data.SqlClient;

namespace SqlConnectionDeneme0
{
    internal class Program
    {
        private static object cmd;

        static void Main(string[] args)
        {
            SqlBaglanti();
            // SqlKayitEkle();
        }
        //private static void SqlKayitEkle()
        //{
        //    string sqlkomut = @"insert into Shippers (CompanyName,Phone) values('Mng Kargo','2124440999')";
        //    string baglanticumlesi = @"Server=localhost;
        //                               Database=Northwind;
        //                               Trusted_Connection=True;";

        //    SqlConnection sqlConnection = new SqlConnection(baglanticumlesi);

        //    try
        //    {
        //        SqlCommand sqlCommand = new SqlCommand(sqlkomut, sqlConnection);
        //        sqlConnection.Open();

        //        int sonuc = sqlCommand.ExecuteNonQuery();
        //        if (sonuc > 0)
        //        {
        //            Console.WriteLine("Islem Basarili");
        //        }
        //        else
        //        {
        //            Console.WriteLine("Kayit Yapilmadi");
        //        }

        //    }


        //    catch (Exception ex)
        //    {

        //        Console.WriteLine(ex.Message);
        //    }

        //    finally
        //    {
        //        sqlConnection.Close();

        //    }
        //}

        private static void SqlBaglanti()
        {
            string sqlkomut = "select*from Customers";
            string baglanticumlesi = @"Server=localhost;
                                       Database=Northwind;
                                       Trusted_Connection=True;";
            SqlConnection sqlConnection = new SqlConnection(baglanticumlesi);
            SqlCommand sqlCommand = new SqlCommand(sqlkomut,sqlConnection);

              sqlConnection.Open();

            Console.WriteLine("Baglanti Durumu" + sqlConnection.State);

            SqlDataReader rdr = sqlCommand.ExecuteReader();
            while (rdr.Read())
            {
                Console.WriteLine(rdr["CustomerId"] + " " + rdr["CompanyName"] + " " + rdr["ContanctName"]);
            }

            Console.WriteLine("Hello World!");

            sqlConnection.Close();
            Console.WriteLine("Baglanti Durumu" + sqlConnection.State);
        }

    }
}

