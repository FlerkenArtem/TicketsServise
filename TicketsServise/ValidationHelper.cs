using System.Text.RegularExpressions;

namespace TicketsServise
{
    public static class ValidationHelper
    {
        public static bool IsValidPhone(string phone)
            => Regex.IsMatch(phone, @"^\+7 \(9\d{2}\) \d{3}-\d{2}-\d{2}$");
        public static bool IsValidEmail(string email)
            => Regex.IsMatch(email, @"^[A-Za-z0-9._%+-]+@[A-Za-z0-9.-]+\.[A-Za-z]{2,}$");
        public static bool IsValidPassword(string password)
            => password.Length >= 8;
        public static bool IsValidLogin(string login)
            => Regex.IsMatch(login, @"^[A-Za-z0-9!@#$%^&*()_\-+=]{8,20}$");
        public static bool IsValidName(string name, bool allowHyphen = true)
        {
            if (string.IsNullOrEmpty(name) || name.Length < 2) return false;
            string pattern = allowHyphen ? @"^[А-ЯЁ][а-яё]+([-][А-ЯЁ][а-яё]+)*$" : @"^[А-ЯЁ][а-яё]+$";
            return Regex.IsMatch(name, pattern) && char.IsUpper(name[0]);
        }
        public static bool IsValidPatronymic(string text)
            => string.IsNullOrEmpty(text) || IsValidName(text, false);
        public static bool IsValidOptional(string text)
            => string.IsNullOrEmpty(text) || IsValidName(text, false);
        public static bool IsValidRegion(string region)
            => Regex.IsMatch(region, @"^[А-ЯЁ][а-яё]*(?:[-\s][А-Яа-яё]+)*$");
        public static bool IsValidHouse(string house)
            => Regex.IsMatch(house, @"^\d+[А-ЯЁа-яё\d\-/]*(?:\s+(?:корпус|к\.|литера|лит\.|строение|стр\.|владение|влад\.|сооружение|соор\.|дом|д\.)\s*[А-ЯЁа-яё\d]+|\s+[А-ЯЁа-яё])*$");
        public static bool IsValidFlat(string flat)
            => string.IsNullOrEmpty(flat) || Regex.IsMatch(flat, @"^\d{1,4}[А-ЯЁа-яё]?$");
        public static bool IsValidOgrn(string ogrn)
            => Regex.IsMatch(ogrn, @"^(\d{13}|\d{15})$");
        public static bool IsValidInn(string inn, bool isOrganization = true)
            => isOrganization ? Regex.IsMatch(inn, @"^\d{10}$") : Regex.IsMatch(inn, @"^\d{12}$");
        public static bool IsValidBik(string bik)
            => Regex.IsMatch(bik, @"^04\d{7}$");
        public static bool IsValidKpp(string kpp)
            => Regex.IsMatch(kpp, @"^\d{9}$");
        public static bool IsValidCorrAccount(string account)
            => Regex.IsMatch(account, @"^301\d{17}$");
        public static bool IsValidOrgAccount(string account)
            => Regex.IsMatch(account, @"^40\d{18}$");
        public static bool IsValidEventDateTime(string input, out DateTime dateTime)
        {
            dateTime = DateTime.MinValue;
            var regex = new Regex(@"^(?:(?:(?:0[1-9]|1[0-9]|2[0-8])[./](?:0[1-9]|1[0-2])|(?:29|30)[./](?:0[13-9]|1[0-2])|31[./](?:0[13578]|1[02]))[./](?:[0-9]{4})|29[./]02[./](?:(?:[0-9]{2}(?:0[48]|[2468][048]|[13579][26]))|(?:[02468][048]|[13579][26])00)) (0[0-9]|1[0-9]|2[0-3]):[0-5][0-9]$");
            if (!regex.IsMatch(input)) return false;
            if (!DateTime.TryParse(input, out dateTime)) return false;
            return dateTime > DateTime.Today.AddDays(1);
        }
    }
}