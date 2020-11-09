using HelloCore.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Threading.Tasks;

namespace HelloCore.Services
{
    public interface IRestaurantData
    {
        IEnumerable<Restaurant> GetAll();
        //geeft een lijst terug van alle restaurant
        Restaurant Get(int id);
        void Add(Restaurant restaurant);
        void Delete(Restaurant restaurant);
        void Update(Restaurant restaurant);
    }

    public class InMemoryRestaurantData: IRestaurantData
    {
        private static List<Restaurant> _restaurants;
        static InMemoryRestaurantData()
        {
            _restaurants = new List<Restaurant>
            {
                new Restaurant {Id = 1, Name = "My Resto"},
                new Restaurant {Id = 2, Name = "Funny Pizza"},
                new Restaurant {Id = 3, Name = "Cray Burgers"}

            };
        }

        public Restaurant Get(int id)
        {
            return _restaurants.FirstOrDefault(x => x.Id == id);
        }

        public IEnumerable<Restaurant> GetAll()
        {
            return _restaurants;
        }

        public void Add(Restaurant restaurant)
        {
            restaurant.Id = _restaurants.Max(x => x.Id) + 1;
            _restaurants.Add(restaurant);
        }

        public void Delete(Restaurant restaurant)
        {
            _restaurants.Remove(restaurant);
        }

        public void Update(Restaurant restaurant)
        {
            var oldResto = Get(restaurant.Id);
            oldResto.Name = restaurant.Name;
            oldResto.CuisineType = restaurant.CuisineType;
        }
    }

}
