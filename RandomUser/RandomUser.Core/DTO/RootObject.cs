using System.Collections.Generic;

namespace RandomUser.Core.DTO
{
    public class RootObject
    {
        public IEnumerable<Result> Results { get; set; }
        public Info Info { get; set; }
    }
}