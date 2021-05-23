using System;

namespace OrderWebApp.Services
{
    public class GuidGenerator : IIdGenerator
    {
        public String GenerateId()
        {
            return Guid.NewGuid().ToString();
        }
    }
}
