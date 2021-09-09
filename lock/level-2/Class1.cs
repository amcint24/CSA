// Decompiled with JetBrains decompiler
// Type: level_2.Class1
// Assembly: level-2, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 67EF0DB1-F044-4536-B25C-27A6461B7BE5
// Assembly location: C:\Dev\CSA\lock\level-2.exe

using Cryptography.Obfuscation;
using System;

namespace level_2
{
  public class Class1
  {
    private Obfuscator ob = new Obfuscator();
    public string impP = "<>><>><><<><<+<>><>><><<<><+<>><>><><<><<+<>><>><><<<<>+<>><>><><<<<>+<>><>><><<<>>+";
    public string imp2 = "<>><>><<<>>>>+<>><><>><><><+<>><><>><<<><+<>><><>>><>>>+<>><><>><>><<+<>><><>><>>>>+<>><><>>><><<+<>><>><>>><<<+<>><>><<<><<<+<>><>><<<>>>>+<>><>><<<><><+<>><>><><>><<+<>><>><>>><<<+<>><>><<<><<<+<>><><>><>><<+<>><><>>><<>>+<>><><>>><>>>+<>><><>><<><>+<>><><>>><<>>+<>><>><>>><<<+<>><>><<<<><<+<>><><>><<>><+<>><><><>>>>>+<>><>><>>><<<+<>><>><<><>>>+<>><><>>><<<>+<>><><>>><>>>+<>><><>><>>>>+<>><><>><><><+";
    public string decOne = "EcFuNr4X";
    public string decTwo = "7M7MVukE";
    public string decThree = "q2CDguQW";
    public string decFour = "7M7MVukE";
    public string decFive = "7zr4ZQ0Y";
    public string decSix = "dxDNMdgC";
    public string decSeven = "B7gZMAkD";
    public string decEight = "7M7MVukE";

    public string enc(string input)
    {
      int num1 = this.ob.Deobfuscate(this.decOne);
      int num2 = this.ob.Deobfuscate(this.decTwo);
      int num3 = this.ob.Deobfuscate(this.decThree);
      int num4 = this.ob.Deobfuscate(this.decFour);
      int num5 = this.ob.Deobfuscate(this.decFive);
      int num6 = this.ob.Deobfuscate(this.decSix);
      int num7 = this.ob.Deobfuscate(this.decSeven);
      int toBase = this.ob.Deobfuscate(this.decEight);
      string oldValue1 = num6.ToString();
      string oldValue2 = num7.ToString();
      string str1 = input;
      string str2 = (string) null;
      foreach (int num8 in str1)
      {
        string str3 = (Convert.ToString(((num8 + num1) * num2 - num3) / num4 + num5, toBase) + " ").Replace(oldValue1, "<").Replace(oldValue2, ">").Replace(" ", "+");
        str2 += str3;
      }
      return str2;
    }

    public string dec(string input)
    {
      int num1 = this.ob.Deobfuscate(this.decOne);
      int num2 = this.ob.Deobfuscate(this.decTwo);
      int num3 = this.ob.Deobfuscate(this.decThree);
      int num4 = this.ob.Deobfuscate(this.decFour);
      int num5 = this.ob.Deobfuscate(this.decFive);
      int num6 = this.ob.Deobfuscate(this.decSix);
      int num7 = this.ob.Deobfuscate(this.decSeven);
      int fromBase = this.ob.Deobfuscate(this.decEight);
      string str1 = num6.ToString();
      string newValue1 = num7.ToString();
      string str2 = input;
      string str3 = str2.Remove(str2.Length - 1, 1);
      string str4 = (string) null;
      string newValue2 = str1;
      string str5 = str3.Replace("<", newValue2).Replace(">", newValue1).Replace("+", " ");
      char[] chArray = new char[1]{ ' ' };
      foreach (string str6 in str5.Split(chArray))
      {
        char ch = (char) (((Convert.ToInt32(str6, fromBase) - num5) * num4 + num3) / num2 - num1);
        str4 += ch.ToString();
      }
      return str4;
    }
  }
}
