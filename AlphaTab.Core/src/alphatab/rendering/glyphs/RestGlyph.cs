using haxe.root;
#pragma warning disable 109, 114, 219, 429, 168, 162
namespace alphatab.rendering.glyphs{
	public  class RestGlyph : global::alphatab.rendering.glyphs.SvgGlyph {
		public    RestGlyph(global::haxe.lang.EmptyObject empty) : base(global::haxe.lang.EmptyObject.EMPTY){
			unchecked {
			}
		}
		
		
		public    RestGlyph(global::haxe.lang.Null<int> x, global::haxe.lang.Null<int> y, global::alphatab.model.Duration duration) : base(global::haxe.lang.EmptyObject.EMPTY){
			unchecked {
				global::alphatab.rendering.glyphs.RestGlyph.__hx_ctor_alphatab_rendering_glyphs_RestGlyph(this, x, y, duration);
			}
		}
		
		
		public static   void __hx_ctor_alphatab_rendering_glyphs_RestGlyph(global::alphatab.rendering.glyphs.RestGlyph __temp_me201, global::haxe.lang.Null<int> x, global::haxe.lang.Null<int> y, global::alphatab.model.Duration duration){
			unchecked {
				global::alphatab.rendering.glyphs.SvgGlyph.__hx_ctor_alphatab_rendering_glyphs_SvgGlyph(__temp_me201, ( ( ! (x.hasValue) ) ? (new global::haxe.lang.Null<int>(0, true)) : (x) ), ( ( ! (y.hasValue) ) ? (new global::haxe.lang.Null<int>(0, true)) : (y) ), __temp_me201.getRestSvg(duration), ((double) (1) ), ((double) (1) ));
				int __temp_y200 = ( ( ! (y.hasValue) ) ? (((int) (0) )) : (y.@value) );
				int __temp_x199 = ( ( ! (x.hasValue) ) ? (((int) (0) )) : (x.@value) );
				__temp_me201._duration = duration;
			}
		}
		
		
		public static  new object __hx_createEmpty(){
			unchecked {
				return new global::alphatab.rendering.glyphs.RestGlyph(((global::haxe.lang.EmptyObject) (global::haxe.lang.EmptyObject.EMPTY) ));
			}
		}
		
		
		public static  new object __hx_create(global::haxe.root.Array arr){
			unchecked {
				return new global::alphatab.rendering.glyphs.RestGlyph(global::haxe.lang.Null<object>.ofDynamic<int>(arr[0]), global::haxe.lang.Null<object>.ofDynamic<int>(arr[1]), ((global::alphatab.model.Duration) (arr[2]) ));
			}
		}
		
		
		public  global::alphatab.model.Duration _duration;
		
		public override   void doLayout(){
			unchecked {
				global::alphatab.model.Duration _g = this._duration;
				switch (global::haxe.root.Type.enumIndex(_g)){
					case 0:case 1:case 2:case 3:case 4:
					{
						this.width = ((int) (( 9 * this.renderer.stave.staveGroup.layout.renderer.settings.scale )) );
						break;
					}
					
					
					case 5:
					{
						this.width = ((int) (( 12 * this.renderer.stave.staveGroup.layout.renderer.settings.scale )) );
						break;
					}
					
					
					case 6:
					{
						this.width = ((int) (( 14 * this.renderer.stave.staveGroup.layout.renderer.settings.scale )) );
						break;
					}
					
					
				}
				
			}
		}
		
		
		public override   bool canScale(){
			unchecked {
				return false;
			}
		}
		
		
		public virtual   global::alphatab.rendering.glyphs.LazySvg getRestSvg(global::alphatab.model.Duration duration){
			unchecked {
				switch (global::haxe.root.Type.enumIndex(duration)){
					case 0:case 1:
					{
						return global::alphatab.rendering.glyphs.MusicFont.RestWhole;
					}
					
					
					case 2:
					{
						return global::alphatab.rendering.glyphs.MusicFont.RestQuarter;
					}
					
					
					case 3:
					{
						return global::alphatab.rendering.glyphs.MusicFont.RestEighth;
					}
					
					
					case 4:
					{
						return global::alphatab.rendering.glyphs.MusicFont.RestSixteenth;
					}
					
					
					case 5:
					{
						return global::alphatab.rendering.glyphs.MusicFont.RestThirtySecond;
					}
					
					
					case 6:
					{
						return global::alphatab.rendering.glyphs.MusicFont.RestSixtyFourth;
					}
					
					
				}
				
				return default(global::alphatab.rendering.glyphs.LazySvg);
			}
		}
		
		
		public override   object __hx_setField(string field, int hash, object @value, bool handleProperties){
			unchecked {
				switch (hash){
					case 1545864883:
					{
						this._duration = ((global::alphatab.model.Duration) (@value) );
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
					case 972861882:
					{
						return ((global::haxe.lang.Function) (new global::haxe.lang.Closure(((object) (this) ), ((string) ("getRestSvg") ), ((int) (972861882) ))) );
					}
					
					
					case 1734479962:
					{
						return ((global::haxe.lang.Function) (new global::haxe.lang.Closure(((object) (this) ), ((string) ("canScale") ), ((int) (1734479962) ))) );
					}
					
					
					case 1825584277:
					{
						return ((global::haxe.lang.Function) (new global::haxe.lang.Closure(((object) (this) ), ((string) ("doLayout") ), ((int) (1825584277) ))) );
					}
					
					
					case 1545864883:
					{
						return this._duration;
					}
					
					
					default:
					{
						return base.__hx_getField(field, hash, throwErrors, isCheck, handleProperties);
					}
					
				}
				
			}
		}
		
		
		public override   object __hx_invokeField(string field, int hash, global::haxe.root.Array dynargs){
			unchecked {
				switch (hash){
					case 1825584277:case 1734479962:
					{
						return global::haxe.lang.Runtime.slowCallField(this, field, dynargs);
					}
					
					
					case 972861882:
					{
						return this.getRestSvg(((global::alphatab.model.Duration) (dynargs[0]) ));
					}
					
					
					default:
					{
						return base.__hx_invokeField(field, hash, dynargs);
					}
					
				}
				
			}
		}
		
		
		public override   void __hx_getFields(global::haxe.root.Array<object> baseArr){
			unchecked {
				baseArr.push("_duration");
				{
					base.__hx_getFields(baseArr);
				}
				
			}
		}
		
		
	}
}


