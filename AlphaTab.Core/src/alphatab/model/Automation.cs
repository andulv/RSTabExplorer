using haxe.root;
#pragma warning disable 109, 114, 219, 429, 168, 162
namespace alphatab.model
{
	public  class Automation : global::haxe.lang.HxObject 
	{
		public    Automation(global::haxe.lang.EmptyObject empty)
		{
			unchecked 
			{
				{
				}
				
			}
		}
		
		
		public    Automation()
		{
			unchecked 
			{
				global::alphatab.model.Automation.__hx_ctor_alphatab_model_Automation(this);
			}
		}
		
		
		public static   void __hx_ctor_alphatab_model_Automation(global::alphatab.model.Automation __temp_me72)
		{
			unchecked 
			{
				{
				}
				
			}
		}
		
		
		public static   global::alphatab.model.Automation builtTempoAutomation(bool isLinear, double ratioPosition, double @value, int reference)
		{
			unchecked 
			{
				if (( ( reference < 1 ) || ( reference > 5 ) )) 
				{
					reference = 2;
				}
				
				global::haxe.root.Array<double> references = new global::haxe.root.Array<double>(new double[]{1.0, 0.5, 1.0, 1.5, 2.0, 3.0});
				global::alphatab.model.Automation automation = new global::alphatab.model.Automation();
				automation.type = global::alphatab.model.AutomationType.Tempo;
				automation.isLinear = isLinear;
				automation.ratioPosition = ratioPosition;
				double realValue = ( @value * references[reference] );
				automation.@value = realValue;
				return automation;
			}
		}
		
		
		public static  new object __hx_createEmpty()
		{
			unchecked 
			{
				return new global::alphatab.model.Automation(((global::haxe.lang.EmptyObject) (global::haxe.lang.EmptyObject.EMPTY) ));
			}
		}
		
		
		public static  new object __hx_create(global::haxe.root.Array arr)
		{
			unchecked 
			{
				return new global::alphatab.model.Automation();
			}
		}
		
		
		public  bool isLinear;
		
		public  global::alphatab.model.AutomationType type;
		
		public  double @value;
		
		public  double ratioPosition;
		
		public  string text;
		
		public virtual   global::alphatab.model.Automation clone()
		{
			unchecked 
			{
				global::alphatab.model.Automation a = new global::alphatab.model.Automation();
				a.isLinear = this.isLinear;
				a.type = this.type;
				a.@value = this.@value;
				return a;
			}
		}
		
		
		public override   double __hx_setField_f(string field, int hash, double @value, bool handleProperties)
		{
			unchecked 
			{
				switch (hash)
				{
					case 1475155156:
					{
						this.ratioPosition = ((double) (@value) );
						return @value;
					}
					
					
					case 834174833:
					{
						this.@value = ((double) (@value) );
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
					case 1291439277:
					{
						this.text = global::haxe.lang.Runtime.toString(@value);
						return @value;
					}
					
					
					case 1475155156:
					{
						this.ratioPosition = ((double) (global::haxe.lang.Runtime.toDouble(@value)) );
						return @value;
					}
					
					
					case 834174833:
					{
						this.@value = ((double) (global::haxe.lang.Runtime.toDouble(@value)) );
						return @value;
					}
					
					
					case 1292432058:
					{
						this.type = ((global::alphatab.model.AutomationType) (@value) );
						return @value;
					}
					
					
					case 1158278511:
					{
						this.isLinear = ((bool) (@value) );
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
					case 1214452573:
					{
						return ((global::haxe.lang.Function) (new global::haxe.lang.Closure(((object) (this) ), global::haxe.lang.Runtime.toString("clone"), ((int) (1214452573) ))) );
					}
					
					
					case 1291439277:
					{
						return this.text;
					}
					
					
					case 1475155156:
					{
						return this.ratioPosition;
					}
					
					
					case 834174833:
					{
						return this.@value;
					}
					
					
					case 1292432058:
					{
						return this.type;
					}
					
					
					case 1158278511:
					{
						return this.isLinear;
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
					case 1475155156:
					{
						return this.ratioPosition;
					}
					
					
					case 834174833:
					{
						return this.@value;
					}
					
					
					default:
					{
						return base.__hx_getField_f(field, hash, throwErrors, handleProperties);
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
					case 1214452573:
					{
						return this.clone();
					}
					
					
					default:
					{
						return base.__hx_invokeField(field, hash, dynargs);
					}
					
				}
				
			}
		}
		
		
		public override   void __hx_getFields(global::haxe.root.Array<object> baseArr)
		{
			unchecked 
			{
				baseArr.push("text");
				baseArr.push("ratioPosition");
				baseArr.push("value");
				baseArr.push("type");
				baseArr.push("isLinear");
				{
					base.__hx_getFields(baseArr);
				}
				
			}
		}
		
		
	}
}


