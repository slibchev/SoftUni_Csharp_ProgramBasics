
string secretWord = string.Empty;

string input = Console.ReadLine();

int hiddenPass = 0;
//bool allDone = false;

int c = 0;
int n = 0;
int o = 0;


while (input != "End")
{

    char num = char.Parse(input);
    if (num >= 65 && num <= 90 || num >= 97 && num <= 122)
    {
        if (input == "c")
        {
            if (c == 0)
            {
                hiddenPass++;
                c++;
            }
            else if (c > 0)
            {
                secretWord += input;
            }
            if (hiddenPass % 3 == 0)
            {

                secretWord += " ";
                //hiddenPass = 0;
                c = 0; n = 0; o = 0;
            }

            //else
            //{
            //    hiddenPass++;
            //    c++;
            //}


        }
        else if (input == "n")
        {
            if (n == 0)
            {
                hiddenPass++;
                n++;
            }
            else if (n > 0)
            {
                secretWord += input;
            }

            if (hiddenPass % 3 == 0)
            {

                secretWord += " ";
                //hiddenPass = 0;
                c = 0; n = 0; o = 0;
            }

            //else
            //{
            //    hiddenPass++;
            //    n++;
            //}

        }
        else if (input == "o")
        {
            if (o == 0)
            {
                hiddenPass++;
                o++;
            }
            else if (o > 0)
            {
                secretWord += input;
            }
            if (hiddenPass % 3 == 0)
            {

                secretWord += " ";
                //hiddenPass = 0;
                c = 0; n = 0; o = 0;
            }

            //else
            //{
            //    hiddenPass++;
            //    o++;
            //}

        }
        else
        {
            

            if (hiddenPass % 3 != 0)
            {
                //secretWord = secretWord;
                secretWord += input;

            }
            else
            {
                secretWord = secretWord;
            }

            

        }


        //if (hiddenPass == 3)
        //{
        //    Console.WriteLine(secretWord);
        //    hiddenPass = 0;
        //    c = 0; n = 0; o = 0;
        //}


        input = Console.ReadLine();

        //if (input == "End")
        //{
        //    Console.WriteLine(secretWord);
        //    allDone = true;
        //}

    }
}
//if (allDone)
//{
    
//}
 //Console.WriteLine(secretWord);