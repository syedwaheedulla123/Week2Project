# Task Management Web API

A **Task Management Web API** built with **ASP.NET Core** that allows users to manage tasks, assign them to team members, set deadlines, and track their statuses.

## Features

- **Create a Task**: Add new tasks with details like name, description, assignee, deadline, and status.
- **Retrieve All Tasks**: Fetch all tasks or filter tasks based on assignee or status.
- **Retrieve Task by ID**: Get details of a specific task by its unique ID.
- **Update a Task**: Modify the task details such as name, description, assignee, deadline, or status.
- **Delete a Task**: Remove a task from the system.

## Technologies Used

- **.NET 6 / .NET 7**: Framework for building the Web API.
- **ASP.NET Core**: For creating RESTful APIs.
- **Swagger**: For API documentation and testing.

## API Endpoints

### Task Endpoints

| HTTP Method | Endpoint                     | Description                                    |
|-------------|------------------------------|------------------------------------------------|
| `GET`       | `/api/tasks`                | Retrieve all tasks                            |
| `GET`       | `/api/tasks/{id}`           | Retrieve a specific task by its ID            |
| `POST`      | `/api/tasks`                | Create a new task                             |
| `PUT`       | `/api/tasks/{id}`           | Update an existing task                       |
| `DELETE`    | `/api/tasks/{id}`           | Delete a task                                 |
| `GET`       | `/api/tasks/assignee/{assignee}` | Retrieve tasks assigned to a specific user    |
| `GET`       | `/api/tasks/status/{status}` | Retrieve tasks filtered by their status       |


## Sample Task JSON Payload

For **POST** or **PUT** requests, use the following JSON format:

```json
{
  "name": "Complete API Documentation",
  "description": "Write API documentation for the task management system.",
  "assignee": "John Doe",
  "deadline": "2025-02-01T12:00:00",
  "status": "In Progress"
}
```

## Project Structure

```
Week2Project
│
├── Controllers
│   └── TasksController.cs      # API Controller for Task Management
│
├── Models
│   └── TaskItem.cs             # Task model
│
├── Services
│   ├── ITaskService.cs         # Interface for task operations
│   └── TaskService.cs          # Implementation of task operations
│
├── Program.cs                  # Entry point and middleware configuration
├── appsettings.json            # Application settings
├── Week2Project.csproj         # Project file
│
└── README.md                   # Documentation
```



