// Decompiled with JetBrains decompiler
// Type: level_0.Class1
// Assembly: level-0, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: FD055372-2D57-4CB4-8943-ADEA38050456
// Assembly location: C:\Dev\CSA\premium-server\level-0.exe

using Cryptography.Obfuscation;
using System;

namespace level_0
{
  internal class Class1
  {
    private Obfuscator ob = new Obfuscator();
    public string lvl = ",',',',,,',,`,',',''',',,`,',',,'','',`,',',,'''','`,',',,'',,',`,',',''',','`,',',,''',',`,',','''',,,`,',',,''',''`,',','''',,,`,',','''',,,`,',',''',,,'`,',','''',,,`,',','''',,,`,',',''',,,'`,',',',,,',,`,',',''',',,`,',',,'','',`,',',,'''','`,',',,'',,',`,',',''',','`,',',,''',',`,',','''',,,`,',',,''',''`";
    public string lvl1 = ",',','',,'''`,',',',,,',,`,',',,''',''`,',',,''''''`,',',,''',',`,',',',',',,`,',',,''',,'`,',',,'''','`,',',',,,,''`,',',,''',',`,',',','''''`,',',,'',','`,',','',,,,,`,',',',,,,''`,',',,'','',`,',',',,,,''`";
    public string lvl2 = ",',',','''''`,',',,''',',`,',',,'',,',`,',',',,,'''`,',',,'''',,`,',',,''''''`,',',',,,',,`,',',',',,''`,',',,'',','`,',',',,,,''`,',',,'','',`,',',',',',,`,',',,''',,'`,',',,'''','`,',',',,,,''`,',',,''',',`";
    public string lvl3 = ",',',',,,,',`,',',,'''',,`,',',',,,'''`,',',',,,,,'`,','',,,',,,`,',',,','','`,','',,,',,,`,',',,',''''`,',',''',','`,',',,'',','`,',',',,',,'`,',',,',''''`,',','''',,,`,',',,'',,''`,',',',,',,'`,',',',,,,,'`,',','''',,,`,',',''',,,'`,',',',,',,'`,',',''','''`,',',''',,,'`,',',',,',,'`,',',',,,'',`,',',,'','',`,',',,'',,''`,',',',,,,,,`,','',,,',,,`,',',,',',''`";
    public string decOne = "70jZ2xXV";
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
      num6.ToString();
      string oldValue = num7.ToString();
      string str1 = input;
      string str2 = (string) null;
      foreach (int num8 in str1)
      {
        string str3 = (Convert.ToString(((num8 + num1) * num2 - num3) / num4 + num5, toBase) + " ").Replace('1', ',').Replace(oldValue, "'").Replace(" ", "`");
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
      num6.ToString();
      string newValue = num7.ToString();
      string str1 = input;
      string str2 = str1.Remove(str1.Length - 1, 1);
      string str3 = (string) null;
      string str4 = str2.Replace(',', '1').Replace("'", newValue).Replace("`", " ");
      char[] chArray = new char[1]{ ' ' };
      foreach (string str5 in str4.Split(chArray))
      {
        char ch = (char) (((Convert.ToInt32(str5, fromBase) - num5) * num4 + num3) / num2 - num1);
        str3 += ch.ToString();
      }
      return str3;
    }
  }
}
