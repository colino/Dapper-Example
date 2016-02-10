using System;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using Dapper;
using System.Collections.Generic;
using System.Text;
using System.Linq;
using System.Collections;

namespace DapperExample
{
    public class Program 
    {

        /**
            Esempio di ORM in C# utilizzando Dapper
        **/
        
        
        static void Main(string[] args)
        {

            IContactRepository contactRepository = new ContactRepository();

            List<Contact> contacts = contactRepository.GetAll();
            foreach(var c in contacts)
            {
                Console.Write(c.Company + " " + c.Email + " " + c.FirstName + " " + c.LastName + " " + c.Title);
                Console.WriteLine();
            }


            Console.ReadLine();
        


        }
    }
}
