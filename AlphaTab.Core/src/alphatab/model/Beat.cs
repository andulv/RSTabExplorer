using haxe.root;
#pragma warning disable 109, 114, 219, 429, 168, 162
namespace alphatab.model{
	public  class Beat : global::haxe.lang.HxObject {
		static Beat() {
			global::alphatab.model.Beat.WhammyBarMaxPosition = 60;
			global::alphatab.model.Beat.WhammyBarMaxValue = 24;
		}
		public    Beat(global::haxe.lang.EmptyObject empty){
			unchecked {
				{
				}
				
			}
		}
		
		
		public    Beat(){
			unchecked {
				global::alphatab.model.Beat.__hx_ctor_alphatab_model_Beat(this);
			}
		}
		
		
		public static   void __hx_ctor_alphatab_model_Beat(global::alphatab.model.Beat __temp_me88){
			unchecked {
				__temp_me88.whammyBarPoints = new global::haxe.root.Array<object>();
				__temp_me88.notes = new global::haxe.root.Array<object>();
				__temp_me88.brushType = global::alphatab.model.BrushType.None;
				__temp_me88.vibrato = global::alphatab.model.VibratoType.None;
				__temp_me88.graceType = global::alphatab.model.GraceType.None;
				__temp_me88.pickStroke = global::alphatab.model.PickStrokeType.None;
				__temp_me88.duration = global::alphatab.model.Duration.Quarter;
				__temp_me88.tremoloSpeed = default(global::haxe.lang.Null<global::alphatab.model.Duration>);
				__temp_me88.automations = new global::haxe.root.Array<object>();
				__temp_me88.dots = 0;
				__temp_me88.start = 0;
				__temp_me88.tupletDenominator = -1;
				__temp_me88.tupletNumerator = -1;
				__temp_me88.dynamicValue = global::alphatab.model.DynamicValue.F;
				__temp_me88.crescendo = global::alphatab.rendering.glyphs.CrescendoType.None;
			}
		}
		
		
		public static  int WhammyBarMaxPosition;
		
		public static  int WhammyBarMaxValue;
		
		public static  new object __hx_createEmpty(){
			unchecked {
				return new global::alphatab.model.Beat(((global::haxe.lang.EmptyObject) (global::haxe.lang.EmptyObject.EMPTY) ));
			}
		}
		
		
		public static  new object __hx_create(global::haxe.root.Array arr){
			unchecked {
				return new global::alphatab.model.Beat();
			}
		}
		
		
		public  global::alphatab.model.Beat previousBeat;
		
		public  global::alphatab.model.Beat nextBeat;
		
		public  int index;
		
		public  global::alphatab.model.Voice voice;
		
		public  global::haxe.root.Array<object> notes;
		
		public  global::alphatab.model.Note _minNote;
		
		public virtual   global::alphatab.model.Note minNote(){
			unchecked {
				if (( this._minNote == default(global::alphatab.model.Note) )) {
					this.refreshNotes();
				}
				
				return this._minNote;
			}
		}
		
		
		public  global::alphatab.model.Note _maxNote;
		
		public virtual   global::alphatab.model.Note maxNote(){
			unchecked {
				if (( this._maxNote == default(global::alphatab.model.Note) )) {
					this.refreshNotes();
				}
				
				return this._maxNote;
			}
		}
		
		
		public  global::alphatab.model.Duration duration;
		
		public  bool isEmpty;
		
		public  global::haxe.root.Array<object> automations;
		
		public virtual   bool isRest(){
			unchecked {
				return ( this.notes.length == 0 );
			}
		}
		
		
		public  int dots;
		
		public  bool fadeIn;
		
		public  global::haxe.root.Array<object> lyrics;
		
		public  bool pop;
		
		public  bool hasRasgueado;
		
		public  bool slap;
		
		public  bool tap;
		
		public  string text;
		
		public  global::alphatab.model.BrushType brushType;
		
