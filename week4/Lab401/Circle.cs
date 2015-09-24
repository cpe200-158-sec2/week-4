using System;

namespace Lab4
{
	public class Circle
	{
		double radius=1;
		double pi=Math.PI;
		Point point = new Point();
		
		public double Radius{
            		get { return radius; }
            		set { radius = value; }
        	}	
		
		public Point pointPos{
            		get { return point; }
        	}
		
		public Circle (){
			point.setValue(0,0);
		}
		
		public Circle (double r){
			setRad(r); point.setValue(0,0);
		}
		
		public Circle (double x,double y,double r){
			setRad(r); point.setValue(x,y);
		}
		
		public Circle (Circle a){
			setRad(a.radius); setPoint(a.point);
		}
		
		public double getArea(){		
			return pi*radius*radius;
        	}
		
		public Point getPoint(){		
			return point;
        	}
		
		public void setRad(double r){
			if(r<0){
				radius=1;
			}
			else{
				radius=r;
			}
        	}
		
		public void setPoint(Point a){
			point.setValue(a.xpos,a.ypos);
        	}
		
		public void setXYPos(double x, double y){
			point.setValue(x,y);
        	}
		
		public override string ToString(){
			return "[Circle: " + point + ", radius=" + radius + ", area= "+getArea();
        	}
	}
}

