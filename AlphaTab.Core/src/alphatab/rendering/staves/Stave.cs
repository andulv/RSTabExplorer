using haxe.root;
#pragma warning disable 109, 114, 219, 429, 168, 162
namespace alphatab.rendering.staves{
	public  class Stave : global::haxe.lang.HxObject {
		public    Stave(global::haxe.lang.EmptyObject empty){
			unchecked {
				{
				}
				
			}
		}
		
		
		public    Stave(global::alphatab.rendering.BarRendererFactory barRendererFactory){
			unchecked {
				global::alphatab.rendering.staves.Stave.__hx_ctor_alphatab_rendering_staves_Stave(this, barRendererFactory);
			}
		}
		
		
		public static   void __hx_ctor_alphatab_rendering_staves_Stave(global::alphatab.rendering.staves.Stave __temp_me280, global::alphatab.rendering.BarRendererFactory barRendererFactory){
			unchecked {
				__temp_me280.barRenderers = new global::haxe.root.Array<object>();
				__temp_me280._factory = barRendererFactory;
				__temp_me280.topSpacing = 10;
				__temp_me280.bottomSpacing = 10;
				__temp_me280.staveTop = 0;
				__temp_me280.staveBottom = 0;
			}
		}
		
		
		public static  new object __hx_createEmpty(){
			unchecked {
				return new global::alphatab.rendering.staves.Stave(((global::haxe.lang.EmptyObject) (global::haxe.lang.EmptyObject.EMPTY) ));
			}
		}
		
		
		public static  new object __hx_create(global::haxe.root.Array arr){
			unchecked {
				return new global::alphatab.rendering.staves.Stave(((global::alphatab.rendering.BarRendererFactory) (arr[0]) ));
			}
		}
		
		
		public  global::alphatab.rendering.staves.StaveTrackGroup staveTrackGroup;
		
		public  global::alphatab.rendering.staves.StaveGroup staveGroup;
		
		public  global::alphatab.rendering.BarRendererFactory _factory;
		
		public  global::haxe.root.Array<object> barRenderers;
		
		public  int x;
		
		public  int y;
		
		public  int height;
		
		public  int index;
		
		public  int staveTop;
		
		public  int topSpacing;
		
		public  int bottomSpacing;
		
		public  int staveBottom;
		
		public  bool isFirstInAccolade;
		
		public  bool isLastInAccolade;
		
