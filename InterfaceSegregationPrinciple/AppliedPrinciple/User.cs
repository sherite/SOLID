using System;
using System.Collections.Generic;

namespace AppliedPrinciple
{
    
        public interface IBasicActions<T>
        {
            T Get(int id);
            List<T> GetList();
            void Add(T entity);
        }

        public interface IEditableActions<T>
        {
            void Update(T entity);
            void Delete(int id);
        }

        public interface ICRUD<T> : IBasicActions<T>, IEditableActions<T> { }

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

    public class Sale
    {
        public decimal Amount { get; set; }
        public DateTime Date { get; set; }
    }

    public class SaleService : IBasicActions<Sale>
    {
        public void Add(Sale entity)
        {
            Console.WriteLine("Creation of Sale.");
        }      

        public Sale Get(int id)
        {
            Console.WriteLine("Return Sale by id");
            return new Sale();
        }

        public List<Sale> GetList()
        {
            Console.WriteLine("Get a list of Sales.");
            return new List<Sale>();
        }
    }
}
