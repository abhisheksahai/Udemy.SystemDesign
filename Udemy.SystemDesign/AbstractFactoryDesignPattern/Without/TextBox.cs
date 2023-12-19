namespace Udemy.SystemDesign.AbstractFactoryDesignPattern.Without
{
    public class TextBox(string text, string color, OS style)
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
    }
}