using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain.Entities
{
    public class Mensagem
    {
        public long id { get; set; }
        public string conteudo { get; set; }
        public DateTime data_envio { get; set; }
        public int status { get; set; } // 0 - Pendente, 1 - Enviada, 2 - Lida
        public long chat_id { get; set; } // ID do chat associado
        public long usuario_id { get; set; } // ID do usuário que enviou a mensagem
    }
}
