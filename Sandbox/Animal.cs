namespace Sandbox
{
    public class Animal
    {
        public string Art { get;  }

        private int _age;

        public int Age
        {
            get { return _age; }
            set { _age = value; }
        }

        public Animal()
        {
            Art = "No name";
            _age = 0;
        }

        public Animal(int age, string art)
        {
            _age = age;
            Art = art;
        }

    }
}