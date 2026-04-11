<a name='assembly'></a>
# Study.LabWork1

## Contents

- [Document](#T-Study-LabWork1-Features-Task2-Document 'Study.LabWork1.Features.Task2.Document')
  - [Add()](#M-Study-LabWork1-Features-Task2-Document-Add-Study-LabWork1-Features-Task2-Element- 'Study.LabWork1.Features.Task2.Document.Add(Study.LabWork1.Features.Task2.Element)')
  - [Export(visitor)](#M-Study-LabWork1-Features-Task2-Document-Export-Study-LabWork1-Features-Task2-IVisitor- 'Study.LabWork1.Features.Task2.Document.Export(Study.LabWork1.Features.Task2.IVisitor)')
- [Element](#T-Study-LabWork1-Features-Task2-Element 'Study.LabWork1.Features.Task2.Element')
  - [Accept(visitor)](#M-Study-LabWork1-Features-Task2-Element-Accept-Study-LabWork1-Features-Task2-IVisitor- 'Study.LabWork1.Features.Task2.Element.Accept(Study.LabWork1.Features.Task2.IVisitor)')
- [HtmlVisitor](#T-Study-LabWork1-Features-Task2-HtmlVisitor 'Study.LabWork1.Features.Task2.HtmlVisitor')
  - [GetResult()](#M-Study-LabWork1-Features-Task2-HtmlVisitor-GetResult 'Study.LabWork1.Features.Task2.HtmlVisitor.GetResult')
  - [Visit(paragraph)](#M-Study-LabWork1-Features-Task2-HtmlVisitor-Visit-Study-LabWork1-Features-Task2-Paragraph- 'Study.LabWork1.Features.Task2.HtmlVisitor.Visit(Study.LabWork1.Features.Task2.Paragraph)')
  - [Visit(image)](#M-Study-LabWork1-Features-Task2-HtmlVisitor-Visit-Study-LabWork1-Features-Task2-Image- 'Study.LabWork1.Features.Task2.HtmlVisitor.Visit(Study.LabWork1.Features.Task2.Image)')
  - [Visit(table)](#M-Study-LabWork1-Features-Task2-HtmlVisitor-Visit-Study-LabWork1-Features-Task2-Table- 'Study.LabWork1.Features.Task2.HtmlVisitor.Visit(Study.LabWork1.Features.Task2.Table)')
- [IRunService](#T-Study-LabWork1-Shared-Abstractions-IRunService 'Study.LabWork1.Shared.Abstractions.IRunService')
  - [RunTask1()](#M-Study-LabWork1-Shared-Abstractions-IRunService-RunTask1 'Study.LabWork1.Shared.Abstractions.IRunService.RunTask1')
  - [RunTask2()](#M-Study-LabWork1-Shared-Abstractions-IRunService-RunTask2 'Study.LabWork1.Shared.Abstractions.IRunService.RunTask2')
  - [RunTask3()](#M-Study-LabWork1-Shared-Abstractions-IRunService-RunTask3 'Study.LabWork1.Shared.Abstractions.IRunService.RunTask3')
- [IVisitor](#T-Study-LabWork1-Features-Task2-IVisitor 'Study.LabWork1.Features.Task2.IVisitor')
  - [Visit(paragraph)](#M-Study-LabWork1-Features-Task2-IVisitor-Visit-Study-LabWork1-Features-Task2-Paragraph- 'Study.LabWork1.Features.Task2.IVisitor.Visit(Study.LabWork1.Features.Task2.Paragraph)')
  - [Visit(image)](#M-Study-LabWork1-Features-Task2-IVisitor-Visit-Study-LabWork1-Features-Task2-Image- 'Study.LabWork1.Features.Task2.IVisitor.Visit(Study.LabWork1.Features.Task2.Image)')
  - [Visit(table)](#M-Study-LabWork1-Features-Task2-IVisitor-Visit-Study-LabWork1-Features-Task2-Table- 'Study.LabWork1.Features.Task2.IVisitor.Visit(Study.LabWork1.Features.Task2.Table)')
- [Image](#T-Study-LabWork1-Features-Task2-Image 'Study.LabWork1.Features.Task2.Image')
  - [#ctor(src,alt)](#M-Study-LabWork1-Features-Task2-Image-#ctor-System-String,System-String- 'Study.LabWork1.Features.Task2.Image.#ctor(System.String,System.String)')
  - [Alt](#P-Study-LabWork1-Features-Task2-Image-Alt 'Study.LabWork1.Features.Task2.Image.Alt')
  - [Src](#P-Study-LabWork1-Features-Task2-Image-Src 'Study.LabWork1.Features.Task2.Image.Src')
  - [Accept(visitor)](#M-Study-LabWork1-Features-Task2-Image-Accept-Study-LabWork1-Features-Task2-IVisitor- 'Study.LabWork1.Features.Task2.Image.Accept(Study.LabWork1.Features.Task2.IVisitor)')
- [MarkdownVisitor](#T-Study-LabWork1-Features-Task2-MarkdownVisitor 'Study.LabWork1.Features.Task2.MarkdownVisitor')
  - [GetResult()](#M-Study-LabWork1-Features-Task2-MarkdownVisitor-GetResult 'Study.LabWork1.Features.Task2.MarkdownVisitor.GetResult')
  - [Visit(paragraph)](#M-Study-LabWork1-Features-Task2-MarkdownVisitor-Visit-Study-LabWork1-Features-Task2-Paragraph- 'Study.LabWork1.Features.Task2.MarkdownVisitor.Visit(Study.LabWork1.Features.Task2.Paragraph)')
  - [Visit(image)](#M-Study-LabWork1-Features-Task2-MarkdownVisitor-Visit-Study-LabWork1-Features-Task2-Image- 'Study.LabWork1.Features.Task2.MarkdownVisitor.Visit(Study.LabWork1.Features.Task2.Image)')
  - [Visit(table)](#M-Study-LabWork1-Features-Task2-MarkdownVisitor-Visit-Study-LabWork1-Features-Task2-Table- 'Study.LabWork1.Features.Task2.MarkdownVisitor.Visit(Study.LabWork1.Features.Task2.Table)')
- [Paragraph](#T-Study-LabWork1-Features-Task2-Paragraph 'Study.LabWork1.Features.Task2.Paragraph')
  - [#ctor(text)](#M-Study-LabWork1-Features-Task2-Paragraph-#ctor-System-String- 'Study.LabWork1.Features.Task2.Paragraph.#ctor(System.String)')
  - [Text](#P-Study-LabWork1-Features-Task2-Paragraph-Text 'Study.LabWork1.Features.Task2.Paragraph.Text')
  - [Accept(visitor)](#M-Study-LabWork1-Features-Task2-Paragraph-Accept-Study-LabWork1-Features-Task2-IVisitor- 'Study.LabWork1.Features.Task2.Paragraph.Accept(Study.LabWork1.Features.Task2.IVisitor)')
- [Program](#T-Study-LabWork1-Program 'Study.LabWork1.Program')
  - [RUN_TASK_NUMBER](#F-Study-LabWork1-Program-RUN_TASK_NUMBER 'Study.LabWork1.Program.RUN_TASK_NUMBER')
  - [Main()](#M-Study-LabWork1-Program-Main 'Study.LabWork1.Program.Main')
- [RunService](#T-Study-LabWork1-Shared-Services-RunService 'Study.LabWork1.Shared.Services.RunService')
  - [RunTask1()](#M-Study-LabWork1-Shared-Services-RunService-RunTask1 'Study.LabWork1.Shared.Services.RunService.RunTask1')
  - [RunTask2()](#M-Study-LabWork1-Shared-Services-RunService-RunTask2 'Study.LabWork1.Shared.Services.RunService.RunTask2')
  - [RunTask3()](#M-Study-LabWork1-Shared-Services-RunService-RunTask3 'Study.LabWork1.Shared.Services.RunService.RunTask3')
- [Table](#T-Study-LabWork1-Features-Task2-Table 'Study.LabWork1.Features.Task2.Table')
  - [#ctor(rows,columns)](#M-Study-LabWork1-Features-Task2-Table-#ctor-System-Int32,System-Int32- 'Study.LabWork1.Features.Task2.Table.#ctor(System.Int32,System.Int32)')
  - [Columns](#P-Study-LabWork1-Features-Task2-Table-Columns 'Study.LabWork1.Features.Task2.Table.Columns')
  - [Rows](#P-Study-LabWork1-Features-Task2-Table-Rows 'Study.LabWork1.Features.Task2.Table.Rows')
  - [Accept(visitor)](#M-Study-LabWork1-Features-Task2-Table-Accept-Study-LabWork1-Features-Task2-IVisitor- 'Study.LabWork1.Features.Task2.Table.Accept(Study.LabWork1.Features.Task2.IVisitor)')

<a name='T-Study-LabWork1-Features-Task2-Document'></a>
## Document `type`

##### Namespace

Study.LabWork1.Features.Task2

##### Summary

Контейнер документа, содержащий коллекцию элементов

<a name='M-Study-LabWork1-Features-Task2-Document-Add-Study-LabWork1-Features-Task2-Element-'></a>
### Add() `method`

##### Summary

Добавление элемента в документ

##### Parameters

This method has no parameters.

<a name='M-Study-LabWork1-Features-Task2-Document-Export-Study-LabWork1-Features-Task2-IVisitor-'></a>
### Export(visitor) `method`

##### Summary

Экспорт документа с помощью Visitor

##### Returns

Результат преобразования

##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| visitor | [Study.LabWork1.Features.Task2.IVisitor](#T-Study-LabWork1-Features-Task2-IVisitor 'Study.LabWork1.Features.Task2.IVisitor') | Посетитель |

<a name='T-Study-LabWork1-Features-Task2-Element'></a>
## Element `type`

##### Namespace

Study.LabWork1.Features.Task2

##### Summary

Абстрактный класс Element — базовый для всех элементов документа

<a name='M-Study-LabWork1-Features-Task2-Element-Accept-Study-LabWork1-Features-Task2-IVisitor-'></a>
### Accept(visitor) `method`

##### Summary

Метод Accept позволяет посетителю (Visitor) выполнить операцию над элементом

##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| visitor | [Study.LabWork1.Features.Task2.IVisitor](#T-Study-LabWork1-Features-Task2-IVisitor 'Study.LabWork1.Features.Task2.IVisitor') | Посетитель |

<a name='T-Study-LabWork1-Features-Task2-HtmlVisitor'></a>
## HtmlVisitor `type`

##### Namespace

Study.LabWork1.Features.Task2

##### Summary

Посетитель, который экспортирует документ в HTML формат

<a name='M-Study-LabWork1-Features-Task2-HtmlVisitor-GetResult'></a>
### GetResult() `method`

##### Summary

Возвращает результат преобразования документа в HTML.

##### Returns

Строка, содержащая документ в формате HTML

##### Parameters

This method has no parameters.

<a name='M-Study-LabWork1-Features-Task2-HtmlVisitor-Visit-Study-LabWork1-Features-Task2-Paragraph-'></a>
### Visit(paragraph) `method`

##### Summary

Посещает элемент Paragraph и добавляет его в HTML формате.

##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| paragraph | [Study.LabWork1.Features.Task2.Paragraph](#T-Study-LabWork1-Features-Task2-Paragraph 'Study.LabWork1.Features.Task2.Paragraph') | Параграф документа |

<a name='M-Study-LabWork1-Features-Task2-HtmlVisitor-Visit-Study-LabWork1-Features-Task2-Image-'></a>
### Visit(image) `method`

##### Summary

Посещает элемент Image и добавляет его в HTML формате как тег img.

##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| image | [Study.LabWork1.Features.Task2.Image](#T-Study-LabWork1-Features-Task2-Image 'Study.LabWork1.Features.Task2.Image') | Изображение документа |

<a name='M-Study-LabWork1-Features-Task2-HtmlVisitor-Visit-Study-LabWork1-Features-Task2-Table-'></a>
### Visit(table) `method`

##### Summary

Посещает элемент Table и добавляет его в HTML формате как тег table.

##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| table | [Study.LabWork1.Features.Task2.Table](#T-Study-LabWork1-Features-Task2-Table 'Study.LabWork1.Features.Task2.Table') | Таблица документа |

<a name='T-Study-LabWork1-Shared-Abstractions-IRunService'></a>
## IRunService `type`

##### Namespace

Study.LabWork1.Shared.Abstractions

##### Summary

Интерфейс для реализации заданий Л/Р

<a name='M-Study-LabWork1-Shared-Abstractions-IRunService-RunTask1'></a>
### RunTask1() `method`

##### Summary

Запуск выполнения задания 1

##### Parameters

This method has no parameters.

<a name='M-Study-LabWork1-Shared-Abstractions-IRunService-RunTask2'></a>
### RunTask2() `method`

##### Summary

Запуск выполнения задания 2

##### Parameters

This method has no parameters.

<a name='M-Study-LabWork1-Shared-Abstractions-IRunService-RunTask3'></a>
### RunTask3() `method`

##### Summary

Запуск выполнения задания 3

##### Parameters

This method has no parameters.

<a name='T-Study-LabWork1-Features-Task2-IVisitor'></a>
## IVisitor `type`

##### Namespace

Study.LabWork1.Features.Task2

##### Summary

Интерфейс Visitor (Посетитель).
Определяет набор операций, которые могут быть выполнены над элементами документа.

<a name='M-Study-LabWork1-Features-Task2-IVisitor-Visit-Study-LabWork1-Features-Task2-Paragraph-'></a>
### Visit(paragraph) `method`

##### Summary

Посещает элемент типа Paragraph.

##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| paragraph | [Study.LabWork1.Features.Task2.Paragraph](#T-Study-LabWork1-Features-Task2-Paragraph 'Study.LabWork1.Features.Task2.Paragraph') | Параграф документа |

<a name='M-Study-LabWork1-Features-Task2-IVisitor-Visit-Study-LabWork1-Features-Task2-Image-'></a>
### Visit(image) `method`

##### Summary

Посещает элемент типа Image.

##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| image | [Study.LabWork1.Features.Task2.Image](#T-Study-LabWork1-Features-Task2-Image 'Study.LabWork1.Features.Task2.Image') | Изображение документа |

<a name='M-Study-LabWork1-Features-Task2-IVisitor-Visit-Study-LabWork1-Features-Task2-Table-'></a>
### Visit(table) `method`

##### Summary

Посещает элемент типа Table.

##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| table | [Study.LabWork1.Features.Task2.Table](#T-Study-LabWork1-Features-Task2-Table 'Study.LabWork1.Features.Task2.Table') | Таблица документа |

<a name='T-Study-LabWork1-Features-Task2-Image'></a>
## Image `type`

##### Namespace

Study.LabWork1.Features.Task2

##### Summary

Представляет изображение в документе.

<a name='M-Study-LabWork1-Features-Task2-Image-#ctor-System-String,System-String-'></a>
### #ctor(src,alt) `constructor`

##### Summary

Создаёт новое изображение.

##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| src | [System.String](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.String 'System.String') | Путь или URL к изображению |
| alt | [System.String](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.String 'System.String') | Альтернативный текст (по умолчанию пустая строка) |

<a name='P-Study-LabWork1-Features-Task2-Image-Alt'></a>
### Alt `property`

##### Summary

Альтернативный текст изображения.

<a name='P-Study-LabWork1-Features-Task2-Image-Src'></a>
### Src `property`

##### Summary

Путь или URL к изображению.

<a name='M-Study-LabWork1-Features-Task2-Image-Accept-Study-LabWork1-Features-Task2-IVisitor-'></a>
### Accept(visitor) `method`

##### Summary

Принимает посетителя и делегирует ему обработку текущего элемента.

##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| visitor | [Study.LabWork1.Features.Task2.IVisitor](#T-Study-LabWork1-Features-Task2-IVisitor 'Study.LabWork1.Features.Task2.IVisitor') | Посетитель |

<a name='T-Study-LabWork1-Features-Task2-MarkdownVisitor'></a>
## MarkdownVisitor `type`

##### Namespace

Study.LabWork1.Features.Task2

##### Summary

Посетитель, который экспортирует документ в Markdown формат

<a name='M-Study-LabWork1-Features-Task2-MarkdownVisitor-GetResult'></a>
### GetResult() `method`

##### Summary

Возвращает результат преобразования документа в Markdown.

##### Returns

Строка, содержащая документ в формате Markdown

##### Parameters

This method has no parameters.

<a name='M-Study-LabWork1-Features-Task2-MarkdownVisitor-Visit-Study-LabWork1-Features-Task2-Paragraph-'></a>
### Visit(paragraph) `method`

##### Summary

Посещает элемент Paragraph и добавляет его в Markdown формате.

##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| paragraph | [Study.LabWork1.Features.Task2.Paragraph](#T-Study-LabWork1-Features-Task2-Paragraph 'Study.LabWork1.Features.Task2.Paragraph') | Параграф документа |

<a name='M-Study-LabWork1-Features-Task2-MarkdownVisitor-Visit-Study-LabWork1-Features-Task2-Image-'></a>
### Visit(image) `method`

##### Summary

Посещает элемент Image и добавляет его в Markdown формате как изображение.

##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| image | [Study.LabWork1.Features.Task2.Image](#T-Study-LabWork1-Features-Task2-Image 'Study.LabWork1.Features.Task2.Image') | Изображение документа |

<a name='M-Study-LabWork1-Features-Task2-MarkdownVisitor-Visit-Study-LabWork1-Features-Task2-Table-'></a>
### Visit(table) `method`

##### Summary

Посещает элемент Table и добавляет его в Markdown формате как полноценную таблицу.

##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| table | [Study.LabWork1.Features.Task2.Table](#T-Study-LabWork1-Features-Task2-Table 'Study.LabWork1.Features.Task2.Table') | Таблица документа |

<a name='T-Study-LabWork1-Features-Task2-Paragraph'></a>
## Paragraph `type`

##### Namespace

Study.LabWork1.Features.Task2

##### Summary

Представляет параграф текста в документе.

<a name='M-Study-LabWork1-Features-Task2-Paragraph-#ctor-System-String-'></a>
### #ctor(text) `constructor`

##### Summary

Создаёт новый параграф с указанным текстом.

##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| text | [System.String](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.String 'System.String') | Текст параграфа |

<a name='P-Study-LabWork1-Features-Task2-Paragraph-Text'></a>
### Text `property`

##### Summary

Текст параграфа.

<a name='M-Study-LabWork1-Features-Task2-Paragraph-Accept-Study-LabWork1-Features-Task2-IVisitor-'></a>
### Accept(visitor) `method`

##### Summary

Принимает посетителя и делегирует ему обработку текущего элемента.

##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| visitor | [Study.LabWork1.Features.Task2.IVisitor](#T-Study-LabWork1-Features-Task2-IVisitor 'Study.LabWork1.Features.Task2.IVisitor') | Посетитель |

<a name='T-Study-LabWork1-Program'></a>
## Program `type`

##### Namespace

Study.LabWork1

##### Summary

Начальная точка входа

<a name='F-Study-LabWork1-Program-RUN_TASK_NUMBER'></a>
### RUN_TASK_NUMBER `constants`

##### Summary

Номер выполняемой задачи

<a name='M-Study-LabWork1-Program-Main'></a>
### Main() `method`

##### Summary

Старт программы

##### Parameters

This method has no parameters.

<a name='T-Study-LabWork1-Shared-Services-RunService'></a>
## RunService `type`

##### Namespace

Study.LabWork1.Shared.Services

##### Summary

Реализация заданий Л/Р

<a name='M-Study-LabWork1-Shared-Services-RunService-RunTask1'></a>
### RunTask1() `method`

##### Summary

Задание 1

##### Parameters

This method has no parameters.

<a name='M-Study-LabWork1-Shared-Services-RunService-RunTask2'></a>
### RunTask2() `method`

##### Summary

Задание 2

##### Parameters

This method has no parameters.

<a name='M-Study-LabWork1-Shared-Services-RunService-RunTask3'></a>
### RunTask3() `method`

##### Summary

Задание 3

##### Parameters

This method has no parameters.

<a name='T-Study-LabWork1-Features-Task2-Table'></a>
## Table `type`

##### Namespace

Study.LabWork1.Features.Task2

##### Summary

Представляет таблицу в документе.

<a name='M-Study-LabWork1-Features-Task2-Table-#ctor-System-Int32,System-Int32-'></a>
### #ctor(rows,columns) `constructor`

##### Summary

Создаёт новую таблицу с указанным количеством строк и столбцов.

##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| rows | [System.Int32](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Int32 'System.Int32') | Количество строк в таблице |
| columns | [System.Int32](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Int32 'System.Int32') | Количество столбцов в таблице |

<a name='P-Study-LabWork1-Features-Task2-Table-Columns'></a>
### Columns `property`

##### Summary

Количество столбцов в таблице.

<a name='P-Study-LabWork1-Features-Task2-Table-Rows'></a>
### Rows `property`

##### Summary

Количество строк в таблице.

<a name='M-Study-LabWork1-Features-Task2-Table-Accept-Study-LabWork1-Features-Task2-IVisitor-'></a>
### Accept(visitor) `method`

##### Summary

Принимает посетителя и делегирует ему обработку текущего элемента таблицы.

##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| visitor | [Study.LabWork1.Features.Task2.IVisitor](#T-Study-LabWork1-Features-Task2-IVisitor 'Study.LabWork1.Features.Task2.IVisitor') | Посетитель |
