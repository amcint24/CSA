// Decompiled with JetBrains decompiler
// Type: level_2.Class2
// Assembly: level-2, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 67EF0DB1-F044-4536-B25C-27A6461B7BE5
// Assembly location: C:\Dev\CSA\lock\level-2.exe

namespace level_2
{
  public class Class2
  {
    private Class1 cls = new Class1();
    public string fin;
    public string inp;
    public string spOne = "<>><><>>><<><+<>><><>><>><<+<>><><>>><>>>+<>><><>>><<<>+<>><>><>>><<<+<>><><><>>><>+<>><>><>>><<<+<>><><>><<<<>+<>><>><><><<<+<>><><>><<<<>+<>><><>>>><<>+<>><><><>>>>>+<>><>><><><<<+<>><><>><<<>>+<>><><>>>><<>+<>><><>>><<<>+<>><>><><><<<+";
    public string spTwo = "<>><>><><<<<>+<>><><>>>><<>+<>><>><><<>>>+<>><>><><<<<>+<>><><>>>><<>+<>><><>>><><>+<>><>><><><<<+<>><>><><><<<+<>><>><><<>>>+<>><><>>>><<>+<>><><>>><><<+<>><><>><<<>>+<>><><>>><><<+<>><>><><<><>+<>><>><>>><<<+<>><><><>><>>+";
    public string imp = "<>><>><><<><<+<>><>><><<<><+<>><>><><<><<+<>><>><><<<<>+<>><>><><<<<>+<>><>><><<<>>+";
    public string epOne = "<>><>><<<>>>>+<>><><>><><><+<>><><>><<<><+<>><><>>><>>>+<>><><>><>><<+<>><><>><>>>>+<>><><>>><><<+<>><>><>>><<<+";
    public string epTwo = "<>><>><<><<><+<>><><>><>><<+<>><><>>><>>>+<>><><>>><<<>+";

    public void first()
    {
      if (this.inp == this.imp)
        this.fin += this.spOne;
      else
        this.fin += this.epOne;
    }

    public void second()
    {
      if (this.inp == this.imp)
        this.fin += this.spTwo;
      else
        this.fin += this.epTwo;
    }
  }
}
