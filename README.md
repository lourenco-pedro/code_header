# code_header
Add owner headers to your files using CodeHeader
 
 ## How to use it

In your command line, just go to the code_header folder and then type the follwing command

````cs
dotnet run rootFolderPath desiredExtensionToModify headerTemplatePath
````

Where:

**rootFolderPath** is going to be the root folder where all the desired files will be located<br>
**desiredExtensionToModify** is going to be the desired extension you want code_header seek for to add the header, it is not necessary to add the '.'(period) before file extension type.<br>
**headerTemplatePath** is going to be the path of the header template file.there is already a header.txt inside the code_header folder, where you can use it.  
