using haxe.root;
#pragma warning disable 109, 114, 219, 429, 168, 162
namespace haxe.lang{
	public  interface Iterator<T> : global::haxe.lang.IHxObject, global::haxe.lang.Iterator {
		   bool hasNext();
		
		   T next();
		
	}
	public class Iterator__Statics_{
		public static   object __hx_cast<T_c_c>(global::haxe.lang.Iterator me){
			unchecked {
				return ( (( me != default(global::haxe.lang.Iterator) )) ? (me.haxe_lang_Iterator_cast<T_c_c>()) : (default(global::haxe.lang.Iterator)) );
			}
		}
		
		
	}
}



#pragma warning disable 109, 114, 219, 429, 168, 162
namespace haxe.lang{
	public  interface Iterator : global::haxe.lang.IHxObject, global::haxe.lang.IGenericObject {
		   object haxe_lang_Iterator_cast<T_c>();
		
	}
}



#pragma warning disable 109, 114, 219, 429, 168, 162
namespace haxe.lang{
	public  interface Iterable<T> : global::haxe.lang.IHxObject, global::haxe.lang.Iterable {
		   global::haxe.lang.Iterator<T> iterator();
		
	}
	public class Iterable__Statics_{
		public static   object __hx_cast<T_c_c>(global::haxe.lang.Iterable me){
			unchecked {
				return ( (( me != default(global::haxe.lang.Iterable) )) ? (me.haxe_lang_Iterable_cast<T_c_c>()) : (default(global::haxe.lang.Iterable)) );
			}
		}
		
		
	}
}



#pragma warning disable 109, 114, 219, 429, 168, 162
namespace haxe.lang{
	public  interface Iterable : global::haxe.lang.IHxObject, global::haxe.lang.IGenericObject {
		   object haxe_lang_Iterable_cast<T_c>();
		
	}
}


