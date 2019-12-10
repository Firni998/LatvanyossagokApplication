namespace LatvanyossagokApplication
{
    internal class Varosok
    {
        private int id;
        private string nev;
        private int lakossag;


        public Varosok(int id, string nev,int lakossag)
        {
            this.id = id;
            this.nev = nev;
            this.lakossag = lakossag;

        }

        public int Id { get => id; set => id = value; }
        public string Nev { get => nev; set => nev = value; }
        public int Lakossag { get => lakossag; set => lakossag = value; }

        public override string ToString()
        {
            return nev;
        }
    }
}