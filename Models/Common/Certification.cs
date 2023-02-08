using System;

namespace Ki4C_Solution.Models.Common
{
    public class Certification
    {
        /*
         * 1	인증번호	CertificationNumber	int	NOT NULL
            2	로그인날짜	LoginDate	datetime	NOT NULL
            3	로그아웃날짜	LogoutDate	datetime	NOT NULL
            4	회원구분번호	CustomerNumber_FK	int	NOT NULL
         */
        public int CertificationNumber { get; set; }
        public DateTime LoginDate { get; set; }
        public DateTime LogoutDate { get; set; }
        public int CustomerNumber_FK { get; set; }

        public Certification()
        {
            CertificationNumber = 0;
            LoginDate = DateTime.Now;
            LogoutDate = DateTime.Now;
            CustomerNumber_FK = 0;
        }

        public Certification(int certificationNumber, DateTime loginDate, DateTime logoutDate, int customerNumber_FK)
        {
            CertificationNumber = certificationNumber;
            LoginDate = loginDate;
            LogoutDate = logoutDate;
            CustomerNumber_FK = customerNumber_FK;
        }

        public override string ToString()
        {
            return $"{nameof(CertificationNumber)}: {CertificationNumber}, {nameof(LoginDate)}: {LoginDate}, {nameof(LogoutDate)}: {LogoutDate}, {nameof(CustomerNumber_FK)}: {CustomerNumber_FK}";
        }
    }
}
