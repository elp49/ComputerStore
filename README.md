# ComputerFactory

ComputerFactory is a program designed to allow a computer store maintain and
modify their families of computers; it is a solution to the problem described
below.

"A computer store needs stand-alone software that keeps track of computer
inventory, which includes computers and different computer parts made by
different hardware manufacturers. The software for the computer store needs
capabilities for displaying information about computer parts, including
information from the manufacturer’s site and various other sites that contain
customer satisfaction reviews and other relevant information. Therefore, each
computer part object needs to be capable of extracting information in real time
from a list of predefined remote locations, of aggregating the information, and
of providing this information upon request. Upon requesting the information for
a particular computer, all computer part objects communicate over the network
and find out the latest comments and statistics about a component from all
predefined sources and make this information available to the requesting object.
Initially, the store supports only two types of computers: standard computers
and advanced computers, composed of standard and advanced computer parts (i.e.,
CPU, monitor, and mouse), respectively. Due to store policy, standard computers
cannot be composed of advanced computer parts and advanced computers cannot be
composed of standard computer parts. The software solution needs to provide a
maintainable and modifiable design for creating these families of objects, to
support easy addition of new families of computers, and to promote consistency
with computer products." (179)

Otero, Carlos E. "Abstract Factory." Software Engineering Design: Theory and
	Practice. Boca Raton: Taylor & Francis Group, LLC, 2012. 179. Print.

## Usage

You may run the program using an IDE like Visual Studio or by running the
provided batch file "RunComputerStore.bat". The batch script will compile and
execute the program, and then delete the outputted executable file.

Note: The batchfile uses "C:\Windows\Microsoft.NET\Framework\v4.0.30319\csc" to
compile the program. If this compiler is not on your machine, you may use
another version to compile or download the full Microsoft .NET Framework 4 here
at https://www.microsoft.com/en-us/download/details.aspx?id=17851.
