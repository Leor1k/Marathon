using System.Windows.Controls;
using System.Windows;

namespace AppForMaraphone.Classes
{
    public class Grids
    {
        public  static void HideGrid(Grid selectedGrid, TextBlock tb, Grid parentKid)
        {
            foreach (var grid in parentKid.Children)
            {
                if (grid.GetType() == typeof(Grid))
                {
                    Grid grid1 = grid as Grid;
                    grid1.Visibility = Visibility.Hidden;
                }
            }
            selectedGrid.Visibility = Visibility.Visible;
            if (selectedGrid.Name == "first_grid")
            {
                tb.Text = "";
            }
            else
            {
                tb.Text = selectedGrid.Name.Replace('0', ' ');
            }
        }
    }
}
