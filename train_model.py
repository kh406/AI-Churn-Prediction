import pandas as pd
import numpy as np
from sklearn.ensemble import RandomForestClassifier
from sklearn.model_selection import train_test_split
from sklearn.preprocessing import LabelEncoder
from sklearn.metrics import accuracy_score
import joblib

print("Step 1: CSV load ho rahi hai...")
df = pd.read_csv(r'C:\Users\shris\.idlerc\Downloads\archive\WA_Fn-UseC_-Telco-Customer-Churn.csv')
print("Total customers:", len(df))

print("Step 2: Data clean ho raha hai...")
df['TotalCharges'] = pd.to_numeric(df['TotalCharges'], errors='coerce')
df['TotalCharges'].fillna(df['TotalCharges'].mean(), inplace=True)

print("Step 3: Text to numbers...")
le = LabelEncoder()
text_columns = ['gender', 'Partner', 'Dependents', 'PhoneService',
                'MultipleLines', 'InternetService', 'OnlineSecurity',
                'OnlineBackup', 'DeviceProtection', 'TechSupport',
                'StreamingTV', 'StreamingMovies', 'Contract',
                'PaperlessBilling', 'PaymentMethod', 'Churn']
for col in text_columns:
    df[col] = le.fit_transform(df[col])

print("Step 4: Features prepare ho rahe hain...")
X = df.drop(['customerID', 'Churn'], axis=1)
y = df['Churn']

print("Step 5: Data split ho raha hai...")
X_train, X_test, y_train, y_test = train_test_split(X, y, test_size=0.2, random_state=42)
print("Training data:", len(X_train), "customers")
print("Testing data:", len(X_test), "customers")

print("Step 6: Model getting trained")
model = RandomForestClassifier(n_estimators=100, random_state=42)
model.fit(X_train, y_train)

print("Step 7: Accuracy check ho rahi hai...")
predictions = model.predict(X_test)
accuracy = accuracy_score(y_test, predictions)
print("Model Accuracy:", round(accuracy * 100, 2), "%")

print("Step 8: Model save ho raha hai...")
joblib.dump(model, 'churn_model.pkl')
print("Model saved: churn_model.pkl")
print("DONE! Model ready hai!")