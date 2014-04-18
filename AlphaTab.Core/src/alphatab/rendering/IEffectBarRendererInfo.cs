using haxe.root;
#pragma warning disable 109, 114, 219, 429, 168, 162
namespace alphatab.rendering
{
	public  interface IEffectBarRendererInfo : global::haxe.lang.IHxObject 
	{
		   bool shouldCreateGlyph(global::alphatab.rendering.EffectBarRenderer renderer, global::alphatab.model.Beat beat);
		
		   global::alphatab.rendering.EffectBarGlyphSizing getSizingMode();
		
		   int getHeight(global::alphatab.rendering.EffectBarRenderer renderer);
		
		   global::alphatab.rendering.Glyph createNewGlyph(global::alphatab.rendering.EffectBarRenderer renderer, global::alphatab.model.Beat beat);
		
		   bool canExpand(global::alphatab.rendering.EffectBarRenderer renderer, global::alphatab.model.Beat @from, global::alphatab.model.Beat to);
		
	}
}


