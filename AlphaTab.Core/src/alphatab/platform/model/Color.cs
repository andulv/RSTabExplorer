using haxe.root;
#pragma warning disable 109, 114, 219, 429, 168, 162
namespace alphatab.platform.model{
	public  class Color : global::haxe.lang.HxObject {
		public    Color(global::haxe.lang.EmptyObject empty){
			unchecked {
				{
				}
				
			}
		}
		
		
		public    Color(int r, int g, int b, global::haxe.lang.Null<int> a){
			unchecked {
				global::alphatab.platform.model.Color.__hx_ctor_alphatab_platform_model_Color(this, r, g, b, a);
			}
		}
		
		
		public static   void __hx_ctor_alphatab_platform_model_Color(global::alphatab.platform.model.Color __temp_me19, int r, int g, int b, global::haxe.lang.Null<int> a){
			unchecked {
				int __temp_a18 = ( ( ! (a.hasValue) ) ? (((int) (255) )) : (a.@value) );
				__temp_me19._higherBits = ( ( (( __temp_a18 & 255 )) << 8 ) | ( r & 255 ) );
				__temp_me19._lowerBits = ( ( (( g & 255 )) << 8 ) | ( b & 255 ) );
			}
		}
		
		
		public static  new object __hx_createEmpty(){
			unchecked {
				return new global::alphatab.platform.model.Color(((global::haxe.lang.EmptyObject) (global::haxe.lang.EmptyObject.EMPTY) ));
			}
		}
		
		
		public static  new object __hx_create(global::haxe.root.Array arr){
			unchecked {
				return new global::alphatab.platform.model.Color(((int) (global::haxe.lang.Runtime.toInt(arr[0])) ), ((int) (global::haxe.lang.Runtime.toInt(arr[1])) ), ((int) (global::haxe.lang.Runtime.toInt(arr[2])) ), global::haxe.lang.Null<object>.ofDynamic<int>(arr[3]));
			}
		}
		
		
		public  int _lowerBits;
		
		public  int _higherBits;
		
		public virtual   int getA(){
			unchecked {
				return ( ( this._higherBits >> 8 ) & 255 );
			}
		}
		
		
		public virtual   int getR(){
			unchecked {
				return ( this._higherBits & 255 );
			}
		}
		
		
		public virtual   int getG(){
			unchecked {
				return ( ( this._lowerBits >> 8 ) & 255 );
			}
		}
		
		
		public virtual   int getB(){
			unchecked {
				return ( this._lowerBits & 255 );
			}
		}
		
		
		public virtual   string toHexString(){
			unchecked {
				return global::haxe.lang.Runtime.concat(global::haxe.lang.Runtime.concat(global::haxe.lang.Runtime.concat(global::haxe.lang.Runtime.concat("#", global::haxe.root.StringTools.hex(this.getA(), new global::haxe.lang.Null<int>(2, true))), global::haxe.root.StringTools.hex(this.getR(), new global::haxe.lang.Null<int>(2, true))), global::haxe.root.StringTools.hex(this.getG(), new global::haxe.lang.Null<int>(2, true))), global::haxe.root.StringTools.hex(this.getB(), new global::haxe.lang.Null<int>(2, true)));
			}
		}
		
		
		public virtual   string toRgbaString(){
			unchecked {
				return global::haxe.lang.Runtime.concat(global::haxe.lang.Runtime.concat(global::haxe.lang.Runtime.concat(global::haxe.lang.Runtime.concat(global::haxe.lang.Runtime.concat(global::haxe.lang.Runtime.concat(global::haxe.lang.Runtime.concat(global::haxe.lang.Runtime.concat("rgba(", global::haxe.lang.Runtime.toString(this.getR())), ","), global::haxe.lang.Runtime.toString(this.getG())), ","), global::haxe.lang.Runtime.toString(this.getB())), ","), global::haxe.lang.Runtime.toString(( this.getA() / 255.0 ))), ")");
			}
		}
		
		
		public override   double __hx_setField_f(string field, int hash, double @value, bool handleProperties){
			unchecked {
				switch (hash){
					case 259814420:
					{
						this._higherBits = ((int) (@value) );
						return @value;
					}
					
					
					case 746467688:
					{
						this._lowerBits = ((int) (@value) );
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
					case 259814420:
					{
						this._higherBits = ((int) (global::haxe.lang.Runtime.toInt(@value)) );
						return @value;
					}
					
					
					case 746467688:
					{
						this._lowerBits = ((int) (global::haxe.lang.Runtime.toInt(@value)) );
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
					case 249568768:
					{
						return ((global::haxe.lang.Function) (new global::haxe.lang.Closure(((object) (this) ), ((string) ("toRgbaString") ), ((int) (249568768) ))) );
					}
					
					
					case 1840474385:
					{
						return ((global::haxe.lang.Function) (new global::haxe.lang.Closure(((object) (this) ), ((string) ("toHexString") ), ((int) (1840474385) ))) );
					}
					
					
					case 1147273964:
					{
						return ((global::haxe.lang.Function) (new global::haxe.lang.Closure(((object) (this) ), ((string) ("getB") ), ((int) (1147273964) ))) );
					}
					
					
					case 1147273969:
					{
						return ((global::haxe.lang.Function) (new global::haxe.lang.Closure(((object) (this) ), ((string) ("getG") ), ((int) (1147273969) ))) );
					}
					
					
					case 1147273980:
					{
						return ((global::haxe.lang.Function) (new global::haxe.lang.Closure(((object) (this) ), ((string) ("getR") ), ((int) (1147273980) ))) );
					}
					
					
					case 1147273963:
					{
						return ((global::haxe.lang.Function) (new global::haxe.lang.Closure(((object) (this) ), ((string) ("getA") ), ((int) (1147273963) ))) );
					}
					
					
					case 259814420:
					{
						return this._higherBits;
					}
					
					
					case 746467688:
					{
						return this._lowerBits;
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
					case 259814420:
					{
						return ((double) (this._higherBits) );
					}
					
					
					case 746467688:
					{
						return ((double) (this._lowerBits) );
					}
					
					
					default:
					{
						return base.__hx_getField_f(field, hash, throwErrors, handleProperties);
					}
					
				}
				
			}
		}
		
		
		public override   object __hx_invokeField(string field, int hash, global::haxe.root.Array dynargs){
			unchecked {
				switch (hash){
					case 249568768:
					{
						return this.toRgbaString();
					}
					
					
					case 1840474385:
					{
						return this.toHexString();
					}
					
					
					case 1147273964:
					{
						return this.getB();
					}
					
					
					case 1147273969:
					{
						return this.getG();
					}
					
					
					case 1147273980:
					{
						return this.getR();
					}
					
					
					case 1147273963:
					{
						return this.getA();
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
				baseArr.push("_higherBits");
				baseArr.push("_lowerBits");
				{
					base.__hx_getFields(baseArr);
				}
				
			}
		}
		
		
	}
}


