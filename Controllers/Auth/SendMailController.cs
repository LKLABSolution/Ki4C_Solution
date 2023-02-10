using Microsoft.AspNetCore.Mvc;

namespace Ki4C_Solution.Controllers.Auth
{
    public class SendMailController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
        
        

        //naver SMTP Send Method
        public string NaverSendMail()
        {
            try
            {
                System.Net.Mail.MailMessage mail = new System.Net.Mail.MailMessage();
                //발신자
                mail.From = new System.Net.Mail.MailAddress("임윤식" + "<" + "lsun000@naver.com" + ">");

                //수신자
                mail.To.Add("amsomad@lklab.org");
                
                //제목
                mail.Subject = "발신Subject";

                //내용
                string bodyTag = @"
                    <link href=""https://cdn.jsdelivr.net/npm/bootstrap@5.0.2/dist/css/bootstrap.min.css"" rel=""stylesheet"" integrity=""sha384-EVSTQN3/azprG1Anm3QDgpJLIm9Nao0Yz1ztcQTwFspd3yD65VohhpuuCOmLASjC"" crossorigin=""anonymous"">
                    <div class=""d-flex align-items-center vh-100"">
                        <div class=""container text-center"">
                            <div class=""row"">
                                <div class=""col-lg-8 mx-auto"">
                                    <h1 class=""display-4"">
                                        <img src=""~/images/logo.png"" alt=""logo"" width=""80%"" height=""80%"" />
                                    </h1>
                                    <p class=""lead text-muted"">이메일 주소 출력란</p>
                                    <p class=""lead text-muted"">정상 로그아웃 하였습니다.</p>
                                    <p class=""lead text-muted"">수고하셨습니다.</p>
                                    <a class=""btn btn-primary"" asp-area="" asp-controller=""Home"" asp-action=""index"">메인으로 이동</a>
                                </div>
                            </div>
                        </div>
                    </div>
                 ";
                mail.Body = bodyTag;
                mail.IsBodyHtml = true;
                mail.Priority = System.Net.Mail.MailPriority.High;

                System.Net.Mail.SmtpClient smtp = new System.Net.Mail.SmtpClient();
                smtp.Host = "smtp.naver.com";
                smtp.Port = 587;
                smtp.UseDefaultCredentials = false;
                smtp.Credentials = new System.Net.NetworkCredential("lsun000@naver.com", "dbsskfo!2");
                smtp.EnableSsl = true;
                smtp.Send(mail);
                return "메일 전송 완료";

            } catch (Exception ex)
            {
                return "메일 전송 실패";
            }
        }

        //naver SMTP Send Method
        public string NaverSendMail(string to, string subject, string body)
        {
            try
            {
                System.Net.Mail.MailMessage mail = new System.Net.Mail.MailMessage();
                mail.To.Add(to);
                mail.From = new System.Net.Mail.MailAddress("임윤식" + "<" + "lsun000@naver.com" + ">");
                mail.Subject = subject;
                mail.Body = body;
                mail.IsBodyHtml = true;
                mail.Priority = System.Net.Mail.MailPriority.High;

                System.Net.Mail.SmtpClient smtp = new System.Net.Mail.SmtpClient();
                smtp.Host = "smtp.naver.com";
                smtp.Port = 587;
                smtp.UseDefaultCredentials = false;
                smtp.Credentials = new System.Net.NetworkCredential(" ", " ");
                smtp.EnableSsl = true;
                smtp.Send(mail);
                return "메일 전송 완료";

            }
            catch (Exception ex)
            {
                return "메일 전송 실패";
            }
        }

    }
}
