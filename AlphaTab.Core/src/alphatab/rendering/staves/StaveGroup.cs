using haxe.root;
#pragma warning disable 109, 114, 219, 429, 168, 162
namespace alphatab.rendering.staves
{
	public  class StaveGroup : global::haxe.lang.HxObject 
	{
		public    StaveGroup(global::haxe.lang.EmptyObject empty)
		{
			unchecked 
			{
				{
				}
				
			}
		}
		
		
		public    StaveGroup()
		{
			unchecked 
			{
				global::alphatab.rendering.staves.StaveGroup.__hx_ctor_alphatab_rendering_staves_StaveGroup(this);
			}
		}
		
		
		public static   void __hx_ctor_alphatab_rendering_staves_StaveGroup(global::alphatab.rendering.staves.StaveGroup __temp_me266)
		{
			unchecked 
			{
				__temp_me266.bars = new global::haxe.root.Array<object>();
				__temp_me266.staves = new global::haxe.root.Array<object>();
				__temp_me266.width = 0;
			}
		}
		
		
		public static  new object __hx_createEmpty()
		{
			unchecked 
			{
				return new global::alphatab.rendering.staves.StaveGroup(((global::haxe.lang.EmptyObject) (global::haxe.lang.EmptyObject.EMPTY) ));
			}
		}
		
		
		public static  new object __hx_create(global::haxe.root.Array arr)
		{
			unchecked 
			{
				return new global::alphatab.rendering.staves.StaveGroup();
			}
		}
		
		
		public  global::alphatab.rendering.staves.Stave _firstStaveInAccolade;
		
		public  global::alphatab.rendering.staves.Stave _lastStaveInAccolade;
		
		public  int x;
		
		public  int y;
		
		public  bool isFull;
		
		public  int width;
		
		public  global::haxe.root.Array<object> bars;
		
		public  global::haxe.root.Array<object> staves;
		
		public  global::alphatab.rendering.layout.ScoreLayout layout;
		
