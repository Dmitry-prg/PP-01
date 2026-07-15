using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace equipment.Classes
{
    internal class Orders
    {
        public static DataTable dtOrders = new DataTable();
        public static DataTable dtFilterOrders = new DataTable();


        /// <summary>
        /// Получает полный список всех заявок из базы данных
        /// </summary>
        public static void GetListOrders()
        {
            DBConnection.myCommand.CommandText =
                $@"SELECT   orders.idOrder, 
                            orders.dateOrder,
                            s_company.nameCompany,
                            s_statusorder.nameStatusOrder,
                            SUM(equipmentonorder.count * equipments.price) AS cost, 
                            COALESCE(CONCAT(staff.surname, ' ', staff.name, ' ', staff.patronymic), 'Не назначен') as fioManager,
                            orders.idStaff
                FROM orders 
                LEFT JOIN equipmentonorder ON equipmentonorder.idOrder = orders.idOrder
				LEFT JOIN equipments ON equipmentonorder.idEquipment = equipments.idEquipment
                LEFT JOIN customers ON orders.idCustomer = customers.idCustomer
                LEFT JOIN s_company ON customers.idCompany = s_company.idCompany
                LEFT JOIN staff ON orders.idStaff = staff.idStaff
                LEFT JOIN s_statusorder ON orders.idStatusOrder = s_statusorder.idStatusOrder
                GROUP BY    orders.idOrder, 
                            s_company.nameCompany,
                            s_statusorder.nameStatusOrder;"; 
            dtOrders.Clear();
            DBConnection.myDataAdapter.Fill(dtOrders);
        }

        /// <summary>
        /// Получает список заказов по конкретному клиенту
        /// </summary>
        /// <param name="idCustomer"></param>
        public static void GetListCustomerOrders(string idCustomer)
        {
            DBConnection.myCommand.CommandText =
                $@"SELECT   orders.idOrder, 
                            orders.dateOrder,
                            s_statusorder.nameStatusOrder,
                            SUM(equipmentonorder.count * equipments.price) AS cost, 
                            COALESCE(CONCAT(staff.surname, ' ', staff.name, ' ', staff.patronymic), 'Не назначен') as fioManager
                FROM orders 
                LEFT JOIN equipmentonorder ON equipmentonorder.idOrder = orders.idOrder
				LEFT JOIN equipments ON equipmentonorder.idEquipment = equipments.idEquipment
                LEFT JOIN customers ON orders.idCustomer = customers.idCustomer
                LEFT JOIN staff ON orders.idStaff = staff.idStaff
                LEFT JOIN s_statusorder ON orders.idStatusOrder = s_statusorder.idStatusOrder
                WHERE orders.idCustomer = {idCustomer}
                GROUP BY    orders.idOrder, 
                            s_statusorder.nameStatusOrder;";
            dtOrders.Clear();
            DBConnection.myDataAdapter.Fill(dtOrders);
        }

        /// <summary>
        /// Получает список заявок по статусу
        /// </summary>
        /// <param name="idStatusOrder"></param>
        public static void GetListFilterStatusOrders(string idStatusOrder)
        {
            DBConnection.myCommand.CommandText =
                $@"SELECT   orders.idOrder,
                            orders.dateOrder,
                            s_company.nameCompany,
                            s_statusorder.nameStatusOrder,
                            SUM(equipmentonorder.count * equipments.price) AS cost, 
                            COALESCE(CONCAT(staff.surname, ' ', staff.name, ' ', staff.patronymic), 'Не назначен') as fioManager,
                            orders.idStaff
                FROM orders 
                LEFT JOIN equipmentonorder ON equipmentonorder.idOrder = orders.idOrder
				LEFT JOIN equipments ON equipmentonorder.idEquipment = equipments.idEquipment
                LEFT JOIN customers ON orders.idCustomer = customers.idCustomer
                LEFT JOIN s_company ON customers.idCompany = s_company.idCompany
                LEFT JOIN staff ON orders.idStaff = staff.idStaff
                LEFT JOIN s_statusorder ON orders.idStatusOrder = s_statusorder.idStatusOrder
                WHERE orders.idStatusOrder = '{idStatusOrder}'
                GROUP BY    orders.idOrder, 
                            s_company.nameCompany,
                            s_statusorder.nameStatusOrder;";
            dtFilterOrders.Clear();
            DBConnection.myDataAdapter.Fill(dtFilterOrders);
        }


        public static void GetListFilterCustomerOrders(string idCustomer, string idStatusOrder)
        {
            DBConnection.myCommand.CommandText =
                $@"SELECT   orders.idOrder, 
                            orders.dateOrder,
                            s_statusorder.nameStatusOrder,
                            SUM(equipmentonorder.count * equipments.price) AS cost, 
                            COALESCE(CONCAT(staff.surname, ' ', staff.name, ' ', staff.patronymic), 'Не назначен') as fioManager
                FROM orders 
                LEFT JOIN equipmentonorder ON equipmentonorder.idOrder = orders.idOrder
				LEFT JOIN equipments ON equipmentonorder.idEquipment = equipments.idEquipment
                LEFT JOIN customers ON orders.idCustomer = customers.idCustomer
                LEFT JOIN staff ON orders.idStaff = staff.idStaff
                LEFT JOIN s_statusorder ON orders.idStatusOrder = s_statusorder.idStatusOrder
                WHERE orders.idCustomer = {idCustomer} and orders.idStatusOrder = '{idStatusOrder}'
                GROUP BY    orders.idOrder, 
                            s_statusorder.nameStatusOrder;";
            dtFilterOrders.Clear();
            DBConnection.myDataAdapter.Fill(dtFilterOrders);
        }


        /// <summary>
        /// Получает текущий статус заявки
        /// </summary>
        /// <param name="idOrder"></param>
        /// <returns></returns>
        public static string GetStatusOrder(string idOrder)
        {
            try
            {
                DBConnection.myCommand.CommandText = $@"SELECT idStatusOrder FROM orders WHERE idOrder = '{idOrder}';";
                return DBConnection.myCommand.ExecuteScalar().ToString();
            }
            catch
            {
                return null;
            }
        }
        /// <summary>
        /// Устанавливает новый статус заявки
        /// </summary>
        /// <param name="idOrder"></param>
        /// <param name="idStatusOrder"></param>
        /// <param name="idStaff"></param>
        /// <returns></returns>
        public static bool SetStatusOrder(string idOrder, string idStatusOrder, string idStaff)
        {
            try
            {
                DBConnection.myCommand.CommandText = 
                    $@"UPDATE orders 
                    SET idStatusOrder = '{idStatusOrder}',
                        idStaff = '{idStaff}'
                    WHERE idOrder = '{idOrder}';";
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
        /// Получает максимальный ID заявки
        /// </summary>
        /// <returns></returns>
        public static string GetMaxIdOrder()
        {
            try
            {
                DBConnection.myCommand.CommandText = $@"SELECT MAX(idOrder) FROM orders;";
                return DBConnection.myCommand.ExecuteScalar().ToString();
            }
            catch
            {
                return null;
            }
        }

        /// <summary>
        /// Обновляет заявку
        /// </summary>
        /// <param name="idOrder"></param>
        /// <param name="dateOrder"></param>
        /// <returns></returns>
        public static bool Update(string idOrder, string dateOrder)
        {
            try
            {
                DBConnection.myCommand.CommandText =
                    $@"UPDATE orders 
                    SET dateOrder = '{dateOrder}'
                    WHERE idOrder = '{idOrder}';";
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
        /// Добавляет новую заявку
        /// </summary>
        /// <param name="idCustomer"></param>
        /// <param name="dateOrder"></param>
        /// <returns></returns>
        public static bool Add(string idCustomer, string dateOrder)
        {
            try
            {
                DBConnection.myCommand.CommandText = $@"INSERT INTO orders VALUES(null, '{idCustomer}', 3, null, '{dateOrder}');";
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
        /// Удаляет заявку
        /// </summary>
        /// <param name="id"></param>
        /// <returns></returns>
        public static bool Delete(string id)
        {
            try
            {
                DBConnection.myCommand.CommandText = $@"DELETE FROM orders WHERE idOrder = '{id}';";
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
