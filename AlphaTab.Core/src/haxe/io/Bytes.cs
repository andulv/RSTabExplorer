using haxe.root;
#pragma warning disable 109, 114, 219, 429, 168, 162
namespace haxe.io{
	public  class Bytes : global::haxe.lang.HxObject {
		public    Bytes(global::haxe.lang.EmptyObject empty){
			unchecked {
				{
				}
				
			}
		}
		
		
		public    Bytes(int length, byte[] b){
			unchecked {
				global::haxe.io.Bytes.__hx_ctor_haxe_io_Bytes(this, length, b);
			}
		}
		
		
		public static   void __hx_ctor_haxe_io_Bytes(global::haxe.io.Bytes __temp_me312, int length, byte[] b){
			unchecked {
				__temp_me312.length = length;
				__temp_me312.b = b;
			}
		}
		
		
		public static   global::haxe.io.Bytes alloc(int length){
			unchecked {
				return new global::haxe.io.Bytes(((int) (length) ), ((byte[]) (new byte[((int) (length) )]) ));
			}
		}
		
		
		public static   global::haxe.io.Bytes ofString(string s){
			unchecked {
				byte[] b = global::System.Text.Encoding.UTF8.GetBytes(((string) (s) ));
				return new global::haxe.io.Bytes(((int) (( b as global::System.Array ).Length) ), ((byte[]) (b) ));
			}
		}
		
		
		public static  new object __hx_createEmpty(){
			unchecked {
				return new global::haxe.io.Bytes(((global::haxe.lang.EmptyObject) (global::haxe.lang.EmptyObject.EMPTY) ));
			}
		}
		
		
		public static  new object __hx_create(global::haxe.root.Array arr){
			unchecked {
				return new global::haxe.io.Bytes(((int) (global::haxe.lang.Runtime.toInt(arr[0])) ), ((byte[]) (arr[1]) ));
			}
		}
		
		
		public  int length;
		
		public  byte[] b;
		
		public virtual   void blit(int pos, global::haxe.io.Bytes src, int srcpos, int len){
			unchecked {
				if (( ( ( ( ( pos < 0 ) || ( srcpos < 0 ) ) || ( len < 0 ) ) || ( ( pos + len ) > this.length ) ) || ( ( srcpos + len ) > src.length ) )) {
					throw global::haxe.lang.HaxeException.wrap(global::haxe.io.Error.OutsideBounds);
				}
				
				global::System.Array.Copy(((global::System.Array) (src.b) ), ((int) (srcpos) ), ((global::System.Array) (this.b) ), ((int) (pos) ), ((int) (len) ));
			}
		}
		
		
		public virtual   global::haxe.io.Bytes sub(int pos, int len){
			unchecked {
				if (( ( ( pos < 0 ) || ( len < 0 ) ) || ( ( pos + len ) > this.length ) )) {
					throw global::haxe.lang.HaxeException.wrap(global::haxe.io.Error.OutsideBounds);
				}
				
				byte[] newarr = new byte[((int) (len) )];
				global::System.Array.Copy(((global::System.Array) (this.b) ), ((int) (pos) ), ((global::System.Array) (newarr) ), ((int) (0) ), ((int) (len) ));
				return new global::haxe.io.Bytes(((int) (len) ), ((byte[]) (newarr) ));
			}
		}
		
		
		public virtual   string toString(){
			unchecked {
				return global::System.Text.Encoding.UTF8.GetString(((byte[]) (this.b) ), ((int) (0) ), ((int) (this.length) ));
			}
		}
		
		
		public override   double __hx_setField_f(string field, int hash, double @value, bool handleProperties){
			unchecked {
				switch (hash){
					case 520590566:
					{
						this.length = ((int) (@value) );
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
					case 98:
					{
						this.b = ((byte[]) (@value) );
						return @value;
					}
					
					
					case 520590566:
					{
						this.length = ((int) (global::haxe.lang.Runtime.toInt(@value)) );
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
					case 946786476:
					{
						return ((global::haxe.lang.Function) (new global::haxe.lang.Closure(((object) (this) ), ((string) ("toString") ), ((int) (946786476) ))) );
					}
					
					
					case 5745024:
					{
						return ((global::haxe.lang.Function) (new global::haxe.lang.Closure(((object) (this) ), ((string) ("sub") ), ((int) (5745024) ))) );
					}
					
					
					case 1092171829:
					{
						return ((global::haxe.lang.Function) (new global::haxe.lang.Closure(((object) (this) ), ((string) ("blit") ), ((int) (1092171829) ))) );
					}
					
					
					case 98:
					{
						return this.b;
					}
					
					
					case 520590566:
					{
						return this.length;
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
					case 520590566:
					{
						return ((double) (this.length) );
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
					case 946786476:
					{
						return this.toString();
					}
					
					
					case 5745024:
					{
						return this.sub(((int) (global::haxe.lang.Runtime.toInt(dynargs[0])) ), ((int) (global::haxe.lang.Runtime.toInt(dynargs[1])) ));
					}
					
					
					case 1092171829:
					{
						this.blit(((int) (global::haxe.lang.Runtime.toInt(dynargs[0])) ), ((global::haxe.io.Bytes) (dynargs[1]) ), ((int) (global::haxe.lang.Runtime.toInt(dynargs[2])) ), ((int) (global::haxe.lang.Runtime.toInt(dynargs[3])) ));
						break;
					}
					
					
					default:
					{
						return base.__hx_invokeField(field, hash, dynargs);
					}
					
				}
				
				return default(object);
			}
		}
		
		
		public override   void __hx_getFields(global::haxe.root.Array<object> baseArr){
			unchecked {
				baseArr.push("b");
				baseArr.push("length");
				{
					base.__hx_getFields(baseArr);
				}
				
			}
		}
		
		
		public override string ToString(){
			return this.toString();
		}
		
		
	}
}


