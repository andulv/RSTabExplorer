using haxe.root;
#pragma warning disable 109, 114, 219, 429, 168, 162
namespace alphatab.rendering
{
	public  class Glyph : global::haxe.lang.HxObject 
	{
		public    Glyph(global::haxe.lang.EmptyObject empty)
		{
			unchecked 
			{
				{
				}
				
			}
		}
		
		
		public    Glyph(global::haxe.lang.Null<int> x, global::haxe.lang.Null<int> y)
		{
			unchecked 
			{
				global::alphatab.rendering.Glyph.__hx_ctor_alphatab_rendering_Glyph(this, x, y);
			}
		}
		
		
		public static   void __hx_ctor_alphatab_rendering_Glyph(global::alphatab.rendering.Glyph __temp_me96, global::haxe.lang.Null<int> x, global::haxe.lang.Null<int> y)
		{
			unchecked 
			{
				int __temp_y95 = ( (global::haxe.lang.Runtime.eq((y).toDynamic(), (default(global::haxe.lang.Null<int>)).toDynamic())) ? (((int) (0) )) : (y.@value) );
				int __temp_x94 = ( (global::haxe.lang.Runtime.eq((x).toDynamic(), (default(global::haxe.lang.Null<int>)).toDynamic())) ? (((int) (0) )) : (x.@value) );
				__temp_me96.x = __temp_x94;
				__temp_me96.y = __temp_y95;
			}
		}
		
		
		public static  new object __hx_createEmpty()
		{
			unchecked 
			{
				return new global::alphatab.rendering.Glyph(((global::haxe.lang.EmptyObject) (global::haxe.lang.EmptyObject.EMPTY) ));
			}
		}
		
		
		public static  new object __hx_create(global::haxe.root.Array arr)
		{
			unchecked 
			{
				return new global::alphatab.rendering.Glyph(global::haxe.lang.Null<object>.ofDynamic<int>(arr[0]), global::haxe.lang.Null<object>.ofDynamic<int>(arr[1]));
			}
		}
		
		
		public  int index;
		
		public  int x;
		
		public  int y;
		
		public  int width;
		
		public  global::alphatab.rendering.BarRendererBase renderer;
		
		public virtual   void applyGlyphSpacing(int spacing)
		{
			unchecked 
			{
				if (this.canScale()) 
				{
					this.width += spacing;
				}
				
			}
		}
		
		
		public   double getScale()
		{
			unchecked 
			{
				return this.renderer.stave.staveGroup.layout.renderer.settings.scale;
			}
		}
		
		
		public virtual   bool canScale()
		{
			unchecked 
			{
				return true;
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
					
					
					case 1041537810:
					{
						this.index = ((int) (@value) );
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
					case 853263683:
					{
						this.renderer = ((global::alphatab.rendering.BarRendererBase) (@value) );
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
					
					
					case 1041537810:
					{
						this.index = ((int) (global::haxe.lang.Runtime.toInt(@value)) );
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
					
					
					case 1734479962:
					{
						return ((global::haxe.lang.Function) (new global::haxe.lang.Closure(((object) (this) ), global::haxe.lang.Runtime.toString("canScale"), ((int) (1734479962) ))) );
					}
					
					
					case 1487265300:
					{
						return ((global::haxe.lang.Function) (new global::haxe.lang.Closure(((object) (this) ), global::haxe.lang.Runtime.toString("getScale"), ((int) (1487265300) ))) );
					}
					
					
					case 1827465669:
					{
						return ((global::haxe.lang.Function) (new global::haxe.lang.Closure(((object) (this) ), global::haxe.lang.Runtime.toString("applyGlyphSpacing"), ((int) (1827465669) ))) );
					}
					
					
					case 853263683:
					{
						return this.renderer;
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
					
					
					case 1041537810:
					{
						return this.index;
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
					
					
					case 1041537810:
					{
						return ((double) (this.index) );
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
					
					
					case 1734479962:
					{
						return this.canScale();
					}
					
					
					case 1487265300:
					{
						return this.getScale();
					}
					
					
					case 1827465669:
					{
						this.applyGlyphSpacing(((int) (global::haxe.lang.Runtime.toInt(dynargs[0])) ));
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
				baseArr.push("renderer");
				baseArr.push("width");
				baseArr.push("y");
				baseArr.push("x");
				baseArr.push("index");
				{
					base.__hx_getFields(baseArr);
				}
				
			}
		}
		
		
	}
}


