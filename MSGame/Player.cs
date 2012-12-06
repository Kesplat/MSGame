using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MSGame
{
    public class Player : Character
	{
		protected string name;
		protected List<Weapons> weapons;
		protected List<Item> items;
		protected int aggro;
		protected Weapon currentWeapon;
		
		public Player(double xIn, double yIn, double hIn, double wIn, int healthIn, string nameIn)
								: base(xIn, yIn, hIn, wIn, healthIn)
		{
			name = nameIn;
		}
		
		public void shoot(double direction)
		{
			currentWeapon.fire(direction);
		}
		
		public void use(Item item)
		{
			item.use(this);
		}
		
		public void drop(int index)
		{
			items[index] = null;
		}
		
		public void taunt()
		{
		}
	}
}
