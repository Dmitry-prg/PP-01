using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace equipment.Classes
{
    internal class EquipmentOnInvoice
    {
        public static DataTable dtInvoiceInfo = new DataTable();


        /// <summary>
        /// Получает список оборудования, привязанного к накладной
        /// </summary>
        /// <param name="idInvoice"></param>
        public static void GetListEquipmentOnInvoice(string idInvoice)
        {
            DBConnection.myCommand.CommandText =
                $@"SELECT 	equipments.nameEquipment,
		                    s_typeequipment.nameTypeEquipment,
		                    equipmentoninvoice.count,
                            equipmentoninvoice.idEquipmentOnInvoice,
                            equipmentoninvoice.idEquipment
                FROM equipmentoninvoice
                LEFT JOIN equipments ON equipmentoninvoice.idEquipment = equipments.idEquipment
                LEFT JOIN s_typeequipment ON equipments.idTypeEquipment = s_typeequipment.idTypeEquipment
                WHERE equipmentoninvoice.idInvoice = '{idInvoice}';";
            dtInvoiceInfo.Clear();
            DBConnection.myDataAdapter.Fill(dtInvoiceInfo);
        }

        /// <summary>
        /// Проверяет наличие дубликатов оборудования в накладной
        /// </summary>
        /// <param name="idInvoice"></param>
        /// <param name="idEquipment"></param>
        /// <returns></returns>
        public static bool CheckDuplicate(string idInvoice, string idEquipment)
        {
            try
            {
                DBConnection.myCommand.CommandText =
                    $@"SELECT   idEquipment 
                        FROM    equipmentoninvoice 
                        WHERE   idEquipment = '{idEquipment}' and 
                                idInvoice = '{idInvoice}';";
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
        /// Добавляет новое оборудование в накладную
        /// </summary>
        /// <param name="idInvoice"></param>
        /// <param name="idEquipment"></param>
        /// <param name="count"></param>
        /// <returns></returns>
        public static bool Add(string idInvoice, string idEquipment, string count)
        {
            try
            {
                DBConnection.myCommand.CommandText = $@"INSERT INTO equipmentoninvoice VALUES(null, '{idInvoice}','{idEquipment}', '{count}');";
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
        /// Обновляет информацию об оборудовании в накладной
        /// </summary>
        /// <param name="idEquipmentOnInvoice"></param>
        /// <param name="idEquipment"></param>
        /// <param name="count"></param>
        /// <returns></returns>
        public static bool Update(string idEquipmentOnInvoice, string idEquipment, string count)
        {
            try
            {
                DBConnection.myCommand.CommandText =
                $@"UPDATE equipmentoninvoice 
                    SET idEquipment = '{idEquipment}', 
                        count = '{count}' 
                    WHERE idEquipmentOnInvoice = '{idEquipmentOnInvoice}';";
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
        /// Удаляет запись оборудования из накладной
        /// </summary>
        /// <param name="id"></param>
        /// <returns></returns>
        public static bool Delete(string id)
        {
            try
            {
                DBConnection.myCommand.CommandText = $@"DELETE FROM equipmentoninvoice WHERE idEquipmentOnInvoice = '{id}';";
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
        /// Удаляет все записи оборудования для указанной накладной
        /// </summary>
        /// <param name="idInvoice"></param>
        /// <returns></returns>
        public static bool DeleteForInvoice(string idInvoice)
        {
            try
            {
                var transaction = DBConnection.myCommand.Connection.BeginTransaction();
                DBConnection.myCommand.CommandText = $@"DELETE FROM equipmentoninvoice WHERE idInvoice = '{idInvoice}' ";
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
