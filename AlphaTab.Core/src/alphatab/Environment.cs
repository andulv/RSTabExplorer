using haxe.root;
#pragma warning disable 109, 114, 219, 429, 168, 162
namespace alphatab
{
	public  class Environment : global::haxe.lang.HxObject 
	{
		static Environment() 
		{
			{
				global::alphatab.Environment.renderEngines = new global::haxe.ds.StringMap<object>();
				global::alphatab.Environment.fileLoaders = new global::haxe.ds.StringMap<object>();
				global::alphatab.Environment.layoutEngines = new global::haxe.ds.StringMap<object>();
				global::alphatab.Environment.staveFactories = new global::haxe.ds.StringMap<object>();
				global::alphatab.Environment.renderEngines.@set("default", ( (( global::alphatab.Environment_new_71__Fun.__hx_current != default(global::alphatab.Environment_new_71__Fun) )) ? (global::alphatab.Environment_new_71__Fun.__hx_current) : (global::alphatab.Environment_new_71__Fun.__hx_current = ((global::alphatab.Environment_new_71__Fun) (new global::alphatab.Environment_new_71__Fun()) )) ));
				global::alphatab.Environment.renderEngines.@set("gdi", ( (( global::alphatab.Environment_new_83__Fun.__hx_current != default(global::alphatab.Environment_new_83__Fun) )) ? (global::alphatab.Environment_new_83__Fun.__hx_current) : (global::alphatab.Environment_new_83__Fun.__hx_current = ((global::alphatab.Environment_new_83__Fun) (new global::alphatab.Environment_new_83__Fun()) )) ));
				global::alphatab.Environment.renderEngines.@set("wpf", ( (( global::alphatab.Environment_new_84__Fun.__hx_current != default(global::alphatab.Environment_new_84__Fun) )) ? (global::alphatab.Environment_new_84__Fun.__hx_current) : (global::alphatab.Environment_new_84__Fun.__hx_current = ((global::alphatab.Environment_new_84__Fun) (new global::alphatab.Environment_new_84__Fun()) )) ));
				global::alphatab.Environment.renderEngines.@set("svg", ( (( global::alphatab.Environment_new_86__Fun.__hx_current != default(global::alphatab.Environment_new_86__Fun) )) ? (global::alphatab.Environment_new_86__Fun.__hx_current) : (global::alphatab.Environment_new_86__Fun.__hx_current = ((global::alphatab.Environment_new_86__Fun) (new global::alphatab.Environment_new_86__Fun()) )) ));
				global::alphatab.Environment.fileLoaders.@set("default", ( (( global::alphatab.Environment_new_89__Fun.__hx_current != default(global::alphatab.Environment_new_89__Fun) )) ? (global::alphatab.Environment_new_89__Fun.__hx_current) : (global::alphatab.Environment_new_89__Fun.__hx_current = ((global::alphatab.Environment_new_89__Fun) (new global::alphatab.Environment_new_89__Fun()) )) ));
				global::alphatab.Environment.layoutEngines.@set("default", ( (( global::alphatab.Environment_new_100__Fun.__hx_current != default(global::alphatab.Environment_new_100__Fun) )) ? (global::alphatab.Environment_new_100__Fun.__hx_current) : (global::alphatab.Environment_new_100__Fun.__hx_current = ((global::alphatab.Environment_new_100__Fun) (new global::alphatab.Environment_new_100__Fun()) )) ));
				global::alphatab.Environment.layoutEngines.@set("page", ( (( global::alphatab.Environment_new_101__Fun.__hx_current != default(global::alphatab.Environment_new_101__Fun) )) ? (global::alphatab.Environment_new_101__Fun.__hx_current) : (global::alphatab.Environment_new_101__Fun.__hx_current = ((global::alphatab.Environment_new_101__Fun) (new global::alphatab.Environment_new_101__Fun()) )) ));
				global::alphatab.Environment.layoutEngines.@set("horizontal", ( (( global::alphatab.Environment_new_102__Fun.__hx_current != default(global::alphatab.Environment_new_102__Fun) )) ? (global::alphatab.Environment_new_102__Fun.__hx_current) : (global::alphatab.Environment_new_102__Fun.__hx_current = ((global::alphatab.Environment_new_102__Fun) (new global::alphatab.Environment_new_102__Fun()) )) ));
				global::alphatab.Environment.staveFactories.@set("marker", ( (( global::alphatab.Environment_new_105__Fun.__hx_current != default(global::alphatab.Environment_new_105__Fun) )) ? (global::alphatab.Environment_new_105__Fun.__hx_current) : (global::alphatab.Environment_new_105__Fun.__hx_current = ((global::alphatab.Environment_new_105__Fun) (new global::alphatab.Environment_new_105__Fun()) )) ));
				global::alphatab.Environment.staveFactories.@set("tempo", ( (( global::alphatab.Environment_new_107__Fun.__hx_current != default(global::alphatab.Environment_new_107__Fun) )) ? (global::alphatab.Environment_new_107__Fun.__hx_current) : (global::alphatab.Environment_new_107__Fun.__hx_current = ((global::alphatab.Environment_new_107__Fun) (new global::alphatab.Environment_new_107__Fun()) )) ));
				global::alphatab.Environment.staveFactories.@set("text", ( (( global::alphatab.Environment_new_108__Fun.__hx_current != default(global::alphatab.Environment_new_108__Fun) )) ? (global::alphatab.Environment_new_108__Fun.__hx_current) : (global::alphatab.Environment_new_108__Fun.__hx_current = ((global::alphatab.Environment_new_108__Fun) (new global::alphatab.Environment_new_108__Fun()) )) ));
				global::alphatab.Environment.staveFactories.@set("chords", ( (( global::alphatab.Environment_new_109__Fun.__hx_current != default(global::alphatab.Environment_new_109__Fun) )) ? (global::alphatab.Environment_new_109__Fun.__hx_current) : (global::alphatab.Environment_new_109__Fun.__hx_current = ((global::alphatab.Environment_new_109__Fun) (new global::alphatab.Environment_new_109__Fun()) )) ));
				global::alphatab.Environment.staveFactories.@set("trill", ( (( global::alphatab.Environment_new_110__Fun.__hx_current != default(global::alphatab.Environment_new_110__Fun) )) ? (global::alphatab.Environment_new_110__Fun.__hx_current) : (global::alphatab.Environment_new_110__Fun.__hx_current = ((global::alphatab.Environment_new_110__Fun) (new global::alphatab.Environment_new_110__Fun()) )) ));
				global::alphatab.Environment.staveFactories.@set("beat-vibrato", ( (( global::alphatab.Environment_new_111__Fun.__hx_current != default(global::alphatab.Environment_new_111__Fun) )) ? (global::alphatab.Environment_new_111__Fun.__hx_current) : (global::alphatab.Environment_new_111__Fun.__hx_current = ((global::alphatab.Environment_new_111__Fun) (new global::alphatab.Environment_new_111__Fun()) )) ));
				global::alphatab.Environment.staveFactories.@set("note-vibrato", ( (( global::alphatab.Environment_new_112__Fun.__hx_current != default(global::alphatab.Environment_new_112__Fun) )) ? (global::alphatab.Environment_new_112__Fun.__hx_current) : (global::alphatab.Environment_new_112__Fun.__hx_current = ((global::alphatab.Environment_new_112__Fun) (new global::alphatab.Environment_new_112__Fun()) )) ));
				global::alphatab.Environment.staveFactories.@set("alternate-endings", ( (( global::alphatab.Environment_new_113__Fun.__hx_current != default(global::alphatab.Environment_new_113__Fun) )) ? (global::alphatab.Environment_new_113__Fun.__hx_current) : (global::alphatab.Environment_new_113__Fun.__hx_current = ((global::alphatab.Environment_new_113__Fun) (new global::alphatab.Environment_new_113__Fun()) )) ));
				global::alphatab.Environment.staveFactories.@set("score", ( (( global::alphatab.Environment_new_114__Fun.__hx_current != default(global::alphatab.Environment_new_114__Fun) )) ? (global::alphatab.Environment_new_114__Fun.__hx_current) : (global::alphatab.Environment_new_114__Fun.__hx_current = ((global::alphatab.Environment_new_114__Fun) (new global::alphatab.Environment_new_114__Fun()) )) ));
				global::alphatab.Environment.staveFactories.@set("crescendo", ( (( global::alphatab.Environment_new_115__Fun.__hx_current != default(global::alphatab.Environment_new_115__Fun) )) ? (global::alphatab.Environment_new_115__Fun.__hx_current) : (global::alphatab.Environment_new_115__Fun.__hx_current = ((global::alphatab.Environment_new_115__Fun) (new global::alphatab.Environment_new_115__Fun()) )) ));
				global::alphatab.Environment.staveFactories.@set("dynamics", ( (( global::alphatab.Environment_new_116__Fun.__hx_current != default(global::alphatab.Environment_new_116__Fun) )) ? (global::alphatab.Environment_new_116__Fun.__hx_current) : (global::alphatab.Environment_new_116__Fun.__hx_current = ((global::alphatab.Environment_new_116__Fun) (new global::alphatab.Environment_new_116__Fun()) )) ));
				global::alphatab.Environment.staveFactories.@set("tap", ( (( global::alphatab.Environment_new_117__Fun.__hx_current != default(global::alphatab.Environment_new_117__Fun) )) ? (global::alphatab.Environment_new_117__Fun.__hx_current) : (global::alphatab.Environment_new_117__Fun.__hx_current = ((global::alphatab.Environment_new_117__Fun) (new global::alphatab.Environment_new_117__Fun()) )) ));
				global::alphatab.Environment.staveFactories.@set("fade-in", ( (( global::alphatab.Environment_new_118__Fun.__hx_current != default(global::alphatab.Environment_new_118__Fun) )) ? (global::alphatab.Environment_new_118__Fun.__hx_current) : (global::alphatab.Environment_new_118__Fun.__hx_current = ((global::alphatab.Environment_new_118__Fun) (new global::alphatab.Environment_new_118__Fun()) )) ));
				global::alphatab.Environment.staveFactories.@set("let-ring", ( (( global::alphatab.Environment_new_119__Fun.__hx_current != default(global::alphatab.Environment_new_119__Fun) )) ? (global::alphatab.Environment_new_119__Fun.__hx_current) : (global::alphatab.Environment_new_119__Fun.__hx_current = ((global::alphatab.Environment_new_119__Fun) (new global::alphatab.Environment_new_119__Fun()) )) ));
				global::alphatab.Environment.staveFactories.@set("palm-mute", ( (( global::alphatab.Environment_new_120__Fun.__hx_current != default(global::alphatab.Environment_new_120__Fun) )) ? (global::alphatab.Environment_new_120__Fun.__hx_current) : (global::alphatab.Environment_new_120__Fun.__hx_current = ((global::alphatab.Environment_new_120__Fun) (new global::alphatab.Environment_new_120__Fun()) )) ));
				global::alphatab.Environment.staveFactories.@set("tab", ( (( global::alphatab.Environment_new_121__Fun.__hx_current != default(global::alphatab.Environment_new_121__Fun) )) ? (global::alphatab.Environment_new_121__Fun.__hx_current) : (global::alphatab.Environment_new_121__Fun.__hx_current = ((global::alphatab.Environment_new_121__Fun) (new global::alphatab.Environment_new_121__Fun()) )) ));
				global::alphatab.Environment.staveFactories.@set("pick-stroke", ( (( global::alphatab.Environment_new_122__Fun.__hx_current != default(global::alphatab.Environment_new_122__Fun) )) ? (global::alphatab.Environment_new_122__Fun.__hx_current) : (global::alphatab.Environment_new_122__Fun.__hx_current = ((global::alphatab.Environment_new_122__Fun) (new global::alphatab.Environment_new_122__Fun()) )) ));
			}
			
		}
		public    Environment(global::haxe.lang.EmptyObject empty)
		{
			unchecked 
			{
				{
				}
				
			}
		}
		
		
		public    Environment()
		{
			unchecked 
			{
				global::alphatab.Environment.__hx_ctor_alphatab_Environment(this);
			}
		}
		
		
		public static   void __hx_ctor_alphatab_Environment(global::alphatab.Environment __temp_me47)
		{
			unchecked 
			{
				{
				}
				
			}
		}
		
		
		public static  global::haxe.ds.StringMap<object> renderEngines;
		
