using haxe.root;
#pragma warning disable 109, 114, 219, 429, 168, 162
namespace alphatab.rendering.glyphs{
	public  class TabNoteChordGlyph : global::alphatab.rendering.Glyph {
		public    TabNoteChordGlyph(global::haxe.lang.EmptyObject empty) : base(global::haxe.lang.EmptyObject.EMPTY){
			unchecked {
			}
		}
		
		
		public    TabNoteChordGlyph(global::haxe.lang.Null<int> x, global::haxe.lang.Null<int> y, bool isGrace) : base(global::haxe.lang.EmptyObject.EMPTY){
			unchecked {
				global::alphatab.rendering.glyphs.TabNoteChordGlyph.__hx_ctor_alphatab_rendering_glyphs_TabNoteChordGlyph(this, x, y, isGrace);
			}
		}
		
		
		public static   void __hx_ctor_alphatab_rendering_glyphs_TabNoteChordGlyph(global::alphatab.rendering.glyphs.TabNoteChordGlyph __temp_me235, global::haxe.lang.Null<int> x, global::haxe.lang.Null<int> y, bool isGrace){
			unchecked {
				global::alphatab.rendering.Glyph.__hx_ctor_alphatab_rendering_Glyph(__temp_me235, ( ( ! (x.hasValue) ) ? (new global::haxe.lang.Null<int>(0, true)) : (x) ), ( ( ! (y.hasValue) ) ? (new global::haxe.lang.Null<int>(0, true)) : (y) ));
				int __temp_y234 = ( ( ! (y.hasValue) ) ? (((int) (0) )) : (y.@value) );
				int __temp_x233 = ( ( ! (x.hasValue) ) ? (((int) (0) )) : (x.@value) );
				__temp_me235._notes = new global::haxe.root.Array<object>();
				__temp_me235.beatEffects = new global::haxe.ds.StringMap<object>();
				__temp_me235._noteLookup = new global::haxe.ds.IntMap<object>();
			}
		}
		
		
		public static  new object __hx_createEmpty(){
			unchecked {
				return new global::alphatab.rendering.glyphs.TabNoteChordGlyph(((global::haxe.lang.EmptyObject) (global::haxe.lang.EmptyObject.EMPTY) ));
			}
		}
		
		
		public static  new object __hx_create(global::haxe.root.Array arr){
			unchecked {
				return new global::alphatab.rendering.glyphs.TabNoteChordGlyph(global::haxe.lang.Null<object>.ofDynamic<int>(arr[0]), global::haxe.lang.Null<object>.ofDynamic<int>(arr[1]), global::haxe.lang.Runtime.toBool(arr[2]));
			}
		}
		
		
		public  global::haxe.root.Array<object> _notes;
		
		public  global::haxe.ds.IntMap<object> _noteLookup;
		
		public  global::alphatab.model.Note _minNote;
		
		public  bool _isGrace;
		
		public  int _centerX;
		
		public  global::alphatab.model.Beat beat;
		
		public  global::alphatab.rendering.utils.BeamingHelper beamingHelper;
		
		public  global::haxe.ds.StringMap<object> beatEffects;
		
