using haxe.root;
#pragma warning disable 109, 114, 219, 429, 168, 162
namespace alphatab.audio.generator{
	public  class MidiFileGenerator : global::haxe.lang.HxObject {
		public    MidiFileGenerator(global::haxe.lang.EmptyObject empty){
			unchecked {
				{
				}
				
			}
		}
		
		
		public    MidiFileGenerator(global::alphatab.model.Score score, global::alphatab.audio.generator.IMidiFileHandler handler, global::haxe.lang.Null<bool> generateMetronome){
			unchecked {
				global::alphatab.audio.generator.MidiFileGenerator.__hx_ctor_alphatab_audio_generator_MidiFileGenerator(this, score, handler, generateMetronome);
			}
		}
		
		
		public static   void __hx_ctor_alphatab_audio_generator_MidiFileGenerator(global::alphatab.audio.generator.MidiFileGenerator __temp_me58, global::alphatab.model.Score score, global::alphatab.audio.generator.IMidiFileHandler handler, global::haxe.lang.Null<bool> generateMetronome){
			unchecked {
				bool __temp_generateMetronome57 = ( ( ! (generateMetronome.hasValue) ) ? (global::haxe.lang.Runtime.toBool(false)) : (generateMetronome.@value) );
				__temp_me58._score = score;
				__temp_me58._currentTempo = __temp_me58._score.tempo;
				__temp_me58._handler = handler;
				__temp_me58.generateMetronome = __temp_generateMetronome57;
			}
		}
		
		
		public static   global::alphatab.audio.model.MidiFile generateMidiFile(global::alphatab.model.Score score, global::haxe.lang.Null<bool> generateMetronome){
			unchecked {
				bool __temp_generateMetronome56 = ( ( ! (generateMetronome.hasValue) ) ? (global::haxe.lang.Runtime.toBool(false)) : (generateMetronome.@value) );
				global::alphatab.audio.model.MidiFile midiFile = new global::alphatab.audio.model.MidiFile();
				{
					int _g1 = 0;
					int _g = score.tracks.length;
					while (( _g1 < _g )){
						int i = _g1++;
						midiFile.createTrack();
					}
					
				}
				
				midiFile.infoTrack = 0;
				global::alphatab.audio.generator.MidiFileHandler handler = new global::alphatab.audio.generator.MidiFileHandler(((global::alphatab.audio.model.MidiFile) (midiFile) ));
				global::alphatab.audio.generator.MidiFileGenerator generator = new global::alphatab.audio.generator.MidiFileGenerator(((global::alphatab.model.Score) (score) ), ((global::alphatab.audio.generator.IMidiFileHandler) (handler) ), new global::haxe.lang.Null<bool>(__temp_generateMetronome56, true));
				generator.generate();
				return midiFile;
			}
		}
		
		
		public static   int toChannelShort(int data){
			unchecked {
				int @value = default(int);
				{
					double x = default(double);
					{
						double b = global::System.Math.Min(((double) (32767) ), ((double) (( ( data * 8 ) - 1 )) ));
						x = global::System.Math.Max(((double) (-32768) ), ((double) (b) ));
					}
					
					@value = ((int) (x) );
				}
				
				int __temp_stmt522 = default(int);
				{
					double x1 = global::System.Math.Max(((double) (@value) ), ((double) (-1) ));
					__temp_stmt522 = ((int) (x1) );
				}
				
				return ( __temp_stmt522 + 1 );
			}
		}
		
		
		public static  new object __hx_createEmpty(){
			unchecked {
				return new global::alphatab.audio.generator.MidiFileGenerator(((global::haxe.lang.EmptyObject) (global::haxe.lang.EmptyObject.EMPTY) ));
			}
		}
		
		
		public static  new object __hx_create(global::haxe.root.Array arr){
			unchecked {
				return new global::alphatab.audio.generator.MidiFileGenerator(((global::alphatab.model.Score) (arr[0]) ), ((global::alphatab.audio.generator.IMidiFileHandler) (arr[1]) ), global::haxe.lang.Null<object>.ofDynamic<bool>(arr[2]));
			}
		}
		
		
		public  global::alphatab.model.Score _score;
		
		public  global::alphatab.audio.generator.IMidiFileHandler _handler;
		
		public  int _currentTempo;
		
		public  int _metronomeTrack;
		
		public  bool generateMetronome;
		