		public static  global::haxe.ds.StringMap<object> fileLoaders;
		
		public static  global::haxe.ds.StringMap<object> layoutEngines;
		
		public static  global::haxe.ds.StringMap<object> staveFactories;
		
		public static  new object __hx_createEmpty()
		{
			unchecked 
			{
				return new global::alphatab.Environment(((global::haxe.lang.EmptyObject) (global::haxe.lang.EmptyObject.EMPTY) ));
			}
		}
		
		
		public static  new object __hx_create(global::haxe.root.Array arr)
		{
			unchecked 
			{
				return new global::alphatab.Environment();
			}
		}
		
		
	}
}



#pragma warning disable 109, 114, 219, 429, 168, 162
namespace alphatab
{
	public  class Environment_new_71__Fun : global::haxe.lang.Function 
	{
		public    Environment_new_71__Fun() : base(1, 0)
		{
			unchecked 
			{
			}
		}
		
		
		public static  global::alphatab.Environment_new_71__Fun __hx_current;
		
		public override   object __hx_invoke1_o(double __fn_float1, object __fn_dyn1)
		{
			unchecked 
			{
				object d = ( (global::haxe.lang.Runtime.eq(__fn_dyn1, global::haxe.lang.Runtime.undefined)) ? (((object) (__fn_float1) )) : (((object) (__fn_dyn1) )) );
				return new global::alphatab.platform.cs.GdiCanvas();
			}
		}
		
		
	}
}



