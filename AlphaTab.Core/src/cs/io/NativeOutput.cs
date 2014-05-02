using haxe.root;
#pragma warning disable 109, 114, 219, 429, 168, 162
namespace cs.io{
	public  class NativeOutput : global::haxe.io.Output {
		public    NativeOutput(global::haxe.lang.EmptyObject empty) : base(((global::haxe.lang.EmptyObject) (global::haxe.lang.EmptyObject.EMPTY) )){
			unchecked {
			}
		}
		
		
		public    NativeOutput(global::System.IO.Stream stream){
			unchecked {
				global::cs.io.NativeOutput.__hx_ctor_cs_io_NativeOutput(this, stream);
			}
		}
		
		
		public static   void __hx_ctor_cs_io_NativeOutput(global::cs.io.NativeOutput __temp_me307, global::System.IO.Stream stream){
			unchecked {
				__temp_me307.stream = stream;
				if ( ! (stream.CanWrite) ) {
					throw global::haxe.lang.HaxeException.wrap("Read-only stream");
				}
				
			}
		}
		
		
		public static  new object __hx_createEmpty(){
			unchecked {
				return new global::cs.io.NativeOutput(((global::haxe.lang.EmptyObject) (global::haxe.lang.EmptyObject.EMPTY) ));
			}
		}
		
		
		public static  new object __hx_create(global::haxe.root.Array arr){
			unchecked {
				return new global::cs.io.NativeOutput(((global::System.IO.Stream) (arr[0]) ));
			}
		}
		
		
		public  global::System.IO.Stream stream;
		
		public override   void writeByte(int c){
			unchecked {
				this.stream.WriteByte(((byte) (c) ));
			}
		}
		
		
		public override   object __hx_setField(string field, int hash, object @value, bool handleProperties){
			unchecked {
				switch (hash){
					case 288167040:
					{
						this.stream = ((global::System.IO.Stream) (@value) );
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
					case 1238832007:
					{
						return ((global::haxe.lang.Function) (new global::haxe.lang.Closure(((object) (this) ), ((string) ("writeByte") ), ((int) (1238832007) ))) );
					}
					
					
					case 288167040:
					{
						return this.stream;
					}
					
					
					default:
					{
						return base.__hx_getField(field, hash, throwErrors, isCheck, handleProperties);
					}
					
				}
				
			}
		}
		
		
		public override   void __hx_getFields(global::haxe.root.Array<object> baseArr){
			unchecked {
				baseArr.push("stream");
				{
					base.__hx_getFields(baseArr);
				}
				
			}
		}
		
		
	}
}


