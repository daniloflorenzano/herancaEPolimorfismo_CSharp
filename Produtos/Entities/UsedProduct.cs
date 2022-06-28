using System;
using System.Globalization;

namespace Produtos.Entities
{
    internal class UsedProduct : Product
    {
        public DateTime ManufactureDate { get; set; }

        public UsedProduct() { }

        public UsedProduct(string name, double price, DateTime manufactureDate)
            : base(name, price)
        {
            ManufactureDate = manufactureDate;
        }

        public override string PriceTag()
        {
            return $"(used) $ {Price.ToString("F2", CultureInfo.InvariantCulture)} (Manufacture date: {ManufactureDate.ToString("dd/MM/yyyy")})";
        }
    }
}
