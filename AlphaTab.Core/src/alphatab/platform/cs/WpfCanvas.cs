using haxe.root;
#pragma warning disable 109, 114, 219, 429, 168, 162
namespace alphatab.platform.cs{
	public  class WpfCanvas : global::haxe.lang.HxObject, global::alphatab.platform.ICanvas {
		public    WpfCanvas(global::haxe.lang.EmptyObject empty){
			unchecked {
				{
				}
				
			}
		}
		
		
		public    WpfCanvas(object canvas){
			unchecked {
				global::alphatab.platform.cs.WpfCanvas.__hx_ctor_alphatab_platform_cs_WpfCanvas(this, canvas);
			}
		}
		
		
		public static   void __hx_ctor_alphatab_platform_cs_WpfCanvas(global::alphatab.platform.cs.WpfCanvas __temp_me20, object canvas){
			unchecked {
				__temp_me20.setCanvas(((global::System.Windows.Controls.Canvas) (canvas) ));
			}
		}
		
		
		public static  new object __hx_createEmpty(){
			unchecked {
				return new global::alphatab.platform.cs.WpfCanvas(((global::haxe.lang.EmptyObject) (global::haxe.lang.EmptyObject.EMPTY) ));
			}
		}
		
		
		public static  new object __hx_create(global::haxe.root.Array arr){
			unchecked {
				return new global::alphatab.platform.cs.WpfCanvas(((object) (arr[0]) ));
			}
		}
		
		
		public  global::haxe.root.StringBuf _currentPath;
		
		public  bool _currentPathIsEmpty;
		
		public  global::System.Windows.Controls.Canvas _canvas;
		
		public virtual   void setCanvas(global::System.Windows.Controls.Canvas canvas){
			unchecked {
				this._canvas = canvas;
				this._currentPath = new global::haxe.root.StringBuf();
				this._currentPathIsEmpty = true;
				this._lineWidth = ((double) (1) );
				this._font = new global::alphatab.platform.model.Font(((string) ("sans-serif") ), ((double) (10) ), ((global::haxe.lang.Null<int>) (default(global::haxe.lang.Null<int>)) ));
				this._textAlign = global::alphatab.platform.model.TextAlign.Left;
				this._textBaseline = global::alphatab.model.TextBaseline.Default;
				this.setColor(new global::alphatab.platform.model.Color(((int) (255) ), ((int) (255) ), ((int) (255) ), ((global::haxe.lang.Null<int>) (default(global::haxe.lang.Null<int>)) )));
			}
		}
		
		
		public virtual   int getWidth(){
			unchecked {
				return ((int) (this._canvas.Width) );
			}
		}
		
		
		public virtual   int getHeight(){
			unchecked {
				return ((int) (this._canvas.Height) );
			}
		}
		
		
		public virtual   void setWidth(int width){
			unchecked {
				this._canvas.Width = ((double) (width) );
			}
		}
		
		
		public virtual   void setHeight(int height){
			unchecked {
				this._canvas.Height = ((double) (height) );
			}
		}
		
		
		public  global::System.Windows.Media.SolidColorBrush _brush;
		
