using haxe.root;
#pragma warning disable 109, 114, 219, 429, 168, 162
namespace alphatab.rendering.layout
{
	public  class PageViewLayout : global::alphatab.rendering.layout.ScoreLayout 
	{
		static PageViewLayout() 
		{
			global::alphatab.rendering.layout.PageViewLayout.ScoreInfos = "ScoreInfos";
			global::alphatab.rendering.layout.PageViewLayout.PagePadding = new global::haxe.root.Array<int>(new int[]{40, 40, 40, 40});
			global::alphatab.rendering.layout.PageViewLayout.WidthOn100 = 950;
			global::alphatab.rendering.layout.PageViewLayout.GroupSpacing = 20;
		}
		public    PageViewLayout(global::haxe.lang.EmptyObject empty) : base(((global::haxe.lang.EmptyObject) (global::haxe.lang.EmptyObject.EMPTY) ))
		{
			unchecked 
			{
			}
		}
		
		
		public    PageViewLayout(global::alphatab.rendering.ScoreRenderer renderer) : base(((global::haxe.lang.EmptyObject) (global::haxe.lang.EmptyObject.EMPTY) ))
		{
			unchecked 
			{
				global::alphatab.rendering.layout.PageViewLayout.__hx_ctor_alphatab_rendering_layout_PageViewLayout(this, renderer);
			}
		}
		
		
		public static   void __hx_ctor_alphatab_rendering_layout_PageViewLayout(global::alphatab.rendering.layout.PageViewLayout __temp_me25, global::alphatab.rendering.ScoreRenderer renderer)
		{
			unchecked 
			{
				global::alphatab.rendering.layout.ScoreLayout.__hx_ctor_alphatab_rendering_layout_ScoreLayout(__temp_me25, renderer);
				__temp_me25._groups = new global::haxe.root.Array<object>();
			}
		}
		
		
		public static  string ScoreInfos;
		
		public static  global::haxe.root.Array<int> PagePadding;
		
		public static  int WidthOn100;
		
		public static  int GroupSpacing;
		
		public static  new object __hx_createEmpty()
		{
			unchecked 
			{
				return new global::alphatab.rendering.layout.PageViewLayout(((global::haxe.lang.EmptyObject) (global::haxe.lang.EmptyObject.EMPTY) ));
			}
		}
		
		
		public static  new object __hx_create(global::haxe.root.Array arr)
		{
			unchecked 
			{
				return new global::alphatab.rendering.layout.PageViewLayout(((global::alphatab.rendering.ScoreRenderer) (arr[0]) ));
			}
		}
		
		
		public  global::haxe.root.Array<object> _groups;
		
