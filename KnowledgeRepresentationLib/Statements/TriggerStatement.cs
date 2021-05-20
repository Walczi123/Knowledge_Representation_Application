﻿using KR_Lib.DataStructures;
using KR_Lib.Formulas;
using KR_Lib.Tree;
using System.Collections.Generic;

namespace KR_Lib.Statements
{
    public class TriggerStatement : Statement
    {
        IFormula formulaIf;

        public TriggerStatement(Action action, IFormula formulaIf) : base(action)
        {
            this.formulaIf = formulaIf;
        }

        public override bool CheckStatement(Action currentAction, List<Fluent> fluents, List<Action> impossibleActions, int time)
        {
            return formulaIf.Evaluate();
        }

        public override State DoStatement(List<Action> currentActions, List<Fluent> fluents, List<Action> impossibleActions)
        {
            currentActions.Add(action);
            return new State(currentActions, fluents, impossibleActions);
        }
    }
}
