using haxe.root;
#pragma warning disable 109, 114, 219, 429, 168, 162
namespace cs{
	public  class Lib : global::haxe.lang.HxObject {
		public    Lib(global::haxe.lang.EmptyObject empty){
			unchecked {
				{
				}
				
			}
		}
		
		
		public    Lib(){
			unchecked {
				global::cs.Lib.__hx_ctor_cs_Lib(this);
			}
		}
		
		
		public static   void __hx_ctor_cs_Lib(global::cs.Lib __temp_me298){
			unchecked {
				{
				}
				
			}
		}
		
		
		public static  string decimalSeparator;
		
		public static   void applyCultureChanges(){
			
			System.Globalization.CultureInfo ci = new System.Globalization.CultureInfo(System.Threading.Thread.CurrentThread.CurrentCulture.Name, true);
			decimalSeparator = ci.NumberFormat.NumberDecimalSeparator;
            ci.NumberFormat.NumberDecimalSeparator = ".";
            System.Threading.Thread.CurrentThread.CurrentCulture = ci;
	
		}
		
		
		public static   global::System.Type nativeType(object obj){
			unchecked {
				return obj.GetType();
			}
		}
		
		
		public static   global::haxe.root.Array<T> array<T>(T[] native){
			unchecked {
				return global::haxe.root.Array<object>.ofNative<T>(native);
			}
		}
		
		
		public static  new object __hx_createEmpty(){
			unchecked {
				return new global::cs.Lib(((global::haxe.lang.EmptyObject) (global::haxe.lang.EmptyObject.EMPTY) ));
			}
		}
		
		
		public static  new object __hx_create(global::haxe.root.Array arr){
			unchecked {
				return new global::cs.Lib();
			}
		}
		
		
	}
}


