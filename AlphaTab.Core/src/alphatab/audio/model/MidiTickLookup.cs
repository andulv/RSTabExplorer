using haxe.root;
#pragma warning disable 109, 114, 219, 429, 168, 162
namespace alphatab.audio.model{
	public  class BarTickLookup : global::haxe.lang.HxObject {
		public    BarTickLookup(global::haxe.lang.EmptyObject empty){
			unchecked {
				{
				}
				
			}
		}
		
		
		public    BarTickLookup(){
			unchecked {
				global::alphatab.audio.model.BarTickLookup.__hx_ctor_alphatab_audio_model_BarTickLookup(this);
			}
		}
		
		
		public static   void __hx_ctor_alphatab_audio_model_BarTickLookup(global::alphatab.audio.model.BarTickLookup __temp_me65){
			unchecked {
				{
				}
				
			}
		}
		
		
		public static  new object __hx_createEmpty(){
			unchecked {
				return new global::alphatab.audio.model.BarTickLookup(((global::haxe.lang.EmptyObject) (global::haxe.lang.EmptyObject.EMPTY) ));
			}
		}
		
		
		public static  new object __hx_create(global::haxe.root.Array arr){
			unchecked {
				return new global::alphatab.audio.model.BarTickLookup();
			}
		}
		
		
		public  int start;
		
		public  int end;
		
		public  global::alphatab.model.MasterBar bar;
		
