using haxe.root;
#pragma warning disable 109, 114, 219, 429, 168, 162
namespace alphatab.rendering.glyphs
{
	public  class TabClefGlyph : global::alphatab.rendering.Glyph 
	{
		public    TabClefGlyph(global::haxe.lang.EmptyObject empty) : base(global::haxe.lang.EmptyObject.EMPTY)
		{
			unchecked 
			{
			}
		}
		
		
		public    TabClefGlyph() : base(global::haxe.lang.EmptyObject.EMPTY)
		{
			unchecked 
			{
				global::alphatab.rendering.glyphs.TabClefGlyph.__hx_ctor_alphatab_rendering_glyphs_TabClefGlyph(this);
			}
		}
		
		
		public static   void __hx_ctor_alphatab_rendering_glyphs_TabClefGlyph(global::alphatab.rendering.glyphs.TabClefGlyph __temp_me216)
		{
			unchecked 
			{
				global::alphatab.rendering.Glyph.__hx_ctor_alphatab_rendering_Glyph(__temp_me216, new global::haxe.lang.Null<int>(0, true), new global::haxe.lang.Null<int>(0, true));
			}
		}
		
		
		public static  new object __hx_createEmpty()
		{
			unchecked 
			{
				return new global::alphatab.rendering.glyphs.TabClefGlyph(((global::haxe.lang.EmptyObject) (global::haxe.lang.EmptyObject.EMPTY) ));
			}
		}
		
		
		public static  new object __hx_create(global::haxe.root.Array arr)
		{
			unchecked 
			{
				return new global::alphatab.rendering.glyphs.TabClefGlyph();
			}
		}
		
		
		public override   void doLayout()
		{
			unchecked 
			{
				this.width = ((int) (( 28 * this.renderer.stave.staveGroup.layout.renderer.settings.scale )) );
			}
		}
		
		
		public override   bool canScale()
		{
			unchecked 
			{
				return false;
			}
		}
		
		
		public override   void paint(int cx, int cy, global::alphatab.platform.ICanvas canvas)
		{
			unchecked 
			{
				global::alphatab.rendering.TabBarRenderer tabBarRenderer = ((global::alphatab.rendering.TabBarRenderer) (this.renderer) );
				global::alphatab.model.Track track = this.renderer.stave.staveGroup.layout.renderer.track;
				global::alphatab.rendering.RenderingResources res = this.renderer.stave.staveGroup.layout.renderer.renderingResources;
				double startY = ( ( cy + this.y ) + ( ( 10 * this.renderer.stave.staveGroup.layout.renderer.settings.scale ) * 0.6 ) );
				int endY = ( ( cy + this.y ) + tabBarRenderer.getTabY(track.tuning.length, new global::haxe.lang.Null<int>(-2, true)) );
				double fontScale = ((double) (1) );
				double correction = ((double) (0) );
				{
					int _g = track.tuning.length;
					switch (_g)
					{
						case 4:
						{
							fontScale = 0.6;
							break;
						}
						
						
						case 5:
						{
							fontScale = 0.8;
							break;
						}
						
						
						case 6:
						{
							fontScale = 1.1;
							correction = ((double) (1) );
							break;
						}
						
						
						case 7:
						{
							fontScale = 1.15;
							break;
						}
						
						
						case 8:
						{
							fontScale = 1.35;
							break;
						}
						
						
					}
					
				}
				
				global::alphatab.platform.model.Font font = res.tabClefFont.clone();
				font.setSize(( font.getSize() * fontScale ));
				canvas.setColor(res.mainGlyphColor);
				canvas.setFont(font);
				canvas.setTextAlign(global::alphatab.platform.model.TextAlign.Center);
				canvas.fillText("T", ((double) (( ( cx + this.x ) + ( this.width / 2 ) )) ), startY);
				canvas.fillText("A", ((double) (( ( cx + this.x ) + ( this.width / 2 ) )) ), ( ( startY + font.getSize() ) - ((int) (( correction * this.renderer.stave.staveGroup.layout.renderer.settings.scale )) ) ));
				canvas.fillText("B", ((double) (( ( cx + this.x ) + ( this.width / 2 ) )) ), ( startY + ( (( font.getSize() - ((int) (( correction * this.renderer.stave.staveGroup.layout.renderer.settings.scale )) ) )) * 2 ) ));
			}
		}
		
		
		public override   object __hx_getField(string field, int hash, bool throwErrors, bool isCheck, bool handleProperties)
		{
			unchecked 
			{
				switch (hash)
				{
					case 1028568990:
					{
						return ((global::haxe.lang.Function) (new global::haxe.lang.Closure(((object) (this) ), global::haxe.lang.Runtime.toString("paint"), ((int) (1028568990) ))) );
					}
					
					
					case 1734479962:
					{
						return ((global::haxe.lang.Function) (new global::haxe.lang.Closure(((object) (this) ), global::haxe.lang.Runtime.toString("canScale"), ((int) (1734479962) ))) );
					}
					
					
					case 1825584277:
					{
						return ((global::haxe.lang.Function) (new global::haxe.lang.Closure(((object) (this) ), global::haxe.lang.Runtime.toString("doLayout"), ((int) (1825584277) ))) );
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


