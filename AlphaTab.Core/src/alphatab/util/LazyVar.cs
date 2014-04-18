using haxe.root;
#pragma warning disable 109, 114, 219, 429, 168, 162
namespace alphatab.util
{
	public  class LazyVar<T> : global::haxe.lang.HxObject, global::alphatab.util.LazyVar 
	{
		public    LazyVar(global::haxe.lang.EmptyObject empty)
		{
			unchecked 
			{
				{
				}
				
			}
		}
		
		
		public    LazyVar(global::haxe.lang.Function loader)
		{
			unchecked 
			{
				global::alphatab.util.LazyVar<object>.__hx_ctor_alphatab_util_LazyVar<T>(this, loader);
			}
		}
		
		
		public static   void __hx_ctor_alphatab_util_LazyVar<T_c>(global::alphatab.util.LazyVar<T_c> __temp_me274, global::haxe.lang.Function loader)
		{
			unchecked 
			{
				__temp_me274._loader = loader;
			}
		}
		
		
		public static   object __hx_cast<T_c_c>(global::alphatab.util.LazyVar me)
		{
			unchecked 
			{
				return ( (( me != default(global::alphatab.util.LazyVar) )) ? (me.alphatab_util_LazyVar_cast<T_c_c>()) : (default(global::alphatab.util.LazyVar)) );
			}
		}
		
		
		public static  new object __hx_createEmpty()
		{
			unchecked 
			{
				return new global::alphatab.util.LazyVar<object>(((global::haxe.lang.EmptyObject) (global::haxe.lang.EmptyObject.EMPTY) ));
			}
		}
		
		
		public static  new object __hx_create(global::haxe.root.Array arr)
		{
			unchecked 
			{
				return new global::alphatab.util.LazyVar<object>(((global::haxe.lang.Function) (arr[0]) ));
			}
		}
		
		
		public virtual   object alphatab_util_LazyVar_cast<T_c>()
		{
			unchecked 
			{
				if (global::haxe.lang.Runtime.eq(typeof(T), typeof(T_c))) 
				{
					return this;
				}
				
				global::alphatab.util.LazyVar<T_c> new_me = new global::alphatab.util.LazyVar<T_c>(((global::haxe.lang.EmptyObject) (global::haxe.lang.EmptyObject.EMPTY) ));
				{
					object __temp_iterator451 = global::haxe.root.Reflect.fields(this).iterator();
					while (((bool) (global::haxe.lang.Runtime.callField(__temp_iterator451, "hasNext", 407283053, default(global::haxe.root.Array))) ))
					{
						string field = global::haxe.lang.Runtime.toString(global::haxe.lang.Runtime.callField(__temp_iterator451, "next", 1224901875, default(global::haxe.root.Array)));
						switch (field)
						{
							default:
							{
								global::haxe.root.Reflect.setField(new_me, field, ((object) (global::haxe.root.Reflect.field(this, field)) ));
								break;
							}
							
						}
						
					}
					
				}
				
				return new_me;
			}
		}
		
		
		public  T _val;
		
		public  global::haxe.lang.Function _loader;
		
		public  bool _loaded;
		
		public virtual   T getValue()
		{
			unchecked 
			{
				if ( ! (this._loaded) ) 
				{
					this._val = global::haxe.lang.Runtime.genericCast<T>(this._loader.__hx_invoke0_o());
					this._loaded = true;
				}
				
				return this._val;
			}
		}
		
		
		public override   double __hx_setField_f(string field, int hash, double @value, bool handleProperties)
		{
			unchecked 
			{
				switch (hash)
				{
					case 1059398626:
					{
						this._val = global::haxe.lang.Runtime.genericCast<T>(((object) (@value) ));
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
					case 1189501348:
					{
						this._loaded = ((bool) (@value) );
						return @value;
					}
					
					
					case 1189501362:
					{
						this._loader = ((global::haxe.lang.Function) (@value) );
						return @value;
					}
					
					
					case 1059398626:
					{
						this._val = global::haxe.lang.Runtime.genericCast<T>(@value);
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
					case 294620923:
					{
						return ((global::haxe.lang.Function) (new global::haxe.lang.Closure(((object) (this) ), global::haxe.lang.Runtime.toString("getValue"), ((int) (294620923) ))) );
					}
					
					
					case 1189501348:
					{
						return this._loaded;
					}
					
					
					case 1189501362:
					{
						return this._loader;
					}
					
					
					case 1059398626:
					{
						return this._val;
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
					case 1059398626:
					{
						return ((double) (global::haxe.lang.Runtime.toDouble(((object) (this._val) ))) );
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
					case 294620923:
					{
						return this.getValue();
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
				baseArr.push("_loaded");
				baseArr.push("_loader");
				baseArr.push("_val");
				{
					base.__hx_getFields(baseArr);
				}
				
			}
		}
		
		
	}
}



#pragma warning disable 109, 114, 219, 429, 168, 162
namespace alphatab.util
{
	public  interface LazyVar : global::haxe.lang.IHxObject, global::haxe.lang.IGenericObject 
	{
		   object alphatab_util_LazyVar_cast<T_c>();
		
	}
}


