using haxe.root;
#pragma warning disable 109, 114, 219, 429, 168, 162
namespace alphatab.rendering.glyphs
{
	public  class GlyphGroup : global::alphatab.rendering.Glyph 
	{
		public    GlyphGroup(global::haxe.lang.EmptyObject empty) : base(global::haxe.lang.EmptyObject.EMPTY)
		{
			unchecked 
			{
			}
		}
		
		
		public    GlyphGroup(global::haxe.lang.Null<int> x, global::haxe.lang.Null<int> y, global::haxe.root.Array<object> glyphs) : base(global::haxe.lang.EmptyObject.EMPTY)
		{
			unchecked 
			{
				global::alphatab.rendering.glyphs.GlyphGroup.__hx_ctor_alphatab_rendering_glyphs_GlyphGroup(this, x, y, glyphs);
			}
		}
		
		
		public static   void __hx_ctor_alphatab_rendering_glyphs_GlyphGroup(global::alphatab.rendering.glyphs.GlyphGroup __temp_me115, global::haxe.lang.Null<int> x, global::haxe.lang.Null<int> y, global::haxe.root.Array<object> glyphs)
		{
			unchecked 
			{
				int __temp_y114 = ( (global::haxe.lang.Runtime.eq((y).toDynamic(), (default(global::haxe.lang.Null<int>)).toDynamic())) ? (((int) (0) )) : (y.@value) );
				int __temp_x113 = ( (global::haxe.lang.Runtime.eq((x).toDynamic(), (default(global::haxe.lang.Null<int>)).toDynamic())) ? (((int) (0) )) : (x.@value) );
				global::alphatab.rendering.Glyph.__hx_ctor_alphatab_rendering_Glyph(__temp_me115, new global::haxe.lang.Null<int>(__temp_x113, true), new global::haxe.lang.Null<int>(__temp_y114, true));
				if (( glyphs != default(global::haxe.root.Array<object>) )) 
				{
					__temp_me115._glyphs = glyphs;
				}
				 else 
				{
					__temp_me115._glyphs = new global::haxe.root.Array<object>();
				}
				
			}
		}
		
		
		public static  new object __hx_createEmpty()
		{
			unchecked 
			{
				return new global::alphatab.rendering.glyphs.GlyphGroup(((global::haxe.lang.EmptyObject) (global::haxe.lang.EmptyObject.EMPTY) ));
			}
		}
		
		
		public static  new object __hx_create(global::haxe.root.Array arr)
		{
			unchecked 
			{
				return new global::alphatab.rendering.glyphs.GlyphGroup(global::haxe.lang.Null<object>.ofDynamic<int>(arr[0]), global::haxe.lang.Null<object>.ofDynamic<int>(arr[1]), ((global::haxe.root.Array<object>) (global::haxe.root.Array<object>.__hx_cast<object>(((global::haxe.root.Array) (arr[2]) ))) ));
			}
		}
		
		
		public  global::haxe.root.Array<object> _glyphs;
		
		public override   void doLayout()
		{
			unchecked 
			{
				int w = 0;
				{
					int _g = 0;
					global::haxe.root.Array<object> _g1 = this._glyphs;
					while (( _g < _g1.length ))
					{
						global::alphatab.rendering.Glyph g = ((global::alphatab.rendering.Glyph) (_g1[_g]) );
						 ++ _g;
						g.renderer = this.renderer;
						g.doLayout();
						{
							double x = global::System.Math.Max(((double) (w) ), ((double) (g.width) ));
							w = ((int) (x) );
						}
						
					}
					
				}
				
				this.width = w;
			}
		}
		
		
		public virtual   void addGlyph(global::alphatab.rendering.Glyph g)
		{
			unchecked 
			{
				this._glyphs.push(g);
			}
		}
		
		
		public override   void paint(int cx, int cy, global::alphatab.platform.ICanvas canvas)
		{
			unchecked 
			{
				int _g = 0;
				global::haxe.root.Array<object> _g1 = this._glyphs;
				while (( _g < _g1.length ))
				{
					global::alphatab.rendering.Glyph g = ((global::alphatab.rendering.Glyph) (_g1[_g]) );
					 ++ _g;
					g.renderer = this.renderer;
					g.paint(( cx + this.x ), ( cy + this.y ), canvas);
				}
				
			}
		}
		
		
		public override   object __hx_setField(string field, int hash, object @value, bool handleProperties)
		{
			unchecked 
			{
				switch (hash)
				{
					case 483396326:
					{
						this._glyphs = ((global::haxe.root.Array<object>) (global::haxe.root.Array<object>.__hx_cast<object>(((global::haxe.root.Array) (@value) ))) );
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
					
					
					case 258089931:
					{
						return ((global::haxe.lang.Function) (new global::haxe.lang.Closure(((object) (this) ), global::haxe.lang.Runtime.toString("addGlyph"), ((int) (258089931) ))) );
					}
					
					
					case 1825584277:
					{
						return ((global::haxe.lang.Function) (new global::haxe.lang.Closure(((object) (this) ), global::haxe.lang.Runtime.toString("doLayout"), ((int) (1825584277) ))) );
					}
					
					
					case 483396326:
					{
						return this._glyphs;
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
					case 1825584277:case 1028568990:
					{
						return global::haxe.lang.Runtime.slowCallField(this, field, dynargs);
					}
					
					
					case 258089931:
					{
						this.addGlyph(((global::alphatab.rendering.Glyph) (dynargs[0]) ));
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
				baseArr.push("_glyphs");
				{
					base.__hx_getFields(baseArr);
				}
				
			}
		}
		
		
	}
}


