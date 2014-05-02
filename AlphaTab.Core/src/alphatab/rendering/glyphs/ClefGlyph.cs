using haxe.root;
#pragma warning disable 109, 114, 219, 429, 168, 162
namespace alphatab.rendering.glyphs{
	public  class ClefGlyph : global::alphatab.rendering.glyphs.SvgGlyph {
		public    ClefGlyph(global::haxe.lang.EmptyObject empty) : base(global::haxe.lang.EmptyObject.EMPTY){
			unchecked {
			}
		}
		
		
		public    ClefGlyph(global::haxe.lang.Null<int> x, global::haxe.lang.Null<int> y, global::alphatab.model.Clef clef) : base(global::haxe.lang.EmptyObject.EMPTY){
			unchecked {
				global::alphatab.rendering.glyphs.ClefGlyph.__hx_ctor_alphatab_rendering_glyphs_ClefGlyph(this, x, y, clef);
			}
		}
		
		
		public static   void __hx_ctor_alphatab_rendering_glyphs_ClefGlyph(global::alphatab.rendering.glyphs.ClefGlyph __temp_me156, global::haxe.lang.Null<int> x, global::haxe.lang.Null<int> y, global::alphatab.model.Clef clef){
			unchecked {
				global::alphatab.rendering.glyphs.SvgGlyph.__hx_ctor_alphatab_rendering_glyphs_SvgGlyph(__temp_me156, ( ( ! (x.hasValue) ) ? (new global::haxe.lang.Null<int>(0, true)) : (x) ), ( ( ! (y.hasValue) ) ? (new global::haxe.lang.Null<int>(0, true)) : (y) ), __temp_me156.getClefSvg(clef), ((double) (1) ), ((double) (1) ));
				int __temp_y155 = ( ( ! (y.hasValue) ) ? (((int) (0) )) : (y.@value) );
				int __temp_x154 = ( ( ! (x.hasValue) ) ? (((int) (0) )) : (x.@value) );
			}
		}
		
		
		public static  new object __hx_createEmpty(){
			unchecked {
				return new global::alphatab.rendering.glyphs.ClefGlyph(((global::haxe.lang.EmptyObject) (global::haxe.lang.EmptyObject.EMPTY) ));
			}
		}
		
		
		public static  new object __hx_create(global::haxe.root.Array arr){
			unchecked {
				return new global::alphatab.rendering.glyphs.ClefGlyph(global::haxe.lang.Null<object>.ofDynamic<int>(arr[0]), global::haxe.lang.Null<object>.ofDynamic<int>(arr[1]), ((global::alphatab.model.Clef) (arr[2]) ));
			}
		}
		
		
		public override   void doLayout(){
			unchecked {
				this.width = ((int) (( 28 * this.renderer.stave.staveGroup.layout.renderer.settings.scale )) );
			}
		}
		
		
		public override   bool canScale(){
			unchecked {
				return false;
			}
		}
		
		
		public virtual   global::alphatab.rendering.glyphs.LazySvg getClefSvg(global::alphatab.model.Clef clef){
			unchecked {
				switch (global::haxe.root.Type.enumIndex(clef)){
					case 0:
					{
						return global::alphatab.rendering.glyphs.MusicFont.ClefNeutral;
					}
					
					
					case 1:
					{
						return global::alphatab.rendering.glyphs.MusicFont.ClefC;
					}
					
					
					case 2:
					{
						return global::alphatab.rendering.glyphs.MusicFont.ClefC;
					}
					
					
					case 3:
					{
						return global::alphatab.rendering.glyphs.MusicFont.ClefF;
					}
					
					
					case 4:
					{
						return global::alphatab.rendering.glyphs.MusicFont.ClefG;
					}
					
					
				}
				
				return default(global::alphatab.rendering.glyphs.LazySvg);
			}
		}
		
		
		public override   object __hx_getField(string field, int hash, bool throwErrors, bool isCheck, bool handleProperties){
			unchecked {
				switch (hash){
					case 2111645508:
					{
						return ((global::haxe.lang.Function) (new global::haxe.lang.Closure(((object) (this) ), ((string) ("getClefSvg") ), ((int) (2111645508) ))) );
					}
					
					
					case 1734479962:
					{
						return ((global::haxe.lang.Function) (new global::haxe.lang.Closure(((object) (this) ), ((string) ("canScale") ), ((int) (1734479962) ))) );
					}
					
					
					case 1825584277:
					{
						return ((global::haxe.lang.Function) (new global::haxe.lang.Closure(((object) (this) ), ((string) ("doLayout") ), ((int) (1825584277) ))) );
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
					
					
					case 2111645508:
					{
						return this.getClefSvg(((global::alphatab.model.Clef) (dynargs[0]) ));
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


