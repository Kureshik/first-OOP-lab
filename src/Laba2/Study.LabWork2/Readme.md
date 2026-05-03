<a name='assembly'></a>
# Study.LabWork2

## Contents

- [AsynchronousServerRequestApp](#T-Study-LabWork2-Feature-Task2-AsynchronousServerRequestApp 'Study.LabWork2.Feature.Task2.AsynchronousServerRequestApp')
  - [ExecuteRequestsAsync\`\`1()](#M-Study-LabWork2-Feature-Task2-AsynchronousServerRequestApp-ExecuteRequestsAsync``1-Study-LabWork2-Abstractions-Feature-Task2-DtoModels-ServerConfigDto[]- 'Study.LabWork2.Feature.Task2.AsynchronousServerRequestApp.ExecuteRequestsAsync``1(Study.LabWork2.Abstractions.Feature.Task2.DtoModels.ServerConfigDto[])')
- [MonitorService](#T-Study-LabWork2-Feature-Task1-SubTask1-MonitorService 'Study.LabWork2.Feature.Task1.SubTask1.MonitorService')
  - [CountPrimes()](#M-Study-LabWork2-Feature-Task1-SubTask1-MonitorService-CountPrimes-System-Int32,System-Int32,System-Int32- 'Study.LabWork2.Feature.Task1.SubTask1.MonitorService.CountPrimes(System.Int32,System.Int32,System.Int32)')
  - [GetVersionName()](#M-Study-LabWork2-Feature-Task1-SubTask1-MonitorService-GetVersionName 'Study.LabWork2.Feature.Task1.SubTask1.MonitorService.GetVersionName')
- [MutexService](#T-Study-LabWork2-Feature-Task1-SubTask1-MutexService 'Study.LabWork2.Feature.Task1.SubTask1.MutexService')
  - [CountPrimes()](#M-Study-LabWork2-Feature-Task1-SubTask1-MutexService-CountPrimes-System-Int32,System-Int32,System-Int32- 'Study.LabWork2.Feature.Task1.SubTask1.MutexService.CountPrimes(System.Int32,System.Int32,System.Int32)')
  - [GetVersionName()](#M-Study-LabWork2-Feature-Task1-SubTask1-MutexService-GetVersionName 'Study.LabWork2.Feature.Task1.SubTask1.MutexService.GetVersionName')
- [NumberSetProcessor](#T-Study-LabWork2-Feature-Task1-SubTask2-NumberSetProcessor 'Study.LabWork2.Feature.Task1.SubTask2.NumberSetProcessor')
- [Program](#T-Study-LabWork2-Program 'Study.LabWork2.Program')
  - [Main()](#M-Study-LabWork2-Program-Main 'Study.LabWork2.Program.Main')
- [SemaphoreService](#T-Study-LabWork2-Feature-Task1-SubTask1-SemaphoreService 'Study.LabWork2.Feature.Task1.SubTask1.SemaphoreService')
  - [CountPrimes()](#M-Study-LabWork2-Feature-Task1-SubTask1-SemaphoreService-CountPrimes-System-Int32,System-Int32,System-Int32- 'Study.LabWork2.Feature.Task1.SubTask1.SemaphoreService.CountPrimes(System.Int32,System.Int32,System.Int32)')
  - [GetVersionName()](#M-Study-LabWork2-Feature-Task1-SubTask1-SemaphoreService-GetVersionName 'Study.LabWork2.Feature.Task1.SubTask1.SemaphoreService.GetVersionName')
- [SynchronousServerRequestApp](#T-Study-LabWork2-Feature-Task2-SynchronousServerRequestApp 'Study.LabWork2.Feature.Task2.SynchronousServerRequestApp')

<a name='T-Study-LabWork2-Feature-Task2-AsynchronousServerRequestApp'></a>
## AsynchronousServerRequestApp `type`

##### Namespace

Study.LabWork2.Feature.Task2

##### Summary

Асинхронная версия приложения (с использованием async/await)

<a name='M-Study-LabWork2-Feature-Task2-AsynchronousServerRequestApp-ExecuteRequestsAsync``1-Study-LabWork2-Abstractions-Feature-Task2-DtoModels-ServerConfigDto[]-'></a>
### ExecuteRequestsAsync\`\`1() `method`

##### Summary

Асинхронное выполнение запросов

##### Parameters

This method has no parameters.

<a name='T-Study-LabWork2-Feature-Task1-SubTask1-MonitorService'></a>
## MonitorService `type`

##### Namespace

Study.LabWork2.Feature.Task1.SubTask1

##### Summary

Версия 1. Использует Monitor (lock) для синхронизации

<a name='M-Study-LabWork2-Feature-Task1-SubTask1-MonitorService-CountPrimes-System-Int32,System-Int32,System-Int32-'></a>
### CountPrimes() `method`

##### Summary

*Inherit from parent.*

##### Parameters

This method has no parameters.

<a name='M-Study-LabWork2-Feature-Task1-SubTask1-MonitorService-GetVersionName'></a>
### GetVersionName() `method`

##### Summary

*Inherit from parent.*

##### Parameters

This method has no parameters.

<a name='T-Study-LabWork2-Feature-Task1-SubTask1-MutexService'></a>
## MutexService `type`

##### Namespace

Study.LabWork2.Feature.Task1.SubTask1

##### Summary

Версия 2. Использует Mutex для синхронизации

<a name='M-Study-LabWork2-Feature-Task1-SubTask1-MutexService-CountPrimes-System-Int32,System-Int32,System-Int32-'></a>
### CountPrimes() `method`

##### Summary

*Inherit from parent.*

##### Parameters

This method has no parameters.

<a name='M-Study-LabWork2-Feature-Task1-SubTask1-MutexService-GetVersionName'></a>
### GetVersionName() `method`

##### Summary

*Inherit from parent.*

##### Parameters

This method has no parameters.

<a name='T-Study-LabWork2-Feature-Task1-SubTask2-NumberSetProcessor'></a>
## NumberSetProcessor `type`

##### Namespace

Study.LabWork2.Feature.Task1.SubTask2

##### Summary

Определяет реализацию для процессора наборов чисел

<a name='T-Study-LabWork2-Program'></a>
## Program `type`

##### Namespace

Study.LabWork2

##### Summary

Точка входа в приложение для запуска заданий лабораторной работы.

<a name='M-Study-LabWork2-Program-Main'></a>
### Main() `method`

##### Summary

Запускает сравнение трех версий подсчета простых чисел
с разными механизмами синхронизации.

##### Parameters

This method has no parameters.

<a name='T-Study-LabWork2-Feature-Task1-SubTask1-SemaphoreService'></a>
## SemaphoreService `type`

##### Namespace

Study.LabWork2.Feature.Task1.SubTask1

##### Summary

Версия 3. Использует Semaphore для синхронизации

<a name='M-Study-LabWork2-Feature-Task1-SubTask1-SemaphoreService-CountPrimes-System-Int32,System-Int32,System-Int32-'></a>
### CountPrimes() `method`

##### Summary

*Inherit from parent.*

##### Parameters

This method has no parameters.

<a name='M-Study-LabWork2-Feature-Task1-SubTask1-SemaphoreService-GetVersionName'></a>
### GetVersionName() `method`

##### Summary

*Inherit from parent.*

##### Parameters

This method has no parameters.

<a name='T-Study-LabWork2-Feature-Task2-SynchronousServerRequestApp'></a>
## SynchronousServerRequestApp `type`

##### Namespace

Study.LabWork2.Feature.Task2

##### Summary

Синхронная версия приложения (без использования async/await)
