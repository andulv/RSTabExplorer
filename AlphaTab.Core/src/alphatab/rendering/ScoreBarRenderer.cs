using haxe.root;
#pragma warning disable 109, 114, 219, 429, 168, 162
namespace alphatab.rendering
{
	public  class ScoreBarRenderer : global::alphatab.rendering.GroupedBarRenderer 
	{
		static ScoreBarRenderer() 
		{
			global::alphatab.rendering.ScoreBarRenderer.StepsPerOctave = 7;
			global::alphatab.rendering.ScoreBarRenderer.OctaveSteps = new global::haxe.root.Array<int>(new int[]{38, 32, 30, 26, 38});
			global::alphatab.rendering.ScoreBarRenderer.SharpNoteSteps = new global::haxe.root.Array<int>(new int[]{0, 0, 1, 1, 2, 3, 3, 4, 4, 5, 5, 6});
			global::alphatab.rendering.ScoreBarRenderer.FLAT_NOTE_STEPS = new global::haxe.root.Array<int>(new int[]{0, 1, 1, 2, 2, 3, 4, 4, 5, 5, 6, 6});
			global::alphatab.rendering.ScoreBarRenderer.SharpKsSteps = new global::haxe.root.Array<int>(new int[]{1, 4, 0, 3, 6, 2, 5});
			global::alphatab.rendering.ScoreBarRenderer.FlatKsSteps = new global::haxe.root.Array<int>(new int[]{5, 2, 6, 3, 7, 4, 8});
			global::alphatab.rendering.ScoreBarRenderer.LineSpacing = 8;
			global::alphatab.rendering.ScoreBarRenderer.NOTE_STEP_CORRECTION = 1;
		}
		public    ScoreBarRenderer(global::haxe.lang.EmptyObject empty) : base(((global::haxe.lang.EmptyObject) (global::haxe.lang.EmptyObject.EMPTY) ))
		{
			unchecked 
			{
			}
		}
		
		
		public    ScoreBarRenderer(global::alphatab.model.Bar bar) : base(((global::haxe.lang.EmptyObject) (global::haxe.lang.EmptyObject.EMPTY) ))
		{
			unchecked 
			{
				global::alphatab.rendering.ScoreBarRenderer.__hx_ctor_alphatab_rendering_ScoreBarRenderer(this, bar);
			}
		}
		
		
		public static   void __hx_ctor_alphatab_rendering_ScoreBarRenderer(global::alphatab.rendering.ScoreBarRenderer __temp_me100, global::alphatab.model.Bar bar)
		{
			unchecked 
			{
				global::alphatab.rendering.GroupedBarRenderer.__hx_ctor_alphatab_rendering_GroupedBarRenderer(__temp_me100, bar);
				__temp_me100.accidentalHelper = new global::alphatab.rendering.utils.AccidentalHelper();
				__temp_me100._beamHelpers = new global::haxe.root.Array<object>();
				__temp_me100._beamHelperLookup = new global::haxe.root.Array<object>();
				__temp_me100._tupletHelpers = new global::haxe.root.Array<object>();
			}
		}
		
		
		public static  int StepsPerOctave;
		
		public static  global::haxe.root.Array<int> OctaveSteps;
		
		public static  global::haxe.root.Array<int> SharpNoteSteps;
		
		public static  global::haxe.root.Array<int> FLAT_NOTE_STEPS;
		
		public static  global::haxe.root.Array<int> SharpKsSteps;
		
		public static  global::haxe.root.Array<int> FlatKsSteps;
		
		public static  int LineSpacing;
		
		public static   void paintSingleBar(global::alphatab.platform.ICanvas canvas, int x1, int y1, int x2, int y2, int size)
		{
			unchecked 
			{
				canvas.beginPath();
				canvas.moveTo(((double) (x1) ), ((double) (y1) ));
				canvas.lineTo(((double) (x2) ), ((double) (y2) ));
				canvas.lineTo(((double) (x2) ), ((double) (( y2 - size )) ));
				canvas.lineTo(((double) (x1) ), ((double) (( y1 - size )) ));
				canvas.closePath();
				canvas.fill();
			}
		}
		
		
		public static  int NOTE_STEP_CORRECTION;
		
		public static  new object __hx_createEmpty()
		{
			unchecked 
			{
				return new global::alphatab.rendering.ScoreBarRenderer(((global::haxe.lang.EmptyObject) (global::haxe.lang.EmptyObject.EMPTY) ));
			}
		}
		
		
		public static  new object __hx_create(global::haxe.root.Array arr)
		{
			unchecked 
			{
				return new global::alphatab.rendering.ScoreBarRenderer(((global::alphatab.model.Bar) (arr[0]) ));
			}
		}
		
		
		public  global::alphatab.rendering.utils.AccidentalHelper accidentalHelper;
		
		public  global::haxe.root.Array<object> _beamHelpers;
		
		public  global::haxe.root.Array<object> _beamHelperLookup;
		
		public  global::haxe.root.Array<object> _tupletHelpers;
		
		public  global::alphatab.rendering.utils.BeamingHelper _currentBeamHelper;
		
		public  global::alphatab.rendering.utils.TupletHelper _currentTupletHelper;
		
