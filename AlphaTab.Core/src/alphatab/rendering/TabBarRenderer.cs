using haxe.root;
#pragma warning disable 109, 114, 219, 429, 168, 162
namespace alphatab.rendering
{
	public  class TabBarRenderer : global::alphatab.rendering.GroupedBarRenderer 
	{
		static TabBarRenderer() 
		{
			global::alphatab.rendering.TabBarRenderer.LineSpacing = 10;
		}
		public    TabBarRenderer(global::haxe.lang.EmptyObject empty) : base(((global::haxe.lang.EmptyObject) (global::haxe.lang.EmptyObject.EMPTY) ))
		{
			unchecked 
			{
			}
		}
		
		
		public    TabBarRenderer(global::alphatab.model.Bar bar) : base(((global::haxe.lang.EmptyObject) (global::haxe.lang.EmptyObject.EMPTY) ))
		{
			unchecked 
			{
				global::alphatab.rendering.TabBarRenderer.__hx_ctor_alphatab_rendering_TabBarRenderer(this, bar);
			}
		}
		
		
		public static   void __hx_ctor_alphatab_rendering_TabBarRenderer(global::alphatab.rendering.TabBarRenderer __temp_me104, global::alphatab.model.Bar bar)
		{
			unchecked 
			{
				global::alphatab.rendering.GroupedBarRenderer.__hx_ctor_alphatab_rendering_GroupedBarRenderer(__temp_me104, bar);
			}
		}
		
		
		public static  int LineSpacing;
		
