Table of Contents
Introduction
Features
Prerequisites
Installation
Usage
Configuration
Contributing
License
Contact
Introduction
This project demonstrates the integration of MassTransit with RabbitMQ in a .NET application. MassTransit is a popular distributed application framework for .NET, and RabbitMQ is a widely-used message broker. Together, they enable reliable and scalable messaging for distributed systems.

Features
MassTransit Integration: Easily connect and configure MassTransit with RabbitMQ.
Message Publishing and Consumption: Publish and consume messages using MassTransit and RabbitMQ.
Sample Projects: Includes sample projects to demonstrate basic usage.
Scalability: Designed for high scalability and reliability in distributed systems.
Prerequisites
.NET SDK (version 5.0 or later)
RabbitMQ Server (version 3.8 or later)
Installation
Clone the Repository

bash
Copy code
git clone https://github.com/Haseeb093/MassTransit-with-RabitMQ.git
cd MassTransit-with-RabitMQ
Restore Dependencies

bash
Copy code
dotnet restore
Build the Solution

bash
Copy code
dotnet build
Usage
Start RabbitMQ Server

Ensure RabbitMQ server is running locally. You can start it using Docker:

bash
Copy code
docker run -d --name rabbitmq -p 5672:5672 -p 15672:15672 rabbitmq:3-management
Run the Publisher

bash
Copy code
cd src/Publisher
dotnet run
Run the Consumer

bash
Copy code
cd src/Consumer
dotnet run
Configuration
Configuration settings for MassTransit and RabbitMQ can be found in the appsettings.json file in each project. Update the settings as needed to match your environment.

json
Copy code
{
  "RabbitMQ": {
    "Host": "localhost",
    "Username": "guest",
    "Password": "guest"
  }
}
Contributing
Contributions are welcome! Please follow these steps to contribute:

Fork the repository.
Create a new branch (git checkout -b feature-branch).
Make your changes.
Commit your changes (git commit -am 'Add new feature').
Push to the branch (git push origin feature-branch).
Create a new Pull Request.
License
This project is licensed under the MIT License. See the LICENSE file for details.

Contact
For any questions or feedback, please reach out to me at haeeb.shahid1@hotmail.com.