		public override   double __hx_setField_f(string field, int hash, double @value, bool handleProperties){
			unchecked {
				switch (hash){
					case 5047259:
					{
						this.end = ((int) (@value) );
						return @value;
					}
					
					
					case 67859554:
					{
						this.start = ((int) (@value) );
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
					case 4895187:
					{
						this.bar = ((global::alphatab.model.MasterBar) (@value) );
						return @value;
					}
					
					
					case 5047259:
					{
						this.end = ((int) (global::haxe.lang.Runtime.toInt(@value)) );
						return @value;
					}
					
					
					case 67859554:
					{
						this.start = ((int) (global::haxe.lang.Runtime.toInt(@value)) );
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
					case 4895187:
					{
						return this.bar;
					}
					
					
					case 5047259:
					{
						return this.end;
					}
					
					
					case 67859554:
					{
						return this.start;
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
					case 5047259:
					{
						return ((double) (this.end) );
					}
					
					
					case 67859554:
					{
						return ((double) (this.start) );
					}
					
					
					default:
					{
						return base.__hx_getField_f(field, hash, throwErrors, handleProperties);
					}
					
				}
				
			}
		}
		
		
		public override   void __hx_getFields(global::haxe.root.Array<object> baseArr){
			unchecked {
				baseArr.push("bar");
				baseArr.push("end");
				baseArr.push("start");
				{
					base.__hx_getFields(baseArr);
				}
				
			}
		}
		
		
	}
}



#pragma warning disable 109, 114, 219, 429, 168, 162
namespace alphatab.audio.model{
	public  class MidiTickLookup : global::haxe.lang.HxObject {
		public    MidiTickLookup(global::haxe.lang.EmptyObject empty){
			unchecked {
				{
				}
				
			}
		}
		
		
		public    MidiTickLookup(){
			unchecked {
				global::alphatab.audio.model.MidiTickLookup.__hx_ctor_alphatab_audio_model_MidiTickLookup(this);
			}
		}
		
		
		public static   void __hx_ctor_alphatab_audio_model_MidiTickLookup(global::alphatab.audio.model.MidiTickLookup __temp_me66){
			unchecked {
				__temp_me66.bars = new global::haxe.root.Array<object>();
			}
		}
		
		
		public static  new object __hx_createEmpty(){
			unchecked {
				return new global::alphatab.audio.model.MidiTickLookup(((global::haxe.lang.EmptyObject) (global::haxe.lang.EmptyObject.EMPTY) ));
			}
		}
		
		
		public static  new object __hx_create(global::haxe.root.Array arr){
			unchecked {
				return new global::alphatab.audio.model.MidiTickLookup();
			}
		}
		
		
		public  global::haxe.root.Array<object> bars;
		
		public  global::alphatab.model.Beat _lastBeat;
		
		public virtual   global::alphatab.model.Beat findBeat(global::alphatab.model.Track track, int tick){
			unchecked {
				if (( ( ( this._lastBeat != default(global::alphatab.model.Beat) ) && ( this._lastBeat.nextBeat != default(global::alphatab.model.Beat) ) ) && ( this._lastBeat.voice.bar.track == track ) )) {
					if (( ( tick >= this._lastBeat.start ) && ( tick < this._lastBeat.nextBeat.start ) )) {
						return this._lastBeat;
					}
					
					if (( ( ( this._lastBeat.nextBeat.nextBeat != default(global::alphatab.model.Beat) ) && ( tick >= this._lastBeat.nextBeat.start ) ) && ( tick < this._lastBeat.nextBeat.nextBeat.start ) )) {
						this._lastBeat = this._lastBeat.nextBeat;
						return this._lastBeat;
					}
					
				}
				
				global::alphatab.audio.model.BarTickLookup lookup = this.findBar(tick);
				if (( lookup == default(global::alphatab.audio.model.BarTickLookup) )) {
					return default(global::alphatab.model.Beat);
				}
				
				global::alphatab.model.MasterBar masterBar = lookup.bar;
				global::alphatab.model.Bar bar = ((global::alphatab.model.Bar) (track.bars[masterBar.index]) );
				tick = ( ( tick - lookup.start ) + masterBar.start );
				global::alphatab.model.Beat beat = default(global::alphatab.model.Beat);
				{
					int _g = 0;
					global::haxe.root.Array<object> _g1 = ((global::alphatab.model.Voice) (bar.voices[0]) ).beats;
					while (( _g < _g1.length )){
						global::alphatab.model.Beat b = ((global::alphatab.model.Beat) (_g1[_g]) );
						 ++ _g;
						if (( ( beat == default(global::alphatab.model.Beat) ) || ( b.start <= tick ) )) {
							beat = b;
						}
						 else {
							break;
						}
						
					}
					
				}
				
				this._lastBeat = beat;
				return this._lastBeat;
			}
		}
		
		
		public virtual   global::alphatab.audio.model.BarTickLookup findBar(int tick){
			unchecked {
				int bottom = 0;
				int top = ( this.bars.length - 1 );
				while (( bottom <= top )){
					int middle = ( (( top + bottom )) / 2 );
					global::alphatab.audio.model.BarTickLookup bar = ((global::alphatab.audio.model.BarTickLookup) (this.bars[middle]) );
					if (( ( tick >= bar.start ) && ( tick <= bar.end ) )) {
						return bar;
					}
					 else {
						if (( tick < bar.start )) {
							top = ( middle - 1 );
						}
						 else {
							bottom = ( middle + 1 );
						}
						
					}
					
				}
				
				return default(global::alphatab.audio.model.BarTickLookup);
			}
		}
		
		
		public override   object __hx_setField(string field, int hash, object @value, bool handleProperties){
			unchecked {
				switch (hash){
					case 468906571:
					{
						this._lastBeat = ((global::alphatab.model.Beat) (@value) );
						return @value;
					}
					
					
					case 1091626816:
					{
						this.bars = ((global::haxe.root.Array<object>) (global::haxe.root.Array<object>.__hx_cast<object>(((global::haxe.root.Array) (@value) ))) );
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
					case 627426074:
					{
						return ((global::haxe.lang.Function) (new global::haxe.lang.Closure(((object) (this) ), ((string) ("findBar") ), ((int) (627426074) ))) );
					}
					
					
					case 329772623:
					{
						return ((global::haxe.lang.Function) (new global::haxe.lang.Closure(((object) (this) ), ((string) ("findBeat") ), ((int) (329772623) ))) );
					}
					
					
					case 468906571:
					{
						return this._lastBeat;
					}
					
					
					case 1091626816:
					{
						return this.bars;
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
					case 627426074:
					{
						return this.findBar(((int) (global::haxe.lang.Runtime.toInt(dynargs[0])) ));
					}
					
					
					case 329772623:
					{
						return this.findBeat(((global::alphatab.model.Track) (dynargs[0]) ), ((int) (global::haxe.lang.Runtime.toInt(dynargs[1])) ));
					}
					
					
					default:
					{
						return base.__hx_invokeField(field, hash, dynargs);
					}
					
				}
				
			}
		}
		
		
		public override   void __hx_getFields(global::haxe.root.Array<object> baseArr){
			unchecked {
				baseArr.push("_lastBeat");
				baseArr.push("bars");
				{
					base.__hx_getFields(baseArr);
				}
				
			}
		}
		
		
	}
}


