using haxe.root;
#pragma warning disable 109, 114, 219, 429, 168, 162
namespace haxe.root
{
	public  class Reflect : global::haxe.lang.HxObject 
	{
		public    Reflect(global::haxe.lang.EmptyObject empty)
		{
			unchecked 
			{
				{
				}
				
			}
		}
		
		
		public    Reflect()
		{
			unchecked 
			{
				global::haxe.root.Reflect.__hx_ctor__Reflect(this);
			}
		}
		
		
		public static   void __hx_ctor__Reflect(global::haxe.root.Reflect __temp_me7)
		{
			unchecked 
			{
				{
				}
				
			}
		}
		
		
		public static   bool hasField(object o, string field)
		{
			
		if (o is haxe.lang.IHxObject)
			return ((haxe.lang.IHxObject) o).__hx_getField(field, haxe.lang.FieldLookup.hash(field), false, true, false) != haxe.lang.Runtime.undefined;

		return haxe.lang.Runtime.slowHasField(o, field);
	
		}
		
		
		public static   object field(object o, string field)
		{
			
		if (o is haxe.lang.IHxObject)
			return ((haxe.lang.IHxObject) o).__hx_getField(field, haxe.lang.FieldLookup.hash(field), false, false, false);

		return haxe.lang.Runtime.slowGetField(o, field, false);
	
		}
		
		
		public static   void setField(object o, string field, object @value)
		{
			
		if (o is haxe.lang.IHxObject)
			((haxe.lang.IHxObject) o).__hx_setField(field, haxe.lang.FieldLookup.hash(field), value, false);
		else
			haxe.lang.Runtime.slowSetField(o, field, value);
	
		}
		
		
		public static   object getProperty(object o, string field)
		{
			
		if (o is haxe.lang.IHxObject)
			return ((haxe.lang.IHxObject) o).__hx_getField(field, haxe.lang.FieldLookup.hash(field), false, false, true);

		if (haxe.lang.Runtime.slowHasField(o, "get_" + field))
			return haxe.lang.Runtime.slowCallField(o, "get_" + field, null);

		return haxe.lang.Runtime.slowGetField(o, field, false);
	
		}
		
		
		public static   void setProperty(object o, string field, object @value)
		{
			
		if (o is haxe.lang.IHxObject)
			((haxe.lang.IHxObject) o).__hx_setField(field, haxe.lang.FieldLookup.hash(field), value, true);
		else if (haxe.lang.Runtime.slowHasField(o, "set_" + field))
			haxe.lang.Runtime.slowCallField(o, "set_" + field, new Array<object>(new object[]{value}));
		else
			haxe.lang.Runtime.slowSetField(o, field, value);
	
		}
		
		
		public static   object callMethod(object o, object func, global::haxe.root.Array args)
		{
			
		return ((haxe.lang.Function) func).__hx_invokeDynamic(args);
	
		}
		
		
		public static   global::haxe.root.Array<object> fields(object o)
		{
			
		if (o is haxe.lang.IHxObject)
		{
			Array<object> ret = new Array<object>();
				((haxe.lang.IHxObject) o).__hx_getFields(ret);
			return ret;
		} else if (o is System.Type) {
			return Type.getClassFields( (System.Type) o);
		} else {
			return new Array<object>();
		}
	
		}
		
		
		public static   bool isFunction(object f)
		{
			
		return f is haxe.lang.Function;
	
		}
		
		
		public static   int compare<T>(T a, T b)
		{
			
		return haxe.lang.Runtime.compare(a, b);
	
		}
		
		
		public static   bool compareMethods(object f1, object f2)
		{
			
		if (f1 == f2)
			return true;

		if (f1 is haxe.lang.Closure && f2 is haxe.lang.Closure)
		{
			haxe.lang.Closure f1c = (haxe.lang.Closure) f1;
			haxe.lang.Closure f2c = (haxe.lang.Closure) f2;

			return haxe.lang.Runtime.refEq(f1c.obj, f2c.obj) && f1c.field.Equals(f2c.field);
		}

		return false;
	
		}
		
		
		public static   bool isObject(object v)
		{
			
		return v != null && !(v is haxe.lang.Enum || v is haxe.lang.Function || v is System.ValueType);
	
		}
		
		
		public static   bool isEnumValue(object v)
		{
			
		return v != null && (v is haxe.lang.Enum || v is System.Enum);
	
		}
		
		
		public static   bool deleteField(object o, string field)
		{
			
		return (o is haxe.lang.DynamicObject && ((haxe.lang.DynamicObject) o).__hx_deleteField(field, haxe.lang.FieldLookup.hash(field)));
	
		}
		
		
		public static   T copy<T>(T o)
		{
			unchecked 
			{
				object o2 = new global::haxe.lang.DynamicObject(new global::haxe.root.Array<int>(new int[]{}), new global::haxe.root.Array<object>(new object[]{}), new global::haxe.root.Array<int>(new int[]{}), new global::haxe.root.Array<double>(new double[]{}));
				{
					int _g = 0;
					global::haxe.root.Array<object> _g1 = global::haxe.root.Reflect.fields(o);
					while (( _g < _g1.length ))
					{
						string f = global::haxe.lang.Runtime.toString(_g1[_g]);
						 ++ _g;
						global::haxe.root.Reflect.setField(o2, f, global::haxe.root.Reflect.field(o, f));
					}
					
				}
				
				return global::haxe.lang.Runtime.genericCast<T>(o2);
			}
		}
		
		
		public static   object makeVarArgs(global::haxe.lang.Function f)
		{
			unchecked 
			{
				return new global::haxe.lang.VarArgsFunction(((global::haxe.lang.Function) (f) ));
			}
		}
		
		
		public static  new object __hx_createEmpty()
		{
			unchecked 
			{
				return new global::haxe.root.Reflect(((global::haxe.lang.EmptyObject) (global::haxe.lang.EmptyObject.EMPTY) ));
			}
		}
		
		
		public static  new object __hx_create(global::haxe.root.Array arr)
		{
			unchecked 
			{
				return new global::haxe.root.Reflect();
			}
		}
		
		
	}
}


