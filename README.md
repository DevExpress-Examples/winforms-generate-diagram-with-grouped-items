<!-- default badges list -->
![](https://img.shields.io/endpoint?url=https://codecentral.devexpress.com/api/v1/VersionRange/739405451/22.2.3%2B)
[![](https://img.shields.io/badge/Open_in_DevExpress_Support_Center-FF7200?style=flat-square&logo=DevExpress&logoColor=white)](https://supportcenter.devexpress.com/ticket/details/T1209567)
[![](https://img.shields.io/badge/📖_How_to_use_DevExpress_Examples-e9f6fc?style=flat-square)](https://docs.devexpress.com/GeneralInformation/403183)
<!-- default badges end -->

# WinForms Diagram Control - Generate Diagrams with Grouped Items

This example uses [DiagramDataBindingController](https://docs.devexpress.com/WindowsForms/DevExpress.XtraDiagram.DiagramDataBindingController) to generate diagrams with grouped items.

![image](https://github.com/DevExpress-Examples/winforms-generate-diagram-with-grouped-items/assets/65009440/ec0253b7-d658-4e12-b98d-dfd94e2c06db)

The `DiagramDataBindingController` allows you to generate a diagram with multiple group levels. You can use the [ItemsPath](https://docs.devexpress.com/WindowsForms/DevExpress.XtraDiagram.DiagramDataBindingControllerBase.ItemsPath) property to specify child collection name. If you use different collections for different group levels, use [ItemsSelector](https://docs.devexpress.com/WindowsForms/DevExpress.XtraDiagram.DiagramDataBindingControllerBase.ItemsSelector). To select keys for parent and child items, use [KeySelector](https://docs.devexpress.com/WindowsForms/DevExpress.XtraDiagram.DiagramDataBindingControllerBase.KeySelector).

> **Note**
>
> [Item Template Designer](https://docs.devexpress.com/WindowsForms/117683/controls-and-libraries/diagrams/data-binding-functionality/item-template-designer) does not allow you to select arbitrary containers and [Diagram Lists](https://docs.devexpress.com/WindowsForms/DevExpress.XtraDiagram.DiagramList). You must explicitly generate corresponding items in the [GenerateItem](https://docs.devexpress.com/WindowsForms/DevExpress.XtraDiagram.DiagramDataBindingControllerBase.GenerateItem) event handler.

## Files to Review

- [Form1.cs](./CS/DiagramDataControllerBehavior/Form1.cs) (VB: [Form1.vb](./VB/DiagramDataControllerBehavior/Form1.vb))

## Documentation

* [Generate Diagrams from a Data Source](https://docs.devexpress.com/WindowsForms/117681/controls-and-libraries/diagrams/data-binding-functionality)
* [DiagramDataBindingController](https://docs.devexpress.com/WindowsForms/DevExpress.XtraDiagram.DiagramDataBindingController)

## More Examples

* [WinForms Diagram - Use the DiagramDataBindingController to Generate a Diagram from a Collection](https://github.com/DevExpress-Examples/how-to-generate-a-diagram-from-a-collection-using-diagramdatabindingcontroller-t477927)
