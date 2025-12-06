// https://xn--5dbqnj.xn--eebf2b.com/oop/02-polymorphism-cs.pptx
// https://מבני.שלי.com/oop/02-polymorphism-cs.pptx

namespace ConsPolym;
public class TestClothes
{
  static void Main(string[] args)
  {

    ClothingItem[] clothingItems = // 2023 syntax
    [
      new ClothingItem(color: "blue", fabric: "cotton"),
      new Shirt(color: "blue", fabric: "cotton",size:'s'),
      new Pants(color: "black", fabric: "jeans", size: 36),
      new ClothingItem(color: "pink", fabric: "silk"),
      new Shirt(color: "green", fabric: "cotton", size: 'm'),
    ];

    foreach (var item in clothingItems)
      item.PrintSpecial();

    Pants p = new Pants("blue", "jeans", 36);
    Shirt sh1 = new Shirt("green", "silk", 'S');
    ClothingItem cl_p = p;
    ClothingItem cl_sh1 = sh1;

    string f1 = cl_p.GetFabric();
    int size3 = sh1.GetSize();
    //int size3b = cl_sh1.GetSize();
    char ch5 = sh1.GetSize();
    //int size4 = cl_p.GetSize();
    //char ch6 = cl_p.GetSize();
    string st2=p.GetFabric();
    //int size1 = p.GetSize();
    //int size2 = c.GetSize();
    //Shirt s = new Shirt(color: "green", fabric: "silk", size: 's');
    //PrintColorAndFabric(s);


    int size;
    if (cl_p is Pants pants) // 2017 pattern matching
      size = pants.GetSize();

    if (cl_p is Pants)
      size = ((Pants)cl_p).GetSize();

  }

  public static void PrintColorAndFabric(Shirt shirt)
  {
    Console.WriteLine(shirt.GetColor());
    Console.WriteLine(shirt.GetFabric());
  }
}


