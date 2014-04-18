using haxe.root;
#pragma warning disable 109, 114, 219, 429, 168, 162
namespace alphatab.rendering.glyphs
{
	public  class TabTieGlyph : global::alphatab.rendering.glyphs.TieGlyph 
	{
		public    TabTieGlyph(global::haxe.lang.EmptyObject empty) : base(global::haxe.lang.EmptyObject.EMPTY)
		{
			unchecked 
			{
			}
		}
		
		
		public    TabTieGlyph(global::alphatab.model.Note startNote, global::alphatab.model.Note endNote, global::alphatab.rendering.Glyph parent) : base(global::haxe.lang.EmptyObject.EMPTY)
		{
			unchecked 
			{
				global::alphatab.rendering.glyphs.TabTieGlyph.__hx_ctor_alphatab_rendering_glyphs_TabTieGlyph(this, startNote, endNote, parent);
			}
		}
		
		
		public static   void __hx_ctor_alphatab_rendering_glyphs_TabTieGlyph(global::alphatab.rendering.glyphs.TabTieGlyph __temp_me222, global::alphatab.model.Note startNote, global::alphatab.model.Note endNote, global::alphatab.rendering.Glyph parent)
		{
			unchecked 
			{
				global::alphatab.rendering.glyphs.TieGlyph.__hx_ctor_alphatab_rendering_glyphs_TieGlyph(__temp_me222, startNote, endNote, parent);
			}
		}
		
		
		public static  new object __hx_createEmpty()
		{
			unchecked 
			{
				return new global::alphatab.rendering.glyphs.TabTieGlyph(((global::haxe.lang.EmptyObject) (global::haxe.lang.EmptyObject.EMPTY) ));
			}
		}
		
		
		public static  new object __hx_create(global::haxe.root.Array arr)
		{
			unchecked 
			{
				return new global::alphatab.rendering.glyphs.TabTieGlyph(((global::alphatab.model.Note) (arr[0]) ), ((global::alphatab.model.Note) (arr[1]) ), ((global::alphatab.rendering.Glyph) (arr[2]) ));
			}
		}
		
		
		public override   void paint(int cx, int cy, global::alphatab.platform.ICanvas canvas)
		{
			unchecked 
			{
				if (( ( this._endNote == default(global::alphatab.model.Note) ) || ( this._startNote.beat.index != this._endNote.beat.index ) )) 
				{
					return ;
				}
				
				global::alphatab.rendering.TabBarRenderer r = ((global::alphatab.rendering.TabBarRenderer) (this.renderer) );
				global::alphatab.rendering.glyphs.TabBeatContainerGlyph parent = ((global::alphatab.rendering.glyphs.TabBeatContainerGlyph) (this._parent) );
				global::alphatab.rendering.RenderingResources res = r.stave.staveGroup.layout.renderer.renderingResources;
				int startX = ( cx + r.getNoteX(this._startNote, default(global::haxe.lang.Null<bool>)) );
				int endX = default(int);
				if (( this._endNote == default(global::alphatab.model.Note) )) 
				{
					endX = ( ( ( cx + parent.x ) + parent.postNotes.x ) + parent.postNotes.width );
				}
				 else 
				{
					endX = ( cx + r.getNoteX(this._endNote, new global::haxe.lang.Null<bool>(false, true)) );
				}
				
				bool down = ( this._startNote.@string > 3 );
				double offset = ( res.tablatureFont.getSize() / 2 );
				if (down) 
				{
					offset *= ((double) (-1) );
				}
				
				double startY = ( ( cy + r.getNoteY(this._startNote) ) + offset );
				double endY = default(double);
				if (( this._endNote == default(global::alphatab.model.Note) )) 
				{
					endY = startY;
				}
				 else 
				{
					endY = ( ( cy + r.getNoteY(this._endNote) ) + offset );
				}
				
				global::alphatab.rendering.glyphs.TieGlyph.paintTie(canvas, this.renderer.stave.staveGroup.layout.renderer.settings.scale, ((double) (startX) ), startY, ((double) (endX) ), endY, new global::haxe.lang.Null<bool>(( this._startNote.@string > 3 ), true));
				canvas.setColor(this.renderer.stave.staveGroup.layout.renderer.renderingResources.mainGlyphColor);
				canvas.fill();
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
					
					
					default:
					{
						return base.__hx_getField(field, hash, throwErrors, isCheck, handleProperties);
					}
					
				}
				
			}
		}
		
		
	}
}


