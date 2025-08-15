/* clear && astyle --style=java --indent=tab *.cs && dotnet run */

using Avalonia.Controls;
using Avalonia.Interactivity;

namespace CHRDRI_GUI_Flood_It_2025;

public partial class MainWindow : Window {
	public MainWindow() {
		InitializeComponent();
	}

	private void onButtonClick(object? sender, RoutedEventArgs e) {
		this.Title = "Hi!";
	}
}

