using DoAnPBL3.DAL;
using DoAnPBL3.Models;
using DoAnPBL3.Validator;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DoAnPBL3.BLL
{

    // Quản lý nhân viên
    class BLL_QLNV
    {
        private static BLL_QLNV _Instance;
        public static BLL_QLNV Instance
        {
            get
            {
                if (_Instance == null)
                {
                    _Instance = new BLL_QLNV();
                }
                return _Instance;
            }
            private set => _Instance = value;
        }

        private BLL_QLNV()
        {

        }

        public List<Employee> GetEmployees()
        {
            return DAL_QLNV.Instance.GetListEmployees();
        }

        public List<Employee> GetMaleEmployees()
        {
            return DAL_QLNV.Instance.GetListMaleEmployees();
        }

        public List<Employee> GetFemaleEmployees()
        {
            return DAL_QLNV.Instance.GetListFemaleEmployees();
        }

        public List<Employee> GetEmployeesQuitJob()
        {
            return DAL_QLNV.Instance.GetListEmployeesQuitJob();
        }

        public List<Employee> GetEmployeesByName(string name)
        {
            return DAL_QLNV.Instance.GetEmployeesByName(name);
        }

        public Employee GetEmployeeByID(string ID_Employee)
        {
            return DAL_QLNV.Instance.GetEmployeeByID(ID_Employee);
        }

        public Employee GetEmployeeByPhone(string phone)
        {
            return DAL_QLNV.Instance.GetEmployeeByPhone(phone);
        }

        public string GetLastID()
        {
            return DAL_QLNV.Instance.GetLastID();
        }

        public string GetIDByAccountUsername(string accountUsername)
        {
            return DAL_QLNV.Instance.GetIDByAccountUsername(accountUsername);
        }

        public int GetNumberTotalEmployee()
        {
            return DAL_QLNV.Instance.GetNumberTotalEmployee();
        }

        public int GetNumberTotalMaleEmployee()
        {
            return DAL_QLNV.Instance.GetNumberTotalMaleEmployee();
        }

        public int GetNumberTotalFemaleEmployee()
        {
            return DAL_QLNV.Instance.GetNumberTotalFemaleEmployee();
        }

        public int GetNumberTotalEmployeeQuitJob()
        {
            return DAL_QLNV.Instance.GetNumberTotalEmployeeQuitJob();
        }

        public int GetNumberTotalMaleEmployeeQuitJob()
        {
            return DAL_QLNV.Instance.GetNumberTotalMaleEmployeeQuitJob();
        }

        public int GetNumberTotalFemaleEmployeeQuitJob()
        {
            return DAL_QLNV.Instance.GetNumberTotalFemaleEmployeeQuitJob();
        }

        public string GetAvatar(string accountUsername)
        {
            return DAL_QLNV.Instance.GetAvatar(accountUsername);
        }

        public string GetNameEmployeeByID(string ID_Employee)
        {
            return DAL_QLNV.Instance.GetNameEmployeeByID(ID_Employee);
        }

        public string CreateNewEmployeeID(string ID_Employee)
        {
            StringBuilder newEmployeeID;
            if (ID_Employee == null)
            {
                newEmployeeID = new StringBuilder("E0000");
                return newEmployeeID.ToString();
            }
            else
            {
                string code = ID_Employee.Substring(1, ID_Employee.Length - 1); // 0006
                int num = Convert.ToInt32(code); // 6
                num++; // 6 + 1 -> 7
                string numStr = num.ToString(); // "7"
                int lenNumStr = numStr.Length; // 1
                newEmployeeID = new StringBuilder(ID_Employee);
                newEmployeeID = newEmployeeID.Remove(newEmployeeID.Length - lenNumStr, lenNumStr);// S000
                newEmployeeID.Append(numStr); // S000 + 7 => E0007
                return newEmployeeID.ToString();
            }
        }

        public string CreateNewAccount(string username, string ID_Employee)
        {
            StringBuilder stringBuilder = new StringBuilder();
            string newUsername = ReplaceWhiteSpace(username.ToLower());
            foreach (char c in newUsername)
            {
                stringBuilder.Append(ConvertVietnameseToAlphabet(c));
            }
            foreach (char c in ID_Employee)
            {
                stringBuilder.Append(c);
            }
            return stringBuilder.ToString();
        }

        public string GetAccountUsernameByID(string ID_Employee)
        {
            return DAL_QLNV.Instance.GetAccountUsernameByID(ID_Employee);
        }

        public DateTime GetDateOfBirth(string dateOfBirth)
        {
            return new DateTime(
                Convert.ToInt32(dateOfBirth.Substring(6, 4)),
                Convert.ToInt32(dateOfBirth.Substring(3, 2)),
                Convert.ToInt32(dateOfBirth.Substring(0, 2))
            );
        }

        public DateTime GetStartDate(string startDate)
        {
            return new DateTime(
                Convert.ToInt32(startDate.Substring(6, 4)),
                Convert.ToInt32(startDate.Substring(3, 2)),
                Convert.ToInt32(startDate.Substring(0, 2))
            );
        }

        public bool AddEmployee(Employee employee)
        {
            if (DAL_QLNV.Instance.AddEmployee(employee))
                return true;
            else
                return false;
        }

        public bool UpdateEmployee(Employee employee)
        {
            if (DAL_QLNV.Instance.UpdateEmployee(employee))
                return true;
            else
                return false;
        }

        public bool DeleteEmployee(string ID_Employee)
        {
            return DAL_QLNV.Instance.DeleteEmployee(ID_Employee);
        }

        public char ConvertVietnameseToAlphabet(char alphaName)
        {
            if (alphaName == 'á' || alphaName == 'Á' || alphaName == 'à' || alphaName == 'À' || alphaName == 'ả' || alphaName == 'Ả'
                || alphaName == 'ã' || alphaName == 'Ã' || alphaName == 'ạ' || alphaName == 'Ạ' || alphaName == 'ă' || alphaName == 'Ă'
                || alphaName == 'ắ' || alphaName == 'Ắ' || alphaName == 'ằ' || alphaName == 'Ằ' || alphaName == 'ẳ' || alphaName == 'Ẳ'
                || alphaName == 'ẵ' || alphaName == 'Ẵ' || alphaName == 'ặ' || alphaName == 'Ặ' || alphaName == 'â' || alphaName == 'Â'
                || alphaName == 'ấ' || alphaName == 'Ấ' || alphaName == 'ầ' || alphaName == 'Ầ' || alphaName == 'ẩ' || alphaName == 'Ẩ'
                || alphaName == 'ẫ' || alphaName == 'Ẫ' || alphaName == 'ậ' || alphaName == 'Ậ')
                return 'a';
            else if (alphaName == 'đ' || alphaName == 'Đ')
                return 'd';
            else if (alphaName == 'é' || alphaName == 'É' || alphaName == 'è' || alphaName == 'È' || alphaName == 'ẻ' || alphaName == 'Ẻ'
                || alphaName == 'ẽ' || alphaName == 'Ẽ' || alphaName == 'ẹ' || alphaName == 'Ẹ' || alphaName == 'ê' || alphaName == 'Ê'
                || alphaName == 'ế' || alphaName == 'Ế' || alphaName == 'ề' || alphaName == 'Ề' || alphaName == 'ể' || alphaName == 'Ể'
                || alphaName == 'ễ' || alphaName == 'Ễ' || alphaName == 'ệ' || alphaName == 'Ệ')
                return 'e';
            else if (alphaName == 'í' || alphaName == 'Í' || alphaName == 'ì' || alphaName == 'Ì' || alphaName == 'ỉ' || alphaName == 'Ỉ'
                || alphaName == 'ĩ' || alphaName == 'Ĩ' || alphaName == 'ị' || alphaName == 'Ị')
                return 'i';
            else if (alphaName == 'ó' || alphaName == 'Ó' || alphaName == 'ò' || alphaName == 'Ò' || alphaName == 'ỏ' || alphaName == 'Ỏ'
                || alphaName == 'õ' || alphaName == 'Õ' || alphaName == 'ọ' || alphaName == 'Ọ' || alphaName == 'ô' || alphaName == 'Ô'
                || alphaName == 'ố' || alphaName == 'Ố' || alphaName == 'ồ' || alphaName == 'Ồ' || alphaName == 'ổ' || alphaName == 'Ổ'
                || alphaName == 'ỗ' || alphaName == 'Ỗ' || alphaName == 'ộ' || alphaName == 'Ộ' || alphaName == 'ơ' || alphaName == 'Ơ'
                || alphaName == 'ớ' || alphaName == 'Ớ' || alphaName == 'ờ' || alphaName == 'Ờ' || alphaName == 'ở' || alphaName == 'Ở'
                || alphaName == 'ỡ' || alphaName == 'Ỡ' || alphaName == 'ợ' || alphaName == 'Ợ')
                return 'o';
            else if (alphaName == 'ú' || alphaName == 'Ú' || alphaName == 'ù' || alphaName == 'Ù' || alphaName == 'ủ' || alphaName == 'Ủ'
                || alphaName == 'ũ' || alphaName == 'Ũ' || alphaName == 'ụ' || alphaName == 'Ụ' || alphaName == 'ư' || alphaName == 'Ư'
                || alphaName == 'ứ' || alphaName == 'Ứ' || alphaName == 'ừ' || alphaName == 'Ừ' || alphaName == 'ử' || alphaName == 'Ử'
                || alphaName == 'ữ' || alphaName == 'Ữ' || alphaName == 'ự' || alphaName == 'Ự')
                return 'u';
            else if (alphaName == 'ý' || alphaName == 'Ý' || alphaName == 'ỳ' || alphaName == 'Ỳ' || alphaName == 'ỷ' || alphaName == 'Ỷ'
                || alphaName == 'ỹ' || alphaName == 'Ỹ' || alphaName == 'ỵ' || alphaName == 'Ỵ')
                return 'y';
            else
                return alphaName;
        }

        public string ReplaceWhiteSpace(string input)
        {
            return new string(input.ToCharArray()
                    .Where(c => !char.IsWhiteSpace(c))
                    .ToArray());
        }

        public bool ValidateName(string name)
        {
            if (name == "")
                return false;
            else
                return true;
        }

        public bool ValidateEmail(string email)
        {
            if (!Validators.IsValidEmail(email))
                return false;
            else
                return true;
        }

        public string ValidateDateOfBirth(string dateOfBirth)
        {
            if (dateOfBirth == "")
                return "Ngày sinh không được để trống";
            else
            {
                // Validate date of birth contains alphabet
                if (Validators.IsDateContainsAlphabet(dateOfBirth))
                    return "Ngày sinh không hợp lệ";
                else
                {
                    // Validate format date of birth
                    if (!Validators.IsValidFormatDate(dateOfBirth, Validators.DATE_TIME_REGEX))
                        return "Ngày sinh phải theo định dạng dd/MM/yyyy";
                    else
                    {
                        // Check date of birth
                        string msgValidate = Validators.CheckDate(dateOfBirth, Validators.DATE_TIME_REGEX);
                        if (msgValidate != "")
                            return msgValidate;
                        else
                        {
                            // Validate current date
                            if (!Validators.IsValidDate(dateOfBirth, Validator.Validators.DATE_TIME_REGEX))
                                return "Ngày sinh không được lớn hơn ngày hiện tại";
                            else
                            {
                                if (!Validators.IsValidAge(dateOfBirth, Validators.DATE_TIME_REGEX))
                                    return "Nhân viên ít nhất phải đủ 18 tuổi";
                                else
                                    return "";
                            }
                        }
                    }
                }
            }
        }

        public string ValidateStartDate(string startDate)
        {
            if (startDate == "")
                return "Ngày vào làm không được để trống";
            else
            {
                // Validate start date contains alphabet
                if (Validators.IsDateContainsAlphabet(startDate))
                    return "Ngày vào làm không hợp lệ";
                else
                {
                    // Validate format start date
                    if (!Validators.IsValidFormatDate(startDate, Validators.DATE_TIME_REGEX))
                        return "Ngày vào làm phải theo định dạng dd/MM/yyyy";
                    else
                    {
                        // Check start date
                        string msgValidate = Validators.CheckDate(startDate, Validators.DATE_TIME_REGEX);
                        if (msgValidate != "")
                            return msgValidate;
                        else
                        {
                            return "";
                        }
                    }
                }
            }
        }

        public bool ValidateGender(object gender)
        {
            if (gender == null)
                return false;
            else
                return true;
        }

        public bool ValidateID_Card(string idCard)
        {
            if (!Validators.IsValidIdCard(idCard, Validators.ID_CARD_REGEX))
                return false;
            else
                return true;
        }

        public bool ValidatePhone(string phone)
        {
            if (!Validators.IsValidPhoneNumber(phone, Validators.PHONE_REGEX))
                return false;
            else
                return true;
        }

        public bool ValidateAddress(string address)
        {
            if (address == "")
                return false;
            else
                return true;
        }
    }
}
