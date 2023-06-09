﻿using System.Globalization;
using System.Text.RegularExpressions;

namespace StudentManagement
{

    public class Utils
    {

        public static List<string> errorMes;

        public static void resetErrorMes()
        {
            errorMes = new List<string>();
        }
        public static bool isEmpty(String str)
        {
            try
            {
                if (!errorMes.Contains("All field must not be empty") && string.IsNullOrWhiteSpace(str) &&
                    !errorMes.Contains("No special characters allowed in name") &&
                    !errorMes.Contains("No number at the first character in name"))
                    errorMes.Add("All field must not be empty");
                return string.IsNullOrWhiteSpace(str);
            }
            catch (Exception e)
            {
                errorMes = new List<string>();
                errorMes.Add("All field must not be empty");
                return false;
            }
        }
        public static int ProcessID(String txtId)
        {
            try
            {
                if (!isEmpty(txtId))
                {
                    int id = int.Parse(txtId);

                    if (id < 0)
                    {
                        errorMes.Add("ID must be a natural number");
                        return -1;
                    }
                    return id;
                }
                return -1;
            }
            catch
            {
                errorMes.Add("ID must be a natural number");
                return -1;
            }
        }


        public static string ProcessName(String txtName)
        {
            TextInfo textInfo = CultureInfo.CurrentCulture.TextInfo;
            if (Regex.IsMatch(txtName, @"[^a-zA-Z\s\d]"))
            {
                errorMes.Add("No special characters allowed in name");
                return "";
            }

            if (char.IsDigit(txtName, 0))
            {
                errorMes.Add("No number at the first character in name");
                return "";
            }
            String name = textInfo.ToTitleCase(ProcessDes(txtName));
            return name;
        }

        public static int ProcessAge(String txtAge)
        {
            try
            {
                int age = int.Parse(txtAge);
                if (age > 0 && age <= 120)
                    return age;

                else
                {
                    errorMes.Add("Age must be between 1 and 120");
                    return -1;
                }
            }
            catch
            {
                errorMes.Add("Age must be a natural number");
                return -1;
            }
        }

        public static bool ProcessEmail(String txtEmail)
        {
            string pattern = @"^[a-zA-Z0-9_.+-]+@[a-zA-Z0-9-]+\.[a-zA-Z0-9-.]+$";

            // Create a regular expression object
            Regex regex = new Regex(pattern);

            // Match the email against the regular expression
            Match match = regex.Match(txtEmail);
            if (!match.Success) errorMes.Add("Email must follow this format 'email@email.com'");
            // Check if the email matches the pattern
            return match.Success;
        }

        public static bool ProcessPhone(String txtPhone)
        {
            String numWithoutSpace = txtPhone.Replace(" ", "");
            String pattern = @"^[0-9]{9,11}$";
            Regex regex = new Regex(pattern);
            Match match = regex.Match(numWithoutSpace);
            if (!match.Success) errorMes.Add("Phone Number lenght is between 9 and 11");
            return match.Success;
        }

        public static String ProcessDes(String txtDes)
        {
            String pattern = @"\s+";
            String des = Regex.Replace(txtDes, pattern, " ");
            return des.Trim();
        }

        public static Student ProcessInput(string txtId, string txtName, string txtAge, string txtDes, string txtPhone, string txtEmail, DateTime created)
        {
            int id = -1;
            string name = "";
            int age = -1;
            string des = "";
            string phone = "";
            string email = "";
            if (!isEmpty(txtId))
            {
                id = ProcessID(txtId);
            }

            if (!isEmpty(txtName))
            {
                name = ProcessName(txtName);
            }

            if (!isEmpty(txtAge))
            {
                age = ProcessAge(txtAge);
            }

            if (!isEmpty(txtDes))
            {
                des = ProcessDes(txtDes);
            }

            if (!isEmpty(txtPhone) && ProcessPhone(txtPhone))
            {
                phone = txtPhone;
            }

            if (!isEmpty(txtEmail) && ProcessEmail(txtEmail))
            {
                email = txtEmail;
            }

            if (id == -1 || age == -1 || isEmpty(name) || isEmpty(des) || isEmpty(phone) || isEmpty(email))
                return null;
            return new Student(id, name, age, des, phone, email, created);
        }

    }
}
