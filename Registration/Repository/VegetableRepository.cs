using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using privateconsloe.Models;
using Dapper;
using System.Data.SqlClient;

namespace privateconsloe.Repository
{
    public class VegetableRepository
    {
        public readonly string connectionstring;

        public VegetableRepository()
        {
            connectionstring = @"Data Source = ASUS5-AK; Initial Catalog = Vegetable; Integrated Security = True";
        }

        public Vegetableinfo Models()
        {
            Vegetableinfo V = new Vegetableinfo();
            Console.WriteLine("Enter the Vegetablename");
            V.Vegetablename = Console.ReadLine();
            Console.WriteLine("Enter the Ownername");
            V.Ownername = Console.ReadLine();
            Console.WriteLine("Enter the Quantity");
            V.Quantity =Convert.ToDecimal( Console.ReadLine());
            Console.WriteLine("Enter the Price");
            V.Price =Convert.ToDecimal(Console.ReadLine());
            Console.WriteLine("Enter the Location");
            V.location = Console.ReadLine();

            return V;
        }
       
        public void insert(Vegetableinfo p)
        {
            try
            {


                SqlConnection con = new SqlConnection(connectionstring);

                con.Open();
                con.Execute($"Exec Veginsert '{p.Vegetablename}','{p.Ownername}','{p.Quantity}','{p.Price}','{p.location}' ");
                con.Close();
            }
            catch (SqlException ex) 
            {
                throw ex;
            }
            catch(Exception e)
            {
                throw e;
            }
        }

        public List<Vegetableinfo> select(int Sno)
        {
            try
            {
                SqlConnection con = new SqlConnection(connectionstring);
                List<Vegetableinfo> res = new List<Vegetableinfo>();

                con.Open();
                res = con.Query<Vegetableinfo>($"Exec selectveg {Sno}").ToList();
                con.Close();

                //foreach (var a in res)
                //{
                //    Console.WriteLine($"Sno {a.Sno},Name {a.Vegetablename},Ownername {a.Quantity},Quantity {a.Quantity},Price {a.Price},Location {a.location}");
                //}
                return res;
            }
            catch (SqlException ex)
            {
                throw ex;

            }
            catch (Exception e)
            {
                throw e;
            }

        }

        public List<Vegetableinfo> select()
        {
            try
            {
                SqlConnection con = new SqlConnection(connectionstring);
                List<Vegetableinfo> res = new List<Vegetableinfo>();

                con.Open();
                res = con.Query<Vegetableinfo>("select * from Vegetable").ToList();
                con.Close();

                //foreach (var a in res)
                //{
                //    Console.WriteLine($"Sno {a.Sno},Name {a.Vegetablename},Ownername {a.Quantity},Quantity {a.Quantity},Price {a.Price},Location {a.location}");
                //}
                return res;
            }
            catch(SqlException ex)
            {
                throw ex;

            }
            catch(Exception e)
            {
                throw e;
            }
              
        } 

        public void Update(Vegetableinfo V)
        {
            try
            {
                SqlConnection con = new SqlConnection(connectionstring);

                con.Open();
                con.Execute($"Exec Vegupdate '{V.Sno}','{V.Vegetablename}','{V.Ownername}','{V.Quantity}','{V.Price}','{V.location}'");
                con.Close();
            } 
            catch(SqlException ex) 
            { 
                throw ex;
            }
            catch(Exception)
            {
                throw;
            }
        }
        public void Delete(int Sno)
        {
            try
            {
                SqlConnection con = new SqlConnection(connectionstring);

                con.Open();
                con.Execute($"Exec vegdelete '{Sno}'");
                con.Close();
            }
            catch (SqlException ex)
            {
                throw ex;
            }
            catch (Exception)
            {
                throw;
            }


        }
    }
}
