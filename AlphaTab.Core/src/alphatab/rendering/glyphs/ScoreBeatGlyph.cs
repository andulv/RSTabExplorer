using haxe.root;
#pragma warning disable 109, 114, 219, 429, 168, 162
namespace alphatab.rendering.glyphs
{
	public  class ScoreBeatGlyph : global::alphatab.rendering.glyphs.BeatGlyphBase, global::alphatab.rendering.glyphs.ISupportsFinalize 
	{
		public    ScoreBeatGlyph(global::haxe.lang.EmptyObject empty) : base(global::haxe.lang.EmptyObject.EMPTY)
		{
			unchecked 
			{
			}
		}
		
		
		public    ScoreBeatGlyph() : base(global::haxe.lang.EmptyObject.EMPTY)
		{
			unchecked 
			{
				global::alphatab.rendering.glyphs.ScoreBeatGlyph.__hx_ctor_alphatab_rendering_glyphs_ScoreBeatGlyph(this);
			}
		}
		
		
		public static   void __hx_ctor_alphatab_rendering_glyphs_ScoreBeatGlyph(global::alphatab.rendering.glyphs.ScoreBeatGlyph __temp_me191)
		{
			unchecked 
			{
				global::alphatab.rendering.glyphs.BeatGlyphBase.__hx_ctor_alphatab_rendering_glyphs_BeatGlyphBase(__temp_me191);
			}
		}
		
		
		public static  new object __hx_createEmpty()
		{
			unchecked 
			{
				return new global::alphatab.rendering.glyphs.ScoreBeatGlyph(((global::haxe.lang.EmptyObject) (global::haxe.lang.EmptyObject.EMPTY) ));
			}
		}
		
		
		public static  new object __hx_create(global::haxe.root.Array arr)
		{
			unchecked 
			{
				return new global::alphatab.rendering.glyphs.ScoreBeatGlyph();
			}
		}
		
		
		public  global::haxe.root.Array<object> _ties;
		
		public  global::alphatab.rendering.glyphs.ScoreNoteChordGlyph noteHeads;
		
		public  global::alphatab.rendering.glyphs.RestGlyph restGlyph;
		
		public  global::alphatab.rendering.utils.BeamingHelper beamingHelper;
		
