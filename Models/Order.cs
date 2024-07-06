using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using start.Enums;

namespace start.Models
{
    public class Order
    {
        public int Id;
        public string RefrenceNumber;
        public string CustomerEmail;
        public Status Status;
        public List<string> Items;

        public Order(int id, string refNumber, string email, Status status, List<string> items)
        {
            Id = id;
            RefrenceNumber = refNumber;
            CustomerEmail = email;
            Status = status;
            Items = items;
        }
    }
}