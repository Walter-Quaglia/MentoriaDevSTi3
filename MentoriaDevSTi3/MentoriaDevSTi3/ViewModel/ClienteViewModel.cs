 using System;

namespace MentoriaDevSTi3.ViewModel
{
    public class ClienteViewModel
    {
        public string Nome { get; set; }
        public DateTime DataNascimento { get; set; }
        public string Cep { get; set; }
        public string Endereco { get; set; }
        public string Cidade { get; set; }
        public long Id { get; internal set; }
    }
}