#pragma warning disable 109, 114, 219, 429, 168, 162
namespace alphatab
{
	public  class Environment_new_83__Fun : global::haxe.lang.Function 
	{
		public    Environment_new_83__Fun() : base(1, 0)
		{
			unchecked 
			{
			}
		}
		
		
		public static  global::alphatab.Environment_new_83__Fun __hx_current;
		
		public override   object __hx_invoke1_o(double __fn_float1, object __fn_dyn1)
		{
			unchecked 
			{
				object d1 = ( (global::haxe.lang.Runtime.eq(__fn_dyn1, global::haxe.lang.Runtime.undefined)) ? (((object) (__fn_float1) )) : (((object) (__fn_dyn1) )) );
				return new global::alphatab.platform.cs.GdiCanvas();
			}
		}
		
		
	}
}



#pragma warning disable 109, 114, 219, 429, 168, 162
namespace alphatab
{
	public  class Environment_new_84__Fun : global::haxe.lang.Function 
	{
		public    Environment_new_84__Fun() : base(1, 0)
		{
			unchecked 
			{
			}
		}
		
		
		public static  global::alphatab.Environment_new_84__Fun __hx_current;
		
		public override   object __hx_invoke1_o(double __fn_float1, object __fn_dyn1)
		{
			unchecked 
			{
				object d2 = ( (global::haxe.lang.Runtime.eq(__fn_dyn1, global::haxe.lang.Runtime.undefined)) ? (((object) (__fn_float1) )) : (((object) (__fn_dyn1) )) );
				return new global::alphatab.platform.cs.WpfCanvas(((object) (d2) ));
			}
		}
		
		
	}
}



