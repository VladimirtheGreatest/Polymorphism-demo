
using System.Collections.Generic;


namespace Polymorphism_Example.Database
{
    /// <summary>
    /// mock the data coming from the database
    /// </summary>
    public class DatabaseSample : IDatabaseSample
    {

        public List<string> GetData()
        {
            var data = new List<string>
            {
                "ALPHAZERO",
                "BETA",
                "ZERO",
            };
            return data;
        }
    }
}
