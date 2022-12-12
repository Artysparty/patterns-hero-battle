using BattlePatterns.Factory;
using BattlePatterns.Grifon;
using BattlePatterns.Soldier;

IGrifon grifon = FactoryGrifon.CreateGrifon("Белый грифон");
ISoldier soldier = FactorySoldier.CreateSoldier("Черный рыцарь");
soldier.Confirmation();
grifon.Confirmation();

Console.WriteLine($"Здоровье грифона до боя: {grifon.Health}");
Console.WriteLine($"Здоровье черного рыцаря до боя: {soldier.Health}");

soldier.Battle(grifon);
grifon.Battle(soldier);
Console.WriteLine($"Здоровье грифона после боя: {grifon.Health}");
Console.WriteLine($"Здоровье черного рыцаря после боя: {soldier.Health}");