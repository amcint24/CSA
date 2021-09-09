// Decompiled with JetBrains decompiler
// Type: level_2.Window1
// Assembly: level-2, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 67EF0DB1-F044-4536-B25C-27A6461B7BE5
// Assembly location: C:\Dev\CSA\lock\level-2.exe

using System;
using System.CodeDom.Compiler;
using System.ComponentModel;
using System.Diagnostics;
using System.IO;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Markup;

namespace level_2
{
  public partial class Window1 : Window, IComponentConnector
  {
    public string check;
    internal Button unlock;
    internal Button exit;
    private bool _contentLoaded;

    public Window1() => this.InitializeComponent();

    private void exit_Click(object sender, RoutedEventArgs e) => this.Close();

    private void unlock_Click(object sender, RoutedEventArgs e)
    {
      Class1 class1 = new Class1();
      Class2 class2 = new Class2();
      class2.inp = this.check;
      string str = "flag.txt";
      class2.first();
      class2.second();
      string fin = class2.fin;
      string contents = class1.dec(fin);
      try
      {
        if (File.Exists(str))
        {
          FileInfo fileInfo = new FileInfo(str);
          File.WriteAllText(str, contents);
          int num = (int) MessageBox.Show("File successfully recoreved to: " + fileInfo.FullName);
        }
        else
        {
          FileInfo fileInfo = new FileInfo(str);
          File.Create(str);
          File.WriteAllText(str, contents);
          int num = (int) MessageBox.Show("File successfully recoreved to: " + fileInfo.FullName);
        }
      }
      catch
      {
        int num = (int) MessageBox.Show("Sorry , an error occured");
      }
    }

    [DebuggerNonUserCode]
    [GeneratedCode("PresentationBuildTasks", "4.0.0.0")]
    public void InitializeComponent()
    {
      if (this._contentLoaded)
        return;
      this._contentLoaded = true;
      Application.LoadComponent((object) this, new Uri("/level-2;component/window1.xaml", UriKind.Relative));
    }

    [DebuggerNonUserCode]
    [GeneratedCode("PresentationBuildTasks", "4.0.0.0")]
    [EditorBrowsable(EditorBrowsableState.Never)]
    void IComponentConnector.Connect(int connectionId, object target)
    {
      if (connectionId != 1)
      {
        if (connectionId == 2)
        {
          this.exit = (Button) target;
          this.exit.Click += new RoutedEventHandler(this.exit_Click);
        }
        else
          this._contentLoaded = true;
      }
      else
      {
        this.unlock = (Button) target;
        this.unlock.Click += new RoutedEventHandler(this.unlock_Click);
      }
    }
  }
}
