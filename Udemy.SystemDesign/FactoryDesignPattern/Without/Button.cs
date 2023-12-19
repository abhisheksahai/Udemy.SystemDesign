namespace Udemy.SystemDesign.FactoryDesignPattern.Without
{
    public class Button
    {
        private string _color;
        private bool _border;
        private OS _style;

        public Button(string color, bool border, OS style)
        {
            _color = color;
            _border = border;
            _style = style;
        }

        public string GetColor
        {
            get
            {
                return _color;
            }
        }

        public bool GetBorder
        {
            get
            {
                return _border;
            }
        }

        public OS GetStyle
        {
            get
            {
                return _style;
            }
        }
    }
}