		public override   void doLayout()
		{
			unchecked 
			{
				this._groups = new global::haxe.root.Array<object>();
				int startIndex = this.renderer.settings.layout.@get<int>("start", 1);
				startIndex--;
				{
					double x = default(double);
					{
						double b = global::System.Math.Max(((double) (0) ), ((double) (startIndex) ));
						x = global::System.Math.Min(((double) (( this.renderer.track.bars.length - 1 )) ), ((double) (b) ));
					}
					
					startIndex = ((int) (x) );
				}
				
				int currentBarIndex = startIndex;
				int endBarIndex = this.renderer.settings.layout.@get<int>("count", this.renderer.track.bars.length);
				if (( endBarIndex < 0 )) 
				{
					endBarIndex = this.renderer.track.bars.length;
				}
				
				endBarIndex = ( ( startIndex + endBarIndex ) - 1 );
				{
					double x1 = default(double);
					{
						double b1 = global::System.Math.Max(((double) (0) ), ((double) (endBarIndex) ));
						x1 = global::System.Math.Min(((double) (( this.renderer.track.bars.length - 1 )) ), ((double) (b1) ));
					}
					
					endBarIndex = ((int) (x1) );
				}
				
				int x2 = global::alphatab.rendering.layout.PageViewLayout.PagePadding[0];
				int y = global::alphatab.rendering.layout.PageViewLayout.PagePadding[1];
				y = this.doScoreInfoLayout(y);
				bool autoSize = this.renderer.settings.layout.@get<bool>("autoSize", true);
				if (( autoSize || ( this.renderer.settings.width <= 0 ) )) 
				{
					this.width = ((int) (( 950 * this.renderer.settings.scale )) );
				}
				 else 
				{
					this.width = this.renderer.settings.width;
				}
				
				if (( this.renderer.settings.staves.length > 0 )) 
				{
					while (( currentBarIndex <= endBarIndex ))
					{
						global::alphatab.rendering.staves.StaveGroup @group = this.createStaveGroup(currentBarIndex, endBarIndex);
						this._groups.push(@group);
						@group.x = x2;
						@group.y = y;
						this.fitGroup(@group);
						@group.finalizeGroup(this);
						y += ( @group.calculateHeight() + ((int) (( 20 * this.renderer.settings.scale )) ) );
						currentBarIndex = ( ((global::alphatab.model.Bar) (@group.bars[( @group.bars.length - 1 )]) ).index + 1 );
					}
					
				}
				
				this.height = ( y + global::alphatab.rendering.layout.PageViewLayout.PagePadding[3] );
			}
		}
		
		
		public virtual   int doScoreInfoLayout(int y)
		{
			unchecked 
			{
				int flags = default(int);
				if (this.renderer.settings.layout.@get<bool>("hideInfo", false)) 
				{
					flags = 0;
				}
				 else 
				{
					flags = 511;
				}
				
				global::alphatab.model.Score score = this.renderer._get_score();
				double scale = this.renderer.settings.scale;
				if ((  ! (this.isNullOrEmpty(score.title))  && ( (( flags & 1 )) != 0 ) )) 
				{
					{
						double x = global::System.Math.Floor(((double) (( 35 * scale )) ));
						y += ((int) (x) );
					}
					
				}
				
				if ((  ! (this.isNullOrEmpty(score.subTitle))  && ( (( flags & 2 )) != 0 ) )) 
				{
					{
						double x1 = global::System.Math.Floor(((double) (( 20 * scale )) ));
						y += ((int) (x1) );
					}
					
				}
				
				if ((  ! (this.isNullOrEmpty(score.artist))  && ( (( flags & 4 )) != 0 ) )) 
				{
					{
						double x2 = global::System.Math.Floor(((double) (( 20 * scale )) ));
						y += ((int) (x2) );
					}
					
				}
				
				if ((  ! (this.isNullOrEmpty(score.album))  && ( (( flags & 8 )) != 0 ) )) 
				{
					{
						double x3 = global::System.Math.Floor(((double) (( 20 * scale )) ));
						y += ((int) (x3) );
					}
					
				}
				
				if (( (  ! (this.isNullOrEmpty(score.music))  && string.Equals(score.music, score.words) ) && ( (( flags & 64 )) != 0 ) )) 
				{
					{
						double x4 = global::System.Math.Floor(((double) (( 20 * scale )) ));
						y += ((int) (x4) );
					}
					
				}
				 else 
				{
					if ((  ! (this.isNullOrEmpty(score.music))  && ( (( flags & 32 )) != 0 ) )) 
					{
						{
							double x5 = global::System.Math.Floor(((double) (( 20 * scale )) ));
							y += ((int) (x5) );
						}
						
					}
					
					if ((  ! (this.isNullOrEmpty(score.words))  && ( (( flags & 16 )) != 0 ) )) 
					{
						{
							double x6 = global::System.Math.Floor(((double) (( 20 * scale )) ));
							y += ((int) (x6) );
						}
						
					}
					
				}
				
				{
					double x7 = global::System.Math.Floor(((double) (( 20 * scale )) ));
					y += ((int) (x7) );
				}
				
				if ( ! (this.renderer.track.isPercussion) ) 
				{
					global::alphatab.model.Tuning tuning = global::alphatab.model.Tuning.findTuning(this.renderer.track.tuning);
					if (( tuning != default(global::alphatab.model.Tuning) )) 
					{
						{
							double x8 = global::System.Math.Floor(((double) (( 15 * scale )) ));
							y += ((int) (x8) );
						}
						
						if ( ! (tuning.isStandard) ) 
						{
							int stringsPerColumn = default(int);
							{
								double x9 = global::System.Math.Ceiling(((double) (( ((double) (this.renderer.track.tuning.length) ) / 2 )) ));
								stringsPerColumn = ((int) (x9) );
							}
							
							int __temp_stmt478 = default(int);
							{
								double x10 = global::System.Math.Floor(((double) (( 15 * scale )) ));
								__temp_stmt478 = ((int) (x10) );
							}
							
							y += ( stringsPerColumn * __temp_stmt478 );
						}
						
						{
							double x11 = global::System.Math.Floor(((double) (( 15 * scale )) ));
							y += ((int) (x11) );
						}
						
					}
					
				}
				
				{
					double x12 = global::System.Math.Floor(((double) (( 40 * scale )) ));
					y += ((int) (x12) );
				}
				
				return y;
			}
		}
		
		
		public override   void paintScore()
		{
			unchecked 
			{
				int x = global::alphatab.rendering.layout.PageViewLayout.PagePadding[0];
				int y = global::alphatab.rendering.layout.PageViewLayout.PagePadding[1];
				y = this.paintScoreInfo(x, y);
				{
					int _g = 0;
					global::haxe.root.Array<object> _g1 = this._groups;
					while (( _g < _g1.length ))
					{
						global::alphatab.rendering.staves.StaveGroup g = ((global::alphatab.rendering.staves.StaveGroup) (_g1[_g]) );
						 ++ _g;
						g.paint(0, 0, this.renderer.canvas);
					}
					
				}
				
			}
		}
		
		
		public virtual   void drawCentered(string text, global::alphatab.platform.model.Font font, int y)
		{
			unchecked 
			{
				this.renderer.canvas.setFont(font);
				this.renderer.canvas.fillText(text, ( ((double) (this.width) ) / 2 ), ((double) (y) ));
			}
		}
		
		
		public virtual   int paintScoreInfo(int x, int y)
		{
			unchecked 
			{
				int flags = default(int);
				if (this.renderer.settings.layout.@get<bool>("hideInfo", false)) 
				{
					flags = 0;
				}
				 else 
				{
					flags = 511;
				}
				
				global::alphatab.model.Score score = this.renderer._get_score();
				double scale = this.renderer.settings.scale;
				global::alphatab.platform.ICanvas canvas = this.renderer.canvas;
				global::alphatab.rendering.RenderingResources res = this.renderer.renderingResources;
				canvas.setColor(new global::alphatab.platform.model.Color(((int) (0) ), ((int) (0) ), ((int) (0) ), ((global::haxe.lang.Null<int>) (default(global::haxe.lang.Null<int>)) )));
				canvas.setTextAlign(global::alphatab.platform.model.TextAlign.Center);
				double tX = default(double);
				double size = default(double);
				string str = "";
				if ((  ! (this.isNullOrEmpty(score.title))  && ( (( flags & 1 )) != 0 ) )) 
				{
					this.drawCentered(score.title, res.titleFont, y);
					{
						double x1 = global::System.Math.Floor(((double) (( 35 * scale )) ));
						y += ((int) (x1) );
					}
					
				}
				
				if ((  ! (this.isNullOrEmpty(score.subTitle))  && ( (( flags & 2 )) != 0 ) )) 
				{
					this.drawCentered(score.subTitle, res.subTitleFont, y);
					{
						double x2 = global::System.Math.Floor(((double) (( 20 * scale )) ));
						y += ((int) (x2) );
					}
					
				}
				
				if ((  ! (this.isNullOrEmpty(score.artist))  && ( (( flags & 4 )) != 0 ) )) 
				{
					this.drawCentered(score.artist, res.subTitleFont, y);
					{
						double x3 = global::System.Math.Floor(((double) (( 20 * scale )) ));
						y += ((int) (x3) );
					}
					
				}
				
				if ((  ! (this.isNullOrEmpty(score.album))  && ( (( flags & 8 )) != 0 ) )) 
				{
					this.drawCentered(score.album, res.subTitleFont, y);
					{
						double x4 = global::System.Math.Floor(((double) (( 20 * scale )) ));
						y += ((int) (x4) );
					}
					
				}
				
				if (( (  ! (this.isNullOrEmpty(score.music))  && string.Equals(score.music, score.words) ) && ( (( flags & 64 )) != 0 ) )) 
				{
					this.drawCentered(global::haxe.lang.Runtime.concat("Music and Words by ", score.words), res.wordsFont, y);
					{
						double x5 = global::System.Math.Floor(((double) (( 20 * scale )) ));
						y += ((int) (x5) );
					}
					
				}
				 else 
				{
					canvas.setFont(res.wordsFont);
					if ((  ! (this.isNullOrEmpty(score.music))  && ( (( flags & 32 )) != 0 ) )) 
					{
						canvas.setTextAlign(global::alphatab.platform.model.TextAlign.Right);
						canvas.fillText(global::haxe.lang.Runtime.concat("Music by ", score.music), ((double) (( this.width - global::alphatab.rendering.layout.PageViewLayout.PagePadding[2] )) ), ((double) (y) ));
					}
					
					if ((  ! (this.isNullOrEmpty(score.words))  && ( (( flags & 16 )) != 0 ) )) 
					{
						canvas.setTextAlign(global::alphatab.platform.model.TextAlign.Left);
						canvas.fillText(global::haxe.lang.Runtime.concat("Words by ", score.music), ((double) (x) ), ((double) (y) ));
					}
					
					{
						double x6 = global::System.Math.Floor(((double) (( 20 * scale )) ));
						y += ((int) (x6) );
					}
					
				}
				
				{
					double x7 = global::System.Math.Floor(((double) (( 20 * scale )) ));
					y += ((int) (x7) );
				}
				
				if ( ! (this.renderer.track.isPercussion) ) 
				{
					canvas.setTextAlign(global::alphatab.platform.model.TextAlign.Left);
					global::alphatab.model.Tuning tuning = global::alphatab.model.Tuning.findTuning(this.renderer.track.tuning);
					if (( tuning != default(global::alphatab.model.Tuning) )) 
					{
						canvas.setFont(res.effectFont);
						canvas.fillText(tuning.name, ((double) (x) ), ((double) (y) ));
						{
							double x8 = global::System.Math.Floor(((double) (( 15 * scale )) ));
							y += ((int) (x8) );
						}
						
						if ( ! (tuning.isStandard) ) 
						{
							int stringsPerColumn = default(int);
							{
								double x9 = global::System.Math.Ceiling(((double) (( ((double) (this.renderer.track.tuning.length) ) / 2 )) ));
								stringsPerColumn = ((int) (x9) );
							}
							
							int currentX = x;
							int currentY = y;
							{
								int _g1 = 0;
								int _g = this.renderer.track.tuning.length;
								while (( _g1 < _g ))
								{
									int i = _g1++;
									str = global::haxe.lang.Runtime.concat(global::haxe.lang.Runtime.concat(global::haxe.lang.Runtime.concat("(", global::Std.@string(( i + 1 ))), ") = "), global::alphatab.model.Tuning.getTextForTuning(this.renderer.track.tuning[i], false));
									canvas.fillText(str, ((double) (currentX) ), ((double) (currentY) ));
									{
										double x10 = global::System.Math.Floor(((double) (( 15 * scale )) ));
										currentY += ((int) (x10) );
									}
									
									if (( i == ( stringsPerColumn - 1 ) )) 
									{
										currentY = y;
										{
											double x11 = global::System.Math.Floor(((double) (( 43 * scale )) ));
											currentX += ((int) (x11) );
										}
										
									}
									
								}
								
							}
							
							int __temp_stmt479 = default(int);
							{
								double x12 = global::System.Math.Floor(((double) (( 15 * scale )) ));
								__temp_stmt479 = ((int) (x12) );
							}
							
							y += ( stringsPerColumn * __temp_stmt479 );
						}
						
					}
					
				}
				
				{
					double x13 = global::System.Math.Floor(((double) (( 25 * scale )) ));
					y += ((int) (x13) );
				}
				
				return y;
			}
		}
		
		
		public virtual   bool isNullOrEmpty(string s)
		{
			unchecked 
			{
				return ( string.Equals(s, default(string)) || string.Equals(s.Trim(), "") );
			}
		}
		
		
		public virtual   void fitGroup(global::alphatab.rendering.staves.StaveGroup @group)
		{
			unchecked 
			{
				int barSpace = 0;
				int freeSpace = ( this.getMaxWidth() - @group.width );
				if (( ( freeSpace != 0 ) && ( @group.bars.length > 0 ) )) 
				{
					barSpace = global::Math.round(( ((double) (freeSpace) ) / @group.bars.length ));
				}
				
				if (( @group.isFull || ( barSpace < 0 ) )) 
				{
					@group.applyBarSpacing(barSpace);
				}
				
				this.width = global::Math.round(global::System.Math.Max(((double) (this.width) ), ((double) (@group.width) )));
			}
		}
		
		
		public virtual   global::alphatab.rendering.staves.StaveGroup createStaveGroup(int currentBarIndex, int endIndex)
		{
			unchecked 
			{
				global::alphatab.rendering.staves.StaveGroup @group = this.createEmptyStaveGroup();
				int barsPerRow = this.renderer.settings.layout.@get<int>("barsPerRow", -1);
				int maxWidth = this.getMaxWidth();
				int end = ( endIndex + 1 );
				{
					int _g = currentBarIndex;
					while (( _g < ((int) (end) ) ))
					{
						int i = _g++;
						global::alphatab.model.Bar bar = ((global::alphatab.model.Bar) (this.renderer.track.bars[i]) );
						@group.addBar(bar);
						bool groupIsFull = false;
						if (( ( barsPerRow == -1 ) && (( ( @group.width >= maxWidth ) && ( @group.bars.length != 0 ) )) )) 
						{
							groupIsFull = true;
						}
						 else 
						{
							if (( @group.bars.length == ( barsPerRow + 1 ) )) 
							{
								groupIsFull = true;
							}
							
						}
						
						if (groupIsFull) 
						{
							@group.revertLastBar();
							@group.isFull = true;
							return @group;
						}
						
						@group.x = 0;
					}
					
				}
				
				return @group;
			}
		}
		
		
		public virtual   int getMaxWidth()
		{
			unchecked 
			{
				bool autoSize = this.renderer.settings.layout.@get<bool>("autoSize", true);
				int width = default(int);
				if (autoSize) 
				{
					width = this.getSheetWidth();
				}
				 else 
				{
					width = this.renderer.settings.width;
				}
				
				return ( ( width - global::alphatab.rendering.layout.PageViewLayout.PagePadding[0] ) - global::alphatab.rendering.layout.PageViewLayout.PagePadding[2] );
			}
		}
		
		
		public virtual   int getSheetWidth()
		{
			unchecked 
			{
				return global::Math.round(( 950 * this.renderer.settings.scale ));
			}
		}
		
		
		public override   object __hx_setField(string field, int hash, object @value, bool handleProperties)
		{
			unchecked 
			{
				switch (hash)
				{
					case 178206195:
					{
						this._groups = ((global::haxe.root.Array<object>) (global::haxe.root.Array<object>.__hx_cast<object>(((global::haxe.root.Array) (@value) ))) );
						return @value;
					}
					
					
					default:
					{
						return base.__hx_setField(field, hash, @value, handleProperties);
					}
					
				}
				
			}
		}
		
		
		public override   object __hx_getField(string field, int hash, bool throwErrors, bool isCheck, bool handleProperties)
		{
			unchecked 
			{
				switch (hash)
				{
					case 667795229:
					{
						return ((global::haxe.lang.Function) (new global::haxe.lang.Closure(((object) (this) ), global::haxe.lang.Runtime.toString("getSheetWidth"), ((int) (667795229) ))) );
					}
					
					
					case 443796344:
					{
						return ((global::haxe.lang.Function) (new global::haxe.lang.Closure(((object) (this) ), global::haxe.lang.Runtime.toString("getMaxWidth"), ((int) (443796344) ))) );
					}
					
					
					case 305429260:
					{
						return ((global::haxe.lang.Function) (new global::haxe.lang.Closure(((object) (this) ), global::haxe.lang.Runtime.toString("createStaveGroup"), ((int) (305429260) ))) );
					}
					
					
					case 1726950318:
					{
						return ((global::haxe.lang.Function) (new global::haxe.lang.Closure(((object) (this) ), global::haxe.lang.Runtime.toString("fitGroup"), ((int) (1726950318) ))) );
					}
					
					
					case 1454772953:
					{
						return ((global::haxe.lang.Function) (new global::haxe.lang.Closure(((object) (this) ), global::haxe.lang.Runtime.toString("isNullOrEmpty"), ((int) (1454772953) ))) );
					}
					
					
					case 166341986:
					{
						return ((global::haxe.lang.Function) (new global::haxe.lang.Closure(((object) (this) ), global::haxe.lang.Runtime.toString("paintScoreInfo"), ((int) (166341986) ))) );
					}
					
					
					case 1698949528:
					{
						return ((global::haxe.lang.Function) (new global::haxe.lang.Closure(((object) (this) ), global::haxe.lang.Runtime.toString("drawCentered"), ((int) (1698949528) ))) );
					}
					
					
					case 1331941076:
					{
						return ((global::haxe.lang.Function) (new global::haxe.lang.Closure(((object) (this) ), global::haxe.lang.Runtime.toString("paintScore"), ((int) (1331941076) ))) );
					}
					
					
					case 1365104735:
					{
						return ((global::haxe.lang.Function) (new global::haxe.lang.Closure(((object) (this) ), global::haxe.lang.Runtime.toString("doScoreInfoLayout"), ((int) (1365104735) ))) );
					}
					
					
					case 1825584277:
					{
						return ((global::haxe.lang.Function) (new global::haxe.lang.Closure(((object) (this) ), global::haxe.lang.Runtime.toString("doLayout"), ((int) (1825584277) ))) );
					}
					
					
					case 178206195:
					{
						return this._groups;
					}
					
					
					default:
					{
						return base.__hx_getField(field, hash, throwErrors, isCheck, handleProperties);
					}
					
				}
				
			}
		}
		
		
		public override   object __hx_invokeField(string field, int hash, global::haxe.root.Array dynargs)
		{
			unchecked 
			{
				switch (hash)
				{
					case 1825584277:case 1331941076:
					{
						return global::haxe.lang.Runtime.slowCallField(this, field, dynargs);
					}
					
					
					case 667795229:
					{
						return this.getSheetWidth();
					}
					
					
					case 443796344:
					{
						return this.getMaxWidth();
					}
					
					
					case 305429260:
					{
						return this.createStaveGroup(((int) (global::haxe.lang.Runtime.toInt(dynargs[0])) ), ((int) (global::haxe.lang.Runtime.toInt(dynargs[1])) ));
					}
					
					
					case 1726950318:
					{
						this.fitGroup(((global::alphatab.rendering.staves.StaveGroup) (dynargs[0]) ));
						break;
					}
					
					
					case 1454772953:
					{
						return this.isNullOrEmpty(global::haxe.lang.Runtime.toString(dynargs[0]));
					}
					
					
					case 166341986:
					{
						return this.paintScoreInfo(((int) (global::haxe.lang.Runtime.toInt(dynargs[0])) ), ((int) (global::haxe.lang.Runtime.toInt(dynargs[1])) ));
					}
					
					
					case 1698949528:
					{
						this.drawCentered(global::haxe.lang.Runtime.toString(dynargs[0]), ((global::alphatab.platform.model.Font) (dynargs[1]) ), ((int) (global::haxe.lang.Runtime.toInt(dynargs[2])) ));
						break;
					}
					
					
					case 1365104735:
					{
						return this.doScoreInfoLayout(((int) (global::haxe.lang.Runtime.toInt(dynargs[0])) ));
					}
					
					
					default:
					{
						return base.__hx_invokeField(field, hash, dynargs);
					}
					
				}
				
				return default(object);
			}
		}
		
		
		public override   void __hx_getFields(global::haxe.root.Array<object> baseArr)
		{
			unchecked 
			{
				baseArr.push("_groups");
				{
					base.__hx_getFields(baseArr);
				}
				
			}
		}
		
		
	}
}


