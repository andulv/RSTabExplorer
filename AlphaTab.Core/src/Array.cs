using haxe.root;
#pragma warning disable 109, 114, 219, 429, 168, 162
namespace haxe.root{
	public sealed class Array<T> : global::haxe.lang.HxObject, global::haxe.root.Array {
		
	public Array(T[] native)
	{
		this.__a = native;
		this.length = native.Length;
	}
		public    Array(global::haxe.lang.EmptyObject empty){
			unchecked {
				{
				}
				
			}
		}
		
		
		public    Array(){
			unchecked {
				global::haxe.root.Array<object>.__hx_ctor__Array<T>(this);
			}
		}
		
		
		public static   void __hx_ctor__Array<T_c>(global::haxe.root.Array<T_c> __temp_me4){
			unchecked {
				__temp_me4.length = 0;
				__temp_me4.__a = new T_c[((int) (0) )];
			}
		}
		
		
		public static   object __hx_cast<T_c_c>(global::haxe.root.Array me){
			unchecked {
				return ( (( me != default(global::haxe.root.Array) )) ? (me.Array_cast<T_c_c>()) : (default(global::haxe.root.Array)) );
			}
		}
		
		
		public static   global::haxe.root.Array<X> ofNative<X>(X[] native){
			
			return new Array<X>(native);
	
		}
		
		
		public static   global::haxe.root.Array<Y> alloc<Y>(int size){
			
			return new Array<Y>(new Y[size]);
	
		}
		
		
		public static  new object __hx_createEmpty(){
			unchecked {
				return new global::haxe.root.Array<object>(((global::haxe.lang.EmptyObject) (global::haxe.lang.EmptyObject.EMPTY) ));
			}
		}
		
		
		public static  new object __hx_create(global::haxe.root.Array arr){
			unchecked {
				return new global::haxe.root.Array<object>();
			}
		}
		
		
		public   object Array_cast<T_c>(){
			unchecked {
				if (global::haxe.lang.Runtime.eq(typeof(T), typeof(T_c))) {
					return this;
				}
				
				global::haxe.root.Array<T_c> new_me = new global::haxe.root.Array<T_c>(((global::haxe.lang.EmptyObject) (global::haxe.lang.EmptyObject.EMPTY) ));
				{
					object __temp_iterator324 = global::haxe.root.Reflect.fields(this).iterator();
					while (global::haxe.lang.Runtime.toBool(global::haxe.lang.Runtime.callField(__temp_iterator324, "hasNext", 407283053, default(global::haxe.root.Array)))){
						string field = global::haxe.lang.Runtime.toString(global::haxe.lang.Runtime.callField(__temp_iterator324, "next", 1224901875, default(global::haxe.root.Array)));
						switch (field){
							case "__a":
							{
								if (( this.__a != default(T[]) )) {
									T_c[] __temp_new_arr1 = new T_c[((int) (this.__a.Length) )];
									int __temp_i2 = -1;
									while ((  ++ __temp_i2 < this.__a.Length )){
										object __temp_obj3 = ((object) (this.__a[__temp_i2]) );
										if ( ! (global::haxe.lang.Runtime.eq(__temp_obj3, default(T[]))) ) {
											__temp_new_arr1[__temp_i2] = global::haxe.lang.Runtime.genericCast<T_c>(__temp_obj3);
										}
										
									}
									
									new_me.__a = __temp_new_arr1;
								}
								 else {
									new_me.__a = default(T_c[]);
								}
								
								break;
							}
							
							
							default:
							{
								global::haxe.root.Reflect.setField(new_me, field, ((object) (global::haxe.root.Reflect.field(this, field)) ));
								break;
							}
							
						}
						
					}
					
				}
				
				return new_me;
			}
		}
		
		
		public  int length;
		
		public  T[] __a;
		
