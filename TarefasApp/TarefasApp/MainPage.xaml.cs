using System.Collections.ObjectModel;

namespace TarefasApp
{
    public partial class MainPage : ContentPage
    {
        ObservableCollection<Tarefa> Tarefas = new ObservableCollection<Tarefa>();
        List<Tarefa> task_list = new List<Tarefa>();
        public MainPage()
        {
            InitializeComponent();
        }

        public MainPage(Tarefa new_task)
        {
            InitializeComponent();
            CarregaItens(new_task);
        }

        void CarregaItens(Tarefa new_task)
        {
            //Tarefa new_task = new Tarefa { Titulo = "Titulo"};
            task_list.Add(new_task);
            lista_tarefas.ItemsSource = task_list;
            /*lista_tarefas.ItemsSource = new List<Tarefa>
            {
               new Tarefa { Titulo="Tarefa1",
                               Descricao = "Descricao", Prioridade ="Prioridade1" },
               new Tarefa { Titulo="Tarefa2",
                              Descricao = "Descricao",  Prioridade = "Prioridade2" }
            };
            */
        }

        private void OnItemClicked(object sender, ItemTappedEventArgs e)
        {
            //var tarefa_escolhida = e.Item as Tarefa;
            //Navigation.PushModalAsync(new DetailsPage(tarefa_escolhida));
        }

        private void OnAddPageClicked(object sender, EventArgs e)
        {
            Navigation.PushModalAsync(new AddPage(task_list));
        }
    }

}
