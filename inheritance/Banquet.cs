    using System;
    using System.Collections.Generic;
    using System.Text;

    namespace _13_march_Tasks_inheritance
    {
        public class Banquet
        {
            public int BanquetId { get; set; }
            public string BanquetName { get; set; }
            public int Capacity { get; set; }

            public int Earning { get; set; }

            public Banquet(int banquetId, string banquetName, int capacity)
            {
                BanquetId = banquetId;
                BanquetName = banquetName;
                Capacity = capacity;
            }

            public virtual int CalculateEarning()
            {
                return Earning = 2000;
            }

        }
    }
