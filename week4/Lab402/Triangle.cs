using System;

namespace Lab4
{
	public class Triangle : Shape
	{
		double width=1.0,height=1.0;
		string color;
		
		public double Width{
            		get { return width; }
            		set { if (value>=0) width = value; else width=1; }
        	}
		
		public double Height{
            		get { return height; }
            		set { if (value>=0) height = value; else height=1; }
        	}
		
		public string Color{
            		get { return color; }
        	}
		
		public Triangle(){ //basic form
			setValue(1,1); setColor("gold");
        	}
		
		public Triangle(string a,double w,double h){
			setValue(w,h); setColor(a);
        	}
		
		public Triangle(Triangle a){
			setValue(a.width,a.height); setColor(a.color);
		}
		
		public void setValue(double w,double h){
			if(w<=0) width=1; else width=w;
			if(h<=0) height=1; else height=h;
        	}

		public void setColor(string a){
			color =a;
        	}
		
		public override double getArea(){		
			return width*height/2;
        	}
		
		public override double printPerimeter(){
			return width + height + Math.Sqrt((width * width) + (height * height));
		}
			
		public override string ToString(){
			return "[Triangle: width="+width+", height="+height+", area="+getArea()+", color=\""+color+"\"]";
        	}
		
	}
}

