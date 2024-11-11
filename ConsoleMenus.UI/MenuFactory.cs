
namespace ConsoleMenus.UI;

/// <summary>
/// As configured, provides method that returns a Main Menu with three (3) submenus
/// Can be altered or extended to create other menu/submenu patterns
/// </summary>
internal static class MenuFactory
{
    internal static Menu GetMainMenu()
    {
        string title = "*** MAIN MENU ***";
        string prompt = "Select a menu option:";
        string error = "Error: Invalid menu option selection.";

        Action mainMenuOption1Action = () =>
        {
            Menu subMenu = GetSubMenu(1);
            subMenu.Run();
        };
        Action mainMenuOption2Action = () =>
        {
            Menu subMenu = GetSubMenu(2);
            subMenu.Run();
        };
        Action mainMenuOption3Action = () =>
        {
            Menu subMenu = GetSubMenu(3);
            subMenu.Run();
        };

        MenuOption mainMenuOption1 = new("1 = Submenu 1", 1, [ConsoleKey.D1, ConsoleKey.NumPad1], mainMenuOption1Action);
        MenuOption mainMenuOption2 = new("2 = Submenu 2", 2, [ConsoleKey.D2, ConsoleKey.NumPad2], mainMenuOption2Action);
        MenuOption mainMenuOption3 = new("3 = Submenu 3", 3, [ConsoleKey.D3, ConsoleKey.NumPad3], mainMenuOption3Action);
        MenuOption[] mainMenuOptions = [mainMenuOption1, mainMenuOption2, mainMenuOption3];

        return new Menu(title, mainMenuOptions, prompt, error, ConsoleKey.Escape, "{esc} = Exit program", ConsoleKey.None);
    }

    internal static Menu GetSubMenu(int menuNumber)
    {
        string title = $"** SubMenu {menuNumber} **";
        string prompt = "Select a menu option:";
        string error = "Error: Invalid menu option selection.";

        Action subMenuOption1Action = () => Console.WriteLine('\n' + $"submenu {menuNumber} option 1");
        Action subMenuOption2Action = () => Console.WriteLine('\n' + $"submenu {menuNumber} option 2");
        Action subMenuOption3Action = () => Console.WriteLine('\n' + $"submenu {menuNumber} option 3");

        MenuOption subMenuOption1 = new($"1 = Submenu {menuNumber} option 1", 1, [ConsoleKey.D1, ConsoleKey.NumPad1], subMenuOption1Action);
        MenuOption subMenuOption2 = new($"2 = Submenu {menuNumber} option 2", 2, [ConsoleKey.D2, ConsoleKey.NumPad2], subMenuOption2Action);
        MenuOption subMenuOption3 = new($"3 = Submenu {menuNumber} option 3", 3, [ConsoleKey.D3, ConsoleKey.NumPad3], subMenuOption3Action);
        MenuOption[] subMenuOptions = [subMenuOption1, subMenuOption2, subMenuOption3];

        return new Menu(title, subMenuOptions, prompt, error, ConsoleKey.Escape, "{esc} = Return to main menu", ConsoleKey.None);
    }
}
