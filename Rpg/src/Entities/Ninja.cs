namespace src.Entities
{
    public class Ninja:Hero
    {
        
        public Ninja (string Name, int Level, string Herotype, int Mp_Now, int Mp_Max, int Hp_Now, int Hp_Max)
        {
            this.Name = Name;
            this.Level = Level;
            this.Herotype = Herotype;
            this.Hp_Max = Hp_Max;
            this.Mp_Max = Mp_Max;
            this.Hp_Now = Hp_Now;
            this.Mp_Now = Mp_Now;
        }

         public override string Attack(){
            return this.Name +" Acaba  de pegar seu inimigo de surpresa e consegue machuca-lo";
        }

        public string Attack(int bonus){

            if(bonus<5){
                return this.Name +" Acaba de utilizar sua fumaca mas ele sofreu de alergia e teve uma perda de dado de " + bonus;
            }
            else{
                return this.Name +" Acaba de se esconder no teto e com isso pula em cima do alvo causando um dado bonus de " + bonus;
            }
        }
    }
}