#pragma warning disable 109, 114, 219, 429, 168, 162
namespace alphatab
{
	public  class Environment_new_86__Fun : global::haxe.lang.Function 
	{
		public    Environment_new_86__Fun() : base(1, 0)
		{
			unchecked 
			{
			}
		}
		
		
		public static  global::alphatab.Environment_new_86__Fun __hx_current;
		
		public override   object __hx_invoke1_o(double __fn_float1, object __fn_dyn1)
		{
			unchecked 
			{
				object d3 = ( (global::haxe.lang.Runtime.eq(__fn_dyn1, global::haxe.lang.Runtime.undefined)) ? (((object) (__fn_float1) )) : (((object) (__fn_dyn1) )) );
				return new global::alphatab.platform.svg.SvgCanvas();
			}
		}
		
		
	}
}



#pragma warning disable 109, 114, 219, 429, 168, 162
namespace alphatab
{
	public  class Environment_new_89__Fun : global::haxe.lang.Function 
	{
		public    Environment_new_89__Fun() : base(0, 0)
		{
			unchecked 
			{
			}
		}
		
		
		public static  global::alphatab.Environment_new_89__Fun __hx_current;
		
		public override   object __hx_invoke0_o()
		{
			unchecked 
			{
				return new global::alphatab.platform.sys.SysFileLoader();
			}
		}
		
		
	}
}



#pragma warning disable 109, 114, 219, 429, 168, 162
namespace alphatab
{
	public  class Environment_new_100__Fun : global::haxe.lang.Function 
	{
		public    Environment_new_100__Fun() : base(1, 0)
		{
			unchecked 
			{
			}
		}
		
		
		public static  global::alphatab.Environment_new_100__Fun __hx_current;
		
		public override   object __hx_invoke1_o(double __fn_float1, object __fn_dyn1)
		{
			unchecked 
			{
				global::alphatab.rendering.ScoreRenderer r = ( (global::haxe.lang.Runtime.eq(__fn_dyn1, global::haxe.lang.Runtime.undefined)) ? (((global::alphatab.rendering.ScoreRenderer) (((object) (__fn_float1) )) )) : (((global::alphatab.rendering.ScoreRenderer) (__fn_dyn1) )) );
				return new global::alphatab.rendering.layout.PageViewLayout(((global::alphatab.rendering.ScoreRenderer) (r) ));
			}
		}
		
		
	}
}



#pragma warning disable 109, 114, 219, 429, 168, 162
namespace alphatab
{
	public  class Environment_new_101__Fun : global::haxe.lang.Function 
	{
		public    Environment_new_101__Fun() : base(1, 0)
		{
			unchecked 
			{
			}
		}
		
		
		public static  global::alphatab.Environment_new_101__Fun __hx_current;
		
		public override   object __hx_invoke1_o(double __fn_float1, object __fn_dyn1)
		{
			unchecked 
			{
				global::alphatab.rendering.ScoreRenderer r1 = ( (global::haxe.lang.Runtime.eq(__fn_dyn1, global::haxe.lang.Runtime.undefined)) ? (((global::alphatab.rendering.ScoreRenderer) (((object) (__fn_float1) )) )) : (((global::alphatab.rendering.ScoreRenderer) (__fn_dyn1) )) );
				return new global::alphatab.rendering.layout.PageViewLayout(((global::alphatab.rendering.ScoreRenderer) (r1) ));
			}
		}
		
		
	}
}



#pragma warning disable 109, 114, 219, 429, 168, 162
namespace alphatab
{
	public  class Environment_new_102__Fun : global::haxe.lang.Function 
	{
		public    Environment_new_102__Fun() : base(1, 0)
		{
			unchecked 
			{
			}
		}
		
		
		public static  global::alphatab.Environment_new_102__Fun __hx_current;
		
