
/****************************************************************************/
/*                                                                          */
/*      Programmer Name: Cameron Tait                                       */
/*      Course Title:    CS316 Section No. 1                                */
/*      Assignment No. : MP #2  Due Date: 09-29-2014                        */
/*      Instructor: Dr. Tai-Chi Lee                                         */
/*                                                                          */
/****************************************************************************/
/*                                                                          */
/* Program Definition: This program reads a command from an input file, then */
/* stores information into a linked list, with a flight linked list containing */
/* a passenger linked list.                                                 */
/*                                                                          */
/****************************************************************************/
/*  Identifier Dictionary                                                   */
/*  cmd - character read in to identify command and function to perform     */
/*  GenList - the linked list class that contains all the nodes             */
/*                                                                          */
/****************************************************************************/
/* Development History                                                      */
/* 9/15: Program assigned, reviewed and studied linked lists                */
/* 9/20: Created design document and coded class                            */
/* 9/28: Program debugged, more revision                                    */
/*                                                                          */
/*                                                                          */
/*                                                                          */
/****************************************************************************/







#include "mp2.h"
/**********************************************************************************/
/* Int main basically opens a file and reads in the first character, then sets    */
/* up an end of file loop that determines what to do with the character, calling  */
/* functions and then repeating the process after the functions are done          */
/**********************************************************************************/

int main()
{

char cmd;
GenList list;

ifstream inFile;
ofstream outFile;

inFile.open("in.txt");
outFile.open("out.txt");


if (!inFile)
{
    cout << "Can't open infile!" << endl;
}

inFile >> cmd;

while (inFile)
{

if (cmd == 'F')
{
list.add_flight();
list.fReadData(inFile);
}

else if (cmd == 'P')
{
list.add_passenger(inFile, outFile);
list.pReadData(inFile);
}

else if (cmd == 'D')
{
list.delete_passenger(inFile, outFile);
}
else if (cmd =='L')
{
list.lookup_passenger(inFile, outFile);
}
else if (cmd == 'W')
{
list.print_passenger(inFile, outFile);
}
else if (cmd == 'A')
{
list.print_all(outFile);
}

inFile >> cmd;
}

cout << "Finished executing";
return 0;
}

