using Microsoft.Office.Interop.Excel;
using Microsoft.Office.Interop.Word;
using Mysqlx.Crud;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Excel = Microsoft.Office.Interop.Excel;
using Word = Microsoft.Office.Interop.Word;


namespace equipment.Classes
{
    internal class DocumentsExport
    {
        /// <summary>
        /// Метод для формирования документа "Акт приёма-передачи"
        /// </summary>
        /// <param name="fName"></param>
        /// <param name="idOrder"></param>
        /// <param name="dateOrder"></param>
        /// <param name="nameCompany"></param>
        public static void Act(string fName, string idOrder, string dateOrder, string nameCompany)
        {
            Excel.Application excelApp = new Excel.Application();
            Workbook workbook;
            Worksheet worksheet;
            try
            {
                string fPath = System.IO.Path.GetDirectoryName(System.Reflection.Assembly.GetExecutingAssembly().Location);
                fPath = fPath.Substring(0, fPath.Length - 10);
                // Создаем экземпляр Excel
                workbook = (excelApp.Workbooks.Open($@"{fPath}\Resources\Акт.xlsx"));

                excelApp.Visible = false;

                // Получаем активный лист
                worksheet = workbook.ActiveSheet;

                object nameEquipment, count, idEquipment, nameTypeEquipment, price, sum;

                int i = 34;
                int counter = 1;
                DBConnection.myCommand.CommandText =
                $@"SELECT 	equipments.nameEquipment,
							equipmentonorder.count,
							equipmentonorder.idEquipment,
		                    s_typeequipment.nameTypeEquipment,
                            equipments.price,
                            equipments.price * equipmentonorder.count as sum
                FROM equipmentonorder
                LEFT JOIN equipments ON equipmentonorder.idEquipment = equipments.idEquipment
                LEFT JOIN s_typeequipment ON equipments.idTypeEquipment = s_typeequipment.idTypeEquipment
                WHERE equipmentonorder.idOrder = '{idOrder}';";
                var readerOrder = DBConnection.myCommand.ExecuteReader();
                if (readerOrder.HasRows)
                {
                    worksheet.Cells[11, "E"] = $"от {dateOrder}";
                    worksheet.Cells[17, "E"] = nameCompany;

                    while (readerOrder.Read())
                    {
                        nameEquipment = readerOrder["nameEquipment"];
                        count = readerOrder["count"];
                        idEquipment = readerOrder["idEquipment"];
                        nameTypeEquipment = readerOrder["nameTypeEquipment"];
                        price = readerOrder["price"];
                        sum = readerOrder["sum"];

                        worksheet.Cells[i, "A"] = counter.ToString();
                        worksheet.Cells[i, "C"] = nameEquipment.ToString();
                        worksheet.Cells[i, "J"] = count.ToString();
                        worksheet.Cells[i, "K"] = idEquipment.ToString();
                        worksheet.Cells[i, "N"] = nameTypeEquipment.ToString();
                        worksheet.Cells[i, "Q"] = price.ToString();
                        worksheet.Cells[i, "R"] = sum.ToString();
                        i++;
                        counter++;
                        worksheet.Rows[i].Insert();
                        Excel.Range range;
                        range = worksheet.Range[$"A{i}:B{i}"];
                        range.MergeCells = true;
                        range.Borders.Weight = 2;
                        range = worksheet.Range[$"C{i}:I{i}"];
                        range.MergeCells = true;
                        range.Borders.Weight = 2;
                        range = worksheet.Range[$"K{i}:M{i}"];
                        range.MergeCells = true;
                        range.Borders.Weight = 2;
                        range = worksheet.Range[$"N{i}:P{i}"];
                        range.MergeCells = true;
                        range.Borders.Weight = 2;
                        range = worksheet.Range[$"A{i}:R{i}"];
                        range.Borders.Weight = 2;
                    }
                    worksheet.Rows[i].Delete();
                    // Сохраняем изменения
                    workbook.SaveAs(fName);
                    workbook.Close(true);
                    MessageBox.Show("Данные сохранены");
                    readerOrder.Close();
                }
                else
                {
                    readerOrder.Close();
                    MessageBox.Show("Нет записей");
                }
                readerOrder.Close();
            }
            catch (System.Runtime.InteropServices.COMException)
            {
                MessageBox.Show("Не удалось сохранить данные!\r\n(Возможно файл открыт в другом приложении)");
            }

        }

