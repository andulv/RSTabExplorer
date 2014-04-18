using haxe.root;
#pragma warning disable 109, 114, 219, 429, 168, 162
namespace haxe.io
{
	public  class Eof : global::haxe.lang.HxObject 
	{
		public    Eof(global::haxe.lang.EmptyObject empty)
		{
			unchecked 
			{
				{
				}
				
			}
		}
		
		
		public    Eof()
		{
			unchecked 
			{
				global::haxe.io.Eof.__hx_ctor_haxe_io_Eof(this);
			}
		}
		
		
		public static   void __hx_ctor_haxe_io_Eof(global::haxe.io.Eof __temp_me293)
		{
			unchecked 
			{
				{
				}
				
			}
		}
		
		
		public static  new object __hx_createEmpty()
		{
			unchecked 
			{
				return new global::haxe.io.Eof(((global::haxe.lang.EmptyObject) (global::haxe.lang.EmptyObject.EMPTY) ));
			}
		}
		
		
		public static  new object __hx_create(global::haxe.root.Array arr)
		{
			unchecked 
			{
				return new global::haxe.io.Eof();
			}
		}
		
		
		public virtual   string toString()
		{
			unchecked 
			{
				return "Eof";
			}
		}
		
		
		public override   object __hx_getField(string field, int hash, bool throwErrors, bool isCheck, bool handleProperties)
		{
			unchecked 
			{
				switch (hash)
				{
					case 946786476:
					{
						return ((global::haxe.lang.Function) (new global::haxe.lang.Closure(((object) (this) ), global::haxe.lang.Runtime.toString("toString"), ((int) (946786476) ))) );
					}
					
					
					default:
					{
						return base.__hx_getField(field, hash, throwErrors, isCheck, handleProperties);
					}
					
				}
				
			}
		}
		
		
		public override   object __hx_invokeField(string field, int hash, global::haxe.root.Array dynargs)
		{
			unchecked 
			{
				switch (hash)
				{
					case 946786476:
					{
						return this.toString();
					}
					
					
					default:
					{
						return base.__hx_invokeField(field, hash, dynargs);
					}
					
				}
				
			}
		}
		
		
		public override string ToString()
		{
			return this.toString();
		}
		
		
	}
}


