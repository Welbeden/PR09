using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace RandWindow
{
  public partial class Form1 : Form
  {
    public Form1()
    {
      InitializeComponent();
    }

    Random rnd = new Random();
    Point tmp_location;

    int _w = System.Windows.Forms.SystemInformation.PrimaryMonitorSize.Width;
    int _h = System.Windows.Forms.SystemInformation.PrimaryMonitorSize.Height;

    private void textBox2_MouseMove(object sender, MouseEventArgs e)
    {
      textBox1.Text = e.X.ToString();
      textBox2.Text = e.Y.ToString();

      if (e.X > 120 && e.X < 225 && e.Y > 320 && e.Y < 370)
      {
        tmp_location = this.Location;
        tmp_location.X += rnd.Next(-100, 100);
        tmp_location.Y += rnd.Next(-100, 100);

        if (tmp_location.X < 0 || tmp_location.X > (_w - this.Width / 2) || tmp_location.Y < 0 || tmp_location.Y > (_h - this.Height / 2))
        {
          tmp_location.X = _w / 2;
          tmp_location.Y = _h / 2;
        }

        this.Location = tmp_location;
      }
    }

    private void button1_MouseClick(object sender, MouseEventArgs e)
    {
      MessageBox.Show("Вы усердны!!");
      Application.Exit();
    }

    private void button2_MouseClick(object sender, MouseEventArgs e)
    {
      MessageBox.Show("Мы не сомневались в вешем безразличии", "Внимание", MessageBoxButtons.OK, MessageBoxIcon.Information);
    }

    private void Form1_MouseMove(object sender, MouseEventArgs e)
    {
      textBox1.Text = e.X.ToString();
      textBox2.Text = e.Y.ToString();

      if (e.X > 90 && e.X < 200 && e.Y > 190 && e.Y < 230)
      {
        tmp_location = this.Location;
        tmp_location.X += rnd.Next(-100, 100);
        tmp_location.Y += rnd.Next(-100, 100);

        if (tmp_location.X < 0 || tmp_location.X > (_w - this.Width / 2) || tmp_location.Y < 0 || tmp_location.Y > (_h - this.Height / 2))
        {
          tmp_location.X = _w / 2;
          tmp_location.Y = _h / 2;
        }

        this.Location = tmp_location;
      }
    }
  }
}
