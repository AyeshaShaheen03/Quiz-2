using System;

namespace Quiz
{
    class Program
    {
        static void Main(string[] args)
        {
           tutorial Object1 = new tutorial();
           Object1.tutorialID= 1;
           Object1.tutorialName= "c#";
           Object1.introduce();
           tutorial Object2 = new tutorial();
           Object2.tutorialID= 2;
           Object2.tutorialName= "ASP.Net";
           Object2.introduce();
           tutorial Object3 = new tutorial ();
           Object3.tutorialID= 3;
           Object3.tutorialName= "VB.Net";
           Object3.introduce();
          


        }
    }
}
