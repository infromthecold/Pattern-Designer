using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Globalization;
using System.IO;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml;

namespace Pattern_Designer
{
	public partial class PatternDesigner : Form
	{
		enum spawns
		{
			None,
			Shoot,
			Radial,
			Drop
		}
		enum spriteTypes
		{
			Object,
			Spawed
		}
		static Timer movementTimer = new Timer();

		private	Random			rand = new Random();
		public	List<Pattern>		patterns		=	new	List<Pattern>();
		//private int			scollPos;
		private	static	Sprite[]	sprites			=	new	Sprite[128];
		public	int			spriteCount		=	1;
		public	bool			paused			=	true;
		public	bool			steping			=	false;
		public	bool			running			=	false;
		public	int			patternIndex		=	0;
		public	int			selectedPattern		=	0;
		public	bool			dontUpdate		=	false;
		public	int			amountSprites		=	1;
		public	int			delayBetween		=	0;
		private	Settings		settingsPanel		=	new	Settings();
		private	Point			displayCenter;
		private	Random			randomNumber		=	new Random();
		private	int			randomSprite		=	0;
		private	SaveFileDialog		projectSaveDialog	=	new SaveFileDialog();
		private	SaveFileDialog		saveDataDialog		=	new SaveFileDialog();
		private	OpenFileDialog		projectOpenDialog	=	new OpenFileDialog();
		private	String			projectName;
		private	String			projectDirectory;
		public	List<loopContainer>	loopBoxes		=	new	List<loopContainer>();
		private		int		saveFilterIndex;

		private byte[]	sinTable =	{0x00,0x02,0x03,0x05,0x06,0x08,0x09,0x0b,0x0c,0x0e,
						0x10,0x11,0x13,0x14,0x16,0x17,0x18,0x1a,0x1b,0x1d,
						0x1e,0x20,0x21,0x22,0x24,0x25,0x26,0x27,0x29,0x2a,
						0x2b,0x2c,0x2d,0x2e,0x2f,0x30,0x31,0x32,0x33,0x34,
						0x35,0x36,0x37,0x38,0x38,0x39,0x3a,0x3b,0x3b,0x3c,
						0x3c,0x3d,0x3d,0x3e,0x3e,0x3e,0x3f,0x3f,0x3f,0x40,
						0x40,0x40,0x40,0x40,0x40};

		private byte[]	cosTable = 	{0x40,0x40,0x40,0x40,0x40,0x40,0x3f,0x3f,0x3f,0x3e,
						0x3e,0x3e,0x3d,0x3d,0x3c,0x3c,0x3b,0x3b,0x3a,0x39,
						0x38,0x38,0x37,0x36,0x35,0x34,0x33,0x32,0x31,0x30,
						0x2f,0x2e,0x2d,0x2c,0x2b,0x2a,0x29,0x27,0x26,0x25,
						0x24,0x22,0x21,0x20,0x1e,0x1d,0x1b,0x1a,0x18,0x17,
						0x16,0x14,0x13,0x11,0x10,0x0e,0x0c,0x0b,0x09,0x08,
						0x06,0x05,0x03,0x02,0x02};	

		private	void	addVector(int sprite)
		{
			byte	angle		=	sprites[sprite].direction;

			if(angle>=192 && angle <= 255)
			{
				angle			=	(byte)(angle - 192);
				sprites[sprite].x	+=	(short)-((sinTable[64-angle] * sprites[sprite].speed));
				sprites[sprite].y	+=	(short) ((cosTable[64-angle] * sprites[sprite].speed));
			}
			else if(angle>=128 && angle <= 191)
			{
				angle			=	(byte)(angle - 128);
				sprites[sprite].x	+=	(short)-((sinTable[angle] * sprites[sprite].speed));
				sprites[sprite].y	+=	(short)-((cosTable[angle] * sprites[sprite].speed));
			}
			else if(angle>=64 && angle <= 127)
			{
				angle			=	(byte)(angle - 64);
				sprites[sprite].x	+=	(short)((sinTable[64-angle]  * sprites[sprite].speed));
				sprites[sprite].y	+=	(short)-((cosTable[64-angle] * sprites[sprite].speed));
			}
			else //if(angle>=0 && angle <= 63)
			{
				sprites[sprite].x	+=	(short)((sinTable[angle] * sprites[sprite].speed));
				sprites[sprite].y	+=	(short)((cosTable[angle] * sprites[sprite].speed));
			}
		}

		public PatternDesigner()
		{
			InitializeComponent();
			this.loopBoxes.Clear();
			projectName		=	"patterns";
			projectDirectory	=	"f:/";
			
		}

		private	int	getEmptySprite()
		{
			for(int s=0;s<128;s++)
			{
				if(sprites[s].active==false)
				{
					return	s;
				}
			}
			return	127;
		}
		
		private	void	resetSprites()
		{
			if(patterns.Count>0)
			{ 
				Pattern	thisPattern	=	patterns[0];
				randomSprite		=	randomNumber.Next(1,(int)amount.Value);
				for(int s=0;s<128;s++)
				{
					sprites[s].active	=	false;
				}
				for(int s=0;s<(int)amount.Value;s++)
				{
					sprites[s].x		=	(short)(settingsPanel.startPositionX<<6);
					sprites[s].y		=	(short)(settingsPanel.startPositionY<<6);
					for(int p=0;p<patterns.Count;p++)
					{
						if(patterns[p].loopBox!=null)
						{
							patterns[p].loopBox.loopCounter		=	(int) patterns[p].loopBox.loopCount.Value;
						}
					}
					sprites[s].delay	=	(byte)(thisPattern.delay*s);
					sprites[s].time		=	thisPattern.time;
					sprites[s].direction	=	thisPattern.direction;
					sprites[s].turn		=	thisPattern.turn;
					sprites[s].speed	=	thisPattern.speed;
					sprites[s].color	=	thisPattern.BackColor;
					sprites[s].type		=	(int)spriteTypes.Object;
					sprites[s].active	=	true;
					sprites[s].patternIndex	=	0;
				}			
			}
		}

