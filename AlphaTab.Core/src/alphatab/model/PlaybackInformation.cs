using haxe.root;
#pragma warning disable 109, 114, 219, 429, 168, 162
namespace alphatab.model{
	public  class PlaybackInformation : global::haxe.lang.HxObject {
		public    PlaybackInformation(global::haxe.lang.EmptyObject empty){
			unchecked {
				{
				}
				
			}
		}
		
		
		public    PlaybackInformation(){
			unchecked {
				global::alphatab.model.PlaybackInformation.__hx_ctor_alphatab_model_PlaybackInformation(this);
			}
		}
		
		
		public static   void __hx_ctor_alphatab_model_PlaybackInformation(global::alphatab.model.PlaybackInformation __temp_me96){
			unchecked {
				__temp_me96.volume = 15;
				__temp_me96.balance = 8;
				__temp_me96.port = 1;
			}
		}
		
		
		public static  new object __hx_createEmpty(){
			unchecked {
				return new global::alphatab.model.PlaybackInformation(((global::haxe.lang.EmptyObject) (global::haxe.lang.EmptyObject.EMPTY) ));
			}
		}
		
		
		public static  new object __hx_create(global::haxe.root.Array arr){
			unchecked {
				return new global::alphatab.model.PlaybackInformation();
			}
		}
		
		
		public  int volume;
		
		public  int balance;
		
		public  int port;
		
		public  int program;
		
		public  int primaryChannel;
		
		public  int secondaryChannel;
		
		public  bool isMute;
		
		public  bool isSolo;
		
		public override   double __hx_setField_f(string field, int hash, double @value, bool handleProperties){
			unchecked {
				switch (hash){
					case 1329360815:
					{
						this.secondaryChannel = ((int) (@value) );
						return @value;
					}
					
					
					case 7816481:
					{
						this.primaryChannel = ((int) (@value) );
						return @value;
					}
					
					
					case 1945717380:
					{
						this.program = ((int) (@value) );
						return @value;
					}
					
					
					case 1247576961:
					{
						this.port = ((int) (@value) );
						return @value;
					}
					
					
					case 596483356:
					{
						this.balance = ((int) (@value) );
						return @value;
					}
					
					
					case 1599285722:
					{
						this.volume = ((int) (@value) );
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
					case 1774118697:
					{
						this.isSolo = global::haxe.lang.Runtime.toBool(@value);
						return @value;
					}
					
					
					case 1707881443:
					{
						this.isMute = global::haxe.lang.Runtime.toBool(@value);
						return @value;
					}
					
					
					case 1329360815:
					{
						this.secondaryChannel = ((int) (global::haxe.lang.Runtime.toInt(@value)) );
						return @value;
					}
					
					
					case 7816481:
					{
						this.primaryChannel = ((int) (global::haxe.lang.Runtime.toInt(@value)) );
						return @value;
					}
					
					
					case 1945717380:
					{
						this.program = ((int) (global::haxe.lang.Runtime.toInt(@value)) );
						return @value;
					}
					
					
					case 1247576961:
					{
						this.port = ((int) (global::haxe.lang.Runtime.toInt(@value)) );
						return @value;
					}
					
					
					case 596483356:
					{
						this.balance = ((int) (global::haxe.lang.Runtime.toInt(@value)) );
						return @value;
					}
					
					
					case 1599285722:
					{
						this.volume = ((int) (global::haxe.lang.Runtime.toInt(@value)) );
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
					case 1774118697:
					{
						return this.isSolo;
					}
					
					
					case 1707881443:
					{
						return this.isMute;
					}
					
					
					case 1329360815:
					{
						return this.secondaryChannel;
					}
					
					
					case 7816481:
					{
						return this.primaryChannel;
					}
					
					
					case 1945717380:
					{
						return this.program;
					}
					
					
					case 1247576961:
					{
						return this.port;
					}
					
					
					case 596483356:
					{
						return this.balance;
					}
					
					
					case 1599285722:
					{
						return this.volume;
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
					case 1329360815:
					{
						return ((double) (this.secondaryChannel) );
					}
					
					
					case 7816481:
					{
						return ((double) (this.primaryChannel) );
					}
					
					
					case 1945717380:
					{
						return ((double) (this.program) );
					}
					
					
					case 1247576961:
					{
						return ((double) (this.port) );
					}
					
					
					case 596483356:
					{
						return ((double) (this.balance) );
					}
					
					
					case 1599285722:
					{
						return ((double) (this.volume) );
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
				baseArr.push("isSolo");
				baseArr.push("isMute");
				baseArr.push("secondaryChannel");
				baseArr.push("primaryChannel");
				baseArr.push("program");
				baseArr.push("port");
				baseArr.push("balance");
				baseArr.push("volume");
				{
					base.__hx_getFields(baseArr);
				}
				
			}
		}
		
		
	}
}


