using haxe.root;
#pragma warning disable 109, 114, 219, 429, 168, 162
namespace alphatab.rendering.utils{
	public  class AccidentalHelper : global::haxe.lang.HxObject {
		static AccidentalHelper() {
			global::alphatab.rendering.utils.AccidentalHelper.AccidentalNotes = new global::haxe.root.Array<object>(new object[]{new global::haxe.root.Array<global::alphatab.model.AccidentalType>(new global::alphatab.model.AccidentalType[]{global::alphatab.model.AccidentalType.Natural, global::alphatab.model.AccidentalType.None, global::alphatab.model.AccidentalType.Natural, global::alphatab.model.AccidentalType.None, global::alphatab.model.AccidentalType.Natural, global::alphatab.model.AccidentalType.Natural, global::alphatab.model.AccidentalType.None, global::alphatab.model.AccidentalType.Natural, global::alphatab.model.AccidentalType.None, global::alphatab.model.AccidentalType.Natural, global::alphatab.model.AccidentalType.None, global::alphatab.model.AccidentalType.Natural}), new global::haxe.root.Array<global::alphatab.model.AccidentalType>(new global::alphatab.model.AccidentalType[]{global::alphatab.model.AccidentalType.Natural, global::alphatab.model.AccidentalType.None, global::alphatab.model.AccidentalType.Natural, global::alphatab.model.AccidentalType.None, global::alphatab.model.AccidentalType.Natural, global::alphatab.model.AccidentalType.None, global::alphatab.model.AccidentalType.None, global::alphatab.model.AccidentalType.Natural, global::alphatab.model.AccidentalType.None, global::alphatab.model.AccidentalType.Natural, global::alphatab.model.AccidentalType.None, global::alphatab.model.AccidentalType.Natural}), new global::haxe.root.Array<global::alphatab.model.AccidentalType>(new global::alphatab.model.AccidentalType[]{global::alphatab.model.AccidentalType.None, global::alphatab.model.AccidentalType.None, global::alphatab.model.AccidentalType.Natural, global::alphatab.model.AccidentalType.None, global::alphatab.model.AccidentalType.Natural, global::alphatab.model.AccidentalType.None, global::alphatab.model.AccidentalType.None, global::alphatab.model.AccidentalType.Natural, global::alphatab.model.AccidentalType.None, global::alphatab.model.AccidentalType.Natural, global::alphatab.model.AccidentalType.None, global::alphatab.model.AccidentalType.Natural}), new global::haxe.root.Array<global::alphatab.model.AccidentalType>(new global::alphatab.model.AccidentalType[]{global::alphatab.model.AccidentalType.None, global::alphatab.model.AccidentalType.None, global::alphatab.model.AccidentalType.Natural, global::alphatab.model.AccidentalType.None, global::alphatab.model.AccidentalType.Natural, global::alphatab.model.AccidentalType.None, global::alphatab.model.AccidentalType.Flat, global::alphatab.model.AccidentalType.Natural, global::alphatab.model.AccidentalType.None, global::alphatab.model.AccidentalType.Natural, global::alphatab.model.AccidentalType.None, global::alphatab.model.AccidentalType.Natural}), new global::haxe.root.Array<global::alphatab.model.AccidentalType>(new global::alphatab.model.AccidentalType[]{global::alphatab.model.AccidentalType.None, global::alphatab.model.AccidentalType.Flat, global::alphatab.model.AccidentalType.Natural, global::alphatab.model.AccidentalType.None, global::alphatab.model.AccidentalType.Natural, global::alphatab.model.AccidentalType.None, global::alphatab.model.AccidentalType.Flat, global::alphatab.model.AccidentalType.Natural, global::alphatab.model.AccidentalType.None, global::alphatab.model.AccidentalType.Natural, global::alphatab.model.AccidentalType.None, global::alphatab.model.AccidentalType.Natural}), new global::haxe.root.Array<global::alphatab.model.AccidentalType>(new global::alphatab.model.AccidentalType[]{global::alphatab.model.AccidentalType.None, global::alphatab.model.AccidentalType.Flat, global::alphatab.model.AccidentalType.Natural, global::alphatab.model.AccidentalType.None, global::alphatab.model.AccidentalType.Natural, global::alphatab.model.AccidentalType.None, global::alphatab.model.AccidentalType.Flat, global::alphatab.model.AccidentalType.Natural, global::alphatab.model.AccidentalType.Flat, global::alphatab.model.AccidentalType.Natural, global::alphatab.model.AccidentalType.None, global::alphatab.model.AccidentalType.Natural}), new global::haxe.root.Array<global::alphatab.model.AccidentalType>(new global::alphatab.model.AccidentalType[]{global::alphatab.model.AccidentalType.None, global::alphatab.model.AccidentalType.Flat, global::alphatab.model.AccidentalType.Natural, global::alphatab.model.AccidentalType.Flat, global::alphatab.model.AccidentalType.Natural, global::alphatab.model.AccidentalType.None, global::alphatab.model.AccidentalType.Flat, global::alphatab.model.AccidentalType.Natural, global::alphatab.model.AccidentalType.Flat, global::alphatab.model.AccidentalType.Natural, global::alphatab.model.AccidentalType.None, global::alphatab.model.AccidentalType.Natural}), new global::haxe.root.Array<global::alphatab.model.AccidentalType>(new global::alphatab.model.AccidentalType[]{global::alphatab.model.AccidentalType.None, global::alphatab.model.AccidentalType.Sharp, global::alphatab.model.AccidentalType.None, global::alphatab.model.AccidentalType.Sharp, global::alphatab.model.AccidentalType.None, global::alphatab.model.AccidentalType.None, global::alphatab.model.AccidentalType.Sharp, global::alphatab.model.AccidentalType.None, global::alphatab.model.AccidentalType.Sharp, global::alphatab.model.AccidentalType.None, global::alphatab.model.AccidentalType.Sharp, global::alphatab.model.AccidentalType.None}), new global::haxe.root.Array<global::alphatab.model.AccidentalType>(new global::alphatab.model.AccidentalType[]{global::alphatab.model.AccidentalType.None, global::alphatab.model.AccidentalType.Sharp, global::alphatab.model.AccidentalType.None, global::alphatab.model.AccidentalType.Sharp, global::alphatab.model.AccidentalType.None, global::alphatab.model.AccidentalType.Natural, global::alphatab.model.AccidentalType.Sharp, global::alphatab.model.AccidentalType.None, global::alphatab.model.AccidentalType.Sharp, global::alphatab.model.AccidentalType.None, global::alphatab.model.AccidentalType.Sharp, global::alphatab.model.AccidentalType.None}), new global::haxe.root.Array<global::alphatab.model.AccidentalType>(new global::alphatab.model.AccidentalType[]{global::alphatab.model.AccidentalType.Natural, global::alphatab.model.AccidentalType.Sharp, global::alphatab.model.AccidentalType.None, global::alphatab.model.AccidentalType.Sharp, global::alphatab.model.AccidentalType.None, global::alphatab.model.AccidentalType.Natural, global::alphatab.model.AccidentalType.Sharp, global::alphatab.model.AccidentalType.None, global::alphatab.model.AccidentalType.Sharp, global::alphatab.model.AccidentalType.None, global::alphatab.model.AccidentalType.Sharp, global::alphatab.model.AccidentalType.None}), new global::haxe.root.Array<global::alphatab.model.AccidentalType>(new global::alphatab.model.AccidentalType[]{global::alphatab.model.AccidentalType.Natural, global::alphatab.model.AccidentalType.Sharp, global::alphatab.model.AccidentalType.None, global::alphatab.model.AccidentalType.Sharp, global::alphatab.model.AccidentalType.None, global::alphatab.model.AccidentalType.Natural, global::alphatab.model.AccidentalType.Sharp, global::alphatab.model.AccidentalType.Natural, global::alphatab.model.AccidentalType.Sharp, global::alphatab.model.AccidentalType.None, global::alphatab.model.AccidentalType.Sharp, global::alphatab.model.AccidentalType.None}), new global::haxe.root.Array<global::alphatab.model.AccidentalType>(new global::alphatab.model.AccidentalType[]{global::alphatab.model.AccidentalType.Natural, global::alphatab.model.AccidentalType.Sharp, global::alphatab.model.AccidentalType.Natural, global::alphatab.model.AccidentalType.Sharp, global::alphatab.model.AccidentalType.None, global::alphatab.model.AccidentalType.Natural, global::alphatab.model.AccidentalType.Sharp, global::alphatab.model.AccidentalType.Natural, global::alphatab.model.AccidentalType.Sharp, global::alphatab.model.AccidentalType.None, global::alphatab.model.AccidentalType.Sharp, global::alphatab.model.AccidentalType.None}), new global::haxe.root.Array<global::alphatab.model.AccidentalType>(new global::alphatab.model.AccidentalType[]{global::alphatab.model.AccidentalType.Natural, global::alphatab.model.AccidentalType.Sharp, global::alphatab.model.AccidentalType.Natural, global::alphatab.model.AccidentalType.Sharp, global::alphatab.model.AccidentalType.None, global::alphatab.model.AccidentalType.Natural, global::alphatab.model.AccidentalType.Sharp, global::alphatab.model.AccidentalType.Natural, global::alphatab.model.AccidentalType.Sharp, global::alphatab.model.AccidentalType.Natural, global::alphatab.model.AccidentalType.Sharp, global::alphatab.model.AccidentalType.None}), new global::haxe.root.Array<global::alphatab.model.AccidentalType>(new global::alphatab.model.AccidentalType[]{global::alphatab.model.AccidentalType.Natural, global::alphatab.model.AccidentalType.Sharp, global::alphatab.model.AccidentalType.Natural, global::alphatab.model.AccidentalType.Sharp, global::alphatab.model.AccidentalType.Natural, global::alphatab.model.AccidentalType.Natural, global::alphatab.model.AccidentalType.Sharp, global::alphatab.model.AccidentalType.Natural, global::alphatab.model.AccidentalType.Sharp, global::alphatab.model.AccidentalType.Natural, global::alphatab.model.AccidentalType.Sharp, global::alphatab.model.AccidentalType.None}), new global::haxe.root.Array<global::alphatab.model.AccidentalType>(new global::alphatab.model.AccidentalType[]{global::alphatab.model.AccidentalType.Natural, global::alphatab.model.AccidentalType.Sharp, global::alphatab.model.AccidentalType.Natural, global::alphatab.model.AccidentalType.Sharp, global::alphatab.model.AccidentalType.Natural, global::alphatab.model.AccidentalType.Natural, global::alphatab.model.AccidentalType.Sharp, global::alphatab.model.AccidentalType.Natural, global::alphatab.model.AccidentalType.Sharp, global::alphatab.model.AccidentalType.Natural, global::alphatab.model.AccidentalType.Sharp, global::alphatab.model.AccidentalType.Natural})});
		}
		public    AccidentalHelper(global::haxe.lang.EmptyObject empty){
			unchecked {
				{
				}
				
			}
		}
		
		
		public    AccidentalHelper(){
			unchecked {
				global::alphatab.rendering.utils.AccidentalHelper.__hx_ctor_alphatab_rendering_utils_AccidentalHelper(this);
			}
		}
		
		
		public static   void __hx_ctor_alphatab_rendering_utils_AccidentalHelper(global::alphatab.rendering.utils.AccidentalHelper __temp_me283){
			unchecked {
				__temp_me283._registeredAccidentals = new global::haxe.ds.IntMap<global::alphatab.model.AccidentalType>();
			}
		}
		
		
		public static  global::haxe.root.Array<object> AccidentalNotes;
		
