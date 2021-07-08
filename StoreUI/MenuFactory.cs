using System.IO;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using StoreBL;
using StoreDL;
using StoreDL.Entities;

namespace StoreUI
{
    public class MenuFactory{
        public IMenu GetMenu(MenuType p_menu){

            var configuration = new ConfigurationBuilder()
                .SetBasePath(Directory.GetCurrentDirectory())
                .AddJsonFile("appsetting.json")
                .Build();

            string connectionString = configuration.GetConnectionString("SilverDatabase");

            DbContextOptions<DemoDbContext> options = new DbContextOptionsBuilder<DemoDbContext>()
                .UseSqlServer(connectionString)
                .Options;

            switch (p_menu)
            {
                case MenuType.MainMenu:
                    return new MainMenu();
                case MenuType.CustomerMenu:
                    return new CustomerMenu();
                case MenuType.CustomerAddMenu:
                    return new CustomerAddMenu(new CustomerBL(new CustomerRepo(new DemoDbContext(options))));
                case MenuType.CustomerShowMenu:
                    return new CustomerShowMenu(new CustomerBL(new CustomerRepo(new DemoDbContext(options))));
                case MenuType.CustomerSearchMenu:
                    return new CustomerSearchMenu(new CustomerBL(new CustomerRepo(new DemoDbContext(options))));
                case MenuType.StoreFrontMenu:
                    return new StoreFrontMenu();
                case MenuType.StoreFrontInventoryMenu:
                    return new StoreFrontInventoryMenu(new StoreFrontBL(new StoreFrontRepo(new DemoDbContext(options))));
                case MenuType.OrderMenu:
                    return new OrderMenu();
                default:
                    return null;
            }
        }
    }
}