		private	void	loopedPattern(int s)
		{
			int	amMoSprite	=	0;	
			Pattern	thisPattern	=	patterns[sprites[s].patternIndex];
			
			// load details from new pattern			
			sprites[s].time		=	thisPattern.time;	
			sprites[s].delay	=	thisPattern.delay;
			sprites[s].direction	+=	thisPattern.direction;
			sprites[s].turn		=	thisPattern.turn;
			sprites[s].color	=	thisPattern.BackColor;
			sprites[s].speed	+=	thisPattern.speed;
			
			if(s	==	randomSprite)
			{ 
				switch (thisPattern.spawn)
				{
					case	(int)spawns.None:
						break;
					case	(int)spawns.Shoot:
						
						break;
					case	(int)spawns.Radial:
						for(int a=0;a<8;a++)
						{
							amMoSprite			=	getEmptySprite();	
							sprites[amMoSprite].direction	=	(byte)((a*32)+sprites[s].direction+16);
							sprites[amMoSprite].type	=	(int)spriteTypes.Spawed;
							sprites[amMoSprite].speed	=	sprites[s].speed;
							sprites[amMoSprite].x		=	sprites[s].x;
							sprites[amMoSprite].y		=	sprites[s].y;
							sprites[amMoSprite].active	=	true;
						}

						break;
					case	(int)spawns.Drop:
						amMoSprite			=	getEmptySprite();	
						sprites[amMoSprite].type	=	(int)spriteTypes.Spawed;
						sprites[amMoSprite].speed	=	0;
						sprites[amMoSprite].x		=	sprites[s].x;
						sprites[amMoSprite].y		=	sprites[s].y;
						sprites[amMoSprite].active	=	true;
						break;
				}
			}
			
		}

		private void	moveSprites(Object myObject, EventArgs myEventArgs) 
		{
			if((paused==false || steping == true) && (running==true || steping == true))
			{ 
				steping		=	false;
				for(int s=0;s<128;s++)
				{ 
					if(sprites[s].active==true)					
					{ 
						switch(sprites[s].type)
						{ 
							case	(int)spriteTypes.Object:
				  				if(sprites[s].delay>0)
				  				{
				  					sprites[s].delay--;
				  					continue;
				  				}
				  				if(sprites[s].time==0)
				  				{
									Pattern	thisPattern	=	patterns[sprites[s].patternIndex];

									if(thisPattern.loopBox!=null)
									{
										if(thisPattern.loopBox.lastLink == thisPattern.index)
										{
											// must be the end of the loop
											thisPattern.loopBox.loopCounter--;
											if(thisPattern.loopBox.loopCounter<0)
											{
												// reset the counter
												thisPattern.loopBox.loopCounter	=	(int)thisPattern.loopBox.loopCount.Value;
												sprites[s].patternIndex++;
											}
											else
											{
												sprites[s].patternIndex		=	thisPattern.loopBox.firstLink;
												loopedPattern(s);
												
											}
										}
										else
										{ 
				  							sprites[s].patternIndex++;
										}	
									}
									else
									{ 
				  						sprites[s].patternIndex++;
									}
				  					if(sprites[s].patternIndex>(patterns.Count-1))
				  					{
				  						if(s==spriteCount-1)	// are we the last sprite?
				  						{
				  							resetSprites();	// yes so reset all the sprites
											continue;	
				  						}
				  						sprites[s].patternIndex--;
				  						continue;		// wait for all to finish
				  					}
				  					else
				  					{
										loopedPattern(s);
										//continue;
				  					}
				  				}				  		
				  				sprites[s].direction	=	(byte)(sprites[s].direction+sprites[s].turn);
								addVector(s);
								sprites[s].time--;	
								break;								
							case	(int)spriteTypes.Spawed:
								addVector(s);	
								break;
						
						}
					}
				  }
			}	
			updateStatus();			
			displayArea.Invalidate(true);
			displayArea.Refresh();
		}

		private void PatternDesigner_Load(object sender, EventArgs e)
		{			
			//updatePatterns();	
		}

