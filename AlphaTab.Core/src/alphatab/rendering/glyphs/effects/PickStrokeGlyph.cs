using haxe.root;
#pragma warning disable 109, 114, 219, 429, 168, 162
namespace alphatab.rendering.glyphs.effects
{
	public  class PickStrokeGlyph : global::alphatab.rendering.glyphs.SvgGlyph 
	{
		public    PickStrokeGlyph(global::haxe.lang.EmptyObject empty) : base(global::haxe.lang.EmptyObject.EMPTY)
		{
			unchecked 
			{
			}
		}
		
		
		public    PickStrokeGlyph(global::haxe.lang.Null<int> x, global::haxe.lang.Null<int> y, global::alphatab.model.PickStrokeType pickStroke) : base(global::haxe.lang.EmptyObject.EMPTY)
		{
			unchecked 
			{
				global::alphatab.rendering.glyphs.effects.PickStrokeGlyph.__hx_ctor_alphatab_rendering_glyphs_effects_PickStrokeGlyph(this, x, y, pickStroke);
			}
		}
		
		
		public static   void __hx_ctor_alphatab_rendering_glyphs_effects_PickStrokeGlyph(global::alphatab.rendering.glyphs.effects.PickStrokeGlyph __temp_me248, global::haxe.lang.Null<int> x, global::haxe.lang.Null<int> y, global::alphatab.model.PickStrokeType pickStroke)
		{
			unchecked 
			{
				int __temp_y247 = ( (global::haxe.lang.Runtime.eq((y).toDynamic(), (default(global::haxe.lang.Null<int>)).toDynamic())) ? (((int) (0) )) : (y.@value) );
				int __temp_x246 = ( (global::haxe.lang.Runtime.eq((x).toDynamic(), (default(global::haxe.lang.Null<int>)).toDynamic())) ? (((int) (0) )) : (x.@value) );
				global::alphatab.rendering.glyphs.SvgGlyph.__hx_ctor_alphatab_rendering_glyphs_SvgGlyph(__temp_me248, new global::haxe.lang.Null<int>(__temp_x246, true), new global::haxe.lang.Null<int>(__temp_y247, true), __temp_me248.getNoteSvg(pickStroke), ((double) (1) ), ((double) (1) ));
			}
		}
		
		
		public static  new object __hx_createEmpty()
		{
			unchecked 
			{
				return new global::alphatab.rendering.glyphs.effects.PickStrokeGlyph(((global::haxe.lang.EmptyObject) (global::haxe.lang.EmptyObject.EMPTY) ));
			}
		}
		
		
		public static  new object __hx_create(global::haxe.root.Array arr)
		{
			unchecked 
			{
				return new global::alphatab.rendering.glyphs.effects.PickStrokeGlyph(global::haxe.lang.Null<object>.ofDynamic<int>(arr[0]), global::haxe.lang.Null<object>.ofDynamic<int>(arr[1]), ((global::alphatab.model.PickStrokeType) (arr[2]) ));
			}
		}
		
		
		public override   void doLayout()
		{
			unchecked 
			{
				this.width = ((int) (( 9 * this.renderer.stave.staveGroup.layout.renderer.settings.scale )) );
			}
		}
		
		
		public override   bool canScale()
		{
			unchecked 
			{
				return false;
			}
		}
		
		
		public virtual   global::alphatab.rendering.glyphs.LazySvg getNoteSvg(global::alphatab.model.PickStrokeType pickStroke)
		{
			unchecked 
			{
				switch (global::haxe.root.Type.enumIndex(pickStroke))
				{
					case 1:
					{
						return global::alphatab.rendering.glyphs.MusicFont.PickStrokeUp;
					}
					
					
					case 2:
					{
						return global::alphatab.rendering.glyphs.MusicFont.PickStrokeDown;
					}
					
					
					case 0:
					{
						return default(global::alphatab.rendering.glyphs.LazySvg);
					}
					
					
				}
				
				return default(global::alphatab.rendering.glyphs.LazySvg);
			}
		}
		
		
		public override   object __hx_getField(string field, int hash, bool throwErrors, bool isCheck, bool handleProperties)
		{
			unchecked 
			{
				switch (hash)
				{
					case 481612700:
					{
						return ((global::haxe.lang.Function) (new global::haxe.lang.Closure(((object) (this) ), global::haxe.lang.Runtime.toString("getNoteSvg"), ((int) (481612700) ))) );
					}
					
					
					case 1734479962:
					{
						return ((global::haxe.lang.Function) (new global::haxe.lang.Closure(((object) (this) ), global::haxe.lang.Runtime.toString("canScale"), ((int) (1734479962) ))) );
					}
					
					
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
		
		
		public override   object __hx_invokeField(string field, int hash, global::haxe.root.Array dynargs)
		{
			unchecked 
			{
				switch (hash)
				{
					case 1825584277:case 1734479962:
					{
						return global::haxe.lang.Runtime.slowCallField(this, field, dynargs);
					}
					
					
					case 481612700:
					{
						return this.getNoteSvg(((global::alphatab.model.PickStrokeType) (dynargs[0]) ));
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


