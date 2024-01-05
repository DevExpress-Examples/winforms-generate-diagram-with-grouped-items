Imports System.Collections.ObjectModel

Namespace DiagramDataControllerBehavior

    Public Class ViewModel

        Public Property Departments As ObservableCollection(Of Department)

        Public Property Relations As ObservableCollection(Of Relation)

        Public Sub New()
            Departments = New ObservableCollection(Of Department)()
            Dim dep1 = New Department() With {.DepartmentID = 1, .DepartmentName = "Provision", .Sections = New ObservableCollection(Of Section)()}
            Dim dep2 = New Department() With {.DepartmentID = 2, .DepartmentName = "Security", .Sections = New ObservableCollection(Of Section)()}
            Dim dep3 = New Department() With {.DepartmentID = 3, .DepartmentName = "HR", .Sections = New ObservableCollection(Of Section)()}
            Dim section1 = New Section() With {.SectionID = 11, .SectionName = "Local", .Employees = New ObservableCollection(Of Employee)()}
            Dim section2 = New Section() With {.SectionID = 12, .SectionName = "Foreign Hubs", .Employees = New ObservableCollection(Of Employee)()}
            Dim section3 = New Section() With {.SectionID = 13, .SectionName = "Technical security", .Employees = New ObservableCollection(Of Employee)()}
            Dim section4 = New Section() With {.SectionID = 14, .SectionName = "Staff", .Employees = New ObservableCollection(Of Employee)()}
            Dim section5 = New Section() With {.SectionID = 15, .SectionName = "Managers", .Employees = New ObservableCollection(Of Employee)()}
            Dim section6 = New Section() With {.SectionID = 16, .SectionName = "Interviewers", .Employees = New ObservableCollection(Of Employee)()}
            section1.Employees.Add(New Employee() With {.EmployeeID = 101, .EmployeeName = "Mark"})
            section1.Employees.Add(New Employee() With {.EmployeeID = 102, .EmployeeName = "Jim"})
            section2.Employees.Add(New Employee() With {.EmployeeID = 103, .EmployeeName = "Andrew"})
            section2.Employees.Add(New Employee() With {.EmployeeID = 104, .EmployeeName = "Alex"})
            section3.Employees.Add(New Employee() With {.EmployeeID = 105, .EmployeeName = "Simon"})
            section3.Employees.Add(New Employee() With {.EmployeeID = 106, .EmployeeName = "Lily"})
            section4.Employees.Add(New Employee() With {.EmployeeID = 107, .EmployeeName = "Kim"})
            section4.Employees.Add(New Employee() With {.EmployeeID = 108, .EmployeeName = "Adam"})
            section5.Employees.Add(New Employee() With {.EmployeeID = 109, .EmployeeName = "Jack"})
            section5.Employees.Add(New Employee() With {.EmployeeID = 110, .EmployeeName = "Miriam"})
            section6.Employees.Add(New Employee() With {.EmployeeID = 111, .EmployeeName = "Justin"})
            section6.Employees.Add(New Employee() With {.EmployeeID = 112, .EmployeeName = "Alexa"})
            dep1.Sections.Add(section1)
            dep1.Sections.Add(section2)
            dep2.Sections.Add(section3)
            dep2.Sections.Add(section4)
            dep3.Sections.Add(section5)
            dep3.Sections.Add(section6)
            Departments.Add(dep1)
            Departments.Add(dep2)
            Departments.Add(dep3)
            Relations = New ObservableCollection(Of Relation)()
            Relations.Add(New Relation() With {.FromEmployeeID = 106, .ToEmployeeID = 101})
            Relations.Add(New Relation() With {.FromEmployeeID = 102, .ToEmployeeID = 109})
            Relations.Add(New Relation() With {.FromEmployeeID = 103, .ToEmployeeID = 108})
        End Sub
    End Class

    Public Class Department

        Public Property DepartmentID As Integer

        Public Property DepartmentName As String

        Public Property Sections As ObservableCollection(Of Section)
    End Class

    Public Class Section

        Public Property SectionID As Integer

        Public Property SectionName As String

        Public Property Employees As ObservableCollection(Of Employee)
    End Class

    Public Class Employee

        Public Property EmployeeID As Integer

        Public Property EmployeeName As String
    End Class

    Public Class Relation

        Public Property FromEmployeeID As Integer

        Public Property ToEmployeeID As Integer
    End Class
End Namespace
