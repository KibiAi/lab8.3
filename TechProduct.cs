using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lab8._3
{
    public abstract class TechProduct
    {
        public abstract void Assemble();
    }

    public class Smartphone : TechProduct
    {
        public override void Assemble()
        {
            Console.WriteLine("Смартфон зібрано");
        }
    }

    public class Laptop : TechProduct
    {
        public override void Assemble()
        {
            Console.WriteLine("Ноутбук зібрано");
        }
    }

    public class Tablet : TechProduct
    {
        public override void Assemble()
        {
            Console.WriteLine("Планшет зібрано");
        }
    }

    public abstract class TechProductFactory
    {
        public abstract TechProduct CreateTechProduct();
    }

    public class SmartphoneFactory : TechProductFactory
    {
        public override TechProduct CreateTechProduct()
        {
            return new Smartphone();
        }
    }

    public class LaptopFactory : TechProductFactory
    {
        public override TechProduct CreateTechProduct()
        {
            return new Laptop();
        }
    }

    public class TabletFactory : TechProductFactory
    {
        public override TechProduct CreateTechProduct()
        {
            return new Tablet();
        }
    }

}
