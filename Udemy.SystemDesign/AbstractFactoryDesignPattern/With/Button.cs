namespace Udemy.SystemDesign.AbstractFactoryDesignPattern.With
{
    public class Button(string color, bool border, OS style) : IUIElement
    {
        public string GetColor
        {
            get
            {
                return color;
            }
        }

        public bool GetBorder
        {
            get
            {
                return border;
            }
        }

        public OS GetStyle
        {
            get
            {
                return style;
            }
        }

        public void Click()
        {
            //Do something...
        }

        public void Render()
        {
            Console.WriteLine($"Rendering button with style " + style);
        }
    }
}