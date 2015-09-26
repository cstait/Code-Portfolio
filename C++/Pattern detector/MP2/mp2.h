#include <iostream>
#include <iomanip>
#include <cstring>
#include <fstream>
using namespace std;


struct passengerNode {
string flightNo;
string passId;
string passName;
string passLast;
char sex;
char classType;
string seatNo;
passengerNode *next = 0;
};

typedef passengerNode *pNodePtr;

struct flightNode {
string pilotName;
string pilotLastName;
string  coPilotName;
string coPilotLastName;
string flightNo;
string deptTime;
string arriTime;
int capacity;
string origin;
string destin;
pNodePtr pLink = 0;
flightNode *next = 0;
};

typedef flightNode *fNodePtr;

class GenList{
public:
GenList( );
void fReadData(ifstream& input);
void pReadData(ifstream& input);
void add_flight();
void delete_flight();
void add_passenger(ifstream& input, ofstream& output);
void delete_passenger(ifstream& input, ofstream& output);
void lookup_passenger(ifstream &input, ofstream&output);
void print_passenger(ifstream& input, ofstream& output);
void print_all(ofstream& output);

private:
flightNode *fCurPos;
flightNode *fNodePtr;
passengerNode *pNodePtr;
passengerNode *pCurPos;
passengerNode *pPrevious;
string pFlightNo;
string pId;
string pName;
string temp;
bool found;
};
/****************************************************************************/
/* Default constructor sets pointer values to null                          */
/****************************************************************************/

GenList::GenList()
{
pNodePtr = 0;
pCurPos = 0;
fNodePtr = 0;
fCurPos = 0;
found = false;
pPrevious = 0;
}





/****************************************************************************/
/* Checks to see if root pointer has a node, if not creates one, otherwise  */
/* cycles through the node looking for an empty link to create a new flight */
/* node                                                                     */
/****************************************************************************/



void GenList::add_flight()
{


if (fNodePtr == 0)
{
    fNodePtr = new flightNode;
    fCurPos = fNodePtr;
    fCurPos->next = 0;
    cout << "fCurPos is now fnodePTR" << endl;
}

else
{
fCurPos = fNodePtr;
while (fCurPos->next != 0)
{
    fCurPos = fCurPos->next;
}
fCurPos->next = new flightNode;
fCurPos = fCurPos->next;
fCurPos->next= 0;
cout << "fCurPost is a new node";
cout << fCurPos->flightNo << endl;
}


}

/****************************************************************************/
/* Reads the input from the data file into the currently pointed to node    */
/****************************************************************************/



void GenList::fReadData(ifstream &input)
{
input >> fCurPos->pilotName;
input >> fCurPos->pilotLastName;
input >>fCurPos->coPilotName;
input >>fCurPos->coPilotLastName;
input >>fCurPos->flightNo;
input >>fCurPos->deptTime;
input >>fCurPos->arriTime;
input >> fCurPos->capacity;
input >>fCurPos->origin;
input >>fCurPos->destin;

if (fCurPos->destin == "Ann")
 {
     input >> temp;
     fCurPos->destin = fCurPos-> destin + " " + temp;
 }

cout << fCurPos->pilotName;
cout << fCurPos->pilotLastName;
cout <<fCurPos->coPilotName;
cout <<fCurPos->coPilotLastName;                        //Debugging tools to show where the program crashes at
cout <<fCurPos->flightNo;
cout <<fCurPos->deptTime;
cout <<fCurPos->arriTime;
cout << fCurPos->capacity;
cout <<fCurPos->origin;
cout <<fCurPos->destin;

cout << "Read Data" << endl;
}


/****************************************************************************/
/* First searches for the same flight as the passenger then once it has     */
/* found the flight it looks for an empty passenger node to insert a new    */
/* node into and sets the pointer to it                                     */
/****************************************************************************/


void GenList::add_passenger(ifstream& input, ofstream& output)
{
input >> pFlightNo;
cout << pFlightNo << endl;
fCurPos = fNodePtr;

while (fCurPos->next != 0)
{
    if (fCurPos->flightNo == pFlightNo)
        break;
    else
        fCurPos = fCurPos->next;
}

if (fCurPos->pLink == 0)
{
     fCurPos->pLink = new passengerNode;
     pCurPos = fCurPos->pLink;
}
else
{
    pCurPos = fCurPos ->pLink;
    while (pCurPos->next != 0)
    {
        pCurPos = pCurPos->next;
    }
    pCurPos->next = new passengerNode;
    pCurPos = pCurPos->next;
}


}

/****************************************************************************/
/* reads passenger data into the currently pointed node                     */
/****************************************************************************/

void GenList::pReadData(ifstream& input)
{

pCurPos->flightNo = pFlightNo;
input >> pCurPos->passId;
input >> pCurPos->passName;
input >> pCurPos->passLast;
input >> pCurPos->sex;
input >> pCurPos->classType;
input >> pCurPos->seatNo;
fCurPos->capacity -= 1;

cout << pCurPos->flightNo;
cout << pCurPos->passId;
cout << pCurPos->passName;
cout << pCurPos->passLast;
cout << pCurPos->sex;
cout << pCurPos->classType;
cout << pCurPos->seatNo;

cout <<"Read passenger data" << endl;


}

