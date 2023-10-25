# DataSet объединение DataTable
## Проект представляет собой пример объединения двух таблиц DataTable, используя DataSet. Одна из таблиц является основной, вторая - вложенной.

**Основные шаги:**

1. Объявление DataSet и DataTable.
2. Создание структуры DataSet и добавление таблиц с именами.
3. Функция заполнения таблиц (может быть запрос к базе данных или ручное заполнение).
4. Создание связи между таблицами на основе общего поля.
5. Назначение источника данных для главного DataGrid. Для вложенного - в XAML.

**В репозитории также представлена картинка с готовым DataGrid и примером XAML.**

**Преимущества использования:**
Использование такого рода отображения данных особенно удобно в ситуациях, когда необходимо избежать повторений строк с одинаковой информацией. 
Вместо того чтобы дублировать строки с одинаковыми данными, все повторяющиеся строки объединяются в одну, что делает отображение более чистым и удобочитаемым.

**Без вложенного DataGrid:**      

![image](https://github.com/novikovadaria/UsingDataSet_WPF/assets/107907983/8568653f-7fbd-4ee5-8eab-7f63f532a27a)


 **С вложенным DataGrid:**
 
 ![image](https://github.com/novikovadaria/UsingDataSet_WPF/assets/107907983/4e952aff-9472-42b0-9e78-70c403abc009)



# DataSet Merging with DataTable
## This project showcases how to merge two DataTables using DataSet. One table serves as the main table and the other as the nested one.

**Key Steps:**

1. Declare DataSet and DataTable.
2. Set up the DataSet structure and add tables with names.
3. A function to populate the tables (can be a database query or manual filling).
4. Establish a relationship between the tables based on a common field.
5. Assign data source to the main DataGrid. For the nested one, it's done in XAML.

**The repository also features an image of the completed DataGrid and a XAML example.**

**Advantages of Using This Approach:**
Utilizing this kind of data representation is especially beneficial when looking to avoid repetitive rows with the same information. 
Instead of duplicating rows with identical data, all repeating rows are merged into one, making the display much cleaner and more readable.

**Without Nested DataGrid:**      

![image](https://github.com/novikovadaria/UsingDataSet_WPF/assets/107907983/8568653f-7fbd-4ee5-8eab-7f63f532a27a)


 **With Neste DataGrid:**
 
 ![image](https://github.com/novikovadaria/UsingDataSet_WPF/assets/107907983/4e952aff-9472-42b0-9e78-70c403abc009)
