using haxe.root;
#pragma warning disable 109, 114, 219, 429, 168, 162
namespace alphatab.rendering.glyphs{
	public  class SvgCommand : global::haxe.lang.HxObject {
		public    SvgCommand(global::haxe.lang.EmptyObject empty){
			unchecked {
				{
				}
				
			}
		}
		
		
		public    SvgCommand(){
			unchecked {
				global::alphatab.rendering.glyphs.SvgCommand.__hx_ctor_alphatab_rendering_glyphs_SvgCommand(this);
			}
		}
		
		
		public static   void __hx_ctor_alphatab_rendering_glyphs_SvgCommand(global::alphatab.rendering.glyphs.SvgCommand __temp_me176){
			unchecked {
				{
				}
				
			}
		}
		
		
		public static  new object __hx_createEmpty(){
			unchecked {
				return new global::alphatab.rendering.glyphs.SvgCommand(((global::haxe.lang.EmptyObject) (global::haxe.lang.EmptyObject.EMPTY) ));
			}
		}
		
		
		public static  new object __hx_create(global::haxe.root.Array arr){
			unchecked {
				return new global::alphatab.rendering.glyphs.SvgCommand();
			}
		}
		
		
		public  string cmd;
		
		public  global::haxe.root.Array<int> numbers;
		
