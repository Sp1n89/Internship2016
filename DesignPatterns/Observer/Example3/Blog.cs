using System.Collections.Generic;

namespace DesignPatterns.Observer.Example3
{
    public class Blog
    {
        public delegate void NotifyDelegate(string state);

        public event NotifyDelegate Notify;

        private IList<IBlogSubscriber> _blogSubscribers;

        private string _state;

        public string State
        {
            get { return _state;}
            set { _state = value;
                Notify(_state);
            }
        }
        
        public void Subscribe(IBlogSubscriber subscriber)
        {
            if (!_blogSubscribers.Contains(subscriber))
            {
                _blogSubscribers.Add(subscriber);
            }
        }

        public void UnSubscribe(IBlogSubscriber subscriber)
        {
            if (_blogSubscribers.Contains(subscriber))
            {
                _blogSubscribers.Remove(subscriber);
            }
        }
    }
}