using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace equipment.Classes
{
    internal class SpPost
    {
        public static DataTable dtPost = new DataTable();

        /// <summary>
        /// получает список всех записей из таблицы s_post
        /// </summary>
        public static void GetList()
        {
            DBConnection.myCommand.CommandText = "SELECT namePost, idPost FROM s_post order by namePost";
            dtPost.Clear();
            DBConnection.myDataAdapter.Fill(dtPost);
        }

        /// <summary>
        /// проверяет наличие дубликатов по имени
        /// </summary>
        /// <param name="name"></param>
        /// <returns></returns>
        public static bool CheckDuplicate(string name)
        {
            try
            {
                DBConnection.myCommand.CommandText = $@"SELECT namePost FROM s_post WHERE namePost = '{name}';";
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
                DBConnection.myCommand.CommandText = $@"SELECT * FROM staff WHERE idPost = '{id}';";
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
        /// <returns></returns>
        public static bool Add(string name)
        {
            try
            {
                DBConnection.myCommand.CommandText = $@"INSERT INTO s_post VALUES(null, '{name}');";
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
        /// <returns></returns>
        public static bool Update(string id, string name)
        {
            try
            {
                DBConnection.myCommand.CommandText = $@"UPDATE s_post SET namePost = '{name}' WHERE idPost = '{id}'";
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
        /// удаляет запись
        /// </summary>
        /// <param name="id"></param>
        /// <returns></returns>
        public static bool Delete(string id)
        {
            try
            {
                DBConnection.myCommand.CommandText = $@"DELETE FROM s_post WHERE idPost = '{id}';";
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
