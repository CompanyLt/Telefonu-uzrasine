using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Windows.Input;


namespace Telefonu_uzrasine
{
    public class SqlAction
    {

        public SqlConnection sqlConnection { get; }

        public SqlAction(string connectionString)
        {
            sqlConnection = new SqlConnection(connectionString);


        }

        public bool checkConnection()
        {
            try
            {
                sqlConnection.Open();

            }
            catch (Exception ex)
            {
                using (StreamWriter writer = new StreamWriter("connstring_patikra.log", true))
                {

                    writer.WriteLine($"[{DateTime.Now}] Klaida: {ex.Message}");
                    writer.WriteLine($"Aprasymas: {ex.StackTrace}");
                    writer.WriteLine();
                }
                return false;
            }
            return true;
        }


        public void addContact(Person asmuo)
        {
            try
            {
                OpenConnection();
                string uzsifruotas = Sifratorius.Encrypt(asmuo.getPhoneNumber());
                using (SqlCommand komanda = new SqlCommand("spIraso_Pridejimas", sqlConnection))
                {
                    komanda.CommandType = CommandType.StoredProcedure;
                    komanda.Parameters.Add(new SqlParameter("@param1", asmuo.getName()));
                    komanda.Parameters.Add(new SqlParameter("@param2", asmuo.getSurnName()));
                    komanda.Parameters.Add(new SqlParameter("@param3", uzsifruotas));
                    komanda.Parameters.Add(new SqlParameter("@param4", asmuo.getBirthDate()));

                    komanda.ExecuteNonQuery();
                    //operacija ivykdyta, suteikiamas leidimas tolimesniems veiksmams
                    asmuo.setPremission(true);
                }


            }
            catch (Exception ex)
            {

                using (StreamWriter writer = new StreamWriter("addContacts.log", true))
                {
                    writer.WriteLine($"[{DateTime.Now}] Klaida: {ex.Message}");
                    writer.WriteLine($"Aprasymas: {ex.StackTrace}");
                    writer.WriteLine();
                }
            }
            finally
            {
                CloseConnection();
            }





        }
        public void updateContact(Person asmuo)
        {
            try
            {
                OpenConnection();
            }
            catch
            {
                return;
            }


            SqlCommand komanda = null;
            try
            {
                komanda = new SqlCommand("spIrasu_Atnaujinimas", sqlConnection);
            }
            catch
            {
                goto ex;
            }

            komanda.CommandType = CommandType.StoredProcedure;
            string uzsifruotas = Sifratorius.Encrypt(asmuo.getPhoneNumber());
            komanda.Parameters.Add(new SqlParameter("@salyga", asmuo.getId()));
            komanda.Parameters.Add(new SqlParameter("@param1", asmuo.getName()));
            komanda.Parameters.Add(new SqlParameter("@param2", asmuo.getSurnName()));
            komanda.Parameters.Add(new SqlParameter("@param3", uzsifruotas));
            komanda.Parameters.Add(new SqlParameter("@param4", asmuo.getBirthDate()));

            try
            {
                komanda.ExecuteNonQuery();
            }
            catch
            {
                goto ex;
            }

        ex:
            CloseConnection();
        }


        public void getAllContacts(List<Person> konteinerio_kelias)
        {
           
            try
            {
                OpenConnection();
                using (SqlCommand komanda = new SqlCommand("spGet_All_Records", sqlConnection))
                {

                  
                    komanda.CommandType = CommandType.StoredProcedure;


              


                    using (SqlDataReader skaitymas = komanda.ExecuteReader())
                    {
                        while (skaitymas.Read())
                        {
                            string issifruotas = Sifratorius.Decrypt(skaitymas["numeris"].ToString());
                            if (issifruotas != string.Empty)
                            {
                                Person asmuo = new(Convert.ToInt32(skaitymas["id"]),
                                skaitymas["vardas"].ToString(),
                                skaitymas["pavarde"].ToString(),
                                issifruotas,
                                skaitymas["gimimodata"].ToString());
                                konteinerio_kelias.Add(asmuo);
                            }


                        }

                    }

                }

            }
            catch (Exception ex)
            {

                using (StreamWriter writer = new StreamWriter("veiksmas_3.log", true))
                {
                    writer.WriteLine($"[{DateTime.Now}] Klaida: {ex.Message}");
                    writer.WriteLine($"Aprasymas: {ex.StackTrace}");
                    writer.WriteLine();
                }

            }
            finally
            {
                CloseConnection();
               
            }


            

        }
        public void deleteContact(Person person)
        {
            try
            {
                OpenConnection();
                using (SqlCommand komanda = new SqlCommand("spIraso_Trynimas", sqlConnection))
                {
                    komanda.CommandType = CommandType.StoredProcedure;
                    komanda.Parameters.Add(new SqlParameter("@id", person.getId()));

                    komanda.ExecuteNonQuery();
                }

            }
            catch (Exception ex)
            {


            }
            finally
            {
                CloseConnection();
            }





        }


        public void OpenConnection()
        {
            if (sqlConnection.State == System.Data.ConnectionState.Closed)
            {
                sqlConnection.Open();
            }

        }

        public void CloseConnection()
        {
            if (sqlConnection.State == System.Data.ConnectionState.Open)
            {
                sqlConnection.Close();
            }

        }

    }
}


