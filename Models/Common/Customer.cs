namespace Ki4C_Solution.Models.Common
{
    public class Customer
    {
        /*
         * 1	고객번호	CustomerNumber	int	NOT NULL
            2	회원구분번호	CustomerClassNumberFK	int	NOT NULL
            3	평가위원선정번호	EvaluatorSelectionNumberFK	int	NOT NULL
            4	회원구분명	CustomerClassName	varchar(16)	NOT NULL
            5	아이디	ID	varchar(16)	NOT NULL
            6	이메일	Email	varchar(16)	NOT NULL
            7	회사명	CompanyName	varchar(16)	NOT NULL
            8	부서명	Department	varchar(16)	NOT NULL
            9	휴대전화	CellPhone	varchar(16)	NOT NULL
            10	메일링수신여부	ReceiveMailing	varchar(1)	NOT NULL
            11	가입일시	SignUpTime	datetime	NOT NULL
            12	로그인수	CountOfLogins	int	NOT NULL
            13	최종로그인	FinalLogin	datetime	NOT NULL
            14	활동정보	ActivityInformation	varchar(2)	NOT NULL
            15	평가신청상태	DiagnosticEvaluationStatus	varchar(1)	NOT NULL
         */
        public int CustomerNumber { get; set; }
        public int CustomerClassNumberFK { get; set; }
        public int EvaluatorSelectionNumberFK { get; set; }
        public string CustomerClassName { get; set; }
        public string ID { get; set; }
        public string Email { get; set; }
        public string CompanyName { get; set; }
        public string Department { get; set; }
        public string CellPhone { get; set; }
        public string ReceiveMailing { get; set; }
        public string SignUpTime { get; set; }
        public int CountOfLogins { get; set; }
        public string FinalLogin { get; set; }
        public string ActivityInformation { get; set; }
        public string DiagnosticEvaluationStatus { get; set; }

        public Customer()
        {
            CustomerNumber = 0;
            CustomerClassNumberFK = 0;
            EvaluatorSelectionNumberFK = 0;
            CustomerClassName = string.Empty;
            ID = string.Empty;
            Email = string.Empty;
            CompanyName = string.Empty;
            Department = string.Empty;
            CellPhone = string.Empty;
            ReceiveMailing = string.Empty;
            SignUpTime = string.Empty;
            CountOfLogins = 0;
            FinalLogin = string.Empty;
            ActivityInformation = string.Empty;
            DiagnosticEvaluationStatus = string.Empty;
        }

        public Customer(int customerNumber, int customerClassNumberFK, int evaluatorSelectionNumberFK, string customerClassName, string id, string email, string companyName, string department, string cellPhone, string receiveMailing, string signUpTime, int countOfLogins, string finalLogin, string activityInformation, string diagnosticEvaluationStatus)
        {
            CustomerNumber = customerNumber;
            CustomerClassNumberFK = customerClassNumberFK;
            EvaluatorSelectionNumberFK = evaluatorSelectionNumberFK;
            CustomerClassName = customerClassName;
            ID = id;
            Email = email;
            CompanyName = companyName;
            Department = department;
            CellPhone = cellPhone;
            ReceiveMailing = receiveMailing;
            SignUpTime = signUpTime;
            CountOfLogins = countOfLogins;
            FinalLogin = finalLogin;
            ActivityInformation = activityInformation;
            DiagnosticEvaluationStatus = diagnosticEvaluationStatus;
        }

        public override string ToString()
        {
            return $"{nameof(CustomerNumber)}: {CustomerNumber}, {nameof(CustomerClassNumberFK)}: {CustomerClassNumberFK}, {nameof(EvaluatorSelectionNumberFK)}: {EvaluatorSelectionNumberFK}, {nameof(CustomerClassName)}: {CustomerClassName}, {nameof(ID)}: {ID}, {nameof(Email)}: {Email}, {nameof(CompanyName)}: {CompanyName}, {nameof(Department)}: {Department}, {nameof(CellPhone)}: {CellPhone}, {nameof(ReceiveMailing)}: {ReceiveMailing}, {nameof(SignUpTime)}: {SignUpTime}, {nameof(CountOfLogins)}: {CountOfLogins}, {nameof(FinalLogin)}: {FinalLogin}, {nameof(ActivityInformation)}: {ActivityInformation}, {nameof(DiagnosticEvaluationStatus)}: {DiagnosticEvaluationStatus}";
        }

    }
}
