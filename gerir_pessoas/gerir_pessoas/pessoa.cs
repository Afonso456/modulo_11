using System;
using System.Collections.Generic;
using System.Text;

namespace gerir_pessoas
{
    internal class pessoa
    {
        public int id { get; set; }
        public string nome { get; set; }
        public int idade { get; set; }
        public string email { get; set; }

        public pessoa(int id, string nome, int idade, string email)
        {
            this.id = id;
            this.nome = nome;
            this.idade = idade;
            this.email = email;
        }
        public pessoa()
        {
            
        }
        public override string ToString()
        {
            return $"{id};{nome};{idade};s{email}";
        }
    }
}
