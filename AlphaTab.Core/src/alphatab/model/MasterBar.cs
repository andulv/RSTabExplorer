using haxe.root;
#pragma warning disable 109, 114, 219, 429, 168, 162
namespace alphatab.model{
	public  class MasterBar : global::haxe.lang.HxObject {
		static MasterBar() {
			global::alphatab.model.MasterBar.MaxAlternateEndings = 8;
		}
		public    MasterBar(global::haxe.lang.EmptyObject empty){
			unchecked {
				{
				}
				
			}
		}
		
		
		public    MasterBar(){
			unchecked {
				global::alphatab.model.MasterBar.__hx_ctor_alphatab_model_MasterBar(this);
			}
		}
		
		
		public static   void __hx_ctor_alphatab_model_MasterBar(global::alphatab.model.MasterBar __temp_me93){
			unchecked {
				__temp_me93.alternateEndings = 0;
				__temp_me93.repeatCount = 0;
				__temp_me93.index = 0;
				__temp_me93.keySignature = 0;
				__temp_me93.isDoubleBar = false;
				__temp_me93.isRepeatStart = false;
				__temp_me93.repeatCount = 0;
				__temp_me93.timeSignatureDenominator = 4;
				__temp_me93.timeSignatureNumerator = 4;
				__temp_me93.tripletFeel = global::alphatab.model.TripletFeel.NoTripletFeel;
				__temp_me93.start = 0;
			}
		}
		
		
		public static  int MaxAlternateEndings;
		
		public static  new object __hx_createEmpty(){
			unchecked {
				return new global::alphatab.model.MasterBar(((global::haxe.lang.EmptyObject) (global::haxe.lang.EmptyObject.EMPTY) ));
			}
		}
		
		
		public static  new object __hx_create(global::haxe.root.Array arr){
			unchecked {
				return new global::alphatab.model.MasterBar();
			}
		}
		
		
		public  int alternateEndings;
		
		public  global::alphatab.model.MasterBar nextMasterBar;
		
		public  global::alphatab.model.MasterBar previousMasterBar;
		
		public  int index;
		
		public  int keySignature;
		
		public  bool isDoubleBar;
		
		public  bool isRepeatStart;
		
		public   bool isRepeatEnd(){
			unchecked {
				return ( this.repeatCount > 0 );
			}
		}
		
		
		public  int repeatCount;
		
		public  global::alphatab.model.RepeatGroup repeatGroup;
		
		public  int timeSignatureDenominator;
		
		public  int timeSignatureNumerator;
		
		public  global::alphatab.model.TripletFeel tripletFeel;
		
		public  global::alphatab.model.Section section;
		
		public   bool isSectionStart(){
			unchecked {
				return ( this.section != default(global::alphatab.model.Section) );
			}
		}
		
		
		public  global::alphatab.model.Automation tempoAutomation;
		
		public  global::alphatab.model.Automation volumeAutomation;
		
		public  global::alphatab.model.Score score;
		
		public  int start;
		
