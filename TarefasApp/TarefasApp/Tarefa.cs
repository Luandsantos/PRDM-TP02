using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
// CBTPRDM TP02 - Luan dos Santos Sales Pinheiro
namespace TarefasApp
{
    public class Tarefa
    {
        public string Titulo { get; set; }
        public string Descricao { get; set; }
        public DateTime Data { get; set; }
        public string Prioridade { get; set; }
        public int Id { get; set; }

        public static int Id_atual = 0;

        public static ObservableCollection<Tarefa> task_list = new ObservableCollection<Tarefa>();
    }
}
