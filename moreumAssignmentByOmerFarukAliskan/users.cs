using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace moreumAssignmentByOmerFarukAliskan
{
    public class users
    {
        string ID, name, surname, bill;
        public users(string csvRow) // -1
        {
            string[] userData = csvRow.Split(';');
            this.ID = userData[0];
            this.name = userData[1];
            this.surname = userData[2];
            this.bill = userData[3];
        }

        public string getName() { return this.name; }
        public string getSurname() { return this.surname; }
        public string getID() { return this.ID; }
        public string getBill() { return this.bill; }
    }
}

/* I did not wanted to pass 4 string data to the setter func
 * Since all the users must get their data from the csv file and each line of the csv file represent one unique user 
 * Rather then parsing the line's data in main programme I refer to do the parsing and assigning data of an user inside of the structre 
 * One of the other reason that i beileve it would be right to do was encapsulation principle.
*/
