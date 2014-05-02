using haxe.root;
#pragma warning disable 109, 114, 219, 429, 168, 162
namespace alphatab.audio.model{
	public  class MidiMessage : global::haxe.lang.HxObject {
		public    MidiMessage(global::haxe.lang.EmptyObject empty){
			unchecked {
				{
				}
				
			}
		}
		
		
		public    MidiMessage(global::haxe.io.Bytes data){
			unchecked {
				global::alphatab.audio.model.MidiMessage.__hx_ctor_alphatab_audio_model_MidiMessage(this, data);
			}
		}
		
		
		public static   void __hx_ctor_alphatab_audio_model_MidiMessage(global::alphatab.audio.model.MidiMessage __temp_me64, global::haxe.io.Bytes data){
			unchecked {
				__temp_me64.data = data;
			}
		}
		
		
		public static   global::alphatab.audio.model.MidiMessage fromArray(global::haxe.root.Array<int> data){
			unchecked {
				global::haxe.io.Bytes bytes = global::haxe.io.Bytes.alloc(data.length);
				{
					int _g1 = 0;
					int _g = data.length;
					while (( _g1 < _g )){
						int i = _g1++;
						bytes.b[i] = ((byte) (data[i]) );
					}
					
				}
				
				return new global::alphatab.audio.model.MidiMessage(((global::haxe.io.Bytes) (bytes) ));
			}
		}
		
		
		public static  new object __hx_createEmpty(){
			unchecked {
				return new global::alphatab.audio.model.MidiMessage(((global::haxe.lang.EmptyObject) (global::haxe.lang.EmptyObject.EMPTY) ));
			}
		}
		
		
		public static  new object __hx_create(global::haxe.root.Array arr){
			unchecked {
				return new global::alphatab.audio.model.MidiMessage(((global::haxe.io.Bytes) (arr[0]) ));
			}
		}
		
		
		public  global::alphatab.audio.model.MidiEvent @event;
		
		public  global::haxe.io.Bytes data;
		
		public virtual   void writeTo(global::haxe.io.Output @out){
			unchecked {
				@out.write(this.data);
			}
		}
		
		
		public override   object __hx_setField(string field, int hash, object @value, bool handleProperties){
			unchecked {
				switch (hash){
					case 1113806378:
					{
						this.data = ((global::haxe.io.Bytes) (@value) );
						return @value;
					}
					
					
					case 1975830554:
					{
						this.@event = ((global::alphatab.audio.model.MidiEvent) (@value) );
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
					
					
					case 1113806378:
					{
						return this.data;
					}
					
					
					case 1975830554:
					{
						return this.@event;
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
					case 724954170:
					{
						this.writeTo(((global::haxe.io.Output) (dynargs[0]) ));
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
				baseArr.push("data");
				baseArr.push("event");
				{
					base.__hx_getFields(baseArr);
				}
				
			}
		}
		
		
	}
}


