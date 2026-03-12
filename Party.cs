namespace knightmoves;
public class Party
{
    // Add your code here
    public class Person{
        public string firstName;
        public string lastName;

        public Person(string firstName, string lastName){
            this.firstName = firstName;
            this.lastName = lastName;
        }
    }

    public class Event{
        public static Person[] Guests = new Person[3];
    }

    
}
