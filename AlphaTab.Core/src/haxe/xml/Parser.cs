using haxe.root;
#pragma warning disable 109, 114, 219, 429, 168, 162
namespace haxe.xml{
	public  class Parser : global::haxe.lang.HxObject {
		static Parser() {
			{
				global::haxe.ds.StringMap<object> h = new global::haxe.ds.StringMap<object>();
				h.@set("lt", "<");
				h.@set("gt", ">");
				h.@set("amp", "&");
				h.@set("quot", "\"");
				h.@set("apos", "\'");
				h.@set("nbsp", new string(((char) (160) ), 1));
				global::haxe.xml.Parser.escapes = h;
			}
			
		}
		public    Parser(global::haxe.lang.EmptyObject empty){
			unchecked {
				{
				}
				
			}
		}
		
		
		public    Parser(){
			unchecked {
				global::haxe.xml.Parser.__hx_ctor_haxe_xml_Parser(this);
			}
		}
		
		
		public static   void __hx_ctor_haxe_xml_Parser(global::haxe.xml.Parser __temp_me318){
			unchecked {
				{
				}
				
			}
		}
		
		
		public static  global::haxe.ds.StringMap<object> escapes;
		
		public static   global::haxe.root.Xml parse(string str){
			unchecked {
				global::haxe.root.Xml doc = global::haxe.root.Xml.createDocument();
				global::haxe.xml.Parser.doParse(str, new global::haxe.lang.Null<int>(0, true), doc);
				return doc;
			}
		}
		
		
		public static   int doParse(string str, global::haxe.lang.Null<int> p, global::haxe.root.Xml parent){
			unchecked {
				int __temp_p317 = ( ( ! (p.hasValue) ) ? (((int) (0) )) : (p.@value) );
				global::haxe.root.Xml xml = default(global::haxe.root.Xml);
				int state = 1;
				int next = 1;
				string aname = default(string);
				int start = 0;
				int nsubs = 0;
				int nbrackets = 0;
				int c = default(int);
				if (( ((uint) (__temp_p317) ) < str.Length )) {
					c = ((int) (global::haxe.lang.Runtime.toInt(str[__temp_p317])) );
				}
				 else {
					c = -1;
				}
				
				global::haxe.root.StringBuf buf = new global::haxe.root.StringBuf();
				while ( ! ((( c == -1 ))) ){
					switch (state){
						case 0:
						{
							switch (c){
								case 10:case 13:case 9:case 32:
								{
									{
									}
									
									break;
								}
								
								
								default:
								{
									state = next;
									continue;
								}
								
							}
							
							break;
						}
						
						
						case 1:
						{
							switch (c){
								case 60:
								{
									state = 0;
									next = 2;
									break;
								}
								
								
								default:
								{
									start = __temp_p317;
									state = 13;
									continue;
								}
								
							}
							
							break;
						}
						
						
						case 13:
						{
							if (( c == 60 )) {
								global::haxe.root.Xml child = global::haxe.root.Xml.createPCData(global::haxe.lang.Runtime.concat(buf.toString(), global::haxe.lang.StringExt.substr(str, start, new global::haxe.lang.Null<int>(( __temp_p317 - start ), true))));
								buf = new global::haxe.root.StringBuf();
								parent.addChild(child);
								nsubs++;
								state = 0;
								next = 2;
							}
							 else {
								if (( c == 38 )) {
									buf.addSub(str, start, new global::haxe.lang.Null<int>(( __temp_p317 - start ), true));
									state = 18;
									next = 13;
									start = ( __temp_p317 + 1 );
								}
								
							}
							
							break;
						}
						
						
						case 17:
						{
							bool __temp_boolv645 = ( c == 93 );
							bool __temp_boolv644 = false;
							bool __temp_boolv643 = false;
							if (__temp_boolv645) {
								int __temp_stmt646 = default(int);
								{
									int index = ( __temp_p317 + 1 );
									__temp_stmt646 = ( (( ((uint) (index) ) < str.Length )) ? (((int) (global::haxe.lang.Runtime.toInt(str[index])) )) : (-1) );
								}
								
								__temp_boolv644 = ( __temp_stmt646 == 93 );
								if (__temp_boolv644) {
									int __temp_stmt647 = default(int);
									{
										int index1 = ( __temp_p317 + 2 );
										__temp_stmt647 = ( (( ((uint) (index1) ) < str.Length )) ? (((int) (global::haxe.lang.Runtime.toInt(str[index1])) )) : (-1) );
									}
									
									__temp_boolv643 = ( __temp_stmt647 == 62 );
								}
								
							}
							
							bool __temp_stmt642 = ( ( __temp_boolv645 && __temp_boolv644 ) && __temp_boolv643 );
							if (__temp_stmt642) {
								global::haxe.root.Xml child1 = global::haxe.root.Xml.createCData(global::haxe.lang.StringExt.substr(str, start, new global::haxe.lang.Null<int>(( __temp_p317 - start ), true)));
								parent.addChild(child1);
								nsubs++;
								__temp_p317 += 2;
								state = 1;
							}
							
							break;
						}
						
						
						case 2:
						{
							switch (c){
								case 33:
								{
									int __temp_stmt648 = default(int);
									{
										int index2 = ( __temp_p317 + 1 );
										__temp_stmt648 = ( (( ((uint) (index2) ) < str.Length )) ? (((int) (global::haxe.lang.Runtime.toInt(str[index2])) )) : (-1) );
									}
									
									if (( __temp_stmt648 == 91 )) {
										__temp_p317 += 2;
										if ( ! (string.Equals(global::haxe.lang.StringExt.substr(str, __temp_p317, new global::haxe.lang.Null<int>(6, true)).ToUpper(), "CDATA[")) ) {
											throw global::haxe.lang.HaxeException.wrap("Expected <![CDATA[");
										}
										
										__temp_p317 += 5;
										state = 17;
										start = ( __temp_p317 + 1 );
									}
									 else {
										int __temp_stmt651 = default(int);
										{
											int index3 = ( __temp_p317 + 1 );
											__temp_stmt651 = ( (( ((uint) (index3) ) < str.Length )) ? (((int) (global::haxe.lang.Runtime.toInt(str[index3])) )) : (-1) );
										}
										
										bool __temp_stmt650 = ( __temp_stmt651 == 68 );
										bool __temp_boolv652 = false;
										if ( ! (__temp_stmt650) ) {
											int __temp_stmt653 = default(int);
											{
												int index4 = ( __temp_p317 + 1 );
												__temp_stmt653 = ( (( ((uint) (index4) ) < str.Length )) ? (((int) (global::haxe.lang.Runtime.toInt(str[index4])) )) : (-1) );
											}
											
											__temp_boolv652 = ( __temp_stmt653 == 100 );
										}
										
										bool __temp_stmt649 = ( __temp_stmt650 || __temp_boolv652 );
										if (__temp_stmt649) {
											if ( ! (string.Equals(global::haxe.lang.StringExt.substr(str, ( __temp_p317 + 2 ), new global::haxe.lang.Null<int>(6, true)).ToUpper(), "OCTYPE")) ) {
												throw global::haxe.lang.HaxeException.wrap("Expected <!DOCTYPE");
											}
											
											__temp_p317 += 8;
											state = 16;
											start = ( __temp_p317 + 1 );
										}
										 else {
											int __temp_stmt656 = default(int);
											{
												int index5 = ( __temp_p317 + 1 );
												__temp_stmt656 = ( (( ((uint) (index5) ) < str.Length )) ? (((int) (global::haxe.lang.Runtime.toInt(str[index5])) )) : (-1) );
											}
											
											bool __temp_stmt655 = ( __temp_stmt656 != 45 );
											bool __temp_boolv657 = false;
											if ( ! (__temp_stmt655) ) {
												int __temp_stmt658 = default(int);
												{
													int index6 = ( __temp_p317 + 2 );
													__temp_stmt658 = ( (( ((uint) (index6) ) < str.Length )) ? (((int) (global::haxe.lang.Runtime.toInt(str[index6])) )) : (-1) );
												}
												
												__temp_boolv657 = ( __temp_stmt658 != 45 );
											}
											
											bool __temp_stmt654 = ( __temp_stmt655 || __temp_boolv657 );
											if (__temp_stmt654) {
												throw global::haxe.lang.HaxeException.wrap("Expected <!--");
											}
											 else {
												__temp_p317 += 2;
												state = 15;
												start = ( __temp_p317 + 1 );
											}
											
										}
										
									}
									
									break;
								}
								
								
								case 63:
								{
									state = 14;
									start = __temp_p317;
									break;
								}
								
								
								case 47:
								{
									if (( parent == default(global::haxe.root.Xml) )) {
										throw global::haxe.lang.HaxeException.wrap("Expected node name");
									}
									
									start = ( __temp_p317 + 1 );
									state = 0;
									next = 10;
									break;
								}
								
								
								default:
								{
									state = 3;
									start = __temp_p317;
									continue;
								}
								
							}
							
							break;
						}
						
						
						case 3:
						{
							if ( ! ((( ( ( ( ( ( ( ( c >= 97 ) && ( c <= 122 ) ) || ( ( c >= 65 ) && ( c <= 90 ) ) ) || ( ( c >= 48 ) && ( c <= 57 ) ) ) || ( c == 58 ) ) || ( c == 46 ) ) || ( c == 95 ) ) || ( c == 45 ) ))) ) {
								if (( __temp_p317 == start )) {
									throw global::haxe.lang.HaxeException.wrap("Expected node name");
								}
								
								xml = global::haxe.root.Xml.createElement(global::haxe.lang.StringExt.substr(str, start, new global::haxe.lang.Null<int>(( __temp_p317 - start ), true)));
								parent.addChild(xml);
								state = 0;
								next = 4;
								continue;
							}
							
							break;
						}
						
						
						case 4:
						{
							switch (c){
								case 47:
								{
									state = 11;
									nsubs++;
									break;
								}
								
								
								case 62:
								{
									state = 9;
									nsubs++;
									break;
								}
								
								
								default:
								{
									state = 5;
									start = __temp_p317;
									continue;
								}
								
							}
							
							break;
						}
						
						
						case 5:
						{
							if ( ! ((( ( ( ( ( ( ( ( c >= 97 ) && ( c <= 122 ) ) || ( ( c >= 65 ) && ( c <= 90 ) ) ) || ( ( c >= 48 ) && ( c <= 57 ) ) ) || ( c == 58 ) ) || ( c == 46 ) ) || ( c == 95 ) ) || ( c == 45 ) ))) ) {
								string tmp = default(string);
								if (( start == __temp_p317 )) {
									throw global::haxe.lang.HaxeException.wrap("Expected attribute name");
								}
								
								tmp = global::haxe.lang.StringExt.substr(str, start, new global::haxe.lang.Null<int>(( __temp_p317 - start ), true));
								aname = tmp;
								if (xml.exists(aname)) {
									throw global::haxe.lang.HaxeException.wrap("Duplicate attribute");
								}
								
								state = 0;
								next = 6;
								continue;
							}
							
							break;
						}
						
						
						case 6:
						{
							switch (c){
								case 61:
								{
									state = 0;
									next = 7;
									break;
								}
								
								
								default:
								{
									throw global::haxe.lang.HaxeException.wrap("Expected =");
								}
								
							}
							
							break;
						}
						
						
						case 7:
						{
							switch (c){
								case 34:case 39:
								{
									state = 8;
									start = __temp_p317;
									break;
								}
								
								
								default:
								{
									throw global::haxe.lang.HaxeException.wrap("Expected \"");
								}
								
							}
							
							break;
						}
						
						
						case 8:
						{
							if (( c == (( (( ((uint) (start) ) < str.Length )) ? (((int) (global::haxe.lang.Runtime.toInt(str[start])) )) : (-1) )) )) {
								string val = global::haxe.lang.StringExt.substr(str, ( start + 1 ), new global::haxe.lang.Null<int>(( ( __temp_p317 - start ) - 1 ), true));
								xml.@set(aname, val);
								state = 0;
								next = 4;
							}
							
							break;
						}
						
						
						case 9:
						{
							__temp_p317 = global::haxe.xml.Parser.doParse(str, new global::haxe.lang.Null<int>(__temp_p317, true), xml);
							start = __temp_p317;
							state = 1;
							break;
						}
						
						
						case 11:
						{
							switch (c){
								case 62:
								{
									state = 1;
									break;
								}
								
								
								default:
								{
									throw global::haxe.lang.HaxeException.wrap("Expected >");
								}
								
							}
							
							break;
						}
						
						
						case 12:
						{
							switch (c){
								case 62:
								{
									if (( nsubs == 0 )) {
										parent.addChild(global::haxe.root.Xml.createPCData(""));
									}
									
									return __temp_p317;
								}
								
								
								default:
								{
									throw global::haxe.lang.HaxeException.wrap("Expected >");
								}
								
							}
							
						}
						
						
						case 10:
						{
							if ( ! ((( ( ( ( ( ( ( ( c >= 97 ) && ( c <= 122 ) ) || ( ( c >= 65 ) && ( c <= 90 ) ) ) || ( ( c >= 48 ) && ( c <= 57 ) ) ) || ( c == 58 ) ) || ( c == 46 ) ) || ( c == 95 ) ) || ( c == 45 ) ))) ) {
								if (( start == __temp_p317 )) {
									throw global::haxe.lang.HaxeException.wrap("Expected node name");
								}
								
								string v = global::haxe.lang.StringExt.substr(str, start, new global::haxe.lang.Null<int>(( __temp_p317 - start ), true));
								if ( ! (string.Equals(v, parent.get_nodeName())) ) {
									throw global::haxe.lang.HaxeException.wrap(global::haxe.lang.Runtime.concat(global::haxe.lang.Runtime.concat("Expected </", parent.get_nodeName()), ">"));
								}
								
								state = 0;
								next = 12;
								continue;
							}
							
							break;
						}
						
						
						case 15:
						{
							bool __temp_boolv662 = ( c == 45 );
							bool __temp_boolv661 = false;
							bool __temp_boolv660 = false;
							if (__temp_boolv662) {
								int __temp_stmt663 = default(int);
								{
									int index7 = ( __temp_p317 + 1 );
									__temp_stmt663 = ( (( ((uint) (index7) ) < str.Length )) ? (((int) (global::haxe.lang.Runtime.toInt(str[index7])) )) : (-1) );
								}
								
								__temp_boolv661 = ( __temp_stmt663 == 45 );
								if (__temp_boolv661) {
									int __temp_stmt664 = default(int);
									{
										int index8 = ( __temp_p317 + 2 );
										__temp_stmt664 = ( (( ((uint) (index8) ) < str.Length )) ? (((int) (global::haxe.lang.Runtime.toInt(str[index8])) )) : (-1) );
									}
									
									__temp_boolv660 = ( __temp_stmt664 == 62 );
								}
								
							}
							
							bool __temp_stmt659 = ( ( __temp_boolv662 && __temp_boolv661 ) && __temp_boolv660 );
							if (__temp_stmt659) {
								parent.addChild(global::haxe.root.Xml.createComment(global::haxe.lang.StringExt.substr(str, start, new global::haxe.lang.Null<int>(( __temp_p317 - start ), true))));
								__temp_p317 += 2;
								state = 1;
							}
							
							break;
						}
						
						
						case 16:
						{
							if (( c == 91 )) {
								nbrackets++;
							}
							 else {
								if (( c == 93 )) {
									nbrackets--;
								}
								 else {
									if (( ( c == 62 ) && ( nbrackets == 0 ) )) {
										parent.addChild(global::haxe.root.Xml.createDocType(global::haxe.lang.StringExt.substr(str, start, new global::haxe.lang.Null<int>(( __temp_p317 - start ), true))));
										state = 1;
									}
									
								}
								
							}
							
							break;
						}
						
						
						case 14:
						{
							bool __temp_boolv667 = ( c == 63 );
							bool __temp_boolv666 = false;
							if (__temp_boolv667) {
								int __temp_stmt668 = default(int);
								{
									int index9 = ( __temp_p317 + 1 );
									__temp_stmt668 = ( (( ((uint) (index9) ) < str.Length )) ? (((int) (global::haxe.lang.Runtime.toInt(str[index9])) )) : (-1) );
								}
								
								__temp_boolv666 = ( __temp_stmt668 == 62 );
							}
							
							bool __temp_stmt665 = ( __temp_boolv667 && __temp_boolv666 );
							if (__temp_stmt665) {
								__temp_p317++;
								string str1 = global::haxe.lang.StringExt.substr(str, ( start + 1 ), new global::haxe.lang.Null<int>(( ( __temp_p317 - start ) - 2 ), true));
								parent.addChild(global::haxe.root.Xml.createProcessingInstruction(str1));
								state = 1;
							}
							
							break;
						}
						
						
						case 18:
						{
							if (( c == 59 )) {
								string s = global::haxe.lang.StringExt.substr(str, start, new global::haxe.lang.Null<int>(( __temp_p317 - start ), true));
								if (( (( (( ((uint) (0) ) < s.Length )) ? (((int) (global::haxe.lang.Runtime.toInt(s[0])) )) : (-1) )) == 35 )) {
									global::haxe.lang.Null<int> i = default(global::haxe.lang.Null<int>);
									if (( (( (( ((uint) (1) ) < s.Length )) ? (((int) (global::haxe.lang.Runtime.toInt(s[1])) )) : (-1) )) == 120 )) {
										i = global::haxe.root.Std.parseInt(global::haxe.lang.Runtime.concat("0", global::haxe.lang.StringExt.substr(s, 1, new global::haxe.lang.Null<int>(( s.Length - 1 ), true))));
									}
									 else {
										i = global::haxe.root.Std.parseInt(global::haxe.lang.StringExt.substr(s, 1, new global::haxe.lang.Null<int>(( s.Length - 1 ), true)));
									}
									
									{
										string x = new string(((char) (i.@value) ), 1);
										buf.b.Append(((object) (global::haxe.root.Std.@string(x)) ));
									}
									
								}
								 else {
									if ( ! (global::haxe.xml.Parser.escapes.exists(s)) ) {
										buf.b.Append(((object) (global::haxe.root.Std.@string(global::haxe.lang.Runtime.concat(global::haxe.lang.Runtime.concat("&", s), ";"))) ));
									}
									 else {
										string x1 = global::haxe.lang.Runtime.toString(global::haxe.xml.Parser.escapes.@get(s).@value);
										buf.b.Append(((object) (global::haxe.root.Std.@string(x1)) ));
									}
									
								}
								
								start = ( __temp_p317 + 1 );
								state = next;
							}
							
							break;
						}
						
						
					}
					
					{
						int index10 =  ++ __temp_p317;
						if (( ((uint) (index10) ) < str.Length )) {
							c = ((int) (global::haxe.lang.Runtime.toInt(str[index10])) );
						}
						 else {
							c = -1;
						}
						
					}
					
				}
				
				if (( state == 1 )) {
					start = __temp_p317;
					state = 13;
				}
				
				if (( state == 13 )) {
					if (( ( __temp_p317 != start ) || ( nsubs == 0 ) )) {
						parent.addChild(global::haxe.root.Xml.createPCData(global::haxe.lang.Runtime.concat(buf.toString(), global::haxe.lang.StringExt.substr(str, start, new global::haxe.lang.Null<int>(( __temp_p317 - start ), true)))));
					}
					
					return __temp_p317;
				}
				
				throw global::haxe.lang.HaxeException.wrap("Unexpected end");
			}
		}
		
		
		public static  new object __hx_createEmpty(){
			unchecked {
				return new global::haxe.xml.Parser(((global::haxe.lang.EmptyObject) (global::haxe.lang.EmptyObject.EMPTY) ));
			}
		}
		
		
		public static  new object __hx_create(global::haxe.root.Array arr){
			unchecked {
				return new global::haxe.xml.Parser();
			}
		}
		
		
	}
}


