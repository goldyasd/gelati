using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace nsGelati
{
    internal class Gelato
    {
        protected int _idGelato;
        private string _name;
        private string _description;
        private string _prezzo;

        public Gelato(string g)
        {
            string[] s = g.Split(';');
            _idGelato = int.Parse(s[0]);
            _name = s[1];
            _description = s[2];
            _prezzo = s[3];
        }

        public int Id
        {
            get { return _idGelato; }
        }

        public string Nome { get => _name; set => _name = value; }
        public string Descrizione { get => _description; set => _description = value; }
        public string Prezzo { get => _prezzo; set => _prezzo = value; }
    }
    internal class Gelati : List<Gelato>
    {
        public Gelati(string file)
        {
            StreamReader sr = new StreamReader(file);
            sr.ReadLine();
            while (!sr.EndOfStream)
            {
                Gelato g = new Gelato(sr.ReadLine());
                Add(g);
            }
        }
    }
}
