using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MSGame
{
	public UsableObject : GameObject
	{
		protected bool onPlayer;
		protected Player owner;
		
		public UsableObject(double xIn, double yIn, double hIn, double wIn, bool stateIn, Player ifOwned)
								: base(xIn, yIn, hIn, wIn)
		{
			onPlayer = stateIn;
			owner = ifOwned;
		}
		
		public double getX()
		{
			if(onPlayer)
				return owner.getX();
			else
				return xCoord;
		}
		
		public double getY()
		{
			if(onPlayer)
				return owner.getY();
			else
				return yCoord;
		}
		
	}
}