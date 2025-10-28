using System.Linq;
// CBTPRDM TP02 - Luan dos Santos Sales Pinheiro
namespace TarefasApp;
public partial class EditPage : ContentPage
{
    public int id_task_atual;
    
    public EditPage()
    {
        InitializeComponent();
        NavigationPage.SetHasBackButton(this, false);
    }

    public EditPage(int id_task)
    {
        InitializeComponent();
        NavigationPage.SetHasBackButton(this, false);
        var tarefa = Tarefa.task_list.FirstOrDefault(t => t.Id == id_task);
        if (tarefa != null)
        {
            edit_titulo.Text = tarefa.Titulo;
            edit_descricao.Text = tarefa.Descricao;
            edit_prioridade.Text = tarefa.Prioridade;
            edit_data.Date = tarefa.Data;
            id_task_atual = id_task;
        }
    }

    public async void ConfirmEditClicked(object sender, EventArgs e)
    {
        var tarefa = Tarefa.task_list.FirstOrDefault(t => t.Id == id_task_atual);
        if (tarefa != null)
        {
            tarefa.Titulo = edit_titulo.Text;
            tarefa.Descricao = edit_descricao.Text;
            tarefa.Prioridade = edit_prioridade.Text;
            tarefa.Data = edit_data.Date;
        }
        await Navigation.PopModalAsync();

        if (Application.Current.MainPage is NavigationPage navPage)
        {
            await navPage.PopToRootAsync();
        }
    }
}