using System;

namespace Lab4
{
	public class Cylinder
	{
		Circle circle = new Circle();
		double height=1.0;
		double pi=Math.PI;
		
		public Cylinder (){
			height=1.0;
		}
		
		public Cylinder (double r,double h){
			height=h; circle.setRad(r); 
		}
		
		public Cylinder (double x,double y, double r, double h){
			height=h; circle.setRad(r); circle.setXYPos(x,y);
		}
		
		public Cylinder (Circle a){
			circle.setRad(a.Radius); circle.setPoint(a.getPoint());
		}
		
		public Cylinder (Cylinder a){
			circle.setRad(a.getRad()); circle.setPoint(a.getPoint()); height=a.height;
		}
		
		public double getRad(){
			return circle.Radius;
		}
		
		public Point getPoint(){
			return circle.pointPos;
		}
		
		public double getArea(){
			return (2*pi*getRad()*height) + (2*circle.getArea());
		}
		
		public double getVolume(){
			return (height*circle.getArea());
		}
		
		public override string ToString(){
			return "[Cylinder: " + getPoint() + ", radius=" + getRad() + ", height="+ height +
				",surface=" + getArea() +", volume= "+getVolume();
        	}
	}
}

