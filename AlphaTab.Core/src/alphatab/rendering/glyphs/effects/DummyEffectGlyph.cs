using haxe.root;
#pragma warning disable 109, 114, 219, 429, 168, 162
namespace alphatab.rendering.glyphs.effects{
	public  class DummyEffectGlyph : global::alphatab.rendering.Glyph {
		public    DummyEffectGlyph(global::haxe.lang.EmptyObject empty) : base(global::haxe.lang.EmptyObject.EMPTY){
			unchecked {
			}
		}
		
		
		public    DummyEffectGlyph(global::haxe.lang.Null<int> x, global::haxe.lang.Null<int> y, string s) : base(global::haxe.lang.EmptyObject.EMPTY){
			unchecked {
				global::alphatab.rendering.glyphs.effects.DummyEffectGlyph.__hx_ctor_alphatab_rendering_glyphs_effects_DummyEffectGlyph(this, x, y, s);
			}
		}
		
		
		public static   void __hx_ctor_alphatab_rendering_glyphs_effects_DummyEffectGlyph(global::alphatab.rendering.glyphs.effects.DummyEffectGlyph __temp_me251, global::haxe.lang.Null<int> x, global::haxe.lang.Null<int> y, string s){
			unchecked {
				global::alphatab.rendering.Glyph.__hx_ctor_alphatab_rendering_Glyph(__temp_me251, ( ( ! (x.hasValue) ) ? (new global::haxe.lang.Null<int>(0, true)) : (x) ), ( ( ! (y.hasValue) ) ? (new global::haxe.lang.Null<int>(0, true)) : (y) ));
				int __temp_y250 = ( ( ! (y.hasValue) ) ? (((int) (0) )) : (y.@value) );
				int __temp_x249 = ( ( ! (x.hasValue) ) ? (((int) (0) )) : (x.@value) );
				__temp_me251._s = s;
			}
		}
		
		
		public static  new object __hx_createEmpty(){
			unchecked {
				return new global::alphatab.rendering.glyphs.effects.DummyEffectGlyph(((global::haxe.lang.EmptyObject) (global::haxe.lang.EmptyObject.EMPTY) ));
			}
		}
		
		
		public static  new object __hx_create(global::haxe.root.Array arr){
			unchecked {
				return new global::alphatab.rendering.glyphs.effects.DummyEffectGlyph(global::haxe.lang.Null<object>.ofDynamic<int>(arr[0]), global::haxe.lang.Null<object>.ofDynamic<int>(arr[1]), global::haxe.lang.Runtime.toString(arr[2]));
			}
		}
		
		
		public  string _s;
		
		public override   void doLayout(){
			unchecked {
				this.width = ((int) (( 20 * this.renderer.stave.staveGroup.layout.renderer.settings.scale )) );
			}
		}
		
		
		public override   bool canScale(){
			unchecked {
				return false;
			}
		}
		
		
		public override   void paint(int cx, int cy, global::alphatab.platform.ICanvas canvas){
			unchecked {
				global::alphatab.rendering.RenderingResources res = this.renderer.stave.staveGroup.layout.renderer.renderingResources;
				canvas.setColor(res.mainGlyphColor);
				canvas.strokeRect(((double) (( cx + this.x )) ), ((double) (( cy + this.y )) ), ((double) (this.width) ), ( 20 * this.renderer.stave.staveGroup.layout.renderer.settings.scale ));
				canvas.setFont(res.tablatureFont);
				canvas.fillText(this._s, ((double) (( cx + this.x )) ), ((double) (( cy + this.y )) ));
			}
		}
		
		
		public override   object __hx_setField(string field, int hash, object @value, bool handleProperties){
			unchecked {
				switch (hash){
					case 21300:
					{
						this._s = global::haxe.lang.Runtime.toString(@value);
						return @value;
					}
					
					
					default:
					{
						return base.__hx_setField(field, hash, @value, handleProperties);
					}
					
				}
				
			}
		}
		
		
		public override   object __hx_getField(string field, int hash, bool throwErrors, bool isCheck, bool handleProperties){
			unchecked {
				switch (hash){
					case 1028568990:
					{
						return ((global::haxe.lang.Function) (new global::haxe.lang.Closure(((object) (this) ), ((string) ("paint") ), ((int) (1028568990) ))) );
					}
					
					
					case 1734479962:
					{
						return ((global::haxe.lang.Function) (new global::haxe.lang.Closure(((object) (this) ), ((string) ("canScale") ), ((int) (1734479962) ))) );
					}
					
					
					case 1825584277:
					{
						return ((global::haxe.lang.Function) (new global::haxe.lang.Closure(((object) (this) ), ((string) ("doLayout") ), ((int) (1825584277) ))) );
					}
					
					
					case 21300:
					{
						return this._s;
					}
					
					
					default:
					{
						return base.__hx_getField(field, hash, throwErrors, isCheck, handleProperties);
					}
					
				}
				
			}
		}
		
		
		public override   void __hx_getFields(global::haxe.root.Array<object> baseArr){
			unchecked {
				baseArr.push("_s");
				{
					base.__hx_getFields(baseArr);
				}
				
			}
		}
		
		
	}
}


