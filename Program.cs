using System;
using System.Collections.Generic;

namespace flower_shop
{
  class Program
  {
    static void Main(string[] args)
    {
      Rose myRose = new Rose();

      Lilly myLilly = new Lilly();

      Dandelion myDandy = new Dandelion();

      CrabGrass myCrab = new CrabGrass();

      FlowerShop macFlowerShop = new FlowerShop();
      List<IBirthDay> Arrangement = macFlowerShop.makeBirthdayArrangement();


    }
  }
}
