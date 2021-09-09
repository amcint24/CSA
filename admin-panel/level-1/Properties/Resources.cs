// Decompiled with JetBrains decompiler
// Type: level_1.Properties.Resources
// Assembly: level-1, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 29ECC2F5-03A7-420C-A7B3-84FAD542B83D
// Assembly location: C:\Dev\CSA\admin-panel\level-1.exe

using System.CodeDom.Compiler;
using System.ComponentModel;
using System.Diagnostics;
using System.Globalization;
using System.Resources;
using System.Runtime.CompilerServices;

namespace level_1.Properties
{
  [GeneratedCode("System.Resources.Tools.StronglyTypedResourceBuilder", "4.0.0.0")]
  [DebuggerNonUserCode]
  [CompilerGenerated]
  internal class Resources
  {
    private static ResourceManager resourceMan;
    private static CultureInfo resourceCulture;

    internal Resources()
    {
    }

    [EditorBrowsable(EditorBrowsableState.Advanced)]
    internal static ResourceManager ResourceManager
    {
      get
      {
        if (level_1.Properties.Resources.resourceMan == null)
          level_1.Properties.Resources.resourceMan = new ResourceManager("level_1.Properties.Resources", typeof (level_1.Properties.Resources).Assembly);
        return level_1.Properties.Resources.resourceMan;
      }
    }

    [EditorBrowsable(EditorBrowsableState.Advanced)]
    internal static CultureInfo Culture
    {
      get => level_1.Properties.Resources.resourceCulture;
      set => level_1.Properties.Resources.resourceCulture = value;
    }
  }
}
