using System;

namespace ContohProtectedInheritance
{
    class Program
    {
        class akses
        {
            protected string role = "Administrator";
        }

//        class admin : akses
//        {
//            static void Main(string[] args)
//            {
//
//                akses mngr = new akses();
//                admin adm = new admin();
//                mngr.role = "Hello Manager!";
//                adm.role = "Hello Administrator!";
//
//           }
//        }

        class Shape
        {
            public void setWidth(int w)
            {
                width = w;
            }
            public void setHeight(int h)
            {
                height = h;
            }
            protected int width;
            protected int height;
        }

        // Child class
        class Rectangle : Shape
        {
            public int getArea()
            {
                return (width * height);
            }
        }

        class RectangleTester
        {
            static void Main(string[] args)
            {
                Rectangle Rect = new Rectangle();

                Rect.setWidth(5);
                Rect.setHeight(7);

                // Print the area of the object.
                Console.WriteLine("Total area: {0}", Rect.getArea());
                Console.ReadKey();
            }
        }
    }
}




