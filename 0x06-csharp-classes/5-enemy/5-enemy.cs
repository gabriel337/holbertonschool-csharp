using System;
using System.Collections.Generic;

namespace Enemies
{
    /// <summary>Represents a zombie.</summary>
    public class Zombie
    {
        /// health attribute
         
        private int health;
        /// name attribute
        private string name = "(No name)";
        /// <summary>
        /// getter and setter for name with new value
        /// </summary>
        /// <value></value>
        public string Name
        {
            get => name;
            set => name = value;
        }
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
        /// <summary>
        /// returns new string
        /// </summary>
        /// <returns></returns>
        public override string ToString()
        {
            return $"Zombie name: {name} / Total Health: {health}";
        }
    }
}