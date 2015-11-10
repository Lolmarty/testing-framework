using ProofOfConcept.Behaviors;


namespace ProofOfConcept.Tests.Component.TestObjects.Elements
{
    public class HtmlTable: ElementBase, ITableBehavior
    {
        private readonly ITableBehavior _tableBehavior;

        public HtmlTable()
        {
            _tableBehavior = AddBehavior<ITableBehavior>();
        }

        public TElementType GetElement<TElementType>(int row_index, int column_index) where TElementType : IElementBehavior
        {
            return _tableBehavior.GetElement<TElementType>(row_index, column_index);
        }

        public int ColumnCount() 
        {
            return _tableBehavior.ColumnCount();
        }

        public int RowCount()
        {
            return _tableBehavior.RowCount();
        }

        public void SetElement(int row_index, int column_index, string value)
        {
            _tableBehavior.SetElement(row_index, column_index, value);
        }
    }
}
