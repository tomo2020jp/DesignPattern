using System;
using System.Collections.Generic;
using System.IO;
using Authlete.Util;

namespace Facade
{
    public class Database
    {
        private Database()
        {
        }

        // 参考記事
        // https://qiita.com/TakahikoKawasaki/items/3120e539c87802b23c03

        public static IDictionary<string, string> GetProperties(string dbname)
        {
            string filename = $"{dbname}.txt";
            IDictionary<string, string> prop;

            using (var reader = new StreamReader(filename))
            {
                prop = PropertiesLoader.Load(reader);
            }
            return prop;
        }
    }
}
