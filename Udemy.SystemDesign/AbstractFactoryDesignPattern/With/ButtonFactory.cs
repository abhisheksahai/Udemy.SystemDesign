using Udemy.SystemDesign.FactoryDesignPattern.Without;

namespace Udemy.SystemDesign.AbstractFactoryDesignPattern.With
{
    public class ButtonFactory
    {
        public static Button CreateButton(OS currentOs)
        {
            Button button = currentOs switch
            {
                OS.Windows => new Button("Black", true, currentOs),
                OS.Mac => new Button("White", false, currentOs),
                OS.Linux => new Button("Green", true, currentOs),
                _ => throw new NotImplementedException()
            };
            return button;
        }
    }
}