﻿using System.Collections.Generic;
using KR_Lib.DataStructures;
using System.Collections.Generic;

namespace KR_Lib.Formulas {
    public interface IFormula
    {
        bool Evaluate();

        List<Fluent> GetFluents();
    
    }

    public class Formula : IFormula
    {
        public Fluent fluent { get; }

        public Formula(Fluent fluent)
        {
            this.fluent = fluent;
        }
        public bool Evaluate()
        {
            return this.fluent.State;
        }

        public List<Fluent> GetFluents()
        {
            return new List<Fluent>() { this.fluent };
        }
    }
}
