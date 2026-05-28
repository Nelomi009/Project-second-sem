using System;

namespace RpgCharacterEditor {
  public class Character {
    public string Name { get; private set; }
    public string CharacterClass { get; private set; }
    public int Level { get; private set; }
    public int Health { get; private set; }
    public string Weapon { get; private set; }
    public string Armor { get; private set; }
    public int Gold { get; private set; }

    public Character(
        string name,
        string characterClass,
        int level,
        int health,
        string weapon,
        string armor,
        int gold) {
      Name = name;
      CharacterClass = characterClass;
      Level = level;
      Health = health;
      Weapon = weapon;
      Armor = armor;
      Gold = gold;
    }

    // Изменение имени
    public void ChangeName(string newName) {
      Name = newName;
    }

    // Изменение класса
    public void ChangeClass(string newClass) {
      CharacterClass = newClass;
    }

    // Изменение оружия
    public void ChangeWeapon(string newWeapon) {
      Weapon = newWeapon;
    }

    // Изменение брони
    public void ChangeArmor(string newArmor) {
      Armor = newArmor;
    }

    // Повышение уровня
    public void LevelUp() {
      Level++;
      Health += 10;
    }

    // Добавление золота
    public void AddGold(int amount) {
      Gold += amount;
    }

    // Сохранение состояния
    public CharacterMemento Save() {
      return new CharacterMemento(
          Name,
          CharacterClass,
          Level,
          Health,
          Weapon,
          Armor,
          Gold
      );
    }

    // Восстановление состояния
    public void Restore(CharacterMemento memento) {
      Name = memento.Name;
      CharacterClass = memento.CharacterClass;
      Level = memento.Level;
      Health = memento.Health;
      Weapon = memento.Weapon;
      Armor = memento.Armor;
      Gold = memento.Gold;
    }

    // Вывод информации
    public void ShowInfo() {
      Console.WriteLine("===== CHARACTER =====");
      Console.WriteLine("Name: " + Name);
      Console.WriteLine("Class: " + CharacterClass);
      Console.WriteLine("Level: " + Level);
      Console.WriteLine("Health: " + Health);
      Console.WriteLine("Weapon: " + Weapon);
      Console.WriteLine("Armor: " + Armor);
      Console.WriteLine("Gold: " + Gold);
      Console.WriteLine("=====================");
    }
  }
}