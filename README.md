# Friend Letter Project

#### By _**Dani Steely; with the assistance of Cameron Abel**_

#### _Simple C# project for Epicodus to practice making basic Web Applications using MVC pattern_

## Technologies Used

* _C#_
* _.NET_
* _Kestrel_

## Description

_This project was created from a [class lesson](https://www.learnhowtoprogram.com/c-and-net-part-time/c-web-applications/constructing-and-configuring-an-asp-net-core-mvc-web-app) on "Constructing and Configuring an ASP.NET Core MVC Web App._

## Setup/Installation Requirements

* _this repo is for class purposes only_
* _if you are interested in setting up this project_
* _navigate to the link in the description for a full walkthrough or for a link to the original repo_

## License

_MIT License_

Copyright (c) _2/12/23_ _Dani Steely_
Co-authored-by: Cameron Abel 

<!-- Without configuration, when we run our applications with dotnet run or dotnet watch run, they automatically are run in "production" mode, which includes the code, resources, and optimizations for our web apps to be hosted online and available for public use.

To run our application in development mode, we simply need to add a flag to our dotnet run command:

dotnet run --environment Development
When we do this, we'll see our environment confirmed in the terminal output. Notice "Hosting environment: Development" in the output below. 

However, there's an even better option for us than adding the command line flag --environment Development to run our apps in development mode: we can create a file called launchSettings.json that contains information about what environment we want our project to be run.-->
<!-- 

RE launch Settings.json
Going forward, we'll use a Properties/launchSettings.json file in all of our ASP.NET Core projects. Because of this, take note of a few important usage notes:

The contents of the launchSettings.json file will be the same in all of our ASP.NET Core projects in LearnHowToProgram.com.
You are welcome to configure the settings in launchSettings.json as you see fit, or just use the default configurations provided above.
According to the MS Docs launchSettings.json is only used on the local development machine and should not be deployed. In other words, it's for development only. -->

<!-- Issuing and Trusting a Security Certificate
For HTTPS to work, we need to have a security certificate set up for our web apps. The security certificate is a digital certificate that verifies the identity of a website and handles encrypting the data that's transferred between the website ("client") and the web server ("server"). These certificates are issued by certification authorities and follow specific protocols for encryption (see SSL and TLS for more information).
The good thing to note is that it's very easy to fix this issue. Simply open your terminal and enter the following command:

$ dotnet dev-certs https --trust
Note that if you are taking classes in person at Epicodus, you do not need to run this command on the campus mac computers.
Don't Have a Security Certificate?
Not having a certificate at all is extremely unlikely. You'll know you don't have a security certificate, because you won't be able to access localhost via HTTPS at all. In this case, to generate a security certificate, run the following command:

$ dotnet dev-certs https
And then trust the certificate with this command:

$ dotnet dev-certs https --trust
You can also clear all existing certificates and check whether you have one issued to begin with. To see all possible commands and tools for dev-certs, enter the following command into your command line:

$ dotnet dev-certs https --help -->