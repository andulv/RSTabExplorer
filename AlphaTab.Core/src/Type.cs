using haxe.root;
#pragma warning disable 109, 114, 219, 429, 168, 162
namespace haxe.root
{
	public  class ValueType : global::haxe.lang.Enum 
	{
		static ValueType() 
		{
			global::haxe.root.ValueType.constructs = new global::haxe.root.Array<object>(new object[]{"TNull", "TInt", "TFloat", "TBool", "TObject", "TFunction", "TClass", "TEnum", "TUnknown"});
			global::haxe.root.ValueType.TNull = new global::haxe.root.ValueType(((int) (0) ), ((global::haxe.root.Array<object>) (global::haxe.root.Array<object>.__hx_cast<object>(((global::haxe.root.Array) (new global::haxe.root.Array<object>(new object[]{})) ))) ));
			global::haxe.root.ValueType.TInt = new global::haxe.root.ValueType(((int) (1) ), ((global::haxe.root.Array<object>) (global::haxe.root.Array<object>.__hx_cast<object>(((global::haxe.root.Array) (new global::haxe.root.Array<object>(new object[]{})) ))) ));
			global::haxe.root.ValueType.TFloat = new global::haxe.root.ValueType(((int) (2) ), ((global::haxe.root.Array<object>) (global::haxe.root.Array<object>.__hx_cast<object>(((global::haxe.root.Array) (new global::haxe.root.Array<object>(new object[]{})) ))) ));
			global::haxe.root.ValueType.TBool = new global::haxe.root.ValueType(((int) (3) ), ((global::haxe.root.Array<object>) (global::haxe.root.Array<object>.__hx_cast<object>(((global::haxe.root.Array) (new global::haxe.root.Array<object>(new object[]{})) ))) ));
			global::haxe.root.ValueType.TObject = new global::haxe.root.ValueType(((int) (4) ), ((global::haxe.root.Array<object>) (global::haxe.root.Array<object>.__hx_cast<object>(((global::haxe.root.Array) (new global::haxe.root.Array<object>(new object[]{})) ))) ));
			global::haxe.root.ValueType.TFunction = new global::haxe.root.ValueType(((int) (5) ), ((global::haxe.root.Array<object>) (global::haxe.root.Array<object>.__hx_cast<object>(((global::haxe.root.Array) (new global::haxe.root.Array<object>(new object[]{})) ))) ));
			global::haxe.root.ValueType.TUnknown = new global::haxe.root.ValueType(((int) (8) ), ((global::haxe.root.Array<object>) (global::haxe.root.Array<object>.__hx_cast<object>(((global::haxe.root.Array) (new global::haxe.root.Array<object>(new object[]{})) ))) ));
		}
		public    ValueType(global::haxe.lang.EmptyObject empty) : base(global::haxe.lang.EmptyObject.EMPTY)
		{
			unchecked 
			{
			}
		}
		
		
		public    ValueType(int index, global::haxe.root.Array<object> @params) : base(index, @params)
		{
			unchecked 
			{
			}
		}
		
		
		public static  global::haxe.root.Array<object> constructs;
		
		public static  global::haxe.root.ValueType TNull;
		
		public static  global::haxe.root.ValueType TInt;
		
		public static  global::haxe.root.ValueType TFloat;
		
		public static  global::haxe.root.ValueType TBool;
		
		public static  global::haxe.root.ValueType TObject;
		
		public static  global::haxe.root.ValueType TFunction;
		
		public static   global::haxe.root.ValueType TClass(global::System.Type c)
		{
			unchecked 
			{
				return new global::haxe.root.ValueType(((int) (6) ), ((global::haxe.root.Array<object>) (global::haxe.root.Array<object>.__hx_cast<object>(((global::haxe.root.Array) (new global::haxe.root.Array<object>(new object[]{c})) ))) ));
			}
		}
		
		
		public static   global::haxe.root.ValueType TEnum(global::System.Type e)
		{
			unchecked 
			{
				return new global::haxe.root.ValueType(((int) (7) ), ((global::haxe.root.Array<object>) (global::haxe.root.Array<object>.__hx_cast<object>(((global::haxe.root.Array) (new global::haxe.root.Array<object>(new object[]{e})) ))) ));
			}
		}
		
		
		public static  global::haxe.root.ValueType TUnknown;
		
		public static  new object __hx_createEmpty()
		{
			unchecked 
			{
				return new global::haxe.root.ValueType(((global::haxe.lang.EmptyObject) (global::haxe.lang.EmptyObject.EMPTY) ));
			}
		}
		
		
		public static  new object __hx_create(global::haxe.root.Array arr)
		{
			unchecked 
			{
				return new global::haxe.root.ValueType(((int) (global::haxe.lang.Runtime.toInt(arr[0])) ), ((global::haxe.root.Array<object>) (global::haxe.root.Array<object>.__hx_cast<object>(((global::haxe.root.Array) (arr[1]) ))) ));
			}
		}
		
		
	}
}



