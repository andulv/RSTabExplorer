using haxe.root;
#pragma warning disable 109, 114, 219, 429, 168, 162
namespace alphatab.rendering.glyphs{
	public  class ScoreBeatPostNotesGlyph : global::alphatab.rendering.glyphs.BeatGlyphBase {
		public    ScoreBeatPostNotesGlyph(global::haxe.lang.EmptyObject empty) : base(global::haxe.lang.EmptyObject.EMPTY){
			unchecked {
			}
		}
		
		
		public    ScoreBeatPostNotesGlyph() : base(global::haxe.lang.EmptyObject.EMPTY){
			unchecked {
				global::alphatab.rendering.glyphs.ScoreBeatPostNotesGlyph.__hx_ctor_alphatab_rendering_glyphs_ScoreBeatPostNotesGlyph(this);
			}
		}
		
		
		public static   void __hx_ctor_alphatab_rendering_glyphs_ScoreBeatPostNotesGlyph(global::alphatab.rendering.glyphs.ScoreBeatPostNotesGlyph __temp_me207){
			unchecked {
				global::alphatab.rendering.glyphs.BeatGlyphBase.__hx_ctor_alphatab_rendering_glyphs_BeatGlyphBase(__temp_me207);
			}
		}
		
		
		public static  new object __hx_createEmpty(){
			unchecked {
				return new global::alphatab.rendering.glyphs.ScoreBeatPostNotesGlyph(((global::haxe.lang.EmptyObject) (global::haxe.lang.EmptyObject.EMPTY) ));
			}
		}
		
		
		public static  new object __hx_create(global::haxe.root.Array arr){
			unchecked {
				return new global::alphatab.rendering.glyphs.ScoreBeatPostNotesGlyph();
			}
		}
		
		
		public override   void doLayout(){
			unchecked {
				int __temp_stmt626 = default(int);
				{
					double x = ( this.getBeatDurationWidth() * this.renderer.stave.staveGroup.layout.renderer.settings.scale );
					__temp_stmt626 = ((int) (x) );
				}
				
				this.addGlyph(new global::alphatab.rendering.glyphs.SpacingGlyph(new global::haxe.lang.Null<int>(0, true), new global::haxe.lang.Null<int>(0, true), ((int) (__temp_stmt626) ), ((global::haxe.lang.Null<bool>) (default(global::haxe.lang.Null<bool>)) )));
				base.doLayout();
			}
		}
		
		
		public override   object __hx_getField(string field, int hash, bool throwErrors, bool isCheck, bool handleProperties){
			unchecked {
				switch (hash){
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
		
		
	}
}


