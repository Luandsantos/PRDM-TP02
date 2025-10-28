using System.Collections.ObjectModel;
// CBTPRDM TP02 - Luan dos Santos Sales Pinheiro
namespace TarefasApp
{
    public partial class MainPage : ContentPage
    {
        public MainPage()
        {
            InitializeComponent();
            lista_tarefas.ItemsSource = Tarefa.task_list;
        }

        private void OnItemClicked(object sender, ItemTappedEventArgs e)
        {
            var tarefa_escolhida = e.Item as Tarefa;
            Navigation.PushAsync(new DetailsPage(tarefa_escolhida));
        }

        private void OnAddPageClicked(object sender, EventArgs e)
        {
            Navigation.PushModalAsync(new AddPage(Tarefa.task_list));
        }
    }

}
