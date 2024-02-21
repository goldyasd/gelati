using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace nsGelati
{
    internal class Ingrediente
    {
        private int _idGelato;
        private TipoIngrediente _tipo;
        private string _valore;

        public Ingrediente(string s)
        {
            string[] ar = s.Split(';');
            _idGelato = int.Parse(ar[0]);
            _tipo = Enum.Parse<TipoIngrediente>(ar[1]);
            _valore = ar[2];
        }

        public int IdGelato { get => _idGelato; set => _idGelato = value; }
        public TipoIngrediente Tipo { get => _tipo; set => _tipo = value; }
        public string Valore { get => _valore; set => _valore = value; }
        
    }
    internal class Ingredienti : List<Ingrediente>
    {
        public Ingredienti() { }
        public Ingredienti(string file)
        {
            StreamReader sr = new StreamReader(file);
            sr.ReadLine();
            while (!sr.EndOfStream)
            {
                Ingrediente g = new Ingrediente(sr.ReadLine());
                Add(g);
            }
        }
    }
}
