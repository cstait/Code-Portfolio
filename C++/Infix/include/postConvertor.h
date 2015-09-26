#ifndef POSTCONVERTOR_H
#define POSTCONVERTOR_H
#include <fstream>
#include <stack>
#include <sstream>
#include <string>

class postConvertor
{
    public:
        postConvertor();
        virtual ~postConvertor();
        void postMain(ifstream &inFile, ofstream &outFile);
        void postChange(ofstream &outFile);
        void postPopAll(ofstream &outFile);
        int inputNum (char curPos);
        int stackNum (char curPos);
        void popPrecedence(ofstream &outFile);
        void rankChange(char curPos);
        void clearStack();
        void popAll(ofstream &outFile);

    protected:
    private:
        stack<char> postStack;
        int postRank;
        string equation;
        char curPos;
        int leftPar;
        int rightPar;
        char charOut;
        int counterLeft;
        int counterRight;
};


class postCommand
{
public:
    void convMain(ifstream &inFile, ofstream &outFile);
    bool isOperand(string operand);
    string strOperand(string operand);

private:
    string curPos;
    string equation;
    stack<string> comStack;
    string op;
    int tempNo;
    string operA;
    string operB;
    string curTemp;
    string strNo;
    stringstream sstm;

};



class binaryCode
{
public:
    void binaryMain(ifstream &inFile, ofstream &outFile);
    void opcode(ifstream &inFile, ofstream &outFile);
    void ascii(ifstream &inFile, ofstream &outFile);

private:
    string temp;
};
#endif // POSTCONVERTOR_H
