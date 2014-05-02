using haxe.root;
#pragma warning disable 109, 114, 219, 429, 168, 162
namespace alphatab.rendering.glyphs{
	public  class RepeatOpenGlyph : global::alphatab.rendering.Glyph {
		public    RepeatOpenGlyph(global::haxe.lang.EmptyObject empty) : base(global::haxe.lang.EmptyObject.EMPTY){
			unchecked {
			}
		}
		
		
		public    RepeatOpenGlyph(global::haxe.lang.Null<int> x, global::haxe.lang.Null<int> y, double circleSize, int dotOffset) : base(global::haxe.lang.EmptyObject.EMPTY){
			unchecked {
				global::alphatab.rendering.glyphs.RepeatOpenGlyph.__hx_ctor_alphatab_rendering_glyphs_RepeatOpenGlyph(this, x, y, circleSize, dotOffset);
			}
		}
		
		
		public static   void __hx_ctor_alphatab_rendering_glyphs_RepeatOpenGlyph(global::alphatab.rendering.glyphs.RepeatOpenGlyph __temp_me198, global::haxe.lang.Null<int> x, global::haxe.lang.Null<int> y, double circleSize, int dotOffset){
			unchecked {
				global::alphatab.rendering.Glyph.__hx_ctor_alphatab_rendering_Glyph(__temp_me198, ( ( ! (x.hasValue) ) ? (new global::haxe.lang.Null<int>(0, true)) : (x) ), ( ( ! (y.hasValue) ) ? (new global::haxe.lang.Null<int>(0, true)) : (y) ));
				int __temp_y197 = ( ( ! (y.hasValue) ) ? (((int) (0) )) : (y.@value) );
				int __temp_x196 = ( ( ! (x.hasValue) ) ? (((int) (0) )) : (x.@value) );
				__temp_me198._dotOffset = dotOffset;
				__temp_me198._circleSize = circleSize;
			}
		}
		
		
		public static  new object __hx_createEmpty(){
			unchecked {
				return new global::alphatab.rendering.glyphs.RepeatOpenGlyph(((global::haxe.lang.EmptyObject) (global::haxe.lang.EmptyObject.EMPTY) ));
			}
		}
		
		
		public static  new object __hx_create(global::haxe.root.Array arr){
			unchecked {
				return new global::alphatab.rendering.glyphs.RepeatOpenGlyph(global::haxe.lang.Null<object>.ofDynamic<int>(arr[0]), global::haxe.lang.Null<object>.ofDynamic<int>(arr[1]), ((double) (global::haxe.lang.Runtime.toDouble(arr[2])) ), ((int) (global::haxe.lang.Runtime.toInt(arr[3])) ));
			}
		}
		
		
		public  int _dotOffset;
		
		public  double _circleSize;
		
		public override   void doLayout(){
			unchecked {
				this.width = ((int) (( 13 * this.renderer.stave.staveGroup.layout.renderer.settings.scale )) );
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
				double left = ( ( cx + this.x ) + 0.5 );
				int h = ( bottom - top );
				canvas.fillRect(left, ((double) (top) ), blockWidth, ((double) (h) ));
				left += ( ( blockWidth * 2 ) - 0.5 );
				canvas.beginPath();
				canvas.moveTo(left, ((double) (top) ));
				canvas.lineTo(left, ((double) (bottom) ));
				canvas.stroke();
				left += ( 3 * this.renderer.stave.staveGroup.layout.renderer.settings.scale );
				double circleSize = ( this._circleSize * this.renderer.stave.staveGroup.layout.renderer.settings.scale );
				double middle = ( ((double) ((( top + bottom ))) ) / 2 );
				canvas.beginPath();
				canvas.circle(left, ( middle - ( circleSize * this._dotOffset ) ), circleSize);
				canvas.circle(left, ( middle + ( circleSize * this._dotOffset ) ), circleSize);
				canvas.fill();
			}
		}
		
		
		public override   double __hx_setField_f(string field, int hash, double @value, bool handleProperties){
			unchecked {
				switch (hash){
					case 1322144784:
					{
						this._circleSize = ((double) (@value) );
						return @value;
					}
					
					
					case 2069681853:
					{
						this._dotOffset = ((int) (@value) );
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
					case 1322144784:
					{
						this._circleSize = ((double) (global::haxe.lang.Runtime.toDouble(@value)) );
						return @value;
					}
					
					
					case 2069681853:
					{
						this._dotOffset = ((int) (global::haxe.lang.Runtime.toInt(@value)) );
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
					
					
					case 1322144784:
					{
						return this._circleSize;
					}
					
					
					case 2069681853:
					{
						return this._dotOffset;
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
					case 1322144784:
					{
						return this._circleSize;
					}
					
					
					case 2069681853:
					{
						return ((double) (this._dotOffset) );
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
				baseArr.push("_circleSize");
				baseArr.push("_dotOffset");
				{
					base.__hx_getFields(baseArr);
				}
				
			}
		}
		
		
	}
}


