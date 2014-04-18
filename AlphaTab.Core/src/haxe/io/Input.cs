using haxe.root;
#pragma warning disable 109, 114, 219, 429, 168, 162
namespace haxe.io
{
	public  class Input : global::haxe.lang.HxObject 
	{
		public    Input(global::haxe.lang.EmptyObject empty)
		{
			unchecked 
			{
				{
				}
				
			}
		}
		
		
		public    Input()
		{
			unchecked 
			{
				global::haxe.io.Input.__hx_ctor_haxe_io_Input(this);
			}
		}
		
		
		public static   void __hx_ctor_haxe_io_Input(global::haxe.io.Input __temp_me66)
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
				return new global::haxe.io.Input(((global::haxe.lang.EmptyObject) (global::haxe.lang.EmptyObject.EMPTY) ));
			}
		}
		
		
		public static  new object __hx_create(global::haxe.root.Array arr)
		{
			unchecked 
			{
				return new global::haxe.io.Input();
			}
		}
		
		
		public  bool bigEndian;
		
		public virtual   int readByte()
		{
			unchecked 
			{
				throw global::haxe.lang.HaxeException.wrap("Not implemented");
			}
		}
		
		
		public virtual   int readBytes(global::haxe.io.Bytes s, int pos, int len)
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
					b[pos] = ((byte) (this.readByte()) );
					pos++;
					k--;
				}
				
				return len;
			}
		}
		
		
		public virtual   global::haxe.io.Bytes readAll(global::haxe.lang.Null<int> bufsize)
		{
			unchecked 
			{
				if (global::haxe.lang.Runtime.eq((bufsize).toDynamic(), (default(global::haxe.lang.Null<int>)).toDynamic())) 
				{
					bufsize = new global::haxe.lang.Null<int>(new global::haxe.lang.Null<int>(16384, true).@value, true);
				}
				
				global::haxe.io.Bytes buf = global::haxe.io.Bytes.alloc(bufsize.@value);
				global::haxe.io.BytesBuffer total = new global::haxe.io.BytesBuffer();
				try 
				{
					while (true)
					{
						int len = this.readBytes(buf, 0, bufsize.@value);
						if (( len == 0 )) 
						{
							throw global::haxe.lang.HaxeException.wrap(global::haxe.io.Error.Blocked);
						}
						
						{
							if (( ( len < 0 ) || ( len > buf.length ) )) 
							{
								throw global::haxe.lang.HaxeException.wrap(global::haxe.io.Error.OutsideBounds);
							}
							
							( total.b as global::System.IO.Stream ).Write(((byte[]) (buf.b) ), ((int) (0) ), ((int) (len) ));
						}
						
					}
					
				}
				catch (global::System.Exception __temp_catchallException512)
				{
					object __temp_catchall513 = __temp_catchallException512;
					if (( __temp_catchall513 is global::haxe.lang.HaxeException )) 
					{
						__temp_catchall513 = ((global::haxe.lang.HaxeException) (__temp_catchallException512) ).obj;
					}
					
					if (( __temp_catchall513 is global::haxe.io.Eof )) 
					{
						global::haxe.io.Eof e = ((global::haxe.io.Eof) (__temp_catchall513) );
						{
							{
							}
							
						}
						
					}
					 else 
					{
						throw;
					}
					
				}
				
				
				return total.getBytes();
			}
		}
		
		
		public virtual   void readFullBytes(global::haxe.io.Bytes s, int pos, int len)
		{
			unchecked 
			{
				while (( len > 0 ))
				{
					int k = this.readBytes(s, pos, len);
					pos += k;
					len -= k;
				}
				
			}
		}
		
		
		public virtual   global::haxe.io.Bytes read(int nbytes)
		{
			unchecked 
			{
				global::haxe.io.Bytes s = global::haxe.io.Bytes.alloc(nbytes);
				int p = 0;
				while (( nbytes > 0 ))
				{
					int k = this.readBytes(s, p, nbytes);
					if (( k == 0 )) 
					{
						throw global::haxe.lang.HaxeException.wrap(global::haxe.io.Error.Blocked);
					}
					
					p += k;
					nbytes -= k;
				}
				
				return s;
			}
		}
		
		
		public virtual   int readInt8()
		{
			unchecked 
			{
				int n = this.readByte();
				if (( n >= 128 )) 
				{
					return ( n - 256 );
				}
				
				return n;
			}
		}
		
		
		public virtual   int readInt32()
		{
			unchecked 
			{
				int ch1 = this.readByte();
				int ch2 = this.readByte();
				int ch3 = this.readByte();
				int ch4 = this.readByte();
				if (this.bigEndian) 
				{
					return ( ( ( ch4 | ( ch3 << 8 ) ) | ( ch2 << 16 ) ) | ( ch1 << 24 ) );
				}
				 else 
				{
					return ( ( ( ch1 | ( ch2 << 8 ) ) | ( ch3 << 16 ) ) | ( ch4 << 24 ) );
				}
				
			}
		}
		
		
		public virtual   string readString(int len)
		{
			unchecked 
			{
				global::haxe.io.Bytes b = global::haxe.io.Bytes.alloc(len);
				this.readFullBytes(b, 0, len);
				return b.toString();
			}
		}
		
		
		public override   object __hx_getField(string field, int hash, bool throwErrors, bool isCheck, bool handleProperties)
		{
			unchecked 
			{
				switch (hash)
				{
					case 179047623:
					{
						return ((global::haxe.lang.Function) (new global::haxe.lang.Closure(((object) (this) ), global::haxe.lang.Runtime.toString("readString"), ((int) (179047623) ))) );
					}
					
					
					case 252174360:
					{
						return ((global::haxe.lang.Function) (new global::haxe.lang.Closure(((object) (this) ), global::haxe.lang.Runtime.toString("readInt32"), ((int) (252174360) ))) );
					}
					
					
					case 1840455391:
					{
						return ((global::haxe.lang.Function) (new global::haxe.lang.Closure(((object) (this) ), global::haxe.lang.Runtime.toString("readInt8"), ((int) (1840455391) ))) );
					}
					
					
					case 1269254998:
					{
						return ((global::haxe.lang.Function) (new global::haxe.lang.Closure(((object) (this) ), global::haxe.lang.Runtime.toString("read"), ((int) (1269254998) ))) );
					}
					
					
					case 1309344294:
					{
						return ((global::haxe.lang.Function) (new global::haxe.lang.Closure(((object) (this) ), global::haxe.lang.Runtime.toString("readFullBytes"), ((int) (1309344294) ))) );
					}
					
					
					case 46374763:
					{
						return ((global::haxe.lang.Function) (new global::haxe.lang.Closure(((object) (this) ), global::haxe.lang.Runtime.toString("readAll"), ((int) (46374763) ))) );
					}
					
					
					case 243225909:
					{
						return ((global::haxe.lang.Function) (new global::haxe.lang.Closure(((object) (this) ), global::haxe.lang.Runtime.toString("readBytes"), ((int) (243225909) ))) );
					}
					
					
					case 1763375486:
					{
						return ((global::haxe.lang.Function) (new global::haxe.lang.Closure(((object) (this) ), global::haxe.lang.Runtime.toString("readByte"), ((int) (1763375486) ))) );
					}
					
					
					case 542823803:
					{
						return this.bigEndian;
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
					case 179047623:
					{
						return this.readString(((int) (global::haxe.lang.Runtime.toInt(dynargs[0])) ));
					}
					
					
					case 252174360:
					{
						return this.readInt32();
					}
					
					
					case 1840455391:
					{
						return this.readInt8();
					}
					
					
					case 1269254998:
					{
						return this.read(((int) (global::haxe.lang.Runtime.toInt(dynargs[0])) ));
					}
					
					
					case 1309344294:
					{
						this.readFullBytes(((global::haxe.io.Bytes) (dynargs[0]) ), ((int) (global::haxe.lang.Runtime.toInt(dynargs[1])) ), ((int) (global::haxe.lang.Runtime.toInt(dynargs[2])) ));
						break;
					}
					
					
					case 46374763:
					{
						return this.readAll(global::haxe.lang.Null<object>.ofDynamic<int>(dynargs[0]));
					}
					
					
					case 243225909:
					{
						return this.readBytes(((global::haxe.io.Bytes) (dynargs[0]) ), ((int) (global::haxe.lang.Runtime.toInt(dynargs[1])) ), ((int) (global::haxe.lang.Runtime.toInt(dynargs[2])) ));
					}
					
					
					case 1763375486:
					{
						return this.readByte();
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
				baseArr.push("bigEndian");
				{
					base.__hx_getFields(baseArr);
				}
				
			}
		}
		
		
	}
}


