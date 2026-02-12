using System;

namespace LogicBuilder.DataContracts
{
    [Obsolete("This class is obsolete. It was used for standard forms which have been removed from LogicBuilder since v2.0.0.")]
    public class VariableMetaData
    {
        public string XmlData { get; set; }
        public string Application { get; set; }
        public string UserData { get; set; }
        public string UploadedBy { get; set; }
        public DateTime UploadedTime { get; set; }
    }
}