        /// <summary>
        /// Метод для формирования документа "Заявка"
        /// </summary>
        /// <param name="nameMedicines"></param>
        /// <param name="idMedicines"></param>
        /// <param name="fName"></param>
        static public void OrderInfo(string nameCompany, string idOrder, string dateOrder, string fName)
        {
            Word.Application wrd = new Word.Application();
            wrd.Visible = false;
            object nameEquipment, nameTypeEquipment, count, explanation;
            object surname = null;
            object name = null;
            object patronymic = null;
            object missing = Type.Missing;
            object oMissing = System.Reflection.Missing.Value;
            string fPath = System.IO.Path.GetDirectoryName(System.Reflection.Assembly.GetExecutingAssembly().Location);
            fPath = fPath.Substring(0, fPath.Length - 10);
            var doc = wrd.Documents.Open($@"{fPath}\Resources\Заявка.docx");
            doc.Activate();
            object defaultTable = WdDefaultTableBehavior.wdWord9TableBehavior;
            object autoFit = WdAutoFitBehavior.wdAutoFitWindow;
            DBConnection.myCommand.CommandText =
                $@"SELECT 	equipments.nameEquipment,
		                    s_typeequipment.nameTypeEquipment,
		                    equipmentonorder.count,
                            equipmentonorder.explanation,
                            customers.surname,
                            customers.name,
                            customers.patronymic
                FROM equipmentonorder
                LEFT JOIN orders ON equipmentonorder.idOrder = orders.idOrder
                LEFT JOIN customers ON orders.idCustomer = customers.idCustomer
                LEFT JOIN equipments ON equipmentonorder.idEquipment = equipments.idEquipment
                LEFT JOIN s_typeequipment ON equipments.idTypeEquipment = s_typeequipment.idTypeEquipment
                WHERE equipmentonorder.idOrder = '{idOrder}';";
            var readerOrder = DBConnection.myCommand.ExecuteReader();
            doc.Bookmarks["idOrder"].Range.Text = idOrder;// заполнили закладки, созданные в Wordе
            doc.Bookmarks["nameCompany"].Range.Text = nameCompany;
            doc.Bookmarks["dateOrder"].Range.Text = dateOrder;
            doc.Tables.Add(doc.Bookmarks["table"].Range, 1, 5, ref defaultTable, ref autoFit);
            doc.Tables[1].Cell(1, 1).Range.Text = "№";
            doc.Tables[1].Cell(1, 2).Range.Text = "Наименование оборудования";
            doc.Tables[1].Cell(1, 3).Range.Text = "Тип оборудования";
            doc.Tables[1].Cell(1, 4).Range.Text = "Количество";
            doc.Tables[1].Cell(1, 5).Range.Text = "Обоснование";
            int i = 1;
            if (readerOrder.HasRows)
            {
                while (readerOrder.Read())
                {
                    i++;
                    nameEquipment = readerOrder["nameEquipment"];
                    nameTypeEquipment = readerOrder["nameTypeEquipment"];
                    count = readerOrder["count"];
                    explanation = readerOrder["explanation"];
                    surname = readerOrder["surname"];
                    name = readerOrder["name"];
                    patronymic = readerOrder["patronymic"];
                    doc.Tables[1].Rows.Add(ref oMissing);
                    doc.Tables[1].Cell(i, 1).Range.Text = (i-1).ToString();
                    doc.Tables[1].Cell(i, 2).Range.Text = nameEquipment.ToString();
                    doc.Tables[1].Cell(i, 3).Range.Text = nameTypeEquipment.ToString();
                    doc.Tables[1].Cell(i, 4).Range.Text = count.ToString();
                    doc.Tables[1].Cell(i, 5).Range.Text = explanation.ToString();
                    
                }
                doc.Bookmarks["fio"].Range.Text = surname.ToString() + " " + name.ToString() + " " + patronymic.ToString();
                doc.Saved = true;
                doc.SaveAs2($@"{fName}.docx");
                MessageBox.Show("Данные сохранены в doc-файле!");
                doc.SaveAs2($@"{fName}.pdf", WdSaveFormat.wdFormatPDF);
                MessageBox.Show("Данные сохранены в pdf-файле!");
            }
            else
            {
                MessageBox.Show("Состава выбранной заявки не найдено!");
            }
            doc.Close(true);
        }
    }
}
