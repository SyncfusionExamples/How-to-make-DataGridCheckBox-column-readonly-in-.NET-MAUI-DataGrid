using Syncfusion.Maui.DataGrid;
using Syncfusion.Maui.DataGrid.Helper;
using System.Globalization;

namespace SfDataGridSample
{
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

}
