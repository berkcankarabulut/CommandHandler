using System; 
using UnityEngine;

namespace CommandHandler.Runtime
{ 
    public abstract class Command : MonoBehaviour 
    {
        public abstract void Execute(); 
        
        public abstract void Undo();

        protected virtual void Complete()
        {
            OnComplete?.Invoke(this);
        }
        
        public Action<Command> OnComplete;
    }  
}
