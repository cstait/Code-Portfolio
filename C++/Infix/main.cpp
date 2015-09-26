/*************************************************/
/*                                               */
/*  Programmer Name: Cameron Tait                */
/*  Course Title: CS316 Section No.: 1           */
/*  Assignment No: MP #3 Due Date: 10-27-2014    */
/*  Instructor: Dr. Tai-Chi Lee                  */
/*                                               */
/*************************************************/
/* Program Definitions:                           */
/*************************************************/
/* Identifier Dictionary:                        */
/*************************************************/
/* Development History:                          */
/* 10/17: Started Work on Prefix converter       */
/* 10/18: finished prefix, started command       */
/* 10/26: finished command and binary            */
/*************************************************/





#include <iostream>
#include <fstream>
using namespace std;

#include "postConvertor.h"



/******************************************************************** */
/* The main function opens input and output files for data processing */
/* which is driven by class function, it repeats this by closing and  */
/* opening new files for output                                       */
/**********************************************************************/

int main()
{

ifstream inFile;
ofstream outFile;
postConvertor post;
postCommand com;
binaryCode binary;

inFile.open("in.txt");
outFile.open("out.txt");

if (!inFile)
{
    cout << "could not open infile!";
}


post.postMain(inFile, outFile);

inFile.close();
outFile.close();

inFile.open("out.txt");
outFile.open("command.txt");

com.convMain(inFile, outFile);

inFile.close();
outFile.close();


inFile.open("command.txt");
outFile.open("assembly.txt");

binary.binaryMain(inFile, outFile);

inFile.close();
outFile.close();





    return 0;
}
