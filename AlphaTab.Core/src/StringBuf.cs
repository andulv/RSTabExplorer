using haxe.root;
#pragma warning disable 109, 114, 219, 429, 168, 162
namespace haxe.root
{
	public  class StringBuf : global::haxe.lang.HxObject 
	{
		public    StringBuf(global::haxe.lang.EmptyObject empty)
		{
			unchecked 
			{
				{
				}
				
			}
		}
		
		
		public    StringBuf()
		{
			unchecked 
			{
				global::haxe.root.StringBuf.__hx_ctor__StringBuf(this);
			}
		}
		
		
		public static   void __hx_ctor__StringBuf(global::haxe.root.StringBuf __temp_me8)
		{
			unchecked 
			{
				__temp_me8.b = new global::System.Text.StringBuilder();
			}
		}
		
		
		public static  new object __hx_createEmpty()
		{
			unchecked 
			{
				return new global::haxe.root.StringBuf(((global::haxe.lang.EmptyObject) (global::haxe.lang.EmptyObject.EMPTY) ));
			}
		}
		
		
		public static  new object __hx_create(global::haxe.root.Array arr)
		{
			unchecked 
			{
				return new global::haxe.root.StringBuf();
			}
		}
		
		
		public  global::System.Text.StringBuilder b;
		
		public virtual   void addSub(string s, int pos, global::haxe.lang.Null<int> len)
		{
			unchecked 
			{
				int l = default(int);
				if (global::haxe.lang.Runtime.eq((len).toDynamic(), (default(global::haxe.lang.Null<int>)).toDynamic())) 
				{
					l = ( s.Length - pos );
				}
				 else 
				{
					l = len.@value;
				}
				
				this.b.Append(global::haxe.lang.Runtime.toString(s), ((int) (pos) ), ((int) (l) ));
			}
		}
		
		
		public virtual   string toString()
		{
			unchecked 
			{
				return this.b.ToString();
			}
		}
		
		
		public override   object __hx_setField(string field, int hash, object @value, bool handleProperties)
		{
			unchecked 
			{
				switch (hash)
				{
					case 98:
					{
						this.b = ((global::System.Text.StringBuilder) (@value) );
						return @value;
					}
					
					
					default:
					{
						return base.__hx_setField(field, hash, @value, handleProperties);
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
					case 946786476:
					{
						return ((global::haxe.lang.Function) (new global::haxe.lang.Closure(((object) (this) ), global::haxe.lang.Runtime.toString("toString"), ((int) (946786476) ))) );
					}
					
					
					case 520665567:
					{
						return ((global::haxe.lang.Function) (new global::haxe.lang.Closure(((object) (this) ), global::haxe.lang.Runtime.toString("addSub"), ((int) (520665567) ))) );
					}
					
					
					case 98:
					{
						return this.b;
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
					
					
					case 520665567:
					{
						this.addSub(global::haxe.lang.Runtime.toString(dynargs[0]), ((int) (global::haxe.lang.Runtime.toInt(dynargs[1])) ), global::haxe.lang.Null<object>.ofDynamic<int>(dynargs[2]));
						break;
					}
					
					
					default:
					{
						return base.__hx_invokeField(field, hash, dynargs);
					}
					
				}
				
				return default(object);
			}
		}
		
		
		public override   void __hx_getFields(global::haxe.root.Array<object> baseArr)
		{
			unchecked 
			{
				baseArr.push("b");
				{
					base.__hx_getFields(baseArr);
				}
				
			}
		}
		
		
		public override string ToString()
		{
			return this.toString();
		}
		
		
	}
}


