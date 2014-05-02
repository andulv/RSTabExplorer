using haxe.root;
#pragma warning disable 109, 114, 219, 429, 168, 162
namespace alphatab.rendering.effects{
	public  class NoteVibratoEffectInfo : global::alphatab.rendering.effects.NoteEffectInfoBase {
		public    NoteVibratoEffectInfo(global::haxe.lang.EmptyObject empty) : base(global::haxe.lang.EmptyObject.EMPTY){
			unchecked {
			}
		}
		
		
		public    NoteVibratoEffectInfo() : base(global::haxe.lang.EmptyObject.EMPTY){
			unchecked {
				global::alphatab.rendering.effects.NoteVibratoEffectInfo.__hx_ctor_alphatab_rendering_effects_NoteVibratoEffectInfo(this);
			}
		}
		
		
		public static   void __hx_ctor_alphatab_rendering_effects_NoteVibratoEffectInfo(global::alphatab.rendering.effects.NoteVibratoEffectInfo __temp_me37){
			unchecked {
				global::alphatab.rendering.effects.NoteEffectInfoBase.__hx_ctor_alphatab_rendering_effects_NoteEffectInfoBase(__temp_me37);
			}
		}
		
		
		public static  new object __hx_createEmpty(){
			unchecked {
				return new global::alphatab.rendering.effects.NoteVibratoEffectInfo(((global::haxe.lang.EmptyObject) (global::haxe.lang.EmptyObject.EMPTY) ));
			}
		}
		
		
		public static  new object __hx_create(global::haxe.root.Array arr){
			unchecked {
				return new global::alphatab.rendering.effects.NoteVibratoEffectInfo();
			}
		}
		
		
		public override   bool shouldCreateGlyphForNote(global::alphatab.rendering.EffectBarRenderer renderer, global::alphatab.model.Note note){
			unchecked {
				return ( ( note.vibrato != global::alphatab.model.VibratoType.None ) || ( note.isTieDestination && ( note.tieOrigin.vibrato != global::alphatab.model.VibratoType.None ) ) );
			}
		}
		
		
		public override   global::alphatab.rendering.EffectBarGlyphSizing getSizingMode(){
			unchecked {
				return global::alphatab.rendering.EffectBarGlyphSizing.GroupedOnBeatToPostBeat;
			}
		}
		
		
		public override   int getHeight(global::alphatab.rendering.EffectBarRenderer renderer){
			unchecked {
				return ((int) (( 15 * renderer.stave.staveGroup.layout.renderer.settings.scale )) );
			}
		}
		
		
		public override   global::alphatab.rendering.Glyph createNewGlyph(global::alphatab.rendering.EffectBarRenderer renderer, global::alphatab.model.Beat beat){
			unchecked {
				return new global::alphatab.rendering.glyphs.effects.VibratoGlyph(new global::haxe.lang.Null<int>(0, true), new global::haxe.lang.Null<int>(((int) (( 5 * renderer.stave.staveGroup.layout.renderer.settings.scale )) ), true), ((global::haxe.lang.Null<double>) (default(global::haxe.lang.Null<double>)) ));
			}
		}
		
		
		public override   object __hx_getField(string field, int hash, bool throwErrors, bool isCheck, bool handleProperties){
			unchecked {
				switch (hash){
					case 193577032:
					{
						return ((global::haxe.lang.Function) (new global::haxe.lang.Closure(((object) (this) ), ((string) ("createNewGlyph") ), ((int) (193577032) ))) );
					}
					
					
					case 2124583197:
					{
						return ((global::haxe.lang.Function) (new global::haxe.lang.Closure(((object) (this) ), ((string) ("getHeight") ), ((int) (2124583197) ))) );
					}
					
					
					case 268685047:
					{
						return ((global::haxe.lang.Function) (new global::haxe.lang.Closure(((object) (this) ), ((string) ("getSizingMode") ), ((int) (268685047) ))) );
					}
					
					
					case 1906986366:
					{
						return ((global::haxe.lang.Function) (new global::haxe.lang.Closure(((object) (this) ), ((string) ("shouldCreateGlyphForNote") ), ((int) (1906986366) ))) );
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