		public static  new object __hx_createEmpty()
		{
			unchecked 
			{
				return new global::alphatab.rendering.TabBarRenderer(((global::haxe.lang.EmptyObject) (global::haxe.lang.EmptyObject.EMPTY) ));
			}
		}
		
		
		public static  new object __hx_create(global::haxe.root.Array arr)
		{
			unchecked 
			{
				return new global::alphatab.rendering.TabBarRenderer(((global::alphatab.model.Bar) (arr[0]) ));
			}
		}
		
		
		public   double getLineOffset()
		{
			unchecked 
			{
				return ( 11 * this.stave.staveGroup.layout.renderer.settings.scale );
			}
		}
		
		
		public virtual   int getNoteX(global::alphatab.model.Note note, global::haxe.lang.Null<bool> onEnd)
		{
			unchecked 
			{
				bool __temp_onEnd102 = ( (global::haxe.lang.Runtime.eq((onEnd).toDynamic(), (default(global::haxe.lang.Null<bool>)).toDynamic())) ? (((bool) (true) )) : (onEnd.@value) );
				global::alphatab.rendering.glyphs.TabBeatGlyph beat = ((global::alphatab.rendering.glyphs.TabBeatGlyph) (((global::alphatab.rendering.glyphs.BeatContainerGlyph) (this.getOrCreateVoiceContainer(note.beat.voice.index).beatGlyphs[note.beat.index]) ).onNotes) );
				if (( beat != default(global::alphatab.rendering.glyphs.TabBeatGlyph) )) 
				{
					return ( ( beat.container.x + beat.x ) + beat.noteNumbers.getNoteX(note, new global::haxe.lang.Null<bool>(__temp_onEnd102, true)) );
				}
				
				return this.getPostBeatGlyphsStart();
			}
		}
		
		
		public virtual   int getBeatX(global::alphatab.model.Beat beat)
		{
			unchecked 
			{
				global::alphatab.rendering.glyphs.TabBeatGlyph bg = ((global::alphatab.rendering.glyphs.TabBeatGlyph) (((global::alphatab.rendering.glyphs.BeatContainerGlyph) (this.getOrCreateVoiceContainer(beat.voice.index).beatGlyphs[beat.index]) ).preNotes) );
				if (( bg != default(global::alphatab.rendering.glyphs.TabBeatGlyph) )) 
				{
					return ( bg.container.x + bg.x );
				}
				
				return 0;
			}
		}
		
		
		public virtual   int getNoteY(global::alphatab.model.Note note)
		{
			unchecked 
			{
				global::alphatab.rendering.glyphs.TabBeatGlyph beat = ((global::alphatab.rendering.glyphs.TabBeatGlyph) (((global::alphatab.rendering.glyphs.BeatContainerGlyph) (this.getOrCreateVoiceContainer(note.beat.voice.index).beatGlyphs[note.beat.index]) ).onNotes) );
				if (( beat != default(global::alphatab.rendering.glyphs.TabBeatGlyph) )) 
				{
					return beat.noteNumbers.getNoteY(note);
				}
				
				return 0;
			}
		}
		
		
		public override   void doLayout()
		{
			unchecked 
			{
				base.doLayout();
				this.height = ( ((int) (( ( 11 * this.stave.staveGroup.layout.renderer.settings.scale ) * (( this._bar.track.tuning.length - 1 )) )) ) + ( this.getNumberOverflow() * 2 ) );
				if (( this.index == 0 )) 
				{
					this.stave.registerStaveTop(this.getNumberOverflow());
					this.stave.registerStaveBottom(( this.height - this.getNumberOverflow() ));
				}
				
			}
		}
		
		
		public override   void createPreBeatGlyphs()
		{
			unchecked 
			{
				global::alphatab.model.MasterBar __temp_stmt567 = default(global::alphatab.model.MasterBar);
				{
					global::alphatab.model.Bar _this = this._bar;
					__temp_stmt567 = ((global::alphatab.model.MasterBar) (_this.track.score.masterBars[_this.index]) );
				}
				
				if (__temp_stmt567.isRepeatStart) 
				{
					this.addPreBeatGlyph(new global::alphatab.rendering.glyphs.RepeatOpenGlyph(new global::haxe.lang.Null<int>(0, true), new global::haxe.lang.Null<int>(0, true), ((double) (1.5) ), ((int) (3) )));
				}
				
				if (( this.index == 0 )) 
				{
					this.addPreBeatGlyph(new global::alphatab.rendering.glyphs.TabClefGlyph());
				}
				
				this.addPreBeatGlyph(new global::alphatab.rendering.glyphs.BarNumberGlyph(new global::haxe.lang.Null<int>(0, true), new global::haxe.lang.Null<int>(this.getTabY(-1, new global::haxe.lang.Null<int>(-3, true)), true), ((int) (( this._bar.index + 1 )) ), new global::haxe.lang.Null<bool>( ! (this.stave.isFirstInAccolade) , true)));
				if (this._bar.isEmpty()) 
				{
					this.addPreBeatGlyph(new global::alphatab.rendering.glyphs.SpacingGlyph(new global::haxe.lang.Null<int>(0, true), new global::haxe.lang.Null<int>(0, true), ((int) (( 30 * this.stave.staveGroup.layout.renderer.settings.scale )) ), new global::haxe.lang.Null<bool>(false, true)));
				}
				
			}
		}
		
		
		public override   void createBeatGlyphs()
		{
			unchecked 
			{
				this.createVoiceGlyphs(((global::alphatab.model.Voice) (this._bar.voices[0]) ));
			}
		}
		
		
		public virtual   void createVoiceGlyphs(global::alphatab.model.Voice v)
		{
			unchecked 
			{
				int _g = 0;
				global::haxe.root.Array<object> _g1 = v.beats;
				while (( _g < _g1.length ))
				{
					global::alphatab.model.Beat b = ((global::alphatab.model.Beat) (_g1[_g]) );
					 ++ _g;
					global::alphatab.rendering.glyphs.TabBeatContainerGlyph container = new global::alphatab.rendering.glyphs.TabBeatContainerGlyph(((global::alphatab.model.Beat) (b) ));
					container.preNotes = new global::alphatab.rendering.glyphs.TabBeatPreNotesGlyph();
					container.onNotes = new global::alphatab.rendering.glyphs.TabBeatGlyph();
					container.postNotes = new global::alphatab.rendering.glyphs.TabBeatPostNotesGlyph();
					this.addBeatGlyph(container);
				}
				
			}
		}
		
		
		public override   void createPostBeatGlyphs()
		{
			unchecked 
			{
				global::alphatab.model.MasterBar __temp_stmt568 = default(global::alphatab.model.MasterBar);
				{
					global::alphatab.model.Bar _this = this._bar;
					__temp_stmt568 = ((global::alphatab.model.MasterBar) (_this.track.score.masterBars[_this.index]) );
				}
				
				if (( __temp_stmt568.repeatCount > 0 )) 
				{
					this.addPostBeatGlyph(new global::alphatab.rendering.glyphs.RepeatCloseGlyph(new global::haxe.lang.Null<int>(this.x, true), new global::haxe.lang.Null<int>(0, true)));
					global::alphatab.model.MasterBar __temp_stmt574 = default(global::alphatab.model.MasterBar);
					{
						global::alphatab.model.Bar _this1 = this._bar;
						__temp_stmt574 = ((global::alphatab.model.MasterBar) (_this1.track.score.masterBars[_this1.index]) );
					}
					
					if (( __temp_stmt574.repeatCount > 2 )) 
					{
						int line = default(int);
						if (( ( this._bar.index == ( this._bar.track.bars.length - 1 ) ) || ( this.index == ( this.stave.barRenderers.length - 1 ) ) )) 
						{
							line = -1;
						}
						 else 
						{
							line = -4;
						}
						
						global::haxe.lang.Null<int> __temp_stmt575 = new global::haxe.lang.Null<int>(this.getTabY(line, new global::haxe.lang.Null<int>(-3, true)), true);
						global::alphatab.model.MasterBar __temp_stmt576 = default(global::alphatab.model.MasterBar);
						{
							global::alphatab.model.Bar _this2 = this._bar;
							__temp_stmt576 = ((global::alphatab.model.MasterBar) (_this2.track.score.masterBars[_this2.index]) );
						}
						
						this.addPostBeatGlyph(new global::alphatab.rendering.glyphs.RepeatCountGlyph(new global::haxe.lang.Null<int>(0, true), __temp_stmt575, ((int) (__temp_stmt576.repeatCount) )));
					}
					
				}
				 else 
				{
					global::alphatab.model.MasterBar __temp_stmt569 = default(global::alphatab.model.MasterBar);
					{
						global::alphatab.model.Bar _this3 = this._bar;
						__temp_stmt569 = ((global::alphatab.model.MasterBar) (_this3.track.score.masterBars[_this3.index]) );
					}
					
					if (__temp_stmt569.isDoubleBar) 
					{
						this.addPostBeatGlyph(new global::alphatab.rendering.glyphs.BarSeperatorGlyph(((global::haxe.lang.Null<int>) (default(global::haxe.lang.Null<int>)) ), ((global::haxe.lang.Null<int>) (default(global::haxe.lang.Null<int>)) ), ((global::haxe.lang.Null<bool>) (default(global::haxe.lang.Null<bool>)) )));
						this.addPostBeatGlyph(new global::alphatab.rendering.glyphs.SpacingGlyph(new global::haxe.lang.Null<int>(0, true), new global::haxe.lang.Null<int>(0, true), ((int) (( 3 * this.stave.staveGroup.layout.renderer.settings.scale )) ), new global::haxe.lang.Null<bool>(false, true)));
						this.addPostBeatGlyph(new global::alphatab.rendering.glyphs.BarSeperatorGlyph(((global::haxe.lang.Null<int>) (default(global::haxe.lang.Null<int>)) ), ((global::haxe.lang.Null<int>) (default(global::haxe.lang.Null<int>)) ), ((global::haxe.lang.Null<bool>) (default(global::haxe.lang.Null<bool>)) )));
					}
					 else 
					{
						bool __temp_stmt571 = ( this._bar.nextBar == default(global::alphatab.model.Bar) );
						bool __temp_boolv572 = false;
						if ( ! (__temp_stmt571) ) 
						{
							global::alphatab.model.MasterBar __temp_stmt573 = default(global::alphatab.model.MasterBar);
							{
								global::alphatab.model.Bar _this4 = this._bar.nextBar;
								__temp_stmt573 = ((global::alphatab.model.MasterBar) (_this4.track.score.masterBars[_this4.index]) );
							}
							
							__temp_boolv572 =  ! (__temp_stmt573.isRepeatStart) ;
						}
						
						bool __temp_stmt570 = ( __temp_stmt571 || __temp_boolv572 );
						if (__temp_stmt570) 
						{
							this.addPostBeatGlyph(new global::alphatab.rendering.glyphs.BarSeperatorGlyph(new global::haxe.lang.Null<int>(0, true), new global::haxe.lang.Null<int>(0, true), new global::haxe.lang.Null<bool>(( this._bar.index == ( this._bar.track.bars.length - 1 ) ), true)));
						}
						
					}
					
				}
				
			}
		}
		
		
		public override   int getTopPadding()
		{
			unchecked 
			{
				return this.getNumberOverflow();
			}
		}
		
		
		public override   int getBottomPadding()
		{
			unchecked 
			{
				return this.getNumberOverflow();
			}
		}
		
		
		public virtual   int getTabY(int line, global::haxe.lang.Null<int> correction)
		{
			unchecked 
			{
				int __temp_correction103 = ( (global::haxe.lang.Runtime.eq((correction).toDynamic(), (default(global::haxe.lang.Null<int>)).toDynamic())) ? (((int) (0) )) : (correction.@value) );
				return ((int) (( ( ( 11 * this.stave.staveGroup.layout.renderer.settings.scale ) * line ) + ( __temp_correction103 * this.stave.staveGroup.layout.renderer.settings.scale ) )) );
			}
		}
		
		
		public virtual   int getNumberOverflow()
		{
			unchecked 
			{
				global::alphatab.rendering.RenderingResources res = this.stave.staveGroup.layout.renderer.renderingResources;
				{
					double x = ( ( res.tablatureFont.getSize() / 2 ) + ( res.tablatureFont.getSize() * 0.2 ) );
					return ((int) (x) );
				}
				
			}
		}
		
		
		public override   void paintBackground(int cx, int cy, global::alphatab.platform.ICanvas canvas)
		{
			unchecked 
			{
				global::alphatab.rendering.RenderingResources res = this.stave.staveGroup.layout.renderer.renderingResources;
				canvas.setColor(res.staveLineColor);
				int lineY = ( ( cy + this.y ) + this.getNumberOverflow() );
				int startY = lineY;
				{
					int _g1 = 0;
					int _g = this._bar.track.tuning.length;
					while (( _g1 < _g ))
					{
						int i = _g1++;
						if (( i > 0 )) 
						{
							lineY += ((int) (( 11 * this.stave.staveGroup.layout.renderer.settings.scale )) );
						}
						
						canvas.beginPath();
						canvas.moveTo(((double) (( cx + this.x )) ), ((double) (lineY) ));
						canvas.lineTo(((double) (( ( cx + this.x ) + this.width )) ), ((double) (lineY) ));
						canvas.stroke();
					}
					
				}
				
			}
		}
		
		
		public virtual   void drawInfoGuide(global::alphatab.platform.ICanvas canvas, int cx, int cy, int y, global::alphatab.platform.model.Color c)
		{
			unchecked 
			{
				canvas.setColor(c);
				canvas.beginPath();
				canvas.moveTo(((double) (( cx + this.x )) ), ((double) (( ( cy + this.y ) + y )) ));
				canvas.lineTo(((double) (( ( cx + this.x ) + this.width )) ), ((double) (( ( cy + this.y ) + y )) ));
				canvas.stroke();
			}
		}
		
		
		public override   object __hx_getField(string field, int hash, bool throwErrors, bool isCheck, bool handleProperties)
		{
			unchecked 
			{
				switch (hash)
				{
					case 438023882:
					{
						return ((global::haxe.lang.Function) (new global::haxe.lang.Closure(((object) (this) ), global::haxe.lang.Runtime.toString("drawInfoGuide"), ((int) (438023882) ))) );
					}
					
					
					case 1334722860:
					{
						return ((global::haxe.lang.Function) (new global::haxe.lang.Closure(((object) (this) ), global::haxe.lang.Runtime.toString("paintBackground"), ((int) (1334722860) ))) );
					}
					
					
					case 895305313:
					{
						return ((global::haxe.lang.Function) (new global::haxe.lang.Closure(((object) (this) ), global::haxe.lang.Runtime.toString("getNumberOverflow"), ((int) (895305313) ))) );
					}
					
					
					case 528048154:
					{
						return ((global::haxe.lang.Function) (new global::haxe.lang.Closure(((object) (this) ), global::haxe.lang.Runtime.toString("getTabY"), ((int) (528048154) ))) );
					}
					
					
					case 357418928:
					{
						return ((global::haxe.lang.Function) (new global::haxe.lang.Closure(((object) (this) ), global::haxe.lang.Runtime.toString("getBottomPadding"), ((int) (357418928) ))) );
					}
					
					
					case 415081458:
					{
						return ((global::haxe.lang.Function) (new global::haxe.lang.Closure(((object) (this) ), global::haxe.lang.Runtime.toString("getTopPadding"), ((int) (415081458) ))) );
					}
					
					
					case 2000963577:
					{
						return ((global::haxe.lang.Function) (new global::haxe.lang.Closure(((object) (this) ), global::haxe.lang.Runtime.toString("createPostBeatGlyphs"), ((int) (2000963577) ))) );
					}
					
					
					case 131841789:
					{
						return ((global::haxe.lang.Function) (new global::haxe.lang.Closure(((object) (this) ), global::haxe.lang.Runtime.toString("createVoiceGlyphs"), ((int) (131841789) ))) );
					}
					
					
					case 1907509625:
					{
						return ((global::haxe.lang.Function) (new global::haxe.lang.Closure(((object) (this) ), global::haxe.lang.Runtime.toString("createBeatGlyphs"), ((int) (1907509625) ))) );
					}
					
					
					case 918754500:
					{
						return ((global::haxe.lang.Function) (new global::haxe.lang.Closure(((object) (this) ), global::haxe.lang.Runtime.toString("createPreBeatGlyphs"), ((int) (918754500) ))) );
					}
					
					
					case 1825584277:
					{
						return ((global::haxe.lang.Function) (new global::haxe.lang.Closure(((object) (this) ), global::haxe.lang.Runtime.toString("doLayout"), ((int) (1825584277) ))) );
					}
					
					
					case 2141318065:
					{
						return ((global::haxe.lang.Function) (new global::haxe.lang.Closure(((object) (this) ), global::haxe.lang.Runtime.toString("getNoteY"), ((int) (2141318065) ))) );
					}
					
					
					case 271087020:
					{
						return ((global::haxe.lang.Function) (new global::haxe.lang.Closure(((object) (this) ), global::haxe.lang.Runtime.toString("getBeatX"), ((int) (271087020) ))) );
					}
					
					
					case 2141318064:
					{
						return ((global::haxe.lang.Function) (new global::haxe.lang.Closure(((object) (this) ), global::haxe.lang.Runtime.toString("getNoteX"), ((int) (2141318064) ))) );
					}
					
					
					case 291106525:
					{
						return ((global::haxe.lang.Function) (new global::haxe.lang.Closure(((object) (this) ), global::haxe.lang.Runtime.toString("getLineOffset"), ((int) (291106525) ))) );
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
					case 1825584277:case 918754500:case 1907509625:case 2000963577:case 415081458:case 357418928:case 1334722860:
					{
						return global::haxe.lang.Runtime.slowCallField(this, field, dynargs);
					}
					
					
					case 438023882:
					{
						this.drawInfoGuide(((global::alphatab.platform.ICanvas) (dynargs[0]) ), ((int) (global::haxe.lang.Runtime.toInt(dynargs[1])) ), ((int) (global::haxe.lang.Runtime.toInt(dynargs[2])) ), ((int) (global::haxe.lang.Runtime.toInt(dynargs[3])) ), ((global::alphatab.platform.model.Color) (dynargs[4]) ));
						break;
					}
					
					
					case 895305313:
					{
						return this.getNumberOverflow();
					}
					
					
					case 528048154:
					{
						return this.getTabY(((int) (global::haxe.lang.Runtime.toInt(dynargs[0])) ), global::haxe.lang.Null<object>.ofDynamic<int>(dynargs[1]));
					}
					
					
					case 131841789:
					{
						this.createVoiceGlyphs(((global::alphatab.model.Voice) (dynargs[0]) ));
						break;
					}
					
					
					case 2141318065:
					{
						return this.getNoteY(((global::alphatab.model.Note) (dynargs[0]) ));
					}
					
					
					case 271087020:
					{
						return this.getBeatX(((global::alphatab.model.Beat) (dynargs[0]) ));
					}
					
					
					case 2141318064:
					{
						return this.getNoteX(((global::alphatab.model.Note) (dynargs[0]) ), global::haxe.lang.Null<object>.ofDynamic<bool>(dynargs[1]));
					}
					
					
					case 291106525:
					{
						return this.getLineOffset();
					}
					
					
					default:
					{
						return base.__hx_invokeField(field, hash, dynargs);
					}
					
				}
				
				return default(object);
			}
		}
		
		
	}
}


