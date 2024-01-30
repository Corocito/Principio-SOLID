namespace InterfaceSegregation
{
    public class Tester : ITest, IDesign
    {
        public Tester()
        {
        }

        public void Test(){
            Console.WriteLine("Im testing the application");
        }
        
        public void Design(){
            Console.WriteLine("Im designing new futures");
        }
    }
}