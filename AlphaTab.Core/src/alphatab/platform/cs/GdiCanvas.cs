using haxe.root;
#pragma warning disable 109, 114, 219, 429, 168, 162
namespace alphatab.platform.cs{
	public  class GdiCanvas : global::haxe.lang.HxObject, global::alphatab.platform.ICanvas {
		public    GdiCanvas(global::haxe.lang.EmptyObject empty){
			unchecked {
				{
				}
				
			}
		}
		
		
		public    GdiCanvas(){
			unchecked {
				global::alphatab.platform.cs.GdiCanvas.__hx_ctor_alphatab_platform_cs_GdiCanvas(this);
			}
		}
		
		
		public static   void __hx_ctor_alphatab_platform_cs_GdiCanvas(global::alphatab.platform.cs.GdiCanvas __temp_me17){
			unchecked {
				__temp_me17._width = 1;
				__temp_me17._height = 1;
				__temp_me17._image = new global::System.Drawing.Bitmap(((int) (1) ), ((int) (1) ), ((global::System.Drawing.Imaging.PixelFormat) (global::System.Drawing.Imaging.PixelFormat.Format32bppArgb) ));
				__temp_me17._graphics = global::System.Drawing.Graphics.FromImage(__temp_me17._image);
				__temp_me17._graphics.SmoothingMode = global::System.Drawing.Drawing2D.SmoothingMode.HighQuality;
				__temp_me17._graphics.TextRenderingHint = global::System.Drawing.Text.TextRenderingHint.AntiAlias;
				__temp_me17._currentPath = new global::System.Drawing.Drawing2D.GraphicsPath(((global::System.Drawing.Drawing2D.FillMode) (global::System.Drawing.Drawing2D.FillMode.Winding) ));
				__temp_me17._stringFormat = new global::System.Drawing.StringFormat();
				__temp_me17._stringFormat.LineAlignment = global::System.Drawing.StringAlignment.Near;
				__temp_me17._lineWidth = ((double) (1) );
				__temp_me17._currentX = ((float) (0) );
				__temp_me17._currentY = ((float) (0) );
				__temp_me17._font = new global::System.Drawing.Font(((string) ("Arial") ), ((float) (10) ), ((global::System.Drawing.GraphicsUnit) (global::System.Drawing.GraphicsUnit.Pixel) ));
				__temp_me17._textAlign = global::alphatab.platform.model.TextAlign.Left;
				__temp_me17._textBaseline = global::alphatab.model.TextBaseline.Top;
				__temp_me17.setColor(new global::alphatab.platform.model.Color(((int) (255) ), ((int) (255) ), ((int) (255) ), ((global::haxe.lang.Null<int>) (default(global::haxe.lang.Null<int>)) )));
			}
		}
		
		
		public static  new object __hx_createEmpty(){
			unchecked {
				return new global::alphatab.platform.cs.GdiCanvas(((global::haxe.lang.EmptyObject) (global::haxe.lang.EmptyObject.EMPTY) ));
			}
		}
		
		
		public static  new object __hx_create(global::haxe.root.Array arr){
			unchecked {
				return new global::alphatab.platform.cs.GdiCanvas();
			}
		}
		
		
		public  global::System.Drawing.Bitmap _image;
		
		public  int _width;
		
		public  int _height;
		
		public  global::System.Drawing.Graphics _graphics;
		
		public  global::System.Drawing.Drawing2D.GraphicsPath _currentPath;
		
		public  float _currentX;
		
