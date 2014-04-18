using haxe.root;
#pragma warning disable 109, 114, 219, 429, 168, 162
namespace alphatab.platform.model
{
	public  class Font : global::haxe.lang.HxObject 
	{
		static Font() 
		{
			global::alphatab.platform.model.Font.StylePlain = 0;
			global::alphatab.platform.model.Font.StyleBold = 1;
			global::alphatab.platform.model.Font.StyleItalic = 2;
		}
		public    Font(global::haxe.lang.EmptyObject empty)
		{
			unchecked 
			{
				{
				}
				
			}
		}
		
		
		public    Font(string family, double size, global::haxe.lang.Null<int> style)
		{
			unchecked 
			{
				global::alphatab.platform.model.Font.__hx_ctor_alphatab_platform_model_Font(this, family, size, style);
			}
		}
		
		
		public static   void __hx_ctor_alphatab_platform_model_Font(global::alphatab.platform.model.Font __temp_me22, string family, double size, global::haxe.lang.Null<int> style)
		{
			unchecked 
			{
				int __temp_style21 = ( (global::haxe.lang.Runtime.eq((style).toDynamic(), (default(global::haxe.lang.Null<int>)).toDynamic())) ? (((int) (0) )) : (style.@value) );
				__temp_me22._family = family;
				__temp_me22._size = size;
				__temp_me22._style = __temp_style21;
			}
		}
		
		
		public static  int StylePlain;
		
		public static  int StyleBold;
		
		public static  int StyleItalic;
		
		public static  new object __hx_createEmpty()
		{
			unchecked 
			{
				return new global::alphatab.platform.model.Font(((global::haxe.lang.EmptyObject) (global::haxe.lang.EmptyObject.EMPTY) ));
			}
		}
		
		
		public static  new object __hx_create(global::haxe.root.Array arr)
		{
			unchecked 
			{
				return new global::alphatab.platform.model.Font(global::haxe.lang.Runtime.toString(arr[0]), ((double) (global::haxe.lang.Runtime.toDouble(arr[1])) ), global::haxe.lang.Null<object>.ofDynamic<int>(arr[2]));
			}
		}
		
		
		public  string _family;
		
		public  double _size;
		
		public  int _style;
		
