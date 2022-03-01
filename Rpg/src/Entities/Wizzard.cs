namespace src.Entities
{
    public class Wizzard : Hero
    {
        public Wizzard(string Name, int Level, string Herotype, int Mp_Now, int Mp_Max, int Hp_Now, int Hp_Max)
        {
            this.Name = Name;
            this.Level = Level;
            this.Herotype = Herotype;
            this.Hp_Max = Hp_Max;
            this.Mp_Max = Mp_Max;
            this.Hp_Now = Hp_Now;
            this.Mp_Now = Mp_Now;
        }


        public string Attack()
        {
            if (Herotype.Equals("White Wizard"))
            {

                return this.Name + " acabou de usar seus milagras para ferir o adiversario";
            }
            else
            {
                return this.Name + " acabou de usar sua magia das trevas para ferir o adiversario";
            }
        }

        public string Attack(int bonus)
        {

            if (bonus < 5)
            {
                if (Herotype.Equals("White Wizard"))
                {

                    return this.Name + " Acaba de utilizar seu milagre mas o sol foi tampado pelas nuvens e perdem um bonus de  " + bonus;
                }
                else
                {
                    return this.Name + " Acaba de utilizar sua magia das trevas mas nao fez o sacrificio com isso perdem um bonus de  " + bonus;
                }

            }
            else
            {
                  if (Herotype.Equals("White Wizard"))
                {

                    return this.Name + " Acaba de utilizar seu milagre e como estava exatamente 12:00 sua Lanca de raios atingiu o inimigo com um bonus de  " + bonus;
                }
                else
                {
                    return this.Name + " Acaba de utilizar sua magia das trevas , e como estava em um cimiterio seu poder foi aumentado num bonus de " + bonus;
                }
            }
        }
    }
}