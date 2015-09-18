using System;

namespace Lab4
{
	public class Point
    	{
		double x=0,y=0;
		
		public double xpos{
        		get { return x; }
            		set { x = value; }
        	}
		
		public double ypos{
            		get { return y; }
            		set { y = value; }
        	}
		
		public Point(){ //basic form
			x=0; y=0;
        	}
		
		public Point(Point a){
			setValue(a.x,a.y);
		}
		
		public Point(double a, double b){
			setValue(a,b);
		}
		
		public void setValue(double xpos,double ypos){
			x=xpos; y=ypos;
        	}
		
		public override string ToString(){
            		return "center(" + x + "," + y + ")";
        	}
	}
}