/****************************************************************************/
/* Searches the node for the flight number first by comparing it with the   */
/* passenger, and then searches the passenger list, deleting if it found it */
/****************************************************************************/

void GenList::delete_passenger(ifstream& input, ofstream& output)
{
input>>pFlightNo;
input>>pId;
input>>pName;
input.ignore(50, '\n');
found = false;


fCurPos = fNodePtr;

while ((fCurPos->next != 0))
{
if (fCurPos->flightNo == pFlightNo)
{
found = true;
break;
}
else
{
fCurPos = fCurPos->next;
}
}

if (found == true)
{
pCurPos = fCurPos->pLink;
pPrevious = pCurPos;

while (pCurPos->next != 0)
{
if ((pCurPos->passId == pId) && (pCurPos->flightNo == pFlightNo))
{
pPrevious->next = pCurPos->next;
delete pCurPos;
output << endl << "Delete successful!" << pId << " " << pName << " " << pFlightNo << endl;
fCurPos->capacity += 1;
found = true;
break;
}
else
{
pPrevious = pCurPos;
pCurPos = pCurPos -> next;
}
}

found == false;

}

if (found == false)
{
    output << endl << "Could not find passenger to delete on selected flight. " << pId << " " << pName << pFlightNo << endl;
}



else
{
 output << endl << "Could not delete passenger because flight or passenger does not exist!" << pId << " " << pName << " " << pFlightNo << endl << endl;
}
}


/****************************************************************************/
/* Similar to delete, instead of deleting the passenger, it tells the output*/
/* if the person was found or not                                           */
/****************************************************************************/

void GenList::lookup_passenger(ifstream &input, ofstream&output)
{
input>> pFlightNo;
input>> pId;
input>> pName;
input.ignore(80, '\n');

found = false;
fCurPos = fNodePtr;

while ((fCurPos->next != 0) && (found == false))
{
if (fCurPos->flightNo == pFlightNo)
{
found = true;
}
else
{
fCurPos = fCurPos->next;
}
}

if (found == true)
{
pCurPos = fCurPos->pLink;

if ((pCurPos->passId == pId) && (pCurPos->passName == pName))
{
output << endl << pCurPos->passName << " was found on flight " <<
pCurPos->flightNo << endl;
}
else
{


while (pCurPos->next != 0)
{
if ((pCurPos->passId == pId) && (pCurPos->passName == pName))
{
output << endl << pCurPos->passName << " was found on flight " <<
pCurPos->flightNo << endl;
break;
}
else
{
pCurPos = pCurPos -> next;
}
}



}
}
if (found == false)
{
output << endl << "Could not find passenger " << pName << " on any flights, sorry. " << endl;
}
}


/****************************************************************************/
/* Searches for the flight nodes then cycles through the passenger list     */
/* sending them to the output file                                          */
/****************************************************************************/

void GenList::print_passenger(ifstream& input, ofstream& output)
{
input >> pFlightNo;
found = false;

fCurPos = fNodePtr;

while ((fCurPos != NULL) && (found == false))
{
if (fCurPos->flightNo == pFlightNo)
{
found = true;
}
else
{
fCurPos = fCurPos->next;
}
}

if ((found == true) && (fCurPos->pLink != 0))
{
pCurPos = fCurPos->pLink;
output << "Display all passengers for flight: " << pCurPos->flightNo << " Current Flight Capacity: " << fCurPos->capacity << endl;
output << endl <<"***************************************************************" << endl;
while (pCurPos != 0)
{

output << "Passenger Name: " << pCurPos->passName << " " << pCurPos->passLast << endl;
output << "Passenger ID: " << pCurPos->passId << endl;
output << "Passenger Gender: " << pCurPos->sex << endl;
output << "Passenger Class: " << pCurPos->classType << endl;
output << "Passenger Seat #: " << pCurPos->seatNo << endl << endl;
pCurPos = pCurPos->next;
}

output << endl <<"***************************************************************" << endl;
}
else
{
output << endl << "There are no passengers on record for flight "<<
pCurPos->flightNo << endl;
}
if (found == false)
{
output << "Sorry could not find flight " << pFlightNo << endl;
}

cout << "Printed Passenger" << endl;
}




/****************************************************************************/
/* Loops through each flight node, and within each flight node loopsthrough */
/* the passenger nodes printing their information                           */
/****************************************************************************/


void GenList::print_all(ofstream& output)
{
fCurPos = fNodePtr;
pCurPos = fCurPos->pLink;




while (fCurPos != 0)
{
output << "Display all passengers for flight: " << fCurPos->flightNo << " Current Flight Capacity: " << fCurPos->capacity << endl;
output << endl <<
"***************************************************************" << endl;

while (pCurPos != 0)
{
output << "Passenger Name: " << pCurPos->passName << " " << pCurPos->passLast << endl;
output << "Passenger ID: " << pCurPos->passId << endl;
output << "Passenger Gender: " << pCurPos->sex << endl;
output << "Passenger Class: " << pCurPos->classType << endl;
output << "Passenger Seat #: " << pCurPos->seatNo << endl << endl;
if (pCurPos->next != 0)
pCurPos = pCurPos->next;
else
    break;
}

if (fCurPos->next !=0)
{
  fCurPos = fCurPos->next;
pCurPos = fCurPos->pLink;
}
else
    break;

}

cout << "Printed All" << endl;











}
