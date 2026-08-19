# WPF Kanban Sorting

This sample demonstrates how to sort cards in the **Syncfusion WPF Kanban** control using different sorting approaches. The application showcases both **Custom Field Sorting** and **Index-Based Sorting**, enabling flexible card organization and drag-and-drop reordering scenarios.

## Features Demonstrated

### Custom Field Sorting
- Sorts Kanban cards using a custom data model property such as Priority, Due Date, or Status.
- Uses the `SortingMappingPath` property to map the sorting field.
- Supports both ascending and descending sorting orders.
- Automatically rearranges cards based on the configured field value.

### Index-Based Sorting
- Sorts cards using a dedicated numeric `Index` field.
- Allows cards to be dropped at specific positions within a Kanban column.
- Updates index values dynamically after drag-and-drop operations.
- Preserves user-defined card ordering across columns.

### Drag-and-Drop Reordering
- Supports moving cards within a column or across columns.
- Updates sorting information when cards are repositioned.
- Refreshes the target column to reflect the latest card order.

### Sorting Order Support
- Supports both ascending and descending sorting modes.
- Dynamically updates the card arrangement based on the selected sorting order.
- Provides a consistent card sequence across Kanban columns.

### Data-Driven Card Organization
- Uses business object properties to control card placement.
- Supports workflow management, task prioritization, and custom ranking scenarios.
- Demonstrates flexible sorting configurations for real-world Kanban applications.


## Documentation Reference

[WPF Kanban Sorting](https://help.syncfusion.com/wpf/kanban-board/sorting)