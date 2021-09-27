using System;
using System.Collections.Generic;
using System.Text;

namespace Zadacha8
{
    public class Invoice
    {
        public int Account { get; }
        public string Customer { get; }
        public string Provider { get; }

        private string article;
        private int quantity;

        public Invoice(int account, string customer, string provider, string article, int quantity)
        {
            Account = account;
            Customer = customer;
            Provider = provider;
            this.article = article;
            this.quantity = quantity;
        }

        public double CalculateCost(bool include)
        {
            double price = 0d;

            switch (article)
            {
                case "88005553535":
                    price = 1337d;
                    break;
            }

            return price * quantity / (include ? 0.8d : 1d);
        }
    }
}
