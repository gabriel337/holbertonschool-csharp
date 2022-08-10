using System;
using System.Collections.Generic;

namespace Enemies
{
    /// <summary>Represents a zombie.</summary>
    public class Zombie
    {
        /// <summary>
        /// health attribute
        /// </summary>
        private int health;
        /// <summary>
        /// new instance of Zombie
        /// </summary>
        public Zombie()
        {
            health = 0;
        }
        /// <summary>
        /// brings value to health
        /// </summary>
        /// <param name="value"></param>
        public Zombie(int value)
        {       
                if (value >= 0)
                {
                    this.health = value;
                }
                else if(value < 0)
                {
                    throw new ArgumentException("Health must be greater than or equal to 0");
                }             
        }
        /// <summary>
        /// returns health
        /// </summary>
        /// <returns></returns>
        public int GetHealth()
        {   
            return health;
        }
    }
}