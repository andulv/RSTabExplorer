using haxe.root;
namespace _Xml
{
	public enum RealXmlType
	{
		Element, PCData, CData, Comment, DocType, ProcessingInstruction, Document
	}
}



#pragma warning disable 109, 114, 219, 429, 168, 162
namespace haxe.root
{
	public  class Xml : global::haxe.lang.HxObject 
	{
		static Xml() 
		{
			{
				global::haxe.root.Xml.Element = ((global::_Xml.RealXmlType) (((object) (global::_Xml.RealXmlType.Element) )) );
				global::haxe.root.Xml.PCData = ((global::_Xml.RealXmlType) (((object) (global::_Xml.RealXmlType.PCData) )) );
				global::haxe.root.Xml.CData = ((global::_Xml.RealXmlType) (((object) (global::_Xml.RealXmlType.CData) )) );
				global::haxe.root.Xml.Comment = ((global::_Xml.RealXmlType) (((object) (global::_Xml.RealXmlType.Comment) )) );
				global::haxe.root.Xml.DocType = ((global::_Xml.RealXmlType) (((object) (global::_Xml.RealXmlType.DocType) )) );
				global::haxe.root.Xml.ProcessingInstruction = ((global::_Xml.RealXmlType) (((object) (global::_Xml.RealXmlType.ProcessingInstruction) )) );
				global::haxe.root.Xml.Document = ((global::_Xml.RealXmlType) (((object) (global::_Xml.RealXmlType.Document) )) );
			}
			
		}
		public    Xml(global::haxe.lang.EmptyObject empty)
		{
			unchecked 
			{
				{
				}
				
			}
		}
		
		
		public    Xml()
		{
			unchecked 
			{
				global::haxe.root.Xml.__hx_ctor__Xml(this);
			}
		}
		
		
		public static   void __hx_ctor__Xml(global::haxe.root.Xml __temp_me11)
		{
			unchecked 
			{
				{
				}
				
			}
		}
		
		
		public static  global::_Xml.RealXmlType Element;
		
		public static  global::_Xml.RealXmlType PCData;
		
		public static  global::_Xml.RealXmlType CData;
		
		public static  global::_Xml.RealXmlType Comment;
		
		public static  global::_Xml.RealXmlType DocType;
		
		public static  global::_Xml.RealXmlType ProcessingInstruction;
		
		public static  global::_Xml.RealXmlType Document;
		
		public static   global::haxe.root.Xml parse(string str)
		{
			unchecked 
			{
				return global::haxe.xml.Parser.parse(str);
			}
		}
		
		
		public static   global::haxe.root.Xml createElement(string name)
		{
			unchecked 
			{
				global::haxe.root.Xml r = new global::haxe.root.Xml();
				r.nodeType = global::haxe.root.Xml.Element;
				r._children = new global::haxe.root.Array<object>();
				r._attributes = new global::haxe.ds.StringMap<object>();
				r._set_nodeName(name);
				return r;
			}
		}
		
		
		public static   global::haxe.root.Xml createPCData(string data)
		{
			unchecked 
			{
				global::haxe.root.Xml r = new global::haxe.root.Xml();
				r.nodeType = global::haxe.root.Xml.PCData;
				r._set_nodeValue(data);
				return r;
			}
		}
		
		
		public static   global::haxe.root.Xml createCData(string data)
		{
			unchecked 
			{
				global::haxe.root.Xml r = new global::haxe.root.Xml();
				r.nodeType = global::haxe.root.Xml.CData;
				r._set_nodeValue(data);
				return r;
			}
		}
		
		
		public static   global::haxe.root.Xml createComment(string data)
		{
			unchecked 
			{
				global::haxe.root.Xml r = new global::haxe.root.Xml();
				r.nodeType = global::haxe.root.Xml.Comment;
				r._set_nodeValue(data);
				return r;
			}
		}
		
		
		public static   global::haxe.root.Xml createDocType(string data)
		{
			unchecked 
			{
				global::haxe.root.Xml r = new global::haxe.root.Xml();
				r.nodeType = global::haxe.root.Xml.DocType;
				r._set_nodeValue(data);
				return r;
			}
		}
		
		
		public static   global::haxe.root.Xml createProcessingInstruction(string data)
		{
			unchecked 
			{
				global::haxe.root.Xml r = new global::haxe.root.Xml();
				r.nodeType = global::haxe.root.Xml.ProcessingInstruction;
				r._set_nodeValue(data);
				return r;
			}
		}
		
		
		public static   global::haxe.root.Xml createDocument()
		{
			unchecked 
			{
				global::haxe.root.Xml r = new global::haxe.root.Xml();
				r.nodeType = global::haxe.root.Xml.Document;
				r._children = new global::haxe.root.Array<object>();
				return r;
			}
		}
		
		
		public static  new object __hx_createEmpty()
		{
			unchecked 
			{
				return new global::haxe.root.Xml(((global::haxe.lang.EmptyObject) (global::haxe.lang.EmptyObject.EMPTY) ));
			}
		}
		
		
		public static  new object __hx_create(global::haxe.root.Array arr)
		{
			unchecked 
			{
				return new global::haxe.root.Xml();
			}
		}
		
		
		public  global::_Xml.RealXmlType nodeType;
		
