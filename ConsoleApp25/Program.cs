/*
 * Write a program in C# Sharp to generate an Inner Join between two data sets.
 * Expected Output :
 * 
 * Item ID         Item Name       Purchase Quantity                                                             
 * -------------------------------------------------------                                                       
 * 1               Biscuit                 458                                                                   
 * 2               Chocolate               650                                                                   
 * 3               Butter                  800                                                                   
 * 3               Butter                  900                                                                   
 * 3               Butter                  900                                                                   
 * 4               Brade                   700                                                                   
 * 4               Brade                   650
 */

namespace ConsoleApp25
{
    class Item_mast
    {
        public int ItemId { get; set; }
        public string? ItemDes { get; set; }

    }

    class Purchase
    {
        public int InvNo { get; set; }
        public int ItemId { get; set; }
        public int  PurQty { get; set; }
    }

    internal class Program
    {
        static void Main(string[] args)
        {
            List<Item_mast> itemList = new List<Item_mast>
            {
            new Item_mast { ItemId = 1, ItemDes = "Biscuit" },
            new Item_mast { ItemId = 2, ItemDes = "Chocolate" },
            new Item_mast { ItemId = 3, ItemDes = "Butter" },
            new Item_mast { ItemId = 4, ItemDes = "Brade" },
            new Item_mast { ItemId = 5, ItemDes = "Honey" }
            };

            List<Purchase> purchlist = new List<Purchase>
            {
            new Purchase { InvNo=100, ItemId = 3,  PurQty = 800 },
            new Purchase { InvNo=101, ItemId = 2,  PurQty = 650 },
            new Purchase { InvNo=102, ItemId = 3,  PurQty = 900 },
            new Purchase { InvNo=103, ItemId = 4,  PurQty = 700 },
            new Purchase { InvNo=104, ItemId = 3,  PurQty = 900 },
            new Purchase { InvNo=105, ItemId = 4,  PurQty = 650 },
            new Purchase { InvNo=106, ItemId = 1,  PurQty = 458 }
            };

            var _list = from item in itemList
                        join p in purchlist
                        on item.ItemId equals p.ItemId
                        select new
                        {
                            item.ItemId,
                            item.ItemDes,
                            p.PurQty
                        };
            foreach ( var item in _list) Console.WriteLine($"{item.ItemId} || {item.ItemDes} || {item.PurQty}");
        }
    }
}
