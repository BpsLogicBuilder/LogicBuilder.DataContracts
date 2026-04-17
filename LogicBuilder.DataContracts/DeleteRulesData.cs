using System;

namespace LogicBuilder.DataContracts
{
    public class DeleteRulesData
    {
        public string[] Files { get; set; } = [];
        public string Application { get; set; } = string.Empty;
        public string UserData { get; set; } = string.Empty;
        public string DeletedBy { get; set; } = string.Empty;
        public DateTime DeleteTime { get; set; }
    }
}
