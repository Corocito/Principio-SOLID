namespace InterfaceSegregation
{
    //Si se desea que una sola interfaz implemente todos los metodos de todas las demás interfaces.
    //Se puede hacer herencia entre interfaces y asi una sola interfaz podrá implementar todos los metodos
    public interface IActivities : IComunicate, IDesign, IDevelop, ITest, IPlan
    {
        
    }
}