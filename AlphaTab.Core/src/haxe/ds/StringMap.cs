using haxe.root;
#pragma warning disable 109, 114, 219, 429, 168, 162
namespace haxe.ds
{
	public  class StringMap<T> : global::haxe.lang.HxObject, global::haxe.ds.StringMap, global::haxe.root.IMap<object, T> 
	{
		public    StringMap(global::haxe.lang.EmptyObject empty)
		{
			unchecked 
			{
				{
				}
				
			}
		}
		
		
		public    StringMap()
		{
			unchecked 
			{
				global::haxe.ds.StringMap<object>.__hx_ctor_haxe_ds_StringMap<T>(this);
			}
		}
		
		
		public static   void __hx_ctor_haxe_ds_StringMap<T_c>(global::haxe.ds.StringMap<T_c> __temp_me15)
		{
			unchecked 
			{
				__temp_me15.cachedIndex = -1;
			}
		}
		
		
		public static   object __hx_cast<T_c_c>(global::haxe.ds.StringMap me)
		{
			unchecked 
			{
				return ( (( me != default(global::haxe.ds.StringMap) )) ? (me.haxe_ds_StringMap_cast<T_c_c>()) : (default(global::haxe.ds.StringMap)) );
			}
		}
		
		
		public static  new object __hx_createEmpty()
		{
			unchecked 
			{
				return new global::haxe.ds.StringMap<object>(((global::haxe.lang.EmptyObject) (global::haxe.lang.EmptyObject.EMPTY) ));
			}
		}
		
		
		public static  new object __hx_create(global::haxe.root.Array arr)
		{
			unchecked 
			{
				return new global::haxe.ds.StringMap<object>();
			}
		}
		
		
		public virtual   object haxe_ds_StringMap_cast<T_c>()
		{
			unchecked 
			{
				if (global::haxe.lang.Runtime.eq(typeof(T), typeof(T_c))) 
				{
					return this;
				}
				
				global::haxe.ds.StringMap<T_c> new_me = new global::haxe.ds.StringMap<T_c>(((global::haxe.lang.EmptyObject) (global::haxe.lang.EmptyObject.EMPTY) ));
				{
					object __temp_iterator303 = global::haxe.root.Reflect.fields(this).iterator();
					while (((bool) (global::haxe.lang.Runtime.callField(__temp_iterator303, "hasNext", 407283053, default(global::haxe.root.Array))) ))
					{
						string field = global::haxe.lang.Runtime.toString(global::haxe.lang.Runtime.callField(__temp_iterator303, "next", 1224901875, default(global::haxe.root.Array)));
						switch (field)
						{
							case "vals":
							{
								{
									T_c[] __temp_new_arr12 = new T_c[((int) (this.vals.Length) )];
									int __temp_i13 = -1;
									while ((  ++ __temp_i13 < this.vals.Length ))
									{
										object __temp_obj14 = ((object) (this.vals[__temp_i13]) );
										if ( ! (global::haxe.lang.Runtime.eq(__temp_obj14, default(T[]))) ) 
										{
											__temp_new_arr12[__temp_i13] = global::haxe.lang.Runtime.genericCast<T_c>(__temp_obj14);
										}
										
									}
									
									new_me.vals = __temp_new_arr12;
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
		
		
		public virtual   object IMap_cast<K_c, V_c>()
		{
			unchecked 
			{
				return this.haxe_ds_StringMap_cast<V_c>();
			}
		}
		
		
		public  int[] hashes;
		
		public  string[] _keys;
		
		public  T[] vals;
		
		public  int nBuckets;
		
		public  int size;
		
		public  int nOccupied;
		
		public  int upperBound;
		
		public  string cachedKey;
		
		public  int cachedIndex;
		
		public virtual   void @set(string key, T @value)
		{
			unchecked 
			{
				int x = default(int);
				int k = default(int);
				if (( this.nOccupied >= this.upperBound )) 
				{
					if (( this.nBuckets > ( this.size << 1 ) )) 
					{
						this.resize(( this.nBuckets - 1 ));
					}
					 else 
					{
						this.resize(( this.nBuckets + 2 ));
					}
					
				}
				
				int[] hashes = this.hashes;
				string[] keys = this._keys;
				int[] hashes1 = hashes;
				{
					int mask = default(int);
					if (( this.nBuckets == 0 )) 
					{
						mask = 0;
					}
					 else 
					{
						mask = ( this.nBuckets - 1 );
					}
					
					int site = x = this.nBuckets;
					{
						int k1 = key.GetHashCode();
						k1 = ( ( k1 + 2127912214 ) + (( k1 << 12 )) );
						k1 = ( ( k1 ^ -949894596 ) ^ ( k1 >> 19 ) );
						k1 = ( ( k1 + 374761393 ) + (( k1 << 5 )) );
						k1 = ( ( k1 + -744332180 ) ^ ( k1 << 9 ) );
						k1 = ( ( k1 + -42973499 ) + (( k1 << 3 )) );
						k1 = ( ( k1 ^ -1252372727 ) ^ ( k1 >> 16 ) );
						int ret = k1;
						if (( (( ret & -2 )) == 0 )) 
						{
							if (( ret == 0 )) 
							{
								ret = 2;
							}
							 else 
							{
								ret = -1;
							}
							
						}
						
						k = ret;
					}
					
					int i = ( k & mask );
					int nProbes = 0;
					if (( (( hashes1[i] & -2 )) == 0 )) 
					{
						x = i;
					}
					 else 
					{
						int last = i;
						int flag = default(int);
						do 
						{
							bool __temp_stmt460 = default(bool);
							{
								int v = flag = hashes1[i];
								__temp_stmt460 = ( (( v & -2 )) == 0 );
							}
							
							bool __temp_boolv461 = false;
							if ( ! (__temp_stmt460) ) 
							{
								__temp_boolv461 = ( ( flag == k ) && string.Equals(this._keys[i], key) );
							}
							
							bool __temp_stmt459 = ( __temp_stmt460 || __temp_boolv461 );
							if ( ! ((__temp_stmt459)) ) 
							{
								i = ( ( i +  ++ nProbes ) & mask );
							}
							 else 
							{
								break;
							}
							
						}
						while (true);
						x = i;
					}
					
				}
				
				int flag1 = hashes1[x];
				if (( flag1 == 0 )) 
				{
					keys[x] = key;
					this.vals[x] = @value;
					hashes1[x] = k;
					this.size++;
					this.nOccupied++;
				}
				 else 
				{
					if (( flag1 == 1 )) 
					{
						keys[x] = key;
						this.vals[x] = @value;
						hashes1[x] = k;
						this.size++;
					}
					 else 
					{
						this.vals[x] = @value;
					}
					
				}
				
				this.cachedIndex = x;
				this.cachedKey = key;
			}
		}
		
		
		public   int lookup(string key)
		{
			unchecked 
			{
				if (( this.nBuckets != 0 )) 
				{
					int[] hashes = this.hashes;
					string[] keys = this._keys;
					int mask = ( this.nBuckets - 1 );
					int hash = default(int);
					{
						int k = key.GetHashCode();
						k = ( ( k + 2127912214 ) + (( k << 12 )) );
						k = ( ( k ^ -949894596 ) ^ ( k >> 19 ) );
						k = ( ( k + 374761393 ) + (( k << 5 )) );
						k = ( ( k + -744332180 ) ^ ( k << 9 ) );
						k = ( ( k + -42973499 ) + (( k << 3 )) );
						k = ( ( k ^ -1252372727 ) ^ ( k >> 16 ) );
						int ret = k;
						if (( (( ret & -2 )) == 0 )) 
						{
							if (( ret == 0 )) 
							{
								ret = 2;
							}
							 else 
							{
								ret = -1;
							}
							
						}
						
						hash = ret;
					}
					
					int k1 = hash;
					int nProbes = 0;
					int i = ( k1 & mask );
					int last = i;
					int flag = default(int);
					do 
					{
						bool __temp_stmt465 = default(bool);
						{
							int v = flag = hashes[i];
							__temp_stmt465 = ( v == 0 );
						}
						
						bool __temp_boolv464 =  ! (__temp_stmt465) ;
						bool __temp_boolv463 = false;
						if (__temp_boolv464) 
						{
							__temp_boolv463 = (( ( ( flag == 1 ) || ( flag != k1 ) ) ||  ! (string.Equals(keys[i], key))  ));
						}
						
						bool __temp_stmt462 = ( __temp_boolv464 && __temp_boolv463 );
						if (__temp_stmt462) 
						{
							i = ( ( i +  ++ nProbes ) & mask );
						}
						 else 
						{
							break;
						}
						
					}
					while (true);
					if (( (( flag & -2 )) == 0 )) 
					{
						return -1;
					}
					 else 
					{
						return i;
					}
					
				}
				
				return -1;
			}
		}
		
		
		public   void resize(int newNBuckets)
		{
			unchecked 
			{
				int[] newHash = default(int[]);
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
					
					if (( newNBuckets < 4 )) 
					{
						newNBuckets = 4;
					}
					
					if (( this.size >= ( ( newNBuckets * 0.77 ) + 0.5 ) )) 
					{
						j = 0;
					}
					 else 
					{
						int nfSize = newNBuckets;
						newHash = new int[((int) (nfSize) )];
						if (( this.nBuckets < newNBuckets )) 
						{
							string[] k = new string[((int) (newNBuckets) )];
							if (( this._keys != default(string[]) )) 
							{
								global::System.Array.Copy(((global::System.Array) (this._keys) ), ((int) (0) ), ((global::System.Array) (k) ), ((int) (0) ), ((int) (this.nBuckets) ));
							}
							
							this._keys = k;
							T[] v = new T[((int) (newNBuckets) )];
							if (( this.vals != default(T[]) )) 
							{
								global::System.Array.Copy(((global::System.Array) (this.vals) ), ((int) (0) ), ((global::System.Array) (v) ), ((int) (0) ), ((int) (this.nBuckets) ));
							}
							
							this.vals = v;
						}
						
					}
					
				}
				
				if (( j != 0 )) 
				{
					this.cachedKey = default(string);
					this.cachedIndex = -1;
					j = -1;
					int nBuckets = this.nBuckets;
					string[] _keys = this._keys;
					T[] vals = this.vals;
					int[] hashes = this.hashes;
					int newMask = ( newNBuckets - 1 );
					while ((  ++ j < nBuckets ))
					{
						int k1 = default(int);
						bool __temp_stmt466 = default(bool);
						{
							int v1 = k1 = hashes[j];
							__temp_stmt466 = ( (( v1 & -2 )) == 0 );
						}
						
						if ( ! (__temp_stmt466) ) 
						{
							string key = _keys[j];
							T val = vals[j];
							hashes[j] = 1;
							while (true)
							{
								int nProbes = 0;
								int i = ( k1 & newMask );
								while ( ! ((( newHash[i] == 0 ))) )
								{
									i = ( ( i +  ++ nProbes ) & newMask );
								}
								
								newHash[i] = k1;
								bool __temp_boolv469 = ( i < nBuckets );
								bool __temp_boolv468 = false;
								if (__temp_boolv469) 
								{
									bool __temp_stmt470 = default(bool);
									{
										int v2 = k1 = hashes[i];
										__temp_stmt470 = ( (( v2 & -2 )) == 0 );
									}
									
									__temp_boolv468 =  ! (__temp_stmt470) ;
								}
								
								bool __temp_stmt467 = ( __temp_boolv469 && __temp_boolv468 );
								if (__temp_stmt467) 
								{
									{
										string tmp = _keys[i];
										_keys[i] = key;
										key = tmp;
									}
									
									{
										T tmp1 = vals[i];
										vals[i] = val;
										val = tmp1;
									}
									
									hashes[i] = 1;
								}
								 else 
								{
									_keys[i] = key;
									vals[i] = val;
									break;
								}
								
							}
							
						}
						
					}
					
					if (( nBuckets > newNBuckets )) 
					{
						{
							string[] k2 = new string[((int) (newNBuckets) )];
							global::System.Array.Copy(((global::System.Array) (_keys) ), ((int) (0) ), ((global::System.Array) (k2) ), ((int) (0) ), ((int) (newNBuckets) ));
							this._keys = k2;
						}
						
						{
							T[] v3 = new T[((int) (newNBuckets) )];
							global::System.Array.Copy(((global::System.Array) (vals) ), ((int) (0) ), ((global::System.Array) (v3) ), ((int) (0) ), ((int) (newNBuckets) ));
							this.vals = v3;
						}
						
					}
					
					this.hashes = newHash;
					this.nBuckets = newNBuckets;
					this.nOccupied = this.size;
					this.upperBound = ((int) (( ( newNBuckets * 0.77 ) + .5 )) );
				}
				
			}
		}
		
		
		public virtual   global::haxe.lang.Null<T> @get(string key)
		{
			unchecked 
			{
				int idx = -1;
				if (( string.Equals(this.cachedKey, key) && ( (idx = this.cachedIndex) != -1 ) )) 
				{
					return new global::haxe.lang.Null<T>(this.vals[idx], true);
				}
				
				idx = this.lookup(key);
				if (( idx != -1 )) 
				{
					this.cachedKey = key;
					this.cachedIndex = idx;
					return new global::haxe.lang.Null<T>(this.vals[idx], true);
				}
				
				return default(global::haxe.lang.Null<T>);
			}
		}
		
		
		public virtual   bool exists(string key)
		{
			unchecked 
			{
				int idx = -1;
				if (( string.Equals(this.cachedKey, key) && ( (idx = this.cachedIndex) != -1 ) )) 
				{
					return true;
				}
				
				idx = this.lookup(key);
				if (( idx != -1 )) 
				{
					this.cachedKey = key;
					this.cachedIndex = idx;
					return true;
				}
				
				return false;
			}
		}
		
		
		public virtual   object keys()
		{
			unchecked 
			{
				global::haxe.root.Array<object> _g1 = new global::haxe.root.Array<object>(new object[]{this});
				global::haxe.root.Array<int> i = new global::haxe.root.Array<int>(new int[]{0});
				global::haxe.root.Array<int> len = new global::haxe.root.Array<int>(new int[]{this.nBuckets});
				{
					global::haxe.lang.Function __temp_odecl471 = new global::haxe.ds.StringMap_keys_356__Fun<T>(((global::haxe.root.Array<int>) (global::haxe.root.Array<object>.__hx_cast<int>(((global::haxe.root.Array) (len) ))) ), ((global::haxe.root.Array<int>) (global::haxe.root.Array<object>.__hx_cast<int>(((global::haxe.root.Array) (i) ))) ), ((global::haxe.root.Array<object>) (global::haxe.root.Array<object>.__hx_cast<object>(((global::haxe.root.Array) (_g1) ))) ));
					global::haxe.lang.Function __temp_odecl472 = new global::haxe.ds.StringMap_keys_367__Fun<T>(((global::haxe.root.Array<int>) (global::haxe.root.Array<object>.__hx_cast<int>(((global::haxe.root.Array) (i) ))) ), ((global::haxe.root.Array<object>) (global::haxe.root.Array<object>.__hx_cast<object>(((global::haxe.root.Array) (_g1) ))) ));
					return new global::haxe.lang.DynamicObject(new global::haxe.root.Array<int>(new int[]{407283053, 1224901875}), new global::haxe.root.Array<object>(new object[]{__temp_odecl471, __temp_odecl472}), new global::haxe.root.Array<int>(new int[]{}), new global::haxe.root.Array<double>(new double[]{}));
				}
				
			}
		}
		
		
		public virtual   object iterator()
		{
			unchecked 
			{
				global::haxe.root.Array<object> _g1 = new global::haxe.root.Array<object>(new object[]{this});
				global::haxe.root.Array<int> i = new global::haxe.root.Array<int>(new int[]{0});
				global::haxe.root.Array<int> len = new global::haxe.root.Array<int>(new int[]{this.nBuckets});
				{
					global::haxe.lang.Function __temp_odecl473 = new global::haxe.ds.StringMap_iterator_387__Fun<T>(((global::haxe.root.Array<int>) (global::haxe.root.Array<object>.__hx_cast<int>(((global::haxe.root.Array) (len) ))) ), ((global::haxe.root.Array<object>) (global::haxe.root.Array<object>.__hx_cast<object>(((global::haxe.root.Array) (_g1) ))) ), ((global::haxe.root.Array<int>) (global::haxe.root.Array<object>.__hx_cast<int>(((global::haxe.root.Array) (i) ))) ));
					global::haxe.lang.Function __temp_odecl474 = new global::haxe.ds.StringMap_iterator_398__Fun<T>(((global::haxe.root.Array<object>) (global::haxe.root.Array<object>.__hx_cast<object>(((global::haxe.root.Array) (_g1) ))) ), ((global::haxe.root.Array<int>) (global::haxe.root.Array<object>.__hx_cast<int>(((global::haxe.root.Array) (i) ))) ));
					return new global::haxe.lang.DynamicObject(new global::haxe.root.Array<int>(new int[]{407283053, 1224901875}), new global::haxe.root.Array<object>(new object[]{__temp_odecl473, __temp_odecl474}), new global::haxe.root.Array<int>(new int[]{}), new global::haxe.root.Array<double>(new double[]{}));
				}
				
			}
		}
		
		
		public override   double __hx_setField_f(string field, int hash, double @value, bool handleProperties)
		{
			unchecked 
			{
				switch (hash)
				{
					case 922671056:
					{
						this.cachedIndex = ((int) (@value) );
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
		
		
		public override   object __hx_setField(string field, int hash, object @value, bool handleProperties)
		{
			unchecked 
			{
				switch (hash)
				{
					case 922671056:
					{
						this.cachedIndex = ((int) (global::haxe.lang.Runtime.toInt(@value)) );
						return @value;
					}
					
					
					case 1395555037:
					{
						this.cachedKey = global::haxe.lang.Runtime.toString(@value);
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
						this._keys = ((string[]) (@value) );
						return @value;
					}
					
					
					case 995006396:
					{
						this.hashes = ((int[]) (@value) );
						return @value;
					}
					
					
					default:
					{
						return base.__hx_setField(field, hash, @value, handleProperties);
					}
					
				}
				
			}
		}
		
		
		public override   object __hx_getField(string field, int hash, bool throwErrors, bool isCheck, bool handleProperties)
		{
			unchecked 
			{
				switch (hash)
				{
					case 328878574:
					{
						return ((global::haxe.lang.Function) (new global::haxe.lang.Closure(((object) (this) ), global::haxe.lang.Runtime.toString("iterator"), ((int) (328878574) ))) );
					}
					
					
					case 1191633396:
					{
						return ((global::haxe.lang.Function) (new global::haxe.lang.Closure(((object) (this) ), global::haxe.lang.Runtime.toString("keys"), ((int) (1191633396) ))) );
					}
					
					
					case 1071652316:
					{
						return ((global::haxe.lang.Function) (new global::haxe.lang.Closure(((object) (this) ), global::haxe.lang.Runtime.toString("exists"), ((int) (1071652316) ))) );
					}
					
					
					case 5144726:
					{
						return ((global::haxe.lang.Function) (new global::haxe.lang.Closure(((object) (this) ), global::haxe.lang.Runtime.toString("get"), ((int) (5144726) ))) );
					}
					
					
					case 142301684:
					{
						return ((global::haxe.lang.Function) (new global::haxe.lang.Closure(((object) (this) ), global::haxe.lang.Runtime.toString("resize"), ((int) (142301684) ))) );
					}
					
					
					case 1639293562:
					{
						return ((global::haxe.lang.Function) (new global::haxe.lang.Closure(((object) (this) ), global::haxe.lang.Runtime.toString("lookup"), ((int) (1639293562) ))) );
					}
					
					
					case 5741474:
					{
						return ((global::haxe.lang.Function) (new global::haxe.lang.Closure(((object) (this) ), global::haxe.lang.Runtime.toString("set"), ((int) (5741474) ))) );
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
					
					
					case 995006396:
					{
						return this.hashes;
					}
					
					
					default:
					{
						return base.__hx_getField(field, hash, throwErrors, isCheck, handleProperties);
					}
					
				}
				
			}
		}
		
		
		public override   double __hx_getField_f(string field, int hash, bool throwErrors, bool handleProperties)
		{
			unchecked 
			{
				switch (hash)
				{
					case 922671056:
					{
						return ((double) (this.cachedIndex) );
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
		
		
		public override   object __hx_invokeField(string field, int hash, global::haxe.root.Array dynargs)
		{
			unchecked 
			{
				switch (hash)
				{
					case 328878574:
					{
						return this.iterator();
					}
					
					
					case 1191633396:
					{
						return this.keys();
					}
					
					
					case 1071652316:
					{
						return this.exists(global::haxe.lang.Runtime.toString(dynargs[0]));
					}
					
					
					case 5144726:
					{
						return (this.@get(global::haxe.lang.Runtime.toString(dynargs[0]))).toDynamic();
					}
					
					
					case 142301684:
					{
						this.resize(((int) (global::haxe.lang.Runtime.toInt(dynargs[0])) ));
						break;
					}
					
					
					case 1639293562:
					{
						return this.lookup(global::haxe.lang.Runtime.toString(dynargs[0]));
					}
					
					
					case 5741474:
					{
						this.@set(global::haxe.lang.Runtime.toString(dynargs[0]), global::haxe.lang.Runtime.genericCast<T>(dynargs[1]));
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
		
		
		public override   void __hx_getFields(global::haxe.root.Array<object> baseArr)
		{
			unchecked 
			{
				baseArr.push("cachedIndex");
				baseArr.push("cachedKey");
				baseArr.push("upperBound");
				baseArr.push("nOccupied");
				baseArr.push("size");
				baseArr.push("nBuckets");
				baseArr.push("vals");
				baseArr.push("_keys");
				baseArr.push("hashes");
				{
					base.__hx_getFields(baseArr);
				}
				
			}
		}
		
		
	}
}



#pragma warning disable 109, 114, 219, 429, 168, 162
namespace haxe.ds
{
	public  class StringMap_keys_356__Fun<T> : global::haxe.lang.Function 
	{
		public    StringMap_keys_356__Fun(global::haxe.root.Array<int> len, global::haxe.root.Array<int> i, global::haxe.root.Array<object> _g1) : base(0, 0)
		{
			unchecked 
			{
				this.len = len;
				this.i = i;
				this._g1 = _g1;
			}
		}
		
		
		public override   object __hx_invoke0_o()
		{
			unchecked 
			{
				{
					int _g = this.i[0];
					while (( _g < ((int) (this.len[0]) ) ))
					{
						int j = _g++;
						if ( ! ((( (( ((global::haxe.ds.StringMap<T>) (global::haxe.ds.StringMap<object>.__hx_cast<T>(((global::haxe.ds.StringMap) (this._g1[0]) ))) ).hashes[j] & -2 )) == 0 ))) ) 
						{
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
namespace haxe.ds
{
	public  class StringMap_keys_367__Fun<T> : global::haxe.lang.Function 
	{
		public    StringMap_keys_367__Fun(global::haxe.root.Array<int> i, global::haxe.root.Array<object> _g1) : base(0, 0)
		{
			unchecked 
			{
				this.i = i;
				this._g1 = _g1;
			}
		}
		
		
		public override   object __hx_invoke0_o()
		{
			unchecked 
			{
				string ret = ((global::haxe.ds.StringMap<T>) (global::haxe.ds.StringMap<object>.__hx_cast<T>(((global::haxe.ds.StringMap) (this._g1[0]) ))) )._keys[this.i[0]];
				((global::haxe.ds.StringMap<T>) (global::haxe.ds.StringMap<object>.__hx_cast<T>(((global::haxe.ds.StringMap) (this._g1[0]) ))) ).cachedIndex = this.i[0];
				((global::haxe.ds.StringMap<T>) (global::haxe.ds.StringMap<object>.__hx_cast<T>(((global::haxe.ds.StringMap) (this._g1[0]) ))) ).cachedKey = ret;
				this.i[0] = ( this.i[0] + 1 );
				return ret;
			}
		}
		
		
		public  global::haxe.root.Array<int> i;
		
		public  global::haxe.root.Array<object> _g1;
		
	}
}



#pragma warning disable 109, 114, 219, 429, 168, 162
namespace haxe.ds
{
	public  class StringMap_iterator_387__Fun<T> : global::haxe.lang.Function 
	{
		public    StringMap_iterator_387__Fun(global::haxe.root.Array<int> len, global::haxe.root.Array<object> _g1, global::haxe.root.Array<int> i) : base(0, 0)
		{
			unchecked 
			{
				this.len = len;
				this._g1 = _g1;
				this.i = i;
			}
		}
		
		
		public override   object __hx_invoke0_o()
		{
			unchecked 
			{
				{
					int _g = this.i[0];
					while (( _g < ((int) (this.len[0]) ) ))
					{
						int j = _g++;
						if ( ! ((( (( ((global::haxe.ds.StringMap<T>) (global::haxe.ds.StringMap<object>.__hx_cast<T>(((global::haxe.ds.StringMap) (this._g1[0]) ))) ).hashes[j] & -2 )) == 0 ))) ) 
						{
							this.i[0] = j;
							return true;
						}
						
					}
					
				}
				
				return false;
			}
		}
		
		
		public  global::haxe.root.Array<int> len;
		
		public  global::haxe.root.Array<object> _g1;
		
		public  global::haxe.root.Array<int> i;
		
	}
}



#pragma warning disable 109, 114, 219, 429, 168, 162
namespace haxe.ds
{
	public  class StringMap_iterator_398__Fun<T> : global::haxe.lang.Function 
	{
		public    StringMap_iterator_398__Fun(global::haxe.root.Array<object> _g1, global::haxe.root.Array<int> i) : base(0, 0)
		{
			unchecked 
			{
				this._g1 = _g1;
				this.i = i;
			}
		}
		
		
		public override   object __hx_invoke0_o()
		{
			unchecked 
			{
				T ret = ((global::haxe.ds.StringMap<T>) (global::haxe.ds.StringMap<object>.__hx_cast<T>(((global::haxe.ds.StringMap) (this._g1[0]) ))) ).vals[this.i[0]];
				this.i[0] = ( this.i[0] + 1 );
				return ret;
			}
		}
		
		
		public  global::haxe.root.Array<object> _g1;
		
		public  global::haxe.root.Array<int> i;
		
	}
}



#pragma warning disable 109, 114, 219, 429, 168, 162
namespace haxe.ds
{
	public  interface StringMap : global::haxe.lang.IHxObject, global::haxe.lang.IGenericObject 
	{
		   object haxe_ds_StringMap_cast<T_c>();
		
	}
}


