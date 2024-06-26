# E-learning API

This is an API to manage e-learning courses.

## Information
The code is in Spanish.
Includes swagger

## Requirements

- .NET 8 or higher
- SQL Server

## Installation

1. Clone the repository.
2. Configure the connection string in `appsettings.json`.
3. Run `dotnet ef database update` to create the database.
4. Run `dotnet run` to start the application.

## Endpoints

### Cursos

- `GET /api/cursos` - Get all courses
- `GET /api/cursos/{id}` - Get a course by ID
- `POST /api/cursos` - Create a new course
- `PUT /api/cursos/{id}` - Update an existing course
- `DELETE /api/cursos/{id}` - Delete a course

### Lecciones

- `GET /api/lecciones` - Get all lessons
- `GET /api/lecciones/{id}` - Get a lesson by ID
- `POST /api/lecciones` - Create a new lesson
- `PUT /api/lecciones/{id}` - Update an existing lesson
- `DELETE /api/lecciones` - Delete a lesson

### Preguntas

- `GET /api/preguntas` - Get all questions
- `GET /api/preguntas/{id}` - Get a question by ID
- `POST /api/preguntas` - Create a new question
- `PUT /api/preguntas/{id}` - Update an existing question
- `DELETE /api/preguntas/{id}` - Delete a question