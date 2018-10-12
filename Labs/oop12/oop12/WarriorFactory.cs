using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;

namespace oop12.AbstractFactory
{
    //абстрактный класс - оружие
    public abstract class Weapon
    {
        public abstract void Hit();
    }
    // абстрактный класс движение
    public abstract class Movement
    {
        public abstract void Move();
    }

    
     
    // класс лук
    public class Bow : Weapon
    {
        public override void Hit()
        {
            Console.WriteLine("Стреляем из лука");
        }
    }
    // класс меч
    public class Sword : Weapon
    {
        public override void Hit()
        {
            Console.WriteLine("Бьем мечом");
        }
    }
    // движение полета
    public class FlyMovement : Movement
    {
        public override void Move()
        {
            Console.WriteLine("Летим");
        }
    }
    // движение - бег
    public class RunMovement : Movement
    {
        public override void Move()
        {
            Console.WriteLine("Бежим");
        }
    }

    public abstract class WarriorFactory
    {
        public abstract Movement CreateMovement();
        public abstract Weapon CreateWeapon();
        public abstract Protection CreateProtection();        
    }

    public class BerserkFactory:  WarriorFactory
    {
        public override Movement CreateMovement()
        {
            return new RunMovement();
        }

        public override Protection CreateProtection()
        {
            BerserkProtectionBuilder ProtectionBuilder = new BerserkProtectionBuilder();
            ChooseArm_Dialog chooseArm_Dialog = new ChooseArm_Dialog();

            chooseArm_Dialog.ShowDialog();
            ProtectionBuilder.CreateProtection();
            ProtectionBuilder.SetArmor(chooseArm_Dialog.ArmorType.Text);
            ProtectionBuilder.SetGuard(chooseArm_Dialog.GuardType.Text);
            return ProtectionBuilder.Protection;
        }

        public override Weapon CreateWeapon()
        {
            return new Sword();
        }
    }

    public class WizardFactory :WarriorFactory
    {

        public override Movement CreateMovement()
        {
            return new FlyMovement();
        }

        public override Weapon CreateWeapon()
        {
            return new Bow();
        }

        public override Protection CreateProtection()
        {
            WizardProtectionBuilder ProtectionBuilder = new WizardProtectionBuilder();
            ChooseArm_Dialog chooseArm_Dialog = new ChooseArm_Dialog();

            chooseArm_Dialog.ShowDialog();
            ProtectionBuilder.CreateProtection();
            ProtectionBuilder.SetArmor(chooseArm_Dialog.ArmorType.Text);
            ProtectionBuilder.SetGuard(chooseArm_Dialog.GuardType.Text);
            return ProtectionBuilder.Protection;
        }
    }

    interface IPrototype
    {
        IPrototype Clone();
    }

    class Warrior: IPrototype
    { 
        private Weapon weapon;
        private Movement movement;
        public Protection protection;
        public Warrior(WarriorFactory factory)
        {
            weapon = factory.CreateWeapon();
            movement = factory.CreateMovement();
            protection = factory.CreateProtection();
        }
       
        public void Move()
        {
            movement.Move();
        }
        public void Hit()
        {
            weapon.Hit();
        }

        public IPrototype Clone()
        {
            return this;
        }
    }




}