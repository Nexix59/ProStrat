using System.Collections.Generic;

public class Battlefield
{
    public List<Unit> attackers;
    public List<Unit> defenders;

    public void ResolveCombat()
    {
        // Simple turn-based combat resolution
        foreach (var attacker in attackers)
        {
            foreach (var defender in defenders)
            {
                attacker.Attack(defender);
            }
        }

        // Remove any units that were destroyed during combat
        attackers.RemoveAll(unit => unit.health <= 0);
        defenders.RemoveAll(unit => unit.health <= 0);
    }
}