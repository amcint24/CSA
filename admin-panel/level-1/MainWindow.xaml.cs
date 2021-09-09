// Decompiled with JetBrains decompiler
// Type: level_1.MainWindow
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
using System.Windows.Media;
using System.Windows.Shapes;

namespace level_1
{
  public partial class MainWindow : Window, IComponentConnector
  {
    private Class1 clss = new Class1();
    internal Image image;
    internal Rectangle continueBtn;
    internal Label label;
    internal Image image1;
    internal TextBox passBox;
    internal Rectangle loginBtn;
    internal Label label1;
    internal Path path;
    internal Label label2;
    internal Image image2;
    internal TextBlock textBlock;
    private bool _contentLoaded;

    public MainWindow() => this.InitializeComponent();

    private void image2_MouseDown(object sender, MouseButtonEventArgs e) => this.Close();

    private void label_MouseEnter(object sender, MouseEventArgs e)
    {
    }

    private void continueBtn_MouseEnter(object sender, MouseEventArgs e)
    {
    }

    private void loginBtn_MouseMove(object sender, MouseEventArgs e)
    {
    }

    private void loginBtn_MouseEnter(object sender, MouseEventArgs e) => this.loginBtn.Fill = (Brush) new SolidColorBrush(Color.FromRgb((byte) 181, (byte) 181, (byte) 200));

    private void loginBtn_MouseLeave(object sender, MouseEventArgs e) => this.loginBtn.Fill = (Brush) new SolidColorBrush(Color.FromRgb((byte) 244, (byte) 244, (byte) 243));

    private void label1_MouseDown(object sender, MouseButtonEventArgs e)
    {
      if (this.clss.enc(this.passBox.Text) == this.clss.lvl)
      {
        this.Hide();
        string str = this.clss.dec(this.clss.lvl1);
        new Window1() { flagBox = { Text = str } }.Show();
        this.Close();
      }
      else
      {
        this.Hide();
        string str = this.clss.dec(this.clss.lvl2);
        new Window1() { flagBox = { Text = str } }.Show();
        this.Close();
      }
    }

    private void loginBtn_MouseDown(object sender, MouseButtonEventArgs e)
    {
      if (this.clss.enc(this.passBox.Text) == this.clss.lvl)
      {
        this.Hide();
        string str = this.clss.dec(this.clss.lvl1);
        new Window1() { flagBox = { Text = str } }.ShowDialog();
        this.Close();
      }
      else
      {
        this.Hide();
        string str = this.clss.dec(this.clss.lvl2);
        new Window1() { flagBox = { Text = str } }.ShowDialog();
        this.Close();
      }
    }

    [DebuggerNonUserCode]
    [GeneratedCode("PresentationBuildTasks", "4.0.0.0")]
    public void InitializeComponent()
    {
      if (this._contentLoaded)
        return;
      this._contentLoaded = true;
      Application.LoadComponent((object) this, new Uri("/level-1;component/mainwindow.xaml", UriKind.Relative));
    }

    [DebuggerNonUserCode]
    [GeneratedCode("PresentationBuildTasks", "4.0.0.0")]
    [EditorBrowsable(EditorBrowsableState.Never)]
    void IComponentConnector.Connect(int connectionId, object target)
    {
      switch (connectionId)
      {
        case 1:
          this.image = (Image) target;
          break;
        case 2:
          this.continueBtn = (Rectangle) target;
          this.continueBtn.MouseEnter += new MouseEventHandler(this.continueBtn_MouseEnter);
          break;
        case 3:
          this.label = (Label) target;
          break;
        case 4:
          this.image1 = (Image) target;
          break;
        case 5:
          this.passBox = (TextBox) target;
          break;
        case 6:
          this.loginBtn = (Rectangle) target;
          this.loginBtn.MouseMove += new MouseEventHandler(this.loginBtn_MouseMove);
          this.loginBtn.MouseEnter += new MouseEventHandler(this.loginBtn_MouseEnter);
          this.loginBtn.MouseLeave += new MouseEventHandler(this.loginBtn_MouseLeave);
          this.loginBtn.MouseDown += new MouseButtonEventHandler(this.loginBtn_MouseDown);
          break;
        case 7:
          this.label1 = (Label) target;
          this.label1.MouseDown += new MouseButtonEventHandler(this.label1_MouseDown);
          break;
        case 8:
          this.path = (Path) target;
          break;
        case 9:
          this.label2 = (Label) target;
          break;
        case 10:
          this.image2 = (Image) target;
          this.image2.MouseDown += new MouseButtonEventHandler(this.image2_MouseDown);
          break;
        case 11:
          this.textBlock = (TextBlock) target;
          break;
        default:
          this._contentLoaded = true;
          break;
      }
    }
  }
}
