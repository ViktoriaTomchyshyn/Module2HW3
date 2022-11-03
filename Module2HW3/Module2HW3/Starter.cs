using System;
using System.IO;

namespace Module2HW3
{
    public class Starter
    {
        public static void Run()
        {
            FullStore();
            Console.WriteLine("\n\n-Cosmetics sorted by price:-\n" + Store.GetInstance().SortByPrice().FormatCosmeticsArray());
            Console.WriteLine("\n-Average price-\n" + Store.GetInstance().Cosmetics.GetAveragePrice());
            Console.WriteLine("\n-Cosmetics with lower than average price-\n" + Store.GetInstance().FindCosmeticsWithLowerPrice().FormatCosmeticsArray());
            Console.WriteLine("\n-Average capacity-\n" + Store.GetInstance().Cosmetics.GetAverageCapacity());
            Console.WriteLine("\n-Cosmetics with bigger than average capacity-\n" + Store.GetInstance().FindCosmeticsWithBiggestCapacity().FormatCosmeticsArray());
            Console.WriteLine("\n-Cosmetics with name \"Gel\"-\n" + Store.GetInstance().GetByName("Gel").FormatCosmeticsArray());
            Console.WriteLine("\n-Cosmetics with name \"Cream\"-\n" + Store.GetInstance().GetByName("Cream").FormatCosmeticsArray());

            Console.WriteLine("\n-Trying cosmetics-");
            ICare care = (ICare)Store.GetInstance().GetByName("Cream")[0];
            Console.WriteLine("Testing cream: " + care.Care());
            IDraw draw = (IDraw)Store.GetInstance().GetByName("Lipstick")[0];
            Console.WriteLine("Testing lipstick: " + draw.Draw());
        }

        public static Cosmetic[] FullStore()
        {
            Cosmetic[] cosmetics =
            {
                new BodyCareCosmetic(300, "Lotion", 1500, "Moisturazing"),
                new BodyCareCosmetic(250, "Shower gel", 400, "Moisturazing"),
                new BodyCareCosmetic(500, "Scrab", 800, "Exfoliating"),
                new FaceCareCosmetic(50, "Cream", 780, "Lightening"),
                new FaceCareCosmetic(150, "Toner", 600, "Softening"),
                new FaceCareCosmetic(150, "Gel", 350, "Cleansening"),
                new FaceCareCosmetic(150, "Gel", 400, "Exfoliating"),
                new DecorativeCosmetic(4, "Lipstick", 380, "Make up", ColorEnum.Red),
                new DecorativeCosmetic(30, "Foundation", 560, "Make up", ColorEnum.White)
            };

            Store.GetInstance().Cosmetics = cosmetics;
            Console.Write(Store.GetInstance().ToString());

            return Store.GetInstance().Cosmetics;
        }
    }
}
