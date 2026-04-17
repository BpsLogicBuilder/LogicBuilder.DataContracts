using System;

namespace LogicBuilder.DataContracts
{
    public class ModuleData
    {
        public byte[] RulesStream { get; set; } = [];
        public byte[] ResourcesStream { get; set; } = [];
        public string ModuleName { get; set; } = string.Empty;
        public string Application { get; set; } = string.Empty;
        public string UserData { get; set; } = string.Empty;
        public string UploadedBy { get; set; } = string.Empty;
        public DateTime UploadedTime { get; set; }
    }
}
