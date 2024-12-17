﻿using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CafeShopManagementSystem.DTO
{
    public class PaymentMethod
    {
        private int id;
        private string name;

        public int ID { get => id; set => id = value; }
        public string Name { get => name; set => name = value; }

        public PaymentMethod() { }

        public PaymentMethod(int id, string name)
        {
            this.id = id;
            this.name = name;
        }

        public PaymentMethod(DataRow row)
        {
            id = (int)row["id"];
            name = (string)row["name"];
        }
    }
}
