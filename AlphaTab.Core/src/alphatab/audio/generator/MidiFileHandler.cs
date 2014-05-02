using haxe.root;
#pragma warning disable 109, 114, 219, 429, 168, 162
namespace alphatab.audio.generator{
	public  class MidiFileHandler : global::haxe.lang.HxObject, global::alphatab.audio.generator.IMidiFileHandler {
		static MidiFileHandler() {
			global::alphatab.audio.generator.MidiFileHandler.DefaultMetronomeKey = 37;
			global::alphatab.audio.generator.MidiFileHandler.DefaultDurationDead = 30;
			global::alphatab.audio.generator.MidiFileHandler.DefaultDurationPalmMute = 80;
			global::alphatab.audio.generator.MidiFileHandler.RestMessage = 0;
		}
		public    MidiFileHandler(global::haxe.lang.EmptyObject empty){
			unchecked {
				{
				}
				
			}
		}
		
		
		public    MidiFileHandler(global::alphatab.audio.model.MidiFile midiFile){
			unchecked {
				global::alphatab.audio.generator.MidiFileHandler.__hx_ctor_alphatab_audio_generator_MidiFileHandler(this, midiFile);
			}
		}
		
		
		public static   void __hx_ctor_alphatab_audio_generator_MidiFileHandler(global::alphatab.audio.generator.MidiFileHandler __temp_me59, global::alphatab.audio.model.MidiFile midiFile){
			unchecked {
				__temp_me59._midiFile = midiFile;
				__temp_me59._metronomeTrack = -1;
			}
		}
		
		
		public static  int DefaultMetronomeKey;
		
		public static  int DefaultDurationDead;
		
		public static  int DefaultDurationPalmMute;
		
		public static  int RestMessage;
		
		public static   int makeCommand(int command, int channel){
			unchecked {
				return ( ( command & 240 ) | ( channel & 15 ) );
			}
		}
		
		
		public static   int fixValue(int @value){
			unchecked {
				if (( @value < 0 )) {
					return 0;
				}
				
				if (( @value > 127 )) {
					return 127;
				}
				
				return @value;
			}
		}
		
		
		public static   int fixChannel(int @value){
			unchecked {
				if (( @value < 0 )) {
					return 0;
				}
				
				if (( @value > 15 )) {
					return 15;
				}
				
				return @value;
			}
		}
		
		
		public static   global::alphatab.audio.model.MidiMessage buildMetaMessage(int metaType, global::haxe.root.Array<int> data){
			unchecked {
				global::haxe.root.Array<int> meta = new global::haxe.root.Array<int>();
				meta.push(255);
				meta.push(( metaType & 255 ));
				global::alphatab.audio.generator.MidiFileHandler.writeVarInt(meta, data.length);
				meta = meta.concat(data);
				return global::alphatab.audio.model.MidiMessage.fromArray(meta);
			}
		}
		
		
		public static   int writeVarInt(global::haxe.root.Array<int> data, int v){
			unchecked {
				int n = 0;
				global::haxe.root.Array<int> array = new global::haxe.root.Array<int>(new int[]{0, 0, 0, 0});
				do {
					array[n++] = ( ( v & 127 ) & 255 );
					v >>= 7;
				}
				while (( v > 0 ));
				while (( n > 0 )){
					n--;
					if (( n > 0 )) {
						data.push(( (( array[n] | 128 )) & 255 ));
					}
					 else {
						data.push(array[n]);
					}
					
				}
				
				return n;
			}
		}
		
		
		public static   global::alphatab.audio.model.MidiMessage buildSysExMessage(global::haxe.root.Array<int> data){
			unchecked {
				global::haxe.root.Array<int> sysex = new global::haxe.root.Array<int>();
				sysex.push(240);
				global::alphatab.audio.generator.MidiFileHandler.writeVarInt(sysex, ( data.length + 2 ));
				sysex.push(0);
				sysex = sysex.concat(data);
				sysex.push(247);
				return global::alphatab.audio.model.MidiMessage.fromArray(sysex);
			}
		}
		
		
		public static  new object __hx_createEmpty(){
			unchecked {
				return new global::alphatab.audio.generator.MidiFileHandler(((global::haxe.lang.EmptyObject) (global::haxe.lang.EmptyObject.EMPTY) ));
			}
		}
		
		
		public static  new object __hx_create(global::haxe.root.Array arr){
			unchecked {
				return new global::alphatab.audio.generator.MidiFileHandler(((global::alphatab.audio.model.MidiFile) (arr[0]) ));
			}
		}
		
		
		public  global::alphatab.audio.model.MidiFile _midiFile;
		
		public  int _metronomeTrack;
		
