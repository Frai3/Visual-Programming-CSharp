using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LatihanInheritance
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        public class window
        {
            public window(int top, int left)
            {
                this.top = top;
                this.left = left;
            }

            public void DrawWindow()
            {
                Console.WriteLine("Drawing Window at {0}, {1}", top, left);
            }

            private int top;
            private int left;

            public class ListBox : window
            {
                public ListBox(int top, int left, string theContent) : base(top, left)
                {
                    mListBoxContents = theContent;
                }
            }

            public new void DrawWindow()
            {
                base.DrawWindow();
                Console.WriteLine("Writing string to the list box: {0}", mListBoxContents);
            }

            private string mListBoxContents;
            
        }
    
        public class Tester
        {
            public static void Main()
            {
                window w = new window(5, 10);
                w.DrawWindow();

                ListBox lb = new ListBox(20, 30, "Hello World");
                lb.DrawWindow();
            }
        }

    }
}