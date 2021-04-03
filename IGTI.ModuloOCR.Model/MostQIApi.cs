using System.Collections.Generic;

namespace IGTI.ModuloOCR.Model
{
    public class MostQIApi
    {
        public string File { get; set; }
        public List<MostQIResult> Result { get; set; }
        public string RequestId { get; set; }
        public int ElapsedMilliseconds { get; set; }
        public ResponseStatus Status { get; set; }
    }

    public class MostQIResult
    {
        public List<MostQIField> Fields { get; set; }
        public string Image { get; set; }
        public decimal Score { get; set; }
        public string Type { get; set; }
        public int PageNumber { get; set; }
        public List<string> Tags { get; set; }
        public List<string> Tables { get; set; }
        public ResponseStatus Status { get; set; }
    }

    public class MostQIField
    {
        public string Name { get; set; }
        public string StdName { get; set; }
        public string Value { get; set; }
        public decimal? Score { get; set; }
    }

    public class ResponseStatus
    {
        public string Code { get; set; }
        public string Message { get; set; }
    }
}
