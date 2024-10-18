using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Mail;
using System.Text;
using System.Threading.Tasks;

namespace AppForMaraphone.Classes
{
    public class CheksProgam
    {
        public static void CheckDate(string date)
        {
            DateTime dateValue;
            if (!DateTime.TryParse(date, out dateValue))
            {
                throw new Exception("Неверный формат даты");
            }
            else
            {
                if (date.Length != 10)
                {
                    throw new Exception("Некоректно введена дата рождения");
                }
                dateValue = Convert.ToDateTime(date);
                if (DateTime.Now.AddYears(-10) < dateValue)
                {
                    throw new Exception("Для регистрации, минимальный необходимый возраст 10 лет");
                }
                else if (DateTime.Now.AddYears(-100) > dateValue)
                {
                    throw new Exception("Некоректно введена дата рождения");
                }
            }
        }
        public static void CheckPass(string firstPass, string secondPass)
        {
            if (firstPass.Length < 5)
            {
                throw new Exception("Пароль должен состоять минимум и 6 символов.");
            }
            bool IsLower = false;
            bool NumberInString = false;
            bool Symbol = false;
            foreach (char ch in firstPass)
            {
                if (char.IsDigit(ch))
                {
                    NumberInString = true;
                }
                if (char.IsLower(ch))
                {
                    IsLower = true;
                }
                if (ch == '!' || ch == '@' || ch == '#' || ch == '$' || ch == '%' || ch == '^')
                {
                    Symbol = true;
                }
            }
            if (NumberInString == false)
            {
                throw new Exception("Пароль должен содержать хотя бы одну цифру");
            }
            if (IsLower == false)
            {
                throw new Exception("Пароль должен содержать хотя бы одну прописную букву");
            }
            if (Symbol == false)
            {
                throw new Exception("Пароль должен содержать хотя бы однин специпльный символ: ! @ # $% ^ ");
            }
            if (firstPass != secondPass)
            {
                throw new Exception("Пароли должны совподать совподают");
            }
        }
        public static bool CheckEmail(string emailAddress)
        {
            try
            {
                if (emailAddress.Length > 0)
                {
                    MailAddress m = new MailAddress(emailAddress);
                    string[] words = emailAddress.Split(new char[] { '@' });
                    int findPoint = 0;
                    foreach (var part in words)
                    {
                        if (part.Contains("."))
                        {
                            findPoint++;
                        }
                    }
                    if (findPoint == 1)
                    {
                        string[] parts = words[words.Length - 1].Split(new char[] { '.' });
                        {
                            if (parts[parts.Length - 1].Length < 1)
                            {
                                return false;
                            }
                        }
                    }
                    else
                    {
                        return false;
                    }
                    return true;
                }
                else
                {
                    return false;
                }
            }
            catch (Exception)
            {
                return false;
            }
        }
    }
}
