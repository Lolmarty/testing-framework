using OpenQA.Selenium;
using ProofOfConcept.Behaviors;

namespace ProofOfConcept.Selenium.Behaviors
{
    public class SeleniumTableBehavior : ITableBehavior
    {
        public ElementBase Element { get; set; }
        private IWebElement NativeElement
        {
            get
            {
                return ((IWebElement)Element.NativeElement);
            }
        }

        public SeleniumTableBehavior(ElementBase element)
        {
            Element = element;
        }

        public TElementType GetElement<TElementType>(int row_index, int column_index) where TElementType : IElementBehavior
        {
            return (TElementType)NativeElement.FindElement(By.XPath(".//tbody/tr[" + row_index.ToString() + "]/td[" + column_index.ToString() + "]"));
        }

        public int ColumnCount()
        {
            return NativeElement.FindElements(By.XPath(".//tbody/tr[1]/td")).Count;
        }

        public int RowCount()
        {
            return NativeElement.FindElements(By.XPath(".//tbody/tr")).Count;
        }

        public void SetElement(int row_index, int column_index, string value)
        {
            GetElement<ElementBase>(row_index, column_index).NativeElement.SendKeys(value);
        }
    }
}
