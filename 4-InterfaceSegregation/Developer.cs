namespace InterfaceSegregation
{
    public class Developer : IDevelop, IDesign
    {
        public Developer()
        {
        }

        public void Develop(){
            Console.WriteLine("Im developing the funcionalities required");
        }

        public void Design(){
            Console.WriteLine("Im designing new features");
        }
    }
}