using System;

namespace prep.utility
{
    public class ComparableMatchFactory<ItemToFind, PropertyType> : INeedMatchFactory<ItemToFind, PropertyType> where PropertyType : IComparable<PropertyType>
    {
        readonly PropertyAccessor<ItemToFind, PropertyType> accessor;
        readonly MatchFactory<ItemToFind, PropertyType> matchFactory;

        public ComparableMatchFactory(PropertyAccessor<ItemToFind, PropertyType> accessor)
        {
            this.accessor = accessor;
            matchFactory = new MatchFactory<ItemToFind, PropertyType>(accessor);
        }

        public IMatchAn<ItemToFind> greater_than(PropertyType value)
        {
            return new LambdaMatcher<ItemToFind>(x => accessor(x).CompareTo(value) > 0);
        }

        public IMatchAn<ItemToFind> equal_to(PropertyType value)
        {
            return matchFactory.equal_to(value);
        }

        public IMatchAn<ItemToFind> equal_to_any(params PropertyType[] values)
        {
            return matchFactory.equal_to_any(values);
        }

        public IMatchAn<ItemToFind> not_equal_to(PropertyType value)
        {
            return matchFactory.not_equal_to(value);
        }
    }
}