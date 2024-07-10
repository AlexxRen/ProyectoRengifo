using ProyectoRengifo;

namespace ProyectoRengifo.UsserControl;

public partial class FlyoutHeaderControl : ContentView
{
	public FlyoutHeaderControl()
	{
		InitializeComponent();
		if (App.fZT != null)
		{
			LblUserName.Text="Adios Session: " + App.fZT;
			LblUserEmail.Text = App.fZT.User;
		}
	}
}