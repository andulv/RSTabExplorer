using haxe.root;
#pragma warning disable 109, 114, 219, 429, 168, 162
namespace alphatab.audio.model{
	public  class MidiEvent : global::haxe.lang.HxObject {
		public    MidiEvent(global::haxe.lang.EmptyObject empty){
			unchecked {
				{
				}
				
			}
		}
		
		
		public    MidiEvent(int tick, global::alphatab.audio.model.MidiMessage message){
			unchecked {
				global::alphatab.audio.model.MidiEvent.__hx_ctor_alphatab_audio_model_MidiEvent(this, tick, message);
			}
		}
		
		
		public static   void __hx_ctor_alphatab_audio_model_MidiEvent(global::alphatab.audio.model.MidiEvent __temp_me62, int tick, global::alphatab.audio.model.MidiMessage message){
			unchecked {
				__temp_me62.tick = tick;
				__temp_me62.message = message;
			}
		}
		
		
		public static  new object __hx_createEmpty(){
			unchecked {
				return new global::alphatab.audio.model.MidiEvent(((global::haxe.lang.EmptyObject) (global::haxe.lang.EmptyObject.EMPTY) ));
			}
		}
		
		
		public static  new object __hx_create(global::haxe.root.Array arr){
			unchecked {
				return new global::alphatab.audio.model.MidiEvent(((int) (global::haxe.lang.Runtime.toInt(arr[0])) ), ((global::alphatab.audio.model.MidiMessage) (arr[1]) ));
			}
		}
		
		
		public  global::alphatab.audio.model.MidiTrack track;
		
		public  int tick;
		
		public  global::alphatab.audio.model.MidiMessage message;
		
		public  global::alphatab.audio.model.MidiEvent nextEvent;
		
		public  global::alphatab.audio.model.MidiEvent previousEvent;
		
		public virtual   int getDeltaTicks(){
			unchecked {
				if (( this.previousEvent == default(global::alphatab.audio.model.MidiEvent) )) {
					return 0;
				}
				 else {
					return ( this.tick - this.previousEvent.tick );
				}
				
			}
		}
		
		
		public virtual   void writeToFile(string path){
			unchecked {
				this.writeTo(global::sys.io.File.write(path, new global::haxe.lang.Null<bool>(true, true)));
			}
		}
		
		
		public virtual   void writeTo(global::haxe.io.Output @out){
			unchecked {
				this.writeVariableInt(@out, this.getDeltaTicks());
				this.message.writeTo(@out);
			}
		}
		
		
		public virtual   void writeVariableInt(global::haxe.io.Output @out, int @value){
			unchecked {
				int v = @value;
				global::haxe.root.Array<int> array = new global::haxe.root.Array<int>(new int[]{0, 0, 0, 0});
				int n = 0;
				do {
					array[n++] = ( ( v & 127 ) & 255 );
					v >>= 7;
				}
				while (( v > 0 ));
				while (( n > 0 )){
					n--;
					if (( n > 0 )) {
						@out.writeByte(( array[n] | 128 ));
					}
					 else {
						@out.writeByte(array[n]);
					}
					
				}
				
			}
		}
		
		
		public override   double __hx_setField_f(string field, int hash, double @value, bool handleProperties){
			unchecked {
				switch (hash){
					case 1291633501:
					{
						this.tick = ((int) (@value) );
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
					case 481875043:
					{
						this.previousEvent = ((global::alphatab.audio.model.MidiEvent) (@value) );
						return @value;
					}
					
					
					case 487186983:
					{
						this.nextEvent = ((global::alphatab.audio.model.MidiEvent) (@value) );
						return @value;
					}
					
					
					case 437335495:
					{
						this.message = ((global::alphatab.audio.model.MidiMessage) (@value) );
						return @value;
					}
					
					
					case 1291633501:
					{
						this.tick = ((int) (global::haxe.lang.Runtime.toInt(@value)) );
						return @value;
					}
					
					
					case 371166859:
					{
						this.track = ((global::alphatab.audio.model.MidiTrack) (@value) );
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
					case 1128524148:
					{
						return ((global::haxe.lang.Function) (new global::haxe.lang.Closure(((object) (this) ), ((string) ("writeVariableInt") ), ((int) (1128524148) ))) );
					}
					
					
					case 724954170:
					{
						return ((global::haxe.lang.Function) (new global::haxe.lang.Closure(((object) (this) ), ((string) ("writeTo") ), ((int) (724954170) ))) );
					}
					
					
					case 242125782:
					{
						return ((global::haxe.lang.Function) (new global::haxe.lang.Closure(((object) (this) ), ((string) ("writeToFile") ), ((int) (242125782) ))) );
					}
					
					
					case 398667668:
					{
						return ((global::haxe.lang.Function) (new global::haxe.lang.Closure(((object) (this) ), ((string) ("getDeltaTicks") ), ((int) (398667668) ))) );
					}
					
					
					case 481875043:
					{
						return this.previousEvent;
					}
					
					
					case 487186983:
					{
						return this.nextEvent;
					}
					
					
					case 437335495:
					{
						return this.message;
					}
					
					
					case 1291633501:
					{
						return this.tick;
					}
					
					
					case 371166859:
					{
						return this.track;
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
					case 1291633501:
					{
						return ((double) (this.tick) );
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
					case 1128524148:
					{
						this.writeVariableInt(((global::haxe.io.Output) (dynargs[0]) ), ((int) (global::haxe.lang.Runtime.toInt(dynargs[1])) ));
						break;
					}
					
					
					case 724954170:
					{
						this.writeTo(((global::haxe.io.Output) (dynargs[0]) ));
						break;
					}
					
					
					case 242125782:
					{
						this.writeToFile(global::haxe.lang.Runtime.toString(dynargs[0]));
						break;
					}
					
					
					case 398667668:
					{
						return this.getDeltaTicks();
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
				baseArr.push("previousEvent");
				baseArr.push("nextEvent");
				baseArr.push("message");
				baseArr.push("tick");
				baseArr.push("track");
				{
					base.__hx_getFields(baseArr);
				}
				
			}
		}
		
		
	}
}


