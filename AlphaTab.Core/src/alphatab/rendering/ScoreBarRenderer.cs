using haxe.root;
#pragma warning disable 109, 114, 219, 429, 168, 162
namespace alphatab.rendering{
	public  class ScoreBarRenderer : global::alphatab.rendering.GroupedBarRenderer {
		static ScoreBarRenderer() {
			global::alphatab.rendering.ScoreBarRenderer.StepsPerOctave = 7;
			global::alphatab.rendering.ScoreBarRenderer.OctaveSteps = new global::haxe.root.Array<int>(new int[]{38, 32, 30, 26, 38});
			global::alphatab.rendering.ScoreBarRenderer.SharpNoteSteps = new global::haxe.root.Array<int>(new int[]{0, 0, 1, 1, 2, 3, 3, 4, 4, 5, 5, 6});
			global::alphatab.rendering.ScoreBarRenderer.FLAT_NOTE_STEPS = new global::haxe.root.Array<int>(new int[]{0, 1, 1, 2, 2, 3, 4, 4, 5, 5, 6, 6});
			global::alphatab.rendering.ScoreBarRenderer.SharpKsSteps = new global::haxe.root.Array<int>(new int[]{1, 4, 0, 3, 6, 2, 5});
			global::alphatab.rendering.ScoreBarRenderer.FlatKsSteps = new global::haxe.root.Array<int>(new int[]{5, 2, 6, 3, 7, 4, 8});
			global::alphatab.rendering.ScoreBarRenderer.LineSpacing = 8;
			global::alphatab.rendering.ScoreBarRenderer.NOTE_STEP_CORRECTION = 1;
		}
		public    ScoreBarRenderer(global::haxe.lang.EmptyObject empty) : base(((global::haxe.lang.EmptyObject) (global::haxe.lang.EmptyObject.EMPTY) )){
			unchecked {
			}
		}
		
		
		public    ScoreBarRenderer(global::alphatab.model.Bar bar) : base(((global::haxe.lang.EmptyObject) (global::haxe.lang.EmptyObject.EMPTY) )){
			unchecked {
				global::alphatab.rendering.ScoreBarRenderer.__hx_ctor_alphatab_rendering_ScoreBarRenderer(this, bar);
			}
		}
		
		
		public static   void __hx_ctor_alphatab_rendering_ScoreBarRenderer(global::alphatab.rendering.ScoreBarRenderer __temp_me115, global::alphatab.model.Bar bar){
			unchecked {
				global::alphatab.rendering.GroupedBarRenderer.__hx_ctor_alphatab_rendering_GroupedBarRenderer(__temp_me115, bar);
				__temp_me115.accidentalHelper = new global::alphatab.rendering.utils.AccidentalHelper();
			}
		}
		
		
		public static  int StepsPerOctave;
		
		public static  global::haxe.root.Array<int> OctaveSteps;
		
		public static  global::haxe.root.Array<int> SharpNoteSteps;
		
		public static  global::haxe.root.Array<int> FLAT_NOTE_STEPS;
		
		public static  global::haxe.root.Array<int> SharpKsSteps;
		
		public static  global::haxe.root.Array<int> FlatKsSteps;
		
		public static  int LineSpacing;
		
