using haxe.root;
#pragma warning disable 109, 114, 219, 429, 168, 162
namespace haxe.root{
	public  interface IMap<K, V> : global::haxe.lang.IHxObject, global::haxe.root.IMap {
	}
	public class IMap__Statics_{
		public static   object __hx_cast<K_c_c, V_c_c>(global::haxe.root.IMap me){
			unchecked {
				return ( (( me != default(global::haxe.root.IMap) )) ? (me.IMap_cast<K_c_c, V_c_c>()) : (default(global::haxe.root.IMap)) );
			}
		}
		
		
	}
}



#pragma warning disable 109, 114, 219, 429, 168, 162
namespace haxe.root{
	public  interface IMap : global::haxe.lang.IHxObject, global::haxe.lang.IGenericObject {
		   object IMap_cast<K_c, V_c>();
		
	}
}


