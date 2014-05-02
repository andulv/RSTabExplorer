using haxe.root;
#pragma warning disable 109, 114, 219, 429, 168, 162
namespace haxe.ds{
	public  class IntMap<T> : global::haxe.lang.HxObject, global::haxe.ds.IntMap, global::haxe.root.IMap<int, T> {
		public    IntMap(global::haxe.lang.EmptyObject empty){
			unchecked {
				{
				}
				
			}
		}
		
		
		public    IntMap(){
			unchecked {
				global::haxe.ds.IntMap<object>.__hx_ctor_haxe_ds_IntMap<T>(this);
			}
		}
		
		
		public static   void __hx_ctor_haxe_ds_IntMap<T_c>(global::haxe.ds.IntMap<T_c> __temp_me311){
			unchecked {
				__temp_me311.cachedIndex = -1;
			}
		}
		
		
		public static   object __hx_cast<T_c_c>(global::haxe.ds.IntMap me){
			unchecked {
				return ( (( me != default(global::haxe.ds.IntMap) )) ? (me.haxe_ds_IntMap_cast<T_c_c>()) : (default(global::haxe.ds.IntMap)) );
			}
		}
		
		
		public static  new object __hx_createEmpty(){
			unchecked {
				return new global::haxe.ds.IntMap<object>(((global::haxe.lang.EmptyObject) (global::haxe.lang.EmptyObject.EMPTY) ));
			}
		}
		
		
		public static  new object __hx_create(global::haxe.root.Array arr){
			unchecked {
				return new global::haxe.ds.IntMap<object>();
			}
		}
		
		
		public virtual   object haxe_ds_IntMap_cast<T_c>(){
			unchecked {
				if (global::haxe.lang.Runtime.eq(typeof(T), typeof(T_c))) {
					return this;
				}
				
				global::haxe.ds.IntMap<T_c> new_me = new global::haxe.ds.IntMap<T_c>(((global::haxe.lang.EmptyObject) (global::haxe.lang.EmptyObject.EMPTY) ));
				{
					object __temp_iterator484 = global::haxe.root.Reflect.fields(this).iterator();
					while (global::haxe.lang.Runtime.toBool(global::haxe.lang.Runtime.callField(__temp_iterator484, "hasNext", 407283053, default(global::haxe.root.Array)))){
						string field = global::haxe.lang.Runtime.toString(global::haxe.lang.Runtime.callField(__temp_iterator484, "next", 1224901875, default(global::haxe.root.Array)));
						switch (field){
							case "vals":
							{
								if (( this.vals != default(T[]) )) {
									T_c[] __temp_new_arr308 = new T_c[((int) (this.vals.Length) )];
									int __temp_i309 = -1;
									while ((  ++ __temp_i309 < this.vals.Length )){
										object __temp_obj310 = ((object) (this.vals[__temp_i309]) );
										if ( ! (global::haxe.lang.Runtime.eq(__temp_obj310, default(T[]))) ) {
											__temp_new_arr308[__temp_i309] = global::haxe.lang.Runtime.genericCast<T_c>(__temp_obj310);
										}
										
									}
									
									new_me.vals = __temp_new_arr308;
								}
								 else {
									new_me.vals = default(T_c[]);
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
		
		
		public virtual   object IMap_cast<K_c, V_c>(){
			unchecked {
				return this.haxe_ds_IntMap_cast<V_c>();
			}
		}
		
		
		public  int[] flags;
		
		public  int[] _keys;
		
		public  T[] vals;
		
		public  int nBuckets;
		
		public  int size;
		
		public  int nOccupied;
		
		public  int upperBound;
		
		public  int cachedKey;
		
		public  int cachedIndex;
		
		public virtual   void @set(int key, T @value){
			unchecked {
				int x = default(int);
				if (( this.nOccupied >= this.upperBound )) {
					if (( this.nBuckets > ( this.size << 1 ) )) {
						this.resize(( this.nBuckets - 1 ));
					}
					 else {
						this.resize(( this.nBuckets + 1 ));
					}
					
				}
				
				int[] flags = this.flags;
				int[] _keys = this._keys;
				{
					int mask = ( this.nBuckets - 1 );
					int site = x = this.nBuckets;
					int k = key;
					int i = ( k & mask );
					if (( (( ((int) (( ((uint) (flags[( i >> 4 )]) ) >> (( (( i & 15 )) << 1 )) )) ) & 2 )) != 0 )) {
						x = i;
					}
					 else {
						int inc = ( (( ( ( k >> 3 ) ^ ( k << 3 ) ) | 1 )) & mask );
						int last = i;
						while ( ! ((( ( (( ((int) (( ((uint) (flags[( i >> 4 )]) ) >> (( (( i & 15 )) << 1 )) )) ) & 3 )) != 0 ) || ( _keys[i] == key ) ))) ){
							i = ( ( i + inc ) & mask );
						}
						
						x = i;
					}
					
				}
				
				if (( (( ((int) (( ((uint) (flags[( x >> 4 )]) ) >> (( (( x & 15 )) << 1 )) )) ) & 2 )) != 0 )) {
					_keys[x] = key;
					this.vals[x] = @value;
					flags[( x >> 4 )] &=  ~ ((( 3 << (( (( x & 15 )) << 1 )) ))) ;
					this.size++;
					this.nOccupied++;
				}
				 else {
					if (( (( ((int) (( ((uint) (flags[( x >> 4 )]) ) >> (( (( x & 15 )) << 1 )) )) ) & 1 )) != 0 )) {
						_keys[x] = key;
						this.vals[x] = @value;
						flags[( x >> 4 )] &=  ~ ((( 3 << (( (( x & 15 )) << 1 )) ))) ;
						this.size++;
					}
					 else {
						this.vals[x] = @value;
					}
					
				}
				
			}
		}
		
		
		public   int lookup(int key){
			unchecked {
				if (( this.nBuckets != 0 )) {
					int[] flags = this.flags;
					int[] _keys = this._keys;
					int mask = ( this.nBuckets - 1 );
					int k = key;
					int i = ( k & mask );
					int inc = ( (( ( ( k >> 3 ) ^ ( k << 3 ) ) | 1 )) & mask );
					int last = i;
					while ((  ! ((( (( ((int) (( ((uint) (flags[( i >> 4 )]) ) >> (( (( i & 15 )) << 1 )) )) ) & 2 )) != 0 )))  && (( ( (( ((int) (( ((uint) (flags[( i >> 4 )]) ) >> (( (( i & 15 )) << 1 )) )) ) & 1 )) != 0 ) || ( _keys[i] != key ) )) )){
						i = ( ( i + inc ) & mask );
						if (( i == last )) {
							return -1;
						}
						
					}
					
					if (( (( ((int) (( ((uint) (flags[( i >> 4 )]) ) >> (( (( i & 15 )) << 1 )) )) ) & 3 )) != 0 )) {
						return -1;
					}
					 else {
						return i;
					}
					
				}
				
				return -1;
			}
		}
		
		
		public virtual   global::haxe.lang.Null<T> @get(int key){
			unchecked {
				int idx = -1;
				if (( ( this.cachedKey == key ) && ( (idx = this.cachedIndex) != -1 ) )) {
					return new global::haxe.lang.Null<T>(this.vals[idx], true);
				}
				
				idx = this.lookup(key);
				if (( idx != -1 )) {
					this.cachedKey = key;
					this.cachedIndex = idx;
					return new global::haxe.lang.Null<T>(this.vals[idx], true);
				}
				
				return default(global::haxe.lang.Null<T>);
			}
		}
		
		
		public virtual   bool exists(int key){
			unchecked {
				int idx = -1;
				if (( ( this.cachedKey == key ) && ( (idx = this.cachedIndex) != -1 ) )) {
					return true;
				}
				
				idx = this.lookup(key);
				if (( idx != -1 )) {
					this.cachedKey = key;
					this.cachedIndex = idx;
					return true;
				}
				
				return false;
			}
		}
		
		
		public virtual   bool @remove(int key){
			unchecked {
				int idx = -1;
				if ( ! ((( ( this.cachedKey == key ) && ( (idx = this.cachedIndex) != -1 ) ))) ) {
					idx = this.lookup(key);
				}
				
				if (( idx == -1 )) {
					return false;
				}
				 else {
					if (( this.cachedKey == key )) {
						this.cachedIndex = -1;
					}
					
					if ( ! ((( (( ((int) (( ((uint) (this.flags[( idx >> 4 )]) ) >> (( (( idx & 15 )) << 1 )) )) ) & 3 )) != 0 ))) ) {
						this.flags[( idx >> 4 )] |= ( 1 << (( (( idx & 15 )) << 1 )) );
						 -- this.size;
						this.vals[idx] = default(T);
						this._keys[idx] = 0;
					}
					
					return true;
				}
				
			}
		}
		
		
		public   void resize(int newNBuckets){
			unchecked {
				int[] newFlags = default(int[]);
				int j = 1;
				{
					{
						int x = newNBuckets;
						 -- x;
						x |= ((int) (( ((uint) (x) ) >> 1 )) );
						x |= ((int) (( ((uint) (x) ) >> 2 )) );
						x |= ((int) (( ((uint) (x) ) >> 4 )) );
						x |= ((int) (( ((uint) (x) ) >> 8 )) );
						x |= ((int) (( ((uint) (x) ) >> 16 )) );
						newNBuckets =  ++ x;
					}
					
					if (( newNBuckets < 4 )) {
						newNBuckets = 4;
					}
					
					if (( this.size >= ( ( newNBuckets * 0.7 ) + 0.5 ) )) {
						j = 0;
					}
					 else {
						int nfSize = default(int);
						if (( newNBuckets < 16 )) {
							nfSize = 1;
						}
						 else {
							nfSize = ( newNBuckets >> 4 );
						}
						
						newFlags = new int[((int) (nfSize) )];
						{
							int _g = 0;
							while (( _g < ((int) (nfSize) ) )){
								int i = _g++;
								newFlags[i] = -1431655766;
							}
							
						}
						
						if (( this.nBuckets < newNBuckets )) {
							int[] k = new int[((int) (newNBuckets) )];
							if (( this._keys != default(int[]) )) {
								global::System.Array.Copy(((global::System.Array) (this._keys) ), ((int) (0) ), ((global::System.Array) (k) ), ((int) (0) ), ((int) (this.nBuckets) ));
							}
							
							this._keys = k;
							T[] v = new T[((int) (newNBuckets) )];
							if (( this.vals != default(T[]) )) {
								global::System.Array.Copy(((global::System.Array) (this.vals) ), ((int) (0) ), ((global::System.Array) (v) ), ((int) (0) ), ((int) (this.nBuckets) ));
							}
							
							this.vals = v;
						}
						
					}
					
				}
				
				if (( j != 0 )) {
					this.cachedKey = 0;
					this.cachedIndex = -1;
					j = -1;
					int nBuckets = this.nBuckets;
					int[] _keys = this._keys;
					T[] vals = this.vals;
					int[] flags = this.flags;
					int newMask = ( newNBuckets - 1 );
					while ((  ++ j < nBuckets )){
						if ( ! ((( (( ((int) (( ((uint) (flags[( j >> 4 )]) ) >> (( (( j & 15 )) << 1 )) )) ) & 3 )) != 0 ))) ) {
							int key = _keys[j];
							T val = vals[j];
							flags[( j >> 4 )] |= ( 1 << (( (( j & 15 )) << 1 )) );
							while (true){
								int k1 = key;
								int inc = ( (( ( ( k1 >> 3 ) ^ ( k1 << 3 ) ) | 1 )) & newMask );
								int i1 = ( k1 & newMask );
								while ( ! ((( (( ((int) (( ((uint) (newFlags[( i1 >> 4 )]) ) >> (( (( i1 & 15 )) << 1 )) )) ) & 2 )) != 0 ))) ){
									i1 = ( ( i1 + inc ) & newMask );
								}
								
								newFlags[( i1 >> 4 )] &=  ~ ((( 2 << (( (( i1 & 15 )) << 1 )) ))) ;
								if (( ( i1 < nBuckets ) &&  ! ((( (( ((int) (( ((uint) (flags[( i1 >> 4 )]) ) >> (( (( i1 & 15 )) << 1 )) )) ) & 3 )) != 0 )))  )) {
									{
										int tmp = _keys[i1];
										_keys[i1] = key;
										key = tmp;
									}
									
									{
										T tmp1 = vals[i1];
										vals[i1] = val;
										val = tmp1;
									}
									
									flags[( i1 >> 4 )] |= ( 1 << (( (( i1 & 15 )) << 1 )) );
								}
								 else {
									_keys[i1] = key;
									vals[i1] = val;
									break;
								}
								
							}
							
						}
						
					}
					
					if (( nBuckets > newNBuckets )) {
						{
							int[] k2 = new int[((int) (newNBuckets) )];
							global::System.Array.Copy(((global::System.Array) (_keys) ), ((int) (0) ), ((global::System.Array) (k2) ), ((int) (0) ), ((int) (newNBuckets) ));
							this._keys = k2;
						}
						
						{
							T[] v1 = new T[((int) (newNBuckets) )];
							global::System.Array.Copy(((global::System.Array) (vals) ), ((int) (0) ), ((global::System.Array) (v1) ), ((int) (0) ), ((int) (newNBuckets) ));
							this.vals = v1;
						}
						
					}
					
					this.flags = newFlags;
					this.nBuckets = newNBuckets;
					this.nOccupied = this.size;
					this.upperBound = ((int) (( ( newNBuckets * 0.7 ) + .5 )) );
				}
				
			}
		}
		
		
		public virtual   object keys(){
			unchecked {
				global::haxe.root.Array<object> _g1 = new global::haxe.root.Array<object>(new object[]{this});
				global::haxe.root.Array<int> i = new global::haxe.root.Array<int>(new int[]{0});
				global::haxe.root.Array<int> len = new global::haxe.root.Array<int>(new int[]{this.nBuckets});
				{
					global::haxe.lang.Function __temp_odecl640 = new global::haxe.ds.IntMap_keys_334__Fun<T>(((global::haxe.root.Array<int>) (len) ), ((global::haxe.root.Array<int>) (i) ), ((global::haxe.root.Array<object>) (_g1) ));
					global::haxe.lang.Function __temp_odecl641 = new global::haxe.ds.IntMap_keys_345__Fun<T>(((global::haxe.root.Array<int>) (i) ), ((global::haxe.root.Array<object>) (_g1) ));
					return new global::haxe.lang.DynamicObject(new global::haxe.root.Array<int>(new int[]{407283053, 1224901875}), new global::haxe.root.Array<object>(new object[]{__temp_odecl640, __temp_odecl641}), new global::haxe.root.Array<int>(new int[]{}), new global::haxe.root.Array<double>(new double[]{}));
				}
				
			}
		}
		
		
		public override   double __hx_setField_f(string field, int hash, double @value, bool handleProperties){
			unchecked {
				switch (hash){
					case 922671056:
					{
						this.cachedIndex = ((int) (@value) );
						return @value;
					}
					
					
					case 1395555037:
					{
						this.cachedKey = ((int) (@value) );
						return @value;
					}
					
					
					case 2022294396:
					{
						this.upperBound = ((int) (@value) );
						return @value;
					}
					
					
					case 480756972:
					{
						this.nOccupied = ((int) (@value) );
						return @value;
					}
					
					
					case 1280549057:
					{
						this.size = ((int) (@value) );
						return @value;
					}
					
					
					case 1537812987:
					{
						this.nBuckets = ((int) (@value) );
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
					case 922671056:
					{
						this.cachedIndex = ((int) (global::haxe.lang.Runtime.toInt(@value)) );
						return @value;
					}
					
					
					case 1395555037:
					{
						this.cachedKey = ((int) (global::haxe.lang.Runtime.toInt(@value)) );
						return @value;
					}
					
					
					case 2022294396:
					{
						this.upperBound = ((int) (global::haxe.lang.Runtime.toInt(@value)) );
						return @value;
					}
					
					
					case 480756972:
					{
						this.nOccupied = ((int) (global::haxe.lang.Runtime.toInt(@value)) );
						return @value;
					}
					
					
					case 1280549057:
					{
						this.size = ((int) (global::haxe.lang.Runtime.toInt(@value)) );
						return @value;
					}
					
					
					case 1537812987:
					{
						this.nBuckets = ((int) (global::haxe.lang.Runtime.toInt(@value)) );
						return @value;
					}
					
					
					case 1313416818:
					{
						this.vals = ((T[]) (@value) );
						return @value;
					}
					
					
					case 2048392659:
					{
						this._keys = ((int[]) (@value) );
						return @value;
					}
					
					
					case 42740551:
					{
						this.flags = ((int[]) (@value) );
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
					case 1191633396:
					{
						return ((global::haxe.lang.Function) (new global::haxe.lang.Closure(((object) (this) ), ((string) ("keys") ), ((int) (1191633396) ))) );
					}
					
					
					case 142301684:
					{
						return ((global::haxe.lang.Function) (new global::haxe.lang.Closure(((object) (this) ), ((string) ("resize") ), ((int) (142301684) ))) );
					}
					
					
					case 76061764:
					{
						return ((global::haxe.lang.Function) (new global::haxe.lang.Closure(((object) (this) ), ((string) ("remove") ), ((int) (76061764) ))) );
					}
					
					
					case 1071652316:
					{
						return ((global::haxe.lang.Function) (new global::haxe.lang.Closure(((object) (this) ), ((string) ("exists") ), ((int) (1071652316) ))) );
					}
					
					
					case 5144726:
					{
						return ((global::haxe.lang.Function) (new global::haxe.lang.Closure(((object) (this) ), ((string) ("get") ), ((int) (5144726) ))) );
					}
					
					
					case 1639293562:
					{
						return ((global::haxe.lang.Function) (new global::haxe.lang.Closure(((object) (this) ), ((string) ("lookup") ), ((int) (1639293562) ))) );
					}
					
					
					case 5741474:
					{
						return ((global::haxe.lang.Function) (new global::haxe.lang.Closure(((object) (this) ), ((string) ("set") ), ((int) (5741474) ))) );
					}
					
					
					case 922671056:
					{
						return this.cachedIndex;
					}
					
					
					case 1395555037:
					{
						return this.cachedKey;
					}
					
					
					case 2022294396:
					{
						return this.upperBound;
					}
					
					
					case 480756972:
					{
						return this.nOccupied;
					}
					
					
					case 1280549057:
					{
						return this.size;
					}
					
					
					case 1537812987:
					{
						return this.nBuckets;
					}
					
					
					case 1313416818:
					{
						return this.vals;
					}
					
					
					case 2048392659:
					{
						return this._keys;
					}
					
					
					case 42740551:
					{
						return this.flags;
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
					case 922671056:
					{
						return ((double) (this.cachedIndex) );
					}
					
					
					case 1395555037:
					{
						return ((double) (this.cachedKey) );
					}
					
					
					case 2022294396:
					{
						return ((double) (this.upperBound) );
					}
					
					
					case 480756972:
					{
						return ((double) (this.nOccupied) );
					}
					
					
					case 1280549057:
					{
						return ((double) (this.size) );
					}
					
					
					case 1537812987:
					{
						return ((double) (this.nBuckets) );
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
					case 1191633396:
					{
						return this.keys();
					}
					
					
					case 142301684:
					{
						this.resize(((int) (global::haxe.lang.Runtime.toInt(dynargs[0])) ));
						break;
					}
					
					
					case 76061764:
					{
						return this.@remove(((int) (global::haxe.lang.Runtime.toInt(dynargs[0])) ));
					}
					
					
					case 1071652316:
					{
						return this.exists(((int) (global::haxe.lang.Runtime.toInt(dynargs[0])) ));
					}
					
					
					case 5144726:
					{
						return (this.@get(((int) (global::haxe.lang.Runtime.toInt(dynargs[0])) ))).toDynamic();
					}
					
					
					case 1639293562:
					{
						return this.lookup(((int) (global::haxe.lang.Runtime.toInt(dynargs[0])) ));
					}
					
					
					case 5741474:
					{
						this.@set(((int) (global::haxe.lang.Runtime.toInt(dynargs[0])) ), global::haxe.lang.Runtime.genericCast<T>(dynargs[1]));
						break;
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
				baseArr.push("cachedIndex");
				baseArr.push("cachedKey");
				baseArr.push("upperBound");
				baseArr.push("nOccupied");
				baseArr.push("size");
				baseArr.push("nBuckets");
				baseArr.push("vals");
				baseArr.push("_keys");
				baseArr.push("flags");
				{
					base.__hx_getFields(baseArr);
				}
				
			}
		}
		
		
	}
}



#pragma warning disable 109, 114, 219, 429, 168, 162
namespace haxe.ds{
	public  class IntMap_keys_334__Fun<T> : global::haxe.lang.Function {
		public    IntMap_keys_334__Fun(global::haxe.root.Array<int> len, global::haxe.root.Array<int> i, global::haxe.root.Array<object> _g1) : base(0, 0){
			unchecked {
				this.len = len;
				this.i = i;
				this._g1 = _g1;
			}
		}
		
		
		public override   object __hx_invoke0_o(){
			unchecked {
				{
					int _g = this.i[0];
					while (( _g < ((int) (this.len[0]) ) )){
						int j = _g++;
						if ( ! ((( (( ((int) (( ((uint) (((global::haxe.ds.IntMap<T>) (global::haxe.ds.IntMap<object>.__hx_cast<T>(((global::haxe.ds.IntMap) (this._g1[0]) ))) ).flags[( j >> 4 )]) ) >> (( (( j & 15 )) << 1 )) )) ) & 3 )) != 0 ))) ) {
							this.i[0] = j;
							return true;
						}
						
					}
					
				}
				
				return false;
			}
		}
		
		
		public  global::haxe.root.Array<int> len;
		
		public  global::haxe.root.Array<int> i;
		
		public  global::haxe.root.Array<object> _g1;
		
	}
}



#pragma warning disable 109, 114, 219, 429, 168, 162
namespace haxe.ds{
	public  class IntMap_keys_345__Fun<T> : global::haxe.lang.Function {
		public    IntMap_keys_345__Fun(global::haxe.root.Array<int> i, global::haxe.root.Array<object> _g1) : base(0, 1){
			unchecked {
				this.i = i;
				this._g1 = _g1;
			}
		}
		
		
		public override   double __hx_invoke0_f(){
			unchecked {
				int ret = ((global::haxe.ds.IntMap<T>) (global::haxe.ds.IntMap<object>.__hx_cast<T>(((global::haxe.ds.IntMap) (this._g1[0]) ))) )._keys[this.i[0]];
				((global::haxe.ds.IntMap<T>) (global::haxe.ds.IntMap<object>.__hx_cast<T>(((global::haxe.ds.IntMap) (this._g1[0]) ))) ).cachedIndex = this.i[0];
				((global::haxe.ds.IntMap<T>) (global::haxe.ds.IntMap<object>.__hx_cast<T>(((global::haxe.ds.IntMap) (this._g1[0]) ))) ).cachedKey = ret;
				this.i[0] = ( this.i[0] + 1 );
				return ((double) (ret) );
			}
		}
		
		
		public  global::haxe.root.Array<int> i;
		
		public  global::haxe.root.Array<object> _g1;
		
	}
}



#pragma warning disable 109, 114, 219, 429, 168, 162
namespace haxe.ds{
	public  interface IntMap : global::haxe.lang.IHxObject, global::haxe.lang.IGenericObject {
		   object haxe_ds_IntMap_cast<T_c>();
		
	}
}


