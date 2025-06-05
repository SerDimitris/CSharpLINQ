namespace ConsoleApp26
{
    public class Item_mast
    {
        public int ItemId { get; set; }
        public string ItemDes { get; set; }
    }

    public class Purchase
    {
        public int InvNo { get; set; }
        public int ItemId { get; set; }
        public int PurQty { get; set; }
    }

    internal class Program
    {
        static void Main(string[] args)
        {
            List<Item_mast> itemlist = new List<Item_mast>
            {  
            // Initializing Item_mast objects with ItemId and ItemDes properties
                new Item_mast { ItemId = 1, ItemDes = "Biscuit  " },
                new Item_mast { ItemId = 2, ItemDes = "Chocolate" },
                new Item_mast { ItemId = 3, ItemDes = "Butter   " },
                new Item_mast { ItemId = 4, ItemDes = "Brade    " },
                new Item_mast { ItemId = 5, ItemDes = "Honey    " }
            };

            // Creating a list of Purchase objects
            List<Purchase> purchlist = new List<Purchase>
            {  
                // Initializing Purchase objects with InvNo, ItemId, and PurQty properties
                new Purchase { InvNo=100, ItemId = 3,  PurQty = 800 },
                new Purchase { InvNo=101, ItemId = 2,  PurQty = 650 },
                new Purchase { InvNo=102, ItemId = 3,  PurQty = 900 },
                new Purchase { InvNo=103, ItemId = 4,  PurQty = 700 },
                new Purchase { InvNo=104, ItemId = 3,  PurQty = 900 },
                new Purchase { InvNo=105, ItemId = 4,  PurQty = 650 },
                new Purchase { InvNo=106, ItemId = 1,  PurQty = 458 }
            };

            var _list = from item in itemlist
                        join purch in purchlist
                        on item.ItemId equals purch.ItemId into itemPurchaces
                        from purch in itemPurchaces.DefaultIfEmpty()
                        select new
                        {
                            item.ItemId,
                            item.ItemDes,
                            PurQty = purch?.PurQty
                        };

            foreach (var row in _list)
            {
                string quantity = row.PurQty.HasValue ? row.PurQty.ToString() : "NULL";
                Console.WriteLine($"{row.ItemId}\t{row.ItemDes}\t{quantity}");
            }
        }
    }
}
