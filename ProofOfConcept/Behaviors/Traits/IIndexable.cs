namespace ProofOfConcept.Behaviors.Traits
{
    public interface IIndexable
    {
        int ColumnCount();

        int RowCount();

        TElementBehavior GetElement<TElementBehavior>(int row_index, int column_index) where TElementBehavior : IElementBehavior;

        void SetElement(int row_index, int column_index, string value);
    }
}
