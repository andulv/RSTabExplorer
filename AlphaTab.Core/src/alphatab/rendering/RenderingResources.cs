using haxe.root;
#pragma warning disable 109, 114, 219, 429, 168, 162
namespace alphatab.rendering
{
	public  class RenderingResources : global::haxe.lang.HxObject 
	{
		public    RenderingResources(global::haxe.lang.EmptyObject empty)
		{
			unchecked 
			{
				{
				}
				
			}
		}
		
		
		public    RenderingResources(double scale)
		{
			unchecked 
			{
				global::alphatab.rendering.RenderingResources.__hx_ctor_alphatab_rendering_RenderingResources(this, scale);
			}
		}
		
		
		public static   void __hx_ctor_alphatab_rendering_RenderingResources(global::alphatab.rendering.RenderingResources __temp_me97, double scale)
		{
			unchecked 
			{
				__temp_me97.init(scale);
			}
		}
		
		
		public static  new object __hx_createEmpty()
		{
			unchecked 
			{
				return new global::alphatab.rendering.RenderingResources(((global::haxe.lang.EmptyObject) (global::haxe.lang.EmptyObject.EMPTY) ));
			}
		}
		
		
		public static  new object __hx_create(global::haxe.root.Array arr)
		{
			unchecked 
			{
				return new global::alphatab.rendering.RenderingResources(((double) (global::haxe.lang.Runtime.toDouble(arr[0])) ));
			}
		}
		
		
		public  global::alphatab.platform.model.Font copyrightFont;
		
		public  global::alphatab.platform.model.Font titleFont;
		
		public  global::alphatab.platform.model.Font subTitleFont;
		
		public  global::alphatab.platform.model.Font wordsFont;
		
		public  global::alphatab.platform.model.Font effectFont;
		
		public  global::alphatab.platform.model.Font tablatureFont;
		
		public  global::alphatab.platform.model.Font graceFont;
		
		public  global::alphatab.platform.model.Color staveLineColor;
		
		public  global::alphatab.platform.model.Color barSeperatorColor;
		
		public  global::alphatab.platform.model.Font barNumberFont;
		
		public  global::alphatab.platform.model.Color barNumberColor;
		
		public  global::alphatab.platform.model.Font markerFont;
		
		public  global::alphatab.platform.model.Font tabClefFont;
		
		public  global::alphatab.platform.model.Color mainGlyphColor;
		
		public  double scale;
		