		public override   object __hx_invoke1_o(double __fn_float1, object __fn_dyn1)
		{
			unchecked 
			{
				global::alphatab.rendering.ScoreRenderer r2 = ( (global::haxe.lang.Runtime.eq(__fn_dyn1, global::haxe.lang.Runtime.undefined)) ? (((global::alphatab.rendering.ScoreRenderer) (((object) (__fn_float1) )) )) : (((global::alphatab.rendering.ScoreRenderer) (__fn_dyn1) )) );
				return new global::alphatab.rendering.layout.HorizontalScreenLayout(((global::alphatab.rendering.ScoreRenderer) (r2) ));
			}
		}
		
		
	}
}



#pragma warning disable 109, 114, 219, 429, 168, 162
namespace alphatab
{
	public  class Environment_new_105__Fun : global::haxe.lang.Function 
	{
		public    Environment_new_105__Fun() : base(1, 0)
		{
			unchecked 
			{
			}
		}
		
		
		public static  global::alphatab.Environment_new_105__Fun __hx_current;
		
		public override   object __hx_invoke1_o(double __fn_float1, object __fn_dyn1)
		{
			unchecked 
			{
				global::alphatab.rendering.layout.ScoreLayout l = ( (global::haxe.lang.Runtime.eq(__fn_dyn1, global::haxe.lang.Runtime.undefined)) ? (((global::alphatab.rendering.layout.ScoreLayout) (((object) (__fn_float1) )) )) : (((global::alphatab.rendering.layout.ScoreLayout) (__fn_dyn1) )) );
				return new global::alphatab.rendering.EffectBarRendererFactory(((global::alphatab.rendering.IEffectBarRendererInfo) (new global::alphatab.rendering.effects.MarkerEffectInfo()) ));
			}
		}
		
		
	}
}



#pragma warning disable 109, 114, 219, 429, 168, 162
namespace alphatab
{
	public  class Environment_new_107__Fun : global::haxe.lang.Function 
	{
		public    Environment_new_107__Fun() : base(1, 0)
		{
			unchecked 
			{
			}
		}
		
		
		public static  global::alphatab.Environment_new_107__Fun __hx_current;
		
		public override   object __hx_invoke1_o(double __fn_float1, object __fn_dyn1)
		{
			unchecked 
			{
				global::alphatab.rendering.layout.ScoreLayout l1 = ( (global::haxe.lang.Runtime.eq(__fn_dyn1, global::haxe.lang.Runtime.undefined)) ? (((global::alphatab.rendering.layout.ScoreLayout) (((object) (__fn_float1) )) )) : (((global::alphatab.rendering.layout.ScoreLayout) (__fn_dyn1) )) );
				return new global::alphatab.rendering.EffectBarRendererFactory(((global::alphatab.rendering.IEffectBarRendererInfo) (new global::alphatab.rendering.effects.TempoEffectInfo()) ));
			}
		}
		
		
	}
}



#pragma warning disable 109, 114, 219, 429, 168, 162
namespace alphatab
{
	public  class Environment_new_108__Fun : global::haxe.lang.Function 
	{
		public    Environment_new_108__Fun() : base(1, 0)
		{
			unchecked 
			{
			}
		}
		
		
		public static  global::alphatab.Environment_new_108__Fun __hx_current;
		
		public override   object __hx_invoke1_o(double __fn_float1, object __fn_dyn1)
		{
			unchecked 
			{
				global::alphatab.rendering.layout.ScoreLayout l2 = ( (global::haxe.lang.Runtime.eq(__fn_dyn1, global::haxe.lang.Runtime.undefined)) ? (((global::alphatab.rendering.layout.ScoreLayout) (((object) (__fn_float1) )) )) : (((global::alphatab.rendering.layout.ScoreLayout) (__fn_dyn1) )) );
				return new global::alphatab.rendering.EffectBarRendererFactory(((global::alphatab.rendering.IEffectBarRendererInfo) (new global::alphatab.rendering.effects.TextEffectInfo()) ));
			}
		}
		
		
	}
}



#pragma warning disable 109, 114, 219, 429, 168, 162
namespace alphatab
{
	public  class Environment_new_109__Fun : global::haxe.lang.Function 
	{
		public    Environment_new_109__Fun() : base(1, 0)
		{
			unchecked 
			{
			}
		}
		
		
		public static  global::alphatab.Environment_new_109__Fun __hx_current;
		
		public override   object __hx_invoke1_o(double __fn_float1, object __fn_dyn1)
		{
			unchecked 
			{
				global::alphatab.rendering.layout.ScoreLayout l3 = ( (global::haxe.lang.Runtime.eq(__fn_dyn1, global::haxe.lang.Runtime.undefined)) ? (((global::alphatab.rendering.layout.ScoreLayout) (((object) (__fn_float1) )) )) : (((global::alphatab.rendering.layout.ScoreLayout) (__fn_dyn1) )) );
				return new global::alphatab.rendering.EffectBarRendererFactory(((global::alphatab.rendering.IEffectBarRendererInfo) (new global::alphatab.rendering.effects.ChordsEffectInfo()) ));
			}
		}
		
		
	}
}



