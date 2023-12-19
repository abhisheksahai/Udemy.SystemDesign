using Udemy.SystemDesign.FactoryDesignPattern.Without;

namespace Udemy.SystemDesign.AbstractFactoryDesignPattern.With
{
    public class ButtonFactory
    {
        public static Button CreateButton(OS style)
        {
            Button button = style switch
            {
                OS.Windows => new Button("Black", true, style),
                OS.Mac => new Button("White", false, style),
                OS.Linux => new Button("Green", true, style),
                _ => throw new NotImplementedException()
            };
            return button;
        }
    }
}