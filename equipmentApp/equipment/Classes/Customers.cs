using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace equipment.Classes
{
    internal class Customers
    {
        static public string user;

        static public string surname, name, patronymic, email, phone;




        public static DataTable dtCustomers = new DataTable();

        /// <summary>
        /// Проверяет уникальность логина в базе данных
        /// </summary>
        /// <param name="login"></param>
        /// <returns></returns>
        public static bool CheckDuplicate(string login)
        {
            try
            {
                DBConnection.myCommand.CommandText = $@"SELECT login FROM customers WHERE login = '{login}';";
                if (DBConnection.myCommand.ExecuteScalar() == null)
                    return true;
                else
                    return false;
            }
            catch
            {
                return false;
            }
        }

        /// <summary>
        /// Проверяет соответствие пароля требованиям безопасности
        /// </summary>
        /// <param name="password"></param>
        /// <returns></returns>
        public static bool CheckPassword(string password)
        {
            return password.Length >= 6 &&
                   password.Any(char.IsDigit) &&
                   password.Any(char.IsPunctuation) &&
                   password.Any(char.IsLower) &&
                   password.Any(char.IsUpper);
        }

        /// <summary>
        /// Проверяет корректность формата email-адреса
        /// </summary>
        /// <param name="email"></param>
        /// <returns></returns>
        static public bool CheckEmail(string email)
        {
            // Проверка на null или пустую строку
            if (string.IsNullOrEmpty(email))
                return false;
            // Проверка на недопустимые символы в начале и конце
            if (email.StartsWith(".") || email.StartsWith("@") ||
                email.EndsWith(".") || email.EndsWith("@"))
                return false;
            // Подсчет количества символов @
            int j = 0;
            foreach (char c in email)
            {
                if (c == '@') j++;
                if (j > 1) return false;
            }
            // Проверка наличия хотя бы одной точки
            if (!email.Contains('.'))
                return false;
            // Проверка, что точка не идет сразу после @
            if (email.Contains("@."))
                return false;
            // Проверка, что после @ есть хотя бы один символ
            if (email.IndexOf('@') + 1 >= email.Length)
                return false;
            return true;
        }

        /// <summary>
        /// Загружает информацию о текущем пользователе в статические поля класса
        /// </summary>
        public static void GetLKInfo()
        {
            DBConnection.myCommand.CommandText = $@"SELECT * 
                                                        FROM customers 
                                                        WHERE login = '{user}';";
            var reader = DBConnection.myCommand.ExecuteReader();
            while (reader.Read())
            {
                surname = reader["surname"].ToString();
                name = reader["name"].ToString();
                patronymic = reader["patronymic"].ToString();
                email = reader["email"].ToString();
                phone = reader["phone"].ToString();
            }
            reader.Close();
        }

        /// <summary>
        /// Выполняет авторизацию пользователя
        /// </summary>
        /// <param name="login"></param>
        /// <param name="password"></param>
        /// <returns></returns>
        static public bool Autorization(string login, string password)
        {
            try
            {
                DBConnection.myCommand.CommandText = $@"SELECT login 
                                                        FROM customers 
                                                        WHERE login = '{login}' 
                                                        and password = md5('{password}');";

                if(DBConnection.myCommand.ExecuteScalar() != null )
                {
                    user = DBConnection.myCommand.ExecuteScalar().ToString();
                }
                else
                {
                    user = null;
                }
                return true;
            }
            catch
            {
                user = null;
                return false;
            }
        }

        /// <summary>
        /// Получает уровень доступа пользователя по логину
        /// </summary>
        /// <param name="login"></param>
        /// <returns></returns>
        public static string CheckAccess(string login)
        {
            try
            {
                DBConnection.myCommand.CommandText = $@"SELECT idAccess 
                                                        FROM customers 
                                                        WHERE login = '{login}';";
                return DBConnection.myCommand.ExecuteScalar().ToString();
            }
            catch
            {
                return null;
            }
        }

        /// <summary>
        /// Загружает полный список клиентов 
        /// </summary>
        public static void GetListCustomers()
        {
            DBConnection.myCommand.CommandText =
                $@"SELECT   customers.login, 
                            customers.password, 
                            customers.surname, 
                            customers.name, 
                            customers.patronymic, 
                            customers.email, 
                            customers.phone,
                            s_company.nameCompany,
                            customers.idCompany,
                            s_access.nameAccess,
                            customers.idAccess,
                            customers.idCustomer
                    FROM customers 
                    LEFT JOIN s_company ON customers.idCompany = s_company.idCompany
                    LEFT JOIN s_access ON customers.idAccess = s_access.idAccess;";
            dtCustomers.Clear();
            DBConnection.myDataAdapter.Fill(dtCustomers);
        }

        /// <summary>
        /// Получает идентификатор клиента по текущему логину
        /// </summary>
        /// <returns></returns>
        public static string GetId()
        {
            try
            {
                DBConnection.myCommand.CommandText = $@"SELECT idCustomer
                                                        FROM customers 
                                                        WHERE login = '{user}';";
                return DBConnection.myCommand.ExecuteScalar().ToString();
            }
            catch
            {
                return null;
            }
        }
        /// <summary>
        ///  Добавляет нового клиента в базу данных
        /// </summary>
        /// <param name="login"></param>
        /// <param name="password"></param>
        /// <param name="surname"></param>
        /// <param name="name"></param>
        /// <param name="patronymic"></param>
        /// <param name="email"></param>
        /// <param name="phone"></param>
        /// <param name="idCompany"></param>
        /// <param name="idAccess"></param>
        /// <returns></returns>
        public static bool Add(string login, string password, string surname, string name, string patronymic,
                                string email, string phone, string idCompany, string idAccess)
        {
            try
            {
                DBConnection.myCommand.CommandText =
                    $@"INSERT INTO customers VALUES(null, '{login}', md5('{password}'), '{surname}', '{name}', '{patronymic}', 
                                            '{email}', '{phone}', '{idCompany}', '{idAccess}');";
                if(DBConnection.myCommand.ExecuteNonQuery() != 0)
                    return true;
                else 
                    return false;
            }
            catch
            {
                return false;
            }
        }

        /// <summary>
        /// Обновляет информацию о клиенте в базе данных
        /// </summary>
        /// <param name="idCustomer"></param>
        /// <param name="editPassword"></param>
        /// <param name="login"></param>
        /// <param name="password"></param>
        /// <param name="surname"></param>
        /// <param name="name"></param>
        /// <param name="patronymic"></param>
        /// <param name="email"></param>
        /// <param name="phone"></param>
        /// <param name="idCompany"></param>
        /// <param name="idAccess"></param>
        /// <returns></returns>
        public static bool Update(string idCustomer, bool editPassword, string login, string password, string surname, string name, string patronymic,
                        string email, string phone, string idCompany, string idAccess)
        {
            try
            {
                if (editPassword)
                {
                    DBConnection.myCommand.CommandText =
                        $@"UPDATE customers 
                        SET login = '{login}',
                            password = md5('{password}'), 
                            surname = '{surname}', 
                            name = '{name}', 
                            patronymic = '{patronymic}',
                            email = '{email}', 
                            phone = '{phone}', 
                            idCompany = '{idCompany}', 
                            idAccess = '{idAccess}'
                        WHERE idCustomer = '{idCustomer}';";
                }
                else
                {
                    DBConnection.myCommand.CommandText =
                        $@"UPDATE customers 
                        SET login = '{login}',
                            surname = '{surname}', 
                            name = '{name}', 
                            patronymic = '{patronymic}',
                            email = '{email}', 
                            phone = '{phone}', 
                            idCompany = '{idCompany}', 
                            idAccess = '{idAccess}'
                        WHERE idCustomer = '{idCustomer}';";
                }
                if (DBConnection.myCommand.ExecuteNonQuery() != 0)
                    return true;
                else
                    return false;
            }
            catch
            {
                return false;
            }
        }

        /// <summary>
        /// Обновляет личную информацию клиента без изменения логина и пароля
        /// Метод предназначен для использования самим клиентом в личном кабинете
        /// </summary>
        /// <param name="idCustomer"></param>
        /// <param name="surname"></param>
        /// <param name="name"></param>
        /// <param name="patronymic"></param>
        /// <param name="email"></param>
        /// <param name="phone"></param>
        /// <returns></returns>
        public static bool UpdateForCustomer(string idCustomer, string surname, string name, string patronymic, string email, string phone)
        {
            try
            {
                    DBConnection.myCommand.CommandText =
                        $@"UPDATE customers 
                        SET surname = '{surname}', 
                            name = '{name}', 
                            patronymic = '{patronymic}',
                            email = '{email}', 
                            phone = '{phone}' 
                        WHERE idCustomer = '{idCustomer}';";
                if (DBConnection.myCommand.ExecuteNonQuery() != 0)
                    return true;
                else
                    return false;
            }
            catch
            {
                return false;
            }
        }

    }
}
