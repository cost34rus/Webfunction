using System;
using AutoMapper;
using WebFunction3D.ViewModels;
using WebFunction3D_core.FunctionNew.FunctionGnuplot.Templates;
using WebFunction3D_core.FunctionNew.Graph3D.Templates;

namespace WebFunction3D.Mappers
{
    public class CommonMapper:IMapper 
    {
        static CommonMapper()
        {
            //шаблон 3D функции
            Mapper.CreateMap<TreeDFunctionViewModel, TreeDScriptTemplate>()
                .ForMember(dest => dest.Function,
                    opt => opt.MapFrom(src => src.Function))
                .ForMember(dest => dest.OutputFileName,
                    opt => opt.MapFrom(src => src.OutputFileName));

            Mapper.CreateMap<Graph3DViewModel, Graph3DTemplate>()
                .ForMember(dest => dest.Function,
                    opt => opt.MapFrom(src => src.Function))
                .ForMember(dest => dest.XFrom,
                    opt => opt.MapFrom(src => src.XFrom))
                .ForMember(dest => dest.XDo,
                    opt => opt.MapFrom(src => src.XDo))
                .ForMember(dest => dest.XStep,
                    opt => opt.MapFrom(src => src.XStep))
                .ForMember(dest => dest.YFrom,
                    opt => opt.MapFrom(src => src.YFrom))
                .ForMember(dest => dest.YDo,
                    opt => opt.MapFrom(src => src.YDo))
                .ForMember(dest => dest.YStep,
                    opt => opt.MapFrom(src => src.YStep));
        }

        public object Map(object source, Type sourceType, Type destinationType)
        {
            return Mapper.Map(source, sourceType, destinationType);
        }
    }
}