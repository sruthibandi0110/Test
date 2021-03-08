using System.Collections.Generic;

namespace Test
{
    public class UsersModel
    {
        public List<Datum> data { get; set; }
    }
    public partial class Datum
    {
        public string _id { get; set; }
        public string email { get; set; }
        public string firstName { get; set; }
        public string lastName { get; set; }
        public int __v { get; set; }
    }

}
