using haxe.root;
#pragma warning disable 109, 114, 219, 429, 168, 162
namespace alphatab.rendering.glyphs.effects
{
	public  class TextGlyph : global::alphatab.rendering.Glyph 
	{
		public    TextGlyph(global::haxe.lang.EmptyObject empty) : base(global::haxe.lang.EmptyObject.EMPTY)
		{
			unchecked 
			{
			}
		}
		
		
		public    TextGlyph(global::haxe.lang.Null<int> x, global::haxe.lang.Null<int> y, string text, global::alphatab.platform.model.Font font) : base(global::haxe.lang.EmptyObject.EMPTY)
		{
			unchecked 
			{
				global::alphatab.rendering.glyphs.effects.TextGlyph.__hx_ctor_alphatab_rendering_glyphs_effects_TextGlyph(this, x, y, text, font);
			}
		}
		
		
		public static   void __hx_ctor_alphatab_rendering_glyphs_effects_TextGlyph(global::alphatab.rendering.glyphs.effects.TextGlyph __temp_me254, global::haxe.lang.Null<int> x, global::haxe.lang.Null<int> y, string text, global::alphatab.platform.model.Font font)
		{
			unchecked 
			{
				int __temp_y253 = ( (global::haxe.lang.Runtime.eq((y).toDynamic(), (default(global::haxe.lang.Null<int>)).toDynamic())) ? (((int) (0) )) : (y.@value) );
				int __temp_x252 = ( (global::haxe.lang.Runtime.eq((x).toDynamic(), (default(global::haxe.lang.Null<int>)).toDynamic())) ? (((int) (0) )) : (x.@value) );
				global::alphatab.rendering.Glyph.__hx_ctor_alphatab_rendering_Glyph(__temp_me254, new global::haxe.lang.Null<int>(__temp_x252, true), new global::haxe.lang.Null<int>(__temp_y253, true));
				__temp_me254._text = text;
				__temp_me254._font = font;
			}
		}
		
		
		public static  new object __hx_createEmpty()
		{
			unchecked 
			{
				return new global::alphatab.rendering.glyphs.effects.TextGlyph(((global::haxe.lang.EmptyObject) (global::haxe.lang.EmptyObject.EMPTY) ));
			}
		}
		
		
		public static  new object __hx_create(global::haxe.root.Array arr)
		{
			unchecked 
			{
				return new global::alphatab.rendering.glyphs.effects.TextGlyph(global::haxe.lang.Null<object>.ofDynamic<int>(arr[0]), global::haxe.lang.Null<object>.ofDynamic<int>(arr[1]), global::haxe.lang.Runtime.toString(arr[2]), ((global::alphatab.platform.model.Font) (arr[3]) ));
			}
		}
		
		
		public  string _text;
		
		public  global::alphatab.platform.model.Font _font;
		
		public override   void paint(int cx, int cy, global::alphatab.platform.ICanvas canvas)
		{
			unchecked 
			{
				global::alphatab.rendering.RenderingResources res = this.renderer.stave.staveGroup.layout.renderer.renderingResources;
				canvas.setFont(this._font);
				canvas.setColor(res.mainGlyphColor);
				canvas.fillText(this._text, ((double) (( cx + this.x )) ), ((double) (( cy + this.y )) ));
			}
		}
		
		
		public override   object __hx_setField(string field, int hash, object @value, bool handleProperties)
		{
			unchecked 
			{
				switch (hash)
				{
					case 1993439662:
					{
						this._font = ((global::alphatab.platform.model.Font) (@value) );
						return @value;
					}
					
					
					case 714892:
					{
						this._text = global::haxe.lang.Runtime.toString(@value);
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
					
					
					case 1993439662:
					{
						return this._font;
					}
					
					
					case 714892:
					{
						return this._text;
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
				baseArr.push("_font");
				baseArr.push("_text");
				{
					base.__hx_getFields(baseArr);
				}
				
			}
		}
		
		
	}
}


