using haxe.root;
#pragma warning disable 109, 114, 219, 429, 168, 162
namespace haxe.io{
	public  class BytesBuffer : global::haxe.lang.HxObject {
		public    BytesBuffer(global::haxe.lang.EmptyObject empty){
			unchecked {
				{
				}
				
			}
		}
		
		
		public    BytesBuffer(){
			unchecked {
				global::haxe.io.BytesBuffer.__hx_ctor_haxe_io_BytesBuffer(this);
			}
		}
		
		
		public static   void __hx_ctor_haxe_io_BytesBuffer(global::haxe.io.BytesBuffer __temp_me313){
			unchecked {
				__temp_me313.b = new global::System.IO.MemoryStream();
			}
		}
		
		
		public static  new object __hx_createEmpty(){
			unchecked {
				return new global::haxe.io.BytesBuffer(((global::haxe.lang.EmptyObject) (global::haxe.lang.EmptyObject.EMPTY) ));
			}
		}
		
		
		public static  new object __hx_create(global::haxe.root.Array arr){
			unchecked {
				return new global::haxe.io.BytesBuffer();
			}
		}
		
		
		public  global::System.IO.MemoryStream b;
		
		public virtual   global::haxe.io.Bytes getBytes(){
			unchecked {
				byte[] buf = this.b.GetBuffer();
				global::haxe.io.Bytes bytes = new global::haxe.io.Bytes(((int) (( this.b as global::System.IO.Stream ).Length) ), ((byte[]) (buf) ));
				this.b = default(global::System.IO.MemoryStream);
				return bytes;
			}
		}
		
		
		public override   object __hx_setField(string field, int hash, object @value, bool handleProperties){
			unchecked {
				switch (hash){
					case 98:
					{
						this.b = ((global::System.IO.MemoryStream) (@value) );
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


