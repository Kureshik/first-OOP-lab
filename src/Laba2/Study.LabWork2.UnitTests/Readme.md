<a name='assembly'></a>
# Study.LabWork2.UnitTests

## Contents

- [MonitorServiceTests](#T-Study-LabWork2-UnitTests-Feature-Task1-SubTask1-MonitorServiceTests 'Study.LabWork2.UnitTests.Feature.Task1.SubTask1.MonitorServiceTests')
  - [CountPrimes_CountsPrimesCorrectly_OnSmallRange()](#M-Study-LabWork2-UnitTests-Feature-Task1-SubTask1-MonitorServiceTests-CountPrimes_CountsPrimesCorrectly_OnSmallRange 'Study.LabWork2.UnitTests.Feature.Task1.SubTask1.MonitorServiceTests.CountPrimes_CountsPrimesCorrectly_OnSmallRange')
  - [CountPrimes_DoesNotThrow_OnValidParameters()](#M-Study-LabWork2-UnitTests-Feature-Task1-SubTask1-MonitorServiceTests-CountPrimes_DoesNotThrow_OnValidParameters 'Study.LabWork2.UnitTests.Feature.Task1.SubTask1.MonitorServiceTests.CountPrimes_DoesNotThrow_OnValidParameters')
  - [CountPrimes_FoundPrimes_AreOrderedAscending()](#M-Study-LabWork2-UnitTests-Feature-Task1-SubTask1-MonitorServiceTests-CountPrimes_FoundPrimes_AreOrderedAscending 'Study.LabWork2.UnitTests.Feature.Task1.SubTask1.MonitorServiceTests.CountPrimes_FoundPrimes_AreOrderedAscending')
  - [CountPrimes_IsIdempotent_OnRepeatedCalls()](#M-Study-LabWork2-UnitTests-Feature-Task1-SubTask1-MonitorServiceTests-CountPrimes_IsIdempotent_OnRepeatedCalls 'Study.LabWork2.UnitTests.Feature.Task1.SubTask1.MonitorServiceTests.CountPrimes_IsIdempotent_OnRepeatedCalls')
  - [CountPrimes_LargeRange_MatchesKnownPrimeTotal()](#M-Study-LabWork2-UnitTests-Feature-Task1-SubTask1-MonitorServiceTests-CountPrimes_LargeRange_MatchesKnownPrimeTotal 'Study.LabWork2.UnitTests.Feature.Task1.SubTask1.MonitorServiceTests.CountPrimes_LargeRange_MatchesKnownPrimeTotal')
  - [CountPrimes_PrimeCount_EqualsFoundPrimesListCount()](#M-Study-LabWork2-UnitTests-Feature-Task1-SubTask1-MonitorServiceTests-CountPrimes_PrimeCount_EqualsFoundPrimesListCount 'Study.LabWork2.UnitTests.Feature.Task1.SubTask1.MonitorServiceTests.CountPrimes_PrimeCount_EqualsFoundPrimesListCount')
  - [CountPrimes_ThreadCount_MatchesActuallySpawnedWorkers()](#M-Study-LabWork2-UnitTests-Feature-Task1-SubTask1-MonitorServiceTests-CountPrimes_ThreadCount_MatchesActuallySpawnedWorkers 'Study.LabWork2.UnitTests.Feature.Task1.SubTask1.MonitorServiceTests.CountPrimes_ThreadCount_MatchesActuallySpawnedWorkers')
  - [CountPrimes_ThrowsArgumentException_WhenEndLessThanStart()](#M-Study-LabWork2-UnitTests-Feature-Task1-SubTask1-MonitorServiceTests-CountPrimes_ThrowsArgumentException_WhenEndLessThanStart 'Study.LabWork2.UnitTests.Feature.Task1.SubTask1.MonitorServiceTests.CountPrimes_ThrowsArgumentException_WhenEndLessThanStart')
  - [CountPrimes_ThrowsArgumentOutOfRange_WhenThreadCountNotPositive()](#M-Study-LabWork2-UnitTests-Feature-Task1-SubTask1-MonitorServiceTests-CountPrimes_ThrowsArgumentOutOfRange_WhenThreadCountNotPositive 'Study.LabWork2.UnitTests.Feature.Task1.SubTask1.MonitorServiceTests.CountPrimes_ThrowsArgumentOutOfRange_WhenThreadCountNotPositive')
  - [CountPrimes_WithMultipleThreads_HasUniqueOrderedPrimes()](#M-Study-LabWork2-UnitTests-Feature-Task1-SubTask1-MonitorServiceTests-CountPrimes_WithMultipleThreads_HasUniqueOrderedPrimes 'Study.LabWork2.UnitTests.Feature.Task1.SubTask1.MonitorServiceTests.CountPrimes_WithMultipleThreads_HasUniqueOrderedPrimes')
  - [GetVersionName_ReturnsExpected()](#M-Study-LabWork2-UnitTests-Feature-Task1-SubTask1-MonitorServiceTests-GetVersionName_ReturnsExpected 'Study.LabWork2.UnitTests.Feature.Task1.SubTask1.MonitorServiceTests.GetVersionName_ReturnsExpected')
- [MutexServiceTests](#T-Study-LabWork2-UnitTests-Feature-Task1-SubTask1-MutexServiceTests 'Study.LabWork2.UnitTests.Feature.Task1.SubTask1.MutexServiceTests')
  - [CountPrimes_CountsPrimesCorrectly_OnSmallRange()](#M-Study-LabWork2-UnitTests-Feature-Task1-SubTask1-MutexServiceTests-CountPrimes_CountsPrimesCorrectly_OnSmallRange 'Study.LabWork2.UnitTests.Feature.Task1.SubTask1.MutexServiceTests.CountPrimes_CountsPrimesCorrectly_OnSmallRange')
  - [CountPrimes_DoesNotThrow_OnValidParameters()](#M-Study-LabWork2-UnitTests-Feature-Task1-SubTask1-MutexServiceTests-CountPrimes_DoesNotThrow_OnValidParameters 'Study.LabWork2.UnitTests.Feature.Task1.SubTask1.MutexServiceTests.CountPrimes_DoesNotThrow_OnValidParameters')
  - [CountPrimes_FoundPrimes_AreOrderedAscending()](#M-Study-LabWork2-UnitTests-Feature-Task1-SubTask1-MutexServiceTests-CountPrimes_FoundPrimes_AreOrderedAscending 'Study.LabWork2.UnitTests.Feature.Task1.SubTask1.MutexServiceTests.CountPrimes_FoundPrimes_AreOrderedAscending')
  - [CountPrimes_IsIdempotent_OnRepeatedCalls()](#M-Study-LabWork2-UnitTests-Feature-Task1-SubTask1-MutexServiceTests-CountPrimes_IsIdempotent_OnRepeatedCalls 'Study.LabWork2.UnitTests.Feature.Task1.SubTask1.MutexServiceTests.CountPrimes_IsIdempotent_OnRepeatedCalls')
  - [CountPrimes_LargeRange_MatchesKnownPrimeTotal()](#M-Study-LabWork2-UnitTests-Feature-Task1-SubTask1-MutexServiceTests-CountPrimes_LargeRange_MatchesKnownPrimeTotal 'Study.LabWork2.UnitTests.Feature.Task1.SubTask1.MutexServiceTests.CountPrimes_LargeRange_MatchesKnownPrimeTotal')
  - [CountPrimes_PrimeCount_EqualsFoundPrimesListCount()](#M-Study-LabWork2-UnitTests-Feature-Task1-SubTask1-MutexServiceTests-CountPrimes_PrimeCount_EqualsFoundPrimesListCount 'Study.LabWork2.UnitTests.Feature.Task1.SubTask1.MutexServiceTests.CountPrimes_PrimeCount_EqualsFoundPrimesListCount')
  - [CountPrimes_ThreadCount_MatchesActuallySpawnedWorkers()](#M-Study-LabWork2-UnitTests-Feature-Task1-SubTask1-MutexServiceTests-CountPrimes_ThreadCount_MatchesActuallySpawnedWorkers 'Study.LabWork2.UnitTests.Feature.Task1.SubTask1.MutexServiceTests.CountPrimes_ThreadCount_MatchesActuallySpawnedWorkers')
  - [CountPrimes_ThrowsArgumentException_WhenEndLessThanStart()](#M-Study-LabWork2-UnitTests-Feature-Task1-SubTask1-MutexServiceTests-CountPrimes_ThrowsArgumentException_WhenEndLessThanStart 'Study.LabWork2.UnitTests.Feature.Task1.SubTask1.MutexServiceTests.CountPrimes_ThrowsArgumentException_WhenEndLessThanStart')
  - [CountPrimes_ThrowsArgumentOutOfRange_WhenThreadCountNotPositive()](#M-Study-LabWork2-UnitTests-Feature-Task1-SubTask1-MutexServiceTests-CountPrimes_ThrowsArgumentOutOfRange_WhenThreadCountNotPositive 'Study.LabWork2.UnitTests.Feature.Task1.SubTask1.MutexServiceTests.CountPrimes_ThrowsArgumentOutOfRange_WhenThreadCountNotPositive')
  - [CountPrimes_WithMultipleThreads_HasUniqueOrderedPrimes()](#M-Study-LabWork2-UnitTests-Feature-Task1-SubTask1-MutexServiceTests-CountPrimes_WithMultipleThreads_HasUniqueOrderedPrimes 'Study.LabWork2.UnitTests.Feature.Task1.SubTask1.MutexServiceTests.CountPrimes_WithMultipleThreads_HasUniqueOrderedPrimes')
  - [GetVersionName_ReturnsExpected()](#M-Study-LabWork2-UnitTests-Feature-Task1-SubTask1-MutexServiceTests-GetVersionName_ReturnsExpected 'Study.LabWork2.UnitTests.Feature.Task1.SubTask1.MutexServiceTests.GetVersionName_ReturnsExpected')
- [SemaphoreServiceTests](#T-Study-LabWork2-UnitTests-Feature-Task1-SubTask1-SemaphoreServiceTests 'Study.LabWork2.UnitTests.Feature.Task1.SubTask1.SemaphoreServiceTests')
  - [CountPrimes_CountsPrimesCorrectly_OnSmallRange()](#M-Study-LabWork2-UnitTests-Feature-Task1-SubTask1-SemaphoreServiceTests-CountPrimes_CountsPrimesCorrectly_OnSmallRange 'Study.LabWork2.UnitTests.Feature.Task1.SubTask1.SemaphoreServiceTests.CountPrimes_CountsPrimesCorrectly_OnSmallRange')
  - [CountPrimes_DoesNotThrow_OnValidParameters()](#M-Study-LabWork2-UnitTests-Feature-Task1-SubTask1-SemaphoreServiceTests-CountPrimes_DoesNotThrow_OnValidParameters 'Study.LabWork2.UnitTests.Feature.Task1.SubTask1.SemaphoreServiceTests.CountPrimes_DoesNotThrow_OnValidParameters')
  - [CountPrimes_FoundPrimes_AreOrderedAscending()](#M-Study-LabWork2-UnitTests-Feature-Task1-SubTask1-SemaphoreServiceTests-CountPrimes_FoundPrimes_AreOrderedAscending 'Study.LabWork2.UnitTests.Feature.Task1.SubTask1.SemaphoreServiceTests.CountPrimes_FoundPrimes_AreOrderedAscending')
  - [CountPrimes_IsIdempotent_OnRepeatedCalls()](#M-Study-LabWork2-UnitTests-Feature-Task1-SubTask1-SemaphoreServiceTests-CountPrimes_IsIdempotent_OnRepeatedCalls 'Study.LabWork2.UnitTests.Feature.Task1.SubTask1.SemaphoreServiceTests.CountPrimes_IsIdempotent_OnRepeatedCalls')
  - [CountPrimes_LargeRange_MatchesKnownPrimeTotal()](#M-Study-LabWork2-UnitTests-Feature-Task1-SubTask1-SemaphoreServiceTests-CountPrimes_LargeRange_MatchesKnownPrimeTotal 'Study.LabWork2.UnitTests.Feature.Task1.SubTask1.SemaphoreServiceTests.CountPrimes_LargeRange_MatchesKnownPrimeTotal')
  - [CountPrimes_PrimeCount_EqualsFoundPrimesListCount()](#M-Study-LabWork2-UnitTests-Feature-Task1-SubTask1-SemaphoreServiceTests-CountPrimes_PrimeCount_EqualsFoundPrimesListCount 'Study.LabWork2.UnitTests.Feature.Task1.SubTask1.SemaphoreServiceTests.CountPrimes_PrimeCount_EqualsFoundPrimesListCount')
  - [CountPrimes_ThreadCount_MatchesActuallySpawnedWorkers()](#M-Study-LabWork2-UnitTests-Feature-Task1-SubTask1-SemaphoreServiceTests-CountPrimes_ThreadCount_MatchesActuallySpawnedWorkers 'Study.LabWork2.UnitTests.Feature.Task1.SubTask1.SemaphoreServiceTests.CountPrimes_ThreadCount_MatchesActuallySpawnedWorkers')
  - [CountPrimes_ThrowsArgumentException_WhenEndLessThanStart()](#M-Study-LabWork2-UnitTests-Feature-Task1-SubTask1-SemaphoreServiceTests-CountPrimes_ThrowsArgumentException_WhenEndLessThanStart 'Study.LabWork2.UnitTests.Feature.Task1.SubTask1.SemaphoreServiceTests.CountPrimes_ThrowsArgumentException_WhenEndLessThanStart')
  - [CountPrimes_ThrowsArgumentOutOfRange_WhenThreadCountNotPositive()](#M-Study-LabWork2-UnitTests-Feature-Task1-SubTask1-SemaphoreServiceTests-CountPrimes_ThrowsArgumentOutOfRange_WhenThreadCountNotPositive 'Study.LabWork2.UnitTests.Feature.Task1.SubTask1.SemaphoreServiceTests.CountPrimes_ThrowsArgumentOutOfRange_WhenThreadCountNotPositive')
  - [CountPrimes_WithMultipleThreads_HasUniqueOrderedPrimes()](#M-Study-LabWork2-UnitTests-Feature-Task1-SubTask1-SemaphoreServiceTests-CountPrimes_WithMultipleThreads_HasUniqueOrderedPrimes 'Study.LabWork2.UnitTests.Feature.Task1.SubTask1.SemaphoreServiceTests.CountPrimes_WithMultipleThreads_HasUniqueOrderedPrimes')
  - [GetVersionName_ReturnsExpected()](#M-Study-LabWork2-UnitTests-Feature-Task1-SubTask1-SemaphoreServiceTests-GetVersionName_ReturnsExpected 'Study.LabWork2.UnitTests.Feature.Task1.SubTask1.SemaphoreServiceTests.GetVersionName_ReturnsExpected')

<a name='T-Study-LabWork2-UnitTests-Feature-Task1-SubTask1-MonitorServiceTests'></a>
## MonitorServiceTests `type`

##### Namespace

Study.LabWork2.UnitTests.Feature.Task1.SubTask1

##### Summary

Тесты для [MonitorService](#T-Study-LabWork2-Feature-Task1-SubTask1-MonitorService 'Study.LabWork2.Feature.Task1.SubTask1.MonitorService') — подсчёт простых чисел с синхронизацией через Monitor (lock).

<a name='M-Study-LabWork2-UnitTests-Feature-Task1-SubTask1-MonitorServiceTests-CountPrimes_CountsPrimesCorrectly_OnSmallRange'></a>
### CountPrimes_CountsPrimesCorrectly_OnSmallRange() `method`

##### Summary

Проверяет корректность подсчёта простых чисел на небольшом диапазоне и заполнение полей результата.

##### Parameters

This method has no parameters.

<a name='M-Study-LabWork2-UnitTests-Feature-Task1-SubTask1-MonitorServiceTests-CountPrimes_DoesNotThrow_OnValidParameters'></a>
### CountPrimes_DoesNotThrow_OnValidParameters() `method`

##### Summary

Проверяет, что вызов [CountPrimes](#M-Study-LabWork2-Feature-Task1-SubTask1-MonitorService-CountPrimes-System-Int32,System-Int32,System-Int32- 'Study.LabWork2.Feature.Task1.SubTask1.MonitorService.CountPrimes(System.Int32,System.Int32,System.Int32)') при корректных параметрах завершается без исключений.

##### Parameters

This method has no parameters.

<a name='M-Study-LabWork2-UnitTests-Feature-Task1-SubTask1-MonitorServiceTests-CountPrimes_FoundPrimes_AreOrderedAscending'></a>
### CountPrimes_FoundPrimes_AreOrderedAscending() `method`

##### Summary

Проверяет, что найденные простые числа в результате упорядочены по возрастанию.

##### Parameters

This method has no parameters.

<a name='M-Study-LabWork2-UnitTests-Feature-Task1-SubTask1-MonitorServiceTests-CountPrimes_IsIdempotent_OnRepeatedCalls'></a>
### CountPrimes_IsIdempotent_OnRepeatedCalls() `method`

##### Summary

Проверяет, что повторный вызов [CountPrimes](#M-Study-LabWork2-Feature-Task1-SubTask1-MonitorService-CountPrimes-System-Int32,System-Int32,System-Int32- 'Study.LabWork2.Feature.Task1.SubTask1.MonitorService.CountPrimes(System.Int32,System.Int32,System.Int32)') даёт тот же набор простых для тех же параметров.

##### Parameters

This method has no parameters.

<a name='M-Study-LabWork2-UnitTests-Feature-Task1-SubTask1-MonitorServiceTests-CountPrimes_LargeRange_MatchesKnownPrimeTotal'></a>
### CountPrimes_LargeRange_MatchesKnownPrimeTotal() `method`

##### Summary

Проверяет соответствие подсчёта известному значению для диапазона 2–10 000 (1229 простых).

##### Parameters

This method has no parameters.

<a name='M-Study-LabWork2-UnitTests-Feature-Task1-SubTask1-MonitorServiceTests-CountPrimes_PrimeCount_EqualsFoundPrimesListCount'></a>
### CountPrimes_PrimeCount_EqualsFoundPrimesListCount() `method`

##### Summary

Проверяет, что [PrimeCount](#P-Study-LabWork2-Abstractions-Feature-Task1-SubTask1-DtoModels-PrimeCountResultDto-PrimeCount 'Study.LabWork2.Abstractions.Feature.Task1.SubTask1.DtoModels.PrimeCountResultDto.PrimeCount') совпадает с количеством элементов в
[FoundPrimes](#P-Study-LabWork2-Abstractions-Feature-Task1-SubTask1-DtoModels-PrimeCountResultDto-FoundPrimes 'Study.LabWork2.Abstractions.Feature.Task1.SubTask1.DtoModels.PrimeCountResultDto.FoundPrimes').

##### Parameters

This method has no parameters.

<a name='M-Study-LabWork2-UnitTests-Feature-Task1-SubTask1-MonitorServiceTests-CountPrimes_ThreadCount_MatchesActuallySpawnedWorkers'></a>
### CountPrimes_ThreadCount_MatchesActuallySpawnedWorkers() `method`

##### Summary

Проверяет, что фактическое число созданных потоков-рабочих в результате может быть меньше запрошенного,
если диапазон короткий и часть потоков не получает ни одного числа.

##### Parameters

This method has no parameters.

<a name='M-Study-LabWork2-UnitTests-Feature-Task1-SubTask1-MonitorServiceTests-CountPrimes_ThrowsArgumentException_WhenEndLessThanStart'></a>
### CountPrimes_ThrowsArgumentException_WhenEndLessThanStart() `method`

##### Summary

Проверяет, что [CountPrimes](#M-Study-LabWork2-Feature-Task1-SubTask1-MonitorService-CountPrimes-System-Int32,System-Int32,System-Int32- 'Study.LabWork2.Feature.Task1.SubTask1.MonitorService.CountPrimes(System.Int32,System.Int32,System.Int32)') выбрасывает [ArgumentException](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.ArgumentException 'System.ArgumentException'),
если конец диапазона меньше начала.

##### Parameters

This method has no parameters.

<a name='M-Study-LabWork2-UnitTests-Feature-Task1-SubTask1-MonitorServiceTests-CountPrimes_ThrowsArgumentOutOfRange_WhenThreadCountNotPositive'></a>
### CountPrimes_ThrowsArgumentOutOfRange_WhenThreadCountNotPositive() `method`

##### Summary

Проверяет, что [CountPrimes](#M-Study-LabWork2-Feature-Task1-SubTask1-MonitorService-CountPrimes-System-Int32,System-Int32,System-Int32- 'Study.LabWork2.Feature.Task1.SubTask1.MonitorService.CountPrimes(System.Int32,System.Int32,System.Int32)') выбрасывает [ArgumentOutOfRangeException](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.ArgumentOutOfRangeException 'System.ArgumentOutOfRangeException'),
если количество потоков неположительно.

##### Parameters

This method has no parameters.

<a name='M-Study-LabWork2-UnitTests-Feature-Task1-SubTask1-MonitorServiceTests-CountPrimes_WithMultipleThreads_HasUniqueOrderedPrimes'></a>
### CountPrimes_WithMultipleThreads_HasUniqueOrderedPrimes() `method`

##### Summary

Проверяет, что при нескольких потоках результат остаётся консистентным (нет пропусков и дубликатов в списке).

##### Parameters

This method has no parameters.

<a name='M-Study-LabWork2-UnitTests-Feature-Task1-SubTask1-MonitorServiceTests-GetVersionName_ReturnsExpected'></a>
### GetVersionName_ReturnsExpected() `method`

##### Summary

Проверяет, что [GetVersionName](#M-Study-LabWork2-Feature-Task1-SubTask1-MonitorService-GetVersionName 'Study.LabWork2.Feature.Task1.SubTask1.MonitorService.GetVersionName') возвращает ожидаемое имя версии.

##### Parameters

This method has no parameters.

<a name='T-Study-LabWork2-UnitTests-Feature-Task1-SubTask1-MutexServiceTests'></a>
## MutexServiceTests `type`

##### Namespace

Study.LabWork2.UnitTests.Feature.Task1.SubTask1

##### Summary

Тесты для [MutexService](#T-Study-LabWork2-Feature-Task1-SubTask1-MutexService 'Study.LabWork2.Feature.Task1.SubTask1.MutexService') — подсчёт простых чисел с синхронизацией через Mutex.

<a name='M-Study-LabWork2-UnitTests-Feature-Task1-SubTask1-MutexServiceTests-CountPrimes_CountsPrimesCorrectly_OnSmallRange'></a>
### CountPrimes_CountsPrimesCorrectly_OnSmallRange() `method`

##### Summary

Проверяет корректность подсчёта простых чисел на небольшом диапазоне и заполнение полей результата.

##### Parameters

This method has no parameters.

<a name='M-Study-LabWork2-UnitTests-Feature-Task1-SubTask1-MutexServiceTests-CountPrimes_DoesNotThrow_OnValidParameters'></a>
### CountPrimes_DoesNotThrow_OnValidParameters() `method`

##### Summary

Проверяет, что вызов [CountPrimes](#M-Study-LabWork2-Feature-Task1-SubTask1-MutexService-CountPrimes-System-Int32,System-Int32,System-Int32- 'Study.LabWork2.Feature.Task1.SubTask1.MutexService.CountPrimes(System.Int32,System.Int32,System.Int32)') при корректных параметрах завершается без исключений.

##### Parameters

This method has no parameters.

<a name='M-Study-LabWork2-UnitTests-Feature-Task1-SubTask1-MutexServiceTests-CountPrimes_FoundPrimes_AreOrderedAscending'></a>
### CountPrimes_FoundPrimes_AreOrderedAscending() `method`

##### Summary

Проверяет, что найденные простые числа в результате упорядочены по возрастанию.

##### Parameters

This method has no parameters.

<a name='M-Study-LabWork2-UnitTests-Feature-Task1-SubTask1-MutexServiceTests-CountPrimes_IsIdempotent_OnRepeatedCalls'></a>
### CountPrimes_IsIdempotent_OnRepeatedCalls() `method`

##### Summary

Проверяет, что повторный вызов [CountPrimes](#M-Study-LabWork2-Feature-Task1-SubTask1-MutexService-CountPrimes-System-Int32,System-Int32,System-Int32- 'Study.LabWork2.Feature.Task1.SubTask1.MutexService.CountPrimes(System.Int32,System.Int32,System.Int32)') даёт тот же набор простых для тех же параметров.

##### Parameters

This method has no parameters.

<a name='M-Study-LabWork2-UnitTests-Feature-Task1-SubTask1-MutexServiceTests-CountPrimes_LargeRange_MatchesKnownPrimeTotal'></a>
### CountPrimes_LargeRange_MatchesKnownPrimeTotal() `method`

##### Summary

Проверяет соответствие подсчёта известному значению для диапазона 2–10 000 (1229 простых).

##### Parameters

This method has no parameters.

<a name='M-Study-LabWork2-UnitTests-Feature-Task1-SubTask1-MutexServiceTests-CountPrimes_PrimeCount_EqualsFoundPrimesListCount'></a>
### CountPrimes_PrimeCount_EqualsFoundPrimesListCount() `method`

##### Summary

Проверяет, что [PrimeCount](#P-Study-LabWork2-Abstractions-Feature-Task1-SubTask1-DtoModels-PrimeCountResultDto-PrimeCount 'Study.LabWork2.Abstractions.Feature.Task1.SubTask1.DtoModels.PrimeCountResultDto.PrimeCount') совпадает с количеством элементов в
[FoundPrimes](#P-Study-LabWork2-Abstractions-Feature-Task1-SubTask1-DtoModels-PrimeCountResultDto-FoundPrimes 'Study.LabWork2.Abstractions.Feature.Task1.SubTask1.DtoModels.PrimeCountResultDto.FoundPrimes').

##### Parameters

This method has no parameters.

<a name='M-Study-LabWork2-UnitTests-Feature-Task1-SubTask1-MutexServiceTests-CountPrimes_ThreadCount_MatchesActuallySpawnedWorkers'></a>
### CountPrimes_ThreadCount_MatchesActuallySpawnedWorkers() `method`

##### Summary

Проверяет, что фактическое число созданных потоков-рабочих в результате может быть меньше запрошенного,
если диапазон короткий и часть потоков не получает ни одного числа.

##### Parameters

This method has no parameters.

<a name='M-Study-LabWork2-UnitTests-Feature-Task1-SubTask1-MutexServiceTests-CountPrimes_ThrowsArgumentException_WhenEndLessThanStart'></a>
### CountPrimes_ThrowsArgumentException_WhenEndLessThanStart() `method`

##### Summary

Проверяет, что [CountPrimes](#M-Study-LabWork2-Feature-Task1-SubTask1-MutexService-CountPrimes-System-Int32,System-Int32,System-Int32- 'Study.LabWork2.Feature.Task1.SubTask1.MutexService.CountPrimes(System.Int32,System.Int32,System.Int32)') выбрасывает [ArgumentException](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.ArgumentException 'System.ArgumentException'),
если конец диапазона меньше начала.

##### Parameters

This method has no parameters.

<a name='M-Study-LabWork2-UnitTests-Feature-Task1-SubTask1-MutexServiceTests-CountPrimes_ThrowsArgumentOutOfRange_WhenThreadCountNotPositive'></a>
### CountPrimes_ThrowsArgumentOutOfRange_WhenThreadCountNotPositive() `method`

##### Summary

Проверяет, что [CountPrimes](#M-Study-LabWork2-Feature-Task1-SubTask1-MutexService-CountPrimes-System-Int32,System-Int32,System-Int32- 'Study.LabWork2.Feature.Task1.SubTask1.MutexService.CountPrimes(System.Int32,System.Int32,System.Int32)') выбрасывает [ArgumentOutOfRangeException](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.ArgumentOutOfRangeException 'System.ArgumentOutOfRangeException'),
если количество потоков неположительно.

##### Parameters

This method has no parameters.

<a name='M-Study-LabWork2-UnitTests-Feature-Task1-SubTask1-MutexServiceTests-CountPrimes_WithMultipleThreads_HasUniqueOrderedPrimes'></a>
### CountPrimes_WithMultipleThreads_HasUniqueOrderedPrimes() `method`

##### Summary

Проверяет, что при нескольких потоках результат остаётся консистентным (нет пропусков и дубликатов в списке).

##### Parameters

This method has no parameters.

<a name='M-Study-LabWork2-UnitTests-Feature-Task1-SubTask1-MutexServiceTests-GetVersionName_ReturnsExpected'></a>
### GetVersionName_ReturnsExpected() `method`

##### Summary

Проверяет, что [GetVersionName](#M-Study-LabWork2-Feature-Task1-SubTask1-MutexService-GetVersionName 'Study.LabWork2.Feature.Task1.SubTask1.MutexService.GetVersionName') возвращает ожидаемое имя версии.

##### Parameters

This method has no parameters.

<a name='T-Study-LabWork2-UnitTests-Feature-Task1-SubTask1-SemaphoreServiceTests'></a>
## SemaphoreServiceTests `type`

##### Namespace

Study.LabWork2.UnitTests.Feature.Task1.SubTask1

##### Summary

Тесты для [SemaphoreService](#T-Study-LabWork2-Feature-Task1-SubTask1-SemaphoreService 'Study.LabWork2.Feature.Task1.SubTask1.SemaphoreService') — подсчёт простых чисел с синхронизацией через Semaphore.

<a name='M-Study-LabWork2-UnitTests-Feature-Task1-SubTask1-SemaphoreServiceTests-CountPrimes_CountsPrimesCorrectly_OnSmallRange'></a>
### CountPrimes_CountsPrimesCorrectly_OnSmallRange() `method`

##### Summary

Проверяет корректность подсчёта простых чисел на небольшом диапазоне и заполнение полей результата.

##### Parameters

This method has no parameters.

<a name='M-Study-LabWork2-UnitTests-Feature-Task1-SubTask1-SemaphoreServiceTests-CountPrimes_DoesNotThrow_OnValidParameters'></a>
### CountPrimes_DoesNotThrow_OnValidParameters() `method`

##### Summary

Проверяет, что вызов [CountPrimes](#M-Study-LabWork2-Feature-Task1-SubTask1-SemaphoreService-CountPrimes-System-Int32,System-Int32,System-Int32- 'Study.LabWork2.Feature.Task1.SubTask1.SemaphoreService.CountPrimes(System.Int32,System.Int32,System.Int32)') при корректных параметрах завершается без исключений.

##### Parameters

This method has no parameters.

<a name='M-Study-LabWork2-UnitTests-Feature-Task1-SubTask1-SemaphoreServiceTests-CountPrimes_FoundPrimes_AreOrderedAscending'></a>
### CountPrimes_FoundPrimes_AreOrderedAscending() `method`

##### Summary

Проверяет, что найденные простые числа в результате упорядочены по возрастанию.

##### Parameters

This method has no parameters.

<a name='M-Study-LabWork2-UnitTests-Feature-Task1-SubTask1-SemaphoreServiceTests-CountPrimes_IsIdempotent_OnRepeatedCalls'></a>
### CountPrimes_IsIdempotent_OnRepeatedCalls() `method`

##### Summary

Проверяет, что повторный вызов [CountPrimes](#M-Study-LabWork2-Feature-Task1-SubTask1-SemaphoreService-CountPrimes-System-Int32,System-Int32,System-Int32- 'Study.LabWork2.Feature.Task1.SubTask1.SemaphoreService.CountPrimes(System.Int32,System.Int32,System.Int32)') даёт тот же набор простых для тех же параметров.

##### Parameters

This method has no parameters.

<a name='M-Study-LabWork2-UnitTests-Feature-Task1-SubTask1-SemaphoreServiceTests-CountPrimes_LargeRange_MatchesKnownPrimeTotal'></a>
### CountPrimes_LargeRange_MatchesKnownPrimeTotal() `method`

##### Summary

Проверяет соответствие подсчёта известному значению для диапазона 2–10 000 (1229 простых).

##### Parameters

This method has no parameters.

<a name='M-Study-LabWork2-UnitTests-Feature-Task1-SubTask1-SemaphoreServiceTests-CountPrimes_PrimeCount_EqualsFoundPrimesListCount'></a>
### CountPrimes_PrimeCount_EqualsFoundPrimesListCount() `method`

##### Summary

Проверяет, что [PrimeCount](#P-Study-LabWork2-Abstractions-Feature-Task1-SubTask1-DtoModels-PrimeCountResultDto-PrimeCount 'Study.LabWork2.Abstractions.Feature.Task1.SubTask1.DtoModels.PrimeCountResultDto.PrimeCount') совпадает с количеством элементов в
[FoundPrimes](#P-Study-LabWork2-Abstractions-Feature-Task1-SubTask1-DtoModels-PrimeCountResultDto-FoundPrimes 'Study.LabWork2.Abstractions.Feature.Task1.SubTask1.DtoModels.PrimeCountResultDto.FoundPrimes').

##### Parameters

This method has no parameters.

<a name='M-Study-LabWork2-UnitTests-Feature-Task1-SubTask1-SemaphoreServiceTests-CountPrimes_ThreadCount_MatchesActuallySpawnedWorkers'></a>
### CountPrimes_ThreadCount_MatchesActuallySpawnedWorkers() `method`

##### Summary

Проверяет, что фактическое число созданных потоков-рабочих в результате может быть меньше запрошенного,
если диапазон короткий и часть потоков не получает ни одного числа.

##### Parameters

This method has no parameters.

<a name='M-Study-LabWork2-UnitTests-Feature-Task1-SubTask1-SemaphoreServiceTests-CountPrimes_ThrowsArgumentException_WhenEndLessThanStart'></a>
### CountPrimes_ThrowsArgumentException_WhenEndLessThanStart() `method`

##### Summary

Проверяет, что [CountPrimes](#M-Study-LabWork2-Feature-Task1-SubTask1-SemaphoreService-CountPrimes-System-Int32,System-Int32,System-Int32- 'Study.LabWork2.Feature.Task1.SubTask1.SemaphoreService.CountPrimes(System.Int32,System.Int32,System.Int32)') выбрасывает [ArgumentException](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.ArgumentException 'System.ArgumentException'),
если конец диапазона меньше начала.

##### Parameters

This method has no parameters.

<a name='M-Study-LabWork2-UnitTests-Feature-Task1-SubTask1-SemaphoreServiceTests-CountPrimes_ThrowsArgumentOutOfRange_WhenThreadCountNotPositive'></a>
### CountPrimes_ThrowsArgumentOutOfRange_WhenThreadCountNotPositive() `method`

##### Summary

Проверяет, что [CountPrimes](#M-Study-LabWork2-Feature-Task1-SubTask1-SemaphoreService-CountPrimes-System-Int32,System-Int32,System-Int32- 'Study.LabWork2.Feature.Task1.SubTask1.SemaphoreService.CountPrimes(System.Int32,System.Int32,System.Int32)') выбрасывает [ArgumentOutOfRangeException](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.ArgumentOutOfRangeException 'System.ArgumentOutOfRangeException'),
если количество потоков неположительно.

##### Parameters

This method has no parameters.

<a name='M-Study-LabWork2-UnitTests-Feature-Task1-SubTask1-SemaphoreServiceTests-CountPrimes_WithMultipleThreads_HasUniqueOrderedPrimes'></a>
### CountPrimes_WithMultipleThreads_HasUniqueOrderedPrimes() `method`

##### Summary

Проверяет, что при нескольких потоках результат остаётся консистентным (нет пропусков и дубликатов в списке).

##### Parameters

This method has no parameters.

<a name='M-Study-LabWork2-UnitTests-Feature-Task1-SubTask1-SemaphoreServiceTests-GetVersionName_ReturnsExpected'></a>
### GetVersionName_ReturnsExpected() `method`

##### Summary

Проверяет, что [GetVersionName](#M-Study-LabWork2-Feature-Task1-SubTask1-SemaphoreService-GetVersionName 'Study.LabWork2.Feature.Task1.SubTask1.SemaphoreService.GetVersionName') возвращает ожидаемое имя версии.

##### Parameters

This method has no parameters.
