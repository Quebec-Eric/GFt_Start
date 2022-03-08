namespace SERIES
{
    public class Serie : EntidadeBase
    {
        private Genero Genero { get; set;}

        private string ?Titulo{ get; set;}

        private string ?Descrition{ get; set;}

        private int  Ano{ get; set;}

        private bool Registro{ get; set;}



        public Serie(int id, Genero genero, string titulo, string descricao, int ano)
		{
			this.Id = id;
			this.Genero = genero;
			this.Titulo = titulo;
			this.Descrition = descricao;
			this.Ano = ano;
            this.Registro=true;
           
		}

        public override string ToString()
        {
            return " Gemero: "+ this.Genero +"\n Titulo: "+this.Titulo
            +"\n Descricao: "+ this.Descrition +"\n Ano de estreia: "+ this.Ano;
        }


        public void ExRegistro(){
            this.Registro=false;
        }

        public bool retornaExcluido(){
           return  this.Registro;
        }

        public int retornaId(){
            return this.Id;
        }

        public string retornaTitulo(){
            return this.Titulo;
        }






    }
}