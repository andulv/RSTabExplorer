using haxe.root;
#pragma warning disable 109, 114, 219, 429, 168, 162
namespace alphatab.rendering.layout{
	public  class HorizontalScreenLayout : global::alphatab.rendering.layout.ScoreLayout {
		static HorizontalScreenLayout() {
			global::alphatab.rendering.layout.HorizontalScreenLayout.PagePadding = new global::haxe.root.Array<int>(new int[]{20, 20, 20, 20});
			global::alphatab.rendering.layout.HorizontalScreenLayout.GroupSpacing = 20;
		}
		public    HorizontalScreenLayout(global::haxe.lang.EmptyObject empty) : base(((global::haxe.lang.EmptyObject) (global::haxe.lang.EmptyObject.EMPTY) )){
			unchecked {
			}
		}
		
		
		public    HorizontalScreenLayout(global::alphatab.rendering.ScoreRenderer renderer) : base(((global::haxe.lang.EmptyObject) (global::haxe.lang.EmptyObject.EMPTY) )){
			unchecked {
				global::alphatab.rendering.layout.HorizontalScreenLayout.__hx_ctor_alphatab_rendering_layout_HorizontalScreenLayout(this, renderer);
			}
		}
		
		
		public static   void __hx_ctor_alphatab_rendering_layout_HorizontalScreenLayout(global::alphatab.rendering.layout.HorizontalScreenLayout __temp_me27, global::alphatab.rendering.ScoreRenderer renderer){
			unchecked {
				global::alphatab.rendering.layout.ScoreLayout.__hx_ctor_alphatab_rendering_layout_ScoreLayout(__temp_me27, renderer);
			}
		}
		
		
		public static  global::haxe.root.Array<int> PagePadding;
		
		public static  int GroupSpacing;
		
		public static  new object __hx_createEmpty(){
			unchecked {
				return new global::alphatab.rendering.layout.HorizontalScreenLayout(((global::haxe.lang.EmptyObject) (global::haxe.lang.EmptyObject.EMPTY) ));
			}
		}
		
		
		public static  new object __hx_create(global::haxe.root.Array arr){
			unchecked {
				return new global::alphatab.rendering.layout.HorizontalScreenLayout(((global::alphatab.rendering.ScoreRenderer) (arr[0]) ));
			}
		}
		
		
		public  global::alphatab.rendering.staves.StaveGroup _group;
		
		public override   void doLayout(){
			unchecked {
				if (( this.renderer.settings.staves.length == 0 )) {
					return ;
				}
				
				global::alphatab.model.Score score = this.renderer.get_score();
				int startIndex = this.renderer.settings.layout.@get<int>("start", 1);
				startIndex--;
				{
					double x = default(double);
					{
						double b = global::System.Math.Max(((double) (0) ), ((double) (startIndex) ));
						x = global::System.Math.Min(((double) (( score.masterBars.length - 1 )) ), ((double) (b) ));
					}
					
					startIndex = ((int) (x) );
				}
				
				int currentBarIndex = startIndex;
				int endBarIndex = this.renderer.settings.layout.@get<int>("count", score.masterBars.length);
				endBarIndex = ( ( startIndex + endBarIndex ) - 1 );
				{
					double x1 = default(double);
					{
						double b1 = global::System.Math.Max(((double) (0) ), ((double) (endBarIndex) ));
						x1 = global::System.Math.Min(((double) (( score.masterBars.length - 1 )) ), ((double) (b1) ));
					}
					
					endBarIndex = ((int) (x1) );
				}
				
				int x2 = global::alphatab.rendering.layout.HorizontalScreenLayout.PagePadding[0];
				int y = global::alphatab.rendering.layout.HorizontalScreenLayout.PagePadding[1];
				this._group = this.createEmptyStaveGroup();
				while (( currentBarIndex <= endBarIndex )){
					this._group.addBars(this.renderer.tracks, currentBarIndex);
					currentBarIndex++;
				}
				
				this._group.x = x2;
				this._group.y = y;
				this._group.finalizeGroup(this);
				y += ( this._group.calculateHeight() + ((int) (( 20 * this.renderer.settings.scale )) ) );
				this.height = ( y + global::alphatab.rendering.layout.HorizontalScreenLayout.PagePadding[3] );
				this.width = ( ( this._group.x + this._group.width ) + global::alphatab.rendering.layout.HorizontalScreenLayout.PagePadding[2] );
			}
		}
		
		
		public override   void paintScore(){
			unchecked {
				this._group.paint(0, 0, this.renderer.canvas);
			}
		}
		
		
		public override   void buildBoundingsLookup(global::alphatab.rendering.utils.BoundingsLookup lookup){
			unchecked {
				this._group.buildBoundingsLookup(lookup);
			}
		}
		
		
		public override   object __hx_setField(string field, int hash, object @value, bool handleProperties){
			unchecked {
				switch (hash){
					case 366738048:
					{
						this._group = ((global::alphatab.rendering.staves.StaveGroup) (@value) );
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
					
					
					case 1331941076:
					{
						return ((global::haxe.lang.Function) (new global::haxe.lang.Closure(((object) (this) ), ((string) ("paintScore") ), ((int) (1331941076) ))) );
					}
					
					
					case 1825584277:
					{
						return ((global::haxe.lang.Function) (new global::haxe.lang.Closure(((object) (this) ), ((string) ("doLayout") ), ((int) (1825584277) ))) );
					}
					
					
					case 366738048:
					{
						return this._group;
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
				baseArr.push("_group");
				{
					base.__hx_getFields(baseArr);
				}
				
			}
		}
		
		
	}
}


