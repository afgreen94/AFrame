using Abstractions;
using Abstractions.Contracts;
using Base;
using Base.Contracts;
using Signals.Contracts;
using Signals.Contracts.ObserverPattern;
using System.Text;

namespace Signals.ObserverPattern
{

    //need abstr for typing  

    public abstract class PublishSubscribeSignalSystemManagerBase<TSignal> : SignalSystemManagerBase, IPublishSubscribeSignalSystemManager
        where TSignal : ISignal
    {

    }


    public abstract class PublisherSubscribeSignalManagerBase<TComms> : IPublisherSubscriber<TComms>
        where TComms : ICommunications
    {
        protected const string NotSupportedAddendum = "Methods not supported";
        protected const string UnSupportedOperationPublisher = "Susbcriber " + NotSupportedAddendum;
        protected const string UnSupportedOperationSubscriber = "Publisher " + NotSupportedAddendum;

        public event IPublisher<TComms>.SubscriberDelegateContract SubscribersDelegate;

        public IResult Subscribe(IPublisher<TComms> publisher) => SubscribeCore(publisher);
        public IResult Subscribe(ISubscriber<TComms> subscriber) => SubscribeCore(subscriber);
        public IResult UnSubscribe(IPublisher<TComms> publisher) => UnSubscribeCore(publisher);
        public IResult UnSubscribe(ISubscriber<TComms> subscriber) => UnSubscribe(subscriber);

        protected virtual IResult SubscribeCore(IPublisher<TComms> publisher)
        {
            publisher.SubscribersDelegate += OnPublication;
            return new Result();
        }
        protected virtual IResult SubscribeCore(ISubscriber<TComms> subscriber) => subscriber.Subscribe(this);
        protected virtual IResult UnSubscribeCore(IPublisher<TComms> publisher)
        {
            publisher.SubscribersDelegate -= OnPublication;
            return new Result();
        }
        protected virtual IResult UnSubscribeCore(ISubscriber<TComms> subscriber) => subscriber.UnSubscribe(this);

        protected virtual void OnPublication(IPublisher<TComms> publisher, TComms args) { }
    }

    public abstract class PublisherBase<TComms> : PublisherSubscribeSignalManagerBase<TComms>, IPublisher<TComms>
        where TComms : ICommunications
    {
        protected override void OnPublication(IPublisher<TComms> publisher, TComms args) => throw new UnsupportedOperationException();
        protected override IResult SubscribeCore(IPublisher<TComms> publisher) => throw new UnsupportedOperationException();
        protected override IResult UnSubscribeCore(IPublisher<TComms> publisher) => throw new UnsupportedOperationException();

    }

    public abstract class SubscriberBase<TComms> : PublisherSubscribeSignalManagerBase<TComms>, ISubscriber<TComms>
        where TComms : ICommunications
    {
        protected override IResult SubscribeCore(ISubscriber<TComms> subscriber) => throw new UnsupportedOperationException();
        protected override IResult UnSubscribeCore(ISubscriber<TComms> subscriber) => throw new UnsupportedOperationException();
    }
}