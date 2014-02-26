﻿Golem Overview
====================

##Event driven WebDriver C# Framework

Golem is an event-driven automation testing framework written in C# that was created to simplify the design of enterprise-scale automation test suites. 
It wraps around Selenium-WebDriver and Gallio/MbUnit to provide the tester with a more robust, flexible framework than would be possible by using either 
application alone. The inclusion of diagnostic features, an intelligently designed library, and enhanced API's helps Golem address issues currently 
overlooked by Selenium and Gallio. A standard test structure is enforced throughout the Golem framework to make the code readable and easy to reuse. 

The Golem repository contains several modules that can be installed in conjunction with Golem Core to perform browser-based testing (Golem.WebDriver), 
create automated test scripts for Windows desktop applications (Golem.White), and use an API built on top of RestSharp to execute and validate REST 
requests (Golem.Rest). 

For all documentation, visit the [Golem Wiki](https://github.com/ProtoTest/ProtoTest.Golem/wiki).



##How to Get Started

1) Install the ProtoTest.Golem Nuget package into a C# project. This sets up Selenium and WebDriver along with the Golem framework.		

2) Take a look at the [Golem.Core documention](https://github.com/ProtoTest/ProtoTest.Golem/wiki/Golem.Core,-Setup) for an overview of the framework.

3) Golem includes modules for testing web sites, REST api's and desktop applications. Take a look at the respective documentation to get started with each.
* For web sites, use [Golem.WebDriver](https://github.com/ProtoTest/ProtoTest.Golem/wiki/Golem.WebDriver,-Getting-Started). 
* For RESTful services, use [Golem.Rest](https://github.com/ProtoTest/ProtoTest.Golem/wiki/Golem.Rest,-Getting-Started). 
* For desktop applications, use [Golem.White](https://github.com/ProtoTest/ProtoTest.Golem/wiki/Golem.White,-Getting-Started).


