﻿namespace Xhznl.DataDictionary
{
    public static class DataDictionaryDbProperties
    {
        public static string DbTablePrefix { get; set; } = "Abp";

        public static string DbSchema { get; set; } = null;

        public const string ConnectionStringName = "DataDictionary";
    }
}
