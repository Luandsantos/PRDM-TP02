using System.Collections.ObjectModel;

namespace TarefasApp;

public partial class AddPage : ContentPage
{
	public AddPage(List<Tarefa> task_list)
	{
		InitializeComponent();
	}

    private void AddTaskClicked(object sender, EventArgs e)
    {
        Tarefa new_task = new Tarefa { 
            Titulo = input_titulo.Text,
            Descricao = input_descricao.Text,
            Data = input_data.Date,
            Prioridade = input_prioridade.Text};
        //task_list.Add(new_task);

        /*
        ObservableCollection<Tarefa> Tarefas = new ObservableCollection<Tarefa>();
        lista_tarefas.ItemsSource = new List<Tarefa>
            {
               new Tarefa { Titulo="Tarefa1",
                               Descricao = "Descricao", Prioridade ="Prioridade1" },
               new Tarefa { Titulo="Tarefa2",
                              Descricao = "Descricao",  Prioridade = "Prioridade2" }
            };
        */

        BindingContext = new_task;
        Navigation.PushModalAsync(new MainPage(new_task));
    }



}