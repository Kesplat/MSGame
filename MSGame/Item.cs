using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MSGame
{
	public Weapon : UsableObject
	{
		
		public Weapon(double xIn, double yIn, double hIn, double wIn, bool stateIn, Player ifOwned)
								: base(xIn, yIn, hIn, wIn, stateIn, ifOwned)
		{
		}
		
		public void use()
		{
		}
		
	}
}