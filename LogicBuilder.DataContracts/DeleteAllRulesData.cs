using System;

namespace LogicBuilder.DataContracts
{
    [Obsolete("This class is obsolete. To delete all rules, select the top node in the treeview. This will select all nodes and use the DeleteRulesData class for each instance..")]
    public class DeleteAllRulesData
    {
        public string Application { get; set; }
        public string UserData { get; set; }
        public string DeletedBy { get; set; }
        public DateTime DeleteTime { get; set; }
    }
}