		public  float _currentY;
		
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
				this.recreateImage();
			}
		}
		
		
		public virtual   void setHeight(int height){
			unchecked {
				this._height = height;
				this.recreateImage();
			}
		}
		
		
		public virtual   global::System.Drawing.Bitmap getImage(){
			unchecked {
				return this._image;
			}
		}
		
		
		public virtual   void recreateImage(){
			unchecked {
				global::System.Drawing.Bitmap newImage = new global::System.Drawing.Bitmap(((int) (this._width) ), ((int) (this._height) ), ((global::System.Drawing.Imaging.PixelFormat) (global::System.Drawing.Imaging.PixelFormat.Format32bppArgb) ));
				global::System.Drawing.Graphics newGraphics = global::System.Drawing.Graphics.FromImage(newImage);
				newGraphics.SmoothingMode = global::System.Drawing.Drawing2D.SmoothingMode.HighQuality;
				newGraphics.TextRenderingHint = global::System.Drawing.Text.TextRenderingHint.AntiAlias;
				newGraphics.Clear(global::System.Drawing.Color.Transparent);
				this._image.Dispose();
				this._graphics.Dispose();
				this._image = newImage;
				this._graphics = newGraphics;
			}
		}
		
		
		public  global::System.Drawing.SolidBrush _brush;
		
		public  global::System.Drawing.Pen _pen;
		
		public  global::System.Drawing.Color _color;
		
		public virtual   void setColor(global::alphatab.platform.model.Color color){
			unchecked {
				this._color = global::System.Drawing.Color.FromArgb(color.getA(), color.getR(), color.getG(), color.getB());
				this.recreateBrush();
				this.recreatePen();
			}
		}
		
		
		public virtual   void recreateBrush(){
			unchecked {
				global::System.Drawing.SolidBrush newBrush = new global::System.Drawing.SolidBrush(((global::System.Drawing.Color) (this._color) ));
				if (( this._brush != default(global::System.Drawing.SolidBrush) )) {
					this._brush.Dispose();
				}
				
				this._brush = newBrush;
			}
		}
		
		
		public virtual   void recreatePen(){
			unchecked {
				global::System.Drawing.Pen newPen = new global::System.Drawing.Pen(((global::System.Drawing.Color) (this._color) ), ((float) (this._lineWidth) ));
				if (( this._pen != default(global::System.Drawing.Pen) )) {
					this._pen.Dispose();
				}
				
				this._pen = newPen;
			}
		}
		
		
		public  double _lineWidth;
		
		public virtual   void setLineWidth(double @value){
			unchecked {
				this._lineWidth = @value;
				this.recreatePen();
			}
		}
		
		
		public virtual   void clear(){
			unchecked {
				this._graphics.Clear(global::System.Drawing.Color.Transparent);
			}
		}
		
		
		public virtual   void fillRect(double x, double y, double w, double h){
			unchecked {
				this._graphics.FillRectangle(this._brush, ((float) (x) ), ((float) (y) ), ((float) (w) ), ((float) (h) ));
			}
		}
		
		
		public virtual   void strokeRect(double x, double y, double w, double h){
			unchecked {
				this._graphics.DrawRectangle(this._pen, ((float) (x) ), ((float) (y) ), ((float) (w) ), ((float) (h) ));
			}
		}
		
		
		public virtual   void beginPath(){
			unchecked {
				this._currentPath.StartFigure();
			}
		}
		
		
		public virtual   void closePath(){
			unchecked {
				this._currentPath.CloseFigure();
			}
		}
		
		
		public virtual   void moveTo(double x, double y){
			unchecked {
				this._currentX = ((float) (x) );
				this._currentY = ((float) (y) );
			}
		}
		
		
		public virtual   void lineTo(double x, double y){
			unchecked {
				this._currentPath.AddLine(this._currentX, this._currentY, ((float) (x) ), ((float) (y) ));
				this._currentX = ((float) (x) );
				this._currentY = ((float) (y) );
			}
		}
		
		
		public virtual   void quadraticCurveTo(double cpx, double cpy, double x, double y){
			unchecked {
				this._currentPath.AddBezier(this._currentX, this._currentY, ((float) (cpx) ), ((float) (cpy) ), ((float) (cpx) ), ((float) (cpy) ), ((float) (x) ), ((float) (y) ));
				this._currentX = ((float) (x) );
				this._currentY = ((float) (y) );
			}
		}
		
		
		public virtual   void bezierCurveTo(double cp1x, double cp1y, double cp2x, double cp2y, double x, double y){
			unchecked {
				this._currentPath.AddBezier(this._currentX, this._currentY, ((float) (cp1x) ), ((float) (cp1y) ), ((float) (cp2x) ), ((float) (cp2y) ), ((float) (x) ), ((float) (y) ));
				this._currentX = ((float) (x) );
				this._currentY = ((float) (y) );
			}
		}
		
		
		public virtual   void circle(double x, double y, double radius){
			unchecked {
				this._currentPath.StartFigure();
				this._currentPath.AddEllipse(((float) (( x - radius )) ), ((float) (( y - radius )) ), ((float) (( radius * 2 )) ), ((float) (( radius * 2 )) ));
				this._currentPath.CloseFigure();
				this._currentX = ((float) (x) );
				this._currentY = ((float) (y) );
			}
		}
		
		
		public virtual   void rect(double x, double y, double w, double h){
			unchecked {
				this._currentPath.StartFigure();
				this._currentPath.AddRectangle(new global::System.Drawing.RectangleF(((float) (x) ), ((float) (y) ), ((float) (w) ), ((float) (h) )));
				this._currentPath.CloseFigure();
				this._currentX = ((float) (x) );
				this._currentY = ((float) (y) );
			}
		}
		
		
		public virtual   void fill(){
			unchecked {
				this._graphics.FillPath(this._brush, this._currentPath);
				this._currentPath.Dispose();
				this._currentPath = new global::System.Drawing.Drawing2D.GraphicsPath(((global::System.Drawing.Drawing2D.FillMode) (global::System.Drawing.Drawing2D.FillMode.Winding) ));
			}
		}
		
		
		public virtual   void stroke(){
			unchecked {
				this._graphics.DrawPath(this._pen, this._currentPath);
				this._currentPath.Dispose();
				this._currentPath = new global::System.Drawing.Drawing2D.GraphicsPath(((global::System.Drawing.Drawing2D.FillMode) (global::System.Drawing.Drawing2D.FillMode.Winding) ));
			}
		}
		
		
		public  double _fontSize;
		
		public  global::System.Drawing.Font _font;
		
		public virtual   void setFont(global::alphatab.platform.model.Font font){
			unchecked {
				global::System.Drawing.FontStyle fontStyle = global::System.Drawing.FontStyle.Regular;
				if (( (( font.getStyle() & 1 )) != 0 )) {
					fontStyle |= System.Drawing.FontStyle.Bold;
				}
				
				if (( (( font.getStyle() & 2 )) != 0 )) {
					fontStyle |= System.Drawing.FontStyle.Italic;
				}
				
				this._fontSize = font.getSize();
				this._font = new global::System.Drawing.Font(((string) (font.getFamily()) ), ((float) (font.getSize()) ), ((global::System.Drawing.FontStyle) (fontStyle) ), ((global::System.Drawing.GraphicsUnit) (global::System.Drawing.GraphicsUnit.Pixel) ));
			}
		}
		
		
		public  global::alphatab.platform.model.TextAlign _textAlign;
		
		public  global::System.Drawing.StringFormat _stringFormat;
		
		public virtual   global::alphatab.platform.model.TextAlign getTextAlign(){
			unchecked {
				return this._textAlign;
			}
		}
		
		
		public virtual   void setTextAlign(global::alphatab.platform.model.TextAlign textAlign){
			unchecked {
				this._textAlign = textAlign;
				switch (global::haxe.root.Type.enumIndex(textAlign)){
					case 0:
					{
						this._stringFormat.Alignment = global::System.Drawing.StringAlignment.Near;
						break;
					}
					
					
					case 1:
					{
						this._stringFormat.Alignment = global::System.Drawing.StringAlignment.Center;
						break;
					}
					
					
					case 2:
					{
						this._stringFormat.Alignment = global::System.Drawing.StringAlignment.Far;
						break;
					}
					
					
				}
				
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
				switch (global::haxe.root.Type.enumIndex(textBaseline)){
					case 1:
					{
						this._stringFormat.LineAlignment = global::System.Drawing.StringAlignment.Near;
						break;
					}
					
					
					case 2:
					{
						this._stringFormat.LineAlignment = global::System.Drawing.StringAlignment.Center;
						break;
					}
					
					
					case 3:
					{
						this._stringFormat.LineAlignment = global::System.Drawing.StringAlignment.Far;
						break;
					}
					
					
					default:
					{
						this._stringFormat.LineAlignment = global::System.Drawing.StringAlignment.Near;
						break;
					}
					
				}
				
			}
		}
		
		
		public virtual   void fillText(string text, double x, double y){
			unchecked {
				this._graphics.DrawString(text, this._font, this._brush, new global::System.Drawing.PointF(((float) (x) ), ((float) (y) )), this._stringFormat);
			}
		}
		
		
		public virtual   double measureText(string text){
			unchecked {
				return ((double) (this._graphics.MeasureString(text, this._font).Width) );
			}
		}
		
		
		public override   double __hx_setField_f(string field, int hash, double @value, bool handleProperties){
			unchecked {
				switch (hash){
					case 375895439:
					{
						this._fontSize = ((double) (@value) );
						return @value;
					}
					
					
					case 1828730163:
					{
						this._lineWidth = ((double) (@value) );
						return @value;
					}
					
					
					case 1658522975:
					{
						this._currentY = ((float) (@value) );
						return @value;
					}
					
					
					case 1658522974:
					{
						this._currentX = ((float) (@value) );
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
					
					
					case 2002104775:
					{
						this._stringFormat = ((global::System.Drawing.StringFormat) (@value) );
						return @value;
					}
					
					
					case 371286681:
					{
						this._textAlign = ((global::alphatab.platform.model.TextAlign) (@value) );
						return @value;
					}
					
					
					case 1993439662:
					{
						this._font = ((global::System.Drawing.Font) (@value) );
						return @value;
					}
					
					
					case 375895439:
					{
						this._fontSize = ((double) (global::haxe.lang.Runtime.toDouble(@value)) );
						return @value;
					}
					
					
					case 1828730163:
					{
						this._lineWidth = ((double) (global::haxe.lang.Runtime.toDouble(@value)) );
						return @value;
					}
					
					
					case 1178843300:
					{
						this._color = ((global::System.Drawing.Color) (@value) );
						return @value;
					}
					
					
					case 1059101146:
					{
						this._pen = ((global::System.Drawing.Pen) (@value) );
						return @value;
					}
					
					
					case 887070651:
					{
						this._brush = ((global::System.Drawing.SolidBrush) (@value) );
						return @value;
					}
					
					
					case 1658522975:
					{
						this._currentY = ((float) (global::haxe.lang.Runtime.toDouble(@value)) );
						return @value;
					}
					
					
					case 1658522974:
					{
						this._currentX = ((float) (global::haxe.lang.Runtime.toDouble(@value)) );
						return @value;
					}
					
					
					case 1760390271:
					{
						this._currentPath = ((global::System.Drawing.Drawing2D.GraphicsPath) (@value) );
						return @value;
					}
					
					
					case 1509814314:
					{
						this._graphics = ((global::System.Drawing.Graphics) (@value) );
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
					
					
					case 961570460:
					{
						this._image = ((global::System.Drawing.Bitmap) (@value) );
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
					
					
					case 2002104775:
					{
						return this._stringFormat;
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
					
					
					case 375895439:
					{
						return this._fontSize;
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
					
					
					case 173029674:
					{
						return ((global::haxe.lang.Function) (new global::haxe.lang.Closure(((object) (this) ), ((string) ("recreatePen") ), ((int) (173029674) ))) );
					}
					
					
					case 1655812875:
					{
						return ((global::haxe.lang.Function) (new global::haxe.lang.Closure(((object) (this) ), ((string) ("recreateBrush") ), ((int) (1655812875) ))) );
					}
					
					
					case 1485888097:
					{
						return ((global::haxe.lang.Function) (new global::haxe.lang.Closure(((object) (this) ), ((string) ("setColor") ), ((int) (1485888097) ))) );
					}
					
					
					case 1178843300:
					{
						return this._color;
					}
					
					
					case 1059101146:
					{
						return this._pen;
					}
					
					
					case 887070651:
					{
						return this._brush;
					}
					
					
					case 1730312684:
					{
						return ((global::haxe.lang.Function) (new global::haxe.lang.Closure(((object) (this) ), ((string) ("recreateImage") ), ((int) (1730312684) ))) );
					}
					
					
					case 490745573:
					{
						return ((global::haxe.lang.Function) (new global::haxe.lang.Closure(((object) (this) ), ((string) ("getImage") ), ((int) (490745573) ))) );
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
					
					
					case 1658522975:
					{
						return this._currentY;
					}
					
					
					case 1658522974:
					{
						return this._currentX;
					}
					
					
					case 1760390271:
					{
						return this._currentPath;
					}
					
					
					case 1509814314:
					{
						return this._graphics;
					}
					
					
					case 1891834246:
					{
						return this._height;
					}
					
					
					case 1179254087:
					{
						return this._width;
					}
					
					
					case 961570460:
					{
						return this._image;
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
					case 375895439:
					{
						return this._fontSize;
					}
					
					
					case 1828730163:
					{
						return this._lineWidth;
					}
					
					
					case 1658522975:
					{
						return ((double) (this._currentY) );
					}
					
					
					case 1658522974:
					{
						return ((double) (this._currentX) );
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
					
					
					case 173029674:
					{
						this.recreatePen();
						break;
					}
					
					
					case 1655812875:
					{
						this.recreateBrush();
						break;
					}
					
					
					case 1485888097:
					{
						this.setColor(((global::alphatab.platform.model.Color) (dynargs[0]) ));
						break;
					}
					
					
					case 1730312684:
					{
						this.recreateImage();
						break;
					}
					
					
					case 490745573:
					{
						return this.getImage();
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
				baseArr.push("_stringFormat");
				baseArr.push("_textAlign");
				baseArr.push("_font");
				baseArr.push("_fontSize");
				baseArr.push("_lineWidth");
				baseArr.push("_color");
				baseArr.push("_pen");
				baseArr.push("_brush");
				baseArr.push("_currentY");
				baseArr.push("_currentX");
				baseArr.push("_currentPath");
				baseArr.push("_graphics");
				baseArr.push("_height");
				baseArr.push("_width");
				baseArr.push("_image");
				{
					base.__hx_getFields(baseArr);
				}
				
			}
		}
		
		
	}
}


