// CBTPRDM TP02 - Luan dos Santos Sales Pinheiro
namespace TarefasApp;

public partial class DetailsPage : ContentPage
{
	public DetailsPage()
	{
		InitializeComponent();
	}

    public DetailsPage(Tarefa tarefa_escolhida)
    {
        InitializeComponent();
        nome_tarefa.Text = tarefa_escolhida.Titulo;
        descricao_tarefa.Text = tarefa_escolhida.Descricao;
        data_tarefa.Text = tarefa_escolhida.Data.ToString().Substring(0, 10);
        prioridade_tarefa.Text = tarefa_escolhida.Prioridade;
        id_tarefa.Text = tarefa_escolhida.Id.ToString();
    }

    public async void EditTaskClicked(object sender, EventArgs e)
    {
        int id_task = Int32.Parse(id_tarefa.Text);
        NavigationPage.SetHasNavigationBar(this, false);
        NavigationPage.SetHasBackButton(this, false);
        await Navigation.PushModalAsync(new EditPage(id_task));
    }
    public async void DeleteTaskClicked(object sender, EventArgs e)
    {
        bool confirmar = await DisplayAlert("Confirmar exclusão", "Você quer excluir essa tarefa?", "Sim", "Não");
        if (confirmar == true)
        {
            int id_task = Int32.Parse(id_tarefa.Text);
            var tarefa = Tarefa.task_list.FirstOrDefault(t => t.Id == id_task);
            if (tarefa != null)
            {
                Tarefa.task_list.Remove(tarefa);
            }

            await Navigation.PopAsync();
        }
    }
}