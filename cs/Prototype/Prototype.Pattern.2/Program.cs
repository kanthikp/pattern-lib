using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Prototype.Pattern._2
{
    class Program
    {
        static void Main(string[] args)
        {
            var puzzle = new LogicPuzzle();
            puzzle.SwitchBlueSwitch();
            puzzle.ToggleBigToggle();
            puzzle.SwitchBlueSwitch();
            puzzle.ToggleBigToggle();
            puzzle.SwitchRedSwitch();

            puzzle.PrintState();

            var puzzle2 = puzzle.Clone() as LogicPuzzle;
            puzzle2.PrintState();

            Console.ReadKey();
        }
    }
}
