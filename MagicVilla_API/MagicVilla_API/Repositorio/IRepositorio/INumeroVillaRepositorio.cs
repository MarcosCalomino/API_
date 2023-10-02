using MagicVilla_API.Modelos;

namespace MagicVilla_API.Repositorio.IRepositorio
{
    //INTERFACE CREADA UNICAMENTE PARA EL MEDELO VILLA, SI TENGO UN MODELO SOCIO DEBO CREAR U IFACE PARA DICHE MODELO
    public interface INumeroVillaRepositorio : IRepositorio<NumeroVilla>
    {
        Task<NumeroVilla> Actualiza(NumeroVilla entidad);
    }
}
