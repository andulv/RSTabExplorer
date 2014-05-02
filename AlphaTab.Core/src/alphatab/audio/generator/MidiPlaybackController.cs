using haxe.root;
#pragma warning disable 109, 114, 219, 429, 168, 162
namespace alphatab.audio.generator{
	public  class MidiPlaybackController : global::haxe.lang.HxObject {
		public    MidiPlaybackController(global::haxe.lang.EmptyObject empty){
			unchecked {
				{
				}
				
			}
		}
		
		
		public    MidiPlaybackController(global::alphatab.model.Score score){
			unchecked {
				global::alphatab.audio.generator.MidiPlaybackController.__hx_ctor_alphatab_audio_generator_MidiPlaybackController(this, score);
			}
		}
		
		
		public static   void __hx_ctor_alphatab_audio_generator_MidiPlaybackController(global::alphatab.audio.generator.MidiPlaybackController __temp_me60, global::alphatab.model.Score score){
			unchecked {
				__temp_me60._score = score;
				__temp_me60.shouldPlay = true;
				__temp_me60.repeatMove = 0;
				__temp_me60.index = 0;
			}
		}
		
		
		public static  new object __hx_createEmpty(){
			unchecked {
				return new global::alphatab.audio.generator.MidiPlaybackController(((global::haxe.lang.EmptyObject) (global::haxe.lang.EmptyObject.EMPTY) ));
			}
		}
		
		
		public static  new object __hx_create(global::haxe.root.Array arr){
			unchecked {
				return new global::alphatab.audio.generator.MidiPlaybackController(((global::alphatab.model.Score) (arr[0]) ));
			}
		}
		
		
		public  global::alphatab.model.Score _score;
		
		public  int _lastIndex;
		
		public  int _repeatAlternative;
		
		public  int _repeatStart;
		
		public  int _repeatStartIndex;
		
		public  int _repeatNumber;
		
		public  int _repeatEnd;
		
		public  bool _repeatOpen;
		
		public  bool shouldPlay;
		
		public  int repeatMove;
		
		public  int index;
		
