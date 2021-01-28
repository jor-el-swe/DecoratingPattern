using System;

namespace DecoratingPattern{
    internal static class Program{
        static void Main(string[] args){
            //Console.WriteLine("Hello World!");
            //Program2.Main2();
            
            IWeapon newWeapon = new Knife();
            //change printout to first type (knife/sword) of weapon then name....
            Console.WriteLine("You have found a new " + newWeapon.GetName());
            Console.WriteLine("It is worth: " + newWeapon.GetGold());
            
            Console.WriteLine("A wizard appears and grants your new " + newWeapon.GetName() + " the Uncommon rarity.\n");
            newWeapon = new UncommonDecorator(newWeapon);
            
            Console.WriteLine("\nYour weapon is now a: " + newWeapon.GetName());
            Console.WriteLine("It is worth: " + newWeapon.GetGold());


            //Console.WriteLine(GetAllWeaponAttributes(newWeapon));
        }

        /*private static string GetAllWeaponAttributes(IWeapon weapon){
            
            return   float GetGold();
           float GetStrengthBuff();
           float GetAgilityBuff();
           float GetIntelligenceBuff();
           float GetAttackSpeed();
           float GetDamage();
           string GetName();
        }*/
    }
    /*We want to Develop a Random Weapon Generator
    The item has a Name
    The Item has a certain amount of Damage
    And Attack Speed
    And Intelligence-Buff (number)
    And Stngth-Buff (nurember)
    And Agility-Buff (number)
    And Gold-Value*/
    
    public interface IWeapon {
        float GetGold();
        float GetStrengthBuff();
        float GetAgilityBuff();
        float GetIntelligenceBuff();
        float GetAttackSpeed();
        float GetDamage();
        string GetName();
    }
    //The base of an Item can be a Sword, Knife, Dagger, Mace, Axe, Staff
    public class Sword : IWeapon{
        public float GetGold(){
            return 10;
        }

        public float GetStrengthBuff(){
            return 20;
        }

        public float GetAgilityBuff(){
            return 1;
        }

        public float GetIntelligenceBuff(){
            return -5;
        }

        public float GetAttackSpeed(){
            return 5;
        }

        public float GetDamage(){
            return 30;
        }

        public string GetName(){
            return "Sword";
        }
    }
    
    public class Knife : IWeapon{
        public float GetGold(){
            return 5;
        }

        public float GetStrengthBuff(){
            return 10;
        }

        public float GetAgilityBuff(){
            return 5;
        }

        public float GetIntelligenceBuff(){
            return 1;
        }

        public float GetAttackSpeed(){
            return 15;
        }

        public float GetDamage(){
            return 10;
        }

        public string GetName(){
            return "Knife";
        }
    }
    
    public abstract class RarityDecorator : IWeapon {
        protected readonly IWeapon weapon;

        public RarityDecorator(IWeapon weapon) {
            this.weapon = weapon;
        }

        public abstract float GetGold();
        public abstract float GetStrengthBuff();

        public abstract float GetAgilityBuff();

        public abstract float GetIntelligenceBuff();

        public abstract float GetAttackSpeed();

        public abstract float GetDamage();

        public abstract string GetName();
    }

    public class UncommonDecorator : RarityDecorator{
        private const float Increase = 1.1f;
        
        //Uncommon: boosts Damage, Attack Speed and stats and gold value
        //by 10%
        public UncommonDecorator(IWeapon weapon) : base(weapon){
        }

        public override float GetGold(){
            return this.weapon.GetGold() * Increase;
        }

        public override float GetStrengthBuff(){
            return this.weapon.GetStrengthBuff() * Increase;
        }

        public override float GetAgilityBuff(){
            return this.weapon.GetAgilityBuff() * Increase;
        }

        public override float GetIntelligenceBuff(){
            return this.weapon.GetIntelligenceBuff() * Increase;
        }

        public override float GetAttackSpeed(){
            return this.weapon.GetAttackSpeed() * Increase;
        }

        public override float GetDamage(){
            return this.weapon.GetDamage() * Increase;
        }

        public override string GetName(){
            return "Uncommon " + this.weapon.GetName();
        }
    }
    
    public class RareDecorator : RarityDecorator{
        private const float Increase = 1.3f;
        
        //Uncommon: boosts Damage, Attack Speed and stats and gold value
        //by 10%
        public RareDecorator(IWeapon weapon) : base(weapon){
        }

        public override float GetGold(){
            return this.weapon.GetGold() * Increase;
        }

        public override float GetStrengthBuff(){
            return this.weapon.GetStrengthBuff() * Increase;
        }

        public override float GetAgilityBuff(){
            return this.weapon.GetAgilityBuff() * Increase;
        }

        public override float GetIntelligenceBuff(){
            return this.weapon.GetIntelligenceBuff() * Increase;
        }

        public override float GetAttackSpeed(){
            return this.weapon.GetAttackSpeed() * Increase;
        }

        public override float GetDamage(){
            return this.weapon.GetDamage() * Increase;
        }

        public override string GetName(){
            return "Uncommon " + this.weapon.GetName();
        }
    }
    
    public class EpicDecorator : RarityDecorator{
        private const float Increase = 1.6f;
        
        //Uncommon: boosts Damage, Attack Speed and stats and gold value
        //by 10%
        public EpicDecorator(IWeapon weapon) : base(weapon){
        }

        public override float GetGold(){
            return this.weapon.GetGold() * Increase;
        }

        public override float GetStrengthBuff(){
            return this.weapon.GetStrengthBuff() * Increase;
        }

        public override float GetAgilityBuff(){
            return this.weapon.GetAgilityBuff() * Increase;
        }

        public override float GetIntelligenceBuff(){
            return this.weapon.GetIntelligenceBuff() * Increase;
        }

        public override float GetAttackSpeed(){
            return this.weapon.GetAttackSpeed() * Increase;
        }

        public override float GetDamage(){
            return this.weapon.GetDamage() * Increase;
        }

        public override string GetName(){
            return "Uncommon " + this.weapon.GetName();
        }
    }
    
    public class LegendaryDecorator : RarityDecorator{
        private const float Increase = 2f;
        
        //Uncommon: boosts Damage, Attack Speed and stats and gold value
        //by 10%
        public LegendaryDecorator(IWeapon weapon) : base(weapon){
        }

        public override float GetGold(){
            return this.weapon.GetGold() * Increase;
        }

        public override float GetStrengthBuff(){
            return this.weapon.GetStrengthBuff() * Increase;
        }

        public override float GetAgilityBuff(){
            return this.weapon.GetAgilityBuff() * Increase;
        }

        public override float GetIntelligenceBuff(){
            return this.weapon.GetIntelligenceBuff() * Increase;
        }

        public override float GetAttackSpeed(){
            return this.weapon.GetAttackSpeed() * Increase;
        }

        public override float GetDamage(){
            return this.weapon.GetDamage() * Increase;
        }

        public override string GetName(){
            return "Uncommon " + this.weapon.GetName();
        }
    }
    
    
       
}