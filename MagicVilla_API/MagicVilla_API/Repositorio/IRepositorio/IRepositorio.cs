using System.Linq.Expressions;

namespace MagicVilla_API.Repositorio.IRepositorio
{
    /*Esto del Repositorio es un patrón que se utiliza para encapsular la lógica de 
     * acceso a datos en una capa separada de la aplicación, lo que facilita la implementación de 
     * operaciones de lectura y escritura en una variedad de tipos de 
     * entidades (por ejemplo, tablas de base de datos) sin tener que escribir código específico 
     * para cada entidad.
     * El uso de un parámetro de tipo genérico T permite que este repositorio sea reutilizable para trabajar 
     * con diferentes tipos de entidades. Por ejemplo, puedes tener un repositorio IRepositorio<Cliente> para 
     * trabajar con entidades de cliente y otro repositorio IRepositorio<Orden> para trabajar con entidades de orden, 
     * y ambos implementarán los mismos métodos definidos en la interfaz genérica.
        La ventaja de esta abstracción es que puedes tener una implementación única de un repositorio genérico
        que maneje las operaciones comunes de acceso a datos, y luego puedes crear repositorios específicos para 
        cada entidad al implementar la interfaz genérica con el tipo de entidad deseado. 
        Esto promueve la reutilización de código y facilita el mantenimiento de la lógica de acceso a datos 
        en una aplicación.*/


    public interface IRepositorio<T> where T : class //esa T significa que se puede recibir  cualquier tipo de entidad
    {
        Task Crear(T entidad);
        Task<List<T>> ObtenerTodos(Expression<Func<T, bool>>? filtro = null);
        Task<T> Obtener(Expression<Func<T, bool>>? filtro = null, bool tracked = true);

        Task Remover(T entidad);

        Task Grabar();
    }
}
