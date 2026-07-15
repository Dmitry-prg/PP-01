using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace equipment.Classes
{
    public class Equipments
    {


        public static DataTable dtEquipments = new DataTable();
        public static DataTable dtFilterEquipments = new DataTable();
        public static DataTable dtFindEquipments = new DataTable();


        /// <summary>
        /// Возвращает количество указанного оборудования в наличии
        /// </summary>
        /// <param name="idEquipment"></param>
        /// <returns></returns>
        public static string GetCountEquipment(string idEquipment)
        {
            try
            {
                DBConnection.myCommand.CommandText = $@"SELECT count FROM equipments WHERE idEquipment = '{idEquipment}';";
                return DBConnection.myCommand.ExecuteScalar().ToString();
            }
            catch
            {
                return null;
            }

        }

        /// <summary>
        /// Загружает список искомого оборудования
        /// </summary>
        /// <param name="findString"></param>
        static public void GetListFindEquipments(string findString)
        {
            DBConnection.myCommand.CommandText =
            $@"SELECT   equipments.nameEquipment, 
                            s_typeequipment.nameTypeEquipment, 
                            equipments.price, 
                            equipments.count, 
                            equipments.idEquipment,
                            equipments.idTypeEquipment
                    FROM equipments 
                    LEFT JOIN s_typeequipment ON equipments.idTypeEquipment = s_typeequipment.idTypeEquipment
                    WHERE   equipments.nameEquipment LIKE '%{findString}%';";
            dtFindEquipments.Clear();
            DBConnection.myDataAdapter.Fill(dtFindEquipments);
        }

        /// <summary>
        /// Загружает полный список оборудования
        /// </summary>
        public static void GetList()
        {
            DBConnection.myCommand.CommandText = 
                $@"SELECT   equipments.nameEquipment, 
                            s_typeequipment.nameTypeEquipment, 
                            equipments.price, 
                            equipments.count, 
                            equipments.idEquipment,
                            equipments.idTypeEquipment
                    FROM equipments 
                    LEFT JOIN s_typeequipment ON equipments.idTypeEquipment = s_typeequipment.idTypeEquipment;";
            dtEquipments.Clear();
            DBConnection.myDataAdapter.Fill(dtEquipments);
        }

        /// <summary>
        /// Загружает список оборудования указанного типа
        /// </summary>
        /// <param name="idTypeEquipment"></param>
        public static void GetListFilter(string idTypeEquipment)
        {
            DBConnection.myCommand.CommandText =
                $@"SELECT   equipments.nameEquipment, 
                            s_typeequipment.nameTypeEquipment, 
                            equipments.price, 
                            equipments.count, 
                            equipments.idEquipment,
                            equipments.idTypeEquipment 
                    FROM equipments 
                    LEFT JOIN s_typeequipment ON equipments.idTypeEquipment = s_typeequipment.idTypeEquipment
                    WHERE equipments.idTypeEquipment = '{idTypeEquipment}';";
            dtFilterEquipments.Clear();
            DBConnection.myDataAdapter.Fill(dtFilterEquipments);
        }

        /// <summary>
        /// Проверяет наличие дубликатов оборудования
        /// </summary>
        /// <param name="name"></param>
        /// <returns></returns>
        public static bool CheckDuplicate(string name)
        {
            try
            {
                DBConnection.myCommand.CommandText = $@"SELECT nameEquipment FROM equipments WHERE nameEquipment = '{name}';";
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
        /// Проверяет возможность удаления указанного оборудования
        /// </summary>
        /// <param name="id"></param>
        /// <returns></returns>
        public static bool CheckDelete(string id)
        {
            try
            {
                int result = 0;
                DBConnection.myCommand.CommandText = $@"SELECT * FROM equipmentonorder WHERE idEquipment = '{id}';";
                result += DBConnection.myCommand.ExecuteNonQuery();
                DBConnection.myCommand.CommandText = $@"SELECT * FROM equipmentoninvoice WHERE idEquipment = '{id}';";
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
        /// Добавляет новое оборудование
        /// </summary>
        /// <param name="nameEquipment"></param>
        /// <param name="idTypeEquipment"></param>
        /// <param name="price"></param>
        /// <param name="count"></param>
        /// <returns></returns>
        public static bool Add(string nameEquipment, string idTypeEquipment, string price, string count)
        {
            try
            {
                DBConnection.myCommand.CommandText = 
                    $@"INSERT INTO equipments 
                       VALUES(null, '{nameEquipment}', '{idTypeEquipment}', '{price}', '{count}');";
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
        /// Обновляет информацию об оборудовании
        /// </summary>
        /// <param name="id"></param>
        /// <param name="nameEquipment"></param>
        /// <param name="idTypeEquipment"></param>
        /// <param name="price"></param>
        /// <param name="count"></param>
        /// <returns></returns>
        public static bool Update(string id, string nameEquipment, string idTypeEquipment, string price, string count)
        {
            try
            {
                DBConnection.myCommand.CommandText =
                    $@"UPDATE equipments 
                       SET  nameEquipment = '{nameEquipment}', 
                            idTypeEquipment = '{idTypeEquipment}', 
                            price = '{price}', 
                            count = '{count}'
                        WHERE idEquipment = '{id}';";
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
        /// Удаляет запись оборудования
        /// </summary>
        /// <param name="id"></param>
        /// <returns></returns>
        public static bool Delete(string id)
        {
            try
            {
                DBConnection.myCommand.CommandText = $@"DELETE FROM equipments WHERE idEquipment = '{id}';";
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
        /// Метод находит в указанной строке "," и меняет их на "."
        /// </summary>
        /// <param name="str"></param>
        /// <returns></returns>
        static public string ConvertDecimal(string str)
        {
            string result = "";
            for (int i = 0; i < str.Length; i++)
            {
                if (str[i] == ',')
                {
                    result += ".";
                }
                else
                {
                    result += str[i];
                }
            }

            return result;
        }
    }
}