		public virtual   void addEvent(int track, int tick, global::alphatab.audio.model.MidiMessage message){
			unchecked {
				((global::alphatab.audio.model.MidiTrack) (this._midiFile.tracks[track]) ).addEvent(new global::alphatab.audio.model.MidiEvent(((int) (tick) ), ((global::alphatab.audio.model.MidiMessage) (message) )));
			}
		}
		
		
		public virtual   void addTimeSignature(int tick, int timeSignatureNumerator, int timeSignatureDenominator){
			unchecked {
				int denominatorIndex = 0;
				while (( (timeSignatureDenominator = ( timeSignatureDenominator >> 1 )) > 0 )){
					denominatorIndex++;
				}
				
				this.addEvent(this._midiFile.infoTrack, tick, global::alphatab.audio.generator.MidiFileHandler.buildMetaMessage(88, new global::haxe.root.Array<int>(new int[]{( timeSignatureNumerator & 255 ), ( denominatorIndex & 255 ), 48, 8})));
			}
		}
		
		
		public virtual   void addRest(int track, int tick, int channel){
			unchecked {
				this.addEvent(track, tick, global::alphatab.audio.generator.MidiFileHandler.buildSysExMessage(new global::haxe.root.Array<int>(new int[]{0})));
			}
		}
		
		
		public virtual   void addNote(int track, int start, int length, int key, global::alphatab.model.DynamicValue dynamicValue, int channel){
			unchecked {
				int velocity = global::alphatab.audio.MidiUtils.dynamicToVelocity(dynamicValue);
				this.addEvent(track, start, global::alphatab.audio.model.MidiMessage.fromArray(new global::haxe.root.Array<int>(new int[]{( 144 | ( channel & 15 ) ), global::alphatab.audio.generator.MidiFileHandler.fixValue(key), global::alphatab.audio.generator.MidiFileHandler.fixValue(velocity)})));
				this.addEvent(track, ( start + length ), global::alphatab.audio.model.MidiMessage.fromArray(new global::haxe.root.Array<int>(new int[]{( 128 | ( channel & 15 ) ), global::alphatab.audio.generator.MidiFileHandler.fixValue(key), global::alphatab.audio.generator.MidiFileHandler.fixValue(velocity)})));
			}
		}
		
		
		public virtual   void addControlChange(int track, int tick, int channel, int controller, int @value){
			unchecked {
				this.addEvent(track, tick, global::alphatab.audio.model.MidiMessage.fromArray(new global::haxe.root.Array<int>(new int[]{( 176 | ( channel & 15 ) ), global::alphatab.audio.generator.MidiFileHandler.fixValue(controller), global::alphatab.audio.generator.MidiFileHandler.fixValue(@value)})));
			}
		}
		
		
		public virtual   void addProgramChange(int track, int tick, int channel, int program){
			unchecked {
				this.addEvent(track, tick, global::alphatab.audio.model.MidiMessage.fromArray(new global::haxe.root.Array<int>(new int[]{( 192 | ( channel & 15 ) ), global::alphatab.audio.generator.MidiFileHandler.fixValue(program)})));
			}
		}
		
		
		public virtual   void addTempo(int tick, int tempo){
			unchecked {
				int tempoInUsq = ( 60000000 / tempo );
				this.addEvent(this._midiFile.infoTrack, tick, global::alphatab.audio.generator.MidiFileHandler.buildMetaMessage(81, new global::haxe.root.Array<int>(new int[]{( ( tempoInUsq >> 16 ) & 255 ), ( ( tempoInUsq >> 8 ) & 255 ), ( tempoInUsq & 255 )})));
			}
		}
		
		
		public virtual   void addBend(int track, int tick, int channel, int @value){
			unchecked {
				this.addEvent(track, tick, global::alphatab.audio.model.MidiMessage.fromArray(new global::haxe.root.Array<int>(new int[]{( 224 | ( channel & 15 ) ), 0, global::alphatab.audio.generator.MidiFileHandler.fixValue(@value)})));
			}
		}
		
		
		public virtual   void addMetronome(int tick, int length){
			unchecked {
				if (( this._metronomeTrack == -1 )) {
					this._midiFile.createTrack();
					this._metronomeTrack = ( this._midiFile.tracks.length - 1 );
				}
				
				this.addNote(this._metronomeTrack, tick, length, 37, global::alphatab.model.DynamicValue.F, 9);
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
					case 1892175512:
					{
						this._metronomeTrack = ((int) (global::haxe.lang.Runtime.toInt(@value)) );
						return @value;
					}
					
					
					case 1337343068:
					{
						this._midiFile = ((global::alphatab.audio.model.MidiFile) (@value) );
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
					case 2146583761:
					{
						return ((global::haxe.lang.Function) (new global::haxe.lang.Closure(((object) (this) ), ((string) ("addMetronome") ), ((int) (2146583761) ))) );
					}
					
					
					case 2102472570:
					{
						return ((global::haxe.lang.Function) (new global::haxe.lang.Closure(((object) (this) ), ((string) ("addBend") ), ((int) (2102472570) ))) );
					}
					
					
					case 116266234:
					{
						return ((global::haxe.lang.Function) (new global::haxe.lang.Closure(((object) (this) ), ((string) ("addTempo") ), ((int) (116266234) ))) );
					}
					
					
					case 1163126835:
					{
						return ((global::haxe.lang.Function) (new global::haxe.lang.Closure(((object) (this) ), ((string) ("addProgramChange") ), ((int) (1163126835) ))) );
					}
					
					
					case 795193804:
					{
						return ((global::haxe.lang.Function) (new global::haxe.lang.Closure(((object) (this) ), ((string) ("addControlChange") ), ((int) (795193804) ))) );
					}
					
					
					case 88562355:
					{
						return ((global::haxe.lang.Function) (new global::haxe.lang.Closure(((object) (this) ), ((string) ("addNote") ), ((int) (88562355) ))) );
					}
					
					
					case 132423125:
					{
						return ((global::haxe.lang.Function) (new global::haxe.lang.Closure(((object) (this) ), ((string) ("addRest") ), ((int) (132423125) ))) );
					}
					
					
					case 88025674:
					{
						return ((global::haxe.lang.Function) (new global::haxe.lang.Closure(((object) (this) ), ((string) ("addTimeSignature") ), ((int) (88025674) ))) );
					}
					
					
					case 1864494649:
					{
						return ((global::haxe.lang.Function) (new global::haxe.lang.Closure(((object) (this) ), ((string) ("addEvent") ), ((int) (1864494649) ))) );
					}
					
					
					case 1892175512:
					{
						return this._metronomeTrack;
					}
					
					
					case 1337343068:
					{
						return this._midiFile;
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
					case 2146583761:
					{
						this.addMetronome(((int) (global::haxe.lang.Runtime.toInt(dynargs[0])) ), ((int) (global::haxe.lang.Runtime.toInt(dynargs[1])) ));
						break;
					}
					
					
					case 2102472570:
					{
						this.addBend(((int) (global::haxe.lang.Runtime.toInt(dynargs[0])) ), ((int) (global::haxe.lang.Runtime.toInt(dynargs[1])) ), ((int) (global::haxe.lang.Runtime.toInt(dynargs[2])) ), ((int) (global::haxe.lang.Runtime.toInt(dynargs[3])) ));
						break;
					}
					
					
					case 116266234:
					{
						this.addTempo(((int) (global::haxe.lang.Runtime.toInt(dynargs[0])) ), ((int) (global::haxe.lang.Runtime.toInt(dynargs[1])) ));
						break;
					}
					
					
					case 1163126835:
					{
						this.addProgramChange(((int) (global::haxe.lang.Runtime.toInt(dynargs[0])) ), ((int) (global::haxe.lang.Runtime.toInt(dynargs[1])) ), ((int) (global::haxe.lang.Runtime.toInt(dynargs[2])) ), ((int) (global::haxe.lang.Runtime.toInt(dynargs[3])) ));
						break;
					}
					
					
					case 795193804:
					{
						this.addControlChange(((int) (global::haxe.lang.Runtime.toInt(dynargs[0])) ), ((int) (global::haxe.lang.Runtime.toInt(dynargs[1])) ), ((int) (global::haxe.lang.Runtime.toInt(dynargs[2])) ), ((int) (global::haxe.lang.Runtime.toInt(dynargs[3])) ), ((int) (global::haxe.lang.Runtime.toInt(dynargs[4])) ));
						break;
					}
					
					
					case 88562355:
					{
						this.addNote(((int) (global::haxe.lang.Runtime.toInt(dynargs[0])) ), ((int) (global::haxe.lang.Runtime.toInt(dynargs[1])) ), ((int) (global::haxe.lang.Runtime.toInt(dynargs[2])) ), ((int) (global::haxe.lang.Runtime.toInt(dynargs[3])) ), ((global::alphatab.model.DynamicValue) (dynargs[4]) ), ((int) (global::haxe.lang.Runtime.toInt(dynargs[5])) ));
						break;
					}
					
					
					case 132423125:
					{
						this.addRest(((int) (global::haxe.lang.Runtime.toInt(dynargs[0])) ), ((int) (global::haxe.lang.Runtime.toInt(dynargs[1])) ), ((int) (global::haxe.lang.Runtime.toInt(dynargs[2])) ));
						break;
					}
					
					
					case 88025674:
					{
						this.addTimeSignature(((int) (global::haxe.lang.Runtime.toInt(dynargs[0])) ), ((int) (global::haxe.lang.Runtime.toInt(dynargs[1])) ), ((int) (global::haxe.lang.Runtime.toInt(dynargs[2])) ));
						break;
					}
					
					
					case 1864494649:
					{
						this.addEvent(((int) (global::haxe.lang.Runtime.toInt(dynargs[0])) ), ((int) (global::haxe.lang.Runtime.toInt(dynargs[1])) ), ((global::alphatab.audio.model.MidiMessage) (dynargs[2]) ));
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
				baseArr.push("_metronomeTrack");
				baseArr.push("_midiFile");
				{
					base.__hx_getFields(baseArr);
				}
				
			}
		}
		
		
	}
}


