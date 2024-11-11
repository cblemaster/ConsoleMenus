
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

        Action mainMenuOption1Action = () => Console.WriteLine('\n' + "Show submenu 1");
        Action mainMenuOption2Action = () => Console.WriteLine('\n' + "Show submenu 2");
        Action mainMenuOption3Action = () => Console.WriteLine('\n' + "Show submenu 3");
        Action submenuOption1Action = () => Console.WriteLine('\n' + "submenu option 1");
        Action submenuOption2Action = () => Console.WriteLine('\n' + "submenu option 2");
        Action submenuOption3Action = () => Console.WriteLine('\n' + "submenu option 3");

        MenuOption mainMenuOption1 = new("1 = Submenu 1", 1, [ConsoleKey.D1, ConsoleKey.NumPad1], mainMenuOption1Action);
        MenuOption mainMenuOption2 = new("2 = Submenu 2", 2, [ConsoleKey.D2, ConsoleKey.NumPad2], mainMenuOption2Action);
        MenuOption mainMenuOption3 = new("3 = Submenu 3", 3, [ConsoleKey.D3, ConsoleKey.NumPad3], mainMenuOption3Action);
        MenuOption[] mainMenuOptions = [mainMenuOption1, mainMenuOption2, mainMenuOption3];

        return new Menu(title, mainMenuOptions, prompt, error, ConsoleKey.Escape, "{esc} = Exit program", ConsoleKey.None);
    }
}
