﻿Imports DevExpress.Mvvm
Imports DevExpress.Xpf.Core
Imports System.Collections.ObjectModel
Imports System.Windows.Media

Namespace DataGridBackground
	Partial Public Class MainWindow
		Inherits ThemedWindow

		Public Sub New()
			InitializeComponent()
		End Sub
	End Class

	Public Class MainViewModel
		Inherits ViewModelBase

		Public Property UseBackground() As Boolean
			Get
				Return GetProperty(Function() UseBackground)
			End Get
			Set(ByVal value As Boolean)
				SetProperty(Function() UseBackground, value)
			End Set
		End Property

		Public Property UseDataAreaBackground() As Boolean
			Get
				Return GetProperty(Function() UseDataAreaBackground)
			End Get
			Set(ByVal value As Boolean)
				SetProperty(Function() UseDataAreaBackground, value)
			End Set
		End Property

		Public Property SelectedColor() As Color
			Get
				Return GetProperty(Function() SelectedColor)
			End Get
			Set(ByVal value As Color)
				SetProperty(Function() SelectedColor, value)
			End Set
		End Property

		Public Property DataAreaSelectedColor() As Color
			Get
				Return GetProperty(Function() DataAreaSelectedColor)
			End Get
			Set(ByVal value As Color)
				SetProperty(Function() DataAreaSelectedColor, value)
			End Set
		End Property

		Public Property IsMultipleColorsMode() As Boolean
			Get
				Return GetProperty(Function() IsMultipleColorsMode)
			End Get
			Set(ByVal value As Boolean)
				SetProperty(Function() IsMultipleColorsMode, value)
			End Set
		End Property

		Public Overridable Property Items() As ObservableCollection(Of Employee)
			Get
				Return GetProperty(Function() Items)
			End Get
			Set(ByVal value As ObservableCollection(Of Employee))
				SetProperty(Function() Items, value)
			End Set
		End Property

		Public Sub New()
			UseBackground = True
			Items = Stuff.GetStuff()
		End Sub
	End Class


	Public Class Employee
		Public Property ID() As Integer
		Public Property Name() As String
		Public Property Position() As String
		Public Property Department() As String
		Public Overrides Function ToString() As String
			Return Name
		End Function
	End Class

	Public Module Stuff
		Public Function GetStuff() As ObservableCollection(Of Employee)
'INSTANT VB NOTE: The variable stuff was renamed since it may cause conflicts with calls to static members of the user-defined type with this name:
			Dim stuff_Conflict As New ObservableCollection(Of Employee)()
			stuff_Conflict.Add(New Employee() With {
				.ID = 1,
				.Name = "Gregory S. Price",
				.Department = "",
				.Position = "President"
			})
			stuff_Conflict.Add(New Employee() With {
				.ID = 2,
				.Name = "Irma R. Marshall",
				.Department = "Marketing",
				.Position = "Vice President"
			})
			stuff_Conflict.Add(New Employee() With {
				.ID = 3,
				.Name = "John C. Powell",
				.Department = "Operations",
				.Position = "Vice President"
			})
			stuff_Conflict.Add(New Employee() With {
				.ID = 4,
				.Name = "Christian P. Laclair",
				.Department = "Production",
				.Position = "Vice President"
			})
			stuff_Conflict.Add(New Employee() With {
				.ID = 5,
				.Name = "Karen J. Kelly",
				.Department = "Finance",
				.Position = "Vice President"
			})

			stuff_Conflict.Add(New Employee() With {
				.ID = 6,
				.Name = "Brian C. Cowling",
				.Department = "Marketing",
				.Position = "Manager"
			})
			stuff_Conflict.Add(New Employee() With {
				.ID = 7,
				.Name = "Thomas C. Dawson",
				.Department = "Marketing",
				.Position = "Manager"
			})
			stuff_Conflict.Add(New Employee() With {
				.ID = 8,
				.Name = "Angel M. Wilson",
				.Department = "Marketing",
				.Position = "Manager"
			})
			stuff_Conflict.Add(New Employee() With {
				.ID = 9,
				.Name = "Bryan R. Henderson",
				.Department = "Marketing",
				.Position = "Manager"
			})

			stuff_Conflict.Add(New Employee() With {
				.ID = 10,
				.Name = "Harold S. Brandes",
				.Department = "Operations",
				.Position = "Manager"
			})
			stuff_Conflict.Add(New Employee() With {
				.ID = 11,
				.Name = "Michael S. Blevins",
				.Department = "Operations",
				.Position = "Manager"
			})
			stuff_Conflict.Add(New Employee() With {
				.ID = 12,
				.Name = "Jan K. Sisk",
				.Department = "Operations",
				.Position = "Manager"
			})
			stuff_Conflict.Add(New Employee() With {
				.ID = 13,
				.Name = "Sidney L. Holder",
				.Department = "Operations",
				.Position = "Manager"
			})

			stuff_Conflict.Add(New Employee() With {
				.ID = 14,
				.Name = "James L. Kelsey",
				.Department = "Production",
				.Position = "Manager"
			})
			stuff_Conflict.Add(New Employee() With {
				.ID = 15,
				.Name = "Howard M. Carpenter",
				.Department = "Production",
				.Position = "Manager"
			})
			stuff_Conflict.Add(New Employee() With {
				.ID = 16,
				.Name = "Jennifer T. Tapia",
				.Department = "Production",
				.Position = "Manager"
			})

			stuff_Conflict.Add(New Employee() With {
				.ID = 17,
				.Name = "Judith P. Underhill",
				.Department = "Finance",
				.Position = "Manager"
			})
			stuff_Conflict.Add(New Employee() With {
				.ID = 18,
				.Name = "Russell E. Belton",
				.Department = "Finance",
				.Position = "Manager"
			})
			Return stuff_Conflict
		End Function
	End Module
End Namespace
