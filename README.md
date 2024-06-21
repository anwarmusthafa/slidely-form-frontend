# Slidely Windows Desktop Application

This project is a Windows Desktop Application built with Visual Basic in Visual Studio. It provides a user interface for creating and viewing form submissions and communicates with a backend server built with Express.js and TypeScript.

## Setup

### Prerequisites

1. **Visual Studio**
   - Download and install [Visual Studio](https://visualstudio.microsoft.com/) with the .NET Desktop Development workload.

2. **Backend Server**
   - Ensure the backend server is running and accessible at `http://localhost:3000`. Refer to the [Slidely Form Backend](https://github.com/anwarmusthafa/slidely-form-backend.git) repository for setup instructions.

### Installation

1. **Clone the repository**

   ```bash
   git clone https://github.com/anwarmusthafa/slidely-form-frontend.git

2. **Open the Project in Visual Studio**

Open Visual Studio.
Select File -> Open -> Project/Solution.

Navigate to the Slidely-form directory and open the solution file (Slidely-Form.sln).

3. **Running the Application**
#### Build the Project

In Visual Studio, select Build -> Build Solution.
Run the Application

Press F5 or select Debug -> Start Debugging to run the application.

## Application Overview

#### Main Form
#### The main form provides two options:

### View Submissions:
 Opens a form to view existing submissions.
Create New Submission: Opens a form to create a new submission.
View Submissions Form
This form allows you to navigate through existing submissions:

Previous: View the previous submission.

Next: View the next submission.

Edit : Update the submissions

Delete :  Delete the submission

Displays details such as name, email, phone number, GitHub link, and stopwatch time.

### Create Submission Form
This form allows you to create a new submission:

Text Boxes: Input fields for name, email, phone number, and GitHub repo link.
Stopwatch: A button to start/stop the stopwatch.
Submit: A button to submit the form. Can also be triggered with Ctrl + S.

## Demo

https://youtu.be/0JfdMbMtVBY
