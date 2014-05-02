using haxe.root;
#pragma warning disable 109, 114, 219, 429, 168, 162
namespace alphatab.audio.model{
	public  class MidiTrack : global::haxe.lang.HxObject {
		public    MidiTrack(global::haxe.lang.EmptyObject empty){
			unchecked {
				{
				}
				
			}
		}
		
		
		public    MidiTrack(){
			unchecked {
				global::alphatab.audio.model.MidiTrack.__hx_ctor_alphatab_audio_model_MidiTrack(this);
			}
		}
		
		
		public static   void __hx_ctor_alphatab_audio_model_MidiTrack(global::alphatab.audio.model.MidiTrack __temp_me67){
			unchecked {
				{
				}
				
			}
		}
		
		
		public static  new object __hx_createEmpty(){
			unchecked {
				return new global::alphatab.audio.model.MidiTrack(((global::haxe.lang.EmptyObject) (global::haxe.lang.EmptyObject.EMPTY) ));
			}
		}
		
		
		public static  new object __hx_create(global::haxe.root.Array arr){
			unchecked {
				return new global::alphatab.audio.model.MidiTrack();
			}
		}
		
		
		public  int index;
		
		public  global::alphatab.audio.model.MidiFile file;
		
		public  global::alphatab.audio.model.MidiEvent firstEvent;
		
		public  global::alphatab.audio.model.MidiEvent lastEvent;
		
		public virtual   void addEvent(global::alphatab.audio.model.MidiEvent @event){
			unchecked {
				@event.track = this;
				if (( this.firstEvent == default(global::alphatab.audio.model.MidiEvent) )) {
					this.firstEvent = @event;
					this.lastEvent = @event;
				}
				 else {
					if (( this.lastEvent.tick <= @event.tick )) {
						this.lastEvent.nextEvent = @event;
						@event.previousEvent = this.lastEvent;
						this.lastEvent = @event;
					}
					 else {
						if (( this.firstEvent.tick > @event.tick )) {
							@event.nextEvent = this.firstEvent;
							this.firstEvent.previousEvent = @event;
							this.firstEvent = @event;
						}
						 else {
							int firstDelta = ( @event.tick - this.firstEvent.tick );
							int lastDelta = ( this.lastEvent.tick - @event.tick );
							if (( firstDelta < lastDelta )) {
								global::alphatab.audio.model.MidiEvent previous = this.firstEvent;
								while (( ( ( previous != default(global::alphatab.audio.model.MidiEvent) ) && ( previous.nextEvent != default(global::alphatab.audio.model.MidiEvent) ) ) && ( previous.nextEvent.tick < @event.tick ) )){
									previous = previous.nextEvent;
								}
								
								if (( previous == default(global::alphatab.audio.model.MidiEvent) )) {
									return ;
								}
								
								global::alphatab.audio.model.MidiEvent next = previous.nextEvent;
								previous.nextEvent = @event;
								@event.previousEvent = previous;
								@event.nextEvent = next;
								if (( next != default(global::alphatab.audio.model.MidiEvent) )) {
									next.previousEvent = @event;
								}
								
							}
							 else {
								global::alphatab.audio.model.MidiEvent next1 = this.lastEvent;
								while (( ( ( next1 != default(global::alphatab.audio.model.MidiEvent) ) && ( next1.previousEvent != default(global::alphatab.audio.model.MidiEvent) ) ) && ( next1.previousEvent.tick > @event.tick ) )){
									next1 = next1.previousEvent;
								}
								
								if (( next1 == default(global::alphatab.audio.model.MidiEvent) )) {
									return ;
								}
								
								global::alphatab.audio.model.MidiEvent previous1 = next1.previousEvent;
								next1.previousEvent = @event;
								@event.nextEvent = next1;
								@event.previousEvent = previous1;
								if (( previous1 != default(global::alphatab.audio.model.MidiEvent) )) {
									previous1.nextEvent = @event;
								}
								 else {
									this.firstEvent = @event;
								}
								
							}
							
						}
						
					}
					
				}
				
			}
		}
		
		
		public virtual   void writeTo(global::haxe.io.Output @out){
			unchecked {
				@out.set_bigEndian(true);
				global::haxe.io.BytesOutput trackData = new global::haxe.io.BytesOutput();
				global::alphatab.audio.model.MidiEvent current = this.firstEvent;
				while (( current != default(global::alphatab.audio.model.MidiEvent) )){
					current.writeTo(trackData);
					current = current.nextEvent;
				}
				
				@out.writeInt32(1297379947);
				global::haxe.io.Bytes bytes = trackData.getBytes();
				@out.writeInt32(bytes.length);
				@out.write(bytes);
			}
		}
		
		
		public override   double __hx_setField_f(string field, int hash, double @value, bool handleProperties){
			unchecked {
				switch (hash){
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
					case 1114764772:
					{
						this.lastEvent = ((global::alphatab.audio.model.MidiEvent) (@value) );
						return @value;
					}
					
					
					case 866324938:
					{
						this.firstEvent = ((global::alphatab.audio.model.MidiEvent) (@value) );
						return @value;
					}
					
					
					case 1136381564:
					{
						this.file = ((global::alphatab.audio.model.MidiFile) (@value) );
						return @value;
					}
					
					
					case 1041537810:
					{
						this.index = ((int) (global::haxe.lang.Runtime.toInt(@value)) );
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
					case 724954170:
					{
						return ((global::haxe.lang.Function) (new global::haxe.lang.Closure(((object) (this) ), ((string) ("writeTo") ), ((int) (724954170) ))) );
					}
					
					
					case 1864494649:
					{
						return ((global::haxe.lang.Function) (new global::haxe.lang.Closure(((object) (this) ), ((string) ("addEvent") ), ((int) (1864494649) ))) );
					}
					
					
					case 1114764772:
					{
						return this.lastEvent;
					}
					
					
					case 866324938:
					{
						return this.firstEvent;
					}
					
					
					case 1136381564:
					{
						return this.file;
					}
					
					
					case 1041537810:
					{
						return this.index;
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
					case 724954170:
					{
						this.writeTo(((global::haxe.io.Output) (dynargs[0]) ));
						break;
					}
					
					
					case 1864494649:
					{
						this.addEvent(((global::alphatab.audio.model.MidiEvent) (dynargs[0]) ));
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
				baseArr.push("lastEvent");
				baseArr.push("firstEvent");
				baseArr.push("file");
				baseArr.push("index");
				{
					base.__hx_getFields(baseArr);
				}
				
			}
		}
		
		
	}
}


