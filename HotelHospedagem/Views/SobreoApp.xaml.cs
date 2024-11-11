namespace HotelHospedagem.Views;

public partial class SobreoApp : ContentPage
{
    
    public SobreoApp() => InitializeComponent();

    private void Button_Clicked3(object sender, EventArgs e)
    {
        try
        {
            Navigation.PushAsync(new ContratacaoHospedagem());

        }
        catch (Exception ex)
        {
            DisplayAlert("Ops", ex.Message, "OK");
        }
    }
}
