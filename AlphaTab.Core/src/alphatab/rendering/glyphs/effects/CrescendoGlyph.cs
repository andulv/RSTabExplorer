using haxe.root;
#pragma warning disable 109, 114, 219, 429, 168, 162
namespace alphatab.rendering.glyphs.effects
{
	public  class CrescendoGlyph : global::alphatab.rendering.Glyph 
	{
		static CrescendoGlyph() 
		{
			global::alphatab.rendering.glyphs.effects.CrescendoGlyph.Height = 17;
		}
		public    CrescendoGlyph(global::haxe.lang.EmptyObject empty) : base(global::haxe.lang.EmptyObject.EMPTY)
		{
			unchecked 
			{
			}
		}
		
		
		public    CrescendoGlyph(global::haxe.lang.Null<int> x, global::haxe.lang.Null<int> y, global::alphatab.rendering.glyphs.CrescendoType crescendo) : base(global::haxe.lang.EmptyObject.EMPTY)
		{
			unchecked 
			{
				global::alphatab.rendering.glyphs.effects.CrescendoGlyph.__hx_ctor_alphatab_rendering_glyphs_effects_CrescendoGlyph(this, x, y, crescendo);
			}
		}
		
		
		public static   void __hx_ctor_alphatab_rendering_glyphs_effects_CrescendoGlyph(global::alphatab.rendering.glyphs.effects.CrescendoGlyph __temp_me233, global::haxe.lang.Null<int> x, global::haxe.lang.Null<int> y, global::alphatab.rendering.glyphs.CrescendoType crescendo)
		{
			unchecked 
			{
				int __temp_y232 = ( (global::haxe.lang.Runtime.eq((y).toDynamic(), (default(global::haxe.lang.Null<int>)).toDynamic())) ? (((int) (0) )) : (y.@value) );
				int __temp_x231 = ( (global::haxe.lang.Runtime.eq((x).toDynamic(), (default(global::haxe.lang.Null<int>)).toDynamic())) ? (((int) (0) )) : (x.@value) );
				global::alphatab.rendering.Glyph.__hx_ctor_alphatab_rendering_Glyph(__temp_me233, new global::haxe.lang.Null<int>(__temp_x231, true), new global::haxe.lang.Null<int>(__temp_y232, true));
				__temp_me233._crescendo = crescendo;
			}
		}
		
		
		public static  int Height;
		
		public static  new object __hx_createEmpty()
		{
			unchecked 
			{
				return new global::alphatab.rendering.glyphs.effects.CrescendoGlyph(((global::haxe.lang.EmptyObject) (global::haxe.lang.EmptyObject.EMPTY) ));
			}
		}
		
		
		public static  new object __hx_create(global::haxe.root.Array arr)
		{
			unchecked 
			{
				return new global::alphatab.rendering.glyphs.effects.CrescendoGlyph(global::haxe.lang.Null<object>.ofDynamic<int>(arr[0]), global::haxe.lang.Null<object>.ofDynamic<int>(arr[1]), ((global::alphatab.rendering.glyphs.CrescendoType) (arr[2]) ));
			}
		}
		
		
		public  global::alphatab.rendering.glyphs.CrescendoType _crescendo;
		
		public override   void paint(int cx, int cy, global::alphatab.platform.ICanvas canvas)
		{
			unchecked 
			{
				double height = ( 17 * this.renderer.stave.staveGroup.layout.renderer.settings.scale );
				global::alphatab.rendering.RenderingResources res = this.renderer.stave.staveGroup.layout.renderer.renderingResources;
				canvas.setColor(res.mainGlyphColor);
				canvas.beginPath();
				if (( this._crescendo == global::alphatab.rendering.glyphs.CrescendoType.Crescendo )) 
				{
					canvas.moveTo(((double) (( ( cx + this.x ) + this.width )) ), ((double) (( cy + this.y )) ));
					canvas.lineTo(((double) (( cx + this.x )) ), ((double) (( ( cy + this.y ) + ((int) (( height / 2 )) ) )) ));
					canvas.lineTo(((double) (( ( cx + this.x ) + this.width )) ), ( ( cy + this.y ) + height ));
				}
				 else 
				{
					canvas.moveTo(((double) (( cx + this.x )) ), ((double) (( cy + this.y )) ));
					canvas.lineTo(((double) (( ( cx + this.x ) + this.width )) ), ((double) (( ( cy + this.y ) + ((int) (( height / 2 )) ) )) ));
					canvas.lineTo(((double) (( cx + this.x )) ), ( ( cy + this.y ) + height ));
				}
				
				canvas.stroke();
			}
		}
		
		
		public override   object __hx_setField(string field, int hash, object @value, bool handleProperties)
		{
			unchecked 
			{
				switch (hash)
				{
					case 238619611:
					{
						this._crescendo = ((global::alphatab.rendering.glyphs.CrescendoType) (@value) );
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
					
					
					case 238619611:
					{
						return this._crescendo;
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
				baseArr.push("_crescendo");
				{
					base.__hx_getFields(baseArr);
				}
				
			}
		}
		
		
	}
}