#pragma warning disable 109, 114, 219, 429, 168, 162
namespace haxe.root
{
	public  class Type : global::haxe.lang.HxObject 
	{
		public    Type(global::haxe.lang.EmptyObject empty)
		{
			unchecked 
			{
				{
				}
				
			}
		}
		
		
		public    Type()
		{
			unchecked 
			{
				global::haxe.root.Type.__hx_ctor__Type(this);
			}
		}
		
		
		public static   void __hx_ctor__Type(global::haxe.root.Type __temp_me10)
		{
			unchecked 
			{
				{
				}
				
			}
		}
		
		
		public static   global::System.Type getClass<T>(T o)
		{
			
		if (o == null || o is haxe.lang.DynamicObject || o is System.Type)
			return null;

		return o.GetType();
	
		}
		
		
		public static   global::System.Type getEnum(object o)
		{
			
		if (o is System.Enum || o is haxe.lang.Enum)
			return o.GetType();
		return null;
	
		}
		
		
		public static   global::System.Type getSuperClass(global::System.Type c)
		{
			unchecked 
			{
				global::System.Type t = ((global::System.Type) (c) );
				global::System.Type @base = t.BaseType;
				if (( ( global::haxe.lang.Runtime.typeEq(@base, default(global::System.Type)) || string.Equals(global::haxe.lang.Runtime.concat(global::Std.@string(@base), ""), "haxe.lang.HxObject") ) || string.Equals(global::haxe.lang.Runtime.concat(global::Std.@string(@base), ""), "System.Object") )) 
				{
					return default(global::System.Type);
				}
				
				return ((global::System.Type) (@base) );
			}
		}
		
		
		public static   string getClassName(global::System.Type c)
		{
			unchecked 
			{
				string ret = global::haxe.lang.Runtime.toString(((global::System.Type) (c) ));
				if (( ( ret.Length > 10 ) && ret.StartsWith("haxe.root.") )) 
				{
					ret = global::haxe.lang.StringExt.substr(ret, 10, default(global::haxe.lang.Null<int>));
				}
				
				switch (ret)
				{
					case "System.Int32":
					{
						return "Int";
					}
					
					
					case "System.Double":
					{
						return "Float";
					}
					
					
					case "System.String":
					{
						return "String";
					}
					
					
					case "System.Object":
					{
						return "Dynamic";
					}
					
					
					case "System.Type":
					{
						return "Class";
					}
					
					
					default:
					{
						return global::haxe.lang.Runtime.toString(global::haxe.lang.StringExt.split(ret, "`")[0]);
					}
					
				}
				
			}
		}
		
		
		public static   string getEnumName(global::System.Type e)
		{
			unchecked 
			{
				string ret = global::haxe.lang.Runtime.toString(((global::System.Type) (e) ));
				if (( ( ret.Length > 10 ) && ret.StartsWith("haxe.root.") )) 
				{
					ret = global::haxe.lang.StringExt.substr(ret, 10, default(global::haxe.lang.Null<int>));
				}
				
				if (( ( ret.Length == 14 ) && string.Equals(ret, "System.Boolean") )) 
				{
					return "Bool";
				}
				
				return ret;
			}
		}
		
		
		public static   global::System.Type resolveClass(string name)
		{
			unchecked 
			{
				if (( global::haxe.lang.StringExt.indexOf(name, ".", default(global::haxe.lang.Null<int>)) == -1 )) 
				{
					name = global::haxe.lang.Runtime.concat("haxe.root.", name);
				}
				
				global::System.Type t = global::System.Type.GetType(global::haxe.lang.Runtime.toString(name));
				if (global::haxe.lang.Runtime.typeEq(t, default(global::System.Type))) 
				{
					switch (name)
					{
						case "haxe.root.Int":
						{
							return ((global::System.Type) (typeof(int)) );
						}
						
						
						case "haxe.root.Float":
						{
							return ((global::System.Type) (typeof(double)) );
						}
						
						
						case "haxe.root.Class":
						{
							return ((global::System.Type) (typeof(global::System.Type)) );
						}
						
						
						case "haxe.root.Dynamic":
						{
							return ((global::System.Type) (typeof(object)) );
						}
						
						
						case "haxe.root.String":
						{
							return ((global::System.Type) (typeof(string)) );
						}
						
						
						default:
						{
							return default(global::System.Type);
						}
						
					}
					
				}
				 else 
				{
					if (( t.IsInterface && (((global::System.Type) (typeof(global::haxe.lang.IGenericObject)) )).IsAssignableFrom(((global::System.Type) (t) )) )) 
					{
						t = default(global::System.Type);
						int i = 0;
						string ts = "";
						while (( global::haxe.lang.Runtime.typeEq(t, default(global::System.Type)) && ( i < 18 ) ))
						{
							i++;
							ts = global::haxe.lang.Runtime.concat(ts, global::haxe.lang.Runtime.concat((( (( i == 1 )) ? ("") : (",") )), "System.Object"));
							t = global::System.Type.GetType(global::haxe.lang.Runtime.toString(global::haxe.lang.Runtime.concat(global::haxe.lang.Runtime.concat(global::haxe.lang.Runtime.concat(global::haxe.lang.Runtime.concat(global::haxe.lang.Runtime.concat(name, "`"), global::haxe.lang.Runtime.toString(i)), "["), ts), "]")));
						}
						
						return ((global::System.Type) (t) );
					}
					 else 
					{
						return ((global::System.Type) (t) );
					}
					
				}
				
			}
		}
		
		
		public static   global::System.Type resolveEnum(string name)
		{
			
		if (name == "Bool") return typeof(bool);
		System.Type t = resolveClass(name);
		if (t != null && (t.BaseType.Equals(typeof(System.Enum)) || t.BaseType.Equals(typeof(haxe.lang.Enum))))
			return t;
		return null;
	
		}
		
		
		public static   T createInstance<T>(global::System.Type cl, global::haxe.root.Array args)
		{
			unchecked 
			{
				if (global::haxe.lang.Runtime.refEq(cl, typeof(string))) 
				{
					return global::haxe.lang.Runtime.genericCast<T>(args[0]);
				}
				
				global::System.Type t = ((global::System.Type) (cl) );
				if (t.IsInterface) 
				{
					global::System.Type cl1 = global::haxe.root.Type.resolveClass(global::haxe.root.Type.getClassName(cl));
					t = cl1;
				}
				
				global::System.Reflection.ConstructorInfo[] ctors = t.GetConstructors();
				return global::haxe.lang.Runtime.genericCast<T>(global::haxe.lang.Runtime.callMethod(default(object), ((global::System.Reflection.MethodBase[]) (ctors) ), ( ctors as global::System.Array ).Length, args));
			}
		}
		
		
		public static   T createEmptyInstance<T>(global::System.Type cl)
		{
			unchecked 
			{
				global::System.Type t = ((global::System.Type) (cl) );
				if (t.IsInterface) 
				{
					global::System.Type cl1 = global::haxe.root.Type.resolveClass(global::haxe.root.Type.getClassName(cl));
					t = cl1;
				}
				
				if (global::haxe.root.Reflect.hasField(cl, "__hx_createEmpty")) 
				{
					return global::haxe.lang.Runtime.genericCast<T>(global::haxe.lang.Runtime.callField(cl, "__hx_createEmpty", 2084789794, default(global::haxe.root.Array)));
				}
				
				return global::haxe.root.Type.createInstance<T>(cl, new global::haxe.root.Array<object>(new object[]{}));
			}
		}
		
		
		public static   T createEnum<T>(global::System.Type e, string constr, global::haxe.root.Array @params)
		{
			
		if (@params == null || @params[0] == null)
		{
			object ret = haxe.lang.Runtime.slowGetField(e, constr, true);
			if (ret is haxe.lang.Function)
				throw haxe.lang.HaxeException.wrap("Constructor " + constr + " needs parameters");
			return (T) ret;
		} else {
			return (T) haxe.lang.Runtime.slowCallField(e, constr, @params);
		}
	
		}
		
		
		public static   T createEnumIndex<T>(global::System.Type e, int index, global::haxe.root.Array @params)
		{
			unchecked 
			{
				global::haxe.root.Array<object> constr = global::haxe.root.Type.getEnumConstructs(e);
				return global::haxe.root.Type.createEnum<T>(e, global::haxe.lang.Runtime.toString(constr[index]), @params);
			}
		}
		
		
		public static   global::haxe.root.Array<object> getInstanceFields(global::System.Type c)
		{
			
		if (c == typeof(string))
		{
			return haxe.lang.StringRefl.fields;
		}

		Array<object> ret = new Array<object>();

        System.Reflection.MemberInfo[] mis = c.GetMembers(System.Reflection.BindingFlags.Public | System.Reflection.BindingFlags.Instance | System.Reflection.BindingFlags.FlattenHierarchy);
        for (int i = 0; i < mis.Length; i++)
        {
			if (mis[i] is System.Reflection.PropertyInfo)
                continue;
			string n = mis[i].Name;
			if (!n.StartsWith("__hx_") && n[0] != '.' && !n.Equals("Equals") && !n.Equals("ToString") && !n.Equals("GetHashCode") && !n.Equals("GetType"))
				ret.push(mis[i].Name);
        }

		return ret;
	
		}
		
		
		public static   global::haxe.root.Array<object> getClassFields(global::System.Type c)
		{
			
		Array<object> ret = new Array<object>();

		if (c == typeof(string))
		{
			ret.push("fromCharCode");
			return ret;
		}

        System.Reflection.MemberInfo[] mis = c.GetMembers(System.Reflection.BindingFlags.Public | System.Reflection.BindingFlags.Static);
        for (int i = 0; i < mis.Length; i++)
        {
            string n = mis[i].Name;
			if (!n.StartsWith("__hx_"))
				ret.push(mis[i].Name);
        }

        return ret;
	
		}
		
		
		public static   global::haxe.root.Array<object> getEnumConstructs(global::System.Type e)
		{
			unchecked 
			{
				if (global::haxe.root.Reflect.hasField(e, "constructs")) 
				{
					return ((global::haxe.root.Array<object>) (global::haxe.root.Array<object>.__hx_cast<object>(((global::haxe.root.Array) (global::haxe.lang.Runtime.callField(global::haxe.lang.Runtime.getField(e, "constructs", 1744813180, true), "copy", 1103412149, default(global::haxe.root.Array))) ))) );
				}
				
				return new Array<object>(System.Enum.GetNames(e));
			}
		}
		
		
		public static   global::haxe.root.ValueType @typeof(object v)
		{
			
		if (v == null) return ValueType.TNull;

        System.Type t = v as System.Type;
        if (t != null)
        {
            //class type
            return ValueType.TObject;
        }

        t = v.GetType();
        if (t.IsEnum)
            return ValueType.TEnum(t);
        if (t.IsValueType)
        {
            System.IConvertible vc = v as System.IConvertible;
            if (vc != null)
            {
                switch (vc.GetTypeCode())
                {
                    case System.TypeCode.Boolean: return ValueType.TBool;
                    case System.TypeCode.Double:
						double d = vc.ToDouble(null);
						if (d >= int.MinValue && d <= int.MaxValue && d == vc.ToInt32(null))
							return ValueType.TInt;
						else
							return ValueType.TFloat;
                    case System.TypeCode.Int32:
                        return ValueType.TInt;
                    default:
                        return ValueType.TClass(t);
                }
            } else {
                return ValueType.TClass(t);
            }
        }

        if (v is haxe.lang.IHxObject)
        {
            if (v is haxe.lang.DynamicObject)
                return ValueType.TObject;
            else if (v is haxe.lang.Enum)
                return ValueType.TEnum(t);
            return ValueType.TClass(t);
        } else if (v is haxe.lang.Function) {
            return ValueType.TFunction;
        } else {
            return ValueType.TClass(t);
        }
	
		}
		
		
		public static   bool enumEq<T>(T a, T b)
		{
			
			if (a is haxe.lang.Enum)
				return a.Equals(b);
			else
				return haxe.lang.Runtime.eq(a, b);
	
		}
		
		
		public static   string enumConstructor(object e)
		{
			
		if (e is System.Enum)
			return e + "";
		else
			return ((haxe.lang.Enum) e).getTag();
	
		}
		
		
		public static   global::haxe.root.Array enumParameters(object e)
		{
			
		return ( e is System.Enum ) ? new Array<object>() : ((haxe.lang.Enum) e).@params;
	
		}
		
		
		public static   int enumIndex(object e)
		{
			
		if (e is System.Enum)
			return ((System.IConvertible) e).ToInt32(null);
		else
			return ((haxe.lang.Enum) e).index;
	
		}
		
		
		public static   global::haxe.root.Array<T> allEnums<T>(global::System.Type e)
		{
			unchecked 
			{
				global::haxe.root.Array<object> ctors = global::haxe.root.Type.getEnumConstructs(e);
				global::haxe.root.Array<T> ret = new global::haxe.root.Array<T>(new T[]{});
				{
					int _g = 0;
					while (( _g < ctors.length ))
					{
						string ctor = global::haxe.lang.Runtime.toString(ctors[_g]);
						 ++ _g;
						T v = global::haxe.lang.Runtime.genericCast<T>(global::haxe.root.Reflect.field(e, ctor));
						if (global::Std.@is(v, e)) 
						{
							ret.push(v);
						}
						
					}
					
				}
				
				return ret;
			}
		}
		
		
		public static  new object __hx_createEmpty()
		{
			unchecked 
			{
				return new global::haxe.root.Type(((global::haxe.lang.EmptyObject) (global::haxe.lang.EmptyObject.EMPTY) ));
			}
		}
		
		
		public static  new object __hx_create(global::haxe.root.Array arr)
		{
			unchecked 
			{
				return new global::haxe.root.Type();
			}
		}
		
		
	}
}


