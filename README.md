# ConsoleMenus
## About
+ Menu/submenu system for console user interfaces
## Built with
+ NET 8 / C# 12
+ Visual Studio Community 2022 Version 17.11.5
## Features
+ CLI menu user interface
+ Nested submenus
## Improvement opportunities
+ Bug fix: From main menu, go to submenu, then back to main menu, observe that the main menu title is truncated
+ Not good that the submenu actions are defined in the factory class; this may be hiding problems in the model
+ The whole menu factory needs to be reconsidered
