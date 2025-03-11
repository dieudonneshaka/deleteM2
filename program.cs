using System;
using Microsoft.AspNetCore.Builder;
public class program {

    // VSCODE
        public static void main(string[] args) {
            System.Console.WriteLine("starting");

            // CreateBuilder create a builder (a factor)
            var bulder = WebApplication.CreateBuilder();

            // Builder. build creates a web app

            var webapi = bulder.build();

            webapi.run();


            Console.WriteLine("Ending");


            
            // After that we can use  the bulder to create the web service

    }
}