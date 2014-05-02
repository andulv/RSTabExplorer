using haxe.root;
#pragma warning disable 109, 114, 219, 429, 168, 162
namespace alphatab.rendering.glyphs{
	public  class BeamGlyph : global::alphatab.rendering.glyphs.SvgGlyph {
		public    BeamGlyph(global::haxe.lang.EmptyObject empty) : base(global::haxe.lang.EmptyObject.EMPTY){
			unchecked {
			}
		}
		
		
		public    BeamGlyph(global::haxe.lang.Null<int> x, global::haxe.lang.Null<int> y, global::alphatab.model.Duration duration, global::alphatab.rendering.utils.BeamDirection direction, bool isGrace) : base(global::haxe.lang.EmptyObject.EMPTY){
			unchecked {
				global::alphatab.rendering.glyphs.BeamGlyph.__hx_ctor_alphatab_rendering_glyphs_BeamGlyph(this, x, y, duration, direction, isGrace);
			}
		}
		
		
		public static   void __hx_ctor_alphatab_rendering_glyphs_BeamGlyph(global::alphatab.rendering.glyphs.BeamGlyph __temp_me144, global::haxe.lang.Null<int> x, global::haxe.lang.Null<int> y, global::alphatab.model.Duration duration, global::alphatab.rendering.utils.BeamDirection direction, bool isGrace){
			unchecked {
				global::alphatab.rendering.glyphs.SvgGlyph.__hx_ctor_alphatab_rendering_glyphs_SvgGlyph(__temp_me144, ( ( ! (x.hasValue) ) ? (new global::haxe.lang.Null<int>(0, true)) : (x) ), ( ( ! (y.hasValue) ) ? (new global::haxe.lang.Null<int>(0, true)) : (y) ), __temp_me144.getRestSvg(duration, direction, isGrace), ( (isGrace) ? (0.7) : (((double) (1) )) ), __temp_me144.getSvgScale(duration, direction, isGrace));
				int __temp_y143 = ( ( ! (y.hasValue) ) ? (((int) (0) )) : (y.@value) );
				int __temp_x142 = ( ( ! (x.hasValue) ) ? (((int) (0) )) : (x.@value) );
			}
		}
		
		
		public static  new object __hx_createEmpty(){
			unchecked {
				return new global::alphatab.rendering.glyphs.BeamGlyph(((global::haxe.lang.EmptyObject) (global::haxe.lang.EmptyObject.EMPTY) ));
			}
		}
		
		
		public static  new object __hx_create(global::haxe.root.Array arr){
			unchecked {
				return new global::alphatab.rendering.glyphs.BeamGlyph(global::haxe.lang.Null<object>.ofDynamic<int>(arr[0]), global::haxe.lang.Null<object>.ofDynamic<int>(arr[1]), ((global::alphatab.model.Duration) (arr[2]) ), ((global::alphatab.rendering.utils.BeamDirection) (arr[3]) ), global::haxe.lang.Runtime.toBool(arr[4]));
			}
		}
		
		
		public virtual   double getSvgScale(global::alphatab.model.Duration duration, global::alphatab.rendering.utils.BeamDirection direction, bool isGrace){
			unchecked {
				double scale = default(double);
				if (isGrace) {
					scale = 0.7;
				}
				 else {
					scale = ((double) (1) );
				}
				
				if (( direction == global::alphatab.rendering.utils.BeamDirection.Up )) {
					return scale;
				}
				 else {
					return ( -1 * scale );
				}
				
			}
		}
		
		
		public override   void doLayout(){
			unchecked {
				this.width = 0;
			}
		}
		
		
		public virtual   global::alphatab.rendering.glyphs.LazySvg getRestSvg(global::alphatab.model.Duration duration, global::alphatab.rendering.utils.BeamDirection direction, bool isGrace){
			unchecked {
				if (isGrace) {
					return global::alphatab.rendering.glyphs.MusicFont.FooterUpEighth;
				}
				
				switch (global::haxe.root.Type.enumIndex(duration)){
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
		
		
		public override   object __hx_getField(string field, int hash, bool throwErrors, bool isCheck, bool handleProperties){
			unchecked {
				switch (hash){
					case 972861882:
					{
						return ((global::haxe.lang.Function) (new global::haxe.lang.Closure(((object) (this) ), ((string) ("getRestSvg") ), ((int) (972861882) ))) );
					}
					
					
					case 1825584277:
					{
						return ((global::haxe.lang.Function) (new global::haxe.lang.Closure(((object) (this) ), ((string) ("doLayout") ), ((int) (1825584277) ))) );
					}
					
					
					case 1027615804:
					{
						return ((global::haxe.lang.Function) (new global::haxe.lang.Closure(((object) (this) ), ((string) ("getSvgScale") ), ((int) (1027615804) ))) );
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
					case 1825584277:
					{
						return global::haxe.lang.Runtime.slowCallField(this, field, dynargs);
					}
					
					
					case 972861882:
					{
						return this.getRestSvg(((global::alphatab.model.Duration) (dynargs[0]) ), ((global::alphatab.rendering.utils.BeamDirection) (dynargs[1]) ), global::haxe.lang.Runtime.toBool(dynargs[2]));
					}
					
					
					case 1027615804:
					{
						return this.getSvgScale(((global::alphatab.model.Duration) (dynargs[0]) ), ((global::alphatab.rendering.utils.BeamDirection) (dynargs[1]) ), global::haxe.lang.Runtime.toBool(dynargs[2]));
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