		public virtual   int calculateDuration(){
			unchecked {
				return ( this.timeSignatureNumerator * global::alphatab.audio.MidiUtils.valueToTicks(this.timeSignatureDenominator) );
			}
		}
		
		
		public override   double __hx_setField_f(string field, int hash, double @value, bool handleProperties){
			unchecked {
				switch (hash){
					case 67859554:
					{
						this.start = ((int) (@value) );
						return @value;
					}
					
					
					case 1324324830:
					{
						this.timeSignatureNumerator = ((int) (@value) );
						return @value;
					}
					
					
					case 46594619:
					{
						this.timeSignatureDenominator = ((int) (@value) );
						return @value;
					}
					
					
					case 462066548:
					{
						this.repeatCount = ((int) (@value) );
						return @value;
					}
					
					
					case 1832144217:
					{
						this.keySignature = ((int) (@value) );
						return @value;
					}
					
					
					case 1041537810:
					{
						this.index = ((int) (@value) );
						return @value;
					}
					
					
					case 1116545170:
					{
						this.alternateEndings = ((int) (@value) );
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
					case 67859554:
					{
						this.start = ((int) (global::haxe.lang.Runtime.toInt(@value)) );
						return @value;
					}
					
					
					case 2027516754:
					{
						this.score = ((global::alphatab.model.Score) (@value) );
						return @value;
					}
					
					
					case 726713937:
					{
						this.volumeAutomation = ((global::alphatab.model.Automation) (@value) );
						return @value;
					}
					
					
					case 288700050:
					{
						this.tempoAutomation = ((global::alphatab.model.Automation) (@value) );
						return @value;
					}
					
					
					case 1574438373:
					{
						this.section = ((global::alphatab.model.Section) (@value) );
						return @value;
					}
					
					
					case 1999551132:
					{
						this.tripletFeel = ((global::alphatab.model.TripletFeel) (@value) );
						return @value;
					}
					
					
					case 1324324830:
					{
						this.timeSignatureNumerator = ((int) (global::haxe.lang.Runtime.toInt(@value)) );
						return @value;
					}
					
					
					case 46594619:
					{
						this.timeSignatureDenominator = ((int) (global::haxe.lang.Runtime.toInt(@value)) );
						return @value;
					}
					
					
					case 1796997604:
					{
						this.repeatGroup = ((global::alphatab.model.RepeatGroup) (@value) );
						return @value;
					}
					
					
					case 462066548:
					{
						this.repeatCount = ((int) (global::haxe.lang.Runtime.toInt(@value)) );
						return @value;
					}
					
					
					case 1582764861:
					{
						this.isRepeatStart = global::haxe.lang.Runtime.toBool(@value);
						return @value;
					}
					
					
					case 875656696:
					{
						this.isDoubleBar = global::haxe.lang.Runtime.toBool(@value);
						return @value;
					}
					
					
					case 1832144217:
					{
						this.keySignature = ((int) (global::haxe.lang.Runtime.toInt(@value)) );
						return @value;
					}
					
					
					case 1041537810:
					{
						this.index = ((int) (global::haxe.lang.Runtime.toInt(@value)) );
						return @value;
					}
					
					
					case 127983386:
					{
						this.previousMasterBar = ((global::alphatab.model.MasterBar) (@value) );
						return @value;
					}
					
					
					case 344334046:
					{
						this.nextMasterBar = ((global::alphatab.model.MasterBar) (@value) );
						return @value;
					}
					
					
					case 1116545170:
					{
						this.alternateEndings = ((int) (global::haxe.lang.Runtime.toInt(@value)) );
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
					case 2079799002:
					{
						return ((global::haxe.lang.Function) (new global::haxe.lang.Closure(((object) (this) ), ((string) ("calculateDuration") ), ((int) (2079799002) ))) );
					}
					
					
					case 67859554:
					{
						return this.start;
					}
					
					
					case 2027516754:
					{
						return this.score;
					}
					
					
					case 726713937:
					{
						return this.volumeAutomation;
					}
					
					
					case 288700050:
					{
						return this.tempoAutomation;
					}
					
					
					case 1502232391:
					{
						return ((global::haxe.lang.Function) (new global::haxe.lang.Closure(((object) (this) ), ((string) ("isSectionStart") ), ((int) (1502232391) ))) );
					}
					
					
					case 1574438373:
					{
						return this.section;
					}
					
					
					case 1999551132:
					{
						return this.tripletFeel;
					}
					
					
					case 1324324830:
					{
						return this.timeSignatureNumerator;
					}
					
					
					case 46594619:
					{
						return this.timeSignatureDenominator;
					}
					
					
					case 1796997604:
					{
						return this.repeatGroup;
					}
					
					
					case 462066548:
					{
						return this.repeatCount;
					}
					
					
					case 420980214:
					{
						return ((global::haxe.lang.Function) (new global::haxe.lang.Closure(((object) (this) ), ((string) ("isRepeatEnd") ), ((int) (420980214) ))) );
					}
					
					
					case 1582764861:
					{
						return this.isRepeatStart;
					}
					
					
					case 875656696:
					{
						return this.isDoubleBar;
					}
					
					
					case 1832144217:
					{
						return this.keySignature;
					}
					
					
					case 1041537810:
					{
						return this.index;
					}
					
					
					case 127983386:
					{
						return this.previousMasterBar;
					}
					
					
					case 344334046:
					{
						return this.nextMasterBar;
					}
					
					
					case 1116545170:
					{
						return this.alternateEndings;
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
					case 67859554:
					{
						return ((double) (this.start) );
					}
					
					
					case 1324324830:
					{
						return ((double) (this.timeSignatureNumerator) );
					}
					
					
					case 46594619:
					{
						return ((double) (this.timeSignatureDenominator) );
					}
					
					
					case 462066548:
					{
						return ((double) (this.repeatCount) );
					}
					
					
					case 1832144217:
					{
						return ((double) (this.keySignature) );
					}
					
					
					case 1041537810:
					{
						return ((double) (this.index) );
					}
					
					
					case 1116545170:
					{
						return ((double) (this.alternateEndings) );
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
					case 2079799002:
					{
						return this.calculateDuration();
					}
					
					
					case 1502232391:
					{
						return this.isSectionStart();
					}
					
					
					case 420980214:
					{
						return this.isRepeatEnd();
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
				baseArr.push("start");
				baseArr.push("score");
				baseArr.push("volumeAutomation");
				baseArr.push("tempoAutomation");
				baseArr.push("section");
				baseArr.push("tripletFeel");
				baseArr.push("timeSignatureNumerator");
				baseArr.push("timeSignatureDenominator");
				baseArr.push("repeatGroup");
				baseArr.push("repeatCount");
				baseArr.push("isRepeatStart");
				baseArr.push("isDoubleBar");
				baseArr.push("keySignature");
				baseArr.push("index");
				baseArr.push("previousMasterBar");
				baseArr.push("nextMasterBar");
				baseArr.push("alternateEndings");
				{
					base.__hx_getFields(baseArr);
				}
				
			}
		}
		
		
	}
}


