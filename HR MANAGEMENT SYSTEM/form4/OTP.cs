using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HR_MANAGEMENT_SYSTEM
{
    class OTP
    {
        
        private static Dictionary<string, (string otp, DateTime expiry)> otpStorage = new();
        public static string Generateotp;
        public static string GenerateOTP(int length = 6)
        {
            var random = new Random();
            string otp = "";

            for (int i = 0; i < length; i++)
            {
                otp += random.Next(0, 10);
            }

            return otp;
        }

        public static void SendOtp(string email)
        {
            Generateotp = GenerateOTP();
            otpStorage[email] = (Generateotp, DateTime.Now.AddMinutes(1));
            Email send = new Email();
            send.SendEmail(email, Generateotp);
        }

        

        public static bool VerifyOtp(string email, string userOTP)
        {
            if (otpStorage.ContainsKey(email))
            {
                var (otp, expiry) = otpStorage[email];
                if (DateTime.Now <= expiry && userOTP == otp)
                {
                    otpStorage.Remove(email); // Remove OTP after verification
                    return true;
                }
            }
            return false;
        }
    }
}
