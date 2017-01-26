using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpPractice
{

    class Entity
    {
        public Entity() { }                         // Default Constructor for Entity
        public Entity(int h, int att) { }

        private int m_health = 50;                  // Private Member Variable of type int name of m_health
        protected int Health                           // Public Varible of type int name of Health
        {
            get { return m_health; }                // Returns member variable of type int m_health
            set { value = m_health; }               // Sets the value of Public variable Health to equal the value of private variable m_health
        }

        private int m_attack = 5;                   // Private Member Variable of type int name of m_attack
        protected int Attack                           // Public Variable of type int name of Attack
        {
            get { return m_attack; }                // Returns member variable of type int m_attack
            set { value = m_attack; }               // Sets the value of Public variable Attack to equal the value of private variable m_attack
        }
        public virtual bool Attack();               //*

        private string m_name = "Bob";              // Private Member Variable of type string name of m_name
        public string Name                          // Public Variable of type string name of Name
        {
            get { return m_name; }                  // Returns member variable of type string m_name
            set { value = m_name; }                 // Sets the value of Public variable Name to equal the value of private variable m_name
        }

        class Zombie
        {

            public Zombie() { }                     // Default Constructor for Zombie
            public Zombie(int a, int b) { }         
            public override Attack();               //*


        }

        class Player
        {

            public Player() { }                    // Default Constructor for Player
            public Player(int a, int b) { }        
            public override Attack();              //*
            public Defend();                       //*
        }
    }




    class Program
    {
        static void Main(string[] args)
        {

        }
    }
}
