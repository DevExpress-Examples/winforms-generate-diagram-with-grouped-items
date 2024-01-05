<!-- default badges list -->
[![](https://img.shields.io/badge/Open_in_DevExpress_Support_Center-FF7200?style=flat-square&logo=DevExpress&logoColor=white)](https://supportcenter.devexpress.com/ticket/details/T1209567)
[![](https://img.shields.io/badge/📖_How_to_use_DevExpress_Examples-e9f6fc?style=flat-square)](https://docs.devexpress.com/GeneralInformation/403183)
<!-- default badges end -->
# WinForms Diagram Control - How to generate diagrams with grouped items

This example demonstrates how to use [DiagramDataBindingController](https://docs.devexpress.com/WindowsForms/DevExpress.XtraDiagram.DiagramDataBindingController) to generate diagrams with grouped items.

The DiagramDataBindingController allows you to generate diagram with several levels of grouped items. You can specify the child collection name using the [ItemsPath](https://docs.devexpress.com/WindowsForms/DevExpress.XtraDiagram.DiagramDataBindingControllerBase.ItemsPath) property. If you use different collections for different levels, use [ItemsSelector](https://docs.devexpress.com/WindowsForms/DevExpress.XtraDiagram.DiagramDataBindingControllerBase.ItemsSelector). To select keys for parent and child items, use [KeySelector](https://docs.devexpress.com/WindowsForms/DevExpress.XtraDiagram.DiagramDataBindingControllerBase.KeySelector).

**Note** that the Item Template Designer doesn't allow you to select artbitrary containers and [DiagramLists](https://docs.devexpress.com/WindowsForms/DevExpress.XtraDiagram.DiagramList). You need to generate corresponding parent container in code in the [GenerateItem](https://docs.devexpress.com/WindowsForms/DevExpress.XtraDiagram.DiagramDataBindingControllerBase.GenerateItem) event handler.

## Files to Review

- [Form1.cs](./CS/DiagramDataControllerBehavior/Form1.cs) (VB: [Form1.vb](./VB/DiagramDataControllerBehavior/Form1.vb))
