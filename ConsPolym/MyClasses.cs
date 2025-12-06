// https://xn--5dbqnj.xn--eebf2b.com/oop/02-polymorphism-cs.pptx
// https://מבני.שלי.com/oop/02-polymorphism-cs.pptx

namespace ConsPolym;


public class ClothingItem
{
  public virtual void PrintSpecial()
  => Console.WriteLine("So special");


  private string color;
  private string fabric;

  public ClothingItem(string color, string fabric)
  {
    this.color = color;
    this.fabric = fabric;
  }

  public string GetFabric() => fabric;

  public void SetFabric(string value) => fabric = value;

  public string GetColor() => color;

  public void SetColor(string value) => color = value;



}
public class Shirt : ClothingItem
{
  public override void PrintSpecial()
  => Console.WriteLine("Very special");


  private char size;
  public Shirt(string color, string fabric, char size)
      : base(color, fabric)
  {
    this.size = size;
  }
  public char GetSize() => size;

  public void SetSize(char value) => size = value;


}

public class Pants : ClothingItem
{
  public override void PrintSpecial()
  => Console.WriteLine("Lovely & special");

  private int size;

  public Pants(string color, string fabric, int size)
      : base(color, fabric)
  {
    this.size = size;
  }
  public int GetSize() => size;

  public void SetSize(int value) => size = value;


}
