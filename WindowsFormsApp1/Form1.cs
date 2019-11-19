using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    public partial class Form1 : Form
    {
        private static readonly int delay = 60000;

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            
        }

        private void button1_Click(object sender, EventArgs e)
        {
            InfiniteMouseMove();

            Button b = (Button)sender;
            b.Text = "WORKING";
        }

        private async void InfiniteMouseMove()
        {

            while(true)
            {
                MoveCursor(true);
                await Task.Delay(delay);
                MoveCursor(false);
                await Task.Delay(delay);
            }

        }

        private void MoveCursor(bool left)
        {
            // Set the Current cursor, move the cursor's Position,
            // and set its clipping rectangle to the form. 

            this.Cursor = new Cursor(Cursor.Current.Handle);
            if(left)
            {
                Cursor.Position = new Point(Cursor.Position.X - 1, Cursor.Position.Y);
            }
            else
            {
                Cursor.Position = new Point(Cursor.Position.X + 1, Cursor.Position.Y);
            }
        }
    }
}
