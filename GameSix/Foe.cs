namespace GameSix
{
    public class Foe
    {
        // Foe Class instance variables.
        private string name;
        private float health;
        private float shield;

        // Foe Class constructor.
        public Foe(string name)
        {
            this.name = name;
            health = 100;
            shield = 0;
        }

        // Obtain the Foe name.
        public string GetName()
        {
            return name;
        }

        // Damage inflicted to the Foe.
        public void TakeDamage(float damage)
        {
            shield -= damage;
            if (shield < 0)
            {
                float damageStillToInflict = -shield;
                shield = 0;
                health -= damageStillToInflict;
                if (health < 0) health = 0;
            }    
        }
    }
}