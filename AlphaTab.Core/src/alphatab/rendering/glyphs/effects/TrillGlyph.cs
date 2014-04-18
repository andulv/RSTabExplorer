using haxe.root;
#pragma warning disable 109, 114, 219, 429, 168, 162
namespace alphatab.rendering.glyphs.effects
{
	public  class TrillGlyph : global::alphatab.rendering.Glyph 
	{
		public    TrillGlyph(global::haxe.lang.EmptyObject empty) : base(global::haxe.lang.EmptyObject.EMPTY)
		{
			unchecked 
			{
			}
		}
		
		
		public    TrillGlyph(global::haxe.lang.Null<int> x, global::haxe.lang.Null<int> y, global::haxe.lang.Null<double> scale) : base(global::haxe.lang.EmptyObject.EMPTY)
		{
			unchecked 
			{
				global::alphatab.rendering.glyphs.effects.TrillGlyph.__hx_ctor_alphatab_rendering_glyphs_effects_TrillGlyph(this, x, y, scale);
			}
		}
		
		
		public static   void __hx_ctor_alphatab_rendering_glyphs_effects_TrillGlyph(global::alphatab.rendering.glyphs.effects.TrillGlyph __temp_me258, global::haxe.lang.Null<int> x, global::haxe.lang.Null<int> y, global::haxe.lang.Null<double> scale)
		{
			unchecked 
			{
				double __temp_scale257 = ( (global::haxe.lang.Runtime.eq((scale).toDynamic(), (default(global::haxe.lang.Null<double>)).toDynamic())) ? (((double) (0.9) )) : (scale.@value) );
				int __temp_y256 = ( (global::haxe.lang.Runtime.eq((y).toDynamic(), (default(global::haxe.lang.Null<int>)).toDynamic())) ? (((int) (0) )) : (y.@value) );
				int __temp_x255 = ( (global::haxe.lang.Runtime.eq((x).toDynamic(), (default(global::haxe.lang.Null<int>)).toDynamic())) ? (((int) (0) )) : (x.@value) );
				global::alphatab.rendering.Glyph.__hx_ctor_alphatab_rendering_Glyph(__temp_me258, new global::haxe.lang.Null<int>(__temp_x255, true), new global::haxe.lang.Null<int>(__temp_y256, true));
				__temp_me258._scale = __temp_scale257;
			}
		}
		
		
		public static  new object __hx_createEmpty()
		{
			unchecked 
			{
				return new global::alphatab.rendering.glyphs.effects.TrillGlyph(((global::haxe.lang.EmptyObject) (global::haxe.lang.EmptyObject.EMPTY) ));
			}
		}
		
		
		public static  new object __hx_create(global::haxe.root.Array arr)
		{
			unchecked 
			{
				return new global::alphatab.rendering.glyphs.effects.TrillGlyph(global::haxe.lang.Null<object>.ofDynamic<int>(arr[0]), global::haxe.lang.Null<object>.ofDynamic<int>(arr[1]), global::haxe.lang.Null<object>.ofDynamic<double>(arr[2]));
			}
		}
		
		
		public  double _scale;
		
		public override   void paint(int cx, int cy, global::alphatab.platform.ICanvas canvas)
		{
			unchecked 
			{
				global::alphatab.rendering.RenderingResources res = this.renderer.stave.staveGroup.layout.renderer.renderingResources;
				canvas.setFont(res.markerFont);
				canvas.setColor(res.mainGlyphColor);
				double textw = canvas.measureText("tr");
				canvas.fillText("tr", ((double) (( cx + this.x )) ), ((double) (( cy + this.y )) ));
				double startX = textw;
				double endX = ( this.width - startX );
				double step = ( ( 11 * this.renderer.stave.staveGroup.layout.renderer.settings.scale ) * this._scale );
				int loops = default(int);
				{
					double v = global::System.Math.Max(((double) (1) ), ((double) (( (( endX - startX )) / step )) ));
					{
						double x = global::System.Math.Floor(((double) (v) ));
						loops = ((int) (x) );
					}
					
				}
				
				int loopX = ((int) (startX) );
				{
					int _g = 0;
					while (( _g < loops ))
					{
						int i = _g++;
						global::alphatab.rendering.glyphs.SvgGlyph glyph = new global::alphatab.rendering.glyphs.SvgGlyph(new global::haxe.lang.Null<int>(loopX, true), new global::haxe.lang.Null<int>(0, true), ((global::alphatab.rendering.glyphs.LazySvg) (global::alphatab.rendering.glyphs.MusicFont.WaveHorizontal) ), ((double) (this._scale) ), ((double) (this._scale) ));
						glyph.renderer = this.renderer;
						int __temp_stmt607 = default(int);
						{
							double x1 = ( res.markerFont.getSize() / 2 );
							__temp_stmt607 = ((int) (x1) );
						}
						
						glyph.paint(( cx + this.x ), ( ( cy + this.y ) + __temp_stmt607 ), canvas);
						{
							double x2 = global::System.Math.Floor(((double) (step) ));
							loopX += ((int) (x2) );
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


