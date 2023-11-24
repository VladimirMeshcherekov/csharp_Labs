namespace BillingSystme
{
    public abstract class State
    {
        public abstract void Enter();

        public abstract void Update();

        public abstract void Exit();

        /// <summary>
        /// Updates internal state data if necessary
        /// </summary>
        public virtual void UpdateData(object value)
        {
        }

        /// <summary>
        /// use this only for objects that are initialized in the inspector
        /// </summary>
        public virtual void Initialize(object value)
        {
        }
    }
}