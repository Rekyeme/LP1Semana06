namespace GameSix
{
    public class Foe
    {
        //Class instance variables.
        private string name;
        private float health;
        private float shield;

        //Class constructor
        public Foe(string name)
        {
            this.name = name;
            health = 100;
            shield = 0;
        }
    }
}