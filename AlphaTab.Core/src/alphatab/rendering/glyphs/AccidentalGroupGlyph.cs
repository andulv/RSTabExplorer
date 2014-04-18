using haxe.root;
#pragma warning disable 109, 114, 219, 429, 168, 162
namespace alphatab.rendering.glyphs
{
	public  class AccidentalGroupGlyph : global::alphatab.rendering.glyphs.GlyphGroup 
	{
		static AccidentalGroupGlyph() 
		{
			global::alphatab.rendering.glyphs.AccidentalGroupGlyph.NonReserved = -3000;
		}
		public    AccidentalGroupGlyph(global::haxe.lang.EmptyObject empty) : base(global::haxe.lang.EmptyObject.EMPTY)
		{
			unchecked 
			{
			}
		}
		
		
		public    AccidentalGroupGlyph(global::haxe.lang.Null<int> x, global::haxe.lang.Null<int> y) : base(global::haxe.lang.EmptyObject.EMPTY)
		{
			unchecked 
			{
				global::alphatab.rendering.glyphs.AccidentalGroupGlyph.__hx_ctor_alphatab_rendering_glyphs_AccidentalGroupGlyph(this, x, y);
			}
		}
		
		
		public static   void __hx_ctor_alphatab_rendering_glyphs_AccidentalGroupGlyph(global::alphatab.rendering.glyphs.AccidentalGroupGlyph __temp_me118, global::haxe.lang.Null<int> x, global::haxe.lang.Null<int> y)
		{
			unchecked 
			{
				int __temp_y117 = ( (global::haxe.lang.Runtime.eq((y).toDynamic(), (default(global::haxe.lang.Null<int>)).toDynamic())) ? (((int) (0) )) : (y.@value) );
				int __temp_x116 = ( (global::haxe.lang.Runtime.eq((x).toDynamic(), (default(global::haxe.lang.Null<int>)).toDynamic())) ? (((int) (0) )) : (x.@value) );
				global::alphatab.rendering.glyphs.GlyphGroup.__hx_ctor_alphatab_rendering_glyphs_GlyphGroup(__temp_me118, new global::haxe.lang.Null<int>(__temp_x116, true), new global::haxe.lang.Null<int>(__temp_y117, true), new global::haxe.root.Array<object>());
			}
		}
		
		
		public static  int NonReserved;
		
		public static  new object __hx_createEmpty()
		{
			unchecked 
			{
				return new global::alphatab.rendering.glyphs.AccidentalGroupGlyph(((global::haxe.lang.EmptyObject) (global::haxe.lang.EmptyObject.EMPTY) ));
			}
		}
		
		
		public static  new object __hx_create(global::haxe.root.Array arr)
		{
			unchecked 
			{
				return new global::alphatab.rendering.glyphs.AccidentalGroupGlyph(global::haxe.lang.Null<object>.ofDynamic<int>(arr[0]), global::haxe.lang.Null<object>.ofDynamic<int>(arr[1]));
			}
		}
		
		
		public override   void doLayout()
		{
			unchecked 
			{
				this._glyphs.sort(( (( global::alphatab.rendering.glyphs.AccidentalGroupGlyph_doLayout_35__Fun.__hx_current != default(global::alphatab.rendering.glyphs.AccidentalGroupGlyph_doLayout_35__Fun) )) ? (global::alphatab.rendering.glyphs.AccidentalGroupGlyph_doLayout_35__Fun.__hx_current) : (global::alphatab.rendering.glyphs.AccidentalGroupGlyph_doLayout_35__Fun.__hx_current = ((global::alphatab.rendering.glyphs.AccidentalGroupGlyph_doLayout_35__Fun) (new global::alphatab.rendering.glyphs.AccidentalGroupGlyph_doLayout_35__Fun()) )) ));
				global::haxe.root.Array<int> columns = new global::haxe.root.Array<int>();
				columns.push(-3000);
				int accidentalSize = ((int) (( 21 * this.renderer.stave.staveGroup.layout.renderer.settings.scale )) );
				{
					int _g = 0;
					global::haxe.root.Array<object> _g1 = this._glyphs;
					while (( _g < _g1.length ))
					{
						global::alphatab.rendering.Glyph g = ((global::alphatab.rendering.Glyph) (_g1[_g]) );
						 ++ _g;
						g.renderer = this.renderer;
						g.doLayout();
						int gColumn = 0;
						while (( columns[gColumn] > g.y ))
						{
							gColumn++;
							if (( gColumn == columns.length )) 
							{
								columns.push(-3000);
							}
							
						}
						
						g.x = gColumn;
						columns[gColumn] = ( g.y + accidentalSize );
					}
					
				}
				
				int columnWidth = ((int) (( 8 * this.renderer.stave.staveGroup.layout.renderer.settings.scale )) );
				if (( this._glyphs.length == 0 )) 
				{
					this.width = 0;
				}
				 else 
				{
					this.width = ( columnWidth * columns.length );
				}
				
				{
					int _g2 = 0;
					global::haxe.root.Array<object> _g11 = this._glyphs;
					while (( _g2 < _g11.length ))
					{
						global::alphatab.rendering.Glyph g1 = ((global::alphatab.rendering.Glyph) (_g11[_g2]) );
						 ++ _g2;
						g1.x = ( this.width - ( (( g1.x + 1 )) * columnWidth ) );
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
					case 1825584277:
					{
						return ((global::haxe.lang.Function) (new global::haxe.lang.Closure(((object) (this) ), global::haxe.lang.Runtime.toString("doLayout"), ((int) (1825584277) ))) );
					}
					
					
					default:
					{
						return base.__hx_getField(field, hash, throwErrors, isCheck, handleProperties);
					}
					
				}
				
			}
		}
		
		
	}
}



#pragma warning disable 109, 114, 219, 429, 168, 162
namespace alphatab.rendering.glyphs
{
	public  class AccidentalGroupGlyph_doLayout_35__Fun : global::haxe.lang.Function 
	{
		public    AccidentalGroupGlyph_doLayout_35__Fun() : base(2, 1)
		{
			unchecked 
			{
			}
		}
		
		
		public static  global::alphatab.rendering.glyphs.AccidentalGroupGlyph_doLayout_35__Fun __hx_current;
		
		public override   double __hx_invoke2_f(double __fn_float1, double __fn_float2, object __fn_dyn1, object __fn_dyn2)
		{
			unchecked 
			{
				global::alphatab.rendering.Glyph b = ( (global::haxe.lang.Runtime.eq(__fn_dyn2, global::haxe.lang.Runtime.undefined)) ? (((global::alphatab.rendering.Glyph) (((object) (__fn_float2) )) )) : (((global::alphatab.rendering.Glyph) (__fn_dyn2) )) );
				global::alphatab.rendering.Glyph a = ( (global::haxe.lang.Runtime.eq(__fn_dyn1, global::haxe.lang.Runtime.undefined)) ? (((global::alphatab.rendering.Glyph) (((object) (__fn_float1) )) )) : (((global::alphatab.rendering.Glyph) (__fn_dyn1) )) );
				if (( a.y == b.y )) 
				{
					return ((double) (0) );
				}
				
				if (( a.y < b.y )) 
				{
					return ((double) (-1) );
				}
				 else 
				{
					return ((double) (1) );
				}
				
			}
		}
		
		
	}
}


