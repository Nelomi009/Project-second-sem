using System;

namespace RpgCharacterEditor {
  internal class Program {
    static void Main(string[] args) {
      Character character = new Character(
          "Arthur",
          "Warrior",
          1,
          100,
          "Sword",
          "Leather Armor",
          100
      );

      History history = new History();

      bool isRunning = true;

      while (isRunning) {
        Console.WriteLine();
        Console.WriteLine("===== RPG CHARACTER EDITOR =====");
        Console.WriteLine("1. Show character");
        Console.WriteLine("2. Change name");
        Console.WriteLine("3. Change class");
        Console.WriteLine("4. Change weapon");
        Console.WriteLine("5. Change armor");
        Console.WriteLine("6. Level up");
        Console.WriteLine("7. Add gold");
        Console.WriteLine("8. Undo last change");
        Console.WriteLine("0. Exit");
        Console.Write("Choose option: ");

        string choice = Console.ReadLine();

        Console.WriteLine();

        switch (choice) {
          case "1":
            character.ShowInfo();
            break;

          case "2":
            history.Save(character.Save());
            Console.Write("Enter new name: ");
            character.ChangeName(Console.ReadLine());
            Console.WriteLine("Name changed.");
            break;

          case "3":
            history.Save(character.Save());
            Console.Write("Enter new class: ");
            character.ChangeClass(Console.ReadLine());
            Console.WriteLine("Class changed.");
            break;

          case "4":
            history.Save(character.Save());
            Console.Write("Enter new weapon: ");
            character.ChangeWeapon(Console.ReadLine());
            Console.WriteLine("Weapon changed.");
            break;

          case "5":
            history.Save(character.Save());
            Console.Write("Enter new armor: ");
            character.ChangeArmor(Console.ReadLine());
            Console.WriteLine("Armor changed.");
            break;

          case "6":
            history.Save(character.Save());
            character.LevelUp();
            Console.WriteLine("Level increased.");
            break;

          case "7":
            history.Save(character.Save());
            Console.Write("Enter gold amount: ");

            int gold;
            if (int.TryParse(Console.ReadLine(), out gold)) {
              character.AddGold(gold);
              Console.WriteLine("Gold added.");
            }
            else {
              Console.WriteLine("Invalid number.");
            }

            break;

          case "8":
            CharacterMemento previousState = history.Undo();

            if (previousState == null) {
              Console.WriteLine("No changes to undo.");
            }
            else {
              character.Restore(previousState);
              Console.WriteLine("Last change was undone.");
            }

            break;

          case "0":
            isRunning = false;
            break;

          default:
            Console.WriteLine("Invalid option.");
            break;
        }
      }
    }
  }
}