using System;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace D02InputKit.Views
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class PageCheckBox : ContentPage
    {
        int intCred01 = 6, intCred02 = 5, intCred03 = 4, intCred04 = 6, intCred05 = 3, intTotalCredito, intTotalCurso;
        public PageCheckBox()
        {
            InitializeComponent();
        }
        protected override async void OnAppearing()
        {
            base.OnAppearing();            
        }
        private void mat_Clicked(object sender, EventArgs e)
        {
            intTotalCredito = 0;
            intTotalCurso = 0;

            if (CUR01.IsChecked == true)
            {
                intTotalCredito = intCred01;
                intTotalCurso = 1;
            }
            if (CUR02.IsChecked == true)
            {
                intTotalCredito += intCred02;
                intTotalCurso += 1;
            }
            if (CUR03.IsChecked == true)
            {   
                intTotalCredito += intCred03;
                intTotalCurso += 1;
            }
            if (CUR04.IsChecked == true)
            {
                intTotalCredito += intCred04;
                intTotalCurso += 1;
            }
            if (CUR05.IsChecked == true)
            {
                intTotalCredito += intCred05;
                intTotalCurso += 1;
            }
            totalCursos.Text = Convert.ToString(intTotalCurso);
            totalCreditos.Text = Convert.ToString(intTotalCredito);
            reset_Controles();
        }
        void reset_Controles() {
            CUR01.IsChecked = false;
            CUR02.IsChecked = false;
            CUR03.IsChecked = false;
            CUR04.IsChecked = false;
            CUR05.IsChecked = false;
        }
    }
}