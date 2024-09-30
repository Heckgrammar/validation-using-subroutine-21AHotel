namespace ValidationTask
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string firstName, lastName, username, password, emailAddress;
            int age;

            // get the user inputs until all are valid.
            // The username should only be output once
            Console.Write("Enter first name: ");
            firstName = Console.ReadLine();
            Console.Write("Enter last name: ");
            lastName = Console.ReadLine();
            string name = firstName + lastName;
            ValidName(name);
            Console.Write("Enter age: ");
            age = Convert.ToInt32(Console.ReadLine());
            ValidAge(age);
            Console.Write("Enter Password: ");
            password = Console.ReadLine();
            Console.Write("Enter email address: ");
            emailAddress = Console.ReadLine();
            


            if (ValidName = true);
            {
                if (ValidAge = true)
                {
                    username = createUserName(firstName, lastName, age);
                    Console.WriteLine($"Username is {username}, you have successfully registered please remember your password");
                }
            }

            //  Test your program with a range of tests to show all validation works
            // Show your evidence in the Readme

        }
        static bool ValidName(string name) //i think im done
        {
            //name = firstName + lastName;
            int nameLength = name.Length;
            while (nameLength >= 2)  //name must be at least two characters
            {
                while (name.All(char.IsLetter))  //contain only letters
                {
                    return true;
                }
            }
            return false;
        }

        static bool validAge(int age)  //DONEEE
        {
            //age must be between 11 and 18 inclusive
            while (age >= 11 && age <= 18)
            {
                return true;
            }
            return false;
        }


        static bool ValidPassword(string password)
        {
            int passwordLength = password.Length;
            bool lowerCaseCheck = password.Any(char.IsLower);
            bool upperCaseCheck = password.Any(char.IsUpper);
            bool nonLettersCheck = password.All(char.IsLetter);
            while (passwordLength >= 8)  // Check password is at least 8 characters in length //done
            {
                while (lowerCaseCheck == true && upperCaseCheck == true && nonLettersCheck == false)  // QWErty%^& = validCheck password contains a mix of lower case, upper case and non letter characters //done
                                                                                                      // QWERTYUi = not valid
                                                                                                      // ab£$%^&* = not valid
                                                                                                      // QWERTYu! = valid
                {
                    // while()
                    {
                        // Check password contains no runs of more than 2 consecutive or repeating letters or numbers //COME BACK TO MEEEE
                        // AAbbdd!2 = valid (only 2 consecutive letters A and B and only 2 repeating of each)
                        // abC461*+ = not valid (abC are 3 consecutive letters)
                        // 987poiq! = not valid (987 are consecutive)
                        // Iterate for every index and
                        // check for the condition

                        //for (int i = 1; i < l; i++)
                        //{

                        //    // If are not consecutive
                        //    if (s[i] - s[i - 1] != 1)
                        //        return false;
                        //}
                    }
                }



            }
            static bool validEmail(string email)  //come back to meeee
            {
                // a valid email address
                // has at least 2 characters followed by an @ symbol
                // has at least 2 characters followed by a .
                // has at least 2 characters after the .
                // contains only one @ and any number of .
                // does not contain any other non letter or number characters
                string shortenedEmail1 = email.Substring(2, email.Length - 1);
                char searchKey = '@';
                bool followedByAnAt;
                int atIndex = (shortenedEmail1.IndexOf('@', 0, shortenedEmail1.Length));
                string shortenedEmail2 = shortenedEmail1.Substring(atIndex, (email.Length - 1));
                for (int i = 0; i < shortenedEmail1.Length; i++)
                {
                    if (shortenedEmail1[i] == searchKey)
                    {
                        followedByAnAt = true;
                    }
                }
                while (email.Substring(0) != "@" && email.Substring(1, 1) != "@")
                {
                    while (followedByAnAt = true)
                    {
                        while (shortenedEmail2.Substring(0) != '.' && shortenedEmail2.Substring(1, 1)  '.' );
                    
                
            static string createUserName(string firstName, string lastName, int age)  //DONEEEE
            {
                // username is made up from:
                string firstTwoLetters = firstName.Substring(1);  // first two characters of first name
                int lastNameLength = lastName.Length - 1;
                string lastTwoLetters = lastName.Substring((lastNameLength - 1), lastNameLength);  // last two characters of last name
                string userName = (firstTwoLetters + lastTwoLetters + age); // age
                                                                            //e.g. Bob Smith aged 34 would have the username Both34
                return userName;


            }

        }
    }
}
