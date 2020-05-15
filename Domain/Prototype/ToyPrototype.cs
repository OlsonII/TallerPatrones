using System.Collections.Generic;

namespace Domain.Prototype
{
    public class ToyPrototype
    {
        private readonly Dictionary<string, Toy> _prototypes = new Dictionary<string, Toy>();

        ToyPrototype()
        {
            var bigSoldierRed = new BigSoldier() {Name = "Red Big Soldier", Color = "Red"};
            var bigSoldierBlue = new BigSoldier() {Name = "Blue Big Soldier", Color = "Blue"};
            var lowSoldierRed = new LowSoldier() {Name = "Red Low Soldier", Color = "Red"};
            var lowSoldierBlue = new LowSoldier() {Name = "Blue Low Soldier", Color = "Red"};
            
            _prototypes.Add("BigSoldierBlue", bigSoldierBlue);
            _prototypes.Add("BigSoldierRed", bigSoldierRed);
            _prototypes.Add("LowSoldierRed", lowSoldierRed);
            _prototypes.Add("LowSoldierBlue", lowSoldierBlue);
        }

        public Toy Prototype(string range)
        {
            if (_prototypes.TryGetValue(range, out var soldier))
            {
                return (Toy) soldier.Clone();
            }

            return null;
        }
    }
}