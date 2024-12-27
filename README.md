# SearchxEngine
## Full-Stack Project

This is a full-stack project combining an Angular frontend and a C# backend.

---

### Frontend (Angular)
- **Path**: `frontend/`
- **Steps to Run**:
  1. Navigate to the `frontend` folder:
     ```bash
     cd frontend
     ```
  2. Install dependencies:
     ```bash
     npm install
     ```
  3. Start the development server:
     ```bash
     ng serve
     ```
  4. Access the frontend at:
     ```url
     http://localhost:4200
     ```

---

### Backend (C#)
- **Path**: `backend/`
- **Steps to Run**:
  1. Navigate to the `backend` folder:
     ```bash
     cd backend
     ```
  2. Build the project:
     ```bash
     dotnet build
     ```
  3. Run the application:
     ```bash
     dotnet run
     ```
  4. Access the backend API at:
     ```url
     http://localhost:5000
     ```

---

### Project Structure


---

### Configuration Notes
- **API Base URL**:
  Update the Angular `environment.ts` file to match the backend's URL:
  ```typescript
  export const environment = {
    production: false,
    apiBaseUrl: 'http://localhost:5000' // Update as needed
  };

