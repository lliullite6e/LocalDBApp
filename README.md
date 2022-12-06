﻿Данное приложение демонстрирует пример подключения к локальной базе данных с помощью класса SqlConnection и манипулирования данными классом SqlCommand.

Прежде чем запускать проект нужно создать базу данных, подключиться к базе данных и добавить источник данных.
 
# Создание базы данных

**Внимание! Если у Вас есть файл базы данных %UserProfile%\DBShop.mdf и вы хотите сохранить его, то переименуйте его, так как запрос, который надо будет выполнить далее, удалит эту базу DBShop для создания новой.**

Выполните запрос SQLQuery\SQLQuery_CreareTables.sql для создания базы данных и таблиц.

База данных состоит из 4 таблиц, соответствующих схеме:

![схема](/image/scheme.jpg "text")

# Подключение к базе данных в Visual Studio

- Откройте окно "Обозреватель серверов" нажатием клавиш CTRL+ALT+S;
- нажмите "Подключиться к базе данных";
- в появившемся окне нажмите "Изменить";
- в новом окне из списка "Источник данных" выбрать "Файл базы данных Microsoft SQL Server" и нажмите "Ок";
- нажмите "Обзор" и в диалоговом окне выберете %UserProfile%\DBShop.mdf, нажмите "Открыть", нажмите "Ок".

# Добавление источника данных в Visual Studio

- Откройте окно "Источники данных" нажатием клавиш CTRL+ALT+D;
- нажмите "Добавить новые источники данных";
- в новом окне выберете "База дынных" и нажмите "Далее";
- выберете "Набор данных" и нажмите "Далее";
- выберете DBShop.mdf из всплывающего списка "Какое подключение ваше приложение должно использовать для работы с базой данных?", нажмите "Далее";
- из списка "Объекты базы данных для набора данных" поставить галочку напротив "Таблицы", нажмите "Готово".

Теперь можно запускать проект. На главной форме имеются 4 вкладки для отображения данных таблиц и 3 кнопки для их модификаций. Кнопки "Добавить" и "Изменить" открывают формы ввода данных таблиц для добавления строки и изменения выбранной строки. Кнопка "Удалить" удаляет выбранную строку из таблицы

![главная форма](/image/mainForm.jpg "text")