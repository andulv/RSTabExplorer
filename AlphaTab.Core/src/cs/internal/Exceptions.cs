using haxe.root;
#pragma warning disable 109, 114, 219, 429, 168, 162
namespace haxe.lang{
	public  class Exceptions {
		public    Exceptions(){
			unchecked {
				{
				}
				
			}
		}
		
		
		[System.ThreadStaticAttribute]
		public static  global::System.Exception exception;
		
	}
}



#pragma warning disable 109, 114, 219, 429, 168, 162
namespace haxe.lang{
	public  class HaxeException : global::System.Exception {
		public    HaxeException(object obj) : base(){
			unchecked {
				if (( obj is global::haxe.lang.HaxeException )) {
					global::haxe.lang.HaxeException _obj = ((global::haxe.lang.HaxeException) (obj) );
					obj = _obj.getObject();
				}
				
				this.obj = obj;
			}
		}
		
		
		public static   global::System.Exception wrap(object obj){
			unchecked {
				if (( obj is global::System.Exception )) {
					return ((global::System.Exception) (obj) );
				}
				
				return new global::haxe.lang.HaxeException(((object) (obj) ));
			}
		}
		
		
		public  object obj;
		
		public virtual   object getObject(){
			unchecked {
				return this.obj;
			}
		}
		
		
		public virtual   string toString(){
			unchecked {
				return global::haxe.lang.Runtime.concat("Haxe Exception: ", global::haxe.root.Std.@string(this.obj));
			}
		}
		
		
		public override string ToString(){
			return this.toString();
		}
		
		
	}
}


