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
        data_tarefa.Text = tarefa_escolhida.Data.ToString();
        prioridade_tarefa.Text = tarefa_escolhida.Prioridade;
    }
}