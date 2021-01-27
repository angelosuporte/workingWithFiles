namespace WorkingFiles.Entities
{
    class Sale
    {
        public string Name { get; set; }
        public double Price { get; set; }
        public int Quantity { get; set; }

        public Sale(string name, double price, int quantity)
        {
            Name = name;
            Price = price;
            Quantity = quantity;
        }

        public double Total()
        {
             return Price * Quantity;
        }
    }
}
