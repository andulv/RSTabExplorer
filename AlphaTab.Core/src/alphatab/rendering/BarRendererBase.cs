using haxe.root;
#pragma warning disable 109, 114, 219, 429, 168, 162
namespace alphatab.rendering
{
	public  class BarRendererBase : global::haxe.lang.HxObject 
	{
		public    BarRendererBase(global::haxe.lang.EmptyObject empty)
		{
			unchecked 
			{
				{
				}
				
			}
		}
		
		
		public    BarRendererBase(global::alphatab.model.Bar bar)
		{
			unchecked 
			{
				global::alphatab.rendering.BarRendererBase.__hx_ctor_alphatab_rendering_BarRendererBase(this, bar);
			}
		}
		
		
		public static   void __hx_ctor_alphatab_rendering_BarRendererBase(global::alphatab.rendering.BarRendererBase __temp_me90, global::alphatab.model.Bar bar)
		{
			unchecked 
			{
				__temp_me90._bar = bar;
				__temp_me90.x = 0;
				__temp_me90.y = 0;
				__temp_me90.width = 0;
				__temp_me90.height = 0;
				__temp_me90.index = 0;
				__temp_me90.topOverflow = 0;
				__temp_me90.bottomOverflow = 0;
				__temp_me90.isEmpty = true;
			}
		}
		
		
		public static  new object __hx_createEmpty()
		{
			unchecked 
			{
				return new global::alphatab.rendering.BarRendererBase(((global::haxe.lang.EmptyObject) (global::haxe.lang.EmptyObject.EMPTY) ));
			}
		}
		
		
		public static  new object __hx_create(global::haxe.root.Array arr)
		{
			unchecked 
			{
				return new global::alphatab.rendering.BarRendererBase(((global::alphatab.model.Bar) (arr[0]) ));
			}
		}
		
		
		public  global::alphatab.rendering.staves.Stave stave;
		
		public  int x;
		
		public  int y;
		
		public  int width;
		
		public  int height;
		
		public  int index;
		
		public  bool isEmpty;
		
		public  int topOverflow;
		
		public  int bottomOverflow;
		
		public  global::alphatab.model.Bar _bar;
		
