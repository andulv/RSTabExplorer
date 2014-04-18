using haxe.root;
#pragma warning disable 109, 114, 219, 429, 168, 162
namespace alphatab.importer
{
	public  class GpxFile : global::haxe.lang.HxObject 
	{
		public    GpxFile(global::haxe.lang.EmptyObject empty)
		{
			unchecked 
			{
				{
				}
				
			}
		}
		
		
		public    GpxFile()
		{
			unchecked 
			{
				global::alphatab.importer.GpxFile.__hx_ctor_alphatab_importer_GpxFile(this);
			}
		}
		
		
		public static   void __hx_ctor_alphatab_importer_GpxFile(global::alphatab.importer.GpxFile __temp_me58)
		{
			unchecked 
			{
				{
				}
				
			}
		}
		
		
		public static  new object __hx_createEmpty()
		{
			unchecked 
			{
				return new global::alphatab.importer.GpxFile(((global::haxe.lang.EmptyObject) (global::haxe.lang.EmptyObject.EMPTY) ));
			}
		}
		
		
		public static  new object __hx_create(global::haxe.root.Array arr)
		{
			unchecked 
			{
				return new global::alphatab.importer.GpxFile();
			}
		}
		
		
		public  string fileName;
		
		public  int fileSize;
		
		public  global::haxe.io.Bytes data;
		
		public override   double __hx_setField_f(string field, int hash, double @value, bool handleProperties)
		{
			unchecked 
			{
				switch (hash)
				{
					case 1704429917:
					{
						this.fileSize = ((int) (@value) );
						return @value;
					}
					
					
					default:
					{
						return base.__hx_setField_f(field, hash, @value, handleProperties);
					}
					
				}
				
			}
		}
		
		
		public override   object __hx_setField(string field, int hash, object @value, bool handleProperties)
		{
			unchecked 
			{
				switch (hash)
				{
					case 1113806378:
					{
						this.data = ((global::haxe.io.Bytes) (@value) );
						return @value;
					}
					
					
					case 1704429917:
					{
						this.fileSize = ((int) (global::haxe.lang.Runtime.toInt(@value)) );
						return @value;
					}
					
					
					case 1648581351:
					{
						this.fileName = global::haxe.lang.Runtime.toString(@value);
						return @value;
					}
					
					
					default:
					{
						return base.__hx_setField(field, hash, @value, handleProperties);
					}
					
				}
				
			}
		}
		
		
		public override   object __hx_getField(string field, int hash, bool throwErrors, bool isCheck, bool handleProperties)
		{
			unchecked 
			{
				switch (hash)
				{
					case 1113806378:
					{
						return this.data;
					}
					
					
					case 1704429917:
					{
						return this.fileSize;
					}
					
					
					case 1648581351:
					{
						return this.fileName;
					}
					
					
					default:
					{
						return base.__hx_getField(field, hash, throwErrors, isCheck, handleProperties);
					}
					
				}
				
			}
		}
		
		
		public override   double __hx_getField_f(string field, int hash, bool throwErrors, bool handleProperties)
		{
			unchecked 
			{
				switch (hash)
				{
					case 1704429917:
					{
						return ((double) (this.fileSize) );
					}
					
					
					default:
					{
						return base.__hx_getField_f(field, hash, throwErrors, handleProperties);
					}
					
				}
				
			}
		}
		
		
		public override   void __hx_getFields(global::haxe.root.Array<object> baseArr)
		{
			unchecked 
			{
				baseArr.push("data");
				baseArr.push("fileSize");
				baseArr.push("fileName");
				{
					base.__hx_getFields(baseArr);
				}
				
			}
		}
		
		
	}
}



#pragma warning disable 109, 114, 219, 429, 168, 162
namespace alphatab.importer
{
	public  class GpxFileSystem : global::haxe.lang.HxObject 
	{
		static GpxFileSystem() 
		{
			global::alphatab.importer.GpxFileSystem.HeaderBcFs = "BCFS";
			global::alphatab.importer.GpxFileSystem.HeaderBcFz = "BCFZ";
			global::alphatab.importer.GpxFileSystem.ScoreGpif = "score.gpif";
		}
		public    GpxFileSystem(global::haxe.lang.EmptyObject empty)
		{
			unchecked 
			{
				{
				}
				
			}
		}
		
		
		public    GpxFileSystem()
		{
			unchecked 
			{
				global::alphatab.importer.GpxFileSystem.__hx_ctor_alphatab_importer_GpxFileSystem(this);
			}
		}
		
		
		public static   void __hx_ctor_alphatab_importer_GpxFileSystem(global::alphatab.importer.GpxFileSystem __temp_me60)
		{
			unchecked 
			{
				__temp_me60.files = new global::haxe.root.Array<object>();
			}
		}
		
		
		public static  string HeaderBcFs;
		
