
' Объявление DataSet и таблиц, которые мы хотим объединить. Одна из них будет основной, другая - вложенной
Dim mainDataTable As New DataTable
Dim innerDataTable As New DataTable
Dim DtS As New DataSet
Dim DV As New DataView


' Создаём структура Dataset, для удобства при дальнейшем обращении к таблицам, называем их
mainDataTable.TableName = "mainDataTable"
innerDataTable.TableName = "innerDataTable"
' Добавляем в Dataset.Tables
DtS.Tables.Add(mainDataTable)
DtS.Tables.Add(innerDataTable)

' ЗДЕСЬ ВАША ФУНКЦИЯ ЗАПОЛНЕНИЯ ТАБЛИЧЕК. БУДЬ ТО ЗАПРОС К DB ИЛИ ЖЕ РУЧНОЕ ЗАПОЛНЕНИЕ DATATABLE
' ИМЕНА ЯЧЕЕК В ЗАПОЛНЕНЫХ ТАБЛИЧКАХ БУДУТ ПРИВЯЗКОЙ ДЛЯ XMAL
Call FillDataTables(mainDataTable, innerDataTable)

' Создаём связь между заполнеными табличками на основании общего поля, даём новой связи имя. 
' В дальнейшем при желании использовать табличку-связь в качестве источника для DataGrid, будем обращаться именно по этому имени
Dim myRelation As DataRelation
myRelation = New DataRelation("FusionTable",
				  DtS.Tables("mainDataTable").Columns("Id"),
				  DtS.Tables("innerDataTable").Columns("Id"),
				  False)
DtS.Relations.Add(myRelation)

' Назначаем источник данных для главного DataGrid. Для вложенного делаем это в XMAL
MainDataGrid.ItemsSource = DtS.Tables("mainDataTable").DefaultView



 
