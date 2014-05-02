using haxe.root;
#pragma warning disable 109, 114, 219, 429, 168, 162
namespace alphatab.rendering.glyphs{
	public  class BendGlyph : global::alphatab.rendering.Glyph {
		public    BendGlyph(global::haxe.lang.EmptyObject empty) : base(global::haxe.lang.EmptyObject.EMPTY){
			unchecked {
			}
		}
		
		
		public    BendGlyph(global::alphatab.model.Note n, int width, int height) : base(global::haxe.lang.EmptyObject.EMPTY){
			unchecked {
				global::alphatab.rendering.glyphs.BendGlyph.__hx_ctor_alphatab_rendering_glyphs_BendGlyph(this, n, width, height);
			}
		}
		
		
		public static   void __hx_ctor_alphatab_rendering_glyphs_BendGlyph(global::alphatab.rendering.glyphs.BendGlyph __temp_me147, global::alphatab.model.Note n, int width, int height){
			unchecked {
				global::alphatab.rendering.Glyph.__hx_ctor_alphatab_rendering_Glyph(__temp_me147, new global::haxe.lang.Null<int>(0, true), new global::haxe.lang.Null<int>(0, true));
				__temp_me147._note = n;
				__temp_me147.width = width;
				__temp_me147._height = height;
			}
		}
		
		
		public static  new object __hx_createEmpty(){
			unchecked {
				return new global::alphatab.rendering.glyphs.BendGlyph(((global::haxe.lang.EmptyObject) (global::haxe.lang.EmptyObject.EMPTY) ));
			}
		}
		
		
		public static  new object __hx_create(global::haxe.root.Array arr){
			unchecked {
				return new global::alphatab.rendering.glyphs.BendGlyph(((global::alphatab.model.Note) (arr[0]) ), ((int) (global::haxe.lang.Runtime.toInt(arr[1])) ), ((int) (global::haxe.lang.Runtime.toInt(arr[2])) ));
			}
		}
		
		
		public  global::alphatab.model.Note _note;
		
		public  int _height;
		
