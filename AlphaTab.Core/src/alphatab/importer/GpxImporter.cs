using haxe.root;
#pragma warning disable 109, 114, 219, 429, 168, 162
namespace alphatab.importer
{
	public  class GpxImporter : global::alphatab.importer.ScoreImporter 
	{
		public    GpxImporter(global::haxe.lang.EmptyObject empty) : base(global::haxe.lang.EmptyObject.EMPTY)
		{
			unchecked 
			{
			}
		}
		
		
		public    GpxImporter() : base(global::haxe.lang.EmptyObject.EMPTY)
		{
			unchecked 
			{
				global::alphatab.importer.GpxImporter.__hx_ctor_alphatab_importer_GpxImporter(this);
			}
		}
		
		
		public static   void __hx_ctor_alphatab_importer_GpxImporter(global::alphatab.importer.GpxImporter __temp_me61)
		{
			unchecked 
			{
				global::alphatab.importer.ScoreImporter.__hx_ctor_alphatab_importer_ScoreImporter(__temp_me61);
			}
		}
		
		
		public static  new object __hx_createEmpty()
		{
			unchecked 
			{
				return new global::alphatab.importer.GpxImporter(((global::haxe.lang.EmptyObject) (global::haxe.lang.EmptyObject.EMPTY) ));
			}
		}
		
		
		public static  new object __hx_create(global::haxe.root.Array arr)
		{
			unchecked 
			{
				return new global::alphatab.importer.GpxImporter();
			}
		}
		
		
		public override   global::alphatab.model.Score readScore()
		{
			unchecked 
			{
				global::alphatab.importer.GpxFileSystem fileSystem = new global::alphatab.importer.GpxFileSystem();
				fileSystem.setFileFilter(( (( global::alphatab.importer.GpxImporter_readScore_38__Fun.__hx_current != default(global::alphatab.importer.GpxImporter_readScore_38__Fun) )) ? (global::alphatab.importer.GpxImporter_readScore_38__Fun.__hx_current) : (global::alphatab.importer.GpxImporter_readScore_38__Fun.__hx_current = ((global::alphatab.importer.GpxImporter_readScore_38__Fun) (new global::alphatab.importer.GpxImporter_readScore_38__Fun()) )) ));
				fileSystem.load(this._data);
				string xml = ((global::alphatab.importer.GpxFile) (fileSystem.files[0]) ).data.toString();
				fileSystem.files = default(global::haxe.root.Array<object>);
				fileSystem = default(global::alphatab.importer.GpxFileSystem);
				global::alphatab.importer.GpxParser parser = new global::alphatab.importer.GpxParser();
				parser.parseXml(xml);
				this.finish(parser.score);
				return parser.score;
			}
		}
		
		
		public override   object __hx_getField(string field, int hash, bool throwErrors, bool isCheck, bool handleProperties)
		{
			unchecked 
			{
				switch (hash)
				{
					case 1237368860:
					{
						return ((global::haxe.lang.Function) (new global::haxe.lang.Closure(((object) (this) ), global::haxe.lang.Runtime.toString("readScore"), ((int) (1237368860) ))) );
					}
					
					
					default:
					{
						return base.__hx_getField(field, hash, throwErrors, isCheck, handleProperties);
					}
					
				}
				
			}
		}
		
		
	}
}



#pragma warning disable 109, 114, 219, 429, 168, 162
namespace alphatab.importer
{
	public  class GpxImporter_readScore_38__Fun : global::haxe.lang.Function 
	{
		public    GpxImporter_readScore_38__Fun() : base(1, 0)
		{
			unchecked 
			{
			}
		}
		
		
		public static  global::alphatab.importer.GpxImporter_readScore_38__Fun __hx_current;
		
		public override   object __hx_invoke1_o(double __fn_float1, object __fn_dyn1)
		{
			unchecked 
			{
				string s = ( (global::haxe.lang.Runtime.eq(__fn_dyn1, global::haxe.lang.Runtime.undefined)) ? (global::haxe.lang.Runtime.toString(__fn_float1)) : (global::haxe.lang.Runtime.toString(__fn_dyn1)) );
				return string.Equals(s, "score.gpif");
			}
		}
		
		
	}
}


