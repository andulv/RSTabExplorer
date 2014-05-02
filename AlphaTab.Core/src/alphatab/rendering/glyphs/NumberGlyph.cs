using haxe.root;
#pragma warning disable 109, 114, 219, 429, 168, 162
namespace alphatab.rendering.glyphs{
	public  class NumberGlyph : global::alphatab.rendering.glyphs.GlyphGroup {
		public    NumberGlyph(global::haxe.lang.EmptyObject empty) : base(global::haxe.lang.EmptyObject.EMPTY){
			unchecked {
			}
		}
		
		
		public    NumberGlyph(int x, int y, int number) : base(global::haxe.lang.EmptyObject.EMPTY){
			unchecked {
				global::alphatab.rendering.glyphs.NumberGlyph.__hx_ctor_alphatab_rendering_glyphs_NumberGlyph(this, x, y, number);
			}
		}
		
		
		public static   void __hx_ctor_alphatab_rendering_glyphs_NumberGlyph(global::alphatab.rendering.glyphs.NumberGlyph __temp_me189, int x, int y, int number){
			unchecked {
				global::alphatab.rendering.glyphs.GlyphGroup.__hx_ctor_alphatab_rendering_glyphs_GlyphGroup(__temp_me189, new global::haxe.lang.Null<int>(x, true), new global::haxe.lang.Null<int>(y, true), new global::haxe.root.Array<object>());
				__temp_me189._number = number;
			}
		}
		
		
		public static  new object __hx_createEmpty(){
			unchecked {
				return new global::alphatab.rendering.glyphs.NumberGlyph(((global::haxe.lang.EmptyObject) (global::haxe.lang.EmptyObject.EMPTY) ));
			}
		}
		
		
		public static  new object __hx_create(global::haxe.root.Array arr){
			unchecked {
				return new global::alphatab.rendering.glyphs.NumberGlyph(((int) (global::haxe.lang.Runtime.toInt(arr[0])) ), ((int) (global::haxe.lang.Runtime.toInt(arr[1])) ), ((int) (global::haxe.lang.Runtime.toInt(arr[2])) ));
			}
		}
		
		
		public  int _number;
		
		public override   bool canScale(){
			unchecked {
				return false;
			}
		}
		
		
		public override   void doLayout(){
			unchecked {
				int i = this._number;
				while (( i > 0 )){
					int num = ( i % 10 );
					global::alphatab.rendering.glyphs.DigitGlyph gl = new global::alphatab.rendering.glyphs.DigitGlyph(new global::haxe.lang.Null<int>(0, true), new global::haxe.lang.Null<int>(0, true), ((int) (num) ));
					this._glyphs.push(gl);
					i = ( i / 10 );
				}
				
				this._glyphs.reverse();
				int cx = 0;
				{
					int _g = 0;
					global::haxe.root.Array<object> _g1 = this._glyphs;
					while (( _g < _g1.length )){
						global::alphatab.rendering.Glyph g = ((global::alphatab.rendering.Glyph) (_g1[_g]) );
						 ++ _g;
						g.x = cx;
						g.y = 0;
						g.renderer = this.renderer;
						g.doLayout();
						cx += g.width;
					}
					
				}
				
				this.width = cx;
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
					case 1825584277:
					{
						return ((global::haxe.lang.Function) (new global::haxe.lang.Closure(((object) (this) ), ((string) ("doLayout") ), ((int) (1825584277) ))) );
					}
					
					
					case 1734479962:
					{
						return ((global::haxe.lang.Function) (new global::haxe.lang.Closure(((object) (this) ), ((string) ("canScale") ), ((int) (1734479962) ))) );
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
				baseArr.push("_number");
				{
					base.__hx_getFields(baseArr);
				}
				
			}
		}
		
		
	}
}


