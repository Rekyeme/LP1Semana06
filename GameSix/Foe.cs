namespace GameSix
{
    public class Foe
    {
        // Foe Class instance variables.
        private string name;
        private float health;
        private float shield;

        // Foe Class constructor.
        public Foe(string Get_Name)
        {
            this.name = Get_Name;
            health = 100;
            shield = 0;
        }

        // Obtain the Foe name. 
        public string Get_Name()
        {
            return name;
        }
        public float Get_Health()
        {
            return health;
        }
        public float Set_Shield()
        {
            return shield;
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