#pragma warning disable 109, 114, 219, 429, 168, 162
namespace alphatab
{
	public  class Environment_new_110__Fun : global::haxe.lang.Function 
	{
		public    Environment_new_110__Fun() : base(1, 0)
		{
			unchecked 
			{
			}
		}
		
		
		public static  global::alphatab.Environment_new_110__Fun __hx_current;
		
		public override   object __hx_invoke1_o(double __fn_float1, object __fn_dyn1)
		{
			unchecked 
			{
				global::alphatab.rendering.layout.ScoreLayout l4 = ( (global::haxe.lang.Runtime.eq(__fn_dyn1, global::haxe.lang.Runtime.undefined)) ? (((global::alphatab.rendering.layout.ScoreLayout) (((object) (__fn_float1) )) )) : (((global::alphatab.rendering.layout.ScoreLayout) (__fn_dyn1) )) );
				return new global::alphatab.rendering.EffectBarRendererFactory(((global::alphatab.rendering.IEffectBarRendererInfo) (new global::alphatab.rendering.effects.TrillEffectInfo()) ));
			}
		}
		
		
	}
}



#pragma warning disable 109, 114, 219, 429, 168, 162
namespace alphatab
{
	public  class Environment_new_111__Fun : global::haxe.lang.Function 
	{
		public    Environment_new_111__Fun() : base(1, 0)
		{
			unchecked 
			{
			}
		}
		
		
		public static  global::alphatab.Environment_new_111__Fun __hx_current;
		
		public override   object __hx_invoke1_o(double __fn_float1, object __fn_dyn1)
		{
			unchecked 
			{
				global::alphatab.rendering.layout.ScoreLayout l5 = ( (global::haxe.lang.Runtime.eq(__fn_dyn1, global::haxe.lang.Runtime.undefined)) ? (((global::alphatab.rendering.layout.ScoreLayout) (((object) (__fn_float1) )) )) : (((global::alphatab.rendering.layout.ScoreLayout) (__fn_dyn1) )) );
				return new global::alphatab.rendering.EffectBarRendererFactory(((global::alphatab.rendering.IEffectBarRendererInfo) (new global::alphatab.rendering.effects.BeatVibratoEffectInfo()) ));
			}
		}
		
		
	}
}



#pragma warning disable 109, 114, 219, 429, 168, 162
namespace alphatab
{
	public  class Environment_new_112__Fun : global::haxe.lang.Function 
	{
		public    Environment_new_112__Fun() : base(1, 0)
		{
			unchecked 
			{
			}
		}
		
		
		public static  global::alphatab.Environment_new_112__Fun __hx_current;
		
		public override   object __hx_invoke1_o(double __fn_float1, object __fn_dyn1)
		{
			unchecked 
			{
				global::alphatab.rendering.layout.ScoreLayout l6 = ( (global::haxe.lang.Runtime.eq(__fn_dyn1, global::haxe.lang.Runtime.undefined)) ? (((global::alphatab.rendering.layout.ScoreLayout) (((object) (__fn_float1) )) )) : (((global::alphatab.rendering.layout.ScoreLayout) (__fn_dyn1) )) );
				return new global::alphatab.rendering.EffectBarRendererFactory(((global::alphatab.rendering.IEffectBarRendererInfo) (new global::alphatab.rendering.effects.NoteVibratoEffectInfo()) ));
			}
		}
		
		
	}
}



#pragma warning disable 109, 114, 219, 429, 168, 162
namespace alphatab
{
	public  class Environment_new_113__Fun : global::haxe.lang.Function 
	{
		public    Environment_new_113__Fun() : base(1, 0)
		{
			unchecked 
			{
			}
		}
		
		
		public static  global::alphatab.Environment_new_113__Fun __hx_current;
		
		public override   object __hx_invoke1_o(double __fn_float1, object __fn_dyn1)
		{
			unchecked 
			{
				global::alphatab.rendering.layout.ScoreLayout l7 = ( (global::haxe.lang.Runtime.eq(__fn_dyn1, global::haxe.lang.Runtime.undefined)) ? (((global::alphatab.rendering.layout.ScoreLayout) (((object) (__fn_float1) )) )) : (((global::alphatab.rendering.layout.ScoreLayout) (__fn_dyn1) )) );
				return new global::alphatab.rendering.AlternateEndingsBarRendererFactory();
			}
		}
		
		
	}
}



