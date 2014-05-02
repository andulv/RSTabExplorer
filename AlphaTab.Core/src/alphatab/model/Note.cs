using haxe.root;
#pragma warning disable 109, 114, 219, 429, 168, 162
namespace alphatab.model{
	public  class Note : global::haxe.lang.HxObject {
		static Note() {
			global::alphatab.model.Note.FingeringUnknown = -2;
			global::alphatab.model.Note.FingeringNoOrDead = -1;
			global::alphatab.model.Note.FingeringThumb = 0;
			global::alphatab.model.Note.FingeringIndexFinger = 1;
			global::alphatab.model.Note.FingeringMiddleFinger = 2;
			global::alphatab.model.Note.FingeringAnnularFinger = 3;
			global::alphatab.model.Note.FingeringLittleFinger = 4;
		}
		public    Note(global::haxe.lang.EmptyObject empty){
			unchecked {
				{
				}
				
			}
		}
		
		
		public    Note(){
			unchecked {
				global::alphatab.model.Note.__hx_ctor_alphatab_model_Note(this);
			}
		}
		
		
		public static   void __hx_ctor_alphatab_model_Note(global::alphatab.model.Note __temp_me95){
			unchecked {
				__temp_me95.bendPoints = new global::haxe.root.Array<object>();
				__temp_me95.dynamicValue = global::alphatab.model.DynamicValue.F;
				__temp_me95.accentuated = global::alphatab.model.AccentuationType.None;
				__temp_me95.fret = -1;
				__temp_me95.isGhost = false;
				__temp_me95.@string = 0;
				__temp_me95.isHammerPullDestination = false;
				__temp_me95.isHammerPullOrigin = false;
				__temp_me95.harmonicValue = ((double) (0) );
				__temp_me95.harmonicType = global::alphatab.model.HarmonicType.None;
				__temp_me95.isLetRing = false;
				__temp_me95.isPalmMute = false;
				__temp_me95.isDead = false;
				__temp_me95.slideType = global::alphatab.model.SlideType.None;
				__temp_me95.vibrato = global::alphatab.model.VibratoType.None;
				__temp_me95.isStaccato = false;
				__temp_me95.isTieOrigin = false;
				__temp_me95.isTieDestination = false;
				__temp_me95.leftHandFinger = -1;
				__temp_me95.rightHandFinger = -1;
				__temp_me95.isFingering = false;
				__temp_me95.swapAccidentals = false;
				__temp_me95.trillValue = -1;
				__temp_me95.trillSpeed = global::alphatab.model.Duration.ThirtySecond;
				__temp_me95.durationPercent = ((double) (1) );
				__temp_me95.octave = -1;
			}
		}
		
		
		public static  int FingeringUnknown;
		
		public static  int FingeringNoOrDead;
		
		public static  int FingeringThumb;
		
		public static  int FingeringIndexFinger;
		
		public static  int FingeringMiddleFinger;
		
		public static  int FingeringAnnularFinger;
		
		public static  int FingeringLittleFinger;
		
		public static   global::alphatab.model.Note nextNoteOnSameLine(global::alphatab.model.Note note){
			unchecked {
				global::alphatab.model.Beat nextBeat = note.beat.nextBeat;
				while (( ( nextBeat != default(global::alphatab.model.Beat) ) && ( nextBeat.voice.bar.index <= ( note.beat.voice.bar.index + 3 ) ) )){
					global::alphatab.model.Note noteOnString = nextBeat.getNoteOnString(note.@string);
					if (( noteOnString != default(global::alphatab.model.Note) )) {
						return noteOnString;
					}
					 else {
						nextBeat = nextBeat.nextBeat;
					}
					
				}
				
				return default(global::alphatab.model.Note);
			}
		}
		
		
		public static   global::alphatab.model.Note previousNoteOnSameLine(global::alphatab.model.Note note){
			unchecked {
				global::alphatab.model.Beat previousBeat = note.beat.previousBeat;
				while (( ( previousBeat != default(global::alphatab.model.Beat) ) && ( previousBeat.voice.bar.index >= ( note.beat.voice.bar.index - 3 ) ) )){
					global::alphatab.model.Note noteOnString = previousBeat.getNoteOnString(note.@string);
					if (( noteOnString != default(global::alphatab.model.Note) )) {
						return noteOnString;
					}
					 else {
						previousBeat = previousBeat.previousBeat;
					}
					
				}
				
				return default(global::alphatab.model.Note);
			}
		}
		
		
		public static  new object __hx_createEmpty(){
			unchecked {
				return new global::alphatab.model.Note(((global::haxe.lang.EmptyObject) (global::haxe.lang.EmptyObject.EMPTY) ));
			}
		}
		
		
		public static  new object __hx_create(global::haxe.root.Array arr){
			unchecked {
				return new global::alphatab.model.Note();
			}
		}
		
		
		public  global::alphatab.model.AccentuationType accentuated;
		
