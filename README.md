# wpf-kanban-examples

This repository contains several sample WPF projects that demonstrate usage patterns, implementation ideas,
and integration strategies for a Kanban control in WPF applications. The samples are intentionally small,
self-contained, and ready to open in Visual Studio. They illustrate practical scenarios such as custom-field
sorting, index-based ordering, MVVM-friendly wiring, and UI composition best practices.

Included samples
- `CustomFieldSorting/` — Demonstrates how to sort Kanban cards by a custom field (for example, an
	enum-based `Priority` or a status string). This sample includes a simple `CardDetails` model and a
	`KanbanViewModel` showing how to apply sorting rules while keeping the UI responsive.
- `IndexBasedSorting/` — Shows how to preserve manual ordering using index values on cards. Useful when
	users expect to reorder items manually and that order must be persisted.

Getting started
1. Requirements: Visual Studio 2019 or later (or a compatible MSBuild toolchain) and the .NET Framework
	 targeted by the projects. (Open the individual project files for exact framework versions.)
2. Open a solution: choose the sample you want to try and open its solution file. For example,
	 open `CustomFieldSorting/CustomFieldSorting.slnx` in Visual Studio.
3. Build and run: build the solution and run the WPF application. The sample apps are desktop WPF
	 projects that launch with a `MainWindow` showcasing the Kanban board behavior.

How each sample works (high level)
- Custom field sorting: the sample binds a collection of `CardDetails` objects to the Kanban control.
	Sorting is implemented in the view model so it can be unit-tested and maintained separately from the UI.
- Index-based sorting: each card contains an index/property the control uses to order items. The view model
	provides helper methods to shift indices when items are moved by the user.

Extending the samples
- To adapt a sample to your app, extract the `Model` and `ViewModel` folders and wire them to your own
	Kanban control instance or third-party control. The projects are minimal on purpose so you can copy only
	the pieces you need.

Troubleshooting
- If a sample fails to build, check the Visual Studio output for the targeted .NET Framework. Restore any
	missing SDKs or workloads via the Visual Studio Installer. If the Kanban control itself is third-party,
	ensure related NuGet packages are available in your feeds.

Contributing
Contributions are welcome. Please open an issue to discuss larger changes, and submit focused pull
requests for fixes or small feature additions. Keep changes to a single sample per PR to simplify reviews.

License and credits
Unless otherwise specified in a sample folder, code in this repository is provided for demonstration
purposes and may be used as a starting point for your own implementations. If you want a formal license
applied, open an issue and we can add one.

Contact
If you have questions, feature requests, or problems running the samples, please open an issue in this
repository so the maintainers can triage and respond.

-- End of README --