		public virtual   void finalizeGlyph(global::alphatab.rendering.layout.ScoreLayout layout)
		{
			unchecked 
			{
				if ( ! (this.container.beat.isRest()) ) 
				{
					this.noteHeads.updateBeamingHelper(( this.container.x + this.x ));
				}
				
			}
		}
		
		
		public override   void applyGlyphSpacing(int spacing)
		{
			unchecked 
			{
				base.applyGlyphSpacing(spacing);
				if ( ! (this.container.beat.isRest()) ) 
				{
					this.noteHeads.updateBeamingHelper(( this.container.x + this.x ));
				}
				
			}
		}
		
		
		public override   void doLayout()
		{
			unchecked 
			{
				global::haxe.root.Array<object> _g = new global::haxe.root.Array<object>(new object[]{this});
				if ( ! (this.container.beat.isEmpty) ) 
				{
					if ( ! (this.container.beat.isRest()) ) 
					{
						this.noteHeads = new global::alphatab.rendering.glyphs.ScoreNoteChordGlyph(((global::haxe.lang.Null<int>) (default(global::haxe.lang.Null<int>)) ), ((global::haxe.lang.Null<int>) (default(global::haxe.lang.Null<int>)) ));
						this.noteHeads.beat = this.container.beat;
						this.noteHeads.beamingHelper = this.beamingHelper;
						this.noteLoop(new global::alphatab.rendering.glyphs.ScoreBeatGlyph_doLayout_80__Fun(((global::haxe.root.Array<object>) (global::haxe.root.Array<object>.__hx_cast<object>(((global::haxe.root.Array) (_g) ))) )));
						this.addGlyph(this.noteHeads);
						{
							int _g1 = 0;
							int _g2 = this.container.beat.dots;
							while (( _g1 < _g2 ))
							{
								int i = _g1++;
								global::haxe.root.Array<object> @group = new global::haxe.root.Array<object>(new object[]{new global::alphatab.rendering.glyphs.GlyphGroup(((global::haxe.lang.Null<int>) (default(global::haxe.lang.Null<int>)) ), ((global::haxe.lang.Null<int>) (default(global::haxe.lang.Null<int>)) ), ((global::haxe.root.Array<object>) (global::haxe.root.Array<object>.__hx_cast<object>(((global::haxe.root.Array) (default(global::haxe.root.Array<object>)) ))) ))});
								this.noteLoop(new global::alphatab.rendering.glyphs.ScoreBeatGlyph_doLayout_91__Fun(((global::haxe.root.Array<object>) (global::haxe.root.Array<object>.__hx_cast<object>(((global::haxe.root.Array) (_g) ))) ), ((global::haxe.root.Array<object>) (global::haxe.root.Array<object>.__hx_cast<object>(((global::haxe.root.Array) (@group) ))) )));
								this.addGlyph(((global::alphatab.rendering.glyphs.GlyphGroup) (@group[0]) ));
							}
							
						}
						
					}
					 else 
					{
						int line = 0;
						int offset = 0;
						{
							global::alphatab.model.Duration _g3 = this.container.beat.duration;
							switch (global::haxe.root.Type.enumIndex(_g3))
							{
								case 0:
								{
									line = 4;
									break;
								}
								
								
								case 1:
								{
									line = 5;
									break;
								}
								
								
								case 2:
								{
									line = 7;
									offset = -2;
									break;
								}
								
								
								case 3:
								{
									line = 8;
									break;
								}
								
								
								case 4:
								{
									line = 8;
									break;
								}
								
								
								case 5:
								{
									line = 8;
									break;
								}
								
								
								case 6:
								{
									line = 8;
									break;
								}
								
								
							}
							
						}
						
						global::alphatab.rendering.ScoreBarRenderer sr = default(global::alphatab.rendering.ScoreBarRenderer);
						sr = ((global::alphatab.rendering.ScoreBarRenderer) (this.renderer) );
						int y = sr.getScoreY(line, new global::haxe.lang.Null<int>(offset, true));
						this.addGlyph(new global::alphatab.rendering.glyphs.RestGlyph(new global::haxe.lang.Null<int>(0, true), new global::haxe.lang.Null<int>(y, true), ((global::alphatab.model.Duration) (this.container.beat.duration) )));
					}
					
				}
				
				base.doLayout();
				if (( this.noteHeads != default(global::alphatab.rendering.glyphs.ScoreNoteChordGlyph) )) 
				{
					this.noteHeads.updateBeamingHelper(this.x);
				}
				
			}
		}
		
		
		public virtual   void createBeatDot(global::alphatab.model.Note n, global::alphatab.rendering.glyphs.GlyphGroup @group)
		{
			unchecked 
			{
				global::alphatab.rendering.ScoreBarRenderer sr = default(global::alphatab.rendering.ScoreBarRenderer);
				sr = ((global::alphatab.rendering.ScoreBarRenderer) (this.renderer) );
				@group.addGlyph(new global::alphatab.rendering.glyphs.CircleGlyph(new global::haxe.lang.Null<int>(0, true), new global::haxe.lang.Null<int>(sr.getScoreY(sr.getNoteLine(n), new global::haxe.lang.Null<int>(((int) (( 2 * this.renderer.stave.staveGroup.layout.renderer.settings.scale )) ), true)), true), ((double) (( 1.5 * this.renderer.stave.staveGroup.layout.renderer.settings.scale )) )));
			}
		}
		
		
		public virtual   global::alphatab.rendering.Glyph createNoteHeadGlyph(global::alphatab.model.Note n)
		{
			unchecked 
			{
				bool isGrace = ( this.container.beat.graceType != global::alphatab.model.GraceType.None );
				if (n.beat.voice.bar.track.isPercussion) 
				{
					global::haxe.root.Array<int> normalKeys = new global::haxe.root.Array<int>(new int[]{32, 34, 35, 36, 38, 39, 40, 41, 43, 45, 47, 48, 50, 55, 56, 58, 60, 61});
					global::haxe.root.Array<int> xKeys = new global::haxe.root.Array<int>(new int[]{31, 33, 37, 42, 44, 54, 62, 63, 64, 65, 66});
					int @value = ( n.fret + n.beat.voice.bar.track.tuning[( ( n.beat.voice.bar.track.tuning.length - (( n.@string - 1 )) ) - 1 )] );
					if (( ( ( @value <= 30 ) || ( @value >= 67 ) ) || global::haxe.root.Lambda.has<int>(normalKeys, @value) )) 
					{
						return new global::alphatab.rendering.glyphs.NoteHeadGlyph(new global::haxe.lang.Null<int>(0, true), new global::haxe.lang.Null<int>(0, true), ((global::alphatab.model.Duration) (global::alphatab.model.Duration.Quarter) ), ((bool) (isGrace) ));
					}
					 else 
					{
						if (global::haxe.root.Lambda.has<int>(xKeys, @value)) 
						{
							return new global::alphatab.rendering.glyphs.DrumSticksGlyph(new global::haxe.lang.Null<int>(0, true), new global::haxe.lang.Null<int>(0, true), ((bool) (isGrace) ));
						}
						 else 
						{
							if (( @value == 46 )) 
							{
								return new global::alphatab.rendering.glyphs.HiHatGlyph(new global::haxe.lang.Null<int>(0, true), new global::haxe.lang.Null<int>(0, true), ((bool) (isGrace) ));
							}
							 else 
							{
								if (( ( @value == 49 ) || ( @value == 57 ) )) 
								{
									return new global::alphatab.rendering.glyphs.DiamondNoteHeadGlyph(new global::haxe.lang.Null<int>(0, true), new global::haxe.lang.Null<int>(0, true), ((bool) (isGrace) ));
								}
								 else 
								{
									if (( @value == 52 )) 
									{
										return new global::alphatab.rendering.glyphs.ChineseCymbalGlyph(new global::haxe.lang.Null<int>(0, true), new global::haxe.lang.Null<int>(0, true), ((bool) (isGrace) ));
									}
									 else 
									{
										if (( ( ( @value == 51 ) || ( @value == 53 ) ) || ( @value == 59 ) )) 
										{
											return new global::alphatab.rendering.glyphs.RideCymbalGlyph(new global::haxe.lang.Null<int>(0, true), new global::haxe.lang.Null<int>(0, true), ((bool) (isGrace) ));
										}
										 else 
										{
											return new global::alphatab.rendering.glyphs.NoteHeadGlyph(new global::haxe.lang.Null<int>(0, true), new global::haxe.lang.Null<int>(0, true), ((global::alphatab.model.Duration) (global::alphatab.model.Duration.Quarter) ), ((bool) (isGrace) ));
										}
										
									}
									
								}
								
							}
							
						}
						
					}
					
				}
				
				if (n.isDead) 
				{
					return new global::alphatab.rendering.glyphs.DeadNoteHeadGlyph(new global::haxe.lang.Null<int>(0, true), new global::haxe.lang.Null<int>(0, true), ((bool) (isGrace) ));
				}
				 else 
				{
					if (( n.harmonicType == global::alphatab.model.HarmonicType.None )) 
					{
						return new global::alphatab.rendering.glyphs.NoteHeadGlyph(new global::haxe.lang.Null<int>(0, true), new global::haxe.lang.Null<int>(0, true), ((global::alphatab.model.Duration) (n.beat.duration) ), ((bool) (isGrace) ));
					}
					 else 
					{
						return new global::alphatab.rendering.glyphs.DiamondNoteHeadGlyph(new global::haxe.lang.Null<int>(0, true), new global::haxe.lang.Null<int>(0, true), ((bool) (isGrace) ));
					}
					
				}
				
			}
		}
		
		
		public virtual   void createNoteGlyph(global::alphatab.model.Note n)
		{
			unchecked 
			{
				global::alphatab.rendering.ScoreBarRenderer sr = default(global::alphatab.rendering.ScoreBarRenderer);
				sr = ((global::alphatab.rendering.ScoreBarRenderer) (this.renderer) );
				global::alphatab.rendering.Glyph noteHeadGlyph = this.createNoteHeadGlyph(n);
				int line = sr.getNoteLine(n);
				noteHeadGlyph.y = sr.getScoreY(line, new global::haxe.lang.Null<int>(-1, true));
				this.noteHeads.addNoteGlyph(noteHeadGlyph, n, line);
				if (( n.isStaccato &&  ! (this.noteHeads.beatEffects.exists("Staccato"))  )) 
				{
					this.noteHeads.beatEffects.@set("Staccato", new global::alphatab.rendering.glyphs.CircleGlyph(new global::haxe.lang.Null<int>(0, true), new global::haxe.lang.Null<int>(0, true), ((double) (1.5) )));
				}
				
				if (( ( n.accentuated == global::alphatab.model.AccentuationType.Normal ) &&  ! (this.noteHeads.beatEffects.exists("Accent"))  )) 
				{
					this.noteHeads.beatEffects.@set("Accent", new global::alphatab.rendering.glyphs.AccentuationGlyph(new global::haxe.lang.Null<int>(0, true), new global::haxe.lang.Null<int>(0, true), ((global::alphatab.model.AccentuationType) (global::alphatab.model.AccentuationType.Normal) )));
				}
				
				if (( ( n.accentuated == global::alphatab.model.AccentuationType.Heavy ) &&  ! (this.noteHeads.beatEffects.exists("HAccent"))  )) 
				{
					this.noteHeads.beatEffects.@set("HAccent", new global::alphatab.rendering.glyphs.AccentuationGlyph(new global::haxe.lang.Null<int>(0, true), new global::haxe.lang.Null<int>(0, true), ((global::alphatab.model.AccentuationType) (global::alphatab.model.AccentuationType.Heavy) )));
				}
				
			}
		}
		
		
		public override   object __hx_setField(string field, int hash, object @value, bool handleProperties)
		{
			unchecked 
			{
				switch (hash)
				{
					case 1692978337:
					{
						this.beamingHelper = ((global::alphatab.rendering.utils.BeamingHelper) (@value) );
						return @value;
					}
					
					
					case 958687736:
					{
						this.restGlyph = ((global::alphatab.rendering.glyphs.RestGlyph) (@value) );
						return @value;
					}
					
					
					case 1648762369:
					{
						this.noteHeads = ((global::alphatab.rendering.glyphs.ScoreNoteChordGlyph) (@value) );
						return @value;
					}
					
					
					case 909570:
					{
						this._ties = ((global::haxe.root.Array<object>) (global::haxe.root.Array<object>.__hx_cast<object>(((global::haxe.root.Array) (@value) ))) );
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
					case 1955004862:
					{
						return ((global::haxe.lang.Function) (new global::haxe.lang.Closure(((object) (this) ), global::haxe.lang.Runtime.toString("createNoteGlyph"), ((int) (1955004862) ))) );
					}
					
					
					case 1753785726:
					{
						return ((global::haxe.lang.Function) (new global::haxe.lang.Closure(((object) (this) ), global::haxe.lang.Runtime.toString("createNoteHeadGlyph"), ((int) (1753785726) ))) );
					}
					
					
					case 1548009239:
					{
						return ((global::haxe.lang.Function) (new global::haxe.lang.Closure(((object) (this) ), global::haxe.lang.Runtime.toString("createBeatDot"), ((int) (1548009239) ))) );
					}
					
					
					case 1825584277:
					{
						return ((global::haxe.lang.Function) (new global::haxe.lang.Closure(((object) (this) ), global::haxe.lang.Runtime.toString("doLayout"), ((int) (1825584277) ))) );
					}
					
					
					case 1827465669:
					{
						return ((global::haxe.lang.Function) (new global::haxe.lang.Closure(((object) (this) ), global::haxe.lang.Runtime.toString("applyGlyphSpacing"), ((int) (1827465669) ))) );
					}
					
					
					case 1308691246:
					{
						return ((global::haxe.lang.Function) (new global::haxe.lang.Closure(((object) (this) ), global::haxe.lang.Runtime.toString("finalizeGlyph"), ((int) (1308691246) ))) );
					}
					
					
					case 1692978337:
					{
						return this.beamingHelper;
					}
					
					
					case 958687736:
					{
						return this.restGlyph;
					}
					
					
					case 1648762369:
					{
						return this.noteHeads;
					}
					
					
					case 909570:
					{
						return this._ties;
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
					case 1827465669:case 1825584277:
					{
						return global::haxe.lang.Runtime.slowCallField(this, field, dynargs);
					}
					
					
					case 1955004862:
					{
						this.createNoteGlyph(((global::alphatab.model.Note) (dynargs[0]) ));
						break;
					}
					
					
					case 1753785726:
					{
						return this.createNoteHeadGlyph(((global::alphatab.model.Note) (dynargs[0]) ));
					}
					
					
					case 1548009239:
					{
						this.createBeatDot(((global::alphatab.model.Note) (dynargs[0]) ), ((global::alphatab.rendering.glyphs.GlyphGroup) (dynargs[1]) ));
						break;
					}
					
					
					case 1308691246:
					{
						this.finalizeGlyph(((global::alphatab.rendering.layout.ScoreLayout) (dynargs[0]) ));
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
				baseArr.push("beamingHelper");
				baseArr.push("restGlyph");
				baseArr.push("noteHeads");
				baseArr.push("_ties");
				{
					base.__hx_getFields(baseArr);
				}
				
			}
		}
		
		
	}
}



#pragma warning disable 109, 114, 219, 429, 168, 162
namespace alphatab.rendering.glyphs
{
	public  class ScoreBeatGlyph_doLayout_80__Fun : global::haxe.lang.Function 
	{
		public    ScoreBeatGlyph_doLayout_80__Fun(global::haxe.root.Array<object> _g) : base(1, 0)
		{
			unchecked 
			{
				this._g = _g;
			}
		}
		
		
		public override   object __hx_invoke1_o(double __fn_float1, object __fn_dyn1)
		{
			unchecked 
			{
				global::alphatab.model.Note n = ( (global::haxe.lang.Runtime.eq(__fn_dyn1, global::haxe.lang.Runtime.undefined)) ? (((global::alphatab.model.Note) (((object) (__fn_float1) )) )) : (((global::alphatab.model.Note) (__fn_dyn1) )) );
				((global::alphatab.rendering.glyphs.ScoreBeatGlyph) (this._g[0]) ).createNoteGlyph(n);
				return default(object);
			}
		}
		
		
		public  global::haxe.root.Array<object> _g;
		
	}
}



#pragma warning disable 109, 114, 219, 429, 168, 162
namespace alphatab.rendering.glyphs
{
	public  class ScoreBeatGlyph_doLayout_91__Fun : global::haxe.lang.Function 
	{
		public    ScoreBeatGlyph_doLayout_91__Fun(global::haxe.root.Array<object> _g, global::haxe.root.Array<object> @group) : base(1, 0)
		{
			unchecked 
			{
				this._g = _g;
				this.@group = @group;
			}
		}
		
		
		public override   object __hx_invoke1_o(double __fn_float1, object __fn_dyn1)
		{
			unchecked 
			{
				global::alphatab.model.Note n1 = ( (global::haxe.lang.Runtime.eq(__fn_dyn1, global::haxe.lang.Runtime.undefined)) ? (((global::alphatab.model.Note) (((object) (__fn_float1) )) )) : (((global::alphatab.model.Note) (__fn_dyn1) )) );
				((global::alphatab.rendering.glyphs.ScoreBeatGlyph) (this._g[0]) ).createBeatDot(n1, ((global::alphatab.rendering.glyphs.GlyphGroup) (this.@group[0]) ));
				return default(object);
			}
		}
		
		
		public  global::haxe.root.Array<object> _g;
		
		public  global::haxe.root.Array<object> @group;
		
	}
}


