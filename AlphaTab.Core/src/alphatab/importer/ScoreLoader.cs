using haxe.root;
#pragma warning disable 109, 114, 219, 429, 168, 162
namespace alphatab.importer{
	public  class ScoreLoader : global::haxe.lang.HxObject {
		public    ScoreLoader(global::haxe.lang.EmptyObject empty){
			unchecked {
				{
				}
				
			}
		}
		
		
		public    ScoreLoader(){
			unchecked {
				global::alphatab.importer.ScoreLoader.__hx_ctor_alphatab_importer_ScoreLoader(this);
			}
		}
		
		
		public static   void __hx_ctor_alphatab_importer_ScoreLoader(global::alphatab.importer.ScoreLoader __temp_me79){
			unchecked {
				{
				}
				
			}
		}
		
		
		public static   void loadScoreAsync(string path, global::haxe.lang.Function success, global::haxe.lang.Function error){
			unchecked {
				global::haxe.root.Array<object> error1 = new global::haxe.root.Array<object>(new object[]{error});
				global::haxe.root.Array<object> success1 = new global::haxe.root.Array<object>(new object[]{success});
				global::alphatab.platform.IFileLoader loader = ((global::alphatab.platform.IFileLoader) (((global::haxe.lang.Function) (global::alphatab.Environment.fileLoaders.@get("default").@value) ).__hx_invoke0_o()) );
				loader.loadBinaryAsync(path, new global::alphatab.importer.ScoreLoader_loadScoreAsync_43__Fun(((global::haxe.root.Array<object>) (success1) ), ((global::haxe.root.Array<object>) (error1) )), ((global::haxe.lang.Function) (error1[0]) ));
			}
		}
		
		
		public static   global::alphatab.model.Score loadScoreFromBytes(global::haxe.io.Bytes data){
			unchecked {
				global::haxe.root.Array<object> importers = global::alphatab.importer.ScoreImporter.availableImporters();
				global::alphatab.model.Score score = default(global::alphatab.model.Score);
				{
					int _g = 0;
					while (( _g < importers.length )){
						global::alphatab.importer.ScoreImporter importer = ((global::alphatab.importer.ScoreImporter) (importers[_g]) );
						 ++ _g;
						try {
							global::haxe.io.BytesInput input = new global::haxe.io.BytesInput(((global::haxe.io.Bytes) (data) ), ((global::haxe.lang.Null<int>) (default(global::haxe.lang.Null<int>)) ), ((global::haxe.lang.Null<int>) (default(global::haxe.lang.Null<int>)) ));
							importer.init(input);
							score = importer.readScore();
							break;
						}
						catch (global::System.Exception __temp_catchallException537){
							global::haxe.lang.Exceptions.exception = __temp_catchallException537;
							object __temp_catchall538 = __temp_catchallException537;
							if (( __temp_catchall538 is global::haxe.lang.HaxeException )) {
								__temp_catchall538 = ((global::haxe.lang.HaxeException) (__temp_catchallException537) ).obj;
							}
							
							{
								object e = __temp_catchall538;
								if (global::haxe.lang.Runtime.eq(e, global::alphatab.importer.ScoreImporter.UnsupportedFormat)) {
									continue;
								}
								 else {
									throw global::haxe.lang.HaxeException.wrap(e);
								}
								
							}
							
						}
						
						
					}
					
				}
				
				if (( score != default(global::alphatab.model.Score) )) {
					return score;
				}
				 else {
					throw global::haxe.lang.HaxeException.wrap("No reader for the requested file found");
				}
				
			}
		}
		
		
		public static   global::alphatab.model.Score loadScore(string path){
			unchecked {
				global::alphatab.platform.IFileLoader loader = ((global::alphatab.platform.IFileLoader) (((global::haxe.lang.Function) (global::alphatab.Environment.fileLoaders.@get("default").@value) ).__hx_invoke0_o()) );
				global::haxe.io.Bytes data = loader.loadBinary(path);
				return global::alphatab.importer.ScoreLoader.loadScoreFromBytes(data);
			}
		}
		
		
		public static  new object __hx_createEmpty(){
			unchecked {
				return new global::alphatab.importer.ScoreLoader(((global::haxe.lang.EmptyObject) (global::haxe.lang.EmptyObject.EMPTY) ));
			}
		}
		
		
		public static  new object __hx_create(global::haxe.root.Array arr){
			unchecked {
				return new global::alphatab.importer.ScoreLoader();
			}
		}
		
		
	}
}



#pragma warning disable 109, 114, 219, 429, 168, 162
namespace alphatab.importer{
	public  class ScoreLoader_loadScoreAsync_43__Fun : global::haxe.lang.Function {
		public    ScoreLoader_loadScoreAsync_43__Fun(global::haxe.root.Array<object> success1, global::haxe.root.Array<object> error1) : base(1, 0){
			unchecked {
				this.success1 = success1;
				this.error1 = error1;
			}
		}
		
		
		public override   object __hx_invoke1_o(double __fn_float1, object __fn_dyn1){
			unchecked {
				global::haxe.io.Bytes data = ( (global::haxe.lang.Runtime.eq(__fn_dyn1, global::haxe.lang.Runtime.undefined)) ? (((global::haxe.io.Bytes) (((object) (__fn_float1) )) )) : (((global::haxe.io.Bytes) (__fn_dyn1) )) );
				try {
					((global::haxe.lang.Function) (this.success1[0]) ).__hx_invoke1_o(default(double), global::alphatab.importer.ScoreLoader.loadScoreFromBytes(data));
				}
				catch (global::System.Exception __temp_catchallException539){
					global::haxe.lang.Exceptions.exception = __temp_catchallException539;
					object __temp_catchall540 = __temp_catchallException539;
					if (( __temp_catchall540 is global::haxe.lang.HaxeException )) {
						__temp_catchall540 = ((global::haxe.lang.HaxeException) (__temp_catchallException539) ).obj;
					}
					
					if (( __temp_catchall540 is string )) {
						string e = global::haxe.lang.Runtime.toString(__temp_catchall540);
						{
							((global::haxe.lang.Function) (this.error1[0]) ).__hx_invoke1_o(default(double), e);
						}
						
					}
					 else {
						throw;
					}
					
				}
				
				
				return default(object);
			}
		}
		
		
		public  global::haxe.root.Array<object> success1;
		
		public  global::haxe.root.Array<object> error1;
		
	}
}