		public static  string HeaderBcFz;
		
		public static  string ScoreGpif;
		
		public static  new object __hx_createEmpty()
		{
			unchecked 
			{
				return new global::alphatab.importer.GpxFileSystem(((global::haxe.lang.EmptyObject) (global::haxe.lang.EmptyObject.EMPTY) ));
			}
		}
		
		
		public static  new object __hx_create(global::haxe.root.Array arr)
		{
			unchecked 
			{
				return new global::alphatab.importer.GpxFileSystem();
			}
		}
		
		
		public  global::haxe.lang.Function _fileFilter;
		
		public  global::haxe.root.Array<object> files;
		
		public virtual   void setFileFilter(global::haxe.lang.Function fileFilter)
		{
			unchecked 
			{
				this._fileFilter = fileFilter;
			}
		}
		
		
		public virtual   bool defaultFileFilter(string s)
		{
			unchecked 
			{
				return true;
			}
		}
		
		
		public virtual   void load(global::haxe.io.BytesInput data)
		{
			unchecked 
			{
				global::alphatab.io.BitInput src = new global::alphatab.io.BitInput(((global::haxe.io.BytesInput) (data) ));
				this.readBlock(src);
			}
		}
		
		
		public virtual   string readHeader(global::alphatab.io.BitInput src)
		{
			unchecked 
			{
				return src.readString(4);
			}
		}
		
		
		public virtual   global::haxe.io.Bytes decompress(global::alphatab.io.BitInput src, global::haxe.lang.Null<bool> skipHeader)
		{
			unchecked 
			{
				bool __temp_skipHeader59 = ( (global::haxe.lang.Runtime.eq((skipHeader).toDynamic(), (default(global::haxe.lang.Null<bool>)).toDynamic())) ? (((bool) (false) )) : (skipHeader.@value) );
				global::alphatab.io.BytesArray uncompressed = new global::alphatab.io.BytesArray(((global::haxe.lang.Null<int>) (default(global::haxe.lang.Null<int>)) ));
				int expectedLength = src.readInt32();
				try 
				{
					while (( uncompressed.length < expectedLength ))
					{
						int flag = src.readBits(1);
						if (( flag == 1 )) 
						{
							int wordSize = src.readBits(4);
							int offset = src.readBitsReversed(wordSize);
							int size = src.readBitsReversed(wordSize);
							int sourcePosition = ( uncompressed.length - offset );
							int toRead = default(int);
							{
								double x = global::System.Math.Min(((double) (offset) ), ((double) (size) ));
								toRead = ((int) (x) );
							}
							
							global::haxe.io.Bytes subBuffer = uncompressed.sub(sourcePosition, toRead);
							uncompressed.addBytes(subBuffer);
						}
						 else 
						{
							int size1 = src.readBitsReversed(2);
							{
								int _g = 0;
								while (( _g < ((int) (size1) ) ))
								{
									int i = _g++;
									uncompressed.@add(src.readByte());
								}
								
							}
							
						}
						
					}
					
				}
				catch (global::System.Exception __temp_catchallException505)
				{
					object __temp_catchall506 = __temp_catchallException505;
					if (( __temp_catchall506 is global::haxe.lang.HaxeException )) 
					{
						__temp_catchall506 = ((global::haxe.lang.HaxeException) (__temp_catchallException505) ).obj;
					}
					
					if (( __temp_catchall506 is global::haxe.io.Eof )) 
					{
						global::haxe.io.Eof e = ((global::haxe.io.Eof) (__temp_catchall506) );
						{
							{
							}
							
						}
						
					}
					 else 
					{
						throw;
					}
					
				}
				
				
				return uncompressed.getBytes(new global::haxe.lang.Null<int>(( (__temp_skipHeader59) ? (4) : (0) ), true));
			}
		}
		
		
		public virtual   void readBlock(global::alphatab.io.BitInput data)
		{
			unchecked 
			{
				string header = this.readHeader(data);
				if (string.Equals(header, "BCFZ")) 
				{
					this.readUncompressedBlock(this.decompress(data, new global::haxe.lang.Null<bool>(true, true)));
				}
				 else 
				{
					if (string.Equals(header, "BCFS")) 
					{
						this.readUncompressedBlock(data.readAll(default(global::haxe.lang.Null<int>)));
					}
					 else 
					{
						throw global::haxe.lang.HaxeException.wrap(global::alphatab.importer.ScoreImporter.UnsupportedFormat);
					}
					
				}
				
			}
		}
		
		
		public virtual   void readUncompressedBlock(global::haxe.io.Bytes data)
		{
			unchecked 
			{
				int sectorSize = 4096;
				int offset = sectorSize;
				while (( ( offset + 3 ) < data.length ))
				{
					int entryType = this.getInteger(data, offset);
					if (( entryType == 2 )) 
					{
						global::alphatab.importer.GpxFile file = new global::alphatab.importer.GpxFile();
						file.fileName = this.getString(data, ( offset + 4 ), 127);
						file.fileSize = this.getInteger(data, ( offset + 140 ));
						bool storeFile = default(bool);
						if (( this._fileFilter != default(global::haxe.lang.Function) )) 
						{
							storeFile = ((bool) (this._fileFilter.__hx_invoke1_o(default(double), file.fileName)) );
						}
						 else 
						{
							storeFile = this.defaultFileFilter(file.fileName);
						}
						
						if (storeFile) 
						{
							this.files.push(file);
						}
						
						int dataPointerOffset = ( offset + 148 );
						int sector = 0;
						int sectorCount = 0;
						global::alphatab.io.BytesArray fileData = default(global::alphatab.io.BytesArray);
						if (storeFile) 
						{
							fileData = new global::alphatab.io.BytesArray(new global::haxe.lang.Null<int>(file.fileSize, true));
						}
						 else 
						{
							fileData = default(global::alphatab.io.BytesArray);
						}
						
						while (( (sector = this.getInteger(data, ( dataPointerOffset + ( 4 * sectorCount++ ) ))) != 0 ))
						{
							offset = ( sector * sectorSize );
							if (storeFile) 
							{
								fileData.addBytes(data.sub(offset, sectorSize));
							}
							
						}
						
						if (storeFile) 
						{
							int __temp_stmt507 = default(int);
							{
								double x = global::System.Math.Min(((double) (file.fileSize) ), ((double) (fileData.length) ));
								__temp_stmt507 = ((int) (x) );
							}
							
							file.data = global::haxe.io.Bytes.alloc(__temp_stmt507);
							file.data.blit(0, fileData.getBuffer(), 0, file.data.length);
						}
						
					}
					
					offset += sectorSize;
				}
				
			}
		}
		
		
		public virtual   string getString(global::haxe.io.Bytes data, int offset, int length)
		{
			unchecked 
			{
				global::haxe.root.StringBuf buf = new global::haxe.root.StringBuf();
				{
					int _g = 0;
					while (( _g < length ))
					{
						int i = _g++;
						int code = ( ((int) (data.b[( offset + i )]) ) & 255 );
						if (( code == 0 )) 
						{
							break;
						}
						
						buf.b.Append(((char) (code) ));
					}
					
				}
				
				return buf.toString();
			}
		}
		
		
		public virtual   int getInteger(global::haxe.io.Bytes data, int offset)
		{
			unchecked 
			{
				return ( ( ( ( (( ((int) (data.b[( offset + 3 )]) ) & 255 )) << 24 ) | ( (( ((int) (data.b[( offset + 2 )]) ) & 255 )) << 16 ) ) | ( (( ((int) (data.b[( offset + 1 )]) ) & 255 )) << 8 ) ) | ( ((int) (data.b[offset]) ) & 255 ) );
			}
		}
		
		
		public override   object __hx_setField(string field, int hash, object @value, bool handleProperties)
		{
			unchecked 
			{
				switch (hash)
				{
					case 10018423:
					{
						this.files = ((global::haxe.root.Array<object>) (global::haxe.root.Array<object>.__hx_cast<object>(((global::haxe.root.Array) (@value) ))) );
						return @value;
					}
					
					
					case 943928435:
					{
						this._fileFilter = ((global::haxe.lang.Function) (@value) );
						return @value;
					}
					
					
					default:
					{
						return base.__hx_setField(field, hash, @value, handleProperties);
					}
					
				}
				
			}
		}
		
		
		public override   object __hx_getField(string field, int hash, bool throwErrors, bool isCheck, bool handleProperties)
		{
			unchecked 
			{
				switch (hash)
				{
					case 1719485384:
					{
						return ((global::haxe.lang.Function) (new global::haxe.lang.Closure(((object) (this) ), global::haxe.lang.Runtime.toString("getInteger"), ((int) (1719485384) ))) );
					}
					
					
					case 226931207:
					{
						return ((global::haxe.lang.Function) (new global::haxe.lang.Closure(((object) (this) ), global::haxe.lang.Runtime.toString("getString"), ((int) (226931207) ))) );
					}
					
					
					case 204643997:
					{
						return ((global::haxe.lang.Function) (new global::haxe.lang.Closure(((object) (this) ), global::haxe.lang.Runtime.toString("readUncompressedBlock"), ((int) (204643997) ))) );
					}
					
					
					case 98812439:
					{
						return ((global::haxe.lang.Function) (new global::haxe.lang.Closure(((object) (this) ), global::haxe.lang.Runtime.toString("readBlock"), ((int) (98812439) ))) );
					}
					
					
					case 1511295011:
					{
						return ((global::haxe.lang.Function) (new global::haxe.lang.Closure(((object) (this) ), global::haxe.lang.Runtime.toString("decompress"), ((int) (1511295011) ))) );
					}
					
					
					case 1987833219:
					{
						return ((global::haxe.lang.Function) (new global::haxe.lang.Closure(((object) (this) ), global::haxe.lang.Runtime.toString("readHeader"), ((int) (1987833219) ))) );
					}
					
					
					case 1203214886:
					{
						return ((global::haxe.lang.Function) (new global::haxe.lang.Closure(((object) (this) ), global::haxe.lang.Runtime.toString("load"), ((int) (1203214886) ))) );
					}
					
					
					case 1008410485:
					{
						return ((global::haxe.lang.Function) (new global::haxe.lang.Closure(((object) (this) ), global::haxe.lang.Runtime.toString("defaultFileFilter"), ((int) (1008410485) ))) );
					}
					
					
					case 120694166:
					{
						return ((global::haxe.lang.Function) (new global::haxe.lang.Closure(((object) (this) ), global::haxe.lang.Runtime.toString("setFileFilter"), ((int) (120694166) ))) );
					}
					
					
					case 10018423:
					{
						return this.files;
					}
					
					
					case 943928435:
					{
						return this._fileFilter;
					}
					
					
					default:
					{
						return base.__hx_getField(field, hash, throwErrors, isCheck, handleProperties);
					}
					
				}
				
			}
		}
		
		
		public override   object __hx_invokeField(string field, int hash, global::haxe.root.Array dynargs)
		{
			unchecked 
			{
				switch (hash)
				{
					case 1719485384:
					{
						return this.getInteger(((global::haxe.io.Bytes) (dynargs[0]) ), ((int) (global::haxe.lang.Runtime.toInt(dynargs[1])) ));
					}
					
					
					case 226931207:
					{
						return this.getString(((global::haxe.io.Bytes) (dynargs[0]) ), ((int) (global::haxe.lang.Runtime.toInt(dynargs[1])) ), ((int) (global::haxe.lang.Runtime.toInt(dynargs[2])) ));
					}
					
					
					case 204643997:
					{
						this.readUncompressedBlock(((global::haxe.io.Bytes) (dynargs[0]) ));
						break;
					}
					
					
					case 98812439:
					{
						this.readBlock(((global::alphatab.io.BitInput) (dynargs[0]) ));
						break;
					}
					
					
					case 1511295011:
					{
						return this.decompress(((global::alphatab.io.BitInput) (dynargs[0]) ), global::haxe.lang.Null<object>.ofDynamic<bool>(dynargs[1]));
					}
					
					
					case 1987833219:
					{
						return this.readHeader(((global::alphatab.io.BitInput) (dynargs[0]) ));
					}
					
					
					case 1203214886:
					{
						this.load(((global::haxe.io.BytesInput) (dynargs[0]) ));
						break;
					}
					
					
					case 1008410485:
					{
						return this.defaultFileFilter(global::haxe.lang.Runtime.toString(dynargs[0]));
					}
					
					
					case 120694166:
					{
						this.setFileFilter(((global::haxe.lang.Function) (dynargs[0]) ));
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
		
		
		public override   void __hx_getFields(global::haxe.root.Array<object> baseArr)
		{
			unchecked 
			{
				baseArr.push("files");
				baseArr.push("_fileFilter");
				{
					base.__hx_getFields(baseArr);
				}
				
			}
		}
		
		
	}
}


