using haxe.root;
#pragma warning disable 109, 114, 219, 429, 168, 162
namespace alphatab.rendering{
	public  class RhythmBarRenderer : global::alphatab.rendering.GroupedBarRenderer {
		public    RhythmBarRenderer(global::haxe.lang.EmptyObject empty) : base(global::haxe.lang.EmptyObject.EMPTY){
			unchecked {
			}
		}
		
		
		public    RhythmBarRenderer(global::alphatab.model.Bar bar, global::alphatab.rendering.utils.BeamDirection direction) : base(((global::haxe.lang.EmptyObject) (global::haxe.lang.EmptyObject.EMPTY) )){
			unchecked {
				global::alphatab.rendering.RhythmBarRenderer.__hx_ctor_alphatab_rendering_RhythmBarRenderer(this, bar, direction);
			}
		}
		
		
		public static   void __hx_ctor_alphatab_rendering_RhythmBarRenderer(global::alphatab.rendering.RhythmBarRenderer __temp_me112, global::alphatab.model.Bar bar, global::alphatab.rendering.utils.BeamDirection direction){
			unchecked {
				global::alphatab.rendering.GroupedBarRenderer.__hx_ctor_alphatab_rendering_GroupedBarRenderer(__temp_me112, bar);
				__temp_me112._direction = direction;
			}
		}
		
		
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
		
		
		public static  new object __hx_createEmpty(){
			unchecked {
				return new global::alphatab.rendering.RhythmBarRenderer(((global::haxe.lang.EmptyObject) (global::haxe.lang.EmptyObject.EMPTY) ));
			}
		}
		
		
		public static  new object __hx_create(global::haxe.root.Array arr){
			unchecked {
				return new global::alphatab.rendering.RhythmBarRenderer(((global::alphatab.model.Bar) (arr[0]) ), ((global::alphatab.rendering.utils.BeamDirection) (arr[1]) ));
			}
		}
		
		
		public  global::alphatab.rendering.utils.BeamDirection _direction;
		
		public  global::alphatab.rendering.utils.BarHelpers _helpers;
		
