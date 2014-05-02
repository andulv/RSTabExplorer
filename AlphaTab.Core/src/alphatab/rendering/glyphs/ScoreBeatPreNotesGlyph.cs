using haxe.root;
#pragma warning disable 109, 114, 219, 429, 168, 162
namespace alphatab.rendering.glyphs{
	public  class ScoreBeatPreNotesGlyph : global::alphatab.rendering.glyphs.BeatGlyphBase {
		public    ScoreBeatPreNotesGlyph(global::haxe.lang.EmptyObject empty) : base(global::haxe.lang.EmptyObject.EMPTY){
			unchecked {
			}
		}
		
		
		public    ScoreBeatPreNotesGlyph() : base(global::haxe.lang.EmptyObject.EMPTY){
			unchecked {
				global::alphatab.rendering.glyphs.ScoreBeatPreNotesGlyph.__hx_ctor_alphatab_rendering_glyphs_ScoreBeatPreNotesGlyph(this);
			}
		}
		
		
		public static   void __hx_ctor_alphatab_rendering_glyphs_ScoreBeatPreNotesGlyph(global::alphatab.rendering.glyphs.ScoreBeatPreNotesGlyph __temp_me208){
			unchecked {
				global::alphatab.rendering.glyphs.BeatGlyphBase.__hx_ctor_alphatab_rendering_glyphs_BeatGlyphBase(__temp_me208);
			}
		}
		
		
		public static  new object __hx_createEmpty(){
			unchecked {
				return new global::alphatab.rendering.glyphs.ScoreBeatPreNotesGlyph(((global::haxe.lang.EmptyObject) (global::haxe.lang.EmptyObject.EMPTY) ));
			}
		}
		
		
		public static  new object __hx_create(global::haxe.root.Array arr){
			unchecked {
				return new global::alphatab.rendering.glyphs.ScoreBeatPreNotesGlyph();
			}
		}
		
		
		public override   void applyGlyphSpacing(int spacing){
			unchecked {
				base.applyGlyphSpacing(spacing);
				{
					int _g = 0;
					global::haxe.root.Array<object> _g1 = this._glyphs;
					while (( _g < _g1.length )){
						global::alphatab.rendering.Glyph g = ((global::alphatab.rendering.Glyph) (_g1[_g]) );
						 ++ _g;
						g.x += spacing;
					}
					
				}
				
			}
		}
		
		
		public override   void doLayout(){
			unchecked {
				global::haxe.root.Array<object> _g = new global::haxe.root.Array<object>(new object[]{this});
				if (( this.container.beat.brushType != global::alphatab.model.BrushType.None )) {
					this.addGlyph(new global::alphatab.rendering.glyphs.ScoreBrushGlyph(((global::alphatab.model.Beat) (this.container.beat) )));
					this.addGlyph(new global::alphatab.rendering.glyphs.SpacingGlyph(new global::haxe.lang.Null<int>(0, true), new global::haxe.lang.Null<int>(0, true), ((int) (( 4 * this.renderer.stave.staveGroup.layout.renderer.settings.scale )) ), ((global::haxe.lang.Null<bool>) (default(global::haxe.lang.Null<bool>)) )));
				}
				
				if ((  ! (this.container.beat.isRest())  &&  ! (this.container.beat.voice.bar.track.isPercussion)  )) {
					global::haxe.root.Array<object> accidentals = new global::haxe.root.Array<object>(new object[]{new global::alphatab.rendering.glyphs.AccidentalGroupGlyph(new global::haxe.lang.Null<int>(0, true), new global::haxe.lang.Null<int>(0, true))});
					this.noteLoop(new global::alphatab.rendering.glyphs.ScoreBeatPreNotesGlyph_doLayout_53__Fun(((global::haxe.root.Array<object>) (accidentals) ), ((global::haxe.root.Array<object>) (_g) )));
					this.addGlyph(((global::alphatab.rendering.glyphs.AccidentalGroupGlyph) (accidentals[0]) ));
				}
				
				this.addGlyph(new global::alphatab.rendering.glyphs.SpacingGlyph(new global::haxe.lang.Null<int>(0, true), new global::haxe.lang.Null<int>(0, true), ((int) (( ( 4 * (( (( this.container.beat.graceType != global::alphatab.model.GraceType.None )) ? (0.7) : (((double) (1) )) )) ) * this.renderer.stave.staveGroup.layout.renderer.settings.scale )) ), new global::haxe.lang.Null<bool>(true, true)));
				base.doLayout();
			}
		}
		
		
		public virtual   void createAccidentalGlyph(global::alphatab.model.Note n, global::alphatab.rendering.glyphs.AccidentalGroupGlyph accidentals){
			unchecked {
				global::alphatab.rendering.ScoreBarRenderer sr = default(global::alphatab.rendering.ScoreBarRenderer);
				sr = ((global::alphatab.rendering.ScoreBarRenderer) (this.renderer) );
				int noteLine = sr.getNoteLine(n);
				global::alphatab.model.AccidentalType accidental = sr.accidentalHelper.applyAccidental(n, noteLine);
				bool isGrace = ( this.container.beat.graceType != global::alphatab.model.GraceType.None );
				switch (global::haxe.root.Type.enumIndex(accidental)){
					case 2:
					{
						accidentals.addGlyph(new global::alphatab.rendering.glyphs.SharpGlyph(new global::haxe.lang.Null<int>(0, true), new global::haxe.lang.Null<int>(sr.getScoreY(noteLine, default(global::haxe.lang.Null<int>)), true), new global::haxe.lang.Null<bool>(isGrace, true)));
						break;
					}
					
					
					case 3:
					{
						accidentals.addGlyph(new global::alphatab.rendering.glyphs.FlatGlyph(new global::haxe.lang.Null<int>(0, true), new global::haxe.lang.Null<int>(sr.getScoreY(noteLine, default(global::haxe.lang.Null<int>)), true), new global::haxe.lang.Null<bool>(isGrace, true)));
						break;
					}
					
					
					case 1:
					{
						accidentals.addGlyph(new global::alphatab.rendering.glyphs.NaturalizeGlyph(new global::haxe.lang.Null<int>(0, true), new global::haxe.lang.Null<int>(sr.getScoreY(( noteLine + 1 ), default(global::haxe.lang.Null<int>)), true), new global::haxe.lang.Null<bool>(isGrace, true)));
						break;
					}
					
					
					default:
					{
						{
						}
						
						break;
					}
					
				}
				
			}
		}
		
		
		public override   object __hx_getField(string field, int hash, bool throwErrors, bool isCheck, bool handleProperties){
			unchecked {
				switch (hash){
					case 448039670:
					{
						return ((global::haxe.lang.Function) (new global::haxe.lang.Closure(((object) (this) ), ((string) ("createAccidentalGlyph") ), ((int) (448039670) ))) );
					}
					
					
					case 1825584277:
					{
						return ((global::haxe.lang.Function) (new global::haxe.lang.Closure(((object) (this) ), ((string) ("doLayout") ), ((int) (1825584277) ))) );
					}
					
					
					case 1827465669:
					{
						return ((global::haxe.lang.Function) (new global::haxe.lang.Closure(((object) (this) ), ((string) ("applyGlyphSpacing") ), ((int) (1827465669) ))) );
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
					case 1827465669:case 1825584277:
					{
						return global::haxe.lang.Runtime.slowCallField(this, field, dynargs);
					}
					
					
					case 448039670:
					{
						this.createAccidentalGlyph(((global::alphatab.model.Note) (dynargs[0]) ), ((global::alphatab.rendering.glyphs.AccidentalGroupGlyph) (dynargs[1]) ));
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
	public  class ScoreBeatPreNotesGlyph_doLayout_53__Fun : global::haxe.lang.Function {
		public    ScoreBeatPreNotesGlyph_doLayout_53__Fun(global::haxe.root.Array<object> accidentals, global::haxe.root.Array<object> _g) : base(1, 0){
			unchecked {
				this.accidentals = accidentals;
				this._g = _g;
			}
		}
		
		
		public override   object __hx_invoke1_o(double __fn_float1, object __fn_dyn1){
			unchecked {
				global::alphatab.model.Note n = ( (global::haxe.lang.Runtime.eq(__fn_dyn1, global::haxe.lang.Runtime.undefined)) ? (((global::alphatab.model.Note) (((object) (__fn_float1) )) )) : (((global::alphatab.model.Note) (__fn_dyn1) )) );
				((global::alphatab.rendering.glyphs.ScoreBeatPreNotesGlyph) (this._g[0]) ).createAccidentalGlyph(n, ((global::alphatab.rendering.glyphs.AccidentalGroupGlyph) (this.accidentals[0]) ));
				return default(object);
			}
		}
		
		
		public  global::haxe.root.Array<object> accidentals;
		
		public  global::haxe.root.Array<object> _g;
		
	}
}


