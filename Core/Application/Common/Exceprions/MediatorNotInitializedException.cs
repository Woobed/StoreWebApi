using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Application.Common.Exceprions
{
    public class MediatorNotInitializedException : Exception
        
    {
        public MediatorNotInitializedException(string name) 
            : base($"Mediator ({name}) is not initialized"){}
    }
}
