The following factors have been fulfilled in this application:

1. Codebase:          Github has been used as Codebase for simplicity, however for more advanced usage, Azure DevOps would be used for better CI/CD.

2. Dependencies:      The dependencies and frameworks used for the project are stored in the .csproj file which is used to open the project itself.
                      It contains data like: (PackageReference Include="Npgsql" Version="6.0.7")
               
3. Config:            The launchsettings.json stores any kind of data used further in the runtime. Such as port, urls and other information.

4. Backing Services:  As a simple backing service, we use a Postgres Database 

6. Processes:         Since this app is an Web Application, the calling thread is blocked until host shutdown, which would be the closing of the local Webpage and 
                      since it is stateless, instances can be added and removed.
                      
7. Port Binding:      This app runs on docker containers and is using the default port 5432, if multiple databases or services would be used, more ports would need to be
                      bound to other ports.
                      
9. Disposability:     This app has simple execute and shutdown methods which are straightforward and used in the most minimalistic manner possible.

11. Logs:             For logging I used the Microsoft Interface called ILogger. Logging is used to store data in cases of errors, crashes and conflicts to determine 
                      possible causes or store data for customers with specialized wishes.
