using haxe.root;
#pragma warning disable 109, 114, 219, 429, 168, 162
namespace alphatab.rendering.glyphs{
	public  class SvgGlyph : global::alphatab.rendering.Glyph {
		public    SvgGlyph(global::haxe.lang.EmptyObject empty) : base(global::haxe.lang.EmptyObject.EMPTY){
			unchecked {
			}
		}
		
		
		public    SvgGlyph(global::haxe.lang.Null<int> x, global::haxe.lang.Null<int> y, global::alphatab.rendering.glyphs.LazySvg svg, double xScale, double yScale) : base(global::haxe.lang.EmptyObject.EMPTY){
			unchecked {
				global::alphatab.rendering.glyphs.SvgGlyph.__hx_ctor_alphatab_rendering_glyphs_SvgGlyph(this, x, y, svg, xScale, yScale);
			}
		}
		
		
		public static   void __hx_ctor_alphatab_rendering_glyphs_SvgGlyph(global::alphatab.rendering.glyphs.SvgGlyph __temp_me124, global::haxe.lang.Null<int> x, global::haxe.lang.Null<int> y, global::alphatab.rendering.glyphs.LazySvg svg, double xScale, double yScale){
			unchecked {
				global::alphatab.rendering.Glyph.__hx_ctor_alphatab_rendering_Glyph(__temp_me124, ( ( ! (x.hasValue) ) ? (new global::haxe.lang.Null<int>(0, true)) : (x) ), ( ( ! (y.hasValue) ) ? (new global::haxe.lang.Null<int>(0, true)) : (y) ));
				int __temp_y123 = ( ( ! (y.hasValue) ) ? (((int) (0) )) : (y.@value) );
				int __temp_x122 = ( ( ! (x.hasValue) ) ? (((int) (0) )) : (x.@value) );
				__temp_me124._svg = svg;
				__temp_me124._xGlyphScale = ( xScale * 0.0099 );
				__temp_me124._yGlyphScale = ( yScale * 0.0099 );
			}
		}
		
		
		public static  new object __hx_createEmpty(){
			unchecked {
				return new global::alphatab.rendering.glyphs.SvgGlyph(((global::haxe.lang.EmptyObject) (global::haxe.lang.EmptyObject.EMPTY) ));
			}
		}
		
		
		public static  new object __hx_create(global::haxe.root.Array arr){
			unchecked {
				return new global::alphatab.rendering.glyphs.SvgGlyph(global::haxe.lang.Null<object>.ofDynamic<int>(arr[0]), global::haxe.lang.Null<object>.ofDynamic<int>(arr[1]), ((global::alphatab.rendering.glyphs.LazySvg) (arr[2]) ), ((double) (global::haxe.lang.Runtime.toDouble(arr[3])) ), ((double) (global::haxe.lang.Runtime.toDouble(arr[4])) ));
			}
		}
		
		
		public  global::alphatab.rendering.glyphs.LazySvg _svg;
		
		public  string _lastCmd;
		
		public  double _currentX;
		
		public  double _currentY;
		
		public  double _xScale;
		
		public  double _yScale;
		
		public  double _xGlyphScale;
		
		public  double _yGlyphScale;
		
		public  double _lastControlX;
		
		public  double _lastControlY;
		
