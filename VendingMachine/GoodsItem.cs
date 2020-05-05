namespace VendingMachine
{
    public class GoodsItem
    {
        public string Name { get; set; }
        public int Price { get; set; }
        public int ItemsLeft { get; set; }

        public GoodsItem(string name, int price, int itemsLeft)
        {
            Name = name;
            Price = price;
            ItemsLeft = itemsLeft;
        }
    }
}