		public  global::haxe.root.Array<object> bendPoints;
		
		public   bool hasBend(){
			unchecked {
				return ( this.bendPoints.length > 1 );
			}
		}
		
		
		public  int fret;
		
		public  bool isGhost;
		
		public  int @string;
		
		public  global::alphatab.model.Note hammerPullOrigin;
		
		public  bool isHammerPullDestination;
		
		public  bool isHammerPullOrigin;
		
		public  double harmonicValue;
		
		public  global::alphatab.model.HarmonicType harmonicType;
		
		public  bool isLetRing;
		
		public  bool isPalmMute;
		
		public  bool isDead;
		
		public  global::alphatab.model.SlideType slideType;
		
		public  global::alphatab.model.Note slideTarget;
		
		public  global::alphatab.model.VibratoType vibrato;
		
		public  bool isStaccato;
		
		public  global::alphatab.model.Note tieOrigin;
		
		public  bool isTieOrigin;
		
		public  bool isTieDestination;
		
		public  int leftHandFinger;
		
		public  int rightHandFinger;
		
		public  bool isFingering;
		
		public  int trillValue;
		
		public   int trillFret(){
			unchecked {
				return ( this.trillValue - this.beat.voice.bar.track.tuning[( ( this.beat.voice.bar.track.tuning.length - (( this.@string - 1 )) ) - 1 )] );
			}
		}
		
		
		public   bool isTrill(){
			unchecked {
				return ( this.trillValue >= 0 );
			}
		}
		
		
		public  global::alphatab.model.Duration trillSpeed;
		
		public  double durationPercent;
		
		public  bool swapAccidentals;
		
		public  global::alphatab.model.Beat beat;
		
		public  global::alphatab.model.DynamicValue dynamicValue;
		
		public  int octave;
		
