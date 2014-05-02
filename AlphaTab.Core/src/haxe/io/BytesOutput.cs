using haxe.root;
#pragma warning disable 109, 114, 219, 429, 168, 162
namespace haxe.io{
	public  class BytesOutput : global::haxe.io.Output {
		public    BytesOutput(global::haxe.lang.EmptyObject empty) : base(global::haxe.lang.EmptyObject.EMPTY){
			unchecked {
			}
		}
		
		
		public    BytesOutput(){
			unchecked {
				global::haxe.io.BytesOutput.__hx_ctor_haxe_io_BytesOutput(this);
			}
		}
		
		
		public static   void __hx_ctor_haxe_io_BytesOutput(global::haxe.io.BytesOutput __temp_me315){
			unchecked {
				__temp_me315.b = new global::haxe.io.BytesBuffer();
			}
		}
		
		
		public static  new object __hx_createEmpty(){
			unchecked {
				return new global::haxe.io.BytesOutput(((global::haxe.lang.EmptyObject) (global::haxe.lang.EmptyObject.EMPTY) ));
			}
		}
		
		
		public static  new object __hx_create(global::haxe.root.Array arr){
			unchecked {
				return new global::haxe.io.BytesOutput();
			}
		}
		
		
		public  global::haxe.io.BytesBuffer b;
		
		public override   void writeByte(int c){
			unchecked {
				( this.b.b as global::System.IO.Stream ).WriteByte(((byte) (c) ));
			}
		}
		
		
		public override   int writeBytes(global::haxe.io.Bytes buf, int pos, int len){
			unchecked {
				{
					if (( ( ( pos < 0 ) || ( len < 0 ) ) || ( ( pos + len ) > buf.length ) )) {
						throw global::haxe.lang.HaxeException.wrap(global::haxe.io.Error.OutsideBounds);
					}
					
					( this.b.b as global::System.IO.Stream ).Write(((byte[]) (buf.b) ), ((int) (pos) ), ((int) (len) ));
				}
				
				return len;
			}
		}
		
		
		public virtual   global::haxe.io.Bytes getBytes(){
			unchecked {
				return this.b.getBytes();
			}
		}
		
		
		public override   object __hx_setField(string field, int hash, object @value, bool handleProperties){
			unchecked {
				switch (hash){
					case 98:
					{
						this.b = ((global::haxe.io.BytesBuffer) (@value) );
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
					case 493819893:
					{
						return ((global::haxe.lang.Function) (new global::haxe.lang.Closure(((object) (this) ), ((string) ("getBytes") ), ((int) (493819893) ))) );
					}
					
					
					case 1381630732:
					{
						return ((global::haxe.lang.Function) (new global::haxe.lang.Closure(((object) (this) ), ((string) ("writeBytes") ), ((int) (1381630732) ))) );
					}
					
					
					case 1238832007:
					{
						return ((global::haxe.lang.Function) (new global::haxe.lang.Closure(((object) (this) ), ((string) ("writeByte") ), ((int) (1238832007) ))) );
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
		
		
		public override   object __hx_invokeField(string field, int hash, global::haxe.root.Array dynargs){
			unchecked {
				switch (hash){
					case 1238832007:case 1381630732:
					{
						return global::haxe.lang.Runtime.slowCallField(this, field, dynargs);
					}
					
					
					case 493819893:
					{
						return this.getBytes();
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
				baseArr.push("b");
				{
					base.__hx_getFields(baseArr);
				}
				
			}
		}
		
		
	}
}


