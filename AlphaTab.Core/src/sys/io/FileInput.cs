using haxe.root;
#pragma warning disable 109, 114, 219, 429, 168, 162
namespace sys.io{
	public  class FileInput : global::cs.io.NativeInput {
		public    FileInput(global::haxe.lang.EmptyObject empty) : base(((global::haxe.lang.EmptyObject) (global::haxe.lang.EmptyObject.EMPTY) )){
			unchecked {
			}
		}
		
		
		public    FileInput(global::System.IO.FileStream stream) : base(((global::haxe.lang.EmptyObject) (global::haxe.lang.EmptyObject.EMPTY) )){
			unchecked {
				global::sys.io.FileInput.__hx_ctor_sys_io_FileInput(this, stream);
			}
		}
		
		
		public static   void __hx_ctor_sys_io_FileInput(global::sys.io.FileInput __temp_me322, global::System.IO.FileStream stream){
			unchecked {
				global::cs.io.NativeInput.__hx_ctor_cs_io_NativeInput(__temp_me322, stream);
			}
		}
		
		
		public static  new object __hx_createEmpty(){
			unchecked {
				return new global::sys.io.FileInput(((global::haxe.lang.EmptyObject) (global::haxe.lang.EmptyObject.EMPTY) ));
			}
		}
		
		
		public static  new object __hx_create(global::haxe.root.Array arr){
			unchecked {
				return new global::sys.io.FileInput(((global::System.IO.FileStream) (arr[0]) ));
			}
		}
		
		
	}
}


