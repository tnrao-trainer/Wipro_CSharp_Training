using System;

public class Program
{
    public static void Main(string[] args)
    {
        int n = 4;
        int len =  2*n-1;
        int row = 0, col =0;
        int x;
    
    for(int i=0;i<n*2-1;i++)
    {
        for(int j=0;j<2*n-1;j++)
        {
            if( i > n-1)   
                row = len-1-i;
            else   
                row = i;
            
            if(j>n-1 ) 
                col =  len-1-j;
            else 
                  col =  j;
            
            if( row < col) 
                x = row;
            else 
                x =  col;
            
            Console.Write("{0} \t",n-x);
        }
        Console.WriteLine();
    }
    
    
 }
}