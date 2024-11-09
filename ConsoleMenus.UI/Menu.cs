
namespace ConsoleMenus.UI;

internal record Menu(
    string Title,
    IEnumerable<string> MenuOptions,
    IEnumerable<ConsoleKey> ValidKeys,
    string Prompt,
    string ValidationError,
    ConsoleKey SelectedKey)

    {
        internal IEnumerable<Menu> SubMenus { get; init; } = [];
        internal ConsoleKey SelectedKey { get; private set; } = SelectedKey;

        internal ConsoleKey GetKey() => SelectedKey = Console.ReadKey().Key;
        internal bool SelectedKeyIsValid() => ValidKeys.Contains(SelectedKey);
    }
