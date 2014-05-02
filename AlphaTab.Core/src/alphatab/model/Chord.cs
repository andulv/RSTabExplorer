using haxe.root;
#pragma warning disable 109, 114, 219, 429, 168, 162
namespace alphatab.model{
	public  class Chord : global::haxe.lang.HxObject {
		public    Chord(global::haxe.lang.EmptyObject empty){
			unchecked {
				{
				}
				
			}
		}
		
		
		public    Chord(){
			unchecked {
				global::alphatab.model.Chord.__hx_ctor_alphatab_model_Chord(this);
			}
		}
		
		
		public static   void __hx_ctor_alphatab_model_Chord(global::alphatab.model.Chord __temp_me92){
			unchecked {
				__temp_me92.strings = new global::haxe.root.Array<int>();
			}
		}
		
		
		public static  new object __hx_createEmpty(){
			unchecked {
				return new global::alphatab.model.Chord(((global::haxe.lang.EmptyObject) (global::haxe.lang.EmptyObject.EMPTY) ));
			}
		}
		
		
		public static  new object __hx_create(global::haxe.root.Array arr){
			unchecked {
				return new global::alphatab.model.Chord();
			}
		}
		
		
		public  string name;
		
		public  int firstFret;
		
		public  global::haxe.root.Array<int> strings;
		
		public override   double __hx_setField_f(string field, int hash, double @value, bool handleProperties){
			unchecked {
				switch (hash){
					case 2056329483:
					{
						this.firstFret = ((int) (@value) );
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
					case 2029227650:
					{
						this.strings = ((global::haxe.root.Array<int>) (global::haxe.root.Array<object>.__hx_cast<int>(((global::haxe.root.Array) (@value) ))) );
						return @value;
					}
					
					
					case 2056329483:
					{
						this.firstFret = ((int) (global::haxe.lang.Runtime.toInt(@value)) );
						return @value;
					}
					
					
					case 1224700491:
					{
						this.name = global::haxe.lang.Runtime.toString(@value);
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
					case 2029227650:
					{
						return this.strings;
					}
					
					
					case 2056329483:
					{
						return this.firstFret;
					}
					
					
					case 1224700491:
					{
						return this.name;
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
					case 2056329483:
					{
						return ((double) (this.firstFret) );
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
				baseArr.push("strings");
				baseArr.push("firstFret");
				baseArr.push("name");
				{
					base.__hx_getFields(baseArr);
				}
				
			}
		}
		
		
	}
}


