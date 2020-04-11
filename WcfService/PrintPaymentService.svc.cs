using BLL;
using System;
using System.Collections.Generic;
using Microsoft.Extensions.Configuration;
using System.IO;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.Text;
using DTO;
using System.Configuration;

namespace WcfService
{
    // NOTE: You can use the "Rename" command on the "Refactor" menu to change the class name "PrintPaymentService" in code, svc and config file together.
    // NOTE: In order to launch WCF Test Client for testing this service, please select PrintPaymentService.svc or PrintPaymentService.svc.cs at the Solution Explorer and start debugging.
    public class PrintPaymentService : IPrintPaymentService
    {
        public static string connectionString { get; } = ConfigurationManager.ConnectionStrings["dbProject"].ConnectionString;

        public string SayHello(int id)
        {
            StudentsManager studentsManager = new StudentsManager(connectionString);
            Student student = studentsManager.GetStudent(id);
            return "Hello " + student.lastname;
        }
    }
}
