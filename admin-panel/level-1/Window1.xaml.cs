// Decompiled with JetBrains decompiler
// Type: level_1.Window1
// Assembly: level-1, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 29ECC2F5-03A7-420C-A7B3-84FAD542B83D
// Assembly location: C:\Dev\CSA\admin-panel\level-1.exe

using System;
using System.CodeDom.Compiler;
using System.ComponentModel;
using System.Diagnostics;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Input;
using System.Windows.Markup;

namespace level_1
{
  public partial class Window1 : Window, IComponentConnector
  {
    internal TextBox flagBox;
    private bool _contentLoaded;

    public Window1() => this.InitializeComponent();

    private void Image_MouseDown(object sender, MouseButtonEventArgs e) => this.Close();

    [DebuggerNonUserCode]
    [GeneratedCode("PresentationBuildTasks", "4.0.0.0")]
    public void InitializeComponent()
    {
      if (this._contentLoaded)
        return;
      this._contentLoaded = true;
      Application.LoadComponent((object) this, new Uri("/level-1;component/window1.xaml", UriKind.Relative));
    }

    [DebuggerNonUserCode]
    [GeneratedCode("PresentationBuildTasks", "4.0.0.0")]
    [EditorBrowsable(EditorBrowsableState.Never)]
    void IComponentConnector.Connect(int connectionId, object target)
    {
      if (connectionId != 1)
      {
        if (connectionId == 2)
          ((UIElement) target).MouseDown += new MouseButtonEventHandler(this.Image_MouseDown);
        else
          this._contentLoaded = true;
      }
      else
        this.flagBox = (TextBox) target;
    }
  }
}
