using haxe.root;
#pragma warning disable 109, 114, 219, 429, 168, 162
namespace alphatab.platform{
	public  interface ICanvas : global::haxe.lang.IHxObject {
		   int getWidth();
		
		   void setWidth(int width);
		
		   int getHeight();
		
		   void setHeight(int height);
		
		   void setColor(global::alphatab.platform.model.Color color);
		
		   void setLineWidth(double width);
		
		   void clear();
		
		   void fillRect(double x, double y, double w, double h);
		
		   void strokeRect(double x, double y, double w, double h);
		
		   void beginPath();
		
		   void closePath();
		
		   void moveTo(double x, double y);
		
		   void lineTo(double x, double y);
		
		   void quadraticCurveTo(double cpx, double cpy, double x, double y);
		
		   void bezierCurveTo(double cp1x, double cp1y, double cp2x, double cp2y, double x, double y);
		
		   void rect(double x, double y, double w, double h);
		
		   void circle(double x, double y, double radius);
		
		   void fill();
		
		   void stroke();
		
		   void setFont(global::alphatab.platform.model.Font font);
		
		   global::alphatab.platform.model.TextAlign getTextAlign();
		
		   void setTextAlign(global::alphatab.platform.model.TextAlign textAlign);
		
		   global::alphatab.model.TextBaseline getTextBaseline();
		
		   void setTextBaseline(global::alphatab.model.TextBaseline textBaseLine);
		
		   void fillText(string text, double x, double y);
		
		   double measureText(string text);
		
	}
}


