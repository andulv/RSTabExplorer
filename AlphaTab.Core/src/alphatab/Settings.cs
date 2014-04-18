using haxe.root;
#pragma warning disable 109, 114, 219, 429, 168, 162
namespace alphatab
{
	public  class Settings : global::haxe.lang.HxObject 
	{
		public    Settings(global::haxe.lang.EmptyObject empty)
		{
			unchecked 
			{
				{
				}
				
			}
		}
		
		
		public    Settings()
		{
			unchecked 
			{
				global::alphatab.Settings.__hx_ctor_alphatab_Settings(this);
			}
		}
		
		
		public static   void __hx_ctor_alphatab_Settings(global::alphatab.Settings __temp_me49)
		{
			unchecked 
			{
				{
				}
				
			}
		}
		
		
		public static   global::alphatab.Settings defaults()
		{
			unchecked 
			{
				global::alphatab.Settings settings = new global::alphatab.Settings();
				settings.scale = 1.0;
				settings.width = 600;
				settings.height = 200;
				settings.engine = "default";
				settings.layout = global::alphatab.LayoutSettings.defaults();
				settings.staves = new global::haxe.root.Array<object>();
				settings.staves.push(new global::alphatab.StaveSettings(global::haxe.lang.Runtime.toString("marker")));
				settings.staves.push(new global::alphatab.StaveSettings(global::haxe.lang.Runtime.toString("tempo")));
				settings.staves.push(new global::alphatab.StaveSettings(global::haxe.lang.Runtime.toString("text")));
				settings.staves.push(new global::alphatab.StaveSettings(global::haxe.lang.Runtime.toString("chords")));
				settings.staves.push(new global::alphatab.StaveSettings(global::haxe.lang.Runtime.toString("trill")));
				settings.staves.push(new global::alphatab.StaveSettings(global::haxe.lang.Runtime.toString("beat-vibrato")));
				settings.staves.push(new global::alphatab.StaveSettings(global::haxe.lang.Runtime.toString("note-vibrato")));
				settings.staves.push(new global::alphatab.StaveSettings(global::haxe.lang.Runtime.toString("alternate-endings")));
				settings.staves.push(new global::alphatab.StaveSettings(global::haxe.lang.Runtime.toString("score")));
				settings.staves.push(new global::alphatab.StaveSettings(global::haxe.lang.Runtime.toString("crescendo")));
				settings.staves.push(new global::alphatab.StaveSettings(global::haxe.lang.Runtime.toString("dynamics")));
				settings.staves.push(new global::alphatab.StaveSettings(global::haxe.lang.Runtime.toString("trill")));
				settings.staves.push(new global::alphatab.StaveSettings(global::haxe.lang.Runtime.toString("beat-vibrato")));
				settings.staves.push(new global::alphatab.StaveSettings(global::haxe.lang.Runtime.toString("note-vibrato")));
				settings.staves.push(new global::alphatab.StaveSettings(global::haxe.lang.Runtime.toString("tap")));
				settings.staves.push(new global::alphatab.StaveSettings(global::haxe.lang.Runtime.toString("fade-in")));
				settings.staves.push(new global::alphatab.StaveSettings(global::haxe.lang.Runtime.toString("let-ring")));
				settings.staves.push(new global::alphatab.StaveSettings(global::haxe.lang.Runtime.toString("palm-mute")));
				settings.staves.push(new global::alphatab.StaveSettings(global::haxe.lang.Runtime.toString("tab")));
				settings.staves.push(new global::alphatab.StaveSettings(global::haxe.lang.Runtime.toString("pick-stroke")));
				return settings;
			}
		}
		
		
		public static  new object __hx_createEmpty()
		{
			unchecked 
			{
				return new global::alphatab.Settings(((global::haxe.lang.EmptyObject) (global::haxe.lang.EmptyObject.EMPTY) ));
			}
		}
		
		
		public static  new object __hx_create(global::haxe.root.Array arr)
		{
			unchecked 
			{
				return new global::alphatab.Settings();
			}
		}
		
		
		public  double scale;
		
		public  int width;
		
