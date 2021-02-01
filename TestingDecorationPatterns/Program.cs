using System;

namespace TestingDecorationPatterns
{

    internal static class Program
    {
        static void Main(string[] args)
        {
            var rand = new Random();
            IWeapon newWeapon;
            switch (rand.Next(6)) {
                case 0:
                    newWeapon = new Sword();
                    break;
	
                case 1:
                    newWeapon = new Knife();
                    break;
                
                case 2:
                    newWeapon = new Dagger();
                    break;
                
                case 3:
                    newWeapon = new Mace();
                    break;
                
                case 4:
                    newWeapon = new Axe();
                    break;
                
                case 5:
                    newWeapon = new Staff();
                    break;
                
                default:
                    newWeapon = new Sword();
                    break;
            }

            switch (rand.Next(15)) {
                case 0:
                case 1:
                case 2:
                case 3:
                case 4:
                    break;
                case 5:
                case 6:
                case 7:
                case 8:
                case 9:
                    newWeapon = new UncommonDecorator(newWeapon);
                    break;
                case 10:
                case 11:
                    newWeapon = new RareDecorator(newWeapon);
                    break;
                case 12:
                case 13:
                    newWeapon = new EpicDecorator(newWeapon);
                    break;
                case 14:
                    newWeapon = new LegendaryDecorator(newWeapon);
                    break;
            }
            
            switch (rand.Next(5)) {
                case 0:
                    break;
                case 1:
                    newWeapon = new PoisonousDecorator(newWeapon);
                    break;
                case 2:
                    newWeapon = new FrozenDecorator(newWeapon);
                    break;
                case 3:
                    newWeapon = new FuriousDecorator(newWeapon);
                    break;
                case 4:
                    newWeapon = new PatientDecorator(newWeapon);
                    break;
            }
            
            Console.WriteLine(GetAllWeaponAttributes(newWeapon));
        }

        private static string GetAllWeaponAttributes(IWeapon weapon)
        {
            return "You have found a new " + weapon.GetWeaponType() + "!"
                   + "\n It's a " + weapon.GetName() + "."
                   + "\n " + weapon.GetDamage() + " damage"
                   + "\n " + weapon.GetAttackSpeed() + " atk speed"
                   + "\n " + weapon.GetStrengthBuff() + " STR"
                   + "\n " + weapon.GetAgilityBuff() + " AGI"
                   + "\n " + weapon.GetIntelligenceBuff() + " INT"
                   + "\n " + weapon.GetGold() + "g";
        }
    }

    public interface IWeapon
    {
        float GetGold();
        float GetStrengthBuff();
        float GetAgilityBuff();
        float GetIntelligenceBuff();
        float GetAttackSpeed();
        float GetDamage();
        string GetName();
        string GetWeaponType();
    }

    //The base of an Item can be a Sword, Knife, Dagger, Mace, Axe, Staff
    public class Sword : IWeapon
    {
        public float GetGold()
        {
            return 10;
        }

        public float GetStrengthBuff()
        {
            return 20;
        }

        public float GetAgilityBuff()
        {
            return 1;
        }

        public float GetIntelligenceBuff()
        {
            return -5;
        }

        public float GetAttackSpeed()
        {
            return 5;
        }

        public float GetDamage()
        {
            return 30;
        }

        public string GetName()
        {
            return "Le Baguette";
        }

        public string GetWeaponType()
        {
            return "Sword";
        }
    }

    public class Knife : IWeapon
    {
        public float GetGold()
        {
            return 5;
        }

        public float GetStrengthBuff()
        {
            return 10;
        }

        public float GetAgilityBuff()
        {
            return 5;
        }

        public float GetIntelligenceBuff()
        {
            return 1;
        }

        public float GetAttackSpeed()
        {
            return 15;
        }

        public float GetDamage()
        {
            return 10;
        }

        public string GetName()
        {
            return "Bread Sticker";
        }

