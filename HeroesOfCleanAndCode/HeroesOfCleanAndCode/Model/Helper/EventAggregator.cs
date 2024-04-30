using System;

namespace HeroesOfCleanAndCode.Model.Helper
{
    public class EventAggregator
    {
        public event EventHandler<string> UpdateCalled;

        public void UpdateEvent(string updateCallData)
        {
            UpdateCalled?.Invoke(this, updateCallData);
        }
    }
}
