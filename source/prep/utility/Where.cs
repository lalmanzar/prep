using System;
using prep.collections;

namespace prep.utility
{
  public class Where<ItemToFind>
  {
      public static PropertyAccess<ItemToFind, PropertyType> has_a<PropertyType>(PropertyAccessor<ItemToFind, PropertyType> accessor)
    {
          return new PropertyAccess<ItemToFind, PropertyType>(accessor);
    }
  }

  public class PropertyAccess<ItemToFind, PropertyType>
    {
      readonly PropertyAccessor<ItemToFind, PropertyType> accessor;

      public PropertyAccess(PropertyAccessor<ItemToFind, PropertyType> accessor)
        {
            this.accessor = accessor;
        }

      public IMatchAn<ItemToFind> equal_to(ProductionStudio studio)
      {
          return new LambdaMatcher<ItemToFind>(x=> accessor(x).Equals(studio));
      }
    }
}