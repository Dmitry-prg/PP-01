using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace equipment.Classes
{
    internal class SpCompany
    {
        public static DataTable dtCompany = new DataTable();
        public static DataTable dtCompanyComboBox = new DataTable();


        /// <summary>
        /// получает список всех записей из таблицы s_company
        /// </summary>
        public static void GetList()
        {
            DBConnection.myCommand.CommandText = "SELECT nameCompany, inn, address, idCompany FROM s_company order by nameCompany";
            dtCompany.Clear();
            DBConnection.myDataAdapter.Fill(dtCompany);
        }

        /// <summary>
        ///  получает список всех записей из таблицы s_company для отображения в выпадающем списке
        /// </summary>
        public static void GetListComboBox()
        {
            DBConnection.myCommand.CommandText = "SELECT nameCompany, idCompany FROM s_company order by nameCompany";
            dtCompanyComboBox.Clear();
            DBConnection.myDataAdapter.Fill(dtCompanyComboBox);
        }

        /// <summary>
        ///  проверяет наличие дубликатов по ИНН
        /// </summary>
        /// <param name="inn"></param>
        /// <returns></returns>
        public static bool CheckDuplicate(string inn)
        {
            try
            {
                DBConnection.myCommand.CommandText = $@"SELECT inn FROM s_company WHERE inn = '{inn}';";
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
        /// проверяет возможность удаления записи
        /// </summary>
        /// <param name="id"></param>
        /// <returns></returns>
        public static bool CheckDelete(string id)
        {
            try
            {
                int result = 0;
                DBConnection.myCommand.CommandText = $@"SELECT * FROM customers WHERE idCompany = '{id}';";
                result += DBConnection.myCommand.ExecuteNonQuery();
                if (result == 0)
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
        /// добавляет новую запись
        /// </summary>
        /// <param name="name"></param>
        /// <param name="inn"></param>
        /// <param name="address"></param>
        /// <returns></returns>
        public static bool Add(string name, string inn, string address)
        {
            try
            {
                DBConnection.myCommand.CommandText = $@"INSERT INTO s_company VALUES(null, '{name}', '{inn}', '{address}');";
                if (DBConnection.myCommand.ExecuteNonQuery() > 0)
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
        /// обновляет существующую запись
        /// </summary>
        /// <param name="id"></param>
        /// <param name="name"></param>
        /// <param name="inn"></param>
        /// <param name="address"></param>
        /// <returns></returns>
        public static bool Update(string id, string name, string inn, string address)
        {
            try
            {
                DBConnection.myCommand.CommandText = 
                    $@"UPDATE s_company 
                    SET nameCompany = '{name}', 
                        inn = '{inn}',
                        address = '{address}' 
                    WHERE idCompany = '{id}'";
                if (DBConnection.myCommand.ExecuteNonQuery() > 0)
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
        ///  удаляет запись
        /// </summary>
        /// <param name="id"></param>
        /// <returns></returns>
        public static bool Delete(string id)
        {
            try
            {
                DBConnection.myCommand.CommandText = $@"DELETE FROM s_company WHERE idCompany = '{id}';";
                if (DBConnection.myCommand.ExecuteNonQuery() > 0)
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
