using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;

namespace ADOHandsOn
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Employee employee = new Employee();
            Account account = new Account();
            //string status = employee.InsertEmployee();
            //Console.WriteLine(status);

            //Console.ReadLine();


            DataTable dt = employee.SelectEmployes();
            for (int i = 0; i < dt.Columns.Count; i++)
            {
                Console.Write(dt.Columns[i].ColumnName + "  ");
            }
            Console.WriteLine();
            for (int i = 0; i < dt.Rows.Count; i++)
            {
                for (int j = 0; j < dt.Columns.Count; j++)
                {
                    Console.Write(dt.Rows[i][j] + "  ");

                }
                Console.WriteLine();
            }
            //Console.WriteLine(employee.DeleteEmployee(10));
            //Console.WriteLine(employee.UpdateEmployee("Yuvraj Singh", 77));
            //Console.WriteLine();
            //employee.SelectEmployeeById(12);
            //account.InsertAccount();
            //account.SelectAccountById(1003);
            //Console.WriteLine();

            //dt = account.SelectAccounts();
            //for (int i = 0; i < dt.Columns.Count; i++)
            //{
            //    Console.Write(dt.Columns[i].ColumnName + "  ");
            //}
            //Console.WriteLine();
            //for (int i = 0; i < dt.Rows.Count; i++)
            //{
            //    for (int j = 0; j < dt.Columns.Count; j++)
            //    {
            //        Console.Write(dt.Rows[i][j] + "     ");

            //    }
            //    Console.WriteLine();
            //}
            //account.UpdateAccount("Pinki", 7777);
            //account.DeleteAccount(77);


            //Console.ReadLine();
        }
    }
}