ECHO OFF
C:\Windows\Microsoft.NET\Framework\v4.0.30319\csc -out:.\ComputerStore.exe .\Client.cs .\ComputerStore.cs
.\ComputerStore.exe
del .\ComputerStore.exe
PAUSE