		public   bool finished(){
			unchecked {
				return ( this.index >= this._score.masterBars.length );
			}
		}
		
		
		public virtual   void process(){
			unchecked {
				global::alphatab.model.MasterBar masterBar = ((global::alphatab.model.MasterBar) (this._score.masterBars[this.index]) );
				if ((  ! (masterBar.repeatGroup.isClosed)  && ( ((global::alphatab.model.MasterBar) (masterBar.repeatGroup.openings[( masterBar.repeatGroup.openings.length - 1 )]) ) == masterBar ) )) {
					this._repeatStart = 0;
					this._repeatNumber = 0;
					this._repeatEnd = 0;
					this._repeatOpen = false;
				}
				
				if (masterBar.isRepeatStart) {
					this._repeatStartIndex = this.index;
					this._repeatStart = masterBar.start;
					this._repeatOpen = true;
					if (( this.index > this._lastIndex )) {
						this._repeatNumber = 0;
						this._repeatAlternative = 0;
					}
					
				}
				 else {
					if (( this._repeatAlternative == 0 )) {
						this._repeatAlternative = masterBar.alternateEndings;
					}
					
					if (( ( this._repeatOpen && ( this._repeatAlternative > 0 ) ) && ( (( this._repeatAlternative & ( 1 << this._repeatNumber ) )) == 0 ) )) {
						this.repeatMove -= masterBar.calculateDuration();
						if (( masterBar.repeatCount > 0 )) {
							this._repeatAlternative = 0;
						}
						
						this.shouldPlay = false;
						this.index++;
						return ;
					}
					
				}
				
				{
					double x = global::System.Math.Max(((double) (this._lastIndex) ), ((double) (this.index) ));
					this._lastIndex = ((int) (x) );
				}
				
				if (( this._repeatOpen && ( masterBar.repeatCount > 0 ) )) {
					if (( ( this._repeatNumber < masterBar.repeatCount ) || ( this._repeatAlternative > 0 ) )) {
						this._repeatEnd = ( masterBar.start + masterBar.calculateDuration() );
						this.repeatMove += ( this._repeatEnd - this._repeatStart );
						this.index = ( this._repeatStartIndex - 1 );
						this._repeatNumber++;
					}
					 else {
						this._repeatStart = 0;
						this._repeatNumber = 0;
						this._repeatEnd = 0;
						this._repeatOpen = false;
					}
					
					this._repeatAlternative = 0;
				}
				
				this.index++;
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
					
					
					case 247787532:
					{
						this.repeatMove = ((int) (@value) );
						return @value;
					}
					
					
					case 372861697:
					{
						this._repeatEnd = ((int) (@value) );
						return @value;
					}
					
					
					case 891722595:
					{
						this._repeatNumber = ((int) (@value) );
						return @value;
					}
					
					
					case 1663491306:
					{
						this._repeatStartIndex = ((int) (@value) );
						return @value;
					}
					
					
					case 993816840:
					{
						this._repeatStart = ((int) (@value) );
						return @value;
					}
					
					
					case 329808147:
					{
						this._repeatAlternative = ((int) (@value) );
						return @value;
					}
					
					
					case 1717847197:
					{
						this._lastIndex = ((int) (@value) );
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
					case 1041537810:
					{
						this.index = ((int) (global::haxe.lang.Runtime.toInt(@value)) );
						return @value;
					}
					
					
					case 247787532:
					{
						this.repeatMove = ((int) (global::haxe.lang.Runtime.toInt(@value)) );
						return @value;
					}
					
					
					case 1501927367:
					{
						this.shouldPlay = global::haxe.lang.Runtime.toBool(@value);
						return @value;
					}
					
					
					case 1654775268:
					{
						this._repeatOpen = global::haxe.lang.Runtime.toBool(@value);
						return @value;
					}
					
					
					case 372861697:
					{
						this._repeatEnd = ((int) (global::haxe.lang.Runtime.toInt(@value)) );
						return @value;
					}
					
					
					case 891722595:
					{
						this._repeatNumber = ((int) (global::haxe.lang.Runtime.toInt(@value)) );
						return @value;
					}
					
					
					case 1663491306:
					{
						this._repeatStartIndex = ((int) (global::haxe.lang.Runtime.toInt(@value)) );
						return @value;
					}
					
					
					case 993816840:
					{
						this._repeatStart = ((int) (global::haxe.lang.Runtime.toInt(@value)) );
						return @value;
					}
					
					
					case 329808147:
					{
						this._repeatAlternative = ((int) (global::haxe.lang.Runtime.toInt(@value)) );
						return @value;
					}
					
					
					case 1717847197:
					{
						this._lastIndex = ((int) (global::haxe.lang.Runtime.toInt(@value)) );
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
					case 1900716655:
					{
						return ((global::haxe.lang.Function) (new global::haxe.lang.Closure(((object) (this) ), ((string) ("process") ), ((int) (1900716655) ))) );
					}
					
					
					case 353276786:
					{
						return ((global::haxe.lang.Function) (new global::haxe.lang.Closure(((object) (this) ), ((string) ("finished") ), ((int) (353276786) ))) );
					}
					
					
					case 1041537810:
					{
						return this.index;
					}
					
					
					case 247787532:
					{
						return this.repeatMove;
					}
					
					
					case 1501927367:
					{
						return this.shouldPlay;
					}
					
					
					case 1654775268:
					{
						return this._repeatOpen;
					}
					
					
					case 372861697:
					{
						return this._repeatEnd;
					}
					
					
					case 891722595:
					{
						return this._repeatNumber;
					}
					
					
					case 1663491306:
					{
						return this._repeatStartIndex;
					}
					
					
					case 993816840:
					{
						return this._repeatStart;
					}
					
					
					case 329808147:
					{
						return this._repeatAlternative;
					}
					
					
					case 1717847197:
					{
						return this._lastIndex;
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
					case 1041537810:
					{
						return ((double) (this.index) );
					}
					
					
					case 247787532:
					{
						return ((double) (this.repeatMove) );
					}
					
					
					case 372861697:
					{
						return ((double) (this._repeatEnd) );
					}
					
					
					case 891722595:
					{
						return ((double) (this._repeatNumber) );
					}
					
					
					case 1663491306:
					{
						return ((double) (this._repeatStartIndex) );
					}
					
					
					case 993816840:
					{
						return ((double) (this._repeatStart) );
					}
					
					
					case 329808147:
					{
						return ((double) (this._repeatAlternative) );
					}
					
					
					case 1717847197:
					{
						return ((double) (this._lastIndex) );
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
					case 1900716655:
					{
						this.process();
						break;
					}
					
					
					case 353276786:
					{
						return this.finished();
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
				baseArr.push("index");
				baseArr.push("repeatMove");
				baseArr.push("shouldPlay");
				baseArr.push("_repeatOpen");
				baseArr.push("_repeatEnd");
				baseArr.push("_repeatNumber");
				baseArr.push("_repeatStartIndex");
				baseArr.push("_repeatStart");
				baseArr.push("_repeatAlternative");
				baseArr.push("_lastIndex");
				baseArr.push("_score");
				{
					base.__hx_getFields(baseArr);
				}
				
			}
		}
		
		
	}
}