		public override   object __hx_setField(string field, int hash, object @value, bool handleProperties){
			unchecked {
				switch (hash){
					case 700148106:
					{
						this.numbers = ((global::haxe.root.Array<int>) (global::haxe.root.Array<object>.__hx_cast<int>(((global::haxe.root.Array) (@value) ))) );
						return @value;
					}
					
					
					case 4947578:
					{
						this.cmd = global::haxe.lang.Runtime.toString(@value);
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
					case 700148106:
					{
						return this.numbers;
					}
					
					
					case 4947578:
					{
						return this.cmd;
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
				baseArr.push("numbers");
				baseArr.push("cmd");
				{
					base.__hx_getFields(baseArr);
				}
				
			}
		}
		
		
	}
}



#pragma warning disable 109, 114, 219, 429, 168, 162
namespace alphatab.rendering.glyphs{
	public  class LazySvg : global::haxe.lang.HxObject {
		public    LazySvg(global::haxe.lang.EmptyObject empty){
			unchecked {
				{
				}
				
			}
		}
		
		
		public    LazySvg(string raw){
			unchecked {
				global::alphatab.rendering.glyphs.LazySvg.__hx_ctor_alphatab_rendering_glyphs_LazySvg(this, raw);
			}
		}
		
		
		public static   void __hx_ctor_alphatab_rendering_glyphs_LazySvg(global::alphatab.rendering.glyphs.LazySvg __temp_me177, string raw){
			unchecked {
				__temp_me177._raw = raw;
				__temp_me177._parsed = default(global::haxe.root.Array<object>);
			}
		}
		
		
		public static  new object __hx_createEmpty(){
			unchecked {
				return new global::alphatab.rendering.glyphs.LazySvg(((global::haxe.lang.EmptyObject) (global::haxe.lang.EmptyObject.EMPTY) ));
			}
		}
		
		
		public static  new object __hx_create(global::haxe.root.Array arr){
			unchecked {
				return new global::alphatab.rendering.glyphs.LazySvg(global::haxe.lang.Runtime.toString(arr[0]));
			}
		}
		
		
		public  string _raw;
		
		public  global::haxe.root.Array<object> _parsed;
		
		public virtual   global::haxe.root.Array<object> @get(){
			unchecked {
				if (( this._parsed == default(global::haxe.root.Array<object>) )) {
					this.parse();
				}
				
				return this._parsed;
			}
		}
		
		
		public virtual   void parse(){
			unchecked {
				global::alphatab.rendering.utils.SvgPathParser parser = new global::alphatab.rendering.utils.SvgPathParser(((string) (this._raw) ));
				parser.reset();
				this._parsed = new global::haxe.root.Array<object>();
				while ( ! (parser.eof()) ){
					global::alphatab.rendering.glyphs.SvgCommand command = new global::alphatab.rendering.glyphs.SvgCommand();
					this._parsed.push(command);
					command.cmd = parser.getString();
					{
						string _g = command.cmd;
						switch (_g){
							case "M":
							{
								command.numbers = new global::haxe.root.Array<int>(new int[]{parser.getNumber(), parser.getNumber()});
								break;
							}
							
							
							case "m":
							{
								command.numbers = new global::haxe.root.Array<int>(new int[]{parser.getNumber(), parser.getNumber()});
								break;
							}
							
							
							case "Z":case "z":
							{
								{
								}
								
								break;
							}
							
							
							case "L":
							{
								command.numbers = new global::haxe.root.Array<int>();
								do {
									command.numbers.push(parser.getNumber());
									command.numbers.push(parser.getNumber());
								}
								while (global::alphatab.rendering.utils.SvgPathParser.isNumber(parser.currentToken, default(global::haxe.lang.Null<bool>)));
								break;
							}
							
							
							case "l":
							{
								command.numbers = new global::haxe.root.Array<int>();
								do {
									command.numbers.push(parser.getNumber());
									command.numbers.push(parser.getNumber());
								}
								while (global::alphatab.rendering.utils.SvgPathParser.isNumber(parser.currentToken, default(global::haxe.lang.Null<bool>)));
								break;
							}
							
							
							case "V":
							{
								command.numbers = new global::haxe.root.Array<int>();
								do {
									command.numbers.push(parser.getNumber());
								}
								while (global::alphatab.rendering.utils.SvgPathParser.isNumber(parser.currentToken, default(global::haxe.lang.Null<bool>)));
								break;
							}
							
							
							case "v":
							{
								command.numbers = new global::haxe.root.Array<int>();
								do {
									command.numbers.push(parser.getNumber());
								}
								while (global::alphatab.rendering.utils.SvgPathParser.isNumber(parser.currentToken, default(global::haxe.lang.Null<bool>)));
								break;
							}
							
							
							case "H":
							{
								command.numbers = new global::haxe.root.Array<int>();
								do {
									command.numbers.push(parser.getNumber());
								}
								while (global::alphatab.rendering.utils.SvgPathParser.isNumber(parser.currentToken, default(global::haxe.lang.Null<bool>)));
								break;
							}
							
							
							case "h":
							{
								command.numbers = new global::haxe.root.Array<int>();
								do {
									command.numbers.push(parser.getNumber());
								}
								while (global::alphatab.rendering.utils.SvgPathParser.isNumber(parser.currentToken, default(global::haxe.lang.Null<bool>)));
								break;
							}
							
							
							case "C":
							{
								command.numbers = new global::haxe.root.Array<int>();
								do {
									command.numbers.push(parser.getNumber());
									command.numbers.push(parser.getNumber());
									command.numbers.push(parser.getNumber());
									command.numbers.push(parser.getNumber());
									command.numbers.push(parser.getNumber());
									command.numbers.push(parser.getNumber());
								}
								while (global::alphatab.rendering.utils.SvgPathParser.isNumber(parser.currentToken, default(global::haxe.lang.Null<bool>)));
								break;
							}
							
							
							case "c":
							{
								command.numbers = new global::haxe.root.Array<int>();
								do {
									command.numbers.push(parser.getNumber());
									command.numbers.push(parser.getNumber());
									command.numbers.push(parser.getNumber());
									command.numbers.push(parser.getNumber());
									command.numbers.push(parser.getNumber());
									command.numbers.push(parser.getNumber());
								}
								while (global::alphatab.rendering.utils.SvgPathParser.isNumber(parser.currentToken, default(global::haxe.lang.Null<bool>)));
								break;
							}
							
							
							case "S":
							{
								command.numbers = new global::haxe.root.Array<int>();
								do {
									command.numbers.push(parser.getNumber());
									command.numbers.push(parser.getNumber());
									command.numbers.push(parser.getNumber());
									command.numbers.push(parser.getNumber());
								}
								while (global::alphatab.rendering.utils.SvgPathParser.isNumber(parser.currentToken, default(global::haxe.lang.Null<bool>)));
								break;
							}
							
							
							case "s":
							{
								command.numbers = new global::haxe.root.Array<int>();
								do {
									command.numbers.push(parser.getNumber());
									command.numbers.push(parser.getNumber());
									command.numbers.push(parser.getNumber());
									command.numbers.push(parser.getNumber());
								}
								while (global::alphatab.rendering.utils.SvgPathParser.isNumber(parser.currentToken, default(global::haxe.lang.Null<bool>)));
								break;
							}
							
							
							case "Q":
							{
								command.numbers = new global::haxe.root.Array<int>();
								do {
									command.numbers.push(parser.getNumber());
									command.numbers.push(parser.getNumber());
									command.numbers.push(parser.getNumber());
									command.numbers.push(parser.getNumber());
								}
								while (global::alphatab.rendering.utils.SvgPathParser.isNumber(parser.currentToken, default(global::haxe.lang.Null<bool>)));
								break;
							}
							
							
							case "q":
							{
								command.numbers = new global::haxe.root.Array<int>();
								do {
									command.numbers.push(parser.getNumber());
									command.numbers.push(parser.getNumber());
									command.numbers.push(parser.getNumber());
									command.numbers.push(parser.getNumber());
								}
								while (global::alphatab.rendering.utils.SvgPathParser.isNumber(parser.currentToken, default(global::haxe.lang.Null<bool>)));
								break;
							}
							
							
							case "T":
							{
								command.numbers = new global::haxe.root.Array<int>();
								do {
									command.numbers.push(parser.getNumber());
									command.numbers.push(parser.getNumber());
								}
								while (global::alphatab.rendering.utils.SvgPathParser.isNumber(parser.currentToken, default(global::haxe.lang.Null<bool>)));
								break;
							}
							
							
							case "t":
							{
								command.numbers = new global::haxe.root.Array<int>();
								do {
									command.numbers.push(parser.getNumber());
									command.numbers.push(parser.getNumber());
								}
								while (global::alphatab.rendering.utils.SvgPathParser.isNumber(parser.currentToken, default(global::haxe.lang.Null<bool>)));
								break;
							}
							
							
						}
						
					}
					
				}
				
				this._raw = default(string);
			}
		}
		
		
		public override   object __hx_setField(string field, int hash, object @value, bool handleProperties){
			unchecked {
				switch (hash){
					case 1543482992:
					{
						this._parsed = ((global::haxe.root.Array<object>) (global::haxe.root.Array<object>.__hx_cast<object>(((global::haxe.root.Array) (@value) ))) );
						return @value;
					}
					
					
					case 1059199721:
					{
						this._raw = global::haxe.lang.Runtime.toString(@value);
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
					case 1029017651:
					{
						return ((global::haxe.lang.Function) (new global::haxe.lang.Closure(((object) (this) ), ((string) ("parse") ), ((int) (1029017651) ))) );
					}
					
					
					case 5144726:
					{
						return ((global::haxe.lang.Function) (new global::haxe.lang.Closure(((object) (this) ), ((string) ("get") ), ((int) (5144726) ))) );
					}
					
					
					case 1543482992:
					{
						return this._parsed;
					}
					
					
					case 1059199721:
					{
						return this._raw;
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
					case 1029017651:
					{
						this.parse();
						break;
					}
					
					
					case 5144726:
					{
						return this.@get();
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
				baseArr.push("_parsed");
				baseArr.push("_raw");
				{
					base.__hx_getFields(baseArr);
				}
				
			}
		}
		
		
	}
}


