using System;

// Inheritance & Composition
namespace SOLID.LSP
{
    #region StudyCase
    public interface IAnimal
    {
        void Walk();
        void Jump();
    }

    public class Elephant : IAnimal
    {
        public void Jump()
        {
            // ERROR : Liskov Principle Violated
            throw new NotImplementedException("Elephants don't jump");
        }

        public void Walk()
        {
            // code for walk as an elephant.
        }
    }

    public class Tiger : IAnimal
    {
        public void Jump()
        {
            // Code for jump as a Tiger.
        }

        public void Walk()
        {
            // Code for walk as a Tiger.
        }
    }

    #endregion StudyCase

    #region Applied
    public interface IAnimal2
    {
        void Walk();
    }
    public interface ILightWeightAnimal : IAnimal2
    {
        void Jump();
    }
    public class Dog : ILightWeightAnimal
    {
        public void Jump()
        {
            // Jump as a Dog
        }

        public void Walk()
        {
            // Walk as a Dog
        }
    }
    public class Elephant2 : IAnimal2
    {
        public void Walk()
        {
            // Walk as an elephant.
        }
    }
    #endregion Applied

    #region Composition

    public interface IFlightAnimal : IAnimal2, ILightWeightAnimal
    {
        void Fly();
    }

    public class Bird : IFlightAnimal
    {
        public void Fly()
        {
            // a Bird can Fly
        }
        public void Jump()
        {
            // a Bird can Jump
        }
        public void Walk()
        {
            // a Bird can Walk.
        }
    }

    #endregion Composition
}