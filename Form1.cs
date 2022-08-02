using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SolverTest {    //**NB(pretty outdated)** I think the error at the moment is that its not passing its value forward if an operator with higher precedence that has already been solved and should be skipped is in the way. Index should keep incrementing until it finds an element that contains the operator
    public partial class Form1 : Form {     //I think I can solve my problems by keeping a list of solved equations indeces and deleting in a single for loop at function end to avoid indexing issues mid operation (problem below).
        public Form1() {
            InitializeComponent();
        }
                                    //, "2+2", "2/2", "2/4", "4-2", "2+3", "3+4", "4*4", "4+5", "5*6" 
        List<string> equation = new List<string> { "2/3", "3+3", "3-3", "3*3", "3/3" };//This still breaks when duplicate operations are adjacent to eachother, the value is not passed correctly because the previous solved values are not deleted until the end
        List<int> solvedIndeces = new List<int>();
        string result = "";                                                     //I think I can solve the above problem by creating a do while loop that checks if the previous element contains the current operator (we will only ever need to look backwards because equations are solved left to right) and replacing the first one not containing it/terminating the loop. 
    
        private void solveButton_Click(object sender, EventArgs e) {    //***NB*****  I THINK THE BEST PLAN IS TO TEST AND FIX USING PRINT OUTS OF BROOKEN EQUATIONS
            Solver(equation, '*', '/');                                      //**NB***** MD and AS must be done simultaneously left to right 2 When I do the math by hand it is correct but calculators disagree and adding a minus to the end breaks it
            for (int i = 0; i < equation.Count; i++) { multiplicationLabel.Text += " " + equation[i];}
            for (int i = solvedIndeces.Count - 1; i > -1; i--) {
                equation.RemoveAt(solvedIndeces[i]);    //TODO turn this into a cleanup function
            }
            solvedIndeces.Clear();

            Solver(equation, '+', '-');
            for (int i = 0; i < equation.Count; i++) { additionLabel.Text += " " + equation[i]; }
            for (int i = solvedIndeces.Count - 1; i > -1; i--) {
                equation.RemoveAt(solvedIndeces[i]);
            }
            solvedIndeces.Clear();

            for (int i = 0; i < equation.Count; i++) {
                postEquationLabel.Text += equation[i] + " ";
            }
            for (int i = 0; i < solvedIndeces.Count; i++) {
                solvedIndecesLabel.Text += solvedIndeces[i].ToString();
            }
            solvedEquation.Text += result + " ";
        }

        private void Solver(List<string> equation, char operator1, char operator2) {

            for (int i = 0; i < equation.Count; i++) {

                if (equation[i].Contains(operator1)) {

                    solvedIndeces.Add(i);
                    string[] operands = equation[i].Split(operator1);

                    switch (operator1) {
                        case '*':
                            result = (double.Parse(operands[0]) * double.Parse(operands[1])).ToString();
                            break;
                        case '/':
                            result = (double.Parse(operands[0]) / double.Parse(operands[1])).ToString();
                            break;
                        case '+':
                            result = (double.Parse(operands[0]) + double.Parse(operands[1])).ToString();
                            break;
                        case '-':
                            result = (double.Parse(operands[0]) - double.Parse(operands[1])).ToString();
                            break;
                    }

                    if (i != equation.Count - 1) {
                        equation[i + 1] = replaceFirstOccurance(equation[i + 1], operands[1], result);//equation[i + 1].Replace(operands[1], result); //These are replacing ALL instances of the old value found in the string, breaks on duplicate operands
                    }

                    if (i != 0) {
                        for (int passerIndex = i -1; passerIndex >= 0; passerIndex--) { //**NB** This seems to be causing trouble 
                            if (!((equation[passerIndex].Contains(operator1)) || (equation[passerIndex].Contains(operator2)))) {
                                equation[passerIndex] = replaceLastOccurance(equation[passerIndex], operands[0], result);// equation[i - 1].Replace(operands[0], result);
                                break;
                            }
                        }
                    }

                } else if (equation[i].Contains(operator2)) {

                    solvedIndeces.Add(i);
                    string[] operands = equation[i].Split(operator2);

                    switch (operator2) {
                        case '*':
                            result = (double.Parse(operands[0]) * double.Parse(operands[1])).ToString();
                            break;
                        case '/':
                            result = (double.Parse(operands[0]) / double.Parse(operands[1])).ToString();
                            break;
                        case '+':
                            result = (double.Parse(operands[0]) + double.Parse(operands[1])).ToString();
                            break;
                        case '-':
                            result = (double.Parse(operands[0]) - double.Parse(operands[1])).ToString();
                            break;
                    }

                    if (i != equation.Count - 1) {
                        equation[i + 1] = replaceFirstOccurance(equation[i + 1], operands[1], result);//equation[i + 1].Replace(operands[1], result); //These are replacing ALL instances of the old value found in the string, breaks on duplicate operands
                    }

                    if (i != 0) {
                        for (int passerIndex = i - 1; passerIndex >= 0; passerIndex--) {
                            if (!((equation[passerIndex].Contains(operator2)) || (equation[passerIndex].Contains(operator1)))) {
                                equation[passerIndex] = replaceLastOccurance(equation[passerIndex], operands[0], result);// equation[i - 1].Replace(operands[0], result);
                                break;
                            }
                        }
                    }
                }
            }
        }


        private string replaceFirstOccurance(string original, string operand, string result) {
            int loc = original.IndexOf(operand);
            if (loc != -1) {        //checks if it is there first
                Console.WriteLine("firstWorks");
                return original.Remove(loc, operand.Length).Insert(loc, result); 
            } else {Console.WriteLine("first");return original; }
        }

        private string replaceLastOccurance(string original, string operand, string result) {
            int loc = original.LastIndexOf(operand);
            if (loc != -1) {        //checks if it is there first
                Console.WriteLine("lastWorks");
                return original.Remove(loc, operand.Length).Insert(loc, result); 
            } else { Console.WriteLine("last"); return original; }
        }

        private void Form1_Load(object sender, EventArgs e) {
            for (int i = 0; i < equation.Count; i++) {
                unsolvedEquation.Text += equation[i] + " ";
            }
        }
    }
}
