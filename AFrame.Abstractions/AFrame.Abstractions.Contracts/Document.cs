namespace Abstractions
{
    //-ag
    //add constraints on typing to capture full abstraction [Basically Typing lol]
    //getting to need own project 

    public interface IDomainable { } //encapsulate typing. trying to abstract something with ID 

    public interface IIDentifiable<T> { public T ID { get; } }
    public interface IIDentifiable : IIDentifiable<object> { }
    public interface INameable : IIDentifiable { public string Name { get; } }
    public interface IDescribable<T> { public T Description { get; } }
    public interface IDescribable : IDescribable<string> { }
    public interface ILoggable<T> : IDescribable<T> { public IDescribable<T> Catalog { get; } }
    public interface ILoggable : ILoggable<IDescribable> { }
    public interface ICatalogable<T> : ILoggable<T> { public ILoggable<T> Log { get; } }
    public interface ICatalogable : ILoggable<ICatalogable> { }
    public interface IStoreable<T> : ILoggable<T> { }
    public interface IStoreable : IStoreable<ILoggable> { }
    public interface ILockable<T> : IStoreable<T> { }
    public interface ILockable : ILockable<IStoreable> { }


    public interface IAddedContext { }
    public interface IAddedContext<T> : IAddedContext { }

    public interface IResult { }
    public interface IResult<T> : IResult { }
}