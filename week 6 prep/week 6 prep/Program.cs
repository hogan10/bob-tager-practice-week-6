using System;
using System.Text;

namespace week_6_prep
{
    class Program
    {
        static void Main(string[] args)
        {
            //string myString = "My \"so-called\" life";
            //string myString = "What if I need a\nnew line?";
            //string myString = "What if I need a " + Environment.NewLine + "new line.");
            //string myString = "go to your c:\\drive ";
            //string myString = @" go to your c:\drive"; --> NOTE the @ symbol will not work to allow quotes like the first example above
            //string myString = String.Format("{0} = {1}", "First", "Second");
            //string myString = string.Format("{0:C}", 123.45);  --> NOTE whenever you put in a colon you are telling it to format in someway. . this is saying take this variable and turn it into a currency format
            //OR with string interpolation --> string myString = $"{123.45:C}";
            //string myString = string.Format("{0:N}", 1234567890);
            //string myString = string.Format("{0:P}", .123);
            //string myString = string.Format("Phone Number: {0:(###) ###-####}", 1234567890);


            //string myString = " That summer we took threes across the board ";

            //below if you want to take out the word "took"
            //var start = myString.IndexOf("took");
            //var end = "took".Length;
            //myString = myString.Subtring(start, end);

            //below are other methods besides format that are very common
            //myString = myString.Substring(6, 14); --> go six in and take 14 characters
            //myString = myString.ToUpper(); --> all uppercase, ToLower forces to lower case
            //myString = myString.Replace(" ", "--"); --> find this string and replace it with this string 
            //myString = myString.Remove(6, 14); --> this removes an exact position from string

           //another way to remove (we want to replace the word took):
           //myString = myString.Replace("took", ""); --> this replaces took with nothing which basically removes it

            /*
            myString = string.Format("Length before: {0} -- Lengthe after: {1}",
                myString.Length,
                myString.Trim().Length);
                */  //TRIM takes the beginning and ending spaces off

            /*
            string myString = " ";
            for (int i = 0; i < 100; i++)
            {
                myString += "--" + i.ToString(); ALSO THE SAME AS --> myString = myString + "--" + i;
            }
            */

            //if you build a program that has millions of lines of string - using the above would start to slow you down. StringBuilder = every time you do append it makes your string a little longer. It isn't constantly making new copies.
            //you would actually never notice the difference unless you are working with mass amounts of data 

            StringBuilder myString = new StringBuilder();

            for (int i = 0; i < 100; i++)
            {
                myString.Append("--");
                myString.Append(i);
            }
              Console.WriteLine(myString);
            Console.ReadLine();
        }
    }
}
