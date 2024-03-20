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
                string s = sr.ReadLine();
                Ingrediente g;
                switch (s.Split(';')[1])
                {
                    case "Panna":
                        g = new IngredientePanna(s);
                        break;
                    case "Colorante":
                        g = new IngredienteColorante(s);
                        break;
                    case "Latte":
                        g = new IngredienteLatte(s);
                        break;
                    default:
                        g = new Ingrediente(s);
                        break;

                }
                Add(g);
            }
        }
    }
    internal class IngredientePanna : Ingrediente
    {
        private string _calorie;
        public IngredientePanna(string s) : base(s)
        {
            _calorie = s.Split(';')[3];
        }
        public string Calorie
        {
            get => _calorie;
        }
    }
    internal class IngredienteColorante : Ingrediente
    {
        private string _colorante;
        public IngredienteColorante(string s) : base(s)
        {
            _colorante = s.Split(';')[3];
        }
        public string Colorante
        {
            get => _colorante;
        }
    }
    internal class IngredienteLatte : Ingrediente
    {
        private string _lattosio;
        public IngredienteLatte(string s) : base(s)
        {
            _lattosio = s.Split(';')[3];
        }
        public string Calorie
        {
            get => _lattosio;
        }
    }
}
