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
	public partial class Pattern : Form
	{
		public	PatternDesigner	main;
		public	int		index;			
		public	byte		direction		=	0;
		public	byte		delay			=	0;
		public	sbyte		turn			=	0;
		public	sbyte		speed			=	0;
		public	byte		time			=	0;
		public	int		spawn			=	0;
		public	loopContainer	loopBox			=	null;

		public	int getIndex()
		{
			return	index;
		}
		public	byte getDirection()
		{
			return	direction;
		}
		public	byte getDelay()
		{
			return	delay;
		}
		public	sbyte getSpeed()
		{
			return	speed;
		}
		public	sbyte getTurn()
		{
			return	turn;
		}
		public	byte getTime()
		{
			return	time;
		}
		public	int getSpawn()
		{
			return	spawn;
		}
		public	loopContainer getLoopbox()
		{
			return	loopBox;
		}
		public Pattern(PatternDesigner mainForm)
		{
			main	=	mainForm;	
			InitializeComponent();			
		}
		
		public	void	addLoopBox(loopContainer thatLoopBox)
		{
			loopBox		=	thatLoopBox;
		}
		private void updateSelected(object sender, EventArgs e)
		{
			delay			=	(byte)udDelay.Value;		
			direction		=	(byte)udDirection.Value;		
			turn			=	(sbyte)udTurn.Value;		
			speed			=	(sbyte)udSpeed.Value;		
			time			=	(byte)udTime.Value;		
			spawn			=	(int)spawnBox.SelectedIndex;
		}

		private void expandCollapse(object sender, EventArgs e)
		{
			if(this.Height>33)
			{
				this.Height	=	33;	
			}
			else
			{
				this.Height	=	226;
			}
			main.updatePatterns();
		}

		private void Pattern_Load(object sender, EventArgs e)
		{

		}

		private void setColour(object sender, EventArgs e)
		{
			this.BackColor	=	ControlPaint.Light (Color.FromName(this.colorBox.SelectedItem.ToString()),0.85f);
		}
	}
}
