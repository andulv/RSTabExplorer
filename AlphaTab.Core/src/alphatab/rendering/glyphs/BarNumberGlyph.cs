using haxe.root;
#pragma warning disable 109, 114, 219, 429, 168, 162
namespace alphatab.rendering.glyphs{
	public  class BarNumberGlyph : global::alphatab.rendering.Glyph {
		public    BarNumberGlyph(global::haxe.lang.EmptyObject empty) : base(global::haxe.lang.EmptyObject.EMPTY){
			unchecked {
			}
		}
		
		
		public    BarNumberGlyph(global::haxe.lang.Null<int> x, global::haxe.lang.Null<int> y, int number, global::haxe.lang.Null<bool> hidden) : base(global::haxe.lang.EmptyObject.EMPTY){
			unchecked {
				global::alphatab.rendering.glyphs.BarNumberGlyph.__hx_ctor_alphatab_rendering_glyphs_BarNumberGlyph(this, x, y, number, hidden);
			}
		}
		
		
		public static   void __hx_ctor_alphatab_rendering_glyphs_BarNumberGlyph(global::alphatab.rendering.glyphs.BarNumberGlyph __temp_me137, global::haxe.lang.Null<int> x, global::haxe.lang.Null<int> y, int number, global::haxe.lang.Null<bool> hidden){
			unchecked {
				global::alphatab.rendering.Glyph.__hx_ctor_alphatab_rendering_Glyph(__temp_me137, ( ( ! (x.hasValue) ) ? (new global::haxe.lang.Null<int>(0, true)) : (x) ), ( ( ! (y.hasValue) ) ? (new global::haxe.lang.Null<int>(0, true)) : (y) ));
				bool __temp_hidden136 = ( ( ! (hidden.hasValue) ) ? (global::haxe.lang.Runtime.toBool(false)) : (hidden.@value) );
				int __temp_y135 = ( ( ! (y.hasValue) ) ? (((int) (0) )) : (y.@value) );
				int __temp_x134 = ( ( ! (x.hasValue) ) ? (((int) (0) )) : (x.@value) );
				__temp_me137._number = number;
				__temp_me137._hidden = __temp_hidden136;
			}
		}
		
		
		public static  new object __hx_createEmpty(){
			unchecked {
				return new global::alphatab.rendering.glyphs.BarNumberGlyph(((global::haxe.lang.EmptyObject) (global::haxe.lang.EmptyObject.EMPTY) ));
			}
		}
		
		
		public static  new object __hx_create(global::haxe.root.Array arr){
			unchecked {
				return new global::alphatab.rendering.glyphs.BarNumberGlyph(global::haxe.lang.Null<object>.ofDynamic<int>(arr[0]), global::haxe.lang.Null<object>.ofDynamic<int>(arr[1]), ((int) (global::haxe.lang.Runtime.toInt(arr[2])) ), global::haxe.lang.Null<object>.ofDynamic<bool>(arr[3]));
			}
		}
		
		
		public  int _number;
		
		public  bool _hidden;
		
		public override   void doLayout(){
			unchecked {
				global::alphatab.rendering.ScoreRenderer scoreRenderer = this.renderer.stave.staveGroup.layout.renderer;
				scoreRenderer.canvas.setFont(scoreRenderer.renderingResources.barNumberFont);
				this.width = ((int) (( 10 * this.renderer.stave.staveGroup.layout.renderer.settings.scale )) );
			}
		}
		
		
		public override   bool canScale(){
			unchecked {
				return false;
			}
		}
		
		
		public override   void paint(int cx, int cy, global::alphatab.platform.ICanvas canvas){
			unchecked {
				if (this._hidden) {
					return ;
				}
				
				global::alphatab.rendering.RenderingResources res = this.renderer.stave.staveGroup.layout.renderer.renderingResources;
				canvas.setColor(res.barNumberColor);
				canvas.setFont(res.barNumberFont);
				canvas.fillText(global::haxe.root.Std.@string(this._number), ((double) (( cx + this.x )) ), ((double) (( cy + this.y )) ));
			}
		}
		
		
		public override   double __hx_setField_f(string field, int hash, double @value, bool handleProperties){
			unchecked {
				switch (hash){
					case 267491432:
					{
						this._number = ((int) (@value) );
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
					case 990712073:
					{
						this._hidden = global::haxe.lang.Runtime.toBool(@value);
						return @value;
					}
					
					
					case 267491432:
					{
						this._number = ((int) (global::haxe.lang.Runtime.toInt(@value)) );
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
					
					
					case 990712073:
					{
						return this._hidden;
					}
					
					
					case 267491432:
					{
						return this._number;
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
					case 267491432:
					{
						return ((double) (this._number) );
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
				baseArr.push("_hidden");
				baseArr.push("_number");
				{
					base.__hx_getFields(baseArr);
				}
				
			}
		}
		
		
	}
}


