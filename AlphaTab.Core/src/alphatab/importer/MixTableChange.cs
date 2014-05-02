using haxe.root;
#pragma warning disable 109, 114, 219, 429, 168, 162
namespace alphatab.importer{
	public  class MixTableChange : global::haxe.lang.HxObject {
		public    MixTableChange(global::haxe.lang.EmptyObject empty){
			unchecked {
				{
				}
				
			}
		}
		
		
		public    MixTableChange(){
			unchecked {
				global::alphatab.importer.MixTableChange.__hx_ctor_alphatab_importer_MixTableChange(this);
			}
		}
		
		
		public static   void __hx_ctor_alphatab_importer_MixTableChange(global::alphatab.importer.MixTableChange __temp_me78){
			unchecked {
				__temp_me78.volume = -1;
				__temp_me78.balance = -1;
				__temp_me78.instrument = -1;
				__temp_me78.tempoName = default(string);
				__temp_me78.tempo = -1;
				__temp_me78.duration = 0;
			}
		}
		
		
		public static  new object __hx_createEmpty(){
			unchecked {
				return new global::alphatab.importer.MixTableChange(((global::haxe.lang.EmptyObject) (global::haxe.lang.EmptyObject.EMPTY) ));
			}
		}
		
		
		public static  new object __hx_create(global::haxe.root.Array arr){
			unchecked {
				return new global::alphatab.importer.MixTableChange();
			}
		}
		
		
		public  int volume;
		
		public  int balance;
		
		public  int instrument;
		
		public  string tempoName;
		
		public  int tempo;
		
		public  int duration;
		
		public override   double __hx_setField_f(string field, int hash, double @value, bool handleProperties){
			unchecked {
				switch (hash){
					case 344854356:
					{
						this.duration = ((int) (@value) );
						return @value;
					}
					
					
					case 227602139:
					{
						this.tempo = ((int) (@value) );
						return @value;
					}
					
					
					case 1184080679:
					{
						this.instrument = ((int) (@value) );
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
					case 344854356:
					{
						this.duration = ((int) (global::haxe.lang.Runtime.toInt(@value)) );
						return @value;
					}
					
					
					case 227602139:
					{
						this.tempo = ((int) (global::haxe.lang.Runtime.toInt(@value)) );
						return @value;
					}
					
					
					case 1077515974:
					{
						this.tempoName = global::haxe.lang.Runtime.toString(@value);
						return @value;
					}
					
					
					case 1184080679:
					{
						this.instrument = ((int) (global::haxe.lang.Runtime.toInt(@value)) );
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
					case 344854356:
					{
						return this.duration;
					}
					
					
					case 227602139:
					{
						return this.tempo;
					}
					
					
					case 1077515974:
					{
						return this.tempoName;
					}
					
					
					case 1184080679:
					{
						return this.instrument;
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
					case 344854356:
					{
						return ((double) (this.duration) );
					}
					
					
					case 227602139:
					{
						return ((double) (this.tempo) );
					}
					
					
					case 1184080679:
					{
						return ((double) (this.instrument) );
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
				baseArr.push("duration");
				baseArr.push("tempo");
				baseArr.push("tempoName");
				baseArr.push("instrument");
				baseArr.push("balance");
				baseArr.push("volume");
				{
					base.__hx_getFields(baseArr);
				}
				
			}
		}
		
		
	}
}


