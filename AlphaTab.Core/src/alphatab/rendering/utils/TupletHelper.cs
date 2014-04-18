using haxe.root;
#pragma warning disable 109, 114, 219, 429, 168, 162
namespace alphatab.rendering.utils
{
	public  class TupletHelper : global::haxe.lang.HxObject 
	{
		public    TupletHelper(global::haxe.lang.EmptyObject empty)
		{
			unchecked 
			{
				{
				}
				
			}
		}
		
		
		public    TupletHelper(int voice)
		{
			unchecked 
			{
				global::alphatab.rendering.utils.TupletHelper.__hx_ctor_alphatab_rendering_utils_TupletHelper(this, voice);
			}
		}
		
		
		public static   void __hx_ctor_alphatab_rendering_utils_TupletHelper(global::alphatab.rendering.utils.TupletHelper __temp_me272, int voice)
		{
			unchecked 
			{
				__temp_me272.voiceIndex = voice;
				__temp_me272.beats = new global::haxe.root.Array<object>();
			}
		}
		
		
		public static  new object __hx_createEmpty()
		{
			unchecked 
			{
				return new global::alphatab.rendering.utils.TupletHelper(((global::haxe.lang.EmptyObject) (global::haxe.lang.EmptyObject.EMPTY) ));
			}
		}
		
		
		public static  new object __hx_create(global::haxe.root.Array arr)
		{
			unchecked 
			{
				return new global::alphatab.rendering.utils.TupletHelper(((int) (global::haxe.lang.Runtime.toInt(arr[0])) ));
			}
		}
		
		
		public  global::haxe.root.Array<object> beats;
		
		public  int voiceIndex;
		
		public  int tuplet;
		
		public  bool _isFinished;
		
		public   bool isFull()
		{
			unchecked 
			{
				return ( this.beats.length == this.tuplet );
			}
		}
		
		
		public virtual   void finish()
		{
			unchecked 
			{
				this._isFinished = true;
			}
		}
		
		
		public virtual   bool check(global::alphatab.model.Beat beat)
		{
			unchecked 
			{
				if (( this.beats.length == 0 )) 
				{
					this.tuplet = beat.tupletNumerator;
				}
				 else 
				{
					if (( ( ( ( beat.voice.index != this.voiceIndex ) || ( beat.tupletNumerator != this.tuplet ) ) || ( this.beats.length == this.tuplet ) ) || this._isFinished )) 
					{
						return false;
					}
					
				}
				
				this.beats.push(beat);
				return true;
			}
		}
		
		
		public override   double __hx_setField_f(string field, int hash, double @value, bool handleProperties)
		{
			unchecked 
			{
				switch (hash)
				{
					case 161606508:
					{
						this.tuplet = ((int) (@value) );
						return @value;
					}
					
					
					case 1456144384:
					{
						this.voiceIndex = ((int) (@value) );
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
					case 1648849563:
					{
						this._isFinished = ((bool) (@value) );
						return @value;
					}
					
					
					case 161606508:
					{
						this.tuplet = ((int) (global::haxe.lang.Runtime.toInt(@value)) );
						return @value;
					}
					
					
					case 1456144384:
					{
						this.voiceIndex = ((int) (global::haxe.lang.Runtime.toInt(@value)) );
						return @value;
					}
					
					
					case 810640957:
					{
						this.beats = ((global::haxe.root.Array<object>) (global::haxe.root.Array<object>.__hx_cast<object>(((global::haxe.root.Array) (@value) ))) );
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
					case 1169594568:
					{
						return ((global::haxe.lang.Function) (new global::haxe.lang.Closure(((object) (this) ), global::haxe.lang.Runtime.toString("check"), ((int) (1169594568) ))) );
					}
					
					
					case 109002835:
					{
						return ((global::haxe.lang.Function) (new global::haxe.lang.Closure(((object) (this) ), global::haxe.lang.Runtime.toString("finish"), ((int) (109002835) ))) );
					}
					
					
					case 1630252697:
					{
						return ((global::haxe.lang.Function) (new global::haxe.lang.Closure(((object) (this) ), global::haxe.lang.Runtime.toString("isFull"), ((int) (1630252697) ))) );
					}
					
					
					case 1648849563:
					{
						return this._isFinished;
					}
					
					
					case 161606508:
					{
						return this.tuplet;
					}
					
					
					case 1456144384:
					{
						return this.voiceIndex;
					}
					
					
					case 810640957:
					{
						return this.beats;
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
					case 161606508:
					{
						return ((double) (this.tuplet) );
					}
					
					
					case 1456144384:
					{
						return ((double) (this.voiceIndex) );
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
					case 1169594568:
					{
						return this.check(((global::alphatab.model.Beat) (dynargs[0]) ));
					}
					
					
					case 109002835:
					{
						this.finish();
						break;
					}
					
					
					case 1630252697:
					{
						return this.isFull();
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
				baseArr.push("_isFinished");
				baseArr.push("tuplet");
				baseArr.push("voiceIndex");
				baseArr.push("beats");
				{
					base.__hx_getFields(baseArr);
				}
				
			}
		}
		
		
	}
}


