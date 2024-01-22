using DevExpress.Diagram.Core;
using System.Collections.Generic;

namespace DiagramDataControllerBehavior {
    public class ItemsSelector : IChildrenSelector {
        public IEnumerable<object> GetChildren(object parent) {
            if (parent is Department)
                return ((Department)parent).Sections;
            else if (parent is Section)
                return ((Section)parent).Employees;
            return null;
        }
    }
    public class KeySelector : IKeySelector {
        object IKeySelector.GetKey(object obj) {
            if (obj is Department)
                return ((Department)obj).DepartmentID;
            else if (obj is Section)
                return ((Section)obj).SectionID;
            else if (obj is Employee)
                return ((Employee)obj).EmployeeID;
            return obj;
        }
    }
}
