using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void button1_MouseEnter(object sender, EventArgs e)
        {
            Random random = new Random();
            do
            {
                if (this.Width <= button1.Width + 100 && this.Height <= button1.Height + 100)
                {
                    MessageBox.Show("You caught me =)");
                    this.Close();
                }
                int TP = random.Next(1, 5);
                if (TP == 1)
                {
                    if (button1.Location.X + button1.Width < this.Width - 100)
                    {
                        button1.Location = new Point(button1.Location.X + button1.Width, button1.Location.Y);
                        break;
                    }
                    else
                    {
                        continue;
                    }
                }
                else if (TP == 2)
                {
                    if (button1.Location.X > 0)
                    {
                        button1.Location = new Point(button1.Location.X - button1.Width, button1.Location.Y);
                        break;
                    }
                    else
                    {
                        continue;
                    }
                }
                else if (TP == 3)
                {
                    if (button1.Location.Y + button1.Height < this.Height - 100)
                    {
                        button1.Location = new Point(button1.Location.X, button1.Location.Y + button1.Height);
                        break;
                    }
                    else
                    {
                        continue;
                    }
                }
                else if (TP == 4)
                {
                    if (button1.Location.Y > 0)
                    {
                        button1.Location = new Point(button1.Location.X, button1.Location.Y - button1.Height);
                        break;
                    }
                    else
                    {
                        continue;
                    }
                }
                else
                {
                    continue;
                }
            } while (true);
        }

        private void button1_MouseClick(object sender, MouseEventArgs e)
        {
            MessageBox.Show("How did you do that?" , "" , MessageBoxButtons.OK, MessageBoxIcon.Question);
            this.Close();
        }
    }
}