		public override   void doLayout(){
			unchecked {
				this._helpers = ((global::alphatab.rendering.utils.BarHelpers) (((global::haxe.ds.IntMap<object>) (global::haxe.ds.IntMap<object>.__hx_cast<object>(((global::haxe.ds.IntMap) (this.stave.staveGroup.helpers.helpers.@get(this.bar.track.index).@value) ))) ).@get(this.bar.index).@value) );
				base.doLayout();
				this.height = ((int) (( 24 * this.stave.staveGroup.layout.renderer.settings.scale )) );
				this.isEmpty = false;
			}
		}
		
		
		public override   void createBeatGlyphs(){
			unchecked {
				this.createVoiceGlyphs(((global::alphatab.model.Voice) (this.bar.voices[0]) ));
			}
		}
		
		
		public virtual   void createVoiceGlyphs(global::alphatab.model.Voice v){
			unchecked {
				int _g = 0;
				global::haxe.root.Array<object> _g1 = v.beats;
				while (( _g < _g1.length )){
					global::alphatab.model.Beat b = ((global::alphatab.model.Beat) (_g1[_g]) );
					 ++ _g;
					global::alphatab.rendering.glyphs.BeatContainerGlyph container = new global::alphatab.rendering.glyphs.BeatContainerGlyph(((global::alphatab.model.Beat) (b) ));
					container.preNotes = new global::alphatab.rendering.glyphs.BeatGlyphBase();
					container.onNotes = new global::alphatab.rendering.glyphs.BeatGlyphBase();
					container.postNotes = new global::alphatab.rendering.glyphs.BeatGlyphBase();
					this.addBeatGlyph(container);
				}
				
			}
		}
		
		
		public override   void paintBackground(int cx, int cy, global::alphatab.platform.ICanvas canvas){
			unchecked {
				{
				}
				
			}
		}
		
		
		public override   void paint(int cx, int cy, global::alphatab.platform.ICanvas canvas){
			unchecked {
				base.paint(cx, cy, canvas);
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
								this.paintBeamHelper(( cx + this.getBeatGlyphsStart() ), cy, canvas, h);
							}
							
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
		
		
		public virtual   void paintBar(int cx, int cy, global::alphatab.platform.ICanvas canvas, global::alphatab.rendering.utils.BeamingHelper h){
			unchecked {
				int _g1 = 0;
				int _g = h.beats.length;
				while (( _g1 < _g )){
					int i = _g1++;
					global::alphatab.model.Beat beat = ((global::alphatab.model.Beat) (h.beats[i]) );
					if (h._beatLineXPositions.exists(beat.index)) {
						int beatLineX = default(int);
						{
							double x = ( h.getBeatLineX(beat) + this.stave.staveGroup.layout.renderer.settings.scale );
							beatLineX = ((int) (x) );
						}
						
						int y1 = ( cy + this.y );
						int y2 = ( ( cy + this.y ) + this.height );
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
						if (( this._direction == global::alphatab.rendering.utils.BeamDirection.Up )) {
							barSpacing =  - (barSpacing) ;
							barStart += this.height;
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
									
									barStartY = ((int) (barY) );
									barEndY = ((int) (barY) );
									global::alphatab.rendering.RhythmBarRenderer.paintSingleBar(canvas, ( ( cx + this.x ) + barStartX ), barStartY, ( ( cx + this.x ) + barEndX ), barEndY, barSize);
								}
								 else {
									if (( ( i > 0 ) &&  ! (this.isFullBarJoin(beat, ((global::alphatab.model.Beat) (h.beats[( i - 1 )]) ), barIndex))  )) {
										barStartX = ( beatLineX - brokenBarOffset );
										barEndX = beatLineX;
										barStartY = ((int) (barY) );
										barEndY = ((int) (barY) );
										global::alphatab.rendering.RhythmBarRenderer.paintSingleBar(canvas, ( ( cx + this.x ) + barStartX ), barStartY, ( ( cx + this.x ) + barEndX ), barEndY, barSize);
									}
									
								}
								
							}
							
						}
						
					}
					
				}
				
			}
		}
		
		
		public virtual   void paintFooter(int cx, int cy, global::alphatab.platform.ICanvas canvas, global::alphatab.rendering.utils.BeamingHelper h){
			unchecked {
				global::alphatab.model.Beat beat = ((global::alphatab.model.Beat) (h.beats[0]) );
				if (( beat.duration == global::alphatab.model.Duration.Whole )) {
					return ;
				}
				
				int beatLineX = default(int);
				{
					double x = ( h.getBeatLineX(beat) + this.stave.staveGroup.layout.renderer.settings.scale );
					beatLineX = ((int) (x) );
				}
				
				global::alphatab.rendering.utils.BeamDirection direction = h.getDirection();
				int topY = 0;
				int bottomY = this.height;
				int beamY = default(int);
				if (( direction == global::alphatab.rendering.utils.BeamDirection.Down )) {
					beamY = bottomY;
				}
				 else {
					beamY = topY;
				}
				
				canvas.setColor(this.stave.staveGroup.layout.renderer.renderingResources.mainGlyphColor);
				canvas.beginPath();
				canvas.moveTo(((double) (((int) (( ( cx + this.x ) + beatLineX )) )) ), ((double) (( ( cy + this.y ) + topY )) ));
				canvas.lineTo(((double) (((int) (( ( cx + this.x ) + beatLineX )) )) ), ((double) (( ( cy + this.y ) + bottomY )) ));
				canvas.stroke();
				int gx = ((int) (beatLineX) );
				global::alphatab.rendering.glyphs.BeamGlyph glyph = new global::alphatab.rendering.glyphs.BeamGlyph(new global::haxe.lang.Null<int>(gx, true), new global::haxe.lang.Null<int>(beamY, true), ((global::alphatab.model.Duration) (beat.duration) ), ((global::alphatab.rendering.utils.BeamDirection) (direction) ), global::haxe.lang.Runtime.toBool(false));
				glyph.renderer = this;
				glyph.doLayout();
				glyph.paint(( cx + this.x ), ( cy + this.y ), canvas);
			}
		}
		
		
		public virtual   bool isFullBarJoin(global::alphatab.model.Beat a, global::alphatab.model.Beat b, int barIndex){
			unchecked {
				return ( ( ( ( global::alphatab.model.ModelUtils.getDurationIndex(a.duration) - 2 ) - barIndex ) > 0 ) && ( ( ( global::alphatab.model.ModelUtils.getDurationIndex(b.duration) - 2 ) - barIndex ) > 0 ) );
			}
		}
		
		
		public override   object __hx_setField(string field, int hash, object @value, bool handleProperties){
			unchecked {
				switch (hash){
					case 2048367814:
					{
						this._helpers = ((global::alphatab.rendering.utils.BarHelpers) (@value) );
						return @value;
					}
					
					
					case 1810030080:
					{
						this._direction = ((global::alphatab.rendering.utils.BeamDirection) (@value) );
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
					case 956261828:
					{
						return ((global::haxe.lang.Function) (new global::haxe.lang.Closure(((object) (this) ), ((string) ("isFullBarJoin") ), ((int) (956261828) ))) );
					}
					
					
					case 1579021529:
					{
						return ((global::haxe.lang.Function) (new global::haxe.lang.Closure(((object) (this) ), ((string) ("paintFooter") ), ((int) (1579021529) ))) );
					}
					
					
					case 1713359061:
					{
						return ((global::haxe.lang.Function) (new global::haxe.lang.Closure(((object) (this) ), ((string) ("paintBar") ), ((int) (1713359061) ))) );
					}
					
					
					case 416595323:
					{
						return ((global::haxe.lang.Function) (new global::haxe.lang.Closure(((object) (this) ), ((string) ("paintBeamHelper") ), ((int) (416595323) ))) );
					}
					
					
					case 1028568990:
					{
						return ((global::haxe.lang.Function) (new global::haxe.lang.Closure(((object) (this) ), ((string) ("paint") ), ((int) (1028568990) ))) );
					}
					
					
					case 1334722860:
					{
						return ((global::haxe.lang.Function) (new global::haxe.lang.Closure(((object) (this) ), ((string) ("paintBackground") ), ((int) (1334722860) ))) );
					}
					
					
					case 131841789:
					{
						return ((global::haxe.lang.Function) (new global::haxe.lang.Closure(((object) (this) ), ((string) ("createVoiceGlyphs") ), ((int) (131841789) ))) );
					}
					
					
					case 1907509625:
					{
						return ((global::haxe.lang.Function) (new global::haxe.lang.Closure(((object) (this) ), ((string) ("createBeatGlyphs") ), ((int) (1907509625) ))) );
					}
					
					
					case 1825584277:
					{
						return ((global::haxe.lang.Function) (new global::haxe.lang.Closure(((object) (this) ), ((string) ("doLayout") ), ((int) (1825584277) ))) );
					}
					
					
					case 2048367814:
					{
						return this._helpers;
					}
					
					
					case 1810030080:
					{
						return this._direction;
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
					case 1825584277:case 1907509625:case 1334722860:case 1028568990:
					{
						return global::haxe.lang.Runtime.slowCallField(this, field, dynargs);
					}
					
					
					case 956261828:
					{
						return this.isFullBarJoin(((global::alphatab.model.Beat) (dynargs[0]) ), ((global::alphatab.model.Beat) (dynargs[1]) ), ((int) (global::haxe.lang.Runtime.toInt(dynargs[2])) ));
					}
					
					
					case 1579021529:
					{
						this.paintFooter(((int) (global::haxe.lang.Runtime.toInt(dynargs[0])) ), ((int) (global::haxe.lang.Runtime.toInt(dynargs[1])) ), ((global::alphatab.platform.ICanvas) (dynargs[2]) ), ((global::alphatab.rendering.utils.BeamingHelper) (dynargs[3]) ));
						break;
					}
					
					
					case 1713359061:
					{
						this.paintBar(((int) (global::haxe.lang.Runtime.toInt(dynargs[0])) ), ((int) (global::haxe.lang.Runtime.toInt(dynargs[1])) ), ((global::alphatab.platform.ICanvas) (dynargs[2]) ), ((global::alphatab.rendering.utils.BeamingHelper) (dynargs[3]) ));
						break;
					}
					
					
					case 416595323:
					{
						this.paintBeamHelper(((int) (global::haxe.lang.Runtime.toInt(dynargs[0])) ), ((int) (global::haxe.lang.Runtime.toInt(dynargs[1])) ), ((global::alphatab.platform.ICanvas) (dynargs[2]) ), ((global::alphatab.rendering.utils.BeamingHelper) (dynargs[3]) ));
						break;
					}
					
					
					case 131841789:
					{
						this.createVoiceGlyphs(((global::alphatab.model.Voice) (dynargs[0]) ));
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
		
		
		public override   void __hx_getFields(global::haxe.root.Array<object> baseArr){
			unchecked {
				baseArr.push("_helpers");
				baseArr.push("_direction");
				{
					base.__hx_getFields(baseArr);
				}
				
			}
		}
		
		
	}
}


