using StoreBL;
using StoreDL;

namespace StoreUI
{
    public class MenuFactory{
        public IMenu GetMenu(MenuType p_menu){
            switch (p_menu)
            {
                case MenuType.MainMenu:
                    return new MainMenu();
                case MenuType.CustomerMenu:
                    return new CustomerMenu();
                case MenuType.CustomerAddMenu:
                    return new CustomerAddMenu(new CustomerBL(new CustomerRepo()));
                case MenuType.CustomerShowMenu:
                    return new CustomerShowMenu(new CustomerBL(new CustomerRepo()));
                case MenuType.CustomerSearchMenu:
                    return new CustomerSearchMenu(new CustomerBL(new CustomerRepo()));
                default:
                    return null;
            }
        }
    }
}