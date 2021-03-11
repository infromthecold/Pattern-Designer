using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Pattern_Designer
{
	public partial class loopContainer : Form
	{
		public	int		id		=	0;
		public	int		firstLink	=	0;
		public	int		lastLink	=	0;
		public	int		loopCounter	=	0;

		public	List<Pattern>	linkedPatterns	=	new	List<Pattern>();
		public loopContainer()
		{
			InitializeComponent();

			this.DoubleBuffered = true;
		}
		public	int		getId()
		{
			return		id;
		}
		public	int		getFirstLink()
		{
			return		firstLink;			
		}
		public	int		getLastLink()
		{			
			return		lastLink;
		}
		public	int		getLoopCounter()
		{			
			return		loopCounter;
		}
		public	int		getLoopCount()
		{			
			return		(int)this.loopCount.Value;
		}
		public	int	getLinkedPatternCount()
		{
			return	linkedPatterns.Count();
		}
		public	int	getLinkedPatternIndex(int ind)
		{
			return	linkedPatterns[ind].index;
		}

		public	void	addPattern(Pattern thisPattern)
		{
			linkedPatterns.Add(thisPattern);
		}
		public	void	addId(int thisId)
		{
			id	=	thisId;
		}
		public	int	removePattern(Pattern thatPattern)
		{
			for(int p=0;p<linkedPatterns.Count;p++)
			{
				if(linkedPatterns[p] == thatPattern)
				{
					linkedPatterns.Remove(linkedPatterns[p]);
					return	linkedPatterns.Count;
				}
			}
			return	linkedPatterns.Count;
		}
		public	bool	cointainsPattern(Pattern thatPattern)
		{
			for(int p=0;p<linkedPatterns.Count;p++)
			{
				if(linkedPatterns[p] == thatPattern)
				{
					return	true;
				}
			}
			return	false;
		}

		private void updateCounter(object sender, EventArgs e)
		{
			this.loopCounter	=	(int)this.loopCount.Value;
			this.SendToBack();
		}
	}
}