		public static   void paintSingleBar(global::alphatab.platform.ICanvas canvas, int x1, int y1, int x2, int y2, int size){
			unchecked {
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
		
		public static  new object __hx_createEmpty(){
			unchecked {
				return new global::alphatab.rendering.ScoreBarRenderer(((global::haxe.lang.EmptyObject) (global::haxe.lang.EmptyObject.EMPTY) ));
			}
		}
		
		
		public static  new object __hx_create(global::haxe.root.Array arr){
			unchecked {
				return new global::alphatab.rendering.ScoreBarRenderer(((global::alphatab.model.Bar) (arr[0]) ));
			}
		}
		
		
		public  global::alphatab.rendering.utils.AccidentalHelper accidentalHelper;
		
		public  global::alphatab.rendering.utils.BarHelpers _helpers;
		
		public virtual   global::alphatab.rendering.utils.BeamDirection getBeatDirection(global::alphatab.model.Beat beat){
			unchecked {
				global::alphatab.rendering.glyphs.ScoreBeatGlyph g = ((global::alphatab.rendering.glyphs.ScoreBeatGlyph) (((global::alphatab.rendering.glyphs.BeatContainerGlyph) (this.getOrCreateVoiceContainer(beat.voice.index).beatGlyphs[beat.index]) ).onNotes) );
				if (( g != default(global::alphatab.rendering.glyphs.ScoreBeatGlyph) )) {
					return g.noteHeads.beamingHelper.getDirection();
				}
				
				return global::alphatab.rendering.utils.BeamDirection.Up;
			}
		}
		
		
		public virtual   int getNoteX(global::alphatab.model.Note note, global::haxe.lang.Null<bool> onEnd){
			unchecked {
				bool __temp_onEnd113 = ( ( ! (onEnd.hasValue) ) ? (global::haxe.lang.Runtime.toBool(true)) : (onEnd.@value) );
				global::alphatab.rendering.glyphs.ScoreBeatGlyph g = ((global::alphatab.rendering.glyphs.ScoreBeatGlyph) (((global::alphatab.rendering.glyphs.BeatContainerGlyph) (this.getOrCreateVoiceContainer(note.beat.voice.index).beatGlyphs[note.beat.index]) ).onNotes) );
				if (( g != default(global::alphatab.rendering.glyphs.ScoreBeatGlyph) )) {
					return ( ( g.container.x + g.x ) + g.noteHeads.getNoteX(note, new global::haxe.lang.Null<bool>(__temp_onEnd113, true)) );
				}
				
				return 0;
			}
		}
		
		
		public virtual   int getNoteY(global::alphatab.model.Note note){
			unchecked {
				global::alphatab.rendering.glyphs.ScoreBeatGlyph beat = ((global::alphatab.rendering.glyphs.ScoreBeatGlyph) (((global::alphatab.rendering.glyphs.BeatContainerGlyph) (this.getOrCreateVoiceContainer(note.beat.voice.index).beatGlyphs[note.beat.index]) ).onNotes) );
				if (( beat != default(global::alphatab.rendering.glyphs.ScoreBeatGlyph) )) {
					return beat.noteHeads.getNoteY(note);
				}
				
				return 0;
			}
		}
		
		
		public override   int getTopPadding(){
			unchecked {
				return this.getGlyphOverflow();
			}
		}
		
		
		public override   int getBottomPadding(){
			unchecked {
				return this.getGlyphOverflow();
			}
		}
		
		
		public   double getLineOffset(){
			unchecked {
				return ( 9 * this.stave.staveGroup.layout.renderer.settings.scale );
			}
		}
		
		
		public override   void doLayout(){
			unchecked {
				this._helpers = ((global::alphatab.rendering.utils.BarHelpers) (((global::haxe.ds.IntMap<object>) (global::haxe.ds.IntMap<object>.__hx_cast<object>(((global::haxe.ds.IntMap) (this.stave.staveGroup.helpers.helpers.@get(this.bar.track.index).@value) ))) ).@get(this.bar.index).@value) );
				base.doLayout();
				this.height = ( ( ((int) (( ( 9 * this.stave.staveGroup.layout.renderer.settings.scale ) * 4 )) ) + this.getTopPadding() ) + this.getBottomPadding() );
				if (( this.index == 0 )) {
					this.stave.registerStaveTop(this.getGlyphOverflow());
					this.stave.registerStaveBottom(( this.height - this.getGlyphOverflow() ));
				}
				
				int top = this.getScoreY(0, default(global::haxe.lang.Null<int>));
				int bottom = this.getScoreY(8, default(global::haxe.lang.Null<int>));
				{
					int _g = 0;
					global::haxe.root.Array<object> _g1 = this._helpers.beamHelpers;
					while (( _g < _g1.length )){
						global::haxe.root.Array<object> v = ((global::haxe.root.Array<object>) (global::haxe.root.Array<object>.__hx_cast<object>(((global::haxe.root.Array) (_g1[_g]) ))) );
						 ++ _g;
						{
							int _g2 = 0;
							while (( _g2 < v.length )){
								global::alphatab.rendering.utils.BeamingHelper h = ((global::alphatab.rendering.utils.BeamingHelper) (v[_g2]) );
								 ++ _g2;
								int maxNoteY = this.getScoreY(this.getNoteLine(h.maxNote), default(global::haxe.lang.Null<int>));
								if (( h.getDirection() == global::alphatab.rendering.utils.BeamDirection.Up )) {
									maxNoteY -= this.getStemSize(h.maxDuration);
								}
								
								if (( maxNoteY < top )) {
									int __temp_stmt553 = default(int);
									{
										double x = global::System.Math.Abs(((double) (maxNoteY) ));
										__temp_stmt553 = ((int) (x) );
									}
									
									this.registerOverflowTop(__temp_stmt553);
								}
								
								int minNoteY = this.getScoreY(this.getNoteLine(h.minNote), default(global::haxe.lang.Null<int>));
								if (( h.getDirection() == global::alphatab.rendering.utils.BeamDirection.Down )) {
									minNoteY += this.getStemSize(h.maxDuration);
								}
								
								if (( minNoteY > bottom )) {
									int __temp_stmt554 = default(int);
									{
										double x1 = global::System.Math.Abs(((double) (minNoteY) ));
										__temp_stmt554 = ((int) (x1) );
									}
									
									this.registerOverflowBottom(( __temp_stmt554 - bottom ));
								}
								
							}
							
						}
						
					}
					
				}
				
			}
		}
		
		
		public override   void paint(int cx, int cy, global::alphatab.platform.ICanvas canvas){
			unchecked {
				base.paint(cx, cy, canvas);
				this.paintBeams(cx, cy, canvas);
				this.paintTuplets(cx, cy, canvas);
			}
		}
		
		
		public virtual   void paintTuplets(int cx, int cy, global::alphatab.platform.ICanvas canvas){
			unchecked {
				int _g = 0;
				global::haxe.root.Array<object> _g1 = this._helpers.tupletHelpers;
				while (( _g < _g1.length )){
					global::haxe.root.Array<object> v = ((global::haxe.root.Array<object>) (global::haxe.root.Array<object>.__hx_cast<object>(((global::haxe.root.Array) (_g1[_g]) ))) );
					 ++ _g;
					{
						int _g2 = 0;
						while (( _g2 < v.length )){
							global::alphatab.rendering.utils.TupletHelper h = ((global::alphatab.rendering.utils.TupletHelper) (v[_g2]) );
							 ++ _g2;
							this.paintTupletHelper(( cx + this.getBeatGlyphsStart() ), cy, canvas, h);
						}
						
					}
					
				}
				
			}
		}
		
		
		public virtual   void paintBeams(int cx, int cy, global::alphatab.platform.ICanvas canvas){
			unchecked {
				int _g = 0;
				global::haxe.root.Array<object> _g1 = this._helpers.beamHelpers;
				while (( _g < _g1.length )){
					global::haxe.root.Array<object> v = ((global::haxe.root.Array<object>) (global::haxe.root.Array<object>.__hx_cast<object>(((global::haxe.root.Array) (_g1[_g]) ))) );
					 ++ _g;
					{
						int _g2 = 0;
						while (( _g2 < v.length )){
							global::alphatab.rendering.utils.BeamingHelper h = ((global::alphatab.rendering.utils.BeamingHelper) (v[_g2]) );
							 ++ _g2;
							this.paintBeamHelper(( cx + this.getBeatGlyphsStart() ), cy, canvas, h);
						}
						
					}
					
				}
				
			}
		}
		
		
		public virtual   void paintBeamHelper(int cx, int cy, global::alphatab.platform.ICanvas canvas, global::alphatab.rendering.utils.BeamingHelper h){
			unchecked {
				if (( h.beats.length == 1 )) {
					this.paintFooter(cx, cy, canvas, h);
				}
				 else {
					this.paintBar(cx, cy, canvas, h);
				}
				
			}
		}
		
		
		public virtual   void paintTupletHelper(int cx, int cy, global::alphatab.platform.ICanvas canvas, global::alphatab.rendering.utils.TupletHelper h){
			unchecked {
				global::alphatab.rendering.RenderingResources res = this.stave.staveGroup.layout.renderer.renderingResources;
				global::alphatab.platform.model.TextAlign oldAlign = canvas.getTextAlign();
				canvas.setTextAlign(global::alphatab.platform.model.TextAlign.Center);
				if (( ( h.beats.length == 1 ) ||  ! ((( h.beats.length == h.tuplet )))  )) {
					int _g1 = 0;
					int _g = h.beats.length;
					while (( _g1 < _g )){
						int i = _g1++;
						global::alphatab.model.Beat beat = ((global::alphatab.model.Beat) (h.beats[i]) );
						global::alphatab.rendering.utils.BeamingHelper beamingHelper = ((global::alphatab.rendering.utils.BeamingHelper) (((global::haxe.ds.IntMap<object>) (global::haxe.ds.IntMap<object>.__hx_cast<object>(((global::haxe.ds.IntMap) (this._helpers.beamHelperLookup[h.voiceIndex]) ))) ).@get(beat.index).@value) );
						if (( beamingHelper == default(global::alphatab.rendering.utils.BeamingHelper) )) {
							continue;
						}
						
						global::alphatab.rendering.utils.BeamDirection direction = beamingHelper.getDirection();
						int tupletX = default(int);
						{
							double x = ( beamingHelper.getBeatLineX(beat) + this.stave.staveGroup.layout.renderer.settings.scale );
							tupletX = ((int) (x) );
						}
						
						int tupletY = ( ( cy + this.y ) + this.calculateBeamY(beamingHelper, tupletX) );
						int offset = default(int);
						if (( direction == global::alphatab.rendering.utils.BeamDirection.Up )) {
							double x1 = ( res.effectFont.getSize() * 1.8 );
							offset = ((int) (x1) );
						}
						 else {
							offset =  - ((((int) (( 3 * this.stave.staveGroup.layout.renderer.settings.scale )) ))) ;
						}
						
						canvas.setFont(res.effectFont);
						canvas.fillText(global::haxe.root.Std.@string(h.tuplet), ((double) (( ( cx + this.x ) + tupletX )) ), ((double) (( tupletY - offset )) ));
					}
					
				}
				 else {
					global::alphatab.model.Beat firstBeat = ((global::alphatab.model.Beat) (h.beats[0]) );
					global::alphatab.model.Beat lastBeat = ((global::alphatab.model.Beat) (h.beats[( h.beats.length - 1 )]) );
					global::alphatab.rendering.utils.BeamingHelper beamingHelper1 = ((global::alphatab.rendering.utils.BeamingHelper) (((global::haxe.ds.IntMap<object>) (global::haxe.ds.IntMap<object>.__hx_cast<object>(((global::haxe.ds.IntMap) (this._helpers.beamHelperLookup[h.voiceIndex]) ))) ).@get(firstBeat.index).@value) );
					if (( beamingHelper1 != default(global::alphatab.rendering.utils.BeamingHelper) )) {
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
						string s = global::haxe.root.Std.@string(h.tuplet);
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
						if (( direction1 == global::alphatab.rendering.utils.BeamDirection.Down )) {
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
					
				}
				
				canvas.setTextAlign(oldAlign);
			}
		}
		
		
		public virtual   int getStemSize(global::alphatab.model.Duration duration){
			unchecked {
				int size = default(int);
				switch (global::haxe.root.Type.enumIndex(duration)){
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
		
		
		public virtual   int calculateBeamY(global::alphatab.rendering.utils.BeamingHelper h, int x){
			unchecked {
				global::haxe.root.Array<object> _g = new global::haxe.root.Array<object>(new object[]{this});
				global::haxe.root.Array<int> correction = new global::haxe.root.Array<int>(new int[]{4});
				int stemSize = this.getStemSize(h.maxDuration);
				return h.calculateBeamY(stemSize, ((int) (this.stave.staveGroup.layout.renderer.settings.scale) ), x, this.stave.staveGroup.layout.renderer.settings.scale, new global::alphatab.rendering.ScoreBarRenderer_calculateBeamY_372__Fun(((global::haxe.root.Array<object>) (_g) ), ((global::haxe.root.Array<int>) (correction) )));
			}
		}
		
		
		public virtual   void paintBar(int cx, int cy, global::alphatab.platform.ICanvas canvas, global::alphatab.rendering.utils.BeamingHelper h){
			unchecked {
				int _g1 = 0;
				int _g = h.beats.length;
				while (( _g1 < _g )){
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
					if (( direction == global::alphatab.rendering.utils.BeamDirection.Down )) {
						barSpacing =  - (barSpacing) ;
					}
					
					{
						int _g2 = 0;
						while (( _g2 < ((int) (barCount) ) )){
							int barIndex = _g2++;
							int barStartX = default(int);
							int barEndX = default(int);
							int barStartY = default(int);
							int barEndY = default(int);
							int barY = ( barStart + ( barIndex * barSpacing ) );
							if (( i < ( h.beats.length - 1 ) )) {
								if (this.isFullBarJoin(beat, ((global::alphatab.model.Beat) (h.beats[( i + 1 )]) ), barIndex)) {
									barStartX = beatLineX;
									{
										double x1 = ( h.getBeatLineX(((global::alphatab.model.Beat) (h.beats[( i + 1 )]) )) + this.stave.staveGroup.layout.renderer.settings.scale );
										barEndX = ((int) (x1) );
									}
									
								}
								 else {
									if (( ( i == 0 ) ||  ! (this.isFullBarJoin(((global::alphatab.model.Beat) (h.beats[( i - 1 )]) ), beat, barIndex))  )) {
										barStartX = beatLineX;
										barEndX = ( barStartX + brokenBarOffset );
									}
									 else {
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
							 else {
								if (( ( i > 0 ) &&  ! (this.isFullBarJoin(beat, ((global::alphatab.model.Beat) (h.beats[( i - 1 )]) ), barIndex))  )) {
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
		
		
		public virtual   bool isFullBarJoin(global::alphatab.model.Beat a, global::alphatab.model.Beat b, int barIndex){
			unchecked {
				return ( ( ( ( global::alphatab.model.ModelUtils.getDurationIndex(a.duration) - 2 ) - barIndex ) > 0 ) && ( ( ( global::alphatab.model.ModelUtils.getDurationIndex(b.duration) - 2 ) - barIndex ) > 0 ) );
			}
		}
		
		
		public virtual   void paintFooter(int cx, int cy, global::alphatab.platform.ICanvas canvas, global::alphatab.rendering.utils.BeamingHelper h){
			unchecked {
				global::alphatab.model.Beat beat = ((global::alphatab.model.Beat) (h.beats[0]) );
				if (( beat.duration == global::alphatab.model.Duration.Whole )) {
					return ;
				}
				
				bool isGrace = ( beat.graceType != global::alphatab.model.GraceType.None );
				double scaleMod = default(double);
				if (isGrace) {
					scaleMod = 0.7;
				}
				 else {
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
				if (( direction == global::alphatab.rendering.utils.BeamDirection.Down )) {
					bottomY += ((int) (( stemSize * scaleMod )) );
					beamY = bottomY;
				}
				 else {
					topY -= ((int) (( stemSize * scaleMod )) );
					beamY = topY;
				}
				
				canvas.setColor(this.stave.staveGroup.layout.renderer.renderingResources.mainGlyphColor);
				canvas.beginPath();
				canvas.moveTo(((double) (((int) (( ( cx + this.x ) + beatLineX )) )) ), ((double) (( ( cy + this.y ) + topY )) ));
				canvas.lineTo(((double) (((int) (( ( cx + this.x ) + beatLineX )) )) ), ((double) (( ( cy + this.y ) + bottomY )) ));
				canvas.stroke();
				if (isGrace) {
					double graceSizeY = ( 15 * this.stave.staveGroup.layout.renderer.settings.scale );
					double graceSizeX = ( 12 * this.stave.staveGroup.layout.renderer.settings.scale );
					canvas.beginPath();
					if (( direction == global::alphatab.rendering.utils.BeamDirection.Down )) {
						canvas.moveTo(((double) (((int) (( ( ( cx + this.x ) + beatLineX ) - ( graceSizeX / 2 ) )) )) ), ( ( ( cy + this.y ) + bottomY ) - graceSizeY ));
						canvas.lineTo(((double) (((int) (( ( ( cx + this.x ) + beatLineX ) + ( graceSizeX / 2 ) )) )) ), ((double) (( ( cy + this.y ) + bottomY )) ));
					}
					 else {
						canvas.moveTo(((double) (((int) (( ( ( cx + this.x ) + beatLineX ) - ( graceSizeX / 2 ) )) )) ), ( ( ( cy + this.y ) + topY ) + graceSizeY ));
						canvas.lineTo(((double) (((int) (( ( ( cx + this.x ) + beatLineX ) + ( graceSizeX / 2 ) )) )) ), ((double) (( ( cy + this.y ) + topY )) ));
					}
					
					canvas.stroke();
				}
				
				int gx = ((int) (beatLineX) );
				global::alphatab.rendering.glyphs.BeamGlyph glyph = new global::alphatab.rendering.glyphs.BeamGlyph(new global::haxe.lang.Null<int>(gx, true), new global::haxe.lang.Null<int>(beamY, true), ((global::alphatab.model.Duration) (beat.duration) ), ((global::alphatab.rendering.utils.BeamDirection) (direction) ), global::haxe.lang.Runtime.toBool(isGrace));
				glyph.renderer = this;
				glyph.doLayout();
				glyph.paint(( cx + this.x ), ( cy + this.y ), canvas);
			}
		}
		
		
		public override   void createPreBeatGlyphs(){
			unchecked {
				global::alphatab.model.MasterBar __temp_stmt555 = default(global::alphatab.model.MasterBar);
				{
					global::alphatab.model.Bar _this = this.bar;
					__temp_stmt555 = ((global::alphatab.model.MasterBar) (_this.track.score.masterBars[_this.index]) );
				}
				
				if (__temp_stmt555.isRepeatStart) {
					this.addPreBeatGlyph(new global::alphatab.rendering.glyphs.RepeatOpenGlyph(new global::haxe.lang.Null<int>(0, true), new global::haxe.lang.Null<int>(0, true), ((double) (1.5) ), ((int) (3) )));
				}
				
				if (( ( this.index == 0 ) || ( this.bar.clef != this.bar.previousBar.clef ) )) {
					int offset = 0;
					{
						global::alphatab.model.Clef _g = this.bar.clef;
						switch (global::haxe.root.Type.enumIndex(_g)){
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
					this.addPreBeatGlyph(new global::alphatab.rendering.glyphs.ClefGlyph(new global::haxe.lang.Null<int>(0, true), new global::haxe.lang.Null<int>(this.getScoreY(offset, default(global::haxe.lang.Null<int>)), true), ((global::alphatab.model.Clef) (this.bar.clef) )));
				}
				
				bool __temp_boolv559 = ( this.bar.previousBar == default(global::alphatab.model.Bar) );
				bool __temp_boolv558 = false;
				if (__temp_boolv559) {
					global::alphatab.model.MasterBar __temp_stmt560 = default(global::alphatab.model.MasterBar);
					{
						global::alphatab.model.Bar _this1 = this.bar;
						__temp_stmt560 = ((global::alphatab.model.MasterBar) (_this1.track.score.masterBars[_this1.index]) );
					}
					
					__temp_boolv558 = ( __temp_stmt560.keySignature != 0 );
				}
				
				bool __temp_stmt557 = ( __temp_boolv559 && __temp_boolv558 );
				bool __temp_boolv561 = false;
				if ( ! (__temp_stmt557) ) {
					bool __temp_boolv563 = ( this.bar.previousBar != default(global::alphatab.model.Bar) );
					bool __temp_boolv562 = false;
					if (__temp_boolv563) {
						global::alphatab.model.MasterBar __temp_stmt564 = default(global::alphatab.model.MasterBar);
						{
							global::alphatab.model.Bar _this2 = this.bar;
							__temp_stmt564 = ((global::alphatab.model.MasterBar) (_this2.track.score.masterBars[_this2.index]) );
						}
						
						global::alphatab.model.MasterBar __temp_stmt565 = default(global::alphatab.model.MasterBar);
						{
							global::alphatab.model.Bar _this3 = this.bar.previousBar;
							__temp_stmt565 = ((global::alphatab.model.MasterBar) (_this3.track.score.masterBars[_this3.index]) );
						}
						
						__temp_boolv562 = ( __temp_stmt564.keySignature != __temp_stmt565.keySignature );
					}
					
					__temp_boolv561 = ( __temp_boolv563 && __temp_boolv562 );
				}
				
				bool __temp_stmt556 = ( __temp_stmt557 || __temp_boolv561 );
				if (__temp_stmt556) {
					this.createStartSpacing();
					this.createKeySignatureGlyphs();
				}
				
				bool __temp_stmt568 = ( this.bar.previousBar == default(global::alphatab.model.Bar) );
				bool __temp_boolv569 = false;
				if ( ! (__temp_stmt568) ) {
					bool __temp_boolv571 = ( this.bar.previousBar != default(global::alphatab.model.Bar) );
					bool __temp_boolv570 = false;
					if (__temp_boolv571) {
						global::alphatab.model.MasterBar __temp_stmt572 = default(global::alphatab.model.MasterBar);
						{
							global::alphatab.model.Bar _this4 = this.bar;
							__temp_stmt572 = ((global::alphatab.model.MasterBar) (_this4.track.score.masterBars[_this4.index]) );
						}
						
						global::alphatab.model.MasterBar __temp_stmt573 = default(global::alphatab.model.MasterBar);
						{
							global::alphatab.model.Bar _this5 = this.bar.previousBar;
							__temp_stmt573 = ((global::alphatab.model.MasterBar) (_this5.track.score.masterBars[_this5.index]) );
						}
						
						__temp_boolv570 = ( __temp_stmt572.timeSignatureNumerator != __temp_stmt573.timeSignatureNumerator );
					}
					
					__temp_boolv569 = ( __temp_boolv571 && __temp_boolv570 );
				}
				
				bool __temp_stmt567 = ( __temp_stmt568 || __temp_boolv569 );
				bool __temp_boolv574 = false;
				if ( ! (__temp_stmt567) ) {
					bool __temp_boolv576 = ( this.bar.previousBar != default(global::alphatab.model.Bar) );
					bool __temp_boolv575 = false;
					if (__temp_boolv576) {
						global::alphatab.model.MasterBar __temp_stmt577 = default(global::alphatab.model.MasterBar);
						{
							global::alphatab.model.Bar _this6 = this.bar;
							__temp_stmt577 = ((global::alphatab.model.MasterBar) (_this6.track.score.masterBars[_this6.index]) );
						}
						
						global::alphatab.model.MasterBar __temp_stmt578 = default(global::alphatab.model.MasterBar);
						{
							global::alphatab.model.Bar _this7 = this.bar.previousBar;
							__temp_stmt578 = ((global::alphatab.model.MasterBar) (_this7.track.score.masterBars[_this7.index]) );
						}
						
						__temp_boolv575 = ( __temp_stmt577.timeSignatureDenominator != __temp_stmt578.timeSignatureDenominator );
					}
					
					__temp_boolv574 = ( __temp_boolv576 && __temp_boolv575 );
				}
				
				bool __temp_stmt566 = ( __temp_stmt567 || __temp_boolv574 );
				if (__temp_stmt566) {
					this.createStartSpacing();
					this.createTimeSignatureGlyphs();
				}
				
				this.addPreBeatGlyph(new global::alphatab.rendering.glyphs.BarNumberGlyph(new global::haxe.lang.Null<int>(0, true), new global::haxe.lang.Null<int>(this.getScoreY(-1, new global::haxe.lang.Null<int>(-3, true)), true), ((int) (( this.bar.index + 1 )) ), new global::haxe.lang.Null<bool>( ! (this.stave.isFirstInAccolade) , true)));
				if (this.bar.isEmpty()) {
					this.addPreBeatGlyph(new global::alphatab.rendering.glyphs.SpacingGlyph(new global::haxe.lang.Null<int>(0, true), new global::haxe.lang.Null<int>(0, true), ((int) (( 30 * this.stave.staveGroup.layout.renderer.settings.scale )) ), new global::haxe.lang.Null<bool>(false, true)));
				}
				
			}
		}
		
		
		public override   void createBeatGlyphs(){
			unchecked {
				this.createVoiceGlyphs(((global::alphatab.model.Voice) (this.bar.voices[0]) ));
			}
		}
		
		
		public override   void createPostBeatGlyphs(){
			unchecked {
				global::alphatab.model.MasterBar __temp_stmt579 = default(global::alphatab.model.MasterBar);
				{
					global::alphatab.model.Bar _this = this.bar;
					__temp_stmt579 = ((global::alphatab.model.MasterBar) (_this.track.score.masterBars[_this.index]) );
				}
				
				if (( __temp_stmt579.repeatCount > 0 )) {
					this.addPostBeatGlyph(new global::alphatab.rendering.glyphs.RepeatCloseGlyph(new global::haxe.lang.Null<int>(this.x, true), new global::haxe.lang.Null<int>(0, true)));
					global::alphatab.model.MasterBar __temp_stmt585 = default(global::alphatab.model.MasterBar);
					{
						global::alphatab.model.Bar _this1 = this.bar;
						__temp_stmt585 = ((global::alphatab.model.MasterBar) (_this1.track.score.masterBars[_this1.index]) );
					}
					
					if (( __temp_stmt585.repeatCount > 2 )) {
						int line = default(int);
						if (( ( this.bar.index == ( this.bar.track.bars.length - 1 ) ) || ( this.index == ( this.stave.barRenderers.length - 1 ) ) )) {
							line = -1;
						}
						 else {
							line = -4;
						}
						
						global::haxe.lang.Null<int> __temp_stmt586 = new global::haxe.lang.Null<int>(this.getScoreY(line, new global::haxe.lang.Null<int>(-3, true)), true);
						global::alphatab.model.MasterBar __temp_stmt587 = default(global::alphatab.model.MasterBar);
						{
							global::alphatab.model.Bar _this2 = this.bar;
							__temp_stmt587 = ((global::alphatab.model.MasterBar) (_this2.track.score.masterBars[_this2.index]) );
						}
						
						this.addPostBeatGlyph(new global::alphatab.rendering.glyphs.RepeatCountGlyph(new global::haxe.lang.Null<int>(0, true), __temp_stmt586, ((int) (__temp_stmt587.repeatCount) )));
					}
					
				}
				 else {
					global::alphatab.model.MasterBar __temp_stmt580 = default(global::alphatab.model.MasterBar);
					{
						global::alphatab.model.Bar _this3 = this.bar;
						__temp_stmt580 = ((global::alphatab.model.MasterBar) (_this3.track.score.masterBars[_this3.index]) );
					}
					
					if (__temp_stmt580.isDoubleBar) {
						this.addPostBeatGlyph(new global::alphatab.rendering.glyphs.BarSeperatorGlyph(((global::haxe.lang.Null<int>) (default(global::haxe.lang.Null<int>)) ), ((global::haxe.lang.Null<int>) (default(global::haxe.lang.Null<int>)) ), ((global::haxe.lang.Null<bool>) (default(global::haxe.lang.Null<bool>)) )));
						this.addPostBeatGlyph(new global::alphatab.rendering.glyphs.SpacingGlyph(new global::haxe.lang.Null<int>(0, true), new global::haxe.lang.Null<int>(0, true), ((int) (( 3 * this.stave.staveGroup.layout.renderer.settings.scale )) ), new global::haxe.lang.Null<bool>(false, true)));
						this.addPostBeatGlyph(new global::alphatab.rendering.glyphs.BarSeperatorGlyph(((global::haxe.lang.Null<int>) (default(global::haxe.lang.Null<int>)) ), ((global::haxe.lang.Null<int>) (default(global::haxe.lang.Null<int>)) ), ((global::haxe.lang.Null<bool>) (default(global::haxe.lang.Null<bool>)) )));
					}
					 else {
						bool __temp_stmt582 = ( this.bar.nextBar == default(global::alphatab.model.Bar) );
						bool __temp_boolv583 = false;
						if ( ! (__temp_stmt582) ) {
							global::alphatab.model.MasterBar __temp_stmt584 = default(global::alphatab.model.MasterBar);
							{
								global::alphatab.model.Bar _this4 = this.bar.nextBar;
								__temp_stmt584 = ((global::alphatab.model.MasterBar) (_this4.track.score.masterBars[_this4.index]) );
							}
							
							__temp_boolv583 =  ! (__temp_stmt584.isRepeatStart) ;
						}
						
						bool __temp_stmt581 = ( __temp_stmt582 || __temp_boolv583 );
						if (__temp_stmt581) {
							this.addPostBeatGlyph(new global::alphatab.rendering.glyphs.BarSeperatorGlyph(new global::haxe.lang.Null<int>(0, true), new global::haxe.lang.Null<int>(0, true), new global::haxe.lang.Null<bool>(( this.bar.index == ( this.bar.track.bars.length - 1 ) ), true)));
						}
						
					}
					
				}
				
			}
		}
		
		
		public  bool _startSpacing;
		
		public virtual   void createStartSpacing(){
			unchecked {
				if (this._startSpacing) {
					return ;
				}
				
				this.addPreBeatGlyph(new global::alphatab.rendering.glyphs.SpacingGlyph(new global::haxe.lang.Null<int>(0, true), new global::haxe.lang.Null<int>(0, true), ((int) (( 2 * this.stave.staveGroup.layout.renderer.settings.scale )) ), ((global::haxe.lang.Null<bool>) (default(global::haxe.lang.Null<bool>)) )));
				this._startSpacing = true;
			}
		}
		
		
		public virtual   void createKeySignatureGlyphs(){
			unchecked {
				int offsetClef = 0;
				global::alphatab.model.MasterBar __temp_stmt588 = default(global::alphatab.model.MasterBar);
				{
					global::alphatab.model.Bar _this = this.bar;
					__temp_stmt588 = ((global::alphatab.model.MasterBar) (_this.track.score.masterBars[_this.index]) );
				}
				
				int currentKey = __temp_stmt588.keySignature;
				int previousKey = default(int);
				if (( this.bar.previousBar == default(global::alphatab.model.Bar) )) {
					previousKey = 0;
				}
				 else {
					global::alphatab.model.MasterBar __temp_stmt589 = default(global::alphatab.model.MasterBar);
					{
						global::alphatab.model.Bar _this1 = this.bar.previousBar;
						__temp_stmt589 = ((global::alphatab.model.MasterBar) (_this1.track.score.masterBars[_this1.index]) );
					}
					
					previousKey = __temp_stmt589.keySignature;
				}
				
				{
					global::alphatab.model.Clef _g = this.bar.clef;
					switch (global::haxe.root.Type.enumIndex(_g)){
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
				if (( previousKey > 0 )) {
					previousKeyPositions = global::alphatab.rendering.ScoreBarRenderer.SharpKsSteps;
				}
				 else {
					previousKeyPositions = global::alphatab.rendering.ScoreBarRenderer.FlatKsSteps;
				}
				
				{
					int _g1 = 0;
					while (( _g1 < naturalizeSymbols )){
						int i = _g1++;
						int __temp_stmt590 = default(int);
						{
							double x1 = ((double) (this.getScoreY(( previousKeyPositions[i] + offsetClef ), default(global::haxe.lang.Null<int>))) );
							__temp_stmt590 = ((int) (x1) );
						}
						
						this.addPreBeatGlyph(new global::alphatab.rendering.glyphs.NaturalizeGlyph(new global::haxe.lang.Null<int>(0, true), new global::haxe.lang.Null<int>(__temp_stmt590, true), ((global::haxe.lang.Null<bool>) (default(global::haxe.lang.Null<bool>)) )));
					}
					
				}
				
				int offsetSymbols = default(int);
				if (( currentKey <= 7 )) {
					offsetSymbols = currentKey;
				}
				 else {
					offsetSymbols = ( currentKey - 7 );
				}
				
				if (( currentKey > 0 )) {
					int _g11 = 0;
					int _g2 = default(int);
					{
						double x2 = global::System.Math.Abs(((double) (currentKey) ));
						_g2 = ((int) (x2) );
					}
					
					while (( _g11 < _g2 )){
						int i1 = _g11++;
						int __temp_stmt592 = default(int);
						{
							double x3 = ((double) (this.getScoreY(( global::alphatab.rendering.ScoreBarRenderer.SharpKsSteps[i1] + offsetClef ), default(global::haxe.lang.Null<int>))) );
							__temp_stmt592 = ((int) (x3) );
						}
						
						this.addPreBeatGlyph(new global::alphatab.rendering.glyphs.SharpGlyph(new global::haxe.lang.Null<int>(0, true), new global::haxe.lang.Null<int>(__temp_stmt592, true), ((global::haxe.lang.Null<bool>) (default(global::haxe.lang.Null<bool>)) )));
					}
					
				}
				 else {
					int _g12 = 0;
					int _g3 = default(int);
					{
						double x4 = global::System.Math.Abs(((double) (currentKey) ));
						_g3 = ((int) (x4) );
					}
					
					while (( _g12 < _g3 )){
						int i2 = _g12++;
						int __temp_stmt591 = default(int);
						{
							double x5 = ((double) (this.getScoreY(( global::alphatab.rendering.ScoreBarRenderer.FlatKsSteps[i2] + offsetClef ), default(global::haxe.lang.Null<int>))) );
							__temp_stmt591 = ((int) (x5) );
						}
						
						this.addPreBeatGlyph(new global::alphatab.rendering.glyphs.FlatGlyph(new global::haxe.lang.Null<int>(0, true), new global::haxe.lang.Null<int>(__temp_stmt591, true), ((global::haxe.lang.Null<bool>) (default(global::haxe.lang.Null<bool>)) )));
					}
					
				}
				
			}
		}
		
		
		public virtual   void createTimeSignatureGlyphs(){
			unchecked {
				this.addPreBeatGlyph(new global::alphatab.rendering.glyphs.SpacingGlyph(new global::haxe.lang.Null<int>(0, true), new global::haxe.lang.Null<int>(0, true), ((int) (( 5 * this.stave.staveGroup.layout.renderer.settings.scale )) ), ((global::haxe.lang.Null<bool>) (default(global::haxe.lang.Null<bool>)) )));
				global::alphatab.model.MasterBar __temp_stmt593 = default(global::alphatab.model.MasterBar);
				{
					global::alphatab.model.Bar _this = this.bar;
					__temp_stmt593 = ((global::alphatab.model.MasterBar) (_this.track.score.masterBars[_this.index]) );
				}
				
				global::alphatab.model.MasterBar __temp_stmt594 = default(global::alphatab.model.MasterBar);
				{
					global::alphatab.model.Bar _this1 = this.bar;
					__temp_stmt594 = ((global::alphatab.model.MasterBar) (_this1.track.score.masterBars[_this1.index]) );
				}
				
				this.addPreBeatGlyph(new global::alphatab.rendering.glyphs.TimeSignatureGlyph(((int) (0) ), ((int) (0) ), ((int) (__temp_stmt593.timeSignatureNumerator) ), ((int) (__temp_stmt594.timeSignatureDenominator) )));
			}
		}
		
		
		public virtual   void createVoiceGlyphs(global::alphatab.model.Voice v){
			unchecked {
				int _g = 0;
				global::haxe.root.Array<object> _g1 = v.beats;
				while (( _g < _g1.length )){
					global::alphatab.model.Beat b = ((global::alphatab.model.Beat) (_g1[_g]) );
					 ++ _g;
					global::alphatab.rendering.glyphs.ScoreBeatContainerGlyph container = new global::alphatab.rendering.glyphs.ScoreBeatContainerGlyph(((global::alphatab.model.Beat) (b) ));
					container.preNotes = new global::alphatab.rendering.glyphs.ScoreBeatPreNotesGlyph();
					container.onNotes = new global::alphatab.rendering.glyphs.ScoreBeatGlyph();
					(((global::alphatab.rendering.glyphs.ScoreBeatGlyph) (container.onNotes) )).beamingHelper = ((global::alphatab.rendering.utils.BeamingHelper) (((global::haxe.ds.IntMap<object>) (global::haxe.ds.IntMap<object>.__hx_cast<object>(((global::haxe.ds.IntMap) (this._helpers.beamHelperLookup[v.index]) ))) ).@get(b.index).@value) );
					container.postNotes = new global::alphatab.rendering.glyphs.ScoreBeatPostNotesGlyph();
					this.addBeatGlyph(container);
				}
				
			}
		}
		
		
		public virtual   int getNoteLine(global::alphatab.model.Note n){
			unchecked {
				int @value = default(int);
				if (n.beat.voice.bar.track.isPercussion) {
					@value = global::alphatab.rendering.utils.PercussionMapper.mapValue(n);
				}
				 else {
					@value = ( n.fret + n.beat.voice.bar.track.tuning[( ( n.beat.voice.bar.track.tuning.length - (( n.@string - 1 )) ) - 1 )] );
				}
				
				global::alphatab.model.MasterBar __temp_stmt595 = default(global::alphatab.model.MasterBar);
				{
					global::alphatab.model.Bar _this = n.beat.voice.bar;
					__temp_stmt595 = ((global::alphatab.model.MasterBar) (_this.track.score.masterBars[_this.index]) );
				}
				
				int ks = __temp_stmt595.keySignature;
				global::alphatab.model.Clef clef = n.beat.voice.bar.clef;
				int index = ( @value % 12 );
				int octave = ( @value / 12 );
				int steps = global::alphatab.rendering.ScoreBarRenderer.OctaveSteps[global::alphatab.model.ModelUtils.getClefIndex(clef)];
				steps -= ( octave * 7 );
				if (( ( ks > 0 ) || ( ks == 0 ) )) {
					steps -= global::alphatab.rendering.ScoreBarRenderer.SharpNoteSteps[index];
				}
				 else {
					steps -= global::alphatab.rendering.ScoreBarRenderer.FLAT_NOTE_STEPS[index];
				}
				
				return ( steps + 1 );
			}
		}
		
		
		public virtual   int getScoreY(int steps, global::haxe.lang.Null<int> correction){
			unchecked {
				int __temp_correction114 = ( ( ! (correction.hasValue) ) ? (((int) (0) )) : (correction.@value) );
				return ((int) (( ( ( ( 9 * this.stave.staveGroup.layout.renderer.settings.scale ) / 2 ) * steps ) + ( __temp_correction114 * this.stave.staveGroup.layout.renderer.settings.scale ) )) );
			}
		}
		
		
		public virtual   int getGlyphOverflow(){
			unchecked {
				global::alphatab.rendering.RenderingResources res = this.stave.staveGroup.layout.renderer.renderingResources;
				{
					double x = ( ( res.tablatureFont.getSize() / 2 ) + ( res.tablatureFont.getSize() * 0.2 ) );
					return ((int) (x) );
				}
				
			}
		}
		
		
		public override   void paintBackground(int cx, int cy, global::alphatab.platform.ICanvas canvas){
			unchecked {
				global::alphatab.rendering.RenderingResources res = this.stave.staveGroup.layout.renderer.renderingResources;
				canvas.setColor(res.staveLineColor);
				int lineY = ( ( cy + this.y ) + this.getGlyphOverflow() );
				int startY = lineY;
				{
					int _g = 0;
					while (( _g < 5 )){
						int i = _g++;
						if (( i > 0 )) {
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
		
		
		public override   object __hx_setField(string field, int hash, object @value, bool handleProperties){
			unchecked {
				switch (hash){
					case 1708501536:
					{
						this._startSpacing = global::haxe.lang.Runtime.toBool(@value);
						return @value;
					}
					
					
					case 2048367814:
					{
						this._helpers = ((global::alphatab.rendering.utils.BarHelpers) (@value) );
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
		
		
		public override   object __hx_getField(string field, int hash, bool throwErrors, bool isCheck, bool handleProperties){
			unchecked {
				switch (hash){
					case 1334722860:
					{
						return ((global::haxe.lang.Function) (new global::haxe.lang.Closure(((object) (this) ), ((string) ("paintBackground") ), ((int) (1334722860) ))) );
					}
					
					
					case 235590296:
					{
						return ((global::haxe.lang.Function) (new global::haxe.lang.Closure(((object) (this) ), ((string) ("getGlyphOverflow") ), ((int) (235590296) ))) );
					}
					
					
					case 1103232509:
					{
						return ((global::haxe.lang.Function) (new global::haxe.lang.Closure(((object) (this) ), ((string) ("getScoreY") ), ((int) (1103232509) ))) );
					}
					
					
					case 2094661564:
					{
						return ((global::haxe.lang.Function) (new global::haxe.lang.Closure(((object) (this) ), ((string) ("getNoteLine") ), ((int) (2094661564) ))) );
					}
					
					
					case 131841789:
					{
						return ((global::haxe.lang.Function) (new global::haxe.lang.Closure(((object) (this) ), ((string) ("createVoiceGlyphs") ), ((int) (131841789) ))) );
					}
					
					
					case 841501494:
					{
						return ((global::haxe.lang.Function) (new global::haxe.lang.Closure(((object) (this) ), ((string) ("createTimeSignatureGlyphs") ), ((int) (841501494) ))) );
					}
					
					
					case 655539612:
					{
						return ((global::haxe.lang.Function) (new global::haxe.lang.Closure(((object) (this) ), ((string) ("createKeySignatureGlyphs") ), ((int) (655539612) ))) );
					}
					
					
					case 2105889885:
					{
						return ((global::haxe.lang.Function) (new global::haxe.lang.Closure(((object) (this) ), ((string) ("createStartSpacing") ), ((int) (2105889885) ))) );
					}
					
					
					case 1708501536:
					{
						return this._startSpacing;
					}
					
					
					case 2000963577:
					{
						return ((global::haxe.lang.Function) (new global::haxe.lang.Closure(((object) (this) ), ((string) ("createPostBeatGlyphs") ), ((int) (2000963577) ))) );
					}
					
					
					case 1907509625:
					{
						return ((global::haxe.lang.Function) (new global::haxe.lang.Closure(((object) (this) ), ((string) ("createBeatGlyphs") ), ((int) (1907509625) ))) );
					}
					
					
					case 918754500:
					{
						return ((global::haxe.lang.Function) (new global::haxe.lang.Closure(((object) (this) ), ((string) ("createPreBeatGlyphs") ), ((int) (918754500) ))) );
					}
					
					
					case 1579021529:
					{
						return ((global::haxe.lang.Function) (new global::haxe.lang.Closure(((object) (this) ), ((string) ("paintFooter") ), ((int) (1579021529) ))) );
					}
					
					
					case 956261828:
					{
						return ((global::haxe.lang.Function) (new global::haxe.lang.Closure(((object) (this) ), ((string) ("isFullBarJoin") ), ((int) (956261828) ))) );
					}
					
					
					case 1713359061:
					{
						return ((global::haxe.lang.Function) (new global::haxe.lang.Closure(((object) (this) ), ((string) ("paintBar") ), ((int) (1713359061) ))) );
					}
					
					
					case 1392437444:
					{
						return ((global::haxe.lang.Function) (new global::haxe.lang.Closure(((object) (this) ), ((string) ("calculateBeamY") ), ((int) (1392437444) ))) );
					}
					
					
					case 188501856:
					{
						return ((global::haxe.lang.Function) (new global::haxe.lang.Closure(((object) (this) ), ((string) ("getStemSize") ), ((int) (188501856) ))) );
					}
					
					
					case 1496985272:
					{
						return ((global::haxe.lang.Function) (new global::haxe.lang.Closure(((object) (this) ), ((string) ("paintTupletHelper") ), ((int) (1496985272) ))) );
					}
					
					
					case 416595323:
					{
						return ((global::haxe.lang.Function) (new global::haxe.lang.Closure(((object) (this) ), ((string) ("paintBeamHelper") ), ((int) (416595323) ))) );
					}
					
					
					case 115063718:
					{
						return ((global::haxe.lang.Function) (new global::haxe.lang.Closure(((object) (this) ), ((string) ("paintBeams") ), ((int) (115063718) ))) );
					}
					
					
					case 914740105:
					{
						return ((global::haxe.lang.Function) (new global::haxe.lang.Closure(((object) (this) ), ((string) ("paintTuplets") ), ((int) (914740105) ))) );
					}
					
					
					case 1028568990:
					{
						return ((global::haxe.lang.Function) (new global::haxe.lang.Closure(((object) (this) ), ((string) ("paint") ), ((int) (1028568990) ))) );
					}
					
					
					case 1825584277:
					{
						return ((global::haxe.lang.Function) (new global::haxe.lang.Closure(((object) (this) ), ((string) ("doLayout") ), ((int) (1825584277) ))) );
					}
					
					
					case 291106525:
					{
						return ((global::haxe.lang.Function) (new global::haxe.lang.Closure(((object) (this) ), ((string) ("getLineOffset") ), ((int) (291106525) ))) );
					}
					
					
					case 357418928:
					{
						return ((global::haxe.lang.Function) (new global::haxe.lang.Closure(((object) (this) ), ((string) ("getBottomPadding") ), ((int) (357418928) ))) );
					}
					
					
					case 415081458:
					{
						return ((global::haxe.lang.Function) (new global::haxe.lang.Closure(((object) (this) ), ((string) ("getTopPadding") ), ((int) (415081458) ))) );
					}
					
					
					case 2141318065:
					{
						return ((global::haxe.lang.Function) (new global::haxe.lang.Closure(((object) (this) ), ((string) ("getNoteY") ), ((int) (2141318065) ))) );
					}
					
					
					case 2141318064:
					{
						return ((global::haxe.lang.Function) (new global::haxe.lang.Closure(((object) (this) ), ((string) ("getNoteX") ), ((int) (2141318064) ))) );
					}
					
					
					case 913255283:
					{
						return ((global::haxe.lang.Function) (new global::haxe.lang.Closure(((object) (this) ), ((string) ("getBeatDirection") ), ((int) (913255283) ))) );
					}
					
					
					case 2048367814:
					{
						return this._helpers;
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
		
		
		public override   object __hx_invokeField(string field, int hash, global::haxe.root.Array dynargs){
			unchecked {
				switch (hash){
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
		
		
		public override   void __hx_getFields(global::haxe.root.Array<object> baseArr){
			unchecked {
				baseArr.push("_startSpacing");
				baseArr.push("_helpers");
				baseArr.push("accidentalHelper");
				{
					base.__hx_getFields(baseArr);
				}
				
			}
		}
		
		
	}
}



#pragma warning disable 109, 114, 219, 429, 168, 162
namespace alphatab.rendering{
	public  class ScoreBarRenderer_calculateBeamY_372__Fun : global::haxe.lang.Function {
		public    ScoreBarRenderer_calculateBeamY_372__Fun(global::haxe.root.Array<object> _g, global::haxe.root.Array<int> correction) : base(1, 1){
			unchecked {
				this._g = _g;
				this.correction = correction;
			}
		}
		
		
		public override   double __hx_invoke1_f(double __fn_float1, object __fn_dyn1){
			unchecked {
				global::alphatab.model.Note n = ( (global::haxe.lang.Runtime.eq(__fn_dyn1, global::haxe.lang.Runtime.undefined)) ? (((global::alphatab.model.Note) (((object) (__fn_float1) )) )) : (((global::alphatab.model.Note) (__fn_dyn1) )) );
				return ((double) (((global::alphatab.rendering.ScoreBarRenderer) (this._g[0]) ).getScoreY(((global::alphatab.rendering.ScoreBarRenderer) (this._g[0]) ).getNoteLine(n), new global::haxe.lang.Null<int>(( this.correction[0] - 1 ), true))) );
			}
		}
		
		
		public  global::haxe.root.Array<object> _g;
		
		public  global::haxe.root.Array<int> correction;
		
	}
}


