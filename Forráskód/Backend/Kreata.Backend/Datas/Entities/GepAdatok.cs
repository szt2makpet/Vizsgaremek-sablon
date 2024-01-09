
namespace Kreata.Backend.Datas.Entities
{
    public class GepAdatok
    {
        public GepAdatok(Guid id, string gepneve, int foglaltturista, int foglalt1oszt, int elsoosztulohelyek, int turistaulohelyek)
        {
            Id = id;
            Gepneve = gepneve;
            Foglaltturista = foglaltturista;
            Foglalt1oszt = foglalt1oszt;
            Elsoosztulohelyek = elsoosztulohelyek;
            Turistaulohelyek = turistaulohelyek;

        }

        public GepAdatok(string gepneve, int foglaltturista, int foglalt1oszt, int elsoosztulohelyek, int turistaulohelyek)
        {
            Id = new Guid();
            Gepneve = gepneve;
            Foglaltturista = foglaltturista;
            Foglalt1oszt = foglalt1oszt;
            Elsoosztulohelyek = elsoosztulohelyek;
            Turistaulohelyek = turistaulohelyek;

        }

        public GepAdatok()
        {
            Gepneve = string.Empty;
            Foglaltturista = 0;
            Foglalt1oszt = 0;
            Elsoosztulohelyek = 1;
            Turistaulohelyek = 1;


        }
        public Guid Id { get; set; }
        public string Gepneve { get; set; }
        public int Foglaltturista { get; set; }
        public int Foglalt1oszt { get; set; }
        public int Elsoosztulohelyek { get; set; }
        public int Turistaulohelyek { get; set; }


        public override string ToString()
        {
            return $"{Gepneve} {Foglaltturista} {Foglalt1oszt} {Elsoosztulohelyek} {Turistaulohelyek}";
        }
    }
}
