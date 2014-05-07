using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;
using System.ComponentModel;

namespace RockSmithTabExplorer.Controls
{
    /// <summary>
    /// Interaction logic for TrackListing.xaml
    /// </summary>
    public partial class TrackListing : UserControl
    {
        public TrackListing()
        {
            InitializeComponent();
        }

        GridViewColumnHeader _lastHeaderClicked = null;
        ListSortDirection _lastDirection = ListSortDirection.Ascending;

        void SortClickHandler(object sender, RoutedEventArgs e)
        {
            GridViewColumnHeader headerClicked = (GridViewColumnHeader)e.OriginalSource;

            if (headerClicked == null || headerClicked.Role == GridViewColumnHeaderRole.Padding)
            {
                return;
            }

            ListSortDirection direction = getDirection(headerClicked);

            Sort((string)headerClicked.Tag, direction);

            headerClicked.Column.HeaderTemplate = getArrow(direction);

            // Remove arrow from previously sorted header
            if (_lastHeaderClicked != null && _lastHeaderClicked != headerClicked)
            {
                _lastHeaderClicked.Column.HeaderTemplate = null;
            }

            _lastHeaderClicked = headerClicked;
            _lastDirection = direction;
        }

        private void Sort(string sortBy, ListSortDirection direction)
        {
            ICollectionView dataView = CollectionViewSource.GetDefaultView(TrackList.ItemsSource);

            dataView.SortDescriptions.Clear();
            SortDescription sd = new SortDescription(sortBy, direction);
            dataView.SortDescriptions.Add(sd);
            dataView.Refresh();
        }

        private DataTemplate getArrow(ListSortDirection direction)
        {
            return (DataTemplate)((direction == ListSortDirection.Ascending) ? Resources["HeaderTemplateArrowUp"] : Resources["HeaderTemplateArrowDown"]);
        }

        private ListSortDirection getDirection(GridViewColumnHeader headerClicked)
        {
            if (headerClicked == _lastHeaderClicked)
            {
                //Reverse direction
                return (_lastDirection == ListSortDirection.Ascending) ? ListSortDirection.Descending :  ListSortDirection.Ascending;
            }
            else
            {
                return ListSortDirection.Ascending;
            }

        }

    }
}
