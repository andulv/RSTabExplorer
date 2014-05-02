using haxe.root;
#pragma warning disable 109, 114, 219, 429, 168, 162
namespace haxe.io{
	public  class BytesInput : global::haxe.io.Input {
		public    BytesInput(global::haxe.lang.EmptyObject empty) : base(global::haxe.lang.EmptyObject.EMPTY){
			unchecked {
			}
		}
		
		
		public    BytesInput(global::haxe.io.Bytes b, global::haxe.lang.Null<int> pos, global::haxe.lang.Null<int> len){
			unchecked {
				global::haxe.io.BytesInput.__hx_ctor_haxe_io_BytesInput(this, b, pos, len);
			}
		}
		
		
		public static   void __hx_ctor_haxe_io_BytesInput(global::haxe.io.BytesInput __temp_me314, global::haxe.io.Bytes b, global::haxe.lang.Null<int> pos, global::haxe.lang.Null<int> len){
			unchecked {
				if ( ! (pos.hasValue) ) {
					pos = new global::haxe.lang.Null<int>(0, true);
				}
				
				if ( ! (len.hasValue) ) {
					len = new global::haxe.lang.Null<int>(( b.length - pos.@value ), true);
				}
				
				if (( ( ( pos.@value < 0 ) || ( len.@value < 0 ) ) || ( ( pos.@value + len.@value ) > b.length ) )) {
					throw global::haxe.lang.HaxeException.wrap(global::haxe.io.Error.OutsideBounds);
				}
				
				__temp_me314.b = b.b;
				__temp_me314.pos = pos.@value;
				__temp_me314.len = len.@value;
				__temp_me314.totlen = len.@value;
			}
		}
		
		
		public static  new object __hx_createEmpty(){
			unchecked {
				return new global::haxe.io.BytesInput(((global::haxe.lang.EmptyObject) (global::haxe.lang.EmptyObject.EMPTY) ));
			}
		}
		
		
		public static  new object __hx_create(global::haxe.root.Array arr){
			unchecked {
				return new global::haxe.io.BytesInput(((global::haxe.io.Bytes) (arr[0]) ), global::haxe.lang.Null<object>.ofDynamic<int>(arr[1]), global::haxe.lang.Null<object>.ofDynamic<int>(arr[2]));
			}
		}
		
		
		public  byte[] b;
		
		public  int pos;
		
		public  int len;
		
		public  int totlen;
		
		public override   int readByte(){
			unchecked {
				if (( this.len == 0 )) {
					throw global::haxe.lang.HaxeException.wrap(new global::haxe.io.Eof());
				}
				
				this.len--;
				return ((int) (this.b[this.pos++]) );
			}
		}
		
		
		public override   int readBytes(global::haxe.io.Bytes buf, int pos, int len){
			unchecked {
				if (( ( ( pos < 0 ) || ( len < 0 ) ) || ( ( pos + len ) > buf.length ) )) {
					throw global::haxe.lang.HaxeException.wrap(global::haxe.io.Error.OutsideBounds);
				}
				
				int avail = this.len;
				if (( len > avail )) {
					len = avail;
				}
				
				if (( len == 0 )) {
					throw global::haxe.lang.HaxeException.wrap(new global::haxe.io.Eof());
				}
				
				global::System.Array.Copy(((global::System.Array) (this.b) ), ((int) (this.pos) ), ((global::System.Array) (buf.b) ), ((int) (pos) ), ((int) (len) ));
				this.pos += len;
				this.len -= len;
				return len;
			}
		}
		
		
		public override   double __hx_setField_f(string field, int hash, double @value, bool handleProperties){
			unchecked {
				switch (hash){
					case 400509660:
					{
						this.totlen = ((int) (@value) );
						return @value;
					}
					
					
					case 5393365:
					{
						this.len = ((int) (@value) );
						return @value;
					}
					
					
					case 5594516:
					{
						this.pos = ((int) (@value) );
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
					case 400509660:
					{
						this.totlen = ((int) (global::haxe.lang.Runtime.toInt(@value)) );
						return @value;
					}
					
					
					case 5393365:
					{
						this.len = ((int) (global::haxe.lang.Runtime.toInt(@value)) );
						return @value;
					}
					
					
					case 5594516:
					{
						this.pos = ((int) (global::haxe.lang.Runtime.toInt(@value)) );
						return @value;
					}
					
					
					case 98:
					{
						this.b = ((byte[]) (@value) );
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
					case 243225909:
					{
						return ((global::haxe.lang.Function) (new global::haxe.lang.Closure(((object) (this) ), ((string) ("readBytes") ), ((int) (243225909) ))) );
					}
					
					
					case 1763375486:
					{
						return ((global::haxe.lang.Function) (new global::haxe.lang.Closure(((object) (this) ), ((string) ("readByte") ), ((int) (1763375486) ))) );
					}
					
					
					case 400509660:
					{
						return this.totlen;
					}
					
					
					case 5393365:
					{
						return this.len;
					}
					
					
					case 5594516:
					{
						return this.pos;
					}
					
					
					case 98:
					{
						return this.b;
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
					case 400509660:
					{
						return ((double) (this.totlen) );
					}
					
					
					case 5393365:
					{
						return ((double) (this.len) );
					}
					
					
					case 5594516:
					{
						return ((double) (this.pos) );
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
				baseArr.push("totlen");
				baseArr.push("len");
				baseArr.push("pos");
				baseArr.push("b");
				{
					base.__hx_getFields(baseArr);
				}
				
			}
		}
		
		
	}
}


