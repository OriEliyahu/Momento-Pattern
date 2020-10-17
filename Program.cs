using System;
using System.Collections.Generic;

namespace MomentoPattern
{
    class Program
    {
        static void Main(string[] args) 
        {
            List<Originator.Memento> savedStates = new List<Originator.Memento>();

            Originator originator = new Originator();
            originator.Set("State1");
            originator.Set("State2");
            savedStates.Add(originator.SaveToMemento());
            originator.Set("State3");
            // We can request multiple mementos, and choose which one to roll back to.
            savedStates.Add(originator.SaveToMemento());
            originator.Set("State4");

            originator.RestoreFromMemento(savedStates[0]);   
        }
    }
}
