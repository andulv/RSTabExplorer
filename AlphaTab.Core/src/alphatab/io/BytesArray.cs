using haxe.root;
#pragma warning disable 109, 114, 219, 429, 168, 162
namespace alphatab.io
{
	public  class BytesArray : global::haxe.lang.HxObject 
	{
		public    BytesArray(global::haxe.lang.EmptyObject empty)
		{
			unchecked 
			{
				{
				}
				
			}
		}
		
		
		public    BytesArray(global::haxe.lang.Null<int> initialSize)
		{
			unchecked 
			{
				global::alphatab.io.BytesArray.__hx_ctor_alphatab_io_BytesArray(this, initialSize);
			}
		}
		
		
		public static   void __hx_ctor_alphatab_io_BytesArray(global::alphatab.io.BytesArray __temp_me70, global::haxe.lang.Null<int> initialSize)
		{
			unchecked 
			{
				int __temp_initialSize69 = ( (global::haxe.lang.Runtime.eq((initialSize).toDynamic(), (default(global::haxe.lang.Null<int>)).toDynamic())) ? (((int) (4) )) : (initialSize.@value) );
				__temp_me70._data = global::haxe.io.Bytes.alloc(__temp_initialSize69);
				__temp_me70.length = 0;
			}
		}
		
		
		public static   global::alphatab.io.BytesArray ofBytes(global::haxe.io.Bytes b)
		{
			unchecked 
			{
				global::alphatab.io.BytesArray a = new global::alphatab.io.BytesArray(((global::haxe.lang.Null<int>) (default(global::haxe.lang.Null<int>)) ));
				a._data = b;
				a.length = a._data.length;
				return a;
			}
		}
		
		
		public static  new object __hx_createEmpty()
		{
			unchecked 
			{
				return new global::alphatab.io.BytesArray(((global::haxe.lang.EmptyObject) (global::haxe.lang.EmptyObject.EMPTY) ));
			}
		}
		
		
		public static  new object __hx_create(global::haxe.root.Array arr)
		{
			unchecked 
			{
				return new global::alphatab.io.BytesArray(global::haxe.lang.Null<object>.ofDynamic<int>(arr[0]));
			}
		}
		
		
		public  global::haxe.io.Bytes _data;
		
		public  int length;
		
