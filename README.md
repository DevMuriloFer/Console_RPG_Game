**[WIP] Work in progress**

Planned Refactoring & Technical Debt
This project was developed during an intensive 5-hour coding session. Due to the limited timeframe, my primary focus was on delivering a fully functional MVP (Minimum Viable Product). The following technical concepts are already mapped out for the next refactoring stage to improve code maturity and maintainability:

DRY (Don't Repeat Yourself) Principle:

Implementing a centralized combat handler to eliminate redundant while loops and switch structures currently repeated throughout the main execution.

Abstraction & Inheritance (OOP):

Creating a base Enemy class to consolidate shared attributes between GenericEnemy and BossEnemy, reducing code duplication and streamlining the addition of new adversaries.

Advanced Encapsulation:

Migrating public fields to Properties with private set to ensure the internal state of classes (such as LifePoints and BaseAttack) is only modified through authorized domain methods.

Exception Handling & Defensive Programming:

Replacing int.Parse() with int.TryParse() or custom input utility methods to prevent application crashes caused by invalid user input.

Separation of Concerns (SoC):

Moving the narrative layer and long string constants into a dedicated StoryService or Narrative class, decoupling the game logic from the storytelling elements.

Console UX Optimization:

Replacing manual repetitive Console.WriteLine outputs with controlled loops and Thread.Sleep to create a more organic and professional narrative pace.

**Note on Current Gameplay: Currently, the gameplay is primarily luck-based, where the player's only action is a basic attack. I am fully aware that the current state lacks strategic depth, as it was designed to test class structures and basic C# loops.**

Future updates will focus on moving beyond this "pure luck" phase by implementing:

Expanded Combat Mechanics: Adding actual gameplay choices, such as varied skills and strategic attacks, so the player has more agency than just pressing "1" to attack.

Inventory System: A system to manage items, healing, and equipment.

Map & Navigation: A world map for movement and exploration.

Random Encounters: Dynamic enemy spawning during exploration.

**Project Intent: This is strictly a learning project designed to develop and demonstrate my programming skills as a first-semester university student. It does not intend to be a "commercial game," but rather a practical playground for applying C# concepts, Object-Oriented Programming (OOP), and version control.**
