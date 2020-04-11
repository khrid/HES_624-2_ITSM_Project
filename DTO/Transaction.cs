using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTO
{
    class Transaction
    {
        int id { get; set; }
        string source { get; set; }
        DateTime timestamp { get; set; }
        double amount { get; set; }
        Student student { get; set; }
    }
}
