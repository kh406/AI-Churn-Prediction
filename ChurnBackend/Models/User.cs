namespace ChurnBackend.Models
{
    public class User
    {
        public int Id { get; set; }
        public string CustomerID { get; set; } = string.Empty;
        public string Gender { get; set; } = string.Empty;
        public int SeniorCitizen { get; set; }
        public string Partner { get; set; } = string.Empty;
        public string Dependents { get; set; } = string.Empty;
        public int Tenure { get; set; }
        public string PhoneService { get; set; } = string.Empty;
        public string MultipleLines { get; set; } = string.Empty;
        public string InternetService { get; set; } = string.Empty;
        public string OnlineSecurity { get; set; } = string.Empty;
        public string OnlineBackup { get; set; } = string.Empty;
        public string DeviceProtection { get; set; } = string.Empty;
        public string TechSupport { get; set; } = string.Empty;
        public string StreamingTV { get; set; } = string.Empty;
        public string StreamingMovies { get; set; } = string.Empty;
        public string Contract { get; set; } = string.Empty;
        public string PaperlessBilling { get; set; } = string.Empty;
        public string PaymentMethod { get; set; } = string.Empty;
        public double MonthlyCharges { get; set; }
        public string TotalCharges { get; set; } = string.Empty;
        public string Churn { get; set; } = string.Empty;
    }
}
