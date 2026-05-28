namespace RpgCharacterEditor {
  public class CharacterMemento {
    public string Name { get; }
    public string CharacterClass { get; }
    public int Level { get; }
    public int Health { get; }
    public string Weapon { get; }
    public string Armor { get; }
    public int Gold { get; }

    public CharacterMemento(
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
  }
}