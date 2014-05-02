using haxe.root;
#pragma warning disable 109, 114, 219, 429, 168, 162
namespace alphatab.rendering.utils{
	public  class Bounds : global::haxe.lang.HxObject {
		public    Bounds(global::haxe.lang.EmptyObject empty){
			unchecked {
				{
				}
				
			}
		}
		
		
		public    Bounds(int x, int y, int w, int h){
			unchecked {
				global::alphatab.rendering.utils.Bounds.__hx_ctor_alphatab_rendering_utils_Bounds(this, x, y, w, h);
			}
		}
		
		
		public static   void __hx_ctor_alphatab_rendering_utils_Bounds(global::alphatab.rendering.utils.Bounds __temp_me287, int x, int y, int w, int h){
			unchecked {
				__temp_me287.x = x;
				__temp_me287.y = y;
				__temp_me287.w = w;
				__temp_me287.h = h;
			}
		}
		
		
		public static  new object __hx_createEmpty(){
			unchecked {
				return new global::alphatab.rendering.utils.Bounds(((global::haxe.lang.EmptyObject) (global::haxe.lang.EmptyObject.EMPTY) ));
			}
		}
		
		
		public static  new object __hx_create(global::haxe.root.Array arr){
			unchecked {
				return new global::alphatab.rendering.utils.Bounds(((int) (global::haxe.lang.Runtime.toInt(arr[0])) ), ((int) (global::haxe.lang.Runtime.toInt(arr[1])) ), ((int) (global::haxe.lang.Runtime.toInt(arr[2])) ), ((int) (global::haxe.lang.Runtime.toInt(arr[3])) ));
			}
		}
		
		
		public  int x;
		
		public  int y;
		
		public  int w;
		
		public  int h;
		
