using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace equipment.Classes
{
    public class Staff
    {
        static public string user;
        static public string role;

        static public DataTable dtStaff = new DataTable();

        /// <summary>
        /// Проверяет уникальность логина в базе данных
        /// </summary>
        /// <param name="login"></param>
        /// <returns></returns>
        public static bool CheckDuplicate(string login)
        {
            try
            {
                DBConnection.myCommand.CommandText = $@"SELECT login FROM staff WHERE login = '{login}';";
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
        ///   Выполняет авторизацию пользователя
        /// </summary>
        /// <param name="login"></param>
        /// <param name="password"></param>
        /// <returns></returns>
        static public bool Autorization(string login, string password)
        {
            try
            {
                DBConnection.myCommand.CommandText = $@"SELECT idPost 
                                                        FROM staff 
                                                        WHERE login = '{login}' 
                                                        and password = md5('{password}');";
                if (DBConnection.myCommand.ExecuteScalar() != null)
                {
                    user = login;
                    role = DBConnection.myCommand.ExecuteScalar().ToString();
                }
                else
                {
                    user = role = null;
                }
                return true;
            }
            catch
            {
                user = role = null;
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
        /// Получает уровень доступа пользователя по логину
        /// </summary>
        /// <param name="login"></param>
        /// <returns></returns>
        public static string CheckAccess(string login)
        {
            try
            {
                DBConnection.myCommand.CommandText = $@"SELECT idAccess 
                                                        FROM staff 
                                                        WHERE login = '{login}';";
                return DBConnection.myCommand.ExecuteScalar().ToString();
            }
            catch
            {
                return null;
            }
        }

        /// <summary>
        /// Получает текущий Id сотрудника
        /// </summary>
        /// <returns></returns>
        public static string GetId()
        {
            try
            {
                DBConnection.myCommand.CommandText = $@"SELECT idStaff 
                                                        FROM staff 
                                                        WHERE login = '{user}';";
                return DBConnection.myCommand.ExecuteScalar().ToString();
            }
            catch
            {
                return null;
            }
        }

        /// <summary>
        /// Загружает полный список сотрудников 
        /// </summary>
        public static void GetListStaff()
        {
            DBConnection.myCommand.CommandText =
                $@"SELECT   staff.login, 
                            staff.password, 
                            staff.surname, 
                            staff.name, 
                            staff.patronymic, 
                            staff.email, 
                            staff.phone,
                            staff.pasportSeries,
                            staff.pasportNumber,
                            s_post.namePost,
                            staff.idPost,
                            s_access.nameAccess,
                            staff.idAccess,
                            staff.idStaff
                    FROM staff 
                    LEFT JOIN s_access ON staff.idAccess = s_access.idAccess
                    LEFT JOIN s_post ON staff.idPost = s_post.idPost;";
            dtStaff.Clear();
            DBConnection.myDataAdapter.Fill(dtStaff);
        }

        /// <summary>
        /// Добавляет нового сотрудника
        /// </summary>
        /// <param name="login"></param>
        /// <param name="password"></param>
        /// <param name="surname"></param>
        /// <param name="name"></param>
        /// <param name="patronymic"></param>
        /// <param name="email"></param>
        /// <param name="phone"></param>
        /// <param name="pasportSeries"></param>
        /// <param name="pasportNumber"></param>
        /// <param name="idAccess"></param>
        /// <param name="idPost"></param>
        /// <returns></returns>
        public static bool Add(string login, string password, string surname, string name, string patronymic, string email,
                                string phone, string pasportSeries, string pasportNumber, string idAccess, string idPost)
        {
            try
            {
                DBConnection.myCommand.CommandText =
                    $@"INSERT INTO staff VALUES(null, '{login}', md5('{password}'), '{surname}', '{name}', '{patronymic}', 
                                   '{email}', '{phone}', '{pasportSeries}', '{pasportNumber}', '{idAccess}', '{idPost}');";
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
        /// Обновляет информацию о сотруднике
        /// </summary>
        /// <param name="idStaff"></param>
        /// <param name="editPassword"></param>
        /// <param name="login"></param>
        /// <param name="password"></param>
        /// <param name="surname"></param>
        /// <param name="name"></param>
        /// <param name="patronymic"></param>
        /// <param name="email"></param>
        /// <param name="phone"></param>
        /// <param name="pasportSeries"></param>
        /// <param name="pasportNumber"></param>
        /// <param name="idAccess"></param>
        /// <param name="idPost"></param>
        /// <returns></returns>
        public static bool Update(string idStaff, bool editPassword, string login, string password, string surname, string name, string patronymic,
                        string email, string phone, string pasportSeries, string pasportNumber, string idAccess, string idPost)
        {
            try
            {
                if (editPassword)
                {
                    DBConnection.myCommand.CommandText =
                        $@"UPDATE staff 
                        SET login = '{login}',
                            password = md5('{password}'), 
                            surname = '{surname}', 
                            name = '{name}', 
                            patronymic = '{patronymic}',
                            email = '{email}', 
                            phone = '{phone}',
                            pasportSeries = '{pasportSeries}',
                            pasportNumber = '{pasportNumber}',
                            idAccess = '{idAccess}',
                            idPost = '{idPost}' 
                        WHERE idStaff = '{idStaff}';";
                }
                else
                {
                    DBConnection.myCommand.CommandText =
                        $@"UPDATE staff 
                        SET login = '{login}',
                            surname = '{surname}', 
                            name = '{name}', 
                            patronymic = '{patronymic}',
                            email = '{email}', 
                            phone = '{phone}', 
                            pasportSeries = '{pasportSeries}',
                            pasportNumber = '{pasportNumber}',
                            idAccess = '{idAccess}',
                            idPost = '{idPost}' 
                        WHERE idStaff = '{idStaff}';";
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

    }
}
