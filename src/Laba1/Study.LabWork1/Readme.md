<a name='assembly'></a>
# Study.LabWork1

## Contents

- [IRunService](#T-Study-LabWork1-Shared-Abstractions-IRunService 'Study.LabWork1.Shared.Abstractions.IRunService')
  - [RunTask1()](#M-Study-LabWork1-Shared-Abstractions-IRunService-RunTask1 'Study.LabWork1.Shared.Abstractions.IRunService.RunTask1')
  - [RunTask2()](#M-Study-LabWork1-Shared-Abstractions-IRunService-RunTask2 'Study.LabWork1.Shared.Abstractions.IRunService.RunTask2')
  - [RunTask3()](#M-Study-LabWork1-Shared-Abstractions-IRunService-RunTask3 'Study.LabWork1.Shared.Abstractions.IRunService.RunTask3')
- [Program](#T-Study-LabWork1-Program 'Study.LabWork1.Program')
  - [RUN_TASK_NUMBER](#F-Study-LabWork1-Program-RUN_TASK_NUMBER 'Study.LabWork1.Program.RUN_TASK_NUMBER')
  - [Main()](#M-Study-LabWork1-Program-Main 'Study.LabWork1.Program.Main')
- [RunService](#T-Study-LabWork1-Shared-Services-RunService 'Study.LabWork1.Shared.Services.RunService')
  - [RunTask1()](#M-Study-LabWork1-Shared-Services-RunService-RunTask1 'Study.LabWork1.Shared.Services.RunService.RunTask1')
  - [RunTask2()](#M-Study-LabWork1-Shared-Services-RunService-RunTask2 'Study.LabWork1.Shared.Services.RunService.RunTask2')
  - [RunTask3()](#M-Study-LabWork1-Shared-Services-RunService-RunTask3 'Study.LabWork1.Shared.Services.RunService.RunTask3')
- [TreeNode\`1](#T-Study-LabWork1-Features-Task3-TreeNode`1 'Study.LabWork1.Features.Task3.TreeNode`1')
  - [#ctor(value)](#M-Study-LabWork1-Features-Task3-TreeNode`1-#ctor-`0- 'Study.LabWork1.Features.Task3.TreeNode`1.#ctor(`0)')
  - [Children](#P-Study-LabWork1-Features-Task3-TreeNode`1-Children 'Study.LabWork1.Features.Task3.TreeNode`1.Children')
  - [Value](#P-Study-LabWork1-Features-Task3-TreeNode`1-Value 'Study.LabWork1.Features.Task3.TreeNode`1.Value')
  - [AddChild(child)](#M-Study-LabWork1-Features-Task3-TreeNode`1-AddChild-Study-LabWork1-Features-Task3-TreeNode{`0}- 'Study.LabWork1.Features.Task3.TreeNode`1.AddChild(Study.LabWork1.Features.Task3.TreeNode{`0})')
  - [Print(depth)](#M-Study-LabWork1-Features-Task3-TreeNode`1-Print-System-Int32- 'Study.LabWork1.Features.Task3.TreeNode`1.Print(System.Int32)')

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

Задание 3 — Простое дерево с рекурсивным выводом

##### Parameters

This method has no parameters.

<a name='T-Study-LabWork1-Features-Task3-TreeNode`1'></a>
## TreeNode\`1 `type`

##### Namespace

Study.LabWork1.Features.Task3

##### Summary

Узел простого дерева.
Каждый узел содержит значение и список потомков (детей).

##### Generic Types

| Name | Description |
| ---- | ----------- |
| T | Тип значения узла (int, string, объект и т.д.) |

<a name='M-Study-LabWork1-Features-Task3-TreeNode`1-#ctor-`0-'></a>
### #ctor(value) `constructor`

##### Summary

Создаёт новый узел дерева с заданным значением.

##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| value | [\`0](#T-`0 '`0') | Значение узла |

<a name='P-Study-LabWork1-Features-Task3-TreeNode`1-Children'></a>
### Children `property`

##### Summary

Список всех непосредственных потомков (детей) узла.

<a name='P-Study-LabWork1-Features-Task3-TreeNode`1-Value'></a>
### Value `property`

##### Summary

Значение, хранящееся в узле.

<a name='M-Study-LabWork1-Features-Task3-TreeNode`1-AddChild-Study-LabWork1-Features-Task3-TreeNode{`0}-'></a>
### AddChild(child) `method`

##### Summary

Метод для добавления ребёнка

##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| child | [Study.LabWork1.Features.Task3.TreeNode{\`0}](#T-Study-LabWork1-Features-Task3-TreeNode{`0} 'Study.LabWork1.Features.Task3.TreeNode{`0}') | Добавляемый потомок |

<a name='M-Study-LabWork1-Features-Task3-TreeNode`1-Print-System-Int32-'></a>
### Print(depth) `method`

##### Summary

Рекурсивная функция вывода всего поддерева.
Сначала выводит значение текущего узла, затем рекурсивно вызывает себя для каждого ребёнка.

##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| depth | [System.Int32](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Int32 'System.Int32') | Текущий уровень вложенности |
