Imports DevExpress.Diagram.Core
Imports System.Collections.Generic

Namespace DiagramDataControllerBehavior

    Public Class ItemsSelector
        Implements IChildrenSelector

        Public Function GetChildren(ByVal parent As Object) As IEnumerable(Of Object) Implements IChildrenSelector.GetChildren
            If TypeOf parent Is Department Then
                Return CType(parent, Department).Sections
            ElseIf TypeOf parent Is Section Then
                Return CType(parent, Section).Employees
            End If

            Return Nothing
        End Function
    End Class

    Public Class KeySelector
        Implements IKeySelector

        Private Function GetKey(ByVal obj As Object) As Object Implements IKeySelector.GetKey
            If TypeOf obj Is Department Then
                Return CType(obj, Department).DepartmentID
            ElseIf TypeOf obj Is Section Then
                Return CType(obj, Section).SectionID
            ElseIf TypeOf obj Is Employee Then
                Return CType(obj, Employee).EmployeeID
            End If

            Return obj
        End Function
    End Class
End Namespace