		private void scrollBar_Scroll(object sender, ScrollEventArgs e)
		{
			scrollPanel.Top		=	(-scrollBar.Value)+20;
			//updatePatterns();

		}
		private void display_Paint(object sender, PaintEventArgs e)
		{
			Graphics g	=		displayArea.CreateGraphics();
			
			Pen pen				=	new Pen(Color.Black,2.0f);
			float[]	dashValues		=	{ 4, 2};	
			pen.DashPattern			=	dashValues;

			Pen gpen			=	new Pen(Color.Black, 1.0f);
			float[]	gDashValues		=	{ 2, 2};			
			gpen.DashPattern		=	gDashValues;

			displayCenter.X			=	(displayArea.Width/2);
			displayCenter.Y			=	(displayArea.Height/2);
			g.DrawRectangle(pen, displayCenter.X-(int)(settingsPanel.guideWidth.Value/2), displayCenter.Y-(int)(settingsPanel.guideHeight.Value/2), (int)settingsPanel.guideWidth.Value, (int)settingsPanel.guideHeight.Value);
			if(settingsPanel.useGrid.Checked==true)			
			{			
				for(int gridX=0;gridX<(int)(settingsPanel.guideWidth.Value/2)/settingsPanel.gridSize.Value;gridX++)
				{
					g.DrawLine(gpen,displayCenter.X-(int)(gridX*settingsPanel.gridSize.Value),
							displayCenter.Y-(int)(settingsPanel.guideHeight.Value/2),
							displayCenter.X-(int)(gridX*settingsPanel.gridSize.Value),
							displayCenter.Y+(int)(settingsPanel.guideHeight.Value/2));	
					g.DrawLine(gpen,displayCenter.X+(int)(gridX*settingsPanel.gridSize.Value),
							displayCenter.Y-(int)(settingsPanel.guideHeight.Value/2),
							displayCenter.X+(int)(gridX*settingsPanel.gridSize.Value),
							displayCenter.Y+(int)(settingsPanel.guideHeight.Value/2));	
				}
				for(int gridY=0;gridY<(int)(settingsPanel.guideHeight.Value/2)/settingsPanel.gridSize.Value;gridY++)
				{
					g.DrawLine(gpen,displayCenter.X-(int)(settingsPanel.guideWidth.Value/2),
							displayCenter.Y-(int)(gridY*settingsPanel.gridSize.Value),
							displayCenter.X+(int)(settingsPanel.guideWidth.Value/2),
							displayCenter.Y-(int)(gridY*settingsPanel.gridSize.Value));
					g.DrawLine(gpen,displayCenter.X-(int)(settingsPanel.guideWidth.Value/2),
							displayCenter.Y+(int)(gridY*settingsPanel.gridSize.Value),
							displayCenter.X+(int)(settingsPanel.guideWidth.Value/2),
							displayCenter.Y+(int)(gridY*settingsPanel.gridSize.Value));
				}
			}
			 
			for(int s=0;s<128;s++)
			{ 
				Pen		sPen		=	new Pen(Color.Black, 1.0f);
				SolidBrush	solidFill	=	new SolidBrush(sprites[s].color); 
				if(sprites[s].active==true)					
				{ 
					g.FillEllipse(solidFill, displayCenter.X+((sprites[s].x>>6) - ((int)settingsPanel.spriteSize.Value/2)), displayCenter.Y + ((sprites[s].y>>6) - ((int)settingsPanel.spriteSize.Value/2)),(int) settingsPanel.spriteSize.Value/2,(int) settingsPanel.spriteSize.Value/2);   
					g.DrawEllipse(sPen, displayCenter.X+((sprites[s].x>>6) - ((int)settingsPanel.spriteSize.Value/2)), displayCenter.Y + ((sprites[s].y>>6) - ((int)settingsPanel.spriteSize.Value/2)),(int) settingsPanel.spriteSize.Value/2,(int) settingsPanel.spriteSize.Value/2);   

				}
			}
		}


		private void PatternDesigner_Shown(object sender, EventArgs e)
		{
			movementTimer.Tick	+=	new	EventHandler(moveSprites);
			movementTimer.Interval	=	1000/30;
			movementTimer.Start();
			patternIndex		=	0;
			for(int s=0;s<128;s++)
			{
				sprites[s]		=	new	Sprite();
				sprites[s].x		=	0;
				sprites[s].y		=	0;
			}
			pauseButtons();
			scrollPanel.Height	=	10000;
			this.DoubleBuffered = true;
		}
					
