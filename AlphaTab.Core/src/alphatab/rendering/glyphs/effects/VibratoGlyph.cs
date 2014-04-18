using haxe.root;
#pragma warning disable 109, 114, 219, 429, 168, 162
namespace alphatab.rendering.glyphs.effects
{
	public  class VibratoGlyph : global::alphatab.rendering.Glyph 
	{
		public    VibratoGlyph(global::haxe.lang.EmptyObject empty) : base(global::haxe.lang.EmptyObject.EMPTY)
		{
			unchecked 
			{
			}
		}
		
		
		public    VibratoGlyph(global::haxe.lang.Null<int> x, global::haxe.lang.Null<int> y, global::haxe.lang.Null<double> scale) : base(global::haxe.lang.EmptyObject.EMPTY)
		{
			unchecked 
			{
				global::alphatab.rendering.glyphs.effects.VibratoGlyph.__hx_ctor_alphatab_rendering_glyphs_effects_VibratoGlyph(this, x, y, scale);
			}
		}
		
		
		public static   void __hx_ctor_alphatab_rendering_glyphs_effects_VibratoGlyph(global::alphatab.rendering.glyphs.effects.VibratoGlyph __temp_me262, global::haxe.lang.Null<int> x, global::haxe.lang.Null<int> y, global::haxe.lang.Null<double> scale)
		{
			unchecked 
			{
				double __temp_scale261 = ( (global::haxe.lang.Runtime.eq((scale).toDynamic(), (default(global::haxe.lang.Null<double>)).toDynamic())) ? (((double) (0.9) )) : (scale.@value) );
				int __temp_y260 = ( (global::haxe.lang.Runtime.eq((y).toDynamic(), (default(global::haxe.lang.Null<int>)).toDynamic())) ? (((int) (0) )) : (y.@value) );
				int __temp_x259 = ( (global::haxe.lang.Runtime.eq((x).toDynamic(), (default(global::haxe.lang.Null<int>)).toDynamic())) ? (((int) (0) )) : (x.@value) );
				global::alphatab.rendering.Glyph.__hx_ctor_alphatab_rendering_Glyph(__temp_me262, new global::haxe.lang.Null<int>(__temp_x259, true), new global::haxe.lang.Null<int>(__temp_y260, true));
				__temp_me262._scale = __temp_scale261;
			}
		}
		
		
		public static  new object __hx_createEmpty()
		{
			unchecked 
			{
				return new global::alphatab.rendering.glyphs.effects.VibratoGlyph(((global::haxe.lang.EmptyObject) (global::haxe.lang.EmptyObject.EMPTY) ));
			}
		}
		
		
		public static  new object __hx_create(global::haxe.root.Array arr)
		{
			unchecked 
			{
				return new global::alphatab.rendering.glyphs.effects.VibratoGlyph(global::haxe.lang.Null<object>.ofDynamic<int>(arr[0]), global::haxe.lang.Null<object>.ofDynamic<int>(arr[1]), global::haxe.lang.Null<object>.ofDynamic<double>(arr[2]));
			}
		}
		
		
		public  double _scale;
		
		public override   void paint(int cx, int cy, global::alphatab.platform.ICanvas canvas)
		{
			unchecked 
			{
				double step = ( ( 11 * this.renderer.stave.staveGroup.layout.renderer.settings.scale ) * this._scale );
				int loops = default(int);
				{
					double v = global::System.Math.Max(((double) (1) ), ((double) (( this.width / step )) ));
					{
						double x = global::System.Math.Floor(((double) (v) ));
						loops = ((int) (x) );
					}
					
				}
				
				int loopX = 0;
				{
					int _g = 0;
					while (( _g < loops ))
					{
						int i = _g++;
						global::alphatab.rendering.glyphs.SvgGlyph glyph = new global::alphatab.rendering.glyphs.SvgGlyph(new global::haxe.lang.Null<int>(loopX, true), new global::haxe.lang.Null<int>(0, true), ((global::alphatab.rendering.glyphs.LazySvg) (global::alphatab.rendering.glyphs.MusicFont.WaveHorizontal) ), ((double) (this._scale) ), ((double) (this._scale) ));
						glyph.renderer = this.renderer;
						glyph.paint(( cx + this.x ), ( cy + this.y ), canvas);
						{
							double x1 = global::System.Math.Floor(((double) (step) ));
							loopX += ((int) (x1) );
						}
						
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
					case 1958090187:
					{
						this._scale = ((double) (@value) );
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
					case 1958090187:
					{
						this._scale = ((double) (global::haxe.lang.Runtime.toDouble(@value)) );
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
					
					
					case 1958090187:
					{
						return this._scale;
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
					case 1958090187:
					{
						return this._scale;
					}
					
					
					default:
					{
						return base.__hx_getField_f(field, hash, throwErrors, handleProperties);
					}
					
				}
				
			}
		}
		
		
		public override   void __hx_getFields(global::haxe.root.Array<object> baseArr)
		{
			unchecked 
			{
				baseArr.push("_scale");
				{
					base.__hx_getFields(baseArr);
				}
				
			}
		}
		
		
	}
}


