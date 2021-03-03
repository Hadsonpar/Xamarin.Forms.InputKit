using System;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;
namespace D01InputKit.Views
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class PageRadioButton : ContentPage
    {
        public PageRadioButton()
        {
            InitializeComponent();
            tpickerTime.Time = DateTime.Now.TimeOfDay;//Horario actual
            dpFechaIng.Date = DateTime.Now.Date;//Fecha actual
            editorValueGlu.Focus();
        }

        #region 1radioButton
        /// <summary>
        /// Método para controlar los RadioButtons según el RadioButtonGroupView
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private async void ingSelected(object sender, EventArgs e)
        {
            reset_Clicked();
            var item = tipIngreso.SelectedItem.ToString();

            if (item == "TD")
            {
                fSecValue.IsVisible = true;
                fSecDateTime.IsVisible = false;

                lblFecha.IsVisible = false;
                etiquetaFecha.IsVisible = false;
            }
            if (item == "PD")
            {
                tpickerTime.Time = DateTime.Now.TimeOfDay;//Horario actual
                dpFechaIng.Date = DateTime.Now.Date;//Fecha actual

                fSecValue.IsVisible = true;
                fSecDateTime.IsVisible = true;

                lblFecha.IsVisible = true;
                etiquetaFecha.IsVisible = true;
            }
        }
        #endregion

        protected override async void OnAppearing()
        {
            base.OnAppearing();
        }

        private async void ing_Clicked(object sender, EventArgs e)
        {
            if ((string.IsNullOrWhiteSpace(editorValueGlu.Text)) || (string.IsNullOrWhiteSpace(editorValueGlu.Text)))
            {
                await DisplayAlert("Alerta", "Debe ingresar un valor.", "Aceptar");
                editorValueGlu.Focus();
            }
            else if ((string.IsNullOrWhiteSpace(comentValueGlu.Text)) || (string.IsNullOrWhiteSpace(comentValueGlu.Text)))
            {
                await DisplayAlert("Alerta", "Debe ingresar una nota.", "Aceptar");
                comentValueGlu.Focus();
            }
            else
            {
                lblValor.Text = editorValueGlu.Text;
                lblNota.Text = comentValueGlu.Text;
                lblFecha.Text = Convert.ToString(dpFechaIng.Date.ToString("dddd, dd MMMM yyyy"));

                clear_Clicked();
                OnAppearing();
            }
        }

        private void clear_Clicked()
        {
            editorValueGlu.Text = null;
            comentValueGlu.Text = null;
        }

        private void reset_Clicked() {
            lblValor.Text = null;
            lblNota.Text = null;
            lblFecha.Text = null;

            editorValueGlu.Text = null;
            comentValueGlu.Text = null;
        }
    }
}