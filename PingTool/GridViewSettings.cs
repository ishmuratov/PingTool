﻿using System;
using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;

namespace PingTool
{
    class GridViewSettings
    {
        public static void Setup(DataGridView myDataGrid, Color _color)
        {
            myDataGrid.ColumnCount = 3;
            myDataGrid.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            myDataGrid.AllowUserToResizeRows = false;
            myDataGrid.RowHeadersVisible = false;
            // Шрифт шапки таблицы
            myDataGrid.EnableHeadersVisualStyles = false;
            myDataGrid.ColumnHeadersDefaultCellStyle.Font = new Font("Tahoma", 9f, FontStyle.Bold);
            myDataGrid.ColumnHeadersDefaultCellStyle.BackColor = Color.DarkSlateBlue; //cell color
            myDataGrid.ColumnHeadersDefaultCellStyle.ForeColor = Color.WhiteSmoke; //text color
            // Шапка таблицы
            myDataGrid.Columns[0].Name = "Адрес хоста";
            myDataGrid.Columns[0].Width = 150;
            myDataGrid.Columns[0].SortMode = DataGridViewColumnSortMode.NotSortable;
            myDataGrid.Columns[1].Name = "Имя хоста";
            myDataGrid.Columns[1].Width = 150;
            myDataGrid.Columns[1].SortMode = DataGridViewColumnSortMode.NotSortable;
            myDataGrid.Columns[2].Name = "Состояние";
            myDataGrid.Columns[2].Width = 150;
            myDataGrid.Columns[2].DefaultCellStyle.ForeColor = _color;
            myDataGrid.Columns[2].DefaultCellStyle.Font = new Font("Tahoma", 9, FontStyle.Bold);
            myDataGrid.Columns[2].SortMode = DataGridViewColumnSortMode.NotSortable;
            // Убрать курсор
            myDataGrid.ClearSelection();
        }

        // View all notes in GrigView
        public static void ViewNotes(DataGridView myDataGrid, List<Host> _data, AppSettings mailSettings)
        {
            Color statusCellColor;
            myDataGrid.Rows.Clear();
            string[] newRow = new string[3];
            foreach (Host anyNote in _data)
            {
                newRow[0] = anyNote.IP;
                newRow[1] = anyNote.Name;
                if (anyNote.OfflineCounter >= 2)
                {
                    newRow[2] = "Не отвечает";
                    statusCellColor = Color.Orange;
                    Logger.Log($"{DateTime.Now.ToString()}: Хост {anyNote.IP} / {anyNote.Name} не отвечает!");
                    if (!anyNote.FailMailSended)
                    {
                        SendMail("Обнаружена проблема!", $"{DateTime.Now.ToString()}: Хост {anyNote.IP} / {anyNote.Name} не отвечает!", mailSettings);
                        anyNote.FailMailSended = true;
                        anyNote.OKMailNeed = true;
                    }
                }
                else
                {
                    anyNote.FailMailSended = false;
                    newRow[2] = "OK!";
                    statusCellColor = Color.White;
                    if (anyNote.OKMailNeed)
                    {
                        Logger.Log($"{DateTime.Now.ToString()}: Хост {anyNote.IP} / {anyNote.Name} снова в работе!");
                        SendMail("Проблема решена!", $"{DateTime.Now.ToString()}: Хост {anyNote.IP} / {anyNote.Name} снова в работе!", mailSettings);
                        anyNote.OKMailNeed = false;
                    }
                }
                myDataGrid.Rows.Add(newRow);
                myDataGrid.Rows[myDataGrid.Rows.Count - 1].DefaultCellStyle.BackColor = statusCellColor;
            }
            // Убрать курсор
            myDataGrid.ClearSelection();
        }

        public static void SendMail(string _subject, string _text, AppSettings mailSettings)
        {
            if (mailSettings.MAIL_DISABLED)
                return;
            Letter testLetter = new Letter();
            testLetter.Subject = _subject;
            testLetter.Body = _text;
            if (mailSettings.MAIL_FROM != "" && mailSettings.MAIL_PASSWORD_FROM != "" && mailSettings.MAIL_TO != "")
            {
                MailSender ms = new MailSender(mailSettings, testLetter);
            }
        }
    }
}
