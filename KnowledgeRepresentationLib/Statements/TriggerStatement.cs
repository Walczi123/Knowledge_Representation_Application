﻿using KR_Lib.DataStructures;
using KR_Lib.Formulas;
using KR_Lib.Tree;
using System.Collections.Generic;

namespace KR_Lib.Statements
{
    public class TriggerStatement : Statement
    {
        public TriggerStatement(Action action, Fluent fluent, Formula formula) : base(action, null, formula)
        {
            // logika chyba w Nodzie - stworzenie tej akcji? TODO
        }

        public override bool CheckStatement(Action currentAction, List<Fluent> fluents, int time)
        {
            return formula.Evaluate();
        }

        public override State DoStatement(Action currentAction, List<Fluent> fluents)
        {
            return new State(action, fluents);
        }
    }
}
