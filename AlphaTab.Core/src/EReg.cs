using haxe.root;
#pragma warning disable 109, 114, 219, 429, 168, 162
namespace haxe.root
{
	public  class EReg : global::haxe.lang.HxObject 
	{
		public    EReg(global::haxe.lang.EmptyObject empty)
		{
			unchecked 
			{
				{
				}
				
			}
		}
		
		
		public    EReg(string r, string opt)
		{
			unchecked 
			{
				global::haxe.root.EReg.__hx_ctor__EReg(this, r, opt);
			}
		}
		
		
		public static   void __hx_ctor__EReg(global::haxe.root.EReg __temp_me5, string r, string opt)
		{
			unchecked 
			{
				int opts = ((int) (global::haxe.lang.Runtime.toInt(((object) (global::System.Text.RegularExpressions.RegexOptions.CultureInvariant) ))) );
				{
					int _g1 = 0;
					int _g = opt.Length;
					while (( _g1 < _g ))
					{
						int i = _g1++;
						{
							int _g2 = default(int);
							_g2 = ((int) (opt[i]) );
							switch (_g2)
							{
								case 105:
								{
									opts |= ((int) (global::haxe.lang.Runtime.toInt(((object) (global::System.Text.RegularExpressions.RegexOptions.IgnoreCase) ))) );
									break;
								}
								
								
								case 103:
								{
									__temp_me5.isGlobal = true;
									break;
								}
								
								
								case 109:
								{
									opts |= ((int) (global::haxe.lang.Runtime.toInt(((object) (global::System.Text.RegularExpressions.RegexOptions.Multiline) ))) );
									break;
								}
								
								
								case 99:
								{
									opts |= ((int) (global::haxe.lang.Runtime.toInt(((object) (global::System.Text.RegularExpressions.RegexOptions.Compiled) ))) );
									break;
								}
								
								
							}
							
						}
						
					}
					
				}
				
				__temp_me5.regex = new global::System.Text.RegularExpressions.Regex(global::haxe.lang.Runtime.toString(r), ((global::System.Text.RegularExpressions.RegexOptions) (((object) (opts) )) ));
			}
		}
		
		
		public static  new object __hx_createEmpty()
		{
			unchecked 
			{
				return new global::haxe.root.EReg(((global::haxe.lang.EmptyObject) (global::haxe.lang.EmptyObject.EMPTY) ));
			}
		}
		
		
		public static  new object __hx_create(global::haxe.root.Array arr)
		{
			unchecked 
			{
				return new global::haxe.root.EReg(global::haxe.lang.Runtime.toString(arr[0]), global::haxe.lang.Runtime.toString(arr[1]));
			}
		}
		
		
		public  global::System.Text.RegularExpressions.Regex regex;
		
		public  global::System.Text.RegularExpressions.Match m;
		
		public  bool isGlobal;
		
		public  string cur;
		
		public virtual   bool match(string s)
		{
			unchecked 
			{
				this.m = this.regex.Match(global::haxe.lang.Runtime.toString(s));
				this.cur = s;
				return ( this.m as global::System.Text.RegularExpressions.Group ).Success;
			}
		}
		
		
		public virtual   string matched(int n)
		{
			unchecked 
			{
				if (( ( this.m == default(global::System.Text.RegularExpressions.Match) ) || ( ((uint) (n) ) > this.m.Groups.Count ) )) 
				{
					throw global::haxe.lang.HaxeException.wrap("EReg::matched");
				}
				
				if ( ! (this.m.Groups[n].Success) ) 
				{
					return default(string);
				}
				
				return ( this.m.Groups[n] as global::System.Text.RegularExpressions.Capture ).Value;
			}
		}
		
		
		public override   object __hx_setField(string field, int hash, object @value, bool handleProperties)
		{
			unchecked 
			{
				switch (hash)
				{
					case 4949376:
					{
						this.cur = global::haxe.lang.Runtime.toString(@value);
						return @value;
					}
					
					
					case 1821933:
					{
						this.isGlobal = ((bool) (@value) );
						return @value;
					}
					
					
					case 109:
					{
						this.m = ((global::System.Text.RegularExpressions.Match) (@value) );
						return @value;
					}
					
					
					case 1723805383:
					{
						this.regex = ((global::System.Text.RegularExpressions.Regex) (@value) );
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
					case 159136996:
					{
						return ((global::haxe.lang.Function) (new global::haxe.lang.Closure(((object) (this) ), global::haxe.lang.Runtime.toString("matched"), ((int) (159136996) ))) );
					}
					
					
					case 52644165:
					{
						return ((global::haxe.lang.Function) (new global::haxe.lang.Closure(((object) (this) ), global::haxe.lang.Runtime.toString("match"), ((int) (52644165) ))) );
					}
					
					
					case 4949376:
					{
						return this.cur;
					}
					
					
					case 1821933:
					{
						return this.isGlobal;
					}
					
					
					case 109:
					{
						return this.m;
					}
					
					
					case 1723805383:
					{
						return this.regex;
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
					case 159136996:
					{
						return this.matched(((int) (global::haxe.lang.Runtime.toInt(dynargs[0])) ));
					}
					
					
					case 52644165:
					{
						return this.match(global::haxe.lang.Runtime.toString(dynargs[0]));
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
				baseArr.push("cur");
				baseArr.push("isGlobal");
				baseArr.push("m");
				baseArr.push("regex");
				{
					base.__hx_getFields(baseArr);
				}
				
			}
		}
		
		
	}
}


