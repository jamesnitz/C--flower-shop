using System;
using System.Collections.Generic;

namespace flower_shop
{
  public class FlowerShop
  {
    public List<Lilly> LillyList = new List<Lilly>();
    public List<Rose> RoseList = new List<Rose>();
    public List<Dandelion> DandelionList = new List<Dandelion>();
    public List<CrabGrass> CrabList = new List<CrabGrass>();

    public List<IMothersDay> makeMotherArrangement()
    {
      List<IMothersDay> Arrangement = new List<IMothersDay>();
      Arrangement.Add(new Lilly());
      Arrangement.Add(new CrabGrass());

      return Arrangement;

    }
    public List<IBirthDay> makeBirthdayArrangement()
    {
      List<IBirthDay> BirthDayArrangement = new List<IBirthDay>();
      BirthDayArrangement.Add(new Dandelion());
      BirthDayArrangement.Add(new Rose());
      return BirthDayArrangement;
    }
    public List<IGetWell> makeGetWellArrangement()
    {
      List<IGetWell> getWellArrangements = new List<IGetWell>();
      getWellArrangements.Add(new Nightshade());
      getWellArrangements.Add(new Nightshade());
      getWellArrangements.Add(new Nightshade());
      return getWellArrangements;
    }



  }
}