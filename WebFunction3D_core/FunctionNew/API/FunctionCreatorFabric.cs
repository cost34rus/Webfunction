namespace WebFunction3D_core.FunctionNew.API
{
    public static class FunctionCreatorFabric<T> where T : IFunctionCreator, new ()
    {
        public static IFunctionCreator GetInstance()
        {
            return new T();
        }
    }
}