using System;
using System.Text;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text.RegularExpressions;

class FindMax {

    static void Main(String[] args) {
        int n = Convert.ToInt32(Console.ReadLine());
        
        string newText = "min(int, int)";           //Default 
        int count = 2;
        while(count < n){
            newText = newText.Remove(newText.LastIndexOf("int"), 3).Insert(newText.LastIndexOf("int"), "min(int, int)");
            count++;
        }
        Console.WriteLine(newText);
    }
}