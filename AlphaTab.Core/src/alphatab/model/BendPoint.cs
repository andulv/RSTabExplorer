using haxe.root;
#pragma warning disable 109, 114, 219, 429, 168, 162
namespace alphatab.model{
	public  class BendPoint : global::haxe.lang.HxObject {
		static BendPoint() {
			global::alphatab.model.BendPoint.MaxPosition = 60;
			global::alphatab.model.BendPoint.MaxValue = 12;
		}
		public    BendPoint(global::haxe.lang.EmptyObject empty){
			unchecked {
				{
				}
				
			}
		}
		
		
		public    BendPoint(global::haxe.lang.Null<int> offset, global::haxe.lang.Null<int> @value){
			unchecked {
				global::alphatab.model.BendPoint.__hx_ctor_alphatab_model_BendPoint(this, offset, @value);
			}
		}
		
		
		public static   void __hx_ctor_alphatab_model_BendPoint(global::alphatab.model.BendPoint __temp_me91, global::haxe.lang.Null<int> offset, global::haxe.lang.Null<int> @value){
			unchecked {
				int __temp_value90 = ( ( ! (@value.hasValue) ) ? (((int) (0) )) : (@value.@value) );
				int __temp_offset89 = ( ( ! (offset.hasValue) ) ? (((int) (0) )) : (offset.@value) );
				__temp_me91.offset = __temp_offset89;
				__temp_me91.@value = __temp_value90;
			}
		}
		
		
		public static  int MaxPosition;
		
		public static  int MaxValue;
		
		public static  new object __hx_createEmpty(){
			unchecked {
				return new global::alphatab.model.BendPoint(((global::haxe.lang.EmptyObject) (global::haxe.lang.EmptyObject.EMPTY) ));
			}
		}
		
		
		public static  new object __hx_create(global::haxe.root.Array arr){
			unchecked {
				return new global::alphatab.model.BendPoint(global::haxe.lang.Null<object>.ofDynamic<int>(arr[0]), global::haxe.lang.Null<object>.ofDynamic<int>(arr[1]));
			}
		}
		
		
		public  int offset;
		
		public  int @value;
		
		public virtual   global::alphatab.model.BendPoint clone(){
			unchecked {
				global::alphatab.model.BendPoint point = new global::alphatab.model.BendPoint(((global::haxe.lang.Null<int>) (default(global::haxe.lang.Null<int>)) ), ((global::haxe.lang.Null<int>) (default(global::haxe.lang.Null<int>)) ));
				point.offset = this.offset;
				point.@value = this.@value;
				return point;
			}
		}
		
		
		public override   double __hx_setField_f(string field, int hash, double @value, bool handleProperties){
			unchecked {
				switch (hash){
					case 834174833:
					{
						this.@value = ((int) (@value) );
						return @value;
					}
					
					
					case 1614780307:
					{
						this.offset = ((int) (@value) );
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
					case 834174833:
					{
						this.@value = ((int) (global::haxe.lang.Runtime.toInt(@value)) );
						return @value;
					}
					
					
					case 1614780307:
					{
						this.offset = ((int) (global::haxe.lang.Runtime.toInt(@value)) );
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
					case 1214452573:
					{
						return ((global::haxe.lang.Function) (new global::haxe.lang.Closure(((object) (this) ), ((string) ("clone") ), ((int) (1214452573) ))) );
					}
					
					
					case 834174833:
					{
						return this.@value;
					}
					
					
					case 1614780307:
					{
						return this.offset;
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
					case 834174833:
					{
						return ((double) (this.@value) );
					}
					
					
					case 1614780307:
					{
						return ((double) (this.offset) );
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
					case 1214452573:
					{
						return this.clone();
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
				baseArr.push("value");
				baseArr.push("offset");
				{
					base.__hx_getFields(baseArr);
				}
				
			}
		}
		
		
	}
}