		public override   void paint(int cx, int cy, global::alphatab.platform.ICanvas canvas){
			unchecked {
				global::alphatab.rendering.TabBarRenderer r = ((global::alphatab.rendering.TabBarRenderer) (this.renderer) );
				global::alphatab.rendering.RenderingResources res = this.renderer.stave.staveGroup.layout.renderer.renderingResources;
				double dX = ( ((double) (this.width) ) / 60 );
				int maxValue = 0;
				{
					int _g1 = 0;
					int _g = this._note.bendPoints.length;
					while (( _g1 < _g )){
						int i = _g1++;
						if (( ((global::alphatab.model.BendPoint) (this._note.bendPoints[i]) ).@value > maxValue )) {
							maxValue = ((global::alphatab.model.BendPoint) (this._note.bendPoints[i]) ).@value;
						}
						
					}
					
				}
				
				double dY = ( ((double) (this._height) ) / maxValue );
				int xx = ( cx + this.x );
				int yy = ( ( cy + this.y ) + r.getNoteY(this._note) );
				canvas.beginPath();
				{
					int _g11 = 0;
					int _g2 = ( this._note.bendPoints.length - 1 );
					while (( _g11 < _g2 )){
						int i1 = _g11++;
						global::alphatab.model.BendPoint firstPt = ((global::alphatab.model.BendPoint) (this._note.bendPoints[i1]) );
						global::alphatab.model.BendPoint secondPt = ((global::alphatab.model.BendPoint) (this._note.bendPoints[( i1 + 1 )]) );
						if (( ( firstPt.@value == secondPt.@value ) && ( i1 == ( this._note.bendPoints.length - 2 ) ) )) {
							continue;
						}
						
						double x1 = ( xx + ( dX * firstPt.offset ) );
						double y1 = ( yy - ( dY * firstPt.@value ) );
						double x2 = ( xx + ( dX * secondPt.offset ) );
						double y2 = ( yy - ( dY * secondPt.@value ) );
						if (( firstPt.@value == secondPt.@value )) {
							canvas.moveTo(x1, y1);
							canvas.lineTo(x2, y2);
							canvas.stroke();
						}
						 else {
							double hx = ( x1 + (( x2 - x1 )) );
							double hy = ( yy - ( dY * firstPt.@value ) );
							canvas.moveTo(x1, y1);
							canvas.bezierCurveTo(hx, hy, x2, y2, x2, y2);
							canvas.stroke();
						}
						
						double arrowSize = ( 6 * this.renderer.stave.staveGroup.layout.renderer.settings.scale );
						if (( secondPt.@value > firstPt.@value )) {
							canvas.beginPath();
							canvas.moveTo(x2, y2);
							canvas.lineTo(( x2 - ( arrowSize * 0.5 ) ), ( y2 + arrowSize ));
							canvas.lineTo(( x2 + ( arrowSize * 0.5 ) ), ( y2 + arrowSize ));
							canvas.closePath();
							canvas.fill();
						}
						 else {
							if (( secondPt.@value != firstPt.@value )) {
								canvas.beginPath();
								canvas.moveTo(x2, y2);
								canvas.lineTo(( x2 - ( arrowSize * 0.5 ) ), ( y2 - arrowSize ));
								canvas.lineTo(( x2 + ( arrowSize * 0.5 ) ), ( y2 - arrowSize ));
								canvas.closePath();
								canvas.fill();
							}
							
						}
						
						canvas.stroke();
						if (( secondPt.@value != 0 )) {
							double dV = ((double) (( secondPt.@value - firstPt.@value )) );
							bool up = ( dV > 0 );
							dV = global::System.Math.Abs(((double) (dV) ));
							string s = "";
							if (( dV == 4 )) {
								s = "full";
								dV -= ((double) (4) );
							}
							 else {
								if (( dV > 4 )) {
									int __temp_stmt624 = default(int);
									{
										double x = global::System.Math.Floor(((double) (( dV / 4 )) ));
										__temp_stmt624 = ((int) (x) );
									}
									
									string __temp_stmt623 = global::haxe.root.Std.@string(__temp_stmt624);
									string __temp_stmt622 = global::haxe.lang.Runtime.concat(__temp_stmt623, " ");
									s = global::haxe.lang.Runtime.concat(s, __temp_stmt622);
									{
										double x3 = global::System.Math.Floor(((double) (dV) ));
										dV -= ((double) (((int) (x3) )) );
									}
									
								}
								
							}
							
							if (( dV > 0 )) {
								s = global::haxe.lang.Runtime.concat(s, global::haxe.lang.Runtime.concat(global::haxe.root.Std.@string(dV), "/4"));
							}
							
							if ( ! (string.Equals(s, "")) ) {
								if ( ! (up) ) {
									s = global::haxe.lang.Runtime.concat("-", s);
								}
								
								canvas.setFont(res.tablatureFont);
								double size = canvas.measureText(s);
								double y = default(double);
								if (up) {
									y = ( ( y2 - res.tablatureFont.getSize() ) - ( 2 * this.renderer.stave.staveGroup.layout.renderer.settings.scale ) );
								}
								 else {
									y = ( y2 + ( 2 * this.renderer.stave.staveGroup.layout.renderer.settings.scale ) );
								}
								
								double x4 = ( x2 - ( size / 2 ) );
								canvas.fillText(s, x4, y);
							}
							
						}
						
					}
					
				}
				
			}
		}
		
		
		public override   double __hx_setField_f(string field, int hash, double @value, bool handleProperties){
			unchecked {
				switch (hash){
					case 1891834246:
					{
						this._height = ((int) (@value) );
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
					case 1891834246:
					{
						this._height = ((int) (global::haxe.lang.Runtime.toInt(@value)) );
						return @value;
					}
					
					
					case 2082157521:
					{
						this._note = ((global::alphatab.model.Note) (@value) );
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
					
					
					case 1891834246:
					{
						return this._height;
					}
					
					
					case 2082157521:
					{
						return this._note;
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
					case 1891834246:
					{
						return ((double) (this._height) );
					}
					
					
					default:
					{
						return base.__hx_getField_f(field, hash, throwErrors, handleProperties);
					}
					
				}
				
			}
		}
		
		
		public override   void __hx_getFields(global::haxe.root.Array<object> baseArr){
			unchecked {
				baseArr.push("_height");
				baseArr.push("_note");
				{
					base.__hx_getFields(baseArr);
				}
				
			}
		}
		
		
	}
}


