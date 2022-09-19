**Задача:**

_**Условие задачи:**_

Написать программу, которая из имеющегося массива строк формирует новый массив из строк, длина которых меньше или равна трём символам. Первоначальный массив можно ввести с клавиатуры, либо задать на старте выполнения алгоритма. При решении не рекомендуется пользоваться коллекциями, лучше обойтись исключительно массивами.

_Примеры:_

["hello", "2", "world", ":-)"] -> ["2", ":-)"]

["1234", "1567", "-2", "computer science"] -> ["-2"]

["Russia", "Denmark", "Kazan"] -> []

**_Описание решения задачи_**

При решении задачи используем методы. Алгоритм решения задачи находится ниже по тексту:
1.  Вводим цифрами количество строк исходного массива (n).
2.  Если введена не цифра - возвращаемся в начало ввода.
3.  Объявляем 2 массива c количеством строк (n).
4. Вводим строки с клавиатуры и печатаем в консоль полученный массив строк.
5. Производим вычисление длин строк, введенных в первый массив и собираем строки с длиной не более 3-х символов во второй массив.
6. Выводим на печать массив №2. (если нашему условию не удовлетворяет ни одна строка.  тогда выводим массив [ ] ).

Блок-схема алгоритма находится в корне данного репозитория. Для удобства просмотра алгоритм размещён в двух файлах с разными расширениями.

Решение задачи находится в файле **Program.cs**. 
