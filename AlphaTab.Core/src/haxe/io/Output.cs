using haxe.root;
#pragma warning disable 109, 114, 219, 429, 168, 162
namespace haxe.io
{
	public  class Output : global::haxe.lang.HxObject 
	{
		public    Output(global::haxe.lang.EmptyObject empty)
		{
			unchecked 
			{
				{
				}
				
			}
		}
		
		
		public    Output()
		{
			unchecked 
			{
				global::haxe.io.Output.__hx_ctor_haxe_io_Output(this);
			}
		}
		
		
		public static   void __hx_ctor_haxe_io_Output(global::haxe.io.Output __temp_me284)
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
				return new global::haxe.io.Output(((global::haxe.lang.EmptyObject) (global::haxe.lang.EmptyObject.EMPTY) ));
			}
		}
		
		
		public static  new object __hx_create(global::haxe.root.Array arr)
		{
			unchecked 
			{
				return new global::haxe.io.Output();
			}
		}
		
		
		public virtual   void writeByte(int c)
		{
			unchecked 
			{
				throw global::haxe.lang.HaxeException.wrap("Not implemented");
			}
		}
		
		
		public virtual   int writeBytes(global::haxe.io.Bytes s, int pos, int len)
		{
			unchecked 
			{
				int k = len;
				byte[] b = s.b;
				if (( ( ( pos < 0 ) || ( len < 0 ) ) || ( ( pos + len ) > s.length ) )) 
				{
					throw global::haxe.lang.HaxeException.wrap(global::haxe.io.Error.OutsideBounds);
				}
				
				while (( k > 0 ))
				{
					this.writeByte(((int) (b[pos]) ));
					pos++;
					k--;
				}
				
				return len;
			}
		}
		
		
		public virtual   void writeFullBytes(global::haxe.io.Bytes s, int pos, int len)
		{
			unchecked 
			{
				while (( len > 0 ))
				{
					int k = this.writeBytes(s, pos, len);
					pos += k;
					len -= k;
				}
				
			}
		}
		
		
		public virtual   void writeString(string s)
		{
			unchecked 
			{
				global::haxe.io.Bytes b = global::haxe.io.Bytes.ofString(s);
				this.writeFullBytes(b, 0, b.length);
			}
		}
		
		
		public override   object __hx_getField(string field, int hash, bool throwErrors, bool isCheck, bool handleProperties)
		{
			unchecked 
			{
				switch (hash)
				{
					case 640252688:
					{
						return ((global::haxe.lang.Function) (new global::haxe.lang.Closure(((object) (this) ), global::haxe.lang.Runtime.toString("writeString"), ((int) (640252688) ))) );
					}
					
					
					case 610723709:
					{
						return ((global::haxe.lang.Function) (new global::haxe.lang.Closure(((object) (this) ), global::haxe.lang.Runtime.toString("writeFullBytes"), ((int) (610723709) ))) );
					}
					
					
					case 1381630732:
					{
						return ((global::haxe.lang.Function) (new global::haxe.lang.Closure(((object) (this) ), global::haxe.lang.Runtime.toString("writeBytes"), ((int) (1381630732) ))) );
					}
					
					
					case 1238832007:
					{
						return ((global::haxe.lang.Function) (new global::haxe.lang.Closure(((object) (this) ), global::haxe.lang.Runtime.toString("writeByte"), ((int) (1238832007) ))) );
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
					case 640252688:
					{
						this.writeString(global::haxe.lang.Runtime.toString(dynargs[0]));
						break;
					}
					
					
					case 610723709:
					{
						this.writeFullBytes(((global::haxe.io.Bytes) (dynargs[0]) ), ((int) (global::haxe.lang.Runtime.toInt(dynargs[1])) ), ((int) (global::haxe.lang.Runtime.toInt(dynargs[2])) ));
						break;
					}
					
					
					case 1381630732:
					{
						return this.writeBytes(((global::haxe.io.Bytes) (dynargs[0]) ), ((int) (global::haxe.lang.Runtime.toInt(dynargs[1])) ), ((int) (global::haxe.lang.Runtime.toInt(dynargs[2])) ));
					}
					
					
					case 1238832007:
					{
						this.writeByte(((int) (global::haxe.lang.Runtime.toInt(dynargs[0])) ));
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
		
		
	}
}


