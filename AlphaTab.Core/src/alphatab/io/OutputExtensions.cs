using haxe.root;
#pragma warning disable 109, 114, 219, 429, 168, 162
namespace alphatab.io{
	public  class OutputExtensions : global::haxe.lang.HxObject {
		public    OutputExtensions(global::haxe.lang.EmptyObject empty){
			unchecked {
				{
				}
				
			}
		}
		
		
		public    OutputExtensions(){
			unchecked {
				global::alphatab.io.OutputExtensions.__hx_ctor_alphatab_io_OutputExtensions(this);
			}
		}
		
		
		public static   void __hx_ctor_alphatab_io_OutputExtensions(global::alphatab.io.OutputExtensions __temp_me85){
			unchecked {
				{
				}
				
			}
		}
		
		
		public static   void writeAsString(global::haxe.io.Output output, object @value){
			unchecked {
				string text = default(string);
				if (( @value is string )) {
					text = global::haxe.lang.Runtime.toString(@value);
				}
				 else {
					text = global::haxe.root.Std.@string(@value);
				}
				
				output.writeString(text);
			}
		}
		
		
		public static  new object __hx_createEmpty(){
			unchecked {
				return new global::alphatab.io.OutputExtensions(((global::haxe.lang.EmptyObject) (global::haxe.lang.EmptyObject.EMPTY) ));
			}
		}
		
		
		public static  new object __hx_create(global::haxe.root.Array arr){
			unchecked {
				return new global::alphatab.io.OutputExtensions();
			}
		}
		
		
	}
}


