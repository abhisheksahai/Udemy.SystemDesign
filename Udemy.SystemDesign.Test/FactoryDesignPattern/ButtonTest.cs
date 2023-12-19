using Udemy.SystemDesign.FactoryDesignPattern;
using Udemy.SystemDesign.FactoryDesignPattern.With;
using Udemy.SystemDesign.FactoryDesignPattern.Without;

namespace Udemy.SystemDesign.Test.FactoryDesignPattern
{
    public class ButtonTest
    {
        [Test]
        public void WithoutFactoryButtonTest()
        {
            OS style = OS.Windows;
            Button button = style switch
            {
                OS.Windows => new Button("Black", true, style),
                OS.Mac => new Button("White", false, style),
                OS.Linux => new Button("Green", true, style),
                _ => throw new NotImplementedException()
            };
            button.Click();
            Assert.That(button, Is.Not.Null);
        }

        [Test]
        public void WithFactoryButtonTest()
        {
            Button button = ButtonFactory.CreateButton(OS.Windows);
            button.Click();
            Assert.That(button, Is.Not.Null);
        }
    }
}