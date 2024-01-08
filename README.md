HEIGHTS BOOK HUB
The Heights Book Hub is an online bookstore that serves as a centralized repository for managing and organizing information about the available books.
The system is built using C#, Asp.Net for API development and RabbitMQ for messaging. For API development, C# AND Asp.Net were chosen to create robust and scalable RESTful API. The APIs include operations such as fetching the list of books, details of a specific book, placing an order, and checking order status. This decision was made to facilitate standard communication protocols, allowing clients to interact with the bookstore's services seamlessly.
RabbitMQ was chosen as the messaging broker to handle communication between the order processing service and the inventory management service so that when a user places an order, the order processing service sends a message to the inventory management service to update the stock, promoting decoupling and scalability.The system architecture comprises of the API application that handles user interactions, the RabbitMQ messaging broker facilitating communication and Order Processing Service and Inventory Management Service—responsible for processing orders and managing inventory, respectively.

HOW TO RUN THE APLLICATIONS
API Application
•	Clone the repository containing the API application.
•	Open the solution in Visual Studio.
•	Configure the database connection string in appsettings.json.
•	Configure the RabbitMQ connection string in appsettings.json
•	Run the application.
RabbitMQ Setup
•	Install RabbitMQ on your server or local machine.
•	Start the RabbitMQ server.
•	Ensure the RabbitMQ management plugin is enabled for easy monitoring.
This documentation provides an overview of the design decisions made for the Heihgts Book Hub communication system. The combination of C#, Asp.Net, APIs, and RabbitMQ creates a scalable, efficient, and asynchronous architecture for handling book orders and inventory management.
