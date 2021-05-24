public static class FunctionFactory
{
    public static IFunction CreateFunctionFilter(Function fun)
    {
        switch (fun.category)
        {
            case FunctionType.Cosine:
                return new Cosine(fun);
            case FunctionType.Sine:
                return new Sine(fun);
            case FunctionType.Squared:
                return new Squared(fun);
            case FunctionType.Sawtooth:
                return new Sawtooth(fun);
        }
        return null;
    }
}