using haxe.root;
#pragma warning disable 109, 114, 219, 429, 168, 162
namespace haxe
{
	public  class Log : global::haxe.lang.HxObject 
	{
		static Log() 
		{
			global::haxe.Log.trace = ( (( global::haxe.Log_new_45__Fun.__hx_current != default(global::haxe.Log_new_45__Fun) )) ? (global::haxe.Log_new_45__Fun.__hx_current) : (global::haxe.Log_new_45__Fun.__hx_current = ((global::haxe.Log_new_45__Fun) (new global::haxe.Log_new_45__Fun()) )) );
		}
		public    Log(global::haxe.lang.EmptyObject empty)
		{
			unchecked 
			{
				{
				}
				
			}
		}
		
		
		public    Log()
		{
			unchecked 
			{
				global::haxe.Log.__hx_ctor_haxe_Log(this);
			}
		}
		
		
		public static   void __hx_ctor_haxe_Log(global::haxe.Log __temp_me285)
		{
			unchecked 
			{
				{
				}
				
			}
		}
		
		
		public static  global::haxe.lang.Function trace;
		
		public static  new object __hx_createEmpty()
		{
			unchecked 
			{
				return new global::haxe.Log(((global::haxe.lang.EmptyObject) (global::haxe.lang.EmptyObject.EMPTY) ));
			}
		}
		
		
		public static  new object __hx_create(global::haxe.root.Array arr)
		{
			unchecked 
			{
				return new global::haxe.Log();
			}
		}
		
		
	}
}



#pragma warning disable 109, 114, 219, 429, 168, 162
namespace haxe
{
	public  class Log_new_45__Fun : global::haxe.lang.Function 
	{
		public    Log_new_45__Fun() : base(2, 0)
		{
			unchecked 
			{
			}
		}
		
		
		public static  global::haxe.Log_new_45__Fun __hx_current;
		
		public override   object __hx_invoke2_o(double __fn_float1, double __fn_float2, object __fn_dyn1, object __fn_dyn2)
		{
			unchecked 
			{
				object infos = ( (global::haxe.lang.Runtime.eq(__fn_dyn2, global::haxe.lang.Runtime.undefined)) ? (((object) (__fn_float2) )) : (( (global::haxe.lang.Runtime.eq(__fn_dyn2, default(object))) ? (default(object)) : (((object) (__fn_dyn2) )) )) );
				object v = ( (global::haxe.lang.Runtime.eq(__fn_dyn1, global::haxe.lang.Runtime.undefined)) ? (((object) (__fn_float1) )) : (((object) (__fn_dyn1) )) );
				string str = default(string);
				if (( ! (global::haxe.lang.Runtime.refEq(infos, default(object))) )) 
				{
					str = global::haxe.lang.Runtime.concat(global::haxe.lang.Runtime.concat(global::haxe.lang.Runtime.concat(global::haxe.lang.Runtime.concat(global::haxe.lang.Runtime.toString(global::haxe.lang.Runtime.getField(infos, "fileName", 1648581351, true)), ":"), global::haxe.lang.Runtime.toString(((int) (global::haxe.lang.Runtime.getField_f(infos, "lineNumber", 1981972957, true)) ))), ": "), global::Std.@string(v));
					if (( ((global::haxe.root.Array) (global::haxe.lang.Runtime.getField(infos, "customParams", 1830310359, true)) ) != default(global::haxe.root.Array) )) 
					{
						str = global::haxe.lang.Runtime.concat(str, global::haxe.lang.Runtime.concat(",", global::haxe.lang.Runtime.toString(global::haxe.lang.Runtime.callField(((global::haxe.root.Array) (global::haxe.lang.Runtime.getField(infos, "customParams", 1830310359, true)) ), "join", 1181037546, new global::haxe.root.Array<object>(new object[]{","})))));
					}
					
				}
				 else 
				{
					str = global::haxe.lang.Runtime.toString(v);
				}
				
				System.Console.WriteLine(str);
				return default(object);
			}
		}
		
		
	}
}


