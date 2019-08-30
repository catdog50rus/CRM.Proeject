using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CRM.Proeject.BL.Model
{
    public class ShopComputerModel
    {
        Generator Generator = new Generator();
        Random rnd = new Random();

        public List<CashDesk> CashDesks { get; set; } = new List<CashDesk>();
        public List<Cart> Carts { get; set; } = new List<Cart>();
        public List<Check> Checks { get; set; } = new List<Check>();
        public List<Sell> Sells { get; set; } = new List<Sell>();
        public Queue<Seller> Sellers { get; set; } = new Queue<Seller>();


        public ShopComputerModel()
        {
            var sellers = Generator.GetNewSellers(20);
            Generator.GetNewProducts(1000);
            Generator.GetNewCustomers(100);

            foreach(var seller in sellers)
            {
                Sellers.Enqueue(seller);
            }

            for(int i = 0; i < 3; i++) // 3 кассы
            {
                CashDesks.Add(new CashDesk(CashDesks.Count, Sellers.Dequeue()));
            }
        }

        public void Start()
        {
            var customers = Generator.GetNewCustomers(10);
            var carts = new List<Cart>();
            foreach(var customer in customers)
            {
                var cart = new Cart(customer);
                foreach(var prod in Generator.GetRandomProducts(10, 30))
                {
                    cart.Add(prod);
                }

                carts.Add(cart);
            }

            

            foreach (var cart in carts)
            {
                var cash = CashDesks[rnd.Next(CashDesks.Count-1)];
                cash.Enqueue(cart);
                carts.Remove(cart);
            }

            while(true)
            {
                var cash = CashDesks[rnd.Next(CashDesks.Count - 1)];
                cash.Dequeue();
            }
        }
    }
}
