using namespace std;

#include "postConvertor.h"


/**********************************************************************/
/* Default constructor that initializes counters and puts a pound     */
/* symbol on stack                                                    */
/**********************************************************************/

postConvertor::postConvertor()
{
    postRank = 0;
    postStack.push('#');
    equation = "";
    rightPar = 0;
    leftPar = 0;
}

/**********************************************************************/
/* unused destructor                                                  */
/**********************************************************************/


postConvertor::~postConvertor()
{
}


/***********************************************************************/
/* A while loop that continues while there is still text to pull in    */
/* from infile, it calls another function to actually convert the line */
/* of data retrieved from the file, then checks to see if that equation*/
/* was parenthesized correctly, warning the user if it wasn't, it then */
/* resets the counter and stack for the next line of data              */
/***********************************************************************/

void postConvertor::postMain(ifstream &inFile, ofstream &outFile)
{
    while (inFile)
    {
        getline(inFile, equation);
        postChange(outFile);
        if (rightPar != leftPar)
        {
            outFile << "Warning: Previous Infix Equation is not parenthesized correctly, continuing to process..." << endl;
        }
        postRank = 0;
        rightPar = 0;
        leftPar = 0;
        clearStack();
    }
}


/**********************************************************************/
/* Cycles through the equation retrieved from the getline function    */
/* in postMain, checking to see if the current character selected     */
/* is a parenthesis, adding it to counter. It also checks to compare  */
/* the ranking value of the character the cursor is on to the stack's */
/* top cursor on. If it is lesser then it pops the stack, if a pair   */
/* of parenthesis match, it pops everything up until the matching     */
/* parenthesis, otherwise it pushes it onto the stack. At the end     */
/* of going through the string, the whole entire stack is popped      */
/* except the pound sign                                              */
/**********************************************************************/

void postConvertor::postChange(ofstream &outFile)
{
    int i = 0;
    while (i != (equation.length()))
    {
        curPos = equation[i];
        if (curPos == '(')
        {
            leftPar += 1;
        }

        else if (curPos == ')')
        {
            rightPar +=1;
        }



        if ((inputNum(curPos)) < (stackNum(postStack.top())))
            popPrecedence(outFile);
        else if (((curPos == ')') && (leftPar >=1)))
            {
             postPopAll(outFile);
            }
        else
        {
         postStack.push(curPos);
        }


      i+=1;
    }
    popAll(outFile);

    outFile << endl;
}


/**********************************************************************/
/* Pops everything out of the stack to the outFile                    */
/**********************************************************************/


void postConvertor::postPopAll(ofstream &outFile)
{
    while (postStack.top() != '(')
    {
        rankChange(postStack.top());
        outFile << postStack.top();
        postStack.pop();
    }
    postStack.pop();
    rightPar = 0;
    leftPar = 0;
}

/**********************************************************************/
/* checks the character to be placed into the stack's ranking number  */
/* and returns it's value                                             */
/**********************************************************************/


int postConvertor::inputNum (char curPos)
{
    if ((curPos == '+') || (curPos == '-'))
        return 1;
    else if ((curPos == '*') || (curPos == '/'))
        return 3;
    else if (curPos == '(')
        return 9;
    else if (curPos == ')')
        return 0;
    else if (curPos == '#')
        return 0;
    else if (curPos == '=')
        return 0;
    else
        return 7;
}


/**********************************************************************/
/* Checks the character at the top of the stack's value and returns it*/
/**********************************************************************/

int postConvertor::stackNum (char curPos)
{
     if ((curPos == '+') || (curPos == '-'))
        return 2;
    else if ((curPos == '*') || (curPos == '/'))
        return 4;
    else if (curPos == '(')
        return 0;
    else if (curPos == '#')
        return 0;
    else if (curPos == '=')
        return 1;
    else if (isalpha(curPos))
        return 8;


}

/**********************************************************************/
/* pops all the values that are less then the current input character */
/* and displays them to output, minus the parenthesis                 */
/**********************************************************************/

void postConvertor::popPrecedence(ofstream &outFile)
{
    while ((inputNum(curPos)) < (stackNum(postStack.top())))
    {
        rankChange(postStack.top());
        if (postStack.top() == '(')
        {
            leftPar -= 1;
        }
        else if (postStack.top() == ')')
        {
            rightPar -=1;
        }
        else
        {
            outFile << postStack.top();
        }
         postStack.pop();
    }

    postStack.push(curPos);
}

