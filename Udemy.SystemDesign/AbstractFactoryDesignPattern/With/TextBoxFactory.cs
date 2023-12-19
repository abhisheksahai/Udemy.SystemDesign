using Udemy.SystemDesign.AbstractFactoryDesignPattern.Without;

namespace Udemy.SystemDesign.AbstractFactoryDesignPattern.With
{
    public class TextBoxFactory
    {
        public static TextBox CreateTextBox(OS currentOs)
        {
            TextBox textBox = currentOs switch
            {
                OS.Windows => new TextBox("Hello Windows", "Black", currentOs),
                OS.Mac => new TextBox("Hello Mac", "White", currentOs),
                OS.Linux => new TextBox("Hello Linux", "Green", currentOs),
                _ => throw new NotImplementedException()
            };
            return textBox;
        }
    }
}