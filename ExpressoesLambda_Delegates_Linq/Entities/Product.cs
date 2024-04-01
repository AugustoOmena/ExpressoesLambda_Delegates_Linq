namespace ExpressoesLambda_Delegates_Linq.Entities
{
    internal class Product
    {
        public string Name { get; set; }
        public double Price { get; set; }

        public Product(string Name, double price)
        {
            Price = price;
            this.Name = Name;
        }

        public override string ToString()
        {
            return Name + ", " + Price.ToString("F2");
        }
    }
}
