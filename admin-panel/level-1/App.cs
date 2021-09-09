// Decompiled with JetBrains decompiler
// Type: level_1.App
// Assembly: level-1, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 29ECC2F5-03A7-420C-A7B3-84FAD542B83D
// Assembly location: C:\Dev\CSA\admin-panel\level-1.exe

using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Windows;

namespace level_1
{
  public class App : Application
  {
    [DebuggerNonUserCode]
    [GeneratedCode("PresentationBuildTasks", "4.0.0.0")]
    public void InitializeComponent() => this.StartupUri = new Uri("MainWindow.xaml", UriKind.Relative);

    [STAThread]
    [DebuggerNonUserCode]
    [GeneratedCode("PresentationBuildTasks", "4.0.0.0")]
    public static void Main()
    {
      App app = new App();
      app.InitializeComponent();
      app.Run();
    }
  }
}
