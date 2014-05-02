using haxe.root;
#pragma warning disable 109, 114, 219, 429, 168, 162
namespace alphatab.platform.svg{
	public  class SvgCanvas : global::haxe.lang.HxObject, global::alphatab.platform.ICanvas {
		public    SvgCanvas(global::haxe.lang.EmptyObject empty){
			unchecked {
				{
				}
				
			}
		}
		
		
		public    SvgCanvas(){
			unchecked {
				global::alphatab.platform.svg.SvgCanvas.__hx_ctor_alphatab_platform_svg_SvgCanvas(this);
			}
		}
		
		
		public static   void __hx_ctor_alphatab_platform_svg_SvgCanvas(global::alphatab.platform.svg.SvgCanvas __temp_me21){
			unchecked {
				__temp_me21._buffer = "";
				__temp_me21._currentPath = "";
				__temp_me21._currentPathIsEmpty = true;
				__temp_me21._color = new global::alphatab.platform.model.Color(((int) (255) ), ((int) (255) ), ((int) (255) ), ((global::haxe.lang.Null<int>) (default(global::haxe.lang.Null<int>)) ));
				__temp_me21._lineWidth = ((double) (1) );
				__temp_me21._width = 0;
				__temp_me21._height = 0;
				__temp_me21._font = new global::alphatab.platform.model.Font(((string) ("sans-serif") ), ((double) (10) ), ((global::haxe.lang.Null<int>) (default(global::haxe.lang.Null<int>)) ));
				__temp_me21._textAlign = global::alphatab.platform.model.TextAlign.Left;
				__temp_me21._textBaseline = global::alphatab.model.TextBaseline.Default;
			}
		}
		
		
		public static  new object __hx_createEmpty(){
			unchecked {
				return new global::alphatab.platform.svg.SvgCanvas(((global::haxe.lang.EmptyObject) (global::haxe.lang.EmptyObject.EMPTY) ));
			}
		}
		
		
		public static  new object __hx_create(global::haxe.root.Array arr){
			unchecked {
				return new global::alphatab.platform.svg.SvgCanvas();
			}
		}
		
		
		public  string _buffer;
		
		public  string _currentPath;
		
		public  bool _currentPathIsEmpty;
		
		public  int _width;
		
		public  int _height;
		
		public virtual   void writeTo(global::haxe.io.Output stream, bool includeWrapper, string className){
			unchecked {
				if (includeWrapper) {
					stream.writeString("<svg xmlns=\"http://www.w3.org/2000/svg\" version=\"1.1\" width=\"");
					global::alphatab.io.OutputExtensions.writeAsString(stream, this._width);
					stream.writeString("px\" height=\"");
					global::alphatab.io.OutputExtensions.writeAsString(stream, this._height);
					stream.writeString("px\"");
					if ( ! (string.Equals(className, default(string))) ) {
						stream.writeString(" class=\"");
						stream.writeString(className);
						stream.writeString("\"");
					}
					
					stream.writeString(">\n");
				}
				
				stream.writeString(this._buffer);
				if (includeWrapper) {
					stream.writeString("</svg>");
				}
				
			}
		}
		
		
		public virtual   string toSvg(bool includeWrapper, string className){
			unchecked {
				global::haxe.root.StringBuf buf = new global::haxe.root.StringBuf();
				if (includeWrapper) {
					buf.b.Append(((object) ("<svg xmlns=\"http://www.w3.org/2000/svg\" version=\"1.1\" width=\"") ));
					buf.b.Append(((object) (global::haxe.root.Std.@string(this._width)) ));
					buf.b.Append(((object) ("px\" height=\"") ));
					buf.b.Append(((object) (global::haxe.root.Std.@string(this._height)) ));
					buf.b.Append(((object) ("px\"") ));
					if ( ! (string.Equals(className, default(string))) ) {
						buf.b.Append(((object) (" class=\"") ));
						buf.b.Append(((object) (global::haxe.root.Std.@string(className)) ));
						buf.b.Append(((object) ("\"") ));
					}
					
					buf.b.Append(((object) (">\n") ));
				}
				
				buf.b.Append(((object) (global::haxe.root.Std.@string(this._buffer)) ));
				if (includeWrapper) {
					buf.b.Append(((object) ("</svg>") ));
				}
				
				return buf.toString();
			}
		}
		
		
		public virtual   int getWidth(){
			unchecked {
				return this._width;
			}
		}
		
		
		public virtual   int getHeight(){
			unchecked {
				return this._height;
			}
		}
		
		
		public virtual   void setWidth(int width){
			unchecked {
				this._width = width;
			}
		}
		
		
		public virtual   void setHeight(int height){
			unchecked {
				this._height = height;
			}
		}
		
		
		public  global::alphatab.platform.model.Color _color;
		
		public virtual   void setColor(global::alphatab.platform.model.Color color){
			unchecked {
				this._color = color;
			}
		}
		
		
		public  double _lineWidth;
		