		public override   void paint(int cx, int cy, global::alphatab.platform.ICanvas canvas){
			unchecked {
				if (( this._svg == default(global::alphatab.rendering.glyphs.LazySvg) )) {
					return ;
				}
				
				this._xScale = ( this._xGlyphScale * this.renderer.stave.staveGroup.layout.renderer.settings.scale );
				this._yScale = ( this._yGlyphScale * this.renderer.stave.staveGroup.layout.renderer.settings.scale );
				global::alphatab.rendering.RenderingResources res = this.renderer.stave.staveGroup.layout.renderer.renderingResources;
				canvas.setColor(res.mainGlyphColor);
				int startX = ( this.x + cx );
				int startY = ( this.y + cy );
				this._currentX = ((double) (startX) );
				this._currentY = ((double) (startY) );
				canvas.setColor(new global::alphatab.platform.model.Color(((int) (0) ), ((int) (0) ), ((int) (0) ), ((global::haxe.lang.Null<int>) (default(global::haxe.lang.Null<int>)) )));
				canvas.beginPath();
				{
					int _g = 0;
					global::haxe.root.Array<object> _g1 = this._svg.@get();
					while (( _g < _g1.length )){
						global::alphatab.rendering.glyphs.SvgCommand c = ((global::alphatab.rendering.glyphs.SvgCommand) (_g1[_g]) );
						 ++ _g;
						this.parseCommand(startX, startY, canvas, c);
					}
					
				}
				
				canvas.fill();
			}
		}
		
		
		public virtual   void parseCommand(int cx, int cy, global::alphatab.platform.ICanvas canvas, global::alphatab.rendering.glyphs.SvgCommand cmd){
			unchecked {
				bool canContinue = default(bool);
				int i = default(int);
				{
					string _g = cmd.cmd;
					switch (_g){
						case "M":
						{
							this._currentX = ( cx + ( cmd.numbers[0] * this._xScale ) );
							this._currentY = ( cy + ( cmd.numbers[1] * this._yScale ) );
							canvas.moveTo(this._currentX, this._currentY);
							break;
						}
						
						
						case "m":
						{
							this._currentX += ( cmd.numbers[0] * this._xScale );
							this._currentY += ( cmd.numbers[1] * this._yScale );
							canvas.moveTo(this._currentX, this._currentY);
							break;
						}
						
						
						case "Z":case "z":
						{
							canvas.closePath();
							break;
						}
						
						
						case "L":
						{
							i = 0;
							while (( i < cmd.numbers.length )){
								this._currentX = ( cx + ( cmd.numbers[i++] * this._xScale ) );
								this._currentY = ( cy + ( cmd.numbers[i++] * this._yScale ) );
								canvas.lineTo(this._currentX, this._currentY);
							}
							
							break;
						}
						
						
						case "l":
						{
							i = 0;
							while (( i < cmd.numbers.length )){
								this._currentX += ( cmd.numbers[i++] * this._xScale );
								this._currentY += ( cmd.numbers[i++] * this._yScale );
								canvas.lineTo(this._currentX, this._currentY);
							}
							
							break;
						}
						
						
						case "V":
						{
							i = 0;
							while (( i < cmd.numbers.length )){
								this._currentY = ( cy + ( cmd.numbers[i++] * this._yScale ) );
								canvas.lineTo(this._currentX, this._currentY);
							}
							
							break;
						}
						
						
						case "v":
						{
							i = 0;
							while (( i < cmd.numbers.length )){
								this._currentY += ( cmd.numbers[i++] * this._yScale );
								canvas.lineTo(this._currentX, this._currentY);
							}
							
							break;
						}
						
						
						case "H":
						{
							i = 0;
							while (( i < cmd.numbers.length )){
								this._currentX = ( cx + ( cmd.numbers[i++] * this._xScale ) );
								canvas.lineTo(this._currentX, this._currentY);
							}
							
							break;
						}
						
						
						case "h":
						{
							i = 0;
							while (( i < cmd.numbers.length )){
								this._currentX += ( cmd.numbers[i++] * this._xScale );
								canvas.lineTo(this._currentX, this._currentY);
							}
							
							break;
						}
						
						
						case "C":
						{
							i = 0;
							while (( i < cmd.numbers.length )){
								double x1 = ( cx + ( cmd.numbers[i++] * this._xScale ) );
								double y1 = ( cy + ( cmd.numbers[i++] * this._yScale ) );
								double x2 = ( cx + ( cmd.numbers[i++] * this._xScale ) );
								double y2 = ( cy + ( cmd.numbers[i++] * this._yScale ) );
								double x3 = ( cx + ( cmd.numbers[i++] * this._xScale ) );
								double y3 = ( cy + ( cmd.numbers[i++] * this._yScale ) );
								this._lastControlX = x2;
								this._lastControlY = y2;
								this._currentX = x3;
								this._currentY = y3;
								canvas.bezierCurveTo(x1, y1, x2, y2, x3, y3);
							}
							
							break;
						}
						
						
						case "c":
						{
							i = 0;
							while (( i < cmd.numbers.length )){
								double x11 = ( this._currentX + ( cmd.numbers[i++] * this._xScale ) );
								double y11 = ( this._currentY + ( cmd.numbers[i++] * this._yScale ) );
								double x21 = ( this._currentX + ( cmd.numbers[i++] * this._xScale ) );
								double y21 = ( this._currentY + ( cmd.numbers[i++] * this._yScale ) );
								double x31 = ( this._currentX + ( cmd.numbers[i++] * this._xScale ) );
								double y31 = ( this._currentY + ( cmd.numbers[i++] * this._yScale ) );
								this._lastControlX = x21;
								this._lastControlY = y21;
								this._currentX = x31;
								this._currentY = y31;
								canvas.bezierCurveTo(x11, y11, x21, y21, x31, y31);
							}
							
							break;
						}
						
						
						case "S":
						{
							i = 0;
							while (( i < cmd.numbers.length )){
								double x12 = ( cx + ( cmd.numbers[i++] * this._xScale ) );
								double y12 = ( cy + ( cmd.numbers[i++] * this._yScale ) );
								canContinue = ( ( ( string.Equals(this._lastCmd, "c") || string.Equals(this._lastCmd, "C") ) || string.Equals(this._lastCmd, "S") ) || string.Equals(this._lastCmd, "s") );
								double x22 = default(double);
								if (canContinue) {
									x22 = ( this._currentX + (( this._currentX - this._lastControlX )) );
								}
								 else {
									x22 = this._currentX;
								}
								
								double y22 = default(double);
								if (canContinue) {
									y22 = ( this._currentY + (( this._currentY - this._lastControlY )) );
								}
								 else {
									y22 = this._currentY;
								}
								
								double x32 = ( cx + ( cmd.numbers[i++] * this._xScale ) );
								double y32 = ( cy + ( cmd.numbers[i++] * this._yScale ) );
								this._lastControlX = x22;
								this._lastControlY = y22;
								this._currentX = x32;
								this._currentY = y32;
								canvas.bezierCurveTo(x12, y12, x22, y22, x32, y32);
							}
							
							break;
						}
						
						
						case "s":
						{
							i = 0;
							while (( i < cmd.numbers.length )){
								double x13 = ( this._currentX + ( cmd.numbers[i++] * this._xScale ) );
								double y13 = ( this._currentY + ( cmd.numbers[i++] * this._yScale ) );
								canContinue = ( ( ( string.Equals(this._lastCmd, "c") || string.Equals(this._lastCmd, "C") ) || string.Equals(this._lastCmd, "S") ) || string.Equals(this._lastCmd, "s") );
								double x23 = default(double);
								if (canContinue) {
									x23 = ( this._currentX + (( this._currentX - this._lastControlX )) );
								}
								 else {
									x23 = this._currentX;
								}
								
								double y23 = default(double);
								if (canContinue) {
									y23 = ( this._currentY + (( this._currentY - this._lastControlY )) );
								}
								 else {
									y23 = this._currentY;
								}
								
								double x33 = ( this._currentX + ( cmd.numbers[i++] * this._xScale ) );
								double y33 = ( this._currentY + ( cmd.numbers[i++] * this._yScale ) );
								this._lastControlX = x23;
								this._lastControlY = y23;
								this._currentX = x33;
								this._currentY = y33;
								canvas.bezierCurveTo(x13, y13, x23, y23, x33, y33);
							}
							
							break;
						}
						
						
						case "Q":
						{
							i = 0;
							while (( i < cmd.numbers.length )){
								double x14 = ( cx + ( cmd.numbers[i++] * this._xScale ) );
								double y14 = ( cy + ( cmd.numbers[i++] * this._yScale ) );
								double x24 = ( cx + ( cmd.numbers[i++] * this._xScale ) );
								double y24 = ( cy + ( cmd.numbers[i++] * this._yScale ) );
								this._lastControlX = x14;
								this._lastControlY = y14;
								this._currentX = x24;
								this._currentY = y24;
								canvas.quadraticCurveTo(x14, y14, x24, y24);
							}
							
							break;
						}
						
						
						case "q":
						{
							i = 0;
							while (( i < cmd.numbers.length )){
								double x15 = ( this._currentX + ( cmd.numbers[i++] * this._xScale ) );
								double y15 = ( this._currentY + ( cmd.numbers[i++] * this._yScale ) );
								double x25 = ( this._currentX + ( cmd.numbers[i++] * this._xScale ) );
								double y25 = ( this._currentY + ( cmd.numbers[i++] * this._yScale ) );
								this._lastControlX = x15;
								this._lastControlY = y15;
								this._currentX = x25;
								this._currentY = y25;
								canvas.quadraticCurveTo(x15, y15, x25, y25);
							}
							
							break;
						}
						
						
						case "T":
						{
							i = 0;
							while (( i < cmd.numbers.length )){
								double x16 = ( cx + ( cmd.numbers[i++] * this._xScale ) );
								double y16 = ( cy + ( cmd.numbers[i++] * this._yScale ) );
								canContinue = ( ( ( string.Equals(this._lastCmd, "q") || string.Equals(this._lastCmd, "Q") ) || string.Equals(this._lastCmd, "t") ) || string.Equals(this._lastCmd, "T") );
								double cpx = default(double);
								if (canContinue) {
									cpx = ( this._currentX + (( this._currentX - this._lastControlX )) );
								}
								 else {
									cpx = this._currentX;
								}
								
								double cpy = default(double);
								if (canContinue) {
									cpy = ( this._currentY + (( this._currentY - this._lastControlY )) );
								}
								 else {
									cpy = this._currentY;
								}
								
								this._currentX = x16;
								this._currentY = y16;
								this._lastControlX = cpx;
								this._lastControlY = cpy;
								canvas.quadraticCurveTo(cpx, cpy, x16, y16);
							}
							
							break;
						}
						
						
						case "t":
						{
							i = 0;
							while (( i < cmd.numbers.length )){
								double x17 = ( this._currentX + ( cmd.numbers[i++] * this._xScale ) );
								double y17 = ( this._currentY + ( cmd.numbers[i++] * this._yScale ) );
								double cpx1 = ( this._currentX + (( this._currentX - this._lastControlX )) );
								double cpy1 = ( this._currentY + (( this._currentY - this._lastControlY )) );
								canContinue = ( ( ( string.Equals(this._lastCmd, "q") || string.Equals(this._lastCmd, "Q") ) || string.Equals(this._lastCmd, "t") ) || string.Equals(this._lastCmd, "T") );
								double cpx2 = default(double);
								if (canContinue) {
									cpx2 = ( this._currentX + (( this._currentX - this._lastControlX )) );
								}
								 else {
									cpx2 = this._currentX;
								}
								
								double cpy2 = default(double);
								if (canContinue) {
									cpy2 = ( this._currentY + (( this._currentY - this._lastControlY )) );
								}
								 else {
									cpy2 = this._currentY;
								}
								
								this._lastControlX = cpx2;
								this._lastControlY = cpy2;
								canvas.quadraticCurveTo(cpx2, cpy2, x17, y17);
							}
							
							break;
						}
						
						
					}
					
				}
				
				this._lastCmd = cmd.cmd;
			}
		}
		
		
		public override   double __hx_setField_f(string field, int hash, double @value, bool handleProperties){
			unchecked {
				switch (hash){
					case 2075993521:
					{
						this._lastControlY = ((double) (@value) );
						return @value;
					}
					
					
					case 2075993520:
					{
						this._lastControlX = ((double) (@value) );
						return @value;
					}
					
					
					case 2097124632:
					{
						this._yGlyphScale = ((double) (@value) );
						return @value;
					}
					
					
					case 2082548183:
					{
						this._xGlyphScale = ((double) (@value) );
						return @value;
					}
					
					
					case 1537341680:
					{
						this._yScale = ((double) (@value) );
						return @value;
					}
					
					
					case 1967561873:
					{
						this._xScale = ((double) (@value) );
						return @value;
					}
					
					
					case 1658522975:
					{
						this._currentY = ((double) (@value) );
						return @value;
					}
					
					
					case 1658522974:
					{
						this._currentX = ((double) (@value) );
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
					case 2075993521:
					{
						this._lastControlY = ((double) (global::haxe.lang.Runtime.toDouble(@value)) );
						return @value;
					}
					
					
					case 2075993520:
					{
						this._lastControlX = ((double) (global::haxe.lang.Runtime.toDouble(@value)) );
						return @value;
					}
					
					
					case 2097124632:
					{
						this._yGlyphScale = ((double) (global::haxe.lang.Runtime.toDouble(@value)) );
						return @value;
					}
					
					
					case 2082548183:
					{
						this._xGlyphScale = ((double) (global::haxe.lang.Runtime.toDouble(@value)) );
						return @value;
					}
					
					
					case 1537341680:
					{
						this._yScale = ((double) (global::haxe.lang.Runtime.toDouble(@value)) );
						return @value;
					}
					
					
					case 1967561873:
					{
						this._xScale = ((double) (global::haxe.lang.Runtime.toDouble(@value)) );
						return @value;
					}
					
					
					case 1658522975:
					{
						this._currentY = ((double) (global::haxe.lang.Runtime.toDouble(@value)) );
						return @value;
					}
					
					
					case 1658522974:
					{
						this._currentX = ((double) (global::haxe.lang.Runtime.toDouble(@value)) );
						return @value;
					}
					
					
					case 291053381:
					{
						this._lastCmd = global::haxe.lang.Runtime.toString(@value);
						return @value;
					}
					
					
					case 1059254117:
					{
						this._svg = ((global::alphatab.rendering.glyphs.LazySvg) (@value) );
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
					case 1531430232:
					{
						return ((global::haxe.lang.Function) (new global::haxe.lang.Closure(((object) (this) ), ((string) ("parseCommand") ), ((int) (1531430232) ))) );
					}
					
					
					case 1028568990:
					{
						return ((global::haxe.lang.Function) (new global::haxe.lang.Closure(((object) (this) ), ((string) ("paint") ), ((int) (1028568990) ))) );
					}
					
					
					case 2075993521:
					{
						return this._lastControlY;
					}
					
					
					case 2075993520:
					{
						return this._lastControlX;
					}
					
					
					case 2097124632:
					{
						return this._yGlyphScale;
					}
					
					
					case 2082548183:
					{
						return this._xGlyphScale;
					}
					
					
					case 1537341680:
					{
						return this._yScale;
					}
					
					
					case 1967561873:
					{
						return this._xScale;
					}
					
					
					case 1658522975:
					{
						return this._currentY;
					}
					
					
					case 1658522974:
					{
						return this._currentX;
					}
					
					
					case 291053381:
					{
						return this._lastCmd;
					}
					
					
					case 1059254117:
					{
						return this._svg;
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
					case 2075993521:
					{
						return this._lastControlY;
					}
					
					
					case 2075993520:
					{
						return this._lastControlX;
					}
					
					
					case 2097124632:
					{
						return this._yGlyphScale;
					}
					
					
					case 2082548183:
					{
						return this._xGlyphScale;
					}
					
					
					case 1537341680:
					{
						return this._yScale;
					}
					
					
					case 1967561873:
					{
						return this._xScale;
					}
					
					
					case 1658522975:
					{
						return this._currentY;
					}
					
					
					case 1658522974:
					{
						return this._currentX;
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
					case 1028568990:
					{
						return global::haxe.lang.Runtime.slowCallField(this, field, dynargs);
					}
					
					
					case 1531430232:
					{
						this.parseCommand(((int) (global::haxe.lang.Runtime.toInt(dynargs[0])) ), ((int) (global::haxe.lang.Runtime.toInt(dynargs[1])) ), ((global::alphatab.platform.ICanvas) (dynargs[2]) ), ((global::alphatab.rendering.glyphs.SvgCommand) (dynargs[3]) ));
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
				baseArr.push("_lastControlY");
				baseArr.push("_lastControlX");
				baseArr.push("_yGlyphScale");
				baseArr.push("_xGlyphScale");
				baseArr.push("_yScale");
				baseArr.push("_xScale");
				baseArr.push("_currentY");
				baseArr.push("_currentX");
				baseArr.push("_lastCmd");
				baseArr.push("_svg");
				{
					base.__hx_getFields(baseArr);
				}
				
			}
		}
		
		
	}
}


