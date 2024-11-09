
namespace ConsoleMenus.UI;

/// <summary>
/// As configured, provides method that returns a Main Menu with three (3) submenus
/// Can be altered or extended to create other menu/submenu patterns
/// </summary>
internal static class MenuFactory
{
    internal static Menu CreateMenus()
    {
        IEnumerable<Menu> result = [];
        // create main menu
        Menu mainMenu = new("Main Menu", ["1 = SubMenu 1", "2 = SubMenu 2", "3 = SubMenu 3", "{esc} = Exit"], [ConsoleKey.D1, ConsoleKey.NumPad1, ConsoleKey.D2, ConsoleKey.NumPad2, ConsoleKey.D3, ConsoleKey.NumPad3, ConsoleKey.Escape], "Select a menu option:", "Error: Invalid menu option selection.", ConsoleKey.None);

        // create three (3) submenus that belong to main menu
        Menu submenu1 = new("SubMenu 1", ["1 = Option 1", "2 = Option 2", "3 = Option 3", "{esc = Main Menu}"], [ConsoleKey.D1, ConsoleKey.NumPad1, ConsoleKey.D2, ConsoleKey.NumPad2, ConsoleKey.D3, ConsoleKey.NumPad3, ConsoleKey.Escape], "Select a menu option:", "Error: Invalid menu option selection.", ConsoleKey.None);
        Menu submenu2 = new("SubMenu 2", ["1 = Option 1", "2 = Option 2", "3 = Option 3", "{esc = Main Menu}"], [ConsoleKey.D1, ConsoleKey.NumPad1, ConsoleKey.D2, ConsoleKey.NumPad2, ConsoleKey.D3, ConsoleKey.NumPad3, ConsoleKey.Escape], "Select a menu option:", "Error: Invalid menu option selection.", ConsoleKey.None);
        Menu submenu3 = new("SubMenu 3", ["1 = Option 1", "2 = Option 2", "3 = Option 3", "{esc = Main Menu}"], [ConsoleKey.D1, ConsoleKey.NumPad1, ConsoleKey.D2, ConsoleKey.NumPad2, ConsoleKey.D3, ConsoleKey.NumPad3, ConsoleKey.Escape], "Select a menu option:", "Error: Invalid menu option selection.", ConsoleKey.None);

        mainMenu.SubMenus.Append(submenu1);
        mainMenu.SubMenus.Append(submenu2);
        mainMenu.SubMenus.Append(submenu3);

        return mainMenu;
    }
}
