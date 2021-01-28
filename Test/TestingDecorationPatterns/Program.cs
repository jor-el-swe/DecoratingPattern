using System;

namespace TestingDecorationPatterns
{

    internal static class Program
    {
        static void Main(string[] args)
        {
            var rand = new Random();
            IWeapon newWeapon;
            switch (rand.Next(2)) {
                case 0:
                    newWeapon = new Sword();
                    break;
	
                case 1:
                    newWeapon = new Knife();
                    break;
                
                default:
                    newWeapon = new Sword();
                    break;
            }
            switch (rand.Next(4)) {
                case 0:
                    newWeapon = new UncommonDecorator(newWeapon);
                    break;
	
                case 1:
                    newWeapon = new RareDecorator(newWeapon);
                    break;
                
                case 2:
                    newWeapon = new EpicDecorator(newWeapon);
                    break;
	
                case 3:
                    newWeapon = new LegendaryDecorator(newWeapon);
                    break;
                
                default:
                    newWeapon = new UncommonDecorator(newWeapon);
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
            return "Bane of All Banes";
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
}
    
    