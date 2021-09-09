// Decompiled with JetBrains decompiler
// Type: level_2.MainWindow
// Assembly: level-2, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 67EF0DB1-F044-4536-B25C-27A6461B7BE5
// Assembly location: C:\Dev\CSA\lock\level-2.exe

using System;
using System.CodeDom.Compiler;
using System.ComponentModel;
using System.Diagnostics;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Input;
using System.Windows.Markup;

namespace level_2
{
  public partial class MainWindow : Window, IComponentConnector
  {
    internal TextBox pin;
    internal Button one;
    internal Button two;
    internal Button three;
    internal Button four;
    internal Button five;
    internal Button six;
    internal Button seven;
    internal Button eight;
    internal Button nine;
    internal Button ok;
    internal Button zero;
    internal Button exit;
    private bool _contentLoaded;

    public MainWindow() => this.InitializeComponent();

    private void exit_MouseDown(object sender, MouseButtonEventArgs e)
    {
    }

    private void exit_MouseEnter(object sender, MouseEventArgs e)
    {
    }

    private void exit_Click(object sender, RoutedEventArgs e) => this.Close();

    private void one_Click(object sender, RoutedEventArgs e) => this.pin.Text += "1";

    private void two_Click(object sender, RoutedEventArgs e) => this.pin.Text += "2";

    private void three_Click(object sender, RoutedEventArgs e) => this.pin.Text += "3";

    private void four_Click(object sender, RoutedEventArgs e) => this.pin.Text += "4";

    private void five_Click(object sender, RoutedEventArgs e) => this.pin.Text += "5";

    private void six_Click(object sender, RoutedEventArgs e) => this.pin.Text += "6";

    private void seven_Click(object sender, RoutedEventArgs e) => this.pin.Text += "7";

    private void eight_Click(object sender, RoutedEventArgs e) => this.pin.Text += "8";

    private void nine_Click(object sender, RoutedEventArgs e) => this.pin.Text += "9";

    private void zero_Click(object sender, RoutedEventArgs e) => this.pin.Text += "0";

    private void ok_Click(object sender, RoutedEventArgs e)
    {
      Class1 class1 = new Class1();
      string text = this.pin.Text;
      string str = class1.enc(text);
      if (str == class1.impP)
      {
        Window1 window1 = new Window1();
        window1.check = str;
        this.Hide();
        window1.ShowDialog();
        this.Close();
      }
      else
      {
        int num = (int) MessageBox.Show(class1.dec(class1.imp2));
      }
    }

    [DebuggerNonUserCode]
    [GeneratedCode("PresentationBuildTasks", "4.0.0.0")]
    public void InitializeComponent()
    {
      if (this._contentLoaded)
        return;
      this._contentLoaded = true;
      Application.LoadComponent((object) this, new Uri("/level-2;component/mainwindow.xaml", UriKind.Relative));
    }

    [DebuggerNonUserCode]
    [GeneratedCode("PresentationBuildTasks", "4.0.0.0")]
    [EditorBrowsable(EditorBrowsableState.Never)]
    void IComponentConnector.Connect(int connectionId, object target)
    {
      switch (connectionId)
      {
        case 1:
          this.pin = (TextBox) target;
          break;
        case 2:
          this.one = (Button) target;
          this.one.Click += new RoutedEventHandler(this.one_Click);
          break;
        case 3:
          this.two = (Button) target;
          this.two.Click += new RoutedEventHandler(this.two_Click);
          break;
        case 4:
          this.three = (Button) target;
          this.three.Click += new RoutedEventHandler(this.three_Click);
          break;
        case 5:
          this.four = (Button) target;
          this.four.Click += new RoutedEventHandler(this.four_Click);
          break;
        case 6:
          this.five = (Button) target;
          this.five.Click += new RoutedEventHandler(this.five_Click);
          break;
        case 7:
          this.six = (Button) target;
          this.six.Click += new RoutedEventHandler(this.six_Click);
          break;
        case 8:
          this.seven = (Button) target;
          this.seven.Click += new RoutedEventHandler(this.seven_Click);
          break;
        case 9:
          this.eight = (Button) target;
          this.eight.Click += new RoutedEventHandler(this.eight_Click);
          break;
        case 10:
          this.nine = (Button) target;
          this.nine.Click += new RoutedEventHandler(this.nine_Click);
          break;
        case 11:
          this.ok = (Button) target;
          this.ok.Click += new RoutedEventHandler(this.ok_Click);
          break;
        case 12:
          this.zero = (Button) target;
          this.zero.Click += new RoutedEventHandler(this.zero_Click);
          break;
        case 13:
          this.exit = (Button) target;
          this.exit.MouseDown += new MouseButtonEventHandler(this.exit_MouseDown);
          this.exit.MouseEnter += new MouseEventHandler(this.exit_MouseEnter);
          this.exit.Click += new RoutedEventHandler(this.exit_Click);
          break;
        default:
          this._contentLoaded = true;
          break;
      }
    }
  }
}
