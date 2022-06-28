using System.Globalization;

namespace Produtos.Entities
{
    internal class ImportedProduct : Product
    {
        public double CustomFee { get; set; }

        public ImportedProduct() { }

        public ImportedProduct(string name, double price, double customFee)
            : base(name, price)
        {
            CustomFee = customFee;
        }

        public double TotalPrice()
        {
            return Price + CustomFee;
        }

        public override string PriceTag()
        {
            return $"$ {Price.ToString("F2", CultureInfo.InvariantCulture)}" +
                $" (Customs fee: $ {CustomFee.ToString("F2", CultureInfo.InvariantCulture)})";
        }
    }
}
