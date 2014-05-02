using haxe.root;
#pragma warning disable 109, 114, 219, 429, 168, 162
namespace alphatab.rendering.glyphs{
	public  class DrumSticksGlyph : global::alphatab.rendering.glyphs.SvgGlyph {
		static DrumSticksGlyph() {
			global::alphatab.rendering.glyphs.DrumSticksGlyph.graceScale = 0.7;
			global::alphatab.rendering.glyphs.DrumSticksGlyph.noteHeadHeight = 9;
		}
		public    DrumSticksGlyph(global::haxe.lang.EmptyObject empty) : base(global::haxe.lang.EmptyObject.EMPTY){
			unchecked {
			}
		}
		
		
		public    DrumSticksGlyph(global::haxe.lang.Null<int> x, global::haxe.lang.Null<int> y, bool isGrace) : base(global::haxe.lang.EmptyObject.EMPTY){
			unchecked {
				global::alphatab.rendering.glyphs.DrumSticksGlyph.__hx_ctor_alphatab_rendering_glyphs_DrumSticksGlyph(this, x, y, isGrace);
			}
		}
		
		
		public static   void __hx_ctor_alphatab_rendering_glyphs_DrumSticksGlyph(global::alphatab.rendering.glyphs.DrumSticksGlyph __temp_me168, global::haxe.lang.Null<int> x, global::haxe.lang.Null<int> y, bool isGrace){
			unchecked {
				global::alphatab.rendering.glyphs.SvgGlyph.__hx_ctor_alphatab_rendering_glyphs_SvgGlyph(__temp_me168, ( ( ! (x.hasValue) ) ? (new global::haxe.lang.Null<int>(0, true)) : (x) ), ( ( ! (y.hasValue) ) ? (new global::haxe.lang.Null<int>(0, true)) : (y) ), global::alphatab.rendering.glyphs.MusicFont.NoteSideStick, ( (isGrace) ? (0.7) : (((double) (1) )) ), ( (isGrace) ? (0.7) : (((double) (1) )) ));
				int __temp_y167 = ( ( ! (y.hasValue) ) ? (((int) (0) )) : (y.@value) );
				int __temp_x166 = ( ( ! (x.hasValue) ) ? (((int) (0) )) : (x.@value) );
				__temp_me168._isGrace = isGrace;
			}
		}
		
		
		public static  double graceScale;
		
		public static  int noteHeadHeight;
		
		public static  new object __hx_createEmpty(){
			unchecked {
				return new global::alphatab.rendering.glyphs.DrumSticksGlyph(((global::haxe.lang.EmptyObject) (global::haxe.lang.EmptyObject.EMPTY) ));
			}
		}
		
		
		public static  new object __hx_create(global::haxe.root.Array arr){
			unchecked {
				return new global::alphatab.rendering.glyphs.DrumSticksGlyph(global::haxe.lang.Null<object>.ofDynamic<int>(arr[0]), global::haxe.lang.Null<object>.ofDynamic<int>(arr[1]), global::haxe.lang.Runtime.toBool(arr[2]));
			}
		}
		
		
		public  bool _isGrace;
		
		public override   void doLayout(){
			unchecked {
				this.width = ((int) (( ( 9 * (( (this._isGrace) ? (0.7) : (((double) (1) )) )) ) * this.renderer.stave.staveGroup.layout.renderer.settings.scale )) );
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