        public string GetWeaponType()
        {
            return "Knife";
        }
    }

    public class Dagger : IWeapon
    {
        public float GetGold()
        {
            return 5;
        }

        public float GetStrengthBuff()
        {
            return 5;
        }

        public float GetAgilityBuff()
        {
            return 10;
        }

        public float GetIntelligenceBuff()
        {
            return 1;
        }

        public float GetAttackSpeed()
        {
            return 20;
        }

        public float GetDamage()
        {
            return 10;
        }

        public string GetName()
        {
            return "Toothpick";
        }

        public string GetWeaponType()
        {
            return "Dagger";
        }
    }

    public class Mace : IWeapon {
        public float GetGold()
        {
            return 10;
        }

        public float GetStrengthBuff()
        {
            return 15;
        }

        public float GetAgilityBuff()
        {
            return 5;
        }

        public float GetIntelligenceBuff()
        {
            return 1;
        }

        public float GetAttackSpeed()
        {
            return 10;
        }

        public float GetDamage()
        {
            return 15;
        }

        public string GetName()
        {
            return "Lollipop";
        }
        public string GetWeaponType()
        {
            return "Mace";
        }
    }

    public class Axe : IWeapon
    {
        public float GetGold()
        {
            return 10;
        }

        public float GetStrengthBuff()
        {
            return 15;
        }

        public float GetAgilityBuff()
        {
            return 10;
        }

        public float GetIntelligenceBuff()
        {
            return 1;
        }

        public float GetAttackSpeed()
        {
            return 5;
        }

        public float GetDamage()
        {
            return 15;
        }

        public string GetName()
        {
            return "T-Bone";
        }

        public string GetWeaponType()
        {
            return "Axe";
        }
    }

    public class Staff : IWeapon
    {
        public float GetGold()
        {
            return 10;
        }

        public float GetStrengthBuff()
        {
            return 1;
        }

        public float GetAgilityBuff()
        {
            return 1;
        }

        public float GetIntelligenceBuff()
        {
            return 15;
        }

        public float GetAttackSpeed()
        {
            return 5;
        }

        public float GetDamage()
        {
            return 15;
        }

        public string GetName()
        {
            return "Spaghetti";
        }

        public string GetWeaponType()
        {
            return "Staff";
        }
    }

    public abstract class RarityDecorator : IWeapon
    {
        protected readonly IWeapon weapon;

        public RarityDecorator(IWeapon weapon)
        {
            this.weapon = weapon;
        }

        public abstract float GetGold();
        public abstract float GetStrengthBuff();

        public abstract float GetAgilityBuff();

        public abstract float GetIntelligenceBuff();

        public abstract float GetAttackSpeed();

        public abstract float GetDamage();

        public abstract string GetName();

        public abstract string GetWeaponType();
    }

    public class UncommonDecorator : RarityDecorator
    {
        private const float Increase = 1.1f;

        //Uncommon: boosts Damage, Attack Speed and stats and gold value
        //by 10%
        public UncommonDecorator(IWeapon weapon) : base(weapon)
        {
        }

        public override float GetGold()
        {
            return this.weapon.GetGold() * Increase;
        }

        public override float GetStrengthBuff()
        {
            return this.weapon.GetStrengthBuff() * Increase;
        }

        public override float GetAgilityBuff()
        {
            return this.weapon.GetAgilityBuff() * Increase;
        }

        public override float GetIntelligenceBuff()
        {
            return this.weapon.GetIntelligenceBuff() * Increase;
        }

        public override float GetAttackSpeed()
        {
            return this.weapon.GetAttackSpeed() * Increase;
        }

        public override float GetDamage()
        {
            return this.weapon.GetDamage() * Increase;
        }

        public override string GetName()
        {
            return "Uncommon " + this.weapon.GetName();
        }

        public override string GetWeaponType()
        {
            return this.weapon.GetWeaponType();
        }
    }

