    using System;
    using BillingSystme;

    public class StateMachine
    {
        public State CurrentState { get; private set; }
      
        /// <summary>
        /// Use for initialize state. Can using one time, before change states.
        /// <param name="initializableState"></param>
        public void Initialize(State initializableState)
        {
            if (CurrentState is null)
            {
                CurrentState = initializableState;
                CurrentState.Enter();
            }
            else
            {
                throw new Exception(
                    "You can use Initialize method only one time, if Current state undefined. For change state use method ChangeState");
            }
        }

        /// <summary>
        /// Use for change state. Old state will exit automatically.
        /// </summary>
        public void ChangeState(State newState)
        {
            CurrentState.Exit();
            CurrentState = newState;
            CurrentState.Enter();
        }

        public void UpdateStateData<T>(T newData)
        {
            CurrentState.UpdateData(newData);
        }

        public void UpdateState()
        {
            CurrentState.Update();
        }
    }
