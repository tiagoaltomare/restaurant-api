using Restaurants.Domain;
using System;
using System.Collections.Generic;

namespace Restaurants.Data.Services
{
    public class MenuService : ServiceBase<Menu>, IMenuService
    {
        private readonly IMenuRepository _serviceRepository;

        public MenuService(IMenuRepository serviceRepository) : base(serviceRepository)
        {
            _serviceRepository = serviceRepository;
        }

        public Menu PreencherTotaisPorFormaPagamento(int idCaixa)
        {
            var menu = _serviceRepository.GetById(idCaixa);
            return menu;
        }

        public List<Menu> GetMenuByRestaurant(int idRestaurant)
        {
            return _serviceRepository.GetMenuByRestaurant(idRestaurant);
        }
    }
}
