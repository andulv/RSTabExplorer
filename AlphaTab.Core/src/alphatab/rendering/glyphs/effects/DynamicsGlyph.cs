using haxe.root;
#pragma warning disable 109, 114, 219, 429, 168, 162
namespace alphatab.rendering.glyphs.effects
{
	public  class DynamicsGlyph : global::alphatab.rendering.Glyph 
	{
		static DynamicsGlyph() 
		{
			global::alphatab.rendering.glyphs.effects.DynamicsGlyph.GlyphScale = 0.8;
		}
		public    DynamicsGlyph(global::haxe.lang.EmptyObject empty) : base(global::haxe.lang.EmptyObject.EMPTY)
		{
			unchecked 
			{
			}
		}
		
		
		public    DynamicsGlyph(global::haxe.lang.Null<int> x, global::haxe.lang.Null<int> y, global::alphatab.model.DynamicValue dynamics) : base(global::haxe.lang.EmptyObject.EMPTY)
		{
			unchecked 
			{
				global::alphatab.rendering.glyphs.effects.DynamicsGlyph.__hx_ctor_alphatab_rendering_glyphs_effects_DynamicsGlyph(this, x, y, dynamics);
			}
		}
		
		
		public static   void __hx_ctor_alphatab_rendering_glyphs_effects_DynamicsGlyph(global::alphatab.rendering.glyphs.effects.DynamicsGlyph __temp_me239, global::haxe.lang.Null<int> x, global::haxe.lang.Null<int> y, global::alphatab.model.DynamicValue dynamics)
		{
			unchecked 
			{
				int __temp_y238 = ( (global::haxe.lang.Runtime.eq((y).toDynamic(), (default(global::haxe.lang.Null<int>)).toDynamic())) ? (((int) (0) )) : (y.@value) );
				int __temp_x237 = ( (global::haxe.lang.Runtime.eq((x).toDynamic(), (default(global::haxe.lang.Null<int>)).toDynamic())) ? (((int) (0) )) : (x.@value) );
				global::alphatab.rendering.Glyph.__hx_ctor_alphatab_rendering_Glyph(__temp_me239, new global::haxe.lang.Null<int>(__temp_x237, true), new global::haxe.lang.Null<int>(__temp_y238, true));
				__temp_me239._dynamics = dynamics;
			}
		}
		
		
		public static  double GlyphScale;
		
		public static  new object __hx_createEmpty()
		{
			unchecked 
			{
				return new global::alphatab.rendering.glyphs.effects.DynamicsGlyph(((global::haxe.lang.EmptyObject) (global::haxe.lang.EmptyObject.EMPTY) ));
			}
		}
		
		
		public static  new object __hx_create(global::haxe.root.Array arr)
		{
			unchecked 
			{
				return new global::alphatab.rendering.glyphs.effects.DynamicsGlyph(global::haxe.lang.Null<object>.ofDynamic<int>(arr[0]), global::haxe.lang.Null<object>.ofDynamic<int>(arr[1]), ((global::alphatab.model.DynamicValue) (arr[2]) ));
			}
		}
		
		
		public  global::alphatab.model.DynamicValue _dynamics;
		
