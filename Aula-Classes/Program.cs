using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Aula_Classes
{
    class Program
    {
        static void Main(string[] args)
        {
            carro objeto = new carro("verde");
            Console.WriteLine(objeto.Cor);
            Console.ReadKey();
        }
    }

    class carro
    {
        private string _cor;


        public carro(String cor)
        {
            this._cor = cor;
        }
        
        //public string Cor
        //{
        //    get { return _cor; }
        //    set { _cor = value; }
        //}

        public string exemplo { get; set; }
        public string Cor {

            get { return _cor; }
            set
            {

                if (value.Contains("Preto"))
                {
                    _cor = value;
                }else
                {
                    throw new Exception("cores n suportada");
                }
            }

        }

        public string Descricao()
        {
             return "o carro eh:" + Cor;
        }
    }
}
