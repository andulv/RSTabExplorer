using haxe.root;
#pragma warning disable 109, 114, 219, 429, 168, 162
namespace alphatab.io
{
	public  class BitInput : global::haxe.io.Input 
	{
		static BitInput() 
		{
			global::alphatab.io.BitInput.ByteSize = 8;
		}
		public    BitInput(global::haxe.lang.EmptyObject empty) : base(((global::haxe.lang.EmptyObject) (global::haxe.lang.EmptyObject.EMPTY) ))
		{
			unchecked 
			{
			}
		}
		
		
		public    BitInput(global::haxe.io.BytesInput input)
		{
			unchecked 
			{
				global::alphatab.io.BitInput.__hx_ctor_alphatab_io_BitInput(this, input);
			}
		}
		
		
		public static   void __hx_ctor_alphatab_io_BitInput(global::alphatab.io.BitInput __temp_me67, global::haxe.io.BytesInput input)
		{
			unchecked 
			{
				__temp_me67._input = input;
				__temp_me67._readBytes = 0;
				__temp_me67._position = 8;
			}
		}
		
		
		public static  int ByteSize;
		
		public static  new object __hx_createEmpty()
		{
			unchecked 
			{
				return new global::alphatab.io.BitInput(((global::haxe.lang.EmptyObject) (global::haxe.lang.EmptyObject.EMPTY) ));
			}
		}
		
		
		public static  new object __hx_create(global::haxe.root.Array arr)
		{
			unchecked 
			{
				return new global::alphatab.io.BitInput(((global::haxe.io.BytesInput) (arr[0]) ));
			}
		}
		
		
		public  int _currentByte;
		
		public  int _position;
		
		public  global::haxe.io.BytesInput _input;
		
		public  int _readBytes;
		
		public virtual   int getReadBytes()
		{
			unchecked 
			{
				return this._readBytes;
			}
		}
		
		
		public override   int readByte()
		{
			unchecked 
			{
				return this.readBits(8);
			}
		}
		
		
		public virtual   int readBits(int count)
		{
			unchecked 
			{
				int bits = 0;
				int i = ( count - 1 );
				while (( i >= 0 ))
				{
					bits |= ( this.readBit() << i );
					i--;
				}
				
				return bits;
			}
		}
		
		
		public virtual   int readBitsReversed(int count)
		{
			unchecked 
			{
				int bits = 0;
				int i = 0;
				while (( i < count ))
				{
					bits |= ( this.readBit() << i );
					i++;
				}
				
				return bits;
			}
		}
		
		
		public virtual   int readBit()
		{
			unchecked 
			{
				int bit = -1;
				if (( this._position >= 8 )) 
				{
					this._currentByte = this._input.readByte();
					this._readBytes++;
					this._position = 0;
				}
				
				int @value = ( ( this._currentByte >> ( ( 8 - this._position ) - 1 ) ) & 1 );
				this._position++;
				return @value;
			}
		}
		
		
		public override   double __hx_setField_f(string field, int hash, double @value, bool handleProperties)
		{
			unchecked 
			{
				switch (hash)
				{
					case 1780601078:
					{
						this._readBytes = ((int) (@value) );
						return @value;
					}
					
					
					case 311465992:
					{
						this._position = ((int) (@value) );
						return @value;
					}
					
					
					case 1606329826:
					{
						this._currentByte = ((int) (@value) );
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
					case 1780601078:
					{
						this._readBytes = ((int) (global::haxe.lang.Runtime.toInt(@value)) );
						return @value;
					}
					
					
					case 973409099:
					{
						this._input = ((global::haxe.io.BytesInput) (@value) );
						return @value;
					}
					
					
					case 311465992:
					{
						this._position = ((int) (global::haxe.lang.Runtime.toInt(@value)) );
						return @value;
					}
					
					
					case 1606329826:
					{
						this._currentByte = ((int) (global::haxe.lang.Runtime.toInt(@value)) );
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
					case 46423831:
					{
						return ((global::haxe.lang.Function) (new global::haxe.lang.Closure(((object) (this) ), global::haxe.lang.Runtime.toString("readBit"), ((int) (46423831) ))) );
					}
					
					
					case 197276318:
					{
						return ((global::haxe.lang.Function) (new global::haxe.lang.Closure(((object) (this) ), global::haxe.lang.Runtime.toString("readBitsReversed"), ((int) (197276318) ))) );
					}
					
					
					case 1762579836:
					{
						return ((global::haxe.lang.Function) (new global::haxe.lang.Closure(((object) (this) ), global::haxe.lang.Runtime.toString("readBits"), ((int) (1762579836) ))) );
					}
					
					
					case 1763375486:
					{
						return ((global::haxe.lang.Function) (new global::haxe.lang.Closure(((object) (this) ), global::haxe.lang.Runtime.toString("readByte"), ((int) (1763375486) ))) );
					}
					
					
					case 500560319:
					{
						return ((global::haxe.lang.Function) (new global::haxe.lang.Closure(((object) (this) ), global::haxe.lang.Runtime.toString("getReadBytes"), ((int) (500560319) ))) );
					}
					
					
					case 1780601078:
					{
						return this._readBytes;
					}
					
					
					case 973409099:
					{
						return this._input;
					}
					
					
					case 311465992:
					{
						return this._position;
					}
					
					
					case 1606329826:
					{
						return this._currentByte;
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
					case 1780601078:
					{
						return ((double) (this._readBytes) );
					}
					
					
					case 311465992:
					{
						return ((double) (this._position) );
					}
					
					
					case 1606329826:
					{
						return ((double) (this._currentByte) );
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
					case 1763375486:
					{
						return global::haxe.lang.Runtime.slowCallField(this, field, dynargs);
					}
					
					
					case 46423831:
					{
						return this.readBit();
					}
					
					
					case 197276318:
					{
						return this.readBitsReversed(((int) (global::haxe.lang.Runtime.toInt(dynargs[0])) ));
					}
					
					
					case 1762579836:
					{
						return this.readBits(((int) (global::haxe.lang.Runtime.toInt(dynargs[0])) ));
					}
					
					
					case 500560319:
					{
						return this.getReadBytes();
					}
					
					
					default:
					{
						return base.__hx_invokeField(field, hash, dynargs);
					}
					
				}
				
			}
		}
		
		
		public override   void __hx_getFields(global::haxe.root.Array<object> baseArr)
		{
			unchecked 
			{
				baseArr.push("_readBytes");
				baseArr.push("_input");
				baseArr.push("_position");
				baseArr.push("_currentByte");
				{
					base.__hx_getFields(baseArr);
				}
				
			}
		}
		
		
	}
}


