using haxe.root;
#pragma warning disable 109, 114, 219, 429, 168, 162
namespace alphatab.rendering.glyphs{
	public  class ScoreTieGlyph : global::alphatab.rendering.glyphs.TieGlyph {
		public    ScoreTieGlyph(global::haxe.lang.EmptyObject empty) : base(global::haxe.lang.EmptyObject.EMPTY){
			unchecked {
			}
		}
		
		
		public    ScoreTieGlyph(global::alphatab.model.Note startNote, global::alphatab.model.Note endNote, global::alphatab.rendering.Glyph parent) : base(global::haxe.lang.EmptyObject.EMPTY){
			unchecked {
				global::alphatab.rendering.glyphs.ScoreTieGlyph.__hx_ctor_alphatab_rendering_glyphs_ScoreTieGlyph(this, startNote, endNote, parent);
			}
		}
		
		
		public static   void __hx_ctor_alphatab_rendering_glyphs_ScoreTieGlyph(global::alphatab.rendering.glyphs.ScoreTieGlyph __temp_me217, global::alphatab.model.Note startNote, global::alphatab.model.Note endNote, global::alphatab.rendering.Glyph parent){
			unchecked {
				global::alphatab.rendering.glyphs.TieGlyph.__hx_ctor_alphatab_rendering_glyphs_TieGlyph(__temp_me217, startNote, endNote, parent);
			}
		}
		
		
		public static  new object __hx_createEmpty(){
			unchecked {
				return new global::alphatab.rendering.glyphs.ScoreTieGlyph(((global::haxe.lang.EmptyObject) (global::haxe.lang.EmptyObject.EMPTY) ));
			}
		}
		
		
		public static  new object __hx_create(global::haxe.root.Array arr){
			unchecked {
				return new global::alphatab.rendering.glyphs.ScoreTieGlyph(((global::alphatab.model.Note) (arr[0]) ), ((global::alphatab.model.Note) (arr[1]) ), ((global::alphatab.rendering.Glyph) (arr[2]) ));
			}
		}
		
		
		public override   void paint(int cx, int cy, global::alphatab.platform.ICanvas canvas){
			unchecked {
				if (( ( this._endNote == default(global::alphatab.model.Note) ) || ( this._startNote.beat.index != this._endNote.beat.index ) )) {
					return ;
				}
				
				global::alphatab.rendering.ScoreBarRenderer r = ((global::alphatab.rendering.ScoreBarRenderer) (this.renderer) );
				global::alphatab.rendering.glyphs.BeatContainerGlyph parent = ((global::alphatab.rendering.glyphs.BeatContainerGlyph) (this._parent) );
				int startX = ( cx + r.getNoteX(this._startNote, default(global::haxe.lang.Null<bool>)) );
				int endX = default(int);
				if (( this._endNote == default(global::alphatab.model.Note) )) {
					endX = ( ( ( cx + parent.x ) + parent.postNotes.x ) + parent.postNotes.width );
				}
				 else {
					endX = ( cx + r.getNoteX(this._endNote, new global::haxe.lang.Null<bool>(false, true)) );
				}
				
				double startY = ( ( cy + r.getNoteY(this._startNote) ) + 4.5 );
				double endY = default(double);
				if (( this._endNote == default(global::alphatab.model.Note) )) {
					endY = startY;
				}
				 else {
					endY = ( ( cy + r.getNoteY(this._endNote) ) + 4.5 );
				}
				
				global::alphatab.rendering.glyphs.TieGlyph.paintTie(canvas, this.renderer.stave.staveGroup.layout.renderer.settings.scale, ((double) (startX) ), startY, ((double) (endX) ), endY, new global::haxe.lang.Null<bool>(( r.getBeatDirection(this._startNote.beat) == global::alphatab.rendering.utils.BeamDirection.Down ), true));
				canvas.setColor(this.renderer.stave.staveGroup.layout.renderer.renderingResources.mainGlyphColor);
				canvas.fill();
			}
		}
		
		
		public override   object __hx_getField(string field, int hash, bool throwErrors, bool isCheck, bool handleProperties){
			unchecked {
				switch (hash){
					case 1028568990:
					{
						return ((global::haxe.lang.Function) (new global::haxe.lang.Closure(((object) (this) ), ((string) ("paint") ), ((int) (1028568990) ))) );
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