#pragma warning disable 109, 114, 219, 429, 168, 162
namespace alphatab
{
	public  class Environment_new_114__Fun : global::haxe.lang.Function 
	{
		public    Environment_new_114__Fun() : base(1, 0)
		{
			unchecked 
			{
			}
		}
		
		
		public static  global::alphatab.Environment_new_114__Fun __hx_current;
		
		public override   object __hx_invoke1_o(double __fn_float1, object __fn_dyn1)
		{
			unchecked 
			{
				global::alphatab.rendering.layout.ScoreLayout l8 = ( (global::haxe.lang.Runtime.eq(__fn_dyn1, global::haxe.lang.Runtime.undefined)) ? (((global::alphatab.rendering.layout.ScoreLayout) (((object) (__fn_float1) )) )) : (((global::alphatab.rendering.layout.ScoreLayout) (__fn_dyn1) )) );
				return new global::alphatab.rendering.ScoreBarRendererFactory();
			}
		}
		
		
	}
}



#pragma warning disable 109, 114, 219, 429, 168, 162
namespace alphatab
{
	public  class Environment_new_115__Fun : global::haxe.lang.Function 
	{
		public    Environment_new_115__Fun() : base(1, 0)
		{
			unchecked 
			{
			}
		}
		
		
		public static  global::alphatab.Environment_new_115__Fun __hx_current;
		
		public override   object __hx_invoke1_o(double __fn_float1, object __fn_dyn1)
		{
			unchecked 
			{
				global::alphatab.rendering.layout.ScoreLayout l9 = ( (global::haxe.lang.Runtime.eq(__fn_dyn1, global::haxe.lang.Runtime.undefined)) ? (((global::alphatab.rendering.layout.ScoreLayout) (((object) (__fn_float1) )) )) : (((global::alphatab.rendering.layout.ScoreLayout) (__fn_dyn1) )) );
				return new global::alphatab.rendering.EffectBarRendererFactory(((global::alphatab.rendering.IEffectBarRendererInfo) (new global::alphatab.rendering.effects.CrescendoEffectInfo()) ));
			}
		}
		
		
	}
}



#pragma warning disable 109, 114, 219, 429, 168, 162
namespace alphatab
{
	public  class Environment_new_116__Fun : global::haxe.lang.Function 
	{
		public    Environment_new_116__Fun() : base(1, 0)
		{
			unchecked 
			{
			}
		}
		
		
		public static  global::alphatab.Environment_new_116__Fun __hx_current;
		
		public override   object __hx_invoke1_o(double __fn_float1, object __fn_dyn1)
		{
			unchecked 
			{
				global::alphatab.rendering.layout.ScoreLayout l10 = ( (global::haxe.lang.Runtime.eq(__fn_dyn1, global::haxe.lang.Runtime.undefined)) ? (((global::alphatab.rendering.layout.ScoreLayout) (((object) (__fn_float1) )) )) : (((global::alphatab.rendering.layout.ScoreLayout) (__fn_dyn1) )) );
				return new global::alphatab.rendering.EffectBarRendererFactory(((global::alphatab.rendering.IEffectBarRendererInfo) (new global::alphatab.rendering.effects.DynamicsEffectInfo()) ));
			}
		}
		
		
	}
}



#pragma warning disable 109, 114, 219, 429, 168, 162
namespace alphatab
{
	public  class Environment_new_117__Fun : global::haxe.lang.Function 
	{
		public    Environment_new_117__Fun() : base(1, 0)
		{
			unchecked 
			{
			}
		}
		
		
		public static  global::alphatab.Environment_new_117__Fun __hx_current;
		
		public override   object __hx_invoke1_o(double __fn_float1, object __fn_dyn1)
		{
			unchecked 
			{
				global::alphatab.rendering.layout.ScoreLayout l11 = ( (global::haxe.lang.Runtime.eq(__fn_dyn1, global::haxe.lang.Runtime.undefined)) ? (((global::alphatab.rendering.layout.ScoreLayout) (((object) (__fn_float1) )) )) : (((global::alphatab.rendering.layout.ScoreLayout) (__fn_dyn1) )) );
				return new global::alphatab.rendering.EffectBarRendererFactory(((global::alphatab.rendering.IEffectBarRendererInfo) (new global::alphatab.rendering.effects.TapEffectInfo()) ));
			}
		}
		
		
	}
}



#pragma warning disable 109, 114, 219, 429, 168, 162
namespace alphatab
{
	public  class Environment_new_118__Fun : global::haxe.lang.Function 
	{
		public    Environment_new_118__Fun() : base(1, 0)
		{
			unchecked 
			{
			}
		}
		
		
		public static  global::alphatab.Environment_new_118__Fun __hx_current;
		