		private void linkChecked(object sender, EventArgs e)
		{
			int	firstLink	=	65535;
			int	lastLink	=	0;
			//bool	linked		=	false;
			checkPaused();
			for(int p=0;p<patterns.Count;p++)
			{
				if(patterns[p].checkBox.Checked==true)
				{	
					if(firstLink==65535)
					{
						firstLink	=	p;
					}
					else
					{
						lastLink	=	p;
					}				
				}			
			}	
			if(lastLink-firstLink>20)
			{
				MessageBox.Show("You cant link that many patterns as it will exceed a byte","Error", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
				return;
			}
			for(int p=0;p<patterns.Count;p++)
			{
				if(p>=firstLink && p<=lastLink)
				{
					if(patterns[p].loopBox!=null)
					{
						MessageBox.Show("Nested linked patterns not allowed, please unlink them first","Error", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
						return;
					}
				}
			}
			loopContainer	thisContainer		=	new	loopContainer();
			thisContainer.addId(loopBoxes.Count);
			thisContainer.SendToBack();
			thisContainer.firstLink			=	firstLink;
			thisContainer.lastLink			=	lastLink;
			loopBoxes.Add(thisContainer);
			thisContainer.TopLevel			=	false;
//			thisContainer.MdiParent		=	this;
			scrollPanel.Controls.Add(thisContainer);
			for(int p=0;p<patterns.Count;p++)
			{
				if(p>=firstLink && p<=lastLink)
				{ 
					thisContainer.addPattern(patterns[p]);					
					patterns[p].addLoopBox(thisContainer);
					//linked			=	true;
				}			
				patterns[p].checkBox.Checked	=	false;	
			}					
			updatePatterns();
		}

		private void unlinkChecked(object sender, EventArgs e)
		{
			int	firstLink	=	65535;
			int	lastLink	=	0;
			checkPaused();
			for(int p=0;p<patterns.Count;p++)
			{
				if(patterns[p].checkBox.Checked==true)
				{		
					
					if(firstLink==65535)
					{
						firstLink	=	patterns[p].loopBox.firstLink;		
						lastLink	=	patterns[p].loopBox.lastLink;	
					}
					else
					{
						lastLink	=	patterns[p].loopBox.lastLink;
						break;
					
					}				
				}			
			}	
			if(patterns[lastLink].getLoopbox()!=null && patterns[firstLink].getLoopbox() != null)
			{ 
				if(patterns[firstLink].loopBox.id!=patterns[lastLink].loopBox.id)
				{
					MessageBox.Show("You can not unlink in different loops","Error", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
					return;
				}
			
			}
			unchain(firstLink,lastLink);
			updatePatterns();
		}
		private	void	unchain(int firstLink,int lastLink)
		{ 
			for(int p=0;p<patterns.Count;p++)
			{
				if(p>=firstLink && p<=lastLink)
				{
					if(patterns[p].loopBox!=null)
					{
						if(patterns[p].loopBox.cointainsPattern(patterns[p])==true)
						{
							patterns[p].loopBox.removePattern(patterns[p]);							
							if(patterns[p].loopBox.linkedPatterns.Count<=1)
							{
								patterns[p].loopBox.linkedPatterns[0].loopBox	=	null;
								patterns[p].loopBox.linkedPatterns.Clear();										
								loopBoxes.RemoveAt(patterns[p].loopBox.id);	
								patterns[p].loopBox.Dispose();
							}
							patterns[p].loopBox	=	null;
							
						}
					}
				}				
				patterns[p].checkBox.Checked	=	false;	
			}
			
		}
		private void addActionButton_Click(object sender, EventArgs e)
		{
			checkPaused();
			
			Pattern thisPattern		=       new     Pattern(this);
			//.MdiParent		=	this;
			thisPattern.TopLevel		=	false;
			scrollPanel.Controls.Add(thisPattern);
			patterns.Add(thisPattern);	
			thisPattern.Width		=	250;
			thisPattern.Height		=	226;
			thisPattern.SetDesktopLocation(2,patterns.Count*(thisPattern.Height+2));
			thisPattern.BackColor		=	Color.FromName("LightBlue");
			thisPattern.Show();
			updatePatterns();
                   
		}
		private void deleteActionButton_Click(object sender, EventArgs e)
		{
			checkPaused();
			bool	deleted	=	true;	
			while(deleted)
			{
				deleted	=	false;	
				for(int p=0;p<patterns.Count;p++)
				{					
					if(patterns[p].checkBox.Checked==true)
					{
						if(patterns[p].loopBox!=null)
						{
							if(patterns[p].loopBox.cointainsPattern(patterns[p])==true)
							{			
								unchain(patterns[p].loopBox.firstLink,patterns[p].loopBox.lastLink);								
							}
						}
						patterns[p].Hide();
						patterns[p].Dispose();
						patterns.RemoveAt(p);	
						deleted	=	true;	
						break;
					}
				}
			}
			updatePatterns();
		}
		public	void	updatePatterns()
		{
		//	scollPos			=	scrollBar.Value;
			int		runningY	=	0;
			int		linkedFirstY	=	65535;
			int		linkedLastY	=	0;
			for(int p=0;p<patterns.Count;p++)
			{
				patterns[p].index	=	p;				
				//patterns[p].SetDesktopLocation(2,runningY);
				patterns[p].Left	=	2;
				patterns[p].Width	=	400;
				patterns[p].Top		=	runningY;
				runningY		+=	patterns[p].Height+2;
				patterns[p].Id.Text	=	p.ToString();
			}
			
			for(int l=0;l<loopBoxes.Count;l++)
			{
				if(loopBoxes[l].linkedPatterns.Count>1)
				{						
					int	runningHeight		=	0;
					for(int c=0;c<loopBoxes[l].linkedPatterns.Count;c++)
					{						
						loopBoxes[l].linkedPatterns[c].Left	=	65;//,loopBoxes[l].linkedPatterns[c].Location.Y);		
						loopBoxes[l].linkedPatterns[c].Width	=	200;
						runningHeight	+=	loopBoxes[l].linkedPatterns[c].Height;
					}
					linkedFirstY			=	loopBoxes[l].linkedPatterns[0].Location.Y;
					linkedLastY			=	loopBoxes[l].linkedPatterns[loopBoxes[l].linkedPatterns.Count-1].Location.Y;
					loopBoxes[l].Show();
					loopBoxes[l].Width		=	60;				
					loopBoxes[l].Height		=	runningHeight-20;
					loopBoxes[l].Left		=	5;
					loopBoxes[l].Top		=	(linkedFirstY)+10;
					loopBoxes[l].loopCount.Top	=	(loopBoxes[l].Height/2)-10;
					loopBoxes[l].SendToBack();
				}
				else
				{
					loopBoxes[l].Hide();	
					loopBoxes.Remove(loopBoxes[l]);						
				}
			}
			scrollBar.Maximum		=	runningY;
			this.Invalidate(true);
			this.Refresh();
		}

		private void upButton_Click(object sender, EventArgs e)
		{
			checkPaused();
			for(int p=0;p<patterns.Count;p++)
			{
				if(patterns[p].checkBox.Checked==true)
				{
					if(patterns[p].loopBox!=null)
					{
						MessageBox.Show("You must unlink before you move patterns","Error", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);	
						return;			
					}
				}
			}
			for(int p=0;p<patterns.Count;p++)
			{
				if(patterns[p].checkBox.Checked==true)
				{	
					if(p>1)
					{
						Pattern tempPattern	=	patterns[p-1];
						patterns[p-1]		=	patterns[p];
						patterns[p]		=	tempPattern;
					}
				}
			}	
			updatePatterns();
			
		}

		private void downButton_Click(object sender, EventArgs e)
		{
			checkPaused();
			for(int p=0;p<patterns.Count;p++)
			{
				if(patterns[p].checkBox.Checked==true)
				{
					if(patterns[p].loopBox!=null)
					{
						MessageBox.Show("You must unlink before you move patterns","Error", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);	
						return;			
					}
				}
			}			
			for(int p=patterns.Count-1;p>=1;p--)
			{
				if(patterns[p].checkBox.Checked==true)
				{	
					if(p+1<patterns.Count)
					{
						Pattern tempPattern	=	patterns[p+1];
						patterns[p+1]		=	patterns[p];
						patterns[p]		=	tempPattern;
					}
				}
			}	
			updatePatterns();
		}
		private void toolStrip1_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
		{

		}

		private void stopClick(object sender, EventArgs e)
		{
			running		=	false;	
			stopButtons();
			pauseButtons();
		}
		private	void	stopButtons()
		{
			if(running==false)
			{
				this.play.Visible	=	true;
				this.Stop.Visible	=	false;

			}
			else
			{
				this.play.Visible	=	false;
				this.Stop.Visible	=	true;
				//paused			=	false;
			}
			
		}
		private void runClick(object sender, EventArgs e)
		{
			running		=	true;
			paused		=	false;
			steping		=	false;
			patternIndex	=	0;
			pauseButtons();
			resetSprites();
			stopButtons();
		}		
		private void stepClick(object sender, EventArgs e)
		{
			paused		=	true;
			steping		=	true;
		}
		private	void	checkPaused()
		{
			if(paused==false)
			{
				paused		=	true;
				pauseButtons();
			}
		}
		private	void	pauseButtons()
		{
			if(paused==false && running==true)
			{
				this.pauseButton.Visible	=	true;
				this.stepButton.Visible		=	false;
			}
			else
			{
				this.pauseButton.Visible	=	false;
				this.stepButton.Visible		=	true;
			}
			
		}
		
		private void pauseClick(object sender, EventArgs e)
		{		
			if(paused==true)
			{
				paused			=	false;
			}		
			else
			{				
				paused			=	true;
			}
			pauseButtons();
		}
		private	void	updateStatus()
		{
			if(patterns.Count>0)
			{ 
				this.statusLable.Text	=	"Pattern : " + patterns[patternIndex].getIndex().ToString() + "  Time : " + sprites[0].time.ToString() + "  X : " + (sprites[0].x>>6).ToString()  +  "  Y : " + (sprites[0].y>>6).ToString()  + "  Direction : " + sprites[0].direction.ToString()  ;  
			}
		}

		private void openSettings(object sender, EventArgs e)
		{
			settingsPanel.ShowDialog();
		}
		
		private void saveButton_Click(object sender, EventArgs e)
		{			
			projectSaveDialog.FileName		=	projectName + ".xml";
			projectSaveDialog.Filter		=	"Project Files (*.xml)|*.xml|All Files (*.*)|*.*";
			projectSaveDialog.FilterIndex		=	1 ;
			projectSaveDialog.RestoreDirectory	=	false;			
			projectSaveDialog.InitialDirectory 	=	projectDirectory + "\\Projects\\";			
			if(projectSaveDialog.ShowDialog() == DialogResult.OK)
			{

				DirectoryInfo	parentDir	=	Directory.GetParent(Path.GetFullPath(projectSaveDialog.FileName));
				projectDirectory		=	parentDir.Parent.FullName;
				projectName			=	Path.GetFileNameWithoutExtension(projectSaveDialog.FileName);

				using 	(XmlTextWriter writer = new XmlTextWriter(Path.ChangeExtension(projectSaveDialog.FileName,"xml"), Encoding.UTF8))
				{
					writer.Formatting				=	Formatting.Indented;
					XmlDocument	doc				=	new XmlDocument();
					XmlNode		rootNode			=	doc.CreateElement("", "XML", "");
					XmlNode 	projectNode			=	doc.CreateElement("Project");	
					XmlNode		nameNode	=			doc.CreateElement("Name");
					XmlAttribute	attribute			=	doc.CreateAttribute("Projectname");	
							attribute.Value			= 	projectName;
					doc.AppendChild(rootNode);
					rootNode.AppendChild(projectNode);	
					nameNode.Attributes.Append(attribute);	
					projectNode.AppendChild(nameNode);

					XmlNode		settingsNode			=	doc.CreateElement("Settings");
					XmlAttribute	settingsAttribute		=	null;	

					projectNode.AppendChild(settingsNode);

					settingsAttribute		=	doc.CreateAttribute("GuideWidth");	
					settingsAttribute.Value		=	settingsPanel.guideWidth.Value.ToString();
					settingsNode.Attributes.Append(settingsAttribute);

					settingsAttribute		=	doc.CreateAttribute("GuideHeight");	
					settingsAttribute.Value		=	settingsPanel.guideHeight.Value.ToString();
					settingsNode.Attributes.Append(settingsAttribute);

					settingsAttribute		=	doc.CreateAttribute("StartPosition");	
					if(settingsPanel.TL.Checked==true)
					{
						settingsAttribute.Value		=	"0";
					}
					else if(settingsPanel.TC.Checked==true)
					{				
						settingsAttribute.Value		=	"1";
					}
					else if(settingsPanel.TR.Checked==true)
					{										
						settingsAttribute.Value		=	"2";
					}
					else if(settingsPanel.ML.Checked==true)
					{			
						settingsAttribute.Value		=	"3";
					}
					else if(settingsPanel.MC.Checked==true)
					{			
						settingsAttribute.Value		=	"4";
					}
					else if(settingsPanel.MR.Checked==true)
					{			
						settingsAttribute.Value		=	"5";
					}
					else if(settingsPanel.BL.Checked==true)
					{			
						settingsAttribute.Value		=	"6";
					}
					else if(settingsPanel.BR.Checked==true)
					{			
						settingsAttribute.Value		=	"7";
					}
					else// if(BC.Checked==true)
					{			
						settingsAttribute.Value		=	"8";
					}
					settingsNode.Attributes.Append(settingsAttribute);

					settingsAttribute				=	doc.CreateAttribute("ShowGrid");	
					settingsAttribute.Value				=	settingsPanel.useGrid.Checked.ToString();
					settingsNode.Attributes.Append(settingsAttribute);

					settingsAttribute				=	doc.CreateAttribute("GridSize");	
					settingsAttribute.Value				=	settingsPanel.gridSize.Value.ToString();
					settingsNode.Attributes.Append(settingsAttribute);

					settingsAttribute				=	doc.CreateAttribute("SpriteSize");	
					settingsAttribute.Value				=	settingsPanel.spriteSize.Value.ToString();
					settingsNode.Attributes.Append(settingsAttribute);

					settingsAttribute				=	doc.CreateAttribute("Sprites");	
					settingsAttribute.Value				=	this.amount.Value.ToString();
					settingsNode.Attributes.Append(settingsAttribute);

					XmlNode		patternsNode			=	doc.CreateElement("Patterns");
					XmlNode		patternItem			=	null;	
					XmlAttribute	patternsAttribute		=	null;	

					patternsAttribute				=	doc.CreateAttribute("Patterns");	
					patternsAttribute.Value				=	patterns.Count.ToString();
					patternsNode.Attributes.Append(patternsAttribute);					
					projectNode.AppendChild(patternsNode);

					for(int p=0;p<patterns.Count;p++)
					{						
						patternItem					=	doc.CreateElement("Pattern"+p.ToString());
						patternsNode.AppendChild(patternItem);
						patternsAttribute				=	doc.CreateAttribute("Direction");
						patternsAttribute.Value				=	patterns[p].getDirection().ToString();
						patternItem.Attributes.Append(patternsAttribute);
						patternsAttribute				=	doc.CreateAttribute("Delay");
						patternsAttribute.Value				=	patterns[p].getDelay().ToString();
						patternItem.Attributes.Append(patternsAttribute);
						patternsAttribute				=	doc.CreateAttribute("Turn");
						patternsAttribute.Value				=	patterns[p].getTurn().ToString();
						patternItem.Attributes.Append(patternsAttribute);
						patternsAttribute				=	doc.CreateAttribute("Speed");
						patternsAttribute.Value				=	patterns[p].getSpeed().ToString();
						patternItem.Attributes.Append(patternsAttribute);
						patternsAttribute				=	doc.CreateAttribute("Time");
						patternsAttribute.Value				=	patterns[p].getTime().ToString();
						patternItem.Attributes.Append(patternsAttribute);
						patternsAttribute				=	doc.CreateAttribute("Spawn");
						patternsAttribute.Value				=	patterns[p].spawnBox.SelectedIndex.ToString();
						patternItem.Attributes.Append(patternsAttribute);						
						patternsAttribute				=	doc.CreateAttribute("Color");
						patternsAttribute.Value				=	patterns[p].colorBox.SelectedIndex.ToString();
						patternItem.Attributes.Append(patternsAttribute);

						if(patterns[p].getLoopbox()!=null)
						{ 
							patternsAttribute			=	doc.CreateAttribute("Loop");
							patternsAttribute.Value			=	patterns[p].getLoopbox().getId().ToString();
							patternItem.Attributes.Append(patternsAttribute);
						}						
					}
					XmlNode		loopsNode			=	doc.CreateElement("Loops");
					XmlNode		loopsItem			=	null;	
					XmlAttribute	loopsAttribute			=	null;	
					projectNode.AppendChild(loopsNode);
					loopsAttribute					=	doc.CreateAttribute("Loops");	
					loopsAttribute.Value				=	loopBoxes.Count.ToString();
					loopsNode.Attributes.Append(loopsAttribute);

					for(int l=0;l<loopBoxes.Count;l++)
					{
						loopsItem					=	doc.CreateElement("Loop"+l.ToString());
						loopsNode.AppendChild(loopsItem);
						loopsAttribute					=	doc.CreateAttribute("FirstLink");
						loopsAttribute.Value				=	loopBoxes[l].getFirstLink().ToString();
						loopsItem.Attributes.Append(loopsAttribute);
						loopsAttribute					=	doc.CreateAttribute("LastLink");
						loopsAttribute.Value				=	loopBoxes[l].getLastLink().ToString();
						loopsItem.Attributes.Append(loopsAttribute);
						loopsAttribute					=	doc.CreateAttribute("Counter");
						loopsAttribute.Value				=	loopBoxes[l].getLoopCounter().ToString();
						loopsItem.Attributes.Append(loopsAttribute);
					}
					doc.WriteContentTo(writer);
					writer.Flush();
					writer.Close();
				}
			}
		}

		private void openButton_Click(object sender, EventArgs e)
		{			
			projectOpenDialog.FileName		=	projectName + ".xml";
			projectOpenDialog.Filter		=	"Project Files (*.xml)|*.xml|All Files (*.*)|*.*";
			projectOpenDialog.FilterIndex		=	1 ;
			projectOpenDialog.RestoreDirectory	=	false;			
			projectOpenDialog.InitialDirectory 	=	projectDirectory + "\\Projects\\";			
			if(projectOpenDialog.ShowDialog() == DialogResult.OK)
			{

				DirectoryInfo	parentDir	=	Directory.GetParent(Path.GetFullPath(projectOpenDialog.FileName));
				projectDirectory		=	parentDir.Parent.FullName;
				XmlDocument xmlDoc			=	new XmlDocument();
				xmlDoc.Load(projectOpenDialog.FileName);
				XmlNode projectNameNode			=	xmlDoc.SelectSingleNode("//Project/Name");
				if(projectNameNode.Attributes["Projectname"]!=null)
				{
					projectName			=	projectNameNode.Attributes["Projectname"].Value;
				}
				XmlNode projectSettingsNode			=	xmlDoc.SelectSingleNode("//Project/Settings");
				if(projectSettingsNode!=null)
				{
					settingsPanel.guideWidth.Value	=	(decimal.Parse(projectSettingsNode.Attributes["GuideWidth"].Value));
					settingsPanel.guideHeight.Value	=	(decimal.Parse(projectSettingsNode.Attributes["GuideHeight"].Value));
					switch((int.Parse(projectSettingsNode.Attributes["StartPosition"].Value)))
					{
						case	0:
							settingsPanel.TL.Checked	=	true;
						break;
						case	1:
							settingsPanel.TC.Checked	=	true;
						break;
						case	2:
							settingsPanel.TR.Checked	=	true;
						break;
						case	3:
							settingsPanel.ML.Checked	=	true;
						break;
						case	4:
							settingsPanel.MC.Checked	=	true;
						break;
						case	5:
							settingsPanel.MR.Checked	=	true;
						break;
						case	6:
							settingsPanel.BL.Checked	=	true;
						break;
						case	7:
							settingsPanel.BC.Checked	=	true;
						break;
						case	8:
							settingsPanel.BR.Checked	=	true;
						break;
					}
					settingsPanel.useGrid.Checked			=	bool.Parse(projectSettingsNode.Attributes["ShowGrid"].Value);
					settingsPanel.gridSize.Value			=	(decimal.Parse(projectSettingsNode.Attributes["GridSize"].Value));
					settingsPanel.spriteSize.Value			=	(decimal.Parse(projectSettingsNode.Attributes["SpriteSize"].Value));
					this.amount.Value				=	(decimal.Parse(projectSettingsNode.Attributes["Sprites"].Value));
				}

				XmlNode projectLoopsNode				=	xmlDoc.SelectSingleNode("//Project/Loops");
				if(projectLoopsNode!=null)
				{
					for(int l=0;l<(int.Parse(projectLoopsNode.Attributes["Loops"].Value));l++)		
					{
						if(xmlDoc.SelectSingleNode("//Project/Loops/Loop"+l.ToString())!=null)	
						{
							XmlNode LoopNode			=	xmlDoc.SelectSingleNode("//Project/Loops/Loop"+l.ToString());

							loopContainer	thisContainer		=	new	loopContainer();
							thisContainer.addId(loopBoxes.Count);
							thisContainer.firstLink			=	int.Parse(LoopNode.Attributes["FirstLink"].Value);
							thisContainer.lastLink			=	int.Parse(LoopNode.Attributes["LastLink"].Value);
							thisContainer.loopCount.Value		=	decimal.Parse(LoopNode.Attributes["Counter"].Value);
							thisContainer.loopCounter		=	(int)thisContainer.loopCount.Value	;
							loopBoxes.Add(thisContainer);
							//thisContainer.MdiParent			=	this;							
							thisContainer.TopLevel			=	false;
							scrollPanel.Controls.Add(thisContainer);
						}
					}
				}


				XmlNode projectPatternsNode				=	xmlDoc.SelectSingleNode("//Project/Patterns");
				if(projectPatternsNode!=null)
				{
					for(int p=0;p<(int.Parse(projectPatternsNode.Attributes["Patterns"].Value));p++)		
					{
						if(xmlDoc.SelectSingleNode("//Project/Patterns/Pattern"+p.ToString())!=null)	
						{
							XmlNode PatternNode		=	xmlDoc.SelectSingleNode("//Project/Patterns/Pattern"+p.ToString());

							Pattern thisPattern			=       new     Pattern(this);
							//thisPattern.MdiParent			=	this;						
							thisPattern.TopLevel = false;
							scrollPanel.Controls.Add(thisPattern);
							patterns.Add(thisPattern);	
							thisPattern.Width			=	250;
							thisPattern.Height			=	226;
							thisPattern.SetDesktopLocation(21,patterns.Count*(thisPattern.Height+2));
								
							thisPattern.BackColor			=	Color.FromName("LightBlue");
							thisPattern.Show();
						
							thisPattern.udDirection.Value		=	decimal.Parse(PatternNode.Attributes["Direction"].Value);	
							thisPattern.direction			=	(byte)thisPattern.udDirection.Value;
						
							thisPattern.udDelay.Value		=	decimal.Parse(PatternNode.Attributes["Delay"].Value);	
							thisPattern.delay			=	(byte)thisPattern.udDelay.Value;	

							thisPattern.udTurn.Value		=	decimal.Parse(PatternNode.Attributes["Turn"].Value);	
							thisPattern.turn			=	(sbyte)thisPattern.udTurn.Value;

							thisPattern.udSpeed.Value		=	decimal.Parse(PatternNode.Attributes["Speed"].Value);	
							thisPattern.speed			=	(sbyte)thisPattern.udSpeed.Value;

							thisPattern.udTime.Value		=	decimal.Parse(PatternNode.Attributes["Time"].Value);	
							thisPattern.time			=	(byte)thisPattern.udTime.Value;		
							thisPattern.spawnBox.SelectedIndex	=	int.Parse(PatternNode.Attributes["Spawn"].Value);	
							thisPattern.colorBox.SelectedIndex	=	int.Parse(PatternNode.Attributes["Color"].Value);	
							
						}
						scrollBar.Maximum			=		(patterns.Count*(226+2));
					}
					for(int l=0;l<loopBoxes.Count;l++)
					{ 
						for(int p=0;p<patterns.Count;p++)
						{
							if(p>=loopBoxes[l].firstLink && p<=loopBoxes[l].lastLink)
							{ 
								loopBoxes[l].addPattern(patterns[p]);					
								patterns[p].addLoopBox(loopBoxes[l]);
							}			
						}
					}
					updatePatterns();
				}
			}
		}
		

		private void export(object sender, EventArgs e)
		{		

			DateTime todaysDate			=	DateTime.Now;
			saveDataDialog.FileName			=	projectName;// + ".asm";
			saveDataDialog.Filter			=	"Machine Code (*.asm)|*.asm|Binary (*.bin)|*.bin|Basic (*.bas)|*.bas|All Files (*.*)|*.*";
			saveDataDialog.FilterIndex		=	saveFilterIndex;
			saveDataDialog.RestoreDirectory		=	false;				
			saveDataDialog.InitialDirectory 	=	projectDirectory + "\\Output\\";
			int	lineNumber			=	100;
			String	outPath;
			if (saveDataDialog.ShowDialog(this) == DialogResult.OK)
			{
				saveFilterIndex		=	saveDataDialog.FilterIndex;
				switch(saveDataDialog.FilterIndex)
				{
					case		1:
						outPath				=	Path.GetFileNameWithoutExtension(saveDataDialog.FileName) + ".asm";
						using(StreamWriter asmFile	=	new StreamWriter(File.Open(outPath, FileMode.OpenOrCreate)))
						{ 
							asmFile.WriteLine("// " + projectName + ".asm");
							asmFile.WriteLine("// Created on " + todaysDate.ToString("F", CultureInfo.CreateSpecificCulture("en-US")) + " by the Pattern Designer from");
							asmFile.WriteLine("// patricia curtis at luckyredfish dot com");

							asmFile.WriteLine("// patterns { delay, direction, speed, turn, time, spawn (None,Shoot,Radial,Drop)}");
							asmFile.WriteLine("// loops{negative byte offset, variable for count, count reset value}");
							asmFile.WriteLine(projectName + "Objects\tequ\t" + amount.Value.ToString());

							asmFile.WriteLine(projectName + "Pattern:");
							for(int p=0;p<patterns.Count;p++)
							{
								asmFile.WriteLine(	"\t\t\t.db\t" +
											patterns[p].getDelay().ToString() + "," +
											patterns[p].getDirection().ToString() + "," +
											patterns[p].getSpeed().ToString() + "," +
											patterns[p].getTurn().ToString() + "," +
											patterns[p].getTime().ToString() + "," +
											patterns[p].getSpawn().ToString());

								if(patterns[p].loopBox!=null)
								{
									if(p==patterns[p].loopBox.lastLink)
									{
										// must be the end of the loop 
										asmFile.WriteLine("\t\t\t.db\t" +
												 (-((	patterns[p].loopBox.lastLink-patterns[p].loopBox.firstLink)+1)*6).ToString() + ","+
													patterns[p].loopBox.getLoopCount().ToString()  + "," +
													patterns[p].loopBox.getLoopCount().ToString());
									}
								}
							}
						}
					break;
					case		2:
						outPath				=	Path.GetFileNameWithoutExtension(saveDataDialog.FileName) + ".bin";
						using(BinaryWriter binFile	=	new BinaryWriter(File.Open(outPath, FileMode.OpenOrCreate)))
						{ 
							binFile.Write((byte)amount.Value);
							for(int p=0;p<patterns.Count;p++)
							{
								binFile.Write((byte)patterns[p].getDelay());
								binFile.Write((byte)patterns[p].getDirection());
								binFile.Write((byte)patterns[p].getSpeed());
								binFile.Write((byte)patterns[p].getTurn());
								binFile.Write((byte)patterns[p].getTime());
								binFile.Write((byte)patterns[p].getSpawn());

								if(patterns[p].loopBox!=null)
								{
									if(p==patterns[p].loopBox.lastLink)
									{
										// must be the end of the loop 
										binFile.Write((byte)(-((patterns[p].loopBox.lastLink-patterns[p].loopBox.firstLink)+1)*6));
										binFile.Write((byte)patterns[p].loopBox.getLoopCount());
										binFile.Write((byte)patterns[p].loopBox.getLoopCount());
									}
								}
							}
						}
					break;
					default:
					case		0:
						outPath				=	Path.GetFileNameWithoutExtension(saveDataDialog.FileName) + ".bas";				
						using(StreamWriter basFile	=	new StreamWriter(File.Open(outPath, FileMode.OpenOrCreate)))
						{ 
							
							basFile.WriteLine(lineNumber.ToString()  + "\tREM " + projectName + ".asm");
							lineNumber	+=	5;
							basFile.WriteLine(lineNumber.ToString()  + "\tREM Created on " + todaysDate.ToString("F", CultureInfo.CreateSpecificCulture("en-US")) + " by the Pattern Designer from");
							lineNumber	+=	5;
							basFile.WriteLine(lineNumber.ToString()  + "\tREM patricia curtis at luckyredfish dot com");
							lineNumber	+=	5;
							basFile.WriteLine(lineNumber.ToString()  + "\tREM patterns { delay, direction, speed, turn, time, spawn (None,Shoot,Radial,Drop)}");
							lineNumber	+=	5;
							basFile.WriteLine(lineNumber.ToString()  + "\tREM loops{negative byte offset, count reset value}");
							lineNumber	+=	5;
							basFile.WriteLine(lineNumber.ToString()  + "\tLET\t" + projectName + "Objects\t=\t" + amount.Value.ToString());
							lineNumber	+=	5;
							for(int p=0;p<patterns.Count;p++)
							{
								basFile.WriteLine(	lineNumber.ToString()  + "\tDATA\t" +
											patterns[p].getDelay().ToString() + "," +
											patterns[p].getDirection().ToString() + "," +
											patterns[p].getSpeed().ToString() + "," +
											patterns[p].getTurn().ToString() + "," +
											patterns[p].getTime().ToString() + "," +
											patterns[p].getSpawn().ToString());
								lineNumber	+=	5;	
								if(patterns[p].loopBox!=null)
								{
									if(p==patterns[p].loopBox.lastLink)
									{
										// must be the end of the loop 
										basFile.WriteLine(	lineNumber.ToString()  + "\tDATA\t" +
													(-((patterns[p].loopBox.lastLink-patterns[p].loopBox.firstLink)+1)*6).ToString() + ","+
													patterns[p].loopBox.getLoopCount().ToString());
										lineNumber	+=	5;	
										basFile.WriteLine(lineNumber.ToString()  + "\tLET\t" + projectName + "Loops\t=\t0");
										lineNumber	+=	5;	
									}
								}
							}
						}
					break;
				}
				
			}
		}
	}
}
