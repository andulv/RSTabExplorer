using haxe.root;
#pragma warning disable 109, 114, 219, 429, 168, 162
namespace alphatab.rendering.glyphs
{
	public  class TabBeatPreNotesGlyph : global::alphatab.rendering.glyphs.BeatGlyphBase 
	{
		public    TabBeatPreNotesGlyph(global::haxe.lang.EmptyObject empty) : base(global::haxe.lang.EmptyObject.EMPTY)
		{
			unchecked 
			{
			}
		}
		
		
		public    TabBeatPreNotesGlyph() : base(global::haxe.lang.EmptyObject.EMPTY)
		{
			unchecked 
			{
				global::alphatab.rendering.glyphs.TabBeatPreNotesGlyph.__hx_ctor_alphatab_rendering_glyphs_TabBeatPreNotesGlyph(this);
			}
		}
		
		
		public static   void __hx_ctor_alphatab_rendering_glyphs_TabBeatPreNotesGlyph(global::alphatab.rendering.glyphs.TabBeatPreNotesGlyph __temp_me214)
		{
			unchecked 
			{
				global::alphatab.rendering.glyphs.BeatGlyphBase.__hx_ctor_alphatab_rendering_glyphs_BeatGlyphBase(__temp_me214);
			}
		}
		
		
		public static  new object __hx_createEmpty()
		{
			unchecked 
			{
				return new global::alphatab.rendering.glyphs.TabBeatPreNotesGlyph(((global::haxe.lang.EmptyObject) (global::haxe.lang.EmptyObject.EMPTY) ));
			}
		}
		
		
		public static  new object __hx_create(global::haxe.root.Array arr)
		{
			unchecked 
			{
				return new global::alphatab.rendering.glyphs.TabBeatPreNotesGlyph();
			}
		}
		
		
		public override   void doLayout()
		{
			unchecked 
			{
				if (( this.container.beat.brushType != global::alphatab.model.BrushType.None )) 
				{
					this.addGlyph(new global::alphatab.rendering.glyphs.TabBrushGlyph(((global::alphatab.model.Beat) (this.container.beat) )));
					this.addGlyph(new global::alphatab.rendering.glyphs.SpacingGlyph(new global::haxe.lang.Null<int>(0, true), new global::haxe.lang.Null<int>(0, true), ((int) (( 4 * this.renderer.stave.staveGroup.layout.renderer.settings.scale )) ), ((global::haxe.lang.Null<bool>) (default(global::haxe.lang.Null<bool>)) )));
				}
				
				base.doLayout();
			}
		}
		
		
		public override   object __hx_getField(string field, int hash, bool throwErrors, bool isCheck, bool handleProperties)
		{
			unchecked 
			{
				switch (hash)
				{
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


