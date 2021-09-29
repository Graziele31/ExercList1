using ExercList1.modal;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace ExercList1
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class PagListaAluno : ContentPage
    {
        public PagListaAluno()
        {
            InitializeComponent();

            var ListaAlunos = new List<ListaAluno>
            {
                new ListaAluno
                {
                    Foto = "img/um.png",
                    Nome = "Rodrigo de Freitas",
                    Matricula = 2020123,                                    
                },
                new ListaAluno
                {
                    Foto = "img/cinco.png",
                    Nome = "Ana Lúcia",
                    Matricula = 2020221,
                },
                new ListaAluno
                {
                    Foto = "img/quatro.png",
                    Nome = "Cláudia Ribeiro",
                    Matricula = 20201333,
                },
                new ListaAluno
                {
                    Foto = "img/tres.png",
                    Nome = "André dos Santos",
                    Matricula = 20204431,
                },
                new ListaAluno
                {
                    Foto = "img/dois.png",
                    Nome = "Marcos Antônio Teixeira",
                    Matricula = 202014555,
                },
                new ListaAluno
                {
                    Foto = "img/seis.png",
                    Nome = "Luzia Mercedes de Oliveira",
                    Matricula = 202015321,
                },


            };

            LvAlunos.ItemsSource = ListaAlunos;
        }

        private void LvSelecionado(object sender, SelectedItemChangedEventArgs e)
        {

        }

        private void LvTocado(object sender, ItemTappedEventArgs e)
        {

        }
    }

    
}