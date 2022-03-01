namespace src.Entities
{
    public abstract class Hero
    {
        protected string Name { get; set; }
        protected int Level { get; set; }
        protected string Herotype { get; set; }
        protected int Hp_Max { get; set; }

        protected int Mp_Max { get; set; }

        protected int Hp_Now { get; set; }

        protected int Mp_Now { get; set; }

        public Hero(string Name, int Level, string Herotype, int Hp_Now, int Hp_Max, int Mp_Now, int Mp_Max)
        {
            this.Name = Name;
            this.Level = Level;
            this.Herotype = Herotype;
            this.Hp_Max = Hp_Max;
            this.Mp_Max = Mp_Max;
            this.Hp_Now = Hp_Now;
            this.Mp_Now = Mp_Now;
        }
        public Hero()
        {

        }

        public override string ToString()
        {
            return this.Name + "\n"
             + " LV. " + this.Level + " " + this.Herotype + "\n" +
             " HP " + this.Mp_Now + "/ " + this.Mp_Max + "\n"
             + " MP " + this.Hp_Now + "/ " + this.Hp_Max
             ;
        }

        public  string Attack()
        {
            return this.Name + " Acaba de utilizar sua espada no inimigo ";
        }

       

       

    }
}