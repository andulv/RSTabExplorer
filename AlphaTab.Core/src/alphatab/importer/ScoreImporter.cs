using haxe.root;
#pragma warning disable 109, 114, 219, 429, 168, 162
namespace alphatab.importer{
	public  class ScoreImporter : global::haxe.lang.HxObject {
		static ScoreImporter() {
			global::alphatab.importer.ScoreImporter.UnsupportedFormat = "unsupported file";
		}
		public    ScoreImporter(global::haxe.lang.EmptyObject empty){
			unchecked {
				{
				}
				
			}
		}
		
		
		public    ScoreImporter(){
			unchecked {
				global::alphatab.importer.ScoreImporter.__hx_ctor_alphatab_importer_ScoreImporter(this);
			}
		}
		
		
		public static   void __hx_ctor_alphatab_importer_ScoreImporter(global::alphatab.importer.ScoreImporter __temp_me68){
			unchecked {
				{
				}
				
			}
		}
		
		
		public static  string UnsupportedFormat;
		
		public static   global::haxe.root.Array<object> availableImporters(){
			unchecked {
				global::haxe.root.Array<object> scoreImporter = new global::haxe.root.Array<object>();
				scoreImporter.push(new global::alphatab.importer.Gp3To5Importer());
				scoreImporter.push(new global::alphatab.importer.AlphaTexImporter());
				scoreImporter.push(new global::alphatab.importer.GpxImporter());
				return scoreImporter;
			}
		}
		
		
		public static  new object __hx_createEmpty(){
			unchecked {
				return new global::alphatab.importer.ScoreImporter(((global::haxe.lang.EmptyObject) (global::haxe.lang.EmptyObject.EMPTY) ));
			}
		}
		
		
		public static  new object __hx_create(global::haxe.root.Array arr){
			unchecked {
				return new global::alphatab.importer.ScoreImporter();
			}
		}
		
		
		public  global::haxe.io.BytesInput _data;
		
		public virtual   void init(global::haxe.io.BytesInput data){
			unchecked {
				this._data = data;
			}
		}
		
		
		public virtual   global::alphatab.model.Score readScore(){
			unchecked {
				return default(global::alphatab.model.Score);
			}
		}
		
		
		public override   object __hx_setField(string field, int hash, object @value, bool handleProperties){
			unchecked {
				switch (hash){
					case 1970565641:
					{
						this._data = ((global::haxe.io.BytesInput) (@value) );
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
					case 1237368860:
					{
						return ((global::haxe.lang.Function) (new global::haxe.lang.Closure(((object) (this) ), ((string) ("readScore") ), ((int) (1237368860) ))) );
					}
					
					
					case 1169898256:
					{
						return ((global::haxe.lang.Function) (new global::haxe.lang.Closure(((object) (this) ), ((string) ("init") ), ((int) (1169898256) ))) );
					}
					
					
					case 1970565641:
					{
						return this._data;
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
					case 1237368860:
					{
						return this.readScore();
					}
					
					
					case 1169898256:
					{
						this.init(((global::haxe.io.BytesInput) (dynargs[0]) ));
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
				baseArr.push("_data");
				{
					base.__hx_getFields(baseArr);
				}
				
			}
		}
		
		
	}
}


