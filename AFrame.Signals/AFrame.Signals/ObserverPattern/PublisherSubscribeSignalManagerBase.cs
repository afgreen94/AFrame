//using AFrame.Base;
//using AFrame.Base.Abstractions;
//using AFrame.Base.Contracts;
//using AFrame.Base.Contracts.Abstractions;
//using AFrame.Signals.Contracts;
//using AFrame.Signals.Contracts.ObserverPattern;
//using System.Text;

//namespace AFrame.Signals.ObserverPattern
//{

//    //need abstr for typing  

//    public abstract class PublishSubscribeSignalSystemManagerBase<TSignal> : SignalSystemManagerBase, IPublishSubscribeSignalSystemManager
//        where TSignal : ISignal
//    {

//    }


//    public abstract class PublisherSubscribeSignalManagerBase<TComms> : IPublisherSubscriber<TComms>
//        where TComms : ICommunications
//    {
//        protected const string NotSupportedAddendum = "Methods not supported";
//        protected const string UnSupportedOperationPublisher = "Susbcriber " + NotSupportedAddendum;
//        protected const string UnSupportedOperationSubscriber = "Publisher " + NotSupportedAddendum;

//        public event IPublisher<TComms>.SubscriberDelegateContract SubscribersDelegate;

//        public ICallResult Subscribe(IPublisher<TComms> publisher) => SubscribeCore(publisher);
//        public ICallResult Subscribe(ISubscriber<TComms> subscriber) => SubscribeCore(subscriber);
//        public ICallResult UnSubscribe(IPublisher<TComms> publisher) => UnSubscribeCore(publisher);
//        public ICallResult UnSubscribe(ISubscriber<TComms> subscriber) => UnSubscribe(subscriber);

//        protected virtual ICallResult SubscribeCore(IPublisher<TComms> publisher)
//        {
//            publisher.SubscribersDelegate += OnPublication;
//            return new CallResult();
//        }
//        protected virtual ICallResult SubscribeCore(ISubscriber<TComms> subscriber) => subscriber.Subscribe(this);
//        protected virtual ICallResult UnSubscribeCore(IPublisher<TComms> publisher)
//        {
//            publisher.SubscribersDelegate -= OnPublication;
//            return new CallResult();
//        }
//        protected virtual ICallResult UnSubscribeCore(ISubscriber<TComms> subscriber) => subscriber.UnSubscribe(this);

//        protected virtual void OnPublication(IPublisher<TComms> publisher, TComms args) { }
//    }

//    public abstract class PublisherBase<TComms> : PublisherSubscribeSignalManagerBase<TComms>, IPublisher<TComms>
//        where TComms : ICommunications
//    {
//        protected override void OnPublication(IPublisher<TComms> publisher, TComms args) => throw new UnsupportedOperationException();
//        protected override ICallResult SubscribeCore(IPublisher<TComms> publisher) => throw new UnsupportedOperationException();
//        protected override ICallResult UnSubscribeCore(IPublisher<TComms> publisher) => throw new UnsupportedOperationException();

//    }

//    public abstract class SubscriberBase<TComms> : PublisherSubscribeSignalManagerBase<TComms>, ISubscriber<TComms>
//        where TComms : ICommunications
//    {
//        protected override ICallResult SubscribeCore(ISubscriber<TComms> subscriber) => throw new UnsupportedOperationException();
//        protected override ICallResult UnSubscribeCore(ISubscriber<TComms> subscriber) => throw new UnsupportedOperationException();
//    }
//}