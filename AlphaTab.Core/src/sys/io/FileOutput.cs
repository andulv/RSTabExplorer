using haxe.root;
#pragma warning disable 109, 114, 219, 429, 168, 162
namespace sys.io{
	public  class FileOutput : global::cs.io.NativeOutput {
		public    FileOutput(global::haxe.lang.EmptyObject empty) : base(((global::haxe.lang.EmptyObject) (global::haxe.lang.EmptyObject.EMPTY) )){
			unchecked {
			}
		}
		
		
		public    FileOutput(global::System.IO.FileStream stream) : base(((global::haxe.lang.EmptyObject) (global::haxe.lang.EmptyObject.EMPTY) )){
			unchecked {
				global::sys.io.FileOutput.__hx_ctor_sys_io_FileOutput(this, stream);
			}
		}
		
		
		public static   void __hx_ctor_sys_io_FileOutput(global::sys.io.FileOutput __temp_me323, global::System.IO.FileStream stream){
			unchecked {
				global::cs.io.NativeOutput.__hx_ctor_cs_io_NativeOutput(__temp_me323, stream);
			}
		}
		
		
		public static  new object __hx_createEmpty(){
			unchecked {
				return new global::sys.io.FileOutput(((global::haxe.lang.EmptyObject) (global::haxe.lang.EmptyObject.EMPTY) ));
			}
		}
		
		
		public static  new object __hx_create(global::haxe.root.Array arr){
			unchecked {
				return new global::sys.io.FileOutput(((global::System.IO.FileStream) (arr[0]) ));
			}
		}
		
		
	}
}


