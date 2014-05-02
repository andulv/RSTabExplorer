using haxe.root;
#pragma warning disable 109, 114, 219, 429, 168, 162
namespace sys.io{
	public  class File : global::haxe.lang.HxObject {
		public    File(global::haxe.lang.EmptyObject empty){
			unchecked {
				{
				}
				
			}
		}
		
		
		public    File(){
			unchecked {
				global::sys.io.File.__hx_ctor_sys_io_File(this);
			}
		}
		
		
		public static   void __hx_ctor_sys_io_File(global::sys.io.File __temp_me321){
			unchecked {
				{
				}
				
			}
		}
		
		
		public static   global::haxe.io.Bytes getBytes(string path){
			unchecked {
				global::sys.io.FileInput f = global::sys.io.File.read(path, new global::haxe.lang.Null<bool>(true, true));
				global::haxe.io.Bytes ret = f.readAll(default(global::haxe.lang.Null<int>));
				f.close();
				return ret;
			}
		}
		
		
		public static   global::sys.io.FileInput read(string path, global::haxe.lang.Null<bool> binary){
			unchecked {
				bool __temp_binary319 = ( ( ! (binary.hasValue) ) ? (global::haxe.lang.Runtime.toBool(true)) : (binary.@value) );
				global::System.IO.FileStream stream = new global::System.IO.FileStream(((string) (path) ), ((global::System.IO.FileMode) (global::System.IO.FileMode.Open) ), ((global::System.IO.FileAccess) (global::System.IO.FileAccess.Read) ), ((global::System.IO.FileShare) (global::System.IO.FileShare.ReadWrite) ));
				return new global::sys.io.FileInput(((global::System.IO.FileStream) (stream) ));
			}
		}
		
		
		public static   global::sys.io.FileOutput write(string path, global::haxe.lang.Null<bool> binary){
			unchecked {
				bool __temp_binary320 = ( ( ! (binary.hasValue) ) ? (global::haxe.lang.Runtime.toBool(true)) : (binary.@value) );
				global::System.IO.FileStream stream = new global::System.IO.FileStream(((string) (path) ), ((global::System.IO.FileMode) (global::System.IO.FileMode.Create) ), ((global::System.IO.FileAccess) (global::System.IO.FileAccess.Write) ), ((global::System.IO.FileShare) (global::System.IO.FileShare.ReadWrite) ));
				return new global::sys.io.FileOutput(((global::System.IO.FileStream) (stream) ));
			}
		}
		
		
		public static  new object __hx_createEmpty(){
			unchecked {
				return new global::sys.io.File(((global::haxe.lang.EmptyObject) (global::haxe.lang.EmptyObject.EMPTY) ));
			}
		}
		
		
		public static  new object __hx_create(global::haxe.root.Array arr){
			unchecked {
				return new global::sys.io.File();
			}
		}
		
		
	}
}