		public  int height;
		
		public  string engine;
		
		public  global::alphatab.LayoutSettings layout;
		
		public  global::haxe.root.Array<object> staves;
		
		public override   double __hx_setField_f(string field, int hash, double @value, bool handleProperties)
		{
			unchecked 
			{
				switch (hash)
				{
					case 38537191:
					{
						this.height = ((int) (@value) );
						return @value;
					}
					
					
					case 1247983110:
					{
						this.width = ((int) (@value) );
						return @value;
					}
					
					
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
					case 100490692:
					{
						this.staves = ((global::haxe.root.Array<object>) (global::haxe.root.Array<object>.__hx_cast<object>(((global::haxe.root.Array) (@value) ))) );
						return @value;
					}
					
					
					case 1488498346:
					{
						this.layout = ((global::alphatab.LayoutSettings) (@value) );
						return @value;
					}
					
					
					case 2089043906:
					{
						this.engine = global::haxe.lang.Runtime.toString(@value);
						return @value;
					}
					
					
					case 38537191:
					{
						this.height = ((int) (global::haxe.lang.Runtime.toInt(@value)) );
						return @value;
					}
					
					
					case 1247983110:
					{
						this.width = ((int) (global::haxe.lang.Runtime.toInt(@value)) );
						return @value;
					}
					
					
					case 2026819210:
					{
						this.scale = ((double) (global::haxe.lang.Runtime.toDouble(@value)) );
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
					case 100490692:
					{
						return this.staves;
					}
					
					
					case 1488498346:
					{
						return this.layout;
					}
					
					
					case 2089043906:
					{
						return this.engine;
					}
					
					
					case 38537191:
					{
						return this.height;
					}
					
					
					case 1247983110:
					{
						return this.width;
					}
					
					
					case 2026819210:
					{
						return this.scale;
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
					case 38537191:
					{
						return ((double) (this.height) );
					}
					
					
					case 1247983110:
					{
						return ((double) (this.width) );
					}
					
					
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
		
		
		public override   void __hx_getFields(global::haxe.root.Array<object> baseArr)
		{
			unchecked 
			{
				baseArr.push("staves");
				baseArr.push("layout");
				baseArr.push("engine");
				baseArr.push("height");
				baseArr.push("width");
				baseArr.push("scale");
				{
					base.__hx_getFields(baseArr);
				}
				
			}
		}
		
		
	}
}



#pragma warning disable 109, 114, 219, 429, 168, 162
namespace alphatab
{
	public  class LayoutSettings : global::haxe.lang.HxObject 
	{
		public    LayoutSettings(global::haxe.lang.EmptyObject empty)
		{
			unchecked 
			{
				{
				}
				
			}
		}
		
		
		public    LayoutSettings()
		{
			unchecked 
			{
				global::alphatab.LayoutSettings.__hx_ctor_alphatab_LayoutSettings(this);
			}
		}
		
		
		public static   void __hx_ctor_alphatab_LayoutSettings(global::alphatab.LayoutSettings __temp_me50)
		{
			unchecked 
			{
				__temp_me50.additionalSettings = new global::haxe.ds.StringMap<object>();
			}
		}
		
		
		public static   global::alphatab.LayoutSettings defaults()
		{
			unchecked 
			{
				global::alphatab.LayoutSettings settings = new global::alphatab.LayoutSettings();
				settings.mode = "page";
				return settings;
			}
		}
		
		
		public static  new object __hx_createEmpty()
		{
			unchecked 
			{
				return new global::alphatab.LayoutSettings(((global::haxe.lang.EmptyObject) (global::haxe.lang.EmptyObject.EMPTY) ));
			}
		}
		
		
		public static  new object __hx_create(global::haxe.root.Array arr)
		{
			unchecked 
			{
				return new global::alphatab.LayoutSettings();
			}
		}
		
		
		public  string mode;
		
		public  global::haxe.ds.StringMap additionalSettings;
		
		public virtual   T @get<T>(string key, T def)
		{
			unchecked 
			{
				if (((bool) (global::haxe.lang.Runtime.callField(this.additionalSettings, "exists", 1071652316, new global::haxe.root.Array<object>(new object[]{key}))) )) 
				{
					return global::haxe.lang.Runtime.genericCast<T>(((object) (global::haxe.lang.Runtime.callField(this.additionalSettings, "get", 5144726, new global::haxe.root.Array<object>(new object[]{key}))) ));
				}
				
				return def;
			}
		}
		
		
		public override   object __hx_setField(string field, int hash, object @value, bool handleProperties)
		{
			unchecked 
			{
				switch (hash)
				{
					case 2083451114:
					{
						this.additionalSettings = ((global::haxe.ds.StringMap) (@value) );
						return @value;
					}
					
					
					case 1214305123:
					{
						this.mode = global::haxe.lang.Runtime.toString(@value);
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
					case 5144726:
					{
						return ((global::haxe.lang.Function) (new global::haxe.lang.Closure(((object) (this) ), global::haxe.lang.Runtime.toString("get"), ((int) (5144726) ))) );
					}
					
					
					case 2083451114:
					{
						return this.additionalSettings;
					}
					
					
					case 1214305123:
					{
						return this.mode;
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
					case 5144726:
					{
						return this.@get<object>(global::haxe.lang.Runtime.toString(dynargs[0]), dynargs[1]);
					}
					
					
					default:
					{
						return base.__hx_invokeField(field, hash, dynargs);
					}
					
				}
				
			}
		}
		
		
		public override   void __hx_getFields(global::haxe.root.Array<object> baseArr)
		{
			unchecked 
			{
				baseArr.push("additionalSettings");
				baseArr.push("mode");
				{
					base.__hx_getFields(baseArr);
				}
				
			}
		}
		
		
	}
}



#pragma warning disable 109, 114, 219, 429, 168, 162
namespace alphatab
{
	public  class StaveSettings : global::haxe.lang.HxObject 
	{
		public    StaveSettings(global::haxe.lang.EmptyObject empty)
		{
			unchecked 
			{
				{
				}
				
			}
		}
		
		
		public    StaveSettings(string id)
		{
			unchecked 
			{
				global::alphatab.StaveSettings.__hx_ctor_alphatab_StaveSettings(this, id);
			}
		}
		
		
		public static   void __hx_ctor_alphatab_StaveSettings(global::alphatab.StaveSettings __temp_me51, string id)
		{
			unchecked 
			{
				__temp_me51.id = id;
				__temp_me51.additionalSettings = new global::haxe.ds.StringMap<object>();
			}
		}
		
		
		public static  new object __hx_createEmpty()
		{
			unchecked 
			{
				return new global::alphatab.StaveSettings(((global::haxe.lang.EmptyObject) (global::haxe.lang.EmptyObject.EMPTY) ));
			}
		}
		
		
		public static  new object __hx_create(global::haxe.root.Array arr)
		{
			unchecked 
			{
				return new global::alphatab.StaveSettings(global::haxe.lang.Runtime.toString(arr[0]));
			}
		}
		
		
		public  string id;
		
		public  global::haxe.ds.StringMap additionalSettings;
		
		public override   object __hx_setField(string field, int hash, object @value, bool handleProperties)
		{
			unchecked 
			{
				switch (hash)
				{
					case 2083451114:
					{
						this.additionalSettings = ((global::haxe.ds.StringMap) (@value) );
						return @value;
					}
					
					
					case 23515:
					{
						this.id = global::haxe.lang.Runtime.toString(@value);
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
					case 2083451114:
					{
						return this.additionalSettings;
					}
					
					
					case 23515:
					{
						return this.id;
					}
					
					
					default:
					{
						return base.__hx_getField(field, hash, throwErrors, isCheck, handleProperties);
					}
					
				}
				
			}
		}
		
		
		public override   void __hx_getFields(global::haxe.root.Array<object> baseArr)
		{
			unchecked 
			{
				baseArr.push("additionalSettings");
				baseArr.push("id");
				{
					base.__hx_getFields(baseArr);
				}
				
			}
		}
		
		
	}
}


