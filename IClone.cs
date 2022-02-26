//Generic interface för att göra det så generiskt som möjligt.
public interface IClone<T>
{
    public T Clone(T t);
}