    public class RareDecorator : RarityDecorator
    {
        private const float Increase = 1.3f;

        //Uncommon: boosts Damage, Attack Speed and stats and gold value
        //by 10%
        public RareDecorator(IWeapon weapon) : base(weapon)
        {
        }

        public override float GetGold()
        {
            return this.weapon.GetGold() * Increase;
        }

        public override float GetStrengthBuff()
        {
            return this.weapon.GetStrengthBuff() * Increase;
        }

        public override float GetAgilityBuff()
        {
            return this.weapon.GetAgilityBuff() * Increase;
        }

        public override float GetIntelligenceBuff()
        {
            return this.weapon.GetIntelligenceBuff() * Increase;
        }

        public override float GetAttackSpeed()
        {
            return this.weapon.GetAttackSpeed() * Increase;
        }

        public override float GetDamage()
        {
            return this.weapon.GetDamage() * Increase;
        }

        public override string GetName()
        {
            return "Rare " + this.weapon.GetName();
        }
        public override string GetWeaponType()
        {
            return this.weapon.GetWeaponType();
        }
    }

    public class EpicDecorator : RarityDecorator
    {
        private const float Increase = 1.6f;

        //Uncommon: boosts Damage, Attack Speed and stats and gold value
        //by 10%
        public EpicDecorator(IWeapon weapon) : base(weapon)
        {
        }

        public override float GetGold()
        {
            return this.weapon.GetGold() * Increase;
        }

        public override float GetStrengthBuff()
        {
            return this.weapon.GetStrengthBuff() * Increase;
        }

        public override float GetAgilityBuff()
        {
            return this.weapon.GetAgilityBuff() * Increase;
        }

        public override float GetIntelligenceBuff()
        {
            return this.weapon.GetIntelligenceBuff() * Increase;
        }

        public override float GetAttackSpeed()
        {
            return this.weapon.GetAttackSpeed() * Increase;
        }

        public override float GetDamage()
        {
            return this.weapon.GetDamage() * Increase;
        }

        public override string GetName()
        {
            return "Epic " + this.weapon.GetName();
        }
        public override string GetWeaponType()
        {
            return this.weapon.GetWeaponType();
        }
    }

    public class LegendaryDecorator : RarityDecorator
    {
        private const float Increase = 2f;

        //Uncommon: boosts Damage, Attack Speed and stats and gold value
        //by 10%
        public LegendaryDecorator(IWeapon weapon) : base(weapon)
        {
        }

        public override float GetGold()
        {
            return this.weapon.GetGold() * Increase;
        }

        public override float GetStrengthBuff()
        {
            return this.weapon.GetStrengthBuff() * Increase;
        }

        public override float GetAgilityBuff()
        {
            return this.weapon.GetAgilityBuff() * Increase;
        }

        public override float GetIntelligenceBuff()
        {
            return this.weapon.GetIntelligenceBuff() * Increase;
        }

        public override float GetAttackSpeed()
        {
            return this.weapon.GetAttackSpeed() * Increase;
        }

        public override float GetDamage()
        {
            return this.weapon.GetDamage() * Increase;
        }

        public override string GetName()
        {
            return "Legendary " + this.weapon.GetName();
        }
        public override string GetWeaponType()
        {
            return this.weapon.GetWeaponType();
        }
    }
    
    public abstract class ModDecorator : IWeapon
    {
        protected readonly IWeapon weapon;

        public ModDecorator(IWeapon weapon)
        {
            this.weapon = weapon;
        }

        public abstract float GetGold();
        public abstract float GetStrengthBuff();

        public abstract float GetAgilityBuff();

        public abstract float GetIntelligenceBuff();

        public abstract float GetAttackSpeed();

        public abstract float GetDamage();

        public abstract string GetName();

        public abstract string GetWeaponType();
    }
    
    public class PoisonousDecorator : ModDecorator
    {
        //Poisonous: Increases 10% Chance to poison the enemy + 15g
        public PoisonousDecorator(IWeapon weapon) : base(weapon)
        {
        }

