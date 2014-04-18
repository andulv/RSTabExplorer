using haxe.root;
#pragma warning disable 109, 114, 219, 429, 168, 162
namespace alphatab.model
{
	public  class Voice : global::haxe.lang.HxObject 
	{
		public    Voice(global::haxe.lang.EmptyObject empty)
		{
			unchecked 
			{
				{
				}
				
			}
		}
		
		
		public    Voice()
		{
			unchecked 
			{
				global::alphatab.model.Voice.__hx_ctor_alphatab_model_Voice(this);
			}
		}
		
		
		public static   void __hx_ctor_alphatab_model_Voice(global::alphatab.model.Voice __temp_me88)
		{
			unchecked 
			{
				__temp_me88.beats = new global::haxe.root.Array<object>();
			}
		}
		
		
		public static  new object __hx_createEmpty()
		{
			unchecked 
			{
				return new global::alphatab.model.Voice(((global::haxe.lang.EmptyObject) (global::haxe.lang.EmptyObject.EMPTY) ));
			}
		}
		
		
		public static  new object __hx_create(global::haxe.root.Array arr)
		{
			unchecked 
			{
				return new global::alphatab.model.Voice();
			}
		}
		
		
		public  int index;
		
		public  global::alphatab.model.Bar bar;
		
		public  global::haxe.root.Array<object> beats;
		
		public virtual   void addBeat(global::alphatab.model.Beat beat)
		{
			unchecked 
			{
				beat.voice = this;
				beat.index = this.beats.length;
				this.beats.push(beat);
			}
		}
		
		
		public virtual   void addGraceBeat(global::alphatab.model.Beat beat)
		{
			unchecked 
			{
				if (( this.beats.length == 0 )) 
				{
					this.addBeat(beat);
					return ;
				}
				
				global::alphatab.model.Beat lastBeat = ((global::alphatab.model.Beat) (this.beats.splice(( this.beats.length - 1 ), 1)[0]) );
				this.addBeat(beat);
				this.addBeat(lastBeat);
			}
		}
		
		
		public virtual   bool isEmpty()
		{
			unchecked 
			{
				return ( this.beats.length == 0 );
			}
		}
		
		
		public override   double __hx_setField_f(string field, int hash, double @value, bool handleProperties)
		{
			unchecked 
			{
				switch (hash)
				{
					case 1041537810:
					{
						this.index = ((int) (@value) );
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
					case 810640957:
					{
						this.beats = ((global::haxe.root.Array<object>) (global::haxe.root.Array<object>.__hx_cast<object>(((global::haxe.root.Array) (@value) ))) );
						return @value;
					}
					
					
					case 4895187:
					{
						this.bar = ((global::alphatab.model.Bar) (@value) );
						return @value;
					}
					
					
					case 1041537810:
					{
						this.index = ((int) (global::haxe.lang.Runtime.toInt(@value)) );
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
					case 207609411:
					{
						return ((global::haxe.lang.Function) (new global::haxe.lang.Closure(((object) (this) ), global::haxe.lang.Runtime.toString("isEmpty"), ((int) (207609411) ))) );
					}
					
					
					case 21532461:
					{
						return ((global::haxe.lang.Function) (new global::haxe.lang.Closure(((object) (this) ), global::haxe.lang.Runtime.toString("addGraceBeat"), ((int) (21532461) ))) );
					}
					
					
					case 2102469687:
					{
						return ((global::haxe.lang.Function) (new global::haxe.lang.Closure(((object) (this) ), global::haxe.lang.Runtime.toString("addBeat"), ((int) (2102469687) ))) );
					}
					
					
					case 810640957:
					{
						return this.beats;
					}
					
					
					case 4895187:
					{
						return this.bar;
					}
					
					
					case 1041537810:
					{
						return this.index;
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
					case 1041537810:
					{
						return ((double) (this.index) );
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
					case 207609411:
					{
						return this.isEmpty();
					}
					
					
					case 21532461:
					{
						this.addGraceBeat(((global::alphatab.model.Beat) (dynargs[0]) ));
						break;
					}
					
					
					case 2102469687:
					{
						this.addBeat(((global::alphatab.model.Beat) (dynargs[0]) ));
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
				baseArr.push("beats");
				baseArr.push("bar");
				baseArr.push("index");
				{
					base.__hx_getFields(baseArr);
				}
				
			}
		}
		
		
	}
}


