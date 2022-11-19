// See https://aka.ms/new-console-template for more information

string [] baseArray = new string [7] {"2", "monday", "try", "it", "three", "2542", "now"};

string [] emptyArray = new string[] { };

string [] selection (string [] baseArray, string [] emptyArray, int a = 3)
{


    for (int i = 0; i< baseArray.Length; i++)
    {
        for (int j = 0; baseArray[i].Length<=a; j++)
        {
            emptyArray[j] = baseArray[i];
        }
       
    }
return emptyArray;
        
}

 Console.Write(selection(baseArray, emptyArray, 3));