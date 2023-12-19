using Udemy.SystemDesign.FactoryDesignPattern;
using Udemy.SystemDesign.FactoryDesignPattern.Without;

namespace Udemy.SystemDesign.Test.FactoryDesignPattern
{
    public class ButtonTest
    {
        [Test]
        public void WithoutFactoryButtonTest()
        {
            OS style = OS.Windows;
            Button? button = null;
            switch (style)
            {
                case OS.Windows:
                    button = new Button("Black", true, style);
                    break;
                case OS.Mac:
                    button = new Button("White", false, style);
                    break;
                case OS.Linux:
                    button = new Button("Green", true, style);
                    break;
                default:
                    break;
            }
            Assert.IsNotNull(button);
        }

        [Test]
        public void WithFactoryButtonTest()
        {

        }
    }
}