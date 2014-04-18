using haxe.root;
#pragma warning disable 109, 114, 219, 429, 168, 162
namespace haxe.root
{
	public  class StringTools : global::haxe.lang.HxObject 
	{
		public    StringTools(global::haxe.lang.EmptyObject empty)
		{
			unchecked 
			{
				{
				}
				
			}
		}
		
		
		public    StringTools()
		{
			unchecked 
			{
				global::haxe.root.StringTools.__hx_ctor__StringTools(this);
			}
		}
		
		
		public static   void __hx_ctor__StringTools(global::haxe.root.StringTools __temp_me9)
		{
			unchecked 
			{
				{
				}
				
			}
		}
		
		
		public static   string urlEncode(string s)
		{
			unchecked 
			{
				return System.Uri.EscapeUriString(s);
			}
		}
		
		
		public static   string urlDecode(string s)
		{
			unchecked 
			{
				return System.Uri.UnescapeDataString(s);
			}
		}
		
		
		public static   string htmlEscape(string s, global::haxe.lang.Null<bool> quotes)
		{
			unchecked 
			{
				s = global::haxe.lang.StringExt.split(global::haxe.lang.StringExt.split(global::haxe.lang.StringExt.split(s, "&").@join("&amp;"), "<").@join("&lt;"), ">").@join("&gt;");
				if ((quotes).@value) 
				{
					return global::haxe.lang.StringExt.split(global::haxe.lang.StringExt.split(s, "\"").@join("&quot;"), "\'").@join("&#039;");
				}
				 else 
				{
					return s;
				}
				
			}
		}
		
		
		public static   string htmlUnescape(string s)
		{
			unchecked 
			{
				return global::haxe.lang.StringExt.split(global::haxe.lang.StringExt.split(global::haxe.lang.StringExt.split(global::haxe.lang.StringExt.split(global::haxe.lang.StringExt.split(s, "&gt;").@join(">"), "&lt;").@join("<"), "&quot;").@join("\""), "&#039;").@join("\'"), "&amp;").@join("&");
			}
		}
		
		
		public static   bool startsWith(string s, string start)
		{
			unchecked 
			{
				return s.StartsWith(start);
			}
		}
		
		
		public static   bool endsWith(string s, string end)
		{
			unchecked 
			{
				return s.EndsWith(end);
			}
		}
		
		
		public static   bool isSpace(string s, int pos)
		{
			unchecked 
			{
				global::haxe.lang.Null<int> c = global::haxe.lang.StringExt.charCodeAt(s, pos);
				return ( ( ( c.@value > 8 ) && ( c.@value < 14 ) ) || global::haxe.lang.Runtime.eq((c).toDynamic(), 32) );
			}
		}
		
		
		public static   string ltrim(string s)
		{
			unchecked 
			{
				return s.TrimStart();
			}
		}
		
		
		public static   string rtrim(string s)
		{
			unchecked 
			{
				return s.TrimEnd();
			}
		}
		
		
		public static   string trim(string s)
		{
			unchecked 
			{
				return s.Trim();
			}
		}
		
		
		public static   string lpad(string s, string c, int l)
		{
			unchecked 
			{
				if (( c.Length <= 0 )) 
				{
					return s;
				}
				
				while (( s.Length < l ))
				{
					s = global::haxe.lang.Runtime.concat(c, s);
				}
				
				return s;
			}
		}
		
		
		public static   string rpad(string s, string c, int l)
		{
			unchecked 
			{
				if (( c.Length <= 0 )) 
				{
					return s;
				}
				
				while (( s.Length < l ))
				{
					s = global::haxe.lang.Runtime.concat(s, c);
				}
				
				return s;
			}
		}
		
		
		public static   string replace(string s, string sub, string @by)
		{
			unchecked 
			{
				if (( sub.Length == 0 )) 
				{
					return global::haxe.lang.StringExt.split(s, sub).@join(@by);
				}
				 else 
				{
					return s.Replace(sub, @by);
				}
				
			}
		}
		
		
		public static   string hex(int n, global::haxe.lang.Null<int> digits)
		{
			unchecked 
			{
				string s = "";
				string hexChars = "0123456789ABCDEF";
				do 
				{
					s = global::haxe.lang.Runtime.concat(global::haxe.lang.StringExt.charAt(hexChars, ( n & 15 )), s);
					n = ((int) (( ((uint) (n) ) >> 4 )) );
				}
				while (( n > 0 ));
				if (( ! (global::haxe.lang.Runtime.eq((digits).toDynamic(), (default(global::haxe.lang.Null<int>)).toDynamic())) )) 
				{
					while (( s.Length < digits.@value ))
					{
						s = global::haxe.lang.Runtime.concat("0", s);
					}
					
				}
				
				return s;
			}
		}
		
		
		public static   int fastCodeAt(string s, int index)
		{
			unchecked 
			{
				if (( ((uint) (index) ) < s.Length )) 
				{
					return ((int) (global::haxe.lang.Runtime.toInt(s[index])) );
				}
				 else 
				{
					return -1;
				}
				
			}
		}
		
		
		public static   bool isEof(int c)
		{
			unchecked 
			{
				return ( c == -1 );
			}
		}
		
		
		public static  new object __hx_createEmpty()
		{
			unchecked 
			{
				return new global::haxe.root.StringTools(((global::haxe.lang.EmptyObject) (global::haxe.lang.EmptyObject.EMPTY) ));
			}
		}
		
		
		public static  new object __hx_create(global::haxe.root.Array arr)
		{
			unchecked 
			{
				return new global::haxe.root.StringTools();
			}
		}
		
		
	}
}


