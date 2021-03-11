using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pattern_Designer
{
	class Sprite
	{
		public	short	x;		// yes ints rather than floats as its 8 
		public	short	y;
		public	byte	delay;
		public	byte	time;
		public	byte	direction;
		public	sbyte	turn;
		public	sbyte	speed;
		public	int	type;
		public	Color	color;
		public	int	patternIndex;
		public	bool	active;

	}
}
