using Udemy.SystemDesign.AbstractFactoryDesignPattern.With;

namespace Udemy.SystemDesign.Test.AbstractFactoryDesignPattern
{
    public class IUFactoryTest
    {
        [Test]
        public void MacUIWindowFactoryTest()
        {
            var result = MacUIWindowFactory.CreateWindow();
            result.Render();
        }
    }
}
