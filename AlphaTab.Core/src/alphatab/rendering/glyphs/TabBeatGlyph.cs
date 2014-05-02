using haxe.root;
#pragma warning disable 109, 114, 219, 429, 168, 162
namespace alphatab.rendering.glyphs{
	public  class TabBeatGlyph : global::alphatab.rendering.glyphs.BeatGlyphBase, global::alphatab.rendering.glyphs.ISupportsFinalize {
		public    TabBeatGlyph(global::haxe.lang.EmptyObject empty) : base(global::haxe.lang.EmptyObject.EMPTY){
			unchecked {
			}
		}
		
		
		public    TabBeatGlyph() : base(global::haxe.lang.EmptyObject.EMPTY){
			unchecked {
				global::alphatab.rendering.glyphs.TabBeatGlyph.__hx_ctor_alphatab_rendering_glyphs_TabBeatGlyph(this);
			}
		}
		
		
		public static   void __hx_ctor_alphatab_rendering_glyphs_TabBeatGlyph(global::alphatab.rendering.glyphs.TabBeatGlyph __temp_me227){
			unchecked {
				global::alphatab.rendering.glyphs.BeatGlyphBase.__hx_ctor_alphatab_rendering_glyphs_BeatGlyphBase(__temp_me227);
			}
		}
		
		
		public static  new object __hx_createEmpty(){
			unchecked {
				return new global::alphatab.rendering.glyphs.TabBeatGlyph(((global::haxe.lang.EmptyObject) (global::haxe.lang.EmptyObject.EMPTY) ));
			}
		}
		
		
		public static  new object __hx_create(global::haxe.root.Array arr){
			unchecked {
				return new global::alphatab.rendering.glyphs.TabBeatGlyph();
			}
		}
		
		
		public  global::alphatab.rendering.glyphs.TabNoteChordGlyph noteNumbers;
		
		public  global::alphatab.rendering.utils.BeamingHelper beamingHelper;
		
