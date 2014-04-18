using haxe.root;
#pragma warning disable 109, 114, 219, 429, 168, 162
namespace alphatab.rendering
{
	public  class BarRendererFactory : global::haxe.lang.HxObject 
	{
		public    BarRendererFactory(global::haxe.lang.EmptyObject empty)
		{
			unchecked 
			{
				{
				}
				
			}
		}
		
		
		public    BarRendererFactory()
		{
			unchecked 
			{
				global::alphatab.rendering.BarRendererFactory.__hx_ctor_alphatab_rendering_BarRendererFactory(this);
			}
		}
		
		
		public static   void __hx_ctor_alphatab_rendering_BarRendererFactory(global::alphatab.rendering.BarRendererFactory __temp_me28)
		{
			unchecked 
			{
				__temp_me28.isInAccolade = true;
			}
		}
		
		
		public static  new object __hx_createEmpty()
		{
			unchecked 
			{
				return new global::alphatab.rendering.BarRendererFactory(((global::haxe.lang.EmptyObject) (global::haxe.lang.EmptyObject.EMPTY) ));
			}
		}
		
		
		public static  new object __hx_create(global::haxe.root.Array arr)
		{
			unchecked 
			{
				return new global::alphatab.rendering.BarRendererFactory();
			}
		}
		
		
		public  bool isInAccolade;
		
		public virtual   global::alphatab.rendering.BarRendererBase create(global::alphatab.model.Bar bar)
		{
			unchecked 
			{
				return default(global::alphatab.rendering.BarRendererBase);
			}
		}
		
		
		public override   object __hx_setField(string field, int hash, object @value, bool handleProperties)
		{
			unchecked 
			{
				switch (hash)
				{
					case 897413587:
					{
						this.isInAccolade = ((bool) (@value) );
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
					case 2081384188:
					{
						return ((global::haxe.lang.Function) (new global::haxe.lang.Closure(((object) (this) ), global::haxe.lang.Runtime.toString("create"), ((int) (2081384188) ))) );
					}
					
					
					case 897413587:
					{
						return this.isInAccolade;
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
					case 2081384188:
					{
						return this.create(((global::alphatab.model.Bar) (dynargs[0]) ));
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
				baseArr.push("isInAccolade");
				{
					base.__hx_getFields(baseArr);
				}
				
			}
		}
		
		
	}
}


