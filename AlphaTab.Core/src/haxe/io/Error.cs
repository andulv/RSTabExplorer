using haxe.root;
#pragma warning disable 109, 114, 219, 429, 168, 162
namespace haxe.io
{
	public  class Error : global::haxe.lang.Enum 
	{
		static Error() 
		{
			global::haxe.io.Error.constructs = new global::haxe.root.Array<object>(new object[]{"Blocked", "Overflow", "OutsideBounds", "Custom"});
			global::haxe.io.Error.Blocked = new global::haxe.io.Error(((int) (0) ), ((global::haxe.root.Array<object>) (global::haxe.root.Array<object>.__hx_cast<object>(((global::haxe.root.Array) (new global::haxe.root.Array<object>(new object[]{})) ))) ));
			global::haxe.io.Error.Overflow = new global::haxe.io.Error(((int) (1) ), ((global::haxe.root.Array<object>) (global::haxe.root.Array<object>.__hx_cast<object>(((global::haxe.root.Array) (new global::haxe.root.Array<object>(new object[]{})) ))) ));
			global::haxe.io.Error.OutsideBounds = new global::haxe.io.Error(((int) (2) ), ((global::haxe.root.Array<object>) (global::haxe.root.Array<object>.__hx_cast<object>(((global::haxe.root.Array) (new global::haxe.root.Array<object>(new object[]{})) ))) ));
		}
		public    Error(global::haxe.lang.EmptyObject empty) : base(global::haxe.lang.EmptyObject.EMPTY)
		{
			unchecked 
			{
			}
		}
		
		
		public    Error(int index, global::haxe.root.Array<object> @params) : base(index, @params)
		{
			unchecked 
			{
			}
		}
		
		
		public static  global::haxe.root.Array<object> constructs;
		
		public static  global::haxe.io.Error Blocked;
		
		public static  global::haxe.io.Error Overflow;
		
		public static  global::haxe.io.Error OutsideBounds;
		
		public static   global::haxe.io.Error Custom(object e)
		{
			unchecked 
			{
				return new global::haxe.io.Error(((int) (3) ), ((global::haxe.root.Array<object>) (global::haxe.root.Array<object>.__hx_cast<object>(((global::haxe.root.Array) (new global::haxe.root.Array<object>(new object[]{e})) ))) ));
			}
		}
		
		
		public static  new object __hx_createEmpty()
		{
			unchecked 
			{
				return new global::haxe.io.Error(((global::haxe.lang.EmptyObject) (global::haxe.lang.EmptyObject.EMPTY) ));
			}
		}
		
		
		public static  new object __hx_create(global::haxe.root.Array arr)
		{
			unchecked 
			{
				return new global::haxe.io.Error(((int) (global::haxe.lang.Runtime.toInt(arr[0])) ), ((global::haxe.root.Array<object>) (global::haxe.root.Array<object>.__hx_cast<object>(((global::haxe.root.Array) (arr[1]) ))) ));
			}
		}
		
		
	}
}


