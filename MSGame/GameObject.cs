using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MSGame
{
    public class GameObject
	{
		protected double xCoord, yCoord, height, width;
		
		public GameObject(double xIn, double yIn, double hIn, double wIn)
		{
			xCoord = xIn;
			yCoord = yIn;
			height = hIn;
			width = wIn;
		}
		
		public double getX()
		{
			return xCoord;
		}
		
		public double getY()
		{
			return yCoord;
		}
		
		public double getH()
		{
			return height;
		}
		
		public double getW()
		{
			return width;
		}
		
	}
}
