using System;
using System.Collections.Generic;
using System.Text;

namespace DTO
{
    public class Transaction
    {
        public Transaction() { }

        public int id { get; set; }
        public string source { get; set; }
        public double amount { get; set; }
        public int fk_student { get; set; }
        public DateTime created_at { get; set; }
    }
}
