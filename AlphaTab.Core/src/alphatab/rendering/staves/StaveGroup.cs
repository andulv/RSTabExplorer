using haxe.root;
#pragma warning disable 109, 114, 219, 429, 168, 162
namespace alphatab.rendering.staves{
	public  class StaveTrackGroup : global::haxe.lang.HxObject {
		public    StaveTrackGroup(global::haxe.lang.EmptyObject empty){
			unchecked {
				{
				}
				
			}
		}
		
		
		public    StaveTrackGroup(global::alphatab.rendering.staves.StaveGroup staveGroup, global::alphatab.model.Track track){
			unchecked {
				global::alphatab.rendering.staves.StaveTrackGroup.__hx_ctor_alphatab_rendering_staves_StaveTrackGroup(this, staveGroup, track);
			}
		}
		
		
		public static   void __hx_ctor_alphatab_rendering_staves_StaveTrackGroup(global::alphatab.rendering.staves.StaveTrackGroup __temp_me281, global::alphatab.rendering.staves.StaveGroup staveGroup, global::alphatab.model.Track track){
			unchecked {
				__temp_me281.staveGroup = staveGroup;
				__temp_me281.track = track;
				__temp_me281.staves = new global::haxe.root.Array<object>();
			}
		}
		
		
		public static  new object __hx_createEmpty(){
			unchecked {
				return new global::alphatab.rendering.staves.StaveTrackGroup(((global::haxe.lang.EmptyObject) (global::haxe.lang.EmptyObject.EMPTY) ));
			}
		}
		
		
		public static  new object __hx_create(global::haxe.root.Array arr){
			unchecked {
				return new global::alphatab.rendering.staves.StaveTrackGroup(((global::alphatab.rendering.staves.StaveGroup) (arr[0]) ), ((global::alphatab.model.Track) (arr[1]) ));
			}
		}
		
		
		public  global::alphatab.model.Track track;
		
		public  global::alphatab.rendering.staves.StaveGroup staveGroup;
		
		public  global::haxe.root.Array<object> staves;
		
		public  global::alphatab.rendering.staves.Stave firstStaveInAccolade;
		
		public  global::alphatab.rendering.staves.Stave lastStaveInAccolade;
		
		public override   object __hx_setField(string field, int hash, object @value, bool handleProperties){
			unchecked {
				switch (hash){
					case 550915138:
					{
						this.lastStaveInAccolade = ((global::alphatab.rendering.staves.Stave) (@value) );
						return @value;
					}
					
					
					case 376144808:
					{
						this.firstStaveInAccolade = ((global::alphatab.rendering.staves.Stave) (@value) );
						return @value;
					}
					
					
					case 100490692:
					{
						this.staves = ((global::haxe.root.Array<object>) (global::haxe.root.Array<object>.__hx_cast<object>(((global::haxe.root.Array) (@value) ))) );
						return @value;
					}
					
					
					case 1560739056:
					{
						this.staveGroup = ((global::alphatab.rendering.staves.StaveGroup) (@value) );
						return @value;
					}
					
					
					case 371166859:
					{
						this.track = ((global::alphatab.model.Track) (@value) );
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
					case 550915138:
					{
						return this.lastStaveInAccolade;
					}
					
					
					case 376144808:
					{
						return this.firstStaveInAccolade;
					}
					
					
					case 100490692:
					{
						return this.staves;
					}
					
					
					case 1560739056:
					{
						return this.staveGroup;
					}
					
					
					case 371166859:
					{
						return this.track;
					}
					
					
					default:
					{
						return base.__hx_getField(field, hash, throwErrors, isCheck, handleProperties);
					}
					
				}
				
			}
		}
		
		
		public override   void __hx_getFields(global::haxe.root.Array<object> baseArr){
			unchecked {
				baseArr.push("lastStaveInAccolade");
				baseArr.push("firstStaveInAccolade");
				baseArr.push("staves");
				baseArr.push("staveGroup");
				baseArr.push("track");
				{
					base.__hx_getFields(baseArr);
				}
				
			}
		}
		
		
	}
}



#pragma warning disable 109, 114, 219, 429, 168, 162
namespace alphatab.rendering.staves{
	public  class StaveGroup : global::haxe.lang.HxObject {
		static StaveGroup() {
			global::alphatab.rendering.staves.StaveGroup.AccoladeLabelSpacing = 10;
		}
		public    StaveGroup(global::haxe.lang.EmptyObject empty){
			unchecked {
				{
				}
				
			}
		}
		
		
		public    StaveGroup(){
			unchecked {
				global::alphatab.rendering.staves.StaveGroup.__hx_ctor_alphatab_rendering_staves_StaveGroup(this);
			}
		}
		
		
		public static   void __hx_ctor_alphatab_rendering_staves_StaveGroup(global::alphatab.rendering.staves.StaveGroup __temp_me282){
			unchecked {
				__temp_me282.bars = new global::haxe.root.Array<object>();
				__temp_me282.staves = new global::haxe.root.Array<object>();
				__temp_me282._allStaves = new global::haxe.root.Array<object>();
				__temp_me282.width = 0;
				__temp_me282.index = 0;
				__temp_me282._accoladeSpacingCalculated = false;
				__temp_me282.accoladeSpacing = 0;
				__temp_me282.helpers = new global::alphatab.rendering.utils.BarHelpersGroup();
			}
		}
		
		
		public static  int AccoladeLabelSpacing;
		
