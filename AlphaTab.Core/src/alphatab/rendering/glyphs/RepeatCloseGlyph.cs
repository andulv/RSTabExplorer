using haxe.root;
#pragma warning disable 109, 114, 219, 429, 168, 162
namespace alphatab.rendering.glyphs{
	public  class RepeatCloseGlyph : global::alphatab.rendering.Glyph {
		public    RepeatCloseGlyph(global::haxe.lang.EmptyObject empty) : base(global::haxe.lang.EmptyObject.EMPTY){
			unchecked {
			}
		}
		
		
		public    RepeatCloseGlyph(global::haxe.lang.Null<int> x, global::haxe.lang.Null<int> y) : base(global::haxe.lang.EmptyObject.EMPTY){
			unchecked {
				global::alphatab.rendering.glyphs.RepeatCloseGlyph.__hx_ctor_alphatab_rendering_glyphs_RepeatCloseGlyph(this, x, y);
			}
		}
		
		
		public static   void __hx_ctor_alphatab_rendering_glyphs_RepeatCloseGlyph(global::alphatab.rendering.glyphs.RepeatCloseGlyph __temp_me192, global::haxe.lang.Null<int> x, global::haxe.lang.Null<int> y){
			unchecked {
				global::alphatab.rendering.Glyph.__hx_ctor_alphatab_rendering_Glyph(__temp_me192, ( ( ! (x.hasValue) ) ? (new global::haxe.lang.Null<int>(0, true)) : (x) ), ( ( ! (y.hasValue) ) ? (new global::haxe.lang.Null<int>(0, true)) : (y) ));
				int __temp_y191 = ( ( ! (y.hasValue) ) ? (((int) (0) )) : (y.@value) );
				int __temp_x190 = ( ( ! (x.hasValue) ) ? (((int) (0) )) : (x.@value) );
			}
		}
		
		
		public static  new object __hx_createEmpty(){
			unchecked {
				return new global::alphatab.rendering.glyphs.RepeatCloseGlyph(((global::haxe.lang.EmptyObject) (global::haxe.lang.EmptyObject.EMPTY) ));
			}
		}
		
		
		public static  new object __hx_create(global::haxe.root.Array arr){
			unchecked {
				return new global::alphatab.rendering.glyphs.RepeatCloseGlyph(global::haxe.lang.Null<object>.ofDynamic<int>(arr[0]), global::haxe.lang.Null<object>.ofDynamic<int>(arr[1]));
			}
		}
		
		
		public override   void doLayout(){
			unchecked {
				int @base = default(int);
				bool __temp_stmt625 = default(bool);
				{
					global::alphatab.rendering.BarRendererBase _this = this.renderer;
					__temp_stmt625 = ( _this.bar.index == ( _this.bar.track.bars.length - 1 ) );
				}
				
				if (__temp_stmt625) {
					@base = 11;
				}
				 else {
					@base = 13;
				}
				
				this.width = ((int) (( @base * this.renderer.stave.staveGroup.layout.renderer.settings.scale )) );
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
				double blockWidth = ( 4 * this.renderer.stave.staveGroup.layout.renderer.settings.scale );
				int top = ( ( cy + this.y ) + this.renderer.getTopPadding() );
				int bottom = ( ( ( cy + this.y ) + this.renderer.height ) - this.renderer.getBottomPadding() );
				double left = ((double) (( cx + this.x )) );
				int h = ( bottom - top );
				double circleSize = ( 1.5 * this.renderer.stave.staveGroup.layout.renderer.settings.scale );
				double middle = ( ((double) ((( top + bottom ))) ) / 2 );
				int dotOffset = 3;
				canvas.beginPath();
				canvas.circle(left, ( middle - ( circleSize * dotOffset ) ), circleSize);
				canvas.circle(left, ( middle + ( circleSize * dotOffset ) ), circleSize);
				canvas.fill();
				left += ( 4 * this.renderer.stave.staveGroup.layout.renderer.settings.scale );
				canvas.beginPath();
				canvas.moveTo(left, ((double) (top) ));
				canvas.lineTo(left, ((double) (bottom) ));
				canvas.stroke();
				left += ( ( 3 * this.renderer.stave.staveGroup.layout.renderer.settings.scale ) + 0.5 );
				canvas.fillRect(left, ((double) (top) ), blockWidth, ((double) (h) ));
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
					
					
					default:
					{
						return base.__hx_getField(field, hash, throwErrors, isCheck, handleProperties);
					}
					
				}
				
			}
		}
		
		
	}
}


