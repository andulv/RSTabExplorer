using haxe.root;
#pragma warning disable 109, 114, 219, 429, 168, 162
namespace alphatab.rendering.utils
{
	public  class SvgPathParser : global::haxe.lang.HxObject 
	{
		public    SvgPathParser(global::haxe.lang.EmptyObject empty)
		{
			unchecked 
			{
				{
				}
				
			}
		}
		
		
		public    SvgPathParser(string svg)
		{
			unchecked 
			{
				global::alphatab.rendering.utils.SvgPathParser.__hx_ctor_alphatab_rendering_utils_SvgPathParser(this, svg);
			}
		}
		
		
		public static   void __hx_ctor_alphatab_rendering_utils_SvgPathParser(global::alphatab.rendering.utils.SvgPathParser __temp_me271, string svg)
		{
			unchecked 
			{
				__temp_me271.svg = svg;
			}
		}
		
		
		public static   bool isNumber(string s, global::haxe.lang.Null<bool> allowSign)
		{
			unchecked 
			{
				bool __temp_allowSign270 = ( (global::haxe.lang.Runtime.eq((allowSign).toDynamic(), (default(global::haxe.lang.Null<bool>)).toDynamic())) ? (((bool) (true) )) : (allowSign.@value) );
				if (( s.Length == 0 )) 
				{
					return false;
				}
				
				int c = default(int);
				if (( ((uint) (0) ) < s.Length )) 
				{
					c = ((int) (global::haxe.lang.Runtime.toInt(s[0])) );
				}
				 else 
				{
					c = -1;
				}
				
				return ( ( __temp_allowSign270 && ( c == 45 ) ) || ( ( c >= 48 ) && ( c <= 57 ) ) );
			}
		}
		
		
		public static   bool isWhiteSpace(string s)
		{
			unchecked 
			{
				if (( s.Length == 0 )) 
				{
					return false;
				}
				
				int c = default(int);
				if (( ((uint) (0) ) < s.Length )) 
				{
					c = ((int) (global::haxe.lang.Runtime.toInt(s[0])) );
				}
				 else 
				{
					c = -1;
				}
				
				return ( ( ( ( c == 32 ) || ( c == 9 ) ) || ( c == 13 ) ) || ( c == 10 ) );
			}
		}
		
		
		public static  new object __hx_createEmpty()
		{
			unchecked 
			{
				return new global::alphatab.rendering.utils.SvgPathParser(((global::haxe.lang.EmptyObject) (global::haxe.lang.EmptyObject.EMPTY) ));
			}
		}
		
		
		public static  new object __hx_create(global::haxe.root.Array arr)
		{
			unchecked 
			{
				return new global::alphatab.rendering.utils.SvgPathParser(global::haxe.lang.Runtime.toString(arr[0]));
			}
		}
		
		
		public  string svg;
		
		public  string lastCommand;
		
		public  string currentToken;
		
		public  int _currentIndex;
		
