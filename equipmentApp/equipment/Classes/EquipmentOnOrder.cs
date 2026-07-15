using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace equipment.Classes
{
    internal class EquipmentOnOrder
    {
        public static DataTable dtOrderInfo = new DataTable();

        /// <summary>
        /// Получает список оборудования, привязанного к заявке
        /// </summary>
        /// <param name="idOrder"></param>
        public static void GetListEquipmentOnOrder(string idOrder)
        {
            DBConnection.myCommand.CommandText =
                $@"SELECT 	equipments.nameEquipment,
		                    s_typeequipment.nameTypeEquipment,
		                    equipmentonorder.count,
                            equipmentonorder.explanation,
                            equipmentonorder.idEquipmentOnOrder,
                            equipmentonorder.idEquipment
                FROM equipmentonorder
                LEFT JOIN equipments ON equipmentonorder.idEquipment = equipments.idEquipment
                LEFT JOIN s_typeequipment ON equipments.idTypeEquipment = s_typeequipment.idTypeEquipment
                WHERE equipmentonorder.idOrder = '{idOrder}';";
            dtOrderInfo.Clear();
            DBConnection.myDataAdapter.Fill(dtOrderInfo);
        }

        /// <summary>
        /// Проверяет наличие дубликатов оборудования в заявке
        /// </summary>
        /// <param name="idOrder"></param>
        /// <param name="idEquipment"></param>
        /// <returns></returns>
        public static bool CheckDuplicate(string idOrder, string idEquipment)
        {
            try
            {
                DBConnection.myCommand.CommandText = 
                    $@"SELECT idEquipment 
                        FROM    equipmentonorder 
                        WHERE   idEquipment = '{idEquipment}' and 
                                idOrder = '{idOrder}';";
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
        /// Добавляет новое оборудование в заявку
        /// </summary>
        /// <param name="idOrder"></param>
        /// <param name="idEquipment"></param>
        /// <param name="count"></param>
        /// <param name="explanation"></param>
        /// <returns></returns>
        public static bool Add(string idOrder, string idEquipment, string count, string explanation)
        {
            try
            {
                DBConnection.myCommand.CommandText = $@"INSERT INTO equipmentonorder VALUES(null, '{idOrder}','{idEquipment}', '{count}', '{explanation}');";
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
        /// Обновляет информацию об оборудовании в заявке
        /// </summary>
        /// <param name="idEquipmentOnOrder"></param>
        /// <param name="idEquipment"></param>
        /// <param name="count"></param>
        /// <param name="explanation"></param>
        /// <returns></returns>
        public static bool Update(string idEquipmentOnOrder, string idEquipment, string count, string explanation)
        {
            try
            {
                DBConnection.myCommand.CommandText =
                    $@"UPDATE equipmentonorder 
                    SET idEquipment = '{idEquipment}', 
                        count = '{count}', 
                        explanation = '{explanation}' 
                    WHERE idEquipmentOnOrder = '{idEquipmentOnOrder}';";
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
        /// Удаляет запись оборудования из заявки
        /// </summary>
        /// <param name="id"></param>
        /// <returns></returns>
        public static bool Delete(string id)
        {
            try
            {
                DBConnection.myCommand.CommandText = $@"DELETE FROM equipmentonorder WHERE idEquipmentOnOrder = '{id}';";
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
        /// Удаляет все записи оборудования для указанной заявки
        /// </summary>
        /// <param name="idOrder"></param>
        /// <returns></returns>
        public static bool DeleteForOrder(string idOrder)
        {
            try
            {
                var transaction = DBConnection.myCommand.Connection.BeginTransaction();
                DBConnection.myCommand.CommandText = $@"DELETE FROM equipmentonorder WHERE idOrder = '{idOrder}' ";
                DBConnection.myCommand.ExecuteNonQuery();
                transaction.Commit();
                return true;
            }
            catch
            {
                return false;
            }
        }
    }
}
