using haxe.root;
#pragma warning disable 109, 114, 219, 429, 168, 162
namespace alphatab.rendering.glyphs
{
	public  class BeamGlyph : global::alphatab.rendering.glyphs.SvgGlyph 
	{
		public    BeamGlyph(global::haxe.lang.EmptyObject empty) : base(global::haxe.lang.EmptyObject.EMPTY)
		{
			unchecked 
			{
			}
		}
		
		
		public    BeamGlyph(global::haxe.lang.Null<int> x, global::haxe.lang.Null<int> y, global::alphatab.model.Duration duration, global::alphatab.rendering.utils.BeamDirection direction, bool isGrace) : base(global::haxe.lang.EmptyObject.EMPTY)
		{
			unchecked 
			{
				global::alphatab.rendering.glyphs.BeamGlyph.__hx_ctor_alphatab_rendering_glyphs_BeamGlyph(this, x, y, duration, direction, isGrace);
			}
		}
		
		
		public static   void __hx_ctor_alphatab_rendering_glyphs_BeamGlyph(global::alphatab.rendering.glyphs.BeamGlyph __temp_me129, global::haxe.lang.Null<int> x, global::haxe.lang.Null<int> y, global::alphatab.model.Duration duration, global::alphatab.rendering.utils.BeamDirection direction, bool isGrace)
		{
			unchecked 
			{
				int __temp_y128 = ( (global::haxe.lang.Runtime.eq((y).toDynamic(), (default(global::haxe.lang.Null<int>)).toDynamic())) ? (((int) (0) )) : (y.@value) );
				int __temp_x127 = ( (global::haxe.lang.Runtime.eq((x).toDynamic(), (default(global::haxe.lang.Null<int>)).toDynamic())) ? (((int) (0) )) : (x.@value) );
				global::alphatab.rendering.glyphs.SvgGlyph.__hx_ctor_alphatab_rendering_glyphs_SvgGlyph(__temp_me129, new global::haxe.lang.Null<int>(__temp_x127, true), new global::haxe.lang.Null<int>(__temp_y128, true), __temp_me129.getRestSvg(duration, direction, isGrace), ( (isGrace) ? (0.7) : (((double) (1) )) ), __temp_me129.getSvgScale(duration, direction, isGrace));
			}
		}
		
		
		public static  new object __hx_createEmpty()
		{
			unchecked 
			{
				return new global::alphatab.rendering.glyphs.BeamGlyph(((global::haxe.lang.EmptyObject) (global::haxe.lang.EmptyObject.EMPTY) ));
			}
		}
		
		
		public static  new object __hx_create(global::haxe.root.Array arr)
		{
			unchecked 
			{
				return new global::alphatab.rendering.glyphs.BeamGlyph(global::haxe.lang.Null<object>.ofDynamic<int>(arr[0]), global::haxe.lang.Null<object>.ofDynamic<int>(arr[1]), ((global::alphatab.model.Duration) (arr[2]) ), ((global::alphatab.rendering.utils.BeamDirection) (arr[3]) ), ((bool) (arr[4]) ));
			}
		}
		
		
		public virtual   double getSvgScale(global::alphatab.model.Duration duration, global::alphatab.rendering.utils.BeamDirection direction, bool isGrace)
		{
			unchecked 
			{
				double scale = default(double);
				if (isGrace) 
				{
					scale = 0.7;
				}
				 else 
				{
					scale = ((double) (1) );
				}
				
				if (( direction == global::alphatab.rendering.utils.BeamDirection.Up )) 
				{
					return scale;
				}
				 else 
				{
					return ( -1 * scale );
				}
				
			}
		}
		
		
		public override   void doLayout()
		{
			unchecked 
			{
				this.width = 0;
			}
		}
		
		
		public virtual   global::alphatab.rendering.glyphs.LazySvg getRestSvg(global::alphatab.model.Duration duration, global::alphatab.rendering.utils.BeamDirection direction, bool isGrace)
		{
			unchecked 
			{
				if (isGrace) 
				{
					return global::alphatab.rendering.glyphs.MusicFont.FooterUpEighth;
				}
				
				switch (global::haxe.root.Type.enumIndex(duration))
				{
					case 3:
					{
						return global::alphatab.rendering.glyphs.MusicFont.FooterUpEighth;
					}
					
					
					case 4:
					{
						return global::alphatab.rendering.glyphs.MusicFont.FooterUpSixteenth;
					}
					
					
					case 5:
					{
						return global::alphatab.rendering.glyphs.MusicFont.FooterUpThirtySecond;
					}
					
					
					case 6:
					{
						return global::alphatab.rendering.glyphs.MusicFont.FooterUpSixtyFourth;
					}
					
					
					default:
					{
						return default(global::alphatab.rendering.glyphs.LazySvg);
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
					case 972861882:
					{
						return ((global::haxe.lang.Function) (new global::haxe.lang.Closure(((object) (this) ), global::haxe.lang.Runtime.toString("getRestSvg"), ((int) (972861882) ))) );
					}
					
					
					case 1825584277:
					{
						return ((global::haxe.lang.Function) (new global::haxe.lang.Closure(((object) (this) ), global::haxe.lang.Runtime.toString("doLayout"), ((int) (1825584277) ))) );
					}
					
					
					case 1027615804:
					{
						return ((global::haxe.lang.Function) (new global::haxe.lang.Closure(((object) (this) ), global::haxe.lang.Runtime.toString("getSvgScale"), ((int) (1027615804) ))) );
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
					case 1825584277:
					{
						return global::haxe.lang.Runtime.slowCallField(this, field, dynargs);
					}
					
					
					case 972861882:
					{
						return this.getRestSvg(((global::alphatab.model.Duration) (dynargs[0]) ), ((global::alphatab.rendering.utils.BeamDirection) (dynargs[1]) ), ((bool) (dynargs[2]) ));
					}
					
					
					case 1027615804:
					{
						return this.getSvgScale(((global::alphatab.model.Duration) (dynargs[0]) ), ((global::alphatab.rendering.utils.BeamDirection) (dynargs[1]) ), ((bool) (dynargs[2]) ));
					}
					
					
					default:
					{
						return base.__hx_invokeField(field, hash, dynargs);
					}
					
				}
				
			}
		}
		
		
	}
}


