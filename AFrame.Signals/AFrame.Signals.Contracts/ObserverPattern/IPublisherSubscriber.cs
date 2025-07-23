using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using AFrame.Base.Abstractions;
using AFrame.Base.Contracts.Abstractions;

namespace AFrame.Signals.Contracts.ObserverPattern
{

    public interface IPublisherController
    {
        ICallResult Publish(IPublication publication);
    }

    public interface IAsyncPublisherController
    {
        ValueTask<ICallResult> PublishAsync(IPublication publication);
    }

    public interface IPublisher<TComms>
        where TComms : IPublication
    {
        delegate void SubscriberDelegateContract(IPublisher<TComms> publisher, TComms args);
        event SubscriberDelegateContract SubscribersDelegate;
    }
    public interface ISubscriber<TComms>
        where TComms : IPublication
    {
        ICallResult Subscribe(IPublisher<TComms> publisher);
        ICallResult UnSubscribe(IPublisher<TComms> publisher);
    }

    public interface IPublisherSubscriber<TComms> : IPublisher<TComms>, ISubscriber<TComms>, ISignalManager
        where TComms : IPublication
    {
        ICallResult Subscribe(ISubscriber<TComms> subscriber);
        ICallResult UnSubscribe(ISubscriber<TComms> subscriber);
    }

    public interface IChiefPublisherSubscriber<TComms> : IPublisherSubscriber<TComms>,      
                                                         IPublisherController,
                                                         IAsyncPublisherController, 
                                                         ISignalSystemManager
    where TComms : IPublication
    {
    }

    public interface IDeputyPublisherSubscriber_PSS<TComms> : IPublisherSubscriber<TComms> 
        where TComms : IPublication
    {
    }

    public interface IPublication : ISignal
    {
    }
}
 