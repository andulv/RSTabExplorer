using haxe.root;
#pragma warning disable 109, 114, 219, 429, 168, 162
namespace alphatab.model
{
	public  class Track : global::haxe.lang.HxObject 
	{
		public    Track(global::haxe.lang.EmptyObject empty)
		{
			unchecked 
			{
				{
				}
				
			}
		}
		
		
		public    Track()
		{
			unchecked 
			{
				global::alphatab.model.Track.__hx_ctor_alphatab_model_Track(this);
			}
		}
		
		
		public static   void __hx_ctor_alphatab_model_Track(global::alphatab.model.Track __temp_me86)
		{
			unchecked 
			{
				__temp_me86.tuning = new global::haxe.root.Array<int>();
				__temp_me86.bars = new global::haxe.root.Array<object>();
				__temp_me86.chords = new global::haxe.ds.StringMap<object>();
				__temp_me86.playbackInfo = new global::alphatab.model.PlaybackInformation();
				__temp_me86.color = new global::alphatab.platform.model.Color(((int) (200) ), ((int) (0) ), ((int) (0) ), ((global::haxe.lang.Null<int>) (default(global::haxe.lang.Null<int>)) ));
			}
		}
		
		
		public static  new object __hx_createEmpty()
		{
			unchecked 
			{
				return new global::alphatab.model.Track(((global::haxe.lang.EmptyObject) (global::haxe.lang.EmptyObject.EMPTY) ));
			}
		}
		
		
		public static  new object __hx_create(global::haxe.root.Array arr)
		{
			unchecked 
			{
				return new global::alphatab.model.Track();
			}
		}
		
		
		public  int capo;
		
		public  int index;
		
		public  string name;
		
		public  string shortName;
		
		public  global::haxe.root.Array<int> tuning;
		
		public  string tuningName;
		
		public  global::alphatab.platform.model.Color color;
		
		public  global::alphatab.model.PlaybackInformation playbackInfo;
		
		public  bool isPercussion;
		
		public  global::alphatab.model.Score score;
		
		public  global::haxe.root.Array<object> bars;
		
		public  global::haxe.ds.StringMap<object> chords;
		
		public virtual   void addBar(global::alphatab.model.Bar bar)
		{
			unchecked 
			{
				bar.track = this;
				bar.index = this.bars.length;
				if (( this.bars.length > 0 )) 
				{
					bar.previousBar = ((global::alphatab.model.Bar) (this.bars[( this.bars.length - 1 )]) );
					bar.previousBar.nextBar = bar;
				}
				
				this.bars.push(bar);
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
					
					
					case 1102715933:
					{
						this.capo = ((int) (@value) );
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
					case 1085707415:
					{
						this.chords = ((global::haxe.ds.StringMap<object>) (global::haxe.ds.StringMap<object>.__hx_cast<object>(((global::haxe.ds.StringMap) (@value) ))) );
						return @value;
					}
					
					
					case 1091626816:
					{
						this.bars = ((global::haxe.root.Array<object>) (global::haxe.root.Array<object>.__hx_cast<object>(((global::haxe.root.Array) (@value) ))) );
						return @value;
					}
					
					
					case 2027516754:
					{
						this.score = ((global::alphatab.model.Score) (@value) );
						return @value;
					}
					
					
					case 73353859:
					{
						this.isPercussion = ((bool) (@value) );
						return @value;
					}
					
					
					case 983703593:
					{
						this.playbackInfo = ((global::alphatab.model.PlaybackInformation) (@value) );
						return @value;
					}
					
					
					case 1247572323:
					{
						this.color = ((global::alphatab.platform.model.Color) (@value) );
						return @value;
					}
					
					
					case 695082016:
					{
						this.tuningName = global::haxe.lang.Runtime.toString(@value);
						return @value;
					}
					
					
					case 139280181:
					{
						this.tuning = ((global::haxe.root.Array<int>) (global::haxe.root.Array<object>.__hx_cast<int>(((global::haxe.root.Array) (@value) ))) );
						return @value;
					}
					
					
					case 432148711:
					{
						this.shortName = global::haxe.lang.Runtime.toString(@value);
						return @value;
					}
					
					
					case 1224700491:
					{
						this.name = global::haxe.lang.Runtime.toString(@value);
						return @value;
					}
					
					
					case 1041537810:
					{
						this.index = ((int) (global::haxe.lang.Runtime.toInt(@value)) );
						return @value;
					}
					
					
					case 1102715933:
					{
						this.capo = ((int) (global::haxe.lang.Runtime.toInt(@value)) );
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
					case 519815730:
					{
						return ((global::haxe.lang.Function) (new global::haxe.lang.Closure(((object) (this) ), global::haxe.lang.Runtime.toString("addBar"), ((int) (519815730) ))) );
					}
					
					
					case 1085707415:
					{
						return this.chords;
					}
					
					
					case 1091626816:
					{
						return this.bars;
					}
					
					
					case 2027516754:
					{
						return this.score;
					}
					
					
					case 73353859:
					{
						return this.isPercussion;
					}
					
					
					case 983703593:
					{
						return this.playbackInfo;
					}
					
					
					case 1247572323:
					{
						return this.color;
					}
					
					
					case 695082016:
					{
						return this.tuningName;
					}
					
					
					case 139280181:
					{
						return this.tuning;
					}
					
					
					case 432148711:
					{
						return this.shortName;
					}
					
					
					case 1224700491:
					{
						return this.name;
					}
					
					
					case 1041537810:
					{
						return this.index;
					}
					
					
					case 1102715933:
					{
						return this.capo;
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
					
					
					case 1102715933:
					{
						return ((double) (this.capo) );
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
					case 519815730:
					{
						this.addBar(((global::alphatab.model.Bar) (dynargs[0]) ));
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
				baseArr.push("chords");
				baseArr.push("bars");
				baseArr.push("score");
				baseArr.push("isPercussion");
				baseArr.push("playbackInfo");
				baseArr.push("color");
				baseArr.push("tuningName");
				baseArr.push("tuning");
				baseArr.push("shortName");
				baseArr.push("name");
				baseArr.push("index");
				baseArr.push("capo");
				{
					base.__hx_getFields(baseArr);
				}
				
			}
		}
		
		
	}
}


