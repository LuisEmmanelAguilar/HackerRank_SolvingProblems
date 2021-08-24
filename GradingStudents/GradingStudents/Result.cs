using System.CodeDom.Compiler;
using System.Collections.Generic;
using System.Collections;
using System.ComponentModel;
using System.Diagnostics.CodeAnalysis;
using System.Globalization;
using System.IO;
using System.Linq;
using System.Reflection;
using System.Runtime.Serialization;
using System.Text.RegularExpressions;
using System.Text;
using System;

// Submitted August 10, 2021
namespace GradingStudents
{
    class Result
    {
        public static List<int> gradingStudents(List<int> grades)
        {
            // LINQ
            // LAMBDA
            /*
            return grades.Select(grade =>
            {
                if (grade % 5 < 3 || grade < 38)
                {
                    return grade;
                }
                return grade + (5 - grade % 5);
            });
            */

            List<int> finalScores = new List<int>();

            foreach(int grade in grades)
            {
                if(grade % 5 < 3 || grade < 38) // Residuo de 5 es menor a 3 o el grado es menor a 38
                {
                    finalScores.Add(grade);
                }
                else
                {
                    // redondea
                    finalScores.Add(grade + (5 - grade % 5));
                }
            }
            return finalScores;

        }

    }
}