		public override   void doLayout(){
			unchecked {
				global::haxe.root.Array<object> _g = new global::haxe.root.Array<object>(new object[]{this});
				if ( ! (this.container.beat.isRest()) ) {
					this.noteNumbers = new global::alphatab.rendering.glyphs.TabNoteChordGlyph(new global::haxe.lang.Null<int>(0, true), new global::haxe.lang.Null<int>(0, true), global::haxe.lang.Runtime.toBool(( this.container.beat.graceType != global::alphatab.model.GraceType.None )));
					this.noteNumbers.beat = this.container.beat;
					this.noteNumbers.beamingHelper = this.beamingHelper;
					this.noteLoop(new global::alphatab.rendering.glyphs.TabBeatGlyph_doLayout_52__Fun(((global::haxe.root.Array<object>) (_g) )));
					this.addGlyph(this.noteNumbers);
					if (( ( this.container.beat.whammyBarPoints.length > 0 ) &&  ! (this.noteNumbers.beatEffects.exists("Whammy"))  )) {
						this.noteNumbers.beatEffects.@set("Whammy", new global::alphatab.rendering.glyphs.WhammyBarGlyph(((global::alphatab.model.Beat) (this.container.beat) ), ((global::alphatab.rendering.glyphs.BeatContainerGlyph) (this.container) )));
					}
					
					if (( this.container.beat.tremoloSpeed.hasValue &&  ! (this.noteNumbers.beatEffects.exists("Tremolo"))  )) {
						this.noteNumbers.beatEffects.@set("Tremolo", new global::alphatab.rendering.glyphs.TremoloPickingGlyph(new global::haxe.lang.Null<int>(0, true), new global::haxe.lang.Null<int>(0, true), this.container.beat.tremoloSpeed.@value));
					}
					
				}
				
				int w = 0;
				{
					int _g1 = 0;
					global::haxe.root.Array<object> _g11 = this._glyphs;
					while (( _g1 < _g11.length )){
						global::alphatab.rendering.Glyph g = ((global::alphatab.rendering.Glyph) (_g11[_g1]) );
						 ++ _g1;
						g.x = w;
						g.renderer = this.renderer;
						g.doLayout();
						w += g.width;
					}
					
				}
				
				this.width = w;
			}
		}
		
		
		public virtual   void finalizeGlyph(global::alphatab.rendering.layout.ScoreLayout layout){
			unchecked {
				if ( ! (this.container.beat.isRest()) ) {
					this.noteNumbers.updateBeamingHelper(( this.container.x + this.x ));
				}
				
			}
		}
		
		
		public override   void applyGlyphSpacing(int spacing){
			unchecked {
				base.applyGlyphSpacing(spacing);
				if ( ! (this.container.beat.isRest()) ) {
					this.noteNumbers.updateBeamingHelper(( this.container.x + this.x ));
				}
				
			}
		}
		
		
		public virtual   void createNoteGlyph(global::alphatab.model.Note n){
			unchecked {
				bool isGrace = ( this.container.beat.graceType != global::alphatab.model.GraceType.None );
				global::alphatab.rendering.TabBarRenderer tr = default(global::alphatab.rendering.TabBarRenderer);
				tr = ((global::alphatab.rendering.TabBarRenderer) (this.renderer) );
				global::alphatab.rendering.glyphs.NoteNumberGlyph noteNumberGlyph = new global::alphatab.rendering.glyphs.NoteNumberGlyph(new global::haxe.lang.Null<int>(0, true), new global::haxe.lang.Null<int>(0, true), ((global::alphatab.model.Note) (n) ), global::haxe.lang.Runtime.toBool(isGrace));
				int l = ( ( n.beat.voice.bar.track.tuning.length - n.@string ) + 1 );
				noteNumberGlyph.y = tr.getTabY(l, new global::haxe.lang.Null<int>(-2, true));
				this.noteNumbers.addNoteGlyph(noteNumberGlyph, n);
			}
		}
		
		
		public override   object __hx_setField(string field, int hash, object @value, bool handleProperties){
			unchecked {
				switch (hash){
					case 1692978337:
					{
						this.beamingHelper = ((global::alphatab.rendering.utils.BeamingHelper) (@value) );
						return @value;
					}
					
					
					case 1563638712:
					{
						this.noteNumbers = ((global::alphatab.rendering.glyphs.TabNoteChordGlyph) (@value) );
						return @value;
					}
					
					
					default:
					{
						return base.__hx_setField(field, hash, @value, handleProperties);
					}
					
				}
				
			}
		}
		
		
		public override   object __hx_getField(string field, int hash, bool throwErrors, bool isCheck, bool handleProperties){
			unchecked {
				switch (hash){
					case 1955004862:
					{
						return ((global::haxe.lang.Function) (new global::haxe.lang.Closure(((object) (this) ), ((string) ("createNoteGlyph") ), ((int) (1955004862) ))) );
					}
					
					
					case 1827465669:
					{
						return ((global::haxe.lang.Function) (new global::haxe.lang.Closure(((object) (this) ), ((string) ("applyGlyphSpacing") ), ((int) (1827465669) ))) );
					}
					
					
					case 1308691246:
					{
						return ((global::haxe.lang.Function) (new global::haxe.lang.Closure(((object) (this) ), ((string) ("finalizeGlyph") ), ((int) (1308691246) ))) );
					}
					
					
					case 1825584277:
					{
						return ((global::haxe.lang.Function) (new global::haxe.lang.Closure(((object) (this) ), ((string) ("doLayout") ), ((int) (1825584277) ))) );
					}
					
					
					case 1692978337:
					{
						return this.beamingHelper;
					}
					
					
					case 1563638712:
					{
						return this.noteNumbers;
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
					case 1825584277:case 1827465669:
					{
						return global::haxe.lang.Runtime.slowCallField(this, field, dynargs);
					}
					
					
					case 1955004862:
					{
						this.createNoteGlyph(((global::alphatab.model.Note) (dynargs[0]) ));
						break;
					}
					
					
					case 1308691246:
					{
						this.finalizeGlyph(((global::alphatab.rendering.layout.ScoreLayout) (dynargs[0]) ));
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
		
		
		public override   void __hx_getFields(global::haxe.root.Array<object> baseArr){
			unchecked {
				baseArr.push("beamingHelper");
				baseArr.push("noteNumbers");
				{
					base.__hx_getFields(baseArr);
				}
				
			}
		}
		
		
	}
}



#pragma warning disable 109, 114, 219, 429, 168, 162
namespace alphatab.rendering.glyphs{
	public  class TabBeatGlyph_doLayout_52__Fun : global::haxe.lang.Function {
		public    TabBeatGlyph_doLayout_52__Fun(global::haxe.root.Array<object> _g) : base(1, 0){
			unchecked {
				this._g = _g;
			}
		}
		
		
		public override   object __hx_invoke1_o(double __fn_float1, object __fn_dyn1){
			unchecked {
				global::alphatab.model.Note n = ( (global::haxe.lang.Runtime.eq(__fn_dyn1, global::haxe.lang.Runtime.undefined)) ? (((global::alphatab.model.Note) (((object) (__fn_float1) )) )) : (((global::alphatab.model.Note) (__fn_dyn1) )) );
				((global::alphatab.rendering.glyphs.TabBeatGlyph) (this._g[0]) ).createNoteGlyph(n);
				return default(object);
			}
		}
		
		
		public  global::haxe.root.Array<object> _g;
		
	}
}


