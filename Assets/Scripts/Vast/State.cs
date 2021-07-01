using System;

namespace Vast.StateMachine {
    [Serializable]
    public abstract class State {
        private string name = String.Empty;

        #region Properties
        public string Name {
            get { return this.name; }
            protected set { this.name = value; }
        }
        #endregion

        #region Class Methods
        public abstract void OnEnter();
        public abstract void OnExit();
        public abstract void Update();
        public abstract void FixedUpdate();
        #endregion
    }
}