        public override float GetGold()
        {
            return this.weapon.GetGold() + 15;
        }

        public override float GetStrengthBuff()
        {
            return this.weapon.GetStrengthBuff();
        }

        public override float GetAgilityBuff()
        {
            return this.weapon.GetAgilityBuff();
        }

        public override float GetIntelligenceBuff()
        {
            return this.weapon.GetIntelligenceBuff();
        }

        public override float GetAttackSpeed()
        {
            return this.weapon.GetAttackSpeed();
        }
        
        public override float GetDamage()
        {
            return this.weapon.GetDamage();
        }

        public override string GetName()
        {
            return "Poisonous " + this.weapon.GetName();
        }

        public override string GetWeaponType()
        {
            return this.weapon.GetWeaponType();
        }
    }
    
    public class FrozenDecorator : ModDecorator
    {
        //Frozen: Increases 10% chance to freeze the enemy + 20g
        public FrozenDecorator(IWeapon weapon) : base(weapon)
        {
        }

        public override float GetGold()
        {
            return this.weapon.GetGold() + 20;
        }

        public override float GetStrengthBuff()
        {
            return this.weapon.GetStrengthBuff();
        }

        public override float GetAgilityBuff()
        {
            return this.weapon.GetAgilityBuff();
        }

        public override float GetIntelligenceBuff()
        {
            return this.weapon.GetIntelligenceBuff();
        }

        public override float GetAttackSpeed()
        {
            return this.weapon.GetAttackSpeed();
        }
        
        public override float GetDamage()
        {
            return this.weapon.GetDamage();
        }

        public override string GetName()
        {
            return "Frozen " + this.weapon.GetName();
        }

        public override string GetWeaponType()
        {
            return this.weapon.GetWeaponType();
        }
    }
    
    public class FuriousDecorator : ModDecorator
    {
        //Furious: Increases the Attack Damage and Speed by 5% + 10g
        public FuriousDecorator(IWeapon weapon) : base(weapon)
        {
        }

        public override float GetGold()
        {
            return this.weapon.GetGold() + 10;
        }

        public override float GetStrengthBuff()
        {
            return this.weapon.GetStrengthBuff();
        }

        public override float GetAgilityBuff()
        {
            return this.weapon.GetAgilityBuff();
        }

        public override float GetIntelligenceBuff()
        {
            return this.weapon.GetIntelligenceBuff();
        }

        public override float GetAttackSpeed()
        {
            return this.weapon.GetAttackSpeed() * 0.5f;
        }
        
        public override float GetDamage()
        {
            return this.weapon.GetDamage() * 0.5f;
        }

        public override string GetName()
        {
            return "Furious " + this.weapon.GetName();
        }

        public override string GetWeaponType()
        {
            return this.weapon.GetWeaponType();
        }
    }
    
    public class PatientDecorator : ModDecorator
    {
        //Patient: Increases Attack Damage by 15%, reduces Attack Speed by 2% +20g
        public PatientDecorator(IWeapon weapon) : base(weapon)
        {
        }

        public override float GetGold()
        {
            return this.weapon.GetGold() + 20;
        }

        public override float GetStrengthBuff()
        {
            return this.weapon.GetStrengthBuff();
        }

        public override float GetAgilityBuff()
        {
            return this.weapon.GetAgilityBuff();
        }

        public override float GetIntelligenceBuff()
        {
            return this.weapon.GetIntelligenceBuff();
        }

        public override float GetAttackSpeed()
        {
            return this.weapon.GetAttackSpeed() / 0.5f;
        }
        
        public override float GetDamage()
        {
            return this.weapon.GetDamage() * 1.5f;
        }

        public override string GetName()
        {
            return "Patient " + this.weapon.GetName();
        }

        public override string GetWeaponType()
        {
            return this.weapon.GetWeaponType();
        }
    }
}