		public static  new object __hx_createEmpty(){
			unchecked {
				return new global::alphatab.rendering.utils.AccidentalHelper(((global::haxe.lang.EmptyObject) (global::haxe.lang.EmptyObject.EMPTY) ));
			}
		}
		
		
		public static  new object __hx_create(global::haxe.root.Array arr){
			unchecked {
				return new global::alphatab.rendering.utils.AccidentalHelper();
			}
		}
		
		
		public  global::haxe.ds.IntMap<global::alphatab.model.AccidentalType> _registeredAccidentals;
		
		public virtual   global::alphatab.model.AccidentalType applyAccidental(global::alphatab.model.Note note, int noteLine){
			unchecked {
				int noteValue = ( note.fret + note.beat.voice.bar.track.tuning[( ( note.beat.voice.bar.track.tuning.length - (( note.@string - 1 )) ) - 1 )] );
				global::alphatab.model.MasterBar __temp_stmt638 = default(global::alphatab.model.MasterBar);
				{
					global::alphatab.model.Bar _this = note.beat.voice.bar;
					__temp_stmt638 = ((global::alphatab.model.MasterBar) (_this.track.score.masterBars[_this.index]) );
				}
				
				int ks = __temp_stmt638.keySignature;
				int ksi = ( ks + 7 );
				int index = ( noteValue % 12 );
				int octave = ( noteValue / 12 );
				global::alphatab.model.AccidentalType accidentalToSet = ((global::haxe.root.Array<global::alphatab.model.AccidentalType>) (global::haxe.root.Array<object>.__hx_cast<global::alphatab.model.AccidentalType>(((global::haxe.root.Array) (global::alphatab.rendering.utils.AccidentalHelper.AccidentalNotes[ksi]) ))) )[index];
				bool updateAccidental = true;
				if (this._registeredAccidentals.exists(noteLine)) {
					global::haxe.lang.Null<global::alphatab.model.AccidentalType> registeredAccidental = this._registeredAccidentals.@get(noteLine);
					if (global::haxe.lang.Runtime.eq((registeredAccidental).toDynamic(), accidentalToSet)) {
						accidentalToSet = global::alphatab.model.AccidentalType.None;
						updateAccidental = false;
					}
					 else {
						if (( accidentalToSet == global::alphatab.model.AccidentalType.None )) {
							accidentalToSet = global::alphatab.model.AccidentalType.Natural;
						}
						
					}
					
				}
				
				if (updateAccidental) {
					if (( ( accidentalToSet == global::alphatab.model.AccidentalType.None ) || ( accidentalToSet == global::alphatab.model.AccidentalType.Natural ) )) {
						this._registeredAccidentals.@remove(noteLine);
					}
					 else {
						this._registeredAccidentals.@set(noteLine, accidentalToSet);
					}
					
				}
				
				return accidentalToSet;
			}
		}
		
		
		public   int getKeySignatureIndex(int ks){
			unchecked {
				return ( ks + 7 );
			}
		}
		
		
		public override   object __hx_setField(string field, int hash, object @value, bool handleProperties){
			unchecked {
				switch (hash){
					case 329786712:
					{
						this._registeredAccidentals = ((global::haxe.ds.IntMap<global::alphatab.model.AccidentalType>) (global::haxe.ds.IntMap<object>.__hx_cast<global::alphatab.model.AccidentalType>(((global::haxe.ds.IntMap) (@value) ))) );
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
					case 1066332547:
					{
						return ((global::haxe.lang.Function) (new global::haxe.lang.Closure(((object) (this) ), ((string) ("getKeySignatureIndex") ), ((int) (1066332547) ))) );
					}
					
					
					case 1217412040:
					{
						return ((global::haxe.lang.Function) (new global::haxe.lang.Closure(((object) (this) ), ((string) ("applyAccidental") ), ((int) (1217412040) ))) );
					}
					
					
					case 329786712:
					{
						return this._registeredAccidentals;
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
					case 1066332547:
					{
						return this.getKeySignatureIndex(((int) (global::haxe.lang.Runtime.toInt(dynargs[0])) ));
					}
					
					
					case 1217412040:
					{
						return this.applyAccidental(((global::alphatab.model.Note) (dynargs[0]) ), ((int) (global::haxe.lang.Runtime.toInt(dynargs[1])) ));
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
				baseArr.push("_registeredAccidentals");
				{
					base.__hx_getFields(baseArr);
				}
				
			}
		}
		
		
	}
}


