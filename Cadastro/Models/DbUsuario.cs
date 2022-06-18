using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Cadastro.Models
{
    [Table("usuario", Schema = "public")]
    public class DbUsuario
    {
        [Key]
        public int id { get; set; }
        public string nome { get; set; }
        public string email { get; set; }
        public DateTime datanascimento { get; set; }
        public string sexo { get; set; }
        public string rua { get; set; }
        public string numero { get; set; }
        public string cep { get; set; }
        public string cidade { get; set; }
        public string estado { get; set; }
        public int grau { get; set; }
        public string mensagem { get; set; }
    }
}
