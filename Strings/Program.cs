using System;
using System.Linq;

namespace String_class
{
    class Program
    {
        static void Main(string[] args)
        {

            #region 1task
            /*string[] arr = new string[] {"One","Two","Three","Four","Five","Six","Seven","Eight" };
            var temp="";
            for (int j = 1; j < arr.Length; j++)
            {
                for (int i = 0; i < arr.Length - j; i++)
                {                   
                    if (String.Compare(arr[i], arr[i + 1]) > 0)
                    {
                        temp = arr[i];
                        arr[i] = arr[i + 1];
                        arr[i + 1] = temp;
                    }
                }
            }            
            foreach (var i in arr)
            {
                Console.WriteLine($"{i}");
            }*/
            #endregion

            #region 2task
            /*Console.WriteLine("Enter a string of words:");
            string words = Console.ReadLine();
            string[] array = new string[] { };
            array = words.Split(" ");            
            Array.Reverse(array);
            Console.WriteLine(string.Join(" ", array));*/
            #endregion

            #region 3task           
            /*string words = (" . Enter a string . of words . Enter ");
            int first = words.IndexOf('.');
            int second = words.IndexOf('.', first + 1);
            for (int i = first+1; i < second; i++)
            {
                if (words[i]==' ')
                {
                    words=words.Remove(i, 1);
                    i--;
                    second--;
                }
            }
            Console.WriteLine($"New text: {words}");*/
            #endregion

            #region 4task
            /*Console.WriteLine("Enter something");
            string words = Console.ReadLine();
            bool palindrome = true;
            for (int i = 0; i < words.Length-1; i++)
            {
                int k = words.Length - 1 - i;
                if (words[i] != words[k])
                {
                    palindrome = false;
                }
            }
            if (palindrome)
            {
                Console.WriteLine("Its a palindrome");
            }
            else
            {
                Console.WriteLine("Its not a palindrome");
            }*/
            #endregion

            #region 5task
            /*Console.WriteLine("Enter a string of words:");
            string words = Console.ReadLine();
            string[] array = new string[] { };
            array = words.Split(new char[] {',','.',' ','!','?' },StringSplitOptions.RemoveEmptyEntries);
            Console.WriteLine("\nEnter a number of word:");
            int a = Int32.Parse(Console.ReadLine());
            Console.WriteLine($"First symbol of your word: {array[a-1].Remove(1)}");*/
            #endregion

            #region 6task

            /*string words = "1 22 333 4444 55555 666666 7777777 88888888";
            string[] array = new string[] { };
            array = words.Split(new char[] {',','.',' ','!','?' },StringSplitOptions.RemoveEmptyEntries);
            Again:
            Console.WriteLine("Enter length of words >3:");
            int length = Int32.Parse(Console.ReadLine());
            if (length<3)
            {
                Console.WriteLine("Error!");
                goto Again;
            }
            for (int i = 0; i < array.Length; i++)
            {
                if (array[i].Length == length)
                {
                    array[i]=array[i].Remove(array[i].Length - 3)+ "$$$";
                }
            }        
            Console.WriteLine($"New string: {string.Join(' ', array)}");*/

            #endregion

            #region 7task
            /*string words = "Its a Simple Text For TASK - tututu.";
            double lowl=0, upl=0;
            for (int i = 0; i < words.Length; i++)
            {
                if (Char.IsUpper(words[i]))
                {
                    upl++;
                }
                else if (Char.IsLower(words[i]))
                {
                    lowl++;
                }
            }            
            Console.WriteLine($"Percent of upper letters:{upl/(lowl+upl)*100:f2}%\t lower letters:{(lowl/(lowl+upl))*100:f2}%");
            */
            #endregion

            #region 8task
            /*char[,] matrix = new char[5,5] {   {'a','r','c','d','w' },
                                               {'w','o','r','l','o' },
                                               {'k','w','e','f','r' },
                                               {'n','b','d','m','l' },
                                               {'w','o','r','l','d' } };
            string find = "world";
            int iter=0;

            for (int i = 0; i < matrix.GetLength(0); i++)
            {
                int k = 0;
                for (int j = 0; j < matrix.GetLength(1); j++)
                {
                    if (matrix[i,j]==find[k])
                    {
                        k++;
                    }
                    else
                    {
                        k = 0;
                    }
                    if (k==find.Length)
                    {
                        Console.WriteLine($"Word ad row {i+1} column {j-k+2}");
                        k = 0;
                    }
                }
            }
            for (int i = 0; i < matrix.GetLength(1); i++)
            {
                int k = 0;
                for (int j = 0; j < matrix.GetLength(0); j++)
                {
                    if (matrix[j, i] == find[k])
                    {
                        k++;
                    }
                    else
                    {
                        k = 0;
                    }
                    if (k == find.Length)
                    {
                        Console.WriteLine($"Word ad row {i - k + 2} column {j+1}");
                        k = 0;
                    }
                }
            }*/
            #endregion

            #region 9task
            /*string words = "  It's   a sentence   for   test working   this   program   ";
            string[] array = new string[] { };
            array = words.Split(new char[] { ',', '.', ' ', '!', '?' }, StringSplitOptions.RemoveEmptyEntries);
            Console.WriteLine($"'{string.Join('*',array)}'");*/
            #endregion

            #region 10task
            /*string words = "It's a asantenca for test working this program";
            string[] array = new string[] { };
            array = words.Split(' ');
            string largestword="a"; int i = 0;
            foreach (var a in array)
            {
                if (largestword.Length<a.Length)
                {
                    largestword = a;
                    i++;
                }
            }
            largestword = largestword.Replace('a', 'b');
            array[i] = largestword;
            Console.WriteLine($"'{string.Join(' ', array)}'");*/
            #endregion

            #region 11task
            /*string words = "1 for 5 test 3,5 working 9 this 2,1 program 4,46";
            string[] array = words.Split();
            string intwords = "";
            string floatwords = "";
            string textwords = "";
            foreach (var item in array)
            {
                if (int.TryParse(item, out var j))
                {
                    intwords += j + " ";
                }
                else if (float.TryParse(item, out var k))
                {
                    floatwords += k + " ";
                }
                else
                {
                    textwords += item + " ";
                }                               
            }          
            Console.WriteLine($"int-{intwords} | float-{floatwords} | text-{textwords}");*/
            #endregion

            #region 12task
            /*string words = "It's a sеntencе for test working this program";            
            var array = words.Split(' ').Where(l=>l.Length > 5);
            Console.WriteLine($"'{string.Join(' ', array)}'");*/
            #endregion

            #region 13task
            /*string fnum = "215065551";
            string snum = "550994232";
            Int32.Parse(fnum);
            Int32.Parse(snum);            
            Console.WriteLine($"{Int32.Parse(fnum)+Int32.Parse(snum)}");*/
            #endregion

        }
    }
}