		public virtual   global::alphatab.model.Note clone(){
			unchecked {
				global::alphatab.model.Note n = new global::alphatab.model.Note();
				{
					int _g = 0;
					global::haxe.root.Array<object> _g1 = this.bendPoints;
					while (( _g < _g1.length )){
						global::alphatab.model.BendPoint p = ((global::alphatab.model.BendPoint) (_g1[_g]) );
						 ++ _g;
						n.bendPoints.push(p.clone());
					}
					
				}
				
				n.dynamicValue = this.dynamicValue;
				n.accentuated = this.accentuated;
				n.fret = this.fret;
				n.isGhost = this.isGhost;
				n.@string = this.@string;
				n.isHammerPullDestination = this.isHammerPullDestination;
				n.isHammerPullOrigin = this.isHammerPullOrigin;
				n.harmonicValue = this.harmonicValue;
				n.harmonicType = this.harmonicType;
				n.isLetRing = this.isLetRing;
				n.isPalmMute = this.isPalmMute;
				n.isDead = this.isDead;
				n.slideType = this.slideType;
				n.vibrato = this.vibrato;
				n.isStaccato = this.isStaccato;
				n.isTieOrigin = this.isTieOrigin;
				n.isTieDestination = this.isTieDestination;
				n.leftHandFinger = this.leftHandFinger;
				n.rightHandFinger = this.rightHandFinger;
				n.isFingering = n.isFingering;
				n.swapAccidentals = this.swapAccidentals;
				n.trillValue = this.trillValue;
				n.trillSpeed = this.trillSpeed;
				n.durationPercent = this.durationPercent;
				return n;
			}
		}
		
		
		public   int stringTuning(){
			unchecked {
				return this.beat.voice.bar.track.tuning[( ( this.beat.voice.bar.track.tuning.length - (( this.@string - 1 )) ) - 1 )];
			}
		}
		
		
		public   int realValue(){
			unchecked {
				return ( this.fret + this.beat.voice.bar.track.tuning[( ( this.beat.voice.bar.track.tuning.length - (( this.@string - 1 )) ) - 1 )] );
			}
		}
		
		
		public virtual   void finish(){
			unchecked {
				global::haxe.root.Array<object> _g = new global::haxe.root.Array<object>(new object[]{this});
				global::alphatab.util.LazyVar<object> nextNoteOnLine = new global::alphatab.util.LazyVar<object>(((global::haxe.lang.Function) (new global::alphatab.model.Note_finish_179__Fun(((global::haxe.root.Array<object>) (_g) ))) ));
				global::alphatab.util.LazyVar<object> prevNoteOnLine = new global::alphatab.util.LazyVar<object>(((global::haxe.lang.Function) (new global::alphatab.model.Note_finish_180__Fun(((global::haxe.root.Array<object>) (_g) ))) ));
				if (this.isTieDestination) {
					if (( ((global::alphatab.model.Note) (prevNoteOnLine.getValue()) ) == default(global::alphatab.model.Note) )) {
						this.isTieDestination = false;
					}
					 else {
						this.tieOrigin = ((global::alphatab.model.Note) (prevNoteOnLine.getValue()) );
						this.tieOrigin.isTieOrigin = true;
						this.fret = this.tieOrigin.fret;
					}
					
				}
				
				if (this.isHammerPullOrigin) {
					if (( ((global::alphatab.model.Note) (nextNoteOnLine.getValue()) ) == default(global::alphatab.model.Note) )) {
						this.isHammerPullOrigin = false;
					}
					 else {
						((global::alphatab.model.Note) (nextNoteOnLine.getValue()) ).isHammerPullDestination = true;
						((global::alphatab.model.Note) (nextNoteOnLine.getValue()) ).hammerPullOrigin = this;
					}
					
				}
				
				if (( this.slideType != global::alphatab.model.SlideType.None )) {
					this.slideTarget = ((global::alphatab.model.Note) (nextNoteOnLine.getValue()) );
				}
				
			}
		}
		
		
		public override   double __hx_setField_f(string field, int hash, double @value, bool handleProperties){
			unchecked {
				switch (hash){
					case 792673520:
					{
						this.octave = ((int) (@value) );
						return @value;
					}
					
					
					case 949687761:
					{
						this.durationPercent = ((double) (@value) );
						return @value;
					}
					
					
					case 91153158:
					{
						this.trillValue = ((int) (@value) );
						return @value;
					}
					
					
					case 1806698356:
					{
						this.rightHandFinger = ((int) (@value) );
						return @value;
					}
					
					
					case 1286276959:
					{
						this.leftHandFinger = ((int) (@value) );
						return @value;
					}
					
					
					case 1969111172:
					{
						this.harmonicValue = ((double) (@value) );
						return @value;
					}
					
					
					case 288368849:
					{
						this.@string = ((int) (@value) );
						return @value;
					}
					
					
					case 1136827579:
					{
						this.fret = ((int) (@value) );
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
					case 792673520:
					{
						this.octave = ((int) (global::haxe.lang.Runtime.toInt(@value)) );
						return @value;
					}
					
					
					case 1751303026:
					{
						this.dynamicValue = ((global::alphatab.model.DynamicValue) (@value) );
						return @value;
					}
					
					
					case 1091821942:
					{
						this.beat = ((global::alphatab.model.Beat) (@value) );
						return @value;
					}
					
					
					case 2132043430:
					{
						this.swapAccidentals = global::haxe.lang.Runtime.toBool(@value);
						return @value;
					}
					
					
					case 949687761:
					{
						this.durationPercent = ((double) (global::haxe.lang.Runtime.toDouble(@value)) );
						return @value;
					}
					
					
					case 1428159260:
					{
						this.trillSpeed = ((global::alphatab.model.Duration) (@value) );
						return @value;
					}
					
					
					case 91153158:
					{
						this.trillValue = ((int) (global::haxe.lang.Runtime.toInt(@value)) );
						return @value;
					}
					
					
					case 1618969487:
					{
						this.isFingering = global::haxe.lang.Runtime.toBool(@value);
						return @value;
					}
					
					
					case 1806698356:
					{
						this.rightHandFinger = ((int) (global::haxe.lang.Runtime.toInt(@value)) );
						return @value;
					}
					
					
					case 1286276959:
					{
						this.leftHandFinger = ((int) (global::haxe.lang.Runtime.toInt(@value)) );
						return @value;
					}
					
					
					case 55629992:
					{
						this.isTieDestination = global::haxe.lang.Runtime.toBool(@value);
						return @value;
					}
					
					
					case 1361216012:
					{
						this.isTieOrigin = global::haxe.lang.Runtime.toBool(@value);
						return @value;
					}
					
					
					case 1923205974:
					{
						this.tieOrigin = ((global::alphatab.model.Note) (@value) );
						return @value;
					}
					
					
					case 253080294:
					{
						this.isStaccato = global::haxe.lang.Runtime.toBool(@value);
						return @value;
					}
					
					
					case 1598475321:
					{
						this.vibrato = ((global::alphatab.model.VibratoType) (@value) );
						return @value;
					}
					
					
					case 59156322:
					{
						this.slideTarget = ((global::alphatab.model.Note) (@value) );
						return @value;
					}
					
					
					case 1293078667:
					{
						this.slideType = ((global::alphatab.model.SlideType) (@value) );
						return @value;
					}
					
					
					case 1607275438:
					{
						this.isDead = global::haxe.lang.Runtime.toBool(@value);
						return @value;
					}
					
					
					case 1725549749:
					{
						this.isPalmMute = global::haxe.lang.Runtime.toBool(@value);
						return @value;
					}
					
					
					case 1914101345:
					{
						this.isLetRing = global::haxe.lang.Runtime.toBool(@value);
						return @value;
					}
					
					
					case 1528640775:
					{
						this.harmonicType = ((global::alphatab.model.HarmonicType) (@value) );
						return @value;
					}
					
					
					case 1969111172:
					{
						this.harmonicValue = ((double) (global::haxe.lang.Runtime.toDouble(@value)) );
						return @value;
					}
					
					
					case 1833015931:
					{
						this.isHammerPullOrigin = global::haxe.lang.Runtime.toBool(@value);
						return @value;
					}
					
					
					case 152554969:
					{
						this.isHammerPullDestination = global::haxe.lang.Runtime.toBool(@value);
						return @value;
					}
					
					
					case 1958899313:
					{
						this.hammerPullOrigin = ((global::alphatab.model.Note) (@value) );
						return @value;
					}
					
					
					case 288368849:
					{
						this.@string = ((int) (global::haxe.lang.Runtime.toInt(@value)) );
						return @value;
					}
					
					
					case 803091205:
					{
						this.isGhost = global::haxe.lang.Runtime.toBool(@value);
						return @value;
					}
					
					
					case 1136827579:
					{
						this.fret = ((int) (global::haxe.lang.Runtime.toInt(@value)) );
						return @value;
					}
					
					
					case 1402094524:
					{
						this.bendPoints = ((global::haxe.root.Array<object>) (global::haxe.root.Array<object>.__hx_cast<object>(((global::haxe.root.Array) (@value) ))) );
						return @value;
					}
					
					
					case 860647805:
					{
						this.accentuated = ((global::alphatab.model.AccentuationType) (@value) );
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
					
					
					case 897232691:
					{
						return ((global::haxe.lang.Function) (new global::haxe.lang.Closure(((object) (this) ), ((string) ("realValue") ), ((int) (897232691) ))) );
					}
					
					
					case 530960102:
					{
						return ((global::haxe.lang.Function) (new global::haxe.lang.Closure(((object) (this) ), ((string) ("stringTuning") ), ((int) (530960102) ))) );
					}
					
					
					case 1214452573:
					{
						return ((global::haxe.lang.Function) (new global::haxe.lang.Closure(((object) (this) ), ((string) ("clone") ), ((int) (1214452573) ))) );
					}
					
					
					case 792673520:
					{
						return this.octave;
					}
					
					
					case 1751303026:
					{
						return this.dynamicValue;
					}
					
					
					case 1091821942:
					{
						return this.beat;
					}
					
					
					case 2132043430:
					{
						return this.swapAccidentals;
					}
					
					
					case 949687761:
					{
						return this.durationPercent;
					}
					
					
					case 1428159260:
					{
						return this.trillSpeed;
					}
					
					
					case 850086945:
					{
						return ((global::haxe.lang.Function) (new global::haxe.lang.Closure(((object) (this) ), ((string) ("isTrill") ), ((int) (850086945) ))) );
					}
					
					
					case 680886982:
					{
						return ((global::haxe.lang.Function) (new global::haxe.lang.Closure(((object) (this) ), ((string) ("trillFret") ), ((int) (680886982) ))) );
					}
					
					
					case 91153158:
					{
						return this.trillValue;
					}
					
					
					case 1618969487:
					{
						return this.isFingering;
					}
					
					
					case 1806698356:
					{
						return this.rightHandFinger;
					}
					
					
					case 1286276959:
					{
						return this.leftHandFinger;
					}
					
					
					case 55629992:
					{
						return this.isTieDestination;
					}
					
					
					case 1361216012:
					{
						return this.isTieOrigin;
					}
					
					
					case 1923205974:
					{
						return this.tieOrigin;
					}
					
					
					case 253080294:
					{
						return this.isStaccato;
					}
					
					
					case 1598475321:
					{
						return this.vibrato;
					}
					
					
					case 59156322:
					{
						return this.slideTarget;
					}
					
					
					case 1293078667:
					{
						return this.slideType;
					}
					
					
					case 1607275438:
					{
						return this.isDead;
					}
					
					
					case 1725549749:
					{
						return this.isPalmMute;
					}
					
					
					case 1914101345:
					{
						return this.isLetRing;
					}
					
					
					case 1528640775:
					{
						return this.harmonicType;
					}
					
					
					case 1969111172:
					{
						return this.harmonicValue;
					}
					
					
					case 1833015931:
					{
						return this.isHammerPullOrigin;
					}
					
					
					case 152554969:
					{
						return this.isHammerPullDestination;
					}
					
					
					case 1958899313:
					{
						return this.hammerPullOrigin;
					}
					
					
					case 288368849:
					{
						return this.@string;
					}
					
					
					case 803091205:
					{
						return this.isGhost;
					}
					
					
					case 1136827579:
					{
						return this.fret;
					}
					
					
					case 274206003:
					{
						return ((global::haxe.lang.Function) (new global::haxe.lang.Closure(((object) (this) ), ((string) ("hasBend") ), ((int) (274206003) ))) );
					}
					
					
					case 1402094524:
					{
						return this.bendPoints;
					}
					
					
					case 860647805:
					{
						return this.accentuated;
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
					case 792673520:
					{
						return ((double) (this.octave) );
					}
					
					
					case 949687761:
					{
						return this.durationPercent;
					}
					
					
					case 91153158:
					{
						return ((double) (this.trillValue) );
					}
					
					
					case 1806698356:
					{
						return ((double) (this.rightHandFinger) );
					}
					
					
					case 1286276959:
					{
						return ((double) (this.leftHandFinger) );
					}
					
					
					case 1969111172:
					{
						return this.harmonicValue;
					}
					
					
					case 288368849:
					{
						return ((double) (this.@string) );
					}
					
					
					case 1136827579:
					{
						return ((double) (this.fret) );
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
					
					
					case 897232691:
					{
						return this.realValue();
					}
					
					
					case 530960102:
					{
						return this.stringTuning();
					}
					
					
					case 1214452573:
					{
						return this.clone();
					}
					
					
					case 850086945:
					{
						return this.isTrill();
					}
					
					
					case 680886982:
					{
						return this.trillFret();
					}
					
					
					case 274206003:
					{
						return this.hasBend();
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
				baseArr.push("octave");
				baseArr.push("dynamicValue");
				baseArr.push("beat");
				baseArr.push("swapAccidentals");
				baseArr.push("durationPercent");
				baseArr.push("trillSpeed");
				baseArr.push("trillValue");
				baseArr.push("isFingering");
				baseArr.push("rightHandFinger");
				baseArr.push("leftHandFinger");
				baseArr.push("isTieDestination");
				baseArr.push("isTieOrigin");
				baseArr.push("tieOrigin");
				baseArr.push("isStaccato");
				baseArr.push("vibrato");
				baseArr.push("slideTarget");
				baseArr.push("slideType");
				baseArr.push("isDead");
				baseArr.push("isPalmMute");
				baseArr.push("isLetRing");
				baseArr.push("harmonicType");
				baseArr.push("harmonicValue");
				baseArr.push("isHammerPullOrigin");
				baseArr.push("isHammerPullDestination");
				baseArr.push("hammerPullOrigin");
				baseArr.push("string");
				baseArr.push("isGhost");
				baseArr.push("fret");
				baseArr.push("bendPoints");
				baseArr.push("accentuated");
				{
					base.__hx_getFields(baseArr);
				}
				
			}
		}
		
		
	}
}



#pragma warning disable 109, 114, 219, 429, 168, 162
namespace alphatab.model{
	public  class Note_finish_179__Fun : global::haxe.lang.Function {
		public    Note_finish_179__Fun(global::haxe.root.Array<object> _g) : base(0, 0){
			unchecked {
				this._g = _g;
			}
		}
		
		
		public override   object __hx_invoke0_o(){
			unchecked {
				return global::alphatab.model.Note.nextNoteOnSameLine(((global::alphatab.model.Note) (this._g[0]) ));
			}
		}
		
		
		public  global::haxe.root.Array<object> _g;
		
	}
}



#pragma warning disable 109, 114, 219, 429, 168, 162
namespace alphatab.model{
	public  class Note_finish_180__Fun : global::haxe.lang.Function {
		public    Note_finish_180__Fun(global::haxe.root.Array<object> _g) : base(0, 0){
			unchecked {
				this._g = _g;
			}
		}
		
		
		public override   object __hx_invoke0_o(){
			unchecked {
				return global::alphatab.model.Note.previousNoteOnSameLine(((global::alphatab.model.Note) (this._g[0]) ));
			}
		}
		
		
		public  global::haxe.root.Array<object> _g;
		
	}
}