		public virtual   void registerOverflowTop(int topOverflow)
		{
			unchecked 
			{
				if (( topOverflow > this.topOverflow )) 
				{
					this.topOverflow = topOverflow;
				}
				
			}
		}
		
		
		public virtual   void registerOverflowBottom(int bottomOverflow)
		{
			unchecked 
			{
				if (( bottomOverflow > this.bottomOverflow )) 
				{
					this.bottomOverflow = bottomOverflow;
				}
				
			}
		}
		
		
		public virtual   void applyBarSpacing(int spacing)
		{
			unchecked 
			{
				{
				}
				
			}
		}
		
		
		public   global::alphatab.Settings getSettings()
		{
			unchecked 
			{
				return this.stave.staveGroup.layout.renderer.settings;
			}
		}
		
		
		public   double getScale()
		{
			unchecked 
			{
				return this.stave.staveGroup.layout.renderer.settings.scale;
			}
		}
		
		
		public   global::alphatab.rendering.layout.ScoreLayout getLayout()
		{
			unchecked 
			{
				return this.stave.staveGroup.layout;
			}
		}
		
		
		public   global::alphatab.rendering.RenderingResources getResources()
		{
			unchecked 
			{
				return this.stave.staveGroup.layout.renderer.renderingResources;
			}
		}
		
		
		public   bool isFirstOfLine()
		{
			unchecked 
			{
				return ( this.index == 0 );
			}
		}
		
		
		public   bool isLastOfLine()
		{
			unchecked 
			{
				return ( this.index == ( this.stave.barRenderers.length - 1 ) );
			}
		}
		
		
		public   bool isLast()
		{
			unchecked 
			{
				return ( this._bar.index == ( this._bar.track.bars.length - 1 ) );
			}
		}
		
		
		public virtual   void registerMaxSizes(global::alphatab.rendering.staves.BarSizeInfo sizes)
		{
			unchecked 
			{
				{
				}
				
			}
		}
		
		
		public virtual   void applySizes(global::alphatab.rendering.staves.BarSizeInfo sizes)
		{
			unchecked 
			{
				{
				}
				
			}
		}
		
		
		public virtual   void finalizeRenderer(global::alphatab.rendering.layout.ScoreLayout layout)
		{
			unchecked 
			{
				{
				}
				
			}
		}
		
		
		public virtual   int getTopPadding()
		{
			unchecked 
			{
				return 0;
			}
		}
		
		
		public virtual   int getBottomPadding()
		{
			unchecked 
			{
				return 0;
			}
		}
		
		
		public virtual   void doLayout()
		{
			unchecked 
			{
				{
				}
				
			}
		}
		
		
		public virtual   void paint(int cx, int cy, global::alphatab.platform.ICanvas canvas)
		{
			unchecked 
			{
				{
				}
				
			}
		}
		
		
		public override   double __hx_setField_f(string field, int hash, double @value, bool handleProperties)
		{
			unchecked 
			{
				switch (hash)
				{
					case 1079503181:
					{
						this.bottomOverflow = ((int) (@value) );
						return @value;
					}
					
					
					case 698229495:
					{
						this.topOverflow = ((int) (@value) );
						return @value;
					}
					
					
					case 1041537810:
					{
						this.index = ((int) (@value) );
						return @value;
					}
					
					
					case 38537191:
					{
						this.height = ((int) (@value) );
						return @value;
					}
					
					
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
					case 1058404052:
					{
						this._bar = ((global::alphatab.model.Bar) (@value) );
						return @value;
					}
					
					
					case 1079503181:
					{
						this.bottomOverflow = ((int) (global::haxe.lang.Runtime.toInt(@value)) );
						return @value;
					}
					
					
					case 698229495:
					{
						this.topOverflow = ((int) (global::haxe.lang.Runtime.toInt(@value)) );
						return @value;
					}
					
					
					case 207609411:
					{
						this.isEmpty = ((bool) (@value) );
						return @value;
					}
					
					
					case 1041537810:
					{
						this.index = ((int) (global::haxe.lang.Runtime.toInt(@value)) );
						return @value;
					}
					
					
					case 38537191:
					{
						this.height = ((int) (global::haxe.lang.Runtime.toInt(@value)) );
						return @value;
					}
					
					
					case 1247983110:
					{
						this.width = ((int) (global::haxe.lang.Runtime.toInt(@value)) );
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
					
					
					case 67860431:
					{
						this.stave = ((global::alphatab.rendering.staves.Stave) (@value) );
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
					case 1028568990:
					{
						return ((global::haxe.lang.Function) (new global::haxe.lang.Closure(((object) (this) ), global::haxe.lang.Runtime.toString("paint"), ((int) (1028568990) ))) );
					}
					
					
					case 1825584277:
					{
						return ((global::haxe.lang.Function) (new global::haxe.lang.Closure(((object) (this) ), global::haxe.lang.Runtime.toString("doLayout"), ((int) (1825584277) ))) );
					}
					
					
					case 357418928:
					{
						return ((global::haxe.lang.Function) (new global::haxe.lang.Closure(((object) (this) ), global::haxe.lang.Runtime.toString("getBottomPadding"), ((int) (357418928) ))) );
					}
					
					
					case 415081458:
					{
						return ((global::haxe.lang.Function) (new global::haxe.lang.Closure(((object) (this) ), global::haxe.lang.Runtime.toString("getTopPadding"), ((int) (415081458) ))) );
					}
					
					
					case 236164353:
					{
						return ((global::haxe.lang.Function) (new global::haxe.lang.Closure(((object) (this) ), global::haxe.lang.Runtime.toString("finalizeRenderer"), ((int) (236164353) ))) );
					}
					
					
					case 673875012:
					{
						return ((global::haxe.lang.Function) (new global::haxe.lang.Closure(((object) (this) ), global::haxe.lang.Runtime.toString("applySizes"), ((int) (673875012) ))) );
					}
					
					
					case 632903889:
					{
						return ((global::haxe.lang.Function) (new global::haxe.lang.Closure(((object) (this) ), global::haxe.lang.Runtime.toString("registerMaxSizes"), ((int) (632903889) ))) );
					}
					
					
					case 1695797088:
					{
						return ((global::haxe.lang.Function) (new global::haxe.lang.Closure(((object) (this) ), global::haxe.lang.Runtime.toString("isLast"), ((int) (1695797088) ))) );
					}
					
					
					case 1812105259:
					{
						return ((global::haxe.lang.Function) (new global::haxe.lang.Closure(((object) (this) ), global::haxe.lang.Runtime.toString("isLastOfLine"), ((int) (1812105259) ))) );
					}
					
					
					case 1020198193:
					{
						return ((global::haxe.lang.Function) (new global::haxe.lang.Closure(((object) (this) ), global::haxe.lang.Runtime.toString("isFirstOfLine"), ((int) (1020198193) ))) );
					}
					
					
					case 1225225327:
					{
						return ((global::haxe.lang.Function) (new global::haxe.lang.Closure(((object) (this) ), global::haxe.lang.Runtime.toString("getResources"), ((int) (1225225327) ))) );
					}
					
					
					case 1427060704:
					{
						return ((global::haxe.lang.Function) (new global::haxe.lang.Closure(((object) (this) ), global::haxe.lang.Runtime.toString("getLayout"), ((int) (1427060704) ))) );
					}
					
					
					case 1487265300:
					{
						return ((global::haxe.lang.Function) (new global::haxe.lang.Closure(((object) (this) ), global::haxe.lang.Runtime.toString("getScale"), ((int) (1487265300) ))) );
					}
					
					
					case 825311129:
					{
						return ((global::haxe.lang.Function) (new global::haxe.lang.Closure(((object) (this) ), global::haxe.lang.Runtime.toString("getSettings"), ((int) (825311129) ))) );
					}
					
					
					case 561297662:
					{
						return ((global::haxe.lang.Function) (new global::haxe.lang.Closure(((object) (this) ), global::haxe.lang.Runtime.toString("applyBarSpacing"), ((int) (561297662) ))) );
					}
					
					
					case 880319888:
					{
						return ((global::haxe.lang.Function) (new global::haxe.lang.Closure(((object) (this) ), global::haxe.lang.Runtime.toString("registerOverflowBottom"), ((int) (880319888) ))) );
					}
					
					
					case 1694779088:
					{
						return ((global::haxe.lang.Function) (new global::haxe.lang.Closure(((object) (this) ), global::haxe.lang.Runtime.toString("registerOverflowTop"), ((int) (1694779088) ))) );
					}
					
					
					case 1058404052:
					{
						return this._bar;
					}
					
					
					case 1079503181:
					{
						return this.bottomOverflow;
					}
					
					
					case 698229495:
					{
						return this.topOverflow;
					}
					
					
					case 207609411:
					{
						return this.isEmpty;
					}
					
					
					case 1041537810:
					{
						return this.index;
					}
					
					
					case 38537191:
					{
						return this.height;
					}
					
					
					case 1247983110:
					{
						return this.width;
					}
					
					
					case 121:
					{
						return this.y;
					}
					
					
					case 120:
					{
						return this.x;
					}
					
					
					case 67860431:
					{
						return this.stave;
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
					case 1079503181:
					{
						return ((double) (this.bottomOverflow) );
					}
					
					
					case 698229495:
					{
						return ((double) (this.topOverflow) );
					}
					
					
					case 1041537810:
					{
						return ((double) (this.index) );
					}
					
					
					case 38537191:
					{
						return ((double) (this.height) );
					}
					
					
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
					case 1028568990:
					{
						this.paint(((int) (global::haxe.lang.Runtime.toInt(dynargs[0])) ), ((int) (global::haxe.lang.Runtime.toInt(dynargs[1])) ), ((global::alphatab.platform.ICanvas) (dynargs[2]) ));
						break;
					}
					
					
					case 1825584277:
					{
						this.doLayout();
						break;
					}
					
					
					case 357418928:
					{
						return this.getBottomPadding();
					}
					
					
					case 415081458:
					{
						return this.getTopPadding();
					}
					
					
					case 236164353:
					{
						this.finalizeRenderer(((global::alphatab.rendering.layout.ScoreLayout) (dynargs[0]) ));
						break;
					}
					
					
					case 673875012:
					{
						this.applySizes(((global::alphatab.rendering.staves.BarSizeInfo) (dynargs[0]) ));
						break;
					}
					
					
					case 632903889:
					{
						this.registerMaxSizes(((global::alphatab.rendering.staves.BarSizeInfo) (dynargs[0]) ));
						break;
					}
					
					
					case 1695797088:
					{
						return this.isLast();
					}
					
					
					case 1812105259:
					{
						return this.isLastOfLine();
					}
					
					
					case 1020198193:
					{
						return this.isFirstOfLine();
					}
					
					
					case 1225225327:
					{
						return this.getResources();
					}
					
					
					case 1427060704:
					{
						return this.getLayout();
					}
					
					
					case 1487265300:
					{
						return this.getScale();
					}
					
					
					case 825311129:
					{
						return this.getSettings();
					}
					
					
					case 561297662:
					{
						this.applyBarSpacing(((int) (global::haxe.lang.Runtime.toInt(dynargs[0])) ));
						break;
					}
					
					
					case 880319888:
					{
						this.registerOverflowBottom(((int) (global::haxe.lang.Runtime.toInt(dynargs[0])) ));
						break;
					}
					
					
					case 1694779088:
					{
						this.registerOverflowTop(((int) (global::haxe.lang.Runtime.toInt(dynargs[0])) ));
						break;
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
				baseArr.push("_bar");
				baseArr.push("bottomOverflow");
				baseArr.push("topOverflow");
				baseArr.push("isEmpty");
				baseArr.push("index");
				baseArr.push("height");
				baseArr.push("width");
				baseArr.push("y");
				baseArr.push("x");
				baseArr.push("stave");
				{
					base.__hx_getFields(baseArr);
				}
				
			}
		}
		
		
	}
}