		public   int getLastBarIndex()
		{
			unchecked 
			{
				return ((global::alphatab.model.Bar) (this.bars[( this.bars.length - 1 )]) ).index;
			}
		}
		
		
		public virtual   void addBar(global::alphatab.model.Bar bar)
		{
			unchecked 
			{
				this.bars.push(bar);
				global::alphatab.rendering.staves.BarSizeInfo maxSizes = new global::alphatab.rendering.staves.BarSizeInfo();
				{
					int _g = 0;
					global::haxe.root.Array<object> _g1 = this.staves;
					while (( _g < _g1.length ))
					{
						global::alphatab.rendering.staves.Stave s = ((global::alphatab.rendering.staves.Stave) (_g1[_g]) );
						 ++ _g;
						s.addBar(bar);
						((global::alphatab.rendering.BarRendererBase) (s.barRenderers[( s.barRenderers.length - 1 )]) ).registerMaxSizes(maxSizes);
					}
					
				}
				
				int realWidth = 0;
				{
					int _g2 = 0;
					global::haxe.root.Array<object> _g11 = this.staves;
					while (( _g2 < _g11.length ))
					{
						global::alphatab.rendering.staves.Stave s1 = ((global::alphatab.rendering.staves.Stave) (_g11[_g2]) );
						 ++ _g2;
						((global::alphatab.rendering.BarRendererBase) (s1.barRenderers[( s1.barRenderers.length - 1 )]) ).applySizes(maxSizes);
						if (( ((global::alphatab.rendering.BarRendererBase) (s1.barRenderers[( s1.barRenderers.length - 1 )]) ).width > realWidth )) 
						{
							realWidth = ((global::alphatab.rendering.BarRendererBase) (s1.barRenderers[( s1.barRenderers.length - 1 )]) ).width;
						}
						
					}
					
				}
				
				this.width += realWidth;
			}
		}
		
		
		public virtual   void addStave(global::alphatab.rendering.staves.Stave stave)
		{
			unchecked 
			{
				stave.staveGroup = this;
				stave.index = this.staves.length;
				this.staves.push(stave);
				if (( ( this._firstStaveInAccolade == default(global::alphatab.rendering.staves.Stave) ) && stave._factory.isInAccolade )) 
				{
					this._firstStaveInAccolade = stave;
					stave.isFirstInAccolade = true;
				}
				
				if (stave._factory.isInAccolade) 
				{
					if (( this._lastStaveInAccolade != default(global::alphatab.rendering.staves.Stave) )) 
					{
						this._lastStaveInAccolade.isLastInAccolade = false;
					}
					
					this._lastStaveInAccolade = stave;
					this._lastStaveInAccolade.isLastInAccolade = true;
				}
				
			}
		}
		
		
		public virtual   int calculateHeight()
		{
			unchecked 
			{
				return ( ((global::alphatab.rendering.staves.Stave) (this.staves[( this.staves.length - 1 )]) ).y + ((global::alphatab.rendering.staves.Stave) (this.staves[( this.staves.length - 1 )]) ).height );
			}
		}
		
		
		public virtual   void revertLastBar()
		{
			unchecked 
			{
				if (( this.bars.length > 1 )) 
				{
					this.bars.pop();
					int w = 0;
					{
						int _g = 0;
						global::haxe.root.Array<object> _g1 = this.staves;
						while (( _g < _g1.length ))
						{
							global::alphatab.rendering.staves.Stave s = ((global::alphatab.rendering.staves.Stave) (_g1[_g]) );
							 ++ _g;
							{
								double x = global::System.Math.Max(((double) (w) ), ((double) (((global::alphatab.rendering.BarRendererBase) (s.barRenderers[( s.barRenderers.length - 1 )]) ).width) ));
								w = ((int) (x) );
							}
							
							s.revertLastBar();
						}
						
					}
					
					this.width -= w;
				}
				
			}
		}
		
		
		public virtual   void applyBarSpacing(int spacing)
		{
			unchecked 
			{
				{
					int _g = 0;
					global::haxe.root.Array<object> _g1 = this.staves;
					while (( _g < _g1.length ))
					{
						global::alphatab.rendering.staves.Stave s = ((global::alphatab.rendering.staves.Stave) (_g1[_g]) );
						 ++ _g;
						s.applyBarSpacing(spacing);
					}
					
				}
				
				this.width += ( this.bars.length * spacing );
			}
		}
		
		
		public virtual   void paint(int cx, int cy, global::alphatab.platform.ICanvas canvas)
		{
			unchecked 
			{
				{
					int _g = 0;
					global::haxe.root.Array<object> _g1 = this.staves;
					while (( _g < _g1.length ))
					{
						global::alphatab.rendering.staves.Stave s = ((global::alphatab.rendering.staves.Stave) (_g1[_g]) );
						 ++ _g;
						s.paint(( cx + this.x ), ( cy + this.y ), canvas);
					}
					
				}
				
				global::alphatab.rendering.RenderingResources res = this.layout.renderer.renderingResources;
				if (( this.staves.length > 0 )) 
				{
					if (( ( this._firstStaveInAccolade != default(global::alphatab.rendering.staves.Stave) ) && ( this._lastStaveInAccolade != default(global::alphatab.rendering.staves.Stave) ) )) 
					{
						int firstStart = ( ( ( ( ( cy + this.y ) + this._firstStaveInAccolade.y ) + this._firstStaveInAccolade.staveTop ) + this._firstStaveInAccolade.topSpacing ) + this._firstStaveInAccolade.getTopOverflow() );
						int lastEnd = ( ( ( ( ( cy + this.y ) + this._lastStaveInAccolade.y ) + this._lastStaveInAccolade.topSpacing ) + this._lastStaveInAccolade.getTopOverflow() ) + this._lastStaveInAccolade.staveBottom );
						canvas.setColor(res.barSeperatorColor);
						canvas.beginPath();
						canvas.moveTo(((double) (( ( cx + this.x ) + this._firstStaveInAccolade.x )) ), ((double) (firstStart) ));
						canvas.lineTo(((double) (( ( cx + this.x ) + this._lastStaveInAccolade.x )) ), ((double) (lastEnd) ));
						canvas.stroke();
						int barSize = ((int) (( 3 * this.layout.renderer.settings.scale )) );
						int barOffset = barSize;
						int accoladeStart = ( firstStart - ( barSize * 4 ) );
						int accoladeEnd = ( lastEnd + ( barSize * 4 ) );
						canvas.fillRect(((double) (( ( ( cx + this.x ) - barOffset ) - barSize )) ), ((double) (accoladeStart) ), ((double) (barSize) ), ((double) (( accoladeEnd - accoladeStart )) ));
						int spikeStartX = ( ( ( cx + this.x ) - barOffset ) - barSize );
						int spikeEndX = ( ( cx + this.x ) + ( barSize * 2 ) );
						canvas.beginPath();
						canvas.moveTo(((double) (spikeStartX) ), ((double) (accoladeStart) ));
						canvas.bezierCurveTo(((double) (spikeStartX) ), ((double) (accoladeStart) ), ((double) (this.x) ), ((double) (accoladeStart) ), ((double) (spikeEndX) ), ((double) (( accoladeStart - barSize )) ));
						canvas.bezierCurveTo(((double) (( cx + this.x )) ), ((double) (( accoladeStart + barSize )) ), ((double) (spikeStartX) ), ((double) (( accoladeStart + barSize )) ), ((double) (spikeStartX) ), ((double) (( accoladeStart + barSize )) ));
						canvas.closePath();
						canvas.fill();
						canvas.beginPath();
						canvas.moveTo(((double) (spikeStartX) ), ((double) (accoladeEnd) ));
						canvas.bezierCurveTo(((double) (spikeStartX) ), ((double) (accoladeEnd) ), ((double) (this.x) ), ((double) (accoladeEnd) ), ((double) (spikeEndX) ), ((double) (( accoladeEnd + barSize )) ));
						canvas.bezierCurveTo(((double) (this.x) ), ((double) (( accoladeEnd - barSize )) ), ((double) (spikeStartX) ), ((double) (( accoladeEnd - barSize )) ), ((double) (spikeStartX) ), ((double) (( accoladeEnd - barSize )) ));
						canvas.closePath();
						canvas.fill();
					}
					
				}
				
			}
		}
		
		
		public virtual   void finalizeGroup(global::alphatab.rendering.layout.ScoreLayout scoreLayout)
		{
			unchecked 
			{
				double currentY = ((double) (0) );
				{
					int _g1 = 0;
					int _g = this.staves.length;
					while (( _g1 < _g ))
					{
						int i = _g1++;
						((global::alphatab.rendering.staves.Stave) (this.staves[i]) ).x = 0;
						((global::alphatab.rendering.staves.Stave) (this.staves[i]) ).y = ((int) (currentY) );
						((global::alphatab.rendering.staves.Stave) (this.staves[i]) ).finalizeStave(scoreLayout);
						currentY += ((double) (((global::alphatab.rendering.staves.Stave) (this.staves[i]) ).height) );
					}
					
				}
				
			}
		}
		
		
		public override   double __hx_setField_f(string field, int hash, double @value, bool handleProperties)
		{
			unchecked 
			{
				switch (hash)
				{
					case 1247983110:
					{
						this.width = ((int) (@value) );
						return @value;
					}
					
					
					case 121:
					{
						this.y = ((int) (@value) );
						return @value;
					}
					
					
					case 120:
					{
						this.x = ((int) (@value) );
						return @value;
					}
					
					
					default:
					{
						return base.__hx_setField_f(field, hash, @value, handleProperties);
					}
					
				}
				
			}
		}
		
		
		public override   object __hx_setField(string field, int hash, object @value, bool handleProperties)
		{
			unchecked 
			{
				switch (hash)
				{
					case 1488498346:
					{
						this.layout = ((global::alphatab.rendering.layout.ScoreLayout) (@value) );
						return @value;
					}
					
					
					case 100490692:
					{
						this.staves = ((global::haxe.root.Array<object>) (global::haxe.root.Array<object>.__hx_cast<object>(((global::haxe.root.Array) (@value) ))) );
						return @value;
					}
					
					
					case 1091626816:
					{
						this.bars = ((global::haxe.root.Array<object>) (global::haxe.root.Array<object>.__hx_cast<object>(((global::haxe.root.Array) (@value) ))) );
						return @value;
					}
					
					
					case 1247983110:
					{
						this.width = ((int) (global::haxe.lang.Runtime.toInt(@value)) );
						return @value;
					}
					
					
					case 1630252697:
					{
						this.isFull = ((bool) (@value) );
						return @value;
					}
					
					
					case 121:
					{
						this.y = ((int) (global::haxe.lang.Runtime.toInt(@value)) );
						return @value;
					}
					
					
					case 120:
					{
						this.x = ((int) (global::haxe.lang.Runtime.toInt(@value)) );
						return @value;
					}
					
					
					case 539976515:
					{
						this._lastStaveInAccolade = ((global::alphatab.rendering.staves.Stave) (@value) );
						return @value;
					}
					
					
					case 84315527:
					{
						this._firstStaveInAccolade = ((global::alphatab.rendering.staves.Stave) (@value) );
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
					case 1374732481:
					{
						return ((global::haxe.lang.Function) (new global::haxe.lang.Closure(((object) (this) ), global::haxe.lang.Runtime.toString("finalizeGroup"), ((int) (1374732481) ))) );
					}
					
					
					case 1028568990:
					{
						return ((global::haxe.lang.Function) (new global::haxe.lang.Closure(((object) (this) ), global::haxe.lang.Runtime.toString("paint"), ((int) (1028568990) ))) );
					}
					
					
					case 561297662:
					{
						return ((global::haxe.lang.Function) (new global::haxe.lang.Closure(((object) (this) ), global::haxe.lang.Runtime.toString("applyBarSpacing"), ((int) (561297662) ))) );
					}
					
					
					case 1131575193:
					{
						return ((global::haxe.lang.Function) (new global::haxe.lang.Closure(((object) (this) ), global::haxe.lang.Runtime.toString("revertLastBar"), ((int) (1131575193) ))) );
					}
					
					
					case 930488813:
					{
						return ((global::haxe.lang.Function) (new global::haxe.lang.Closure(((object) (this) ), global::haxe.lang.Runtime.toString("calculateHeight"), ((int) (930488813) ))) );
					}
					
					
					case 2104008174:
					{
						return ((global::haxe.lang.Function) (new global::haxe.lang.Closure(((object) (this) ), global::haxe.lang.Runtime.toString("addStave"), ((int) (2104008174) ))) );
					}
					
					
					case 519815730:
					{
						return ((global::haxe.lang.Function) (new global::haxe.lang.Closure(((object) (this) ), global::haxe.lang.Runtime.toString("addBar"), ((int) (519815730) ))) );
					}
					
					
					case 291454571:
					{
						return ((global::haxe.lang.Function) (new global::haxe.lang.Closure(((object) (this) ), global::haxe.lang.Runtime.toString("getLastBarIndex"), ((int) (291454571) ))) );
					}
					
					
					case 1488498346:
					{
						return this.layout;
					}
					
					
					case 100490692:
					{
						return this.staves;
					}
					
					
					case 1091626816:
					{
						return this.bars;
					}
					
					
					case 1247983110:
					{
						return this.width;
					}
					
					
					case 1630252697:
					{
						return this.isFull;
					}
					
					
					case 121:
					{
						return this.y;
					}
					
					
					case 120:
					{
						return this.x;
					}
					
					
					case 539976515:
					{
						return this._lastStaveInAccolade;
					}
					
					
					case 84315527:
					{
						return this._firstStaveInAccolade;
					}
					
					
					default:
					{
						return base.__hx_getField(field, hash, throwErrors, isCheck, handleProperties);
					}
					
				}
				
			}
		}
		
		
		public override   double __hx_getField_f(string field, int hash, bool throwErrors, bool handleProperties)
		{
			unchecked 
			{
				switch (hash)
				{
					case 1247983110:
					{
						return ((double) (this.width) );
					}
					
					
					case 121:
					{
						return ((double) (this.y) );
					}
					
					
					case 120:
					{
						return ((double) (this.x) );
					}
					
					
					default:
					{
						return base.__hx_getField_f(field, hash, throwErrors, handleProperties);
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
					case 1374732481:
					{
						this.finalizeGroup(((global::alphatab.rendering.layout.ScoreLayout) (dynargs[0]) ));
						break;
					}
					
					
					case 1028568990:
					{
						this.paint(((int) (global::haxe.lang.Runtime.toInt(dynargs[0])) ), ((int) (global::haxe.lang.Runtime.toInt(dynargs[1])) ), ((global::alphatab.platform.ICanvas) (dynargs[2]) ));
						break;
					}
					
					
					case 561297662:
					{
						this.applyBarSpacing(((int) (global::haxe.lang.Runtime.toInt(dynargs[0])) ));
						break;
					}
					
					
					case 1131575193:
					{
						this.revertLastBar();
						break;
					}
					
					
					case 930488813:
					{
						return this.calculateHeight();
					}
					
					
					case 2104008174:
					{
						this.addStave(((global::alphatab.rendering.staves.Stave) (dynargs[0]) ));
						break;
					}
					
					
					case 519815730:
					{
						this.addBar(((global::alphatab.model.Bar) (dynargs[0]) ));
						break;
					}
					
					
					case 291454571:
					{
						return this.getLastBarIndex();
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
				baseArr.push("layout");
				baseArr.push("staves");
				baseArr.push("bars");
				baseArr.push("width");
				baseArr.push("isFull");
				baseArr.push("y");
				baseArr.push("x");
				baseArr.push("_lastStaveInAccolade");
				baseArr.push("_firstStaveInAccolade");
				{
					base.__hx_getFields(baseArr);
				}
				
			}
		}
		
		
	}
}