/**********************************************************************/
/* changes the rank based on the character being pushed out           */
/**********************************************************************/

void postConvertor::rankChange(char curPos)
{
     if ((curPos == '+') || (curPos == '-'))
        postRank -= 1;
    else if ((curPos == '*') || (curPos == '/'))
         postRank -= 1;
   else if (curPos == '=')
       postRank -= 1;
    else if (isalpha(curPos))
        postRank += 1;
   else
            return;
}

/**********************************************************************/
/* clears the stack container and adds a pound sign                   */
/**********************************************************************/

void postConvertor::clearStack()
{
    while (!postStack.empty())
    {
        postStack.pop();
    }
    postStack.push('#');
}



/**********************************************************************/
/*pops all values of the stack until it reaches the pound sign        */
/**********************************************************************/


void postConvertor::popAll(ofstream &outFile)
{
    while (postStack.top() != '#')
    {

        rankChange(postStack.top());
        if ((postStack.top() == '(') || (postStack.top() == ')'))
        {

            postStack.pop();
        }
        else
        {
            outFile << postStack.top();
            postStack.pop();
        }

    }

}


/**************************************************************************/
/* Reads in an equation while the infile exists, and then cycles through  */
/* the equation, storing each string value unless it is a operator,       */
/* then the function outputs the assembly commands using the the 2 top    */
/* stack values and the operator, then stores the new value as            */
/* tempX, where X is the number of times this process has happened before */
/**************************************************************************/



void postCommand::convMain(ifstream &inFile, ofstream &outFile)
{
    while (inFile)
    {
        getline(inFile, equation);
        int i = 0;
        tempNo = 1;
        while (i != equation.length())
        {
            curPos = equation[i];
            if (!isOperand(curPos))
                {

                  comStack.push(curPos);
                  }
            else if(isOperand(curPos))
                {
                    sstm << "TEMP" << tempNo;
                    curTemp = sstm.str();
                    sstm.str("");

                    op = strOperand(curPos);
                    operA = comStack.top();
                    comStack.pop();
                    operB = comStack.top();
                    comStack.pop();
                    outFile << "LD  " + operB << endl;
                    op = strOperand(curPos);
                    outFile << op << "   " + operA << endl;
                    outFile << "ST  " + curTemp << endl;

                    comStack.push(curTemp);
                    tempNo += 1;
                    }
                      i +=1;

                }
                outFile << endl << endl;



        }



         }



/**********************************************************************/
/* Checks to see if current string is an operand                      */
/**********************************************************************/

bool postCommand::isOperand(string operand)
                 {
                     if ((operand =="+") || (operand =="-") || (operand =="*") || (operand =="/"))
                        return true;

                     else
                        return false;

                     }


/**********************************************************************/
/* sees the value of the operand string and returns a new string      */
/* for the equivalent assembly command                                */
/**********************************************************************/

string postCommand::strOperand(string operand)
{
    if (operand=="+")
        return "AD";
    else if (operand=="-")
        return "SB";
    else if (operand=="*")
        return "ML";
    else if (operand=="/")
        return "DV";
}



/**********************************************************************/
/* prereads the first string value and then launches a while loop     */
/* that calls two functions to convert read in data to machine code   */
/**********************************************************************/

void binaryCode::binaryMain(ifstream &inFile, ofstream &outFile)
{
    inFile >> temp;

    while (inFile)
    {
        opcode(inFile, outFile);
        inFile >> temp;
        ascii(inFile, outFile);
        inFile >> temp;
    }

}

/**********************************************************************/
/* converts the read in string to 4 bit opcodes to show on the outfile*/
/**********************************************************************/

void binaryCode::opcode(ifstream &inFile, ofstream &outFile)
{
    if (temp == "LD")
    outFile << "0000    ";
    else if (temp =="ST")
    outFile << "0001    ";
    else if (temp =="AD")
    outFile << "0010    ";
    else if (temp =="SB")
    outFile << "0011    ";
    else if (temp =="ML")
    outFile << "0100    ";
    else if (temp =="DV")
    outFile << "0101    ";
}





/**********************************************************************/
/* loops through the string to convert each character to it's ascii   */
/* value and then throws it to outfile                                */
/**********************************************************************/



void binaryCode::ascii(ifstream &inFile, ofstream &outFile)
{
      for (int i = 0; i < temp.length(); i++)
    {
        char x = temp.at(i);
        outFile << int(x);
    }
  outFile << endl;
}
