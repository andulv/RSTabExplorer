using haxe.root;
#pragma warning disable 109, 114, 219, 429, 168, 162
namespace alphatab.rendering.glyphs{
	public  class WhammyBarGlyph : global::alphatab.rendering.Glyph {
		static WhammyBarGlyph() {
			global::alphatab.rendering.glyphs.WhammyBarGlyph.WhammyMaxOffset = 60;
		}
		public    WhammyBarGlyph(global::haxe.lang.EmptyObject empty) : base(global::haxe.lang.EmptyObject.EMPTY){
			unchecked {
			}
		}
		
		
		public    WhammyBarGlyph(global::alphatab.model.Beat beat, global::alphatab.rendering.glyphs.BeatContainerGlyph parent) : base(global::haxe.lang.EmptyObject.EMPTY){
			unchecked {
				global::alphatab.rendering.glyphs.WhammyBarGlyph.__hx_ctor_alphatab_rendering_glyphs_WhammyBarGlyph(this, beat, parent);
			}
		}
		
		
		public static   void __hx_ctor_alphatab_rendering_glyphs_WhammyBarGlyph(global::alphatab.rendering.glyphs.WhammyBarGlyph __temp_me245, global::alphatab.model.Beat beat, global::alphatab.rendering.glyphs.BeatContainerGlyph parent){
			unchecked {
				global::alphatab.rendering.Glyph.__hx_ctor_alphatab_rendering_Glyph(__temp_me245, default(global::haxe.lang.Null<int>), default(global::haxe.lang.Null<int>));
				__temp_me245._beat = beat;
				__temp_me245._parent = parent;
			}
		}
		
		
		public static  int WhammyMaxOffset;
		
		public static  new object __hx_createEmpty(){
			unchecked {
				return new global::alphatab.rendering.glyphs.WhammyBarGlyph(((global::haxe.lang.EmptyObject) (global::haxe.lang.EmptyObject.EMPTY) ));
			}
		}
		
		
		public static  new object __hx_create(global::haxe.root.Array arr){
			unchecked {
				return new global::alphatab.rendering.glyphs.WhammyBarGlyph(((global::alphatab.model.Beat) (arr[0]) ), ((global::alphatab.rendering.glyphs.BeatContainerGlyph) (arr[1]) ));
			}
		}
		
		
		public  global::alphatab.model.Beat _beat;
		
		public  global::alphatab.rendering.glyphs.BeatContainerGlyph _parent;
		
