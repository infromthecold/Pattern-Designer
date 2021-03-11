using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pattern_Designer
{
	public class displayPanel : System.Windows.Forms.Panel
	{
		public displayPanel() 
		{
			this.SetStyle(	System.Windows.Forms.ControlStyles.UserPaint | 
					System.Windows.Forms.ControlStyles.AllPaintingInWmPaint | 
					System.Windows.Forms.ControlStyles.OptimizedDoubleBuffer, 
					true);
		}
	}
}
