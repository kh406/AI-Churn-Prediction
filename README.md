# AI Churn Prediction

## Project Overview
This repository contains a comprehensive AI model designed to predict customer churn based on various metrics. It incorporates machine learning algorithms for predictive modeling and is integrated with a backend API.

## Project Structure
The project is organized into several key components:

```
AI-Churn-Prediction/
├── backend/               # Contains the C# backend API
│   ├── Controllers/      # API Controllers
│   ├── Models/           # Models used in the API
│   ├── Services/         # Business logic and services
│   └── Program.cs        # Entry point
├── ml_model/             # Python machine learning model
│   ├── training/ (Random Forest) ---train_model.py       # Scripts for training the model
│   ├── predictions/ ----- churn_model.pkl     # Scripts for making predictions
│   └── utils/ (libraries----requiremnets.txt)           # Utility functions
├── database/             # Database scripts and migrations
└── README.md             # Project README
```

## Python ML Model Training
The machine learning model is developed in Python and uses various libraries. To train the model, navigate to the `ml_model/training/` directory and run the following command:

```bash
python train_model.py
```

Ensure that you have the required libraries installed:

```bash
pip install -r requirements.txt
```

## C# Backend API
The backend API is built using C#. To run the application locally, you will need .NET SDK installed. Navigate to the `backend/` directory and execute:

```bash
dotnet run
```

This will start the API service, typically hosted at `http://localhost:5000`.

## Database
The project uses a relational database to store data. Ensure that your database server is running, and execute the migration scripts located in the `database/` directory to set up the schema.

## Dependencies
The following dependencies are included in this project:
- Python Libraries: Listed in `requirements.txt`
- C# Libraries: .NET libraries are handled via NuGet package manager

## How to Use the System
1. Start the database service and run the migration scripts.
2. Train the machine learning model using the provided training scripts.
3. Run the C# backend API to expose the model predictions through API endpoints.
4. You can make requests to the API using tools like Postman or URL.
