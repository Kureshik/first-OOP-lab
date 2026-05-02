<a name='assembly'></a>
# Study.LabWork2.UnitTests

## Contents

- [AsynchronousServerRequestAppTests](#T-Study-LabWork2-UnitTests-Feature-Task2-AsynchronousServerRequestAppTests 'Study.LabWork2.UnitTests.Feature.Task2.AsynchronousServerRequestAppTests')
  - [ExecuteRequests_ProcessesThreeServers_AndPrintsJsonAndTotalTime()](#M-Study-LabWork2-UnitTests-Feature-Task2-AsynchronousServerRequestAppTests-ExecuteRequests_ProcessesThreeServers_AndPrintsJsonAndTotalTime 'Study.LabWork2.UnitTests.Feature.Task2.AsynchronousServerRequestAppTests.ExecuteRequests_ProcessesThreeServers_AndPrintsJsonAndTotalTime')
  - [ExecuteRequests_ThrowsArgumentException_WhenServersInvalid()](#M-Study-LabWork2-UnitTests-Feature-Task2-AsynchronousServerRequestAppTests-ExecuteRequests_ThrowsArgumentException_WhenServersInvalid 'Study.LabWork2.UnitTests.Feature.Task2.AsynchronousServerRequestAppTests.ExecuteRequests_ThrowsArgumentException_WhenServersInvalid')
  - [ExecuteRequests_Throws_WhenServerReturnsNegativeResponse()](#M-Study-LabWork2-UnitTests-Feature-Task2-AsynchronousServerRequestAppTests-ExecuteRequests_Throws_WhenServerReturnsNegativeResponse 'Study.LabWork2.UnitTests.Feature.Task2.AsynchronousServerRequestAppTests.ExecuteRequests_Throws_WhenServerReturnsNegativeResponse')
  - [GetVersion_ReturnsAsynchronous()](#M-Study-LabWork2-UnitTests-Feature-Task2-AsynchronousServerRequestAppTests-GetVersion_ReturnsAsynchronous 'Study.LabWork2.UnitTests.Feature.Task2.AsynchronousServerRequestAppTests.GetVersion_ReturnsAsynchronous')
  - [SetUp()](#M-Study-LabWork2-UnitTests-Feature-Task2-AsynchronousServerRequestAppTests-SetUp 'Study.LabWork2.UnitTests.Feature.Task2.AsynchronousServerRequestAppTests.SetUp')
  - [TearDown()](#M-Study-LabWork2-UnitTests-Feature-Task2-AsynchronousServerRequestAppTests-TearDown 'Study.LabWork2.UnitTests.Feature.Task2.AsynchronousServerRequestAppTests.TearDown')
- [SynchronousServerRequestAppTests](#T-Study-LabWork2-UnitTests-Feature-Task2-SynchronousServerRequestAppTests 'Study.LabWork2.UnitTests.Feature.Task2.SynchronousServerRequestAppTests')
  - [ExecuteRequests_ProcessesThreeServers_AndPrintsJsonAndTotalTime()](#M-Study-LabWork2-UnitTests-Feature-Task2-SynchronousServerRequestAppTests-ExecuteRequests_ProcessesThreeServers_AndPrintsJsonAndTotalTime 'Study.LabWork2.UnitTests.Feature.Task2.SynchronousServerRequestAppTests.ExecuteRequests_ProcessesThreeServers_AndPrintsJsonAndTotalTime')
  - [ExecuteRequests_ThrowsAndStops_WhenServerReturnsNegativeResponse()](#M-Study-LabWork2-UnitTests-Feature-Task2-SynchronousServerRequestAppTests-ExecuteRequests_ThrowsAndStops_WhenServerReturnsNegativeResponse 'Study.LabWork2.UnitTests.Feature.Task2.SynchronousServerRequestAppTests.ExecuteRequests_ThrowsAndStops_WhenServerReturnsNegativeResponse')
  - [ExecuteRequests_ThrowsArgumentException_WhenServersInvalid()](#M-Study-LabWork2-UnitTests-Feature-Task2-SynchronousServerRequestAppTests-ExecuteRequests_ThrowsArgumentException_WhenServersInvalid 'Study.LabWork2.UnitTests.Feature.Task2.SynchronousServerRequestAppTests.ExecuteRequests_ThrowsArgumentException_WhenServersInvalid')
  - [GetVersion_ReturnsSynchronous()](#M-Study-LabWork2-UnitTests-Feature-Task2-SynchronousServerRequestAppTests-GetVersion_ReturnsSynchronous 'Study.LabWork2.UnitTests.Feature.Task2.SynchronousServerRequestAppTests.GetVersion_ReturnsSynchronous')
  - [SetUp()](#M-Study-LabWork2-UnitTests-Feature-Task2-SynchronousServerRequestAppTests-SetUp 'Study.LabWork2.UnitTests.Feature.Task2.SynchronousServerRequestAppTests.SetUp')
  - [TearDown()](#M-Study-LabWork2-UnitTests-Feature-Task2-SynchronousServerRequestAppTests-TearDown 'Study.LabWork2.UnitTests.Feature.Task2.SynchronousServerRequestAppTests.TearDown')

<a name='T-Study-LabWork2-UnitTests-Feature-Task2-AsynchronousServerRequestAppTests'></a>
## AsynchronousServerRequestAppTests `type`

##### Namespace

Study.LabWork2.UnitTests.Feature.Task2

##### Summary

Тесты для [AsynchronousServerRequestApp](#T-Study-LabWork2-Feature-Task2-AsynchronousServerRequestApp 'Study.LabWork2.Feature.Task2.AsynchronousServerRequestApp').

<a name='M-Study-LabWork2-UnitTests-Feature-Task2-AsynchronousServerRequestAppTests-ExecuteRequests_ProcessesThreeServers_AndPrintsJsonAndTotalTime'></a>
### ExecuteRequests_ProcessesThreeServers_AndPrintsJsonAndTotalTime() `method`

##### Summary

Проверяет обработку трех серверов, JSON-вывод ответов и вывод общего времени выполнения.

##### Parameters

This method has no parameters.

<a name='M-Study-LabWork2-UnitTests-Feature-Task2-AsynchronousServerRequestAppTests-ExecuteRequests_ThrowsArgumentException_WhenServersInvalid'></a>
### ExecuteRequests_ThrowsArgumentException_WhenServersInvalid() `method`

##### Summary

Проверяет выброс [ArgumentException](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.ArgumentException 'System.ArgumentException') при невалидной конфигурации серверов.

##### Parameters

This method has no parameters.

<a name='M-Study-LabWork2-UnitTests-Feature-Task2-AsynchronousServerRequestAppTests-ExecuteRequests_Throws_WhenServerReturnsNegativeResponse'></a>
### ExecuteRequests_Throws_WhenServerReturnsNegativeResponse() `method`

##### Summary

Проверяет выброс исключения при отрицательном ответе одного из серверов.

##### Parameters

This method has no parameters.

<a name='M-Study-LabWork2-UnitTests-Feature-Task2-AsynchronousServerRequestAppTests-GetVersion_ReturnsAsynchronous'></a>
### GetVersion_ReturnsAsynchronous() `method`

##### Summary

Проверяет, что версия асинхронного приложения возвращается корректно.

##### Parameters

This method has no parameters.

<a name='M-Study-LabWork2-UnitTests-Feature-Task2-AsynchronousServerRequestAppTests-SetUp'></a>
### SetUp() `method`

##### Summary

Сохраняет исходный поток вывода консоли перед каждым тестом.

##### Parameters

This method has no parameters.

<a name='M-Study-LabWork2-UnitTests-Feature-Task2-AsynchronousServerRequestAppTests-TearDown'></a>
### TearDown() `method`

##### Summary

Восстанавливает исходный поток вывода консоли после каждого теста.

##### Parameters

This method has no parameters.

<a name='T-Study-LabWork2-UnitTests-Feature-Task2-SynchronousServerRequestAppTests'></a>
## SynchronousServerRequestAppTests `type`

##### Namespace

Study.LabWork2.UnitTests.Feature.Task2

##### Summary

Тесты для [SynchronousServerRequestApp](#T-Study-LabWork2-Feature-Task2-SynchronousServerRequestApp 'Study.LabWork2.Feature.Task2.SynchronousServerRequestApp').

<a name='M-Study-LabWork2-UnitTests-Feature-Task2-SynchronousServerRequestAppTests-ExecuteRequests_ProcessesThreeServers_AndPrintsJsonAndTotalTime'></a>
### ExecuteRequests_ProcessesThreeServers_AndPrintsJsonAndTotalTime() `method`

##### Summary

Проверяет обработку трех серверов, JSON-вывод ответов и вывод общего времени выполнения.

##### Parameters

This method has no parameters.

<a name='M-Study-LabWork2-UnitTests-Feature-Task2-SynchronousServerRequestAppTests-ExecuteRequests_ThrowsAndStops_WhenServerReturnsNegativeResponse'></a>
### ExecuteRequests_ThrowsAndStops_WhenServerReturnsNegativeResponse() `method`

##### Summary

Проверяет остановку выполнения и выброс исключения при отрицательном ответе сервера.

##### Parameters

This method has no parameters.

<a name='M-Study-LabWork2-UnitTests-Feature-Task2-SynchronousServerRequestAppTests-ExecuteRequests_ThrowsArgumentException_WhenServersInvalid'></a>
### ExecuteRequests_ThrowsArgumentException_WhenServersInvalid() `method`

##### Summary

Проверяет выброс [ArgumentException](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.ArgumentException 'System.ArgumentException') при невалидной конфигурации серверов.

##### Parameters

This method has no parameters.

<a name='M-Study-LabWork2-UnitTests-Feature-Task2-SynchronousServerRequestAppTests-GetVersion_ReturnsSynchronous'></a>
### GetVersion_ReturnsSynchronous() `method`

##### Summary

Проверяет, что версия синхронного приложения возвращается корректно.

##### Parameters

This method has no parameters.

<a name='M-Study-LabWork2-UnitTests-Feature-Task2-SynchronousServerRequestAppTests-SetUp'></a>
### SetUp() `method`

##### Summary

Сохраняет исходный поток вывода консоли перед каждым тестом.

##### Parameters

This method has no parameters.

<a name='M-Study-LabWork2-UnitTests-Feature-Task2-SynchronousServerRequestAppTests-TearDown'></a>
### TearDown() `method`

##### Summary

Восстанавливает исходный поток вывода консоли после каждого теста.

##### Parameters

This method has no parameters.
