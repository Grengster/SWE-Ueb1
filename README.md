# SWE-Ueb1

For this ASP.NET Core-Web-API we need following tools and software: 
1. PostgreSQL 10 or later
2. Docker with LINUX Containers
3. Visual Studio 2022


To run the Postgres image, we need to pull the latest image:

docker pull postgres

Then we run the container with this command:

docker run -d -e POSTGRES_USER=admin -e POSTGRES_PASSWORD=test1 --name db-my -p 5432:5432  postgres

Now the container should be running and is accessible with any IDE for managing databases, I used the free software: DBeaver.
