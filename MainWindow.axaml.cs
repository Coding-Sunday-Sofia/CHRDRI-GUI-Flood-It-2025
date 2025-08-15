/* clear && astyle --style=java --indent=tab *.cs && dotnet run */

using Avalonia.Media;
using Avalonia.Controls;
using Avalonia.Interactivity;

namespace CHRDRI_GUI_Flood_It_2025;

public partial class MainWindow : Window {
	private static Color[] colors = {
		Colors.Yellow,
		Colors.Red,
		Colors.Green,
		Colors.Cyan,
		Colors.Magenta,
		Colors.Blue,
		Colors.Brown,
	};

	private int turn = 0;

	private Button[][] tiles = null;

	private int width = 10;
	private int height = 10;

	private void reset() {
	}

	public MainWindow() {
		InitializeComponent();

		tiles = new Button[width][];
		for(int w=0; w<width; w++) {
			tiles[w] = new Button[ height ];
		}

		tiles[0][0] = this.FindControl<Button>("Button0000");
		tiles[1][0] = this.FindControl<Button>("Button0100");
		tiles[2][0] = this.FindControl<Button>("Button0200");
		tiles[3][0] = this.FindControl<Button>("Button0300");
		tiles[4][0] = this.FindControl<Button>("Button0400");
		tiles[5][0] = this.FindControl<Button>("Button0500");
		tiles[6][0] = this.FindControl<Button>("Button0600");
		tiles[7][0] = this.FindControl<Button>("Button0700");
		tiles[8][0] = this.FindControl<Button>("Button0800");
		tiles[9][0] = this.FindControl<Button>("Button0900");
		tiles[0][1] = this.FindControl<Button>("Button0001");
		tiles[1][1] = this.FindControl<Button>("Button0101");
		tiles[2][1] = this.FindControl<Button>("Button0201");
		tiles[3][1] = this.FindControl<Button>("Button0301");
		tiles[4][1] = this.FindControl<Button>("Button0401");
		tiles[5][1] = this.FindControl<Button>("Button0501");
		tiles[6][1] = this.FindControl<Button>("Button0601");
		tiles[7][1] = this.FindControl<Button>("Button0701");
		tiles[8][1] = this.FindControl<Button>("Button0801");
		tiles[9][1] = this.FindControl<Button>("Button0901");
		tiles[0][2] = this.FindControl<Button>("Button0002");
		tiles[1][2] = this.FindControl<Button>("Button0102");
		tiles[2][2] = this.FindControl<Button>("Button0202");
		tiles[3][2] = this.FindControl<Button>("Button0302");
		tiles[4][2] = this.FindControl<Button>("Button0402");
		tiles[5][2] = this.FindControl<Button>("Button0502");
		tiles[6][2] = this.FindControl<Button>("Button0602");
		tiles[7][2] = this.FindControl<Button>("Button0702");
		tiles[8][2] = this.FindControl<Button>("Button0802");
		tiles[9][2] = this.FindControl<Button>("Button0902");
		tiles[0][3] = this.FindControl<Button>("Button0003");
		tiles[1][3] = this.FindControl<Button>("Button0103");
		tiles[2][3] = this.FindControl<Button>("Button0203");
		tiles[3][3] = this.FindControl<Button>("Button0303");
		tiles[4][3] = this.FindControl<Button>("Button0403");
		tiles[5][3] = this.FindControl<Button>("Button0503");
		tiles[6][3] = this.FindControl<Button>("Button0603");
		tiles[7][3] = this.FindControl<Button>("Button0703");
		tiles[8][3] = this.FindControl<Button>("Button0803");
		tiles[9][3] = this.FindControl<Button>("Button0903");
		tiles[0][4] = this.FindControl<Button>("Button0004");
		tiles[1][4] = this.FindControl<Button>("Button0104");
		tiles[2][4] = this.FindControl<Button>("Button0204");
		tiles[3][4] = this.FindControl<Button>("Button0304");
		tiles[4][4] = this.FindControl<Button>("Button0404");
		tiles[5][4] = this.FindControl<Button>("Button0504");
		tiles[6][4] = this.FindControl<Button>("Button0604");
		tiles[7][4] = this.FindControl<Button>("Button0704");
		tiles[8][4] = this.FindControl<Button>("Button0804");
		tiles[9][4] = this.FindControl<Button>("Button0904");
		tiles[0][5] = this.FindControl<Button>("Button0005");
		tiles[1][5] = this.FindControl<Button>("Button0105");
		tiles[2][5] = this.FindControl<Button>("Button0205");
		tiles[3][5] = this.FindControl<Button>("Button0305");
		tiles[4][5] = this.FindControl<Button>("Button0405");
		tiles[5][5] = this.FindControl<Button>("Button0505");
		tiles[6][5] = this.FindControl<Button>("Button0605");
		tiles[7][5] = this.FindControl<Button>("Button0705");
		tiles[8][5] = this.FindControl<Button>("Button0805");
		tiles[9][5] = this.FindControl<Button>("Button0905");
		tiles[0][6] = this.FindControl<Button>("Button0006");
		tiles[1][6] = this.FindControl<Button>("Button0106");
		tiles[2][6] = this.FindControl<Button>("Button0206");
		tiles[3][6] = this.FindControl<Button>("Button0306");
		tiles[4][6] = this.FindControl<Button>("Button0406");
		tiles[5][6] = this.FindControl<Button>("Button0506");
		tiles[6][6] = this.FindControl<Button>("Button0606");
		tiles[7][6] = this.FindControl<Button>("Button0706");
		tiles[8][6] = this.FindControl<Button>("Button0806");
		tiles[9][6] = this.FindControl<Button>("Button0906");
		tiles[0][7] = this.FindControl<Button>("Button0007");
		tiles[1][7] = this.FindControl<Button>("Button0107");
		tiles[2][7] = this.FindControl<Button>("Button0207");
		tiles[3][7] = this.FindControl<Button>("Button0307");
		tiles[4][7] = this.FindControl<Button>("Button0407");
		tiles[5][7] = this.FindControl<Button>("Button0507");
		tiles[6][7] = this.FindControl<Button>("Button0607");
		tiles[7][7] = this.FindControl<Button>("Button0707");
		tiles[8][7] = this.FindControl<Button>("Button0807");
		tiles[9][7] = this.FindControl<Button>("Button0907");
		tiles[0][8] = this.FindControl<Button>("Button0008");
		tiles[1][8] = this.FindControl<Button>("Button0108");
		tiles[2][8] = this.FindControl<Button>("Button0208");
		tiles[3][8] = this.FindControl<Button>("Button0308");
		tiles[4][8] = this.FindControl<Button>("Button0408");
		tiles[5][8] = this.FindControl<Button>("Button0508");
		tiles[6][8] = this.FindControl<Button>("Button0608");
		tiles[7][8] = this.FindControl<Button>("Button0708");
		tiles[8][8] = this.FindControl<Button>("Button0808");
		tiles[9][8] = this.FindControl<Button>("Button0908");
		tiles[0][9] = this.FindControl<Button>("Button0009");
		tiles[1][9] = this.FindControl<Button>("Button0109");
		tiles[2][9] = this.FindControl<Button>("Button0209");
		tiles[3][9] = this.FindControl<Button>("Button0309");
		tiles[4][9] = this.FindControl<Button>("Button0409");
		tiles[5][9] = this.FindControl<Button>("Button0509");
		tiles[6][9] = this.FindControl<Button>("Button0609");
		tiles[7][9] = this.FindControl<Button>("Button0709");
		tiles[8][9] = this.FindControl<Button>("Button0809");
		tiles[9][9] = this.FindControl<Button>("Button0909");
	}

	private void onButtonClick(object? sender, RoutedEventArgs e) {
		this.Title = "Hi!";
		((Button)sender).Background = new SolidColorBrush(Colors.Green);
	}
}

