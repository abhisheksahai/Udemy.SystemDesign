namespace Udemy.SystemDesign.AbstractFactoryDesignPattern.With
{
    public class TextBox(string text, string color, OS style) : IUIElement
    {
        public string GetText
        {
            get
            {
                return text;
            }
        }

        public string GetColor
        {
            get
            {
                return color;
            }
        }

        public OS GetStyle
        {
            get
            {
                return style;
            }
        }

        public void Render()
        {
            Console.WriteLine($"Rendering text with style " + style);
        }
    }
}