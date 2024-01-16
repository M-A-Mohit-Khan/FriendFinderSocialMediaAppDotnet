# Friend-Finder

A social media web application for connection and interaction with others.

## Project descripton

A group project developed by four team members.

Four types of users: 1. Admin, 2. Business user, 3. Job recruiter, 4. User(M A Mohit Khan). User's features- Ac creation, update; Follow others; Create posts; Comments; Search users;

Admin can manage the overall social media. Business user can sell products. Job recruiter can post jobs to recruit.

## Prerequisites

Make sure you have the following software installed on your machine:

- [.NET SDK](https://dotnet.microsoft.com/download)
- [Visual Studio](https://visualstudio.microsoft.com/) (Optional, but recommended)
- [Microsoft SQL Server](https://www.microsoft.com/en-us/sql-server/sql-server-downloads)

## Installation

1. Clone the repository:

    ```bash
    git clone https://github.com/your-username/dotnet-project.git
    ```

2. Navigate to the project directory:

    ```bash
    cd dotnet-project
    ```

## Microsoft SQL Server Setup

1. Open SQL Server Management Studio (SSMS).

2. Connect to your SQL Server instance.

3. Create a new database:

    ```sql
    CREATE DATABASE DotnetProjectDB;
    ```

4. Update the project configuration:

    - Open the project's configuration file (e.g., `appsettings.json`).
    - Update the `ConnectionStrings` section with your SQL Server connection details.

## Usage

1. Build and run the .NET project:

    ```bash
    dotnet build
    dotnet run
    ```

    Alternatively, you can open the project in Visual Studio and run it from there.

2. Open your web browser and navigate to the following URL:

    ```url
    http://localhost:5000
    ```

3. You should see the .NET project running.