		public virtual   void generate(){
			unchecked {
				{
					int _g = 0;
					global::haxe.root.Array<object> _g1 = this._score.tracks;
					while (( _g < _g1.length )){
						global::alphatab.model.Track track = ((global::alphatab.model.Track) (_g1[_g]) );
						 ++ _g;
						this.generateTrack(track);
					}
					
				}
				
				global::alphatab.audio.generator.MidiPlaybackController controller = new global::alphatab.audio.generator.MidiPlaybackController(((global::alphatab.model.Score) (this._score) ));
				global::alphatab.model.MasterBar previousMasterBar = default(global::alphatab.model.MasterBar);
				while ( ! ((( controller.index >= controller._score.masterBars.length ))) ){
					int index = controller.index;
					int repeatMove = controller.repeatMove;
					controller.process();
					if (controller.shouldPlay) {
						this.generateMasterBar(((global::alphatab.model.MasterBar) (this._score.masterBars[index]) ), previousMasterBar, controller.repeatMove);
						{
							int _g2 = 0;
							global::haxe.root.Array<object> _g11 = this._score.tracks;
							while (( _g2 < _g11.length )){
								global::alphatab.model.Track track1 = ((global::alphatab.model.Track) (_g11[_g2]) );
								 ++ _g2;
								this.generateBar(((global::alphatab.model.Bar) (track1.bars[index]) ), controller.repeatMove);
							}
							
						}
						
					}
					
					previousMasterBar = ((global::alphatab.model.MasterBar) (this._score.masterBars[index]) );
				}
				
			}
		}
		
		
		public virtual   void generateTrack(global::alphatab.model.Track track){
			unchecked {
				this.generateChannel(track, track.playbackInfo.primaryChannel, track.playbackInfo);
				if (( track.playbackInfo.primaryChannel != track.playbackInfo.secondaryChannel )) {
					this.generateChannel(track, track.playbackInfo.secondaryChannel, track.playbackInfo);
				}
				
			}
		}
		
		
		public virtual   void generateChannel(global::alphatab.model.Track track, int channel, global::alphatab.model.PlaybackInformation playbackInfo){
			unchecked {
				int volume = global::alphatab.audio.generator.MidiFileGenerator.toChannelShort(playbackInfo.volume);
				int balance = global::alphatab.audio.generator.MidiFileGenerator.toChannelShort(playbackInfo.balance);
				this._handler.addControlChange(track.index, 0, channel, 7, volume);
				this._handler.addControlChange(track.index, 0, channel, 10, balance);
				this._handler.addControlChange(track.index, 0, channel, 11, 127);
				this._handler.addProgramChange(track.index, 0, channel, playbackInfo.program);
			}
		}
		
		
		public virtual   void generateMasterBar(global::alphatab.model.MasterBar masterBar, global::alphatab.model.MasterBar previousMasterBar, int startMove){
			unchecked {
				if (( ( ( previousMasterBar == default(global::alphatab.model.MasterBar) ) || ( previousMasterBar.timeSignatureDenominator != masterBar.timeSignatureDenominator ) ) || ( previousMasterBar.timeSignatureNumerator != masterBar.timeSignatureNumerator ) )) {
					this._handler.addTimeSignature(( masterBar.start + startMove ), masterBar.timeSignatureNumerator, masterBar.timeSignatureDenominator);
				}
				
				if (( previousMasterBar == default(global::alphatab.model.MasterBar) )) {
					this._handler.addTempo(( masterBar.start + startMove ), masterBar.score.tempo);
					this._currentTempo = masterBar.score.tempo;
				}
				 else {
					if (( masterBar.tempoAutomation != default(global::alphatab.model.Automation) )) {
						this._handler.addTempo(( masterBar.start + startMove ), ((int) (masterBar.tempoAutomation.@value) ));
						this._currentTempo = ((int) (masterBar.tempoAutomation.@value) );
					}
					
				}
				
				if (this.generateMetronome) {
					int start = ( masterBar.start + startMove );
					int length = global::alphatab.audio.MidiUtils.valueToTicks(masterBar.timeSignatureDenominator);
					{
						int _g1 = 0;
						int _g = masterBar.timeSignatureNumerator;
						while (( _g1 < _g )){
							int i = _g1++;
							this._handler.addMetronome(start, length);
							start += length;
						}
						
					}
					
				}
				
			}
		}
		
		
		public virtual   void generateBar(global::alphatab.model.Bar bar, int startMove){
			unchecked {
				int _g = 0;
				global::haxe.root.Array<object> _g1 = bar.voices;
				while (( _g < _g1.length )){
					global::alphatab.model.Voice voice = ((global::alphatab.model.Voice) (_g1[_g]) );
					 ++ _g;
					this.generateVoice(voice, startMove);
				}
				
			}
		}
		
		
		public virtual   void generateVoice(global::alphatab.model.Voice voice, int startMove){
			unchecked {
				int _g = 0;
				global::haxe.root.Array<object> _g1 = voice.beats;
				while (( _g < _g1.length )){
					global::alphatab.model.Beat b = ((global::alphatab.model.Beat) (_g1[_g]) );
					 ++ _g;
					this.generateBeat(b, startMove);
				}
				
			}
		}
		
		
		public virtual   void generateBeat(global::alphatab.model.Beat beat, int startMove){
			unchecked {
				int start = beat.start;
				int duration = beat.calculateDuration();
				global::alphatab.model.Track track = beat.voice.bar.track;
				{
					int _g = 0;
					global::haxe.root.Array<object> _g1 = beat.automations;
					while (( _g < _g1.length )){
						global::alphatab.model.Automation automation = ((global::alphatab.model.Automation) (_g1[_g]) );
						 ++ _g;
						this.generateAutomation(beat, automation, startMove);
					}
					
				}
				
				if (beat.isRest()) {
					this._handler.addRest(track.index, ( start + startMove ), track.playbackInfo.primaryChannel);
				}
				 else {
					global::haxe.root.Array<int> brushInfo = this.getBrushInfo(beat);
					{
						int _g2 = 0;
						global::haxe.root.Array<object> _g11 = beat.notes;
						while (( _g2 < _g11.length )){
							global::alphatab.model.Note n = ((global::alphatab.model.Note) (_g11[_g2]) );
							 ++ _g2;
							if (n.isTieDestination) {
								continue;
							}
							
							this.generateNote(n, start, duration, startMove, brushInfo);
						}
						
					}
					
				}
				
			}
		}
		
		
		public virtual   void generateNote(global::alphatab.model.Note note, int beatStart, int beatDuration, int startMove, global::haxe.root.Array<int> brushInfo){
			unchecked {
				global::alphatab.model.Track track = note.beat.voice.bar.track;
				int noteKey = ( track.capo + (( note.fret + note.beat.voice.bar.track.tuning[( ( note.beat.voice.bar.track.tuning.length - (( note.@string - 1 )) ) - 1 )] )) );
				int noteStart = ( ( beatStart + startMove ) + brushInfo[( note.@string - 1 )] );
				int noteDuration = ( this.getNoteDuration(note, beatDuration) - brushInfo[( note.@string - 1 )] );
				global::alphatab.model.DynamicValue dynamicValue = this.getDynamicValue(note);
				if (note.beat.fadeIn) {
					this.generateFadeIn(note, noteStart, noteDuration, noteKey, dynamicValue);
				}
				
				if (( ( note.trillValue >= 0 ) &&  ! (track.isPercussion)  )) {
					this.generateTrill(note, noteStart, noteDuration, noteKey, dynamicValue);
					return ;
				}
				
				if (note.beat.tremoloSpeed.hasValue) {
					this.generateTremoloPicking(note, noteStart, noteDuration, noteKey, dynamicValue);
					return ;
				}
				
				if (( note.bendPoints.length > 1 )) {
					this.generateBend(note, noteStart, noteDuration, noteKey, dynamicValue);
				}
				 else {
					if (( note.beat.whammyBarPoints.length > 0 )) {
						this.generateWhammyBar(note, noteStart, noteDuration, noteKey, dynamicValue);
					}
					 else {
						if (( note.slideType != global::alphatab.model.SlideType.None )) {
							this.generateSlide(note, noteStart, noteDuration, noteKey, dynamicValue);
						}
						 else {
							if (( note.vibrato != global::alphatab.model.VibratoType.None )) {
								this.generateVibrato(note, noteStart, noteDuration, noteKey, dynamicValue);
							}
							
						}
						
					}
					
				}
				
				if (( note.harmonicType != global::alphatab.model.HarmonicType.None )) {
					this.generateHarmonic(note, noteStart, noteDuration, noteKey, dynamicValue);
				}
				
				this._handler.addNote(track.index, noteStart, noteDuration, noteKey, dynamicValue, track.playbackInfo.primaryChannel);
			}
		}
		
		
		public virtual   int getNoteDuration(global::alphatab.model.Note note, int beatDuration){
			unchecked {
				return this.applyDurationEffects(note, beatDuration);
			}
		}
		
		
		public virtual   int applyDurationEffects(global::alphatab.model.Note note, int duration){
			unchecked {
				if (note.isDead) {
					return this.applyStaticDuration(30, duration);
				}
				
				if (note.isPalmMute) {
					return this.applyStaticDuration(80, duration);
				}
				
				if (note.isStaccato) {
					return ( duration / 2 );
				}
				
				return duration;
			}
		}
		
		
		public virtual   int applyStaticDuration(int duration, int maximum){
			unchecked {
				double @value = ( ((double) (( this._currentTempo * duration )) ) / 60 );
				{
					double x = global::System.Math.Min(((double) (@value) ), ((double) (maximum) ));
					return ((int) (x) );
				}
				
			}
		}
		
		
		public virtual   global::alphatab.model.DynamicValue getDynamicValue(global::alphatab.model.Note note){
			unchecked {
				global::alphatab.model.DynamicValue dynamicValue = note.dynamicValue;
				global::haxe.root.Array<global::alphatab.model.DynamicValue> allDynamics = global::haxe.root.Type.allEnums<global::alphatab.model.DynamicValue>(typeof(global::alphatab.model.DynamicValue));
				int currentIndex = global::haxe.root.Lambda.indexOf<global::alphatab.model.DynamicValue>(allDynamics, dynamicValue);
				if ((  ! (note.beat.voice.bar.track.isPercussion)  && note.isHammerPullDestination )) {
					currentIndex--;
				}
				
				if (note.isGhost) {
					currentIndex--;
				}
				
				{
					global::alphatab.model.AccentuationType _g = note.accentuated;
					switch (global::haxe.root.Type.enumIndex(_g)){
						case 1:
						{
							currentIndex++;
							break;
						}
						
						
						case 2:
						{
							currentIndex += 2;
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
				
				int __temp_stmt521 = default(int);
				{
					double x = default(double);
					{
						double b = global::System.Math.Min(((double) (( allDynamics.length - 1 )) ), ((double) (currentIndex) ));
						x = global::System.Math.Max(((double) (0) ), ((double) (b) ));
					}
					
					__temp_stmt521 = ((int) (x) );
				}
				
				return allDynamics[__temp_stmt521];
			}
		}
		
		
		public virtual   void generateFadeIn(global::alphatab.model.Note note, int noteStart, int noteDuration, int noteKey, global::alphatab.model.DynamicValue dynamicValue){
			unchecked {
				{
				}
				
			}
		}
		
		
		public virtual   void generateHarmonic(global::alphatab.model.Note note, int noteStart, int noteDuration, int noteKey, global::alphatab.model.DynamicValue dynamicValue){
			unchecked {
				{
				}
				
			}
		}
		
		
		public virtual   void generateVibrato(global::alphatab.model.Note note, int noteStart, int noteDuration, int noteKey, global::alphatab.model.DynamicValue dynamicValue){
			unchecked {
				{
				}
				
			}
		}
		
		
		public virtual   void generateSlide(global::alphatab.model.Note note, int noteStart, int noteDuration, int noteKey, global::alphatab.model.DynamicValue dynamicValue){
			unchecked {
				{
				}
				
			}
		}
		
		
		public virtual   void generateWhammyBar(global::alphatab.model.Note note, int noteStart, int noteDuration, int noteKey, global::alphatab.model.DynamicValue dynamicValue){
			unchecked {
				{
				}
				
			}
		}
		
		
		public virtual   void generateBend(global::alphatab.model.Note note, int noteStart, int noteDuration, int noteKey, global::alphatab.model.DynamicValue dynamicValue){
			unchecked {
				{
				}
				
			}
		}
		
		
		public virtual   void generateTrill(global::alphatab.model.Note note, int noteStart, int noteDuration, int noteKey, global::alphatab.model.DynamicValue dynamicValue){
			unchecked {
				global::alphatab.model.Track track = note.beat.voice.bar.track;
				int trillKey = ( ( track.capo + note.beat.voice.bar.track.tuning[( ( note.beat.voice.bar.track.tuning.length - (( note.@string - 1 )) ) - 1 )] ) + (( note.trillValue - note.beat.voice.bar.track.tuning[( ( note.beat.voice.bar.track.tuning.length - (( note.@string - 1 )) ) - 1 )] )) );
				int trillLength = global::alphatab.audio.MidiUtils.durationToTicks(note.trillSpeed);
				bool realKey = true;
				int tick = noteStart;
				while (( ( tick + 10 ) < ( noteStart + noteDuration ) )){
					if (( ( tick + trillLength ) >= ( noteStart + noteDuration ) )) {
						trillLength = ( ( noteStart + noteDuration ) - tick );
					}
					
					this._handler.addNote(track.index, tick, trillLength, ( (realKey) ? (trillKey) : (noteKey) ), dynamicValue, track.playbackInfo.primaryChannel);
					realKey =  ! (realKey) ;
					tick += trillLength;
				}
				
			}
		}
		
		
		public virtual   void generateTremoloPicking(global::alphatab.model.Note note, int noteStart, int noteDuration, int noteKey, global::alphatab.model.DynamicValue dynamicValue){
			unchecked {
				global::alphatab.model.Track track = note.beat.voice.bar.track;
				int tpLength = global::alphatab.audio.MidiUtils.durationToTicks(note.beat.tremoloSpeed.@value);
				int tick = noteStart;
				while (( ( tick + 10 ) < ( noteStart + noteDuration ) )){
					if (( ( tick + tpLength ) >= ( noteStart + noteDuration ) )) {
						tpLength = ( ( noteStart + noteDuration ) - tick );
					}
					
					this._handler.addNote(track.index, tick, tpLength, noteKey, dynamicValue, track.playbackInfo.primaryChannel);
					tick += tpLength;
				}
				
			}
		}
		
		
		public virtual   global::haxe.root.Array<int> getBrushInfo(global::alphatab.model.Beat beat){
			unchecked {
				global::haxe.root.Array<int> brushInfo = new global::haxe.root.Array<int>();
				{
					int _g1 = 0;
					int _g = beat.voice.bar.track.tuning.length;
					while (( _g1 < _g )){
						int i = _g1++;
						brushInfo.push(0);
					}
					
				}
				
				if (( beat.brushType != global::alphatab.model.BrushType.None )) {
					int stringUsed = 0;
					int stringCount = 0;
					{
						int _g2 = 0;
						global::haxe.root.Array<object> _g11 = beat.notes;
						while (( _g2 < _g11.length )){
							global::alphatab.model.Note n = ((global::alphatab.model.Note) (_g11[_g2]) );
							 ++ _g2;
							if (n.isTieDestination) {
								continue;
							}
							
							stringUsed |= ( 1 << ( n.@string - 1 ) );
							stringCount++;
						}
						
					}
					
					if (( beat.notes.length > 0 )) {
						int brushMove = 0;
						int brushIncrement = this.getBrushIncrement(beat);
						{
							int _g12 = 0;
							int _g3 = beat.voice.bar.track.tuning.length;
							while (( _g12 < _g3 )){
								int i1 = _g12++;
								int index = default(int);
								if (( ( beat.brushType == global::alphatab.model.BrushType.ArpeggioDown ) || ( beat.brushType == global::alphatab.model.BrushType.BrushDown ) )) {
									index = i1;
								}
								 else {
									index = ( ( brushInfo.length - 1 ) - i1 );
								}
								
								if (( (( stringUsed & ( 1 << index ) )) != 0 )) {
									brushInfo[index] = brushMove;
									brushMove = brushIncrement;
								}
								
							}
							
						}
						
					}
					
				}
				
				return brushInfo;
			}
		}
		
		
		public virtual   int getBrushIncrement(global::alphatab.model.Beat beat){
			unchecked {
				if (( beat.brushDuration == 0 )) {
					return 0;
				}
				
				int duration = beat.calculateDuration();
				if (( duration == 0 )) {
					return 0;
				}
				
				return ((int) (( ( duration / 8.0 ) * (( 4.0 / beat.brushDuration )) )) );
			}
		}
		
		
		public virtual   void generateAutomation(global::alphatab.model.Beat beat, global::alphatab.model.Automation automation, int startMove){
			unchecked {
				global::alphatab.model.AutomationType _g = automation.type;
				switch (global::haxe.root.Type.enumIndex(_g)){
					case 2:
					{
						this._handler.addProgramChange(beat.voice.bar.track.index, ( beat.start + startMove ), beat.voice.bar.track.playbackInfo.primaryChannel, ((int) (automation.@value) ));
						this._handler.addProgramChange(beat.voice.bar.track.index, ( beat.start + startMove ), beat.voice.bar.track.playbackInfo.secondaryChannel, ((int) (automation.@value) ));
						break;
					}
					
					
					case 3:
					{
						this._handler.addControlChange(beat.voice.bar.track.index, ( beat.start + startMove ), beat.voice.bar.track.playbackInfo.primaryChannel, 10, ((int) (automation.@value) ));
						this._handler.addControlChange(beat.voice.bar.track.index, ( beat.start + startMove ), beat.voice.bar.track.playbackInfo.secondaryChannel, 10, ((int) (automation.@value) ));
						break;
					}
					
					
					case 1:
					{
						this._handler.addControlChange(beat.voice.bar.track.index, ( beat.start + startMove ), beat.voice.bar.track.playbackInfo.primaryChannel, 7, ((int) (automation.@value) ));
						this._handler.addControlChange(beat.voice.bar.track.index, ( beat.start + startMove ), beat.voice.bar.track.playbackInfo.secondaryChannel, 7, ((int) (automation.@value) ));
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
		
		
		public override   double __hx_setField_f(string field, int hash, double @value, bool handleProperties){
			unchecked {
				switch (hash){
					case 1892175512:
					{
						this._metronomeTrack = ((int) (@value) );
						return @value;
					}
					
					
					case 923494081:
					{
						this._currentTempo = ((int) (@value) );
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
					case 1987417405:
					{
						this.generateMetronome = global::haxe.lang.Runtime.toBool(@value);
						return @value;
					}
					
					
					case 1892175512:
					{
						this._metronomeTrack = ((int) (global::haxe.lang.Runtime.toInt(@value)) );
						return @value;
					}
					
					
					case 923494081:
					{
						this._currentTempo = ((int) (global::haxe.lang.Runtime.toInt(@value)) );
						return @value;
					}
					
					
					case 2140014923:
					{
						this._handler = ((global::alphatab.audio.generator.IMidiFileHandler) (@value) );
						return @value;
					}
					
					
					case 1958787731:
					{
						this._score = ((global::alphatab.model.Score) (@value) );
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
					case 430201708:
					{
						return ((global::haxe.lang.Function) (new global::haxe.lang.Closure(((object) (this) ), ((string) ("generateAutomation") ), ((int) (430201708) ))) );
					}
					
					
					case 1795120523:
					{
						return ((global::haxe.lang.Function) (new global::haxe.lang.Closure(((object) (this) ), ((string) ("getBrushIncrement") ), ((int) (1795120523) ))) );
					}
					
					
					case 1456610962:
					{
						return ((global::haxe.lang.Function) (new global::haxe.lang.Closure(((object) (this) ), ((string) ("getBrushInfo") ), ((int) (1456610962) ))) );
					}
					
					
					case 372828938:
					{
						return ((global::haxe.lang.Function) (new global::haxe.lang.Closure(((object) (this) ), ((string) ("generateTremoloPicking") ), ((int) (372828938) ))) );
					}
					
					
					case 1017280758:
					{
						return ((global::haxe.lang.Function) (new global::haxe.lang.Closure(((object) (this) ), ((string) ("generateTrill") ), ((int) (1017280758) ))) );
					}
					
					
					case 333952654:
					{
						return ((global::haxe.lang.Function) (new global::haxe.lang.Closure(((object) (this) ), ((string) ("generateBend") ), ((int) (333952654) ))) );
					}
					
					
					case 703620981:
					{
						return ((global::haxe.lang.Function) (new global::haxe.lang.Closure(((object) (this) ), ((string) ("generateWhammyBar") ), ((int) (703620981) ))) );
					}
					
					
					case 625251772:
					{
						return ((global::haxe.lang.Function) (new global::haxe.lang.Closure(((object) (this) ), ((string) ("generateSlide") ), ((int) (625251772) ))) );
					}
					
					
					case 989926788:
					{
						return ((global::haxe.lang.Function) (new global::haxe.lang.Closure(((object) (this) ), ((string) ("generateVibrato") ), ((int) (989926788) ))) );
					}
					
					
					case 108336130:
					{
						return ((global::haxe.lang.Function) (new global::haxe.lang.Closure(((object) (this) ), ((string) ("generateHarmonic") ), ((int) (108336130) ))) );
					}
					
					
					case 1801778582:
					{
						return ((global::haxe.lang.Function) (new global::haxe.lang.Closure(((object) (this) ), ((string) ("generateFadeIn") ), ((int) (1801778582) ))) );
					}
					
					
					case 189602088:
					{
						return ((global::haxe.lang.Function) (new global::haxe.lang.Closure(((object) (this) ), ((string) ("getDynamicValue") ), ((int) (189602088) ))) );
					}
					
					
					case 461079600:
					{
						return ((global::haxe.lang.Function) (new global::haxe.lang.Closure(((object) (this) ), ((string) ("applyStaticDuration") ), ((int) (461079600) ))) );
					}
					
					
					case 1087118848:
					{
						return ((global::haxe.lang.Function) (new global::haxe.lang.Closure(((object) (this) ), ((string) ("applyDurationEffects") ), ((int) (1087118848) ))) );
					}
					
					
					case 215513884:
					{
						return ((global::haxe.lang.Function) (new global::haxe.lang.Closure(((object) (this) ), ((string) ("getNoteDuration") ), ((int) (215513884) ))) );
					}
					
					
					case 467526087:
					{
						return ((global::haxe.lang.Function) (new global::haxe.lang.Closure(((object) (this) ), ((string) ("generateNote") ), ((int) (467526087) ))) );
					}
					
					
					case 333949771:
					{
						return ((global::haxe.lang.Function) (new global::haxe.lang.Closure(((object) (this) ), ((string) ("generateBeat") ), ((int) (333949771) ))) );
					}
					
					
					case 1634989629:
					{
						return ((global::haxe.lang.Function) (new global::haxe.lang.Closure(((object) (this) ), ((string) ("generateVoice") ), ((int) (1634989629) ))) );
					}
					
					
					case 1176353182:
					{
						return ((global::haxe.lang.Function) (new global::haxe.lang.Closure(((object) (this) ), ((string) ("generateBar") ), ((int) (1176353182) ))) );
					}
					
					
					case 1968041052:
					{
						return ((global::haxe.lang.Function) (new global::haxe.lang.Closure(((object) (this) ), ((string) ("generateMasterBar") ), ((int) (1968041052) ))) );
					}
					
					
					case 680282638:
					{
						return ((global::haxe.lang.Function) (new global::haxe.lang.Closure(((object) (this) ), ((string) ("generateChannel") ), ((int) (680282638) ))) );
					}
					
					
					case 1016880918:
					{
						return ((global::haxe.lang.Function) (new global::haxe.lang.Closure(((object) (this) ), ((string) ("generateTrack") ), ((int) (1016880918) ))) );
					}
					
					
					case 1503813429:
					{
						return ((global::haxe.lang.Function) (new global::haxe.lang.Closure(((object) (this) ), ((string) ("generate") ), ((int) (1503813429) ))) );
					}
					
					
					case 1987417405:
					{
						return this.generateMetronome;
					}
					
					
					case 1892175512:
					{
						return this._metronomeTrack;
					}
					
					
					case 923494081:
					{
						return this._currentTempo;
					}
					
					
					case 2140014923:
					{
						return this._handler;
					}
					
					
					case 1958787731:
					{
						return this._score;
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
					case 1892175512:
					{
						return ((double) (this._metronomeTrack) );
					}
					
					
					case 923494081:
					{
						return ((double) (this._currentTempo) );
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
					case 430201708:
					{
						this.generateAutomation(((global::alphatab.model.Beat) (dynargs[0]) ), ((global::alphatab.model.Automation) (dynargs[1]) ), ((int) (global::haxe.lang.Runtime.toInt(dynargs[2])) ));
						break;
					}
					
					
					case 1795120523:
					{
						return this.getBrushIncrement(((global::alphatab.model.Beat) (dynargs[0]) ));
					}
					
					
					case 1456610962:
					{
						return this.getBrushInfo(((global::alphatab.model.Beat) (dynargs[0]) ));
					}
					
					
					case 372828938:
					{
						this.generateTremoloPicking(((global::alphatab.model.Note) (dynargs[0]) ), ((int) (global::haxe.lang.Runtime.toInt(dynargs[1])) ), ((int) (global::haxe.lang.Runtime.toInt(dynargs[2])) ), ((int) (global::haxe.lang.Runtime.toInt(dynargs[3])) ), ((global::alphatab.model.DynamicValue) (dynargs[4]) ));
						break;
					}
					
					
					case 1017280758:
					{
						this.generateTrill(((global::alphatab.model.Note) (dynargs[0]) ), ((int) (global::haxe.lang.Runtime.toInt(dynargs[1])) ), ((int) (global::haxe.lang.Runtime.toInt(dynargs[2])) ), ((int) (global::haxe.lang.Runtime.toInt(dynargs[3])) ), ((global::alphatab.model.DynamicValue) (dynargs[4]) ));
						break;
					}
					
					
					case 333952654:
					{
						this.generateBend(((global::alphatab.model.Note) (dynargs[0]) ), ((int) (global::haxe.lang.Runtime.toInt(dynargs[1])) ), ((int) (global::haxe.lang.Runtime.toInt(dynargs[2])) ), ((int) (global::haxe.lang.Runtime.toInt(dynargs[3])) ), ((global::alphatab.model.DynamicValue) (dynargs[4]) ));
						break;
					}
					
					
					case 703620981:
					{
						this.generateWhammyBar(((global::alphatab.model.Note) (dynargs[0]) ), ((int) (global::haxe.lang.Runtime.toInt(dynargs[1])) ), ((int) (global::haxe.lang.Runtime.toInt(dynargs[2])) ), ((int) (global::haxe.lang.Runtime.toInt(dynargs[3])) ), ((global::alphatab.model.DynamicValue) (dynargs[4]) ));
						break;
					}
					
					
					case 625251772:
					{
						this.generateSlide(((global::alphatab.model.Note) (dynargs[0]) ), ((int) (global::haxe.lang.Runtime.toInt(dynargs[1])) ), ((int) (global::haxe.lang.Runtime.toInt(dynargs[2])) ), ((int) (global::haxe.lang.Runtime.toInt(dynargs[3])) ), ((global::alphatab.model.DynamicValue) (dynargs[4]) ));
						break;
					}
					
					
					case 989926788:
					{
						this.generateVibrato(((global::alphatab.model.Note) (dynargs[0]) ), ((int) (global::haxe.lang.Runtime.toInt(dynargs[1])) ), ((int) (global::haxe.lang.Runtime.toInt(dynargs[2])) ), ((int) (global::haxe.lang.Runtime.toInt(dynargs[3])) ), ((global::alphatab.model.DynamicValue) (dynargs[4]) ));
						break;
					}
					
					
					case 108336130:
					{
						this.generateHarmonic(((global::alphatab.model.Note) (dynargs[0]) ), ((int) (global::haxe.lang.Runtime.toInt(dynargs[1])) ), ((int) (global::haxe.lang.Runtime.toInt(dynargs[2])) ), ((int) (global::haxe.lang.Runtime.toInt(dynargs[3])) ), ((global::alphatab.model.DynamicValue) (dynargs[4]) ));
						break;
					}
					
					
					case 1801778582:
					{
						this.generateFadeIn(((global::alphatab.model.Note) (dynargs[0]) ), ((int) (global::haxe.lang.Runtime.toInt(dynargs[1])) ), ((int) (global::haxe.lang.Runtime.toInt(dynargs[2])) ), ((int) (global::haxe.lang.Runtime.toInt(dynargs[3])) ), ((global::alphatab.model.DynamicValue) (dynargs[4]) ));
						break;
					}
					
					
					case 189602088:
					{
						return this.getDynamicValue(((global::alphatab.model.Note) (dynargs[0]) ));
					}
					
					
					case 461079600:
					{
						return this.applyStaticDuration(((int) (global::haxe.lang.Runtime.toInt(dynargs[0])) ), ((int) (global::haxe.lang.Runtime.toInt(dynargs[1])) ));
					}
					
					
					case 1087118848:
					{
						return this.applyDurationEffects(((global::alphatab.model.Note) (dynargs[0]) ), ((int) (global::haxe.lang.Runtime.toInt(dynargs[1])) ));
					}
					
					
					case 215513884:
					{
						return this.getNoteDuration(((global::alphatab.model.Note) (dynargs[0]) ), ((int) (global::haxe.lang.Runtime.toInt(dynargs[1])) ));
					}
					
					
					case 467526087:
					{
						this.generateNote(((global::alphatab.model.Note) (dynargs[0]) ), ((int) (global::haxe.lang.Runtime.toInt(dynargs[1])) ), ((int) (global::haxe.lang.Runtime.toInt(dynargs[2])) ), ((int) (global::haxe.lang.Runtime.toInt(dynargs[3])) ), ((global::haxe.root.Array<int>) (global::haxe.root.Array<object>.__hx_cast<int>(((global::haxe.root.Array) (dynargs[4]) ))) ));
						break;
					}
					
					
					case 333949771:
					{
						this.generateBeat(((global::alphatab.model.Beat) (dynargs[0]) ), ((int) (global::haxe.lang.Runtime.toInt(dynargs[1])) ));
						break;
					}
					
					
					case 1634989629:
					{
						this.generateVoice(((global::alphatab.model.Voice) (dynargs[0]) ), ((int) (global::haxe.lang.Runtime.toInt(dynargs[1])) ));
						break;
					}
					
					
					case 1176353182:
					{
						this.generateBar(((global::alphatab.model.Bar) (dynargs[0]) ), ((int) (global::haxe.lang.Runtime.toInt(dynargs[1])) ));
						break;
					}
					
					
					case 1968041052:
					{
						this.generateMasterBar(((global::alphatab.model.MasterBar) (dynargs[0]) ), ((global::alphatab.model.MasterBar) (dynargs[1]) ), ((int) (global::haxe.lang.Runtime.toInt(dynargs[2])) ));
						break;
					}
					
					
					case 680282638:
					{
						this.generateChannel(((global::alphatab.model.Track) (dynargs[0]) ), ((int) (global::haxe.lang.Runtime.toInt(dynargs[1])) ), ((global::alphatab.model.PlaybackInformation) (dynargs[2]) ));
						break;
					}
					
					
					case 1016880918:
					{
						this.generateTrack(((global::alphatab.model.Track) (dynargs[0]) ));
						break;
					}
					
					
					case 1503813429:
					{
						this.generate();
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
				baseArr.push("generateMetronome");
				baseArr.push("_metronomeTrack");
				baseArr.push("_currentTempo");
				baseArr.push("_handler");
				baseArr.push("_score");
				{
					base.__hx_getFields(baseArr);
				}
				
			}
		}
		
		
	}
}


