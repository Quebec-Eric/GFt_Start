namespace src.Entities
{
    public class Knight : Hero
    {

        public Knight(string Name, int Level, string Herotype, int Mp_Now, int Mp_Max, int Hp_Now, int Hp_Max)
        {
            this.Name = Name;
            this.Level = Level;
            this.Herotype = Herotype;
            this.Hp_Max = Hp_Max;
            this.Mp_Max = Mp_Max;
            this.Hp_Now = Hp_Now;
            this.Mp_Now = Mp_Now;
        }

        public  string Attack(){
            return this.Name +" Acaba de utilizar sua espada no inimigo ";
        }

        public string Attack(int bonus){

            if(bonus<5){
                return this.Name +" Acaba de utilizar sua espada no inimigo , mas ela ficou presa na bainha tendo um bonus de " + bonus;
            }
            else{
                return this.Name +" Acaba de utilizar sua espada no inimigo que estava imbuida a fogo causando um bonus de "  + bonus;
            }
        }
    }
}