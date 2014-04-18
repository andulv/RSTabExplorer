using haxe.root;
#pragma warning disable 109, 114, 219, 429, 168, 162
namespace haxe.root
{
	public  class Lambda : global::haxe.lang.HxObject 
	{
		public    Lambda(global::haxe.lang.EmptyObject empty)
		{
			unchecked 
			{
				{
				}
				
			}
		}
		
		
		public    Lambda()
		{
			unchecked 
			{
				global::haxe.root.Lambda.__hx_ctor__Lambda(this);
			}
		}
		
		
		public static   void __hx_ctor__Lambda(global::haxe.root.Lambda __temp_me6)
		{
			unchecked 
			{
				{
				}
				
			}
		}
		
		
		public static   bool has<A>(object it, A elt)
		{
			unchecked 
			{
				{
					object __temp_iterator300 = ((object) (global::haxe.lang.Runtime.callField(it, "iterator", 328878574, default(global::haxe.root.Array))) );
					while (((bool) (global::haxe.lang.Runtime.callField(__temp_iterator300, "hasNext", 407283053, default(global::haxe.root.Array))) ))
					{
						A x = global::haxe.lang.Runtime.genericCast<A>(global::haxe.lang.Runtime.callField(__temp_iterator300, "next", 1224901875, default(global::haxe.root.Array)));
						if (global::haxe.lang.Runtime.eq(x, elt)) 
						{
							return true;
						}
						
					}
					
				}
				
				return false;
			}
		}
		
		
		public static  new object __hx_createEmpty()
		{
			unchecked 
			{
				return new global::haxe.root.Lambda(((global::haxe.lang.EmptyObject) (global::haxe.lang.EmptyObject.EMPTY) ));
			}
		}
		
		
		public static  new object __hx_create(global::haxe.root.Array arr)
		{
			unchecked 
			{
				return new global::haxe.root.Lambda();
			}
		}
		
		
	}
}