		public virtual   int @get(int pos)
		{
			unchecked 
			{
				if (( pos >= this.length )) 
				{
					throw global::haxe.lang.HaxeException.wrap(global::haxe.io.Error.OutsideBounds);
				}
				
				return ((int) (this._data.b[pos]) );
			}
		}
		
		
		public virtual   void @set(int pos, int v)
		{
			unchecked 
			{
				if (( pos >= this.length )) 
				{
					throw global::haxe.lang.HaxeException.wrap(global::haxe.io.Error.OutsideBounds);
				}
				
				this._data.b[pos] = ((byte) (( v & 255 )) );
			}
		}
		
		
		public virtual   global::haxe.io.Bytes sub(int pos, int len)
		{
			unchecked 
			{
				if (( ( ( pos < 0 ) || ( len < 0 ) ) || ( ( pos + len ) > this.length ) )) 
				{
					throw global::haxe.lang.HaxeException.wrap(global::haxe.io.Error.OutsideBounds);
				}
				
				return this._data.sub(pos, len);
			}
		}
		
		
		public virtual   void @add(int v)
		{
			unchecked 
			{
				this.updateCapacity(( this.length + 1 ));
				{
					int pos = this.length++;
					this._data.b[pos] = ((byte) (( v & 255 )) );
				}
				
			}
		}
		
		
		public virtual   void addBytes(global::haxe.io.Bytes v)
		{
			unchecked 
			{
				if (( v.length > 0 )) 
				{
					this.updateCapacity(( this.length + v.length ));
					this._data.blit(this.length, v, 0, v.length);
					this.length += v.length;
				}
				
			}
		}
		
		
		public virtual   global::haxe.io.Bytes getBuffer()
		{
			unchecked 
			{
				return this._data;
			}
		}
		
		
		public virtual   global::haxe.io.Bytes getBytes(global::haxe.lang.Null<int> offset)
		{
			unchecked 
			{
				int __temp_offset68 = ( (global::haxe.lang.Runtime.eq((offset).toDynamic(), (default(global::haxe.lang.Null<int>)).toDynamic())) ? (((int) (0) )) : (offset.@value) );
				global::haxe.io.Bytes copy = global::haxe.io.Bytes.alloc(this.length);
				copy.blit(0, this._data, __temp_offset68, ( this.length - __temp_offset68 ));
				return copy;
			}
		}
		
		
		public virtual   int _get_capacity()
		{
			unchecked 
			{
				return this._data.length;
			}
		}
		
		
		public virtual   void setCapacity(int capacity)
		{
			unchecked 
			{
				global::haxe.io.Bytes newData = global::haxe.io.Bytes.alloc(capacity);
				newData.blit(0, this._data, 0, this._data.length);
				this._data = newData;
			}
		}
		
		
		public virtual   void updateCapacity(int min)
		{
			unchecked 
			{
				if (( min < 0 )) 
				{
					throw global::haxe.lang.HaxeException.wrap(global::haxe.io.Error.Overflow);
				}
				
				if (( this._data.length < min )) 
				{
					int c = default(int);
					{
						double x = global::System.Math.Max(((double) (( this._data.length * 2 )) ), ((double) (min) ));
						c = ((int) (x) );
					}
					
					this.setCapacity(c);
				}
				
			}
		}
		
		
		public override   double __hx_setField_f(string field, int hash, double @value, bool handleProperties)
		{
			unchecked 
			{
				switch (hash)
				{
					case 520590566:
					{
						this.length = ((int) (@value) );
						return @value;
					}
					
					
					default:
					{
						return base.__hx_setField_f(field, hash, @value, handleProperties);
					}
					
				}
				
			}
		}
		
		
		public override   object __hx_setField(string field, int hash, object @value, bool handleProperties)
		{
			unchecked 
			{
				switch (hash)
				{
					case 520590566:
					{
						this.length = ((int) (global::haxe.lang.Runtime.toInt(@value)) );
						return @value;
					}
					
					
					case 1970565641:
					{
						this._data = ((global::haxe.io.Bytes) (@value) );
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
					case 2028270691:
					{
						return ((global::haxe.lang.Function) (new global::haxe.lang.Closure(((object) (this) ), global::haxe.lang.Runtime.toString("updateCapacity"), ((int) (2028270691) ))) );
					}
					
					
					case 1947978492:
					{
						return ((global::haxe.lang.Function) (new global::haxe.lang.Closure(((object) (this) ), global::haxe.lang.Runtime.toString("setCapacity"), ((int) (1947978492) ))) );
					}
					
					
					case 2027205955:
					{
						return ((global::haxe.lang.Function) (new global::haxe.lang.Closure(((object) (this) ), global::haxe.lang.Runtime.toString("get_capacity"), ((int) (2027205955) ))) );
					}
					
					
					case 493819893:
					{
						return ((global::haxe.lang.Function) (new global::haxe.lang.Closure(((object) (this) ), global::haxe.lang.Runtime.toString("getBytes"), ((int) (493819893) ))) );
					}
					
					
					case 1290487350:
					{
						return ((global::haxe.lang.Function) (new global::haxe.lang.Closure(((object) (this) ), global::haxe.lang.Runtime.toString("getBuffer"), ((int) (1290487350) ))) );
					}
					
					
					case 922037898:
					{
						return ((global::haxe.lang.Function) (new global::haxe.lang.Closure(((object) (this) ), global::haxe.lang.Runtime.toString("addBytes"), ((int) (922037898) ))) );
					}
					
					
					case 4846113:
					{
						return ((global::haxe.lang.Function) (new global::haxe.lang.Closure(((object) (this) ), global::haxe.lang.Runtime.toString("add"), ((int) (4846113) ))) );
					}
					
					
					case 5745024:
					{
						return ((global::haxe.lang.Function) (new global::haxe.lang.Closure(((object) (this) ), global::haxe.lang.Runtime.toString("sub"), ((int) (5745024) ))) );
					}
					
					
					case 5741474:
					{
						return ((global::haxe.lang.Function) (new global::haxe.lang.Closure(((object) (this) ), global::haxe.lang.Runtime.toString("set"), ((int) (5741474) ))) );
					}
					
					
					case 5144726:
					{
						return ((global::haxe.lang.Function) (new global::haxe.lang.Closure(((object) (this) ), global::haxe.lang.Runtime.toString("get"), ((int) (5144726) ))) );
					}
					
					
					case 520590566:
					{
						return this.length;
					}
					
					
					case 1136329018:
					{
						return this._get_capacity();
					}
					
					
					case 1970565641:
					{
						return this._data;
					}
					
					
					default:
					{
						return base.__hx_getField(field, hash, throwErrors, isCheck, handleProperties);
					}
					
				}
				
			}
		}
		
		
		public override   double __hx_getField_f(string field, int hash, bool throwErrors, bool handleProperties)
		{
			unchecked 
			{
				switch (hash)
				{
					case 520590566:
					{
						return ((double) (this.length) );
					}
					
					
					case 1136329018:
					{
						return ((double) (this._get_capacity()) );
					}
					
					
					default:
					{
						return base.__hx_getField_f(field, hash, throwErrors, handleProperties);
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
					case 2028270691:
					{
						this.updateCapacity(((int) (global::haxe.lang.Runtime.toInt(dynargs[0])) ));
						break;
					}
					
					
					case 1947978492:
					{
						this.setCapacity(((int) (global::haxe.lang.Runtime.toInt(dynargs[0])) ));
						break;
					}
					
					
					case 2027205955:
					{
						return this._get_capacity();
					}
					
					
					case 493819893:
					{
						return this.getBytes(global::haxe.lang.Null<object>.ofDynamic<int>(dynargs[0]));
					}
					
					
					case 1290487350:
					{
						return this.getBuffer();
					}
					
					
					case 922037898:
					{
						this.addBytes(((global::haxe.io.Bytes) (dynargs[0]) ));
						break;
					}
					
					
					case 4846113:
					{
						this.@add(((int) (global::haxe.lang.Runtime.toInt(dynargs[0])) ));
						break;
					}
					
					
					case 5745024:
					{
						return this.sub(((int) (global::haxe.lang.Runtime.toInt(dynargs[0])) ), ((int) (global::haxe.lang.Runtime.toInt(dynargs[1])) ));
					}
					
					
					case 5741474:
					{
						this.@set(((int) (global::haxe.lang.Runtime.toInt(dynargs[0])) ), ((int) (global::haxe.lang.Runtime.toInt(dynargs[1])) ));
						break;
					}
					
					
					case 5144726:
					{
						return this.@get(((int) (global::haxe.lang.Runtime.toInt(dynargs[0])) ));
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
				baseArr.push("length");
				baseArr.push("capacity");
				baseArr.push("_data");
				{
					base.__hx_getFields(baseArr);
				}
				
			}
		}
		
		
		public   int capacity
		{
			get { return _get_capacity(); }
		}
	}
}


