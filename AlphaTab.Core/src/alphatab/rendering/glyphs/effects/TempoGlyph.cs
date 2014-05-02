using haxe.root;
#pragma warning disable 109, 114, 219, 429, 168, 162
namespace alphatab.rendering.glyphs.effects{
	public  class TempoGlyph : global::alphatab.rendering.Glyph {
		public    TempoGlyph(global::haxe.lang.EmptyObject empty) : base(global::haxe.lang.EmptyObject.EMPTY){
			unchecked {
			}
		}
		
		
		public    TempoGlyph(global::haxe.lang.Null<int> x, global::haxe.lang.Null<int> y, int tempo) : base(global::haxe.lang.EmptyObject.EMPTY){
			unchecked {
				global::alphatab.rendering.glyphs.effects.TempoGlyph.__hx_ctor_alphatab_rendering_glyphs_effects_TempoGlyph(this, x, y, tempo);
			}
		}
		
		
		public static   void __hx_ctor_alphatab_rendering_glyphs_effects_TempoGlyph(global::alphatab.rendering.glyphs.effects.TempoGlyph __temp_me266, global::haxe.lang.Null<int> x, global::haxe.lang.Null<int> y, int tempo){
			unchecked {
				global::alphatab.rendering.Glyph.__hx_ctor_alphatab_rendering_Glyph(__temp_me266, ( ( ! (x.hasValue) ) ? (new global::haxe.lang.Null<int>(0, true)) : (x) ), ( ( ! (y.hasValue) ) ? (new global::haxe.lang.Null<int>(0, true)) : (y) ));
				int __temp_y265 = ( ( ! (y.hasValue) ) ? (((int) (0) )) : (y.@value) );
				int __temp_x264 = ( ( ! (x.hasValue) ) ? (((int) (0) )) : (x.@value) );
				__temp_me266._tempo = tempo;
			}
		}
		
		
		public static  new object __hx_createEmpty(){
			unchecked {
				return new global::alphatab.rendering.glyphs.effects.TempoGlyph(((global::haxe.lang.EmptyObject) (global::haxe.lang.EmptyObject.EMPTY) ));
			}
		}
		
		
		public static  new object __hx_create(global::haxe.root.Array arr){
			unchecked {
				return new global::alphatab.rendering.glyphs.effects.TempoGlyph(global::haxe.lang.Null<object>.ofDynamic<int>(arr[0]), global::haxe.lang.Null<object>.ofDynamic<int>(arr[1]), ((int) (global::haxe.lang.Runtime.toInt(arr[2])) ));
			}
		}
		
		
		public  int _tempo;
		
		public override   void paint(int cx, int cy, global::alphatab.platform.ICanvas canvas){
			unchecked {
				global::alphatab.rendering.RenderingResources res = this.renderer.stave.staveGroup.layout.renderer.renderingResources;
				canvas.setFont(res.markerFont);
				canvas.setColor(res.mainGlyphColor);
				global::alphatab.rendering.glyphs.SvgGlyph symbol = new global::alphatab.rendering.glyphs.SvgGlyph(new global::haxe.lang.Null<int>(0, true), new global::haxe.lang.Null<int>(0, true), ((global::alphatab.rendering.glyphs.LazySvg) (global::alphatab.rendering.glyphs.MusicFont.Tempo) ), ((double) (1) ), ((double) (1) ));
				symbol.renderer = this.renderer;
				symbol.paint(( cx + this.x ), ( cy + this.y ), canvas);
				canvas.fillText(global::haxe.lang.Runtime.concat("", global::haxe.lang.Runtime.toString(this._tempo)), ((double) (( ( cx + this.x ) + ((int) (( 30 * this.renderer.stave.staveGroup.layout.renderer.settings.scale )) ) )) ), ((double) (( ( cy + this.y ) + ((int) (( 7 * this.renderer.stave.staveGroup.layout.renderer.settings.scale )) ) )) ));
			}
		}
		
		
		public override   double __hx_setField_f(string field, int hash, double @value, bool handleProperties){
			unchecked {
				switch (hash){
					case 158873116:
					{
						this._tempo = ((int) (@value) );
						return @value;
					}
					
					
					default:
					{
						return base.__hx_setField_f(field, hash, @value, handleProperties);
					}
					
				}
				
			}
		}
		
		
		public override   object __hx_setField(string field, int hash, object @value, bool handleProperties){
			unchecked {
				switch (hash){
					case 158873116:
					{
						this._tempo = ((int) (global::haxe.lang.Runtime.toInt(@value)) );
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
					
					
					case 158873116:
					{
						return this._tempo;
					}
					
					
					default:
					{
						return base.__hx_getField(field, hash, throwErrors, isCheck, handleProperties);
					}
					
				}
				
			}
		}
		
		
		public override   double __hx_getField_f(string field, int hash, bool throwErrors, bool handleProperties){
			unchecked {
				switch (hash){
					case 158873116:
					{
						return ((double) (this._tempo) );
					}
					
					
					default:
					{
						return base.__hx_getField_f(field, hash, throwErrors, handleProperties);
					}
					
				}
				
			}
		}
		
		
		public override   void __hx_getFields(global::haxe.root.Array<object> baseArr){
			unchecked {
				baseArr.push("_tempo");
				{
					base.__hx_getFields(baseArr);
				}
				
			}
		}
		
		
	}
}


