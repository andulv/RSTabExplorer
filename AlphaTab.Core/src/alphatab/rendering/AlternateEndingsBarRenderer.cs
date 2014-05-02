using haxe.root;
#pragma warning disable 109, 114, 219, 429, 168, 162
namespace alphatab.rendering{
	public  class AlternateEndingsBarRenderer : global::alphatab.rendering.BarRendererBase {
		static AlternateEndingsBarRenderer() {
			global::alphatab.rendering.AlternateEndingsBarRenderer.Padding = 3;
		}
		public    AlternateEndingsBarRenderer(global::haxe.lang.EmptyObject empty) : base(((global::haxe.lang.EmptyObject) (global::haxe.lang.EmptyObject.EMPTY) )){
			unchecked {
			}
		}
		
		
		public    AlternateEndingsBarRenderer(global::alphatab.model.Bar bar) : base(((global::haxe.lang.EmptyObject) (global::haxe.lang.EmptyObject.EMPTY) )){
			unchecked {
				global::alphatab.rendering.AlternateEndingsBarRenderer.__hx_ctor_alphatab_rendering_AlternateEndingsBarRenderer(this, bar);
			}
		}
		
		
		public static   void __hx_ctor_alphatab_rendering_AlternateEndingsBarRenderer(global::alphatab.rendering.AlternateEndingsBarRenderer __temp_me105, global::alphatab.model.Bar bar){
			unchecked {
				global::alphatab.rendering.BarRendererBase.__hx_ctor_alphatab_rendering_BarRendererBase(__temp_me105, bar);
				int alternateEndings = ((global::alphatab.model.MasterBar) (bar.track.score.masterBars[bar.index]) ).alternateEndings;
				__temp_me105._endings = new global::haxe.root.Array<int>();
				{
					int _g = 0;
					while (( _g < 8 )){
						int i = _g++;
						if (( (( alternateEndings & ( 1 << i ) )) != 0 )) {
							__temp_me105._endings.push(i);
						}
						
					}
					
				}
				
			}
		}
		
		
		public static  int Padding;
		
		public static  new object __hx_createEmpty(){
			unchecked {
				return new global::alphatab.rendering.AlternateEndingsBarRenderer(((global::haxe.lang.EmptyObject) (global::haxe.lang.EmptyObject.EMPTY) ));
			}
		}
		
		
		public static  new object __hx_create(global::haxe.root.Array arr){
			unchecked {
				return new global::alphatab.rendering.AlternateEndingsBarRenderer(((global::alphatab.model.Bar) (arr[0]) ));
			}
		}
		
		
		public  global::haxe.root.Array<int> _endings;
		
		public  string _endingsString;
		
		public override   void finalizeRenderer(global::alphatab.rendering.layout.ScoreLayout layout){
			unchecked {
				base.finalizeRenderer(layout);
				this.isEmpty = ( this._endings.length == 0 );
			}
		}
		
		
		public override   void doLayout(){
			unchecked {
				base.doLayout();
				if (( this.index == 0 )) {
					this.stave.topSpacing = 5;
					this.stave.bottomSpacing = 5;
				}
				
				{
					double x = this.stave.staveGroup.layout.renderer.renderingResources.wordsFont.getSize();
					this.height = ((int) (x) );
				}
				
				global::haxe.root.StringBuf endingsString = new global::haxe.root.StringBuf();
				{
					int _g = 0;
					global::haxe.root.Array<int> _g1 = this._endings;
					while (( _g < _g1.length )){
						int e = _g1[_g];
						 ++ _g;
						endingsString.b.Append(((object) (global::haxe.root.Std.@string(( e + 1 ))) ));
						endingsString.b.Append(((object) (". ") ));
					}
					
				}
				
				this._endingsString = endingsString.toString();
			}
		}
		
		
		public override   int getTopPadding(){
			unchecked {
				return 0;
			}
		}
		
		
		public override   int getBottomPadding(){
			unchecked {
				return 0;
			}
		}
		
		
		public override   void applySizes(global::alphatab.rendering.staves.BarSizeInfo sizes){
			unchecked {
				base.applySizes(sizes);
				this.width = sizes.fullWidth;
			}
		}
		
		
		public override   void paint(int cx, int cy, global::alphatab.platform.ICanvas canvas){
			unchecked {
				if (( this._endings.length > 0 )) {
					global::alphatab.rendering.RenderingResources res = this.stave.staveGroup.layout.renderer.renderingResources;
					canvas.setColor(res.mainGlyphColor);
					canvas.setFont(res.wordsFont);
					canvas.moveTo(((double) (( cx + this.x )) ), ((double) (( ( cy + this.y ) + this.height )) ));
					canvas.lineTo(((double) (( cx + this.x )) ), ((double) (( cy + this.y )) ));
					canvas.lineTo(((double) (( ( cx + this.x ) + this.width )) ), ((double) (( cy + this.y )) ));
					canvas.stroke();
					canvas.fillText(this._endingsString, ((double) (((int) (( ( cx + this.x ) + ( 3 * this.stave.staveGroup.layout.renderer.settings.scale ) )) )) ), ((double) (((int) (( cy + ( this.y * this.stave.staveGroup.layout.renderer.settings.scale ) )) )) ));
				}
				
			}
		}
		
		
		public override   object __hx_setField(string field, int hash, object @value, bool handleProperties){
			unchecked {
				switch (hash){
					case 1407294686:
					{
						this._endingsString = global::haxe.lang.Runtime.toString(@value);
						return @value;
					}
					
					
					case 1992237101:
					{
						this._endings = ((global::haxe.root.Array<int>) (global::haxe.root.Array<object>.__hx_cast<int>(((global::haxe.root.Array) (@value) ))) );
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
					
					
					case 673875012:
					{
						return ((global::haxe.lang.Function) (new global::haxe.lang.Closure(((object) (this) ), ((string) ("applySizes") ), ((int) (673875012) ))) );
					}
					
					
					case 357418928:
					{
						return ((global::haxe.lang.Function) (new global::haxe.lang.Closure(((object) (this) ), ((string) ("getBottomPadding") ), ((int) (357418928) ))) );
					}
					
					
					case 415081458:
					{
						return ((global::haxe.lang.Function) (new global::haxe.lang.Closure(((object) (this) ), ((string) ("getTopPadding") ), ((int) (415081458) ))) );
					}
					
					
					case 1825584277:
					{
						return ((global::haxe.lang.Function) (new global::haxe.lang.Closure(((object) (this) ), ((string) ("doLayout") ), ((int) (1825584277) ))) );
					}
					
					
					case 236164353:
					{
						return ((global::haxe.lang.Function) (new global::haxe.lang.Closure(((object) (this) ), ((string) ("finalizeRenderer") ), ((int) (236164353) ))) );
					}
					
					
					case 1407294686:
					{
						return this._endingsString;
					}
					
					
					case 1992237101:
					{
						return this._endings;
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
				baseArr.push("_endingsString");
				baseArr.push("_endings");
				{
					base.__hx_getFields(baseArr);
				}
				
			}
		}
		
		
	}
}


