using haxe.root;
#pragma warning disable 109, 114, 219, 429, 168, 162
namespace alphatab.platform.sys
{
	public  class SysFileLoader : global::haxe.lang.HxObject, global::alphatab.platform.IFileLoader 
	{
		public    SysFileLoader(global::haxe.lang.EmptyObject empty)
		{
			unchecked 
			{
				{
				}
				
			}
		}
		
		
		public    SysFileLoader()
		{
			unchecked 
			{
				global::alphatab.platform.sys.SysFileLoader.__hx_ctor_alphatab_platform_sys_SysFileLoader(this);
			}
		}
		
		
		public static   void __hx_ctor_alphatab_platform_sys_SysFileLoader(global::alphatab.platform.sys.SysFileLoader __temp_me23)
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
				return new global::alphatab.platform.sys.SysFileLoader(((global::haxe.lang.EmptyObject) (global::haxe.lang.EmptyObject.EMPTY) ));
			}
		}
		
		
		public static  new object __hx_create(global::haxe.root.Array arr)
		{
			unchecked 
			{
				return new global::alphatab.platform.sys.SysFileLoader();
			}
		}
		
		
		public virtual   global::haxe.io.Bytes loadBinary(string path)
		{
			unchecked 
			{
				return global::sys.io.File.getBytes(path);
			}
		}
		
		
		public virtual   void loadBinaryAsync(string path, global::haxe.lang.Function success, global::haxe.lang.Function error)
		{
			unchecked 
			{
				try 
				{
					success.__hx_invoke1_o(default(double), this.loadBinary(path));
				}
				catch (global::System.Exception __temp_catchallException476)
				{
					object __temp_catchall477 = __temp_catchallException476;
					if (( __temp_catchall477 is global::haxe.lang.HaxeException )) 
					{
						__temp_catchall477 = ((global::haxe.lang.HaxeException) (__temp_catchallException476) ).obj;
					}
					
					{
						object e = __temp_catchall477;
						error.__hx_invoke1_o(default(double), global::Std.@string(e));
					}
					
				}
				
				
			}
		}
		
		
		public override   object __hx_getField(string field, int hash, bool throwErrors, bool isCheck, bool handleProperties)
		{
			unchecked 
			{
				switch (hash)
				{
					case 1726550773:
					{
						return ((global::haxe.lang.Function) (new global::haxe.lang.Closure(((object) (this) ), global::haxe.lang.Runtime.toString("loadBinaryAsync"), ((int) (1726550773) ))) );
					}
					
					
					case 574024391:
					{
						return ((global::haxe.lang.Function) (new global::haxe.lang.Closure(((object) (this) ), global::haxe.lang.Runtime.toString("loadBinary"), ((int) (574024391) ))) );
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
					case 1726550773:
					{
						this.loadBinaryAsync(global::haxe.lang.Runtime.toString(dynargs[0]), ((global::haxe.lang.Function) (dynargs[1]) ), ((global::haxe.lang.Function) (dynargs[2]) ));
						break;
					}
					
					
					case 574024391:
					{
						return this.loadBinary(global::haxe.lang.Runtime.toString(dynargs[0]));
					}
					
					
					default:
					{
						return base.__hx_invokeField(field, hash, dynargs);
					}
					
				}
				
				return default(object);
			}
		}
		
		
	}
}


