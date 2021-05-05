﻿using System.Collections.Generic;
using KR_Lib.Descriptions;
using KR_Lib.Models;
using KR_Lib.Scenarios;
using KR_Lib.Tree;

namespace KR_Lib
{
    public static class TreeMethods
    {
        /// <summary>
        /// Metoda tworząca drzewo możliwości na podstawie domeny oraz scenariusza.
        /// </summary>
        /// <param name="descrpition"></param>
        /// <param name="scenario"></param>
        /// <returns>Korzeń powstałego drzewa możliwości.</returns>
        public static Node GenerateTree(IDescription descrpition, IScenario scenario)
        {
            Node root = new Node();
            return root;
        }

        /// <summary>
        /// Zwraca listę wszystkich powstałych struktur na podstawie drzewa możliwości.
        /// </summary>
        /// <param name="root"></param>
        /// <returns>Lista struktur</returns>
        public static List<Structure> GenerateStructues(Node root)
        {
            return new List<Structure>();
        }
    }
}