		public virtual   void reset()
		{
			unchecked 
			{
				this._currentIndex = 0;
				this.nextToken();
			}
		}
		
		
		public virtual   bool eof()
		{
			unchecked 
			{
				return ( this._currentIndex >= this.svg.Length );
			}
		}
		
		
		public virtual   string getString()
		{
			unchecked 
			{
				string t = this.currentToken;
				this.nextToken();
				return t;
			}
		}
		
		
		public virtual   int getNumber()
		{
			unchecked 
			{
				return global::Std.parseInt(this.getString()).@value;
			}
		}
		
		
		public   bool currentTokenIsNumber()
		{
			unchecked 
			{
				return global::alphatab.rendering.utils.SvgPathParser.isNumber(this.currentToken, default(global::haxe.lang.Null<bool>));
			}
		}
		
		
		public virtual   string nextChar()
		{
			unchecked 
			{
				if (this.eof()) 
				{
					return "";
				}
				
				return global::haxe.lang.StringExt.charAt(this.svg, this._currentIndex++);
			}
		}
		
		
		public virtual   string peekChar()
		{
			unchecked 
			{
				if (this.eof()) 
				{
					return "";
				}
				
				return global::haxe.lang.StringExt.charAt(this.svg, this._currentIndex);
			}
		}
		
		
		public virtual   void nextToken()
		{
			unchecked 
			{
				global::haxe.root.StringBuf token = new global::haxe.root.StringBuf();
				string c = default(string);
				bool skipChar = default(bool);
				do 
				{
					c = this.nextChar();
					skipChar = ( global::alphatab.rendering.utils.SvgPathParser.isWhiteSpace(c) || string.Equals(c, ",") );
				}
				while ((  ! (this.eof())  && skipChar ));
				if ((  ! (this.eof())  ||  ! (skipChar)  )) 
				{
					token.b.Append(((object) (global::Std.@string(c)) ));
					if (global::alphatab.rendering.utils.SvgPathParser.isNumber(c, default(global::haxe.lang.Null<bool>))) 
					{
						c = this.peekChar();
						while ((  ! (this.eof())  && (( global::alphatab.rendering.utils.SvgPathParser.isNumber(c, new global::haxe.lang.Null<bool>(false, true)) || string.Equals(c, ".") )) ))
						{
							{
								object x = this.nextChar();
								token.b.Append(((object) (global::Std.@string(x)) ));
							}
							
							c = this.peekChar();
						}
						
					}
					 else 
					{
						this.lastCommand = token.toString();
					}
					
				}
				
				this.currentToken = token.toString();
			}
		}
		
		
		public override   double __hx_setField_f(string field, int hash, double @value, bool handleProperties)
		{
			unchecked 
			{
				switch (hash)
				{
					case 1737429752:
					{
						this._currentIndex = ((int) (@value) );
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
					case 1737429752:
					{
						this._currentIndex = ((int) (global::haxe.lang.Runtime.toInt(@value)) );
						return @value;
					}
					
					
					case 1530357760:
					{
						this.currentToken = global::haxe.lang.Runtime.toString(@value);
						return @value;
					}
					
					
					case 907617685:
					{
						this.lastCommand = global::haxe.lang.Runtime.toString(@value);
						return @value;
					}
					
					
					case 5745252:
					{
						this.svg = global::haxe.lang.Runtime.toString(@value);
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
					case 997235974:
					{
						return ((global::haxe.lang.Function) (new global::haxe.lang.Closure(((object) (this) ), global::haxe.lang.Runtime.toString("nextToken"), ((int) (997235974) ))) );
					}
					
					
					case 411948561:
					{
						return ((global::haxe.lang.Function) (new global::haxe.lang.Closure(((object) (this) ), global::haxe.lang.Runtime.toString("peekChar"), ((int) (411948561) ))) );
					}
					
					
					case 1837892969:
					{
						return ((global::haxe.lang.Function) (new global::haxe.lang.Closure(((object) (this) ), global::haxe.lang.Runtime.toString("nextChar"), ((int) (1837892969) ))) );
					}
					
					
					case 1349863027:
					{
						return ((global::haxe.lang.Function) (new global::haxe.lang.Closure(((object) (this) ), global::haxe.lang.Runtime.toString("currentTokenIsNumber"), ((int) (1349863027) ))) );
					}
					
					
					case 500240383:
					{
						return ((global::haxe.lang.Function) (new global::haxe.lang.Closure(((object) (this) ), global::haxe.lang.Runtime.toString("getNumber"), ((int) (500240383) ))) );
					}
					
					
					case 226931207:
					{
						return ((global::haxe.lang.Function) (new global::haxe.lang.Closure(((object) (this) ), global::haxe.lang.Runtime.toString("getString"), ((int) (226931207) ))) );
					}
					
					
					case 5047484:
					{
						return ((global::haxe.lang.Function) (new global::haxe.lang.Closure(((object) (this) ), global::haxe.lang.Runtime.toString("eof"), ((int) (5047484) ))) );
					}
					
					
					case 1724402127:
					{
						return ((global::haxe.lang.Function) (new global::haxe.lang.Closure(((object) (this) ), global::haxe.lang.Runtime.toString("reset"), ((int) (1724402127) ))) );
					}
					
					
					case 1737429752:
					{
						return this._currentIndex;
					}
					
					
					case 1530357760:
					{
						return this.currentToken;
					}
					
					
					case 907617685:
					{
						return this.lastCommand;
					}
					
					
					case 5745252:
					{
						return this.svg;
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
					case 1737429752:
					{
						return ((double) (this._currentIndex) );
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
					case 997235974:
					{
						this.nextToken();
						break;
					}
					
					
					case 411948561:
					{
						return this.peekChar();
					}
					
					
					case 1837892969:
					{
						return this.nextChar();
					}
					
					
					case 1349863027:
					{
						return this.currentTokenIsNumber();
					}
					
					
					case 500240383:
					{
						return this.getNumber();
					}
					
					
					case 226931207:
					{
						return this.getString();
					}
					
					
					case 5047484:
					{
						return this.eof();
					}
					
					
					case 1724402127:
					{
						this.reset();
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
				baseArr.push("_currentIndex");
				baseArr.push("currentToken");
				baseArr.push("lastCommand");
				baseArr.push("svg");
				{
					base.__hx_getFields(baseArr);
				}
				
			}
		}
		
		
	}
}


