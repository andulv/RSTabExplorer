using haxe.root;
#pragma warning disable 109, 114, 219, 429, 168, 162
namespace alphatab.rendering.staves
{
	public  class BarSizeInfo : global::haxe.lang.HxObject 
	{
		public    BarSizeInfo(global::haxe.lang.EmptyObject empty)
		{
			unchecked 
			{
				{
				}
				
			}
		}
		
		
		public    BarSizeInfo()
		{
			unchecked 
			{
				global::alphatab.rendering.staves.BarSizeInfo.__hx_ctor_alphatab_rendering_staves_BarSizeInfo(this);
			}
		}
		
		
		public static   void __hx_ctor_alphatab_rendering_staves_BarSizeInfo(global::alphatab.rendering.staves.BarSizeInfo __temp_me264)
		{
			unchecked 
			{
				__temp_me264.sizes = new global::haxe.ds.StringMap<int>();
				__temp_me264.preNoteSizes = new global::haxe.ds.IntMap<int>();
				__temp_me264.onNoteSizes = new global::haxe.ds.IntMap<int>();
				__temp_me264.postNoteSizes = new global::haxe.ds.IntMap<int>();
				__temp_me264.fullWidth = 0;
			}
		}
		
		
		public static  new object __hx_createEmpty()
		{
			unchecked 
			{
				return new global::alphatab.rendering.staves.BarSizeInfo(((global::haxe.lang.EmptyObject) (global::haxe.lang.EmptyObject.EMPTY) ));
			}
		}
		
		
		public static  new object __hx_create(global::haxe.root.Array arr)
		{
			unchecked 
			{
				return new global::alphatab.rendering.staves.BarSizeInfo();
			}
		}
		
		
		public  int fullWidth;
		
		public  global::haxe.ds.StringMap<int> sizes;
		
		public  global::haxe.ds.IntMap<int> preNoteSizes;
		
		public  global::haxe.ds.IntMap<int> onNoteSizes;
		
		public  global::haxe.ds.IntMap<int> postNoteSizes;
		