		public static  new object __hx_createEmpty(){
			unchecked {
				return new global::alphatab.rendering.staves.StaveGroup(((global::haxe.lang.EmptyObject) (global::haxe.lang.EmptyObject.EMPTY) ));
			}
		}
		
		
		public static  new object __hx_create(global::haxe.root.Array arr){
			unchecked {
				return new global::alphatab.rendering.staves.StaveGroup();
			}
		}
		
		
		public  global::alphatab.rendering.staves.Stave _firstStaveInAccolade;
		
		public  global::alphatab.rendering.staves.Stave _lastStaveInAccolade;
		
		public  int x;
		
		public  int y;
		
		public  int index;
		
		public  bool _accoladeSpacingCalculated;
		
		public  int accoladeSpacing;
		
		public  bool isFull;
		
		public  int width;
		
		public  global::haxe.root.Array<object> bars;
		
		public  global::haxe.root.Array<object> staves;
		
		public  global::haxe.root.Array<object> _allStaves;
		
		public  global::alphatab.rendering.layout.ScoreLayout layout;
		
		public  global::alphatab.rendering.utils.BarHelpersGroup helpers;
		
		public   int getLastBarIndex(){
			unchecked {
				return ((global::alphatab.model.MasterBar) (this.bars[( this.bars.length - 1 )]) ).index;
			}
		}
		
		
		public virtual   void addBars(global::haxe.root.Array<object> tracks, int barIndex){
			unchecked {
				if (( tracks.length == 0 )) {
					return ;
				}
				
				global::alphatab.model.Score score = ((global::alphatab.model.Track) (tracks[0]) ).score;
				global::alphatab.model.MasterBar masterBar = ((global::alphatab.model.MasterBar) (score.masterBars[barIndex]) );
				this.bars.push(masterBar);
				this.helpers.buildHelpers(tracks, barIndex);
				if ((  ! (this._accoladeSpacingCalculated)  && ( this.index == 0 ) )) {
					this._accoladeSpacingCalculated = true;
					global::alphatab.platform.ICanvas canvas = this.layout.renderer.canvas;
					global::alphatab.platform.model.Font res = this.layout.renderer.renderingResources.effectFont;
					canvas.setFont(res);
					{
						int _g = 0;
						while (( _g < tracks.length )){
							global::alphatab.model.Track t = ((global::alphatab.model.Track) (tracks[_g]) );
							 ++ _g;
							{
								double x = default(double);
								{
									double b = canvas.measureText(t.shortName);
									x = global::System.Math.Max(((double) (this.accoladeSpacing) ), ((double) (b) ));
								}
								
								this.accoladeSpacing = ((int) (x) );
							}
							
						}
						
					}
					
					this.accoladeSpacing += 20;
					this.width += this.accoladeSpacing;
				}
				
				global::alphatab.rendering.staves.BarSizeInfo maxSizes = new global::alphatab.rendering.staves.BarSizeInfo();
				{
					int _g1 = 0;
					global::haxe.root.Array<object> _g11 = this.staves;
					while (( _g1 < _g11.length )){
						global::alphatab.rendering.staves.StaveTrackGroup g = ((global::alphatab.rendering.staves.StaveTrackGroup) (_g11[_g1]) );
						 ++ _g1;
						{
							int _g2 = 0;
							global::haxe.root.Array<object> _g3 = g.staves;
							while (( _g2 < _g3.length )){
								global::alphatab.rendering.staves.Stave s = ((global::alphatab.rendering.staves.Stave) (_g3[_g2]) );
								 ++ _g2;
								s.addBar(((global::alphatab.model.Bar) (g.track.bars[barIndex]) ));
								((global::alphatab.rendering.BarRendererBase) (s.barRenderers[( s.barRenderers.length - 1 )]) ).registerMaxSizes(maxSizes);
							}
							
						}
						
					}
					
				}
				
				int realWidth = 0;
				{
					int _g4 = 0;
					global::haxe.root.Array<object> _g12 = this._allStaves;
					while (( _g4 < _g12.length )){
						global::alphatab.rendering.staves.Stave s1 = ((global::alphatab.rendering.staves.Stave) (_g12[_g4]) );
						 ++ _g4;
						((global::alphatab.rendering.BarRendererBase) (s1.barRenderers[( s1.barRenderers.length - 1 )]) ).applySizes(maxSizes);
						if (( ((global::alphatab.rendering.BarRendererBase) (s1.barRenderers[( s1.barRenderers.length - 1 )]) ).width > realWidth )) {
							realWidth = ((global::alphatab.rendering.BarRendererBase) (s1.barRenderers[( s1.barRenderers.length - 1 )]) ).width;
						}
						
					}
					
				}
				
				this.width += realWidth;
			}
		}
		
		
		public virtual   global::alphatab.rendering.staves.StaveTrackGroup getStaveTrackGroup(global::alphatab.model.Track track){
			unchecked {
				{
					int _g = 0;
					global::haxe.root.Array<object> _g1 = this.staves;
					while (( _g < _g1.length )){
						global::alphatab.rendering.staves.StaveTrackGroup g = ((global::alphatab.rendering.staves.StaveTrackGroup) (_g1[_g]) );
						 ++ _g;
						if (( g.track == track )) {
							return g;
						}
						
					}
					
				}
				
				return default(global::alphatab.rendering.staves.StaveTrackGroup);
			}
		}
		
		
		public virtual   void addStave(global::alphatab.model.Track track, global::alphatab.rendering.staves.Stave stave){
			unchecked {
				global::alphatab.rendering.staves.StaveTrackGroup @group = this.getStaveTrackGroup(track);
				if (( @group == default(global::alphatab.rendering.staves.StaveTrackGroup) )) {
					@group = new global::alphatab.rendering.staves.StaveTrackGroup(((global::alphatab.rendering.staves.StaveGroup) (this) ), ((global::alphatab.model.Track) (track) ));
					this.staves.push(@group);
				}
				
				stave.staveTrackGroup = @group;
				stave.staveGroup = this;
				stave.index = this._allStaves.length;
				this._allStaves.push(stave);
				@group.staves.push(stave);
				if (stave._factory.isInAccolade) {
					if (( this._firstStaveInAccolade == default(global::alphatab.rendering.staves.Stave) )) {
						this._firstStaveInAccolade = stave;
						stave.isFirstInAccolade = true;
					}
					
					if (( @group.firstStaveInAccolade == default(global::alphatab.rendering.staves.Stave) )) {
						@group.firstStaveInAccolade = stave;
					}
					
					if (( this._lastStaveInAccolade == default(global::alphatab.rendering.staves.Stave) )) {
						this._lastStaveInAccolade = stave;
						stave.isLastInAccolade = true;
					}
					
					if (( this._lastStaveInAccolade != default(global::alphatab.rendering.staves.Stave) )) {
						this._lastStaveInAccolade.isLastInAccolade = false;
					}
					
					this._lastStaveInAccolade = stave;
					this._lastStaveInAccolade.isLastInAccolade = true;
					@group.lastStaveInAccolade = stave;
				}
				
			}
		}
		
		
		public virtual   int calculateHeight(){
			unchecked {
				return ( ((global::alphatab.rendering.staves.Stave) (this._allStaves[( this._allStaves.length - 1 )]) ).y + ((global::alphatab.rendering.staves.Stave) (this._allStaves[( this._allStaves.length - 1 )]) ).height );
			}
		}
		
		
		public virtual   void revertLastBar(){
			unchecked {
				if (( this.bars.length > 1 )) {
					this.bars.pop();
					int w = 0;
					{
						int _g = 0;
						global::haxe.root.Array<object> _g1 = this._allStaves;
						while (( _g < _g1.length )){
							global::alphatab.rendering.staves.Stave s = ((global::alphatab.rendering.staves.Stave) (_g1[_g]) );
							 ++ _g;
							{
								double x = global::System.Math.Max(((double) (w) ), ((double) (((global::alphatab.rendering.BarRendererBase) (s.barRenderers[( s.barRenderers.length - 1 )]) ).width) ));
								w = ((int) (x) );
							}
							
							s.revertLastBar();
						}
						
					}
					
					this.width -= w;
				}
				
			}
		}
		
		
		public virtual   void applyBarSpacing(int spacing){
			unchecked {
				{
					int _g = 0;
					global::haxe.root.Array<object> _g1 = this._allStaves;
					while (( _g < _g1.length )){
						global::alphatab.rendering.staves.Stave s = ((global::alphatab.rendering.staves.Stave) (_g1[_g]) );
						 ++ _g;
						s.applyBarSpacing(spacing);
					}
					
				}
				
				this.width += ( this.bars.length * spacing );
			}
		}
		
		
		public virtual   void paint(int cx, int cy, global::alphatab.platform.ICanvas canvas){
			unchecked {
				{
					int _g = 0;
					global::haxe.root.Array<object> _g1 = this._allStaves;
					while (( _g < _g1.length )){
						global::alphatab.rendering.staves.Stave s = ((global::alphatab.rendering.staves.Stave) (_g1[_g]) );
						 ++ _g;
						s.paint(( cx + this.x ), ( cy + this.y ), canvas);
					}
					
				}
				
				global::alphatab.rendering.RenderingResources res = this.layout.renderer.renderingResources;
				if (( this.staves.length > 0 )) {
					if (( ( this._firstStaveInAccolade != default(global::alphatab.rendering.staves.Stave) ) && ( this._lastStaveInAccolade != default(global::alphatab.rendering.staves.Stave) ) )) {
						int firstStart = ( ( ( ( ( cy + this.y ) + this._firstStaveInAccolade.y ) + this._firstStaveInAccolade.staveTop ) + this._firstStaveInAccolade.topSpacing ) + this._firstStaveInAccolade.getTopOverflow() );
						int lastEnd = ( ( ( ( ( cy + this.y ) + this._lastStaveInAccolade.y ) + this._lastStaveInAccolade.topSpacing ) + this._lastStaveInAccolade.getTopOverflow() ) + this._lastStaveInAccolade.staveBottom );
						int acooladeX = ( ( cx + this.x ) + this._firstStaveInAccolade.x );
						canvas.setColor(res.barSeperatorColor);
						canvas.beginPath();
						canvas.moveTo(((double) (acooladeX) ), ((double) (firstStart) ));
						canvas.lineTo(((double) (acooladeX) ), ((double) (lastEnd) ));
						canvas.stroke();
					}
					
					canvas.setFont(res.effectFont);
					{
						int _g2 = 0;
						global::haxe.root.Array<object> _g11 = this.staves;
						while (( _g2 < _g11.length )){
							global::alphatab.rendering.staves.StaveTrackGroup g = ((global::alphatab.rendering.staves.StaveTrackGroup) (_g11[_g2]) );
							 ++ _g2;
							int firstStart1 = ( ( ( ( ( cy + this.y ) + g.firstStaveInAccolade.y ) + g.firstStaveInAccolade.staveTop ) + g.firstStaveInAccolade.topSpacing ) + g.firstStaveInAccolade.getTopOverflow() );
							int lastEnd1 = ( ( ( ( ( cy + this.y ) + g.lastStaveInAccolade.y ) + g.lastStaveInAccolade.topSpacing ) + g.lastStaveInAccolade.getTopOverflow() ) + g.lastStaveInAccolade.staveBottom );
							int acooladeX1 = ( ( cx + this.x ) + g.firstStaveInAccolade.x );
							int barSize = ((int) (( 3 * this.layout.renderer.settings.scale )) );
							int barOffset = barSize;
							int accoladeStart = ( firstStart1 - ( barSize * 4 ) );
							int accoladeEnd = ( lastEnd1 + ( barSize * 4 ) );
							if (( this.index == 0 )) {
								canvas.fillText(g.track.shortName, ( ( cx + this.x ) + ( 10 * this.layout.renderer.settings.scale ) ), ((double) (firstStart1) ));
							}
							
							canvas.fillRect(((double) (( ( acooladeX1 - barOffset ) - barSize )) ), ((double) (accoladeStart) ), ((double) (barSize) ), ((double) (( accoladeEnd - accoladeStart )) ));
							int spikeStartX = ( ( acooladeX1 - barOffset ) - barSize );
							int spikeEndX = ( acooladeX1 + ( barSize * 2 ) );
							canvas.beginPath();
							canvas.moveTo(((double) (spikeStartX) ), ((double) (accoladeStart) ));
							canvas.bezierCurveTo(((double) (spikeStartX) ), ((double) (accoladeStart) ), ((double) (spikeStartX) ), ((double) (accoladeStart) ), ((double) (spikeEndX) ), ((double) (( accoladeStart - barSize )) ));
							canvas.bezierCurveTo(((double) (acooladeX1) ), ((double) (( accoladeStart + barSize )) ), ((double) (spikeStartX) ), ((double) (( accoladeStart + barSize )) ), ((double) (spikeStartX) ), ((double) (( accoladeStart + barSize )) ));
							canvas.closePath();
							canvas.fill();
							canvas.beginPath();
							canvas.moveTo(((double) (spikeStartX) ), ((double) (accoladeEnd) ));
							canvas.bezierCurveTo(((double) (spikeStartX) ), ((double) (accoladeEnd) ), ((double) (acooladeX1) ), ((double) (accoladeEnd) ), ((double) (spikeEndX) ), ((double) (( accoladeEnd + barSize )) ));
							canvas.bezierCurveTo(((double) (acooladeX1) ), ((double) (( accoladeEnd - barSize )) ), ((double) (spikeStartX) ), ((double) (( accoladeEnd - barSize )) ), ((double) (spikeStartX) ), ((double) (( accoladeEnd - barSize )) ));
							canvas.closePath();
							canvas.fill();
						}
						
					}
					
				}
				
			}
		}
		
		
		public virtual   void finalizeGroup(global::alphatab.rendering.layout.ScoreLayout scoreLayout){
			unchecked {
				double currentY = ((double) (0) );
				{
					int _g1 = 0;
					int _g = this._allStaves.length;
					while (( _g1 < _g )){
						int i = _g1++;
						((global::alphatab.rendering.staves.Stave) (this._allStaves[i]) ).x = this.accoladeSpacing;
						((global::alphatab.rendering.staves.Stave) (this._allStaves[i]) ).y = ((int) (currentY) );
						((global::alphatab.rendering.staves.Stave) (this._allStaves[i]) ).finalizeStave(scoreLayout);
						currentY += ((double) (((global::alphatab.rendering.staves.Stave) (this._allStaves[i]) ).height) );
					}
					
				}
				
			}
		}
		
		
		public virtual   void buildBoundingsLookup(global::alphatab.rendering.utils.BoundingsLookup lookup){
			unchecked {
				int visualTop = ( this.y + this._firstStaveInAccolade.y );
				int visualBottom = ( ( this.y + this._lastStaveInAccolade.y ) + this._lastStaveInAccolade.height );
				int realTop = ( this.y + ((global::alphatab.rendering.staves.Stave) (this._allStaves[0]) ).y );
				int realBottom = ( ( this.y + ((global::alphatab.rendering.staves.Stave) (this._allStaves[( this._allStaves.length - 1 )]) ).y ) + ((global::alphatab.rendering.staves.Stave) (this._allStaves[( this._allStaves.length - 1 )]) ).height );
				int visualHeight = ( visualBottom - visualTop );
				int realHeight = ( realBottom - realTop );
				{
					int _g = 0;
					global::haxe.root.Array<object> _g1 = this._firstStaveInAccolade.barRenderers;
					while (( _g < _g1.length )){
						global::alphatab.rendering.BarRendererBase b = ((global::alphatab.rendering.BarRendererBase) (_g1[_g]) );
						 ++ _g;
						b.buildBoundingsLookup(lookup, visualTop, visualHeight, realTop, realHeight, this.x);
					}
					
				}
				
			}
		}
		
		
		public override   double __hx_setField_f(string field, int hash, double @value, bool handleProperties){
			unchecked {
				switch (hash){
					case 1247983110:
					{
						this.width = ((int) (@value) );
						return @value;
					}
					
					
					case 1209853855:
					{
						this.accoladeSpacing = ((int) (@value) );
						return @value;
					}
					
					
					case 1041537810:
					{
						this.index = ((int) (@value) );
						return @value;
					}
					
					
					case 121:
					{
						this.y = ((int) (@value) );
						return @value;
					}
					
					
					case 120:
					{
						this.x = ((int) (@value) );
						return @value;
					}
					
					
					default:
					{
						return base.__hx_setField_f(field, hash, @value, handleProperties);
					}
					
				}
				
			}
		}
		
		
		public override   object __hx_setField(string field, int hash, object @value, bool handleProperties){
			unchecked {
				switch (hash){
					case 1079984965:
					{
						this.helpers = ((global::alphatab.rendering.utils.BarHelpersGroup) (@value) );
						return @value;
					}
					
					
					case 1488498346:
					{
						this.layout = ((global::alphatab.rendering.layout.ScoreLayout) (@value) );
						return @value;
					}
					
					
					case 805524870:
					{
						this._allStaves = ((global::haxe.root.Array<object>) (global::haxe.root.Array<object>.__hx_cast<object>(((global::haxe.root.Array) (@value) ))) );
						return @value;
					}
					
					
					case 100490692:
					{
						this.staves = ((global::haxe.root.Array<object>) (global::haxe.root.Array<object>.__hx_cast<object>(((global::haxe.root.Array) (@value) ))) );
						return @value;
					}
					
					
					case 1091626816:
					{
						this.bars = ((global::haxe.root.Array<object>) (global::haxe.root.Array<object>.__hx_cast<object>(((global::haxe.root.Array) (@value) ))) );
						return @value;
					}
					
					
					case 1247983110:
					{
						this.width = ((int) (global::haxe.lang.Runtime.toInt(@value)) );
						return @value;
					}
					
					
					case 1630252697:
					{
						this.isFull = global::haxe.lang.Runtime.toBool(@value);
						return @value;
					}
					
					
					case 1209853855:
					{
						this.accoladeSpacing = ((int) (global::haxe.lang.Runtime.toInt(@value)) );
						return @value;
					}
					
					
					case 233519742:
					{
						this._accoladeSpacingCalculated = global::haxe.lang.Runtime.toBool(@value);
						return @value;
					}
					
					
					case 1041537810:
					{
						this.index = ((int) (global::haxe.lang.Runtime.toInt(@value)) );
						return @value;
					}
					
					
					case 121:
					{
						this.y = ((int) (global::haxe.lang.Runtime.toInt(@value)) );
						return @value;
					}
					
					
					case 120:
					{
						this.x = ((int) (global::haxe.lang.Runtime.toInt(@value)) );
						return @value;
					}
					
					
					case 539976515:
					{
						this._lastStaveInAccolade = ((global::alphatab.rendering.staves.Stave) (@value) );
						return @value;
					}
					
					
					case 84315527:
					{
						this._firstStaveInAccolade = ((global::alphatab.rendering.staves.Stave) (@value) );
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
					case 776879323:
					{
						return ((global::haxe.lang.Function) (new global::haxe.lang.Closure(((object) (this) ), ((string) ("buildBoundingsLookup") ), ((int) (776879323) ))) );
					}
					
					
					case 1374732481:
					{
						return ((global::haxe.lang.Function) (new global::haxe.lang.Closure(((object) (this) ), ((string) ("finalizeGroup") ), ((int) (1374732481) ))) );
					}
					
					
					case 1028568990:
					{
						return ((global::haxe.lang.Function) (new global::haxe.lang.Closure(((object) (this) ), ((string) ("paint") ), ((int) (1028568990) ))) );
					}
					
					
					case 561297662:
					{
						return ((global::haxe.lang.Function) (new global::haxe.lang.Closure(((object) (this) ), ((string) ("applyBarSpacing") ), ((int) (561297662) ))) );
					}
					
					
					case 1131575193:
					{
						return ((global::haxe.lang.Function) (new global::haxe.lang.Closure(((object) (this) ), ((string) ("revertLastBar") ), ((int) (1131575193) ))) );
					}
					
					
					case 930488813:
					{
						return ((global::haxe.lang.Function) (new global::haxe.lang.Closure(((object) (this) ), ((string) ("calculateHeight") ), ((int) (930488813) ))) );
					}
					
					
					case 2104008174:
					{
						return ((global::haxe.lang.Function) (new global::haxe.lang.Closure(((object) (this) ), ((string) ("addStave") ), ((int) (2104008174) ))) );
					}
					
					
					case 678465901:
					{
						return ((global::haxe.lang.Function) (new global::haxe.lang.Closure(((object) (this) ), ((string) ("getStaveTrackGroup") ), ((int) (678465901) ))) );
					}
					
					
					case 2102274561:
					{
						return ((global::haxe.lang.Function) (new global::haxe.lang.Closure(((object) (this) ), ((string) ("addBars") ), ((int) (2102274561) ))) );
					}
					
					
					case 291454571:
					{
						return ((global::haxe.lang.Function) (new global::haxe.lang.Closure(((object) (this) ), ((string) ("getLastBarIndex") ), ((int) (291454571) ))) );
					}
					
					
					case 1079984965:
					{
						return this.helpers;
					}
					
					
					case 1488498346:
					{
						return this.layout;
					}
					
					
					case 805524870:
					{
						return this._allStaves;
					}
					
					
					case 100490692:
					{
						return this.staves;
					}
					
					
					case 1091626816:
					{
						return this.bars;
					}
					
					
					case 1247983110:
					{
						return this.width;
					}
					
					
					case 1630252697:
					{
						return this.isFull;
					}
					
					
					case 1209853855:
					{
						return this.accoladeSpacing;
					}
					
					
					case 233519742:
					{
						return this._accoladeSpacingCalculated;
					}
					
					
					case 1041537810:
					{
						return this.index;
					}
					
					
					case 121:
					{
						return this.y;
					}
					
					
					case 120:
					{
						return this.x;
					}
					
					
					case 539976515:
					{
						return this._lastStaveInAccolade;
					}
					
					
					case 84315527:
					{
						return this._firstStaveInAccolade;
					}
					
					
					default:
					{
						return base.__hx_getField(field, hash, throwErrors, isCheck, handleProperties);
					}
					
				}
				
			}
		}
		
		
		public override   double __hx_getField_f(string field, int hash, bool throwErrors, bool handleProperties){
			unchecked {
				switch (hash){
					case 1247983110:
					{
						return ((double) (this.width) );
					}
					
					
					case 1209853855:
					{
						return ((double) (this.accoladeSpacing) );
					}
					
					
					case 1041537810:
					{
						return ((double) (this.index) );
					}
					
					
					case 121:
					{
						return ((double) (this.y) );
					}
					
					
					case 120:
					{
						return ((double) (this.x) );
					}
					
					
					default:
					{
						return base.__hx_getField_f(field, hash, throwErrors, handleProperties);
					}
					
				}
				
			}
		}
		
		
		public override   object __hx_invokeField(string field, int hash, global::haxe.root.Array dynargs){
			unchecked {
				switch (hash){
					case 776879323:
					{
						this.buildBoundingsLookup(((global::alphatab.rendering.utils.BoundingsLookup) (dynargs[0]) ));
						break;
					}
					
					
					case 1374732481:
					{
						this.finalizeGroup(((global::alphatab.rendering.layout.ScoreLayout) (dynargs[0]) ));
						break;
					}
					
					
					case 1028568990:
					{
						this.paint(((int) (global::haxe.lang.Runtime.toInt(dynargs[0])) ), ((int) (global::haxe.lang.Runtime.toInt(dynargs[1])) ), ((global::alphatab.platform.ICanvas) (dynargs[2]) ));
						break;
					}
					
					
					case 561297662:
					{
						this.applyBarSpacing(((int) (global::haxe.lang.Runtime.toInt(dynargs[0])) ));
						break;
					}
					
					
					case 1131575193:
					{
						this.revertLastBar();
						break;
					}
					
					
					case 930488813:
					{
						return this.calculateHeight();
					}
					
					
					case 2104008174:
					{
						this.addStave(((global::alphatab.model.Track) (dynargs[0]) ), ((global::alphatab.rendering.staves.Stave) (dynargs[1]) ));
						break;
					}
					
					
					case 678465901:
					{
						return this.getStaveTrackGroup(((global::alphatab.model.Track) (dynargs[0]) ));
					}
					
					
					case 2102274561:
					{
						this.addBars(((global::haxe.root.Array<object>) (global::haxe.root.Array<object>.__hx_cast<object>(((global::haxe.root.Array) (dynargs[0]) ))) ), ((int) (global::haxe.lang.Runtime.toInt(dynargs[1])) ));
						break;
					}
					
					
					case 291454571:
					{
						return this.getLastBarIndex();
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
				baseArr.push("helpers");
				baseArr.push("layout");
				baseArr.push("_allStaves");
				baseArr.push("staves");
				baseArr.push("bars");
				baseArr.push("width");
				baseArr.push("isFull");
				baseArr.push("accoladeSpacing");
				baseArr.push("_accoladeSpacingCalculated");
				baseArr.push("index");
				baseArr.push("y");
				baseArr.push("x");
				baseArr.push("_lastStaveInAccolade");
				baseArr.push("_firstStaveInAccolade");
				{
					base.__hx_getFields(baseArr);
				}
				
			}
		}
		
		
	}
}


