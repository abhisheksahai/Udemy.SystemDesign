namespace Udemy.SystemDesign.AbstractFactoryDesignPattern.With
{
    public class MacUIWindowFactory : IUIWindowFactory
    {
        public static Window CreateWindow()
        {
            Window window = new([ButtonFactory.CreateButton(OS.Mac), TextBoxFactory.CreateTextBox(OS.Mac)]);
            return window;
        }
    }
}