		public virtual   string getFamily()
		{
			unchecked 
			{
				return this._family;
			}
		}
		
		
		public virtual   void setFamily(string family)
		{
			unchecked 
			{
				this._family = family;
			}
		}
		
		
		public virtual   double getSize()
		{
			unchecked 
			{
				return this._size;
			}
		}
		
		
		public virtual   void setSize(double size)
		{
			unchecked 
			{
				this._size = size;
			}
		}
		
		
		public virtual   int getStyle()
		{
			unchecked 
			{
				return this._style;
			}
		}
		
		
		public virtual   void setStyle(int style)
		{
			unchecked 
			{
				this._style = style;
			}
		}
		
		
		public   bool isBold()
		{
			unchecked 
			{
				return ( (( this.getStyle() & 1 )) != 0 );
			}
		}
		
		
		public   bool isItalic()
		{
			unchecked 
			{
				return ( (( this.getStyle() & 2 )) != 0 );
			}
		}
		
		
		public virtual   global::alphatab.platform.model.Font clone()
		{
			unchecked 
			{
				return new global::alphatab.platform.model.Font(global::haxe.lang.Runtime.toString(this._family), ((double) (this._size) ), new global::haxe.lang.Null<int>(this._style, true));
			}
		}
		
		
		public virtual   string toCssString()
		{
			unchecked 
			{
				global::haxe.root.StringBuf buf = new global::haxe.root.StringBuf();
				if (( (( this.getStyle() & 1 )) != 0 )) 
				{
					buf.b.Append(((object) ("bold ") ));
				}
				
				if (( (( this.getStyle() & 2 )) != 0 )) 
				{
					buf.b.Append(((object) ("italic ") ));
				}
				
				buf.b.Append(((object) (global::Std.@string(this._size)) ));
				buf.b.Append(((object) ("px") ));
				buf.b.Append(((object) ("\'") ));
				buf.b.Append(((object) (global::Std.@string(this._family)) ));
				buf.b.Append(((object) ("\'") ));
				return buf.toString();
			}
		}
		
		
		public override   double __hx_setField_f(string field, int hash, double @value, bool handleProperties)
		{
			unchecked 
			{
				switch (hash)
				{
					case 322674:
					{
						this._style = ((int) (@value) );
						return @value;
					}
					
					
					case 2137308320:
					{
						this._size = ((double) (@value) );
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
					case 322674:
					{
						this._style = ((int) (global::haxe.lang.Runtime.toInt(@value)) );
						return @value;
					}
					
					
					case 2137308320:
					{
						this._size = ((double) (global::haxe.lang.Runtime.toDouble(@value)) );
						return @value;
					}
					
					
					case 1494774083:
					{
						this._family = global::haxe.lang.Runtime.toString(@value);
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
					case 533940217:
					{
						return ((global::haxe.lang.Function) (new global::haxe.lang.Closure(((object) (this) ), global::haxe.lang.Runtime.toString("toCssString"), ((int) (533940217) ))) );
					}
					
					
					case 1214452573:
					{
						return ((global::haxe.lang.Function) (new global::haxe.lang.Closure(((object) (this) ), global::haxe.lang.Runtime.toString("clone"), ((int) (1214452573) ))) );
					}
					
					
					case 1590545018:
					{
						return ((global::haxe.lang.Function) (new global::haxe.lang.Closure(((object) (this) ), global::haxe.lang.Runtime.toString("isItalic"), ((int) (1590545018) ))) );
					}
					
					
					case 1585596047:
					{
						return ((global::haxe.lang.Function) (new global::haxe.lang.Closure(((object) (this) ), global::haxe.lang.Runtime.toString("isBold"), ((int) (1585596047) ))) );
					}
					
					
					case 307367471:
					{
						return ((global::haxe.lang.Function) (new global::haxe.lang.Closure(((object) (this) ), global::haxe.lang.Runtime.toString("setStyle"), ((int) (307367471) ))) );
					}
					
					
					case 1676981435:
					{
						return ((global::haxe.lang.Function) (new global::haxe.lang.Closure(((object) (this) ), global::haxe.lang.Runtime.toString("getStyle"), ((int) (1676981435) ))) );
					}
					
					
					case 299360643:
					{
						return ((global::haxe.lang.Function) (new global::haxe.lang.Closure(((object) (this) ), global::haxe.lang.Runtime.toString("setSize"), ((int) (299360643) ))) );
					}
					
					
					case 517361783:
					{
						return ((global::haxe.lang.Function) (new global::haxe.lang.Closure(((object) (this) ), global::haxe.lang.Runtime.toString("getSize"), ((int) (517361783) ))) );
					}
					
					
					case 1246287078:
					{
						return ((global::haxe.lang.Function) (new global::haxe.lang.Closure(((object) (this) ), global::haxe.lang.Runtime.toString("setFamily"), ((int) (1246287078) ))) );
					}
					
					
					case 1727523034:
					{
						return ((global::haxe.lang.Function) (new global::haxe.lang.Closure(((object) (this) ), global::haxe.lang.Runtime.toString("getFamily"), ((int) (1727523034) ))) );
					}
					
					
					case 322674:
					{
						return this._style;
					}
					
					
					case 2137308320:
					{
						return this._size;
					}
					
					
					case 1494774083:
					{
						return this._family;
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
					case 322674:
					{
						return ((double) (this._style) );
					}
					
					
					case 2137308320:
					{
						return this._size;
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
					case 533940217:
					{
						return this.toCssString();
					}
					
					
					case 1214452573:
					{
						return this.clone();
					}
					
					
					case 1590545018:
					{
						return this.isItalic();
					}
					
					
					case 1585596047:
					{
						return this.isBold();
					}
					
					
					case 307367471:
					{
						this.setStyle(((int) (global::haxe.lang.Runtime.toInt(dynargs[0])) ));
						break;
					}
					
					
					case 1676981435:
					{
						return this.getStyle();
					}
					
					
					case 299360643:
					{
						this.setSize(((double) (global::haxe.lang.Runtime.toDouble(dynargs[0])) ));
						break;
					}
					
					
					case 517361783:
					{
						return this.getSize();
					}
					
					
					case 1246287078:
					{
						this.setFamily(global::haxe.lang.Runtime.toString(dynargs[0]));
						break;
					}
					
					
					case 1727523034:
					{
						return this.getFamily();
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
				baseArr.push("_style");
				baseArr.push("_size");
				baseArr.push("_family");
				{
					base.__hx_getFields(baseArr);
				}
				
			}
		}
		
		
	}
}


