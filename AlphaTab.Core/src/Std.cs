using haxe.root;
#pragma warning disable 109, 114, 219, 429, 168, 162
namespace haxe.root{
	public  class Std {
		public    Std(){
			unchecked {
				{
				}
				
			}
		}
		
		
		public static   bool @is(object v, object t){
			unchecked {
				if (global::haxe.lang.Runtime.eq(v, default(object))) {
					return global::haxe.lang.Runtime.eq(t, typeof(object));
				}
				
				if (global::haxe.lang.Runtime.eq(t, default(object))) {
					return false;
				}
				
				global::System.Type clt = ((global::System.Type) (t) );
				if (global::haxe.lang.Runtime.typeEq(clt, default(global::System.Type))) {
					return false;
				}
				
				string name = global::haxe.lang.Runtime.toString(clt);
				switch (name){
					case "System.Double":
					{
						return v is double || v is int;
					}
					
					
					case "System.Int32":
					{
						return haxe.lang.Runtime.isInt(v);
					}
					
					
					case "System.Boolean":
					{
						return v is bool;
					}
					
					
					case "System.Object":
					{
						return true;
					}
					
					
				}
				
				return clt.IsAssignableFrom(((global::System.Type) (global::cs.Lib.nativeType(v)) ));
			}
		}
		
		
		public static   string @string(object s){
			unchecked {
				if (global::haxe.lang.Runtime.eq(s, default(object))) {
					return "null";
				}
				
				if (( s is bool )) {
					if (global::haxe.lang.Runtime.toBool(s)) {
						return "true";
					}
					 else {
						return "false";
					}
					
				}
				
				return s.ToString();
			}
		}
		
		
		public static   global::haxe.lang.Null<int> parseInt(string x){
			unchecked {
				if (string.Equals(x, default(string))) {
					return default(global::haxe.lang.Null<int>);
				}
				
				int ret = 0;
				int @base = 10;
				int i = -1;
				int len = x.Length;
				if (( x.StartsWith("0") && ( len > 2 ) )) {
					int c = ((int) (global::haxe.lang.Runtime.toInt(x[1])) );
					if (( ( c == 120 ) || ( c == 88 ) )) {
						i = 1;
						@base = 16;
					}
					
				}
				
				bool foundAny = false;
				bool isNeg = false;
				while ((  ++ i < len )){
					int c1 = default(int);
					c1 = ((int) (global::haxe.lang.Runtime.toInt(x[i])) );
					if ( ! (foundAny) ) {
						switch (c1){
							case 45:
							{
								isNeg = true;
								continue;
							}
							
							
							case 32:case 9:case 10:case 13:case 43:
							{
								if (isNeg) {
									return default(global::haxe.lang.Null<int>);
								}
								
								continue;
							}
							
							
						}
						
					}
					
					if (( ( c1 >= 48 ) && ( c1 <= 57 ) )) {
						if ((  ! (foundAny)  && ( c1 == 48 ) )) {
							foundAny = true;
							continue;
						}
						
						ret *= @base;
						foundAny = true;
						ret += ( c1 - 48 );
					}
					 else {
						if (( @base == 16 )) {
							if (( ( c1 >= 97 ) && ( c1 <= 102 ) )) {
								ret *= @base;
								foundAny = true;
								ret += ( ( c1 - 97 ) + 10 );
							}
							 else {
								if (( ( c1 >= 65 ) && ( c1 <= 70 ) )) {
									ret *= @base;
									foundAny = true;
									ret += ( ( c1 - 65 ) + 10 );
								}
								 else {
									break;
								}
								
							}
							
						}
						 else {
							break;
						}
						
					}
					
				}
				
				if (foundAny) {
					if (isNeg) {
						return new global::haxe.lang.Null<int>( - (ret) , true);
					}
					 else {
						return new global::haxe.lang.Null<int>(ret, true);
					}
					
				}
				 else {
					return default(global::haxe.lang.Null<int>);
				}
				
			}
		}
		
		
		public static   double parseFloat(string x){
			unchecked {
				if (string.Equals(x, default(string))) {
					return global::haxe.root.Math.NaN;
				}
				
				x = x.TrimStart();
				double ret = 0.0;
				double div = 0.0;
				double e = 0.0;
				int len = x.Length;
				bool foundAny = false;
				bool isNeg = false;
				int i = -1;
				while ((  ++ i < len )){
					int c = default(int);
					c = ((int) (global::haxe.lang.Runtime.toInt(x[i])) );
					if ( ! (foundAny) ) {
						switch (c){
							case 45:
							{
								isNeg = true;
								continue;
							}
							
							
							case 32:case 9:case 10:case 13:case 43:
							{
								if (isNeg) {
									return global::haxe.root.Math.NaN;
								}
								
								continue;
							}
							
							
						}
						
					}
					
					if (( c == 46 )) {
						if (( div != 0.0 )) {
							break;
						}
						
						div = 1.0;
						continue;
					}
					
					if (( ( c >= 48 ) && ( c <= 57 ) )) {
						if ((  ! (foundAny)  && ( c == 48 ) )) {
							foundAny = true;
							continue;
						}
						
						ret *= ((double) (10) );
						foundAny = true;
						div *= ((double) (10) );
						ret += ((double) (( c - 48 )) );
					}
					 else {
						if (( foundAny && (( ( c == 101 ) || ( c == 69 ) )) )) {
							bool eNeg = false;
							bool eFoundAny = false;
							if (( ( i + 1 ) < len )) {
								int next = default(int);
								next = ((int) (x[( i + 1 )]) );
								if (( next == 45 )) {
									eNeg = true;
									i++;
								}
								 else {
									if (( next == 43 )) {
										i++;
									}
									
								}
								
							}
							
							while ((  ++ i < len )){
								c = ((int) (x[i]) );
								if (( ( c >= 48 ) && ( c <= 57 ) )) {
									if ((  ! (eFoundAny)  && ( c == 48 ) )) {
										continue;
									}
									
									eFoundAny = true;
									e *= ((double) (10) );
									e += ((double) (( c - 48 )) );
								}
								 else {
									break;
								}
								
							}
							
							if (eNeg) {
								e =  - (e) ;
							}
							
						}
						 else {
							break;
						}
						
					}
					
				}
				
				if (( div == 0.0 )) {
					div = 1.0;
				}
				
				if (foundAny) {
					if (isNeg) {
						ret =  - ((( ret / div ))) ;
					}
					 else {
						ret = ( ret / div );
					}
					
					if (( e != 0.0 )) {
						return ( ret * global::System.Math.Pow(((double) (10.0) ), ((double) (e) )) );
					}
					 else {
						return ret;
					}
					
				}
				 else {
					return global::haxe.root.Math.NaN;
				}
				
			}
		}
		
		
	}
}


