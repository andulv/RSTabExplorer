using haxe.root;
#pragma warning disable 109, 114, 219, 429, 168, 162
namespace alphatab.rendering.effects
{
	public  class TripletFeelEffectInfo : global::haxe.lang.HxObject, global::alphatab.rendering.IEffectBarRendererInfo 
	{
		public    TripletFeelEffectInfo(global::haxe.lang.EmptyObject empty)
		{
			unchecked 
			{
				{
				}
				
			}
		}
		
		
		public    TripletFeelEffectInfo()
		{
			unchecked 
			{
				global::alphatab.rendering.effects.TripletFeelEffectInfo.__hx_ctor_alphatab_rendering_effects_TripletFeelEffectInfo(this);
			}
		}
		
		
		public static   void __hx_ctor_alphatab_rendering_effects_TripletFeelEffectInfo(global::alphatab.rendering.effects.TripletFeelEffectInfo __temp_me106)
		{
			unchecked 
			{
				{
				}
				
			}
		}
		
		
		public static  new object __hx_createEmpty()
		{
			unchecked 
			{
				return new global::alphatab.rendering.effects.TripletFeelEffectInfo(((global::haxe.lang.EmptyObject) (global::haxe.lang.EmptyObject.EMPTY) ));
			}
		}
		
		
		public static  new object __hx_create(global::haxe.root.Array arr)
		{
			unchecked 
			{
				return new global::alphatab.rendering.effects.TripletFeelEffectInfo();
			}
		}
		
		
		public virtual   bool shouldCreateGlyph(global::alphatab.rendering.EffectBarRenderer renderer, global::alphatab.model.Beat beat)
		{
			unchecked 
			{
				bool __temp_boolv580 = ( beat.index == 0 );
				bool __temp_boolv579 = false;
				if (__temp_boolv580) 
				{
					global::alphatab.model.MasterBar __temp_stmt584 = default(global::alphatab.model.MasterBar);
					{
						global::alphatab.model.Bar _this = beat.voice.bar;
						__temp_stmt584 = ((global::alphatab.model.MasterBar) (_this.track.score.masterBars[_this.index]) );
					}
					
					bool __temp_boolv583 = ( __temp_stmt584.index == 0 );
					bool __temp_boolv582 = false;
					if (__temp_boolv583) 
					{
						global::alphatab.model.MasterBar __temp_stmt585 = default(global::alphatab.model.MasterBar);
						{
							global::alphatab.model.Bar _this1 = beat.voice.bar;
							__temp_stmt585 = ((global::alphatab.model.MasterBar) (_this1.track.score.masterBars[_this1.index]) );
						}
						
						__temp_boolv582 = ( __temp_stmt585.tripletFeel != global::alphatab.model.TripletFeel.NoTripletFeel );
					}
					
					bool __temp_stmt581 = ( __temp_boolv583 && __temp_boolv582 );
					__temp_boolv579 = (__temp_stmt581);
				}
				
				bool __temp_stmt578 = ( __temp_boolv580 && __temp_boolv579 );
				bool __temp_boolv586 = false;
				if ( ! (__temp_stmt578) ) 
				{
					global::alphatab.model.MasterBar __temp_stmt589 = default(global::alphatab.model.MasterBar);
					{
						global::alphatab.model.Bar _this2 = beat.voice.bar;
						__temp_stmt589 = ((global::alphatab.model.MasterBar) (_this2.track.score.masterBars[_this2.index]) );
					}
					
					bool __temp_boolv588 = ( __temp_stmt589.index > 0 );
					bool __temp_boolv587 = false;
					if (__temp_boolv588) 
					{
						global::alphatab.model.MasterBar __temp_stmt590 = default(global::alphatab.model.MasterBar);
						{
							global::alphatab.model.Bar _this3 = beat.voice.bar;
							__temp_stmt590 = ((global::alphatab.model.MasterBar) (_this3.track.score.masterBars[_this3.index]) );
						}
						
						global::alphatab.model.MasterBar __temp_stmt591 = default(global::alphatab.model.MasterBar);
						{
							global::alphatab.model.Bar _this4 = beat.voice.bar;
							__temp_stmt591 = ((global::alphatab.model.MasterBar) (_this4.track.score.masterBars[_this4.index]) );
						}
						
						__temp_boolv587 = ( __temp_stmt590.tripletFeel != __temp_stmt591.previousMasterBar.tripletFeel );
					}
					
					__temp_boolv586 = ( __temp_boolv588 && __temp_boolv587 );
				}
				
				bool __temp_stmt577 = ( __temp_stmt578 || __temp_boolv586 );
				return __temp_stmt577;
			}
		}
		
		
		public virtual   bool canExpand(global::alphatab.rendering.EffectBarRenderer renderer, global::alphatab.model.Beat @from, global::alphatab.model.Beat to)
		{
			unchecked 
			{
				return true;
			}
		}
		
		
		public virtual   int getHeight(global::alphatab.rendering.EffectBarRenderer renderer)
		{
			unchecked 
			{
				return ((int) (( 20 * renderer.stave.staveGroup.layout.renderer.settings.scale )) );
			}
		}
		
		
		public virtual   global::alphatab.rendering.EffectBarGlyphSizing getSizingMode()
		{
			unchecked 
			{
				return global::alphatab.rendering.EffectBarGlyphSizing.SinglePreBeatOnly;
			}
		}
		
		
		public virtual   global::alphatab.rendering.Glyph createNewGlyph(global::alphatab.rendering.EffectBarRenderer renderer, global::alphatab.model.Beat beat)
		{
			unchecked 
			{
				return new global::alphatab.rendering.glyphs.effects.DummyEffectGlyph(new global::haxe.lang.Null<int>(0, true), new global::haxe.lang.Null<int>(0, true), global::haxe.lang.Runtime.toString("TripletFeel"));
			}
		}
		
		
		public override   object __hx_getField(string field, int hash, bool throwErrors, bool isCheck, bool handleProperties)
		{
			unchecked 
			{
				switch (hash)
				{
					case 193577032:
					{
						return ((global::haxe.lang.Function) (new global::haxe.lang.Closure(((object) (this) ), global::haxe.lang.Runtime.toString("createNewGlyph"), ((int) (193577032) ))) );
					}
					
					
					case 268685047:
					{
						return ((global::haxe.lang.Function) (new global::haxe.lang.Closure(((object) (this) ), global::haxe.lang.Runtime.toString("getSizingMode"), ((int) (268685047) ))) );
					}
					
					
					case 2124583197:
					{
						return ((global::haxe.lang.Function) (new global::haxe.lang.Closure(((object) (this) ), global::haxe.lang.Runtime.toString("getHeight"), ((int) (2124583197) ))) );
					}
					
					
					case 381239946:
					{
						return ((global::haxe.lang.Function) (new global::haxe.lang.Closure(((object) (this) ), global::haxe.lang.Runtime.toString("canExpand"), ((int) (381239946) ))) );
					}
					
					
					case 286784413:
					{
						return ((global::haxe.lang.Function) (new global::haxe.lang.Closure(((object) (this) ), global::haxe.lang.Runtime.toString("shouldCreateGlyph"), ((int) (286784413) ))) );
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
					case 193577032:
					{
						return this.createNewGlyph(((global::alphatab.rendering.EffectBarRenderer) (dynargs[0]) ), ((global::alphatab.model.Beat) (dynargs[1]) ));
					}
					
					
					case 268685047:
					{
						return this.getSizingMode();
					}
					
					
					case 2124583197:
					{
						return this.getHeight(((global::alphatab.rendering.EffectBarRenderer) (dynargs[0]) ));
					}
					
					
					case 381239946:
					{
						return this.canExpand(((global::alphatab.rendering.EffectBarRenderer) (dynargs[0]) ), ((global::alphatab.model.Beat) (dynargs[1]) ), ((global::alphatab.model.Beat) (dynargs[2]) ));
					}
					
					
					case 286784413:
					{
						return this.shouldCreateGlyph(((global::alphatab.rendering.EffectBarRenderer) (dynargs[0]) ), ((global::alphatab.model.Beat) (dynargs[1]) ));
					}
					
					
					default:
					{
						return base.__hx_invokeField(field, hash, dynargs);
					}
					
				}
				
			}
		}
		
		
	}
}


