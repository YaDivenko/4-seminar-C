﻿int [] arr = new int [8];
Random Rnd = new Random ();


for (int i = 0; i < arr.Length; i++)
{
    arr [i] = Rnd.Next (100);
}

for (int i = 0; i < arr.Length; i++)
{
    System.Console.Write(arr [i] + " ");
}