using haxe.root;
#pragma warning disable 109, 114, 219, 429, 168, 162
namespace alphatab.rendering.glyphs{
	public  class NaturalizeGlyph : global::alphatab.rendering.glyphs.SvgGlyph {
		public    NaturalizeGlyph(global::haxe.lang.EmptyObject empty) : base(global::haxe.lang.EmptyObject.EMPTY){
			unchecked {
			}
		}
		
		
		public    NaturalizeGlyph(global::haxe.lang.Null<int> x, global::haxe.lang.Null<int> y, global::haxe.lang.Null<bool> isGrace) : base(global::haxe.lang.EmptyObject.EMPTY){
			unchecked {
				global::alphatab.rendering.glyphs.NaturalizeGlyph.__hx_ctor_alphatab_rendering_glyphs_NaturalizeGlyph(this, x, y, isGrace);
			}
		}
		
		
		public static   void __hx_ctor_alphatab_rendering_glyphs_NaturalizeGlyph(global::alphatab.rendering.glyphs.NaturalizeGlyph __temp_me182, global::haxe.lang.Null<int> x, global::haxe.lang.Null<int> y, global::haxe.lang.Null<bool> isGrace){
			unchecked {
				global::alphatab.rendering.glyphs.SvgGlyph.__hx_ctor_alphatab_rendering_glyphs_SvgGlyph(__temp_me182, ( ( ! (x.hasValue) ) ? (new global::haxe.lang.Null<int>(0, true)) : (x) ), ( ( ! (y.hasValue) ) ? (new global::haxe.lang.Null<int>(0, true)) : (y) ), global::alphatab.rendering.glyphs.MusicFont.AccidentalNatural, ( (( ( ! (isGrace.hasValue) ) ? (new global::haxe.lang.Null<bool>(false, true)) : (isGrace) )) ? (0.7) : (((double) (1) )) ), ( (( ( ! (isGrace.hasValue) ) ? (new global::haxe.lang.Null<bool>(false, true)) : (isGrace) )) ? (0.7) : (((double) (1) )) ));
				bool __temp_isGrace181 = ( ( ! (isGrace.hasValue) ) ? (global::haxe.lang.Runtime.toBool(false)) : (isGrace.@value) );
				int __temp_y180 = ( ( ! (y.hasValue) ) ? (((int) (0) )) : (y.@value) );
				int __temp_x179 = ( ( ! (x.hasValue) ) ? (((int) (0) )) : (x.@value) );
				__temp_me182._isGrace = __temp_isGrace181;
			}
		}
		
		
		public static  new object __hx_createEmpty(){
			unchecked {
				return new global::alphatab.rendering.glyphs.NaturalizeGlyph(((global::haxe.lang.EmptyObject) (global::haxe.lang.EmptyObject.EMPTY) ));
			}
		}
		
		
		public static  new object __hx_create(global::haxe.root.Array arr){
			unchecked {
				return new global::alphatab.rendering.glyphs.NaturalizeGlyph(global::haxe.lang.Null<object>.ofDynamic<int>(arr[0]), global::haxe.lang.Null<object>.ofDynamic<int>(arr[1]), global::haxe.lang.Null<object>.ofDynamic<bool>(arr[2]));
			}
		}
		
		
		public  bool _isGrace;
		
		public override   void doLayout(){
			unchecked {
				this.width = ((int) (( ( 8 * (( (this._isGrace) ? (0.7) : (((double) (1) )) )) ) * this.renderer.stave.staveGroup.layout.renderer.settings.scale )) );
			}
		}
		
		
		public override   bool canScale(){
			unchecked {
				return false;
			}
		}
		
		
		public override   object __hx_setField(string field, int hash, object @value, bool handleProperties){
			unchecked {
				switch (hash){
					case 1881669935:
					{
						this._isGrace = global::haxe.lang.Runtime.toBool(@value);
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
					case 1734479962:
					{
						return ((global::haxe.lang.Function) (new global::haxe.lang.Closure(((object) (this) ), ((string) ("canScale") ), ((int) (1734479962) ))) );
					}
					
					
					case 1825584277:
					{
						return ((global::haxe.lang.Function) (new global::haxe.lang.Closure(((object) (this) ), ((string) ("doLayout") ), ((int) (1825584277) ))) );
					}
					
					
					case 1881669935:
					{
						return this._isGrace;
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
				baseArr.push("_isGrace");
				{
					base.__hx_getFields(baseArr);
				}
				
			}
		}
		
		
	}
}


