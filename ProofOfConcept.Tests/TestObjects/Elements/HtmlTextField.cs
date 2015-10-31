
using ProofOfConcept.Behaviors;

namespace ProofOfConcept.Samples.TestObjects.Elements

{
    public class HtmlTextField : ElementBase, ITextFieldBehavior
    {
        private ITextFieldBehavior _textFieldBehavior;

        public HtmlTextField()
        {
            _textFieldBehavior = AddBehavior<ITextFieldBehavior>();
        }
        
        public void SetText(string textValue)
        {
            _textFieldBehavior.SetText(textValue);
        }

        public string GetText()
        {
            return _textFieldBehavior.GetText();
        }

        public void AppendText(string textValue)
        {
            _textFieldBehavior.AppendText(textValue);
        }

        public void Clear()
        {
            _textFieldBehavior.Clear();
        }
    }

}