		public   global::haxe.root.Array<T> concat(global::haxe.root.Array<T> a){
			unchecked {
				int len = ( this.length + a.length );
				T[] retarr = new T[((int) (len) )];
				global::System.Array.Copy(((global::System.Array) (this.__a) ), ((int) (0) ), ((global::System.Array) (retarr) ), ((int) (0) ), ((int) (this.length) ));
				global::System.Array.Copy(((global::System.Array) (a.__a) ), ((int) (0) ), ((global::System.Array) (retarr) ), ((int) (this.length) ), ((int) (a.length) ));
				return global::haxe.root.Array<object>.ofNative<T>(retarr);
			}
		}
		
		
		public   void concatNative(T[] a){
			unchecked {
				T[] __a = this.__a;
				int len = ( this.length + ( a as global::System.Array ).Length );
				if (( ( __a as global::System.Array ).Length >= len )) {
					global::System.Array.Copy(((global::System.Array) (a) ), ((int) (0) ), ((global::System.Array) (__a) ), ((int) (this.length) ), ((int) (this.length) ));
				}
				 else {
					T[] newarr = new T[((int) (len) )];
					global::System.Array.Copy(((global::System.Array) (__a) ), ((int) (0) ), ((global::System.Array) (newarr) ), ((int) (0) ), ((int) (this.length) ));
					global::System.Array.Copy(((global::System.Array) (a) ), ((int) (0) ), ((global::System.Array) (newarr) ), ((int) (this.length) ), ((int) (( a as global::System.Array ).Length) ));
					this.__a = newarr;
				}
				
				this.length = len;
			}
		}
		
		
		public   int indexOf(T x, global::haxe.lang.Null<int> fromIndex){
			unchecked {
				int len = this.length;
				int i = default(int);
				if ( ! (fromIndex.hasValue) ) {
					i = 0;
				}
				 else {
					i = fromIndex.@value;
				}
				
				if (( i < 0 )) {
					i += len;
					if (( i < 0 )) {
						i = 0;
					}
					
				}
				
				return global::System.Array.IndexOf<T>(((T[]) (this.__a) ), global::haxe.lang.Runtime.genericCast<T>(x), ((int) (i) ), ((int) (( len - i )) ));
			}
		}
		
		
		public   int lastIndexOf(T x, global::haxe.lang.Null<int> fromIndex){
			unchecked {
				int len = this.length;
				int i = default(int);
				if ( ! (fromIndex.hasValue) ) {
					i = ( len - 1 );
				}
				 else {
					i = fromIndex.@value;
				}
				
				if (( i >= len )) {
					i = ( len - 1 );
				}
				 else {
					if (( i < 0 )) {
						i += len;
						if (( i < 0 )) {
							return -1;
						}
						
					}
					
				}
				
				return global::System.Array.LastIndexOf<T>(((T[]) (this.__a) ), global::haxe.lang.Runtime.genericCast<T>(x), ((int) (i) ), ((int) (( i + 1 )) ));
			}
		}
		
		
		public   string @join(string sep){
			unchecked {
				global::haxe.root.StringBuf buf = new global::haxe.root.StringBuf();
				int i = -1;
				bool first = true;
				int length = this.length;
				while ((  ++ i < length )){
					if (first) {
						first = false;
					}
					 else {
						buf.b.Append(((object) (global::haxe.root.Std.@string(sep)) ));
					}
					
					buf.b.Append(((object) (global::haxe.root.Std.@string(this.__a[i])) ));
				}
				
				return buf.toString();
			}
		}
		
		
		public   global::haxe.lang.Null<T> pop(){
			unchecked {
				T[] __a = this.__a;
				int length = this.length;
				if (( length > 0 )) {
					T val = __a[ -- length];
					__a[length] = default(T);
					this.length = length;
					return new global::haxe.lang.Null<T>(val, true);
				}
				 else {
					return default(global::haxe.lang.Null<T>);
				}
				
			}
		}
		
		
		public   int push(T x){
			unchecked {
				if (( this.length >= ( this.__a as global::System.Array ).Length )) {
					int newLen = ( (( this.length << 1 )) + 1 );
					T[] newarr = new T[((int) (newLen) )];
					( this.__a as global::System.Array ).CopyTo(((global::System.Array) (newarr) ), ((int) (0) ));
					this.__a = newarr;
				}
				
				this.__a[this.length] = x;
				return  ++ this.length;
			}
		}
		
		
		public   void reverse(){
			unchecked {
				int i = 0;
				int l = this.length;
				T[] a = this.__a;
				int half = ( l >> 1 );
				l -= 1;
				while (( i < half )){
					T tmp = a[i];
					a[i] = a[( l - i )];
					a[( l - i )] = tmp;
					i += 1;
				}
				
			}
		}
		
		
		public   global::haxe.lang.Null<T> shift(){
			unchecked {
				int l = this.length;
				if (( l == 0 )) {
					return default(global::haxe.lang.Null<T>);
				}
				
				T[] a = this.__a;
				T x = a[0];
				l -= 1;
				global::System.Array.Copy(((global::System.Array) (a) ), ((int) (1) ), ((global::System.Array) (a) ), ((int) (0) ), ((int) (( this.length - 1 )) ));
				a[l] = default(T);
				this.length = l;
				return new global::haxe.lang.Null<T>(x, true);
			}
		}
		
		
		public   global::haxe.root.Array<T> slice(int pos, global::haxe.lang.Null<int> end){
			unchecked {
				if (( pos < 0 )) {
					pos = ( this.length + pos );
					if (( pos < 0 )) {
						pos = 0;
					}
					
				}
				
				if ( ! (end.hasValue) ) {
					end = new global::haxe.lang.Null<int>(this.length, true);
				}
				 else {
					if (( end.@value < 0 )) {
						end = new global::haxe.lang.Null<int>(( this.length + end.@value ), true);
					}
					
				}
				
				if (( end.@value > this.length )) {
					end = new global::haxe.lang.Null<int>(this.length, true);
				}
				
				int len = ( end.@value - pos );
				if (( len < 0 )) {
					return new global::haxe.root.Array<T>();
				}
				
				T[] newarr = new T[((int) (len) )];
				global::System.Array.Copy(((global::System.Array) (this.__a) ), ((int) (pos) ), ((global::System.Array) (newarr) ), ((int) (0) ), ((int) (len) ));
				return global::haxe.root.Array<object>.ofNative<T>(newarr);
			}
		}
		
		
		public   void sort(global::haxe.lang.Function f){
			unchecked {
				if (( this.length == 0 )) {
					return ;
				}
				
				this.quicksort(0, ( this.length - 1 ), f);
			}
		}
		
		
		public   void quicksort(int lo, int hi, global::haxe.lang.Function f){
			unchecked {
				T[] buf = this.__a;
				int i = lo;
				int j = hi;
				T p = buf[( ( i + j ) >> 1 )];
				while (( i <= j )){
					while (( ((int) (f.__hx_invoke2_f(default(double), buf[i], default(double), p)) ) < 0 )){
						i++;
					}
					
					while (( ((int) (f.__hx_invoke2_f(default(double), buf[j], default(double), p)) ) > 0 )){
						j--;
					}
					
					if (( i <= j )) {
						T t = buf[i];
						buf[i++] = buf[j];
						buf[j--] = t;
					}
					
				}
				
				if (( lo < j )) {
					this.quicksort(lo, j, f);
				}
				
				if (( i < hi )) {
					this.quicksort(i, hi, f);
				}
				
			}
		}
		
		
		public   global::haxe.root.Array<T> splice(int pos, int len){
			unchecked {
				if (( len < 0 )) {
					return new global::haxe.root.Array<T>();
				}
				
				if (( pos < 0 )) {
					pos = ( this.length + pos );
					if (( pos < 0 )) {
						pos = 0;
					}
					
				}
				
				if (( pos > this.length )) {
					pos = 0;
					len = 0;
				}
				 else {
					if (( ( pos + len ) > this.length )) {
						len = ( this.length - pos );
						if (( len < 0 )) {
							len = 0;
						}
						
					}
					
				}
				
				T[] a = this.__a;
				T[] ret = new T[((int) (len) )];
				global::System.Array.Copy(((global::System.Array) (a) ), ((int) (pos) ), ((global::System.Array) (ret) ), ((int) (0) ), ((int) (len) ));
				global::haxe.root.Array<T> ret1 = global::haxe.root.Array<object>.ofNative<T>(ret);
				int end = ( pos + len );
				global::System.Array.Copy(((global::System.Array) (a) ), ((int) (end) ), ((global::System.Array) (a) ), ((int) (pos) ), ((int) (( this.length - end )) ));
				this.length -= len;
				while ((  -- len >= 0 )){
					a[( this.length + len )] = default(T);
				}
				
				return ret1;
			}
		}
		
		
		public   void spliceVoid(int pos, int len){
			unchecked {
				if (( len < 0 )) {
					return ;
				}
				
				if (( pos < 0 )) {
					pos = ( this.length + pos );
					if (( pos < 0 )) {
						pos = 0;
					}
					
				}
				
				if (( pos > this.length )) {
					pos = 0;
					len = 0;
				}
				 else {
					if (( ( pos + len ) > this.length )) {
						len = ( this.length - pos );
						if (( len < 0 )) {
							len = 0;
						}
						
					}
					
				}
				
				T[] a = this.__a;
				int end = ( pos + len );
				global::System.Array.Copy(((global::System.Array) (a) ), ((int) (end) ), ((global::System.Array) (a) ), ((int) (pos) ), ((int) (( this.length - end )) ));
				this.length -= len;
				while ((  -- len >= 0 )){
					a[( this.length + len )] = default(T);
				}
				
			}
		}
		
		
		public   string toString(){
			unchecked {
				global::haxe.root.StringBuf ret = new global::haxe.root.StringBuf();
				T[] a = this.__a;
				ret.b.Append(((object) ("[") ));
				bool first = true;
				{
					int _g1 = 0;
					int _g = this.length;
					while (( _g1 < _g )){
						int i = _g1++;
						if (first) {
							first = false;
						}
						 else {
							ret.b.Append(((object) (",") ));
						}
						
						ret.b.Append(((object) (global::haxe.root.Std.@string(a[i])) ));
					}
					
				}
				
				ret.b.Append(((object) ("]") ));
				return ret.toString();
			}
		}
		
		
		public   void unshift(T x){
			unchecked {
				T[] __a = this.__a;
				int length = this.length;
				if (( length >= ( __a as global::System.Array ).Length )) {
					int newLen = ( (( length << 1 )) + 1 );
					T[] newarr = new T[((int) (newLen) )];
					global::System.Array.Copy(((global::System.Array) (__a) ), ((int) (0) ), ((global::System.Array) (newarr) ), ((int) (1) ), ((int) (length) ));
					this.__a = newarr;
				}
				 else {
					global::System.Array.Copy(((global::System.Array) (__a) ), ((int) (0) ), ((global::System.Array) (__a) ), ((int) (1) ), ((int) (length) ));
				}
				
				this.__a[0] = x;
				 ++ this.length;
			}
		}
		
		
		public   void insert(int pos, T x){
			unchecked {
				int l = this.length;
				if (( pos < 0 )) {
					pos = ( l + pos );
					if (( pos < 0 )) {
						pos = 0;
					}
					
				}
				
				if (( pos >= l )) {
					this.push(x);
					return ;
				}
				 else {
					if (( pos == 0 )) {
						this.unshift(x);
						return ;
					}
					
				}
				
				if (( l >= ( this.__a as global::System.Array ).Length )) {
					int newLen = ( (( this.length << 1 )) + 1 );
					T[] newarr = new T[((int) (newLen) )];
					global::System.Array.Copy(((global::System.Array) (this.__a) ), ((int) (0) ), ((global::System.Array) (newarr) ), ((int) (0) ), ((int) (pos) ));
					newarr[pos] = x;
					global::System.Array.Copy(((global::System.Array) (this.__a) ), ((int) (pos) ), ((global::System.Array) (newarr) ), ((int) (( pos + 1 )) ), ((int) (( l - pos )) ));
					this.__a = newarr;
					 ++ this.length;
				}
				 else {
					T[] __a = this.__a;
					global::System.Array.Copy(((global::System.Array) (__a) ), ((int) (pos) ), ((global::System.Array) (__a) ), ((int) (( pos + 1 )) ), ((int) (( l - pos )) ));
					global::System.Array.Copy(((global::System.Array) (__a) ), ((int) (0) ), ((global::System.Array) (__a) ), ((int) (0) ), ((int) (pos) ));
					__a[pos] = x;
					 ++ this.length;
				}
				
			}
		}
		
		
		public   bool @remove(T x){
			unchecked {
				T[] __a = this.__a;
				int i = -1;
				int length = this.length;
				while ((  ++ i < length )){
					if (global::haxe.lang.Runtime.eq(__a[i], x)) {
						global::System.Array.Copy(((global::System.Array) (__a) ), ((int) (( i + 1 )) ), ((global::System.Array) (__a) ), ((int) (i) ), ((int) (( ( length - i ) - 1 )) ));
						__a[ -- this.length] = default(T);
						return true;
					}
					
				}
				
				return false;
			}
		}
		
		
		public   global::haxe.root.Array<S> map<S>(global::haxe.lang.Function f){
			unchecked {
				global::haxe.root.Array<S> ret = new global::haxe.root.Array<S>(new S[]{});
				{
					int _g = 0;
					global::haxe.root.Array<T> _g1 = this;
					while (( _g < _g1.length )){
						T elt = _g1[_g];
						 ++ _g;
						ret.push(global::haxe.lang.Runtime.genericCast<S>(f.__hx_invoke1_o(default(double), elt)));
					}
					
				}
				
				return ret;
			}
		}
		
		
		public   global::haxe.root.Array<T> filter(global::haxe.lang.Function f){
			unchecked {
				global::haxe.root.Array<T> ret = new global::haxe.root.Array<T>(new T[]{});
				{
					int _g = 0;
					global::haxe.root.Array<T> _g1 = this;
					while (( _g < _g1.length )){
						T elt = _g1[_g];
						 ++ _g;
						if (global::haxe.lang.Runtime.toBool(f.__hx_invoke1_o(default(double), elt))) {
							ret.push(elt);
						}
						
					}
					
				}
				
				return ret;
			}
		}
		
		
		public   global::haxe.root.Array<T> copy(){
			unchecked {
				int len = this.length;
				T[] __a = this.__a;
				T[] newarr = new T[((int) (len) )];
				global::System.Array.Copy(((global::System.Array) (__a) ), ((int) (0) ), ((global::System.Array) (newarr) ), ((int) (0) ), ((int) (len) ));
				return global::haxe.root.Array<object>.ofNative<T>(newarr);
			}
		}
		
		
		public   object iterator(){
			unchecked {
				return new global::_Array.ArrayIterator<T>(((global::haxe.root.Array<T>) (this) ));
			}
		}
		
		
		public   T __get(int idx){
			unchecked {
				T[] __a = this.__a;
				uint idx1 = ((uint) (idx) );
				if (( idx1 >= this.length )) {
					return default(T);
				}
				
				return __a[((int) (idx1) )];
			}
		}
		
		
		public   T __set(int idx, T v){
			unchecked {
				uint idx1 = ((uint) (idx) );
				T[] __a = this.__a;
				if (( idx1 >= ( __a as global::System.Array ).Length )) {
					uint len = ( idx1 + 1 );
					if (( idx1 == ( __a as global::System.Array ).Length )) {
						len = ((uint) (( (( idx1 << 1 )) + 1 )) );
					}
					
					T[] newArr = new T[((int) (len) )];
					( __a as global::System.Array ).CopyTo(((global::System.Array) (newArr) ), ((int) (0) ));
					this.__a = __a = newArr;
				}
				
				if (( idx1 >= this.length )) {
					this.length = ((int) (( idx1 + 1 )) );
				}
				
				return __a[((int) (idx1) )] = v;
			}
		}
		
		
		public   T __unsafe_get(int idx){
			unchecked {
				return this.__a[idx];
			}
		}
		
		
		public   T __unsafe_set(int idx, T val){
			unchecked {
				return this.__a[idx] = val;
			}
		}
		
		
		public override   double __hx_setField_f(string field, int hash, double @value, bool handleProperties){
			unchecked {
				switch (hash){
					case 520590566:
					{
						this.length = ((int) (@value) );
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
					case 4745537:
					{
						this.__a = ((T[]) (@value) );
						return @value;
					}
					
					
					case 520590566:
					{
						this.length = ((int) (global::haxe.lang.Runtime.toInt(@value)) );
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
					case 1621420777:
					{
						return ((global::haxe.lang.Function) (new global::haxe.lang.Closure(((object) (this) ), ((string) ("__unsafe_set") ), ((int) (1621420777) ))) );
					}
					
					
					case 1620824029:
					{
						return ((global::haxe.lang.Function) (new global::haxe.lang.Closure(((object) (this) ), ((string) ("__unsafe_get") ), ((int) (1620824029) ))) );
					}
					
					
					case 1916009602:
					{
						return ((global::haxe.lang.Function) (new global::haxe.lang.Closure(((object) (this) ), ((string) ("__set") ), ((int) (1916009602) ))) );
					}
					
					
					case 1915412854:
					{
						return ((global::haxe.lang.Function) (new global::haxe.lang.Closure(((object) (this) ), ((string) ("__get") ), ((int) (1915412854) ))) );
					}
					
					
					case 328878574:
					{
						return ((global::haxe.lang.Function) (new global::haxe.lang.Closure(((object) (this) ), ((string) ("iterator") ), ((int) (328878574) ))) );
					}
					
					
					case 1103412149:
					{
						return ((global::haxe.lang.Function) (new global::haxe.lang.Closure(((object) (this) ), ((string) ("copy") ), ((int) (1103412149) ))) );
					}
					
					
					case 87367608:
					{
						return ((global::haxe.lang.Function) (new global::haxe.lang.Closure(((object) (this) ), ((string) ("filter") ), ((int) (87367608) ))) );
					}
					
					
					case 5442204:
					{
						return ((global::haxe.lang.Function) (new global::haxe.lang.Closure(((object) (this) ), ((string) ("map") ), ((int) (5442204) ))) );
					}
					
					
					case 76061764:
					{
						return ((global::haxe.lang.Function) (new global::haxe.lang.Closure(((object) (this) ), ((string) ("remove") ), ((int) (76061764) ))) );
					}
					
					
					case 501039929:
					{
						return ((global::haxe.lang.Function) (new global::haxe.lang.Closure(((object) (this) ), ((string) ("insert") ), ((int) (501039929) ))) );
					}
					
					
					case 2025055113:
					{
						return ((global::haxe.lang.Function) (new global::haxe.lang.Closure(((object) (this) ), ((string) ("unshift") ), ((int) (2025055113) ))) );
					}
					
					
					case 946786476:
					{
						return ((global::haxe.lang.Function) (new global::haxe.lang.Closure(((object) (this) ), ((string) ("toString") ), ((int) (946786476) ))) );
					}
					
					
					case 1352786672:
					{
						return ((global::haxe.lang.Function) (new global::haxe.lang.Closure(((object) (this) ), ((string) ("spliceVoid") ), ((int) (1352786672) ))) );
					}
					
					
					case 1067353468:
					{
						return ((global::haxe.lang.Function) (new global::haxe.lang.Closure(((object) (this) ), ((string) ("splice") ), ((int) (1067353468) ))) );
					}
					
					
					case 1282943179:
					{
						return ((global::haxe.lang.Function) (new global::haxe.lang.Closure(((object) (this) ), ((string) ("quicksort") ), ((int) (1282943179) ))) );
					}
					
					
					case 1280845662:
					{
						return ((global::haxe.lang.Function) (new global::haxe.lang.Closure(((object) (this) ), ((string) ("sort") ), ((int) (1280845662) ))) );
					}
					
					
					case 2127021138:
					{
						return ((global::haxe.lang.Function) (new global::haxe.lang.Closure(((object) (this) ), ((string) ("slice") ), ((int) (2127021138) ))) );
					}
					
					
					case 2082663554:
					{
						return ((global::haxe.lang.Function) (new global::haxe.lang.Closure(((object) (this) ), ((string) ("shift") ), ((int) (2082663554) ))) );
					}
					
					
					case 452737314:
					{
						return ((global::haxe.lang.Function) (new global::haxe.lang.Closure(((object) (this) ), ((string) ("reverse") ), ((int) (452737314) ))) );
					}
					
					
					case 1247875546:
					{
						return ((global::haxe.lang.Function) (new global::haxe.lang.Closure(((object) (this) ), ((string) ("push") ), ((int) (1247875546) ))) );
					}
					
					
					case 5594513:
					{
						return ((global::haxe.lang.Function) (new global::haxe.lang.Closure(((object) (this) ), ((string) ("pop") ), ((int) (5594513) ))) );
					}
					
					
					case 1181037546:
					{
						return ((global::haxe.lang.Function) (new global::haxe.lang.Closure(((object) (this) ), ((string) ("join") ), ((int) (1181037546) ))) );
					}
					
					
					case 359333139:
					{
						return ((global::haxe.lang.Function) (new global::haxe.lang.Closure(((object) (this) ), ((string) ("lastIndexOf") ), ((int) (359333139) ))) );
					}
					
					
					case 1623148745:
					{
						return ((global::haxe.lang.Function) (new global::haxe.lang.Closure(((object) (this) ), ((string) ("indexOf") ), ((int) (1623148745) ))) );
					}
					
					
					case 1532710347:
					{
						return ((global::haxe.lang.Function) (new global::haxe.lang.Closure(((object) (this) ), ((string) ("concatNative") ), ((int) (1532710347) ))) );
					}
					
					
					case 1204816148:
					{
						return ((global::haxe.lang.Function) (new global::haxe.lang.Closure(((object) (this) ), ((string) ("concat") ), ((int) (1204816148) ))) );
					}
					
					
					case 4745537:
					{
						return this.__a;
					}
					
					
					case 520590566:
					{
						return this.length;
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
					case 520590566:
					{
						return ((double) (this.length) );
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
					case 1621420777:
					{
						return this.__unsafe_set(((int) (global::haxe.lang.Runtime.toInt(dynargs[0])) ), global::haxe.lang.Runtime.genericCast<T>(dynargs[1]));
					}
					
					
					case 1620824029:
					{
						return this.__unsafe_get(((int) (global::haxe.lang.Runtime.toInt(dynargs[0])) ));
					}
					
					
					case 1916009602:
					{
						return this.__set(((int) (global::haxe.lang.Runtime.toInt(dynargs[0])) ), global::haxe.lang.Runtime.genericCast<T>(dynargs[1]));
					}
					
					
					case 1915412854:
					{
						return this.__get(((int) (global::haxe.lang.Runtime.toInt(dynargs[0])) ));
					}
					
					
					case 328878574:
					{
						return this.iterator();
					}
					
					
					case 1103412149:
					{
						return this.copy();
					}
					
					
					case 87367608:
					{
						return this.filter(((global::haxe.lang.Function) (dynargs[0]) ));
					}
					
					
					case 5442204:
					{
						return this.map<object>(((global::haxe.lang.Function) (dynargs[0]) ));
					}
					
					
					case 76061764:
					{
						return this.@remove(global::haxe.lang.Runtime.genericCast<T>(dynargs[0]));
					}
					
					
					case 501039929:
					{
						this.insert(((int) (global::haxe.lang.Runtime.toInt(dynargs[0])) ), global::haxe.lang.Runtime.genericCast<T>(dynargs[1]));
						break;
					}
					
					
					case 2025055113:
					{
						this.unshift(global::haxe.lang.Runtime.genericCast<T>(dynargs[0]));
						break;
					}
					
					
					case 946786476:
					{
						return this.toString();
					}
					
					
					case 1352786672:
					{
						this.spliceVoid(((int) (global::haxe.lang.Runtime.toInt(dynargs[0])) ), ((int) (global::haxe.lang.Runtime.toInt(dynargs[1])) ));
						break;
					}
					
					
					case 1067353468:
					{
						return this.splice(((int) (global::haxe.lang.Runtime.toInt(dynargs[0])) ), ((int) (global::haxe.lang.Runtime.toInt(dynargs[1])) ));
					}
					
					
					case 1282943179:
					{
						this.quicksort(((int) (global::haxe.lang.Runtime.toInt(dynargs[0])) ), ((int) (global::haxe.lang.Runtime.toInt(dynargs[1])) ), ((global::haxe.lang.Function) (dynargs[2]) ));
						break;
					}
					
					
					case 1280845662:
					{
						this.sort(((global::haxe.lang.Function) (dynargs[0]) ));
						break;
					}
					
					
					case 2127021138:
					{
						return this.slice(((int) (global::haxe.lang.Runtime.toInt(dynargs[0])) ), global::haxe.lang.Null<object>.ofDynamic<int>(dynargs[1]));
					}
					
					
					case 2082663554:
					{
						return (this.shift()).toDynamic();
					}
					
					
					case 452737314:
					{
						this.reverse();
						break;
					}
					
					
					case 1247875546:
					{
						return this.push(global::haxe.lang.Runtime.genericCast<T>(dynargs[0]));
					}
					
					
					case 5594513:
					{
						return (this.pop()).toDynamic();
					}
					
					
					case 1181037546:
					{
						return this.@join(global::haxe.lang.Runtime.toString(dynargs[0]));
					}
					
					
					case 359333139:
					{
						return this.lastIndexOf(global::haxe.lang.Runtime.genericCast<T>(dynargs[0]), global::haxe.lang.Null<object>.ofDynamic<int>(dynargs[1]));
					}
					
					
					case 1623148745:
					{
						return this.indexOf(global::haxe.lang.Runtime.genericCast<T>(dynargs[0]), global::haxe.lang.Null<object>.ofDynamic<int>(dynargs[1]));
					}
					
					
					case 1532710347:
					{
						this.concatNative(((T[]) (dynargs[0]) ));
						break;
					}
					
					
					case 1204816148:
					{
						return this.concat(((global::haxe.root.Array<T>) (global::haxe.root.Array<object>.__hx_cast<T>(((global::haxe.root.Array) (dynargs[0]) ))) ));
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
				baseArr.push("__a");
				baseArr.push("length");
				{
					base.__hx_getFields(baseArr);
				}
				
			}
		}
		
		
		public T this[int index]{
			get{
				return this.__get(index);
			}
			set{
				this.__set(index,value);
			}
		}
		object global::haxe.root.Array.this[int key]{
			get{
				return ((object) this.__get(key));
			}
			set{
				this.__set(key, (T) value);
			}
		}
		
		
		public override string ToString(){
			return this.toString();
		}
		
		
	}
}



#pragma warning disable 109, 114, 219, 429, 168, 162
namespace haxe.root{
	public  interface Array : global::haxe.lang.IHxObject, global::haxe.lang.IGenericObject {
		   object Array_cast<T_c>();
		
		object this[int key]{
			get;
			set;
		}
		
		
	}
}



#pragma warning disable 109, 114, 219, 429, 168, 162
namespace _Array{
	public sealed class ArrayIterator<T> : global::haxe.lang.HxObject, global::_Array.ArrayIterator {
		public    ArrayIterator(global::haxe.lang.EmptyObject empty){
			unchecked {
				{
				}
				
			}
		}
		
		
		public    ArrayIterator(global::haxe.root.Array<T> a){
			unchecked {
				global::_Array.ArrayIterator<object>.__hx_ctor__Array_ArrayIterator<T>(this, a);
			}
		}
		
		
		public static   void __hx_ctor__Array_ArrayIterator<T_c>(global::_Array.ArrayIterator<T_c> __temp_me5, global::haxe.root.Array<T_c> a){
			unchecked {
				__temp_me5.arr = a;
				__temp_me5.len = a.length;
				__temp_me5.i = 0;
			}
		}
		
		
		public static   object __hx_cast<T_c_c>(global::_Array.ArrayIterator me){
			unchecked {
				return ( (( me != default(global::_Array.ArrayIterator) )) ? (me._Array_ArrayIterator_cast<T_c_c>()) : (default(global::_Array.ArrayIterator)) );
			}
		}
		
		
		public static  new object __hx_createEmpty(){
			unchecked {
				return new global::_Array.ArrayIterator<object>(((global::haxe.lang.EmptyObject) (global::haxe.lang.EmptyObject.EMPTY) ));
			}
		}
		
		
		public static  new object __hx_create(global::haxe.root.Array arr){
			unchecked {
				return new global::_Array.ArrayIterator<object>(((global::haxe.root.Array<object>) (global::haxe.root.Array<object>.__hx_cast<object>(((global::haxe.root.Array) (arr[0]) ))) ));
			}
		}
		
		
		public   object _Array_ArrayIterator_cast<T_c>(){
			unchecked {
				if (global::haxe.lang.Runtime.eq(typeof(T), typeof(T_c))) {
					return this;
				}
				
				global::_Array.ArrayIterator<T_c> new_me = new global::_Array.ArrayIterator<T_c>(((global::haxe.lang.EmptyObject) (global::haxe.lang.EmptyObject.EMPTY) ));
				{
					object __temp_iterator325 = global::haxe.root.Reflect.fields(this).iterator();
					while (global::haxe.lang.Runtime.toBool(global::haxe.lang.Runtime.callField(__temp_iterator325, "hasNext", 407283053, default(global::haxe.root.Array)))){
						string field = global::haxe.lang.Runtime.toString(global::haxe.lang.Runtime.callField(__temp_iterator325, "next", 1224901875, default(global::haxe.root.Array)));
						switch (field){
							default:
							{
								global::haxe.root.Reflect.setField(new_me, field, ((object) (global::haxe.root.Reflect.field(this, field)) ));
								break;
							}
							
						}
						
					}
					
				}
				
				return new_me;
			}
		}
		
		
		public  global::haxe.root.Array<T> arr;
		
		public  int len;
		
		public  int i;
		
		public   bool hasNext(){
			unchecked {
				return ( this.i < this.len );
			}
		}
		
		
		public   T next(){
			unchecked {
				return this.arr[this.i++];
			}
		}
		
		
		public override   double __hx_setField_f(string field, int hash, double @value, bool handleProperties){
			unchecked {
				switch (hash){
					case 105:
					{
						this.i = ((int) (@value) );
						return @value;
					}
					
					
					case 5393365:
					{
						this.len = ((int) (@value) );
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
					case 105:
					{
						this.i = ((int) (global::haxe.lang.Runtime.toInt(@value)) );
						return @value;
					}
					
					
					case 5393365:
					{
						this.len = ((int) (global::haxe.lang.Runtime.toInt(@value)) );
						return @value;
					}
					
					
					case 4849249:
					{
						this.arr = ((global::haxe.root.Array<T>) (global::haxe.root.Array<object>.__hx_cast<T>(((global::haxe.root.Array) (@value) ))) );
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
					case 1224901875:
					{
						return ((global::haxe.lang.Function) (new global::haxe.lang.Closure(((object) (this) ), ((string) ("next") ), ((int) (1224901875) ))) );
					}
					
					
					case 407283053:
					{
						return ((global::haxe.lang.Function) (new global::haxe.lang.Closure(((object) (this) ), ((string) ("hasNext") ), ((int) (407283053) ))) );
					}
					
					
					case 105:
					{
						return this.i;
					}
					
					
					case 5393365:
					{
						return this.len;
					}
					
					
					case 4849249:
					{
						return this.arr;
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
					case 105:
					{
						return ((double) (this.i) );
					}
					
					
					case 5393365:
					{
						return ((double) (this.len) );
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
					case 1224901875:
					{
						return this.next();
					}
					
					
					case 407283053:
					{
						return this.hasNext();
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
				baseArr.push("i");
				baseArr.push("len");
				baseArr.push("arr");
				{
					base.__hx_getFields(baseArr);
				}
				
			}
		}
		
		
	}
}



#pragma warning disable 109, 114, 219, 429, 168, 162
namespace _Array{
	public  interface ArrayIterator : global::haxe.lang.IHxObject, global::haxe.lang.IGenericObject {
		   object _Array_ArrayIterator_cast<T_c>();
		
	}
}


