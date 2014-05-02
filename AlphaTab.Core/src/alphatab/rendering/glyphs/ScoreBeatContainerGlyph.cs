using haxe.root;
#pragma warning disable 109, 114, 219, 429, 168, 162
namespace alphatab.rendering.glyphs{
	public  class ScoreBeatContainerGlyph : global::alphatab.rendering.glyphs.BeatContainerGlyph {
		public    ScoreBeatContainerGlyph(global::haxe.lang.EmptyObject empty) : base(((global::haxe.lang.EmptyObject) (global::haxe.lang.EmptyObject.EMPTY) )){
			unchecked {
			}
		}
		
		
		public    ScoreBeatContainerGlyph(global::alphatab.model.Beat beat) : base(((global::haxe.lang.EmptyObject) (global::haxe.lang.EmptyObject.EMPTY) )){
			unchecked {
				global::alphatab.rendering.glyphs.ScoreBeatContainerGlyph.__hx_ctor_alphatab_rendering_glyphs_ScoreBeatContainerGlyph(this, beat);
			}
		}
		
		
		public static   void __hx_ctor_alphatab_rendering_glyphs_ScoreBeatContainerGlyph(global::alphatab.rendering.glyphs.ScoreBeatContainerGlyph __temp_me205, global::alphatab.model.Beat beat){
			unchecked {
				global::alphatab.rendering.glyphs.BeatContainerGlyph.__hx_ctor_alphatab_rendering_glyphs_BeatContainerGlyph(__temp_me205, beat);
			}
		}
		
		
		public static  new object __hx_createEmpty(){
			unchecked {
				return new global::alphatab.rendering.glyphs.ScoreBeatContainerGlyph(((global::haxe.lang.EmptyObject) (global::haxe.lang.EmptyObject.EMPTY) ));
			}
		}
		
		
		public static  new object __hx_create(global::haxe.root.Array arr){
			unchecked {
				return new global::alphatab.rendering.glyphs.ScoreBeatContainerGlyph(((global::alphatab.model.Beat) (arr[0]) ));
			}
		}
		
		
		public override   void createTies(global::alphatab.model.Note n){
			unchecked {
				if (( n.isTieDestination && ( n.tieOrigin != default(global::alphatab.model.Note) ) )) {
					global::alphatab.rendering.glyphs.ScoreTieGlyph tie = new global::alphatab.rendering.glyphs.ScoreTieGlyph(((global::alphatab.model.Note) (n.tieOrigin) ), ((global::alphatab.model.Note) (n) ), ((global::alphatab.rendering.Glyph) (this) ));
					this.ties.push(tie);
				}
				 else {
					if (n.isHammerPullDestination) {
						global::alphatab.rendering.glyphs.ScoreTieGlyph tie1 = new global::alphatab.rendering.glyphs.ScoreTieGlyph(((global::alphatab.model.Note) (n.hammerPullOrigin) ), ((global::alphatab.model.Note) (n) ), ((global::alphatab.rendering.Glyph) (this) ));
						this.ties.push(tie1);
					}
					 else {
						if (( n.slideType == global::alphatab.model.SlideType.Legato )) {
							global::alphatab.rendering.glyphs.ScoreTieGlyph tie2 = new global::alphatab.rendering.glyphs.ScoreTieGlyph(((global::alphatab.model.Note) (n) ), ((global::alphatab.model.Note) (n.slideTarget) ), ((global::alphatab.rendering.Glyph) (this) ));
							this.ties.push(tie2);
						}
						
					}
					
				}
				
				if (( n.slideType != global::alphatab.model.SlideType.None )) {
					global::alphatab.rendering.glyphs.ScoreSlideLineGlyph l = new global::alphatab.rendering.glyphs.ScoreSlideLineGlyph(((global::alphatab.model.SlideType) (n.slideType) ), ((global::alphatab.model.Note) (n) ), ((global::alphatab.rendering.glyphs.BeatContainerGlyph) (this) ));
					this.ties.push(l);
				}
				
			}
		}
		
		
		public override   object __hx_getField(string field, int hash, bool throwErrors, bool isCheck, bool handleProperties){
			unchecked {
				switch (hash){
					case 1602913855:
					{
						return ((global::haxe.lang.Function) (new global::haxe.lang.Closure(((object) (this) ), ((string) ("createTies") ), ((int) (1602913855) ))) );
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