		public override   double __hx_setField_f(string field, int hash, double @value, bool handleProperties){
			unchecked {
				switch (hash){
					case 104:
					{
						this.h = ((int) (@value) );
						return @value;
					}
					
					
					case 119:
					{
						this.w = ((int) (@value) );
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
					case 104:
					{
						this.h = ((int) (global::haxe.lang.Runtime.toInt(@value)) );
						return @value;
					}
					
					
					case 119:
					{
						this.w = ((int) (global::haxe.lang.Runtime.toInt(@value)) );
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
					case 104:
					{
						return this.h;
					}
					
					
					case 119:
					{
						return this.w;
					}
					
					
					case 121:
					{
						return this.y;
					}
					
					
					case 120:
					{
						return this.x;
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
					case 104:
					{
						return ((double) (this.h) );
					}
					
					
					case 119:
					{
						return ((double) (this.w) );
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
		
		
		public override   void __hx_getFields(global::haxe.root.Array<object> baseArr){
			unchecked {
				baseArr.push("h");
				baseArr.push("w");
				baseArr.push("y");
				baseArr.push("x");
				{
					base.__hx_getFields(baseArr);
				}
				
			}
		}
		
		
	}
}



#pragma warning disable 109, 114, 219, 429, 168, 162
namespace alphatab.rendering.utils{
	public  class BeatBoundings : global::haxe.lang.HxObject {
		public    BeatBoundings(global::haxe.lang.EmptyObject empty){
			unchecked {
				{
				}
				
			}
		}
		
		
		public    BeatBoundings(){
			unchecked {
				global::alphatab.rendering.utils.BeatBoundings.__hx_ctor_alphatab_rendering_utils_BeatBoundings(this);
			}
		}
		
		
		public static   void __hx_ctor_alphatab_rendering_utils_BeatBoundings(global::alphatab.rendering.utils.BeatBoundings __temp_me288){
			unchecked {
				{
				}
				
			}
		}
		
		
		public static  new object __hx_createEmpty(){
			unchecked {
				return new global::alphatab.rendering.utils.BeatBoundings(((global::haxe.lang.EmptyObject) (global::haxe.lang.EmptyObject.EMPTY) ));
			}
		}
		
		
		public static  new object __hx_create(global::haxe.root.Array arr){
			unchecked {
				return new global::alphatab.rendering.utils.BeatBoundings();
			}
		}
		
		
		public  global::alphatab.model.Beat beat;
		
		public  global::alphatab.rendering.utils.Bounds bounds;
		
		public  global::alphatab.rendering.utils.Bounds visualBounds;
		
		public override   object __hx_setField(string field, int hash, object @value, bool handleProperties){
			unchecked {
				switch (hash){
					case 1159507285:
					{
						this.visualBounds = ((global::alphatab.rendering.utils.Bounds) (@value) );
						return @value;
					}
					
					
					case 1713210997:
					{
						this.bounds = ((global::alphatab.rendering.utils.Bounds) (@value) );
						return @value;
					}
					
					
					case 1091821942:
					{
						this.beat = ((global::alphatab.model.Beat) (@value) );
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
					case 1159507285:
					{
						return this.visualBounds;
					}
					
					
					case 1713210997:
					{
						return this.bounds;
					}
					
					
					case 1091821942:
					{
						return this.beat;
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
				baseArr.push("visualBounds");
				baseArr.push("bounds");
				baseArr.push("beat");
				{
					base.__hx_getFields(baseArr);
				}
				
			}
		}
		
		
	}
}



#pragma warning disable 109, 114, 219, 429, 168, 162
namespace alphatab.rendering.utils{
	public  class BarBoundings : global::haxe.lang.HxObject {
		public    BarBoundings(global::haxe.lang.EmptyObject empty){
			unchecked {
				{
				}
				
			}
		}
		
		
		public    BarBoundings(){
			unchecked {
				global::alphatab.rendering.utils.BarBoundings.__hx_ctor_alphatab_rendering_utils_BarBoundings(this);
			}
		}
		
		
		public static   void __hx_ctor_alphatab_rendering_utils_BarBoundings(global::alphatab.rendering.utils.BarBoundings __temp_me289){
			unchecked {
				__temp_me289.beats = new global::haxe.root.Array<object>();
			}
		}
		
		
		public static  new object __hx_createEmpty(){
			unchecked {
				return new global::alphatab.rendering.utils.BarBoundings(((global::haxe.lang.EmptyObject) (global::haxe.lang.EmptyObject.EMPTY) ));
			}
		}
		
		
		public static  new object __hx_create(global::haxe.root.Array arr){
			unchecked {
				return new global::alphatab.rendering.utils.BarBoundings();
			}
		}
		
		
		public  bool isFirstOfLine;
		
		public  bool isLastOfLine;
		
		public  global::alphatab.model.Bar bar;
		
		public  global::alphatab.rendering.utils.Bounds bounds;
		
		public  global::alphatab.rendering.utils.Bounds visualBounds;
		
		public  global::haxe.root.Array<object> beats;
		
		public virtual   global::alphatab.model.Beat findBeatAtPos(int x){
			unchecked {
				int index = 0;
				while (( ( index < ( this.beats.length - 1 ) ) && ( x > ( ((global::alphatab.rendering.utils.BeatBoundings) (this.beats[index]) ).bounds.x + ((global::alphatab.rendering.utils.BeatBoundings) (this.beats[index]) ).bounds.w ) ) )){
					index++;
				}
				
				return ((global::alphatab.rendering.utils.BeatBoundings) (this.beats[index]) ).beat;
			}
		}
		
		
		public override   object __hx_setField(string field, int hash, object @value, bool handleProperties){
			unchecked {
				switch (hash){
					case 810640957:
					{
						this.beats = ((global::haxe.root.Array<object>) (global::haxe.root.Array<object>.__hx_cast<object>(((global::haxe.root.Array) (@value) ))) );
						return @value;
					}
					
					
					case 1159507285:
					{
						this.visualBounds = ((global::alphatab.rendering.utils.Bounds) (@value) );
						return @value;
					}
					
					
					case 1713210997:
					{
						this.bounds = ((global::alphatab.rendering.utils.Bounds) (@value) );
						return @value;
					}
					
					
					case 4895187:
					{
						this.bar = ((global::alphatab.model.Bar) (@value) );
						return @value;
					}
					
					
					case 1812105259:
					{
						this.isLastOfLine = global::haxe.lang.Runtime.toBool(@value);
						return @value;
					}
					
					
					case 1020198193:
					{
						this.isFirstOfLine = global::haxe.lang.Runtime.toBool(@value);
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
					case 251682194:
					{
						return ((global::haxe.lang.Function) (new global::haxe.lang.Closure(((object) (this) ), ((string) ("findBeatAtPos") ), ((int) (251682194) ))) );
					}
					
					
					case 810640957:
					{
						return this.beats;
					}
					
					
					case 1159507285:
					{
						return this.visualBounds;
					}
					
					
					case 1713210997:
					{
						return this.bounds;
					}
					
					
					case 4895187:
					{
						return this.bar;
					}
					
					
					case 1812105259:
					{
						return this.isLastOfLine;
					}
					
					
					case 1020198193:
					{
						return this.isFirstOfLine;
					}
					
					
					default:
					{
						return base.__hx_getField(field, hash, throwErrors, isCheck, handleProperties);
					}
					
				}
				
			}
		}
		
		
		public override   object __hx_invokeField(string field, int hash, global::haxe.root.Array dynargs){
			unchecked {
				switch (hash){
					case 251682194:
					{
						return this.findBeatAtPos(((int) (global::haxe.lang.Runtime.toInt(dynargs[0])) ));
					}
					
					
					default:
					{
						return base.__hx_invokeField(field, hash, dynargs);
					}
					
				}
				
			}
		}
		
		
		public override   void __hx_getFields(global::haxe.root.Array<object> baseArr){
			unchecked {
				baseArr.push("beats");
				baseArr.push("visualBounds");
				baseArr.push("bounds");
				baseArr.push("bar");
				baseArr.push("isLastOfLine");
				baseArr.push("isFirstOfLine");
				{
					base.__hx_getFields(baseArr);
				}
				
			}
		}
		
		
	}
}



#pragma warning disable 109, 114, 219, 429, 168, 162
namespace alphatab.rendering.utils{
	public  class BoundingsLookup : global::haxe.lang.HxObject {
		public    BoundingsLookup(global::haxe.lang.EmptyObject empty){
			unchecked {
				{
				}
				
			}
		}
		
		
		public    BoundingsLookup(){
			unchecked {
				global::alphatab.rendering.utils.BoundingsLookup.__hx_ctor_alphatab_rendering_utils_BoundingsLookup(this);
			}
		}
		
		
		public static   void __hx_ctor_alphatab_rendering_utils_BoundingsLookup(global::alphatab.rendering.utils.BoundingsLookup __temp_me290){
			unchecked {
				__temp_me290.bars = new global::haxe.root.Array<object>();
			}
		}
		
		
		public static  new object __hx_createEmpty(){
			unchecked {
				return new global::alphatab.rendering.utils.BoundingsLookup(((global::haxe.lang.EmptyObject) (global::haxe.lang.EmptyObject.EMPTY) ));
			}
		}
		
		
		public static  new object __hx_create(global::haxe.root.Array arr){
			unchecked {
				return new global::alphatab.rendering.utils.BoundingsLookup();
			}
		}
		
		
		public  global::haxe.root.Array<object> bars;
		
		public virtual   global::alphatab.model.Beat getBeatAtPos(int x, int y){
			unchecked {
				int bottom = 0;
				int top = ( this.bars.length - 1 );
				int barIndex = -1;
				while (( bottom <= top )){
					int middle = ( (( top + bottom )) / 2 );
					global::alphatab.rendering.utils.BarBoundings bar = ((global::alphatab.rendering.utils.BarBoundings) (this.bars[middle]) );
					if (( ( y >= bar.bounds.y ) && ( y <= ( bar.bounds.y + bar.bounds.h ) ) )) {
						barIndex = middle;
						break;
					}
					 else {
						if (( y < bar.bounds.y )) {
							top = ( middle - 1 );
						}
						 else {
							bottom = ( middle + 1 );
						}
						
					}
					
				}
				
				if (( barIndex == -1 )) {
					return default(global::alphatab.model.Beat);
				}
				
				global::alphatab.rendering.utils.BarBoundings currentBar = ((global::alphatab.rendering.utils.BarBoundings) (this.bars[barIndex]) );
				if (( x < currentBar.bounds.x )) {
					while (( ( ( barIndex > 0 ) && ( x < ((global::alphatab.rendering.utils.BarBoundings) (this.bars[barIndex]) ).bounds.x ) ) &&  ! (((global::alphatab.rendering.utils.BarBoundings) (this.bars[barIndex]) ).isFirstOfLine)  )){
						barIndex--;
					}
					
				}
				 else {
					while (( ( ( barIndex < ( this.bars.length - 1 ) ) && ( x > ( ((global::alphatab.rendering.utils.BarBoundings) (this.bars[barIndex]) ).bounds.x + ((global::alphatab.rendering.utils.BarBoundings) (this.bars[barIndex]) ).bounds.w ) ) ) &&  ! (((global::alphatab.rendering.utils.BarBoundings) (this.bars[barIndex]) ).isLastOfLine)  )){
						barIndex++;
					}
					
				}
				
				return ((global::alphatab.rendering.utils.BarBoundings) (this.bars[barIndex]) ).findBeatAtPos(x);
			}
		}
		
		
		public override   object __hx_setField(string field, int hash, object @value, bool handleProperties){
			unchecked {
				switch (hash){
					case 1091626816:
					{
						this.bars = ((global::haxe.root.Array<object>) (global::haxe.root.Array<object>.__hx_cast<object>(((global::haxe.root.Array) (@value) ))) );
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
					case 1034238357:
					{
						return ((global::haxe.lang.Function) (new global::haxe.lang.Closure(((object) (this) ), ((string) ("getBeatAtPos") ), ((int) (1034238357) ))) );
					}
					
					
					case 1091626816:
					{
						return this.bars;
					}
					
					
					default:
					{
						return base.__hx_getField(field, hash, throwErrors, isCheck, handleProperties);
					}
					
				}
				
			}
		}
		
		
		public override   object __hx_invokeField(string field, int hash, global::haxe.root.Array dynargs){
			unchecked {
				switch (hash){
					case 1034238357:
					{
						return this.getBeatAtPos(((int) (global::haxe.lang.Runtime.toInt(dynargs[0])) ), ((int) (global::haxe.lang.Runtime.toInt(dynargs[1])) ));
					}
					
					
					default:
					{
						return base.__hx_invokeField(field, hash, dynargs);
					}
					
				}
				
			}
		}
		
		
		public override   void __hx_getFields(global::haxe.root.Array<object> baseArr){
			unchecked {
				baseArr.push("bars");
				{
					base.__hx_getFields(baseArr);
				}
				
			}
		}
		
		
	}
}