		public override   object __hx_invoke1_o(double __fn_float1, object __fn_dyn1)
		{
			unchecked 
			{
				global::alphatab.rendering.layout.ScoreLayout l12 = ( (global::haxe.lang.Runtime.eq(__fn_dyn1, global::haxe.lang.Runtime.undefined)) ? (((global::alphatab.rendering.layout.ScoreLayout) (((object) (__fn_float1) )) )) : (((global::alphatab.rendering.layout.ScoreLayout) (__fn_dyn1) )) );
				return new global::alphatab.rendering.EffectBarRendererFactory(((global::alphatab.rendering.IEffectBarRendererInfo) (new global::alphatab.rendering.effects.FadeInEffectInfo()) ));
			}
		}
		
		
	}
}



#pragma warning disable 109, 114, 219, 429, 168, 162
namespace alphatab
{
	public  class Environment_new_119__Fun : global::haxe.lang.Function 
	{
		public    Environment_new_119__Fun() : base(1, 0)
		{
			unchecked 
			{
			}
		}
		
		
		public static  global::alphatab.Environment_new_119__Fun __hx_current;
		
		public override   object __hx_invoke1_o(double __fn_float1, object __fn_dyn1)
		{
			unchecked 
			{
				global::alphatab.rendering.layout.ScoreLayout l13 = ( (global::haxe.lang.Runtime.eq(__fn_dyn1, global::haxe.lang.Runtime.undefined)) ? (((global::alphatab.rendering.layout.ScoreLayout) (((object) (__fn_float1) )) )) : (((global::alphatab.rendering.layout.ScoreLayout) (__fn_dyn1) )) );
				return new global::alphatab.rendering.EffectBarRendererFactory(((global::alphatab.rendering.IEffectBarRendererInfo) (new global::alphatab.rendering.effects.LetRingEffectInfo()) ));
			}
		}
		
		
	}
}



#pragma warning disable 109, 114, 219, 429, 168, 162
namespace alphatab
{
	public  class Environment_new_120__Fun : global::haxe.lang.Function 
	{
		public    Environment_new_120__Fun() : base(1, 0)
		{
			unchecked 
			{
			}
		}
		
		
		public static  global::alphatab.Environment_new_120__Fun __hx_current;
		
		public override   object __hx_invoke1_o(double __fn_float1, object __fn_dyn1)
		{
			unchecked 
			{
				global::alphatab.rendering.layout.ScoreLayout l14 = ( (global::haxe.lang.Runtime.eq(__fn_dyn1, global::haxe.lang.Runtime.undefined)) ? (((global::alphatab.rendering.layout.ScoreLayout) (((object) (__fn_float1) )) )) : (((global::alphatab.rendering.layout.ScoreLayout) (__fn_dyn1) )) );
				return new global::alphatab.rendering.EffectBarRendererFactory(((global::alphatab.rendering.IEffectBarRendererInfo) (new global::alphatab.rendering.effects.PalmMuteEffectInfo()) ));
			}
		}
		
		
	}
}



#pragma warning disable 109, 114, 219, 429, 168, 162
namespace alphatab
{
	public  class Environment_new_121__Fun : global::haxe.lang.Function 
	{
		public    Environment_new_121__Fun() : base(1, 0)
		{
			unchecked 
			{
			}
		}
		
		
		public static  global::alphatab.Environment_new_121__Fun __hx_current;
		
		public override   object __hx_invoke1_o(double __fn_float1, object __fn_dyn1)
		{
			unchecked 
			{
				global::alphatab.rendering.layout.ScoreLayout l15 = ( (global::haxe.lang.Runtime.eq(__fn_dyn1, global::haxe.lang.Runtime.undefined)) ? (((global::alphatab.rendering.layout.ScoreLayout) (((object) (__fn_float1) )) )) : (((global::alphatab.rendering.layout.ScoreLayout) (__fn_dyn1) )) );
				return new global::alphatab.rendering.TabBarRendererFactory();
			}
		}
		
		
	}
}



#pragma warning disable 109, 114, 219, 429, 168, 162
namespace alphatab
{
	public  class Environment_new_122__Fun : global::haxe.lang.Function 
	{
		public    Environment_new_122__Fun() : base(1, 0)
		{
			unchecked 
			{
			}
		}
		
		
		public static  global::alphatab.Environment_new_122__Fun __hx_current;
		
		public override   object __hx_invoke1_o(double __fn_float1, object __fn_dyn1)
		{
			unchecked 
			{
				global::alphatab.rendering.layout.ScoreLayout l16 = ( (global::haxe.lang.Runtime.eq(__fn_dyn1, global::haxe.lang.Runtime.undefined)) ? (((global::alphatab.rendering.layout.ScoreLayout) (((object) (__fn_float1) )) )) : (((global::alphatab.rendering.layout.ScoreLayout) (__fn_dyn1) )) );
				return new global::alphatab.rendering.EffectBarRendererFactory(((global::alphatab.rendering.IEffectBarRendererInfo) (new global::alphatab.rendering.effects.PickStrokeEffectInfo()) ));
			}
		}
		
		
	}
}