		public virtual   void setLineWidth(double @value){
			unchecked {
				this._lineWidth = @value;
			}
		}
		
		
		public virtual   void clear(){
			unchecked {
				this._buffer = "";
				this._currentPath = "";
				this._currentPathIsEmpty = true;
			}
		}
		
		
		public virtual   void fillRect(double x, double y, double w, double h){
			unchecked {
				{
					global::alphatab.platform.svg.SvgCanvas __temp_dynop331 = this;
					__temp_dynop331._buffer = global::haxe.lang.Runtime.concat(__temp_dynop331._buffer, "<rect x=\"");
				}
				
				{
					global::alphatab.platform.svg.SvgCanvas __temp_dynop332 = this;
					__temp_dynop332._buffer = global::haxe.lang.Runtime.concat(__temp_dynop332._buffer, global::haxe.lang.Runtime.toString(x));
				}
				
				{
					global::alphatab.platform.svg.SvgCanvas __temp_dynop333 = this;
					__temp_dynop333._buffer = global::haxe.lang.Runtime.concat(__temp_dynop333._buffer, "\" y=\"");
				}
				
				{
					global::alphatab.platform.svg.SvgCanvas __temp_dynop334 = this;
					__temp_dynop334._buffer = global::haxe.lang.Runtime.concat(__temp_dynop334._buffer, global::haxe.lang.Runtime.toString(y));
				}
				
				{
					global::alphatab.platform.svg.SvgCanvas __temp_dynop335 = this;
					__temp_dynop335._buffer = global::haxe.lang.Runtime.concat(__temp_dynop335._buffer, "\" width=\"");
				}
				
				{
					global::alphatab.platform.svg.SvgCanvas __temp_dynop336 = this;
					__temp_dynop336._buffer = global::haxe.lang.Runtime.concat(__temp_dynop336._buffer, global::haxe.lang.Runtime.toString(w));
				}
				
				{
					global::alphatab.platform.svg.SvgCanvas __temp_dynop337 = this;
					__temp_dynop337._buffer = global::haxe.lang.Runtime.concat(__temp_dynop337._buffer, "\" height=\"");
				}
				
				{
					global::alphatab.platform.svg.SvgCanvas __temp_dynop338 = this;
					__temp_dynop338._buffer = global::haxe.lang.Runtime.concat(__temp_dynop338._buffer, global::haxe.lang.Runtime.toString(h));
				}
				
				{
					global::alphatab.platform.svg.SvgCanvas __temp_dynop339 = this;
					__temp_dynop339._buffer = global::haxe.lang.Runtime.concat(__temp_dynop339._buffer, "\" style=\"fill:");
				}
				
				{
					global::alphatab.platform.svg.SvgCanvas __temp_dynop340 = this;
					__temp_dynop340._buffer = global::haxe.lang.Runtime.concat(__temp_dynop340._buffer, this._color.toRgbaString());
				}
				
				{
					global::alphatab.platform.svg.SvgCanvas __temp_dynop341 = this;
					__temp_dynop341._buffer = global::haxe.lang.Runtime.concat(__temp_dynop341._buffer, ";\" />\n");
				}
				
			}
		}
		
		
		public virtual   void strokeRect(double x, double y, double w, double h){
			unchecked {
				{
					global::alphatab.platform.svg.SvgCanvas __temp_dynop342 = this;
					__temp_dynop342._buffer = global::haxe.lang.Runtime.concat(__temp_dynop342._buffer, "<rect x=\"");
				}
				
				{
					global::alphatab.platform.svg.SvgCanvas __temp_dynop343 = this;
					__temp_dynop343._buffer = global::haxe.lang.Runtime.concat(__temp_dynop343._buffer, global::haxe.lang.Runtime.toString(x));
				}
				
				{
					global::alphatab.platform.svg.SvgCanvas __temp_dynop344 = this;
					__temp_dynop344._buffer = global::haxe.lang.Runtime.concat(__temp_dynop344._buffer, "\" y=\"");
				}
				
				{
					global::alphatab.platform.svg.SvgCanvas __temp_dynop345 = this;
					__temp_dynop345._buffer = global::haxe.lang.Runtime.concat(__temp_dynop345._buffer, global::haxe.lang.Runtime.toString(y));
				}
				
				{
					global::alphatab.platform.svg.SvgCanvas __temp_dynop346 = this;
					__temp_dynop346._buffer = global::haxe.lang.Runtime.concat(__temp_dynop346._buffer, "\" width=\"");
				}
				
				{
					global::alphatab.platform.svg.SvgCanvas __temp_dynop347 = this;
					__temp_dynop347._buffer = global::haxe.lang.Runtime.concat(__temp_dynop347._buffer, global::haxe.lang.Runtime.toString(w));
				}
				
				{
					global::alphatab.platform.svg.SvgCanvas __temp_dynop348 = this;
					__temp_dynop348._buffer = global::haxe.lang.Runtime.concat(__temp_dynop348._buffer, "\" height=\"");
				}
				
				{
					global::alphatab.platform.svg.SvgCanvas __temp_dynop349 = this;
					__temp_dynop349._buffer = global::haxe.lang.Runtime.concat(__temp_dynop349._buffer, global::haxe.lang.Runtime.toString(h));
				}
				
				{
					global::alphatab.platform.svg.SvgCanvas __temp_dynop350 = this;
					__temp_dynop350._buffer = global::haxe.lang.Runtime.concat(__temp_dynop350._buffer, "\" style=\"stroke:");
				}
				
				{
					global::alphatab.platform.svg.SvgCanvas __temp_dynop351 = this;
					__temp_dynop351._buffer = global::haxe.lang.Runtime.concat(__temp_dynop351._buffer, this._color.toRgbaString());
				}
				
				{
					global::alphatab.platform.svg.SvgCanvas __temp_dynop352 = this;
					__temp_dynop352._buffer = global::haxe.lang.Runtime.concat(__temp_dynop352._buffer, "; stroke-width:");
				}
				
				{
					global::alphatab.platform.svg.SvgCanvas __temp_dynop353 = this;
					__temp_dynop353._buffer = global::haxe.lang.Runtime.concat(__temp_dynop353._buffer, global::haxe.lang.Runtime.toString(this._lineWidth));
				}
				
				{
					global::alphatab.platform.svg.SvgCanvas __temp_dynop354 = this;
					__temp_dynop354._buffer = global::haxe.lang.Runtime.concat(__temp_dynop354._buffer, ";\" />\n");
				}
				
			}
		}
		
		
		public virtual   void beginPath(){
			unchecked {
				{
				}
				
			}
		}
		
		
		public virtual   void closePath(){
			unchecked {
				{
					global::alphatab.platform.svg.SvgCanvas __temp_dynop355 = this;
					__temp_dynop355._currentPath = global::haxe.lang.Runtime.concat(__temp_dynop355._currentPath, " z");
				}
				
			}
		}
		
		
		public virtual   void moveTo(double x, double y){
			unchecked {
				{
					global::alphatab.platform.svg.SvgCanvas __temp_dynop356 = this;
					__temp_dynop356._currentPath = global::haxe.lang.Runtime.concat(__temp_dynop356._currentPath, " M");
				}
				
				{
					global::alphatab.platform.svg.SvgCanvas __temp_dynop357 = this;
					__temp_dynop357._currentPath = global::haxe.lang.Runtime.concat(__temp_dynop357._currentPath, global::haxe.lang.Runtime.toString(x));
				}
				
				{
					global::alphatab.platform.svg.SvgCanvas __temp_dynop358 = this;
					__temp_dynop358._currentPath = global::haxe.lang.Runtime.concat(__temp_dynop358._currentPath, ",");
				}
				
				{
					global::alphatab.platform.svg.SvgCanvas __temp_dynop359 = this;
					__temp_dynop359._currentPath = global::haxe.lang.Runtime.concat(__temp_dynop359._currentPath, global::haxe.lang.Runtime.toString(y));
				}
				
			}
		}
		
		
		public virtual   void lineTo(double x, double y){
			unchecked {
				this._currentPathIsEmpty = false;
				{
					global::alphatab.platform.svg.SvgCanvas __temp_dynop360 = this;
					__temp_dynop360._currentPath = global::haxe.lang.Runtime.concat(__temp_dynop360._currentPath, " L");
				}
				
				{
					global::alphatab.platform.svg.SvgCanvas __temp_dynop361 = this;
					__temp_dynop361._currentPath = global::haxe.lang.Runtime.concat(__temp_dynop361._currentPath, global::haxe.lang.Runtime.toString(x));
				}
				
				{
					global::alphatab.platform.svg.SvgCanvas __temp_dynop362 = this;
					__temp_dynop362._currentPath = global::haxe.lang.Runtime.concat(__temp_dynop362._currentPath, ",");
				}
				
				{
					global::alphatab.platform.svg.SvgCanvas __temp_dynop363 = this;
					__temp_dynop363._currentPath = global::haxe.lang.Runtime.concat(__temp_dynop363._currentPath, global::haxe.lang.Runtime.toString(y));
				}
				
			}
		}
		
		
		public virtual   void quadraticCurveTo(double cpx, double cpy, double x, double y){
			unchecked {
				this._currentPathIsEmpty = false;
				{
					global::alphatab.platform.svg.SvgCanvas __temp_dynop364 = this;
					__temp_dynop364._currentPath = global::haxe.lang.Runtime.concat(__temp_dynop364._currentPath, " Q");
				}
				
				{
					global::alphatab.platform.svg.SvgCanvas __temp_dynop365 = this;
					__temp_dynop365._currentPath = global::haxe.lang.Runtime.concat(__temp_dynop365._currentPath, global::haxe.lang.Runtime.toString(cpx));
				}
				
				{
					global::alphatab.platform.svg.SvgCanvas __temp_dynop366 = this;
					__temp_dynop366._currentPath = global::haxe.lang.Runtime.concat(__temp_dynop366._currentPath, ",");
				}
				
				{
					global::alphatab.platform.svg.SvgCanvas __temp_dynop367 = this;
					__temp_dynop367._currentPath = global::haxe.lang.Runtime.concat(__temp_dynop367._currentPath, global::haxe.lang.Runtime.toString(cpy));
				}
				
				{
					global::alphatab.platform.svg.SvgCanvas __temp_dynop368 = this;
					__temp_dynop368._currentPath = global::haxe.lang.Runtime.concat(__temp_dynop368._currentPath, ",");
				}
				
				{
					global::alphatab.platform.svg.SvgCanvas __temp_dynop369 = this;
					__temp_dynop369._currentPath = global::haxe.lang.Runtime.concat(__temp_dynop369._currentPath, global::haxe.lang.Runtime.toString(x));
				}
				
				{
					global::alphatab.platform.svg.SvgCanvas __temp_dynop370 = this;
					__temp_dynop370._currentPath = global::haxe.lang.Runtime.concat(__temp_dynop370._currentPath, ",");
				}
				
				{
					global::alphatab.platform.svg.SvgCanvas __temp_dynop371 = this;
					__temp_dynop371._currentPath = global::haxe.lang.Runtime.concat(__temp_dynop371._currentPath, global::haxe.lang.Runtime.toString(y));
				}
				
			}
		}
		
		
		public virtual   void bezierCurveTo(double cp1x, double cp1y, double cp2x, double cp2y, double x, double y){
			unchecked {
				this._currentPathIsEmpty = false;
				{
					global::alphatab.platform.svg.SvgCanvas __temp_dynop372 = this;
					__temp_dynop372._currentPath = global::haxe.lang.Runtime.concat(__temp_dynop372._currentPath, " C");
				}
				
				{
					global::alphatab.platform.svg.SvgCanvas __temp_dynop373 = this;
					__temp_dynop373._currentPath = global::haxe.lang.Runtime.concat(__temp_dynop373._currentPath, global::haxe.lang.Runtime.toString(cp1x));
				}
				
				{
					global::alphatab.platform.svg.SvgCanvas __temp_dynop374 = this;
					__temp_dynop374._currentPath = global::haxe.lang.Runtime.concat(__temp_dynop374._currentPath, ",");
				}
				
				{
					global::alphatab.platform.svg.SvgCanvas __temp_dynop375 = this;
					__temp_dynop375._currentPath = global::haxe.lang.Runtime.concat(__temp_dynop375._currentPath, global::haxe.lang.Runtime.toString(cp1y));
				}
				
				{
					global::alphatab.platform.svg.SvgCanvas __temp_dynop376 = this;
					__temp_dynop376._currentPath = global::haxe.lang.Runtime.concat(__temp_dynop376._currentPath, ",");
				}
				
				{
					global::alphatab.platform.svg.SvgCanvas __temp_dynop377 = this;
					__temp_dynop377._currentPath = global::haxe.lang.Runtime.concat(__temp_dynop377._currentPath, global::haxe.lang.Runtime.toString(cp2x));
				}
				
				{
					global::alphatab.platform.svg.SvgCanvas __temp_dynop378 = this;
					__temp_dynop378._currentPath = global::haxe.lang.Runtime.concat(__temp_dynop378._currentPath, ",");
				}
				
				{
					global::alphatab.platform.svg.SvgCanvas __temp_dynop379 = this;
					__temp_dynop379._currentPath = global::haxe.lang.Runtime.concat(__temp_dynop379._currentPath, global::haxe.lang.Runtime.toString(cp2y));
				}
				
				{
					global::alphatab.platform.svg.SvgCanvas __temp_dynop380 = this;
					__temp_dynop380._currentPath = global::haxe.lang.Runtime.concat(__temp_dynop380._currentPath, ",");
				}
				
				{
					global::alphatab.platform.svg.SvgCanvas __temp_dynop381 = this;
					__temp_dynop381._currentPath = global::haxe.lang.Runtime.concat(__temp_dynop381._currentPath, global::haxe.lang.Runtime.toString(x));
				}
				
				{
					global::alphatab.platform.svg.SvgCanvas __temp_dynop382 = this;
					__temp_dynop382._currentPath = global::haxe.lang.Runtime.concat(__temp_dynop382._currentPath, ",");
				}
				
				{
					global::alphatab.platform.svg.SvgCanvas __temp_dynop383 = this;
					__temp_dynop383._currentPath = global::haxe.lang.Runtime.concat(__temp_dynop383._currentPath, global::haxe.lang.Runtime.toString(y));
				}
				
			}
		}
		
		
		public virtual   void circle(double x, double y, double radius){
			unchecked {
				this._currentPathIsEmpty = false;
				{
					global::alphatab.platform.svg.SvgCanvas __temp_dynop384 = this;
					__temp_dynop384._currentPath = global::haxe.lang.Runtime.concat(__temp_dynop384._currentPath, " M");
				}
				
				{
					global::alphatab.platform.svg.SvgCanvas __temp_dynop385 = this;
					__temp_dynop385._currentPath = global::haxe.lang.Runtime.concat(__temp_dynop385._currentPath, global::haxe.lang.Runtime.toString(( x - radius )));
				}
				
				{
					global::alphatab.platform.svg.SvgCanvas __temp_dynop386 = this;
					__temp_dynop386._currentPath = global::haxe.lang.Runtime.concat(__temp_dynop386._currentPath, ",");
				}
				
				{
					global::alphatab.platform.svg.SvgCanvas __temp_dynop387 = this;
					__temp_dynop387._currentPath = global::haxe.lang.Runtime.concat(__temp_dynop387._currentPath, global::haxe.lang.Runtime.toString(y));
				}
				
				{
					global::alphatab.platform.svg.SvgCanvas __temp_dynop388 = this;
					__temp_dynop388._currentPath = global::haxe.lang.Runtime.concat(__temp_dynop388._currentPath, " A1,1 0 0,0 ");
				}
				
				{
					global::alphatab.platform.svg.SvgCanvas __temp_dynop389 = this;
					__temp_dynop389._currentPath = global::haxe.lang.Runtime.concat(__temp_dynop389._currentPath, global::haxe.lang.Runtime.toString(( x + radius )));
				}
				
				{
					global::alphatab.platform.svg.SvgCanvas __temp_dynop390 = this;
					__temp_dynop390._currentPath = global::haxe.lang.Runtime.concat(__temp_dynop390._currentPath, ",");
				}
				
				{
					global::alphatab.platform.svg.SvgCanvas __temp_dynop391 = this;
					__temp_dynop391._currentPath = global::haxe.lang.Runtime.concat(__temp_dynop391._currentPath, global::haxe.lang.Runtime.toString(y));
				}
				
				{
					global::alphatab.platform.svg.SvgCanvas __temp_dynop392 = this;
					__temp_dynop392._currentPath = global::haxe.lang.Runtime.concat(__temp_dynop392._currentPath, " A1,1 0 0,0 ");
				}
				
				{
					global::alphatab.platform.svg.SvgCanvas __temp_dynop393 = this;
					__temp_dynop393._currentPath = global::haxe.lang.Runtime.concat(__temp_dynop393._currentPath, global::haxe.lang.Runtime.toString(( x - radius )));
				}
				
				{
					global::alphatab.platform.svg.SvgCanvas __temp_dynop394 = this;
					__temp_dynop394._currentPath = global::haxe.lang.Runtime.concat(__temp_dynop394._currentPath, ",");
				}
				
				{
					global::alphatab.platform.svg.SvgCanvas __temp_dynop395 = this;
					__temp_dynop395._currentPath = global::haxe.lang.Runtime.concat(__temp_dynop395._currentPath, global::haxe.lang.Runtime.toString(y));
				}
				
				{
					global::alphatab.platform.svg.SvgCanvas __temp_dynop396 = this;
					__temp_dynop396._currentPath = global::haxe.lang.Runtime.concat(__temp_dynop396._currentPath, " z");
				}
				
			}
		}
		
		
		public virtual   void rect(double x, double y, double w, double h){
			unchecked {
				this._currentPathIsEmpty = false;
				{
					global::alphatab.platform.svg.SvgCanvas __temp_dynop397 = this;
					__temp_dynop397._currentPath = global::haxe.lang.Runtime.concat(__temp_dynop397._currentPath, " M");
				}
				
				{
					global::alphatab.platform.svg.SvgCanvas __temp_dynop398 = this;
					__temp_dynop398._currentPath = global::haxe.lang.Runtime.concat(__temp_dynop398._currentPath, global::haxe.lang.Runtime.toString(x));
				}
				
				{
					global::alphatab.platform.svg.SvgCanvas __temp_dynop399 = this;
					__temp_dynop399._currentPath = global::haxe.lang.Runtime.concat(__temp_dynop399._currentPath, ",");
				}
				
				{
					global::alphatab.platform.svg.SvgCanvas __temp_dynop400 = this;
					__temp_dynop400._currentPath = global::haxe.lang.Runtime.concat(__temp_dynop400._currentPath, global::haxe.lang.Runtime.toString(y));
				}
				
				{
					global::alphatab.platform.svg.SvgCanvas __temp_dynop401 = this;
					__temp_dynop401._currentPath = global::haxe.lang.Runtime.concat(__temp_dynop401._currentPath, " L");
				}
				
				{
					global::alphatab.platform.svg.SvgCanvas __temp_dynop402 = this;
					__temp_dynop402._currentPath = global::haxe.lang.Runtime.concat(__temp_dynop402._currentPath, global::haxe.lang.Runtime.toString(( x + w )));
				}
				
				{
					global::alphatab.platform.svg.SvgCanvas __temp_dynop403 = this;
					__temp_dynop403._currentPath = global::haxe.lang.Runtime.concat(__temp_dynop403._currentPath, ",");
				}
				
				{
					global::alphatab.platform.svg.SvgCanvas __temp_dynop404 = this;
					__temp_dynop404._currentPath = global::haxe.lang.Runtime.concat(__temp_dynop404._currentPath, global::haxe.lang.Runtime.toString(y));
				}
				
				{
					global::alphatab.platform.svg.SvgCanvas __temp_dynop405 = this;
					__temp_dynop405._currentPath = global::haxe.lang.Runtime.concat(__temp_dynop405._currentPath, " ");
				}
				
				{
					global::alphatab.platform.svg.SvgCanvas __temp_dynop406 = this;
					__temp_dynop406._currentPath = global::haxe.lang.Runtime.concat(__temp_dynop406._currentPath, global::haxe.lang.Runtime.toString(( x + w )));
				}
				
				{
					global::alphatab.platform.svg.SvgCanvas __temp_dynop407 = this;
					__temp_dynop407._currentPath = global::haxe.lang.Runtime.concat(__temp_dynop407._currentPath, ",");
				}
				
				{
					global::alphatab.platform.svg.SvgCanvas __temp_dynop408 = this;
					__temp_dynop408._currentPath = global::haxe.lang.Runtime.concat(__temp_dynop408._currentPath, global::haxe.lang.Runtime.toString(( y + h )));
				}
				
				{
					global::alphatab.platform.svg.SvgCanvas __temp_dynop409 = this;
					__temp_dynop409._currentPath = global::haxe.lang.Runtime.concat(__temp_dynop409._currentPath, " ");
				}
				
				{
					global::alphatab.platform.svg.SvgCanvas __temp_dynop410 = this;
					__temp_dynop410._currentPath = global::haxe.lang.Runtime.concat(__temp_dynop410._currentPath, global::haxe.lang.Runtime.toString(x));
				}
				
				{
					global::alphatab.platform.svg.SvgCanvas __temp_dynop411 = this;
					__temp_dynop411._currentPath = global::haxe.lang.Runtime.concat(__temp_dynop411._currentPath, ",");
				}
				
				{
					global::alphatab.platform.svg.SvgCanvas __temp_dynop412 = this;
					__temp_dynop412._currentPath = global::haxe.lang.Runtime.concat(__temp_dynop412._currentPath, global::haxe.lang.Runtime.toString(( y + h )));
				}
				
				{
					global::alphatab.platform.svg.SvgCanvas __temp_dynop413 = this;
					__temp_dynop413._currentPath = global::haxe.lang.Runtime.concat(__temp_dynop413._currentPath, " z");
				}
				
			}
		}
		
		
		public virtual   void fill(){
			unchecked {
				if ( ! (this._currentPathIsEmpty) ) {
					{
						global::alphatab.platform.svg.SvgCanvas __temp_dynop414 = this;
						__temp_dynop414._buffer = global::haxe.lang.Runtime.concat(__temp_dynop414._buffer, "<path d=\"");
					}
					
					{
						global::alphatab.platform.svg.SvgCanvas __temp_dynop415 = this;
						__temp_dynop415._buffer = global::haxe.lang.Runtime.concat(__temp_dynop415._buffer, this._currentPath);
					}
					
					{
						global::alphatab.platform.svg.SvgCanvas __temp_dynop416 = this;
						__temp_dynop416._buffer = global::haxe.lang.Runtime.concat(__temp_dynop416._buffer, "\" style=\"fill:");
					}
					
					{
						global::alphatab.platform.svg.SvgCanvas __temp_dynop417 = this;
						__temp_dynop417._buffer = global::haxe.lang.Runtime.concat(__temp_dynop417._buffer, this._color.toRgbaString());
					}
					
					{
						global::alphatab.platform.svg.SvgCanvas __temp_dynop418 = this;
						__temp_dynop418._buffer = global::haxe.lang.Runtime.concat(__temp_dynop418._buffer, "\" stroke=\"none\"/>\n");
					}
					
				}
				
				this._currentPath = "";
				this._currentPathIsEmpty = true;
			}
		}
		
		
		public virtual   void stroke(){
			unchecked {
				if ( ! (this._currentPathIsEmpty) ) {
					{
						global::alphatab.platform.svg.SvgCanvas __temp_dynop419 = this;
						__temp_dynop419._buffer = global::haxe.lang.Runtime.concat(__temp_dynop419._buffer, "<path d=\"");
					}
					
					{
						global::alphatab.platform.svg.SvgCanvas __temp_dynop420 = this;
						__temp_dynop420._buffer = global::haxe.lang.Runtime.concat(__temp_dynop420._buffer, this._currentPath);
					}
					
					{
						global::alphatab.platform.svg.SvgCanvas __temp_dynop421 = this;
						__temp_dynop421._buffer = global::haxe.lang.Runtime.concat(__temp_dynop421._buffer, "\" style=\"stroke:");
					}
					
					{
						global::alphatab.platform.svg.SvgCanvas __temp_dynop422 = this;
						__temp_dynop422._buffer = global::haxe.lang.Runtime.concat(__temp_dynop422._buffer, this._color.toRgbaString());
					}
					
					{
						global::alphatab.platform.svg.SvgCanvas __temp_dynop423 = this;
						__temp_dynop423._buffer = global::haxe.lang.Runtime.concat(__temp_dynop423._buffer, "; stroke-width:");
					}
					
					{
						global::alphatab.platform.svg.SvgCanvas __temp_dynop424 = this;
						__temp_dynop424._buffer = global::haxe.lang.Runtime.concat(__temp_dynop424._buffer, global::haxe.lang.Runtime.toString(this._lineWidth));
					}
					
					{
						global::alphatab.platform.svg.SvgCanvas __temp_dynop425 = this;
						__temp_dynop425._buffer = global::haxe.lang.Runtime.concat(__temp_dynop425._buffer, ";\" fill=\"none\" />\n");
					}
					
				}
				
				this._currentPath = "";
				this._currentPathIsEmpty = true;
			}
		}
		
		
		public  global::alphatab.platform.model.Font _font;
		
