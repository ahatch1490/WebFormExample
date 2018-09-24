# WebFormExample
Example of using Moxiworks.PlatForm in a WebForm 

Need to include the following in the web.config application section:
```
<appSettings>
    <add key="Secret" value="sercret here" /> <! --- Add your MoxiWorks secret --> 
    <add key="Identifier" value="identifier here" /> <!-- Add your MoxiWorks identifier -->
    <add key ="CompanyId" value="company id here"/> <!-- Add the ID of your company with in the api we use this to get all the agents --> 
</appSettings>
```
