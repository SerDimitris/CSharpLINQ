/*
 * Write a program in C# Sharp to generate a Right
 * Outer Join between two data sets.
 * Expected Output :
 * 
 * Here is the list after joining  :                                                                             
 * 
 * Item ID         Item Name       Purchase Quantity                                                             
 * -------------------------------------------------------                                                       
 * 3               Butter                  800                                                                   
 * 5               Honey                   650                                                                   
 * 3               Butter                  900                                                                   
 * 4               Brade                   700                                                                   
 * 3               Butter                  900                                                                   
 * 4               Brade                   650                                                                   
 * 1               Biscuit                 458   
 */

namespace ConsoleApp27
{
    public class Item_list
    {
        public int ItemId {  get; set; }
        public string ItemName { get; set; }

    }

    public class Purchase
    {
        public int InvNo { get; set; }
        public int ItemId { get; set; }
        public int Quantity { get; set; }
    }
    internal class Program
    {
        static void Main(string[] args)
        {
            List<Item_list> list = new List<Item_list>
            {
                new Item_list { ItemId = 1, ItemName = "Biscuit"},
                new Item_list { ItemId = 2, ItemName = "Choco"},
                new Item_list { ItemId = 3, ItemName = "Butter"},
                new Item_list { ItemId = 4, ItemName = "Brade"},
                new Item_list { ItemId = 5, ItemName = "Honey"}
            };

            List<Purchase> purchase = new List<Purchase>
            {
                new Purchase { InvNo=100, ItemId = 3,  Quantity = 800 },
                new Purchase { InvNo=101, ItemId = 2,  Quantity = 650 },
                new Purchase { InvNo=102, ItemId = 3,  Quantity = 900 },
                new Purchase { InvNo=103, ItemId = 4,  Quantity = 700 },
                new Purchase { InvNo=104, ItemId = 3,  Quantity = 900 },
                new Purchase { InvNo=105, ItemId = 4,  Quantity = 650 },
                new Purchase { InvNo=106, ItemId = 1,  Quantity = 458 }
            };

            var _list = from purch in purchase
                        join it in list
                        on purch.ItemId equals it.ItemId into itemPurch
                        from it in itemPurch.DefaultIfEmpty()
                        select new
                        {
                            purch.InvNo,
                            purch.ItemId,
                            ItemName = it.ItemName ?? "UNKNOWN",
                            purch.Quantity
                        };
            foreach (var row in _list)
            {
                Console.WriteLine($"{row.InvNo}\t{row.ItemId}\t{row.ItemName}\t{row.Quantity}");
            }
                
        }
    }
}
