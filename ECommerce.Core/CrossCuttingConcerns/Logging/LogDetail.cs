using System.Collections.Generic;

namespace ECommerce.Core.CrossCuttingConcerns.Logging
{
    public class LogDetail
    {
        public string FullName { get; set; }
        public List<LogParameter> Parameters { get; set; }
    }
}