		public virtual   void setSize(string key, int size)
		{
			unchecked 
			{
				this.sizes.@set(key, size);
			}
		}
		
		
		public virtual   global::haxe.lang.Null<int> getSize(string key)
		{
			unchecked 
			{
				global::haxe.lang.Null<int> size = this.sizes.@get(key);
				if (global::haxe.lang.Runtime.eq((size).toDynamic(), (default(global::haxe.lang.Null<int>)).toDynamic())) 
				{
					return new global::haxe.lang.Null<int>(0, true);
				}
				 else 
				{
					return size;
				}
				
			}
		}
		
		
		public virtual   int getPreNoteSize(int beat)
		{
			unchecked 
			{
				global::haxe.lang.Null<int> size = this.preNoteSizes.@get(beat);
				if (global::haxe.lang.Runtime.eq((size).toDynamic(), (default(global::haxe.lang.Null<int>)).toDynamic())) 
				{
					return 0;
				}
				 else 
				{
					return size.@value;
				}
				
			}
		}
		
		
		public virtual   int getOnNoteSize(int beat)
		{
			unchecked 
			{
				global::haxe.lang.Null<int> size = this.onNoteSizes.@get(beat);
				if (global::haxe.lang.Runtime.eq((size).toDynamic(), (default(global::haxe.lang.Null<int>)).toDynamic())) 
				{
					return 0;
				}
				 else 
				{
					return size.@value;
				}
				
			}
		}
		
		
		public virtual   int getPostNoteSize(int beat)
		{
			unchecked 
			{
				global::haxe.lang.Null<int> size = this.postNoteSizes.@get(beat);
				if (global::haxe.lang.Runtime.eq((size).toDynamic(), (default(global::haxe.lang.Null<int>)).toDynamic())) 
				{
					return 0;
				}
				 else 
				{
					return size.@value;
				}
				
			}
		}
		
		
		public   void setPreNoteSize(int beat, int @value)
		{
			unchecked 
			{
				this.preNoteSizes.@set(beat, @value);
			}
		}
		
		
		public   void setOnNoteSize(int beat, int @value)
		{
			unchecked 
			{
				this.onNoteSizes.@set(beat, @value);
			}
		}
		
		
		public   void setPostNoteSize(int beat, int @value)
		{
			unchecked 
			{
				this.postNoteSizes.@set(beat, @value);
			}
		}
		
		
		public override   double __hx_setField_f(string field, int hash, double @value, bool handleProperties)
		{
			unchecked 
			{
				switch (hash)
				{
					case 1197946359:
					{
						this.fullWidth = ((int) (@value) );
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
					case 1746477760:
					{
						this.postNoteSizes = ((global::haxe.ds.IntMap<int>) (global::haxe.ds.IntMap<object>.__hx_cast<int>(((global::haxe.ds.IntMap) (@value) ))) );
						return @value;
					}
					
					
					case 1554593313:
					{
						this.onNoteSizes = ((global::haxe.ds.IntMap<int>) (global::haxe.ds.IntMap<object>.__hx_cast<int>(((global::haxe.ds.IntMap) (@value) ))) );
						return @value;
					}
					
					
					case 1617311389:
					{
						this.preNoteSizes = ((global::haxe.ds.IntMap<int>) (global::haxe.ds.IntMap<object>.__hx_cast<int>(((global::haxe.ds.IntMap) (@value) ))) );
						return @value;
					}
					
					
					case 2094598290:
					{
						this.sizes = ((global::haxe.ds.StringMap<int>) (global::haxe.ds.StringMap<object>.__hx_cast<int>(((global::haxe.ds.StringMap) (@value) ))) );
						return @value;
					}
					
					
					case 1197946359:
					{
						this.fullWidth = ((int) (global::haxe.lang.Runtime.toInt(@value)) );
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
					case 1861630229:
					{
						return ((global::haxe.lang.Function) (new global::haxe.lang.Closure(((object) (this) ), global::haxe.lang.Runtime.toString("setPostNoteSize"), ((int) (1861630229) ))) );
					}
					
					
					case 1521866836:
					{
						return ((global::haxe.lang.Function) (new global::haxe.lang.Closure(((object) (this) ), global::haxe.lang.Runtime.toString("setOnNoteSize"), ((int) (1521866836) ))) );
					}
					
					
					case 414021780:
					{
						return ((global::haxe.lang.Function) (new global::haxe.lang.Closure(((object) (this) ), global::haxe.lang.Runtime.toString("setPreNoteSize"), ((int) (414021780) ))) );
					}
					
					
					case 1932180489:
					{
						return ((global::haxe.lang.Function) (new global::haxe.lang.Closure(((object) (this) ), global::haxe.lang.Runtime.toString("getPostNoteSize"), ((int) (1932180489) ))) );
					}
					
					
					case 363853384:
					{
						return ((global::haxe.lang.Function) (new global::haxe.lang.Closure(((object) (this) ), global::haxe.lang.Runtime.toString("getOnNoteSize"), ((int) (363853384) ))) );
					}
					
					
					case 2022543392:
					{
						return ((global::haxe.lang.Function) (new global::haxe.lang.Closure(((object) (this) ), global::haxe.lang.Runtime.toString("getPreNoteSize"), ((int) (2022543392) ))) );
					}
					
					
					case 517361783:
					{
						return ((global::haxe.lang.Function) (new global::haxe.lang.Closure(((object) (this) ), global::haxe.lang.Runtime.toString("getSize"), ((int) (517361783) ))) );
					}
					
					
					case 299360643:
					{
						return ((global::haxe.lang.Function) (new global::haxe.lang.Closure(((object) (this) ), global::haxe.lang.Runtime.toString("setSize"), ((int) (299360643) ))) );
					}
					
					
					case 1746477760:
					{
						return this.postNoteSizes;
					}
					
					
					case 1554593313:
					{
						return this.onNoteSizes;
					}
					
					
					case 1617311389:
					{
						return this.preNoteSizes;
					}
					
					
					case 2094598290:
					{
						return this.sizes;
					}
					
					
					case 1197946359:
					{
						return this.fullWidth;
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
					case 1197946359:
					{
						return ((double) (this.fullWidth) );
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
					case 1861630229:
					{
						this.setPostNoteSize(((int) (global::haxe.lang.Runtime.toInt(dynargs[0])) ), ((int) (global::haxe.lang.Runtime.toInt(dynargs[1])) ));
						break;
					}
					
					
					case 1521866836:
					{
						this.setOnNoteSize(((int) (global::haxe.lang.Runtime.toInt(dynargs[0])) ), ((int) (global::haxe.lang.Runtime.toInt(dynargs[1])) ));
						break;
					}
					
					
					case 414021780:
					{
						this.setPreNoteSize(((int) (global::haxe.lang.Runtime.toInt(dynargs[0])) ), ((int) (global::haxe.lang.Runtime.toInt(dynargs[1])) ));
						break;
					}
					
					
					case 1932180489:
					{
						return this.getPostNoteSize(((int) (global::haxe.lang.Runtime.toInt(dynargs[0])) ));
					}
					
					
					case 363853384:
					{
						return this.getOnNoteSize(((int) (global::haxe.lang.Runtime.toInt(dynargs[0])) ));
					}
					
					
					case 2022543392:
					{
						return this.getPreNoteSize(((int) (global::haxe.lang.Runtime.toInt(dynargs[0])) ));
					}
					
					
					case 517361783:
					{
						return (this.getSize(global::haxe.lang.Runtime.toString(dynargs[0]))).toDynamic();
					}
					
					
					case 299360643:
					{
						this.setSize(global::haxe.lang.Runtime.toString(dynargs[0]), ((int) (global::haxe.lang.Runtime.toInt(dynargs[1])) ));
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
				baseArr.push("postNoteSizes");
				baseArr.push("onNoteSizes");
				baseArr.push("preNoteSizes");
				baseArr.push("sizes");
				baseArr.push("fullWidth");
				{
					base.__hx_getFields(baseArr);
				}
				
			}
		}
		
		
	}
}