		public virtual   void init(double scale)
		{
			unchecked 
			{
				this.scale = scale;
				string sansFont = "Arial";
				string serifFont = "Georgia";
				this.effectFont = new global::alphatab.platform.model.Font(global::haxe.lang.Runtime.toString(serifFont), ((double) (( 12 * scale )) ), new global::haxe.lang.Null<int>(2, true));
				this.copyrightFont = new global::alphatab.platform.model.Font(global::haxe.lang.Runtime.toString(sansFont), ((double) (( 12 * scale )) ), new global::haxe.lang.Null<int>(1, true));
				this.titleFont = new global::alphatab.platform.model.Font(global::haxe.lang.Runtime.toString(serifFont), ((double) (( 32 * scale )) ), ((global::haxe.lang.Null<int>) (default(global::haxe.lang.Null<int>)) ));
				this.subTitleFont = new global::alphatab.platform.model.Font(global::haxe.lang.Runtime.toString(serifFont), ((double) (( 20 * scale )) ), ((global::haxe.lang.Null<int>) (default(global::haxe.lang.Null<int>)) ));
				this.wordsFont = new global::alphatab.platform.model.Font(global::haxe.lang.Runtime.toString(serifFont), ((double) (( 15 * scale )) ), ((global::haxe.lang.Null<int>) (default(global::haxe.lang.Null<int>)) ));
				this.tablatureFont = new global::alphatab.platform.model.Font(global::haxe.lang.Runtime.toString(sansFont), ((double) (( 13 * scale )) ), ((global::haxe.lang.Null<int>) (default(global::haxe.lang.Null<int>)) ));
				this.graceFont = new global::alphatab.platform.model.Font(global::haxe.lang.Runtime.toString(sansFont), ((double) (( 11 * scale )) ), ((global::haxe.lang.Null<int>) (default(global::haxe.lang.Null<int>)) ));
				this.staveLineColor = new global::alphatab.platform.model.Color(((int) (165) ), ((int) (165) ), ((int) (165) ), ((global::haxe.lang.Null<int>) (default(global::haxe.lang.Null<int>)) ));
				this.barSeperatorColor = new global::alphatab.platform.model.Color(((int) (34) ), ((int) (34) ), ((int) (17) ), ((global::haxe.lang.Null<int>) (default(global::haxe.lang.Null<int>)) ));
				this.barNumberFont = new global::alphatab.platform.model.Font(global::haxe.lang.Runtime.toString(sansFont), ((double) (( 11 * scale )) ), ((global::haxe.lang.Null<int>) (default(global::haxe.lang.Null<int>)) ));
				this.barNumberColor = new global::alphatab.platform.model.Color(((int) (200) ), ((int) (0) ), ((int) (0) ), ((global::haxe.lang.Null<int>) (default(global::haxe.lang.Null<int>)) ));
				this.markerFont = new global::alphatab.platform.model.Font(global::haxe.lang.Runtime.toString(serifFont), ((double) (( 14 * scale )) ), new global::haxe.lang.Null<int>(1, true));
				this.tabClefFont = new global::alphatab.platform.model.Font(global::haxe.lang.Runtime.toString(sansFont), ((double) (( 18 * scale )) ), new global::haxe.lang.Null<int>(1, true));
				this.mainGlyphColor = new global::alphatab.platform.model.Color(((int) (0) ), ((int) (0) ), ((int) (0) ), ((global::haxe.lang.Null<int>) (default(global::haxe.lang.Null<int>)) ));
			}
		}
		
		
		public override   double __hx_setField_f(string field, int hash, double @value, bool handleProperties)
		{
			unchecked 
			{
				switch (hash)
				{
					case 2026819210:
					{
						this.scale = ((double) (@value) );
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
					case 2026819210:
					{
						this.scale = ((double) (global::haxe.lang.Runtime.toDouble(@value)) );
						return @value;
					}
					
					
					case 674558384:
					{
						this.mainGlyphColor = ((global::alphatab.platform.model.Color) (@value) );
						return @value;
					}
					
					
					case 1345344942:
					{
						this.tabClefFont = ((global::alphatab.platform.model.Font) (@value) );
						return @value;
					}
					
					
					case 1534092457:
					{
						this.markerFont = ((global::alphatab.platform.model.Font) (@value) );
						return @value;
					}
					
					
					case 1906311879:
					{
						this.barNumberColor = ((global::alphatab.platform.model.Color) (@value) );
						return @value;
					}
					
					
					case 2035221739:
					{
						this.barNumberFont = ((global::alphatab.platform.model.Font) (@value) );
						return @value;
					}
					
					
					case 617369845:
					{
						this.barSeperatorColor = ((global::alphatab.platform.model.Color) (@value) );
						return @value;
					}
					
					
					case 1873734400:
					{
						this.staveLineColor = ((global::alphatab.platform.model.Color) (@value) );
						return @value;
					}
					
					
					case 77654503:
					{
						this.graceFont = ((global::alphatab.platform.model.Font) (@value) );
						return @value;
					}
					
					
					case 1035342189:
					{
						this.tablatureFont = ((global::alphatab.platform.model.Font) (@value) );
						return @value;
					}
					
					
					case 705429760:
					{
						this.effectFont = ((global::alphatab.platform.model.Font) (@value) );
						return @value;
					}
					
					
					case 1090814424:
					{
						this.wordsFont = ((global::alphatab.platform.model.Font) (@value) );
						return @value;
					}
					
					
					case 342184423:
					{
						this.subTitleFont = ((global::alphatab.platform.model.Font) (@value) );
						return @value;
					}
					
					
					case 1735084935:
					{
						this.titleFont = ((global::alphatab.platform.model.Font) (@value) );
						return @value;
					}
					
					
					case 1853446518:
					{
						this.copyrightFont = ((global::alphatab.platform.model.Font) (@value) );
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
					case 1169898256:
					{
						return ((global::haxe.lang.Function) (new global::haxe.lang.Closure(((object) (this) ), global::haxe.lang.Runtime.toString("init"), ((int) (1169898256) ))) );
					}
					
					
					case 2026819210:
					{
						return this.scale;
					}
					
					
					case 674558384:
					{
						return this.mainGlyphColor;
					}
					
					
					case 1345344942:
					{
						return this.tabClefFont;
					}
					
					
					case 1534092457:
					{
						return this.markerFont;
					}
					
					
					case 1906311879:
					{
						return this.barNumberColor;
					}
					
					
					case 2035221739:
					{
						return this.barNumberFont;
					}
					
					
					case 617369845:
					{
						return this.barSeperatorColor;
					}
					
					
					case 1873734400:
					{
						return this.staveLineColor;
					}
					
					
					case 77654503:
					{
						return this.graceFont;
					}
					
					
					case 1035342189:
					{
						return this.tablatureFont;
					}
					
					
					case 705429760:
					{
						return this.effectFont;
					}
					
					
					case 1090814424:
					{
						return this.wordsFont;
					}
					
					
					case 342184423:
					{
						return this.subTitleFont;
					}
					
					
					case 1735084935:
					{
						return this.titleFont;
					}
					
					
					case 1853446518:
					{
						return this.copyrightFont;
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
					case 2026819210:
					{
						return this.scale;
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
					case 1169898256:
					{
						this.init(((double) (global::haxe.lang.Runtime.toDouble(dynargs[0])) ));
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
				baseArr.push("scale");
				baseArr.push("mainGlyphColor");
				baseArr.push("tabClefFont");
				baseArr.push("markerFont");
				baseArr.push("barNumberColor");
				baseArr.push("barNumberFont");
				baseArr.push("barSeperatorColor");
				baseArr.push("staveLineColor");
				baseArr.push("graceFont");
				baseArr.push("tablatureFont");
				baseArr.push("effectFont");
				baseArr.push("wordsFont");
				baseArr.push("subTitleFont");
				baseArr.push("titleFont");
				baseArr.push("copyrightFont");
				{
					base.__hx_getFields(baseArr);
				}
				
			}
		}
		
		
	}
}