		public  string _nodeName;
		
		public  string _nodeValue;
		
		public  global::haxe.ds.StringMap<object> _attributes;
		
		public  global::haxe.root.Array<object> _children;
		
		public  global::haxe.root.Xml _parent;
		
		public virtual   string _get_nodeName()
		{
			unchecked 
			{
				if (( this.nodeType != global::haxe.root.Xml.Element )) 
				{
					throw global::haxe.lang.HaxeException.wrap("bad nodeType");
				}
				
				return this._nodeName;
			}
		}
		
		
		public virtual   string _set_nodeName(string n)
		{
			unchecked 
			{
				if (( this.nodeType != global::haxe.root.Xml.Element )) 
				{
					throw global::haxe.lang.HaxeException.wrap("bad nodeType");
				}
				
				return this._nodeName = n;
			}
		}
		
		
		public virtual   string _get_nodeValue()
		{
			unchecked 
			{
				if (( ( this.nodeType == global::haxe.root.Xml.Element ) || ( this.nodeType == global::haxe.root.Xml.Document ) )) 
				{
					throw global::haxe.lang.HaxeException.wrap("bad nodeType");
				}
				
				return this._nodeValue;
			}
		}
		
		
		public virtual   string _set_nodeValue(string v)
		{
			unchecked 
			{
				if (( ( this.nodeType == global::haxe.root.Xml.Element ) || ( this.nodeType == global::haxe.root.Xml.Document ) )) 
				{
					throw global::haxe.lang.HaxeException.wrap("bad nodeType");
				}
				
				return this._nodeValue = v;
			}
		}
		
		
		public virtual   string @get(string att)
		{
			unchecked 
			{
				if (( this.nodeType != global::haxe.root.Xml.Element )) 
				{
					throw global::haxe.lang.HaxeException.wrap("bad nodeType");
				}
				
				return global::haxe.lang.Runtime.toString(this._attributes.@get(att).@value);
			}
		}
		
		
		public virtual   void @set(string att, string @value)
		{
			unchecked 
			{
				if (( this.nodeType != global::haxe.root.Xml.Element )) 
				{
					throw global::haxe.lang.HaxeException.wrap("bad nodeType");
				}
				
				this._attributes.@set(att, @value);
			}
		}
		
		
		public virtual   bool exists(string att)
		{
			unchecked 
			{
				if (( this.nodeType != global::haxe.root.Xml.Element )) 
				{
					throw global::haxe.lang.HaxeException.wrap("bad nodeType");
				}
				
				return this._attributes.exists(att);
			}
		}
		
		
		public virtual   object iterator()
		{
			unchecked 
			{
				if (( this._children == default(global::haxe.root.Array<object>) )) 
				{
					throw global::haxe.lang.HaxeException.wrap("bad nodetype");
				}
				
				global::haxe.root.Array<int> cur = new global::haxe.root.Array<int>(new int[]{0});
				global::haxe.root.Array<object> x = new global::haxe.root.Array<object>(new object[]{this._children});
				{
					global::haxe.lang.Function __temp_odecl457 = new global::Xml_iterator_178__Fun(((global::haxe.root.Array<object>) (global::haxe.root.Array<object>.__hx_cast<object>(((global::haxe.root.Array) (x) ))) ), ((global::haxe.root.Array<int>) (global::haxe.root.Array<object>.__hx_cast<int>(((global::haxe.root.Array) (cur) ))) ));
					global::haxe.lang.Function __temp_odecl458 = new global::Xml_iterator_181__Fun(((global::haxe.root.Array<object>) (global::haxe.root.Array<object>.__hx_cast<object>(((global::haxe.root.Array) (x) ))) ), ((global::haxe.root.Array<int>) (global::haxe.root.Array<object>.__hx_cast<int>(((global::haxe.root.Array) (cur) ))) ));
					return new global::haxe.lang.DynamicObject(new global::haxe.root.Array<int>(new int[]{407283053, 1224901875}), new global::haxe.root.Array<object>(new object[]{__temp_odecl457, __temp_odecl458}), new global::haxe.root.Array<int>(new int[]{}), new global::haxe.root.Array<double>(new double[]{}));
				}
				
			}
		}
		
		
		public virtual   global::haxe.root.Xml firstChild()
		{
			unchecked 
			{
				if (( this._children == default(global::haxe.root.Array<object>) )) 
				{
					throw global::haxe.lang.HaxeException.wrap("bad nodetype");
				}
				
				return ((global::haxe.root.Xml) (this._children[0]) );
			}
		}
		
		
		public virtual   global::haxe.root.Xml firstElement()
		{
			unchecked 
			{
				if (( this._children == default(global::haxe.root.Array<object>) )) 
				{
					throw global::haxe.lang.HaxeException.wrap("bad nodetype");
				}
				
				int cur = 0;
				int l = this._children.length;
				while (( cur < l ))
				{
					global::haxe.root.Xml n = ((global::haxe.root.Xml) (this._children[cur]) );
					if (( n.nodeType == global::haxe.root.Xml.Element )) 
					{
						return n;
					}
					
					cur++;
				}
				
				return default(global::haxe.root.Xml);
			}
		}
		
		
		public virtual   void addChild(global::haxe.root.Xml x)
		{
			unchecked 
			{
				if (( this._children == default(global::haxe.root.Array<object>) )) 
				{
					throw global::haxe.lang.HaxeException.wrap("bad nodetype");
				}
				
				if (( x._parent != default(global::haxe.root.Xml) )) 
				{
					x._parent._children.@remove(x);
				}
				
				x._parent = this;
				this._children.push(x);
			}
		}
		
		
		public virtual   string toString()
		{
			unchecked 
			{
				if (( this.nodeType == global::haxe.root.Xml.PCData )) 
				{
					return global::haxe.root.StringTools.htmlEscape(this._nodeValue, default(global::haxe.lang.Null<bool>));
				}
				
				if (( this.nodeType == global::haxe.root.Xml.CData )) 
				{
					return global::haxe.lang.Runtime.concat(global::haxe.lang.Runtime.concat("<![CDATA[", this._nodeValue), "]]>");
				}
				
				if (( this.nodeType == global::haxe.root.Xml.Comment )) 
				{
					return global::haxe.lang.Runtime.concat(global::haxe.lang.Runtime.concat("<!--", this._nodeValue), "-->");
				}
				
				if (( this.nodeType == global::haxe.root.Xml.DocType )) 
				{
					return global::haxe.lang.Runtime.concat(global::haxe.lang.Runtime.concat("<!DOCTYPE ", this._nodeValue), ">");
				}
				
				if (( this.nodeType == global::haxe.root.Xml.ProcessingInstruction )) 
				{
					return global::haxe.lang.Runtime.concat(global::haxe.lang.Runtime.concat("<?", this._nodeValue), "?>");
				}
				
				global::haxe.root.StringBuf s = new global::haxe.root.StringBuf();
				if (( this.nodeType == global::haxe.root.Xml.Element )) 
				{
					s.b.Append(((object) ("<") ));
					s.b.Append(((object) (global::Std.@string(this._nodeName)) ));
					{
						object __temp_iterator301 = this._attributes.keys();
						while (((bool) (global::haxe.lang.Runtime.callField(__temp_iterator301, "hasNext", 407283053, default(global::haxe.root.Array))) ))
						{
							string k = global::haxe.lang.Runtime.toString(global::haxe.lang.Runtime.callField(__temp_iterator301, "next", 1224901875, default(global::haxe.root.Array)));
							s.b.Append(((object) (" ") ));
							s.b.Append(((object) (global::Std.@string(k)) ));
							s.b.Append(((object) ("=\"") ));
							{
								object x = global::haxe.lang.Runtime.toString(this._attributes.@get(k).@value);
								s.b.Append(((object) (global::Std.@string(x)) ));
							}
							
							s.b.Append(((object) ("\"") ));
						}
						
					}
					
					if (( this._children.length == 0 )) 
					{
						s.b.Append(((object) ("/>") ));
						return s.toString();
					}
					
					s.b.Append(((object) (">") ));
				}
				
				{
					object __temp_iterator302 = this.iterator();
					while (((bool) (global::haxe.lang.Runtime.callField(__temp_iterator302, "hasNext", 407283053, default(global::haxe.root.Array))) ))
					{
						global::haxe.root.Xml x1 = ((global::haxe.root.Xml) (global::haxe.lang.Runtime.callField(__temp_iterator302, "next", 1224901875, default(global::haxe.root.Array))) );
						object x2 = x1.toString();
						s.b.Append(((object) (global::Std.@string(x2)) ));
					}
					
				}
				
				if (( this.nodeType == global::haxe.root.Xml.Element )) 
				{
					s.b.Append(((object) ("</") ));
					s.b.Append(((object) (global::Std.@string(this._nodeName)) ));
					s.b.Append(((object) (">") ));
				}
				
				return s.toString();
			}
		}
		
		
		public override   object __hx_setField(string field, int hash, object @value, bool handleProperties)
		{
			unchecked 
			{
				switch (hash)
				{
					case 1542788809:
					{
						this._parent = ((global::haxe.root.Xml) (@value) );
						return @value;
					}
					
					
					case 939528350:
					{
						this._children = ((global::haxe.root.Array<object>) (global::haxe.root.Array<object>.__hx_cast<object>(((global::haxe.root.Array) (@value) ))) );
						return @value;
					}
					
					
					case 1778087414:
					{
						this._attributes = ((global::haxe.ds.StringMap<object>) (global::haxe.ds.StringMap<object>.__hx_cast<object>(((global::haxe.ds.StringMap) (@value) ))) );
						return @value;
					}
					
					
					case 831576528:
					{
						this._nodeValue = global::haxe.lang.Runtime.toString(@value);
						return @value;
					}
					
					
					case 974309580:
					{
						this._nodeName = global::haxe.lang.Runtime.toString(@value);
						return @value;
					}
					
					
					case 1988514268:
					{
						this.nodeType = ((global::_Xml.RealXmlType) (@value) );
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
					
					
					case 1058459579:
					{
						return ((global::haxe.lang.Function) (new global::haxe.lang.Closure(((object) (this) ), global::haxe.lang.Runtime.toString("addChild"), ((int) (1058459579) ))) );
					}
					
					
					case 798803052:
					{
						return ((global::haxe.lang.Function) (new global::haxe.lang.Closure(((object) (this) ), global::haxe.lang.Runtime.toString("firstElement"), ((int) (798803052) ))) );
					}
					
					
					case 60289868:
					{
						return ((global::haxe.lang.Function) (new global::haxe.lang.Closure(((object) (this) ), global::haxe.lang.Runtime.toString("firstChild"), ((int) (60289868) ))) );
					}
					
					
					case 328878574:
					{
						return ((global::haxe.lang.Function) (new global::haxe.lang.Closure(((object) (this) ), global::haxe.lang.Runtime.toString("iterator"), ((int) (328878574) ))) );
					}
					
					
					case 1071652316:
					{
						return ((global::haxe.lang.Function) (new global::haxe.lang.Closure(((object) (this) ), global::haxe.lang.Runtime.toString("exists"), ((int) (1071652316) ))) );
					}
					
					
					case 5741474:
					{
						return ((global::haxe.lang.Function) (new global::haxe.lang.Closure(((object) (this) ), global::haxe.lang.Runtime.toString("set"), ((int) (5741474) ))) );
					}
					
					
					case 5144726:
					{
						return ((global::haxe.lang.Function) (new global::haxe.lang.Closure(((object) (this) ), global::haxe.lang.Runtime.toString("get"), ((int) (5144726) ))) );
					}
					
					
					case 1549276146:
					{
						return ((global::haxe.lang.Function) (new global::haxe.lang.Closure(((object) (this) ), global::haxe.lang.Runtime.toString("set_nodeValue"), ((int) (1549276146) ))) );
					}
					
					
					case 391262694:
					{
						return ((global::haxe.lang.Function) (new global::haxe.lang.Closure(((object) (this) ), global::haxe.lang.Runtime.toString("get_nodeValue"), ((int) (391262694) ))) );
					}
					
					
					case 1016047850:
					{
						return ((global::haxe.lang.Function) (new global::haxe.lang.Closure(((object) (this) ), global::haxe.lang.Runtime.toString("set_nodeName"), ((int) (1016047850) ))) );
					}
					
					
					case 664175990:
					{
						return ((global::haxe.lang.Function) (new global::haxe.lang.Closure(((object) (this) ), global::haxe.lang.Runtime.toString("get_nodeName"), ((int) (664175990) ))) );
					}
					
					
					case 1542788809:
					{
						return this._parent;
					}
					
					
					case 939528350:
					{
						return this._children;
					}
					
					
					case 1778087414:
					{
						return this._attributes;
					}
					
					
					case 831576528:
					{
						return this._nodeValue;
					}
					
					
					case 974309580:
					{
						return this._nodeName;
					}
					
					
					case 1988514268:
					{
						return this.nodeType;
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
					
					
					case 1058459579:
					{
						this.addChild(((global::haxe.root.Xml) (dynargs[0]) ));
						break;
					}
					
					
					case 798803052:
					{
						return this.firstElement();
					}
					
					
					case 60289868:
					{
						return this.firstChild();
					}
					
					
					case 328878574:
					{
						return this.iterator();
					}
					
					
					case 1071652316:
					{
						return this.exists(global::haxe.lang.Runtime.toString(dynargs[0]));
					}
					
					
					case 5741474:
					{
						this.@set(global::haxe.lang.Runtime.toString(dynargs[0]), global::haxe.lang.Runtime.toString(dynargs[1]));
						break;
					}
					
					
					case 5144726:
					{
						return this.@get(global::haxe.lang.Runtime.toString(dynargs[0]));
					}
					
					
					case 1549276146:
					{
						return this._set_nodeValue(global::haxe.lang.Runtime.toString(dynargs[0]));
					}
					
					
					case 391262694:
					{
						return this._get_nodeValue();
					}
					
					
					case 1016047850:
					{
						return this._set_nodeName(global::haxe.lang.Runtime.toString(dynargs[0]));
					}
					
					
					case 664175990:
					{
						return this._get_nodeName();
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
				baseArr.push("_parent");
				baseArr.push("_children");
				baseArr.push("_attributes");
				baseArr.push("_nodeValue");
				baseArr.push("_nodeName");
				baseArr.push("nodeType");
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



#pragma warning disable 109, 114, 219, 429, 168, 162
public  class Xml_iterator_178__Fun : global::haxe.lang.Function 
{
	public    Xml_iterator_178__Fun(global::haxe.root.Array<object> x, global::haxe.root.Array<int> cur) : base(0, 0)
	{
		unchecked 
		{
			this.x = x;
			this.cur = cur;
		}
	}
	
	
	public override   object __hx_invoke0_o()
	{
		unchecked 
		{
			return ( this.cur[0] < ((global::haxe.root.Array<object>) (global::haxe.root.Array<object>.__hx_cast<object>(((global::haxe.root.Array) (this.x[0]) ))) ).length );
		}
	}
	
	
	public  global::haxe.root.Array<object> x;
	
	public  global::haxe.root.Array<int> cur;
	
}



#pragma warning disable 109, 114, 219, 429, 168, 162
public  class Xml_iterator_181__Fun : global::haxe.lang.Function 
{
	public    Xml_iterator_181__Fun(global::haxe.root.Array<object> x, global::haxe.root.Array<int> cur) : base(0, 0)
	{
		unchecked 
		{
			this.x = x;
			this.cur = cur;
		}
	}
	
	
	public override   object __hx_invoke0_o()
	{
		unchecked 
		{
			return ((global::haxe.root.Xml) (((global::haxe.root.Array<object>) (global::haxe.root.Array<object>.__hx_cast<object>(((global::haxe.root.Array) (this.x[0]) ))) )[this.cur[0]++]) );
		}
	}
	
	
	public  global::haxe.root.Array<object> x;
	
	public  global::haxe.root.Array<int> cur;
	
}


