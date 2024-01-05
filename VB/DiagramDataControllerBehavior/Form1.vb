Imports DevExpress.Diagram.Core
Imports DevExpress.Utils
Imports DevExpress.XtraDiagram
Imports System.ComponentModel
Imports System.Drawing
Imports System.Windows.Forms

Namespace DiagramDataControllerBehavior

    Public Partial Class Form1
        Inherits DevExpress.XtraEditors.XtraForm

        Public Sub New()
            InitializeComponent()
            Dim viewModel = New ViewModel()
            diagramDataBindingController1.BeginInit()
            diagramDataBindingController1.LayoutKind = DiagramLayoutKind.Sugiyama
            diagramControl1.OptionsSugiyamaLayout.ColumnSpacing = 300
            diagramControl1.OptionsSugiyamaLayout.Direction = DevExpress.Diagram.Core.Layout.LayoutDirection.RightToLeft
            diagramControl1.OptionsSugiyamaLayout.LayerSpacing = 400
            diagramControl1.OptionsSugiyamaLayout.LayersAlignment = Alignment.Center
            diagramDataBindingController1.ConnectorFromMember = "FromEmployeeID"
            diagramDataBindingController1.ConnectorToMember = "ToEmployeeID"
            diagramDataBindingController1.ItemsSelector = New ItemsSelector()
            diagramDataBindingController1.KeySelector = New KeySelector()
            AddHandler diagramDataBindingController1.GenerateItem, AddressOf DiagramDataBindingController1_GenerateItem
            AddHandler diagramDataBindingController1.GenerateConnector, AddressOf DiagramDataBindingController1_GenerateConnector
            diagramDataBindingController1.DataSource = viewModel.Departments
            diagramDataBindingController1.ConnectorsSource = viewModel.Relations
            diagramDataBindingController1.EndInit()
        End Sub

        Private Sub DiagramDataBindingController1_GenerateItem(ByVal sender As Object, ByVal e As DiagramGenerateItemEventArgs)
            If TypeOf e.DataObject Is Department Then
                e.Item = GenerateVerticalList()
            ElseIf TypeOf e.DataObject Is Section Then
                e.Item = GenerateHorizontalList()
            ElseIf TypeOf e.DataObject Is Employee Then
                e.Item = GenerateShape()
            End If
        End Sub

        Private Sub DiagramDataBindingController1_GenerateConnector(ByVal sender As Object, ByVal e As DiagramGenerateConnectorEventArgs)
            e.Connector = New DiagramConnector() With {.Type = ConnectorType.Straight}
        End Sub

        Public Function GenerateVerticalList() As DiagramList
            Dim list = New DiagramList() With {.MinWidth = 240, .CanAddItems = False, .CanAttachConnectorBeginPoint = False, .CanAttachConnectorEndPoint = False, .CanCollapse = True, .DragMode = ContainerDragMode.ByAnyPoint, .ItemsCanMove = False, .ItemsCanSelect = True, .ShowHeader = True}
            Dim binding As DiagramBinding = New DiagramBinding("Header", "DepartmentName")
            list.Bindings.Add(binding)
            Return list
        End Function

        Public Function GenerateHorizontalList() As DiagramList
            Dim list = New DiagramList() With {.Orientation = Orientation.Horizontal, .CanAttachConnectorBeginPoint = False, .CanAttachConnectorEndPoint = False, .CanCollapse = True, .DragMode = ContainerDragMode.ByAnyPoint, .ItemsCanMove = False, .ItemsCanSelect = True, .ShowHeader = True}
            Dim binding As DiagramBinding = New DiagramBinding("Header", "SectionName")
            list.Bindings.Add(binding)
            Return list
        End Function

        Public Function GenerateShape() As DiagramShape
            Dim shape = New DiagramShape() With {.MinHeight = 50, .ConnectionPoints = New PointCollection(New PointFloat() {New PointFloat(0, 0.5F), New PointFloat(1, 0.5F)})}
            shape.Appearance.BackColor = Color.Green
            Dim binding As DiagramBinding = New DiagramBinding("Content", "EmployeeName")
            shape.Bindings.Add(binding)
            Return shape
        End Function
    End Class
End Namespace