		public virtual   global::alphatab.rendering.utils.BeamDirection getBeatDirection(global::alphatab.model.Beat beat)
		{
			unchecked 
			{
				global::alphatab.rendering.glyphs.ScoreBeatGlyph g = ((global::alphatab.rendering.glyphs.ScoreBeatGlyph) (((global::alphatab.rendering.glyphs.BeatContainerGlyph) (this.getOrCreateVoiceContainer(beat.voice.index).beatGlyphs[beat.index]) ).onNotes) );
				if (( g != default(global::alphatab.rendering.glyphs.ScoreBeatGlyph) )) 
				{
					return g.noteHeads.beamingHelper.getDirection();
				}
				
				return global::alphatab.rendering.utils.BeamDirection.Up;
			}
		}
		
		
		public virtual   int getNoteX(global::alphatab.model.Note note, global::haxe.lang.Null<bool> onEnd)
		{
			unchecked 
			{
				bool __temp_onEnd98 = ( (global::haxe.lang.Runtime.eq((onEnd).toDynamic(), (default(global::haxe.lang.Null<bool>)).toDynamic())) ? (((bool) (true) )) : (onEnd.@value) );
				global::alphatab.rendering.glyphs.ScoreBeatGlyph g = ((global::alphatab.rendering.glyphs.ScoreBeatGlyph) (((global::alphatab.rendering.glyphs.BeatContainerGlyph) (this.getOrCreateVoiceContainer(note.beat.voice.index).beatGlyphs[note.beat.index]) ).onNotes) );
				if (( g != default(global::alphatab.rendering.glyphs.ScoreBeatGlyph) )) 
				{
					return ( ( g.container.x + g.x ) + g.noteHeads.getNoteX(note, new global::haxe.lang.Null<bool>(__temp_onEnd98, true)) );
				}
				
				return 0;
			}
		}
		
		
		public virtual   int getNoteY(global::alphatab.model.Note note)
		{
			unchecked 
			{
				global::alphatab.rendering.glyphs.ScoreBeatGlyph beat = ((global::alphatab.rendering.glyphs.ScoreBeatGlyph) (((global::alphatab.rendering.glyphs.BeatContainerGlyph) (this.getOrCreateVoiceContainer(note.beat.voice.index).beatGlyphs[note.beat.index]) ).onNotes) );
				if (( beat != default(global::alphatab.rendering.glyphs.ScoreBeatGlyph) )) 
				{
					return beat.noteHeads.getNoteY(note);
				}
				
				return 0;
			}
		}
		
		
		public override   int getTopPadding()
		{
			unchecked 
			{
				return this.getGlyphOverflow();
			}
		}
		
		
		public override   int getBottomPadding()
		{
			unchecked 
			{
				return this.getGlyphOverflow();
			}
		}
		
		
		public   double getLineOffset()
		{
			unchecked 
			{
				return ( 9 * this.stave.staveGroup.layout.renderer.settings.scale );
			}
		}
		
		
		public override   void doLayout()
		{
			unchecked 
			{
				base.doLayout();
				this.height = ( ( ((int) (( ( 9 * this.stave.staveGroup.layout.renderer.settings.scale ) * 4 )) ) + this.getTopPadding() ) + this.getBottomPadding() );
				if (( this.index == 0 )) 
				{
					this.stave.registerStaveTop(this.getGlyphOverflow());
					this.stave.registerStaveBottom(( this.height - this.getGlyphOverflow() ));
				}
				
				int top = this.getScoreY(0, default(global::haxe.lang.Null<int>));
				int bottom = this.getScoreY(8, default(global::haxe.lang.Null<int>));
				{
					int _g = 0;
					global::haxe.root.Array<object> _g1 = this._beamHelpers;
					while (( _g < _g1.length ))
					{
						global::haxe.root.Array<object> v = ((global::haxe.root.Array<object>) (global::haxe.root.Array<object>.__hx_cast<object>(((global::haxe.root.Array) (_g1[_g]) ))) );
						 ++ _g;
						{
							int _g2 = 0;
							while (( _g2 < v.length ))
							{
								global::alphatab.rendering.utils.BeamingHelper h = ((global::alphatab.rendering.utils.BeamingHelper) (v[_g2]) );
								 ++ _g2;
								int maxNoteY = this.getScoreY(this.getNoteLine(h.maxNote), default(global::haxe.lang.Null<int>));
								if (( h.getDirection() == global::alphatab.rendering.utils.BeamDirection.Up )) 
								{
									maxNoteY -= this.getStemSize(h.maxDuration);
								}
								
								if (( maxNoteY < top )) 
								{
									int __temp_stmt523 = default(int);
									{
										double x = global::System.Math.Abs(((double) (maxNoteY) ));
										__temp_stmt523 = ((int) (x) );
									}
									
									this.registerOverflowTop(__temp_stmt523);
								}
								
								int minNoteY = this.getScoreY(this.getNoteLine(h.minNote), default(global::haxe.lang.Null<int>));
								if (( h.getDirection() == global::alphatab.rendering.utils.BeamDirection.Down )) 
								{
									minNoteY += this.getStemSize(h.maxDuration);
								}
								
								if (( minNoteY > bottom )) 
								{
									int __temp_stmt524 = default(int);
									{
										double x1 = global::System.Math.Abs(((double) (minNoteY) ));
										__temp_stmt524 = ((int) (x1) );
									}
									
									this.registerOverflowBottom(( __temp_stmt524 - bottom ));
								}
								
							}
							
						}
						
					}
					
				}
				
			}
		}
		
		
		public override   void paint(int cx, int cy, global::alphatab.platform.ICanvas canvas)
		{
			unchecked 
			{
				base.paint(cx, cy, canvas);
				this.paintBeams(cx, cy, canvas);
				this.paintTuplets(cx, cy, canvas);
			}
		}
		
		
		public virtual   void paintTuplets(int cx, int cy, global::alphatab.platform.ICanvas canvas)
		{
			unchecked 
			{
				int _g = 0;
				global::haxe.root.Array<object> _g1 = this._tupletHelpers;
				while (( _g < _g1.length ))
				{
					global::haxe.root.Array<object> v = ((global::haxe.root.Array<object>) (global::haxe.root.Array<object>.__hx_cast<object>(((global::haxe.root.Array) (_g1[_g]) ))) );
					 ++ _g;
					{
						int _g2 = 0;
						while (( _g2 < v.length ))
						{
							global::alphatab.rendering.utils.TupletHelper h = ((global::alphatab.rendering.utils.TupletHelper) (v[_g2]) );
							 ++ _g2;
							this.paintTupletHelper(( cx + this.getBeatGlyphsStart() ), cy, canvas, h);
						}
						
					}
					
				}
				
			}
		}
		
		
		public virtual   void paintBeams(int cx, int cy, global::alphatab.platform.ICanvas canvas)
		{
			unchecked 
			{
				int _g = 0;
				global::haxe.root.Array<object> _g1 = this._beamHelpers;
				while (( _g < _g1.length ))
				{
					global::haxe.root.Array<object> v = ((global::haxe.root.Array<object>) (global::haxe.root.Array<object>.__hx_cast<object>(((global::haxe.root.Array) (_g1[_g]) ))) );
					 ++ _g;
					{
						int _g2 = 0;
						while (( _g2 < v.length ))
						{
							global::alphatab.rendering.utils.BeamingHelper h = ((global::alphatab.rendering.utils.BeamingHelper) (v[_g2]) );
							 ++ _g2;
							this.paintBeamHelper(( cx + this.getBeatGlyphsStart() ), cy, canvas, h);
						}
						
					}
					
				}
				
			}
		}
		
		
		public virtual   void paintBeamHelper(int cx, int cy, global::alphatab.platform.ICanvas canvas, global::alphatab.rendering.utils.BeamingHelper h)
		{
			unchecked 
			{
				if (( h.beats.length == 1 )) 
				{
					this.paintFooter(cx, cy, canvas, h);
				}
				 else 
				{
					this.paintBar(cx, cy, canvas, h);
				}
				
			}
		}
		
		
		public virtual   void paintTupletHelper(int cx, int cy, global::alphatab.platform.ICanvas canvas, global::alphatab.rendering.utils.TupletHelper h)
		{
			unchecked 
			{
				global::alphatab.rendering.RenderingResources res = this.stave.staveGroup.layout.renderer.renderingResources;
				global::alphatab.platform.model.TextAlign oldAlign = canvas.getTextAlign();
				canvas.setTextAlign(global::alphatab.platform.model.TextAlign.Center);
				if (( ( h.beats.length == 1 ) ||  ! ((( h.beats.length == h.tuplet )))  )) 
				{
					int _g1 = 0;
					int _g = h.beats.length;
					while (( _g1 < _g ))
					{
						int i = _g1++;
						global::alphatab.model.Beat beat = ((global::alphatab.model.Beat) (h.beats[i]) );
						global::alphatab.rendering.utils.BeamingHelper beamingHelper = ((global::alphatab.rendering.utils.BeamingHelper) (((global::haxe.ds.IntMap<object>) (global::haxe.ds.IntMap<object>.__hx_cast<object>(((global::haxe.ds.IntMap) (this._beamHelperLookup[h.voiceIndex]) ))) ).@get(beat.index).@value) );
						global::alphatab.rendering.utils.BeamDirection direction = beamingHelper.getDirection();
						int tupletX = default(int);
						{
							double x = ( beamingHelper.getBeatLineX(beat) + this.stave.staveGroup.layout.renderer.settings.scale );
							tupletX = ((int) (x) );
						}
						
						int tupletY = ( ( cy + this.y ) + this.calculateBeamY(beamingHelper, tupletX) );
						int offset = default(int);
						if (( direction == global::alphatab.rendering.utils.BeamDirection.Up )) 
						{
							double x1 = ( res.effectFont.getSize() * 1.8 );
							offset = ((int) (x1) );
						}
						 else 
						{
							offset =  - ((((int) (( 3 * this.stave.staveGroup.layout.renderer.settings.scale )) ))) ;
						}
						
						canvas.setFont(res.effectFont);
						canvas.fillText(global::Std.@string(h.tuplet), ((double) (( ( cx + this.x ) + tupletX )) ), ((double) (( tupletY - offset )) ));
					}
					
				}
				 else 
				{
					global::alphatab.model.Beat firstBeat = ((global::alphatab.model.Beat) (h.beats[0]) );
					global::alphatab.model.Beat lastBeat = ((global::alphatab.model.Beat) (h.beats[( h.beats.length - 1 )]) );
					global::alphatab.rendering.utils.BeamingHelper beamingHelper1 = ((global::alphatab.rendering.utils.BeamingHelper) (((global::haxe.ds.IntMap<object>) (global::haxe.ds.IntMap<object>.__hx_cast<object>(((global::haxe.ds.IntMap) (this._beamHelperLookup[h.voiceIndex]) ))) ).@get(firstBeat.index).@value) );
					global::alphatab.rendering.utils.BeamDirection direction1 = beamingHelper1.getDirection();
					int startX = default(int);
					{
						double x2 = ( beamingHelper1.getBeatLineX(firstBeat) + this.stave.staveGroup.layout.renderer.settings.scale );
						startX = ((int) (x2) );
					}
					
					int endX = default(int);
					{
						double x3 = ( beamingHelper1.getBeatLineX(lastBeat) + this.stave.staveGroup.layout.renderer.settings.scale );
						endX = ((int) (x3) );
					}
					
					canvas.setFont(res.effectFont);
					string s = global::Std.@string(h.tuplet);
					double sw = canvas.measureText(s);
					int sp = ((int) (( 3 * this.stave.staveGroup.layout.renderer.settings.scale )) );
					int middleX = ( (( startX + endX )) / 2 );
					int offset1X = ((int) (( ( middleX - ( sw / 2 ) ) - sp )) );
					int offset2X = ((int) (( ( middleX + ( sw / 2 ) ) + sp )) );
					int startY = this.calculateBeamY(beamingHelper1, startX);
					int offset1Y = this.calculateBeamY(beamingHelper1, offset1X);
					int middleY = this.calculateBeamY(beamingHelper1, middleX);
					int offset2Y = this.calculateBeamY(beamingHelper1, offset2X);
					int endY = this.calculateBeamY(beamingHelper1, endX);
					int offset1 = ((int) (( 10 * this.stave.staveGroup.layout.renderer.settings.scale )) );
					int size = ((int) (( 5 * this.stave.staveGroup.layout.renderer.settings.scale )) );
					if (( direction1 == global::alphatab.rendering.utils.BeamDirection.Down )) 
					{
						offset1 *= -1;
						size *= -1;
					}
					
					canvas.beginPath();
					canvas.moveTo(((double) (( ( cx + this.x ) + startX )) ), ((double) (( ( ( cy + this.y ) + startY ) - offset1 )) ));
					canvas.lineTo(((double) (( ( cx + this.x ) + startX )) ), ((double) (( ( ( ( cy + this.y ) + startY ) - offset1 ) - size )) ));
					canvas.lineTo(((double) (( ( cx + this.x ) + offset1X )) ), ((double) (( ( ( ( cy + this.y ) + offset1Y ) - offset1 ) - size )) ));
					canvas.stroke();
					canvas.beginPath();
					canvas.moveTo(((double) (( ( cx + this.x ) + offset2X )) ), ((double) (( ( ( ( cy + this.y ) + offset2Y ) - offset1 ) - size )) ));
					canvas.lineTo(((double) (( ( cx + this.x ) + endX )) ), ((double) (( ( ( ( cy + this.y ) + endY ) - offset1 ) - size )) ));
					canvas.lineTo(((double) (( ( cx + this.x ) + endX )) ), ((double) (( ( ( cy + this.y ) + endY ) - offset1 )) ));
					canvas.stroke();
					canvas.fillText(s, ((double) (( ( cx + this.x ) + middleX )) ), ( ( ( ( ( cy + this.y ) + middleY ) - offset1 ) - size ) - res.effectFont.getSize() ));
				}
				
				canvas.setTextAlign(oldAlign);
			}
		}
		
		
		public virtual   int getStemSize(global::alphatab.model.Duration duration)
		{
			unchecked 
			{
				int size = default(int);
				switch (global::haxe.root.Type.enumIndex(duration))
				{
					case 1:
					{
						size = 6;
						break;
					}
					
					
					case 2:
					{
						size = 6;
						break;
					}
					
					
					case 3:
					{
						size = 6;
						break;
					}
					
					
					case 4:
					{
						size = 6;
						break;
					}
					
					
					case 5:
					{
						size = 7;
						break;
					}
					
					
					case 6:
					{
						size = 8;
						break;
					}
					
					
					default:
					{
						size = 0;
						break;
					}
					
				}
				
				return this.getScoreY(size, default(global::haxe.lang.Null<int>));
			}
		}
		
		
		public virtual   int calculateBeamY(global::alphatab.rendering.utils.BeamingHelper h, int x)
		{
			unchecked 
			{
				global::haxe.root.Array<object> _g = new global::haxe.root.Array<object>(new object[]{this});
				global::haxe.root.Array<int> correction = new global::haxe.root.Array<int>(new int[]{4});
				int stemSize = this.getStemSize(h.maxDuration);
				return h.calculateBeamY(stemSize, ((int) (this.stave.staveGroup.layout.renderer.settings.scale) ), x, this.stave.staveGroup.layout.renderer.settings.scale, new global::alphatab.rendering.ScoreBarRenderer_calculateBeamY_372__Fun(((global::haxe.root.Array<int>) (global::haxe.root.Array<object>.__hx_cast<int>(((global::haxe.root.Array) (correction) ))) ), ((global::haxe.root.Array<object>) (global::haxe.root.Array<object>.__hx_cast<object>(((global::haxe.root.Array) (_g) ))) )));
			}
		}
		
		
		public virtual   void paintBar(int cx, int cy, global::alphatab.platform.ICanvas canvas, global::alphatab.rendering.utils.BeamingHelper h)
		{
			unchecked 
			{
				int _g1 = 0;
				int _g = h.beats.length;
				while (( _g1 < _g ))
				{
					int i = _g1++;
					global::alphatab.model.Beat beat = ((global::alphatab.model.Beat) (h.beats[i]) );
					int correction = 4;
					int beatLineX = default(int);
					{
						double x = ( h.getBeatLineX(beat) + this.stave.staveGroup.layout.renderer.settings.scale );
						beatLineX = ((int) (x) );
					}
					
					global::alphatab.rendering.utils.BeamDirection direction = h.getDirection();
					int y1 = default(int);
					y1 = ( ( cy + this.y ) + (( (( direction == global::alphatab.rendering.utils.BeamDirection.Up )) ? (this.getScoreY(this.getNoteLine(beat.minNote()), new global::haxe.lang.Null<int>(( correction - 1 ), true))) : (this.getScoreY(this.getNoteLine(beat.maxNote()), new global::haxe.lang.Null<int>(( correction - 1 ), true))) )) );
					int y2 = ( ( cy + this.y ) + this.calculateBeamY(h, beatLineX) );
					canvas.setColor(this.stave.staveGroup.layout.renderer.renderingResources.mainGlyphColor);
					canvas.beginPath();
					canvas.moveTo(((double) (((int) (( ( cx + this.x ) + beatLineX )) )) ), ((double) (y1) ));
					canvas.lineTo(((double) (((int) (( ( cx + this.x ) + beatLineX )) )) ), ((double) (y2) ));
					canvas.stroke();
					int brokenBarOffset = ((int) (( 6 * this.stave.staveGroup.layout.renderer.settings.scale )) );
					int barSpacing = ((int) (( 6 * this.stave.staveGroup.layout.renderer.settings.scale )) );
					int barSize = ((int) (( 3 * this.stave.staveGroup.layout.renderer.settings.scale )) );
					int barCount = ( global::alphatab.model.ModelUtils.getDurationIndex(beat.duration) - 2 );
					int barStart = ( cy + this.y );
					if (( direction == global::alphatab.rendering.utils.BeamDirection.Down )) 
					{
						barSpacing =  - (barSpacing) ;
					}
					
					{
						int _g2 = 0;
						while (( _g2 < ((int) (barCount) ) ))
						{
							int barIndex = _g2++;
							int barStartX = default(int);
							int barEndX = default(int);
							int barStartY = default(int);
							int barEndY = default(int);
							int barY = ( barStart + ( barIndex * barSpacing ) );
							if (( i < ( h.beats.length - 1 ) )) 
							{
								if (this.isFullBarJoin(beat, ((global::alphatab.model.Beat) (h.beats[( i + 1 )]) ), barIndex)) 
								{
									barStartX = beatLineX;
									{
										double x1 = ( h.getBeatLineX(((global::alphatab.model.Beat) (h.beats[( i + 1 )]) )) + this.stave.staveGroup.layout.renderer.settings.scale );
										barEndX = ((int) (x1) );
									}
									
								}
								 else 
								{
									if (( ( i == 0 ) ||  ! (this.isFullBarJoin(((global::alphatab.model.Beat) (h.beats[( i - 1 )]) ), beat, barIndex))  )) 
									{
										barStartX = beatLineX;
										barEndX = ( barStartX + brokenBarOffset );
									}
									 else 
									{
										continue;
									}
									
								}
								
								{
									double x2 = ((double) (( barY + this.calculateBeamY(h, barStartX) )) );
									barStartY = ((int) (x2) );
								}
								
								{
									double x3 = ((double) (( barY + this.calculateBeamY(h, barEndX) )) );
									barEndY = ((int) (x3) );
								}
								
								global::alphatab.rendering.ScoreBarRenderer.paintSingleBar(canvas, ( ( cx + this.x ) + barStartX ), barStartY, ( ( cx + this.x ) + barEndX ), barEndY, barSize);
							}
							 else 
							{
								if (( ( i > 0 ) &&  ! (this.isFullBarJoin(beat, ((global::alphatab.model.Beat) (h.beats[( i - 1 )]) ), barIndex))  )) 
								{
									barStartX = ( beatLineX - brokenBarOffset );
									barEndX = beatLineX;
									{
										double x4 = ((double) (( barY + this.calculateBeamY(h, barStartX) )) );
										barStartY = ((int) (x4) );
									}
									
									{
										double x5 = ((double) (( barY + this.calculateBeamY(h, barEndX) )) );
										barEndY = ((int) (x5) );
									}
									
									global::alphatab.rendering.ScoreBarRenderer.paintSingleBar(canvas, ( ( cx + this.x ) + barStartX ), barStartY, ( ( cx + this.x ) + barEndX ), barEndY, barSize);
								}
								
							}
							
						}
						
					}
					
				}
				
			}
		}
		
		
		public virtual   bool isFullBarJoin(global::alphatab.model.Beat a, global::alphatab.model.Beat b, int barIndex)
		{
			unchecked 
			{
				return ( ( ( ( global::alphatab.model.ModelUtils.getDurationIndex(a.duration) - 2 ) - barIndex ) > 0 ) && ( ( ( global::alphatab.model.ModelUtils.getDurationIndex(b.duration) - 2 ) - barIndex ) > 0 ) );
			}
		}
		
		
		public virtual   void paintFooter(int cx, int cy, global::alphatab.platform.ICanvas canvas, global::alphatab.rendering.utils.BeamingHelper h)
		{
			unchecked 
			{
				global::alphatab.model.Beat beat = ((global::alphatab.model.Beat) (h.beats[0]) );
				if (( beat.duration == global::alphatab.model.Duration.Whole )) 
				{
					return ;
				}
				
				bool isGrace = ( beat.graceType != global::alphatab.model.GraceType.None );
				double scaleMod = default(double);
				if (isGrace) 
				{
					scaleMod = 0.7;
				}
				 else 
				{
					scaleMod = ((double) (1) );
				}
				
				int stemSize = this.getStemSize(h.maxDuration);
				int correction = ((int) (( ( 9 * scaleMod ) / 2 )) );
				int beatLineX = default(int);
				{
					double x = ( h.getBeatLineX(beat) + this.stave.staveGroup.layout.renderer.settings.scale );
					beatLineX = ((int) (x) );
				}
				
				global::alphatab.rendering.utils.BeamDirection direction = h.getDirection();
				int topY = this.getScoreY(this.getNoteLine(beat.maxNote()), new global::haxe.lang.Null<int>(correction, true));
				int bottomY = this.getScoreY(this.getNoteLine(beat.minNote()), new global::haxe.lang.Null<int>(correction, true));
				int beamY = default(int);
				if (( direction == global::alphatab.rendering.utils.BeamDirection.Down )) 
				{
					bottomY += ((int) (( stemSize * scaleMod )) );
					beamY = bottomY;
				}
				 else 
				{
					topY -= ((int) (( stemSize * scaleMod )) );
					beamY = topY;
				}
				
				canvas.setColor(this.stave.staveGroup.layout.renderer.renderingResources.mainGlyphColor);
				canvas.beginPath();
				canvas.moveTo(((double) (((int) (( ( cx + this.x ) + beatLineX )) )) ), ((double) (( ( cy + this.y ) + topY )) ));
				canvas.lineTo(((double) (((int) (( ( cx + this.x ) + beatLineX )) )) ), ((double) (( ( cy + this.y ) + bottomY )) ));
				canvas.stroke();
				if (isGrace) 
				{
					double graceSizeY = ( 15 * this.stave.staveGroup.layout.renderer.settings.scale );
					double graceSizeX = ( 12 * this.stave.staveGroup.layout.renderer.settings.scale );
					canvas.beginPath();
					if (( direction == global::alphatab.rendering.utils.BeamDirection.Down )) 
					{
						canvas.moveTo(((double) (((int) (( ( ( cx + this.x ) + beatLineX ) - ( graceSizeX / 2 ) )) )) ), ( ( ( cy + this.y ) + bottomY ) - graceSizeY ));
						canvas.lineTo(((double) (((int) (( ( ( cx + this.x ) + beatLineX ) + ( graceSizeX / 2 ) )) )) ), ((double) (( ( cy + this.y ) + bottomY )) ));
					}
					 else 
					{
						canvas.moveTo(((double) (((int) (( ( ( cx + this.x ) + beatLineX ) - ( graceSizeX / 2 ) )) )) ), ( ( ( cy + this.y ) + topY ) + graceSizeY ));
						canvas.lineTo(((double) (((int) (( ( ( cx + this.x ) + beatLineX ) + ( graceSizeX / 2 ) )) )) ), ((double) (( ( cy + this.y ) + topY )) ));
					}
					
					canvas.stroke();
				}
				
				int gx = ((int) (beatLineX) );
				global::alphatab.rendering.glyphs.BeamGlyph glyph = new global::alphatab.rendering.glyphs.BeamGlyph(new global::haxe.lang.Null<int>(gx, true), new global::haxe.lang.Null<int>(beamY, true), ((global::alphatab.model.Duration) (beat.duration) ), ((global::alphatab.rendering.utils.BeamDirection) (direction) ), ((bool) (isGrace) ));
				glyph.renderer = this;
				glyph.doLayout();
				glyph.paint(( cx + this.x ), ( cy + this.y ), canvas);
			}
		}
		
		
		public override   void createPreBeatGlyphs()
		{
			unchecked 
			{
				global::alphatab.model.MasterBar __temp_stmt525 = default(global::alphatab.model.MasterBar);
				{
					global::alphatab.model.Bar _this = this._bar;
					__temp_stmt525 = ((global::alphatab.model.MasterBar) (_this.track.score.masterBars[_this.index]) );
				}
				
				if (__temp_stmt525.isRepeatStart) 
				{
					this.addPreBeatGlyph(new global::alphatab.rendering.glyphs.RepeatOpenGlyph(new global::haxe.lang.Null<int>(0, true), new global::haxe.lang.Null<int>(0, true), ((double) (1.5) ), ((int) (3) )));
				}
				
				if (( ( this.index == 0 ) || ( this._bar.clef != this._bar.previousBar.clef ) )) 
				{
					int offset = 0;
					{
						global::alphatab.model.Clef _g = this._bar.clef;
						switch (global::haxe.root.Type.enumIndex(_g))
						{
							case 0:
							{
								offset = 4;
								break;
							}
							
							
							case 3:
							{
								offset = 4;
								break;
							}
							
							
							case 1:
							{
								offset = 6;
								break;
							}
							
							
							case 2:
							{
								offset = 4;
								break;
							}
							
							
							case 4:
							{
								offset = 6;
								break;
							}
							
							
						}
						
					}
					
					this.createStartSpacing();
					this.addPreBeatGlyph(new global::alphatab.rendering.glyphs.ClefGlyph(new global::haxe.lang.Null<int>(0, true), new global::haxe.lang.Null<int>(this.getScoreY(offset, default(global::haxe.lang.Null<int>)), true), ((global::alphatab.model.Clef) (this._bar.clef) )));
				}
				
				bool __temp_boolv529 = ( this._bar.previousBar == default(global::alphatab.model.Bar) );
				bool __temp_boolv528 = false;
				if (__temp_boolv529) 
				{
					global::alphatab.model.MasterBar __temp_stmt530 = default(global::alphatab.model.MasterBar);
					{
						global::alphatab.model.Bar _this1 = this._bar;
						__temp_stmt530 = ((global::alphatab.model.MasterBar) (_this1.track.score.masterBars[_this1.index]) );
					}
					
					__temp_boolv528 = ( __temp_stmt530.keySignature != 0 );
				}
				
				bool __temp_stmt527 = ( __temp_boolv529 && __temp_boolv528 );
				bool __temp_boolv531 = false;
				if ( ! (__temp_stmt527) ) 
				{
					bool __temp_boolv533 = ( this._bar.previousBar != default(global::alphatab.model.Bar) );
					bool __temp_boolv532 = false;
					if (__temp_boolv533) 
					{
						global::alphatab.model.MasterBar __temp_stmt534 = default(global::alphatab.model.MasterBar);
						{
							global::alphatab.model.Bar _this2 = this._bar;
							__temp_stmt534 = ((global::alphatab.model.MasterBar) (_this2.track.score.masterBars[_this2.index]) );
						}
						
						global::alphatab.model.MasterBar __temp_stmt535 = default(global::alphatab.model.MasterBar);
						{
							global::alphatab.model.Bar _this3 = this._bar.previousBar;
							__temp_stmt535 = ((global::alphatab.model.MasterBar) (_this3.track.score.masterBars[_this3.index]) );
						}
						
						__temp_boolv532 = ( __temp_stmt534.keySignature != __temp_stmt535.keySignature );
					}
					
					__temp_boolv531 = ( __temp_boolv533 && __temp_boolv532 );
				}
				
				bool __temp_stmt526 = ( __temp_stmt527 || __temp_boolv531 );
				if (__temp_stmt526) 
				{
					this.createStartSpacing();
					this.createKeySignatureGlyphs();
				}
				
				bool __temp_stmt538 = ( this._bar.previousBar == default(global::alphatab.model.Bar) );
				bool __temp_boolv539 = false;
				if ( ! (__temp_stmt538) ) 
				{
					bool __temp_boolv541 = ( this._bar.previousBar != default(global::alphatab.model.Bar) );
					bool __temp_boolv540 = false;
					if (__temp_boolv541) 
					{
						global::alphatab.model.MasterBar __temp_stmt542 = default(global::alphatab.model.MasterBar);
						{
							global::alphatab.model.Bar _this4 = this._bar;
							__temp_stmt542 = ((global::alphatab.model.MasterBar) (_this4.track.score.masterBars[_this4.index]) );
						}
						
						global::alphatab.model.MasterBar __temp_stmt543 = default(global::alphatab.model.MasterBar);
						{
							global::alphatab.model.Bar _this5 = this._bar.previousBar;
							__temp_stmt543 = ((global::alphatab.model.MasterBar) (_this5.track.score.masterBars[_this5.index]) );
						}
						
						__temp_boolv540 = ( __temp_stmt542.timeSignatureNumerator != __temp_stmt543.timeSignatureNumerator );
					}
					
					__temp_boolv539 = ( __temp_boolv541 && __temp_boolv540 );
				}
				
				bool __temp_stmt537 = ( __temp_stmt538 || __temp_boolv539 );
				bool __temp_boolv544 = false;
				if ( ! (__temp_stmt537) ) 
				{
					bool __temp_boolv546 = ( this._bar.previousBar != default(global::alphatab.model.Bar) );
					bool __temp_boolv545 = false;
					if (__temp_boolv546) 
					{
						global::alphatab.model.MasterBar __temp_stmt547 = default(global::alphatab.model.MasterBar);
						{
							global::alphatab.model.Bar _this6 = this._bar;
							__temp_stmt547 = ((global::alphatab.model.MasterBar) (_this6.track.score.masterBars[_this6.index]) );
						}
						
						global::alphatab.model.MasterBar __temp_stmt548 = default(global::alphatab.model.MasterBar);
						{
							global::alphatab.model.Bar _this7 = this._bar.previousBar;
							__temp_stmt548 = ((global::alphatab.model.MasterBar) (_this7.track.score.masterBars[_this7.index]) );
						}
						
						__temp_boolv545 = ( __temp_stmt547.timeSignatureDenominator != __temp_stmt548.timeSignatureDenominator );
					}
					
					__temp_boolv544 = ( __temp_boolv546 && __temp_boolv545 );
				}
				
				bool __temp_stmt536 = ( __temp_stmt537 || __temp_boolv544 );
				if (__temp_stmt536) 
				{
					this.createStartSpacing();
					this.createTimeSignatureGlyphs();
				}
				
				this.addPreBeatGlyph(new global::alphatab.rendering.glyphs.BarNumberGlyph(new global::haxe.lang.Null<int>(0, true), new global::haxe.lang.Null<int>(this.getScoreY(-1, new global::haxe.lang.Null<int>(-3, true)), true), ((int) (( this._bar.index + 1 )) ), new global::haxe.lang.Null<bool>( ! (this.stave.isFirstInAccolade) , true)));
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
		
		
		public override   void createPostBeatGlyphs()
		{
			unchecked 
			{
				global::alphatab.model.MasterBar __temp_stmt549 = default(global::alphatab.model.MasterBar);
				{
					global::alphatab.model.Bar _this = this._bar;
					__temp_stmt549 = ((global::alphatab.model.MasterBar) (_this.track.score.masterBars[_this.index]) );
				}
				
				if (( __temp_stmt549.repeatCount > 0 )) 
				{
					this.addPostBeatGlyph(new global::alphatab.rendering.glyphs.RepeatCloseGlyph(new global::haxe.lang.Null<int>(this.x, true), new global::haxe.lang.Null<int>(0, true)));
					global::alphatab.model.MasterBar __temp_stmt555 = default(global::alphatab.model.MasterBar);
					{
						global::alphatab.model.Bar _this1 = this._bar;
						__temp_stmt555 = ((global::alphatab.model.MasterBar) (_this1.track.score.masterBars[_this1.index]) );
					}
					
					if (( __temp_stmt555.repeatCount > 2 )) 
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
						
						global::haxe.lang.Null<int> __temp_stmt556 = new global::haxe.lang.Null<int>(this.getScoreY(line, new global::haxe.lang.Null<int>(-3, true)), true);
						global::alphatab.model.MasterBar __temp_stmt557 = default(global::alphatab.model.MasterBar);
						{
							global::alphatab.model.Bar _this2 = this._bar;
							__temp_stmt557 = ((global::alphatab.model.MasterBar) (_this2.track.score.masterBars[_this2.index]) );
						}
						
						this.addPostBeatGlyph(new global::alphatab.rendering.glyphs.RepeatCountGlyph(new global::haxe.lang.Null<int>(0, true), __temp_stmt556, ((int) (__temp_stmt557.repeatCount) )));
					}
					
				}
				 else 
				{
					global::alphatab.model.MasterBar __temp_stmt550 = default(global::alphatab.model.MasterBar);
					{
						global::alphatab.model.Bar _this3 = this._bar;
						__temp_stmt550 = ((global::alphatab.model.MasterBar) (_this3.track.score.masterBars[_this3.index]) );
					}
					
					if (__temp_stmt550.isDoubleBar) 
					{
						this.addPostBeatGlyph(new global::alphatab.rendering.glyphs.BarSeperatorGlyph(((global::haxe.lang.Null<int>) (default(global::haxe.lang.Null<int>)) ), ((global::haxe.lang.Null<int>) (default(global::haxe.lang.Null<int>)) ), ((global::haxe.lang.Null<bool>) (default(global::haxe.lang.Null<bool>)) )));
						this.addPostBeatGlyph(new global::alphatab.rendering.glyphs.SpacingGlyph(new global::haxe.lang.Null<int>(0, true), new global::haxe.lang.Null<int>(0, true), ((int) (( 3 * this.stave.staveGroup.layout.renderer.settings.scale )) ), new global::haxe.lang.Null<bool>(false, true)));
						this.addPostBeatGlyph(new global::alphatab.rendering.glyphs.BarSeperatorGlyph(((global::haxe.lang.Null<int>) (default(global::haxe.lang.Null<int>)) ), ((global::haxe.lang.Null<int>) (default(global::haxe.lang.Null<int>)) ), ((global::haxe.lang.Null<bool>) (default(global::haxe.lang.Null<bool>)) )));
					}
					 else 
					{
						bool __temp_stmt552 = ( this._bar.nextBar == default(global::alphatab.model.Bar) );
						bool __temp_boolv553 = false;
						if ( ! (__temp_stmt552) ) 
						{
							global::alphatab.model.MasterBar __temp_stmt554 = default(global::alphatab.model.MasterBar);
							{
								global::alphatab.model.Bar _this4 = this._bar.nextBar;
								__temp_stmt554 = ((global::alphatab.model.MasterBar) (_this4.track.score.masterBars[_this4.index]) );
							}
							
							__temp_boolv553 =  ! (__temp_stmt554.isRepeatStart) ;
						}
						
						bool __temp_stmt551 = ( __temp_stmt552 || __temp_boolv553 );
						if (__temp_stmt551) 
						{
							this.addPostBeatGlyph(new global::alphatab.rendering.glyphs.BarSeperatorGlyph(new global::haxe.lang.Null<int>(0, true), new global::haxe.lang.Null<int>(0, true), new global::haxe.lang.Null<bool>(( this._bar.index == ( this._bar.track.bars.length - 1 ) ), true)));
						}
						
					}
					
				}
				
			}
		}
		
		
		public  bool _startSpacing;
		
		public virtual   void createStartSpacing()
		{
			unchecked 
			{
				if (this._startSpacing) 
				{
					return ;
				}
				
				this.addPreBeatGlyph(new global::alphatab.rendering.glyphs.SpacingGlyph(new global::haxe.lang.Null<int>(0, true), new global::haxe.lang.Null<int>(0, true), ((int) (( 2 * this.stave.staveGroup.layout.renderer.settings.scale )) ), ((global::haxe.lang.Null<bool>) (default(global::haxe.lang.Null<bool>)) )));
				this._startSpacing = true;
			}
		}
		
		
		public virtual   void createKeySignatureGlyphs()
		{
			unchecked 
			{
				int offsetClef = 0;
				global::alphatab.model.MasterBar __temp_stmt558 = default(global::alphatab.model.MasterBar);
				{
					global::alphatab.model.Bar _this = this._bar;
					__temp_stmt558 = ((global::alphatab.model.MasterBar) (_this.track.score.masterBars[_this.index]) );
				}
				
				int currentKey = __temp_stmt558.keySignature;
				int previousKey = default(int);
				if (( this._bar.previousBar == default(global::alphatab.model.Bar) )) 
				{
					previousKey = 0;
				}
				 else 
				{
					global::alphatab.model.MasterBar __temp_stmt559 = default(global::alphatab.model.MasterBar);
					{
						global::alphatab.model.Bar _this1 = this._bar.previousBar;
						__temp_stmt559 = ((global::alphatab.model.MasterBar) (_this1.track.score.masterBars[_this1.index]) );
					}
					
					previousKey = __temp_stmt559.keySignature;
				}
				
				{
					global::alphatab.model.Clef _g = this._bar.clef;
					switch (global::haxe.root.Type.enumIndex(_g))
					{
						case 0:
						{
							offsetClef = 0;
							break;
						}
						
						
						case 4:
						{
							offsetClef = 0;
							break;
						}
						
						
						case 3:
						{
							offsetClef = 2;
							break;
						}
						
						
						case 1:
						{
							offsetClef = -1;
							break;
						}
						
						
						case 2:
						{
							offsetClef = 1;
							break;
						}
						
						
					}
					
				}
				
				int naturalizeSymbols = default(int);
				{
					double x = global::System.Math.Abs(((double) (previousKey) ));
					naturalizeSymbols = ((int) (x) );
				}
				
				global::haxe.root.Array<int> previousKeyPositions = default(global::haxe.root.Array<int>);
				if (( previousKey > 0 )) 
				{
					previousKeyPositions = global::alphatab.rendering.ScoreBarRenderer.SharpKsSteps;
				}
				 else 
				{
					previousKeyPositions = global::alphatab.rendering.ScoreBarRenderer.FlatKsSteps;
				}
				
				{
					int _g1 = 0;
					while (( _g1 < naturalizeSymbols ))
					{
						int i = _g1++;
						int __temp_stmt560 = default(int);
						{
							double x1 = ((double) (this.getScoreY(( previousKeyPositions[i] + offsetClef ), default(global::haxe.lang.Null<int>))) );
							__temp_stmt560 = ((int) (x1) );
						}
						
						this.addPreBeatGlyph(new global::alphatab.rendering.glyphs.NaturalizeGlyph(new global::haxe.lang.Null<int>(0, true), new global::haxe.lang.Null<int>(__temp_stmt560, true), ((global::haxe.lang.Null<bool>) (default(global::haxe.lang.Null<bool>)) )));
					}
					
				}
				
				int offsetSymbols = default(int);
				if (( currentKey <= 7 )) 
				{
					offsetSymbols = currentKey;
				}
				 else 
				{
					offsetSymbols = ( currentKey - 7 );
				}
				
				if (( currentKey > 0 )) 
				{
					int _g11 = 0;
					int _g2 = default(int);
					{
						double x2 = global::System.Math.Abs(((double) (currentKey) ));
						_g2 = ((int) (x2) );
					}
					
					while (( _g11 < _g2 ))
					{
						int i1 = _g11++;
						int __temp_stmt562 = default(int);
						{
							double x3 = ((double) (this.getScoreY(( global::alphatab.rendering.ScoreBarRenderer.SharpKsSteps[i1] + offsetClef ), default(global::haxe.lang.Null<int>))) );
							__temp_stmt562 = ((int) (x3) );
						}
						
						this.addPreBeatGlyph(new global::alphatab.rendering.glyphs.SharpGlyph(new global::haxe.lang.Null<int>(0, true), new global::haxe.lang.Null<int>(__temp_stmt562, true), ((global::haxe.lang.Null<bool>) (default(global::haxe.lang.Null<bool>)) )));
					}
					
				}
				 else 
				{
					int _g12 = 0;
					int _g3 = default(int);
					{
						double x4 = global::System.Math.Abs(((double) (currentKey) ));
						_g3 = ((int) (x4) );
					}
					
					while (( _g12 < _g3 ))
					{
						int i2 = _g12++;
						int __temp_stmt561 = default(int);
						{
							double x5 = ((double) (this.getScoreY(( global::alphatab.rendering.ScoreBarRenderer.FlatKsSteps[i2] + offsetClef ), default(global::haxe.lang.Null<int>))) );
							__temp_stmt561 = ((int) (x5) );
						}
						
						this.addPreBeatGlyph(new global::alphatab.rendering.glyphs.FlatGlyph(new global::haxe.lang.Null<int>(0, true), new global::haxe.lang.Null<int>(__temp_stmt561, true), ((global::haxe.lang.Null<bool>) (default(global::haxe.lang.Null<bool>)) )));
					}
					
				}
				
			}
		}
		
		
		public virtual   void createTimeSignatureGlyphs()
		{
			unchecked 
			{
				this.addPreBeatGlyph(new global::alphatab.rendering.glyphs.SpacingGlyph(new global::haxe.lang.Null<int>(0, true), new global::haxe.lang.Null<int>(0, true), ((int) (( 5 * this.stave.staveGroup.layout.renderer.settings.scale )) ), ((global::haxe.lang.Null<bool>) (default(global::haxe.lang.Null<bool>)) )));
				global::alphatab.model.MasterBar __temp_stmt563 = default(global::alphatab.model.MasterBar);
				{
					global::alphatab.model.Bar _this = this._bar;
					__temp_stmt563 = ((global::alphatab.model.MasterBar) (_this.track.score.masterBars[_this.index]) );
				}
				
				global::alphatab.model.MasterBar __temp_stmt564 = default(global::alphatab.model.MasterBar);
				{
					global::alphatab.model.Bar _this1 = this._bar;
					__temp_stmt564 = ((global::alphatab.model.MasterBar) (_this1.track.score.masterBars[_this1.index]) );
				}
				
				this.addPreBeatGlyph(new global::alphatab.rendering.glyphs.TimeSignatureGlyph(((int) (0) ), ((int) (0) ), ((int) (__temp_stmt563.timeSignatureNumerator) ), ((int) (__temp_stmt564.timeSignatureDenominator) )));
			}
		}
		
		
		public virtual   void createVoiceGlyphs(global::alphatab.model.Voice v)
		{
			unchecked 
			{
				this._currentBeamHelper = default(global::alphatab.rendering.utils.BeamingHelper);
				this._beamHelpers.push(new global::haxe.root.Array<object>());
				this._beamHelperLookup.push(new global::haxe.ds.IntMap<object>());
				this._tupletHelpers.push(new global::haxe.root.Array<object>());
				{
					int _g = 0;
					global::haxe.root.Array<object> _g1 = v.beats;
					while (( _g < _g1.length ))
					{
						global::alphatab.model.Beat b = ((global::alphatab.model.Beat) (_g1[_g]) );
						 ++ _g;
						bool newBeamingHelper = false;
						if ( ! (b.isRest()) ) 
						{
							if (( ( this._currentBeamHelper == default(global::alphatab.rendering.utils.BeamingHelper) ) ||  ! (this._currentBeamHelper.checkBeat(b))  )) 
							{
								this._currentBeamHelper = new global::alphatab.rendering.utils.BeamingHelper(((global::alphatab.model.Track) (this._bar.track) ));
								this._currentBeamHelper.checkBeat(b);
								((global::haxe.root.Array<object>) (global::haxe.root.Array<object>.__hx_cast<object>(((global::haxe.root.Array) (this._beamHelpers[v.index]) ))) ).push(this._currentBeamHelper);
								newBeamingHelper = true;
							}
							
						}
						
						if ((  ! ((( ( b.tupletDenominator == -1 ) && ( b.tupletNumerator == -1 ) )))  &&  ! ((( ( b.tupletDenominator == 1 ) && ( b.tupletNumerator == 1 ) )))  )) 
						{
							global::alphatab.model.Beat previousBeat = b.previousBeat;
							if (( ( previousBeat != default(global::alphatab.model.Beat) ) && ( previousBeat.voice != b.voice ) )) 
							{
								previousBeat = default(global::alphatab.model.Beat);
							}
							
							if (( newBeamingHelper && ( this._currentTupletHelper != default(global::alphatab.rendering.utils.TupletHelper) ) )) 
							{
								this._currentTupletHelper.finish();
							}
							
							if (( ( ( previousBeat == default(global::alphatab.model.Beat) ) || ( this._currentTupletHelper == default(global::alphatab.rendering.utils.TupletHelper) ) ) ||  ! (this._currentTupletHelper.check(b))  )) 
							{
								this._currentTupletHelper = new global::alphatab.rendering.utils.TupletHelper(((int) (v.index) ));
								this._currentTupletHelper.check(b);
								((global::haxe.root.Array<object>) (global::haxe.root.Array<object>.__hx_cast<object>(((global::haxe.root.Array) (this._tupletHelpers[v.index]) ))) ).push(this._currentTupletHelper);
							}
							
						}
						
						global::alphatab.rendering.glyphs.ScoreBeatContainerGlyph container = new global::alphatab.rendering.glyphs.ScoreBeatContainerGlyph(((global::alphatab.model.Beat) (b) ));
						container.preNotes = new global::alphatab.rendering.glyphs.ScoreBeatPreNotesGlyph();
						container.onNotes = new global::alphatab.rendering.glyphs.ScoreBeatGlyph();
						(((global::alphatab.rendering.glyphs.ScoreBeatGlyph) (container.onNotes) )).beamingHelper = this._currentBeamHelper;
						container.postNotes = new global::alphatab.rendering.glyphs.ScoreBeatPostNotesGlyph();
						((global::haxe.ds.IntMap<object>) (global::haxe.ds.IntMap<object>.__hx_cast<object>(((global::haxe.ds.IntMap) (this._beamHelperLookup[v.index]) ))) ).@set(b.index, this._currentBeamHelper);
						this.addBeatGlyph(container);
					}
					
				}
				
				this._currentBeamHelper = default(global::alphatab.rendering.utils.BeamingHelper);
			}
		}
		
		
		public virtual   int getNoteLine(global::alphatab.model.Note n)
		{
			unchecked 
			{
				int @value = default(int);
				if (n.beat.voice.bar.track.isPercussion) 
				{
					@value = global::alphatab.rendering.utils.PercussionMapper.mapValue(n);
				}
				 else 
				{
					@value = ( n.fret + n.beat.voice.bar.track.tuning[( ( n.beat.voice.bar.track.tuning.length - (( n.@string - 1 )) ) - 1 )] );
				}
				
				global::alphatab.model.MasterBar __temp_stmt565 = default(global::alphatab.model.MasterBar);
				{
					global::alphatab.model.Bar _this = n.beat.voice.bar;
					__temp_stmt565 = ((global::alphatab.model.MasterBar) (_this.track.score.masterBars[_this.index]) );
				}
				
				int ks = __temp_stmt565.keySignature;
				global::alphatab.model.Clef clef = n.beat.voice.bar.clef;
				int index = ( @value % 12 );
				int octave = ( @value / 12 );
				int steps = global::alphatab.rendering.ScoreBarRenderer.OctaveSteps[global::alphatab.model.ModelUtils.getClefIndex(clef)];
				steps -= ( octave * 7 );
				steps -= ( (( ( ks > 0 ) || ( ks == 0 ) )) ? (global::alphatab.rendering.ScoreBarRenderer.SharpNoteSteps[index]) : (global::alphatab.rendering.ScoreBarRenderer.FLAT_NOTE_STEPS[index]) );
				return ( steps + 1 );
			}
		}
		
		
		public virtual   int getScoreY(int steps, global::haxe.lang.Null<int> correction)
		{
			unchecked 
			{
				int __temp_correction99 = ( (global::haxe.lang.Runtime.eq((correction).toDynamic(), (default(global::haxe.lang.Null<int>)).toDynamic())) ? (((int) (0) )) : (correction.@value) );
				return ((int) (( ( ( ( 9 * this.stave.staveGroup.layout.renderer.settings.scale ) / 2 ) * steps ) + ( __temp_correction99 * this.stave.staveGroup.layout.renderer.settings.scale ) )) );
			}
		}
		
		
		public virtual   int getGlyphOverflow()
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
				int lineY = ( ( cy + this.y ) + this.getGlyphOverflow() );
				int startY = lineY;
				{
					int _g = 0;
					while (( _g < 5 ))
					{
						int i = _g++;
						if (( i > 0 )) 
						{
							lineY += ((int) (( 9 * this.stave.staveGroup.layout.renderer.settings.scale )) );
						}
						
						canvas.beginPath();
						canvas.moveTo(((double) (( cx + this.x )) ), ((double) (lineY) ));
						canvas.lineTo(((double) (( ( cx + this.x ) + this.width )) ), ((double) (lineY) ));
						canvas.stroke();
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
					case 1708501536:
					{
						this._startSpacing = ((bool) (@value) );
						return @value;
					}
					
					
					case 544876244:
					{
						this._currentTupletHelper = ((global::alphatab.rendering.utils.TupletHelper) (@value) );
						return @value;
					}
					
					
					case 430913175:
					{
						this._currentBeamHelper = ((global::alphatab.rendering.utils.BeamingHelper) (@value) );
						return @value;
					}
					
					
					case 411825530:
					{
						this._tupletHelpers = ((global::haxe.root.Array<object>) (global::haxe.root.Array<object>.__hx_cast<object>(((global::haxe.root.Array) (@value) ))) );
						return @value;
					}
					
					
					case 20078838:
					{
						this._beamHelperLookup = ((global::haxe.root.Array<object>) (global::haxe.root.Array<object>.__hx_cast<object>(((global::haxe.root.Array) (@value) ))) );
						return @value;
					}
					
					
					case 1848890263:
					{
						this._beamHelpers = ((global::haxe.root.Array<object>) (global::haxe.root.Array<object>.__hx_cast<object>(((global::haxe.root.Array) (@value) ))) );
						return @value;
					}
					
					
					case 662803912:
					{
						this.accidentalHelper = ((global::alphatab.rendering.utils.AccidentalHelper) (@value) );
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
					case 1334722860:
					{
						return ((global::haxe.lang.Function) (new global::haxe.lang.Closure(((object) (this) ), global::haxe.lang.Runtime.toString("paintBackground"), ((int) (1334722860) ))) );
					}
					
					
					case 235590296:
					{
						return ((global::haxe.lang.Function) (new global::haxe.lang.Closure(((object) (this) ), global::haxe.lang.Runtime.toString("getGlyphOverflow"), ((int) (235590296) ))) );
					}
					
					
					case 1103232509:
					{
						return ((global::haxe.lang.Function) (new global::haxe.lang.Closure(((object) (this) ), global::haxe.lang.Runtime.toString("getScoreY"), ((int) (1103232509) ))) );
					}
					
					
					case 2094661564:
					{
						return ((global::haxe.lang.Function) (new global::haxe.lang.Closure(((object) (this) ), global::haxe.lang.Runtime.toString("getNoteLine"), ((int) (2094661564) ))) );
					}
					
					
					case 131841789:
					{
						return ((global::haxe.lang.Function) (new global::haxe.lang.Closure(((object) (this) ), global::haxe.lang.Runtime.toString("createVoiceGlyphs"), ((int) (131841789) ))) );
					}
					
					
					case 841501494:
					{
						return ((global::haxe.lang.Function) (new global::haxe.lang.Closure(((object) (this) ), global::haxe.lang.Runtime.toString("createTimeSignatureGlyphs"), ((int) (841501494) ))) );
					}
					
					
					case 655539612:
					{
						return ((global::haxe.lang.Function) (new global::haxe.lang.Closure(((object) (this) ), global::haxe.lang.Runtime.toString("createKeySignatureGlyphs"), ((int) (655539612) ))) );
					}
					
					
					case 2105889885:
					{
						return ((global::haxe.lang.Function) (new global::haxe.lang.Closure(((object) (this) ), global::haxe.lang.Runtime.toString("createStartSpacing"), ((int) (2105889885) ))) );
					}
					
					
					case 1708501536:
					{
						return this._startSpacing;
					}
					
					
					case 2000963577:
					{
						return ((global::haxe.lang.Function) (new global::haxe.lang.Closure(((object) (this) ), global::haxe.lang.Runtime.toString("createPostBeatGlyphs"), ((int) (2000963577) ))) );
					}
					
					
					case 1907509625:
					{
						return ((global::haxe.lang.Function) (new global::haxe.lang.Closure(((object) (this) ), global::haxe.lang.Runtime.toString("createBeatGlyphs"), ((int) (1907509625) ))) );
					}
					
					
					case 918754500:
					{
						return ((global::haxe.lang.Function) (new global::haxe.lang.Closure(((object) (this) ), global::haxe.lang.Runtime.toString("createPreBeatGlyphs"), ((int) (918754500) ))) );
					}
					
					
					case 1579021529:
					{
						return ((global::haxe.lang.Function) (new global::haxe.lang.Closure(((object) (this) ), global::haxe.lang.Runtime.toString("paintFooter"), ((int) (1579021529) ))) );
					}
					
					
					case 956261828:
					{
						return ((global::haxe.lang.Function) (new global::haxe.lang.Closure(((object) (this) ), global::haxe.lang.Runtime.toString("isFullBarJoin"), ((int) (956261828) ))) );
					}
					
					
					case 1713359061:
					{
						return ((global::haxe.lang.Function) (new global::haxe.lang.Closure(((object) (this) ), global::haxe.lang.Runtime.toString("paintBar"), ((int) (1713359061) ))) );
					}
					
					
					case 1392437444:
					{
						return ((global::haxe.lang.Function) (new global::haxe.lang.Closure(((object) (this) ), global::haxe.lang.Runtime.toString("calculateBeamY"), ((int) (1392437444) ))) );
					}
					
					
					case 188501856:
					{
						return ((global::haxe.lang.Function) (new global::haxe.lang.Closure(((object) (this) ), global::haxe.lang.Runtime.toString("getStemSize"), ((int) (188501856) ))) );
					}
					
					
					case 1496985272:
					{
						return ((global::haxe.lang.Function) (new global::haxe.lang.Closure(((object) (this) ), global::haxe.lang.Runtime.toString("paintTupletHelper"), ((int) (1496985272) ))) );
					}
					
					
					case 416595323:
					{
						return ((global::haxe.lang.Function) (new global::haxe.lang.Closure(((object) (this) ), global::haxe.lang.Runtime.toString("paintBeamHelper"), ((int) (416595323) ))) );
					}
					
					
					case 115063718:
					{
						return ((global::haxe.lang.Function) (new global::haxe.lang.Closure(((object) (this) ), global::haxe.lang.Runtime.toString("paintBeams"), ((int) (115063718) ))) );
					}
					
					
					case 914740105:
					{
						return ((global::haxe.lang.Function) (new global::haxe.lang.Closure(((object) (this) ), global::haxe.lang.Runtime.toString("paintTuplets"), ((int) (914740105) ))) );
					}
					
					
					case 1028568990:
					{
						return ((global::haxe.lang.Function) (new global::haxe.lang.Closure(((object) (this) ), global::haxe.lang.Runtime.toString("paint"), ((int) (1028568990) ))) );
					}
					
					
					case 1825584277:
					{
						return ((global::haxe.lang.Function) (new global::haxe.lang.Closure(((object) (this) ), global::haxe.lang.Runtime.toString("doLayout"), ((int) (1825584277) ))) );
					}
					
					
					case 291106525:
					{
						return ((global::haxe.lang.Function) (new global::haxe.lang.Closure(((object) (this) ), global::haxe.lang.Runtime.toString("getLineOffset"), ((int) (291106525) ))) );
					}
					
					
					case 357418928:
					{
						return ((global::haxe.lang.Function) (new global::haxe.lang.Closure(((object) (this) ), global::haxe.lang.Runtime.toString("getBottomPadding"), ((int) (357418928) ))) );
					}
					
					
					case 415081458:
					{
						return ((global::haxe.lang.Function) (new global::haxe.lang.Closure(((object) (this) ), global::haxe.lang.Runtime.toString("getTopPadding"), ((int) (415081458) ))) );
					}
					
					
					case 2141318065:
					{
						return ((global::haxe.lang.Function) (new global::haxe.lang.Closure(((object) (this) ), global::haxe.lang.Runtime.toString("getNoteY"), ((int) (2141318065) ))) );
					}
					
					
					case 2141318064:
					{
						return ((global::haxe.lang.Function) (new global::haxe.lang.Closure(((object) (this) ), global::haxe.lang.Runtime.toString("getNoteX"), ((int) (2141318064) ))) );
					}
					
					
					case 913255283:
					{
						return ((global::haxe.lang.Function) (new global::haxe.lang.Closure(((object) (this) ), global::haxe.lang.Runtime.toString("getBeatDirection"), ((int) (913255283) ))) );
					}
					
					
					case 544876244:
					{
						return this._currentTupletHelper;
					}
					
					
					case 430913175:
					{
						return this._currentBeamHelper;
					}
					
					
					case 411825530:
					{
						return this._tupletHelpers;
					}
					
					
					case 20078838:
					{
						return this._beamHelperLookup;
					}
					
					
					case 1848890263:
					{
						return this._beamHelpers;
					}
					
					
					case 662803912:
					{
						return this.accidentalHelper;
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
					case 415081458:case 357418928:case 1825584277:case 1028568990:case 918754500:case 1907509625:case 2000963577:case 1334722860:
					{
						return global::haxe.lang.Runtime.slowCallField(this, field, dynargs);
					}
					
					
					case 235590296:
					{
						return this.getGlyphOverflow();
					}
					
					
					case 1103232509:
					{
						return this.getScoreY(((int) (global::haxe.lang.Runtime.toInt(dynargs[0])) ), global::haxe.lang.Null<object>.ofDynamic<int>(dynargs[1]));
					}
					
					
					case 2094661564:
					{
						return this.getNoteLine(((global::alphatab.model.Note) (dynargs[0]) ));
					}
					
					
					case 131841789:
					{
						this.createVoiceGlyphs(((global::alphatab.model.Voice) (dynargs[0]) ));
						break;
					}
					
					
					case 841501494:
					{
						this.createTimeSignatureGlyphs();
						break;
					}
					
					
					case 655539612:
					{
						this.createKeySignatureGlyphs();
						break;
					}
					
					
					case 2105889885:
					{
						this.createStartSpacing();
						break;
					}
					
					
					case 1579021529:
					{
						this.paintFooter(((int) (global::haxe.lang.Runtime.toInt(dynargs[0])) ), ((int) (global::haxe.lang.Runtime.toInt(dynargs[1])) ), ((global::alphatab.platform.ICanvas) (dynargs[2]) ), ((global::alphatab.rendering.utils.BeamingHelper) (dynargs[3]) ));
						break;
					}
					
					
					case 956261828:
					{
						return this.isFullBarJoin(((global::alphatab.model.Beat) (dynargs[0]) ), ((global::alphatab.model.Beat) (dynargs[1]) ), ((int) (global::haxe.lang.Runtime.toInt(dynargs[2])) ));
					}
					
					
					case 1713359061:
					{
						this.paintBar(((int) (global::haxe.lang.Runtime.toInt(dynargs[0])) ), ((int) (global::haxe.lang.Runtime.toInt(dynargs[1])) ), ((global::alphatab.platform.ICanvas) (dynargs[2]) ), ((global::alphatab.rendering.utils.BeamingHelper) (dynargs[3]) ));
						break;
					}
					
					
					case 1392437444:
					{
						return this.calculateBeamY(((global::alphatab.rendering.utils.BeamingHelper) (dynargs[0]) ), ((int) (global::haxe.lang.Runtime.toInt(dynargs[1])) ));
					}
					
					
					case 188501856:
					{
						return this.getStemSize(((global::alphatab.model.Duration) (dynargs[0]) ));
					}
					
					
					case 1496985272:
					{
						this.paintTupletHelper(((int) (global::haxe.lang.Runtime.toInt(dynargs[0])) ), ((int) (global::haxe.lang.Runtime.toInt(dynargs[1])) ), ((global::alphatab.platform.ICanvas) (dynargs[2]) ), ((global::alphatab.rendering.utils.TupletHelper) (dynargs[3]) ));
						break;
					}
					
					
					case 416595323:
					{
						this.paintBeamHelper(((int) (global::haxe.lang.Runtime.toInt(dynargs[0])) ), ((int) (global::haxe.lang.Runtime.toInt(dynargs[1])) ), ((global::alphatab.platform.ICanvas) (dynargs[2]) ), ((global::alphatab.rendering.utils.BeamingHelper) (dynargs[3]) ));
						break;
					}
					
					
					case 115063718:
					{
						this.paintBeams(((int) (global::haxe.lang.Runtime.toInt(dynargs[0])) ), ((int) (global::haxe.lang.Runtime.toInt(dynargs[1])) ), ((global::alphatab.platform.ICanvas) (dynargs[2]) ));
						break;
					}
					
					
					case 914740105:
					{
						this.paintTuplets(((int) (global::haxe.lang.Runtime.toInt(dynargs[0])) ), ((int) (global::haxe.lang.Runtime.toInt(dynargs[1])) ), ((global::alphatab.platform.ICanvas) (dynargs[2]) ));
						break;
					}
					
					
					case 291106525:
					{
						return this.getLineOffset();
					}
					
					
					case 2141318065:
					{
						return this.getNoteY(((global::alphatab.model.Note) (dynargs[0]) ));
					}
					
					
					case 2141318064:
					{
						return this.getNoteX(((global::alphatab.model.Note) (dynargs[0]) ), global::haxe.lang.Null<object>.ofDynamic<bool>(dynargs[1]));
					}
					
					
					case 913255283:
					{
						return this.getBeatDirection(((global::alphatab.model.Beat) (dynargs[0]) ));
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
				baseArr.push("_startSpacing");
				baseArr.push("_currentTupletHelper");
				baseArr.push("_currentBeamHelper");
				baseArr.push("_tupletHelpers");
				baseArr.push("_beamHelperLookup");
				baseArr.push("_beamHelpers");
				baseArr.push("accidentalHelper");
				{
					base.__hx_getFields(baseArr);
				}
				
			}
		}
		
		
	}
}



#pragma warning disable 109, 114, 219, 429, 168, 162
namespace alphatab.rendering
{
	public  class ScoreBarRenderer_calculateBeamY_372__Fun : global::haxe.lang.Function 
	{
		public    ScoreBarRenderer_calculateBeamY_372__Fun(global::haxe.root.Array<int> correction, global::haxe.root.Array<object> _g) : base(1, 1)
		{
			unchecked 
			{
				this.correction = correction;
				this._g = _g;
			}
		}
		
		
		public override   double __hx_invoke1_f(double __fn_float1, object __fn_dyn1)
		{
			unchecked 
			{
				global::alphatab.model.Note n = ( (global::haxe.lang.Runtime.eq(__fn_dyn1, global::haxe.lang.Runtime.undefined)) ? (((global::alphatab.model.Note) (((object) (__fn_float1) )) )) : (((global::alphatab.model.Note) (__fn_dyn1) )) );
				return ((double) (((global::alphatab.rendering.ScoreBarRenderer) (this._g[0]) ).getScoreY(((global::alphatab.rendering.ScoreBarRenderer) (this._g[0]) ).getNoteLine(n), new global::haxe.lang.Null<int>(( this.correction[0] - 1 ), true))) );
			}
		}
		
		
		public  global::haxe.root.Array<int> correction;
		
		public  global::haxe.root.Array<object> _g;
		
	}
}


