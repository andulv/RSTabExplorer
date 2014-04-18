using haxe.root;
#pragma warning disable 109, 114, 219, 429, 168, 162
namespace alphatab.rendering.glyphs
{
	public  class SpacingGlyph : global::alphatab.rendering.Glyph 
	{
		public    SpacingGlyph(global::haxe.lang.EmptyObject empty) : base(global::haxe.lang.EmptyObject.EMPTY)
		{
			unchecked 
			{
			}
		}
		
		
		public    SpacingGlyph(global::haxe.lang.Null<int> x, global::haxe.lang.Null<int> y, int width, global::haxe.lang.Null<bool> scaling) : base(global::haxe.lang.EmptyObject.EMPTY)
		{
			unchecked 
			{
				global::alphatab.rendering.glyphs.SpacingGlyph.__hx_ctor_alphatab_rendering_glyphs_SpacingGlyph(this, x, y, width, scaling);
			}
		}
		
		
		public static   void __hx_ctor_alphatab_rendering_glyphs_SpacingGlyph(global::alphatab.rendering.glyphs.SpacingGlyph __temp_me210, global::haxe.lang.Null<int> x, global::haxe.lang.Null<int> y, int width, global::haxe.lang.Null<bool> scaling)
		{
			unchecked 
			{
				bool __temp_scaling209 = ( (global::haxe.lang.Runtime.eq((scaling).toDynamic(), (default(global::haxe.lang.Null<bool>)).toDynamic())) ? (((bool) (true) )) : (scaling.@value) );
				int __temp_y208 = ( (global::haxe.lang.Runtime.eq((y).toDynamic(), (default(global::haxe.lang.Null<int>)).toDynamic())) ? (((int) (0) )) : (y.@value) );
				int __temp_x207 = ( (global::haxe.lang.Runtime.eq((x).toDynamic(), (default(global::haxe.lang.Null<int>)).toDynamic())) ? (((int) (0) )) : (x.@value) );
				global::alphatab.rendering.Glyph.__hx_ctor_alphatab_rendering_Glyph(__temp_me210, new global::haxe.lang.Null<int>(__temp_x207, true), new global::haxe.lang.Null<int>(__temp_y208, true));
				__temp_me210.width = width;
				__temp_me210._scaling = __temp_scaling209;
			}
		}
		
		
		public static  new object __hx_createEmpty()
		{
			unchecked 
			{
				return new global::alphatab.rendering.glyphs.SpacingGlyph(((global::haxe.lang.EmptyObject) (global::haxe.lang.EmptyObject.EMPTY) ));
			}
		}
		
		
		public static  new object __hx_create(global::haxe.root.Array arr)
		{
			unchecked 
			{
				return new global::alphatab.rendering.glyphs.SpacingGlyph(global::haxe.lang.Null<object>.ofDynamic<int>(arr[0]), global::haxe.lang.Null<object>.ofDynamic<int>(arr[1]), ((int) (global::haxe.lang.Runtime.toInt(arr[2])) ), global::haxe.lang.Null<object>.ofDynamic<bool>(arr[3]));
			}
		}
		
		
		public  bool _scaling;
		
		public override   bool canScale()
		{
			unchecked 
			{
				return this._scaling;
			}
		}
		
		
		public override   object __hx_setField(string field, int hash, object @value, bool handleProperties)
		{
			unchecked 
			{
				switch (hash)
				{
					case 516081608:
					{
						this._scaling = ((bool) (@value) );
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
					case 1734479962:
					{
						return ((global::haxe.lang.Function) (new global::haxe.lang.Closure(((object) (this) ), global::haxe.lang.Runtime.toString("canScale"), ((int) (1734479962) ))) );
					}
					
					
					case 516081608:
					{
						return this._scaling;
					}
					
					
					default:
					{
						return base.__hx_getField(field, hash, throwErrors, isCheck, handleProperties);
					}
					
				}
				
			}
		}
		
		
		public override   void __hx_getFields(global::haxe.root.Array<object> baseArr)
		{
			unchecked 
			{
				baseArr.push("_scaling");
				{
					base.__hx_getFields(baseArr);
				}
				
			}
		}
		
		
	}
}


