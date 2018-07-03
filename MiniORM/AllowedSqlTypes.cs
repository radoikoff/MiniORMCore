namespace MiniORM
{
    using System;

    internal static class AllowedSqlTypes
    {
        internal static Type[] SqlTypes = new Type[]
        {
            typeof(string),
            typeof(int),
            typeof(uint),
            typeof(long),
            typeof(ulong),
            typeof(decimal),
            typeof(bool),
            typeof(DateTime)
        };
    }
}
