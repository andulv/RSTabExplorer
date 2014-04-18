using haxe.root;
#pragma warning disable 109, 114, 219, 429, 168, 162
namespace alphatab.model
{
	public  class RepeatGroup : global::haxe.lang.HxObject 
	{
		public    RepeatGroup(global::haxe.lang.EmptyObject empty)
		{
			unchecked 
			{
				{
				}
				
			}
		}
		
		
		public    RepeatGroup()
		{
			unchecked 
			{
				global::alphatab.model.RepeatGroup.__hx_ctor_alphatab_model_RepeatGroup(this);
			}
		}
		
		
		public static   void __hx_ctor_alphatab_model_RepeatGroup(global::alphatab.model.RepeatGroup __temp_me83)
		{
			unchecked 
			{
				__temp_me83.masterBars = new global::haxe.root.Array<object>();
				__temp_me83.closings = new global::haxe.root.Array<object>();
				__temp_me83.openings = new global::haxe.root.Array<object>();
				__temp_me83.isClosed = false;
			}
		}
		
		
		public static  new object __hx_createEmpty()
		{
			unchecked 
			{
				return new global::alphatab.model.RepeatGroup(((global::haxe.lang.EmptyObject) (global::haxe.lang.EmptyObject.EMPTY) ));
			}
		}
		
		
		public static  new object __hx_create(global::haxe.root.Array arr)
		{
			unchecked 
			{
				return new global::alphatab.model.RepeatGroup();
			}
		}
		
		
		public  global::haxe.root.Array<object> masterBars;
		
		public  global::haxe.root.Array<object> openings;
		
		public  global::haxe.root.Array<object> closings;
		
		public  bool isClosed;
		
		public virtual   void addMasterBar(global::alphatab.model.MasterBar masterBar)
		{
			unchecked 
			{
				if (( this.openings.length == 0 )) 
				{
					this.openings.push(masterBar);
				}
				
				this.masterBars.push(masterBar);
				masterBar.repeatGroup = this;
				if (( masterBar.repeatCount > 0 )) 
				{
					this.closings.push(masterBar);
					this.isClosed = true;
				}
				 else 
				{
					if (this.isClosed) 
					{
						this.isClosed = false;
						this.openings.push(masterBar);
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
					case 1723548982:
					{
						this.isClosed = ((bool) (@value) );
						return @value;
					}
					
					
					case 134035422:
					{
						this.closings = ((global::haxe.root.Array<object>) (global::haxe.root.Array<object>.__hx_cast<object>(((global::haxe.root.Array) (@value) ))) );
						return @value;
					}
					
					
					case 2082335259:
					{
						this.openings = ((global::haxe.root.Array<object>) (global::haxe.root.Array<object>.__hx_cast<object>(((global::haxe.root.Array) (@value) ))) );
						return @value;
					}
					
					
					case 137661698:
					{
						this.masterBars = ((global::haxe.root.Array<object>) (global::haxe.root.Array<object>.__hx_cast<object>(((global::haxe.root.Array) (@value) ))) );
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
					case 2127207408:
					{
						return ((global::haxe.lang.Function) (new global::haxe.lang.Closure(((object) (this) ), global::haxe.lang.Runtime.toString("addMasterBar"), ((int) (2127207408) ))) );
					}
					
					
					case 1723548982:
					{
						return this.isClosed;
					}
					
					
					case 134035422:
					{
						return this.closings;
					}
					
					
					case 2082335259:
					{
						return this.openings;
					}
					
					
					case 137661698:
					{
						return this.masterBars;
					}
					
					
					default:
					{
						return base.__hx_getField(field, hash, throwErrors, isCheck, handleProperties);
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
					case 2127207408:
					{
						this.addMasterBar(((global::alphatab.model.MasterBar) (dynargs[0]) ));
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
				baseArr.push("isClosed");
				baseArr.push("closings");
				baseArr.push("openings");
				baseArr.push("masterBars");
				{
					base.__hx_getFields(baseArr);
				}
				
			}
		}
		
		
	}
}


