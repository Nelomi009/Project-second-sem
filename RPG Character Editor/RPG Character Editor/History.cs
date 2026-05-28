using System.Collections.Generic;

namespace RpgCharacterEditor {
  public class History {
    private Stack<CharacterMemento> _history = new Stack<CharacterMemento>();

    public void Save(CharacterMemento memento) {
      _history.Push(memento);
    }

    public CharacterMemento Undo() {
      if (_history.Count == 0) {
        return null;
      }

      return _history.Pop();
    }

    public bool HasHistory() {
      return _history.Count > 0;
    }
  }
}