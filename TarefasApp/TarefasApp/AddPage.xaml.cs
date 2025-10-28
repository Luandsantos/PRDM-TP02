using System.Collections.ObjectModel;
// CBTPRDM TP02 - Luan dos Santos Sales Pinheiro
namespace TarefasApp;
public partial class AddPage : ContentPage
{
    public int id_atual;
    public AddPage(ObservableCollection<Tarefa> task_list)
	{
        InitializeComponent();
	}

    private void AddTaskClicked(object sender, EventArgs e)
    {
        Tarefa new_task = new Tarefa
        {
            Titulo = input_titulo.Text,
            Descricao = input_descricao.Text,
            Data = input_data.Date,
            Prioridade = input_prioridade.Text,
            Id = Tarefa.Id_atual
        };

        Tarefa.Id_atual += 1;
        Tarefa.task_list.Add(new_task);

        Navigation.PopModalAsync();

    }
}