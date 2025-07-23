using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace AFrame.Base.Contracts.Abstractions
{
    //-ag
    //add constraints on typing to capture full abstraction [Basically Typing lol]


    public interface IPseudoNonDomainable { }
    public interface IAssertedNonDomainable : IPseudoNonDomainable { }
    public interface INonDomainable { } //getting at ID_0, seperate project 
    public interface IDomainable { } //encapsulate typing. trying to abstract something with ID 

    public interface IIdentifiable<T> { T Id { get; } }
    public interface IIdentifiable : IIdentifiable<Guid> { }

    public interface INameable<TIdentity, TName> : IIdentifiable<TIdentity> { TName Name { get; } }
    public interface INameable<TName> : IIdentifiable { }
    public interface INameable : INameable<string> { }

    public interface IDescribable<TIdentity, TName, TDescription> { TDescription Description { get; } }
    public interface IDescribable<TName, TDescription> : IDescribable<IIdentifiable, TName, TDescription> { }
    public interface IDescribable<TDescription> : IDescribable<INameable, TDescription> { }
    public interface IDescribable : IDescribable<string> { }
    public interface IGSSDescribable : IDescribable { }
    public interface IDefaultDescribable : IDescribable { }


    public interface ILoggable<T> : IDescribable<T> { IDescribable<T> Catalog { get; } }
    public interface ILoggable : ILoggable<IDescribable> { }
    public interface ICatalogable<T> : ILoggable<T> { ILoggable<T> Log { get; } }
    public interface ICatalogable : ILoggable<ICatalogable> { }
    public interface IStoreable<T> : ILoggable<T> { }
    public interface IStoreable : IStoreable<ILoggable> { }
    public interface ILockable<T> : IStoreable<T> { }
    public interface ILockable : ILockable<IStoreable> { }


    public interface IPair { }
    public interface IPair<T> { }
}
