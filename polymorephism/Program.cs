namespace polymorephism
{
    internal class Program
    {
        class Animal
        {
            public virtual  void makeSound()
            {
                Console.WriteLine("make sound");
            }
        }
        //abstract class Animal
        //{
        //    public abstract void makeSound();

        //}
        //interface Animal
        //{
        //    void makeSound();
        //}

        class Cat:Animal
        {
            public override void makeSound()
            {
                Console.WriteLine("mm");
            }
        }
        class Dog:Animal
        {
            public override  void makeSound()
            {
                Console.WriteLine("dd");
            }
        }
        class calculete
        {
            public string Add(int x, int y,int z)
            {
                return$"Sum ={x+y+z}";
            }
            //public int Add(int x, int y, int z)
            //{
            //    return x + y + z;
            //}
            public int Add(int x, int y)
            {
                return  x + y ;
            }
            public int Add(float x, int y)
            {
                int a =( int)x + y;
                return a ;
            }
        }

        static void Main(string[] args)
        {
            //calculete calculete = new calculete();
            //Console.WriteLine(calculete.Add(3,2));
            //Console.WriteLine(calculete.Add(3, 2,4));

            Animal dog = new Dog();//
            dog.makeSound();
            Animal cat = new Cat();
            cat.makeSound();

        }
    }
}
