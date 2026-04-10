<a name='assembly'></a>
# Study.LabWork1

## Contents

- [IRunService](#T-Study-LabWork1-Shared-Abstractions-IRunService 'Study.LabWork1.Shared.Abstractions.IRunService')
  - [RunTask1()](#M-Study-LabWork1-Shared-Abstractions-IRunService-RunTask1 'Study.LabWork1.Shared.Abstractions.IRunService.RunTask1')
  - [RunTask2()](#M-Study-LabWork1-Shared-Abstractions-IRunService-RunTask2 'Study.LabWork1.Shared.Abstractions.IRunService.RunTask2')
  - [RunTask3()](#M-Study-LabWork1-Shared-Abstractions-IRunService-RunTask3 'Study.LabWork1.Shared.Abstractions.IRunService.RunTask3')
- [MySet\`1](#T-Study-LabWork1-Features-Task1-MySet`1 'Study.LabWork1.Features.Task1.MySet`1')
  - [#ctor()](#M-Study-LabWork1-Features-Task1-MySet`1-#ctor-System-Collections-Generic-IEnumerable{`0}- 'Study.LabWork1.Features.Task1.MySet`1.#ctor(System.Collections.Generic.IEnumerable{`0})')
  - [#ctor()](#M-Study-LabWork1-Features-Task1-MySet`1-#ctor 'Study.LabWork1.Features.Task1.MySet`1.#ctor')
  - [Count](#P-Study-LabWork1-Features-Task1-MySet`1-Count 'Study.LabWork1.Features.Task1.MySet`1.Count')
  - [Items](#P-Study-LabWork1-Features-Task1-MySet`1-Items 'Study.LabWork1.Features.Task1.MySet`1.Items')
  - [Contains()](#M-Study-LabWork1-Features-Task1-MySet`1-Contains-`0- 'Study.LabWork1.Features.Task1.MySet`1.Contains(`0)')
  - [ToString()](#M-Study-LabWork1-Features-Task1-MySet`1-ToString 'Study.LabWork1.Features.Task1.MySet`1.ToString')
  - [op_BitwiseOr()](#M-Study-LabWork1-Features-Task1-MySet`1-op_BitwiseOr-Study-LabWork1-Features-Task1-MySet{`0},Study-LabWork1-Features-Task1-MySet{`0}- 'Study.LabWork1.Features.Task1.MySet`1.op_BitwiseOr(Study.LabWork1.Features.Task1.MySet{`0},Study.LabWork1.Features.Task1.MySet{`0})')
  - [op_Division()](#M-Study-LabWork1-Features-Task1-MySet`1-op_Division-Study-LabWork1-Features-Task1-MySet{`0},Study-LabWork1-Features-Task1-MySet{`0}- 'Study.LabWork1.Features.Task1.MySet`1.op_Division(Study.LabWork1.Features.Task1.MySet{`0},Study.LabWork1.Features.Task1.MySet{`0})')
  - [op_Equality()](#M-Study-LabWork1-Features-Task1-MySet`1-op_Equality-Study-LabWork1-Features-Task1-MySet{`0},Study-LabWork1-Features-Task1-MySet{`0}- 'Study.LabWork1.Features.Task1.MySet`1.op_Equality(Study.LabWork1.Features.Task1.MySet{`0},Study.LabWork1.Features.Task1.MySet{`0})')
  - [op_Subtraction()](#M-Study-LabWork1-Features-Task1-MySet`1-op_Subtraction-Study-LabWork1-Features-Task1-MySet{`0},Study-LabWork1-Features-Task1-MySet{`0}- 'Study.LabWork1.Features.Task1.MySet`1.op_Subtraction(Study.LabWork1.Features.Task1.MySet{`0},Study.LabWork1.Features.Task1.MySet{`0})')
- [Program](#T-Study-LabWork1-Program 'Study.LabWork1.Program')
  - [RUN_TASK_NUMBER](#F-Study-LabWork1-Program-RUN_TASK_NUMBER 'Study.LabWork1.Program.RUN_TASK_NUMBER')
  - [Main()](#M-Study-LabWork1-Program-Main 'Study.LabWork1.Program.Main')
- [RunService](#T-Study-LabWork1-Shared-Services-RunService 'Study.LabWork1.Shared.Services.RunService')
  - [RunTask1()](#M-Study-LabWork1-Shared-Services-RunService-RunTask1 'Study.LabWork1.Shared.Services.RunService.RunTask1')
  - [RunTask2()](#M-Study-LabWork1-Shared-Services-RunService-RunTask2 'Study.LabWork1.Shared.Services.RunService.RunTask2')
  - [RunTask3()](#M-Study-LabWork1-Shared-Services-RunService-RunTask3 'Study.LabWork1.Shared.Services.RunService.RunTask3')

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

<a name='T-Study-LabWork1-Features-Task1-MySet`1'></a>
## MySet\`1 `type`

##### Namespace

Study.LabWork1.Features.Task1

##### Summary

Обобщённое математическое множество уникальных элементов
Внутреннее хранилище — List (по требованию преподавателя)

<a name='M-Study-LabWork1-Features-Task1-MySet`1-#ctor-System-Collections-Generic-IEnumerable{`0}-'></a>
### #ctor() `constructor`

##### Summary

Конструктор, принимающий коллекцию и сохраняющий только уникальные элементы

##### Parameters

This constructor has no parameters.

<a name='M-Study-LabWork1-Features-Task1-MySet`1-#ctor'></a>
### #ctor() `constructor`

##### Summary

Конструктор по умолчанию (пустое множество)

##### Parameters

This constructor has no parameters.

<a name='P-Study-LabWork1-Features-Task1-MySet`1-Count'></a>
### Count `property`

##### Summary

Количество элементов в множестве (только для чтения)

<a name='P-Study-LabWork1-Features-Task1-MySet`1-Items'></a>
### Items `property`

##### Summary

Элементы множества (только для чтения)

<a name='M-Study-LabWork1-Features-Task1-MySet`1-Contains-`0-'></a>
### Contains() `method`

##### Summary

Проверка наличия элемента в множестве

##### Parameters

This method has no parameters.

<a name='M-Study-LabWork1-Features-Task1-MySet`1-ToString'></a>
### ToString() `method`

##### Summary

Вывод в требуемом формате: {elem1, elem2, elem3}

##### Parameters

This method has no parameters.

<a name='M-Study-LabWork1-Features-Task1-MySet`1-op_BitwiseOr-Study-LabWork1-Features-Task1-MySet{`0},Study-LabWork1-Features-Task1-MySet{`0}-'></a>
### op_BitwiseOr() `method`

##### Summary

Объединение: A | B

##### Parameters

This method has no parameters.

<a name='M-Study-LabWork1-Features-Task1-MySet`1-op_Division-Study-LabWork1-Features-Task1-MySet{`0},Study-LabWork1-Features-Task1-MySet{`0}-'></a>
### op_Division() `method`

##### Summary

Симметричная разность: A / B

##### Parameters

This method has no parameters.

<a name='M-Study-LabWork1-Features-Task1-MySet`1-op_Equality-Study-LabWork1-Features-Task1-MySet{`0},Study-LabWork1-Features-Task1-MySet{`0}-'></a>
### op_Equality() `method`

##### Summary

Сравнение множеств по значениям (==)

##### Parameters

This method has no parameters.

<a name='M-Study-LabWork1-Features-Task1-MySet`1-op_Subtraction-Study-LabWork1-Features-Task1-MySet{`0},Study-LabWork1-Features-Task1-MySet{`0}-'></a>
### op_Subtraction() `method`

##### Summary

Разность: A - B

##### Parameters

This method has no parameters.

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

Задание 1 - Реализация обобщённого класса MySet

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