		public virtual   void setFont(global::alphatab.platform.model.Font font){
			unchecked {
				this._font = font;
			}
		}
		
		
		public  global::alphatab.platform.model.TextAlign _textAlign;
		
		public virtual   global::alphatab.platform.model.TextAlign getTextAlign(){
			unchecked {
				return this._textAlign;
			}
		}
		
		
		public virtual   void setTextAlign(global::alphatab.platform.model.TextAlign textAlign){
			unchecked {
				this._textAlign = textAlign;
			}
		}
		
		
		public  global::alphatab.model.TextBaseline _textBaseline;
		
		public virtual   global::alphatab.model.TextBaseline getTextBaseline(){
			unchecked {
				return this._textBaseline;
			}
		}
		
		
		public virtual   void setTextBaseline(global::alphatab.model.TextBaseline textBaseline){
			unchecked {
				this._textBaseline = textBaseline;
			}
		}
		
		
		public virtual   void fillText(string text, double x, double y){
			unchecked {
				{
					global::alphatab.platform.svg.SvgCanvas __temp_dynop426 = this;
					__temp_dynop426._buffer = global::haxe.lang.Runtime.concat(__temp_dynop426._buffer, "<text x=\"");
				}
				
				{
					global::alphatab.platform.svg.SvgCanvas __temp_dynop427 = this;
					__temp_dynop427._buffer = global::haxe.lang.Runtime.concat(__temp_dynop427._buffer, global::haxe.lang.Runtime.toString(x));
				}
				
				{
					global::alphatab.platform.svg.SvgCanvas __temp_dynop428 = this;
					__temp_dynop428._buffer = global::haxe.lang.Runtime.concat(__temp_dynop428._buffer, "\" y=\"");
				}
				
				{
					global::alphatab.platform.svg.SvgCanvas __temp_dynop429 = this;
					__temp_dynop429._buffer = global::haxe.lang.Runtime.concat(__temp_dynop429._buffer, global::haxe.lang.Runtime.toString(( y + this.getSvgBaseLineOffset() )));
				}
				
				{
					global::alphatab.platform.svg.SvgCanvas __temp_dynop430 = this;
					__temp_dynop430._buffer = global::haxe.lang.Runtime.concat(__temp_dynop430._buffer, "\" style=\"font:");
				}
				
				{
					global::alphatab.platform.svg.SvgCanvas __temp_dynop431 = this;
					__temp_dynop431._buffer = global::haxe.lang.Runtime.concat(__temp_dynop431._buffer, this._font.toCssString());
				}
				
				{
					global::alphatab.platform.svg.SvgCanvas __temp_dynop432 = this;
					__temp_dynop432._buffer = global::haxe.lang.Runtime.concat(__temp_dynop432._buffer, "; fill:");
				}
				
				{
					global::alphatab.platform.svg.SvgCanvas __temp_dynop433 = this;
					__temp_dynop433._buffer = global::haxe.lang.Runtime.concat(__temp_dynop433._buffer, this._color.toRgbaString());
				}
				
				{
					global::alphatab.platform.svg.SvgCanvas __temp_dynop434 = this;
					__temp_dynop434._buffer = global::haxe.lang.Runtime.concat(__temp_dynop434._buffer, ";\" ");
				}
				
				{
					global::alphatab.platform.svg.SvgCanvas __temp_dynop435 = this;
					__temp_dynop435._buffer = global::haxe.lang.Runtime.concat(__temp_dynop435._buffer, " dominant-baseline=\"");
				}
				
				{
					global::alphatab.model.TextBaseline _g = this._textBaseline;
					switch (global::haxe.root.Type.enumIndex(_g)){
						case 1:
						{
							global::alphatab.platform.svg.SvgCanvas __temp_dynop436 = this;
							__temp_dynop436._buffer = global::haxe.lang.Runtime.concat(__temp_dynop436._buffer, "top");
							break;
						}
						
						
						case 2:
						{
							global::alphatab.platform.svg.SvgCanvas __temp_dynop437 = this;
							__temp_dynop437._buffer = global::haxe.lang.Runtime.concat(__temp_dynop437._buffer, "middle");
							break;
						}
						
						
						case 3:
						{
							global::alphatab.platform.svg.SvgCanvas __temp_dynop438 = this;
							__temp_dynop438._buffer = global::haxe.lang.Runtime.concat(__temp_dynop438._buffer, "bottom");
							break;
						}
						
						
						default:
						{
							global::alphatab.platform.svg.SvgCanvas __temp_dynop439 = this;
							__temp_dynop439._buffer = global::haxe.lang.Runtime.concat(__temp_dynop439._buffer, "top");
							break;
						}
						
					}
					
				}
				
				{
					global::alphatab.platform.svg.SvgCanvas __temp_dynop440 = this;
					__temp_dynop440._buffer = global::haxe.lang.Runtime.concat(__temp_dynop440._buffer, "\" text-anchor=\"");
				}
				
				{
					global::alphatab.platform.svg.SvgCanvas __temp_dynop441 = this;
					__temp_dynop441._buffer = global::haxe.lang.Runtime.concat(__temp_dynop441._buffer, this.getSvgTextAlignment());
				}
				
				{
					global::alphatab.platform.svg.SvgCanvas __temp_dynop442 = this;
					__temp_dynop442._buffer = global::haxe.lang.Runtime.concat(__temp_dynop442._buffer, "\">\n");
				}
				
				{
					global::alphatab.platform.svg.SvgCanvas __temp_dynop443 = this;
					__temp_dynop443._buffer = global::haxe.lang.Runtime.concat(__temp_dynop443._buffer, text);
				}
				
				{
					global::alphatab.platform.svg.SvgCanvas __temp_dynop444 = this;
					__temp_dynop444._buffer = global::haxe.lang.Runtime.concat(__temp_dynop444._buffer, "</text>\n");
				}
				
			}
		}
		
		
		public virtual   string getSvgTextAlignment(){
			unchecked {
				global::alphatab.platform.model.TextAlign _g = this._textAlign;
				switch (global::haxe.root.Type.enumIndex(_g)){
					case 0:
					{
						return "start";
					}
					
					
					case 1:
					{
						return "middle";
					}
					
					
					case 2:
					{
						return "end";
					}
					
					
				}
				
				return default(string);
			}
		}
		
		
		public virtual   double getSvgBaseLineOffset(){
			unchecked {
				global::alphatab.model.TextBaseline _g = this._textBaseline;
				switch (global::haxe.root.Type.enumIndex(_g)){
					case 1:
					{
						return ((double) (0) );
					}
					
					
					case 2:
					{
						return ((double) (0) );
					}
					
					
					case 3:
					{
						return ((double) (0) );
					}
					
					
					default:
					{
						return this._font.getSize();
					}
					
				}
				
			}
		}
		
		
		public   string getSvgBaseLine(){
			unchecked {
				global::alphatab.model.TextBaseline _g = this._textBaseline;
				switch (global::haxe.root.Type.enumIndex(_g)){
					case 1:
					{
						return "top";
					}
					
					
					case 2:
					{
						return "middle";
					}
					
					
					case 3:
					{
						return "bottom";
					}
					
					
					default:
					{
						return "top";
					}
					
				}
				
			}
		}
		
		
		public virtual   double measureText(string text){
			unchecked {
				if (( string.Equals(text, default(string)) || ( text.Length == 0 ) )) {
					return ((double) (0) );
				}
				
				global::alphatab.platform.svg.SupportedFonts font = global::alphatab.platform.svg.SupportedFonts.Arial;
				if (( global::haxe.lang.StringExt.indexOf(this._font.getFamily(), "Times", default(global::haxe.lang.Null<int>)) >= 0 )) {
					font = global::alphatab.platform.svg.SupportedFonts.TimesNewRoman;
				}
				
				return ((double) (global::alphatab.platform.svg.FontSizes.measureString(text, font, this._font.getSize())) );
			}
		}
		
		
		public override   double __hx_setField_f(string field, int hash, double @value, bool handleProperties){
			unchecked {
				switch (hash){
					case 1828730163:
					{
						this._lineWidth = ((double) (@value) );
						return @value;
					}
					
					
					case 1891834246:
					{
						this._height = ((int) (@value) );
						return @value;
					}
					
					
					case 1179254087:
					{
						this._width = ((int) (@value) );
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
					case 672263473:
					{
						this._textBaseline = ((global::alphatab.model.TextBaseline) (@value) );
						return @value;
					}
					
					
					case 371286681:
					{
						this._textAlign = ((global::alphatab.platform.model.TextAlign) (@value) );
						return @value;
					}
					
					
					case 1993439662:
					{
						this._font = ((global::alphatab.platform.model.Font) (@value) );
						return @value;
					}
					
					
					case 1828730163:
					{
						this._lineWidth = ((double) (global::haxe.lang.Runtime.toDouble(@value)) );
						return @value;
					}
					
					
					case 1178843300:
					{
						this._color = ((global::alphatab.platform.model.Color) (@value) );
						return @value;
					}
					
					
					case 1891834246:
					{
						this._height = ((int) (global::haxe.lang.Runtime.toInt(@value)) );
						return @value;
					}
					
					
					case 1179254087:
					{
						this._width = ((int) (global::haxe.lang.Runtime.toInt(@value)) );
						return @value;
					}
					
					
					case 1083160452:
					{
						this._currentPathIsEmpty = global::haxe.lang.Runtime.toBool(@value);
						return @value;
					}
					
					
					case 1760390271:
					{
						this._currentPath = global::haxe.lang.Runtime.toString(@value);
						return @value;
					}
					
					
					case 1057738399:
					{
						this._buffer = global::haxe.lang.Runtime.toString(@value);
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
					case 1350630187:
					{
						return ((global::haxe.lang.Function) (new global::haxe.lang.Closure(((object) (this) ), ((string) ("measureText") ), ((int) (1350630187) ))) );
					}
					
					
					case 1118815795:
					{
						return ((global::haxe.lang.Function) (new global::haxe.lang.Closure(((object) (this) ), ((string) ("getSvgBaseLine") ), ((int) (1118815795) ))) );
					}
					
					
					case 1734539814:
					{
						return ((global::haxe.lang.Function) (new global::haxe.lang.Closure(((object) (this) ), ((string) ("getSvgBaseLineOffset") ), ((int) (1734539814) ))) );
					}
					
					
					case 507631656:
					{
						return ((global::haxe.lang.Function) (new global::haxe.lang.Closure(((object) (this) ), ((string) ("getSvgTextAlignment") ), ((int) (507631656) ))) );
					}
					
					
					case 1846265040:
					{
						return ((global::haxe.lang.Function) (new global::haxe.lang.Closure(((object) (this) ), ((string) ("fillText") ), ((int) (1846265040) ))) );
					}
					
					
					case 1683565844:
					{
						return ((global::haxe.lang.Function) (new global::haxe.lang.Closure(((object) (this) ), ((string) ("setTextBaseline") ), ((int) (1683565844) ))) );
					}
					
					
					case 1754116104:
					{
						return ((global::haxe.lang.Function) (new global::haxe.lang.Closure(((object) (this) ), ((string) ("getTextBaseline") ), ((int) (1754116104) ))) );
					}
					
					
					case 672263473:
					{
						return this._textBaseline;
					}
					
					
					case 1590601430:
					{
						return ((global::haxe.lang.Function) (new global::haxe.lang.Closure(((object) (this) ), ((string) ("setTextAlign") ), ((int) (1590601430) ))) );
					}
					
					
					case 1238729570:
					{
						return ((global::haxe.lang.Function) (new global::haxe.lang.Closure(((object) (this) ), ((string) ("getTextAlign") ), ((int) (1238729570) ))) );
					}
					
					
					case 371286681:
					{
						return this._textAlign;
					}
					
					
					case 155491985:
					{
						return ((global::haxe.lang.Function) (new global::haxe.lang.Closure(((object) (this) ), ((string) ("setFont") ), ((int) (155491985) ))) );
					}
					
					
					case 1993439662:
					{
						return this._font;
					}
					
					
					case 288666552:
					{
						return ((global::haxe.lang.Function) (new global::haxe.lang.Closure(((object) (this) ), ((string) ("stroke") ), ((int) (288666552) ))) );
					}
					
					
					case 1136381571:
					{
						return ((global::haxe.lang.Function) (new global::haxe.lang.Closure(((object) (this) ), ((string) ("fill") ), ((int) (1136381571) ))) );
					}
					
					
					case 1269255460:
					{
						return ((global::haxe.lang.Function) (new global::haxe.lang.Closure(((object) (this) ), ((string) ("rect") ), ((int) (1269255460) ))) );
					}
					
					
					case 1443721744:
					{
						return ((global::haxe.lang.Function) (new global::haxe.lang.Closure(((object) (this) ), ((string) ("circle") ), ((int) (1443721744) ))) );
					}
					
					
					case 978278827:
					{
						return ((global::haxe.lang.Function) (new global::haxe.lang.Closure(((object) (this) ), ((string) ("bezierCurveTo") ), ((int) (978278827) ))) );
					}
					
					
					case 46352402:
					{
						return ((global::haxe.lang.Function) (new global::haxe.lang.Closure(((object) (this) ), ((string) ("quadraticCurveTo") ), ((int) (46352402) ))) );
					}
					
					
					case 1822443151:
					{
						return ((global::haxe.lang.Function) (new global::haxe.lang.Closure(((object) (this) ), ((string) ("lineTo") ), ((int) (1822443151) ))) );
					}
					
					
					case 1286394604:
					{
						return ((global::haxe.lang.Function) (new global::haxe.lang.Closure(((object) (this) ), ((string) ("moveTo") ), ((int) (1286394604) ))) );
					}
					
					
					case 337667453:
					{
						return ((global::haxe.lang.Function) (new global::haxe.lang.Closure(((object) (this) ), ((string) ("closePath") ), ((int) (337667453) ))) );
					}
					
					
					case 321635438:
					{
						return ((global::haxe.lang.Function) (new global::haxe.lang.Closure(((object) (this) ), ((string) ("beginPath") ), ((int) (321635438) ))) );
					}
					
					
					case 491088124:
					{
						return ((global::haxe.lang.Function) (new global::haxe.lang.Closure(((object) (this) ), ((string) ("strokeRect") ), ((int) (491088124) ))) );
					}
					
					
					case 1824081223:
					{
						return ((global::haxe.lang.Function) (new global::haxe.lang.Closure(((object) (this) ), ((string) ("fillRect") ), ((int) (1824081223) ))) );
					}
					
					
					case 1213952397:
					{
						return ((global::haxe.lang.Function) (new global::haxe.lang.Closure(((object) (this) ), ((string) ("clear") ), ((int) (1213952397) ))) );
					}
					
					
					case 900561264:
					{
						return ((global::haxe.lang.Function) (new global::haxe.lang.Closure(((object) (this) ), ((string) ("setLineWidth") ), ((int) (900561264) ))) );
					}
					
					
					case 1828730163:
					{
						return this._lineWidth;
					}
					
					
					case 1485888097:
					{
						return ((global::haxe.lang.Function) (new global::haxe.lang.Closure(((object) (this) ), ((string) ("setColor") ), ((int) (1485888097) ))) );
					}
					
					
					case 1178843300:
					{
						return this._color;
					}
					
					
					case 1643347241:
					{
						return ((global::haxe.lang.Function) (new global::haxe.lang.Closure(((object) (this) ), ((string) ("setHeight") ), ((int) (1643347241) ))) );
					}
					
					
					case 1486298884:
					{
						return ((global::haxe.lang.Function) (new global::haxe.lang.Closure(((object) (this) ), ((string) ("setWidth") ), ((int) (1486298884) ))) );
					}
					
					
					case 2124583197:
					{
						return ((global::haxe.lang.Function) (new global::haxe.lang.Closure(((object) (this) ), ((string) ("getHeight") ), ((int) (2124583197) ))) );
					}
					
					
					case 708429200:
					{
						return ((global::haxe.lang.Function) (new global::haxe.lang.Closure(((object) (this) ), ((string) ("getWidth") ), ((int) (708429200) ))) );
					}
					
					
					case 337206185:
					{
						return ((global::haxe.lang.Function) (new global::haxe.lang.Closure(((object) (this) ), ((string) ("toSvg") ), ((int) (337206185) ))) );
					}
					
					
					case 724954170:
					{
						return ((global::haxe.lang.Function) (new global::haxe.lang.Closure(((object) (this) ), ((string) ("writeTo") ), ((int) (724954170) ))) );
					}
					
					
					case 1891834246:
					{
						return this._height;
					}
					
					
					case 1179254087:
					{
						return this._width;
					}
					
					
					case 1083160452:
					{
						return this._currentPathIsEmpty;
					}
					
					
					case 1760390271:
					{
						return this._currentPath;
					}
					
					
					case 1057738399:
					{
						return this._buffer;
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
					case 1828730163:
					{
						return this._lineWidth;
					}
					
					
					case 1891834246:
					{
						return ((double) (this._height) );
					}
					
					
					case 1179254087:
					{
						return ((double) (this._width) );
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
					case 1350630187:
					{
						return this.measureText(global::haxe.lang.Runtime.toString(dynargs[0]));
					}
					
					
					case 1118815795:
					{
						return this.getSvgBaseLine();
					}
					
					
					case 1734539814:
					{
						return this.getSvgBaseLineOffset();
					}
					
					
					case 507631656:
					{
						return this.getSvgTextAlignment();
					}
					
					
					case 1846265040:
					{
						this.fillText(global::haxe.lang.Runtime.toString(dynargs[0]), ((double) (global::haxe.lang.Runtime.toDouble(dynargs[1])) ), ((double) (global::haxe.lang.Runtime.toDouble(dynargs[2])) ));
						break;
					}
					
					
					case 1683565844:
					{
						this.setTextBaseline(((global::alphatab.model.TextBaseline) (dynargs[0]) ));
						break;
					}
					
					
					case 1754116104:
					{
						return this.getTextBaseline();
					}
					
					
					case 1590601430:
					{
						this.setTextAlign(((global::alphatab.platform.model.TextAlign) (dynargs[0]) ));
						break;
					}
					
					
					case 1238729570:
					{
						return this.getTextAlign();
					}
					
					
					case 155491985:
					{
						this.setFont(((global::alphatab.platform.model.Font) (dynargs[0]) ));
						break;
					}
					
					
					case 288666552:
					{
						this.stroke();
						break;
					}
					
					
					case 1136381571:
					{
						this.fill();
						break;
					}
					
					
					case 1269255460:
					{
						this.rect(((double) (global::haxe.lang.Runtime.toDouble(dynargs[0])) ), ((double) (global::haxe.lang.Runtime.toDouble(dynargs[1])) ), ((double) (global::haxe.lang.Runtime.toDouble(dynargs[2])) ), ((double) (global::haxe.lang.Runtime.toDouble(dynargs[3])) ));
						break;
					}
					
					
					case 1443721744:
					{
						this.circle(((double) (global::haxe.lang.Runtime.toDouble(dynargs[0])) ), ((double) (global::haxe.lang.Runtime.toDouble(dynargs[1])) ), ((double) (global::haxe.lang.Runtime.toDouble(dynargs[2])) ));
						break;
					}
					
					
					case 978278827:
					{
						this.bezierCurveTo(((double) (global::haxe.lang.Runtime.toDouble(dynargs[0])) ), ((double) (global::haxe.lang.Runtime.toDouble(dynargs[1])) ), ((double) (global::haxe.lang.Runtime.toDouble(dynargs[2])) ), ((double) (global::haxe.lang.Runtime.toDouble(dynargs[3])) ), ((double) (global::haxe.lang.Runtime.toDouble(dynargs[4])) ), ((double) (global::haxe.lang.Runtime.toDouble(dynargs[5])) ));
						break;
					}
					
					
					case 46352402:
					{
						this.quadraticCurveTo(((double) (global::haxe.lang.Runtime.toDouble(dynargs[0])) ), ((double) (global::haxe.lang.Runtime.toDouble(dynargs[1])) ), ((double) (global::haxe.lang.Runtime.toDouble(dynargs[2])) ), ((double) (global::haxe.lang.Runtime.toDouble(dynargs[3])) ));
						break;
					}
					
					
					case 1822443151:
					{
						this.lineTo(((double) (global::haxe.lang.Runtime.toDouble(dynargs[0])) ), ((double) (global::haxe.lang.Runtime.toDouble(dynargs[1])) ));
						break;
					}
					
					
					case 1286394604:
					{
						this.moveTo(((double) (global::haxe.lang.Runtime.toDouble(dynargs[0])) ), ((double) (global::haxe.lang.Runtime.toDouble(dynargs[1])) ));
						break;
					}
					
					
					case 337667453:
					{
						this.closePath();
						break;
					}
					
					
					case 321635438:
					{
						this.beginPath();
						break;
					}
					
					
					case 491088124:
					{
						this.strokeRect(((double) (global::haxe.lang.Runtime.toDouble(dynargs[0])) ), ((double) (global::haxe.lang.Runtime.toDouble(dynargs[1])) ), ((double) (global::haxe.lang.Runtime.toDouble(dynargs[2])) ), ((double) (global::haxe.lang.Runtime.toDouble(dynargs[3])) ));
						break;
					}
					
					
					case 1824081223:
					{
						this.fillRect(((double) (global::haxe.lang.Runtime.toDouble(dynargs[0])) ), ((double) (global::haxe.lang.Runtime.toDouble(dynargs[1])) ), ((double) (global::haxe.lang.Runtime.toDouble(dynargs[2])) ), ((double) (global::haxe.lang.Runtime.toDouble(dynargs[3])) ));
						break;
					}
					
					
					case 1213952397:
					{
						this.clear();
						break;
					}
					
					
					case 900561264:
					{
						this.setLineWidth(((double) (global::haxe.lang.Runtime.toDouble(dynargs[0])) ));
						break;
					}
					
					
					case 1485888097:
					{
						this.setColor(((global::alphatab.platform.model.Color) (dynargs[0]) ));
						break;
					}
					
					
					case 1643347241:
					{
						this.setHeight(((int) (global::haxe.lang.Runtime.toInt(dynargs[0])) ));
						break;
					}
					
					
					case 1486298884:
					{
						this.setWidth(((int) (global::haxe.lang.Runtime.toInt(dynargs[0])) ));
						break;
					}
					
					
					case 2124583197:
					{
						return this.getHeight();
					}
					
					
					case 708429200:
					{
						return this.getWidth();
					}
					
					
					case 337206185:
					{
						return this.toSvg(global::haxe.lang.Runtime.toBool(dynargs[0]), global::haxe.lang.Runtime.toString(dynargs[1]));
					}
					
					
					case 724954170:
					{
						this.writeTo(((global::haxe.io.Output) (dynargs[0]) ), global::haxe.lang.Runtime.toBool(dynargs[1]), global::haxe.lang.Runtime.toString(dynargs[2]));
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
				baseArr.push("_textBaseline");
				baseArr.push("_textAlign");
				baseArr.push("_font");
				baseArr.push("_lineWidth");
				baseArr.push("_color");
				baseArr.push("_height");
				baseArr.push("_width");
				baseArr.push("_currentPathIsEmpty");
				baseArr.push("_currentPath");
				baseArr.push("_buffer");
				{
					base.__hx_getFields(baseArr);
				}
				
			}
		}
		
		
	}
}


