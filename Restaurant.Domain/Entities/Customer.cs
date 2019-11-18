using System;
using System.Collections.Generic;
using System.Text;

namespace Restaurants.Domain
{
    public class Customer
    {
        public int CustomerId { get; set; }
        public string Name { get; set; }
        public string Email { get; set; }
        public string Telephone { get; set; }
        public string Adress { get; set; }
        public string Number { get; set; }
        public string OptionalAdress { get; set; }
        public string AccessKey { get; set; }
        public string ImagePath { get; set; }
        public int IdPermission { get; set; }

        //Propertie Control
        public Boolean Authenticated { get; set; }
        public string Created { get; set; }
        public string Expiration { get; set; }
        public string AccessToken { get; set; }
        public string Message { get; set; }
    }
}
