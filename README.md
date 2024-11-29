# How to make DataGridCheckBox column readonly in .NET MAUI DataGrid (SfDataGrid)?
In this article, we will show you how to make DataGridCheckBox column readonly in [.Net Maui DataGrid](https://www.syncfusion.com/maui-controls/maui-datagrid).

## xaml
```
 <ContentPage.BindingContext>
     <local:EmployeeViewModel x:Name="viewModel"/>
 </ContentPage.BindingContext>

 <syncfusion:SfDataGrid x:Name="dataGrid"
                        GridLinesVisibility="Both"
                        HeaderGridLinesVisibility="Both"
                        ColumnWidthMode="Auto"
                        AutoGenerateColumnsMode="None"
                        ItemsSource="{Binding Employees}">

     <syncfusion:SfDataGrid.Columns>
         <syncfusion:DataGridNumericColumn MappingName="EmployeeID"
                                           Format="#"
                                           HeaderText="Employee ID" />
         <syncfusion:DataGridTextColumn MappingName="Name"
                                        HeaderText="Employee Name" />
         <syncfusion:DataGridTextColumn MappingName="Title"
                                        HeaderText="Designation" />
         <syncfusion:DataGridDateColumn MappingName="HireDate"
                                        HeaderText="Hire Date" />
         <syncfusion:DataGridCheckBoxColumn MappingName="EmployeeStatus"
                                            HeaderText="Employee Status" />

     </syncfusion:SfDataGrid.Columns>

 </syncfusion:SfDataGrid>
```

## C# 
The below code illustrates how to make DataGridCheckBox column readonly with custom checkBoxRenderer in dataGrid.
```
public partial class MainPage : ContentPage
{
    public MainPage()
    {
        InitializeComponent();
        this.dataGrid.CellRenderers.Remove("CheckBox");
        dataGrid.CellRenderers.Add("CheckBox", new DataGridCheckBoxCellRendererExt());
    }
}

public class DataGridCheckBoxCellRendererExt : DataGridCheckBoxCellRenderer
{
    protected override void OnInitializeDisplayView(DataColumnBase dataColumn, StackLayout? view)
    {
        base.OnInitializeDisplayView(dataColumn, view);

        if (view != null && view.Children[0] is CheckBox checkBox)
        {
            checkBox.IsEnabled = false;
        }
    }
}  
```

![CheckBoxdisabled.png](https://support.syncfusion.com/kb/agent/attachment/inline?token=eyJhbGciOiJodHRwOi8vd3d3LnczLm9yZy8yMDAxLzA0L3htbGRzaWctbW9yZSNobWFjLXNoYTI1NiIsInR5cCI6IkpXVCJ9.eyJpZCI6IjMzMDA2Iiwib3JnaWQiOiIzIiwiaXNzIjoic3VwcG9ydC5zeW5jZnVzaW9uLmNvbSJ9.Zz0QFfn6THDqAgV348JTriPj7hC7-UHFfQ_gG2ooDPY)

[View sample in GitHub](https://github.com/SyncfusionExamples/How-to-make-DataGridCheckBox-column-readonly-in-.NET-MAUI-DataGrid)

Take a moment to explore this [documentation](https://help.syncfusion.com/maui/datagrid/overview), where you can find more information about Syncfusion .NET MAUI DataGrid (SfDataGrid) with code examples. Please refer to this [link](https://www.syncfusion.com/maui-controls/maui-datagrid) to learn about the essential features of Syncfusion .NET MAUI DataGrid (SfDataGrid).
 
##### Conclusion
 
I hope you enjoyed learning about how to make DataGridCheckBox column readonly in .NET MAUI DataGrid (SfDataGrid).
 
You can refer to our [.NET MAUI DataGrid’s feature tour](https://www.syncfusion.com/maui-controls/maui-datagrid) page to learn about its other groundbreaking feature representations. You can also explore our [.NET MAUI DataGrid Documentation](https://help.syncfusion.com/maui/datagrid/getting-started) to understand how to present and manipulate data. 
For current customers, you can check out our .NET MAUI components on the [License and Downloads](https://www.syncfusion.com/sales/teamlicense) page. If you are new to Syncfusion, you can try our 30-day [free trial](https://www.syncfusion.com/downloads/maui) to explore our .NET MAUI DataGrid and other .NET MAUI components.
 
If you have any queries or require clarifications, please let us know in the comments below. You can also contact us through our [support forums](https://www.syncfusion.com/forums), [Direct-Trac](https://support.syncfusion.com/create) or [feedback portal](https://www.syncfusion.com/feedback/maui?control=sfdatagrid), or the feedback portal. We are always happy to assist you!