using haxe.root;
#pragma warning disable 109, 114, 219, 429, 168, 162
namespace haxe.root{
	public  class Lambda : global::haxe.lang.HxObject {
		public    Lambda(global::haxe.lang.EmptyObject empty){
			unchecked {
				{
				}
				
			}
		}
		
		
		public    Lambda(){
			unchecked {
				global::haxe.root.Lambda.__hx_ctor__Lambda(this);
			}
		}
		
		
		public static   void __hx_ctor__Lambda(global::haxe.root.Lambda __temp_me7){
			unchecked {
				{
				}
				
			}
		}
		
		
		public static   bool has<A>(object it, A elt){
			unchecked {
				{
					object __temp_iterator326 = ((object) (global::haxe.lang.Runtime.callField(it, "iterator", 328878574, default(global::haxe.root.Array))) );
					while (global::haxe.lang.Runtime.toBool(global::haxe.lang.Runtime.callField(__temp_iterator326, "hasNext", 407283053, default(global::haxe.root.Array)))){
						A x = global::haxe.lang.Runtime.genericCast<A>(global::haxe.lang.Runtime.callField(__temp_iterator326, "next", 1224901875, default(global::haxe.root.Array)));
						if (global::haxe.lang.Runtime.eq(x, elt)) {
							return true;
						}
						
					}
					
				}
				
				return false;
			}
		}
		
		
		public static   int indexOf<T>(object it, T v){
			unchecked {
				int i = 0;
				{
					object __temp_iterator327 = ((object) (global::haxe.lang.Runtime.callField(it, "iterator", 328878574, default(global::haxe.root.Array))) );
					while (global::haxe.lang.Runtime.toBool(global::haxe.lang.Runtime.callField(__temp_iterator327, "hasNext", 407283053, default(global::haxe.root.Array)))){
						T v2 = global::haxe.lang.Runtime.genericCast<T>(global::haxe.lang.Runtime.callField(__temp_iterator327, "next", 1224901875, default(global::haxe.root.Array)));
						if (global::haxe.lang.Runtime.eq(v, v2)) {
							return i;
						}
						
						i++;
					}
					
				}
				
				return -1;
			}
		}
		
		
		public static  new object __hx_createEmpty(){
			unchecked {
				return new global::haxe.root.Lambda(((global::haxe.lang.EmptyObject) (global::haxe.lang.EmptyObject.EMPTY) ));
			}
		}
		
		
		public static  new object __hx_create(global::haxe.root.Array arr){
			unchecked {
				return new global::haxe.root.Lambda();
			}
		}
		
		
	}
}


