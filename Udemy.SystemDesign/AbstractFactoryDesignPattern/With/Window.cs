namespace Udemy.SystemDesign.AbstractFactoryDesignPattern.With
{
    public class Window(List<IUIElement> uIElements) : IUIElement
    {
        public void Render()
        {
            foreach (var uIElement in uIElements)
            {
                uIElement.Render();
            }
        }
    }
}