		public override   void doLayout(){
			unchecked {
				base.doLayout();
				int minY = 0;
				int maxY = 0;
				int sizeY = ((int) (( 60 * this.renderer.stave.staveGroup.layout.renderer.settings.scale )) );
				if (( this._beat.whammyBarPoints.length >= 2 )) {
					double dy = ( ((double) (sizeY) ) / 24 );
					{
						int _g1 = 0;
						int _g = this._beat.whammyBarPoints.length;
						while (( _g1 < _g )){
							int i = _g1++;
							global::alphatab.model.BendPoint pt = ((global::alphatab.model.BendPoint) (this._beat.whammyBarPoints[i]) );
							int ptY = ((int) (( 0 - ( dy * pt.@value ) )) );
							if (( ptY > maxY )) {
								maxY = ptY;
							}
							
							if (( ptY < minY )) {
								minY = ptY;
							}
							
						}
						
					}
					
				}
				
				global::alphatab.rendering.TabBarRenderer tabBarRenderer = ((global::alphatab.rendering.TabBarRenderer) (this.renderer) );
				global::alphatab.model.Track track = this.renderer.bar.track;
				int tabTop = tabBarRenderer.getTabY(0, new global::haxe.lang.Null<int>(-2, true));
				int tabBottom = tabBarRenderer.getTabY(track.tuning.length, new global::haxe.lang.Null<int>(-2, true));
				int absMinY = ( ( this.y + minY ) + tabTop );
				int absMaxY = ( ( this.y + maxY ) - tabBottom );
				if (( absMinY < 0 )) {
					int __temp_stmt631 = default(int);
					{
						double x = global::System.Math.Abs(((double) (absMinY) ));
						__temp_stmt631 = ((int) (x) );
					}
					
					tabBarRenderer.registerOverflowTop(__temp_stmt631);
				}
				
				if (( absMaxY > 0 )) {
					int __temp_stmt632 = default(int);
					{
						double x1 = global::System.Math.Abs(((double) (absMaxY) ));
						__temp_stmt632 = ((int) (x1) );
					}
					
					tabBarRenderer.registerOverflowBottom(__temp_stmt632);
				}
				
				int height = tabBarRenderer.height;
			}
		}
		
		
		public override   void paint(int cx, int cy, global::alphatab.platform.ICanvas canvas){
			unchecked {
				global::alphatab.rendering.TabBarRenderer tabBarRenderer = ((global::alphatab.rendering.TabBarRenderer) (this.renderer) );
				global::alphatab.rendering.RenderingResources res = this.renderer.stave.staveGroup.layout.renderer.renderingResources;
				double startX = ( ( cx + this.x ) + ( ((double) (this._parent.onNotes.width) ) / 2 ) );
				double endX = default(double);
				if (( ( this._beat.nextBeat == default(global::alphatab.model.Beat) ) || ( this._beat.voice != this._beat.nextBeat.voice ) )) {
					endX = ( ( ( cx + this.x ) + ( ((double) (this._parent.onNotes.width) ) / 2 ) ) + this._parent.postNotes.width );
				}
				 else {
					endX = ((double) (( cx + tabBarRenderer.getBeatX(this._beat.nextBeat) )) );
				}
				
				int startY = ( cy + this.y );
				int textOffset = ((int) (( 3 * this.renderer.stave.staveGroup.layout.renderer.settings.scale )) );
				int sizeY = ((int) (( 60 * this.renderer.stave.staveGroup.layout.renderer.settings.scale )) );
				canvas.setTextAlign(global::alphatab.platform.model.TextAlign.Center);
				if (( this._beat.whammyBarPoints.length >= 2 )) {
					double dx = ( (( endX - startX )) / 60 );
					double dy = ( ((double) (sizeY) ) / 24 );
					canvas.beginPath();
					{
						int _g1 = 0;
						int _g = ( this._beat.whammyBarPoints.length - 1 );
						while (( _g1 < _g )){
							int i = _g1++;
							global::alphatab.model.BendPoint pt1 = ((global::alphatab.model.BendPoint) (this._beat.whammyBarPoints[i]) );
							global::alphatab.model.BendPoint pt2 = ((global::alphatab.model.BendPoint) (this._beat.whammyBarPoints[( i + 1 )]) );
							if (( ( pt1.@value == pt2.@value ) && ( i == ( this._beat.whammyBarPoints.length - 2 ) ) )) {
								continue;
							}
							
							int pt1X = ((int) (( startX + ( dx * pt1.offset ) )) );
							int pt1Y = ((int) (( startY - ( dy * pt1.@value ) )) );
							int pt2X = ((int) (( startX + ( dx * pt2.offset ) )) );
							int pt2Y = ((int) (( startY - ( dy * pt2.@value ) )) );
							canvas.moveTo(((double) (pt1X) ), ((double) (pt1Y) ));
							canvas.lineTo(((double) (pt2X) ), ((double) (pt2Y) ));
							if (( pt2.@value != 0 )) {
								double dv = ( pt2.@value / 4.0 );
								bool up = ( ( pt2.@value - pt1.@value ) >= 0 );
								string s = "";
								if (( dv < 0 )) {
									s = global::haxe.lang.Runtime.concat(s, "-");
								}
								
								if (( ( dv >= 1 ) || ( dv <= -1 ) )) {
									int __temp_stmt635 = default(int);
									{
										double v = global::System.Math.Abs(((double) (dv) ));
										{
											double x = global::System.Math.Floor(((double) (v) ));
											__temp_stmt635 = ((int) (x) );
										}
										
									}
									
									string __temp_stmt634 = global::haxe.root.Std.@string(__temp_stmt635);
									string __temp_stmt633 = global::haxe.lang.Runtime.concat(__temp_stmt634, " ");
									s = global::haxe.lang.Runtime.concat(s, __temp_stmt633);
								}
								
								{
									double x1 = global::System.Math.Floor(((double) (dv) ));
									dv -= ((double) (((int) (x1) )) );
								}
								
								if (( dv == 0.25 )) {
									s = global::haxe.lang.Runtime.concat(s, "1/4");
								}
								 else {
									if (( dv == 0.5 )) {
										s = global::haxe.lang.Runtime.concat(s, "1/2");
									}
									 else {
										if (( dv == 0.75 )) {
											s = global::haxe.lang.Runtime.concat(s, "3/4");
										}
										
									}
									
								}
								
								canvas.setFont(res.graceFont);
								double size = canvas.measureText(s);
								double sy = default(double);
								if (up) {
									sy = ( ( pt2Y - res.graceFont.getSize() ) - textOffset );
								}
								 else {
									sy = ((double) (( pt2Y + textOffset )) );
								}
								
								int sx = pt2X;
								canvas.fillText(s, ((double) (sx) ), sy);
							}
							
						}
						
					}
					
					canvas.stroke();
				}
				
			}
		}
		
		
		public override   object __hx_setField(string field, int hash, object @value, bool handleProperties){
			unchecked {
				switch (hash){
					case 1542788809:
					{
						this._parent = ((global::alphatab.rendering.glyphs.BeatContainerGlyph) (@value) );
						return @value;
					}
					
					
					case 1948581205:
					{
						this._beat = ((global::alphatab.model.Beat) (@value) );
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
					case 1028568990:
					{
						return ((global::haxe.lang.Function) (new global::haxe.lang.Closure(((object) (this) ), ((string) ("paint") ), ((int) (1028568990) ))) );
					}
					
					
					case 1825584277:
					{
						return ((global::haxe.lang.Function) (new global::haxe.lang.Closure(((object) (this) ), ((string) ("doLayout") ), ((int) (1825584277) ))) );
					}
					
					
					case 1542788809:
					{
						return this._parent;
					}
					
					
					case 1948581205:
					{
						return this._beat;
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
				baseArr.push("_parent");
				baseArr.push("_beat");
				{
					base.__hx_getFields(baseArr);
				}
				
			}
		}
		
		
	}
}


