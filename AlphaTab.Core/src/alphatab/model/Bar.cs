using haxe.root;
#pragma warning disable 109, 114, 219, 429, 168, 162
namespace alphatab.model{
	public  class Bar : global::haxe.lang.HxObject {
		public    Bar(global::haxe.lang.EmptyObject empty){
			unchecked {
				{
				}
				
			}
		}
		
		
		public    Bar(){
			unchecked {
				global::alphatab.model.Bar.__hx_ctor_alphatab_model_Bar(this);
			}
		}
		
		
		public static   void __hx_ctor_alphatab_model_Bar(global::alphatab.model.Bar __temp_me87){
			unchecked {
				__temp_me87.voices = new global::haxe.root.Array<object>();
				__temp_me87.clef = global::alphatab.model.Clef.G2;
			}
		}
		
		
		public static  new object __hx_createEmpty(){
			unchecked {
				return new global::alphatab.model.Bar(((global::haxe.lang.EmptyObject) (global::haxe.lang.EmptyObject.EMPTY) ));
			}
		}
		
		
		public static  new object __hx_create(global::haxe.root.Array arr){
			unchecked {
				return new global::alphatab.model.Bar();
			}
		}
		
		
		public  int index;
		
		public  global::alphatab.model.Bar nextBar;
		
		public  global::alphatab.model.Bar previousBar;
		
		public  global::alphatab.model.Clef clef;
		
		public  global::alphatab.model.Track track;
		
		public  global::haxe.root.Array<object> voices;
		
		public  global::haxe.lang.Null<global::alphatab.model.Duration> minDuration;
		
		public  global::haxe.lang.Null<global::alphatab.model.Duration> maxDuration;
		
		public virtual   void addVoice(global::alphatab.model.Voice voice){
			unchecked {
				voice.bar = this;
				voice.index = this.voices.length;
				this.voices.push(voice);
			}
		}
		
		
		public   global::alphatab.model.MasterBar getMasterBar(){
			unchecked {
				return ((global::alphatab.model.MasterBar) (this.track.score.masterBars[this.index]) );
			}
		}
		
		
		public virtual   bool isEmpty(){
			unchecked {
				{
					int _g = 0;
					global::haxe.root.Array<object> _g1 = this.voices;
					while (( _g < _g1.length )){
						global::alphatab.model.Voice v = ((global::alphatab.model.Voice) (_g1[_g]) );
						 ++ _g;
						if ( ! (v.isEmpty()) ) {
							return false;
						}
						
					}
					
				}
				
				return true;
			}
		}
		
		
		public virtual   void finish(){
			unchecked {
				int _g = 0;
				global::haxe.root.Array<object> _g1 = this.voices;
				while (( _g < _g1.length )){
					global::alphatab.model.Voice v = ((global::alphatab.model.Voice) (_g1[_g]) );
					 ++ _g;
					v.finish();
					if (( (  ! (v.minDuration.hasValue)  ||  ! (this.minDuration.hasValue)  ) || ( global::alphatab.model.ModelUtils.getDurationValue(this.minDuration.@value) > global::alphatab.model.ModelUtils.getDurationValue(v.minDuration.@value) ) )) {
						this.minDuration = v.minDuration;
					}
					
					if (( (  ! (v.maxDuration.hasValue)  ||  ! (this.maxDuration.hasValue)  ) || ( global::alphatab.model.ModelUtils.getDurationValue(this.maxDuration.@value) < global::alphatab.model.ModelUtils.getDurationValue(v.maxDuration.@value) ) )) {
						this.maxDuration = v.maxDuration;
					}
					
				}
				
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
					case 173283864:
					{
						this.maxDuration = global::haxe.lang.Null<object>.ofDynamic<global::alphatab.model.Duration>(@value);
						return @value;
					}
					
					
					case 1329184518:
					{
						this.minDuration = global::haxe.lang.Null<object>.ofDynamic<global::alphatab.model.Duration>(@value);
						return @value;
					}
					
					
					case 1565120129:
					{
						this.voices = ((global::haxe.root.Array<object>) (global::haxe.root.Array<object>.__hx_cast<object>(((global::haxe.root.Array) (@value) ))) );
						return @value;
					}
					
					
					case 371166859:
					{
						this.track = ((global::alphatab.model.Track) (@value) );
						return @value;
					}
					
					
					case 1103260490:
					{
						this.clef = ((global::alphatab.model.Clef) (@value) );
						return @value;
					}
					
					
					case 855239132:
					{
						this.previousBar = ((global::alphatab.model.Bar) (@value) );
						return @value;
					}
					
					
					case 624508576:
					{
						this.nextBar = ((global::alphatab.model.Bar) (@value) );
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
					case 109002835:
					{
						return ((global::haxe.lang.Function) (new global::haxe.lang.Closure(((object) (this) ), ((string) ("finish") ), ((int) (109002835) ))) );
					}
					
					
					case 207609411:
					{
						return ((global::haxe.lang.Function) (new global::haxe.lang.Closure(((object) (this) ), ((string) ("isEmpty") ), ((int) (207609411) ))) );
					}
					
					
					case 248321755:
					{
						return ((global::haxe.lang.Function) (new global::haxe.lang.Closure(((object) (this) ), ((string) ("getMasterBar") ), ((int) (248321755) ))) );
					}
					
					
					case 877939665:
					{
						return ((global::haxe.lang.Function) (new global::haxe.lang.Closure(((object) (this) ), ((string) ("addVoice") ), ((int) (877939665) ))) );
					}
					
					
					case 173283864:
					{
						return (this.maxDuration).toDynamic();
					}
					
					
					case 1329184518:
					{
						return (this.minDuration).toDynamic();
					}
					
					
					case 1565120129:
					{
						return this.voices;
					}
					
					
					case 371166859:
					{
						return this.track;
					}
					
					
					case 1103260490:
					{
						return this.clef;
					}
					
					
					case 855239132:
					{
						return this.previousBar;
					}
					
					
					case 624508576:
					{
						return this.nextBar;
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
					case 109002835:
					{
						this.finish();
						break;
					}
					
					
					case 207609411:
					{
						return this.isEmpty();
					}
					
					
					case 248321755:
					{
						return this.getMasterBar();
					}
					
					
					case 877939665:
					{
						this.addVoice(((global::alphatab.model.Voice) (dynargs[0]) ));
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
				baseArr.push("maxDuration");
				baseArr.push("minDuration");
				baseArr.push("voices");
				baseArr.push("track");
				baseArr.push("clef");
				baseArr.push("previousBar");
				baseArr.push("nextBar");
				baseArr.push("index");
				{
					base.__hx_getFields(baseArr);
				}
				
			}
		}
		
		
	}
}


