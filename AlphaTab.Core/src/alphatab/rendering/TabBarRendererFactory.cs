using haxe.root;
#pragma warning disable 109, 114, 219, 429, 168, 162
namespace alphatab.rendering
{
	public  class TabBarRendererFactory : global::alphatab.rendering.BarRendererFactory 
	{
		public    TabBarRendererFactory(global::haxe.lang.EmptyObject empty) : base(global::haxe.lang.EmptyObject.EMPTY)
		{
			unchecked 
			{
			}
		}
		
		
		public    TabBarRendererFactory() : base(global::haxe.lang.EmptyObject.EMPTY)
		{
			unchecked 
			{
				global::alphatab.rendering.TabBarRendererFactory.__hx_ctor_alphatab_rendering_TabBarRendererFactory(this);
			}
		}
		
		
		public static   void __hx_ctor_alphatab_rendering_TabBarRendererFactory(global::alphatab.rendering.TabBarRendererFactory __temp_me45)
		{
			unchecked 
			{
				global::alphatab.rendering.BarRendererFactory.__hx_ctor_alphatab_rendering_BarRendererFactory(__temp_me45);
			}
		}
		
		
		public static  new object __hx_createEmpty()
		{
			unchecked 
			{
				return new global::alphatab.rendering.TabBarRendererFactory(((global::haxe.lang.EmptyObject) (global::haxe.lang.EmptyObject.EMPTY) ));
			}
		}
		
		
		public static  new object __hx_create(global::haxe.root.Array arr)
		{
			unchecked 
			{
				return new global::alphatab.rendering.TabBarRendererFactory();
			}
		}
		
		
		public override   global::alphatab.rendering.BarRendererBase create(global::alphatab.model.Bar bar)
		{
			unchecked 
			{
				return new global::alphatab.rendering.TabBarRenderer(((global::alphatab.model.Bar) (bar) ));
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
					
					
					default:
					{
						return base.__hx_getField(field, hash, throwErrors, isCheck, handleProperties);
					}
					
				}
				
			}
		}
		
		
	}
}


