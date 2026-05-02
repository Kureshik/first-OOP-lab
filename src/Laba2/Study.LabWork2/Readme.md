<a name='assembly'></a>
# Study.LabWork2

## Contents

- [AsynchronousServerRequestApp](#T-Study-LabWork2-Feature-Task2-AsynchronousServerRequestApp 'Study.LabWork2.Feature.Task2.AsynchronousServerRequestApp')
  - [#ctor(requestService)](#M-Study-LabWork2-Feature-Task2-AsynchronousServerRequestApp-#ctor-Study-LabWork2-Abstractions-Feature-Task2-IRequestService- 'Study.LabWork2.Feature.Task2.AsynchronousServerRequestApp.#ctor(Study.LabWork2.Abstractions.Feature.Task2.IRequestService)')
  - [DeserializeResponse\`\`1(responseJson,server)](#M-Study-LabWork2-Feature-Task2-AsynchronousServerRequestApp-DeserializeResponse``1-System-String,Study-LabWork2-Abstractions-Feature-Task2-DtoModels-ServerConfigDto- 'Study.LabWork2.Feature.Task2.AsynchronousServerRequestApp.DeserializeResponse``1(System.String,Study.LabWork2.Abstractions.Feature.Task2.DtoModels.ServerConfigDto)')
  - [EnsurePositiveResponse(server,responseJson)](#M-Study-LabWork2-Feature-Task2-AsynchronousServerRequestApp-EnsurePositiveResponse-Study-LabWork2-Abstractions-Feature-Task2-DtoModels-ServerConfigDto,System-String- 'Study.LabWork2.Feature.Task2.AsynchronousServerRequestApp.EnsurePositiveResponse(Study.LabWork2.Abstractions.Feature.Task2.DtoModels.ServerConfigDto,System.String)')
  - [EnsureServerConfigValid(server)](#M-Study-LabWork2-Feature-Task2-AsynchronousServerRequestApp-EnsureServerConfigValid-Study-LabWork2-Abstractions-Feature-Task2-DtoModels-ServerConfigDto- 'Study.LabWork2.Feature.Task2.AsynchronousServerRequestApp.EnsureServerConfigValid(Study.LabWork2.Abstractions.Feature.Task2.DtoModels.ServerConfigDto)')
  - [ExecuteRequestsAsync\`\`1()](#M-Study-LabWork2-Feature-Task2-AsynchronousServerRequestApp-ExecuteRequestsAsync``1-Study-LabWork2-Abstractions-Feature-Task2-DtoModels-ServerConfigDto[]- 'Study.LabWork2.Feature.Task2.AsynchronousServerRequestApp.ExecuteRequestsAsync``1(Study.LabWork2.Abstractions.Feature.Task2.DtoModels.ServerConfigDto[])')
  - [ExecuteRequests\`\`1(servers)](#M-Study-LabWork2-Feature-Task2-AsynchronousServerRequestApp-ExecuteRequests``1-Study-LabWork2-Abstractions-Feature-Task2-DtoModels-ServerConfigDto[]- 'Study.LabWork2.Feature.Task2.AsynchronousServerRequestApp.ExecuteRequests``1(Study.LabWork2.Abstractions.Feature.Task2.DtoModels.ServerConfigDto[])')
  - [FetchResponseAsync\`\`1(server,index,cancellationToken)](#M-Study-LabWork2-Feature-Task2-AsynchronousServerRequestApp-FetchResponseAsync``1-Study-LabWork2-Abstractions-Feature-Task2-DtoModels-ServerConfigDto,System-Int32,System-Threading-CancellationToken- 'Study.LabWork2.Feature.Task2.AsynchronousServerRequestApp.FetchResponseAsync``1(Study.LabWork2.Abstractions.Feature.Task2.DtoModels.ServerConfigDto,System.Int32,System.Threading.CancellationToken)')
  - [GetVersion()](#M-Study-LabWork2-Feature-Task2-AsynchronousServerRequestApp-GetVersion 'Study.LabWork2.Feature.Task2.AsynchronousServerRequestApp.GetVersion')
  - [IsPositiveResponse(json)](#M-Study-LabWork2-Feature-Task2-AsynchronousServerRequestApp-IsPositiveResponse-System-String- 'Study.LabWork2.Feature.Task2.AsynchronousServerRequestApp.IsPositiveResponse(System.String)')
  - [TryGetBoolean(root,propertyName,value)](#M-Study-LabWork2-Feature-Task2-AsynchronousServerRequestApp-TryGetBoolean-System-Text-Json-JsonElement,System-String,System-Boolean@- 'Study.LabWork2.Feature.Task2.AsynchronousServerRequestApp.TryGetBoolean(System.Text.Json.JsonElement,System.String,System.Boolean@)')
- [DemoRequestService](#T-Study-LabWork2-Program-DemoRequestService 'Study.LabWork2.Program.DemoRequestService')
  - [#ctor(responses)](#M-Study-LabWork2-Program-DemoRequestService-#ctor-System-Collections-Generic-Dictionary{System-String,System-String}- 'Study.LabWork2.Program.DemoRequestService.#ctor(System.Collections.Generic.Dictionary{System.String,System.String})')
- [HttpRequestService](#T-Study-LabWork2-Feature-Task2-HttpRequestService 'Study.LabWork2.Feature.Task2.HttpRequestService')
  - [#ctor(httpClient)](#M-Study-LabWork2-Feature-Task2-HttpRequestService-#ctor-System-Net-Http-HttpClient- 'Study.LabWork2.Feature.Task2.HttpRequestService.#ctor(System.Net.Http.HttpClient)')
  - [FetchData(url)](#M-Study-LabWork2-Feature-Task2-HttpRequestService-FetchData-System-String- 'Study.LabWork2.Feature.Task2.HttpRequestService.FetchData(System.String)')
  - [FetchDataAsync(url,cancellationToken)](#M-Study-LabWork2-Feature-Task2-HttpRequestService-FetchDataAsync-System-String,System-Threading-CancellationToken- 'Study.LabWork2.Feature.Task2.HttpRequestService.FetchDataAsync(System.String,System.Threading.CancellationToken)')
- [MonitorService](#T-Study-LabWork2-Feature-Task1-SubTask1-MonitorService 'Study.LabWork2.Feature.Task1.SubTask1.MonitorService')
- [MutexService](#T-Study-LabWork2-Feature-Task1-SubTask1-MutexService 'Study.LabWork2.Feature.Task1.SubTask1.MutexService')
- [NumberSetProcessor](#T-Study-LabWork2-Feature-Task1-SubTask2-NumberSetProcessor 'Study.LabWork2.Feature.Task1.SubTask2.NumberSetProcessor')
- [Program](#T-Study-LabWork2-Program 'Study.LabWork2.Program')
  - [Main()](#M-Study-LabWork2-Program-Main 'Study.LabWork2.Program.Main')
  - [RunTask2Version(app,servers)](#M-Study-LabWork2-Program-RunTask2Version-Study-LabWork2-Abstractions-Feature-Task2-IServerRequestApp,Study-LabWork2-Abstractions-Feature-Task2-DtoModels-ServerConfigDto[]- 'Study.LabWork2.Program.RunTask2Version(Study.LabWork2.Abstractions.Feature.Task2.IServerRequestApp,Study.LabWork2.Abstractions.Feature.Task2.DtoModels.ServerConfigDto[])')
- [SemaphoreService](#T-Study-LabWork2-Feature-Task1-SubTask1-SemaphoreService 'Study.LabWork2.Feature.Task1.SubTask1.SemaphoreService')
- [SynchronousServerRequestApp](#T-Study-LabWork2-Feature-Task2-SynchronousServerRequestApp 'Study.LabWork2.Feature.Task2.SynchronousServerRequestApp')
  - [#ctor(requestService)](#M-Study-LabWork2-Feature-Task2-SynchronousServerRequestApp-#ctor-Study-LabWork2-Abstractions-Feature-Task2-IRequestService- 'Study.LabWork2.Feature.Task2.SynchronousServerRequestApp.#ctor(Study.LabWork2.Abstractions.Feature.Task2.IRequestService)')
  - [DeserializeResponse\`\`1(responseJson,server)](#M-Study-LabWork2-Feature-Task2-SynchronousServerRequestApp-DeserializeResponse``1-System-String,Study-LabWork2-Abstractions-Feature-Task2-DtoModels-ServerConfigDto- 'Study.LabWork2.Feature.Task2.SynchronousServerRequestApp.DeserializeResponse``1(System.String,Study.LabWork2.Abstractions.Feature.Task2.DtoModels.ServerConfigDto)')
  - [EnsurePositiveResponse(server,responseJson)](#M-Study-LabWork2-Feature-Task2-SynchronousServerRequestApp-EnsurePositiveResponse-Study-LabWork2-Abstractions-Feature-Task2-DtoModels-ServerConfigDto,System-String- 'Study.LabWork2.Feature.Task2.SynchronousServerRequestApp.EnsurePositiveResponse(Study.LabWork2.Abstractions.Feature.Task2.DtoModels.ServerConfigDto,System.String)')
  - [EnsureServerConfigValid(server)](#M-Study-LabWork2-Feature-Task2-SynchronousServerRequestApp-EnsureServerConfigValid-Study-LabWork2-Abstractions-Feature-Task2-DtoModels-ServerConfigDto- 'Study.LabWork2.Feature.Task2.SynchronousServerRequestApp.EnsureServerConfigValid(Study.LabWork2.Abstractions.Feature.Task2.DtoModels.ServerConfigDto)')
  - [ExecuteRequests\`\`1(servers)](#M-Study-LabWork2-Feature-Task2-SynchronousServerRequestApp-ExecuteRequests``1-Study-LabWork2-Abstractions-Feature-Task2-DtoModels-ServerConfigDto[]- 'Study.LabWork2.Feature.Task2.SynchronousServerRequestApp.ExecuteRequests``1(Study.LabWork2.Abstractions.Feature.Task2.DtoModels.ServerConfigDto[])')
  - [GetVersion()](#M-Study-LabWork2-Feature-Task2-SynchronousServerRequestApp-GetVersion 'Study.LabWork2.Feature.Task2.SynchronousServerRequestApp.GetVersion')
  - [IsPositiveResponse(json)](#M-Study-LabWork2-Feature-Task2-SynchronousServerRequestApp-IsPositiveResponse-System-String- 'Study.LabWork2.Feature.Task2.SynchronousServerRequestApp.IsPositiveResponse(System.String)')
  - [TryGetBoolean(root,propertyName,value)](#M-Study-LabWork2-Feature-Task2-SynchronousServerRequestApp-TryGetBoolean-System-Text-Json-JsonElement,System-String,System-Boolean@- 'Study.LabWork2.Feature.Task2.SynchronousServerRequestApp.TryGetBoolean(System.Text.Json.JsonElement,System.String,System.Boolean@)')

<a name='T-Study-LabWork2-Feature-Task2-AsynchronousServerRequestApp'></a>
## AsynchronousServerRequestApp `type`

##### Namespace

Study.LabWork2.Feature.Task2

##### Summary

Асинхронная версия приложения (с использованием async/await)

<a name='M-Study-LabWork2-Feature-Task2-AsynchronousServerRequestApp-#ctor-Study-LabWork2-Abstractions-Feature-Task2-IRequestService-'></a>
### #ctor(requestService) `constructor`

##### Summary

Создает экземпляр асинхронного приложения для выполнения запросов к серверам.

##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| requestService | [Study.LabWork2.Abstractions.Feature.Task2.IRequestService](#T-Study-LabWork2-Abstractions-Feature-Task2-IRequestService 'Study.LabWork2.Abstractions.Feature.Task2.IRequestService') | Сервис отправки запросов. Если не передан, используется [HttpRequestService](#T-Study-LabWork2-Feature-Task2-HttpRequestService 'Study.LabWork2.Feature.Task2.HttpRequestService'). |

<a name='M-Study-LabWork2-Feature-Task2-AsynchronousServerRequestApp-DeserializeResponse``1-System-String,Study-LabWork2-Abstractions-Feature-Task2-DtoModels-ServerConfigDto-'></a>
### DeserializeResponse\`\`1(responseJson,server) `method`

##### Summary

Десериализует JSON-ответ от сервера в объект типа TResponse. Если десериализация не удалась, выбрасывает исключение с подробным сообщением.

##### Returns

Десериализованный объект типа TResponse.

##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| responseJson | [System.String](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.String 'System.String') | JSON-ответ от сервера. |
| server | [Study.LabWork2.Abstractions.Feature.Task2.DtoModels.ServerConfigDto](#T-Study-LabWork2-Abstractions-Feature-Task2-DtoModels-ServerConfigDto 'Study.LabWork2.Abstractions.Feature.Task2.DtoModels.ServerConfigDto') | Конфигурация сервера. |

##### Generic Types

| Name | Description |
| ---- | ----------- |
| TResponse | Тип модели для десериализации JSON-ответа. |

##### Exceptions

| Name | Description |
| ---- | ----------- |
| [System.InvalidOperationException](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.InvalidOperationException 'System.InvalidOperationException') | Выбрасывается, если десериализация не удалась. |

<a name='M-Study-LabWork2-Feature-Task2-AsynchronousServerRequestApp-EnsurePositiveResponse-Study-LabWork2-Abstractions-Feature-Task2-DtoModels-ServerConfigDto,System-String-'></a>
### EnsurePositiveResponse(server,responseJson) `method`

##### Summary

Проверяет JSON-ответ от сервера на наличие признаков отрицательного ответа. Если ответ считается отрицательным, выбрасывает исключение.

##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| server | [Study.LabWork2.Abstractions.Feature.Task2.DtoModels.ServerConfigDto](#T-Study-LabWork2-Abstractions-Feature-Task2-DtoModels-ServerConfigDto 'Study.LabWork2.Abstractions.Feature.Task2.DtoModels.ServerConfigDto') | Конфигурация сервера. |
| responseJson | [System.String](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.String 'System.String') | JSON-ответ от сервера. |

##### Exceptions

| Name | Description |
| ---- | ----------- |
| [System.InvalidOperationException](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.InvalidOperationException 'System.InvalidOperationException') | Выбрасывается, если ответ считается отрицательным. |

<a name='M-Study-LabWork2-Feature-Task2-AsynchronousServerRequestApp-EnsureServerConfigValid-Study-LabWork2-Abstractions-Feature-Task2-DtoModels-ServerConfigDto-'></a>
### EnsureServerConfigValid(server) `method`

##### Summary

Проверяет валидность конфигурации сервера. Если конфигурация невалидна, выбрасывает исключение.

##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| server | [Study.LabWork2.Abstractions.Feature.Task2.DtoModels.ServerConfigDto](#T-Study-LabWork2-Abstractions-Feature-Task2-DtoModels-ServerConfigDto 'Study.LabWork2.Abstractions.Feature.Task2.DtoModels.ServerConfigDto') | Конфигурация сервера. |

##### Exceptions

| Name | Description |
| ---- | ----------- |
| [System.ArgumentException](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.ArgumentException 'System.ArgumentException') | Выбрасывается, если конфигурация сервера невалидна. |

<a name='M-Study-LabWork2-Feature-Task2-AsynchronousServerRequestApp-ExecuteRequestsAsync``1-Study-LabWork2-Abstractions-Feature-Task2-DtoModels-ServerConfigDto[]-'></a>
### ExecuteRequestsAsync\`\`1() `method`

##### Summary

Асинхронное выполнение запросов

##### Parameters

This method has no parameters.

<a name='M-Study-LabWork2-Feature-Task2-AsynchronousServerRequestApp-ExecuteRequests``1-Study-LabWork2-Abstractions-Feature-Task2-DtoModels-ServerConfigDto[]-'></a>
### ExecuteRequests\`\`1(servers) `method`

##### Summary

Выполняет запросы к серверам и возвращает агрегированный результат.

##### Returns

Результат выполнения запросов.

##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| servers | [Study.LabWork2.Abstractions.Feature.Task2.DtoModels.ServerConfigDto[]](#T-Study-LabWork2-Abstractions-Feature-Task2-DtoModels-ServerConfigDto[] 'Study.LabWork2.Abstractions.Feature.Task2.DtoModels.ServerConfigDto[]') | Массив серверов для опроса. |

##### Generic Types

| Name | Description |
| ---- | ----------- |
| TResponse | Тип модели для десериализации JSON-ответов. |

<a name='M-Study-LabWork2-Feature-Task2-AsynchronousServerRequestApp-FetchResponseAsync``1-Study-LabWork2-Abstractions-Feature-Task2-DtoModels-ServerConfigDto,System-Int32,System-Threading-CancellationToken-'></a>
### FetchResponseAsync\`\`1(server,index,cancellationToken) `method`

##### Summary

Асинхронно выполняет запрос к серверу, возвращает индекс и десериализованный ответ.

##### Returns

Кортеж с индексом и десериализованным ответом.

##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| server | [Study.LabWork2.Abstractions.Feature.Task2.DtoModels.ServerConfigDto](#T-Study-LabWork2-Abstractions-Feature-Task2-DtoModels-ServerConfigDto 'Study.LabWork2.Abstractions.Feature.Task2.DtoModels.ServerConfigDto') | Конфигурация сервера. |
| index | [System.Int32](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Int32 'System.Int32') | Индекс сервера в массиве. |
| cancellationToken | [System.Threading.CancellationToken](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Threading.CancellationToken 'System.Threading.CancellationToken') | Токен отмены. |

##### Generic Types

| Name | Description |
| ---- | ----------- |
| TResponse | Тип модели для десериализации JSON-ответа. |

<a name='M-Study-LabWork2-Feature-Task2-AsynchronousServerRequestApp-GetVersion'></a>
### GetVersion() `method`

##### Summary

Возвращает название версии приложения.

##### Returns

Строка с названием версии.

##### Parameters

This method has no parameters.

<a name='M-Study-LabWork2-Feature-Task2-AsynchronousServerRequestApp-IsPositiveResponse-System-String-'></a>
### IsPositiveResponse(json) `method`

##### Summary

Проверяет JSON-ответ от сервера на наличие признаков положительного ответа. Если JSON не является объектом или не содержит явных признаков отрицательного ответа, считается положительным.

##### Returns

`true`, если ответ считается положительным; иначе `false`.

##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| json | [System.String](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.String 'System.String') | JSON-ответ от сервера. |

<a name='M-Study-LabWork2-Feature-Task2-AsynchronousServerRequestApp-TryGetBoolean-System-Text-Json-JsonElement,System-String,System-Boolean@-'></a>
### TryGetBoolean(root,propertyName,value) `method`

##### Summary

Пытается извлечь булевое значение из JSON-объекта по заданному имени свойства. Учитывает, что булевое значение может быть представлено как true/false в JSON. Если свойство найдено и является булевым, возвращает его значение через выходной параметр и `true`; иначе возвращает `false` и устанавливает выходной параметр в `false`.

##### Returns

`true`, если свойство найдено и является булевым; иначе `false`.

##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| root | [System.Text.Json.JsonElement](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Text.Json.JsonElement 'System.Text.Json.JsonElement') | JSON-объект для проверки. |
| propertyName | [System.String](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.String 'System.String') | Имя свойства для извлечения. |
| value | [System.Boolean@](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Boolean@ 'System.Boolean@') | Выходной параметр для хранения извлеченного значения. |

<a name='T-Study-LabWork2-Program-DemoRequestService'></a>
## DemoRequestService `type`

##### Namespace

Study.LabWork2.Program

##### Summary

Простая реализация IRequestService для демонстрационных целей, возвращающая предопределенные ответы на запросы.

##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| responses | [T:Study.LabWork2.Program.DemoRequestService](#T-T-Study-LabWork2-Program-DemoRequestService 'T:Study.LabWork2.Program.DemoRequestService') | Словарь, где ключом является URL сервера, а значением - предопределенный ответ. |

<a name='M-Study-LabWork2-Program-DemoRequestService-#ctor-System-Collections-Generic-Dictionary{System-String,System-String}-'></a>
### #ctor(responses) `constructor`

##### Summary

Простая реализация IRequestService для демонстрационных целей, возвращающая предопределенные ответы на запросы.

##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| responses | [System.Collections.Generic.Dictionary{System.String,System.String}](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Collections.Generic.Dictionary 'System.Collections.Generic.Dictionary{System.String,System.String}') | Словарь, где ключом является URL сервера, а значением - предопределенный ответ. |

<a name='T-Study-LabWork2-Feature-Task2-HttpRequestService'></a>
## HttpRequestService `type`

##### Namespace

Study.LabWork2.Feature.Task2

##### Summary

Реализация сервиса HTTP-запросов для Task2.

<a name='M-Study-LabWork2-Feature-Task2-HttpRequestService-#ctor-System-Net-Http-HttpClient-'></a>
### #ctor(httpClient) `constructor`

##### Summary

Создает сервис HTTP-запросов.

##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| httpClient | [System.Net.Http.HttpClient](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Net.Http.HttpClient 'System.Net.Http.HttpClient') | Экземпляр [HttpClient](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Net.Http.HttpClient 'System.Net.Http.HttpClient'). Если не передан, создается новый. |

<a name='M-Study-LabWork2-Feature-Task2-HttpRequestService-FetchData-System-String-'></a>
### FetchData(url) `method`

##### Summary

Выполняет синхронный запрос данных по указанному URL.

##### Returns

Строка с ответом сервера.

##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| url | [System.String](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.String 'System.String') | Адрес сервиса. |

<a name='M-Study-LabWork2-Feature-Task2-HttpRequestService-FetchDataAsync-System-String,System-Threading-CancellationToken-'></a>
### FetchDataAsync(url,cancellationToken) `method`

##### Summary

Выполняет асинхронный запрос данных по указанному URL.

##### Returns

Задача с ответом сервера в виде строки.

##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| url | [System.String](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.String 'System.String') | Адрес сервиса. |
| cancellationToken | [System.Threading.CancellationToken](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Threading.CancellationToken 'System.Threading.CancellationToken') | Токен отмены операции. |

<a name='T-Study-LabWork2-Feature-Task1-SubTask1-MonitorService'></a>
## MonitorService `type`

##### Namespace

Study.LabWork2.Feature.Task1.SubTask1

##### Summary

Версия 1. Использует Monitor (lock) для синхронизации

<a name='T-Study-LabWork2-Feature-Task1-SubTask1-MutexService'></a>
## MutexService `type`

##### Namespace

Study.LabWork2.Feature.Task1.SubTask1

##### Summary

Версия 2. Использует Mutex для синхронизации

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

Точка входа приложения и демонстрация запуска Task2 в двух версиях.

<a name='M-Study-LabWork2-Program-Main'></a>
### Main() `method`

##### Summary

Запускает синхронную и асинхронную версии Task2 для трех серверов.

##### Parameters

This method has no parameters.

<a name='M-Study-LabWork2-Program-RunTask2Version-Study-LabWork2-Abstractions-Feature-Task2-IServerRequestApp,Study-LabWork2-Abstractions-Feature-Task2-DtoModels-ServerConfigDto[]-'></a>
### RunTask2Version(app,servers) `method`

##### Summary

Выполняет запросы к серверам с помощью указанного приложения и выводит результаты.

##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| app | [Study.LabWork2.Abstractions.Feature.Task2.IServerRequestApp](#T-Study-LabWork2-Abstractions-Feature-Task2-IServerRequestApp 'Study.LabWork2.Abstractions.Feature.Task2.IServerRequestApp') | Приложение для выполнения запросов. |
| servers | [Study.LabWork2.Abstractions.Feature.Task2.DtoModels.ServerConfigDto[]](#T-Study-LabWork2-Abstractions-Feature-Task2-DtoModels-ServerConfigDto[] 'Study.LabWork2.Abstractions.Feature.Task2.DtoModels.ServerConfigDto[]') | Массив серверов для опроса. |

<a name='T-Study-LabWork2-Feature-Task1-SubTask1-SemaphoreService'></a>
## SemaphoreService `type`

##### Namespace

Study.LabWork2.Feature.Task1.SubTask1

##### Summary

Версия 3. Использует Semaphore для синхронизации

<a name='T-Study-LabWork2-Feature-Task2-SynchronousServerRequestApp'></a>
## SynchronousServerRequestApp `type`

##### Namespace

Study.LabWork2.Feature.Task2

##### Summary

Синхронная версия приложения (без использования async/await)

<a name='M-Study-LabWork2-Feature-Task2-SynchronousServerRequestApp-#ctor-Study-LabWork2-Abstractions-Feature-Task2-IRequestService-'></a>
### #ctor(requestService) `constructor`

##### Summary

Создает экземпляр синхронного приложения для выполнения запросов к серверам.

##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| requestService | [Study.LabWork2.Abstractions.Feature.Task2.IRequestService](#T-Study-LabWork2-Abstractions-Feature-Task2-IRequestService 'Study.LabWork2.Abstractions.Feature.Task2.IRequestService') | Сервис отправки запросов. Если не передан, используется [HttpRequestService](#T-Study-LabWork2-Feature-Task2-HttpRequestService 'Study.LabWork2.Feature.Task2.HttpRequestService'). |

<a name='M-Study-LabWork2-Feature-Task2-SynchronousServerRequestApp-DeserializeResponse``1-System-String,Study-LabWork2-Abstractions-Feature-Task2-DtoModels-ServerConfigDto-'></a>
### DeserializeResponse\`\`1(responseJson,server) `method`

##### Summary

Пытается десериализовать JSON-ответ от сервера в объект указанного типа. Если десериализация не удалась, выбрасывает исключение с подробным сообщением.

##### Returns

Десериализованный объект типа TResponse.

##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| responseJson | [System.String](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.String 'System.String') | JSON-ответ от сервера. |
| server | [Study.LabWork2.Abstractions.Feature.Task2.DtoModels.ServerConfigDto](#T-Study-LabWork2-Abstractions-Feature-Task2-DtoModels-ServerConfigDto 'Study.LabWork2.Abstractions.Feature.Task2.DtoModels.ServerConfigDto') | Конфигурация сервера, от которого получен ответ. |

##### Generic Types

| Name | Description |
| ---- | ----------- |
| TResponse | Тип модели для десериализации JSON-ответа. |

##### Exceptions

| Name | Description |
| ---- | ----------- |
| [System.InvalidOperationException](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.InvalidOperationException 'System.InvalidOperationException') | Выбрасывается, если десериализация не удалась. |

<a name='M-Study-LabWork2-Feature-Task2-SynchronousServerRequestApp-EnsurePositiveResponse-Study-LabWork2-Abstractions-Feature-Task2-DtoModels-ServerConfigDto,System-String-'></a>
### EnsurePositiveResponse(server,responseJson) `method`

##### Summary

Проверяет JSON-ответ от сервера на наличие признаков успешного выполнения. Если ответ указывает на ошибку, выбрасывает исключение.

##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| server | [Study.LabWork2.Abstractions.Feature.Task2.DtoModels.ServerConfigDto](#T-Study-LabWork2-Abstractions-Feature-Task2-DtoModels-ServerConfigDto 'Study.LabWork2.Abstractions.Feature.Task2.DtoModels.ServerConfigDto') | Конфигурация сервера, от которого получен ответ. |
| responseJson | [System.String](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.String 'System.String') | JSON-ответ от сервера. |

##### Exceptions

| Name | Description |
| ---- | ----------- |
| [System.InvalidOperationException](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.InvalidOperationException 'System.InvalidOperationException') | Выбрасывается, если ответ указывает на ошибку. |

<a name='M-Study-LabWork2-Feature-Task2-SynchronousServerRequestApp-EnsureServerConfigValid-Study-LabWork2-Abstractions-Feature-Task2-DtoModels-ServerConfigDto-'></a>
### EnsureServerConfigValid(server) `method`

##### Summary

Проверяет валидность конфигурации сервера. Если конфигурация невалидна, выбрасывает исключение.

##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| server | [Study.LabWork2.Abstractions.Feature.Task2.DtoModels.ServerConfigDto](#T-Study-LabWork2-Abstractions-Feature-Task2-DtoModels-ServerConfigDto 'Study.LabWork2.Abstractions.Feature.Task2.DtoModels.ServerConfigDto') | Конфигурация сервера для проверки. |

##### Exceptions

| Name | Description |
| ---- | ----------- |
| [System.ArgumentException](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.ArgumentException 'System.ArgumentException') | Выбрасывается, если конфигурация сервера невалидна. |

<a name='M-Study-LabWork2-Feature-Task2-SynchronousServerRequestApp-ExecuteRequests``1-Study-LabWork2-Abstractions-Feature-Task2-DtoModels-ServerConfigDto[]-'></a>
### ExecuteRequests\`\`1(servers) `method`

##### Summary

Выполняет запросы к серверам последовательно и возвращает агрегированный результат.

##### Returns

Результат выполнения запросов.

##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| servers | [Study.LabWork2.Abstractions.Feature.Task2.DtoModels.ServerConfigDto[]](#T-Study-LabWork2-Abstractions-Feature-Task2-DtoModels-ServerConfigDto[] 'Study.LabWork2.Abstractions.Feature.Task2.DtoModels.ServerConfigDto[]') | Массив серверов для опроса. |

##### Generic Types

| Name | Description |
| ---- | ----------- |
| TResponse | Тип модели для десериализации JSON-ответов. |

<a name='M-Study-LabWork2-Feature-Task2-SynchronousServerRequestApp-GetVersion'></a>
### GetVersion() `method`

##### Summary

Возвращает название версии приложения.

##### Returns

Строка с названием версии.

##### Parameters

This method has no parameters.

<a name='M-Study-LabWork2-Feature-Task2-SynchronousServerRequestApp-IsPositiveResponse-System-String-'></a>
### IsPositiveResponse(json) `method`

##### Summary

Проверяет JSON-ответ от сервера на наличие признаков положительного ответа. Если JSON не является объектом или не содержит явных признаков отрицательного ответа, считается положительным.

##### Returns

`true`, если ответ считается положительным; иначе `false`.

##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| json | [System.String](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.String 'System.String') | JSON-ответ от сервера. |

<a name='M-Study-LabWork2-Feature-Task2-SynchronousServerRequestApp-TryGetBoolean-System-Text-Json-JsonElement,System-String,System-Boolean@-'></a>
### TryGetBoolean(root,propertyName,value) `method`

##### Summary

Пытается извлечь логическое значение из JSON-объекта по указанному имени свойства. Учитывает, что свойство может быть представлено как true/false или как строка "true"/"false". Если извлечение прошло успешно, возвращает `true` и устанавливает значение; иначе возвращает `false` и устанавливает значение в `false`.

##### Returns

`true`, если извлечение прошло успешно; иначе `false`.

##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| root | [System.Text.Json.JsonElement](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Text.Json.JsonElement 'System.Text.Json.JsonElement') | JSON-объект для извлечения значения. |
| propertyName | [System.String](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.String 'System.String') | Имя свойства для извлечения. |
| value | [System.Boolean@](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Boolean@ 'System.Boolean@') | Извлеченное логическое значение. |
