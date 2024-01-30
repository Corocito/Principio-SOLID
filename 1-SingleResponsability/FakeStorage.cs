using System.Collections.ObjectModel;

namespace SingleResponsability
{
    //Creacion de un almacenamiento local para la lista que se usará
    public class FakeStorage<T>
    {
        //Definicion de la lista observable
        private ObservableCollection<T> collection;

        //Se inicializa la lista observable como la variable collection
        public FakeStorage()
        {
            collection = new ObservableCollection<T>();
        }

        //Se pasa un item T el cual se usará como la variable que agrega la informacion a la lista
        public T Add(T item)
        {
            collection.Add(item);
            return item;
        }

        //La variable T tambien es utilizada para eliminar un registro de la lista
        public T Remove(T item)
        {
            collection.Remove(item);
            return item;
        }

        //Se retorna la lista para poder visualizar la información
        public IEnumerable<T> GetAll()
        {
            return collection;
        }
    }
}