using haxe.root;
#pragma warning disable 109, 114, 219, 429, 168, 162
namespace alphatab.rendering.utils{
	public  class BarHelpers : global::haxe.lang.HxObject {
		public    BarHelpers(global::haxe.lang.EmptyObject empty){
			unchecked {
				{
				}
				
			}
		}
		
		
		public    BarHelpers(global::alphatab.model.Bar bar){
			unchecked {
				global::alphatab.rendering.utils.BarHelpers.__hx_ctor_alphatab_rendering_utils_BarHelpers(this, bar);
			}
		}
		
		
		public static   void __hx_ctor_alphatab_rendering_utils_BarHelpers(global::alphatab.rendering.utils.BarHelpers __temp_me284, global::alphatab.model.Bar bar){
			unchecked {
				__temp_me284.beamHelpers = new global::haxe.root.Array<object>();
				__temp_me284.beamHelperLookup = new global::haxe.root.Array<object>();
				__temp_me284.tupletHelpers = new global::haxe.root.Array<object>();
				global::alphatab.rendering.utils.BeamingHelper currentBeamHelper = default(global::alphatab.rendering.utils.BeamingHelper);
				global::alphatab.rendering.utils.TupletHelper currentTupletHelper = default(global::alphatab.rendering.utils.TupletHelper);
				{
					int _g = 0;
					global::haxe.root.Array<object> _g1 = bar.voices;
					while (( _g < _g1.length )){
						global::alphatab.model.Voice v = ((global::alphatab.model.Voice) (_g1[_g]) );
						 ++ _g;
						__temp_me284.beamHelpers.push(new global::haxe.root.Array<object>());
						__temp_me284.beamHelperLookup.push(new global::haxe.ds.IntMap<object>());
						__temp_me284.tupletHelpers.push(new global::haxe.root.Array<object>());
						{
							int _g2 = 0;
							global::haxe.root.Array<object> _g3 = v.beats;
							while (( _g2 < _g3.length )){
								global::alphatab.model.Beat b = ((global::alphatab.model.Beat) (_g3[_g2]) );
								 ++ _g2;
								bool newBeamingHelper = false;
								if ( ! (b.isRest()) ) {
									if (( ( currentBeamHelper == default(global::alphatab.rendering.utils.BeamingHelper) ) ||  ! (currentBeamHelper.checkBeat(b))  )) {
										currentBeamHelper = new global::alphatab.rendering.utils.BeamingHelper(((global::alphatab.model.Track) (bar.track) ));
										currentBeamHelper.checkBeat(b);
										((global::haxe.root.Array<object>) (global::haxe.root.Array<object>.__hx_cast<object>(((global::haxe.root.Array) (__temp_me284.beamHelpers[v.index]) ))) ).push(currentBeamHelper);
										newBeamingHelper = true;
									}
									
								}
								
								if ((  ! ((( ( b.tupletDenominator == -1 ) && ( b.tupletNumerator == -1 ) )))  &&  ! ((( ( b.tupletDenominator == 1 ) && ( b.tupletNumerator == 1 ) )))  )) {
									global::alphatab.model.Beat previousBeat = b.previousBeat;
									if (( ( previousBeat != default(global::alphatab.model.Beat) ) && ( previousBeat.voice != b.voice ) )) {
										previousBeat = default(global::alphatab.model.Beat);
									}
									
									if (( newBeamingHelper && ( currentTupletHelper != default(global::alphatab.rendering.utils.TupletHelper) ) )) {
										currentTupletHelper.finish();
									}
									
									if (( ( ( previousBeat == default(global::alphatab.model.Beat) ) || ( currentTupletHelper == default(global::alphatab.rendering.utils.TupletHelper) ) ) ||  ! (currentTupletHelper.check(b))  )) {
										currentTupletHelper = new global::alphatab.rendering.utils.TupletHelper(((int) (v.index) ));
										currentTupletHelper.check(b);
										((global::haxe.root.Array<object>) (global::haxe.root.Array<object>.__hx_cast<object>(((global::haxe.root.Array) (__temp_me284.tupletHelpers[v.index]) ))) ).push(currentTupletHelper);
									}
									
								}
								
								((global::haxe.ds.IntMap<object>) (global::haxe.ds.IntMap<object>.__hx_cast<object>(((global::haxe.ds.IntMap) (__temp_me284.beamHelperLookup[v.index]) ))) ).@set(b.index, currentBeamHelper);
							}
							
						}
						
						currentBeamHelper = default(global::alphatab.rendering.utils.BeamingHelper);
						currentTupletHelper = default(global::alphatab.rendering.utils.TupletHelper);
					}
					
				}
				
			}
		}
		
		
		public static  new object __hx_createEmpty(){
			unchecked {
				return new global::alphatab.rendering.utils.BarHelpers(((global::haxe.lang.EmptyObject) (global::haxe.lang.EmptyObject.EMPTY) ));
			}
		}
		
		
		public static  new object __hx_create(global::haxe.root.Array arr){
			unchecked {
				return new global::alphatab.rendering.utils.BarHelpers(((global::alphatab.model.Bar) (arr[0]) ));
			}
		}
		
		
		public  global::haxe.root.Array<object> beamHelpers;
		