		public virtual   void setColor(global::alphatab.platform.model.Color color){
			unchecked {
				this._brush = new global::System.Windows.Media.SolidColorBrush(((global::System.Windows.Media.Color) (global::System.Windows.Media.Color.FromArgb(((byte) (color.getA()) ), ((byte) (color.getR()) ), ((byte) (color.getG()) ), ((byte) (color.getB()) ))) ));
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
				this._canvas.Children.Clear();
				this._currentPath = new global::haxe.root.StringBuf();
				this._currentPathIsEmpty = true;
			}
		}
		
		
		public virtual   void fillRect(double x, double y, double w, double h){
			unchecked {
				global::System.Windows.Shapes.Rectangle rectangle = new global::System.Windows.Shapes.Rectangle();
				rectangle.Fill = this._brush;
				rectangle.Width = w;
				rectangle.Height = h;
				global::System.Windows.Controls.Canvas.SetLeft(rectangle, x);
				global::System.Windows.Controls.Canvas.SetTop(rectangle, y);
				this._canvas.Children.Add(rectangle);
			}
		}
		
		
		public virtual   void strokeRect(double x, double y, double w, double h){
			unchecked {
				global::System.Windows.Shapes.Rectangle rectangle = new global::System.Windows.Shapes.Rectangle();
				rectangle.Stroke = this._brush;
				rectangle.StrokeThickness = this._lineWidth;
				rectangle.Width = w;
				rectangle.Height = h;
				global::System.Windows.Controls.Canvas.SetLeft(rectangle, x);
				global::System.Windows.Controls.Canvas.SetTop(rectangle, y);
				this._canvas.Children.Add(rectangle);
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
				this._currentPath.b.Append(((object) (" z") ));
			}
		}
		
		
		public virtual   void moveTo(double x, double y){
			unchecked {
				this._currentPath.b.Append(((object) (" M ") ));
				this._currentPath.b.Append(((object) (global::haxe.root.Std.@string(x)) ));
				this._currentPath.b.Append(((object) (",") ));
				this._currentPath.b.Append(((object) (global::haxe.root.Std.@string(y)) ));
			}
		}
		
		
		public virtual   void lineTo(double x, double y){
			unchecked {
				this._currentPathIsEmpty = false;
				this._currentPath.b.Append(((object) (" L ") ));
				this._currentPath.b.Append(((object) (global::haxe.root.Std.@string(x)) ));
				this._currentPath.b.Append(((object) (",") ));
				this._currentPath.b.Append(((object) (global::haxe.root.Std.@string(y)) ));
			}
		}
		
		
		public virtual   void quadraticCurveTo(double cpx, double cpy, double x, double y){
			unchecked {
				this._currentPathIsEmpty = false;
				this._currentPath.b.Append(((object) (" Q ") ));
				this._currentPath.b.Append(((object) (global::haxe.root.Std.@string(cpx)) ));
				this._currentPath.b.Append(((object) (",") ));
				this._currentPath.b.Append(((object) (global::haxe.root.Std.@string(cpy)) ));
				this._currentPath.b.Append(((object) (",") ));
				this._currentPath.b.Append(((object) (global::haxe.root.Std.@string(x)) ));
				this._currentPath.b.Append(((object) (",") ));
				this._currentPath.b.Append(((object) (global::haxe.root.Std.@string(y)) ));
			}
		}
		
		
		public virtual   void bezierCurveTo(double cp1x, double cp1y, double cp2x, double cp2y, double x, double y){
			unchecked {
				this._currentPathIsEmpty = false;
				this._currentPath.b.Append(((object) (" C ") ));
				this._currentPath.b.Append(((object) (global::haxe.root.Std.@string(cp1x)) ));
				this._currentPath.b.Append(((object) (",") ));
				this._currentPath.b.Append(((object) (global::haxe.root.Std.@string(cp1y)) ));
				this._currentPath.b.Append(((object) (",") ));
				this._currentPath.b.Append(((object) (global::haxe.root.Std.@string(cp2x)) ));
				this._currentPath.b.Append(((object) (",") ));
				this._currentPath.b.Append(((object) (global::haxe.root.Std.@string(cp2y)) ));
				this._currentPath.b.Append(((object) (",") ));
				this._currentPath.b.Append(((object) (global::haxe.root.Std.@string(x)) ));
				this._currentPath.b.Append(((object) (",") ));
				this._currentPath.b.Append(((object) (global::haxe.root.Std.@string(y)) ));
			}
		}
		
		
		public virtual   void circle(double x, double y, double radius){
			unchecked {
				this._currentPathIsEmpty = false;
				this._currentPath.b.Append(((object) (" M ") ));
				this._currentPath.b.Append(((object) (global::haxe.root.Std.@string(( x - radius ))) ));
				this._currentPath.b.Append(((object) (",") ));
				this._currentPath.b.Append(((object) (global::haxe.root.Std.@string(y)) ));
				this._currentPath.b.Append(((object) (" A 1,1 0 0,0 ") ));
				this._currentPath.b.Append(((object) (global::haxe.root.Std.@string(( x + radius ))) ));
				this._currentPath.b.Append(((object) (",") ));
				this._currentPath.b.Append(((object) (global::haxe.root.Std.@string(y)) ));
				this._currentPath.b.Append(((object) (" A 1,1 0 0,0 ") ));
				this._currentPath.b.Append(((object) (global::haxe.root.Std.@string(( x - radius ))) ));
				this._currentPath.b.Append(((object) (",") ));
				this._currentPath.b.Append(((object) (global::haxe.root.Std.@string(y)) ));
				this._currentPath.b.Append(((object) (" z") ));
			}
		}
		
		
		public virtual   void rect(double x, double y, double w, double h){
			unchecked {
				this._currentPathIsEmpty = false;
				this._currentPath.b.Append(((object) (" M ") ));
				this._currentPath.b.Append(((object) (global::haxe.root.Std.@string(x)) ));
				this._currentPath.b.Append(((object) (",") ));
				this._currentPath.b.Append(((object) (global::haxe.root.Std.@string(y)) ));
				this._currentPath.b.Append(((object) (" L ") ));
				this._currentPath.b.Append(((object) (global::haxe.root.Std.@string(( x + w ))) ));
				this._currentPath.b.Append(((object) (",") ));
				this._currentPath.b.Append(((object) (global::haxe.root.Std.@string(y)) ));
				this._currentPath.b.Append(((object) (" ") ));
				this._currentPath.b.Append(((object) (global::haxe.root.Std.@string(( x + w ))) ));
				this._currentPath.b.Append(((object) (",") ));
				this._currentPath.b.Append(((object) (global::haxe.root.Std.@string(( y + h ))) ));
				this._currentPath.b.Append(((object) (" ") ));
				this._currentPath.b.Append(((object) (global::haxe.root.Std.@string(x)) ));
				this._currentPath.b.Append(((object) (",") ));
				this._currentPath.b.Append(((object) (global::haxe.root.Std.@string(( y + h ))) ));
				this._currentPath.b.Append(((object) (" z") ));
			}
		}
		
		
		public virtual   void fill(){
			unchecked {
				if ( ! (this._currentPathIsEmpty) ) {
					global::System.Windows.Shapes.Path wpfPath = new global::System.Windows.Shapes.Path();
					wpfPath.Fill = this._brush;
					wpfPath.Data = global::System.Windows.Media.Geometry.Parse(this._currentPath.toString());
					this._canvas.Children.Add(wpfPath);
				}
				
				this._currentPath = new global::haxe.root.StringBuf();
				this._currentPathIsEmpty = true;
			}
		}
		
		
		public virtual   void stroke(){
			unchecked {
				string path = this._currentPath.toString();
				if ( ! (this._currentPathIsEmpty) ) {
					global::System.Windows.Shapes.Path wpfPath = new global::System.Windows.Shapes.Path();
					wpfPath.Stroke = this._brush;
					wpfPath.StrokeThickness = this._lineWidth;
					wpfPath.Data = global::System.Windows.Media.Geometry.Parse(this._currentPath.toString());
					this._canvas.Children.Add(wpfPath);
				}
				
				this._currentPath = new global::haxe.root.StringBuf();
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
				global::System.Windows.Controls.TextBlock textBlock = new global::System.Windows.Controls.TextBlock();
				textBlock.Text = text;
				textBlock.Foreground = this._brush;
				textBlock.FontFamily = new global::System.Windows.Media.FontFamily(((string) (this._font.getFamily()) ));
				textBlock.FontSize = this._font.getSize();
				if (( (( this._font.getStyle() & 2 )) != 0 )) {
					textBlock.FontStyle = global::System.Windows.FontStyles.Italic;
				}
				
				if (( (( this._font.getStyle() & 1 )) != 0 )) {
					textBlock.FontWeight = global::System.Windows.FontWeights.Bold;
				}
				
				global::AlphaTab.Utils.AlignmentHelper.SetAlignment(textBlock, this._textAlign);
				global::AlphaTab.Utils.AlignmentHelper.SetLineAlignment(textBlock, this._textBaseline);
				global::System.Windows.Controls.Canvas.SetLeft(textBlock, x);
				global::System.Windows.Controls.Canvas.SetTop(textBlock, y);
				this._canvas.Children.Add(textBlock);
			}
		}
		
		
		public virtual   double measureText(string text){
			unchecked {
				if (( string.Equals(text, default(string)) || ( text.Length == 0 ) )) {
					return ((double) (0) );
				}
				
				return global::AlphaTab.Utils.MeasureUtil.MeasureText(text, this._font);
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
					
					
					case 887070651:
					{
						this._brush = ((global::System.Windows.Media.SolidColorBrush) (@value) );
						return @value;
					}
					
					
					case 649684599:
					{
						this._canvas = ((global::System.Windows.Controls.Canvas) (@value) );
						return @value;
					}
					
					
					case 1083160452:
					{
						this._currentPathIsEmpty = global::haxe.lang.Runtime.toBool(@value);
						return @value;
					}
					
					
					case 1760390271:
					{
						this._currentPath = ((global::haxe.root.StringBuf) (@value) );
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
					
					
					case 887070651:
					{
						return this._brush;
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
					
					
					case 401197594:
					{
						return ((global::haxe.lang.Function) (new global::haxe.lang.Closure(((object) (this) ), ((string) ("setCanvas") ), ((int) (401197594) ))) );
					}
					
					
					case 649684599:
					{
						return this._canvas;
					}
					
					
					case 1083160452:
					{
						return this._currentPathIsEmpty;
					}
					
					
					case 1760390271:
					{
						return this._currentPath;
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
					
					
					case 401197594:
					{
						this.setCanvas(((global::System.Windows.Controls.Canvas) (dynargs[0]) ));
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
				baseArr.push("_brush");
				baseArr.push("_canvas");
				baseArr.push("_currentPathIsEmpty");
				baseArr.push("_currentPath");
				{
					base.__hx_getFields(baseArr);
				}
				
			}
		}
		
		
	}
}


