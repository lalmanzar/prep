namespace prep.utility
{
    public interface INeedMatchFactory<ItemToFind, PropertyType>
    {
        IMatchAn<ItemToFind> equal_to(PropertyType value);
        IMatchAn<ItemToFind> equal_to_any(params PropertyType[] values);
        IMatchAn<ItemToFind> not_equal_to(PropertyType value);
    }
}