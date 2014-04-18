using haxe.root;
#pragma warning disable 109, 114, 219, 429, 168, 162
namespace alphatab.rendering.layout
{
	public  class ScoreLayout : global::haxe.lang.HxObject 
	{
		public    ScoreLayout(global::haxe.lang.EmptyObject empty)
		{
			unchecked 
			{
				{
				}
				
			}
		}
		
		
		public    ScoreLayout(global::alphatab.rendering.ScoreRenderer renderer)
		{
			unchecked 
			{
				global::alphatab.rendering.layout.ScoreLayout.__hx_ctor_alphatab_rendering_layout_ScoreLayout(this, renderer);
			}
		}
		
		
		public static   void __hx_ctor_alphatab_rendering_layout_ScoreLayout(global::alphatab.rendering.layout.ScoreLayout __temp_me24, global::alphatab.rendering.ScoreRenderer renderer)
		{
			unchecked 
			{
				__temp_me24.renderer = renderer;
			}
		}
		
		
		public static  new object __hx_createEmpty()
		{
			unchecked 
			{
				return new global::alphatab.rendering.layout.ScoreLayout(((global::haxe.lang.EmptyObject) (global::haxe.lang.EmptyObject.EMPTY) ));
			}
		}
		
		
		public static  new object __hx_create(global::haxe.root.Array arr)
		{
			unchecked 
			{
				return new global::alphatab.rendering.layout.ScoreLayout(((global::alphatab.rendering.ScoreRenderer) (arr[0]) ));
			}
		}
		
		
		public  global::alphatab.rendering.ScoreRenderer renderer;
		
		public  int width;
		
		public  int height;
		
		public virtual   void doLayout()
		{
			unchecked 
			{
				{
				}
				
			}
		}
		
		
		public virtual   void paintScore()
		{
			unchecked 
			{
				{
				}
				
			}
		}
		
		
		public   double getScale()
		{
			unchecked 
			{
				return this.renderer.settings.scale;
			}
		}
		
		
		public virtual   global::alphatab.rendering.staves.StaveGroup createEmptyStaveGroup()
		{
			unchecked 
			{
				global::alphatab.rendering.staves.StaveGroup @group = new global::alphatab.rendering.staves.StaveGroup();
				@group.layout = this;
				{
					int _g = 0;
					global::haxe.root.Array<object> _g1 = this.renderer.settings.staves;
					while (( _g < _g1.length ))
					{
						global::alphatab.StaveSettings s = ((global::alphatab.StaveSettings) (_g1[_g]) );
						 ++ _g;
						if (global::alphatab.Environment.staveFactories.exists(s.id)) 
						{
							@group.addStave(new global::alphatab.rendering.staves.Stave(((global::alphatab.rendering.BarRendererFactory) (((global::haxe.lang.Function) (global::alphatab.Environment.staveFactories.@get(s.id).@value) ).__hx_invoke1_o(default(double), this)) )));
						}
						
					}
					
				}
				
				return @group;
			}
		}
		
		
		public override   double __hx_setField_f(string field, int hash, double @value, bool handleProperties)
		{
			unchecked 
			{
				switch (hash)
				{
					case 38537191:
					{
						this.height = ((int) (@value) );
						return @value;
					}
					
					
					case 1247983110:
					{
						this.width = ((int) (@value) );
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
					case 38537191:
					{
						this.height = ((int) (global::haxe.lang.Runtime.toInt(@value)) );
						return @value;
					}
					
					
					case 1247983110:
					{
						this.width = ((int) (global::haxe.lang.Runtime.toInt(@value)) );
						return @value;
					}
					
					
					case 853263683:
					{
						this.renderer = ((global::alphatab.rendering.ScoreRenderer) (@value) );
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
					case 1208461889:
					{
						return ((global::haxe.lang.Function) (new global::haxe.lang.Closure(((object) (this) ), global::haxe.lang.Runtime.toString("createEmptyStaveGroup"), ((int) (1208461889) ))) );
					}
					
					
					case 1487265300:
					{
						return ((global::haxe.lang.Function) (new global::haxe.lang.Closure(((object) (this) ), global::haxe.lang.Runtime.toString("getScale"), ((int) (1487265300) ))) );
					}
					
					
					case 1331941076:
					{
						return ((global::haxe.lang.Function) (new global::haxe.lang.Closure(((object) (this) ), global::haxe.lang.Runtime.toString("paintScore"), ((int) (1331941076) ))) );
					}
					
					
					case 1825584277:
					{
						return ((global::haxe.lang.Function) (new global::haxe.lang.Closure(((object) (this) ), global::haxe.lang.Runtime.toString("doLayout"), ((int) (1825584277) ))) );
					}
					
					
					case 38537191:
					{
						return this.height;
					}
					
					
					case 1247983110:
					{
						return this.width;
					}
					
					
					case 853263683:
					{
						return this.renderer;
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
					case 38537191:
					{
						return ((double) (this.height) );
					}
					
					
					case 1247983110:
					{
						return ((double) (this.width) );
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
					case 1208461889:
					{
						return this.createEmptyStaveGroup();
					}
					
					
					case 1487265300:
					{
						return this.getScale();
					}
					
					
					case 1331941076:
					{
						this.paintScore();
						break;
					}
					
					
					case 1825584277:
					{
						this.doLayout();
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
				baseArr.push("height");
				baseArr.push("width");
				baseArr.push("renderer");
				{
					base.__hx_getFields(baseArr);
				}
				
			}
		}
		
		
	}
}


