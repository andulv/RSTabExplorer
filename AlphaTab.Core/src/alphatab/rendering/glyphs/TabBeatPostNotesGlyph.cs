using haxe.root;
#pragma warning disable 109, 114, 219, 429, 168, 162
namespace alphatab.rendering.glyphs{
	public  class TabBeatPostNotesGlyph : global::alphatab.rendering.glyphs.BeatGlyphBase {
		public    TabBeatPostNotesGlyph(global::haxe.lang.EmptyObject empty) : base(global::haxe.lang.EmptyObject.EMPTY){
			unchecked {
			}
		}
		
		
		public    TabBeatPostNotesGlyph() : base(global::haxe.lang.EmptyObject.EMPTY){
			unchecked {
				global::alphatab.rendering.glyphs.TabBeatPostNotesGlyph.__hx_ctor_alphatab_rendering_glyphs_TabBeatPostNotesGlyph(this);
			}
		}
		
		
		public static   void __hx_ctor_alphatab_rendering_glyphs_TabBeatPostNotesGlyph(global::alphatab.rendering.glyphs.TabBeatPostNotesGlyph __temp_me228){
			unchecked {
				global::alphatab.rendering.glyphs.BeatGlyphBase.__hx_ctor_alphatab_rendering_glyphs_BeatGlyphBase(__temp_me228);
			}
		}
		
		
		public static  new object __hx_createEmpty(){
			unchecked {
				return new global::alphatab.rendering.glyphs.TabBeatPostNotesGlyph(((global::haxe.lang.EmptyObject) (global::haxe.lang.EmptyObject.EMPTY) ));
			}
		}
		
		
		public static  new object __hx_create(global::haxe.root.Array arr){
			unchecked {
				return new global::alphatab.rendering.glyphs.TabBeatPostNotesGlyph();
			}
		}
		
		
		public override   void doLayout(){
			unchecked {
				global::haxe.root.Array<object> _g = new global::haxe.root.Array<object>(new object[]{this});
				this.noteLoop(new global::alphatab.rendering.glyphs.TabBeatPostNotesGlyph_doLayout_35__Fun(((global::haxe.root.Array<object>) (_g) )));
				int __temp_stmt628 = default(int);
				{
					double x = ( this.getBeatDurationWidth() * this.renderer.stave.staveGroup.layout.renderer.settings.scale );
					__temp_stmt628 = ((int) (x) );
				}
				
				this.addGlyph(new global::alphatab.rendering.glyphs.SpacingGlyph(new global::haxe.lang.Null<int>(0, true), new global::haxe.lang.Null<int>(0, true), ((int) (__temp_stmt628) ), ((global::haxe.lang.Null<bool>) (default(global::haxe.lang.Null<bool>)) )));
				base.doLayout();
			}
		}
		
		
		public virtual   void createNoteGlyphs(global::alphatab.model.Note n){
			unchecked {
				if (( n.trillValue >= 0 )) {
					this.addGlyph(new global::alphatab.rendering.glyphs.SpacingGlyph(new global::haxe.lang.Null<int>(0, true), new global::haxe.lang.Null<int>(0, true), ((int) (( 4 * this.renderer.stave.staveGroup.layout.renderer.settings.scale )) ), ((global::haxe.lang.Null<bool>) (default(global::haxe.lang.Null<bool>)) )));
					global::alphatab.model.Note trillNote = new global::alphatab.model.Note();
					trillNote.isGhost = true;
					trillNote.fret = ( n.trillValue - n.beat.voice.bar.track.tuning[( ( n.beat.voice.bar.track.tuning.length - (( n.@string - 1 )) ) - 1 )] );
					trillNote.@string = n.@string;
					global::alphatab.rendering.TabBarRenderer tr = default(global::alphatab.rendering.TabBarRenderer);
					tr = ((global::alphatab.rendering.TabBarRenderer) (this.renderer) );
					global::alphatab.rendering.Glyph trillNumberGlyph = new global::alphatab.rendering.glyphs.NoteNumberGlyph(new global::haxe.lang.Null<int>(0, true), new global::haxe.lang.Null<int>(0, true), ((global::alphatab.model.Note) (trillNote) ), global::haxe.lang.Runtime.toBool(true));
					int l = ( n.beat.voice.bar.track.tuning.length - n.@string );
					trillNumberGlyph.y = tr.getTabY(l, default(global::haxe.lang.Null<int>));
					this.addGlyph(trillNumberGlyph);
				}
				
				if (( n.bendPoints.length > 1 )) {
					int bendHeight = ((int) (( 60 * this.renderer.stave.staveGroup.layout.renderer.settings.scale )) );
					this.renderer.registerOverflowTop(bendHeight);
					int __temp_stmt629 = default(int);
					{
						double x = ( this.getBeatDurationWidth() * this.renderer.stave.staveGroup.layout.renderer.settings.scale );
						__temp_stmt629 = ((int) (x) );
					}
					
					this.addGlyph(new global::alphatab.rendering.glyphs.BendGlyph(((global::alphatab.model.Note) (n) ), ((int) (__temp_stmt629) ), ((int) (bendHeight) )));
				}
				
			}
		}
		
		
		public override   object __hx_getField(string field, int hash, bool throwErrors, bool isCheck, bool handleProperties){
			unchecked {
				switch (hash){
					case 26903797:
					{
						return ((global::haxe.lang.Function) (new global::haxe.lang.Closure(((object) (this) ), ((string) ("createNoteGlyphs") ), ((int) (26903797) ))) );
					}
					
					
					case 1825584277:
					{
						return ((global::haxe.lang.Function) (new global::haxe.lang.Closure(((object) (this) ), ((string) ("doLayout") ), ((int) (1825584277) ))) );
					}
					
					
					default:
					{
						return base.__hx_getField(field, hash, throwErrors, isCheck, handleProperties);
					}
					
				}
				
			}
		}
		
		
		public override   object __hx_invokeField(string field, int hash, global::haxe.root.Array dynargs){
			unchecked {
				switch (hash){
					case 1825584277:
					{
						return global::haxe.lang.Runtime.slowCallField(this, field, dynargs);
					}
					
					
					case 26903797:
					{
						this.createNoteGlyphs(((global::alphatab.model.Note) (dynargs[0]) ));
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
		
		
	}
}



#pragma warning disable 109, 114, 219, 429, 168, 162
namespace alphatab.rendering.glyphs{
	public  class TabBeatPostNotesGlyph_doLayout_35__Fun : global::haxe.lang.Function {
		public    TabBeatPostNotesGlyph_doLayout_35__Fun(global::haxe.root.Array<object> _g) : base(1, 0){
			unchecked {
				this._g = _g;
			}
		}
		
		
		public override   object __hx_invoke1_o(double __fn_float1, object __fn_dyn1){
			unchecked {
				global::alphatab.model.Note n = ( (global::haxe.lang.Runtime.eq(__fn_dyn1, global::haxe.lang.Runtime.undefined)) ? (((global::alphatab.model.Note) (((object) (__fn_float1) )) )) : (((global::alphatab.model.Note) (__fn_dyn1) )) );
				((global::alphatab.rendering.glyphs.TabBeatPostNotesGlyph) (this._g[0]) ).createNoteGlyphs(n);
				return default(object);
			}
		}
		
		
		public  global::haxe.root.Array<object> _g;
		
	}
}