		public   bool isInAccolade(){
			unchecked {
				return this._factory.isInAccolade;
			}
		}
		
		
		public virtual   void registerStaveTop(int offset){
			unchecked {
				this.staveTop = offset;
			}
		}
		
		
		public virtual   void registerStaveBottom(int offset){
			unchecked {
				this.staveBottom = offset;
			}
		}
		
		
		public virtual   void addBar(global::alphatab.model.Bar bar){
			unchecked {
				global::alphatab.rendering.BarRendererBase renderer = this._factory.create(bar);
				renderer.stave = this;
				renderer.index = this.barRenderers.length;
				renderer.doLayout();
				this.barRenderers.push(renderer);
			}
		}
		
		
		public virtual   void revertLastBar(){
			unchecked {
				this.barRenderers.pop();
			}
		}
		
		
		public virtual   void applyBarSpacing(int spacing){
			unchecked {
				int _g = 0;
				global::haxe.root.Array<object> _g1 = this.barRenderers;
				while (( _g < _g1.length )){
					global::alphatab.rendering.BarRendererBase b = ((global::alphatab.rendering.BarRendererBase) (_g1[_g]) );
					 ++ _g;
					b.applyBarSpacing(spacing);
				}
				
			}
		}
		
		
		public virtual   int getTopOverflow(){
			unchecked {
				int m = 0;
				{
					int _g = 0;
					global::haxe.root.Array<object> _g1 = this.barRenderers;
					while (( _g < _g1.length )){
						global::alphatab.rendering.BarRendererBase r = ((global::alphatab.rendering.BarRendererBase) (_g1[_g]) );
						 ++ _g;
						if (( r.topOverflow > m )) {
							m = r.topOverflow;
						}
						
					}
					
				}
				
				return m;
			}
		}
		
		
		public virtual   int getBottomOverflow(){
			unchecked {
				int m = 0;
				{
					int _g = 0;
					global::haxe.root.Array<object> _g1 = this.barRenderers;
					while (( _g < _g1.length )){
						global::alphatab.rendering.BarRendererBase r = ((global::alphatab.rendering.BarRendererBase) (_g1[_g]) );
						 ++ _g;
						if (( r.bottomOverflow > m )) {
							m = r.bottomOverflow;
						}
						
					}
					
				}
				
				return m;
			}
		}
		
		
		public virtual   void finalizeStave(global::alphatab.rendering.layout.ScoreLayout layout){
			unchecked {
				int x = 0;
				this.height = 0;
				int topOverflow = this.getTopOverflow();
				int bottomOverflow = this.getBottomOverflow();
				bool isEmpty = true;
				{
					int _g1 = 0;
					int _g = this.barRenderers.length;
					while (( _g1 < _g )){
						int i = _g1++;
						((global::alphatab.rendering.BarRendererBase) (this.barRenderers[i]) ).x = x;
						((global::alphatab.rendering.BarRendererBase) (this.barRenderers[i]) ).y = ( this.topSpacing + topOverflow );
						{
							double x1 = global::System.Math.Max(((double) (this.height) ), ((double) (((global::alphatab.rendering.BarRendererBase) (this.barRenderers[i]) ).height) ));
							this.height = ((int) (x1) );
						}
						
						((global::alphatab.rendering.BarRendererBase) (this.barRenderers[i]) ).finalizeRenderer(layout);
						x += ((global::alphatab.rendering.BarRendererBase) (this.barRenderers[i]) ).width;
						if ( ! (((global::alphatab.rendering.BarRendererBase) (this.barRenderers[i]) ).isEmpty) ) {
							isEmpty = false;
						}
						
					}
					
				}
				
				if ( ! (isEmpty) ) {
					this.height += ( ( ( this.topSpacing + topOverflow ) + bottomOverflow ) + this.bottomSpacing );
				}
				 else {
					this.height = 0;
				}
				
			}
		}
		
		
		public virtual   void paint(int cx, int cy, global::alphatab.platform.ICanvas canvas){
			unchecked {
				if (( this.height == 0 )) {
					return ;
				}
				
				{
					int _g = 0;
					global::haxe.root.Array<object> _g1 = this.barRenderers;
					while (( _g < _g1.length )){
						global::alphatab.rendering.BarRendererBase r = ((global::alphatab.rendering.BarRendererBase) (_g1[_g]) );
						 ++ _g;
						r.paint(( cx + this.x ), ( cy + this.y ), canvas);
					}
					
				}
				
			}
		}
		
		
		public override   double __hx_setField_f(string field, int hash, double @value, bool handleProperties){
			unchecked {
				switch (hash){
					case 1382488090:
					{
						this.staveBottom = ((int) (@value) );
						return @value;
					}
					
					
					case 1818949592:
					{
						this.bottomSpacing = ((int) (@value) );
						return @value;
					}
					
					
					case 2106138990:
					{
						this.topSpacing = ((int) (@value) );
						return @value;
					}
					
					
					case 105656838:
					{
						this.staveTop = ((int) (@value) );
						return @value;
					}
					
					
					case 1041537810:
					{
						this.index = ((int) (@value) );
						return @value;
					}
					
					
					case 38537191:
					{
						this.height = ((int) (@value) );
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
					case 553915593:
					{
						this.isLastInAccolade = global::haxe.lang.Runtime.toBool(@value);
						return @value;
					}
					
					
					case 504792271:
					{
						this.isFirstInAccolade = global::haxe.lang.Runtime.toBool(@value);
						return @value;
					}
					
					
					case 1382488090:
					{
						this.staveBottom = ((int) (global::haxe.lang.Runtime.toInt(@value)) );
						return @value;
					}
					
					
					case 1818949592:
					{
						this.bottomSpacing = ((int) (global::haxe.lang.Runtime.toInt(@value)) );
						return @value;
					}
					
					
					case 2106138990:
					{
						this.topSpacing = ((int) (global::haxe.lang.Runtime.toInt(@value)) );
						return @value;
					}
					
					
					case 105656838:
					{
						this.staveTop = ((int) (global::haxe.lang.Runtime.toInt(@value)) );
						return @value;
					}
					
					
					case 1041537810:
					{
						this.index = ((int) (global::haxe.lang.Runtime.toInt(@value)) );
						return @value;
					}
					
					
					case 38537191:
					{
						this.height = ((int) (global::haxe.lang.Runtime.toInt(@value)) );
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
					
					
					case 268153213:
					{
						this.barRenderers = ((global::haxe.root.Array<object>) (global::haxe.root.Array<object>.__hx_cast<object>(((global::haxe.root.Array) (@value) ))) );
						return @value;
					}
					
					
					case 1636857419:
					{
						this._factory = ((global::alphatab.rendering.BarRendererFactory) (@value) );
						return @value;
					}
					
					
					case 1560739056:
					{
						this.staveGroup = ((global::alphatab.rendering.staves.StaveGroup) (@value) );
						return @value;
					}
					
					
					case 1974137187:
					{
						this.staveTrackGroup = ((global::alphatab.rendering.staves.StaveTrackGroup) (@value) );
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
					
					
					case 1007125841:
					{
						return ((global::haxe.lang.Function) (new global::haxe.lang.Closure(((object) (this) ), ((string) ("finalizeStave") ), ((int) (1007125841) ))) );
					}
					
					
					case 852203651:
					{
						return ((global::haxe.lang.Function) (new global::haxe.lang.Closure(((object) (this) ), ((string) ("getBottomOverflow") ), ((int) (852203651) ))) );
					}
					
					
					case 826045953:
					{
						return ((global::haxe.lang.Function) (new global::haxe.lang.Closure(((object) (this) ), ((string) ("getTopOverflow") ), ((int) (826045953) ))) );
					}
					
					
					case 561297662:
					{
						return ((global::haxe.lang.Function) (new global::haxe.lang.Closure(((object) (this) ), ((string) ("applyBarSpacing") ), ((int) (561297662) ))) );
					}
					
					
					case 1131575193:
					{
						return ((global::haxe.lang.Function) (new global::haxe.lang.Closure(((object) (this) ), ((string) ("revertLastBar") ), ((int) (1131575193) ))) );
					}
					
					
					case 519815730:
					{
						return ((global::haxe.lang.Function) (new global::haxe.lang.Closure(((object) (this) ), ((string) ("addBar") ), ((int) (519815730) ))) );
					}
					
					
					case 175582839:
					{
						return ((global::haxe.lang.Function) (new global::haxe.lang.Closure(((object) (this) ), ((string) ("registerStaveBottom") ), ((int) (175582839) ))) );
					}
					
					
					case 84881289:
					{
						return ((global::haxe.lang.Function) (new global::haxe.lang.Closure(((object) (this) ), ((string) ("registerStaveTop") ), ((int) (84881289) ))) );
					}
					
					
					case 897413587:
					{
						return ((global::haxe.lang.Function) (new global::haxe.lang.Closure(((object) (this) ), ((string) ("isInAccolade") ), ((int) (897413587) ))) );
					}
					
					
					case 553915593:
					{
						return this.isLastInAccolade;
					}
					
					
					case 504792271:
					{
						return this.isFirstInAccolade;
					}
					
					
					case 1382488090:
					{
						return this.staveBottom;
					}
					
					
					case 1818949592:
					{
						return this.bottomSpacing;
					}
					
					
					case 2106138990:
					{
						return this.topSpacing;
					}
					
					
					case 105656838:
					{
						return this.staveTop;
					}
					
					
					case 1041537810:
					{
						return this.index;
					}
					
					
					case 38537191:
					{
						return this.height;
					}
					
					
					case 121:
					{
						return this.y;
					}
					
					
					case 120:
					{
						return this.x;
					}
					
					
					case 268153213:
					{
						return this.barRenderers;
					}
					
					
					case 1636857419:
					{
						return this._factory;
					}
					
					
					case 1560739056:
					{
						return this.staveGroup;
					}
					
					
					case 1974137187:
					{
						return this.staveTrackGroup;
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
					case 1382488090:
					{
						return ((double) (this.staveBottom) );
					}
					
					
					case 1818949592:
					{
						return ((double) (this.bottomSpacing) );
					}
					
					
					case 2106138990:
					{
						return ((double) (this.topSpacing) );
					}
					
					
					case 105656838:
					{
						return ((double) (this.staveTop) );
					}
					
					
					case 1041537810:
					{
						return ((double) (this.index) );
					}
					
					
					case 38537191:
					{
						return ((double) (this.height) );
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
					case 1028568990:
					{
						this.paint(((int) (global::haxe.lang.Runtime.toInt(dynargs[0])) ), ((int) (global::haxe.lang.Runtime.toInt(dynargs[1])) ), ((global::alphatab.platform.ICanvas) (dynargs[2]) ));
						break;
					}
					
					
					case 1007125841:
					{
						this.finalizeStave(((global::alphatab.rendering.layout.ScoreLayout) (dynargs[0]) ));
						break;
					}
					
					
					case 852203651:
					{
						return this.getBottomOverflow();
					}
					
					
					case 826045953:
					{
						return this.getTopOverflow();
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
					
					
					case 519815730:
					{
						this.addBar(((global::alphatab.model.Bar) (dynargs[0]) ));
						break;
					}
					
					
					case 175582839:
					{
						this.registerStaveBottom(((int) (global::haxe.lang.Runtime.toInt(dynargs[0])) ));
						break;
					}
					
					
					case 84881289:
					{
						this.registerStaveTop(((int) (global::haxe.lang.Runtime.toInt(dynargs[0])) ));
						break;
					}
					
					
					case 897413587:
					{
						return this.isInAccolade();
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
				baseArr.push("isLastInAccolade");
				baseArr.push("isFirstInAccolade");
				baseArr.push("staveBottom");
				baseArr.push("bottomSpacing");
				baseArr.push("topSpacing");
				baseArr.push("staveTop");
				baseArr.push("index");
				baseArr.push("height");
				baseArr.push("y");
				baseArr.push("x");
				baseArr.push("barRenderers");
				baseArr.push("_factory");
				baseArr.push("staveGroup");
				baseArr.push("staveTrackGroup");
				{
					base.__hx_getFields(baseArr);
				}
				
			}
		}
		
		
	}
}


