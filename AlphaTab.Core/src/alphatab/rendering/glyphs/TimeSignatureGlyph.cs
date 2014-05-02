using haxe.root;
#pragma warning disable 109, 114, 219, 429, 168, 162
namespace alphatab.rendering.glyphs{
	public  class TimeSignatureGlyph : global::alphatab.rendering.glyphs.GlyphGroup {
		public    TimeSignatureGlyph(global::haxe.lang.EmptyObject empty) : base(global::haxe.lang.EmptyObject.EMPTY){
			unchecked {
			}
		}
		
		
		public    TimeSignatureGlyph(int x, int y, int numerator, int denominator) : base(global::haxe.lang.EmptyObject.EMPTY){
			unchecked {
				global::alphatab.rendering.glyphs.TimeSignatureGlyph.__hx_ctor_alphatab_rendering_glyphs_TimeSignatureGlyph(this, x, y, numerator, denominator);
			}
		}
		
		
		public static   void __hx_ctor_alphatab_rendering_glyphs_TimeSignatureGlyph(global::alphatab.rendering.glyphs.TimeSignatureGlyph __temp_me238, int x, int y, int numerator, int denominator){
			unchecked {
				global::alphatab.rendering.glyphs.GlyphGroup.__hx_ctor_alphatab_rendering_glyphs_GlyphGroup(__temp_me238, new global::haxe.lang.Null<int>(x, true), new global::haxe.lang.Null<int>(y, true), new global::haxe.root.Array<object>());
				__temp_me238._numerator = numerator;
				__temp_me238._denominator = denominator;
			}
		}
		
		
		public static  new object __hx_createEmpty(){
			unchecked {
				return new global::alphatab.rendering.glyphs.TimeSignatureGlyph(((global::haxe.lang.EmptyObject) (global::haxe.lang.EmptyObject.EMPTY) ));
			}
		}
		
		
		public static  new object __hx_create(global::haxe.root.Array arr){
			unchecked {
				return new global::alphatab.rendering.glyphs.TimeSignatureGlyph(((int) (global::haxe.lang.Runtime.toInt(arr[0])) ), ((int) (global::haxe.lang.Runtime.toInt(arr[1])) ), ((int) (global::haxe.lang.Runtime.toInt(arr[2])) ), ((int) (global::haxe.lang.Runtime.toInt(arr[3])) ));
			}
		}
		
		
		public  int _numerator;
		
		public  int _denominator;
		
		public override   bool canScale(){
			unchecked {
				return false;
			}
		}
		
		
		public override   void doLayout(){
			unchecked {
				global::alphatab.rendering.glyphs.NumberGlyph numerator = new global::alphatab.rendering.glyphs.NumberGlyph(((int) (0) ), ((int) (0) ), ((int) (this._numerator) ));
				global::alphatab.rendering.glyphs.NumberGlyph denominator = new global::alphatab.rendering.glyphs.NumberGlyph(((int) (0) ), ((int) (( 18 * this.renderer.stave.staveGroup.layout.renderer.settings.scale )) ), ((int) (this._denominator) ));
				this._glyphs.push(numerator);
				this._glyphs.push(denominator);
				base.doLayout();
				{
					int _g = 0;
					global::haxe.root.Array<object> _g1 = this._glyphs;
					while (( _g < _g1.length )){
						global::alphatab.rendering.Glyph g = ((global::alphatab.rendering.Glyph) (_g1[_g]) );
						 ++ _g;
						g.x = ( (( this.width - g.width )) / 2 );
					}
					
				}
				
			}
		}
		
		
		public override   double __hx_setField_f(string field, int hash, double @value, bool handleProperties){
			unchecked {
				switch (hash){
					case 1368249255:
					{
						this._denominator = ((int) (@value) );
						return @value;
					}
					
					
					case 507444810:
					{
						this._numerator = ((int) (@value) );
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
					case 1368249255:
					{
						this._denominator = ((int) (global::haxe.lang.Runtime.toInt(@value)) );
						return @value;
					}
					
					
					case 507444810:
					{
						this._numerator = ((int) (global::haxe.lang.Runtime.toInt(@value)) );
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
					
					
					case 1368249255:
					{
						return this._denominator;
					}
					
					
					case 507444810:
					{
						return this._numerator;
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
					case 1368249255:
					{
						return ((double) (this._denominator) );
					}
					
					
					case 507444810:
					{
						return ((double) (this._numerator) );
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
				baseArr.push("_denominator");
				baseArr.push("_numerator");
				{
					base.__hx_getFields(baseArr);
				}
				
			}
		}
		
		
	}
}


