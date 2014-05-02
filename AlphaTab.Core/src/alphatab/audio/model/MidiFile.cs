using haxe.root;
#pragma warning disable 109, 114, 219, 429, 168, 162
namespace alphatab.audio.model{
	public  class MidiFile : global::haxe.lang.HxObject {
		public    MidiFile(global::haxe.lang.EmptyObject empty){
			unchecked {
				{
				}
				
			}
		}
		
		
		public    MidiFile(){
			unchecked {
				global::alphatab.audio.model.MidiFile.__hx_ctor_alphatab_audio_model_MidiFile(this);
			}
		}
		
		
		public static   void __hx_ctor_alphatab_audio_model_MidiFile(global::alphatab.audio.model.MidiFile __temp_me63){
			unchecked {
				__temp_me63.tracks = new global::haxe.root.Array<object>();
			}
		}
		
		
		public static  new object __hx_createEmpty(){
			unchecked {
				return new global::alphatab.audio.model.MidiFile(((global::haxe.lang.EmptyObject) (global::haxe.lang.EmptyObject.EMPTY) ));
			}
		}
		
		
		public static  new object __hx_create(global::haxe.root.Array arr){
			unchecked {
				return new global::alphatab.audio.model.MidiFile();
			}
		}
		
		
		public  global::haxe.root.Array<object> tracks;
		
		public  int infoTrack;
		
		public virtual   global::alphatab.audio.model.MidiTrack createTrack(){
			unchecked {
				global::alphatab.audio.model.MidiTrack track = new global::alphatab.audio.model.MidiTrack();
				track.index = this.tracks.length;
				track.file = this;
				this.tracks.push(track);
				return track;
			}
		}
		
		
		public virtual   void writeTo(global::haxe.io.Output @out){
			unchecked {
				@out.set_bigEndian(true);
				@out.writeInt32(1297377380);
				@out.writeInt32(6);
				@out.writeInt16(1);
				@out.writeInt16(this.tracks.length);
				@out.writeInt16(960);
				{
					int _g = 0;
					global::haxe.root.Array<object> _g1 = this.tracks;
					while (( _g < _g1.length )){
						global::alphatab.audio.model.MidiTrack t = ((global::alphatab.audio.model.MidiTrack) (_g1[_g]) );
						 ++ _g;
						t.writeTo(@out);
					}
					
				}
				
			}
		}
		
		
		public override   double __hx_setField_f(string field, int hash, double @value, bool handleProperties){
			unchecked {
				switch (hash){
					case 891844413:
					{
						this.infoTrack = ((int) (@value) );
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
					case 891844413:
					{
						this.infoTrack = ((int) (global::haxe.lang.Runtime.toInt(@value)) );
						return @value;
					}
					
					
					case 1165831048:
					{
						this.tracks = ((global::haxe.root.Array<object>) (global::haxe.root.Array<object>.__hx_cast<object>(((global::haxe.root.Array) (@value) ))) );
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
					
					
					case 1067107823:
					{
						return ((global::haxe.lang.Function) (new global::haxe.lang.Closure(((object) (this) ), ((string) ("createTrack") ), ((int) (1067107823) ))) );
					}
					
					
					case 891844413:
					{
						return this.infoTrack;
					}
					
					
					case 1165831048:
					{
						return this.tracks;
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
					case 891844413:
					{
						return ((double) (this.infoTrack) );
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
					
					
					case 1067107823:
					{
						return this.createTrack();
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
				baseArr.push("infoTrack");
				baseArr.push("tracks");
				{
					base.__hx_getFields(baseArr);
				}
				
			}
		}
		
		
	}
}


