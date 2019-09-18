using System.Collections.Generic;

namespace WindowsFormsApp1
{
    class StateCollections
    {
        List<State> states = new List<State>();
        public List<State> GetStates()
        {
            states.Add(new State(){StateId = 0,StateName = "Select"});
            //states.Add(new State(){StateId = 1,StateName = "Telangana"});
            //states.Add(new State(){StateId = 2,StateName = "Maharastra"});
            //states.Add(new State(){StateId = 3,StateName = "Kerala"});
            //states.Add(new State(){StateId = 4,StateName = "Indore"});

            return states;
        }
    }
}
