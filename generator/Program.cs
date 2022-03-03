using System;
using System.IO;

class program
{
      
    static void Main(string[] args)
    {
        int [] rnd_size = {10,20,30,40};
        Random rnd = new Random();

        for(int i = 0; i < rnd_size.Length; i++)
        {

            string s = "number-gen" + rnd_size[i] + ".txt";
            
            StreamWriter sw = new StreamWriter(s);
            sw.WriteLine(rnd_size[i]);
            for(int j = 0; j < rnd_size[i]; j++) 
            {   
                int r = rnd.Next(0, 100000); 
                sw.WriteLine(r);
                

            }
            sw.Close();
        }
        
    }
}