		public  global::haxe.root.Array<object> beamHelperLookup;
		
		public  global::haxe.root.Array<object> tupletHelpers;
		
		public override   object __hx_setField(string field, int hash, object @value, bool handleProperties){
			unchecked {
				switch (hash){
					case 1513751865:
					{
						this.tupletHelpers = ((global::haxe.root.Array<object>) (global::haxe.root.Array<object>.__hx_cast<object>(((global::haxe.root.Array) (@value) ))) );
						return @value;
					}
					
					
					case 1756852887:
					{
						this.beamHelperLookup = ((global::haxe.root.Array<object>) (global::haxe.root.Array<object>.__hx_cast<object>(((global::haxe.root.Array) (@value) ))) );
						return @value;
					}
					
					
					case 136979862:
					{
						this.beamHelpers = ((global::haxe.root.Array<object>) (global::haxe.root.Array<object>.__hx_cast<object>(((global::haxe.root.Array) (@value) ))) );
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
					case 1513751865:
					{
						return this.tupletHelpers;
					}
					
					
					case 1756852887:
					{
						return this.beamHelperLookup;
					}
					
					
					case 136979862:
					{
						return this.beamHelpers;
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
				baseArr.push("tupletHelpers");
				baseArr.push("beamHelperLookup");
				baseArr.push("beamHelpers");
				{
					base.__hx_getFields(baseArr);
				}
				
			}
		}
		
		
	}
}



#pragma warning disable 109, 114, 219, 429, 168, 162
namespace alphatab.rendering.utils{
	public  class BarHelpersGroup : global::haxe.lang.HxObject {
		public    BarHelpersGroup(global::haxe.lang.EmptyObject empty){
			unchecked {
				{
				}
				
			}
		}
		
		
		public    BarHelpersGroup(){
			unchecked {
				global::alphatab.rendering.utils.BarHelpersGroup.__hx_ctor_alphatab_rendering_utils_BarHelpersGroup(this);
			}
		}
		
		
		public static   void __hx_ctor_alphatab_rendering_utils_BarHelpersGroup(global::alphatab.rendering.utils.BarHelpersGroup __temp_me285){
			unchecked {
				__temp_me285.helpers = new global::haxe.ds.IntMap<object>();
			}
		}
		
		
		public static  new object __hx_createEmpty(){
			unchecked {
				return new global::alphatab.rendering.utils.BarHelpersGroup(((global::haxe.lang.EmptyObject) (global::haxe.lang.EmptyObject.EMPTY) ));
			}
		}
		
		
		public static  new object __hx_create(global::haxe.root.Array arr){
			unchecked {
				return new global::alphatab.rendering.utils.BarHelpersGroup();
			}
		}
		
		
		public  global::haxe.ds.IntMap<object> helpers;
		
		public virtual   void buildHelpers(global::haxe.root.Array<object> tracks, int barIndex){
			unchecked {
				int _g = 0;
				while (( _g < tracks.length )){
					global::alphatab.model.Track t = ((global::alphatab.model.Track) (tracks[_g]) );
					 ++ _g;
					global::haxe.ds.IntMap<object> h = ((global::haxe.ds.IntMap<object>) (global::haxe.ds.IntMap<object>.__hx_cast<object>(((global::haxe.ds.IntMap) (this.helpers.@get(t.index).@value) ))) );
					if (( h == default(global::haxe.ds.IntMap<object>) )) {
						h = new global::haxe.ds.IntMap<object>();
						this.helpers.@set(t.index, h);
					}
					
					if (( ((global::alphatab.rendering.utils.BarHelpers) (h.@get(barIndex).@value) ) == default(global::alphatab.rendering.utils.BarHelpers) )) {
						h.@set(barIndex, new global::alphatab.rendering.utils.BarHelpers(((global::alphatab.model.Bar) (t.bars[barIndex]) )));
					}
					
				}
				
			}
		}
		
		
		public override   object __hx_setField(string field, int hash, object @value, bool handleProperties){
			unchecked {
				switch (hash){
					case 1079984965:
					{
						this.helpers = ((global::haxe.ds.IntMap<object>) (global::haxe.ds.IntMap<object>.__hx_cast<object>(((global::haxe.ds.IntMap) (@value) ))) );
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
					case 1387753911:
					{
						return ((global::haxe.lang.Function) (new global::haxe.lang.Closure(((object) (this) ), ((string) ("buildHelpers") ), ((int) (1387753911) ))) );
					}
					
					
					case 1079984965:
					{
						return this.helpers;
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
					case 1387753911:
					{
						this.buildHelpers(((global::haxe.root.Array<object>) (global::haxe.root.Array<object>.__hx_cast<object>(((global::haxe.root.Array) (dynargs[0]) ))) ), ((int) (global::haxe.lang.Runtime.toInt(dynargs[1])) ));
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
				baseArr.push("helpers");
				{
					base.__hx_getFields(baseArr);
				}
				
			}
		}
		
		
	}
}


