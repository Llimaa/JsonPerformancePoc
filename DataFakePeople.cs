internal static class DataFakePeople
{
        public static Address[] GetAddresses()
    {
        return Enumerable.Range(1, 1000).Select(i =>
        {
            return new Address(
                Guid.NewGuid(),
                "street"+ i,
                "city"+ i,
                "state"+ i,
                "zip" + i);
        }
        ).ToArray();
    }
    public static Person[] GetPeople()
    {
        return Enumerable.Range(1, 5000).Select(i =>
        {
            return new Person(
                Guid.NewGuid(),
                "Name_" + i,
                DateTime.UtcNow,
                GetAddresses()
            );
        }
        ).ToArray();
    }

    
}
