using EstudandoApp.Telas.Login;

namespace EstudandoApp;

public partial class App : Application
{
	public App()
	{
		InitializeComponent();

		MainPage = new Login1();
	}
}
