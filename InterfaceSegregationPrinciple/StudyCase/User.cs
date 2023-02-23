using System;
using System.Collections.Generic;

namespace StudyCase
{
    public interface ICRUD<T>
    {
        T Get(int id);
        List<T> GetList();
        void Add(T entity);
        void Update(T entity);
        void Delete(int id);
    }
    public class User
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Email { get; set; }
    }

    public class UserService : ICRUD<User>
    {
        public void Add(User entity)
        {
           Console.WriteLine("Creation of user.");
        }

        public void Delete(int id)
        {
            Console.WriteLine("Delete user by id.");
        }

        public User Get(int id)
        {
            Console.WriteLine("Return user by id");
            return new User();
        }

        public List<User> GetList()
        {
            Console.WriteLine("Get a list of users.");
            return new List<User>();
        }

        public void Update(User entity)
        {
            Console.WriteLine("Edit a user.");
        }
    }

    // ---------------------------

    public class Sale
    {
        public decimal Amount { get; set; }
        public DateTime Date { get; set; }
    }

    public class SaleService : ICRUD<Sale>
    {
        public void Add(Sale entity)
        {
            Console.WriteLine("Creation of sale.");
        }

        public Sale Get(int id)
        {
            Console.WriteLine("Get a sale.");
            return new Sale();
        }

        public List<Sale> GetList()
        {
            Console.WriteLine("Get list of sales.");
            return new List<Sale>();    
        }

        // FR #1
        // SALES CAN NOT UPDATE.
        
        // FR #2
        // SALES CAN NOT DELETE.

        public void Update(Sale entity)
        {
           // ### WARNING!!! SOLID I PRINCIPLE BROKEN
            throw new NotImplementedException();
        }

        public void Delete(int id)
        {
            // ### WARNING!!! SOLID I PRINCIPLE BROKEN
            throw new NotImplementedException();
        }       
    }
}