		public override   void paint(int cx, int cy, global::alphatab.platform.ICanvas canvas)
		{
			unchecked 
			{
				global::alphatab.rendering.RenderingResources res = this.renderer.stave.staveGroup.layout.renderer.renderingResources;
				canvas.setColor(res.mainGlyphColor);
				global::haxe.root.Array<object> glyphs = default(global::haxe.root.Array<object>);
				{
					global::alphatab.model.DynamicValue _g = this._dynamics;
					switch (global::haxe.root.Type.enumIndex(_g))
					{
						case 0:
						{
							glyphs = new global::haxe.root.Array<object>(new object[]{this.p(), this.p(), this.p()});
							break;
						}
						
						
						case 1:
						{
							glyphs = new global::haxe.root.Array<object>(new object[]{this.p(), this.p()});
							break;
						}
						
						
						case 2:
						{
							glyphs = new global::haxe.root.Array<object>(new object[]{this.p()});
							break;
						}
						
						
						case 3:
						{
							glyphs = new global::haxe.root.Array<object>(new object[]{this.m(), this.p()});
							break;
						}
						
						
						case 4:
						{
							glyphs = new global::haxe.root.Array<object>(new object[]{this.m(), this.f()});
							break;
						}
						
						
						case 5:
						{
							glyphs = new global::haxe.root.Array<object>(new object[]{this.f()});
							break;
						}
						
						
						case 6:
						{
							glyphs = new global::haxe.root.Array<object>(new object[]{this.f(), this.f()});
							break;
						}
						
						
						case 7:
						{
							glyphs = new global::haxe.root.Array<object>(new object[]{this.f(), this.f(), this.f()});
							break;
						}
						
						
					}
					
				}
				
				int glyphWidth = 0;
				{
					int _g1 = 0;
					while (( _g1 < glyphs.length ))
					{
						global::alphatab.rendering.Glyph g = ((global::alphatab.rendering.Glyph) (glyphs[_g1]) );
						 ++ _g1;
						glyphWidth += g.width;
					}
					
				}
				
				int startX = ( (( this.width - glyphWidth )) / 2 );
				{
					int _g2 = 0;
					while (( _g2 < glyphs.length ))
					{
						global::alphatab.rendering.Glyph g1 = ((global::alphatab.rendering.Glyph) (glyphs[_g2]) );
						 ++ _g2;
						g1.x = startX;
						g1.y = 0;
						g1.renderer = this.renderer;
						g1.paint(( cx + this.x ), ( cy + this.y ), canvas);
						startX += g1.width;
					}
					
				}
				
			}
		}
		
		
		public virtual   global::alphatab.rendering.glyphs.SvgGlyph p()
		{
			unchecked 
			{
				global::alphatab.rendering.glyphs.SvgGlyph p = new global::alphatab.rendering.glyphs.SvgGlyph(new global::haxe.lang.Null<int>(0, true), new global::haxe.lang.Null<int>(0, true), ((global::alphatab.rendering.glyphs.LazySvg) (global::alphatab.rendering.glyphs.MusicFont.DynamicP) ), ((double) (0.8) ), ((double) (0.8) ));
				p.width = ((int) (( 7 * this.renderer.stave.staveGroup.layout.renderer.settings.scale )) );
				return p;
			}
		}
		
		
		public virtual   global::alphatab.rendering.glyphs.SvgGlyph m()
		{
			unchecked 
			{
				global::alphatab.rendering.glyphs.SvgGlyph m = new global::alphatab.rendering.glyphs.SvgGlyph(new global::haxe.lang.Null<int>(0, true), new global::haxe.lang.Null<int>(0, true), ((global::alphatab.rendering.glyphs.LazySvg) (global::alphatab.rendering.glyphs.MusicFont.DynamicM) ), ((double) (0.8) ), ((double) (0.8) ));
				m.width = ((int) (( 7 * this.renderer.stave.staveGroup.layout.renderer.settings.scale )) );
				return m;
			}
		}
		
		
		public virtual   global::alphatab.rendering.glyphs.SvgGlyph f()
		{
			unchecked 
			{
				global::alphatab.rendering.glyphs.SvgGlyph f = new global::alphatab.rendering.glyphs.SvgGlyph(new global::haxe.lang.Null<int>(0, true), new global::haxe.lang.Null<int>(0, true), ((global::alphatab.rendering.glyphs.LazySvg) (global::alphatab.rendering.glyphs.MusicFont.DynamicF) ), ((double) (0.8) ), ((double) (0.8) ));
				f.width = ((int) (( 7 * this.renderer.stave.staveGroup.layout.renderer.settings.scale )) );
				return f;
			}
		}
		
		
		public override   object __hx_setField(string field, int hash, object @value, bool handleProperties)
		{
			unchecked 
			{
				switch (hash)
				{
					case 1684793203:
					{
						this._dynamics = ((global::alphatab.model.DynamicValue) (@value) );
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
					case 102:
					{
						return ((global::haxe.lang.Function) (new global::haxe.lang.Closure(((object) (this) ), global::haxe.lang.Runtime.toString("f"), ((int) (102) ))) );
					}
					
					
					case 109:
					{
						return ((global::haxe.lang.Function) (new global::haxe.lang.Closure(((object) (this) ), global::haxe.lang.Runtime.toString("m"), ((int) (109) ))) );
					}
					
					
					case 112:
					{
						return ((global::haxe.lang.Function) (new global::haxe.lang.Closure(((object) (this) ), global::haxe.lang.Runtime.toString("p"), ((int) (112) ))) );
					}
					
					
					case 1028568990:
					{
						return ((global::haxe.lang.Function) (new global::haxe.lang.Closure(((object) (this) ), global::haxe.lang.Runtime.toString("paint"), ((int) (1028568990) ))) );
					}
					
					
					case 1684793203:
					{
						return this._dynamics;
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
					case 1028568990:
					{
						return global::haxe.lang.Runtime.slowCallField(this, field, dynargs);
					}
					
					
					case 102:
					{
						return this.f();
					}
					
					
					case 109:
					{
						return this.m();
					}
					
					
					case 112:
					{
						return this.p();
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
				baseArr.push("_dynamics");
				{
					base.__hx_getFields(baseArr);
				}
				
			}
		}
		
		
	}
}