		public virtual   int getNoteX(global::alphatab.model.Note note, global::haxe.lang.Null<bool> onEnd){
			unchecked {
				bool __temp_onEnd232 = ( ( ! (onEnd.hasValue) ) ? (global::haxe.lang.Runtime.toBool(true)) : (onEnd.@value) );
				if (this._noteLookup.exists(note.@string)) {
					global::alphatab.rendering.glyphs.NoteNumberGlyph n = ((global::alphatab.rendering.glyphs.NoteNumberGlyph) (this._noteLookup.@get(note.@string).@value) );
					int pos = ( ( this.x + n.x ) + ((int) (( 0 * this.renderer.stave.staveGroup.layout.renderer.settings.scale )) ) );
					if (__temp_onEnd232) {
						n.calculateWidth();
						pos += n.width;
					}
					
					return pos;
				}
				
				return 0;
			}
		}
		
		
		public virtual   int getNoteY(global::alphatab.model.Note note){
			unchecked {
				if (this._noteLookup.exists(note.@string)) {
					return ( this.y + ((global::alphatab.rendering.glyphs.NoteNumberGlyph) (this._noteLookup.@get(note.@string).@value) ).y );
				}
				
				return 0;
			}
		}
		
		
		public override   void doLayout(){
			unchecked {
				int w = 0;
				{
					int _g = 0;
					global::haxe.root.Array<object> _g1 = this._notes;
					while (( _g < _g1.length )){
						global::alphatab.rendering.glyphs.NoteNumberGlyph g = ((global::alphatab.rendering.glyphs.NoteNumberGlyph) (_g1[_g]) );
						 ++ _g;
						g.renderer = this.renderer;
						g.doLayout();
						if (( g.width > w )) {
							w = g.width;
						}
						
					}
					
				}
				
				global::alphatab.rendering.TabBarRenderer tabRenderer = ((global::alphatab.rendering.TabBarRenderer) (this.renderer) );
				double tabHeight = this.renderer.stave.staveGroup.layout.renderer.renderingResources.tablatureFont.getSize();
				int effectY = default(int);
				{
					double x = ( this.getNoteY(this._minNote) + ( tabHeight / 2 ) );
					effectY = ((int) (x) );
				}
				
				int effectSpacing = ((int) (( 7 * this.renderer.stave.staveGroup.layout.renderer.settings.scale )) );
				{
					object __temp_iterator479 = this.beatEffects.iterator();
					while (global::haxe.lang.Runtime.toBool(global::haxe.lang.Runtime.callField(__temp_iterator479, "hasNext", 407283053, default(global::haxe.root.Array)))){
						global::alphatab.rendering.Glyph g1 = ((global::alphatab.rendering.Glyph) (global::haxe.lang.Runtime.callField(__temp_iterator479, "next", 1224901875, default(global::haxe.root.Array))) );
						g1.y = effectY;
						g1.x = ( this.width / 2 );
						g1.renderer = this.renderer;
						effectY += effectSpacing;
						g1.doLayout();
					}
					
				}
				
				this._centerX = 0;
				this.width = w;
			}
		}
		
		
		public virtual   void addNoteGlyph(global::alphatab.rendering.glyphs.NoteNumberGlyph noteGlyph, global::alphatab.model.Note note){
			unchecked {
				this._notes.push(noteGlyph);
				this._noteLookup.@set(note.@string, noteGlyph);
				if (( ( this._minNote == default(global::alphatab.model.Note) ) || ( note.@string < this._minNote.@string ) )) {
					this._minNote = note;
				}
				
			}
		}
		
		
		public override   void paint(int cx, int cy, global::alphatab.platform.ICanvas canvas){
			unchecked {
				global::alphatab.rendering.RenderingResources res = this.renderer.stave.staveGroup.layout.renderer.renderingResources;
				global::alphatab.model.TextBaseline old = canvas.getTextBaseline();
				canvas.setTextBaseline(global::alphatab.model.TextBaseline.Middle);
				canvas.setColor(res.mainGlyphColor);
				if (this._isGrace) {
					canvas.setFont(res.graceFont);
				}
				 else {
					canvas.setFont(res.tablatureFont);
				}
				
				{
					int _g = 0;
					global::haxe.root.Array<object> _g1 = this._notes;
					while (( _g < _g1.length )){
						global::alphatab.rendering.glyphs.NoteNumberGlyph g = ((global::alphatab.rendering.glyphs.NoteNumberGlyph) (_g1[_g]) );
						 ++ _g;
						g.renderer = this.renderer;
						g.paint(( cx + this.x ), ( cy + this.y ), canvas);
					}
					
				}
				
				canvas.setTextBaseline(old);
				{
					object __temp_iterator480 = this.beatEffects.iterator();
					while (global::haxe.lang.Runtime.toBool(global::haxe.lang.Runtime.callField(__temp_iterator480, "hasNext", 407283053, default(global::haxe.root.Array)))){
						global::alphatab.rendering.Glyph g1 = ((global::alphatab.rendering.Glyph) (global::haxe.lang.Runtime.callField(__temp_iterator480, "next", 1224901875, default(global::haxe.root.Array))) );
						g1.paint(( cx + this.x ), ( cy + this.y ), canvas);
					}
					
				}
				
			}
		}
		
		
		public virtual   void updateBeamingHelper(int cx){
			unchecked {
				if ( ! (this.beamingHelper._beatLineXPositions.exists(this.beat.index)) ) {
					this.beamingHelper.registerBeatLineX(this.beat, ( ( cx + this.x ) + this._centerX ), ( ( cx + this.x ) + this._centerX ));
				}
				
			}
		}
		
		
		public override   double __hx_setField_f(string field, int hash, double @value, bool handleProperties){
			unchecked {
				switch (hash){
					case 1402883684:
					{
						this._centerX = ((int) (@value) );
						return @value;
					}
					
					
					default:
					{
						return base.__hx_setField_f(field, hash, @value, handleProperties);
					}
					
				}
				
			}
		}
		
		
		public override   object __hx_setField(string field, int hash, object @value, bool handleProperties){
			unchecked {
				switch (hash){
					case 108520940:
					{
						this.beatEffects = ((global::haxe.ds.StringMap<object>) (global::haxe.ds.StringMap<object>.__hx_cast<object>(((global::haxe.ds.StringMap) (@value) ))) );
						return @value;
					}
					
					
					case 1692978337:
					{
						this.beamingHelper = ((global::alphatab.rendering.utils.BeamingHelper) (@value) );
						return @value;
					}
					
					
					case 1091821942:
					{
						this.beat = ((global::alphatab.model.Beat) (@value) );
						return @value;
					}
					
					
					case 1402883684:
					{
						this._centerX = ((int) (global::haxe.lang.Runtime.toInt(@value)) );
						return @value;
					}
					
					
					case 1881669935:
					{
						this._isGrace = global::haxe.lang.Runtime.toBool(@value);
						return @value;
					}
					
					
					case 1942741029:
					{
						this._minNote = ((global::alphatab.model.Note) (@value) );
						return @value;
					}
					
					
					case 1381203243:
					{
						this._noteLookup = ((global::haxe.ds.IntMap<object>) (global::haxe.ds.IntMap<object>.__hx_cast<object>(((global::haxe.ds.IntMap) (@value) ))) );
						return @value;
					}
					
					
					case 464659330:
					{
						this._notes = ((global::haxe.root.Array<object>) (global::haxe.root.Array<object>.__hx_cast<object>(((global::haxe.root.Array) (@value) ))) );
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
					case 2020590808:
					{
						return ((global::haxe.lang.Function) (new global::haxe.lang.Closure(((object) (this) ), ((string) ("updateBeamingHelper") ), ((int) (2020590808) ))) );
					}
					
					
					case 1028568990:
					{
						return ((global::haxe.lang.Function) (new global::haxe.lang.Closure(((object) (this) ), ((string) ("paint") ), ((int) (1028568990) ))) );
					}
					
					
					case 1390832121:
					{
						return ((global::haxe.lang.Function) (new global::haxe.lang.Closure(((object) (this) ), ((string) ("addNoteGlyph") ), ((int) (1390832121) ))) );
					}
					
					
					case 1825584277:
					{
						return ((global::haxe.lang.Function) (new global::haxe.lang.Closure(((object) (this) ), ((string) ("doLayout") ), ((int) (1825584277) ))) );
					}
					
					
					case 2141318065:
					{
						return ((global::haxe.lang.Function) (new global::haxe.lang.Closure(((object) (this) ), ((string) ("getNoteY") ), ((int) (2141318065) ))) );
					}
					
					
					case 2141318064:
					{
						return ((global::haxe.lang.Function) (new global::haxe.lang.Closure(((object) (this) ), ((string) ("getNoteX") ), ((int) (2141318064) ))) );
					}
					
					
					case 108520940:
					{
						return this.beatEffects;
					}
					
					
					case 1692978337:
					{
						return this.beamingHelper;
					}
					
					
					case 1091821942:
					{
						return this.beat;
					}
					
					
					case 1402883684:
					{
						return this._centerX;
					}
					
					
					case 1881669935:
					{
						return this._isGrace;
					}
					
					
					case 1942741029:
					{
						return this._minNote;
					}
					
					
					case 1381203243:
					{
						return this._noteLookup;
					}
					
					
					case 464659330:
					{
						return this._notes;
					}
					
					
					default:
					{
						return base.__hx_getField(field, hash, throwErrors, isCheck, handleProperties);
					}
					
				}
				
			}
		}
		
		
		public override   double __hx_getField_f(string field, int hash, bool throwErrors, bool handleProperties){
			unchecked {
				switch (hash){
					case 1402883684:
					{
						return ((double) (this._centerX) );
					}
					
					
					default:
					{
						return base.__hx_getField_f(field, hash, throwErrors, handleProperties);
					}
					
				}
				
			}
		}
		
		
		public override   object __hx_invokeField(string field, int hash, global::haxe.root.Array dynargs){
			unchecked {
				switch (hash){
					case 1825584277:case 1028568990:
					{
						return global::haxe.lang.Runtime.slowCallField(this, field, dynargs);
					}
					
					
					case 2020590808:
					{
						this.updateBeamingHelper(((int) (global::haxe.lang.Runtime.toInt(dynargs[0])) ));
						break;
					}
					
					
					case 1390832121:
					{
						this.addNoteGlyph(((global::alphatab.rendering.glyphs.NoteNumberGlyph) (dynargs[0]) ), ((global::alphatab.model.Note) (dynargs[1]) ));
						break;
					}
					
					
					case 2141318065:
					{
						return this.getNoteY(((global::alphatab.model.Note) (dynargs[0]) ));
					}
					
					
					case 2141318064:
					{
						return this.getNoteX(((global::alphatab.model.Note) (dynargs[0]) ), global::haxe.lang.Null<object>.ofDynamic<bool>(dynargs[1]));
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
				baseArr.push("beatEffects");
				baseArr.push("beamingHelper");
				baseArr.push("beat");
				baseArr.push("_centerX");
				baseArr.push("_isGrace");
				baseArr.push("_minNote");
				baseArr.push("_noteLookup");
				baseArr.push("_notes");
				{
					base.__hx_getFields(baseArr);
				}
				
			}
		}
		
		
	}
}


