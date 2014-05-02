using haxe.root;
#pragma warning disable 109, 114, 219, 429, 168, 162
namespace alphatab.model{
	public  class Section : global::haxe.lang.HxObject {
		public    Section(global::haxe.lang.EmptyObject empty){
			unchecked {
				{
				}
				
			}
		}
		
		
		public    Section(){
			unchecked {
				global::alphatab.model.Section.__hx_ctor_alphatab_model_Section(this);
			}
		}
		
		
		public static   void __hx_ctor_alphatab_model_Section(global::alphatab.model.Section __temp_me99){
			unchecked {
				{
				}
				
			}
		}
		
		
		public static  new object __hx_createEmpty(){
			unchecked {
				return new global::alphatab.model.Section(((global::haxe.lang.EmptyObject) (global::haxe.lang.EmptyObject.EMPTY) ));
			}
		}
		
		
		public static  new object __hx_create(global::haxe.root.Array arr){
			unchecked {
				return new global::alphatab.model.Section();
			}
		}
		
		
		public  string marker;
		
		public  string text;
		
		public override   object __hx_setField(string field, int hash, object @value, bool handleProperties){
			unchecked {
				switch (hash){
					case 1291439277:
					{
						this.text = global::haxe.lang.Runtime.toString(@value);
						return @value;
					}
					
					
					case 980448698:
					{
						this.marker = global::haxe.lang.Runtime.toString(@value);
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
					case 1291439277:
					{
						return this.text;
					}
					
					
					case 980448698:
					{
						return this.marker;
					}
					
					
					default:
					{
						return base.__hx_getField(field, hash, throwErrors, isCheck, handleProperties);
					}
					
				}
				
			}
		}
		
		
		public override   void __hx_getFields(global::haxe.root.Array<object> baseArr){
			unchecked {
				baseArr.push("text");
				baseArr.push("marker");
				{
					base.__hx_getFields(baseArr);
				}
				
			}
		}
		
		
	}
}


