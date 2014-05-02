using haxe.root;
#pragma warning disable 109, 114, 219, 429, 168, 162
namespace alphatab.util{
	public  class Guid : global::haxe.lang.HxObject {
		public    Guid(global::haxe.lang.EmptyObject empty){
			unchecked {
				{
				}
				
			}
		}
		
		
		public    Guid(){
			unchecked {
				global::alphatab.util.Guid.__hx_ctor_alphatab_util_Guid(this);
			}
		}
		
		
		public static   void __hx_ctor_alphatab_util_Guid(global::alphatab.util.Guid __temp_me295){
			unchecked {
				{
				}
				
			}
		}
		
		
		public static   string generate(){
			unchecked {
				global::haxe.root.StringBuf result = new global::haxe.root.StringBuf();
				{
					int _g = 0;
					while (( _g < 32 )){
						int j = _g++;
						if (( ( ( ( j == 8 ) || ( j == 12 ) ) || ( j == 16 ) ) || ( j == 20 ) )) {
							result.b.Append(((object) ("-") ));
						}
						
						{
							int __temp_stmt639 = default(int);
							{
								double v = ( global::haxe.root.Math.rand.NextDouble() * 16 );
								{
									double x1 = global::System.Math.Floor(((double) (v) ));
									__temp_stmt639 = ((int) (x1) );
								}
								
							}
							
							string x = global::haxe.root.StringTools.hex(__temp_stmt639, default(global::haxe.lang.Null<int>));
							result.b.Append(((object) (global::haxe.root.Std.@string(x)) ));
						}
						
					}
					
				}
				
				return result.toString().ToUpper();
			}
		}
		
		
		public static  new object __hx_createEmpty(){
			unchecked {
				return new global::alphatab.util.Guid(((global::haxe.lang.EmptyObject) (global::haxe.lang.EmptyObject.EMPTY) ));
			}
		}
		
		
		public static  new object __hx_create(global::haxe.root.Array arr){
			unchecked {
				return new global::alphatab.util.Guid();
			}
		}
		
		
	}
}


