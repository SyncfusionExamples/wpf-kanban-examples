namespace CustomFieldSorting
{
    using System;
    using System.Collections.ObjectModel;
    using System.Windows;
    using System.Windows.Controls;
    using Syncfusion.SfSkinManager;
    using Syncfusion.UI.Xaml.Kanban;
    using Syncfusion.Windows.Tools.Controls;

    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        #region Constructor

        /// <summary>
        /// Initializes a new instance of the <see cref="MainWindow"/> class.
        /// </summary>
        public MainWindow()
        {
            InitializeComponent();
            this.sortOrderCombobox.ItemsSource = new ObservableCollection<string>() { "Ascending", "Descending" };
            this.sortOrderCombobox.SelectedIndex = 0;
            this.sortOrderCombobox.SelectionChanged += this.OnSortOrderSelectionChanged; ;
            this.mappingPathCombobox.ItemsSource = new ObservableCollection<string>() { "Title", "Priority" };
            this.mappingPathCombobox.SelectedIndex = 0;
            this.mappingPathCombobox.SelectionChanged += OnMappingPathSelectionChanged;
            this.kanban.CardDragEnd += this.OnKanbanCardDragEnd;

            SfSkinManager.SetTheme(this, new Theme("Material3Light"));
        }

        #endregion

        #region Property changed

        /// <summary>
        /// Occurs when the mapping path value is changed.
        /// </summary>
        /// <param name="sender">The object.</param>
        /// <param name="e">The event args.</param>
        private void OnMappingPathSelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            var selectedItem = (sender as ComboBoxAdv)?.SelectedItem?.ToString();
            if (this.kanban == null || string.IsNullOrEmpty(selectedItem))
            {
                return;
            }

            this.kanban.SortingMappingPath = selectedItem;
        }

        /// <summary>
        /// Occurs when the sorting order value is changed.
        /// </summary>
        /// <param name="sender">The object.</param>
        /// <param name="e">The event args.</param>
        private void OnSortOrderSelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            var selectedItem = (sender as ComboBoxAdv)?.SelectedItem?.ToString();
            if (this.kanban == null || selectedItem == null)
            {
                return;
            }

            if (Enum.TryParse<KanbanSortingOrder>(selectedItem.ToString(), out KanbanSortingOrder sortOrder))
            {
                this.kanban.SortingOrder = sortOrder;
            }
        }

        /// <summary>
        /// Occurs when a card drag end event is completed.
        /// </summary>
        /// <param name="sender">The object.</param>
        /// <param name="e">The event args.</param>
        private void OnKanbanCardDragEnd(object sender, KanbanDragEndEventArgs e)
        {
            this.kanban.RefreshKanbanColumn(e.TargetKey.ToString());
        }

        #endregion
    }
}