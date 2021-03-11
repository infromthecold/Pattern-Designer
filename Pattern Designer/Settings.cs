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
	public partial class Settings : Form
	{
		public	int	startPositionX;
		public	int	startPositionY;
		public Settings()
		{
			startPositionX		=	0;
			startPositionY		=	0;
			InitializeComponent();
		}
		private void okButonClick(object sender, EventArgs e)
		{

			if(TL.Checked==true)
			{
				startPositionX		=	(int)-(this.guideWidth.Value/2);
				startPositionY		=	(int)-(this.guideHeight.Value/2);
			}
			else if(TC.Checked==true)
			{				
				startPositionX		=	0;
				startPositionY		=	(int)-(this.guideHeight.Value/2);
			}
			else if(TR.Checked==true)
			{				
				startPositionX		=	(int)(this.guideWidth.Value/2);
				startPositionY		=	(int)-(this.guideHeight.Value/2);
			}
			else if(ML.Checked==true)
			{				
				startPositionX		=	(int)(this.guideWidth.Value/2);
				startPositionY		=	0;
			}
			else if(MC.Checked==true)
			{
				startPositionX		=	0;
				startPositionY		=	0;
			}
			else if(MR.Checked==true)
			{
				startPositionX		=	(int)(this.guideWidth.Value/2);
				startPositionY		=	(int)(this.guideHeight.Value/2);
			}
			else if(BL.Checked==true)
			{
				startPositionX		=	(int)-(this.guideWidth.Value/2);
				startPositionY		=	(int)(this.guideHeight.Value/2);
			}
			else if(BR.Checked==true)
			{
				startPositionX		=	(int)(this.guideWidth.Value/2);
				startPositionY		=	(int)(this.guideHeight.Value/2);
			}
			else// if(BC.Checked==true)
			{
				startPositionX		=	0;
				startPositionY		=	(int)(this.guideHeight.Value/2);
			}
			
		}
	}
}
