namespace Udemy.SystemDesign.FactoryDesignPattern.Without
{
    public class Button(string color, bool border, OS style)
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
    }
}