		public  int brushDuration;
		
		public  int tupletDenominator;
		
		public  int tupletNumerator;
		
		public  global::haxe.root.Array<object> whammyBarPoints;
		
		public   bool hasWhammyBar(){
			unchecked {
				return ( this.whammyBarPoints.length > 0 );
			}
		}
		
		
		public  global::alphatab.model.VibratoType vibrato;
		
		public  string chordId;
		
		public   bool hasChord(){
			unchecked {
				return  ! (string.Equals(this.chordId, default(string))) ;
			}
		}
		
		
		public   global::alphatab.model.Chord chord(){
			unchecked {
				return ((global::alphatab.model.Chord) (this.voice.bar.track.chords.@get(this.chordId).@value) );
			}
		}
		
		
		public  global::alphatab.model.GraceType graceType;
		
		public  global::alphatab.model.PickStrokeType pickStroke;
		
		public   bool isTremolo(){
			unchecked {
				return this.tremoloSpeed.hasValue;
			}
		}
		
		
		public  global::haxe.lang.Null<global::alphatab.model.Duration> tremoloSpeed;
		
		public  global::alphatab.rendering.glyphs.CrescendoType crescendo;
		
		public  int start;
		
		public  global::alphatab.model.DynamicValue dynamicValue;
		
		public virtual   global::alphatab.model.Beat clone(){
			unchecked {
				global::alphatab.model.Beat beat = new global::alphatab.model.Beat();
				{
					int _g = 0;
					global::haxe.root.Array<object> _g1 = this.whammyBarPoints;
					while (( _g < _g1.length )){
						global::alphatab.model.BendPoint b = ((global::alphatab.model.BendPoint) (_g1[_g]) );
						 ++ _g;
						beat.whammyBarPoints.push(b.clone());
					}
					
				}
				
				{
					int _g2 = 0;
					global::haxe.root.Array<object> _g11 = this.notes;
					while (( _g2 < _g11.length )){
						global::alphatab.model.Note n = ((global::alphatab.model.Note) (_g11[_g2]) );
						 ++ _g2;
						beat.addNote(n.clone());
					}
					
				}
				
				beat.dots = this.dots;
				beat.chordId = this.chordId;
				beat.brushType = this.brushType;
				beat.vibrato = this.vibrato;
				beat.graceType = this.graceType;
				beat.pickStroke = this.pickStroke;
				beat.duration = this.duration;
				beat.tremoloSpeed = this.tremoloSpeed;
				beat.text = this.text;
				beat.fadeIn = this.fadeIn;
				beat.tap = this.tap;
				beat.slap = this.slap;
				beat.pop = this.pop;
				{
					int _g3 = 0;
					global::haxe.root.Array<object> _g12 = this.automations;
					while (( _g3 < _g12.length )){
						global::alphatab.model.Automation a = ((global::alphatab.model.Automation) (_g12[_g3]) );
						 ++ _g3;
						beat.automations.push(a.clone());
					}
					
				}
				
				beat.start = this.start;
				beat.tupletDenominator = this.tupletDenominator;
				beat.tupletNumerator = this.tupletNumerator;
				beat.dynamicValue = this.dynamicValue;
				beat.crescendo = this.crescendo;
				return beat;
			}
		}
		
		
		public   bool hasTuplet(){
			unchecked {
				return (  ! ((( ( this.tupletDenominator == -1 ) && ( this.tupletNumerator == -1 ) )))  &&  ! ((( ( this.tupletDenominator == 1 ) && ( this.tupletNumerator == 1 ) )))  );
			}
		}
		
		
		public virtual   int calculateDuration(){
			unchecked {
				int ticks = global::alphatab.audio.MidiUtils.durationToTicks(this.duration);
				if (( this.dots == 2 )) {
					ticks = global::alphatab.audio.MidiUtils.applyDot(ticks, true);
				}
				 else {
					if (( this.dots == 1 )) {
						ticks = global::alphatab.audio.MidiUtils.applyDot(ticks, false);
					}
					
				}
				
				if (( ( this.tupletDenominator > 0 ) && ( this.tupletNumerator >= 0 ) )) {
					ticks = global::alphatab.audio.MidiUtils.applyTuplet(ticks, this.tupletNumerator, this.tupletDenominator);
				}
				
				return ticks;
			}
		}
		
		
		public virtual   void addNote(global::alphatab.model.Note note){
			unchecked {
				note.beat = this;
				this.notes.push(note);
			}
		}
		
		
		public virtual   void refreshNotes(){
			unchecked {
				int _g = 0;
				global::haxe.root.Array<object> _g1 = this.notes;
				while (( _g < _g1.length )){
					global::alphatab.model.Note n = ((global::alphatab.model.Note) (_g1[_g]) );
					 ++ _g;
					bool __temp_stmt544 = ( this._minNote == default(global::alphatab.model.Note) );
					bool __temp_boolv545 = false;
					if ( ! (__temp_stmt544) ) {
						int __temp_stmt546 = default(int);
						{
							global::alphatab.model.Note _this = this._minNote;
							__temp_stmt546 = ( _this.fret + _this.beat.voice.bar.track.tuning[( ( _this.beat.voice.bar.track.tuning.length - (( _this.@string - 1 )) ) - 1 )] );
						}
						
						__temp_boolv545 = ( ( n.fret + n.beat.voice.bar.track.tuning[( ( n.beat.voice.bar.track.tuning.length - (( n.@string - 1 )) ) - 1 )] ) < __temp_stmt546 );
					}
					
					bool __temp_stmt543 = ( __temp_stmt544 || __temp_boolv545 );
					if (__temp_stmt543) {
						this._minNote = n;
					}
					
					bool __temp_stmt548 = ( this._maxNote == default(global::alphatab.model.Note) );
					bool __temp_boolv549 = false;
					if ( ! (__temp_stmt548) ) {
						int __temp_stmt550 = default(int);
						{
							global::alphatab.model.Note _this1 = this._maxNote;
							__temp_stmt550 = ( _this1.fret + _this1.beat.voice.bar.track.tuning[( ( _this1.beat.voice.bar.track.tuning.length - (( _this1.@string - 1 )) ) - 1 )] );
						}
						
						__temp_boolv549 = ( ( n.fret + n.beat.voice.bar.track.tuning[( ( n.beat.voice.bar.track.tuning.length - (( n.@string - 1 )) ) - 1 )] ) > __temp_stmt550 );
					}
					
					bool __temp_stmt547 = ( __temp_stmt548 || __temp_boolv549 );
					if (__temp_stmt547) {
						this._maxNote = n;
					}
					
				}
				
			}
		}
		
		
		public virtual   global::alphatab.model.Automation getAutomation(global::alphatab.model.AutomationType type){
			unchecked {
				{
					int _g = 0;
					global::haxe.root.Array<object> _g1 = this.automations;
					while (( _g < _g1.length )){
						global::alphatab.model.Automation a = ((global::alphatab.model.Automation) (_g1[_g]) );
						 ++ _g;
						if (( a.type == type )) {
							return a;
						}
						
					}
					
				}
				
				return default(global::alphatab.model.Automation);
			}
		}
		
		
		public virtual   global::alphatab.model.Note getNoteOnString(int @string){
			unchecked {
				{
					int _g = 0;
					global::haxe.root.Array<object> _g1 = this.notes;
					while (( _g < _g1.length )){
						global::alphatab.model.Note n = ((global::alphatab.model.Note) (_g1[_g]) );
						 ++ _g;
						if (( n.@string == @string )) {
							return n;
						}
						
					}
					
				}
				
				return default(global::alphatab.model.Note);
			}
		}
		
		
		public virtual   void finish(){
			unchecked {
				if (( ( this.voice.bar.index == 0 ) && ( this.index == 0 ) )) {
					this.previousBeat = default(global::alphatab.model.Beat);
				}
				 else {
					if (( this.index == 0 )) {
						this.previousBeat = ((global::alphatab.model.Beat) (((global::alphatab.model.Voice) (this.voice.bar.previousBar.voices[this.voice.index]) ).beats[( ((global::alphatab.model.Voice) (this.voice.bar.previousBar.voices[this.voice.index]) ).beats.length - 1 )]) );
						this.previousBeat.nextBeat = this;
					}
					 else {
						this.previousBeat = ((global::alphatab.model.Beat) (this.voice.beats[( this.index - 1 )]) );
						this.previousBeat.nextBeat = this;
					}
					
				}
				
				if (( this.index == 0 )) {
					global::alphatab.model.MasterBar __temp_stmt551 = default(global::alphatab.model.MasterBar);
					{
						global::alphatab.model.Bar _this = this.voice.bar;
						__temp_stmt551 = ((global::alphatab.model.MasterBar) (_this.track.score.masterBars[_this.index]) );
					}
					
					this.start = __temp_stmt551.start;
				}
				 else {
					this.start = ( this.previousBeat.start + this.previousBeat.calculateDuration() );
				}
				
				{
					int _g = 0;
					global::haxe.root.Array<object> _g1 = this.notes;
					while (( _g < _g1.length )){
						global::alphatab.model.Note n = ((global::alphatab.model.Note) (_g1[_g]) );
						 ++ _g;
						n.finish();
					}
					
				}
				
			}
		}
		
		
		public override   double __hx_setField_f(string field, int hash, double @value, bool handleProperties){
			unchecked {
				switch (hash){
					case 67859554:
					{
						this.start = ((int) (@value) );
						return @value;
					}
					
					
					case 438479229:
					{
						this.tupletNumerator = ((int) (@value) );
						return @value;
					}
					
					
					case 1310257562:
					{
						this.tupletDenominator = ((int) (@value) );
						return @value;
					}
					
					
					case 1650208238:
					{
						this.brushDuration = ((int) (@value) );
						return @value;
					}
					
					
					case 1114502602:
					{
						this.dots = ((int) (@value) );
						return @value;
					}
					
					
					case 1041537810:
					{
						this.index = ((int) (@value) );
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
					case 1751303026:
					{
						this.dynamicValue = ((global::alphatab.model.DynamicValue) (@value) );
						return @value;
					}
					
					
					case 67859554:
					{
						this.start = ((int) (global::haxe.lang.Runtime.toInt(@value)) );
						return @value;
					}
					
					
					case 848728090:
					{
						this.crescendo = ((global::alphatab.rendering.glyphs.CrescendoType) (@value) );
						return @value;
					}
					
					
					case 706091227:
					{
						this.tremoloSpeed = global::haxe.lang.Null<object>.ofDynamic<global::alphatab.model.Duration>(@value);
						return @value;
					}
					
					
					case 1801219961:
					{
						this.pickStroke = ((global::alphatab.model.PickStrokeType) (@value) );
						return @value;
					}
					
					
					case 233406162:
					{
						this.graceType = ((global::alphatab.model.GraceType) (@value) );
						return @value;
					}
					
					
					case 1594575703:
					{
						this.chordId = global::haxe.lang.Runtime.toString(@value);
						return @value;
					}
					
					
					case 1598475321:
					{
						this.vibrato = ((global::alphatab.model.VibratoType) (@value) );
						return @value;
					}
					
					
					case 1147430701:
					{
						this.whammyBarPoints = ((global::haxe.root.Array<object>) (global::haxe.root.Array<object>.__hx_cast<object>(((global::haxe.root.Array) (@value) ))) );
						return @value;
					}
					
					
					case 438479229:
					{
						this.tupletNumerator = ((int) (global::haxe.lang.Runtime.toInt(@value)) );
						return @value;
					}
					
					
					case 1310257562:
					{
						this.tupletDenominator = ((int) (global::haxe.lang.Runtime.toInt(@value)) );
						return @value;
					}
					
					
					case 1650208238:
					{
						this.brushDuration = ((int) (global::haxe.lang.Runtime.toInt(@value)) );
						return @value;
					}
					
					
					case 1321811028:
					{
						this.brushType = ((global::alphatab.model.BrushType) (@value) );
						return @value;
					}
					
					
					case 1291439277:
					{
						this.text = global::haxe.lang.Runtime.toString(@value);
						return @value;
					}
					
					
					case 5790307:
					{
						this.tap = global::haxe.lang.Runtime.toBool(@value);
						return @value;
					}
					
					
					case 1280692680:
					{
						this.slap = global::haxe.lang.Runtime.toBool(@value);
						return @value;
					}
					
					
					case 650430015:
					{
						this.hasRasgueado = global::haxe.lang.Runtime.toBool(@value);
						return @value;
					}
					
					
					case 5594513:
					{
						this.pop = global::haxe.lang.Runtime.toBool(@value);
						return @value;
					}
					
					
					case 632389428:
					{
						this.lyrics = ((global::haxe.root.Array<object>) (global::haxe.root.Array<object>.__hx_cast<object>(((global::haxe.root.Array) (@value) ))) );
						return @value;
					}
					
					
					case 1688947841:
					{
						this.fadeIn = global::haxe.lang.Runtime.toBool(@value);
						return @value;
					}
					
					
					case 1114502602:
					{
						this.dots = ((int) (global::haxe.lang.Runtime.toInt(@value)) );
						return @value;
					}
					
					
					case 638277820:
					{
						this.automations = ((global::haxe.root.Array<object>) (global::haxe.root.Array<object>.__hx_cast<object>(((global::haxe.root.Array) (@value) ))) );
						return @value;
					}
					
					
					case 207609411:
					{
						this.isEmpty = global::haxe.lang.Runtime.toBool(@value);
						return @value;
					}
					
					
					case 344854356:
					{
						this.duration = ((global::alphatab.model.Duration) (@value) );
						return @value;
					}
					
					
					case 49465911:
					{
						this._maxNote = ((global::alphatab.model.Note) (@value) );
						return @value;
					}
					
					
					case 1942741029:
					{
						this._minNote = ((global::alphatab.model.Note) (@value) );
						return @value;
					}
					
					
					case 533388353:
					{
						this.notes = ((global::haxe.root.Array<object>) (global::haxe.root.Array<object>.__hx_cast<object>(((global::haxe.root.Array) (@value) ))) );
						return @value;
					}
					
					
					case 989275570:
					{
						this.voice = ((global::alphatab.model.Voice) (@value) );
						return @value;
					}
					
					
					case 1041537810:
					{
						this.index = ((int) (global::haxe.lang.Runtime.toInt(@value)) );
						return @value;
					}
					
					
					case 1826654217:
					{
						this.nextBeat = ((global::alphatab.model.Beat) (@value) );
						return @value;
					}
					
					
					case 1739960653:
					{
						this.previousBeat = ((global::alphatab.model.Beat) (@value) );
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
					case 109002835:
					{
						return ((global::haxe.lang.Function) (new global::haxe.lang.Closure(((object) (this) ), ((string) ("finish") ), ((int) (109002835) ))) );
					}
					
					
					case 1764199192:
					{
						return ((global::haxe.lang.Function) (new global::haxe.lang.Closure(((object) (this) ), ((string) ("getNoteOnString") ), ((int) (1764199192) ))) );
					}
					
					
					case 1332371469:
					{
						return ((global::haxe.lang.Function) (new global::haxe.lang.Closure(((object) (this) ), ((string) ("getAutomation") ), ((int) (1332371469) ))) );
					}
					
					
					case 860674150:
					{
						return ((global::haxe.lang.Function) (new global::haxe.lang.Closure(((object) (this) ), ((string) ("refreshNotes") ), ((int) (860674150) ))) );
					}
					
					
					case 88562355:
					{
						return ((global::haxe.lang.Function) (new global::haxe.lang.Closure(((object) (this) ), ((string) ("addNote") ), ((int) (88562355) ))) );
					}
					
					
					case 2079799002:
					{
						return ((global::haxe.lang.Function) (new global::haxe.lang.Closure(((object) (this) ), ((string) ("calculateDuration") ), ((int) (2079799002) ))) );
					}
					
					
					case 1250598502:
					{
						return ((global::haxe.lang.Function) (new global::haxe.lang.Closure(((object) (this) ), ((string) ("hasTuplet") ), ((int) (1250598502) ))) );
					}
					
					
					case 1214452573:
					{
						return ((global::haxe.lang.Function) (new global::haxe.lang.Closure(((object) (this) ), ((string) ("clone") ), ((int) (1214452573) ))) );
					}
					
					
					case 1751303026:
					{
						return this.dynamicValue;
					}
					
					
					case 67859554:
					{
						return this.start;
					}
					
					
					case 848728090:
					{
						return this.crescendo;
					}
					
					
					case 706091227:
					{
						return (this.tremoloSpeed).toDynamic();
					}
					
					
					case 1614864450:
					{
						return ((global::haxe.lang.Function) (new global::haxe.lang.Closure(((object) (this) ), ((string) ("isTremolo") ), ((int) (1614864450) ))) );
					}
					
					
					case 1801219961:
					{
						return this.pickStroke;
					}
					
					
					case 233406162:
					{
						return this.graceType;
					}
					
					
					case 1170095196:
					{
						return ((global::haxe.lang.Function) (new global::haxe.lang.Closure(((object) (this) ), ((string) ("chord") ), ((int) (1170095196) ))) );
					}
					
					
					case 1377207970:
					{
						return ((global::haxe.lang.Function) (new global::haxe.lang.Closure(((object) (this) ), ((string) ("hasChord") ), ((int) (1377207970) ))) );
					}
					
					
					case 1594575703:
					{
						return this.chordId;
					}
					
					
					case 1598475321:
					{
						return this.vibrato;
					}
					
					
					case 1097521840:
					{
						return ((global::haxe.lang.Function) (new global::haxe.lang.Closure(((object) (this) ), ((string) ("hasWhammyBar") ), ((int) (1097521840) ))) );
					}
					
					
					case 1147430701:
					{
						return this.whammyBarPoints;
					}
					
					
					case 438479229:
					{
						return this.tupletNumerator;
					}
					
					
					case 1310257562:
					{
						return this.tupletDenominator;
					}
					
					
					case 1650208238:
					{
						return this.brushDuration;
					}
					
					
					case 1321811028:
					{
						return this.brushType;
					}
					
					
					case 1291439277:
					{
						return this.text;
					}
					
					
					case 5790307:
					{
						return this.tap;
					}
					
					
					case 1280692680:
					{
						return this.slap;
					}
					
					
					case 650430015:
					{
						return this.hasRasgueado;
					}
					
					
					case 5594513:
					{
						return this.pop;
					}
					
					
					case 632389428:
					{
						return this.lyrics;
					}
					
					
					case 1688947841:
					{
						return this.fadeIn;
					}
					
					
					case 1114502602:
					{
						return this.dots;
					}
					
					
					case 1762533406:
					{
						return ((global::haxe.lang.Function) (new global::haxe.lang.Closure(((object) (this) ), ((string) ("isRest") ), ((int) (1762533406) ))) );
					}
					
					
					case 638277820:
					{
						return this.automations;
					}
					
					
					case 207609411:
					{
						return this.isEmpty;
					}
					
					
					case 344854356:
					{
						return this.duration;
					}
					
					
					case 1228566710:
					{
						return ((global::haxe.lang.Function) (new global::haxe.lang.Closure(((object) (this) ), ((string) ("maxNote") ), ((int) (1228566710) ))) );
					}
					
					
					case 49465911:
					{
						return this._maxNote;
					}
					
					
					case 974358180:
					{
						return ((global::haxe.lang.Function) (new global::haxe.lang.Closure(((object) (this) ), ((string) ("minNote") ), ((int) (974358180) ))) );
					}
					
					
					case 1942741029:
					{
						return this._minNote;
					}
					
					
					case 533388353:
					{
						return this.notes;
					}
					
					
					case 989275570:
					{
						return this.voice;
					}
					
					
					case 1041537810:
					{
						return this.index;
					}
					
					
					case 1826654217:
					{
						return this.nextBeat;
					}
					
					
					case 1739960653:
					{
						return this.previousBeat;
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
					case 67859554:
					{
						return ((double) (this.start) );
					}
					
					
					case 438479229:
					{
						return ((double) (this.tupletNumerator) );
					}
					
					
					case 1310257562:
					{
						return ((double) (this.tupletDenominator) );
					}
					
					
					case 1650208238:
					{
						return ((double) (this.brushDuration) );
					}
					
					
					case 1114502602:
					{
						return ((double) (this.dots) );
					}
					
					
					case 1041537810:
					{
						return ((double) (this.index) );
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
					case 109002835:
					{
						this.finish();
						break;
					}
					
					
					case 1764199192:
					{
						return this.getNoteOnString(((int) (global::haxe.lang.Runtime.toInt(dynargs[0])) ));
					}
					
					
					case 1332371469:
					{
						return this.getAutomation(((global::alphatab.model.AutomationType) (dynargs[0]) ));
					}
					
					
					case 860674150:
					{
						this.refreshNotes();
						break;
					}
					
					
					case 88562355:
					{
						this.addNote(((global::alphatab.model.Note) (dynargs[0]) ));
						break;
					}
					
					
					case 2079799002:
					{
						return this.calculateDuration();
					}
					
					
					case 1250598502:
					{
						return this.hasTuplet();
					}
					
					
					case 1214452573:
					{
						return this.clone();
					}
					
					
					case 1614864450:
					{
						return this.isTremolo();
					}
					
					
					case 1170095196:
					{
						return this.chord();
					}
					
					
					case 1377207970:
					{
						return this.hasChord();
					}
					
					
					case 1097521840:
					{
						return this.hasWhammyBar();
					}
					
					
					case 1762533406:
					{
						return this.isRest();
					}
					
					
					case 1228566710:
					{
						return this.maxNote();
					}
					
					
					case 974358180:
					{
						return this.minNote();
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
				baseArr.push("dynamicValue");
				baseArr.push("start");
				baseArr.push("crescendo");
				baseArr.push("tremoloSpeed");
				baseArr.push("pickStroke");
				baseArr.push("graceType");
				baseArr.push("chordId");
				baseArr.push("vibrato");
				baseArr.push("whammyBarPoints");
				baseArr.push("tupletNumerator");
				baseArr.push("tupletDenominator");
				baseArr.push("brushDuration");
				baseArr.push("brushType");
				baseArr.push("text");
				baseArr.push("tap");
				baseArr.push("slap");
				baseArr.push("hasRasgueado");
				baseArr.push("pop");
				baseArr.push("lyrics");
				baseArr.push("fadeIn");
				baseArr.push("dots");
				baseArr.push("automations");
				baseArr.push("isEmpty");
				baseArr.push("duration");
				baseArr.push("_maxNote");
				baseArr.push("_minNote");
				baseArr.push("notes");
				baseArr.push("voice");
				baseArr.push("index");
				baseArr.push("nextBeat");
				baseArr.push("previousBeat");
				{
					base.__hx_getFields(baseArr);
				}
				
			}
		}
		
		
	}
}


