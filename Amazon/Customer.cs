using System;

namespace Amazon
{
    public class Customer
    {
      public int Id { get; set; }
      public string Name { get; set; }

      public void Promote()
      {
        System.Console.WriteLine("Promote logic changed");
        // var rating = CalculateRating(excludeOrders: true);
        // if (rating == 0)
        //   System.Console.WriteLine("Promoted to Level1");
        // else  
        //   System.Console.WriteLine("Promoted to Level 2");
      }

      protected int CalculateRating(bool excludeOrders)
      {
        return 0;
      }
    }
}

    