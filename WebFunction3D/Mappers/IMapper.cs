using System;

namespace WebFunction3D.Mappers
{
    public interface IMapper
    {
        object Map(object source, Type sourceType, Type destinationType);
    }
}