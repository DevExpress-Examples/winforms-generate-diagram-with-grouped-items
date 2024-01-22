using DevExpress.Diagram.Core;
using DevExpress.Utils;
using DevExpress.XtraDiagram;
using System.Drawing;
using System.Windows.Forms;

namespace DiagramDataControllerBehavior {
    public partial class Form1 : DevExpress.XtraEditors.XtraForm {
        public Form1() {
            InitializeComponent();
            var viewModel = new ViewModel();

            diagramDataBindingController1.BeginInit();
            diagramDataBindingController1.LayoutKind = DiagramLayoutKind.Sugiyama;
            diagramControl1.OptionsSugiyamaLayout.ColumnSpacing = 300;
            diagramControl1.OptionsSugiyamaLayout.Direction = DevExpress.Diagram.Core.Layout.LayoutDirection.RightToLeft;
            diagramControl1.OptionsSugiyamaLayout.LayerSpacing = 400;
            diagramControl1.OptionsSugiyamaLayout.LayersAlignment = Alignment.Center;
            diagramDataBindingController1.ConnectorFromMember = "FromEmployeeID";
            diagramDataBindingController1.ConnectorToMember = "ToEmployeeID";
            diagramDataBindingController1.ItemsSelector = new ItemsSelector();
            diagramDataBindingController1.KeySelector = new KeySelector();
            diagramDataBindingController1.GenerateItem += DiagramDataBindingController1_GenerateItem;
            diagramDataBindingController1.GenerateConnector += DiagramDataBindingController1_GenerateConnector;
            diagramDataBindingController1.DataSource = viewModel.Departments;
            diagramDataBindingController1.ConnectorsSource = viewModel.Relations;
            diagramDataBindingController1.EndInit();
        }

        private void DiagramDataBindingController1_GenerateItem(object sender, DiagramGenerateItemEventArgs e) {
            if (e.DataObject is Department)
                e.Item = GenerateVerticalList();
            else if (e.DataObject is Section)
                e.Item = GenerateHorizontalList();
            else if (e.DataObject is Employee)
                e.Item = GenerateShape();
        }

        private void DiagramDataBindingController1_GenerateConnector(object sender, DiagramGenerateConnectorEventArgs e) {
            e.Connector = new DiagramConnector() { Type = ConnectorType.Straight };
        }

        public DiagramList GenerateVerticalList() {
            var list = new DiagramList() {
                MinWidth = 240,
                CanAddItems = false,
                CanAttachConnectorBeginPoint = false,
                CanAttachConnectorEndPoint = false,
                CanCollapse = true,
                DragMode = DevExpress.Diagram.Core.ContainerDragMode.ByAnyPoint,
                ItemsCanMove = false,
                ItemsCanSelect = true,
                ShowHeader = true
            };
            DiagramBinding binding = new DiagramBinding("Header", "DepartmentName");
            list.Bindings.Add(binding);
            return list;
        }

        public DiagramList GenerateHorizontalList() {
            var list = new DiagramList() {
                Orientation = Orientation.Horizontal,
                CanAttachConnectorBeginPoint = false,
                CanAttachConnectorEndPoint = false,
                CanCollapse = true,
                DragMode = DevExpress.Diagram.Core.ContainerDragMode.ByAnyPoint,
                ItemsCanMove = false,
                ItemsCanSelect = true,
                ShowHeader = true
            };
            DiagramBinding binding = new DiagramBinding("Header", "SectionName");
            list.Bindings.Add(binding);
            return list;
        }

        public DiagramShape GenerateShape() {
            var shape = new DiagramShape() {
                MinHeight = 50,
                ConnectionPoints = new PointCollection(new PointFloat[] { new PointFloat(0, 0.5f), new PointFloat(1, 0.5f) })
            };
            shape.Appearance.BackColor = Color.Green;
            DiagramBinding binding = new DiagramBinding("Content", "EmployeeName");
            shape.Bindings.Add(binding);
            return shape;
        }
    }
}
