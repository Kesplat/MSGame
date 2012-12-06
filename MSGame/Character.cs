using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MSGame
{
	public class Character : GameObject
	{
		protected int health, maxHealth;
		
		public Character(double xIn, double yIn, double hIn, double wIn, int healthIn)
								: base(xIn, yIn, hIn, wIn)
		{
			maxHealth = healthIn;
			health = healthIn;
		}
		
		public int getHealth()
		{
			return health;
		}
		
		public void heal(int healSize)
		{
			if (health + healSize > maxHealth)
				health = maxHealth;
			else
				health+ = healSize;
		}
		
		public void hit(Object hitObj)
		{
			health -= hitObj.getDamage();
		}
		
	}
}