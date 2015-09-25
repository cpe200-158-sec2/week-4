﻿using System;

namespace Lab4
{
	class MainClass
	{
		public static void Main (string[] args)
		{
			Shape s1 = new Rectangle("red", 4, 5); 			Console.WriteLine (s1);  			Shape s2 = new Triangle("blue", 4, 5); 			Console.WriteLine (s2);  			Shape s3 = new Rectangle(); 			Console.WriteLine (s3);  			Rectangle r1 = new Rectangle((Rectangle)s1); 			Console.WriteLine (r1); 			r1.Width=-5.0; r1.Height=15; 			//Console.WriteLine (r1);  			Triangle t1 = new Triangle(); 			t1.Width=3; t1.Height=4; 			//Console.WriteLine (t1);

            //			Shape s4 = new Shape("green"); 
            //			Console.WriteLine (s4);

            			Console.WriteLine ("Perimeter s1: "+printPerimeter (s1));
            			Console.WriteLine ("Perimeter s2: "+printPerimeter (s2));
            			Console.WriteLine ("Perimeter s3: "+printPerimeter (s3));
            			Console.WriteLine ("Perimeter r1: "+printPerimeter (r1));
            			Console.WriteLine ("Perimeter t1: "+printPerimeter (t1));
            Console.ReadKey();

        }
        private static double printPerimeter(Shape a)
        {
            return a.getPerimeter();
        }
    }
}
